using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGitHub
{
    class Program
    {
        static void EscreverNaTela(String txt)
        {
            Console.WriteLine(txt);
        }

        static void EscreverNaTela2(String txt)
        {
            EscreverNaTela(txt);
        }
        static void Main(string[] args)
        {
            EscreverNaTela();
            Console.ReadKey();
        }
    }
}
