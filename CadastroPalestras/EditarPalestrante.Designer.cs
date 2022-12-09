namespace CadastroPalestras
{
    partial class EditarPalestrante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarPalestrante));
            this.btSalvar = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btFechar = new System.Windows.Forms.Button();
            this.tbProfissao = new System.Windows.Forms.TextBox();
            this.tbNomePalestrante = new System.Windows.Forms.TextBox();
            this.tbCurriculo = new System.Windows.Forms.RichTextBox();
            this.lbCurriculo = new System.Windows.Forms.Label();
            this.lbProfissao = new System.Windows.Forms.Label();
            this.lbNomePalestrante = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btSalvar
            // 
            this.btSalvar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvar.Location = new System.Drawing.Point(16, 471);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 23);
            this.btSalvar.TabIndex = 1;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpar.Location = new System.Drawing.Point(118, 471);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(75, 23);
            this.btLimpar.TabIndex = 2;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btFechar
            // 
            this.btFechar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFechar.Location = new System.Drawing.Point(776, 471);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(75, 23);
            this.btFechar.TabIndex = 3;
            this.btFechar.Text = "Fechar";
            this.btFechar.UseVisualStyleBackColor = true;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // tbProfissao
            // 
            this.tbProfissao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProfissao.Location = new System.Drawing.Point(81, 130);
            this.tbProfissao.Name = "tbProfissao";
            this.tbProfissao.Size = new System.Drawing.Size(760, 25);
            this.tbProfissao.TabIndex = 11;
            // 
            // tbNomePalestrante
            // 
            this.tbNomePalestrante.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNomePalestrante.Location = new System.Drawing.Point(81, 65);
            this.tbNomePalestrante.Name = "tbNomePalestrante";
            this.tbNomePalestrante.Size = new System.Drawing.Size(760, 25);
            this.tbNomePalestrante.TabIndex = 10;
            // 
            // tbCurriculo
            // 
            this.tbCurriculo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCurriculo.Location = new System.Drawing.Point(22, 228);
            this.tbCurriculo.Name = "tbCurriculo";
            this.tbCurriculo.Size = new System.Drawing.Size(819, 214);
            this.tbCurriculo.TabIndex = 9;
            this.tbCurriculo.Text = "";
            // 
            // lbCurriculo
            // 
            this.lbCurriculo.AutoSize = true;
            this.lbCurriculo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurriculo.Location = new System.Drawing.Point(22, 212);
            this.lbCurriculo.Name = "lbCurriculo";
            this.lbCurriculo.Size = new System.Drawing.Size(68, 17);
            this.lbCurriculo.TabIndex = 8;
            this.lbCurriculo.Text = "Currículo:";
            // 
            // lbProfissao
            // 
            this.lbProfissao.AutoSize = true;
            this.lbProfissao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProfissao.Location = new System.Drawing.Point(22, 137);
            this.lbProfissao.Name = "lbProfissao";
            this.lbProfissao.Size = new System.Drawing.Size(69, 17);
            this.lbProfissao.TabIndex = 7;
            this.lbProfissao.Text = "Profissão:";
            // 
            // lbNomePalestrante
            // 
            this.lbNomePalestrante.AutoSize = true;
            this.lbNomePalestrante.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomePalestrante.Location = new System.Drawing.Point(22, 65);
            this.lbNomePalestrante.Name = "lbNomePalestrante";
            this.lbNomePalestrante.Size = new System.Drawing.Size(49, 17);
            this.lbNomePalestrante.TabIndex = 6;
            this.lbNomePalestrante.Text = "Nome:";
            // 
            // EditarPalestrante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CadastroPalestras.Properties.Resources.degrade_1250;
            this.ClientSize = new System.Drawing.Size(863, 506);
            this.Controls.Add(this.tbProfissao);
            this.Controls.Add(this.tbNomePalestrante);
            this.Controls.Add(this.tbCurriculo);
            this.Controls.Add(this.lbCurriculo);
            this.Controls.Add(this.lbProfissao);
            this.Controls.Add(this.lbNomePalestrante);
            this.Controls.Add(this.btFechar);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btSalvar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditarPalestrante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Palestrante";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.EditarPalestrante_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.TextBox tbProfissao;
        private System.Windows.Forms.TextBox tbNomePalestrante;
        private System.Windows.Forms.RichTextBox tbCurriculo;
        private System.Windows.Forms.Label lbCurriculo;
        private System.Windows.Forms.Label lbProfissao;
        private System.Windows.Forms.Label lbNomePalestrante;
    }
}