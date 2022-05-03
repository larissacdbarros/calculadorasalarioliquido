namespace Aula53_Exercicio
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
            this.txtColaborador = new System.Windows.Forms.TextBox();
            this.txtSalBruto = new System.Windows.Forms.TextBox();
            this.txtValorProjeto = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblColaborador = new System.Windows.Forms.Label();
            this.lblSalBruto = new System.Windows.Forms.Label();
            this.lblValorproj = new System.Windows.Forms.Label();
            this.lblSalLiquido = new System.Windows.Forms.Label();
            this.rBtnCLT = new System.Windows.Forms.RadioButton();
            this.rBtnPJ = new System.Windows.Forms.RadioButton();
            this.rBtnFreela = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txtColaborador
            // 
            this.txtColaborador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColaborador.Location = new System.Drawing.Point(189, 20);
            this.txtColaborador.Name = "txtColaborador";
            this.txtColaborador.Size = new System.Drawing.Size(246, 26);
            this.txtColaborador.TabIndex = 0;
            // 
            // txtSalBruto
            // 
            this.txtSalBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalBruto.Location = new System.Drawing.Point(189, 107);
            this.txtSalBruto.Name = "txtSalBruto";
            this.txtSalBruto.Size = new System.Drawing.Size(135, 26);
            this.txtSalBruto.TabIndex = 1;
            // 
            // txtValorProjeto
            // 
            this.txtValorProjeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorProjeto.Location = new System.Drawing.Point(189, 154);
            this.txtValorProjeto.Name = "txtValorProjeto";
            this.txtValorProjeto.Size = new System.Drawing.Size(135, 26);
            this.txtValorProjeto.TabIndex = 1;
            this.txtValorProjeto.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(189, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "Confirma";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblColaborador
            // 
            this.lblColaborador.AutoSize = true;
            this.lblColaborador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColaborador.Location = new System.Drawing.Point(36, 25);
            this.lblColaborador.Name = "lblColaborador";
            this.lblColaborador.Size = new System.Drawing.Size(96, 20);
            this.lblColaborador.TabIndex = 4;
            this.lblColaborador.Text = "Colaborador";
            // 
            // lblSalBruto
            // 
            this.lblSalBruto.AutoSize = true;
            this.lblSalBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalBruto.Location = new System.Drawing.Point(36, 113);
            this.lblSalBruto.Name = "lblSalBruto";
            this.lblSalBruto.Size = new System.Drawing.Size(101, 20);
            this.lblSalBruto.TabIndex = 5;
            this.lblSalBruto.Text = "Salario Bruto";
            // 
            // lblValorproj
            // 
            this.lblValorproj.AutoSize = true;
            this.lblValorproj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorproj.Location = new System.Drawing.Point(36, 160);
            this.lblValorproj.Name = "lblValorproj";
            this.lblValorproj.Size = new System.Drawing.Size(125, 20);
            this.lblValorproj.TabIndex = 6;
            this.lblValorproj.Text = "Valor do projeto ";
            this.lblValorproj.Visible = false;
            // 
            // lblSalLiquido
            // 
            this.lblSalLiquido.AutoSize = true;
            this.lblSalLiquido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalLiquido.Location = new System.Drawing.Point(192, 281);
            this.lblSalLiquido.Name = "lblSalLiquido";
            this.lblSalLiquido.Size = new System.Drawing.Size(0, 20);
            this.lblSalLiquido.TabIndex = 7;
            // 
            // rBtnCLT
            // 
            this.rBtnCLT.AutoSize = true;
            this.rBtnCLT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnCLT.Location = new System.Drawing.Point(189, 68);
            this.rBtnCLT.Name = "rBtnCLT";
            this.rBtnCLT.Size = new System.Drawing.Size(56, 24);
            this.rBtnCLT.TabIndex = 9;
            this.rBtnCLT.TabStop = true;
            this.rBtnCLT.Text = "CLT";
            this.rBtnCLT.UseVisualStyleBackColor = true;
            this.rBtnCLT.CheckedChanged += new System.EventHandler(this.rBtnCLT_CheckedChanged);
            // 
            // rBtnPJ
            // 
            this.rBtnPJ.AutoSize = true;
            this.rBtnPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnPJ.Location = new System.Drawing.Point(279, 68);
            this.rBtnPJ.Name = "rBtnPJ";
            this.rBtnPJ.Size = new System.Drawing.Size(45, 24);
            this.rBtnPJ.TabIndex = 9;
            this.rBtnPJ.TabStop = true;
            this.rBtnPJ.Text = "PJ";
            this.rBtnPJ.UseVisualStyleBackColor = true;
            this.rBtnPJ.CheckedChanged += new System.EventHandler(this.rBtnPJ_CheckedChanged);
            // 
            // rBtnFreela
            // 
            this.rBtnFreela.AutoSize = true;
            this.rBtnFreela.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnFreela.Location = new System.Drawing.Point(363, 68);
            this.rBtnFreela.Name = "rBtnFreela";
            this.rBtnFreela.Size = new System.Drawing.Size(72, 24);
            this.rBtnFreela.TabIndex = 9;
            this.rBtnFreela.TabStop = true;
            this.rBtnFreela.Text = "Freela";
            this.rBtnFreela.UseVisualStyleBackColor = true;
            this.rBtnFreela.CheckedChanged += new System.EventHandler(this.rBtnFreela_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 337);
            this.Controls.Add(this.rBtnFreela);
            this.Controls.Add(this.rBtnPJ);
            this.Controls.Add(this.rBtnCLT);
            this.Controls.Add(this.lblSalLiquido);
            this.Controls.Add(this.lblValorproj);
            this.Controls.Add(this.lblSalBruto);
            this.Controls.Add(this.lblColaborador);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtValorProjeto);
            this.Controls.Add(this.txtSalBruto);
            this.Controls.Add(this.txtColaborador);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtColaborador;
        private System.Windows.Forms.TextBox txtSalBruto;
        private System.Windows.Forms.TextBox txtValorProjeto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblColaborador;
        private System.Windows.Forms.Label lblSalBruto;
        private System.Windows.Forms.Label lblValorproj;
        private System.Windows.Forms.Label lblSalLiquido;
        private System.Windows.Forms.RadioButton rBtnCLT;
        private System.Windows.Forms.RadioButton rBtnPJ;
        private System.Windows.Forms.RadioButton rBtnFreela;
    }
}

