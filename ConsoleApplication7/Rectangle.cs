using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
   public  class Rectangle : Shape
    {
        public override double Area {
            //Räknar ut och returnerar area 
            get {
                return Length * Width;
            }
        }
        //Räknar ut och returnerar Omkrets
        public override double Perimeter {
            get
            {
                return 2 * Length + 2 * Width;
            }
        }
        //Basklassens konstruktor ser till att det nya objektets längd och bredd sätts.
        public Rectangle (double lenght, double width) : base(lenght , width) {

        }
    }
}
