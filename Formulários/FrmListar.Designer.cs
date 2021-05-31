namespace Trabalho_POO_N2.Formulários
{
    partial class FrmListar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListar));
            this.label1 = new System.Windows.Forms.Label();
            this.cbTipoVeiculo_Listar = new System.Windows.Forms.ComboBox();
            this.txtListarVeiculos = new System.Windows.Forms.TextBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de veículo:";
            // 
            // cbTipoVeiculo_Listar
            // 
            this.cbTipoVeiculo_Listar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoVeiculo_Listar.FormattingEnabled = true;
            this.cbTipoVeiculo_Listar.Items.AddRange(new object[] {
            "Todos",
            "Avião",
            "Avião de Guerra",
            "Carro",
            "Caminhão",
            "Moto",
            "Navio",
            "Navio de Guerra",
            "Ônibus",
            "Trem"});
            this.cbTipoVeiculo_Listar.Location = new System.Drawing.Point(126, 32);
            this.cbTipoVeiculo_Listar.Name = "cbTipoVeiculo_Listar";
            this.cbTipoVeiculo_Listar.Size = new System.Drawing.Size(174, 21);
            this.cbTipoVeiculo_Listar.TabIndex = 1;
            // 
            // txtListarVeiculos
            // 
            this.txtListarVeiculos.Location = new System.Drawing.Point(12, 59);
            this.txtListarVeiculos.Multiline = true;
            this.txtListarVeiculos.Name = "txtListarVeiculos";
            this.txtListarVeiculos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtListarVeiculos.Size = new System.Drawing.Size(445, 256);
            this.txtListarVeiculos.TabIndex = 2;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(307, 30);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 3;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // FrmListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(480, 327);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.txtListarVeiculos);
            this.Controls.Add(this.cbTipoVeiculo_Listar);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmListar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar Veículos Cadastrados";
            this.Load += new System.EventHandler(this.FrmListar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTipoVeiculo_Listar;
        private System.Windows.Forms.TextBox txtListarVeiculos;
        private System.Windows.Forms.Button btnListar;
    }
}