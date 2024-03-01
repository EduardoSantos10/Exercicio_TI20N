using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_TI20N
{
    class Model
    {
    
        //Construtor
        public Model() 
        {
        
        
        
        
        }//Fim do Construtor 

        //Exercício 01: Faça um programa que imprima os números de 1 a 10.
        public string ExercicioUm() 
        {




            string resultado = "";


            for (int i = 0; i < 10; i++) 
            {

                resultado += "\n" + (i + 1);
            
            
            
            }
            return resultado;
        }//Fim do Método

        //Faça um programa que imprima os números pares de 1 a 20.
        public string ExercicioDois() 
        {

            string resultado = "";
            for (int i = 0; i < 20; i++) 
            {

                if ((i + 1) % 2 == 0) 
                {
                
                    resultado += "\n" + (i + 1);
                    

                }// fim do if
            
            }// Fim do For
            return resultado;
        
        }// Fim do Dois

        // Exercício 3: Faça uma soma que calcule a soma dos números de 1 a 100.
        public int ExercicioTres() 
        {
            int resultado = 0;
            for (int i = 1; i <= 100; i++)
            { 
                resultado += i;
            }// Fim do For
            return resultado;
        }// Fim do Três

        // Exercício 4: Faça um programa que imprima os múltiplos de 5 de 1 a 50.
        public string ExercicioQuatro() 
        {
            string resultado = "";
            for (int i = 1; i < 50; i++)
            {

                if ((i + 1) % 5 == 0)
                {

                    resultado += "\n" + (i + 1);


                }// fim do if

            }// Fim do For
            return resultado;

        }//Fim do Quatro

        //Exercício 5: Faça um programa que peça ao usuário um número e imprima se é par ou ímpar.

        public string ExercicioCinco( int num) 
        {


            if (num % 2 == 0)
            {
                return num + "Par";

            }
            else 
            {

                return num + "ímpar";
            
            
            }




        }//Fim do Cinco








    }//Fim da Classe

}//Fim do Projeto
