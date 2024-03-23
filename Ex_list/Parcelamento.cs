using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ex_list
{
    class Parcelamento
    {
        public Parcelamento(int quantidadeDeParcelas, double valorPorParcela)
        {

        }

        private int _quantidade;
        public int Quantidade 
        {
            get => _quantidade; 
            set
            {
              

            }
        }
        

        private static void Validaquantidade_parcela(int quantidade)
        {

            double juros = 0; 

            if (quantidade >= 10)
            {
                juros = 0.10; 
            }
            if (quantidade >= 5)
            {
                juros = 0.05; 
            }
            if (quantidade <= 0)
            {
                throw new Exception("É Necessário inserir um numero de parcelas"); 
            }
        }


        public static void CalculoJuros(int quantidade)
        {
            
        }


    }
}
