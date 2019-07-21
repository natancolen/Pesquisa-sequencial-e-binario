using System;

namespace Pesquisa_Sequencial_e_Binaria
{
    class Program
    {
        /// <summary>
        /// Metodo que cria um vetor de tamanho N e embaralha os valores
        /// </summary>
        /// <param name="tam">Tamanho do vetor</param>
        /// <returns>Retorna o Vetor</returns>
        static int[] CriarVetor(int tam)
        {
            int[] aux = new int[tam];

            for (int i = 0; i < aux.Length; i++)
                aux[i] = (i + 1);
            return aux;
        }

        /// <summary>
        /// Metodo oara imprimir um vetor em ordem posicional
        /// </summary>
        /// <param name="vet">O vetor que deve ser impresso</param>
        static void ImprimirVetor(int[] vet)
        {
            for (int i = 0; i < vet.Length; i++)
                Console.Write("{0} ", vet[i]);
        }

        /// <summary>
        /// Pesquisa sequencial de vetor
        /// </summary>
        /// <param name="vetp">Vetor onde sera colocado os valores numericos</param>
        /// <param name="val">Valor que sera colocado em vetor</param>
        /// <returns></returns>
        static int PesquisaSequencial(int[] vetp, int val)
        {
            for (int i = 0; i < vetp.Length; i++)
                if (vetp[i] == val)
                {
                    Console.Write("\nO numero a ser buscado se encontra na posiçao: " + i);
                    return i;
                }
            return -1;
        }

        /// <summary>
        /// Pesquisa Binaria
        /// </summary>
        /// <param name="vet">Vetor que seram colocados numero</param>
        /// <param name="ini">Inicio posição Inicial do vetor</param>
        /// <param name="fim">Fim posicção Final do Vetor</param>
        /// <param name="val">Valor que sera colocado em cada vetor</param>
        /// <returns></returns>
        static int PesquisaBinaria(int[] vet, int ini, int fim, int val)
        {
            if (ini > fim) return -1;
            else
            {
                int meio = (ini + fim) / 2;
                if (vet[meio] == val)
                {
                    Console.Write("\nO numero a ser buscado se encontra na posiçao: " + meio);
                    return meio;
                }
                else
                {
                    if (val > vet[meio])
                    {
                        return PesquisaBinaria(vet, (meio + 1), fim, val);
                    }
                    else
                    {
                        return PesquisaBinaria(vet, ini, (meio - 1), val);
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Digite o tamanho do vetor: ");
            int tamanho = int.Parse(Console.ReadLine());

            int[] vetor = CriarVetor(tamanho);

            ImprimirVetor(vetor);

            Console.Write("\n\nDigite o numero a ser buscado: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("\n\n-Pesquisa sequencial-");
            int busca = PesquisaSequencial(vetor, numero);

            Console.WriteLine("\n\n-Pesquisa binaria-");
            busca = PesquisaBinaria(vetor, 0, tamanho, numero);

            Console.ReadKey();
        }
    }
}
