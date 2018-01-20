using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterApples
{
    public class Cart<T>

    {
        Colour color;
        Dimension dimension;
        Health health;
        int count = 1;

        public class Dimension
        {
            double width;
            double height;
            double depth;
        }

        public class Colour
        {
            string Red;
            string Yellow;
            string Green;
        }

        private enum Health
        {
            Good,
            Ok,
            Bad,
            Rotten,
        }

        IEnumerator<T> Enumerator
        {
            get
            {

            }
        }
    }
}