/*        HomeWork 2            
    by Salnikov Markiian
                                   gmail: salnikov.markiya@gmail.com
*/

using System;

namespace Salnikov_Hw2
{
    class Program
    {
        static bool inRange(float number1, float number2, float number3) // for task1
        {
            sbyte low = -5;
            sbyte high = 5;
            return ((number1 <= high && number1 >= low) &&
                (number2 <= high && number2 >= low) &&
                (number3 <= high && number3 >= low));
        }

        public enum HTTPError //for task3
        {
            NotFound = 404,
            Conflict = 409,
            Locked = 423,
            ToEarly = 425

        }

        public struct Dog  //for task4
        {
            public string mark;
            public string name;
            public byte age;

            public override string ToString()
            {
                return string.Format("\nDog name is {0}, \nmark: {1}, \nage: {2} y.o.", name, mark, age);
            }
        }


        static void Main(string[] args)
        {
            bool exitPoint = true;
            do
            {
                Console.WriteLine("\n\nHW-2 \n 1) Task 1 \n 2) Task 2 \n 3) Task 3 \n 4) Exit");
                int i = int.Parse(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        Task1();
                        break;
                    case 2:
                        Task2();
                        break;
                    case 3:
                        Task3();
                        break;
                    case 4:
                        Task4();
                        break;
                    case 5:
                        Exiting();
                        break;

                    default:
                        Console.WriteLine("Error");
                        break;
                }
            } while (exitPoint);


            // methods
            void Task1()
            {
                Console.WriteLine("Enter three float number");

                float fNumber = Convert.ToSingle(Console.ReadLine());
                float sNumber = Convert.ToSingle(Console.ReadLine());
                float tNumber = Convert.ToSingle(Console.ReadLine());

                bool check = inRange(tNumber, sNumber, tNumber);
                if (check)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("No");
                }
            }
            void Task2()
            {
                Console.WriteLine("Enter integer a, b & c: ");
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                int c = Convert.ToInt32(Console.ReadLine());

                int max = a > b ? (a > c ? a : c) : (b > c ? b : c);
                int min = a < b ? (a < c ? a : c) : (b < c ? b : c);

                Console.WriteLine($"Max = {max}, Min = {min}");

            }
            void Task3()
            {
                Console.WriteLine("Enter ur error from enum: ");

                var values = Enum.GetValues(typeof(HTTPError));
                foreach (var item in values)
                {
                    Console.WriteLine((int)item);
                }


                int error = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"The error name is: {(HTTPError)error}");
            }
            void Task4()
            {
                Dog dog1;
                Console.WriteLine("Enter please dog`s name, mark & age: ");
                dog1.name = Console.ReadLine();
                dog1.mark = Console.ReadLine();
                dog1.age = Convert.ToByte(Console.ReadLine());

                Console.WriteLine(dog1);
            }

            void Exiting()
            {
                Console.Write("\n Exiting!....");
                exitPoint = false;
            }
        }

    }
}
