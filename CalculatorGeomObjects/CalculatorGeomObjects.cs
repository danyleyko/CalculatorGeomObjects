using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CalculatorGeomObjects
{
    public class Program
    {
        static void Main(string[] args)
        {
            WelcomeMessage Welcome = new WelcomeMessage();
            UserInputs UserInputs = new UserInputs();
            Welcome.WelcomeNotif();
            UserInputs.PickedObject();
            UserInputs.PickedOperation();
            //Console.WriteLine(UserInputs.userInputValues);

        }
    }

    //Writing greetings for beauty C:
    public class WelcomeMessage
    {
        public void WelcomeNotif()
        {
            Console.WriteLine("_________________________________________________\n");
            Console.WriteLine("Welcome, to the calculator of geometrical objects");
            Console.WriteLine("\tCreated by Danyleyko Kirill");
            Console.WriteLine("\tStart project in 01.12.2022");
            Console.WriteLine("_________________________________________________\n");
        }
    }


    public class UserInputs 
    {
        public int objectChoice;
        public int operationChoice;

        public int[] userInputValues = new int[2];

        public void PickedObject() 
        {
            int arrayMax = 2;
            Console.WriteLine("Hey! \nIn front of you is a list of objects with which we will work further: ");
            Console.WriteLine("\r \t1. Square." +
                              "\r\n \t2. Circle." +
                              "\r\n \t3. Rectangle." +
                              "\r\n \t4. Cuboid." +
                              "\r\n \t5. Cylinder." +
                              "\r\n \t6. Sphere.");
            Console.Write("Please choose one of the options of the object to continue working with it: ");


            switch (objectChoice = Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    Console.WriteLine($"\nYou picked - '{objectChoice}. Square'");
                    userInputValues = new int[1];
                    Console.WriteLine($"You must write - '{arrayMax - 1}' argument, please insert it - ");
                    for (int i = 0; i != 1; i++)
                    {
                        Console.Write($"\n{i + 1}. "); //For beauty
                        userInputValues[i] = Convert.ToInt32(Console.ReadLine());
                    }

                    break;
                case 2:
                    Console.WriteLine($"You picked - '{objectChoice}. Circle'");
                    break;
                case 3:
                    Console.WriteLine($"You picked - '{objectChoice}. Rectangle'");
                    break;
                case 4:
                    Console.WriteLine($"You picked - '{objectChoice}. Cuboid'");
                    break;
                case 5:
                    Console.WriteLine($"You picked - '{objectChoice}. Cylinder'");
                    break;
                case 6:
                    Console.WriteLine($"You picked - '{objectChoice}. Sphere'");
                    break;
                default:
                    Console.WriteLine("You write wrong number, rewrite please.");
                    break;
            }
        }

        public void PickedOperation()
        {
            Console.WriteLine("Now please choose which operation you want to take place:");
            Console.WriteLine("\r \t1. Area." +
                              "\r\n \t2. Volume.");
            Console.Write("Please choose one of the options of the operation to continue working with it: ");
            switch (operationChoice = Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    Console.WriteLine($"You picked - '{operationChoice}. Area'");
                    break;
                case 2:
                    Console.WriteLine($"You picked - '{operationChoice}. Volume'");
                    break;
                default:
                    Console.WriteLine("You write wrong number, rewrite please.");
                    break;

            }
        }


    }

}
