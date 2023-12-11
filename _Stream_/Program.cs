using System.Text;

namespace _Stream_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var sw = new StreamWriter("test.txt", true, Encoding.UTF8))
            {
                sw.WriteLine("Hello ");
                sw.WriteLine("Hello World");
                sw.WriteLine("лриромр");
            }

            using (var sr = new StreamReader("test.txt", Encoding.UTF8))
            {
                while(!sr.EndOfStream)
                {
                    Console.WriteLine(sr.ReadLine() + " End Line");
                }
                var text = sr.ReadToEnd();
                Console.WriteLine(text);
            }
            Console.ReadLine();
        }
    }
}
