using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMC
{
    class Bloco
    {
        /*          
        nome -> nome do bloco
        usado -> ultima vez usado (milisegundos)
        ordChegada -> Ordem de chegada
        qtdeAcessos -> Quantidade de Acessos          
       */

        int num, usado, ordChegada, qtdeAcessos;

        public Bloco(int n, int u, int o, int qtde)
        {
            Num = n;
            Usado = u;
            OrdChegada = o;
            QtdeAcessos = qtde;
        }

        public string imprime()
        {
            return "Nome do bloco: Bloco " + Num + "\n Última vez usado: " + Usado + "\n Ordem de chegada: " + OrdChegada + "\n Quantidade de acessos: " + QtdeAcessos;
        }

        public int Usado { get => usado; set => usado = value; }
        public int OrdChegada { get => ordChegada; set => ordChegada = value; }
        public int QtdeAcessos { get => qtdeAcessos; set => qtdeAcessos = value; }
        public int Num { get => num; set => num = value; }
    }
}
