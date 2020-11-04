using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[5];
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

            ShowPeople(names);
            string compareName = Console.ReadLine().ToUpper();
            //int compareByNumber = int.Parse(Console.ReadLine());
            int placeInArray = 0;

            switch (compareName)
            {
                case "HANNE":
                    placeInArray = 0;
                    break;
                case "VIC":
                    placeInArray = 1;
                    break;
                case "YANNICK":
                    placeInArray = 2;
                    break;
                case "HILDE":
                    placeInArray = 3;
                    break;
                case "SHANA":
                    placeInArray = 4;
                    break;

                default:
                    throw new NotImplementedException();
            }

            #region compareByMenuNumber
            //switch (compareByNumber)
            //{
            //    case 1:
            //        placeInArray = 0;
            //        break;
            //    case 2:
            //        placeInArray = 1;
            //        break;
            //    case 3:
            //        placeInArray = 2;
            //        break;
            //    case 4:
            //        placeInArray = 3;
            //        break;
            //    case 5:
            //        placeInArray = 4;
            //        break;

            //    default:
            //        throw new NotImplementedException();
            //}
            #endregion

            BerekenDagenVerschil(placeInArray, compareName, names, bDay);           
            Console.ReadLine();

        }
        private static void BerekenDagenVerschil(int placeInArray, string compareName, string[] names, DateTime[] bday)
        {
            for (int n = 0; n < names.Length; n++)
            {
                if (names[placeInArray] != names[n] && bday[placeInArray] < bday[n])
                {
                    TimeSpan dif = bday[n] - bday[placeInArray];
                    Console.WriteLine($"{compareName} is {dif.Days} dagen ouder dan {names[n]}");
                }
                if (names[placeInArray] != names[n] && bday[placeInArray] > bday[n])
                {
                    TimeSpan dif1 = bday[placeInArray] - bday[n];
                    Console.WriteLine($"{compareName} is {dif1.Days} dagen jonger dan {names[n]}");
                }
            }
        }
        private static void ShowPeople(string [] names)
        {
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"{i+1}.\t{names[i]}");
            }
            Console.WriteLine("####################################################################");
            Console.Write("Geef één van bovenstaand namen in om de verjaardagen te vergelijken: ");
        }
    }
}


