using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class car : Vehicle
    {
        public car(double _Prise, double _Speed, double _data)
            :base( _Prise,  _Speed,  _data)
        {

        }

        public override void get_all_info()
        {
            base.get_all_info();
        }
    }
}
