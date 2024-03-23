using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_list
{
    enum FormaPagamento
    {
        Pix, 
        CartaoCredito, 
        CartaoDebito, 
        Dinheiro
    }
    internal class Compra
    {
        List<Produto> produtos;
        Parcelamento? parcelamento;
        FormaPagamento formaPagamento; 

        public Compra(List<Produto> produtos, FormaPagamento formaPagamento)
        {
            this.produtos = produtos;
            this.formaPagamento = formaPagamento;
        }
    }
}
