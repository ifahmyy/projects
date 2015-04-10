using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Agency_DS_Project_vol._1
{
    class human
    {
        public int id { get; set; }
        public string name { get; set; }
        public int salary { get; set; }
        public int work_time { get; set; }
        public DateTime date { get; set; }


        //Yearly salary for each employee
        public void yearly_salary(int sal)
        {
            Double yearsal = sal * 12;
        }

        //Hourly salary for each employee
        public void hour_salary(int sal)
        {
            Double hoursal = sal / work_time;
        }
    }
}
