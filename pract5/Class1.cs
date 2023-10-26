using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace pract5
{
    internal class Class1
    {

        
    public static int meny(int max, int[] x, string[] z)
        {
            int pos = 1;
            
            while (true)
            {
                Console.SetCursorPosition(0, pos);
                Console.WriteLine(">");
                ConsoleKeyInfo key = Console.ReadKey();
                Console.SetCursorPosition(0, pos);
                Console.WriteLine(" ");
                if (key.Key == ConsoleKey.UpArrow && pos != 1)
                {
                    pos--;
                }
                if (key.Key == ConsoleKey.DownArrow && pos != max)
                {
                    pos++;
                } 
                if (key.Key == ConsoleKey.Enter)
                {
                    break;
                }
                if (key.Key == ConsoleKey.Escape)
                {
                    max = 7;
                    Class2.main(x, z);
                }
            }
            return pos;
        }

        

        public static void spis(int max, int pos, int[] x, string[] z)
        {
            Console.Clear();
           
            if (pos == 1)
            {
                Console.WriteLine(" Форма:");
                Console.WriteLine(" Круглая: 200");
                Console.WriteLine(" Квадратная: 250");
                max = 2;
                pos = meny(max, x, z);
                
                if (pos == 1)
                {
                    x[0] = 200;
                    z[0] = "Круглая";
                }
                if (pos == 2)
                {
                    x[0] = 250;
                    z[0] = "Квадратная";
                }
            }
            else if (pos == 2)
            {
                Console.WriteLine(" Размер");
                Console.WriteLine(" Маленький: 400");
                Console.WriteLine(" Средний: 500");
                Console.WriteLine(" Большой: 600");
                max = 3;
                pos = meny(max, x, z);
                if (pos == 1)
                {
                    x[1] = 400;
                    z[1] = "Маленький";
                }
                if (pos == 2)
                {
                    x[1] = 500;
                    z[1] = "Средний";
                }
                if (pos == 3)
                {
                    x[1] = 600;
                    z[1] = "Большой";
                }
            }
            else if (pos == 3)
            {
                Console.WriteLine(" Вкус:");
                Console.WriteLine(" Шоколад 100");
                Console.WriteLine(" Вишня 150");
                Console.WriteLine(" Клубника 150");
                max = 3;
                pos = meny(max, x, z);
                if (pos == 1)
                {
                    x[2] = 100;
                    z[2] = "Шоколад";
                }
                if (pos == 2)
                {
                    x[2] = 150;
                    z[2] = "Вишня";
                }
                if (pos == 3)
                {
                    x[2]  = 150;
                    z[2] = "Клубника";
                }
            }
            else if (pos == 4)
            {
                Console.WriteLine(" Количество коржей");
                Console.WriteLine(" один: 100 \n два: 200 \n три: 400");
                max = 3;
                pos = meny(max, x, z);
                if (pos == 1)
                {
                    x[3] = 100;
                    z[3] = "один";
                }
                if (pos == 2)
                {
                    x[3] = 0;
                    z[3] = "два";
                }
                if (pos == 3)
                {
                    x[3] = 0;
                    z[3] = "три";
                }

            }
            else if (pos == 5)
            {
                Console.WriteLine(" Хотите ли глазурь?");
                Console.WriteLine(" да: 100");
                Console.WriteLine(" нет");
                max = 2;
                pos = meny(max, x, z);
                if (pos == 1)
                {
                    x[4] = 100;
                    z[4] = "есть";
                }
                if (pos == 2)
                {
                    x[4] = 0;
                    z[4] = "нет";
                }
            }
            else if (pos == 6)
            {
                Console.WriteLine(" Декор:");
                Console.WriteLine(" Стандартный: 100");
                Console.WriteLine(" Особый: 200");
                Console.WriteLine(" Нет");
                max = 3;
                pos = meny(max, x, z);
                if (pos == 1)
                {
                    x[5] = 100;
                    z[5] = "Стандартный";
                }
                if (pos == 2)
                {
                    x[5] = 200;
                    z[5] = "Особый";
                }
                if (pos == 3)
                {
                    x[5]  = 0;
                    z[5] = "Нет";
                }
            }
            else if (pos == 7)
            {
                Console.WriteLine("итоговая цена:" + ((x[0] +x[2]+x[4]+x[5])+x[1]+x[3]) + " принять? \n да \n нет");
                Console.WriteLine("форма: " + z[0] + ", размер: " + z[1] + ", вкус: " + z[2] + ", количество коржей: " + z[3] + ", глазурь: " + z[4] + ", декор: " + z[5]);
                max = 2;
                pos = meny(max, x, z);
                string path = "D:\\История заказов.txt";
                if (pos == 1)
                {
                    File.Create(path);
                    var n = new DateOnly();
                    File.WriteAllText(path, "Заказ от: " + n + "\n  итоговая цена:" + ((x[0] + x[2] + x[4] + x[5]) + x[1] + x[3]) + "\n итоговый заказ: форма: " + z[0] + ", размер: " + z[1] + ", вкус: " + z[2] + ", количество коржей: " + z[3] + ", глазурь: " + z[4] + ", декор: " + z[5]);
                }
                if (pos == 2)
                {
                    Class2.main(x, z);
                }
            }
        }
    }
}
