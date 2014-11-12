using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    public class Ellipse : Shape
    {  public override double Area {
        //Räknar ut och returnerar  area 
            get {
                return  Math.PI * (Length/2) * (Width/2);
            }
        }
        public override double Perimeter {
            //Räknar ut och returnerar Omkrets
            get
            {
                return Math.PI * Math.Sqrt(2 * (Length/2) * (Length/2) + 2 * (Width/2) * (Width/2));
            }
        }
        //Basklassens konstruktor ser till att det nya objektets längd och bredd sätts.
        public Ellipse (double lenght, double width) : base(lenght , width) {

        }
    }
}
