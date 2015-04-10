using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Agency_DS_Project_vol._1
{
    class sport : car
    {
        public string tint_color { get; set; }
       // public string wheel_color { get; set; }
        public int engin_stage_kit { get; set; }
       // public string turbo { get; set; }


        //Display method
        public void display()
        {
            Console.WriteLine(" "+company+" "+manufactuer+"\n  ID : {0}\n  Company : {1}\n  Manufactur : {2}\n  Modle : {3}\n  Gear : {4}\n  Color : {5}\n  Top Speed : {6}\n  Price : {7}\n  Window Tint Color : {8}\n  Engine Stage-kit : {9}\n"
                , id, company, manufactuer, modle, gear, color, top_speed, price, tint_color, engin_stage_kit);
        }
    }
}
