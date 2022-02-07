using System;

namespace Lecture2
{


    class Program
    {
        enum HTTPError
        {
            Continue = 100,
            OK = 200,
            SeeOther = 303,
            BadReques = 400,
            Forbidden = 403,
            NotFound = 404,
            BadGateway = 502,
            HTTPVersionNotSupported = 505
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter 3-sign code of HTTP error");
            int res = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Code {res} is \"{(HTTPError)res}\"");
            Console.ReadKey();
        }
    }
}