namespace Projeto_Menus
{
    partial class frmPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.mnuprincipal = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.configuraçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exercíciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cálculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iMCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cálculoTemperaturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.calculadoraWindowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.professorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.cursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administraçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.mostrarBarraDeStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblData = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblVersao = new System.Windows.Forms.ToolStripStatusLabel();
            this.process1 = new System.Diagnostics.Process();
            this.tmrHora = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnCalc = new System.Windows.Forms.ToolStripButton();
            this.btnSalvarComo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSair = new System.Windows.Forms.ToolStripButton();
            this.mnuprincipal.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuprincipal
            // 
            this.mnuprincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuprincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.exercíciosToolStripMenuItem,
            this.cadastroToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.mnuprincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuprincipal.Name = "mnuprincipal";
            this.mnuprincipal.Size = new System.Drawing.Size(1238, 28);
            this.mnuprincipal.TabIndex = 0;
            this.mnuprincipal.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.novoToolStripMenuItem,
            this.toolStripMenuItem1,
            this.salvarToolStripMenuItem,
            this.salvarComoToolStripMenuItem,
            this.toolStripMenuItem2,
            this.configuraçãoToolStripMenuItem});
            this.arquivoToolStripMenuItem.Image = global::Projeto_Menus.Properties.Resources.folder_open;
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.arquivoToolStripMenuItem.Text = "&Arquivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(275, 26);
            this.abrirToolStripMenuItem.Text = "Abrir";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(275, 26);
            this.novoToolStripMenuItem.Text = "Novo";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(272, 6);
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(275, 26);
            this.salvarToolStripMenuItem.Text = "Salvar";
            // 
            // salvarComoToolStripMenuItem
            // 
            this.salvarComoToolStripMenuItem.Name = "salvarComoToolStripMenuItem";
            this.salvarComoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.salvarComoToolStripMenuItem.Size = new System.Drawing.Size(275, 26);
            this.salvarComoToolStripMenuItem.Text = "Salvar Como...";
            this.salvarComoToolStripMenuItem.Click += new System.EventHandler(this.salvarComoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(272, 6);
            // 
            // configuraçãoToolStripMenuItem
            // 
            this.configuraçãoToolStripMenuItem.Name = "configuraçãoToolStripMenuItem";
            this.configuraçãoToolStripMenuItem.Size = new System.Drawing.Size(275, 26);
            this.configuraçãoToolStripMenuItem.Text = "Configuração";
            // 
            // exercíciosToolStripMenuItem
            // 
            this.exercíciosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cálculoToolStripMenuItem,
            this.iMCToolStripMenuItem,
            this.cálculoTemperaturaToolStripMenuItem,
            this.calculadoraToolStripMenuItem,
            this.toolStripMenuItem3,
            this.calculadoraWindowsToolStripMenuItem});
            this.exercíciosToolStripMenuItem.Image = global::Projeto_Menus.Properties.Resources.application_side_expand;
            this.exercíciosToolStripMenuItem.Name = "exercíciosToolStripMenuItem";
            this.exercíciosToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.exercíciosToolStripMenuItem.Text = "&Exercícios";
            // 
            // cálculoToolStripMenuItem
            // 
            this.cálculoToolStripMenuItem.Name = "cálculoToolStripMenuItem";
            this.cálculoToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.cálculoToolStripMenuItem.Text = "Cálculo IMC";
            // 
            // iMCToolStripMenuItem
            // 
            this.iMCToolStripMenuItem.Name = "iMCToolStripMenuItem";
            this.iMCToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.iMCToolStripMenuItem.Text = "Cálculo Ferradura";
            // 
            // cálculoTemperaturaToolStripMenuItem
            // 
            this.cálculoTemperaturaToolStripMenuItem.Name = "cálculoTemperaturaToolStripMenuItem";
            this.cálculoTemperaturaToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.cálculoTemperaturaToolStripMenuItem.Text = "Cálculo Temperatura";
            // 
            // calculadoraToolStripMenuItem
            // 
            this.calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            this.calculadoraToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.calculadoraToolStripMenuItem.Text = "Calculadora";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(233, 6);
            // 
            // calculadoraWindowsToolStripMenuItem
            // 
            this.calculadoraWindowsToolStripMenuItem.Name = "calculadoraWindowsToolStripMenuItem";
            this.calculadoraWindowsToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.calculadoraWindowsToolStripMenuItem.Text = "Calculadora Windows";
            this.calculadoraWindowsToolStripMenuItem.Click += new System.EventHandler(this.calculadoraWindowsToolStripMenuItem_Click);
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alunoToolStripMenuItem,
            this.professorToolStripMenuItem,
            this.toolStripMenuItem4,
            this.cursoToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.cadastroToolStripMenuItem.Text = "&Cadastro";
            // 
            // alunoToolStripMenuItem
            // 
            this.alunoToolStripMenuItem.Name = "alunoToolStripMenuItem";
            this.alunoToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.alunoToolStripMenuItem.Text = "Aluno";
            // 
            // professorToolStripMenuItem
            // 
            this.professorToolStripMenuItem.Name = "professorToolStripMenuItem";
            this.professorToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.professorToolStripMenuItem.Text = "Professor";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(150, 6);
            // 
            // cursoToolStripMenuItem
            // 
            this.cursoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administraçãoToolStripMenuItem,
            this.rHToolStripMenuItem,
            this.dSToolStripMenuItem});
            this.cursoToolStripMenuItem.Name = "cursoToolStripMenuItem";
            this.cursoToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.cursoToolStripMenuItem.Text = "Curso";
            // 
            // administraçãoToolStripMenuItem
            // 
            this.administraçãoToolStripMenuItem.Name = "administraçãoToolStripMenuItem";
            this.administraçãoToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.administraçãoToolStripMenuItem.Text = "Administração";
            // 
            // rHToolStripMenuItem
            // 
            this.rHToolStripMenuItem.Name = "rHToolStripMenuItem";
            this.rHToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.rHToolStripMenuItem.Text = "RH";
            // 
            // dSToolStripMenuItem
            // 
            this.dSToolStripMenuItem.Name = "dSToolStripMenuItem";
            this.dSToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.dSToolStripMenuItem.Text = "DS";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualSistemaToolStripMenuItem,
            this.sobreToolStripMenuItem,
            this.toolStripMenuItem5,
            this.mostrarBarraDeStatusToolStripMenuItem,
            this.toolStripMenuItem6,
            this.sairToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.ajudaToolStripMenuItem.Text = "Aj&uda";
            // 
            // manualSistemaToolStripMenuItem
            // 
            this.manualSistemaToolStripMenuItem.Image = global::Projeto_Menus.Properties.Resources.doc_pdf;
            this.manualSistemaToolStripMenuItem.Name = "manualSistemaToolStripMenuItem";
            this.manualSistemaToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.manualSistemaToolStripMenuItem.Text = "Manual Sistema";
            this.manualSistemaToolStripMenuItem.Click += new System.EventHandler(this.manualSistemaToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.sobreToolStripMenuItem.Text = "Sobre...";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(244, 6);
            // 
            // mostrarBarraDeStatusToolStripMenuItem
            // 
            this.mostrarBarraDeStatusToolStripMenuItem.Checked = true;
            this.mostrarBarraDeStatusToolStripMenuItem.CheckOnClick = true;
            this.mostrarBarraDeStatusToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mostrarBarraDeStatusToolStripMenuItem.Name = "mostrarBarraDeStatusToolStripMenuItem";
            this.mostrarBarraDeStatusToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.mostrarBarraDeStatusToolStripMenuItem.Text = "Mostrar Barra de Status";
            this.mostrarBarraDeStatusToolStripMenuItem.Click += new System.EventHandler(this.mostrarBarraDeStatusToolStripMenuItem_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(244, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.sairToolStripMenuItem.Text = "&Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUsuario,
            this.lblData,
            this.lblHora,
            this.lblVersao});
            this.statusStrip1.Location = new System.Drawing.Point(0, 743);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1238, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblUsuario
            // 
            this.lblUsuario.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(4, 16);
            // 
            // lblData
            // 
            this.lblData.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(4, 16);
            // 
            // lblHora
            // 
            this.lblHora.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(4, 16);
            // 
            // lblVersao
            // 
            this.lblVersao.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(4, 16);
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // tmrHora
            // 
            this.tmrHora.Enabled = true;
            this.tmrHora.Interval = 1000;
            this.tmrHora.Tick += new System.EventHandler(this.tmrHora_Tick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCalc,
            this.btnSalvarComo,
            this.toolStripSeparator1,
            this.btnSair});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1238, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnCalc
            // 
            this.btnCalc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCalc.Image = ((System.Drawing.Image)(resources.GetObject("btnCalc.Image")));
            this.btnCalc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(29, 24);
            this.btnCalc.Text = "Calculadora Windows";
            this.btnCalc.Click += new System.EventHandler(this.calculadoraWindowsToolStripMenuItem_Click);
            // 
            // btnSalvarComo
            // 
            this.btnSalvarComo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSalvarComo.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvarComo.Image")));
            this.btnSalvarComo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvarComo.Name = "btnSalvarComo";
            this.btnSalvarComo.Size = new System.Drawing.Size(29, 24);
            this.btnSalvarComo.Text = "Salvar Como";
            this.btnSalvarComo.Click += new System.EventHandler(this.salvarComoToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // btnSair
            // 
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(58, 24);
            this.btnSair.Text = "Sair";
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 765);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mnuprincipal);
            this.MainMenuStrip = this.mnuprincipal;
            this.Name = "frmPrincipal";
            this.mnuprincipal.ResumeLayout(false);
            this.mnuprincipal.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuprincipal;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarComoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem configuraçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exercíciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cálculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iMCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cálculoTemperaturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculadoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem calculadoraWindowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem professorToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem cursoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administraçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem mostrarBarraDeStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblUsuario;
        private System.Windows.Forms.ToolStripStatusLabel lblData;
        private System.Windows.Forms.ToolStripStatusLabel lblHora;
        private System.Windows.Forms.ToolStripStatusLabel lblVersao;
        private System.Diagnostics.Process process1;
        private System.Windows.Forms.Timer tmrHora;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnCalc;
        private System.Windows.Forms.ToolStripButton btnSalvarComo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnSair;
    }
}

