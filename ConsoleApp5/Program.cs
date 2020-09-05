using System;
using System.IO;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            string linha = @"C:\c#\produtos.txt";

            try
            {
                using (FileStream fs = new FileStream(linha, FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {

                    }
                }
            }
            catch
            {
                throw new Exception("Erro");
            }
        }
    }
}
