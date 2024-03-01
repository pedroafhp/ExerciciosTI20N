using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ExercíciosTI20N
{
    class Control
    {
        Model modelo;
        public Control()
        {
            modelo = new Model();
        }//Fim do Construtor

        public void Menu()
        {
            Console.WriteLine("\n\nEscolha uma das opções abaixo: \n" +
                             "0. Sair\n"                              +
                             "1. Exercício 01\n"                      +
                             "2. Exercício 02\n"                      +
                             "3. Exercício 03\n"                      +
                             "4. Exercício 04\n"                      +
                             "5. Exercício 05\n");
        }//Fim do Menu

        public void Operacao()
        {
            int opcao = 0;
            do
            {
                Menu();//Mostrando as Opções
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado!");
                        break;
                    case 1:
                        Console.WriteLine(modelo.ExercicioUm());
                        break;
                    case 2:
                        Console.WriteLine(modelo.ExercicioDois());
                        break;
                    case 3:
                        Console.WriteLine("A soma dos números entre 1 e 100 é: " + modelo.ExercicioTres());
                        break;
                    case 4:
                        Console.WriteLine("Os múltiplos de 5 entre 1 e 50 são: " + modelo.ExercicioQuatro());
                        break;
                    case 5:
                        Console.WriteLine("Informe um número: ");
                        int num = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(modelo.ExercicioCinco(num));
                        break;
                    default:
                        Console.WriteLine("Código digitado não é valido!");
                        break;


                }//Fim da Operação
            } while (opcao != 0);
        }//Fim da Operação
    }//Fim da Classe
}//Fim do Projeto
