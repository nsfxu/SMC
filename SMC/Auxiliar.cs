using System.Collections.Generic;
using System.Windows.Forms; // message box
using System;


namespace SMC
{
    internal class AUX
    {
        /*
         * ================================================
         * List<MC> m, -> Memória Cache
         * Bloco novoBloco, -> O bloco que vai ser inserido
         * int aSubst, -> O método de substituição
         * int pos, -> O número do conjunto
         * int N -> Quantidade de conjuntos
         * ================================================
         */

        public List<MC> insert(List<MC> m, Bloco novoBloco, int aSubst, int pos, int N)
        {
            MC aux = null;
            bool editando = false;
            int index = m.FindIndex(x => x.Num == pos); // descobre a posição do conjunto que está na {List<MC> m}          

            if (m.Find(x => x.Num == pos) == null) // se o conjunto está vazio então...
                aux = new MC(pos, new Bloco[N]); // passa para um auxiliar
            else
            {
                if (isExistente(m, novoBloco.Num, pos)) // se o bloco já existe no conjunto
                    return atualizaExistente(m, novoBloco.Num, pos, index); // retorna ele com os valores atualizados                

                editando = true;   // significa que vamos editar um conjunto             
                aux = m.Find(x => x.Num == pos); // passa ela para um auxiliar                
            }

            if (isCheio(aux.Bloco)) // se estiver cheia então usamos um algoritmo definido pelo o usuario
            {
                switch (aSubst)
                {
                    // FIFO
                    case 1:
                        FIFO f = new FIFO(0, 0);
                        aux.Bloco = f.substitui(aux.Bloco, novoBloco); // faz a substituição e atualiza o conjunto
                        break;
                    // LRU
                    case 2:
                        LRU l = new LRU(0, 0);
                        aux.Bloco = l.substitui(aux.Bloco, novoBloco); // faz a substituição e atualiza o conjunto
                        break;
                    // LFU
                    case 3:
                        LFU lf = new LFU(0, 0);
                        aux.Bloco = lf.substitui(aux.Bloco, novoBloco); // faz a substituição e atualiza o conjunto
                        break;

                    default:
                        break;
                }

                if (editando)
                {
                    m[index] = new MC(aux.Num, aux.Bloco); // atualiza o conjunto na posição (index)
                    return m;
                }
            }

            for (int i = 0; i < aux.Bloco.Length; i++) // percorre o conjunto até achar um lugar vazio
            {
                if (aux.Bloco[i] == null)
                {
                    aux.Bloco[i] = novoBloco; // Insere no lugar vázio o novo bloco
                    break;
                }
            }

            if (editando)
            {
                // se não usar o index, a função simplesmente duplica o conjunto...
                // index -> a POSIÇÃO do conjunto que queremos atualizar
                m[index] = new MC(aux.Num, aux.Bloco); // atualiza o conjunto na posição (index)
                return m;
            }

            m.Add(aux); // Adiciona o novo conjunto para a MC
            return m;
        }
        public bool isCheio(Bloco[] b)
        {
            int count = 0;
            for (int i = 0; i < b.Length; i++)
                if (b[i] != null)
                    count++;

            if (count == b.Length)
                return true;
            else
                return false;
        }
        public List<MC> atualizaExistente(List<MC> m, int numBloco, int pos, int index)
        {
            MC aux = m.Find(x => x.Num == pos); // auxiliar recebe os valores conjunto da posição "pos"
            
            foreach (var bloco in aux.Bloco)
            {
                if (bloco != null && bloco.Num == numBloco)
                {
                    bloco.QtdeAcessos += 1; // aumenta a qtde de acessos
                    bloco.Usado = int.Parse(DateTime.Now.ToString("HHmmss")); // atualiza a ultima vez q foi usado
                    break;
                }
            }
            
            m[index] = new MC(aux.Num, aux.Bloco);

            return m;
        }
        public bool isExistente(List<MC> m, int numBloco, int pos)
        {
            MC aux = m.Find(x => x.Num == pos); // auxiliar recebe os valores conjunto da posição "pos"

            foreach (var bloco in aux.Bloco)
                if (bloco != null && bloco.Num == numBloco)
                    return true;

            return false;
        }
    }
}