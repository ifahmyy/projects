using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPUST
{
    class RR
    {
        private class node
        {
            public PProcess data;//Template value for 'data', General to any datatype
            public node next;//Duh...

            public node(PProcess data, node next)//same old constructor 
            {
                this.data = data;
                this.next = next;
            }
            public node(PProcess dat)
                : this(dat, null) //simple, but useful overload
            { }
            public static node operator ++(node n)//cool,eh?
            {
                return n.next;
            }
        }
        public int time, SumWT, SumTAT,TimeQuantam;
        node start;
        public PProcess[] ProcessArray;
        public bool[] nTaken;
        public int WT()
        {
            int n = ProcessArray.Length;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {

                sum += ProcessArray[i].WaitingTime; 
            }
            return sum;

        }
        public int TAT()
        {
            int n = ProcessArray.Length;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {

                sum += ProcessArray[i].TurnaroundTime;
            }
            return sum;

        }
        public void inQ(PProcess dat)//list.addend() ya fahmy
        {
            if (start == null)
            {
                start = new node(dat);
                return;
            }
            node q = start;
            while (q.next != null)
                q++;
            q.next = new node(dat);
        }
        public void deQ()//dequeue
        {
            if (time < start.data.ArrivalTime)
            {
                time = start.data.ArrivalTime;
            }
            time = start.data.Execute(time,TimeQuantam);
            Console.WriteLine(start.data.ProcessNumber + " " + start.data.RemainingBurstTime);
            retriev();
            if (start.data.RemainingBurstTime > 0)
                inQ(start.data);
            start++;
            


            if (start == null && howmany() > 0)
            {
                solvethesituation();
                retriev();
            }
        }
        int howmany()
        {
            int n = ProcessArray.Length, h = 0;
            for (int i = 0; i < n; i++)
            {
                if (nTaken[i])
                {
                    h++;
                }
            }
            return h;
        }
        private void solvethesituation()
        {
            int n = ProcessArray.Length;
            for (int i = 0; i < n; i++)
            {
                if (ProcessArray[i].ArrivalTime <= time && nTaken[i])
                {
                    time = ProcessArray[i].ArrivalTime;
                    return;
                }
            }
        }
        private void retriev()
        {
            int n = ProcessArray.Length;
            for (int i = 0; i < n; i++)
            {
                if (ProcessArray[i].ArrivalTime <= time && nTaken[i])
                {
                    inQ(ProcessArray[i]);
                    nTaken[i] = false;
                }
            }
        }
        /*public T peak()
        {
            return start.data;
        }*/
        public void deQall()
        {
            time = ProcessArray[0].ArrivalTime;
            retriev();
            while (start != null)
                deQ();
        }

    }
}
