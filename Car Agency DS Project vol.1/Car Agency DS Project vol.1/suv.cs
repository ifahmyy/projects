using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Agency_DS_Project_vol._1
{
    class suv : car
    {
        public int waight { get; set; }
        public int power { get; set; }
        public int seats { get; set; }

        //Display method
        public void display()
        {
            Console.WriteLine(" " + company + " " + manufactuer + " ID : {0}\n Company : {1}\n Manufactur : {2}\n Modle : {3}\n Gear : {4}\n Color : {5}\n Top Speed : {6}\n Price : {7}\n Car waight : {8}\n Power : {9}\n Seats : {10}\n"
                , id, company, manufactuer, gear, color, top_speed, price, waight, power, seats);
        }
    }

    
}
