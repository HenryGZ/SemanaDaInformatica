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
using System.Reflection.Emit;

namespace CadastroPalestras
{

    public partial class Pesquisas : Form
    {
        private SqlConnection _conn { get; set; }
        private SqlDataReader _dados { get; set; }

        public Pesquisas(SqlConnection conn, SqlDataReader dados)
        {
            _conn = conn;
            _dados = dados;
            InitializeComponent();
        }

        private void Pesquisas_Load(object sender, EventArgs e)
        {
            try
            {
                if (_dados != null)
                    if (!_dados.IsClosed)
                        _dados.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir a conexão com o banco de dados: " + ex.Message);
            }
        }

        private void PesquisarPalestrante()
        {
            if (String.IsNullOrEmpty(tbNomePalestrante.Text))
            {
                if (String.IsNullOrEmpty(tbProfissao.Text))
                    MessageBox.Show("Não há valor para pesquisar!");
                else
                {
                    string sql = "SELECT * FROM Palestrantes WHERE Profissao=@profissao";
                    SqlCommand cmd = new SqlCommand(sql, _conn);
                    cmd.Parameters.AddWithValue("profissao", tbProfissao.Text);
                    _dados = cmd.ExecuteReader();
                    if (_dados.Read())
                    {
                    tbNomePalestrante.Text = _dados["Nome"].ToString();
                    tbCurriculo.Text = _dados["Currículo"].ToString();
                    }
                }
            }
            else
            {
                string sql = "SELECT * FROM Palestrantes WHERE Nome=@nome";
                SqlCommand cmd = new SqlCommand(sql, _conn);
                cmd.Parameters.AddWithValue("nome", tbNomePalestrante.Text);
                _dados = cmd.ExecuteReader();
                if (_dados.Read())
                {
                    tbProfissao.Text = _dados["Profissao"].ToString();
                    tbCurriculo.Text = _dados["Curriculo"].ToString();
                }
            }
        }

        private void PesquisarPalestra()
        {
            if (String.IsNullOrEmpty(tbNomePalestra.Text))
            {
                if (String.IsNullOrEmpty(tbPalestrante.Text))
                    MessageBox.Show("Não há valor para pesquisar!");
                else
                {
                    string sql = "SELECT * FROM Palestras WHERE Palestrante=@palestrante";
                    SqlCommand cmd = new SqlCommand(sql, _conn);
                    cmd.Parameters.AddWithValue("palestrante", tbPalestrante.Text);
                    _dados = cmd.ExecuteReader();
                    if (_dados.Read())
                    {
                        tbNomePalestra.Text = _dados["Nome"].ToString();
                        tbTema.Text = _dados["Tema"].ToString();
                        tbLimiteParticipantes.Text = _dados["LimiteParticipantes"].ToString();
                        tbLocal.Text = _dados["Local"].ToString();
                        lbIdPalestra.Text = _dados["Id"].ToString();
                        dtData.Value = _dados.GetDateTime(5);
                        tbDescricao.Text = _dados["Descricao"].ToString();
                    }
                }
            }
            else
            {
                string sql = "SELECT * FROM Palestras WHERE Nome=@nome";
                SqlCommand cmd = new SqlCommand(sql, _conn);
                cmd.Parameters.AddWithValue("nome", tbNomePalestra.Text);
                _dados = cmd.ExecuteReader();
                if (_dados.Read())
                {
                    tbPalestrante.Text = _dados["Palestrante"].ToString();
                    tbTema.Text = _dados["Tema"].ToString();
                    tbLimiteParticipantes.Text = _dados["LimiteParticipantes"].ToString();
                    tbLocal.Text = _dados["Local"].ToString();
                    lbIdPalestra.Text = _dados["Id"].ToString();
                    dtData.Value = _dados.GetDateTime(6);
                    tbDescricao.Text = _dados["Descricao"].ToString();
                }
            }
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            if (_dados != null)
                if (!_dados.IsClosed)
                    _dados.Close();

            if (tabControl1.SelectedTab == tpPalestrantes)
                PesquisarPalestrante();
            else
                PesquisarPalestra();
        }

        private void Limpar()
        {
            if (tabControl1.SelectedTab == tpPalestrantes)
            {
                tbNomePalestrante.Clear();
                tbProfissao.Clear();
                tbCurriculo.Clear();
            }
            else
            {
                tbNomePalestra.Clear();
                tbPalestrante.Clear();
                tbTema.Clear();
                tbLimiteParticipantes.Clear();
                tbLocal.Clear();
                tbDescricao.Clear();
            }
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }
        private void btFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbPalestrante_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
