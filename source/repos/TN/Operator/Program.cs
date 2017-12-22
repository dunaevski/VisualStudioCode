using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Operator
{
    internal class ThreeD
    {   
        private int _x, _y, _z;

        public ThreeD(int x = 0, int y = 0, int z = 0)
        {
            this._x = x;
            this._y = y;
            this._z = z;
        }
    
        public static ThreeD operator +(ThreeD obj1, ThreeD obj2)
        {
            var arr = new ThreeD
            {
                _x = obj1._x + obj2._x,
                _y = obj1._y + obj2._y,
                _z = obj1._z + obj2._z
            };
            return arr;
        }

        public static ThreeD operator -(ThreeD obj1, ThreeD obj2)
        {
            var arr = new ThreeD
            {
                _x = obj1._x - obj2._x,
                _y = obj1._y - obj2._y,
                _z = obj1._z - obj2._z
            };
            return arr;
        }

        public static ThreeD operator ++(ThreeD obj1)
        {
            obj1._x++;
            obj1._y++;
            obj1._z++;
            return obj1;
        }

        public static ThreeD operator --(ThreeD obj1)
        {
            obj1._x--;
            obj1._y--;
            obj1._z--;
            return obj1;
        }

        public void Show()
        {
            Console.WriteLine("Координаты точки: " +
                             _x + " " + _y + " " + _z);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            var point1 = new ThreeD(1, 12, -4);
            point1.Show();
            var point2 = new ThreeD(0, -3, 18);
            point2.Show();
            var point3 = point1 + point2;
            point3.Show();
            point3 = point1 - point2;
            point3.Show();
            point3++;
            point3.Show();
            point3--;
            point3.Show();
            var point4 = new ThreeD();
            point4.Show();

            Console.ReadLine();
        }
    }
}
