using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMC
{
    class LFU
    {
        int numBloco, qtdeAcessos;
        public LFU(int n, int qtde)
        {
            NumBloco = n;
            QtdeAcessos = qtde;
        }

        public Bloco[] substitui(Bloco[] b, Bloco novoValores)
        {
            LFU menosAcessado = descobreMenosAcessado(b); // descobre o menor valor do bloco
            for (int i = 0; i < b.Length; i++) // percorre todos os blocos do conjunto procurando pelo menor bloco descoberto
            {
                if (b[i].Num == menosAcessado.NumBloco) // se o bloco[i] for igual ao menor bloco descoberto
                {
                    b[i] = novoValores; // troca b[i] pelo novo valor
                    break;
                }
            }

            MessageBox.Show("O bloco " + menosAcessado.NumBloco + " foi substituido pelo bloco " + novoValores.Num +
            "\nBloco " + menosAcessado.NumBloco + ": " + menosAcessado.QtdeAcessos + " >>> Bloco " + novoValores.Num + ": " + novoValores.QtdeAcessos, 
            "LFU", MessageBoxButtons.OK, MessageBoxIcon.Information);

            return b; // retorna o conjunto atualizado
        }

        public LFU descobreMenosAcessado(Bloco[] b)
        {
            LFU menosAcessado = new LFU(0, 0);
            int flag = 1;
            foreach (var item in b)
            {
                // marca a primeira entrada como o menor 
                // e depois trava o if
                if (flag == 1)
                {
                    menosAcessado.NumBloco = item.Num;
                    menosAcessado.QtdeAcessos = item.QtdeAcessos;
                    flag = 0;
                }

                // pega o bloco que tem a menor qtde de acessos
                // e depois passa para a variavel auxiliar
                if (item.QtdeAcessos < menosAcessado.QtdeAcessos)
                {
                    menosAcessado.NumBloco = item.Num;
                    menosAcessado.QtdeAcessos = item.QtdeAcessos;
                }
            }

            return menosAcessado;
        }

        public int NumBloco { get => numBloco; set => numBloco = value; }
        public int QtdeAcessos { get => qtdeAcessos; set => qtdeAcessos = value; }
    }
}
