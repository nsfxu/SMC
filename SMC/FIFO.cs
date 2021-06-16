using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMC
{
    class FIFO
    {
        int numBloco, ordChegada;

        public FIFO(int n, int o)
        {
            NumBloco = n;
            OrdChegada = 0;
        }

        public Bloco[] substitui(Bloco[] b, Bloco novoValores)
        {
            FIFO menorOrd = descobreMenor(b); // descobre o menor valor do bloco
            for (int i = 0; i < b.Length; i++) // percorre todos os blocos do conjunto procurando pelo menor bloco descoberto
            {
                if (b[i].Num == menorOrd.NumBloco) // se o bloco[i] for igual ao menor bloco descoberto
                {
                    b[i] = novoValores; // troca b[i] pelo novo valor
                    break;
                }
            }
            
            MessageBox.Show("O bloco " + menorOrd.numBloco + " foi substituido pelo bloco " + novoValores.Num +
                "\nBloco: " + menorOrd.NumBloco + ": " + menorOrd.OrdChegada + " >>> Bloco " + novoValores.Num + ": " + novoValores.OrdChegada, "FIFO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            return b; // retorna o conjunto atualizado
        }

        public FIFO descobreMenor(Bloco[] b)
        {
            FIFO menorOrd = new FIFO(0, 0);
            int flag = 1;
            foreach (var item in b)
            {
                // marca a primeira entrada como o menor 
                // e depois trava o if
                if (flag == 1)
                {
                    menorOrd.NumBloco = item.Num;
                    menorOrd.OrdChegada = item.OrdChegada;
                    flag = 0;
                }

                if (item.OrdChegada < menorOrd.OrdChegada)
                {
                    menorOrd.NumBloco = item.Num;
                    menorOrd.OrdChegada = item.OrdChegada;
                }
            }

            return menorOrd;
        }

        public int NumBloco { get => numBloco; set => numBloco = value; }
        public int OrdChegada { get => ordChegada; set => ordChegada = value; }
    }
}
