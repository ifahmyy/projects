using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Car_Agency_DS_Project_vol._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating array listes using (System Collections)
            ArrayList cars = new ArrayList();
            ArrayList employees = new ArrayList();

            //Car Constractors
            car car = new car();
            sport sport = new sport();
            suv suv = new suv();
            urban urban = new urban();
            supercars super = new supercars();

            //Human Constractors
            human human=new human();
            driver driver=new driver();
            salesman sales_man=new salesman();

            //Creating Variables
            int modle = 0, speed = 0, price = 0, salary = 0, work_time = 0;
            string company = "defult", manu = "defult", gear = "defult", color = "defult", d_class = "defult", name = "defult";
            int count=0, counth = 0;


            //User interface Using (While) loop
            while (true)
            {
                Console.WriteLine("-------------------------------------------------------------------------------");
                Console.WriteLine("  Make a Choice :");
                Console.WriteLine("   1) Enter a new Car.");
                Console.WriteLine("   2) Enter a new Employee.");
                Console.WriteLine("   3) View Cars.");
                Console.WriteLine("   4) View Employees.");
                Console.WriteLine("   5) Exit.\n");

                int choise1 = int.Parse(Console.ReadLine());
                
                switch (choise1)
                {
                    //Case he choose (ENTER NEW CAR)
                    case 1:
                        Console.WriteLine("  Make a Choice :");
                        Console.WriteLine("   1) Sports.");
                        Console.WriteLine("   2) SUV.");
                        Console.WriteLine("   3) Urban.");
                        Console.WriteLine("   4) Supercar.\n");

                        int choise1_1 = int.Parse(Console.ReadLine());

                       
                        switch (choise1_1)
                        {
                            //case he choose SPORTS.
                            case 1:

                                car_entries(car, ref count, ref company,ref manu, ref modle, ref gear, ref speed, ref price, ref d_class, ref color);
                                
                                cars.Add(sport.id = count);
                                cars.Add(sport.company = company);
                                cars.Add(sport.manufactuer = manu);
                                cars.Add(sport.modle = modle);
                                cars.Add(sport.gear = gear);
                                cars.Add(sport.top_speed = speed);
                                cars.Add(sport.price = price);
                                cars.Add(sport.drive_class = d_class);
                                cars.Add(sport.color = color);
                                cars.Add(sport.date);

                                Console.WriteLine("  Enter Car Window Tint Color:");
                                string tint = Console.ReadLine();
                                cars.Add( sport.tint_color = tint);

                                Console.WriteLine("  Enter car Engine Stage-Kite:");
                                int kite = int.Parse(Console.ReadLine());
                                cars.Add(sport.engin_stage_kit = kite);

                                Console.WriteLine(" Done...");

                                sport.display();

                                break; //End of Sport case.


                            //case he choose SUV.
                            case 2:

                                car_entries(car, ref count, ref company,ref manu, ref modle, ref gear, ref speed, ref price, ref d_class, ref color);

                                cars.Add(suv.id = count);
                                cars.Add(suv.company = company);
                                cars.Add(suv.manufactuer = manu);
                                cars.Add(suv.modle = modle);
                                cars.Add(suv.gear = gear);
                                cars.Add(suv.top_speed = speed);
                                cars.Add(suv.price = price);
                                cars.Add(suv.drive_class = d_class);
                                cars.Add(suv.color = color);
                                cars.Add(suv.date);

                                Console.WriteLine("  Enter car waight:");
                                int waight = int.Parse(Console.ReadLine());
                                cars.Add(suv.waight = waight);

                                Console.WriteLine("  Enter car Power:");
                                int power = int.Parse(Console.ReadLine());
                                cars.Add(suv.power = power);

                                Console.WriteLine("  Enter number of seats:");
                                int seat = int.Parse(Console.ReadLine());
                                cars.Add(suv.seats = seat);

                                Console.WriteLine(" Done...");

                                break; //End of SUV case.

                            //case he choose Urban.
                            case 3:

                                car_entries(car, ref count, ref company,ref manu, ref modle, ref gear, ref speed, ref price, ref d_class, ref color);

                                cars.Add(urban.id = count);
                                cars.Add(urban.company = company);
                                cars.Add(urban.manufactuer = manu);
                                cars.Add(urban.modle = modle);
                                cars.Add(urban.gear = gear);
                                cars.Add(urban.top_speed = speed);
                                cars.Add(urban.price = price);
                                cars.Add(urban.drive_class = d_class);
                                cars.Add(urban.color = color);
                                cars.Add(urban.date);

                                Console.WriteLine("  Enter Salon size:");
                                int salon = int.Parse(Console.ReadLine());
                                cars.Add(urban.salon_size = salon);

                                Console.WriteLine("  Enter number of seats:");
                                int seatu = int.Parse(Console.ReadLine());
                                cars.Add(urban.salon_size = seatu);

                                Console.WriteLine(" Done...");

                                break; //End of Urban casr.

                            //case he choose Supercar.
                            case 4:

                                car_entries(car, ref count, ref company,ref manu, ref modle, ref gear, ref speed, ref price, ref d_class, ref color);

                                cars.Add(super.id = count);
                                cars.Add(super.company = company);
                                cars.Add(super.manufactuer = manu);
                                cars.Add(super.modle = modle);
                                cars.Add(super.gear = gear);
                                cars.Add(super.top_speed = speed);
                                cars.Add(super.price = price);
                                cars.Add(super.drive_class = d_class);
                                cars.Add(super.color = color);
                                cars.Add(super.date);

                                Console.WriteLine("  Enter car Grip:");
                                double grip = double.Parse(Console.ReadLine());
                                cars.Add(super.grip = grip);

                                Console.WriteLine("  Enter car Brakes power:");
                                Double brake = Double.Parse(Console.ReadLine());
                                cars.Add(super.brakes = brake);

                                Console.WriteLine(" Done...");

                                break; //End of Supercar case.

                            default:
                                Console.WriteLine(" Err in choice ");

                                break;
                        }

                        break; //end of choice 1 (ENTER A NEW CAR)

                    //case he choose (ENTER NEW EMPLOYEE)
                    case 2:

                        Console.WriteLine("  Make a choice :");
                        Console.WriteLine("   1) Sales Man.");
                        Console.WriteLine("   2) Driver.\n");

                        int choice2 = int.Parse(Console.ReadLine());

                        switch (choice2)
                        {
                            //Case he choose SALES MAN.
                            case 1:

                                human_entries(human, ref counth, ref name, ref salary, ref work_time);

                                employees.Add(sales_man.id = counth);
                                employees.Add(sales_man.name = name);
                                employees.Add(sales_man.salary = salary);
                                employees.Add(sales_man.work_time = work_time);

                                Console.WriteLine("  Enter years of Experince :");
                                int exp = int.Parse(Console.ReadLine());
                                employees.Add(sales_man.experince = exp);

                                Console.WriteLine(" Done...");

                                break; //End of sales man case

                            //case he choose Driver.
                            case 2:

                                human_entries(human, ref counth, ref name, ref salary, ref work_time);

                                employees.Add(driver.id = counth);
                                employees.Add(driver.name = name);
                                employees.Add(driver.salary = salary);
                                employees.Add(driver.work_time = work_time);

                                Console.WriteLine("  How many years for license expire :");
                                int licens = int.Parse(Console.ReadLine());
                                employees.Add(driver.licens_exp = licens);

                                Console.WriteLine(" Done...");

                                break; //end of Driver case


                            default:
                                Console.WriteLine(" Err in choise ");

                                break;
                        }
                        

                        break; //End of Choice 2 (ENTER A NEW EMPLOYEE)

                    //Case he choose (VIEW CARS)
                    case 3:

                        Console.WriteLine("  Choose a Brand to Display cars :");
                        Console.WriteLine("   1) Sports.");
                        Console.WriteLine("   2) SUV.");
                        Console.WriteLine("   3) Urban.");
                        Console.WriteLine("   4) Supercar.\n");

                        int choise3_1 = int.Parse(Console.ReadLine());

                        switch (choise3_1)
                        {
                            //case of SPORTS.
                            case 1:
                                display_cars(cars, sport, suv, urban, super, choise3_1);
                                break; //End of SPORTS.

                            //case of SUV.
                            case 2:
                                display_cars(cars, sport, suv, urban, super, choise3_1);
                                break;//End of SUV.

                            //case of Urban.
                            case 3:
                                display_cars(cars, sport, suv, urban, super, choise3_1);
                                break; //End of URBAN.

                            //case of SUPERCAR.
                            case 4:
                                display_cars(cars, sport, suv, urban, super, choise3_1);
                                break; //End of SUPERCAR.

                            default:
                                Console.WriteLine("  Err in choice...");
                                break;
                        }
                        break; //End of choice 3 (VIEW CARS)
                 
                    //case he Choose (VIEW EMPLOYEES)
                    case 4:

                        Console.WriteLine("  Choose a job to display employees :");
                        Console.WriteLine("   1) Sales Man.");
                        Console.WriteLine("   2) Driver.\n");

                        int choice4 = int.Parse(Console.ReadLine());

                        switch (choice4)
                        {
                            //case he choose sales man.
                            case 1:
                                display_employees(employees, sales_man, driver, choice4);
                                break; //End of sales man.

                            //case he Choose driver.
                            case 2:
                                display_employees(employees, sales_man, driver, choice4);
                                break; //end of driver.

                            default:
                                Console.WriteLine("  Err in choice....");
                                break;
                        }

                        break; //End of Choice 4 (VIEW EMPLOYEES)
                    
                    // case he choose (EXIT)
                    case 5:
                        return;
                       
                    default:
                        Console.WriteLine("  Err in Choice...");
                        break; //End of Choice (EXIT)
                }
            }
        }

        //car entries
        public static void car_entries(car car, ref int count, ref string companyy, ref string manuu, ref int modell, ref string gearr, ref int speedd, ref int pricee, ref string d_classs, ref string colorr)
        {
            count++;

            Console.WriteLine("  Enter car Company:");
            companyy = Console.ReadLine();

            Console.WriteLine("  Enter car Manufacuter (car name):");
            manuu = Console.ReadLine();

            Console.WriteLine("  Enter car Modle:");
            modell = int.Parse(Console.ReadLine());

            Console.WriteLine("  Enter Car Gear tybe (manual || Outomatic):");
            gearr = Console.ReadLine();

            Console.WriteLine("  Enter car Top Speed:");
            speedd = int.Parse(Console.ReadLine());

            Console.WriteLine("  Enter car price:");
            pricee = int.Parse(Console.ReadLine());

            Console.WriteLine("  Enter car Drive class (RWD | FWD | 4WD):");
            d_classs = Console.ReadLine();

            Console.WriteLine("  Enter car color:");
            colorr = Console.ReadLine();

        }

    
       //Human entries
        public static void human_entries(human human, ref int counth, ref string namee, ref int salaryy, ref int time)
        {
            counth++;

            Console.WriteLine("  Enter employee Name :");
            namee = Console.ReadLine();

            Console.WriteLine("  Enter Employee Salary :");
            salaryy = int.Parse(Console.ReadLine());

            Console.WriteLine("  Enter Employee Work time (Hours) :");
            time = int.Parse(Console.ReadLine());

        }


        //Display cars
        public static void display_cars(ArrayList cars, sport sport, suv suv, urban urban, supercars super, int choice)
        {
            if (choice == 1)
            {
                for (int i = 0; i < cars.Count; i++)
                {
                    sport.display();
                    return;
                }
            }

            else if(choice == 2)
            {
                for (int i = 0; i < cars.Count; i++)
                {
                    suv.display();
                    return;
                }
            }

            else if (choice == 3)
            {
                for (int i = 0; i < cars.Count; i++)
                {
                    urban.display();
                    return;
                }
            }

            else if (choice == 4)
            {
                for (int i = 0; i < cars.Count; i++)
                {
                    super.display();
                    return;
                }
            }
        }


        //Display Employees
        public static void display_employees(ArrayList employees, salesman salesman, driver driver, int choice)
        {
            if (choice == 1)
            {
                for (int i = 0; i < employees.Count; i++)
                {
                    salesman.display();
                    return;
                }
            }

            else if (choice == 2)
            {
                for (int i = 0; i < employees.Count; i++)
                {
                    driver.display();
                    return;
                }
            }
        }
    }
}
