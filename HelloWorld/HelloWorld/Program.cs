using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Int - 156 como 32334
            // Float - -15.6 como 232.132 ==> Double\ Decimal
            //Bool - true or false
            //String - "textual"
            //Char - caracter 'a'

            //A-Z, 0 -9 desde que não seja no inicio, _, não @#$%
            /*
            int segundaGuerraMundial = 1945;
            string corFavorita = "Preto";
            float velocidade = 245.2f;
            bool sGM = true;

            var meuTexto = "Hello World";

            Console.WriteLine(segundaGuerraMundial);
            Console.WriteLine(corFavorita);
            Console.WriteLine(velocidade);
            Console.WriteLine(sGM);

            Console.ReadKey();

            corFavorita = "Roxo";
            velocidade = 90.2f;

            Console.WriteLine(corFavorita);
            Console.ReadKey();
            */

            /*
            var corFavorita = "Vermelho";
            var modeloDoProduto = 2323;
            */

            //não aconselhavel usar dynamic
            /*
            dynamic corFav = "Vermelho";
            Console.WriteLine(corFav);
            corFav = 22;
            Console.WriteLine(corFav);

            const float PI = 3.145254;
            */

            string nome = "";

            Console.WriteLine("Escreva seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Seu nome é: ");
            Console.WriteLine(nome);

            Console.ReadKey();
        
        }
    }
}
