using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroPalestras
{
    public partial class Infos : Form
    {
        private string _tabela { get; set; }
        private SqlConnection _conn { get; set; }

        public Infos(string tabela, SqlConnection conn)
        {
            _tabela = tabela;
            _conn = conn;
            InitializeComponent();
        }

        private void PreencherDG()
        {
            try
            {
                string sql = "SELECT * FROM " + _tabela;
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, _conn);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                dg.ReadOnly = true;
                dg.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir a conexão com o banco de dados: " + ex.Message);
            }
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            Text = "Mais informações sobre " + _tabela;
            lbTitulo.Text = _tabela == "Palestrantes" ? _tabela.ToUpper() + " CONFIRMADOS" : _tabela.ToUpper() + " CONFIRMADAS";
            PreencherDG();
        }
    }
}
