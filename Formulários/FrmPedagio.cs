using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_POO_N2.Formulários
{
    public partial class FrmPedagio : Form
    {
        List<Pedagio> listaPedagios = new List<Pedagio>();
        public FrmPedagio()
        {
            InitializeComponent();
            CarregaPedagios();            
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            try
            {
                Pedagio p = new Pedagio();
                p.Identificação = txtIdentificacao_Pedagio.Text;
                p.Localização = txtLocalizacao_Pedagio.Text;
                listaPedagios.Add(p);

                MessageBox.Show("Pedágio cadastrado com sucesso!");
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }           
            
        }

        private void CarregaPedagios()
        {
            
            if (!string.IsNullOrEmpty(File.ReadAllText("pedagios.json")))
                listaPedagios = JsonConvert.DeserializeObject<List<Pedagio>>(File.ReadAllText("pedagios.json"));
        }

        private void FrmPedagio_Load(object sender, EventArgs e)
        {

        }

        private void FrmPedagio_FormClosed(object sender, FormClosedEventArgs e)
        {
            File.WriteAllText("pedagios.json", JsonConvert.SerializeObject(listaPedagios, Formatting.Indented));
        }

        private void btnListarPedagios_Click(object sender, EventArgs e)
        {
            txtListarPedagios.Clear();

            if (listaPedagios == null)
            {
                MessageBox.Show("Não existem pedágios cadastrados!");
                return;
            }

            foreach (var item in listaPedagios)
            {
                txtListarPedagios.Text += item.ToString() + Environment.NewLine;
            }           
            
        }
    }
}
