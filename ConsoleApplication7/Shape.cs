using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    public abstract class Shape
    {

        private double _lenght;
        private double _width;

        public abstract double Area { get; }
        //Kontrolerar att ett inhämtat värde är störe än noll och returnerar detta om det är större än noll annars kastas ett ArgumentException
        public double Length
        {
            get
            {
                return _lenght;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                _lenght = value;
            }
        }

        public abstract double Perimeter { get; }
        //Kontrolerar att ett inhämtat värde är störe än noll och returnerar detta om det är större än noll annars kastas ett ArgumentException
        
        public double Width
        {
            get
            {

                return _width;
            }

            set
            {

                if (value < 0)
                {

                    throw new ArgumentException();

                }
                _width = value;
            }
        }

        //Metod som för över värden från length och width till Lenght och Width
        protected Shape(double lenght, double width)
        {
            Length = lenght;
            Width = width;
        }
        //Metod som skriver ut måtten
        public override string ToString()
        {

            return String.Format("Längd:\t\t{0} \nBredd:\t\t{1} \nOmkretss:\t{2} \nArea:\t\t{3}", Math.Round(Length, 2), Math.Round(Width, 2), Math.Round(Perimeter, 1), Math.Round(Area, 1));

        }
    }
}
