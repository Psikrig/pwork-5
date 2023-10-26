using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract5
{
    internal class Class2
    {

        public static void main(int[] x, string[] z)
        {
            Console.Clear();
            Console.WriteLine("выберете свой торт: \n форма \n размер \n вкус \n количество коржей \n глазурь \n декор \n купить \nитоговая цена:" + (x[0] + x[2] + x[4] + x[5] + x[1] + x[3]));
            Console.WriteLine("форма: " + z[0] + ", размер: " + z[1] + ", вкус: " + z[2] + ", количество коржей: " + z[3] + ", глазурь: " + z[4] + ", декор: " + z[5]);
        }
    }
}
