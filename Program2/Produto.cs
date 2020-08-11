using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Program2
{
    class Produto
    {

        private string _nome;
        private double _preco;
        private int _quantidade;


        public Produto()
        {
            _nome = "";
            _preco = 0;
            _quantidade = 0;
        }
        public Produto(String nome, double preco) : this ()
        {
            _nome = nome;
            _preco = preco;
           
        }
        public Produto(String nome, double preco, int quantidade)  : this (nome, preco)
        {

            _quantidade = quantidade;
        }

        public string GetNome()
        {
            return _nome;
        }
        public void SetNome(string nome)
        {
            if (nome != null && nome.Length > 1)
            {
                _nome = nome;
            }
        }

        public double GetPreco()
        {
            return _preco;
        }

        public void setPreco(double preco)
        {
            _preco = preco;
        }

        public int GetQuantidade()
        {
            return _quantidade;
        }
        public void setQuantidade(int quantidade)
        {
           _quantidade = quantidade;
        }


        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }

        public override string ToString()
        {

            return _nome
            + ", Valor unitário  R$ "
            + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + _quantidade
            + " unidades, Total: R$ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
