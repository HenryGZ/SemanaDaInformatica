namespace CadastroPalestras
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loginADMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.áreaDoAlunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.palestrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = global::CadastroPalestras.Properties.Resources.degrade_1250;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginADMToolStripMenuItem,
            this.áreaDoAlunoToolStripMenuItem,
            this.palestrasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(535, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loginADMToolStripMenuItem
            // 
            this.loginADMToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.loginADMToolStripMenuItem.Name = "loginADMToolStripMenuItem";
            this.loginADMToolStripMenuItem.Size = new System.Drawing.Size(90, 21);
            this.loginADMToolStripMenuItem.Text = "Login ADM";
            this.loginADMToolStripMenuItem.Click += new System.EventHandler(this.loginADMToolStripMenuItem_Click);
            // 
            // áreaDoAlunoToolStripMenuItem
            // 
            this.áreaDoAlunoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.áreaDoAlunoToolStripMenuItem.Name = "áreaDoAlunoToolStripMenuItem";
            this.áreaDoAlunoToolStripMenuItem.Size = new System.Drawing.Size(111, 21);
            this.áreaDoAlunoToolStripMenuItem.Text = "Área Do Aluno";
            this.áreaDoAlunoToolStripMenuItem.Click += new System.EventHandler(this.áreaDoAlunoToolStripMenuItem_Click);
            // 
            // palestrasToolStripMenuItem
            // 
            this.palestrasToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.palestrasToolStripMenuItem.Name = "palestrasToolStripMenuItem";
            this.palestrasToolStripMenuItem.Size = new System.Drawing.Size(75, 21);
            this.palestrasToolStripMenuItem.Text = "Palestras";
            this.palestrasToolStripMenuItem.Click += new System.EventHandler(this.palestrasToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(-6, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(545, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "SEMANA DA INFORMÁTICA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(867, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::CadastroPalestras.Properties.Resources._68984377806c969d9504f0faaaede75f_silhueta_de_computador;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(535, 430);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::CadastroPalestras.Properties.Resources.degrade_1250;
            this.ClientSize = new System.Drawing.Size(535, 430);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Início";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loginADMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem áreaDoAlunoToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem palestrasToolStripMenuItem;
    }
}

