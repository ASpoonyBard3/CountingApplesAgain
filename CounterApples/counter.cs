using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterApples
{
    public class Counter : IEnumerable
    {

            // Must implement GetEnumerator, which returns a new StreamReaderEnumerator.

        IEnumerator<CounterApples.Cart> IEnumerable<CounterApples.Cart>.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        // Must also implement IEnumerable.GetEnumerator, but implement as a private method.
        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
