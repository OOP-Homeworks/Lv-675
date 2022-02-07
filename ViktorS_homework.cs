namespace HomeWork2_1
{
    class Program
    {
        static void Main(string[] args)
        {
           
                    Console.WriteLine("Введiть перше число:");
                    float num1 = (float)Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введiть друге число:");
                    float num2 = (float)Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введiть третє число:");
                    float num3 = (float)Convert.ToDouble(Console.ReadLine());

                if (num1 < -5 || num1 > 5 || num2 < -5 || num2 > 5 || num3 < -5 || num3 > 5)
                {
                    Console.WriteLine("Три числа мають бути в дiапазонi вiд -5 до 5");
                }
                else
                {
                    Console.WriteLine($"{num1} , {num2} , {num3} є в дiапазонi вiд -5 до 5 ");
                }
            
            Console.ReadKey();
        }
    }
}

_____________________________________________________________________________ 

namespace HomeWork2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введiть перше число:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введiть друге число:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введiть третє число:");
            int num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 < num2 && num1 < num3 )
            {
                Console.WriteLine($"{num1} - min число");
            }
            else if (num2 < num1 && num2 < num3)
            {
                Console.WriteLine($"{num2} - min число");
            }
            else
            {
                Console.WriteLine($"{num3} - min число");
            }

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine($"{num1} - max число");
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine($"{num2} - max число");
            }
            else
            {
                Console.WriteLine($"{num3} - max число");
            }

            Console.ReadKey();
        }
    }
}

______________________________________________________________________________

namespace HomeWork2_3
{
    class Program
    {
        enum HTTPError
        {
            BadRequest = 400,
            UnauthorizedError = 401,
            PaymentRequired = 402,
            Forbidden = 403,
            NotFound = 404,
            MethodNotAllowed = 405,
            NotAcceptable = 406,
        }
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter HTTPError from 400 to 406");

             int error = Convert.ToInt32(Console.ReadLine());

            

            switch (error)
            {
                case 400:
                    HTTPError status = HTTPError.BadRequest;
                    Console.WriteLine($"HTTP Error {error}:" + status);
                    break;
                case 401:
                    HTTPError status1 = HTTPError.UnauthorizedError;
                    Console.WriteLine($"HTTP Error {error}:" + status1);
                    break;
                case 402:
                    HTTPError status2 = HTTPError.PaymentRequired;
                    Console.WriteLine($"HTTP Error {error}:" + status2);
                    break;
                case 403:
                    HTTPError status3 = HTTPError.Forbidden;
                    Console.WriteLine($"HTTP Error {error}:" + status3);
                    break;
                case 404:
                    HTTPError status4 = HTTPError.NotFound;
                    Console.WriteLine($"HTTP Error {error}:" + status4);
                    break;
                case 405:
                    HTTPError status5 = HTTPError.MethodNotAllowed;
                    Console.WriteLine($"HTTP Error {error}:" + status5);
                    break;
                case 406:
                    HTTPError status6 = HTTPError.NotAcceptable;
                    Console.WriteLine($"HTTP Error {error}:" + status6);
                    break;                           
            }
            Console.ReadKey();
        }
    }
}

______________________________________________________________________________

namespace HomeWork2_4
{
    class Program
    {
        struct Dog
        {
            public string Name;
            public string Mark;
            public int Age;

            //override ToString
            public override string ToString()
            {

                return ($"The dog's name: {Name}, mark: {Mark}, and age: {Age}");
            }
        }
        static void Main(string[] args)
        {
            Dog myDog;
            Console.WriteLine("Enter name of dog");
            myDog.Name = Console.ReadLine();
            Console.WriteLine("Enter mark of dog");
            myDog.Mark = Console.ReadLine();
            Console.WriteLine("Enter age of dog");
            myDog.Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(myDog.ToString());

            Console.ReadKey();
        }
    }
}