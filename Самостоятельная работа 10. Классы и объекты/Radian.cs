using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Самостоятельная_работа_10.Классы_и_объекты
{
    class Radian
    {//Назначаем поля
        int gradus;
        int min;
        int sec;
        //Назначаем свойства. Проверяем корректность введенных значений.
        public int Gradus
        {
            get
            {
                return gradus;
            }
            set
            {
                gradus = value % 360;
            }
        }
        public int Min
        { 
            get
            {
                return min;
            }
            set
            {
                Gradus += value / 60;
                min = value % 60;
            }
        }
        public int Sec
        { 
            get
            {
                return sec;
            }
            set
            {
                Min += value / 60;
                sec = value % 60;
            }
        }
        //Создаем конструктор. Присваиваем полям проверенные значения.
        public Radian(int gradus, int min, int sec)
        {
            this.Gradus = gradus;
            this.Min = min;
            this.Sec = sec;
        }
        //Создаем метод расчета радиана
        public double ToRadians()
        {
            return gradus * Math.PI / 180 + min * Math.PI / 10800 + sec * Math.PI / 648000;
        }
    }
}
