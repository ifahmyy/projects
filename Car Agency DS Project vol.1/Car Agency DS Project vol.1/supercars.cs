using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Agency_DS_Project_vol._1
{
    class supercars : car
    {
        public double grip { get; set; }
        public Double brakes { get; set; }

        //Display Method
        public void display()
        {
            Console.WriteLine(" " + company + " " + manufactuer + " ID : {0}\n Company : {1}\n Manufactur : {2}\n Modle : {3}\n Gear : {4}\n Color : {5}\n Top Speed : {6}\n Price : {7}\n Grip : {8}\n Brakes : {9}\n"
                , id, company, manufactuer, gear, color, top_speed, price, grip, brakes);
        }
    }
}
