using System;
using System.Text;

namespace MaskSensitiveInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tell me a secret");
            var secret = Console.ReadLine();
            var counter = 0;

            StringBuilder maskedSecret = new StringBuilder();

            foreach (var letter in secret)
            {
                if (counter < 4)
                {
                    maskedSecret.Append(letter.ToString());
                }
                else
                {
                    maskedSecret.Append("X");
                }
                counter += 1;
            }

            Console.WriteLine(maskedSecret);
            Console.ReadLine();
        }
    }
}
