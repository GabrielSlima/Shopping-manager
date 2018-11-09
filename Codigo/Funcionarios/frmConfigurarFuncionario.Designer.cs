namespace Tcc.Funcionarios
{
    partial class frmConfigurarFuncionario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mtArualizar = new MetroFramework.Controls.MetroTabControl();
            this.mtbEditar = new MetroFramework.Controls.MetroTabPage();
            this.btnDeletar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnAtualizar = new MaterialSkin.Controls.MaterialFlatButton();
            this.dgvVer = new MetroFramework.Controls.MetroGrid();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.complemento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mtArualizar.SuspendLayout();
            this.mtbEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVer)).BeginInit();
            this.SuspendLayout();
            // 
            // mtArualizar
            // 
            this.mtArualizar.Controls.Add(this.mtbEditar);
            this.mtArualizar.Location = new System.Drawing.Point(9, 63);
            this.mtArualizar.Name = "mtArualizar";
            this.mtArualizar.SelectedIndex = 0;
            this.mtArualizar.Size = new System.Drawing.Size(870, 457);
            this.mtArualizar.TabIndex = 3;
            this.mtArualizar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtArualizar.UseSelectable = true;
            // 
            // mtbEditar
            // 
            this.mtbEditar.Controls.Add(this.btnDeletar);
            this.mtbEditar.Controls.Add(this.btnAtualizar);
            this.mtbEditar.Controls.Add(this.dgvVer);
            this.mtbEditar.HorizontalScrollbarBarColor = true;
            this.mtbEditar.HorizontalScrollbarHighlightOnWheel = false;
            this.mtbEditar.HorizontalScrollbarSize = 10;
            this.mtbEditar.Location = new System.Drawing.Point(4, 38);
            this.mtbEditar.Name = "mtbEditar";
            this.mtbEditar.Size = new System.Drawing.Size(862, 415);
            this.mtbEditar.TabIndex = 0;
            this.mtbEditar.Text = "Editar";
            this.mtbEditar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbEditar.VerticalScrollbarBarColor = true;
            this.mtbEditar.VerticalScrollbarHighlightOnWheel = false;
            this.mtbEditar.VerticalScrollbarSize = 10;
            // 
            // btnDeletar
            // 
            this.btnDeletar.AutoSize = true;
            this.btnDeletar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeletar.Depth = 0;
            this.btnDeletar.Location = new System.Drawing.Point(669, 363);
            this.btnDeletar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDeletar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Primary = false;
            this.btnDeletar.Size = new System.Drawing.Size(70, 36);
            this.btnDeletar.TabIndex = 9;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.AutoSize = true;
            this.btnAtualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAtualizar.Depth = 0;
            this.btnAtualizar.Location = new System.Drawing.Point(762, 363);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAtualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Primary = false;
            this.btnAtualizar.Size = new System.Drawing.Size(85, 36);
            this.btnAtualizar.TabIndex = 8;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // dgvVer
            // 
            this.dgvVer.AllowUserToResizeRows = false;
            this.dgvVer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvVer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvVer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nome,
            this.endereco,
            this.cidade,
            this.telefone,
            this.celular,
            this.sexo,
            this.cargo,
            this.cpf,
            this.rg,
            this.turno,
            this.complemento,
            this.email});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVer.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVer.EnableHeadersVisualStyles = false;
            this.dgvVer.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvVer.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvVer.Location = new System.Drawing.Point(0, 3);
            this.dgvVer.Name = "dgvVer";
            this.dgvVer.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVer.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvVer.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvVer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVer.Size = new System.Drawing.Size(862, 327);
            this.dgvVer.TabIndex = 7;
            this.dgvVer.Theme = MetroFramework.MetroThemeStyle.Light;
            this.dgvVer.DoubleClick += new System.EventHandler(this.dgvVer_DoubleClick);
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "Codigo";
            this.codigo.HeaderText = "ID:";
            this.codigo.Name = "codigo";
            // 
            // nome
            // 
            this.nome.DataPropertyName = "Nome";
            this.nome.HeaderText = "Nome:";
            this.nome.Name = "nome";
            // 
            // endereco
            // 
            this.endereco.DataPropertyName = "Endereco";
            this.endereco.HeaderText = "Endereço:";
            this.endereco.Name = "endereco";
            // 
            // cidade
            // 
            this.cidade.DataPropertyName = "Cidade";
            this.cidade.HeaderText = "Cidade:";
            this.cidade.Name = "cidade";
            // 
            // telefone
            // 
            this.telefone.DataPropertyName = "Telefone";
            this.telefone.HeaderText = "Telefone:";
            this.telefone.Name = "telefone";
            // 
            // celular
            // 
            this.celular.DataPropertyName = "Celular";
            this.celular.HeaderText = "Celular:";
            this.celular.Name = "celular";
            // 
            // sexo
            // 
            this.sexo.DataPropertyName = "Sexo";
            this.sexo.HeaderText = "Sexo:";
            this.sexo.Name = "sexo";
            // 
            // cargo
            // 
            this.cargo.DataPropertyName = "Cargo";
            this.cargo.HeaderText = "Cargo:";
            this.cargo.Name = "cargo";
            // 
            // cpf
            // 
            this.cpf.DataPropertyName = "Cpf";
            this.cpf.HeaderText = "CPF:";
            this.cpf.Name = "cpf";
            // 
            // rg
            // 
            this.rg.DataPropertyName = "Rg";
            this.rg.HeaderText = "RG:";
            this.rg.Name = "rg";
            // 
            // turno
            // 
            this.turno.DataPropertyName = "Turno";
            this.turno.HeaderText = "Turno:";
            this.turno.Name = "turno";
            // 
            // complemento
            // 
            this.complemento.DataPropertyName = "Complemento";
            this.complemento.HeaderText = "Complemento:";
            this.complemento.Name = "complemento";
            // 
            // email
            // 
            this.email.DataPropertyName = "Email";
            this.email.HeaderText = "Email:";
            this.email.Name = "email";
            // 
            // frmConfigurarFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 526);
            this.Controls.Add(this.mtArualizar);
            this.Name = "frmConfigurarFuncionario";
            this.Text = "Escolha um campo para editar ou excluir!";
            this.Load += new System.EventHandler(this.frmConfigurarFuncionario_Load);
            this.mtArualizar.ResumeLayout(false);
            this.mtbEditar.ResumeLayout(false);
            this.mtbEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl mtArualizar;
        private MetroFramework.Controls.MetroTabPage mtbEditar;
        private MetroFramework.Controls.MetroGrid dgvVer;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn rg;
        private System.Windows.Forms.DataGridViewTextBoxColumn turno;
        private System.Windows.Forms.DataGridViewTextBoxColumn complemento;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private MaterialSkin.Controls.MaterialFlatButton btnAtualizar;
        private MaterialSkin.Controls.MaterialFlatButton btnDeletar;
    }
}