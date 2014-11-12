using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    public enum ShapeType { Indefinite, Rectangle, Ellipse };
    class Program
    {
        static void Main(string[] args)
        {
            int button;
            do
            {
                ViewMenu();
                //Kollar så att användaren trycker på en "godkänd" knapp
                if (int.TryParse(Console.ReadLine(), out button) && button >= 0 && button <= 2)
                {
                    switch (button)
                    {//0:an avslutar
                        case 0:
                            return;
                        //Här skickar man till  ViewShapeDetail att den ska vissa detalejer på ett objekt som CreateShape skapar efter den valda shapetypen
                        case 1:
                            ViewShapeDetail(CreateShape(ShapeType.Ellipse));
                            break;

                        case 2:
                            ViewShapeDetail(CreateShape(ShapeType.Rectangle));
                            break;

                    }

                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\nFel menyvalet måste vara mellan 0-2 \n\n");

                }
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Tryck tangent för att fortsätta");
                Console.ResetColor();
                Console.ReadKey();
                Console.Clear();
            } while (true);

        }
        private static Shape CreateShape(ShapeType shapeType)
        {

            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" ========================================================");
            Console.WriteLine(" =                                                      =");
            Console.WriteLine(" ={0,25}                             =", shapeType);
            Console.WriteLine(" =                                                      =");
            Console.WriteLine(" ========================================================");
            Console.WriteLine();
            Console.ResetColor();
            //Två doubles som hämtar in längd och bredd via metoden ReadDoubleGreaterThanZero
            double l = ReadDoubleGreaterThanZero("Ange Längden: ");
            double w = ReadDoubleGreaterThanZero("Ange Bredden: ");
            //beroende på vilken shapetype som valts i menyn skappas ett objekt med dom ovan angedd måtten
            if (shapeType == ShapeType.Ellipse)
            {
                return new Ellipse(l, w);
            }
            return new Rectangle(l, w);
        }

        //Metod som kolla så att värdet är en double inom de angivna reglerna
        private static double ReadDoubleGreaterThanZero(string prompt)
        {
            double value;

            do
            {
                Console.Write(prompt);

                if (double.TryParse(Console.ReadLine(), out value) && value > 0d)
                {
                    return value;
                }
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("FEL! Ange ett flyttal som är större än 0");
                Console.ResetColor();
            } while (true);
        }

        //Metod som vissar menyn
        private static void ViewMenu()
        {
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" ========================================================");
            Console.WriteLine(" =                                                      =");
            Console.WriteLine(" =                 Geometriska figurer                  =");
            Console.WriteLine(" =                                                      =");
            Console.WriteLine(" ========================================================");
            Console.WriteLine();
            Console.ResetColor();
            Console.WriteLine(" 0. Avsluta. \n 1. Ellipse. \n 2. Rektangel \n ================================ \n Ange Menyval 0-2:");

        }
        //Metod som skirver ut måtten
        private static void ViewShapeDetail(Shape shape)
        {
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" ========================================================");
            Console.WriteLine(" =                 Detaljer                             =");
            Console.WriteLine(" ========================================================");
            Console.ResetColor();
            Console.WriteLine(shape.ToString());
            Console.WriteLine(" ========================================================\n");

        }
    }
}
