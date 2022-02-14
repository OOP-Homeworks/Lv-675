using System;

namespace Salnkov_HW2_2
{
    enum Food
    {
        Milk = 10,
        Mouse = 20,
        Wiskass = 30,
        Fish = 40,
        DryFood = 45

    }

    class Cat
    {
        public int satiety = 0;

        public void EatSmth()
        {
            Random rnd = new Random(); // to random generation

            bool exitPoint = true;
            do
            {
                if (satiety >= 100)
                {
                    satiety = 100;
                }
                else if (satiety <= 0)
                {
                    satiety = 0;
                }

                Console.Clear();

                var values = Enum.GetValues(typeof(Food));
                int x = 0;
                foreach (var item in values)
                {
                    x++;
                    Console.WriteLine($"{x} {item} + {(int)item} satiety");
                }
                Console.WriteLine("6 Wait a little while \n7 Exit\n");

                Console.CursorVisible = false;
                Console.SetCursorPosition(1, 8);
                for (int b = 0; b < (satiety / 2); b++)
                {
                    for (int y = 0; y < b; y++)
                    {
                        string pb = "\u2551";
                        Console.Write(pb);
                    }
                    Console.Write("Level of satiety : " + (b * 2 + 2) + "/100%");
                    Console.SetCursorPosition(1, 8);

                    System.Threading.Thread.Sleep(50);
                }
                Console.Write("\nTap on Enter");
                Console.ReadLine();


                Console.WriteLine("How do we feed the cat? :");

                int i = int.Parse(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        satiety = satiety + (int)Food.Milk;
                        break;
                    case 2:
                        satiety = satiety + (int)Food.Mouse;
                        break;
                    case 3:
                        satiety = satiety + (int)Food.Wiskass;
                        break;
                    case 4:
                        satiety = satiety + (int)Food.Fish;
                        break;
                    case 5:
                        satiety = satiety + (int)Food.DryFood;
                        break;
                    case 6:
                        Console.WriteLine("Waitiing a little while .... /n/n");
                        int randomValue = rnd.Next(0, 100);
                        satiety = satiety - randomValue;
                        break;
                    case 7:
                        exitPoint = false;
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }
            } while (exitPoint);

        }
    }

    struct Student
    {
        public int nbrStudents; //number of students
        public int[] groupNumber;
        public string[] surname;
    }

    class Program
    {
        static void Main(string[] args)
        {
            //first additional assignment 
            Cat milka = new Cat();
            milka.EatSmth();

            /*second assitional assigment in developing



        }


    }
}

