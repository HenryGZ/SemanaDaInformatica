using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroPalestras
{
    public partial class AreaAluno : Form
    {
        private SqlConnection _conn { get; set; }
        private SqlDataReader _dados { get; set; }
        private int _matricula { get; set; }

        public AreaAluno(int matricula, SqlConnection conn, SqlDataReader dados)
        {
            _matricula = matricula;
            _conn = conn;
            _dados = dados;
            InitializeComponent();
        }

        private void PreencherDG(string tabela, DataGridView dg)
        {
            try
            {
                string sqlSelect = "SELECT * FROM " + tabela;
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlSelect, _conn);
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

        private void AreaAluno_Load(object sender, EventArgs e)
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
            PreencherDG("Palestras", dgDisponiveis);
            PreencherDG("Matriculadas", dgConfirmadas);
        }
        private void btCadastrar_Click(object sender, EventArgs e)
        {
            string id = tbIdPalestra.Text;
            string sqlBusca = "SELECT * FROM Palestras WHERE Id=" + id;
            SqlCommand cmdBusca = new SqlCommand(sqlBusca, _conn);
            try
            {
                _dados = cmdBusca.ExecuteReader();
            }
            catch (SqlException a)
            {
                MessageBox.Show(a.ToString());
            }
            if (_dados.Read())
            {
                string nomePalestra = _dados["Nome"].ToString();
                string sqlInsercao = "INSERT INTO Matriculadas (Matricula, Palestra) VALUES(@matricula, @palestra)";
                SqlCommand cmdInsercao = new SqlCommand(sqlInsercao, _conn);
                cmdInsercao.Parameters.AddWithValue("matricula", _matricula);
                cmdInsercao.Parameters.AddWithValue("palestra", nomePalestra);

                try
                {
                    _dados.Close();
                    cmdInsercao.ExecuteNonQuery();
                    MessageBox.Show("Você se cadastrou para a palestra " + nomePalestra + " com sucesso.");
                }
                catch (SqlException a)
                {
                    MessageBox.Show(a.ToString());
                }

            }
            else
                MessageBox.Show("A palestra de ID " + id + " não foi encontrada.");

            _conn.Close();
            AreaAluno_Load(sender, e);
        }

        private void llPalestrantes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_dados != null)
                if (!_dados.IsClosed)
                    _dados.Close();
            new Infos("Palestrantes", _conn).ShowDialog();
        }

        private void llPalestras_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_dados != null)
                if (!_dados.IsClosed)
                    _dados.Close();
            new Infos("Palestras", _conn).ShowDialog();
        }

        private void btPesquisa_Click(object sender, EventArgs e)
        {
            new Pesquisas(_conn, _dados).ShowDialog();
        }
    }
}
