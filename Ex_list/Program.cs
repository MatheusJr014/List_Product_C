using System.Data;
using System.Runtime.CompilerServices;

namespace Ex_list
{
    class Produto
    {
        public Produto(string nome, int quantidade, double valor)
        {
            Produto.ValidaQuantidade(quantidade);
            Produto.ValidaValor(valor);
            this._nome = nome;
            this._quantidade = quantidade;
            this._valor = valor;
        }
        private string _nome; 
        public string Nome 
        {
            get => _nome;
            set => _nome = value;
        }
            
        private int _quantidade;
        public int Quantidade
        {
            get => _quantidade;
            set
            {
                Produto.ValidaQuantidade(value);
                _quantidade = value;
            } 
        }

        private double _valor;
        public double valor
        {
            get=> _valor;
            set
            {
                Produto.ValidaValor(value);
                _valor = value;
            }
        }
        private static void ValidaQuantidade(int quantidade)
        {
            if (quantidade <= 0) 
            {
                throw new Exception("Quantidade inválida. Deve ser maior que 0"); 

            }
        }

        private static void ValidaValor(double valor)
        {
            if (valor <= 0)
            {
                throw new Exception("Valor inválido. Deve ser maior que 0"); 
            }
        }


    }
}
