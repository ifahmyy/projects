using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPUST
{
    public class Queue<T>
    {
        private class node
        {
            public T data;//Template value for 'data', General to any datatype
            public node next;//Duh...
            
            public node(T data, node next)//same old constructor 
            {
                this.data = data;
                this.next = next;
            }
            public node(T dat):this(dat,null) //simple, but useful overload
            {}
            public static node operator ++(node n)//cool,eh?
            {
                return n.next;
            }
        }

        node start;

        public Queue()//duh...
        {
            start = null;
        }
        public void inQ(T dat)//list.addend() ya fahmy
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
        }//So typical
        public T deQ()//dequeue, where you can see the greatness of the operator
        {
            return start++.data;
        }
        public T peak()//simply, dequeue without the operator
        {
            return start.data;
        }

    }
}
