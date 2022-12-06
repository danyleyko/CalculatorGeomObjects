using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CalculatorGeomObjects
{
    //Output all functions in Main method
    public class OutputProgram
    {
        static void Main(string[] args)
        {
            double result;
            WelcomeMessage Welcome = new WelcomeMessage();
            Program prog = new Program();

            Welcome.WelcomeNotif();
            prog.PickedObject();
            prog.PickedOperation();
            prog.Arguments();


            result = prog.Calculation(prog.objectChoice, prog.userArguments);
            //Output 'Area/Volume' result
            if (prog.operationChoice == 1)
            {
                Console.WriteLine("\n\nResult of 'Area' is: " + result);
            }
            else
            {
                Console.WriteLine("\n\nResult of 'Value' is: " + result);
            }
        }
    }

    //Writing greetings for beauty :-)
    public class WelcomeMessage
    {
        public void WelcomeNotif()
        {
            Console.WriteLine("_________________________________________________\n");
            Console.WriteLine("Welcome, to the calculator of geometrical objects");
            Console.WriteLine("\tCreated by Danyleyko Kirill");
            Console.WriteLine("\tStart project in 01.12.2022");
            Console.WriteLine("\tEnd project in 06.12.2022");
            Console.WriteLine("_________________________________________________\n");
        }
    }

    //The user inserted value will be checked here and calculate
    public class Program 
    {
        public int objectChoice;
        public int operationChoice;
        public const double PI = 3.1415926535897931;
        public double[] userArguments = new double[3];

        //This method checks which object the user selected
        public void PickedObject() 
        {
            Console.WriteLine("Hey!\n");
            do
            {
                Console.WriteLine("_______________________________________________________________________________\n");

                Console.WriteLine("In front of you is a list of objects with which we will work further: ");
                Console.WriteLine("\r\n 2D objects:" +
                                  "\r\n \t1. Square." +
                                  "\r\n \t2. Circle." +
                                  "\r\n \t3. Rectangle." +
                                  "\r\n 3D objects:" +
                                  "\r\n \t4. Cuboid." +
                                  "\r\n \t5. Cylinder." +
                                  "\r\n \t6. Sphere.");
                Console.Write("Please choose one of the options of the object to continue working with it: ");

                //Output picked 'object' 
                switch (objectChoice = Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        Console.WriteLine($"\n\n\tYou picked - '{objectChoice}. Square'\n\n");
                        break;
                    case 2:
                        Console.WriteLine($"\n\n\tYou picked - '{objectChoice}. Circle'\n\n");
                        break;
                    case 3:
                        Console.WriteLine($"\n\n\tYou picked - '{objectChoice}. Rectangle'\n\n");
                        break;
                    case 4:
                        Console.WriteLine($"\n\n\tYou picked - '{objectChoice}. Cuboid'\n\n");
                        break;
                    case 5:
                        Console.WriteLine($"\n\n\tYou picked - '{objectChoice}. Cylinder'\n\n");
                        break;
                    case 6:
                        Console.WriteLine($"\n\n\tYou picked - '{objectChoice}. Sphere'\n\n");
                        break;
                    default:
                        break;
                }
                if (objectChoice > 6)
                {
                    Console.WriteLine("\n\n\tError: You write wrong number, rewrite please.\n\n");
                }
                Console.WriteLine("_______________________________________________________________________________\n");

            } while (objectChoice > 6);// do{  }while(); used for loop answers (true/false)
        }


        //This method checks which operation the user selected and also checks errors
        public void PickedOperation()
        {
            bool error_ = false;
            do
            {
                Console.WriteLine("_______________________________________________________________________________\n");
                Console.WriteLine("Now please choose which operation you want to take place:");
                Console.WriteLine("\r \t1. Area." +
                                  "\r\n \t2. Volume.");
                Console.Write("Please choose one of the options of the operation to continue working with it: ");


                //Output picked 'operation' 
                switch (operationChoice = Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        Console.WriteLine($"\n\n\tYou picked - '{operationChoice}. Area'\n");
                        break;
                    case 2:
                        Console.WriteLine($"\n\n\tYou picked - '{operationChoice}. Volume'\n");
                        break;
                    default:
                        Console.WriteLine("\n\n\tYou write wrong number, rewrite please.\n");
                        break;

                }

                //Makes an error when the user selects the wrong operation (it all depends on the object selected)
                if (objectChoice < 4 && operationChoice == 2 || objectChoice > 3 && operationChoice == 1 || operationChoice > 6)
                {
                    error_ = true;
                }
                else
                {
                    error_ = false;
                }

                //Output errors
                if (objectChoice < 4 && operationChoice == 2)
                {
                    Console.WriteLine("\n\n\tError: Sorry, you can't use 'Volume' when you have 2d objects\n\n");
                }
                else if (objectChoice > 3 && operationChoice == 1)
                {
                    Console.WriteLine("\n\n\tError: Sorry, you can't use 'Area' when you have 3d objects\n\n");

                }
                Console.WriteLine("_______________________________________________________________________________\n");

            } while (error_ == true); // do{  }while(); used for loop answers (true/false)

        }


        //This method checks how many arguments the user needs for each object
        public void Arguments() 
        {

            //Cirlce & Sphere
            if (objectChoice == 2 || objectChoice == 6) 
            {
                Console.WriteLine("\n\nYou must write 1 args: ");
                Console.Write("Radius - ");
                userArguments[0] = Convert.ToInt32(Console.ReadLine());
            }

            //Cuboid
            else if (objectChoice == 4) 
            {
                Console.WriteLine("\n\nYou must write 3 args:");
                Console.Write("a - ");
                userArguments[0] = Convert.ToInt32(Console.ReadLine());
                Console.Write("b - ");
                userArguments[1] = Convert.ToInt32(Console.ReadLine());
                Console.Write("c - ");
                userArguments[2] = Convert.ToInt32(Console.ReadLine());
            }

            //Cylinder
            else if (objectChoice == 5) 
            {
                Console.WriteLine("\n\nYou must write 2 args:");
                Console.Write("Radius - ");
                userArguments[0] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Height - ");
                userArguments[1] = Convert.ToInt32(Console.ReadLine());
            }

            //Square
            else if (objectChoice == 1) 
            {
                Console.WriteLine("\n\nYou must write 1 args: ");
                Console.Write("a - ");
                userArguments[0] = Convert.ToInt32(Console.ReadLine());
            }

            //Rectangle
            else
            {
                Console.WriteLine("\n\nYou must write 2 args: ");
                Console.Write("a - ");
                userArguments[0] = Convert.ToInt32(Console.ReadLine());
                Console.Write("b - ");
                userArguments[1] = Convert.ToInt32(Console.ReadLine());
            }
        }

        //This method calculates the 'area' or 'volume' of previously selected objects and return 'result'
        public double Calculation(int object_, double[] value)
        {
            double result;
            double a, b, c;
            a = value[0];
            b = value[1];
            c = value[2];

            switch (object_)
            {
                case 1:
                    result = a * a; //Area of Square (a^2)
                    return result;
                case 2:
                    result = PI * (a * a); //Area of Circle (Pi * r^2)
                    return result;
                case 3:
                    result = a * b; // Area of Rectangle (a * b)
                    return result;
                case 4:
                    result = a * b * c; //Volume of Cuboid (a * b * c)
                    return result;
                case 5:
                    result = PI * (a * a) * b; //Volume of Cylinder (Pi * r^2 * h)
                    return result;
                case 6:
                    result = (4 / 3) * PI * (a * a * a); // Volume of Sphere (4/3 * Pi * r^3)
                    return result;
                default:
                    result = 0;
                    return result;
            }

        }
    }

}

