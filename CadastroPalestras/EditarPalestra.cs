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
    public partial class EditarPalestra : Form
    {
        private SqlConnection _conn { get; set; }
        private string _nome { get; set; }
        private string _palestrante { get; set; }
        private string _tema { get; set; }
        private string _local { get; set; }
        private int _limiteParticipantes { get; set; }
        private DateTime _data { get; set; }
        private string _descricao { get; set; }
        public EditarPalestra(SqlConnection conn, string nome, string palestrante, string tema, string local, int limiteParticipantes, DateTime data, string descricao)
        {
            _conn = conn;
            _nome = nome;
            _palestrante = palestrante;
            _tema = tema;
            _local = local;
            _limiteParticipantes = limiteParticipantes;
            _data = data;
            _descricao = descricao;
            InitializeComponent();
        }

        private void EditarPalestra_Load(object sender, EventArgs e)
        {
            tbNomePalestra.Text = _nome;
            tbPalestrante.Text = _palestrante;
            tbTema.Text = _tema;
            tbLocal.Text = _local;
            tbLimiteParticipantes.Text = _limiteParticipantes.ToString();
            dtData.Value = _data;
            tbDescricao.Text = _descricao;
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            tbNomePalestra.Clear();
            tbPalestrante.Clear();
            tbTema.Clear();
            tbLocal.Clear();
            tbLimiteParticipantes.Clear();
            tbDescricao.Clear();
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "UPDATE Palestras SET Nome=@nome, Palestrante=@palestrante, Tema=@tema, Local=@local, LimiteParticipantes=@limiteParticipantes, Data=@data, Descricao=@descricao WHERE Nome=@nomeAnterior AND Palestrante=@palestranteAnterior";
                SqlCommand cmd = new SqlCommand(sql, _conn);
                cmd.Parameters.AddWithValue("nome", tbNomePalestra.Text);
                cmd.Parameters.AddWithValue("palestrante", tbPalestrante.Text);
                cmd.Parameters.AddWithValue("tema", tbTema.Text);
                cmd.Parameters.AddWithValue("local", tbLocal.Text);
                cmd.Parameters.AddWithValue("limiteParticipantes", tbLimiteParticipantes.Text);
                cmd.Parameters.AddWithValue("data", dtData.Value);
                cmd.Parameters.AddWithValue("descricao", tbDescricao.Text);
                cmd.Parameters.AddWithValue("nomeAnterior", _nome);
                cmd.Parameters.AddWithValue("palestranteAnterior", _palestrante);
                cmd.ExecuteNonQuery();

                _nome = tbNomePalestra.Text;
                _palestrante = tbPalestrante.Text;
                _tema = tbTema.Text;
                _local = tbLocal.Text;
                _limiteParticipantes = Convert.ToInt32(tbLimiteParticipantes.Text);
                _data = dtData.Value;
                 _descricao = tbDescricao.Text;

                MessageBox.Show("A palestra " + _nome + " foi atualizada com sucesso.");

            }
            catch (SqlException a)
            {
                MessageBox.Show(a.ToString());
            }
        }
    }

}
