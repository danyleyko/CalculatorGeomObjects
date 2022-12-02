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
            Console.WriteLine(UserInputs.userInputValues);

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
        public int pickedObject;
        public int pickedOperation;

        public int[] userInputValues = new int[3];

        public void PickedObject() 
        {
            
            Console.WriteLine("Hey! \nIn front of you is a list of objects with which we will work further:");
            Console.WriteLine("\r \t1. Square." +
                              "\r\n \t2. Circle." +
                              "\r\n \t3. Rectangle." +
                              "\r\n \t4. Cuboid." +
                              "\r\n \t5. Cylinder." +
                              "\r\n \t6. Sphere.");
            Console.Write("Please choose one of the options of the object to continue working with it:");


            switch (pickedObject = Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    Console.WriteLine($"You picked - '{pickedObject}. Square'");
                    break;
                case 2:
                    Console.WriteLine($"You picked - '{pickedObject}. Circle'");
                    break;
                case 3:
                    Console.WriteLine($"You picked - '{pickedObject}. Rectangle'");
                    break;
                case 4:
                    Console.WriteLine($"You picked - '{pickedObject}. Cuboid'");
                    break;
                case 5:
                    Console.WriteLine($"You picked - '{pickedObject}. Cylinder'");
                    break;
                case 6:
                    Console.WriteLine($"You picked - '{pickedObject}. Sphere'");
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
            Console.Write("Please choose one of the options of the operation to continue working with it:");
            switch (pickedOperation = Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    Console.WriteLine($"You picked - '{pickedOperation}. Area'");
                    break;
                case 2:
                    Console.WriteLine($"You picked - '{pickedOperation}. Volume'");
                    break;
                default:
                    Console.WriteLine("You write wrong number, rewrite please.");
                    break;

            }
        }

        public void UserArguments()
        {
            int arrayMax = 3;
            if (pickedObject <= 3)
            {
                userInputValues = new int[arrayMax - 1];
            }
            else 
            {
                userInputValues = new int[arrayMax];
            }
        }
    }
}
