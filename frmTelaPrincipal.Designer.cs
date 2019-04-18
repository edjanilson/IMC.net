namespace ImcNet
{
    partial class frmTelaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelaPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mtxtAltura = new System.Windows.Forms.MaskedTextBox();
            this.mtxtPeso = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.pbTabela = new System.Windows.Forms.PictureBox();
            this.txtResul = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbTabela)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe seu peso:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tempus Sans ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Informe sua altura:";
            // 
            // mtxtAltura
            // 
            this.mtxtAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtAltura.Location = new System.Drawing.Point(264, 93);
            this.mtxtAltura.Mask = "0.00";
            this.mtxtAltura.Name = "mtxtAltura";
            this.mtxtAltura.Size = new System.Drawing.Size(53, 35);
            this.mtxtAltura.TabIndex = 1;
            // 
            // mtxtPeso
            // 
            this.mtxtPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtPeso.Location = new System.Drawing.Point(264, 30);
            this.mtxtPeso.Mask = "00";
            this.mtxtPeso.Name = "mtxtPeso";
            this.mtxtPeso.Size = new System.Drawing.Size(34, 35);
            this.mtxtPeso.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tempus Sans ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(417, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 35);
            this.label3.TabIndex = 6;
            this.label3.Text = "Resultado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tempus Sans ITC", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(222, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 27);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tabela IMC.";
            this.label5.Visible = false;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Image = global::ImcNet.Properties.Resources.iconfinder_close_309090;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(369, 500);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(114, 47);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.Image = global::ImcNet.Properties.Resources.iconfinder_trash_103224;
            this.btnApagar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApagar.Location = new System.Drawing.Point(249, 499);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(114, 48);
            this.btnApagar.TabIndex = 3;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Image = global::ImcNet.Properties.Resources.iconfinder_circled_play_2639911;
            this.btnCalcular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalcular.Location = new System.Drawing.Point(129, 499);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(114, 48);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // pbTabela
            // 
            this.pbTabela.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbTabela.Image = global::ImcNet.Properties.Resources.tABELA_2;
            this.pbTabela.Location = new System.Drawing.Point(18, 191);
            this.pbTabela.Name = "pbTabela";
            this.pbTabela.Size = new System.Drawing.Size(573, 301);
            this.pbTabela.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbTabela.TabIndex = 5;
            this.pbTabela.TabStop = false;
            this.pbTabela.Visible = false;
            // 
            // txtResul
            // 
            this.txtResul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResul.Location = new System.Drawing.Point(423, 100);
            this.txtResul.MaxLength = 5;
            this.txtResul.Name = "txtResul";
            this.txtResul.ReadOnly = true;
            this.txtResul.Size = new System.Drawing.Size(136, 26);
            this.txtResul.TabIndex = 9;
            this.txtResul.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtResul.Visible = false;
            // 
            // frmTelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 555);
            this.Controls.Add(this.txtResul);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbTabela);
            this.Controls.Add(this.mtxtPeso);
            this.Controls.Add(this.mtxtAltura);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmTelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Imc.Net";
            ((System.ComponentModel.ISupportInitialize)(this.pbTabela)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtxtAltura;
        private System.Windows.Forms.MaskedTextBox mtxtPeso;
        private System.Windows.Forms.PictureBox pbTabela;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtResul;
    }
}

