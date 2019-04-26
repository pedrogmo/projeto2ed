namespace apCalculadora
{
    partial class FrmCalculadora
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
            this.txtVisor = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lblSequencias = new System.Windows.Forms.Label();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnAbreParenteses = new System.Windows.Forms.Button();
            this.btnFechaParenteses = new System.Windows.Forms.Button();
            this.btnVirgula = new System.Windows.Forms.Button();
            this.btnMais = new System.Windows.Forms.Button();
            this.btnMenos = new System.Windows.Forms.Button();
            this.btnMultiplicacao = new System.Windows.Forms.Button();
            this.btnDivisao = new System.Windows.Forms.Button();
            this.btnElevado = new System.Windows.Forms.Button();
            this.btnBackspace = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtVisor
            // 
            this.txtVisor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVisor.Location = new System.Drawing.Point(2, 6);
            this.txtVisor.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtVisor.Name = "txtVisor";
            this.txtVisor.ReadOnly = true;
            this.txtVisor.Size = new System.Drawing.Size(543, 30);
            this.txtVisor.TabIndex = 12;
            // 
            // txtResultado
            // 
            this.txtResultado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResultado.Location = new System.Drawing.Point(2, 46);
            this.txtResultado.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(543, 30);
            this.txtResultado.TabIndex = 13;
            // 
            // lblSequencias
            // 
            this.lblSequencias.AutoSize = true;
            this.lblSequencias.Location = new System.Drawing.Point(16, 94);
            this.lblSequencias.Name = "lblSequencias";
            this.lblSequencias.Size = new System.Drawing.Size(75, 22);
            this.lblSequencias.TabIndex = 14;
            this.lblSequencias.Text = "Pósfixa:";
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(276, 205);
            this.btn9.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(125, 61);
            this.btn9.TabIndex = 20;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.Tudo_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(139, 205);
            this.btn8.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(125, 61);
            this.btn8.TabIndex = 18;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.Tudo_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(2, 205);
            this.btn7.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(125, 61);
            this.btn7.TabIndex = 17;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.Tudo_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(276, 276);
            this.btn6.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(125, 61);
            this.btn6.TabIndex = 24;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.Tudo_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(139, 276);
            this.btn5.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(125, 61);
            this.btn5.TabIndex = 22;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.Tudo_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(2, 276);
            this.btn4.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(125, 61);
            this.btn4.TabIndex = 21;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.Tudo_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(276, 347);
            this.btn3.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(125, 61);
            this.btn3.TabIndex = 28;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.Tudo_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(139, 347);
            this.btn2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(125, 61);
            this.btn2.TabIndex = 26;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.Tudo_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(2, 347);
            this.btn1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(125, 61);
            this.btn1.TabIndex = 25;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.Tudo_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(276, 418);
            this.btnClear.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(125, 61);
            this.btnClear.TabIndex = 32;
            this.btnClear.Text = "c";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.Location = new System.Drawing.Point(139, 418);
            this.btnIgual.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(125, 61);
            this.btnIgual.TabIndex = 30;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = true;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(2, 418);
            this.btn0.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(125, 61);
            this.btn0.TabIndex = 29;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.Tudo_Click);
            // 
            // btnAbreParenteses
            // 
            this.btnAbreParenteses.Location = new System.Drawing.Point(413, 418);
            this.btnAbreParenteses.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnAbreParenteses.Name = "btnAbreParenteses";
            this.btnAbreParenteses.Size = new System.Drawing.Size(125, 61);
            this.btnAbreParenteses.TabIndex = 31;
            this.btnAbreParenteses.Text = "(";
            this.btnAbreParenteses.UseVisualStyleBackColor = true;
            this.btnAbreParenteses.Click += new System.EventHandler(this.Tudo_Click);
            // 
            // btnFechaParenteses
            // 
            this.btnFechaParenteses.Location = new System.Drawing.Point(413, 347);
            this.btnFechaParenteses.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnFechaParenteses.Name = "btnFechaParenteses";
            this.btnFechaParenteses.Size = new System.Drawing.Size(125, 61);
            this.btnFechaParenteses.TabIndex = 27;
            this.btnFechaParenteses.Text = ")";
            this.btnFechaParenteses.UseVisualStyleBackColor = true;
            this.btnFechaParenteses.Click += new System.EventHandler(this.Tudo_Click);
            // 
            // btnVirgula
            // 
            this.btnVirgula.Location = new System.Drawing.Point(413, 276);
            this.btnVirgula.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnVirgula.Name = "btnVirgula";
            this.btnVirgula.Size = new System.Drawing.Size(125, 61);
            this.btnVirgula.TabIndex = 23;
            this.btnVirgula.Text = ",";
            this.btnVirgula.UseVisualStyleBackColor = true;
            this.btnVirgula.Click += new System.EventHandler(this.Tudo_Click);
            // 
            // btnMais
            // 
            this.btnMais.Location = new System.Drawing.Point(413, 205);
            this.btnMais.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnMais.Name = "btnMais";
            this.btnMais.Size = new System.Drawing.Size(125, 61);
            this.btnMais.TabIndex = 19;
            this.btnMais.Text = "+";
            this.btnMais.UseVisualStyleBackColor = true;
            this.btnMais.Click += new System.EventHandler(this.Tudo_Click);
            // 
            // btnMenos
            // 
            this.btnMenos.Location = new System.Drawing.Point(413, 134);
            this.btnMenos.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(125, 61);
            this.btnMenos.TabIndex = 15;
            this.btnMenos.Text = "-";
            this.btnMenos.UseVisualStyleBackColor = true;
            this.btnMenos.Click += new System.EventHandler(this.Tudo_Click);
            // 
            // btnMultiplicacao
            // 
            this.btnMultiplicacao.Location = new System.Drawing.Point(276, 134);
            this.btnMultiplicacao.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnMultiplicacao.Name = "btnMultiplicacao";
            this.btnMultiplicacao.Size = new System.Drawing.Size(125, 61);
            this.btnMultiplicacao.TabIndex = 16;
            this.btnMultiplicacao.Text = "*";
            this.btnMultiplicacao.UseVisualStyleBackColor = true;
            this.btnMultiplicacao.Click += new System.EventHandler(this.Tudo_Click);
            // 
            // btnDivisao
            // 
            this.btnDivisao.Location = new System.Drawing.Point(139, 134);
            this.btnDivisao.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnDivisao.Name = "btnDivisao";
            this.btnDivisao.Size = new System.Drawing.Size(125, 61);
            this.btnDivisao.TabIndex = 15;
            this.btnDivisao.Text = "/";
            this.btnDivisao.UseVisualStyleBackColor = true;
            this.btnDivisao.Click += new System.EventHandler(this.Tudo_Click);
            // 
            // btnElevado
            // 
            this.btnElevado.Location = new System.Drawing.Point(2, 134);
            this.btnElevado.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnElevado.Name = "btnElevado";
            this.btnElevado.Size = new System.Drawing.Size(125, 61);
            this.btnElevado.TabIndex = 8;
            this.btnElevado.Text = "^";
            this.btnElevado.UseVisualStyleBackColor = true;
            this.btnElevado.Click += new System.EventHandler(this.Tudo_Click);
            // 
            // btnBackspace
            // 
            this.btnBackspace.Location = new System.Drawing.Point(2, 489);
            this.btnBackspace.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnBackspace.Name = "btnBackspace";
            this.btnBackspace.Size = new System.Drawing.Size(125, 61);
            this.btnBackspace.TabIndex = 33;
            this.btnBackspace.Text = "Backspace";
            this.btnBackspace.UseVisualStyleBackColor = true;
            this.btnBackspace.Click += new System.EventHandler(this.btnBackspace_Click);
            // 
            // FrmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 555);
            this.Controls.Add(this.btnBackspace);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnAbreParenteses);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btnFechaParenteses);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btnVirgula);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btnMais);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnMultiplicacao);
            this.Controls.Add(this.btnDivisao);
            this.Controls.Add(this.btnMenos);
            this.Controls.Add(this.lblSequencias);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtVisor);
            this.Controls.Add(this.btnElevado);
            this.Font = new System.Drawing.Font("DejaVu Sans Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FrmCalculadora";
            this.Text = "Calculadora";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmCalculadora_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtVisor;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label lblSequencias;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnAbreParenteses;
        private System.Windows.Forms.Button btnFechaParenteses;
        private System.Windows.Forms.Button btnVirgula;
        private System.Windows.Forms.Button btnMais;
        private System.Windows.Forms.Button btnMenos;
        private System.Windows.Forms.Button btnMultiplicacao;
        private System.Windows.Forms.Button btnDivisao;
        private System.Windows.Forms.Button btnElevado;
        private System.Windows.Forms.Button btnBackspace;
    }
}

