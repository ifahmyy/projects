using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Agency_DS_Project_vol._1
{
    class car
    {
        // int ID;
        public int id { get; set; }
        public string company { get; set; }
        public string manufactuer { get; set; }
        public int modle { get; set; }           //year
        public string gear { get; set; }         //Manual or outmatic
        public string drive_class { get; set; }  //FWD RWD 4WD
        public string color { get; set; }
        public int top_speed { get; set; }
        public int price { get; set; }
        public DateTime date = DateTime.Now;

        //defult constractor
        public car()
        {
        }
    }
}
