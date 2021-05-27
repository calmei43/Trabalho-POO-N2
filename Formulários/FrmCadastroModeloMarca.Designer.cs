namespace Trabalho_POO_N2.Formulários
{
    partial class FrmCadastroModeloMarca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroModeloMarca));
            this.tcMarcaModelo = new System.Windows.Forms.TabControl();
            this.tpMarca = new System.Windows.Forms.TabPage();
            this.btnCadastrar_Marca = new System.Windows.Forms.Button();
            this.label41 = new System.Windows.Forms.Label();
            this.tpModelo = new System.Windows.Forms.TabPage();
            this.txtDescricao_Marca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.npdCodigo_Marca = new System.Windows.Forms.NumericUpDown();
            this.nmCodigo_Modelo = new System.Windows.Forms.NumericUpDown();
            this.txtDescricao_Modelo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCadastrarModelo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbMarca_Modelo = new System.Windows.Forms.ComboBox();
            this.pbVeiculos = new System.Windows.Forms.PictureBox();
            this.pbCarros = new System.Windows.Forms.PictureBox();
            this.tcMarcaModelo.SuspendLayout();
            this.tpMarca.SuspendLayout();
            this.tpModelo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npdCodigo_Marca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmCodigo_Modelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVeiculos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCarros)).BeginInit();
            this.SuspendLayout();
            // 
            // tcMarcaModelo
            // 
            this.tcMarcaModelo.Controls.Add(this.tpMarca);
            this.tcMarcaModelo.Controls.Add(this.tpModelo);
            this.tcMarcaModelo.Location = new System.Drawing.Point(-1, -2);
            this.tcMarcaModelo.Name = "tcMarcaModelo";
            this.tcMarcaModelo.SelectedIndex = 0;
            this.tcMarcaModelo.Size = new System.Drawing.Size(482, 331);
            this.tcMarcaModelo.TabIndex = 1;
            // 
            // tpMarca
            // 
            this.tpMarca.BackColor = System.Drawing.Color.LightGray;
            this.tpMarca.Controls.Add(this.pbVeiculos);
            this.tpMarca.Controls.Add(this.npdCodigo_Marca);
            this.tpMarca.Controls.Add(this.txtDescricao_Marca);
            this.tpMarca.Controls.Add(this.label1);
            this.tpMarca.Controls.Add(this.btnCadastrar_Marca);
            this.tpMarca.Controls.Add(this.label41);
            this.tpMarca.Location = new System.Drawing.Point(4, 22);
            this.tpMarca.Name = "tpMarca";
            this.tpMarca.Padding = new System.Windows.Forms.Padding(3);
            this.tpMarca.Size = new System.Drawing.Size(474, 305);
            this.tpMarca.TabIndex = 6;
            this.tpMarca.Text = "Marca";
            // 
            // btnCadastrar_Marca
            // 
            this.btnCadastrar_Marca.Location = new System.Drawing.Point(88, 196);
            this.btnCadastrar_Marca.Name = "btnCadastrar_Marca";
            this.btnCadastrar_Marca.Size = new System.Drawing.Size(84, 41);
            this.btnCadastrar_Marca.TabIndex = 80;
            this.btnCadastrar_Marca.Text = "Cadastrar!";
            this.btnCadastrar_Marca.UseVisualStyleBackColor = true;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.Location = new System.Drawing.Point(37, 86);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(56, 19);
            this.label41.TabIndex = 66;
            this.label41.Text = "Código:";
            // 
            // tpModelo
            // 
            this.tpModelo.BackColor = System.Drawing.Color.LightGray;
            this.tpModelo.Controls.Add(this.pbCarros);
            this.tpModelo.Controls.Add(this.cbMarca_Modelo);
            this.tpModelo.Controls.Add(this.nmCodigo_Modelo);
            this.tpModelo.Controls.Add(this.txtDescricao_Modelo);
            this.tpModelo.Controls.Add(this.label2);
            this.tpModelo.Controls.Add(this.btnCadastrarModelo);
            this.tpModelo.Controls.Add(this.label3);
            this.tpModelo.Controls.Add(this.label4);
            this.tpModelo.Location = new System.Drawing.Point(4, 22);
            this.tpModelo.Name = "tpModelo";
            this.tpModelo.Padding = new System.Windows.Forms.Padding(3);
            this.tpModelo.Size = new System.Drawing.Size(474, 305);
            this.tpModelo.TabIndex = 8;
            this.tpModelo.Text = "Modelo";
            // 
            // txtDescricao_Marca
            // 
            this.txtDescricao_Marca.Location = new System.Drawing.Point(115, 144);
            this.txtDescricao_Marca.Name = "txtDescricao_Marca";
            this.txtDescricao_Marca.Size = new System.Drawing.Size(103, 20);
            this.txtDescricao_Marca.TabIndex = 82;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 81;
            this.label1.Text = "Descrição:";
            // 
            // npdCodigo_Marca
            // 
            this.npdCodigo_Marca.Location = new System.Drawing.Point(115, 88);
            this.npdCodigo_Marca.Name = "npdCodigo_Marca";
            this.npdCodigo_Marca.Size = new System.Drawing.Size(103, 20);
            this.npdCodigo_Marca.TabIndex = 83;
            // 
            // nmCodigo_Modelo
            // 
            this.nmCodigo_Modelo.Location = new System.Drawing.Point(87, 62);
            this.nmCodigo_Modelo.Name = "nmCodigo_Modelo";
            this.nmCodigo_Modelo.Size = new System.Drawing.Size(121, 20);
            this.nmCodigo_Modelo.TabIndex = 90;
            // 
            // txtDescricao_Modelo
            // 
            this.txtDescricao_Modelo.Location = new System.Drawing.Point(95, 110);
            this.txtDescricao_Modelo.Name = "txtDescricao_Modelo";
            this.txtDescricao_Modelo.Size = new System.Drawing.Size(113, 20);
            this.txtDescricao_Modelo.TabIndex = 89;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 88;
            this.label2.Text = "Descrição:";
            // 
            // btnCadastrarModelo
            // 
            this.btnCadastrarModelo.Location = new System.Drawing.Point(72, 211);
            this.btnCadastrarModelo.Name = "btnCadastrarModelo";
            this.btnCadastrarModelo.Size = new System.Drawing.Size(84, 41);
            this.btnCadastrarModelo.TabIndex = 87;
            this.btnCadastrarModelo.Text = "Cadastrar!";
            this.btnCadastrarModelo.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 19);
            this.label3.TabIndex = 85;
            this.label3.Text = "Marca:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 19);
            this.label4.TabIndex = 84;
            this.label4.Text = "Código:";
            // 
            // cbMarca_Modelo
            // 
            this.cbMarca_Modelo.FormattingEnabled = true;
            this.cbMarca_Modelo.Location = new System.Drawing.Point(86, 157);
            this.cbMarca_Modelo.Name = "cbMarca_Modelo";
            this.cbMarca_Modelo.Size = new System.Drawing.Size(121, 21);
            this.cbMarca_Modelo.TabIndex = 91;
            // 
            // pbVeiculos
            // 
            this.pbVeiculos.Image = global::Trabalho_POO_N2.Properties.Resources.veiculos;
            this.pbVeiculos.Location = new System.Drawing.Point(266, -8);
            this.pbVeiculos.Name = "pbVeiculos";
            this.pbVeiculos.Size = new System.Drawing.Size(208, 315);
            this.pbVeiculos.TabIndex = 84;
            this.pbVeiculos.TabStop = false;
            // 
            // pbCarros
            // 
            this.pbCarros.Image = global::Trabalho_POO_N2.Properties.Resources.carros;
            this.pbCarros.Location = new System.Drawing.Point(226, 40);
            this.pbCarros.Name = "pbCarros";
            this.pbCarros.Size = new System.Drawing.Size(225, 224);
            this.pbCarros.TabIndex = 92;
            this.pbCarros.TabStop = false;
            // 
            // FrmCadastroModeloMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 327);
            this.Controls.Add(this.tcMarcaModelo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCadastroModeloMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Modelo / Marca";
            this.tcMarcaModelo.ResumeLayout(false);
            this.tpMarca.ResumeLayout(false);
            this.tpMarca.PerformLayout();
            this.tpModelo.ResumeLayout(false);
            this.tpModelo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npdCodigo_Marca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmCodigo_Modelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVeiculos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCarros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcMarcaModelo;
        private System.Windows.Forms.TabPage tpMarca;
        private System.Windows.Forms.NumericUpDown npdCodigo_Marca;
        private System.Windows.Forms.TextBox txtDescricao_Marca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCadastrar_Marca;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.TabPage tpModelo;
        private System.Windows.Forms.PictureBox pbCarros;
        private System.Windows.Forms.ComboBox cbMarca_Modelo;
        private System.Windows.Forms.NumericUpDown nmCodigo_Modelo;
        private System.Windows.Forms.TextBox txtDescricao_Modelo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCadastrarModelo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbVeiculos;
    }
}