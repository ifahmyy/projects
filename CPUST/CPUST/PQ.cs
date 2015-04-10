using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPUST
{
    public class rPriorityQueue<T>
    {
        private class node
        {
            public T data; //Template, for general use 
            public node next;//no explanation needed, fahmy
            
            public node(T data, node next)
            {
                this.data = data;
                this.next = next;
            }
            public node(T dat):this (dat,null)//we love overloading everything (el4a3b el masry)
            {}
            public static node operator ++(node n)
            {
                return n.next;
            }
        }

        node start;

        public rPriorityQueue()//constructor, msh 7war
        {
            start = null;
        }
        public void inQ(T dat)//adding element in place, increasing order
        {
            if (start == null)//that means that the RPQ is empty
            {
                start = new node(dat);
                return;
            }
            if (Comparer<T>.Default.Compare(start.data, dat) > 0)//the new element should be added to beginning of the queue 
            {
                start = new node(dat, start);
                return;
            }
            //Default Case
            //no need for an else, actually
            node q = start;
            while (q.next != null && Comparer<T>.Default.Compare(q.next.data, dat) < 0)
                q++;
            q.next = new node(dat, q.next);
        }
        // Comparer<T> IS SUPER COOL
        public T deQ()
        {
            return start++.data;
        }
        public T peak()
        {
            return start.data;
        }
        //TESTING METHODS
        public void Display(string begin, string saparator)
        {
            node q = start;
            Console.Write(begin);
            while (q != null)
            {
                Console.Write(q.data);
                Console.Write(saparator);
                q++;
            }
        }
        public void Display()
        {
            node q = start;
            while (q != null)
            {
                Console.WriteLine(q.data);
                q = q.next;
            }
        }

    }
}
