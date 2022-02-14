using System;
using System.Linq;

namespace BelyaevNikitaHW2
{
    class Program
    {
        struct Dog
        {
            public string name;
            public string mark;
            public int age;

            public override string ToString()
            {
                return $"Name = {name} , mark = {mark} , age = {age}";
            }
        }

        enum HTTPError
        {
            BadRequest = 400,
            Unauthorized = 401,
            PaymentRequired = 402,
            Forbidden = 403, 
            NotFound = 404
        }


        static void Main(string[] args)
        {
            // Task 1 : Read 3 float numbers and check if they are all in the range[-5.5]

            Console.Write("Type first number : ");
            float num1 = float.Parse(Console.ReadLine());
            Console.Write("Type second number : ");
            float num2 = float.Parse(Console.ReadLine());
            Console.Write("Type third number : ");
            float num3 = float.Parse(Console.ReadLine());

            string forNum1 = (num1 >= -5 && num1 <= 5) ? "First number in -5.5 range" : "First number not in in -5.5 range";
            Console.WriteLine(forNum1);

            if (num2 <= 5 && num2 >= -5)
            {
                Console.WriteLine($"Second number in -5.5 range");
            }
            else
            {
                Console.WriteLine($"Second number not in -5.5 range");
            }

            bool forNum3 = true;

            if (num3 > 5 && num3 < -5)
            {
                forNum3 = false;
            }

            Console.WriteLine(forNum3 ? "Third number in -5.5 range" : "Third number not in -5.5 range");  // output: Checked

            // Task 2 : Read 3 integer numbers and output max and min of them.

            Console.Write("Type first number : ");
            int firstNum = int.Parse(Console.ReadLine());
            Console.Write("Type second number : ");
            int secondNum = int.Parse(Console.ReadLine());
            Console.Write("Type third number : ");
            int thirdNum = int.Parse(Console.ReadLine());

            int[] intArr = new int[] { firstNum, secondNum, thirdNum };

            Console.WriteLine($"Min : {intArr.Min()} , Max : {intArr.Max()}");

            // Task 3 : Read number of HTTP Error(400, 401, 402, ...) and write the name of this error(Declare enum HTTPError)

            Console.WriteLine($"{HTTPError.BadRequest} = {(int)HTTPError.BadRequest}");
            Console.Write("Type error code ( 400-404 ) : ");
            int answer = int.Parse(Console.ReadLine());

            switch (answer)
            {
                case 400:
                    Console.WriteLine(HTTPError.BadRequest);
                    break;
                case 401:
                    Console.WriteLine(HTTPError.Unauthorized);
                    break;
                case 402:
                    Console.WriteLine(HTTPError.PaymentRequired);
                    break;
                case 403:
                    Console.WriteLine(HTTPError.Forbidden);
                    break;
                case 404:
                    Console.WriteLine(HTTPError.NotFound);
                    break;
            }

            // Task 4 : Declare struct Dog with fields name, mark, age. Declare object myDog of Dog type and read values for it. 
            // Output information on the console. (Override method ToString in struct)

            Dog dog = new Dog();

            Console.WriteLine("What name of your dog?");
            dog.name = Console.ReadLine();
            Console.WriteLine("What mark of your dog?");
            dog.mark = Console.ReadLine();
            Console.WriteLine("How old is your dog?");
            dog.age = int.Parse(Console.ReadLine());

            Console.WriteLine(dog.ToString());
        }
    }
}
