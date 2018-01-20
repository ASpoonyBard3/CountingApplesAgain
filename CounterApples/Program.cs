using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterApples
{
    class Program
    {
        static void Main(string[] args)
        {


            List<Shoe> shoeBox = new List<Shoe>
            {
                new Shoe()
                {
                    style = Style.sneakers,
                    Colour = "blue/white"
                },
                new Shoe()
                {
                    style = Style.Loafer,
                    Colour = "Brown"
                }
            };

            List<Box> contentsOfBox = new List<Box>();

            contentsOfBox.Add(new Box()
            {
                Box.width = 1.3,
                Box.height = 4.5,
                Box.depth = 7.4,
            });


            List<Cart> FullCart = new List<Cart>();
            FullCart.Add(new Cart()
            {
                
            });
            foreach()
            {}
        }
    }
}
