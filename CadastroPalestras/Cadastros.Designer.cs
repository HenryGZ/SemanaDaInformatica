namespace CadastroPalestras
{
    partial class Cadastros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastros));
            this.btSalvar = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btFechar = new System.Windows.Forms.Button();
            this.tpAdministradores = new System.Windows.Forms.TabPage();
            this.lbSenha = new System.Windows.Forms.Label();
            this.lbLogin = new System.Windows.Forms.Label();
            this.lbNomeAdm = new System.Windows.Forms.Label();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbNomeAdm = new System.Windows.Forms.TextBox();
            this.tpPalestras = new System.Windows.Forms.TabPage();
            this.tbLimiteParticipantes = new System.Windows.Forms.TextBox();
            this.tbDescricao = new System.Windows.Forms.RichTextBox();
            this.tbLocal = new System.Windows.Forms.TextBox();
            this.tbTema = new System.Windows.Forms.TextBox();
            this.tbPalestrante = new System.Windows.Forms.TextBox();
            this.tbNomePalestra = new System.Windows.Forms.TextBox();
            this.dtData = new System.Windows.Forms.DateTimePicker();
            this.lbDescricao = new System.Windows.Forms.Label();
            this.lbData = new System.Windows.Forms.Label();
            this.lbIdPalestra = new System.Windows.Forms.Label();
            this.lbNumeroPalestra = new System.Windows.Forms.Label();
            this.lbLocal = new System.Windows.Forms.Label();
            this.lbLimiteParticipantes = new System.Windows.Forms.Label();
            this.lbTema = new System.Windows.Forms.Label();
            this.lbPalestrante = new System.Windows.Forms.Label();
            this.lbNomePalestra = new System.Windows.Forms.Label();
            this.tpPalestrantes = new System.Windows.Forms.TabPage();
            this.tbProfissao = new System.Windows.Forms.TextBox();
            this.tbNomePalestrante = new System.Windows.Forms.TextBox();
            this.tbCurriculo = new System.Windows.Forms.RichTextBox();
            this.lbCurriculo = new System.Windows.Forms.Label();
            this.lbProfissao = new System.Windows.Forms.Label();
            this.lbNomePalestrante = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpAlunos = new System.Windows.Forms.TabPage();
            this.tbMatricula = new System.Windows.Forms.TextBox();
            this.tbNomeAluno = new System.Windows.Forms.TextBox();
            this.lbMatricula = new System.Windows.Forms.Label();
            this.lbNomeAluno = new System.Windows.Forms.Label();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.tpAdministradores.SuspendLayout();
            this.tpPalestras.SuspendLayout();
            this.tpPalestrantes.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpAlunos.SuspendLayout();
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
            // tpAdministradores
            // 
            this.tpAdministradores.Controls.Add(this.lbSenha);
            this.tpAdministradores.Controls.Add(this.lbLogin);
            this.tpAdministradores.Controls.Add(this.lbNomeAdm);
            this.tpAdministradores.Controls.Add(this.tbSenha);
            this.tpAdministradores.Controls.Add(this.tbLogin);
            this.tpAdministradores.Controls.Add(this.tbNomeAdm);
            this.tpAdministradores.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpAdministradores.Location = new System.Drawing.Point(4, 26);
            this.tpAdministradores.Name = "tpAdministradores";
            this.tpAdministradores.Padding = new System.Windows.Forms.Padding(3);
            this.tpAdministradores.Size = new System.Drawing.Size(831, 406);
            this.tpAdministradores.TabIndex = 2;
            this.tpAdministradores.Text = "Administradores";
            this.tpAdministradores.UseVisualStyleBackColor = true;
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSenha.Location = new System.Drawing.Point(6, 142);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(49, 17);
            this.lbSenha.TabIndex = 5;
            this.lbSenha.Text = "Senha:";
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogin.Location = new System.Drawing.Point(6, 91);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(47, 17);
            this.lbLogin.TabIndex = 4;
            this.lbLogin.Text = "Login:";
            // 
            // lbNomeAdm
            // 
            this.lbNomeAdm.AutoSize = true;
            this.lbNomeAdm.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeAdm.Location = new System.Drawing.Point(6, 46);
            this.lbNomeAdm.Name = "lbNomeAdm";
            this.lbNomeAdm.Size = new System.Drawing.Size(49, 17);
            this.lbNomeAdm.TabIndex = 3;
            this.lbNomeAdm.Text = "Nome:";
            // 
            // tbSenha
            // 
            this.tbSenha.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSenha.Location = new System.Drawing.Point(72, 139);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.Size = new System.Drawing.Size(753, 25);
            this.tbSenha.TabIndex = 2;
            // 
            // tbLogin
            // 
            this.tbLogin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLogin.Location = new System.Drawing.Point(72, 88);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(753, 25);
            this.tbLogin.TabIndex = 1;
            // 
            // tbNomeAdm
            // 
            this.tbNomeAdm.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNomeAdm.Location = new System.Drawing.Point(72, 43);
            this.tbNomeAdm.Name = "tbNomeAdm";
            this.tbNomeAdm.Size = new System.Drawing.Size(753, 25);
            this.tbNomeAdm.TabIndex = 0;
            // 
            // tpPalestras
            // 
            this.tpPalestras.Controls.Add(this.tbLimiteParticipantes);
            this.tpPalestras.Controls.Add(this.tbDescricao);
            this.tpPalestras.Controls.Add(this.tbLocal);
            this.tpPalestras.Controls.Add(this.tbTema);
            this.tpPalestras.Controls.Add(this.tbPalestrante);
            this.tpPalestras.Controls.Add(this.tbNomePalestra);
            this.tpPalestras.Controls.Add(this.dtData);
            this.tpPalestras.Controls.Add(this.lbDescricao);
            this.tpPalestras.Controls.Add(this.lbData);
            this.tpPalestras.Controls.Add(this.lbIdPalestra);
            this.tpPalestras.Controls.Add(this.lbNumeroPalestra);
            this.tpPalestras.Controls.Add(this.lbLocal);
            this.tpPalestras.Controls.Add(this.lbLimiteParticipantes);
            this.tpPalestras.Controls.Add(this.lbTema);
            this.tpPalestras.Controls.Add(this.lbPalestrante);
            this.tpPalestras.Controls.Add(this.lbNomePalestra);
            this.tpPalestras.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpPalestras.Location = new System.Drawing.Point(4, 26);
            this.tpPalestras.Name = "tpPalestras";
            this.tpPalestras.Padding = new System.Windows.Forms.Padding(3);
            this.tpPalestras.Size = new System.Drawing.Size(831, 406);
            this.tpPalestras.TabIndex = 1;
            this.tpPalestras.Text = "Palestras";
            this.tpPalestras.UseVisualStyleBackColor = true;
            // 
            // tbLimiteParticipantes
            // 
            this.tbLimiteParticipantes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLimiteParticipantes.Location = new System.Drawing.Point(167, 131);
            this.tbLimiteParticipantes.Name = "tbLimiteParticipantes";
            this.tbLimiteParticipantes.Size = new System.Drawing.Size(658, 25);
            this.tbLimiteParticipantes.TabIndex = 15;
            // 
            // tbDescricao
            // 
            this.tbDescricao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescricao.Location = new System.Drawing.Point(10, 261);
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(805, 143);
            this.tbDescricao.TabIndex = 13;
            this.tbDescricao.Text = "";
            // 
            // tbLocal
            // 
            this.tbLocal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLocal.Location = new System.Drawing.Point(90, 164);
            this.tbLocal.Name = "tbLocal";
            this.tbLocal.Size = new System.Drawing.Size(518, 25);
            this.tbLocal.TabIndex = 12;
            // 
            // tbTema
            // 
            this.tbTema.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTema.Location = new System.Drawing.Point(90, 84);
            this.tbTema.Name = "tbTema";
            this.tbTema.Size = new System.Drawing.Size(735, 25);
            this.tbTema.TabIndex = 11;
            // 
            // tbPalestrante
            // 
            this.tbPalestrante.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPalestrante.Location = new System.Drawing.Point(90, 45);
            this.tbPalestrante.Name = "tbPalestrante";
            this.tbPalestrante.Size = new System.Drawing.Size(735, 25);
            this.tbPalestrante.TabIndex = 10;
            // 
            // tbNomePalestra
            // 
            this.tbNomePalestra.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNomePalestra.Location = new System.Drawing.Point(90, 10);
            this.tbNomePalestra.Name = "tbNomePalestra";
            this.tbNomePalestra.Size = new System.Drawing.Size(735, 25);
            this.tbNomePalestra.TabIndex = 9;
            // 
            // dtData
            // 
            this.dtData.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtData.Location = new System.Drawing.Point(90, 203);
            this.dtData.Name = "dtData";
            this.dtData.Size = new System.Drawing.Size(260, 25);
            this.dtData.TabIndex = 14;
            // 
            // lbDescricao
            // 
            this.lbDescricao.AutoSize = true;
            this.lbDescricao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescricao.Location = new System.Drawing.Point(11, 245);
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.Size = new System.Drawing.Size(71, 17);
            this.lbDescricao.TabIndex = 8;
            this.lbDescricao.Text = "Descrição:";
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbData.Location = new System.Drawing.Point(11, 209);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(41, 17);
            this.lbData.TabIndex = 7;
            this.lbData.Text = "Data:";
            // 
            // lbIdPalestra
            // 
            this.lbIdPalestra.AutoSize = true;
            this.lbIdPalestra.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdPalestra.Location = new System.Drawing.Point(762, 171);
            this.lbIdPalestra.Name = "lbIdPalestra";
            this.lbIdPalestra.Size = new System.Drawing.Size(33, 17);
            this.lbIdPalestra.TabIndex = 6;
            this.lbIdPalestra.Text = "_____";
            // 
            // lbNumeroPalestra
            // 
            this.lbNumeroPalestra.AutoSize = true;
            this.lbNumeroPalestra.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumeroPalestra.Location = new System.Drawing.Point(627, 171);
            this.lbNumeroPalestra.Name = "lbNumeroPalestra";
            this.lbNumeroPalestra.Size = new System.Drawing.Size(134, 17);
            this.lbNumeroPalestra.TabIndex = 5;
            this.lbNumeroPalestra.Text = "Número da Palestra:";
            // 
            // lbLocal
            // 
            this.lbLocal.AutoSize = true;
            this.lbLocal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLocal.Location = new System.Drawing.Point(7, 171);
            this.lbLocal.Name = "lbLocal";
            this.lbLocal.Size = new System.Drawing.Size(44, 17);
            this.lbLocal.TabIndex = 4;
            this.lbLocal.Text = "Local:";
            // 
            // lbLimiteParticipantes
            // 
            this.lbLimiteParticipantes.AutoSize = true;
            this.lbLimiteParticipantes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLimiteParticipantes.Location = new System.Drawing.Point(7, 131);
            this.lbLimiteParticipantes.Name = "lbLimiteParticipantes";
            this.lbLimiteParticipantes.Size = new System.Drawing.Size(154, 17);
            this.lbLimiteParticipantes.TabIndex = 3;
            this.lbLimiteParticipantes.Text = "Limite de participantes:";
            // 
            // lbTema
            // 
            this.lbTema.AutoSize = true;
            this.lbTema.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTema.Location = new System.Drawing.Point(7, 91);
            this.lbTema.Name = "lbTema";
            this.lbTema.Size = new System.Drawing.Size(45, 17);
            this.lbTema.TabIndex = 2;
            this.lbTema.Text = "Tema:";
            // 
            // lbPalestrante
            // 
            this.lbPalestrante.AutoSize = true;
            this.lbPalestrante.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPalestrante.Location = new System.Drawing.Point(6, 52);
            this.lbPalestrante.Name = "lbPalestrante";
            this.lbPalestrante.Size = new System.Drawing.Size(81, 17);
            this.lbPalestrante.TabIndex = 1;
            this.lbPalestrante.Text = "Palestrante:";
            // 
            // lbNomePalestra
            // 
            this.lbNomePalestra.AutoSize = true;
            this.lbNomePalestra.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomePalestra.Location = new System.Drawing.Point(6, 13);
            this.lbNomePalestra.Name = "lbNomePalestra";
            this.lbNomePalestra.Size = new System.Drawing.Size(61, 17);
            this.lbNomePalestra.TabIndex = 0;
            this.lbNomePalestra.Text = "Palestra:";
            // 
            // tpPalestrantes
            // 
            this.tpPalestrantes.Controls.Add(this.tbProfissao);
            this.tpPalestrantes.Controls.Add(this.tbNomePalestrante);
            this.tpPalestrantes.Controls.Add(this.tbCurriculo);
            this.tpPalestrantes.Controls.Add(this.lbCurriculo);
            this.tpPalestrantes.Controls.Add(this.lbProfissao);
            this.tpPalestrantes.Controls.Add(this.lbNomePalestrante);
            this.tpPalestrantes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpPalestrantes.Location = new System.Drawing.Point(4, 26);
            this.tpPalestrantes.Name = "tpPalestrantes";
            this.tpPalestrantes.Padding = new System.Windows.Forms.Padding(3);
            this.tpPalestrantes.Size = new System.Drawing.Size(831, 406);
            this.tpPalestrantes.TabIndex = 0;
            this.tpPalestrantes.Text = "Palestrantes";
            this.tpPalestrantes.UseVisualStyleBackColor = true;
            // 
            // tbProfissao
            // 
            this.tbProfissao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProfissao.Location = new System.Drawing.Point(65, 92);
            this.tbProfissao.Name = "tbProfissao";
            this.tbProfissao.Size = new System.Drawing.Size(760, 25);
            this.tbProfissao.TabIndex = 5;
            // 
            // tbNomePalestrante
            // 
            this.tbNomePalestrante.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNomePalestrante.Location = new System.Drawing.Point(65, 27);
            this.tbNomePalestrante.Name = "tbNomePalestrante";
            this.tbNomePalestrante.Size = new System.Drawing.Size(760, 25);
            this.tbNomePalestrante.TabIndex = 4;
            // 
            // tbCurriculo
            // 
            this.tbCurriculo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCurriculo.Location = new System.Drawing.Point(6, 190);
            this.tbCurriculo.Name = "tbCurriculo";
            this.tbCurriculo.Size = new System.Drawing.Size(819, 214);
            this.tbCurriculo.TabIndex = 3;
            this.tbCurriculo.Text = "";
            // 
            // lbCurriculo
            // 
            this.lbCurriculo.AutoSize = true;
            this.lbCurriculo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurriculo.Location = new System.Drawing.Point(6, 174);
            this.lbCurriculo.Name = "lbCurriculo";
            this.lbCurriculo.Size = new System.Drawing.Size(68, 17);
            this.lbCurriculo.TabIndex = 2;
            this.lbCurriculo.Text = "Currículo:";
            // 
            // lbProfissao
            // 
            this.lbProfissao.AutoSize = true;
            this.lbProfissao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProfissao.Location = new System.Drawing.Point(6, 99);
            this.lbProfissao.Name = "lbProfissao";
            this.lbProfissao.Size = new System.Drawing.Size(69, 17);
            this.lbProfissao.TabIndex = 1;
            this.lbProfissao.Text = "Profissão:";
            // 
            // lbNomePalestrante
            // 
            this.lbNomePalestrante.AutoSize = true;
            this.lbNomePalestrante.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomePalestrante.Location = new System.Drawing.Point(6, 27);
            this.lbNomePalestrante.Name = "lbNomePalestrante";
            this.lbNomePalestrante.Size = new System.Drawing.Size(49, 17);
            this.lbNomePalestrante.TabIndex = 0;
            this.lbNomePalestrante.Text = "Nome:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpPalestrantes);
            this.tabControl1.Controls.Add(this.tpPalestras);
            this.tabControl1.Controls.Add(this.tpAdministradores);
            this.tabControl1.Controls.Add(this.tpAlunos);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(839, 436);
            this.tabControl1.TabIndex = 0;
            // 
            // tpAlunos
            // 
            this.tpAlunos.Controls.Add(this.tbMatricula);
            this.tpAlunos.Controls.Add(this.tbNomeAluno);
            this.tpAlunos.Controls.Add(this.lbMatricula);
            this.tpAlunos.Controls.Add(this.lbNomeAluno);
            this.tpAlunos.Location = new System.Drawing.Point(4, 26);
            this.tpAlunos.Name = "tpAlunos";
            this.tpAlunos.Size = new System.Drawing.Size(831, 406);
            this.tpAlunos.TabIndex = 3;
            this.tpAlunos.Text = "Alunos";
            this.tpAlunos.UseVisualStyleBackColor = true;
            // 
            // tbMatricula
            // 
            this.tbMatricula.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMatricula.Location = new System.Drawing.Point(86, 46);
            this.tbMatricula.Name = "tbMatricula";
            this.tbMatricula.Size = new System.Drawing.Size(739, 25);
            this.tbMatricula.TabIndex = 11;
            // 
            // tbNomeAluno
            // 
            this.tbNomeAluno.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNomeAluno.Location = new System.Drawing.Point(86, 15);
            this.tbNomeAluno.Name = "tbNomeAluno";
            this.tbNomeAluno.Size = new System.Drawing.Size(739, 25);
            this.tbNomeAluno.TabIndex = 10;
            // 
            // lbMatricula
            // 
            this.lbMatricula.AutoSize = true;
            this.lbMatricula.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMatricula.Location = new System.Drawing.Point(6, 53);
            this.lbMatricula.Name = "lbMatricula";
            this.lbMatricula.Size = new System.Drawing.Size(66, 17);
            this.lbMatricula.TabIndex = 7;
            this.lbMatricula.Text = "Matrícula";
            // 
            // lbNomeAluno
            // 
            this.lbNomeAluno.AutoSize = true;
            this.lbNomeAluno.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeAluno.Location = new System.Drawing.Point(6, 23);
            this.lbNomeAluno.Name = "lbNomeAluno";
            this.lbNomeAluno.Size = new System.Drawing.Size(49, 17);
            this.lbNomeAluno.TabIndex = 6;
            this.lbNomeAluno.Text = "Nome:";
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(218, 471);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(75, 23);
            this.btExcluir.TabIndex = 4;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btEditar
            // 
            this.btEditar.Location = new System.Drawing.Point(318, 470);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(75, 23);
            this.btEditar.TabIndex = 5;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // Cadastros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackgroundImage = global::CadastroPalestras.Properties.Resources.degrade_1250;
            this.ClientSize = new System.Drawing.Size(863, 506);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btFechar);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cadastros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastros";
            this.Load += new System.EventHandler(this.Cadastros_Load);
            this.tpAdministradores.ResumeLayout(false);
            this.tpAdministradores.PerformLayout();
            this.tpPalestras.ResumeLayout(false);
            this.tpPalestras.PerformLayout();
            this.tpPalestrantes.ResumeLayout(false);
            this.tpPalestrantes.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tpAlunos.ResumeLayout(false);
            this.tpAlunos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.TabPage tpAdministradores;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Label lbNomeAdm;
        private System.Windows.Forms.TextBox tbSenha;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbNomeAdm;
        private System.Windows.Forms.TabPage tpPalestras;
        private System.Windows.Forms.TextBox tbLimiteParticipantes;
        private System.Windows.Forms.RichTextBox tbDescricao;
        private System.Windows.Forms.TextBox tbLocal;
        private System.Windows.Forms.TextBox tbTema;
        private System.Windows.Forms.TextBox tbPalestrante;
        private System.Windows.Forms.TextBox tbNomePalestra;
        private System.Windows.Forms.DateTimePicker dtData;
        private System.Windows.Forms.Label lbDescricao;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.Label lbIdPalestra;
        private System.Windows.Forms.Label lbNumeroPalestra;
        private System.Windows.Forms.Label lbLocal;
        private System.Windows.Forms.Label lbLimiteParticipantes;
        private System.Windows.Forms.Label lbTema;
        private System.Windows.Forms.Label lbPalestrante;
        private System.Windows.Forms.Label lbNomePalestra;
        private System.Windows.Forms.TabPage tpPalestrantes;
        private System.Windows.Forms.TextBox tbProfissao;
        private System.Windows.Forms.TextBox tbNomePalestrante;
        private System.Windows.Forms.RichTextBox tbCurriculo;
        private System.Windows.Forms.Label lbCurriculo;
        private System.Windows.Forms.Label lbProfissao;
        private System.Windows.Forms.Label lbNomePalestrante;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpAlunos;
        private System.Windows.Forms.TextBox tbMatricula;
        private System.Windows.Forms.TextBox tbNomeAluno;
        private System.Windows.Forms.Label lbMatricula;
        private System.Windows.Forms.Label lbNomeAluno;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btEditar;
    }
}