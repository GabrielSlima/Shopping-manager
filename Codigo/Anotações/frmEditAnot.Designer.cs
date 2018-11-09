namespace Tcc.Anotações
{
    partial class frmEditAnot
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
            this.components = new System.ComponentModel.Container();
            this.mtAtualizar = new MetroFramework.Controls.MetroTile();
            this.mtSave = new MetroFramework.Controls.MetroTile();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // mtAtualizar
            // 
            this.mtAtualizar.ActiveControl = null;
            this.mtAtualizar.Location = new System.Drawing.Point(529, 262);
            this.mtAtualizar.Name = "mtAtualizar";
            this.mtAtualizar.Size = new System.Drawing.Size(137, 64);
            this.mtAtualizar.TabIndex = 8;
            this.mtAtualizar.Text = "Arualizar";
            this.mtAtualizar.UseSelectable = true;
            // 
            // mtSave
            // 
            this.mtSave.ActiveControl = null;
            this.mtSave.Location = new System.Drawing.Point(386, 262);
            this.mtSave.Name = "mtSave";
            this.mtSave.Size = new System.Drawing.Size(137, 64);
            this.mtSave.TabIndex = 7;
            this.mtSave.Text = "Salvar";
            this.mtSave.UseSelectable = true;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Green;
            // 
            // frmEditAnot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 332);
            this.Controls.Add(this.mtAtualizar);
            this.Controls.Add(this.mtSave);
            this.Name = "frmEditAnot";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.frmEditAnot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile mtAtualizar;
        private MetroFramework.Controls.MetroTile mtSave;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
    }
}