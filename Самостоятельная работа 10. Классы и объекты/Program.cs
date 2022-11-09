using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Самостоятельная_работа_10.Классы_и_объекты
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение угла: градусы, минуты, секунды");
            int gradus_ = Convert.ToInt32(Console.ReadLine());
            int min_ = Convert.ToInt32(Console.ReadLine());
            int sec_ = Convert.ToInt32(Console.ReadLine());
            //Создаем экземпляр класса
            Radian radian = new Radian(gradus_, min_, sec_);
            //Вычисляем радиан при помощи метода из созданного класса
            double result_radian = radian.ToRadians();
            Console.WriteLine("Радиан угла равн {0:f3}",result_radian);
            Console.ReadKey();
        }
    }
}
