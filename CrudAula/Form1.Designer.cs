
namespace CrudAula
{
    partial class Locadora
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbNome = new System.Windows.Forms.Label();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.lbDescricao = new System.Windows.Forms.Label();
            this.lbAno = new System.Windows.Forms.Label();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbCategoria = new System.Windows.Forms.TextBox();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.tbAno = new System.Windows.Forms.TextBox();
            this.dgLocadora = new System.Windows.Forms.DataGridView();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.tbId = new System.Windows.Forms.TextBox();
            this.lbId = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgLocadora)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(56, 29);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(38, 13);
            this.lbNome.TabIndex = 0;
            this.lbNome.Text = "Nome:";
            // 
            // lbCategoria
            // 
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.Location = new System.Drawing.Point(217, 29);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(55, 13);
            this.lbCategoria.TabIndex = 1;
            this.lbCategoria.Text = "Categoria:";
            // 
            // lbDescricao
            // 
            this.lbDescricao.AutoSize = true;
            this.lbDescricao.Location = new System.Drawing.Point(381, 29);
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.Size = new System.Drawing.Size(58, 13);
            this.lbDescricao.TabIndex = 2;
            this.lbDescricao.Text = "Descricao:";
            // 
            // lbAno
            // 
            this.lbAno.AutoSize = true;
            this.lbAno.Location = new System.Drawing.Point(671, 29);
            this.lbAno.Name = "lbAno";
            this.lbAno.Size = new System.Drawing.Size(29, 13);
            this.lbAno.TabIndex = 3;
            this.lbAno.Text = "Ano:";
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(189, 97);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(75, 23);
            this.btLimpar.TabIndex = 4;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(108, 97);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 5;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(56, 49);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(158, 20);
            this.tbNome.TabIndex = 8;
            // 
            // tbCategoria
            // 
            this.tbCategoria.Location = new System.Drawing.Point(220, 49);
            this.tbCategoria.Name = "tbCategoria";
            this.tbCategoria.Size = new System.Drawing.Size(158, 20);
            this.tbCategoria.TabIndex = 9;
            // 
            // tbDescricao
            // 
            this.tbDescricao.Location = new System.Drawing.Point(384, 49);
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(284, 20);
            this.tbDescricao.TabIndex = 10;
            // 
            // tbAno
            // 
            this.tbAno.Location = new System.Drawing.Point(674, 49);
            this.tbAno.Name = "tbAno";
            this.tbAno.Size = new System.Drawing.Size(73, 20);
            this.tbAno.TabIndex = 11;
            // 
            // dgLocadora
            // 
            this.dgLocadora.AllowUserToDeleteRows = false;
            this.dgLocadora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLocadora.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nome,
            this.categoria,
            this.descricao,
            this.ano});
            this.dgLocadora.Location = new System.Drawing.Point(12, 150);
            this.dgLocadora.Name = "dgLocadora";
            this.dgLocadora.ReadOnly = true;
            this.dgLocadora.Size = new System.Drawing.Size(777, 289);
            this.dgLocadora.TabIndex = 12;
            this.dgLocadora.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgLocadora_CellContentClick);
            this.dgLocadora.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgLocadora_CellContentClick);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(272, 97);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 13;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(353, 97);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(75, 23);
            this.btnDeletar.TabIndex = 14;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // tbId
            // 
            this.tbId.Enabled = false;
            this.tbId.Location = new System.Drawing.Point(12, 49);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(38, 20);
            this.tbId.TabIndex = 16;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(12, 29);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(19, 13);
            this.lbId.TabIndex = 15;
            this.lbId.Text = "Id:";
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 30;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "nomeFilme";
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 170;
            // 
            // categoria
            // 
            this.categoria.DataPropertyName = "categoriaFilme";
            this.categoria.HeaderText = "Categoria";
            this.categoria.Name = "categoria";
            this.categoria.ReadOnly = true;
            this.categoria.Width = 150;
            // 
            // descricao
            // 
            this.descricao.DataPropertyName = "descricaoFilme";
            this.descricao.HeaderText = "Descricao";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            this.descricao.Width = 300;
            // 
            // ano
            // 
            this.ano.DataPropertyName = "anoFilme";
            this.ano.HeaderText = "Ano";
            this.ano.Name = "ano";
            this.ano.ReadOnly = true;
            // 
            // Locadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.dgLocadora);
            this.Controls.Add(this.tbAno);
            this.Controls.Add(this.tbDescricao);
            this.Controls.Add(this.tbCategoria);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.lbAno);
            this.Controls.Add(this.lbDescricao);
            this.Controls.Add(this.lbCategoria);
            this.Controls.Add(this.lbNome);
            this.Name = "Locadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Locadora";
            this.Load += new System.EventHandler(this.Locadora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgLocadora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbCategoria;
        private System.Windows.Forms.Label lbDescricao;
        private System.Windows.Forms.Label lbAno;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbCategoria;
        private System.Windows.Forms.TextBox tbDescricao;
        private System.Windows.Forms.TextBox tbAno;
        private System.Windows.Forms.DataGridView dgLocadora;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ano;
    }
}

