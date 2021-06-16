using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMC
{
    class LRU
    {
        int numBloco, usado;

        public LRU(int n, int u)
        {
            NumBloco = n;
            Usado = u;
        }

        public Bloco[] substitui(Bloco[] b, Bloco novoValores)
        {
            LRU maiorUsado = descobreMaiorUsado(b); // descobre o menor valor do bloco
            for (int i = 0; i < b.Length; i++) // percorre todos os blocos do conjunto procurando pelo menor bloco descoberto
            {
                if (b[i].Num == maiorUsado.NumBloco) // se o bloco[i] for igual ao bloco que está a mais tempo sem ser usado
                {
                    b[i] = novoValores; // troca b[i] pelo novo valor
                    break;
                }
            }
            MessageBox.Show("O bloco " + maiorUsado.numBloco + " foi substituido pelo bloco " + novoValores.Num + 
            "\nBloco " + maiorUsado.numBloco + ": " + maiorUsado.Usado + "s >>> Bloco " + novoValores.Num + ": " + novoValores.Usado + "s", 
            "LRU", MessageBoxButtons.OK, MessageBoxIcon.Information);

            return b; // retorna o conjunto atualizado
        }

        public LRU descobreMaiorUsado(Bloco[] b)
        {
            LRU maiorUsado = new LRU(0, 0);
            int flag = 1;
            foreach (var item in b)
            {
                // marca a primeira entrada como o menor 
                // e depois trava o if
                if (flag == 1)
                {
                    maiorUsado.NumBloco = item.Num;
                    maiorUsado.Usado = item.Usado;
                    flag = 0;
                }

                // pega o bloco que tem o menor tempo de uso na MC
                // e depois passa para a variavel auxiliar
                if (item.Usado < maiorUsado.Usado)
                {
                    maiorUsado.NumBloco = item.Num;
                    maiorUsado.Usado = item.Usado;
                }
            }

            return maiorUsado;
        }

        public int NumBloco { get => numBloco; set => numBloco = value; }
        public int Usado { get => usado; set => usado = value; }
    }
}
