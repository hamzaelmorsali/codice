using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace base64
{
    class Program
    {
        static void Main(string[] args)
        {
            string plainText;
            Console.WriteLine("inserire una stringa");
            plainText = Convert.ToString(Console.ReadLine());
            string base64EncodedData;
            byte[] PlainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            for(int i = 0; i < PlainTextBytes.Length; i++)
            {
                Console.WriteLine(PlainTextBytes[i]);
                Console.WriteLine(Convert.ToString(PlainTextBytes[i], 2));

            }
            base64EncodedData = Convert.ToBase64String(PlainTextBytes);
            Console.WriteLine(base64EncodedData);
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            plainText = System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
            Console.WriteLine(plainText);
            Console.ReadLine();
        }
    }
}
