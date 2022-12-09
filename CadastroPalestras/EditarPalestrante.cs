using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace CadastroPalestras
{
    public partial class EditarPalestrante : Form
    {
        private SqlConnection _conn { get; set; }
        private string _nome { get; set; }
        private string _profissao { get; set; }
        private string _curriculo { get; set; }
        public EditarPalestrante(SqlConnection conn, string nome, string profissao, string curriculo)
        {
            _conn = conn;
            _nome = nome;
            _profissao = profissao;
            _curriculo = curriculo;
            InitializeComponent();
        }

        private void EditarPalestrante_Load(object sender, EventArgs e)
        {
            tbNomePalestrante.Text = _nome;
            tbProfissao.Text = _profissao;
            tbCurriculo.Text = _curriculo;
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            tbNomePalestrante.Clear();
            tbProfissao.Clear();
            tbCurriculo.Clear();
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "UPDATE Palestrantes SET Nome=@nome, Profissao=@profissao, Curriculo=@curriculo WHERE Nome=@nomeAnterior AND Profissao=@profissaoAnterior";
                SqlCommand cmd = new SqlCommand(sql, _conn);
                cmd.Parameters.AddWithValue("nome", tbNomePalestrante.Text);
                cmd.Parameters.AddWithValue("profissao", tbProfissao.Text);
                cmd.Parameters.AddWithValue("curriculo", tbCurriculo.Text);
                cmd.Parameters.AddWithValue("nomeAnterior", _nome);
                cmd.Parameters.AddWithValue("profissaoAnterior", _profissao);
                cmd.ExecuteNonQuery();

                _nome = tbNomePalestrante.Text;
                _profissao = tbProfissao.Text;
                _curriculo = tbCurriculo.Text;

                MessageBox.Show("O(a) palestrante " + _nome + " foi atualizado(a) com sucesso.");

            }
            catch (SqlException a)
            {
                MessageBox.Show(a.ToString());
            }
        }
    }

}
