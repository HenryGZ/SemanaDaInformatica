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
    public partial class LoginAluno : Form
    {
        private SqlConnection _conn { get; set; }
        private SqlDataReader _dados { get; set; }

        public LoginAluno(SqlConnection conn, SqlDataReader dados)
        {
            _conn = conn;
            _dados = dados;
            InitializeComponent();
        }
        private void LoginAluno_Load(object sender, EventArgs e)
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

        private void Login(string login, string matricula)
        {
            string sql = "Select * from Alunos where Matricula=@matricula and Nome=@nome";
            SqlCommand cmd = new SqlCommand(sql, _conn);
            cmd.Parameters.AddWithValue("nome", login);
            cmd.Parameters.AddWithValue("matricula", matricula);
            try
            {
                if (_dados != null)
                    if (!_dados.IsClosed)
                        _dados.Close();
                _dados = cmd.ExecuteReader();
                if (_dados.Read())
                {
                    MessageBox.Show("O aluno " + _dados["Nome"] + " efetuou login com sucesso.");
                    Close();
                    new AreaAluno(Convert.ToInt32(matricula), _conn, _dados).ShowDialog();
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
            Login(tbNomeLogin.Text, tbMatriculaLogin.Text);
        }

        private void Limpar()
        {
            tbMatriculaLogin.Clear();
            tbMatriculaLogin.Clear();
        }

        private void Cadastrar(string matricula, string nome)
        {
            if (!(String.IsNullOrEmpty(matricula) || String.IsNullOrEmpty(nome)))
            {
                string sql = "Insert into Alunos (Matricula, Nome) values(@matricula, @nome)";
                SqlCommand cmd = new SqlCommand(sql, _conn);
                cmd.Parameters.AddWithValue("matricula", matricula);
                cmd.Parameters.AddWithValue("nome", nome);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cadastro efetuado com sucesso!");
                    Limpar();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
                MessageBox.Show("Erro durante o cadastro do aluno.");
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            Cadastrar(tbMatriculaLogin.Text, tbNomeLogin.Text);
        }

        private void lbTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}
