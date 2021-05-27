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
            this.btnListarPedagios = new System.Windows.Forms.Button();
            this.txtListarPedagios = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de veículo:";
            // 
            // cbTipoVeiculo_Listar
            // 
            this.cbTipoVeiculo_Listar.FormattingEnabled = true;
            this.cbTipoVeiculo_Listar.Location = new System.Drawing.Point(29, 33);
            this.cbTipoVeiculo_Listar.Name = "cbTipoVeiculo_Listar";
            this.cbTipoVeiculo_Listar.Size = new System.Drawing.Size(174, 21);
            this.cbTipoVeiculo_Listar.TabIndex = 1;
            // 
            // txtListarVeiculos
            // 
            this.txtListarVeiculos.Location = new System.Drawing.Point(18, 60);
            this.txtListarVeiculos.Multiline = true;
            this.txtListarVeiculos.Name = "txtListarVeiculos";
            this.txtListarVeiculos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtListarVeiculos.Size = new System.Drawing.Size(213, 256);
            this.txtListarVeiculos.TabIndex = 2;
            // 
            // btnListarPedagios
            // 
            this.btnListarPedagios.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarPedagios.Location = new System.Drawing.Point(249, 22);
            this.btnListarPedagios.Name = "btnListarPedagios";
            this.btnListarPedagios.Size = new System.Drawing.Size(213, 32);
            this.btnListarPedagios.TabIndex = 4;
            this.btnListarPedagios.Text = "Listar Pedágios";
            this.btnListarPedagios.UseVisualStyleBackColor = true;
            // 
            // txtListarPedagios
            // 
            this.txtListarPedagios.Location = new System.Drawing.Point(249, 60);
            this.txtListarPedagios.Multiline = true;
            this.txtListarPedagios.Name = "txtListarPedagios";
            this.txtListarPedagios.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtListarPedagios.Size = new System.Drawing.Size(213, 256);
            this.txtListarPedagios.TabIndex = 5;
            // 
            // FrmListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(480, 327);
            this.Controls.Add(this.txtListarPedagios);
            this.Controls.Add(this.btnListarPedagios);
            this.Controls.Add(this.txtListarVeiculos);
            this.Controls.Add(this.cbTipoVeiculo_Listar);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmListar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar Veículos Cadastrados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTipoVeiculo_Listar;
        private System.Windows.Forms.TextBox txtListarVeiculos;
        private System.Windows.Forms.Button btnListarPedagios;
        private System.Windows.Forms.TextBox txtListarPedagios;
    }
}