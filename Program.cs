using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_ForEncadeado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto - For encadeado - Desenhando forma com asteriscos: \r\n");

            Console.WriteLine("____________________________________________________________________ \r\n");

            for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
            {
                for (int contadorColuna = 0; contadorColuna < 10; contadorColuna++)
                {
                    //Quando adicionamos o Console.WriteLine() com os parênteses vazios, ocorre a quebra de linha, mas nesse caso adicionamos o * detro do parênteses.

                    Console.Write("*");
                    if (contadorColuna >= contadorLinha)
                        break;

                    //Nesse caso quando o contadorColuna for maior ou igual ao ContadorLinha, interrompemos a execução utilizando a palavra reservado break, que quando adicionada faz o editor selecionar imediatamente o for().

                    //O resultado deve ser:

                    //*
                    //**
                    //***
                    //****
                    //*****
                    //******
                    //*******
                    //********
                }
                Console.WriteLine();
            }


            Console.WriteLine("\r\n____________________________________________________________________ \r\n");

            Console.WriteLine("For encadeado - Desenhando forma com asteriscos - Outro modo de executar: \r\n");

            for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
            {
                for (int contadorColuna = 0; contadorColuna <= contadorLinha; contadorColuna++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
