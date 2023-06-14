using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07_listasRepeticoes
{
    internal class Program
    {
        public static List<string> usuarios = new List<string>();

        static void Main(string[] args)
        {
            List<string> nomes = new List<string>();
            nomes.Add("Stella");
            nomes.Add("William");
            nomes.Add("Luis");
            int contador = 0;
            while (nomes.Count > contador)
            {
                Console.WriteLine($"{contador + 1} - {nomes[contador]}");
                contador++;
       
            }
            Console.ReadKey();
        }
        void lista()
        {
            List<string> nomes = new List<string>();

            nomes.Add("Conrado");
            nomes.Add("Vanessa");
            nomes.Add("Roberta");


            Console.WriteLine($"A primeira posição é {nomes[0]}");
            Console.WriteLine($"A segunda posição é {nomes[1]}");
            Console.WriteLine($"A terceira posição é {nomes[2]}");


            nomes.Remove("Vanessa");

            nomes.RemoveAt(0);


            int quantidade = nomes.Count();
            Console.WriteLine($"Existem {quantidade} itens dentro da lista");

            Console.ReadKey();
        }
        void listas_e_repetições()
        {
            int[] numeros = { 1, 2, 3 };

            for (int i = 0; i < numeros.Length; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("Aperte uma tecla para ver o primeiro número ! ");
                    Console.ReadKey();
                    Console.WriteLine($"O numero da primeira posição é {numeros[0]} !!\n");
                    Console.WriteLine("\nAperte uma tecla para ver o próximo número ! ");
                    Console.ReadKey();
                }

                if (i == 1)
                {
                    Console.WriteLine($"O numero da segunda posição é {numeros[1]} ! \n");
                    Console.WriteLine("\nAperte uma tecla para ver o próximo número ! ");
                    Console.ReadKey();

                }

                if (i == 2)
                {
                    Console.WriteLine($"O numero da terceira posição é {numeros[2]} ! ");
                    Console.WriteLine("\nAperte uma tecla para mostar o primeiro nome !");
                    Console.ReadKey();

                }

            }


            string[] nomes = new string[3];

            nomes[0] = "Conrado";
            nomes[1] = "Robertinha";
            nomes[2] = "Pomba";

            for (int i = 0; i < nomes.Length; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("Aperte uma tecla para ver o primeiro nome ! ");
                    Console.ReadKey();

                    Console.WriteLine($"O nome da primeira posição é {nomes[i]}");
                }

                if (i == 1)
                {

                    Console.WriteLine($"O nome da segunda posição é {nomes[i]}");
                }

                if (i == 2)
                {
                    Console.WriteLine($"O nome da terceira posição é {nomes[i]}");
                }
                Console.WriteLine("Aperte uma tecla para ver o próximo nome ! \n");
                Console.ReadKey();
            }
            Console.WriteLine("As listas foram percorridas e o FOR foi concluido!");
            Console.ReadKey();

        }
        void exercicio_Sala_listas()
        {
            Console.WriteLine("Cadastro de usuários");
            Console.WriteLine("1 - Cadastrar");
            Console.WriteLine("2 - Buscar");
            int opcao = int.Parse(Console.ReadLine());


            if (opcao == 2)
            {
                if (usuarios.Count == 0)
                {
                    Console.WriteLine("\nAinda não há usuários cadastrados");
                    Console.ReadKey();
                    Console.Clear();
                    Main(null);
                    return;
                }
                Console.WriteLine("Digite o usuário que deseja buscar!");
                string busca = Console.ReadLine();

                if (usuarios.Contains(busca))
                {
                    Console.WriteLine($"O usuário {busca} foi localizado!");
                }
                else
                {
                    Console.WriteLine("Usuário não cadastrado");
                }
                Console.ReadKey();
                Console.Clear();
                Main(null);
                return;

            }

            if (opcao == 1)
            {
                Console.WriteLine("Digite o nome do usuário que gostaria de cadastrar!");
                usuarios.Add(Console.ReadLine());
                Console.WriteLine($"O usuàrio foi cadastado com sucesso ! ");
            }

            Console.ReadKey();
            Console.Clear();
            Main(null);
            return;
        }
        void repeticaoWhile()
        {
            //Repetições (loop)


            Console.WriteLine("--------------------------");
            Console.WriteLine("---------- for -----------");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i + 1} - Olá");
            }
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("--------------------------");
            Console.WriteLine("--------- while ----------");

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            int contador = 0;
            while (contador < 5)
            {
                Console.WriteLine($"{contador + 1} - Olá");
                contador++;
            }

            Console.ReadKey();

        }


    }
}