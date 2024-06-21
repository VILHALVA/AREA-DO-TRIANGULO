namespace WindowsFormsApp1
{
    partial class FormInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicio));
            this.TbBase = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TbAltura = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtCalcular = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TbResultado = new System.Windows.Forms.TextBox();
            this.BtLimpar = new System.Windows.Forms.Button();
            this.LbMensagem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TbBase
            // 
            this.TbBase.Location = new System.Drawing.Point(324, 43);
            this.TbBase.Name = "TbBase";
            this.TbBase.Size = new System.Drawing.Size(241, 22);
            this.TbBase.TabIndex = 0;
            this.TbBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "DIGITE A BASE: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TbAltura
            // 
            this.TbAltura.Location = new System.Drawing.Point(324, 108);
            this.TbAltura.Name = "TbAltura";
            this.TbAltura.Size = new System.Drawing.Size(241, 22);
            this.TbAltura.TabIndex = 2;
            this.TbAltura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "DIGITE A ALTURA:";
            // 
            // BtCalcular
            // 
            this.BtCalcular.Location = new System.Drawing.Point(454, 212);
            this.BtCalcular.Name = "BtCalcular";
            this.BtCalcular.Size = new System.Drawing.Size(111, 23);
            this.BtCalcular.TabIndex = 4;
            this.BtCalcular.Text = "CALCULAR";
            this.BtCalcular.UseVisualStyleBackColor = true;
            this.BtCalcular.Click += new System.EventHandler(this.BtCalcular_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "AREA: ";
            // 
            // TbResultado
            // 
            this.TbResultado.Location = new System.Drawing.Point(269, 319);
            this.TbResultado.Name = "TbResultado";
            this.TbResultado.ReadOnly = true;
            this.TbResultado.Size = new System.Drawing.Size(241, 22);
            this.TbResultado.TabIndex = 5;
            this.TbResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtLimpar
            // 
            this.BtLimpar.Location = new System.Drawing.Point(170, 212);
            this.BtLimpar.Name = "BtLimpar";
            this.BtLimpar.Size = new System.Drawing.Size(127, 23);
            this.BtLimpar.TabIndex = 7;
            this.BtLimpar.Text = "LIMPAR";
            this.BtLimpar.UseVisualStyleBackColor = true;
            this.BtLimpar.Click += new System.EventHandler(this.BtLimpar_Click);
            // 
            // LbMensagem
            // 
            this.LbMensagem.AutoSize = true;
            this.LbMensagem.Location = new System.Drawing.Point(253, 405);
            this.LbMensagem.Name = "LbMensagem";
            this.LbMensagem.Size = new System.Drawing.Size(0, 16);
            this.LbMensagem.TabIndex = 8;
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LbMensagem);
            this.Controls.Add(this.BtLimpar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TbResultado);
            this.Controls.Add(this.BtCalcular);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TbAltura);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbBase);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormInicio";
            this.Text = "AREA DO TRIANGULO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbBase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbAltura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtCalcular;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbResultado;
        private System.Windows.Forms.Button BtLimpar;
        private System.Windows.Forms.Label LbMensagem;
    }
}

