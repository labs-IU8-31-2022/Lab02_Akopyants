using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Vehicle
    {
        public Vehicle(double _Prise, double _Speed, double _data)
        {
            Prise = _Prise;
            Speed = _Speed;
            data = _data;
        }
        public virtual void get_all_info() { Console.WriteLine($"Prise = {Prise} Speed = {Speed} Data = {data}\n"); }

        private double Prise;
        private double Speed;
        private double data;

    }
}
