using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Agency_DS_Project_vol._1
{
    class urban : car
    {
        public int salon_size { get; set; }
        public int seat_num { get; set; }
        

        //Display method
        public void display()
        {
            Console.WriteLine(" " + company + " " + manufactuer + " ID : {0}\n Company : {1}\n Manufactur : {2}\n Modle : {3}\n Gear : {4}\n Color : {5}\n Top Speed : {6}\n Price : {7}\n Salon Size : {8}\n Seats number : {9}\n"
                , id, company, manufactuer, gear, color, top_speed, price, salon_size, seat_num);
        }
    }
}
