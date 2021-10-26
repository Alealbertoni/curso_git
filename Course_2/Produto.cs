using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Course_2 {
    class Produto {
        private string _nome;
        //auto properties
        public double Preco { get; private set; }
        public double Quantidade { get; private set; }
      

        public Produto() {
        }

      
        public Produto(string nome, double preco, int quantidade) {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        // properties
        public string Nome {
            get { return _nome; }
            set {
                if (value != null && value.Length > 1) {
                    _nome = value;
                }
            }
        }

        /*public double Preco {
            get { return _preco; }
        }

        public int Quantidade {
            get {
                return _quantidade;}
        }

                public string GetNome() {
            return _nome;
        }*/

        /*
        metodo manual
        public void SetNome(string nome) {
            if (nome != null && nome.Length > 1) {
                _nome = nome;
            }
        }
        public double GetPreco() {
            return _preco;
        }
        public int GetQuantidade() {
            return _quantidade;
        }*/

        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade) {
            Quantidade = Quantidade + quantidade;
        }

        public void RemoverProdutos(int quantidade) {
            Quantidade = Quantidade - quantidade;
        }


        public override string ToString() {
            return _nome
                  + ", $"
                  + Preco.ToString("F2", CultureInfo.InvariantCulture)
                  + ", "
                  + Quantidade
                  + " unidades, Total: $ "
                  + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
