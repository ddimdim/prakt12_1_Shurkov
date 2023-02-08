using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    internal class Student
    {
        public string name;
        public int rost;
        public double ves = 53;

        public double SetEat(double eda)
        {
            if (eda <= 5)
                ves += (eda * 1000 - 1800) / 1000;
            if (eda > 5 && eda < 10)
            {
                rost = rost - 1;
                ves += ((eda * 1000 - 1600) / 1000) * 1.7;
            }
            if (eda > 10)
            {
                rost = rost - 2;
                ves += ((eda * 1000 - 1600) / 1000) * 1.5;
            }
            return ves;
        }
        public double GetEat()
        {
            return ves;
        }

    }
}

