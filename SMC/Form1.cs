using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SMC
{
    public partial class Form1 : Form
    {
        public int N, qtdeLinhas, qtdeConjuntosMC, tamMP, tamBloco, qtdeConjuntosMP, ordChegada = 0;

        // Inicializando variáveis auxiliares
        // A lista tem dois campos
        // Bloco[] -> tem um array com o tamanho de N
        // int -> é o valor do conjunto

        // TODO
        // VER A AULA
        // FAZER AS LINHAS

        private List<MC> MC = new List<MC>();

        private AUX aux = new AUX();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            gbxMP.Enabled = true;

            N = int.Parse(txtN.Text);
            qtdeLinhas = int.Parse(txtqtdelinhas.Text);
            qtdeConjuntosMC = qtdeLinhas / N; // calcula a qtde de conjuntos da MC
        }

        private void btnIniciaMP_Click(object sender, EventArgs e)
        {
            gbxOpcoes.Enabled = true;

            tamMP = Convert.ToInt32(txtTamMP.Text);
            tamBloco = Convert.ToInt32(txtTamBloco.Text);

            qtdeConjuntosMP = tamMP / tamBloco; // calcula a qtde de blocos da MP

            lbxMP.Items.Add("==============================");
            for (int i = 0; i < qtdeConjuntosMP; i++) // imprime a MP
            {
                lbxMP.Items.Add("Bloco " + i);
                lbxMP.Items.Add("==============================");
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int pos = 0, num, aSubst;

            // Verifica qual algoritmo foi selecionado no formulário
            if (cbxalgoritmos.Text == "FIFO")
                aSubst = 1;
            else if (cbxalgoritmos.Text == "LRU")
                aSubst = 2;
            else if (cbxalgoritmos.Text == "LFU")
                aSubst = 3;
            else
            {
                // se nenhum algoritmo foi selecionado, então selecione o FIFO
                MessageBox.Show("Nenhum algoritmo foi selecionado! por padrão foi selecionado o FIFO", "Inserir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                aSubst = 1;
            }

            // chama interaction box para receber o valor do bloco
            num = Convert.ToInt32(Interaction.InputBox("Digite o número do Bloco", "Inserir", ""));

            // se o valor do bloco for maior ou igual a quantidade de conjuntos da MP, então não insere
            if (num >= qtdeConjuntosMP)
            {
                MessageBox.Show("O valor do bloco inserido não existe na MP!!!", "Inserir", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            pos = num % qtdeConjuntosMC; // calcula a posição a ser inserida na MC            

            // Cria um novo bloco
            // Parametros(valor do bloco, ultima vez usado, ordem de chegada, quantidade de acessos)
            Bloco novoBloco = new Bloco(num, int.Parse(DateTime.Now.ToString("HHmmss")), ordChegada++, 1);

            // Insere o bloco acima na MC usando a classe AUX
            MC = aux.insert(MC, novoBloco, aSubst, pos, N);

            atualizarMC();
        }

        private void btnInserirManual_Click(object sender, EventArgs e)
        {
            int pos, aSubst; // calculos do conjunto
            int numero, ultUsado, ordemChegada, qtdeUsado; // atributos do bloco

            // Verifica qual algoritmo foi selecionado no formulário
            if (cbxalgoritmos.Text == "FIFO")
                aSubst = 1;
            else if (cbxalgoritmos.Text == "LRU")
                aSubst = 2;
            else if (cbxalgoritmos.Text == "LFU")
                aSubst = 3;
            else
            {
                // se nenhum algoritmo foi selecionado, então selecione o FIFO
                MessageBox.Show("Nenhum algoritmo foi selecionado! por padrão foi selecionado o FIFO", "Inserir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                aSubst = 1;
            }

            // chama interaction box para receber os valores do bloco
            numero = Convert.ToInt32(Interaction.InputBox("Digite o número do Bloco", "Inserir", ""));
            ultUsado = Convert.ToInt32(Interaction.InputBox("Digite a ultima vez usada (milissegundos)", "Inserir", ""));
            ordemChegada = Convert.ToInt32(Interaction.InputBox("Digite o valor da ordem de chegada", "Inserir", ""));
            qtdeUsado = Convert.ToInt32(Interaction.InputBox("Digite a quantidade de vezes usadas", "Inserir", ""));

            // se o valor do bloco for maior ou igual a quantidade de conjuntos da MP, então não insere
            if (numero >= qtdeConjuntosMP)
            {
                MessageBox.Show("O valor do bloco inserido não existe na MP!!!", "Inserir", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            pos = numero % qtdeConjuntosMC; // calcula a posição a ser inserida na MC

            // Cria um novo bloco
            // Parametros(valor do bloco, ultima vez usado, ordem de chegada, quantidade de acessos)
            Bloco novoBloco = new Bloco(numero, ultUsado, ordemChegada, qtdeUsado);

            // Insere o bloco acima na MC usando a classe AUX
            MC = aux.insert(MC, novoBloco, aSubst, pos, N);

            atualizarMC();
        }

        private void atualizarMC()
        {
            lbxMC.Items.Clear();

            List<int> conjs = new List<int>();

            foreach (var m in MC.OrderBy(x => x.Num))
                conjs.Add(m.Num); // adiciona todos os conjuntos com valores em uma lista

            lbxMC.Items.Add("==============================");

            foreach (var m in MC.OrderBy(x => x.Num))
            {               
                lbxMC.Items.Add("Conjunto " + m.Num);
                lbxMC.Items.Add("==============================");

                foreach (var b in m.Bloco) // outro foreach que percorre os blocos do conjunto
                {
                    if (b != null)
                    {
                        lbxMC.Items.Add("Número do bloco: " + b.Num);
                        lbxMC.Items.Add("Ordem de chegada: " + b.OrdChegada);
                        lbxMC.Items.Add("Quantidade de acessos: " + b.QtdeAcessos);
                        lbxMC.Items.Add("Ultima vez usado: " + b.Usado);
                        lbxMC.Items.Add("==============================");
                    }
                }
            }

            lbxMC.Refresh();
        }
    }
}