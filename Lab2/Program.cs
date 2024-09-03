using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab2lib;

namespace Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Phone[] arrPhones;
            Console.Write("Введiть кiлькiсть телефонiв: ");
            int cntPhones = int.Parse(Console.ReadLine());
            arrPhones = new Phone[cntPhones];
            for (int i = 0; i < cntPhones; i++)
            {

                Console.Write("Введiть фiрму телефона: ");
                string sName = Console.ReadLine();

                Console.Write("Введiть назву моделi: ");
                string sModel = Console.ReadLine();

                Console.Write("Введiть цiну телефона в доларах: ");
                string sCost = Console.ReadLine();

                Console.Write("Введiть рiк виходу телефону: ");
                string sReleaseYear = Console.ReadLine();

                Console.Write("Введiть рiк покупки телефону: ");
                int sYearOfPurchase = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введіть ємність акамулятору (mA/h): ");
                string sBatteryCapacity = Console.ReadLine();

                Console.Write("Введiть назву процесора: ");
                string sProcessorName = Console.ReadLine();

                Console.Write("Введiть кiлькiсть ядер в процесорi: ");
                string sAmountOfCores = Console.ReadLine();

                Console.Write("Введiть кiлькiсть пам'ятi(Гб): ");
                string sAmountOfMemory = Console.ReadLine();

                Console.Write("Введiть кiлькiсть оперативноi пам'ятi(Гб): ");
                string sAmountOfRAM = Console.ReadLine();

                Console.Write("Введiть довжину дiагоналi екрану телефона(дюймiв): ");
                string sDiagonal = Console.ReadLine();

                Console.Write("Чи є у телефона 3 камери? (у-так, n-нi): ");
                ConsoleKeyInfo keyHas3Cameras = Console.ReadKey();
                Console.WriteLine();

                Console.Write("Чи є у телефона бездротова зарядка? (у-так, n-нi): ");
                ConsoleKeyInfo keyHasWirelessCharging = Console.ReadKey();
                Console.WriteLine("\n----------------------------------------------------------------------------");
                Console.WriteLine();

                Phone YourPhone = new Phone();
                YourPhone.Name = sName;
                YourPhone.Model = sModel;
                YourPhone.Cost = sCost;
                YourPhone.ReleaseYear = sReleaseYear;
                YourPhone.YearOfPurchase = sYearOfPurchase;
                YourPhone.AmountOfCores = sAmountOfCores;
                YourPhone.BatteryCapacity = (sBatteryCapacity);
                YourPhone.ProcessorName = (sProcessorName);
                YourPhone.AmountOfMemory = (sAmountOfMemory);
                YourPhone.AmountOfRAM = (sAmountOfRAM);
                YourPhone.Diagonal = (sDiagonal);
                YourPhone.Has3Cameras = keyHas3Cameras.Key == ConsoleKey.Y ? true : false;
                YourPhone.HasWirelessCharging = keyHasWirelessCharging.Key == ConsoleKey.Y ? true : false;
                double GaranteEndingYear = YourPhone.getGaranteEndingYear();
                arrPhones[i] = YourPhone;
            }

                foreach (Phone t in arrPhones)
                {
                    Console.WriteLine();
                    Console.WriteLine("Данi про об'ект: ");
                    Console.WriteLine("----------------------------------------------------------------------------");
                    Console.WriteLine("Фiрма: " + t.Name);
                    Console.WriteLine("Модель: " + t.Model);
                    Console.WriteLine($"Цiна:  + {t.Model} доларів");
                    Console.WriteLine("Рiк випуску: " + t.ReleaseYear);
                    Console.WriteLine("Рiк покупки: " + t.YearOfPurchase);
                    Console.WriteLine("Процессор: " + t.ProcessorName);
                    Console.WriteLine("Кiлькiсть ядер: " + t.AmountOfCores);
                    Console.WriteLine($"Ємнiсть акамулятора:  {t.BatteryCapacity}мA/г");
                    Console.WriteLine($"Кiлькiсть пам'ятi: " + t.AmountOfMemory);
                    Console.WriteLine($"Кiлькiсть оперативноi пам'ятi: {t.AmountOfRAM}Гб ");
                    Console.WriteLine($"Дiагональ екрану: {t.Diagonal} дюймiв");
                    Console.WriteLine(t.Has3Cameras ?
                    "Має три або бiльше камер " : "Має меньше трьох камер");
                    Console.WriteLine(t.HasWirelessCharging ?
                    "Телефон має бездротову зарядку" : "Не має бездротовоi зарядки");
                    if (t.GaranteEndingYear >= 2023) Console.WriteLine
                            ($"Гарантiя закiнчується в {t.GaranteEndingYear} роцi ");
                    else Console.WriteLine($"Гарантiя закiнчилась в {t.GaranteEndingYear} роцi ");
                }
            Console.WriteLine("\n \n Виконав: Лiвак Саша 2IСТ-23б");
            Console.ReadKey();
        }
    }
}
