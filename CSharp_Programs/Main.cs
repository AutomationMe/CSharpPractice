using System;

namespace HelloWorld
{

    class Main_Function
    {

        static void Main(string[] args)
        {
            Programs P = new Programs();

            Console.WriteLine("Please select the action from below\n" + "1.Reverse String\n" + "2.Reverse String without keyword\n"
                + "3.Reverse each word in a string \n" + "4.Reverse a number \n");
            string value = Console.ReadLine();

            switch (value)
            {
                case "1": P.ReverseString1(); break;
                case "2": P.ReverseString2(); break;
                case "3": P.ReverseString3(); break;
                case "4":
                    P.ReverseNumber(); break;

                    Console.WriteLine("Press any key to exit");
                    Console.ReadLine();


            }
        }
    }
}