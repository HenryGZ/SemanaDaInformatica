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

    public partial class Cadastros : Form
    {
        private SqlConnection _conn { get; set; }
        private SqlDataReader _dados { get; set; }

        public Cadastros(SqlConnection conn, SqlDataReader dados)
        {
            _conn = conn;
            _dados = dados;
            InitializeComponent();
        }

        private void Cadastros_Load(object sender, EventArgs e)
        {
            try
            {
                if (_dados != null)
                    if (!_dados.IsClosed)
                        _dados.Close();
                string SQLastId = "SELECT MAX(Id) FROM Palestras;";
                SqlCommand cmd = new SqlCommand(SQLastId, _conn);
                _dados = cmd.ExecuteReader();
                if (_dados.Read() && _dados.IsDBNull(0))
                    lbIdPalestra.Text = "1";
                else
                {
                    int proxId = _dados.GetInt32(0) + 1;
                    lbIdPalestra.Text = proxId.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir a conexão com BD " + ex.Message);
            }
        }

        private void CadastrarPalestrante(string nome, string profissao, string curriculo)
        {
            if (!(String.IsNullOrEmpty(nome) || String.IsNullOrEmpty(profissao) || String.IsNullOrEmpty(curriculo)))
            {
                string sql = "INSERT INTO Palestrantes (nome, profissao, curriculo)" + "VALUES(@nome, @profissao, @curriculo)";
                SqlCommand cmd = new SqlCommand(sql, _conn);
                cmd.Parameters.AddWithValue("nome", nome);
                cmd.Parameters.AddWithValue("profissao", profissao);
                cmd.Parameters.AddWithValue("curriculo", curriculo);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("O(a) palestrante " + nome + " foi cadastrado(a) com sucesso.");
                }
                catch (SqlException a)
                {
                    MessageBox.Show(a.ToString());
                }
            }
            else
                MessageBox.Show("Erro durante o cadastro do(a) palestrante.");
        }

        private bool PalestranteCadastrado(string nome)
        {
            if (_dados != null)
                if (!_dados.IsClosed)
                    _dados.Close();
            string sql = "SELECT * FROM Palestrantes WHERE Nome=@nome";
            SqlCommand cmd = new SqlCommand(sql, _conn);
            cmd.Parameters.AddWithValue("nome", nome);
            _dados = cmd.ExecuteReader();
            return _dados.Read();
        }

        private void CadastrarPalestra(string nome, string palestrante, string tema, int limiteParticipantes, string local, string descricao, DateTime data)
        {
            if (!(String.IsNullOrEmpty(nome) || String.IsNullOrEmpty(tbPalestrante.Text)
                    || String.IsNullOrEmpty(tema) || limiteParticipantes <= 0 || String.IsNullOrEmpty(local)
                    || String.IsNullOrEmpty(descricao)))
            {
                string sql = "INSERT INTO Palestras (Nome, Tema, Local, Palestrante, LimiteParticipantes, Data, Descricao)" + "VALUES(@nome, @tema, @local, @palestrante, @limite_participantes, @data, @descricao)";
                SqlCommand cmd = new SqlCommand(sql, _conn);
                cmd.Parameters.AddWithValue("nome", nome);
                cmd.Parameters.AddWithValue("palestrante", palestrante);
                cmd.Parameters.AddWithValue("tema", tema);
                cmd.Parameters.AddWithValue("limite_participantes", limiteParticipantes);
                cmd.Parameters.AddWithValue("local", local);
                cmd.Parameters.AddWithValue("descricao", descricao);
                cmd.Parameters.AddWithValue("data", data);

                try
                {
                    if (PalestranteCadastrado(tbPalestrante.Text))
                    {
                        _dados.Close();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cadastro efetuado com sucesso!!");
                    }
                    else
                        MessageBox.Show("O palestrante " + palestrante + " não foi cadastrado.");
                }
                catch (SqlException a)
                {
                    MessageBox.Show(a.ToString());
                }
            }
            else
                MessageBox.Show("Erro durante o cadastro da palestra.");
        }

        private void CadastrarAdministrador(string nome, string login, string senha)
        {
            if (!(String.IsNullOrEmpty(nome) || String.IsNullOrEmpty(login) || String.IsNullOrEmpty(senha)))
            {
                string sql = "INSERT INTO Adms (Nome, Login, Senha) VALUES(@nome, @login, @senha)";
                SqlCommand cmd = new SqlCommand(sql, _conn);
                cmd.Parameters.AddWithValue("Nome", nome);
                cmd.Parameters.AddWithValue("Login", login);
                cmd.Parameters.AddWithValue("Senha", senha);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("O(a) administrador(a) " + nome + " foi cadastrado(a) com sucesso.");
                }
                catch (SqlException a)
                {
                    MessageBox.Show(a.ToString());
                }
            }
            else
                MessageBox.Show("Erro durante o cadastro do(a) administrador(a).");
        }

        private void CadastrarAluno(string nome, string matricula)
        {
            if (!(String.IsNullOrEmpty(nome) || String.IsNullOrEmpty(matricula)))
            {
                string sql = "INSERT INTO Alunos (Nome, Matricula) VALUES(@nome, @matricula)";
                SqlCommand cmd = new SqlCommand(sql, _conn);
                cmd.Parameters.AddWithValue("Nome", nome);
                cmd.Parameters.AddWithValue("Matricula", matricula);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("O(a) aluno(a) " + nome + " foi cadastrado(a) com sucesso.");
                }
                catch (SqlException a)
                {
                    MessageBox.Show(a.ToString());
                }
            }
            else
                MessageBox.Show("Erro durante o cadastro do(a) aluno(a).");
        }

        private void Limpar()
        {
            if (tabControl1.SelectedTab == tpPalestrantes)
            {
                tbNomePalestrante.Clear();
                tbProfissao.Clear();
                tbCurriculo.Clear();
            }
            else if (tabControl1.SelectedTab == tpPalestras)
            {
                tbNomePalestra.Clear();
                tbPalestrante.Clear();
                tbTema.Clear();
                tbLimiteParticipantes.Clear();
                tbLocal.Clear();
                tbDescricao.Clear();
            }
            else if (tabControl1.SelectedTab == tpAdministradores)
            {
                tbNomeAdm.Clear();
                tbLogin.Clear();
                tbSenha.Clear();
            }
            else
            {
                tbNomeAluno.Clear();
                tbMatricula.Clear();
            }
        }
        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (_dados != null)
                if (!_dados.IsClosed)
                    _dados.Close();

            if (tabControl1.SelectedTab == tpPalestrantes)
            {
                CadastrarPalestrante(tbNomePalestrante.Text, tbProfissao.Text, tbCurriculo.Text);
            }
            else if (tabControl1.SelectedTab == tpPalestras)
            {
                CadastrarPalestra(tbNomePalestra.Text, tbPalestrante.Text, tbTema.Text, Convert.ToInt32(tbLimiteParticipantes.Text), tbLocal.Text, tbDescricao.Text, dtData.Value);
            }
            else if (tabControl1.SelectedTab == tpAdministradores)
            {
                CadastrarAdministrador(tbNomeAdm.Text, tbLogin.Text, tbSenha.Text);
            }
            else
                CadastrarAluno(tbNomeAluno.Text, tbMatricula.Text);

            Limpar();
            Cadastros_Load(sender, e);
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }
        private void btFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ExcluirPalestrante(string nome, string profissao)
        {
            if (!(String.IsNullOrEmpty(nome) || String.IsNullOrEmpty(tbProfissao.Text)))
            {
                SqlCommand cmdExcluirPalestrante = new SqlCommand("DELETE FROM Palestrantes WHERE Nome = @nome AND Profissao = @profissao", _conn);
                cmdExcluirPalestrante.Parameters.AddWithValue("nome", nome);
                cmdExcluirPalestrante.Parameters.AddWithValue("profissao", profissao);

                SqlCommand cmdExcluirPalestra = new SqlCommand("DELETE FROM Palestras WHERE Palestrante = @palestrante", _conn);
                cmdExcluirPalestra.Parameters.AddWithValue("palestrante", nome);
                try
                {
                    cmdExcluirPalestrante.ExecuteNonQuery();
                    cmdExcluirPalestra.ExecuteNonQuery();
                    MessageBox.Show("O(a) palestrante " + nome + " foi excluído(a) com sucesso.");
                }
                catch (SqlException a)
                {
                    MessageBox.Show(a.ToString());
                }
            }
            else
                MessageBox.Show("Erro durante a exclusão do(a) palestrante.");
        }

        private void ExcluirPalestra(string palestra, string palestrante)
        {
            if (!(String.IsNullOrEmpty(palestra) || String.IsNullOrEmpty(palestrante)))
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Palestras WHERE Palestra = @palestra AND Palestrante = @palestrante", _conn);
                cmd.Parameters.AddWithValue("palestra", palestra);
                cmd.Parameters.AddWithValue("palestrante", palestrante);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("A palestra " + palestra + " foi excluída com sucesso.");
                }
                catch (SqlException a)
                {
                    MessageBox.Show(a.ToString());
                }
            }
            else
                MessageBox.Show("Erro durante a exclusão da palestra.");
        }

        private void ExcluirAdministrador(string nome, string login, string senha)
        {
            if (!(String.IsNullOrEmpty(nome) || String.IsNullOrEmpty(login) || String.IsNullOrEmpty(senha)))
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Adms WHERE Nome = @nome AND Login = @login AND Senha = @senha", _conn);
                cmd.Parameters.AddWithValue("nome", nome);
                cmd.Parameters.AddWithValue("login", login);
                cmd.Parameters.AddWithValue("senha", senha);
                if (nome != "Primeiro ADM" && login != "admin")
                {
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("O(a) administrador(a) " + nome + " foi excluido(a) com sucesso.");
                    }
                    catch (SqlException a)
                    {
                        MessageBox.Show(a.ToString());
                    }

                }
                else
                    MessageBox.Show("Esse administrador não pode ser excluído.");
            }
            else
                MessageBox.Show("Erro durante a exclusão do(a) administrador(a).");
        }

        private void ExcluirAluno(string nome, string matricula)
        {
            if (!(String.IsNullOrEmpty(nome) || String.IsNullOrEmpty(matricula)))
            {
                string sql = "DELETE FROM Alunos WHERE Nome = @nome AND Matricula = @matricula";
                SqlCommand cmd = new SqlCommand(sql, _conn);
                cmd.Parameters.AddWithValue("Nome", nome);
                cmd.Parameters.AddWithValue("Matricula", matricula);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("O(a) aluno(a) " + nome + " foi excluido(a) com sucesso.");
                }
                catch (SqlException a)
                {
                    MessageBox.Show(a.ToString());
                }
            }
            else
                MessageBox.Show("Erro durante a exclusão do(a) aluno(a).");
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (_dados != null)
                if (!_dados.IsClosed)
                    _dados.Close();

            if (tabControl1.SelectedTab == tpPalestrantes)
            {
                ExcluirPalestrante(tbNomePalestrante.Text, tbProfissao.Text);
            }
            else if (tabControl1.SelectedTab == tpPalestras)
            {
                ExcluirPalestra(tbNomePalestra.Text, tbPalestrante.Text);
            }
            else if (tabControl1.SelectedTab == tpAdministradores)
            {
                ExcluirAdministrador(tbNomeAdm.Text, tbLogin.Text, tbSenha.Text);
            }
            else
                ExcluirAluno(tbNomeAluno.Text, tbMatricula.Text);

            Limpar();
            Cadastros_Load(sender, e);
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            if (_dados != null)
                if (!_dados.IsClosed)
                    _dados.Close();
            if (tabControl1.SelectedTab == tpPalestrantes)
                if (String.IsNullOrEmpty(tbNomePalestrante.Text) || String.IsNullOrEmpty(tbProfissao.Text))
                    MessageBox.Show("É necessário inserir o nome e a profissão do palestrante para editar seus dados.");
                else
                {
                    string sql = "SELECT * FROM Palestrantes WHERE Nome=@nome AND Profissao=@profissao";
                    SqlCommand cmd = new SqlCommand(sql, _conn);
                    cmd.Parameters.AddWithValue("nome", tbNomePalestrante.Text);
                    cmd.Parameters.AddWithValue("profissao", tbProfissao.Text);
                    _dados = cmd.ExecuteReader();

                    if (_dados.Read())
                    {
                        string curriculo = _dados["Curriculo"].ToString();
                        _dados.Close();
                        new EditarPalestrante(_conn, tbNomePalestrante.Text, tbProfissao.Text, curriculo).ShowDialog();
                    }
                }
            else if (tabControl1.SelectedTab == tpPalestras)
                if (String.IsNullOrEmpty(tbNomePalestra.Text) || String.IsNullOrEmpty(tbPalestrante.Text))
                    MessageBox.Show("É necessário inserir o nome da palestra e do palestrante para editar seus dados.");
                else
                {
                    string sql = "SELECT * FROM Palestras WHERE Nome=@nome AND Palestrante=@palestrante";
                    SqlCommand cmd = new SqlCommand(sql, _conn);
                    cmd.Parameters.AddWithValue("nome", tbNomePalestra.Text);
                    cmd.Parameters.AddWithValue("palestrante", tbPalestrante.Text);
                    _dados = cmd.ExecuteReader();

                    if (_dados.Read())
                    {
                        string tema = _dados["Tema"].ToString();
                        string local = _dados["Local"].ToString();
                        int limiteParticipantes = Convert.ToInt32(_dados["LimiteParticipantes"]);
                        DateTime data = _dados.GetDateTime(6);
                        string descricao = _dados["Descricao"].ToString();
                        _dados.Close();
                        new EditarPalestra(_conn, tbNomePalestra.Text, tbPalestrante.Text, tema, local, limiteParticipantes, data, descricao).ShowDialog();
                    }
                }
            else
                MessageBox.Show("Só é possível editar dados de palestras e palestrantes.");
        }
    }
}
