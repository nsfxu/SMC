using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMC
{
    class MC
    {
        /*          
         nome -> nome do bloco
         usado -> ultima vez usado (milisegundos)
         ordChegada -> Ordem de chegada
         qtdeAcessos -> Quantidade de Acessos          
        */

        int num; // pos do bloco
        Bloco[] bloco;

        public MC(int n, Bloco[] b)
        {
            Num = n;
            Bloco = b;
        }

        public int Num { get => num; set => num = value; }
        internal Bloco[] Bloco { get => bloco; set => bloco = value; }
    }
}
