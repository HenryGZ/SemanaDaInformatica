using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroPalestras
{
    public partial class Inicio : Form
    {
        private static string _url { get; set; }
        private static SqlConnection _conn { get; set; }
        private static SqlDataReader _dados { get; set; }

        public Inicio()
        {
            _url = "Data Source=(localdb)\\MSSQLLocalDB;";
            _conn = new SqlConnection(_url);
            _dados = null;
            InitializeComponent();
        }

        private void loginADMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _conn.Close();
            new LoginAdm(_conn, _dados).ShowDialog();
        }

        private void áreaDoAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _conn.Close();
            new LoginAluno(_conn, _dados).ShowDialog();
        }

        private static bool DBExiste(string nomeDB)
        {
            SqlCommand cmd = new SqlCommand("SELECT db_id('" + nomeDB + "')", _conn);
            return (cmd.ExecuteScalar() != DBNull.Value);
        }



        private void Inicio_Load(object sender, EventArgs e)
        {
            try
            {
                _conn.Open();
                if (DBExiste("DBPalestras"))
                {
                    _url += " Initial Catalog=DBPalestras";
                    _conn = new SqlConnection(_url);

                }
                else
                {
                    MessageBox.Show("Um banco de dados será criado.");
                    SqlCommand cmd = new SqlCommand("CREATE DATABASE DBPalestras;", _conn);
                    cmd.ExecuteNonQuery();
                    _url += " Initial Catalog=DBPalestras";
                    _conn = new SqlConnection(_url);
                    _conn.Open();

                    string[] cmdsTabelas =
                    {
                        "CREATE TABLE[dbo].[Adms](" +
                            "[Id]    INT            IDENTITY(1, 1) NOT NULL," +
                            "[Nome]  NVARCHAR(50) NULL," +
                            "[Login] NVARCHAR(50) NOT NULL," +
                            "[Senha] NVARCHAR(50) NOT NULL" +
                        ");",
                        "INSERT INTO Adms values('Primeiro ADM', 'admin', 'admin');",
                        "CREATE TABLE[dbo].[Alunos](" +
                            "[Matricula] INT NOT NULL," +
                            "[Nome]      NVARCHAR(50) NOT NULL," +
                            "PRIMARY KEY CLUSTERED([Matricula] ASC)" +
                        ");",
                        "CREATE TABLE[dbo].[Matriculadas](" +
                            "[Matricula] INT NOT NULL," +
                            "[Palestra] VARCHAR(50) NOT NULL," +
                            "foreign key(Matricula) references Alunos(Matricula)" +
                        ");",
                        "CREATE TABLE[dbo].[Palestras](" +
                            "[Id]                   INT            IDENTITY(1, 1) NOT NULL," +
                            "[Nome]                 NVARCHAR(100) NOT NULL," +
                            "[Tema]                 NVARCHAR(100) NULL," +
                            "[Local]                NVARCHAR(100) NOT NULL," +
                            "[Palestrante]          NVARCHAR(50)  NOT NULL," +
                            "[LimiteParticipantes] INT            NOT NULL," +
                            "[Data]                 DATE           NOT NULL," +
                            "[Descricao]            NVARCHAR(500) NULL," +
                            "PRIMARY KEY CLUSTERED([Id] ASC)" +
                        ");",
                        "CREATE TABLE[dbo].[Palestrantes](" +
                            "[IdPalestrante] INT            IDENTITY(1, 1) NOT NULL," +
                            "[Nome]           NVARCHAR(50)  NOT NULL," +
                            "[Profissao]      NVARCHAR(100) NOT NULL," +
                            "[Curriculo]      NVARCHAR(500) NOT NULL," +
                            "PRIMARY KEY CLUSTERED([IdPalestrante] ASC)" +
                        ");"
                    };
                    foreach (String sqlCmd in cmdsTabelas)
                    {
                        SqlCommand cmdTabelas = new SqlCommand(sqlCmd, _conn);
                        cmdTabelas.ExecuteNonQuery();
                    }
                    MessageBox.Show("Banco de dados DBPalestras criado com sucesso.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir a conexão com o banco de dados: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Relatorios().ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void palestrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Relatorios().ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
