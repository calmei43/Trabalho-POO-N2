namespace Trabalho_POO_N2.Formulários
{
    partial class FrmPedagio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPedagio));
            this.label41 = new System.Windows.Forms.Label();
            this.txtIdentificacao_Pedagio = new System.Windows.Forms.TextBox();
            this.txtLocalizacao_Pedagio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtListarPedagios = new System.Windows.Forms.TextBox();
            this.btnListarPedagios = new System.Windows.Forms.Button();
            this.btnCadastro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.Location = new System.Drawing.Point(21, 104);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(91, 19);
            this.label41.TabIndex = 67;
            this.label41.Text = "Identificação:";
            // 
            // txtIdentificacao_Pedagio
            // 
            this.txtIdentificacao_Pedagio.Location = new System.Drawing.Point(129, 103);
            this.txtIdentificacao_Pedagio.Name = "txtIdentificacao_Pedagio";
            this.txtIdentificacao_Pedagio.Size = new System.Drawing.Size(100, 20);
            this.txtIdentificacao_Pedagio.TabIndex = 68;
            // 
            // txtLocalizacao_Pedagio
            // 
            this.txtLocalizacao_Pedagio.Location = new System.Drawing.Point(129, 137);
            this.txtLocalizacao_Pedagio.Name = "txtLocalizacao_Pedagio";
            this.txtLocalizacao_Pedagio.Size = new System.Drawing.Size(100, 20);
            this.txtLocalizacao_Pedagio.TabIndex = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 19);
            this.label1.TabIndex = 69;
            this.label1.Text = "Localização:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Trabalho_POO_N2.Properties.Resources.cashier2_117800;
            this.pictureBox1.Location = new System.Drawing.Point(92, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 75;
            this.pictureBox1.TabStop = false;
            // 
            // txtListarPedagios
            // 
            this.txtListarPedagios.Location = new System.Drawing.Point(255, 50);
            this.txtListarPedagios.Multiline = true;
            this.txtListarPedagios.Name = "txtListarPedagios";
            this.txtListarPedagios.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtListarPedagios.Size = new System.Drawing.Size(213, 256);
            this.txtListarPedagios.TabIndex = 77;
            // 
            // btnListarPedagios
            // 
            this.btnListarPedagios.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarPedagios.Location = new System.Drawing.Point(255, 12);
            this.btnListarPedagios.Name = "btnListarPedagios";
            this.btnListarPedagios.Size = new System.Drawing.Size(213, 32);
            this.btnListarPedagios.TabIndex = 76;
            this.btnListarPedagios.Text = "Listar Pedágios";
            this.btnListarPedagios.UseVisualStyleBackColor = true;
            // 
            // btnCadastro
            // 
            this.btnCadastro.Location = new System.Drawing.Point(67, 193);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(98, 26);
            this.btnCadastro.TabIndex = 78;
            this.btnCadastro.Text = "Cadastrar";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // FrmPedagio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(480, 327);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.txtListarPedagios);
            this.Controls.Add(this.btnListarPedagios);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtLocalizacao_Pedagio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdentificacao_Pedagio);
            this.Controls.Add(this.label41);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPedagio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Pedágio";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.TextBox txtIdentificacao_Pedagio;
        private System.Windows.Forms.TextBox txtLocalizacao_Pedagio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtListarPedagios;
        private System.Windows.Forms.Button btnListarPedagios;
        private System.Windows.Forms.Button btnCadastro;
    }
}