using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ConsoleApp5.Entities
{
    class Produto: IComparable
    { 
        public string Name { get; set; }
        public double Valor { get; set; }

        public Produto()
        {
        }

        public Produto(string name, double valor)
        {
            Name = name;
            Valor = valor;
        }

        public Produto (string arquivo)
        {
            string[] linha = arquivo.Split(",");
            Name = linha[0];
            Valor = double.Parse(linha[1],CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj)
        {
            if(!(obj is Produto))
            {
                throw new Exception("Obj não é Produto");
            }

            Produto outro = obj as Produto;
            return outro.Valor.CompareTo(Valor);
        }
    }
}
