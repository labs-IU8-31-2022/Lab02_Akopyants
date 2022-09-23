using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Plane : Vehicle
    {
        public Plane(double _Prise, double _Speed, double _data, int _passengers, double _height)
            :base( _Prise, _Speed, _data)
        {
            passengers = _passengers;
            height = _height;
        }
        public override void get_all_info()
        {
            base.get_all_info();
            Console.WriteLine($"passengers - {passengers} height - {height}\n");
        }

        private readonly int passengers;
        private readonly double height;
    }
}
