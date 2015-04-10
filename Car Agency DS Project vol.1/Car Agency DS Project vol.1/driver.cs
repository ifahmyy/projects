using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Agency_DS_Project_vol._1
{
    class driver : human
    {
        public int licens_exp { get; set; }


        //display method
        public void display()
        {
            Console.WriteLine(" " + name + "  ID : {0}\n  Name : {1}\n  Work time : {2}\n  Licenes Expire in : {3} Years\n"
                , id, name, work_time, licens_exp);
        }
    }
}
