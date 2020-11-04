using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefDateTimeAndTimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            #region days of birth
            //DateTime bDayHanne = new DateTime(2020, 10, 01);
            //DateTime bDayVic = new DateTime(2019, 04, 16);
            //DateTime bDayHilde = new DateTime(1987, 10, 17);
            //DateTime bDayYannick = new DateTime(1989, 10, 23);
            #endregion

            string[] names= new string[5];
            names[0] = "Hanne";
            names[1] = "Vic";
            names[2] = "Yannick";
            names[3] = "Hilde";
            names[4] = "Shana";

            DateTime[] bDay = new DateTime[5];
            bDay[0] = new DateTime(2020, 10, 01);
            bDay[1] = new DateTime(2019, 04, 16);
            bDay[2] = new DateTime(1989, 10, 23);
            bDay[3] = new DateTime(1987, 10, 17);
            bDay[4] = new DateTime(1991, 07, 28);

            Console.WriteLine(string.Join(", ", names));
            Console.WriteLine("Geef één van bovenstaand namen in om de verjaardagen te vergelijken: ");
            string compareName = Console.ReadLine().ToUpper();

            switch (compareName)
            {
                case "HANNE":
                    Console.WriteLine(bDay[0].ToShortDateString());
                    for (int d = 1; d < bDay.Length; d++)
                    {
                        DateTime day = bDay[d];
                        for (int n = 0; n < names.Length; n++)
                        {
                            string name = names[n];
                            if (d == n)
                            {
                                TimeSpan dif = bDay[0] - bDay[d];
                                Console.WriteLine($"Hanne is {dif.Days} dagen jonger dan {names[n]}");
                            }
                        }
                    }
                    break;

                case "VIC":
                    Console.WriteLine(bDay[1].ToShortDateString());
                    for (int d = 0; d < bDay.Length; d++)
                    {
                        DateTime day = bDay[d];
                        for (int n = 0; n < names.Length; n++)
                        {
                            string name = names[n];
                            if (d == n && bDay[1] > bDay[d])
                            {
                                TimeSpan dif = bDay[1] - bDay[d];
                                Console.WriteLine($"Vic is {dif.Days} dagen jonger dan {names[n]}");
                            }
                            else if (d == n && bDay[1] < bDay[d])
                            {
                                TimeSpan dif = bDay[d] - bDay[1];
                                Console.WriteLine($"Vic is {dif.Days} dagen ouder dan {names[n]}");
                            }
                        }
                    }
                    break;

                case "YANNICK":
                    Console.WriteLine(bDay[2].ToShortDateString());
                    for (int d = 0; d < bDay.Length; d++)
                    {
                        DateTime day = bDay[d];
                        for (int n = 0; n < names.Length; n++)
                        {
                            string name = names[n];
                            if (d == n && bDay[2] > bDay[d])
                            {
                                TimeSpan dif = bDay[2] - bDay[d];
                                Console.WriteLine($"Yannick is {dif.Days} dagen jonger dan {names[n]}");
                            }
                            else if (d == n && bDay[2] < bDay[d])
                            {
                                TimeSpan dif = bDay[d] - bDay[2];
                                Console.WriteLine($"Yannick is {dif.Days} dagen ouder dan {names[n]}");
                            }
                        }
                    }
                    break;

                case "HILDE":
                    Console.WriteLine(bDay[3].ToShortDateString());
                    for (int d = 0; d < bDay.Length; d++)
                    {
                        DateTime day = bDay[d];
                        for (int n = 0; n < names.Length; n++)
                        {
                            string name = names[n];
                            if (d == n && bDay[3] > bDay[d])
                            {
                                TimeSpan dif = bDay[3] - bDay[d];
                                Console.WriteLine($"Yannick is {dif.Days} dagen jonger dan {names[n]}");
                            }
                            else if (d == n && bDay[3] < bDay[d])
                            {
                                TimeSpan dif = bDay[d] - bDay[3];
                                Console.WriteLine($"Yannick is {dif.Days} dagen ouder dan {names[n]}");
                            }
                        }
                    }
                    break;

                case "SHANA":
                    Console.WriteLine(bDay[4].ToShortDateString());
                    for (int d = 0; d < bDay.Length; d++)
                    {
                        DateTime day = bDay[d];
                        for (int n = 0; n < names.Length; n++)
                        {
                            string name = names[n];
                            if (d == n && bDay[4] > bDay[d])
                            {
                                TimeSpan dif = bDay[4] - bDay[d];
                                Console.WriteLine($"Yannick is {dif.Days} dagen jonger dan {names[n]}");
                            }
                            else if (d == n && bDay[4] < bDay[d])
                            {
                                TimeSpan dif = bDay[d] - bDay[4];
                                Console.WriteLine($"Yannick is {dif.Days} dagen ouder dan {names[n]}");
                            }
                        }
                    }
                    break;

                default:
                    Console.WriteLine("Something went wrong");
                    break;
            }
            Console.ReadLine();
        }
    }
}
