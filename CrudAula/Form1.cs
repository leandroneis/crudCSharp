using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace CrudAula
{
    public partial class Locadora : Form
    {
        public Locadora()
        {
            InitializeComponent();
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void limparCampos()
        {
            tbNome.Clear();
            tbCategoria.Clear();
            tbDescricao.Clear();
            tbAno.Clear();

        }

        private void atualizarGrid() {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexaoBD = new MySqlConnection(conexaoBD.ToString());
            try {
                realizaConexaoBD.Open();
                MySqlCommand comandoMysql = realizaConexaoBD.CreateCommand();
                comandoMysql.CommandText = "SELECT * FROM LOCADORA WHERE ativoFilme = 1";
                MySqlDataReader reader = comandoMysql.ExecuteReader();
                dgLocadora.Rows.Clear();

                while (reader.Read()) 
                {
                    DataGridViewRow row = (DataGridViewRow)dgLocadora.Rows[0].Clone();
                    row.Cells[0].Value = reader.GetInt32(0);//Id
                    row.Cells[1].Value = reader.GetString(1);//Nome do Filme
                    row.Cells[2].Value = reader.GetString(2);//Descrição
                    row.Cells[3].Value = reader.GetString(3);//Categoria
                    row.Cells[4].Value = reader.GetString(4);//Ano
                    dgLocadora.Rows.Add(row);
                }
                realizaConexaoBD.Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Can not open Connection!");
            }
        }

        private MySqlConnectionStringBuilder conexaoBanco() 
        {
            MySqlConnectionStringBuilder conexaoBD = new MySqlConnectionStringBuilder();
            conexaoBD.Server = "127.0.1.1";
            conexaoBD.Database = "locadora";
            conexaoBD.UserID = "desenvolvimento";
            conexaoBD.Password = "$8h&1a]PKh.J";
            return conexaoBD;
        }

        private void Locadora_Load(object sender, EventArgs e)
        {
            atualizarGrid();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexaoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexaoBD.Open();
                MySqlCommand comandoMysql = realizaConexaoBD.CreateCommand();

                comandoMysql.CommandText = "INSERT INTO locadora(nomeFilme, descricaoFilme, categoriaFilme, anoFilme) " +
                    "VALUES('"+tbNome.Text+"', '"+tbDescricao.Text+"', '"+tbCategoria.Text+"','"+tbAno.Text+"')";
                comandoMysql.ExecuteReader();
                realizaConexaoBD.Close();
                MessageBox.Show("Inserido com sucesso!");
                atualizarGrid();
                limparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open Connection!");
            }
        }
    }
}
