using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroPalestras
{
    public partial class LoginAdm : Form
    {
        private SqlConnection _conn { get; set; }
        private SqlDataReader _dados { get; set; }

        public LoginAdm(SqlConnection conn, SqlDataReader dados)
        {
            _conn = conn;
            _dados = dados;
            InitializeComponent();
        }
        private void LoginAdm_Load(object sender, EventArgs e)
        {
            try
            {
                _conn.Open();
                if (_dados != null)
                    if (!_dados.IsClosed)
                        _dados.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir a conexão com o banco de dados: " + ex.Message);
            }
        }

        private void Login(string login, string senha)
        {
            string sql = "SELECT * FROM Adms WHERE Login=@login AND Senha=@senha";
            SqlCommand cmd = new SqlCommand(sql, _conn);
            cmd.Parameters.AddWithValue("login", login);
            cmd.Parameters.AddWithValue("senha", senha);
            try
            {
                if (_dados != null)
                    if (!_dados.IsClosed)
                        _dados.Close();
                _dados = cmd.ExecuteReader();
                if (_dados.Read())
                {
                    MessageBox.Show("O ADM " + _dados["Nome"] + " efetuou login com sucesso.");
                    new Cadastros(_conn, _dados).ShowDialog(this);
                    Close();
                }
                else
                    MessageBox.Show("Login inválido.");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btEntrar_Click(object sender, EventArgs e)
        {
            Login(tbLogin.Text, tbSenha.Text);
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
