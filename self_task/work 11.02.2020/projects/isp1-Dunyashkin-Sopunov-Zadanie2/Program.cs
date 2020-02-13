using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isp1_Dunyashkin_Sopunov_Zadanie2
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector3D myVector = new Vector3D(35.50, 87.90, 35.10);
            Vector3D otherVector = new Vector3D(50.50, 32.35, 12.70);

            Console.WriteLine("Вывод изначального вектора: " + myVector);

            Console.WriteLine("Длина вектора: " + myVector.Length());

            Console.WriteLine("Cкалярное произведение: " + myVector.ScalarProduct(otherVector));

            Console.WriteLine("Векторное произведение: " + myVector.VectorProduct(otherVector));

            Console.ReadKey();
        }
    }
}
