using System;

namespace Tupiniquim.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite as coordenadas do canto superior direito (Separados por espaço: ex.: 0 0): ");
            var coordenadasSuperiorDireito = Console.ReadLine();
            char[] listaSuperiorDireito = coordenadasSuperiorDireito.ToCharArray();
            while (listaSuperiorDireito.Length != 3)
            {
                Console.WriteLine("O formato inserido é inválido");
                Console.WriteLine("Digite novamente as coordenadas do canto superior direito (Separados por espaço: ex.: 0 0): ");
                coordenadasSuperiorDireito = Console.ReadLine();
                listaSuperiorDireito = coordenadasSuperiorDireito.ToCharArray();
            }

            var limiteDeX1 = listaSuperiorDireito[0];
            var limiteDeY1 = listaSuperiorDireito[2];

            Console.WriteLine("Digite a posição inicial do Robô 1 (Coordenada X + Y + Direção (N, S, L, O) separados por espaço. ex.: 0 0 N): ");
            var posicaoInicial = Console.ReadLine().ToUpper(); 
            char[] instrucoesPosicaoInicial = posicaoInicial.ToCharArray();

            while (instrucoesPosicaoInicial.Length != 5)
            {
                Console.WriteLine("O formato inserido é inválido");
                Console.WriteLine("Digite novamente a posição inicial do Robô 1 (Coordenada X + Y + Direção (N, S, L, O) separados por espaço. ex.: 0 0 N): ");
                posicaoInicial = Console.ReadLine().ToUpper();
                instrucoesPosicaoInicial = posicaoInicial.ToCharArray();
            }

            var x1 = Convert.ToInt32(instrucoesPosicaoInicial[0].ToString());
            var y1 = Convert.ToInt32(instrucoesPosicaoInicial[2].ToString());
            var bussola1 = instrucoesPosicaoInicial[4].ToString().ToUpper();

            Console.WriteLine("Digite as instruções para o primeiro robô: ");
            var instrucoesRobo1 = Console.ReadLine().ToUpper();            
            char[] listaInstrucoesRobo1 = instrucoesRobo1.ToCharArray();            

            for (int i = 0; i < listaInstrucoesRobo1.Length; i++)
            {
                var instrucao = listaInstrucoesRobo1[i];
                if (instrucao != 'M' && instrucao != 'D' && instrucao != 'E')
                {
                    Console.WriteLine("Instrução inválida");
                }

                if (instrucao == 'M')
                {
                    if (bussola1 == "L")
                    {
                        x1++;
                    }
                    else if (bussola1 == "N")
                    {
                        y1++;
                    }
                    else if (bussola1 == "O")
                    {
                        x1--;
                    }
                    else if (bussola1 == "S")
                    {
                        y1--;
                    }

                }
                else if (instrucao == 'D')
                {
                    if (bussola1 == "N")
                    {
                        bussola1 = "L";
                    }
                    else if (bussola1 == "L")
                    {
                        bussola1 = "S";
                    }
                    else if (bussola1 == "S")
                    {
                        bussola1 = "O";
                    }
                    else if (bussola1 == "O")
                    {
                        bussola1 = "N";
                    }
                }
                else if (instrucao == 'E')
                {
                    if (bussola1 == "N")
                    {
                        bussola1 = "O";
                    }
                    else if (bussola1 == "O")
                    {
                        bussola1 = "S";
                    }
                    else if (bussola1 == "S")
                    {
                        bussola1 = "L";
                    }
                    else if (bussola1 == "L")
                    {
                        bussola1 = "N";
                    }
                }
            }
            Console.WriteLine("Digite a posição inicial do Robô 2 (Coordenada X + Y + Direção (N, S, L, O) separados por espaço. ex.: 0 0 N): ");
            var posicaoInicial2 = Console.ReadLine().ToUpper();
            char[] instrucoesPosicaoInicial2 = posicaoInicial2.ToCharArray();

            while (instrucoesPosicaoInicial2.Length != 5)
            {
                Console.WriteLine("O formato inserido é inválido");
                Console.WriteLine("Digite novamente a posição inicial do Robô 2 (Coordenada X + Y + Direção (N, S, L, O) separados por espaço. ex.: 0 0 N): ");
                posicaoInicial2 = Console.ReadLine().ToUpper();
                instrucoesPosicaoInicial2 = posicaoInicial2.ToCharArray();
            }

            var x2 = Convert.ToInt32(instrucoesPosicaoInicial2[0].ToString());
            var y2 = Convert.ToInt32(instrucoesPosicaoInicial2[2].ToString());
            var bussola2 = instrucoesPosicaoInicial2[4].ToString();

            Console.WriteLine("Digite as instruções para o segundo robô: ");
            var instrucoesRobo2 = Console.ReadLine().ToUpper();
            char[] listaInstrucoesRobo2 = instrucoesRobo2.ToCharArray();

            for (int index = 0; index < listaInstrucoesRobo2.Length; index++)
            {
                var instrucao2 = listaInstrucoesRobo2[index];                
                if (instrucao2 != 'M' && instrucao2 != 'D' && instrucao2 != 'E')
                {
                    Console.WriteLine("Instrução inválida");
                }
                if (instrucao2 == 'M')
                {
                    if (bussola2 == "L")
                    {
                        x2++;
                    }
                    else if (bussola2 == "N")
                    {
                        y2++;
                    }
                    else if (bussola2 == "O")
                    {
                        x2--;
                    }
                    else if (bussola2 == "S")
                    {
                        y2--;
                    }

                }
                else if (instrucao2 == 'D')
                {
                    if (bussola2 == "N")
                    {
                        bussola2 = "L";
                    }
                    else if (bussola2 == "L")
                    {
                        bussola2 = "S";
                    }
                    else if (bussola2 == "S")
                    {
                        bussola2 = "O";
                    }
                    else if (bussola2 == "O")
                    {
                        bussola2 = "N";
                    }
                }
                else if (instrucao2 == 'E')
                {
                    if (bussola2 == "N")
                    {
                        bussola2 = "O";
                    }
                    else if (bussola2 == "O")
                    {
                        bussola2 = "S";
                    }
                    else if (bussola2 == "S")
                    {
                        bussola2 = "L";
                    }
                    else if (bussola2 == "L")
                    {
                        bussola2 = "N";
                    }
                }
            }
            Console.WriteLine($"{x1} {y1} {bussola1}");
            Console.WriteLine($"{x2} {y2} {bussola2}");
            Console.ReadLine();
        }
    }
}