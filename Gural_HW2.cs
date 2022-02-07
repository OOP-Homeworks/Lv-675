using System;

namespace Gural_NW2
{
    class Program
    {

        enum HTTPEror
        {
            Bad_Request = 400,
            Unauthorized = 401,
            Payment_Required = 402,
            Forbidden = 403,
            Not_Found = 404,
            Method_Not_Allowed = 405
        }

        struct Dog
        {
            public string name;
            public string mark;
            public int age;
            public void Adddoginfo(string n, string m, int a)
            {
                name = n;
                mark = m;
                age = a;
            }
            public override string ToString()
            {
                return string.Format("DogInfo\n Name = {0}\n Mark = {1}\n Age = {2}", name, mark, age);
            }

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Task 1");
            Console.WriteLine("Enter 3 float number");
            float a = float.Parse(Console.ReadLine());
            string answer = (a >= -5 && a <= 5) ? "Number is in range" : "Number is not in range";
            Console.WriteLine(answer);
            a = float.Parse(Console.ReadLine());
            answer = (a >= -5 && a <= 5) ? "Number is in range" : "Number is not in range";
            Console.WriteLine(answer);
            a = float.Parse(Console.ReadLine());
            answer = (a >= -5 && a <= 5) ? "Number is in range" : "Number is not in range";
            Console.WriteLine(answer);
            Console.WriteLine("\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\");
            Console.WriteLine();
            

            Console.WriteLine("Task 2");
            int num;
            int min = 0;
            int max = 0;
            int n = 3;
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter number");
                num = Int32.Parse(Console.ReadLine());
                min = (i == 0) ? num : (min > num) ? num : min;
                max = (i == 0) ? num : (max < num) ? num : max;
            }
            Console.WriteLine("Max number = {0} \nMin number = {1}",max ,min);
            Console.WriteLine("\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\");
            Console.WriteLine();
           

            Console.WriteLine("Task 3");
            Console.WriteLine("Enter eror code");
            int erorcode = Int32.Parse(Console.ReadLine());
            HTTPEror eror = (HTTPEror) erorcode;
            Console.WriteLine("Eror code = {0}-{1}", erorcode, eror);
            Console.WriteLine("\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\");
            Console.WriteLine();
            

            Console.WriteLine("Task 4");
            Dog mydog = new Dog();
            Console.WriteLine("Enter dog name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter dog mark");
            string mark = Console.ReadLine();
            Console.WriteLine("Enter dog age");
            int age = Int32.Parse(Console.ReadLine());
            mydog.Adddoginfo(name, mark, age);
            Console.WriteLine(mydog);

            Console.ReadKey();
        }
    }
}
