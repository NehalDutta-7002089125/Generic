using System;

namespace Generics_Max
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MaxNo<int> a = new MaxNo<int>(314, 34, 4);
            MaxNo<string> b = new MaxNo<string>("Apple", "Banana","Peach");
            MaxNo<float> c = new MaxNo<float>(31.44f, 3481.43f, 412.44f);
            Console.WriteLine(a.check());
            Console.WriteLine(b.check());
            Console.WriteLine(c.check());
        }
    }
}
