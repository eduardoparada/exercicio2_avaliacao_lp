using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio2_avaliacao_lp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2 – Fazer um programa para que mostre uma lista de cidades para o usuário e que ele informe
            //o código da cidade escolhida. Em seguida pedir uma data para o usuário.
            //Ao final deve ser apresentada em tela a data completa em formato extenso longo, juntamente
            //com a cidade escolhida. 
            //Exemplo: Bragança Paulista, 29 de junho de 2022.
            //A relação das cidades é a seguinte: 1 – Atibaia || 2 – Bragança Paulista || 3 – Mairiporã
            //4 – Nazaré || 5 – Terra Preta  || 6 – Extrema || 7 – Vargem
            //Requisitos: Criar uma função para converter a data em extenso.

            string cidade = null, dataextenso;
            int dia, mes, ano, cod_cidade;
            Console.WriteLine("1 – Atibaia\n2 – Bragança Paulista \n3 – Mairiporã  \n4 – Nazaré \n5 – Terra Preta \n6 – Extrema \n7 – Vargem\n");
            Console.WriteLine("Escolha a cidade informando o numero: ");
            cod_cidade = int.Parse(Console.ReadLine());
            Console.WriteLine("Escreva uma data no formato (DD/MM/AAAA)");
            var data = Convert.ToDateTime(Console.ReadLine());

            dia = data.Day;
            mes = data.Month;
            ano = data.Year;

            switch (cod_cidade)
            {
                case 1:
                    cidade = ("Atibaia");
                    break;
                case 2:
                    cidade = "Bragança Paulista";
                    break;
                case 3:
                    cidade = "Mairiporã";
                    break;
                case 4:
                    cidade = "Nazaré";
                    break;
                case 5:
                    cidade = "Terra Preta";
                    break;
                case 6:
                    cidade = "Extrema";
                    break;
                case 7:
                    cidade = "Vargem";
                    break;
            }
           
            dataextenso = datafull(mes);
            Console.Write('\n');
            Console.WriteLine(cidade + " , " + dia + " de " + dataextenso + " de " + ano + ".");

            Console.ReadKey();
        }

        public static string datafull(int mes) // função para converter data int em data string 

            {
                string mestexto;

                switch (mes)
                {
                    case 1:
                        mestexto = "janeiro";
                        break;
                    case 2:
                        mestexto = "fevereiro";
                        break;
                    case 3:
                        mestexto = "março";
                        break;
                    case 4:
                        mestexto = "abril";
                        break;
                    case 5:
                        mestexto = "maio";
                        break;
                    case 6:
                        mestexto = "junho";
                        break;
                    case 7:
                        mestexto = "julho";
                        break;
                    case 8:
                        mestexto = "agosto";
                        break;
                    case 9:
                        mestexto = "setembro";
                        break;
                    case 10:
                        mestexto = "setembro";
                        break;
                    case 11:
                        mestexto = "setembro";
                        break;
                    case 12:
                        mestexto = "setembro";
                        break;
                    default:
                        mestexto = "error";
                        break;
                }
            string mesextenso = mestexto;
            return mesextenso;
                
            }
    }
}
            