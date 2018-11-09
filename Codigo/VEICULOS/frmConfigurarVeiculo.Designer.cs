namespace Tcc.VEICULOS
{
    partial class frmConfigurarVeiculo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.mtbEditar = new MetroFramework.Controls.MetroTabPage();
            this.btnAtualizar = new MaterialSkin.Controls.MaterialFlatButton();
            this.dgvVer = new MetroFramework.Controls.MetroGrid();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codFunc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brnDeletar = new MaterialSkin.Controls.MaterialFlatButton();
            this.metroTabControl1.SuspendLayout();
            this.mtbEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVer)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.mtbEditar);
            this.metroTabControl1.Location = new System.Drawing.Point(3, 62);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(870, 457);
            this.metroTabControl1.TabIndex = 4;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTabControl1.UseSelectable = true;
            // 
            // mtbEditar
            // 
            this.mtbEditar.Controls.Add(this.brnDeletar);
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
            // btnAtualizar
            // 
            this.btnAtualizar.AutoSize = true;
            this.btnAtualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAtualizar.Depth = 0;
            this.btnAtualizar.Location = new System.Drawing.Point(773, 360);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAtualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Primary = false;
            this.btnAtualizar.Size = new System.Drawing.Size(85, 36);
            this.btnAtualizar.TabIndex = 10;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvVer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.placa,
            this.modelo,
            this.marca,
            this.codFunc});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVer.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvVer.EnableHeadersVisualStyles = false;
            this.dgvVer.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvVer.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvVer.Location = new System.Drawing.Point(0, 3);
            this.dgvVer.Name = "dgvVer";
            this.dgvVer.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVer.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvVer.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvVer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVer.Size = new System.Drawing.Size(862, 348);
            this.dgvVer.TabIndex = 9;
            this.dgvVer.DoubleClick += new System.EventHandler(this.dgvVer_DoubleClick);
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "Codigo";
            this.codigo.HeaderText = "ID:";
            this.codigo.Name = "codigo";
            // 
            // placa
            // 
            this.placa.DataPropertyName = "Placa";
            this.placa.HeaderText = "Placa:";
            this.placa.Name = "placa";
            // 
            // modelo
            // 
            this.modelo.DataPropertyName = "Modelo";
            this.modelo.HeaderText = "Modelo:";
            this.modelo.Name = "modelo";
            // 
            // marca
            // 
            this.marca.DataPropertyName = "Marca";
            this.marca.HeaderText = "Marca:";
            this.marca.Name = "marca";
            // 
            // codFunc
            // 
            this.codFunc.DataPropertyName = "CodFuncionario";
            this.codFunc.HeaderText = "Id do funcionario:";
            this.codFunc.Name = "codFunc";
            // 
            // brnDeletar
            // 
            this.brnDeletar.AutoSize = true;
            this.brnDeletar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.brnDeletar.Depth = 0;
            this.brnDeletar.Location = new System.Drawing.Point(680, 360);
            this.brnDeletar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.brnDeletar.MouseState = MaterialSkin.MouseState.HOVER;
            this.brnDeletar.Name = "brnDeletar";
            this.brnDeletar.Primary = false;
            this.brnDeletar.Size = new System.Drawing.Size(70, 36);
            this.brnDeletar.TabIndex = 11;
            this.brnDeletar.Text = "Deletar";
            this.brnDeletar.UseVisualStyleBackColor = true;
            this.brnDeletar.Click += new System.EventHandler(this.brnDeletar_Click);
            // 
            // frmConfigurarVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 522);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "frmConfigurarVeiculo";
            this.Text = "Escolha um campo para editar ou excluir!";
            this.Load += new System.EventHandler(this.frmConfigurarVeiculo_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.mtbEditar.ResumeLayout(false);
            this.mtbEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage mtbEditar;
        private MetroFramework.Controls.MetroGrid dgvVer;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn codFunc;
        private MaterialSkin.Controls.MaterialFlatButton btnAtualizar;
        private MaterialSkin.Controls.MaterialFlatButton brnDeletar;
    }
}