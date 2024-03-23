using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Produto produto1 = new Produto("Camiseta", 5, 25.0);
                Produto produto2 = new Produto("Calça", 3, 50.0);
                Produto produto3 = new Produto("Boné", 10, 15.0);

                Console.WriteLine("Informações dos Produtos:");
                Console.WriteLine($"Produto 1: Nome - {produto1.Nome}, Quantidade - {produto1.Quantidade}, Valor - {produto1.Valor}");
                Console.WriteLine($"Produto 2: Nome - {produto2.Nome}, Quantidade - {produto2.Quantidade}, Valor - {produto2.Valor}");
                Console.WriteLine($"Produto 3: Nome - {produto3.Nome}, Quantidade - {produto3.Quantidade}, Valor - {produto3.Valor}");

                Console.WriteLine("\nValor Total de Cada Produto:");
                Console.WriteLine($"Produto 1: {produto1.CalcularTotal()}");
                Console.WriteLine($"Produto 2: {produto2.CalcularTotal()}");
                Console.WriteLine($"Produto 3: {produto3.CalcularTotal()}"); 

                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro {ex.Message}");  

            } 
            


            
        }


    }
}
