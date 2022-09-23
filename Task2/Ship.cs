using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Ship : Vehicle
    {

        public Ship(double _Prise, double _Speed, double _data, int _passengers, string _seaport) 
            : base(_Prise, _Speed, _data)
        {
            passengers = _passengers;
            seaport = _seaport;
        }

        public override void get_all_info()
        {
            base.get_all_info();
            Console.WriteLine($"passengers - {passengers} seaport - {seaport}\n");
        }

        private readonly int passengers;
        private readonly string seaport;
    }
}
