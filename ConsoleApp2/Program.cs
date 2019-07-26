using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaBruno = new ContaCorrente();
            contaBruno.titular = "Bruno";

            Console.WriteLine(contaBruno.saldo);
            contaBruno.Sacar(50);
            Console.WriteLine(contaBruno.saldo);

            Console.ReadLine();
        }
    }
}
