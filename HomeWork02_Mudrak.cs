using System;

namespace NomeWork02
{
    class HM2
    {
        struct Dog
        {
            public string name;
            public string mark;
            public int age;

            public override string ToString()
            {
                return string.Format($"Ім'я {name}, порода {mark}, років {age}.");
            }
        }


        enum Error 
        {
            BadRequest,
            Unauthorized,
            PaymentRequired 
        }

        static void Errors(Error b)
        {
            string result = "";
            switch (b)
            {
                case Error.BadRequest:
                    result = "HTTP 400 Bad Request";
                    break;
                case Error.Unauthorized:
                    result = "HTTP 401 Unauthorized";
                    break;
                case Error.PaymentRequired:
                    result = "HTTP 402 Payment Required";
                    break;
            }
            Console.WriteLine(result);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Type any 3 number");
            string a = Console.ReadLine(), b = Console.ReadLine(), c = Console.ReadLine();
            float a1 = float.Parse(a);
            float b1 = float.Parse(b);
            float c1 = float.Parse(c);
            Console.WriteLine($"Numbers in range -5 to 5 is");
            if (a1 >= -5 && a1 <= 5) { Console.WriteLine(a1); }
            if (b1 >= -5 && b1 <= 5) { Console.WriteLine(b1); }
            if (c1 >= -5 && c1 <= 5) { Console.WriteLine(c1); }

            
            int f, g, h;
            Console.WriteLine("Type any 3 numbers");
            f = Convert.ToInt32(Console.ReadLine());
            g = Convert.ToInt32(Console.ReadLine());
            h = Convert.ToInt32(Console.ReadLine());

            if (f > g && f > h)
                Console.WriteLine("Nubmer Max = " + f);
            else if (g > h)
                Console.WriteLine("Number Max = " + g);
            else
                Console.WriteLine("Number Max = " + h);
            if (f < g && f < h)
                Console.WriteLine("Nubmer Min = " + f);
            else if (g < h)
                Console.WriteLine("Number Min = " + g);
            else
                Console.WriteLine("Number Min = " + h);


            Errors(Error.BadRequest);
            Errors(Error.PaymentRequired);
            Errors(Error.Unauthorized);

            Dog MyDog;
            MyDog.name = "Indus";
            MyDog.mark = "Pitbul";
            MyDog.age = 5;
            Console.WriteLine(MyDog);
        }
    }
}
