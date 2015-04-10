using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPUST
{
   public class NPProcess//Non-Preemitive Process- You cannot kill or pause this one 
    {
        public int ArrivalTime,BurstTime,ExecutionTime,WaitingTime,ProcessNumber,TurnaroundTime,CompletionTime;// Self-Explainatory, Seriously
        public NPProcess(int arriv,int burst,int number)
        {
            ArrivalTime = arriv;
            BurstTime = burst;
            ProcessNumber = number;
        }
        public NPProcess()
        {
            ArrivalTime = 0;
            BurstTime = 0;
        }

        public int Execute(int time)
        {

            ExecutionTime = time;
            CompletionTime = time + BurstTime;
            TurnaroundTime = CompletionTime - ArrivalTime;
            WaitingTime = TurnaroundTime - BurstTime;
            return time+BurstTime;
        }
        public PProcess MakePreemetive()
        {
            return new PProcess(ArrivalTime, BurstTime,ProcessNumber);
        }
        public int CompareAT(NPProcess a,NPProcess b)
        {
            return a.ArrivalTime - b.ArrivalTime;
        }
       

    }
    /*class compare : IComparer<NPProcess>//To be used in the queueing business
    {
        int IComparer<NPProcess>.Compare(NPProcess a, NPProcess b)
        {
            return a.BurstTime - b.BurstTime;
        }
    }*/
    public class PProcess : NPProcess
    {
        public int TotalExecutionTime, RemainingBurstTime,LastTime;

        public PProcess(int arriv, int burst, int number)
        {
            ArrivalTime = arriv;
            BurstTime = burst;
            RemainingBurstTime = burst;
            ProcessNumber = number;
        }
        public int Execute(int time,int Quanta )
        {
            //int newtime = time;
            ExecutionTime = time;
            if (RemainingBurstTime == BurstTime)
            {
                LastTime = ArrivalTime;
            }
            if (RemainingBurstTime <= Quanta)
            {
                Quanta = RemainingBurstTime;
                RemainingBurstTime = 0;
                CompletionTime = time + Quanta;
                TurnaroundTime = CompletionTime - ArrivalTime;
                WaitingTime += (time) - LastTime;
                return time + Quanta;
            }
            RemainingBurstTime -= Quanta;
            WaitingTime += (time - LastTime);
            LastTime = time + Quanta;
            return time + Quanta;
            
        }

    }
}
/*CompletionTime = time + BurstTime;
            TurnaroundTime = CompletionTime - ArrivalTime;
            WaitingTime = TurnaroundTime - BurstTime;
            return time + BurstTime;*/