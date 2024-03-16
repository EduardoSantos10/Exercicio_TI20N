using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization;
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

        public string ExercicioCinco(int nub)
        {


            if (nub % 2 == 0)
            {
                return nub + "Par";

            }
            else
            {

                return nub + "ímpar";


            }




        }//Fim do Cinco


        //Exercício 6: Faça um programa que peça ao usuário um número e imprima se é positivo, negativo ou zero.

        public string ExercicioSeis(int nub)
        {
            if (nub > 0)
            {
                return "Positivo";

            }
            else if (nub < 0)
            {

                return "Negativo";


            }
            else
            {

                return "O número informado é Zero";


            }// Fim do IF

        }// Fim do Seis

        // Exercício 7: Faça um programa que peça ao usuário um
        // Número e imprima a tabuada desse número

        public string ExercicioSete(int num)
        {


            string resultado = "";

            resultado += "Tabuada de " + num;
            for (int i = 0; i <= 10; i++)
            {

                resultado += "\n" + num + " * " + i + " = " + (num * i);



            }//Fim do Método For
            return resultado;

        } // Fim do Sete


        //Exercício 8: Faça um programa que peça ao usuario um número e
        //imprima os numeros de 1 até esse número

        public string ExercicioOito(int num)
        {

            string resultado = "";
            for (int i = 0; i < num; i++)
            {
                resultado += "\n" + (1 + i);
            }// Fim do For
            return resultado;


        }// Fim do Oito

        //Exercício 9: Faça um programa que peça ao usuário um número e
        //Imprima a soma dos números de 1 até esse número.

        public int ExercicioNove(int num)
        {

            int resultado = 0;

            for (int i = 0; i <= num; i++)
            {
                resultado += i;
            }// Fim do For
            return resultado;
        }//Fim do Nove


        //Exercício 10: Faça um programa que imprima os números primos de 1 a 20.
        public string ExercicioDez()
        {

            string primos = "2 3 5";

            for (int i = 2; i <= 20; i++)
            {
                if (i % 2 != 0 && i % 3 != 0 && i % 5 != 0)
                {

                    primos += " " + i;

                }


            }// Fim do For
            return primos;

        }//Fim do Dez

        //Exercício 11: Faça um programa que peça ao usuário um
        // número e verifique se é primo
        public string ExercicioOnze(int num)
        {


            if (num % 2 != 0 && num % 3 != 0 && num % 5 != 0)
            {

                return "Primo!";

            }
            else if (num == 2 || num == 3 || num == 5)
            {

                return "Primo!";


            }
            else
            {

                return "Não Primo!";

            }//Fim do IF


        }//Fim do Onze


        //Exercício 12: Faça um programa que calcule o fatorial de um número
        public int ExercícioDoze(int num)
        {

            int fatorial = 1;
            for (int i = num; i >= 1; i--)
            {

                fatorial *= i;

            }//Fim do For

            return fatorial;



        }// Fim do Doze

        //Exercício 13: Faça um programa que imprima uma sequencia de Fibonacci
        //até o décimo termo
        public string ExercícioTreze()
        {

            string resultado = "0 1";

            int fib1 = 0;
            int fib2 = 1;
            int fib3 = 0;

            for (int i = 1; i <= 8; i++)
            {


                fib3 = fib1 + fib2;
                resultado += " " + fib3;
                fib1 = fib2;
                fib2 = fib3;


            }// Fim do For

            return resultado;

        }//Fim do Treze

        //Exercício 14: Faça um programa que peça ao usuário
        // um número e imprima se é número de Fibonacci

        public string ExercícioQuatorze(int num)
        {

            string resultado = "0 1";

            int fib1 = 0;
            int fib2 = 1;
            int fib3 = 0;

            for (int i = 1; i <= num - 2; i++)
            {


                fib3 = fib1 + fib2;
                resultado += " " + fib3;
                fib1 = fib2;
                fib2 = fib3;


            }// Fim do For

            return resultado;


        }// Fim do Quatorze


        // Exercício 15: Faça um programa que peça ao usuário um
        // número e calcule a soma dos seus dígitos.
        public int ExercícioQuinze(int num)
        {

            string resultado = "" + num; //Convertendo número para texto
            int tamanho = resultado.Length; //Retorna o tamanho do texto
            int soma = 0;

            for (int i = 0; i < tamanho; i++)
            {

                soma += Convert.ToInt32(resultado.Substring(i, 1));

            }// Fim do For

            return soma;

        }// Fim do Quinze





        // Exercício 16: Faça um programa que peça ao usuário um número
        // e imprima os números pares e impares de 1 até esse número.
        public string ExercícioDezesseis(int num)
        {

            string par = "";
            string impar = "";

            for (int i = 1; i <= num; i++)
            {

                if (i % 2 == 0)
                {


                    par += "" + i;


                }
                else
                {

                    impar += "" + i;


                }// Fim do if


            }// Fim do For

            return "pares " + par + "\nImpares: " + impar;


        }// Fim do Dezesseis

        //Exercício 17: Faça um programa que peça ao usuário um número
        // e imprima o dobro desse número

        public int ExercícioDezessete(int num)
        {

            int resultado = 0;

            resultado = num * 2;


            return resultado;

        }//Fim do Dezessete

        //Exercício 18: Faça um programa que peça ao usuário dois números
        // e imprima a média deles.
        public double ExercícioDezoito(double num1, double num2)
        {

            double resultado = 0;

            resultado = num1 + num2 / 2;



            return resultado;

        }// Fim do Dezoito

        //Exercício 19: Faça um programa que converta a
        // temperatura de Celsius para Fahrenheit. A fórmula é F = C * 9/5 + 32
        public double ExercícioDezenove(double celsius)
        {

            double fahrenheit = 0;

            fahrenheit = celsius * 9 / 5 + 32;

            return fahrenheit;

        }// Fim do Dezenove

        //Exercício 20: Faça um programa que peça o raio de um círculo e imprima a área.
        // A fórmula é A = pi * raio^2.
        public double ExercícioVinte(double raio) 
        { 
        
            return Math.PI* Math.Pow(raio, 2);
        
        }//Fim do Vinte

        //ExercícioVinteUm 21: Faça um programa que peça um número e imprima o seu quadrado
        public double ExercícioVinteUm (double num) 
        { 
        
            return num * 2;
  
        
        
        }//Fim do Vinte e Um

        //Exercício 22: Faça um programa que peça dois números e imprima o maior deles.
        public int ExercícioVinteDois(int nun1, int nun2) 
        {

            if (nun1 > nun2)
            {

                return nun1;


            }
            else 
            {

                return nun2;
            
            }// Fim do If
        
        
        
        }//Fim do Vinte e Dois

        //Exercício 23: Faça um programa que peça dois números e imprima "São Iguais" se
        //os números forem iguais ou
        //imprima "São diferentes" se forem diferentes.
        public string ExercícioVinteTres(int primeiro, int segundo) 
        {

            

            if (primeiro == segundo)
            {

                return "São Iguais";


            }
            else
            {

                return "São Diferentes";

            }// Fim do If

        }//Fim do For

        //Exercício 24: Faça um programa que peça a idade do usuário e
        //Imprima se ele é maior de idade ou menor de idade.
        public string ExercícioVinteQuatro(int maior) 
        {

            if (maior > 18)
            {

                return "Maior de Idade";


            }
            else
            {

                return "Menor de Idade";

            }// Fim do If


        }// Fim do Vinte Quatro

        //Exercício 25: Faça um programa que peça dois números e imprima o menor deles.
        public int ExercícioVinteCinco(int nus1, int nus2) 
        {
            


            if (nus1 < nus2)
            {

                return nus1;


            }
            else
            {

                return nus2;

            }// Fim do If

        }// Fim do Vinte e Cinco

        //Exercício 26: Faça um programa que peça a altura e o peso de uma pessoa e
        //calcula o IMC(indíce de massa corporal). A fórmula é IMC = peso / altura^2.
        public double ExercícioVinteSeis(double altura, double peso) 
        {

            return peso / Math.Pow(altura , 2);

        }// Fim do Vinte Seis

        //Exercício 27: Faça um algoritmo que leia a idade de uma pessoa expressa em anos
        //meses e dias e escreva a idade dessa pessoa expressa em dias
        //Considerar ano com 365 dias e mês com 30 dias.
        public int ExercícioVinteSete(int ano, int ide, int mes) 
        {

            return (ano * 365) + (mes * 30) + ide;

        
        }// Fim do Vinte Sete

        //Exercício 28:  Ler o salário fixo e o valor das vendas efetuadas pelo
        //vendedor de uma empresa.Sabendo-se que ele recebe uma
        //comissão de 3% sobre o total das vendas até R$ 1.500,00
        //mais 5% sobre o que ultrapassar este valor, calcular e
        //escrever o seu salário total
        public double ExercícioVinteOito( double salario, double vendas) 
        {

            double comissao = 0;
            

            if (vendas <= 1500)
            {

                return comissao = (vendas * 0.03) + vendas;

            }
            else if (salario > 1500)
            {

                return comissao = salario + (1500 * 0.03) + (1500 - vendas); 
            
            
            
            }// Fim do If


                return comissao = vendas + (salario + vendas); 
        
        }//Fim do Vinte e oito


        //Exercício 29: Ler 10 valores e escrever quantos desses valores lidos são NEGATIVOS.
        public int ExercícioVinteNove() 
        {

            int contNegativos = 0;
            int num = 0;
            

            for ( int i = 0; i < 10; i++) 
            {

                Console.WriteLine($"Digite o valor: ");
                num = Convert.ToInt32(Console.ReadLine());

                if (num < 0) 
                { 
                    contNegativos++;
                }
            }


            return contNegativos;
        
        }//Fim do Vinte Nove

        //Exercício 30: Escreva um algoritmo para ler 10 números. Todos os
        //números lidos com valor inferior a 40 devem ser somados.
        //Escreva o valor final da soma efetuada
        public int ExercícioTrinta() 
        { 
                int soma = 0;
                int num = 0;

            for (int i = 0; i < 10; i++)
            { 

                Console.WriteLine($"Digite um Valor: ");
                num = Convert.ToInt32(Console.ReadLine());

                if (num < 40) 
                {       
                      soma+= num;
                }// Fim do If
            
            }//Fim do For
        
            return soma;
        
        }// Fim do Trinta

        //Exercício 31: Escreva um algoritmo que permita a leitura das notas de
        //uma turma de 20 alunos.Calcular a média da turma.Escrever a média da turma.
        public int ExercícioTrintaUm() 
        {

            int media = 0;
            int soma = 0;
            int nota = 0;

            for (int i = 0; i <= 20; i++) 
            {

                Console.WriteLine($"Digite um Valor: ");
                nota = Convert.ToInt32(Console.ReadLine());

                soma += nota;
            
           
            }//Fim do For

                media = soma / 20;


                return media;

        }//Fim do Trinta e Um

        //Exercício 32: Faça um algoritmo que calcule a quantidade de litros de
        //combustível gasta em uma viagem, utilizando um automóvel
        //que faz 12Km por litro.Para obter o cálculo, o usuário deve
        //fornecer o tempo gasto na viagem e a velocidade média
        //durante ela.Desta forma, será possível obter a distância
        //percorrida com a fórmula DISTANCIA = TEMPO * VELOCIDADE.
        //Tendo o valor da distância, basta calcular a quantidade de
        //litros de combustível utilizada na viagem com a fórmula:
        //LITROS_USADOS = DISTANCIA / 12.O programa deve
        //apresentar os valores da velocidade média, tempo gasto na
        //viagem, a distância percorrida e a quantidade de litros
        //utilizada na viagem
        public string ExercícioTrintaDois(int tempo, int velocidade) 
        {

            int litrosUsados = 0;
            int distancia = 0;


            distancia = tempo * velocidade;

            litrosUsados = distancia / 12;


            return "O tempo gasto na viagem foi: " + tempo + "a distancia percorrida foi:" + distancia + "A quantidade de litros ultilizada foi: " + litrosUsados;

        }//Fim do Trinta e Dois

        //Exercício 33: Escreva um algoritmo para ler as dimensões de um retângulo (base e
        //altura), calcular e escrever a área do retângulo
        public int ExercícioTrintaTres(int valorBaseRetangulo, int valorAlturaRetangulo) 
        {

            int area = 0;
        
            area = valorAlturaRetangulo * valorBaseRetangulo;


            return area;
        
        }//Fim do Trinta e Tres

        //Exercício 34: Escreva um algoritmo para ler o número total de eleitores de um
        //município, o número de votos brancos, nulos e válidos.Calcular e
        //escrever o percentual que cada um representa em relação ao total de eleitores
        public int ExercícioTrintaQuatro() 
        { 
        
            
        
        
        
        
        
        
        
        
        }







    }//Fim da Classe




}//Fim do Projeto