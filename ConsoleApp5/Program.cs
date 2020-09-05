using ConsoleApp5.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            string caminho = @"C:\c#\produtos.txt";
            List<Produto> produtos = new List<Produto>();
            try
            {
                using (FileStream fs = new FileStream(caminho, FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        while (!sr.EndOfStream)
                        {
                            string linha = sr.ReadLine();
                            Produto produto = new Produto(linha);
                            produtos.Add(produto);
                        }
                    }
                }
            }
            catch
            {
                throw new Exception("Erro");
            }

            produtos.Sort();

            Console.WriteLine($"O produto mais caro é a {produtos[0].Name} e o seu valor é $ {produtos[0].Valor.ToString("F2",CultureInfo.InvariantCulture)}");
        }
    }
}
