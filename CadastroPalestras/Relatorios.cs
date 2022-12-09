using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroPalestras
{
    public partial class Relatorios : Form
    {
        public Relatorios()
        {
            InitializeComponent();
        }

        private void Relatórios_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dBPalestrasDataSet.Palestras'. Você pode movê-la ou removê-la conforme necessário.
            this.palestrasTableAdapter.Fill(this.dBPalestrasDataSet.Palestras);

            this.reportViewer1.RefreshReport();
        }
    }
}
