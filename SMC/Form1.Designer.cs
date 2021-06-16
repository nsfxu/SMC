namespace SMC
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbxMC = new System.Windows.Forms.GroupBox();
            this.btnIniciarMC = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtqtdelinhas = new System.Windows.Forms.TextBox();
            this.gbxOpcoes = new System.Windows.Forms.GroupBox();
            this.btnInserirManual = new System.Windows.Forms.Button();
            this.cbxalgoritmos = new System.Windows.Forms.ComboBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbxMC = new System.Windows.Forms.ListBox();
            this.lbxMP = new System.Windows.Forms.ListBox();
            this.gbxMP = new System.Windows.Forms.GroupBox();
            this.btnIniciaMP = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTamBloco = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTamMP = new System.Windows.Forms.TextBox();
            this.gbxMC.SuspendLayout();
            this.gbxOpcoes.SuspendLayout();
            this.gbxMP.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxMC
            // 
            this.gbxMC.Controls.Add(this.btnIniciarMC);
            this.gbxMC.Controls.Add(this.label2);
            this.gbxMC.Controls.Add(this.txtN);
            this.gbxMC.Controls.Add(this.label1);
            this.gbxMC.Controls.Add(this.txtqtdelinhas);
            this.gbxMC.Location = new System.Drawing.Point(12, 12);
            this.gbxMC.Name = "gbxMC";
            this.gbxMC.Size = new System.Drawing.Size(151, 164);
            this.gbxMC.TabIndex = 0;
            this.gbxMC.TabStop = false;
            this.gbxMC.Text = "Memória Cache";
            // 
            // btnIniciarMC
            // 
            this.btnIniciarMC.Location = new System.Drawing.Point(33, 122);
            this.btnIniciarMC.Name = "btnIniciarMC";
            this.btnIniciarMC.Size = new System.Drawing.Size(75, 23);
            this.btnIniciarMC.TabIndex = 4;
            this.btnIniciarMC.Text = "Iniciar MC";
            this.btnIniciarMC.UseVisualStyleBackColor = true;
            this.btnIniciarMC.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Valor de N";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(19, 86);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(110, 20);
            this.txtN.TabIndex = 2;
            this.txtN.Text = "4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Qtde. de Linhas";
            // 
            // txtqtdelinhas
            // 
            this.txtqtdelinhas.Location = new System.Drawing.Point(19, 45);
            this.txtqtdelinhas.Name = "txtqtdelinhas";
            this.txtqtdelinhas.Size = new System.Drawing.Size(110, 20);
            this.txtqtdelinhas.TabIndex = 0;
            this.txtqtdelinhas.Text = "32";
            // 
            // gbxOpcoes
            // 
            this.gbxOpcoes.Controls.Add(this.btnInserirManual);
            this.gbxOpcoes.Controls.Add(this.cbxalgoritmos);
            this.gbxOpcoes.Controls.Add(this.btnInserir);
            this.gbxOpcoes.Controls.Add(this.label4);
            this.gbxOpcoes.Enabled = false;
            this.gbxOpcoes.Location = new System.Drawing.Point(12, 352);
            this.gbxOpcoes.Name = "gbxOpcoes";
            this.gbxOpcoes.Size = new System.Drawing.Size(151, 132);
            this.gbxOpcoes.TabIndex = 1;
            this.gbxOpcoes.TabStop = false;
            this.gbxOpcoes.Text = "Opções";
            // 
            // btnInserirManual
            // 
            this.btnInserirManual.Location = new System.Drawing.Point(19, 100);
            this.btnInserirManual.Name = "btnInserirManual";
            this.btnInserirManual.Size = new System.Drawing.Size(110, 26);
            this.btnInserirManual.TabIndex = 6;
            this.btnInserirManual.Text = "Inserir (MANUAL)";
            this.btnInserirManual.UseVisualStyleBackColor = true;
            this.btnInserirManual.Click += new System.EventHandler(this.btnInserirManual_Click);
            // 
            // cbxalgoritmos
            // 
            this.cbxalgoritmos.FormattingEnabled = true;
            this.cbxalgoritmos.Items.AddRange(new object[] {
            "FIFO",
            "LRU",
            "LFU"});
            this.cbxalgoritmos.Location = new System.Drawing.Point(19, 44);
            this.cbxalgoritmos.Name = "cbxalgoritmos";
            this.cbxalgoritmos.Size = new System.Drawing.Size(110, 21);
            this.cbxalgoritmos.TabIndex = 5;
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(19, 71);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(110, 26);
            this.btnInserir.TabIndex = 4;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Algoritmos de Subst.";
            // 
            // lbxMC
            // 
            this.lbxMC.FormattingEnabled = true;
            this.lbxMC.Location = new System.Drawing.Point(505, 23);
            this.lbxMC.Name = "lbxMC";
            this.lbxMC.Size = new System.Drawing.Size(294, 459);
            this.lbxMC.TabIndex = 2;
            // 
            // lbxMP
            // 
            this.lbxMP.FormattingEnabled = true;
            this.lbxMP.Location = new System.Drawing.Point(182, 23);
            this.lbxMP.Name = "lbxMP";
            this.lbxMP.Size = new System.Drawing.Size(294, 459);
            this.lbxMP.TabIndex = 3;
            // 
            // gbxMP
            // 
            this.gbxMP.Controls.Add(this.btnIniciaMP);
            this.gbxMP.Controls.Add(this.label3);
            this.gbxMP.Controls.Add(this.txtTamBloco);
            this.gbxMP.Controls.Add(this.label5);
            this.gbxMP.Controls.Add(this.txtTamMP);
            this.gbxMP.Enabled = false;
            this.gbxMP.Location = new System.Drawing.Point(12, 182);
            this.gbxMP.Name = "gbxMP";
            this.gbxMP.Size = new System.Drawing.Size(151, 164);
            this.gbxMP.TabIndex = 5;
            this.gbxMP.TabStop = false;
            this.gbxMP.Text = "Memória Principal";
            // 
            // btnIniciaMP
            // 
            this.btnIniciaMP.Location = new System.Drawing.Point(33, 122);
            this.btnIniciaMP.Name = "btnIniciaMP";
            this.btnIniciaMP.Size = new System.Drawing.Size(75, 23);
            this.btnIniciaMP.TabIndex = 4;
            this.btnIniciaMP.Text = "Iniciar MP";
            this.btnIniciaMP.UseVisualStyleBackColor = true;
            this.btnIniciaMP.Click += new System.EventHandler(this.btnIniciaMP_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tam. do Bloco (bytes)";
            // 
            // txtTamBloco
            // 
            this.txtTamBloco.Location = new System.Drawing.Point(19, 86);
            this.txtTamBloco.Name = "txtTamBloco";
            this.txtTamBloco.Size = new System.Drawing.Size(110, 20);
            this.txtTamBloco.TabIndex = 2;
            this.txtTamBloco.Text = "32";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tam. da MP (bytes)";
            // 
            // txtTamMP
            // 
            this.txtTamMP.Location = new System.Drawing.Point(19, 45);
            this.txtTamMP.Name = "txtTamMP";
            this.txtTamMP.Size = new System.Drawing.Size(110, 20);
            this.txtTamMP.TabIndex = 0;
            this.txtTamMP.Text = "2048";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 498);
            this.Controls.Add(this.gbxMP);
            this.Controls.Add(this.lbxMP);
            this.Controls.Add(this.lbxMC);
            this.Controls.Add(this.gbxOpcoes);
            this.Controls.Add(this.gbxMC);
            this.Name = "Form1";
            this.Text = "SMC";
            this.gbxMC.ResumeLayout(false);
            this.gbxMC.PerformLayout();
            this.gbxOpcoes.ResumeLayout(false);
            this.gbxOpcoes.PerformLayout();
            this.gbxMP.ResumeLayout(false);
            this.gbxMP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxMC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtqtdelinhas;
        private System.Windows.Forms.Button btnIniciarMC;
        private System.Windows.Forms.GroupBox gbxOpcoes;
        private System.Windows.Forms.ComboBox cbxalgoritmos;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbxMC;
        private System.Windows.Forms.ListBox lbxMP;
        private System.Windows.Forms.GroupBox gbxMP;
        private System.Windows.Forms.Button btnIniciaMP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTamBloco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTamMP;
        private System.Windows.Forms.Button btnInserirManual;
    }
}

