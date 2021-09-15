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
            tbId.Clear();

        }

        private void atualizarGrid() {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexaoBD = new MySqlConnection(conexaoBD.ToString());
            try {
                realizaConexaoBD.Open();
                MySqlCommand comandoMysql = realizaConexaoBD.CreateCommand();
                comandoMysql.CommandText = "SELECT id, nomeFilme, categoriaFilme, descricaoFilme, anoFilme FROM LOCADORA WHERE ativoFilme = 1";
                Console.WriteLine(comandoMysql.CommandText);
                MySqlDataReader reader = comandoMysql.ExecuteReader();
                dgLocadora.Rows.Clear();

                while (reader.Read()) 
                {
                    DataGridViewRow row = (DataGridViewRow)dgLocadora.Rows[0].Clone();
                    row.Cells[0].Value = reader.GetInt32(0);//Id
                    row.Cells[1].Value = reader.GetString(1);//Nome do Filme
                    row.Cells[2].Value = reader.GetString(2);//Categoria
                    row.Cells[3].Value = reader.GetString(3);//Descricao
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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexaoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexaoBD.Open();
                MySqlCommand comandoMysql = realizaConexaoBD.CreateCommand();

                comandoMysql.CommandText = "UPDATE locadora SET nomeFilme = '" + tbNome.Text + "' , " +
                    "descricaoFilme= '" + tbDescricao.Text + "' , " + 
                    "categoriaFilme='" + tbCategoria.Text + "' , "+
                    "anoFilme = '" + tbAno.Text + "' " +
                    "WHERE id = "+tbId.Text + "";
                
                Console.WriteLine(comandoMysql.CommandText);
                comandoMysql.ExecuteNonQuery();
                realizaConexaoBD.Close();
                MessageBox.Show("Atualizado com sucesso!");
                atualizarGrid();
                limparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open Connection!");
            }
        }

        private void btnInativar_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexaoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexaoBD.Open();
                MySqlCommand comandoMysql = realizaConexaoBD.CreateCommand();

                //Se quiser excluir do banco de dados o registro descomente a linha abaixo e comente a linha 134
                //comandoMysql.CommandText = "DELETE FROM locadora WHERE id = " + tbId.Text + "";
                comandoMysql.CommandText = "UPDATE locadora SET ativoFilme = 0 WHERE id = " + tbId.Text + "";
                Console.WriteLine(comandoMysql.CommandText);
                comandoMysql.ExecuteNonQuery();
                realizaConexaoBD.Close();
                MessageBox.Show("Deletado com sucesso!");
                atualizarGrid();
                limparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open Connection!");
            }
        }

        private void dgLocadora_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (e.ColumnIndex >= -1 && dgLocadora.Rows[e.RowIndex].Cells[0].Value != null) {
                    dgLocadora.CurrentRow.Selected = true;
                    tbId.Text = dgLocadora.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString();
                    tbNome.Text = dgLocadora.Rows[e.RowIndex].Cells["nome"].FormattedValue.ToString();
                    tbCategoria.Text = dgLocadora.Rows[e.RowIndex].Cells["categoria"].FormattedValue.ToString();
                    tbDescricao.Text = dgLocadora.Rows[e.RowIndex].Cells["descricao"].FormattedValue.ToString();
                    tbAno.Text = dgLocadora.Rows[e.RowIndex].Cells["ano"].FormattedValue.ToString();
                }
            }
        }
    }
}
