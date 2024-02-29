using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercíciosTI20N
{
    class Model
    {

        //Contrutor
        public Model() 
        { 
            
        }//Fim do Método Construtor

        //Exercício 01: Faça um programa que imprima os números de 1 a 10.
        public string ExercicioUm()
        {
            string resultado = "";

            for(int i=0; i < 10; i++)
            {
                resultado += "\n" + i+1;
            }

            return resultado;
        }//Fim do Método


    }//Fim da Classe
}//Fim do Projeto
