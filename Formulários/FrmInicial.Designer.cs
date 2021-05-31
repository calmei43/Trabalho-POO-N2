namespace Trabalho_POO_N2.Formulários
{
    partial class FrmInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicial));
            this.label1 = new System.Windows.Forms.Label();
            this.btnCadatroModeloMarca = new System.Windows.Forms.Button();
            this.btnCadastrarVeiculo = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCadastraPedagio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escolha uma opção:";
            // 
            // btnCadatroModeloMarca
            // 
            this.btnCadatroModeloMarca.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadatroModeloMarca.Location = new System.Drawing.Point(148, 101);
            this.btnCadatroModeloMarca.Name = "btnCadatroModeloMarca";
            this.btnCadatroModeloMarca.Size = new System.Drawing.Size(245, 49);
            this.btnCadatroModeloMarca.TabIndex = 1;
            this.btnCadatroModeloMarca.Text = "Cadastrar Modelo/Marca";
            this.btnCadatroModeloMarca.UseVisualStyleBackColor = true;
            this.btnCadatroModeloMarca.Click += new System.EventHandler(this.btnCadatroModeloMarca_Click);
            // 
            // btnCadastrarVeiculo
            // 
            this.btnCadastrarVeiculo.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarVeiculo.Location = new System.Drawing.Point(148, 211);
            this.btnCadastrarVeiculo.Name = "btnCadastrarVeiculo";
            this.btnCadastrarVeiculo.Size = new System.Drawing.Size(245, 50);
            this.btnCadastrarVeiculo.TabIndex = 2;
            this.btnCadastrarVeiculo.Text = "Cadastrar Veículo";
            this.btnCadastrarVeiculo.UseVisualStyleBackColor = true;
            this.btnCadastrarVeiculo.Click += new System.EventHandler(this.btnCadastrarVeiculo_Click);
            // 
            // btnListar
            // 
            this.btnListar.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(148, 266);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(245, 49);
            this.btnListar.TabIndex = 3;
            this.btnListar.Text = "Listar Itens Cadastrados";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(192, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bem-Vindo(a)!    ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Trabalho_POO_N2.Properties.Resources.veiculos;
            this.pictureBox1.Location = new System.Drawing.Point(-4, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 355);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnCadastraPedagio
            // 
            this.btnCadastraPedagio.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastraPedagio.Location = new System.Drawing.Point(148, 156);
            this.btnCadastraPedagio.Name = "btnCadastraPedagio";
            this.btnCadastraPedagio.Size = new System.Drawing.Size(245, 49);
            this.btnCadastraPedagio.TabIndex = 6;
            this.btnCadastraPedagio.Text = "Cadastrar Pedágio";
            this.btnCadastraPedagio.UseVisualStyleBackColor = true;
            this.btnCadastraPedagio.Click += new System.EventHandler(this.btnCadastraPedagio_Click);
            // 
            // FrmInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(480, 341);
            this.Controls.Add(this.btnCadastraPedagio);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnCadastrarVeiculo);
            this.Controls.Add(this.btnCadatroModeloMarca);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seja bem-vindo(a)!";
            this.Load += new System.EventHandler(this.FrmInicial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button btnCadatroModeloMarca;
        public System.Windows.Forms.Button btnCadastrarVeiculo;
        public System.Windows.Forms.Button btnListar;
        public System.Windows.Forms.Button btnCadastraPedagio;
    }
}