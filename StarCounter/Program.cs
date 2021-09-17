using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace StarCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            if (args.Length > 0)
                n = int.Parse(args[0]);
            else
                n = 1;
            string s = "";
            for(int i=0;i<n;i++)
            {
                s += "*";
                Console.WriteLine(s);
                Thread.Sleep(1000);
            }
        }
    }
}
