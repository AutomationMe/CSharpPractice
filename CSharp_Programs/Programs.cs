using System;

namespace HelloWorld
{
    public class Programs
    {
     public void ReverseString1()
        {
            String s = "Anju";
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            Console.WriteLine(charArray);
            Console.ReadLine();
        }

        public void ReverseString2()
        {
            String name = "Sandeep";
            char[] ch = name.ToCharArray();
            String Reversed = string.Empty;
            for (int i= ch.Length-1;i> -1;i--)
            {
                Reversed += ch[i];
            }
/
            Console.WriteLine(Reversed);
        }

        public void ReverseString3()
        {
            string str = "I am going to reverse myself";
            string strrev = "";

            foreach (var word in str.Split(' '))
            {
                string temp = "";
                foreach (var ch in word.ToCharArray())
                {
                    temp = ch + temp;
                }
                strrev = strrev + temp + "";
            }
            Console.WriteLine(strrev);

        }

        public void ReverseNumber()
        {
           
                int n, reverse = 0, rem;
                Console.Write("Enter a number: ");
                n = Convert.ToInt32(Console.ReadLine());
                while (n != 0)
                {
                rem = n % 10;
                reverse = reverse * 10 + rem;
                n /= 10;
                }
                Console.Write("Reversed Number: " + reverse);
            
        }

        public void sentense()
        {
            string name = "My name is XYZ";

            foreach (var word in name.Split(' '))
            {
              

                Console.WriteLine(word);
            }


            Console.WriteLine("/n");

        }

    }
}