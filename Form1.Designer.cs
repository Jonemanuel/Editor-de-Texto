namespace EditorTXT
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.mArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.mArquivoNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.mArquivoNovaJanela = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mArquivoAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.mArquivoSalvar = new System.Windows.Forms.ToolStripMenuItem();
            this.mArquivoSalvarComo = new System.Windows.Forms.ToolStripMenuItem();
            this.mArquivoSair = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditarDesfazer = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditarRefazer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mEditarRecortar = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditarCopiar = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditarColar = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditarExcluir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mEditarDataHora = new System.Windows.Forms.ToolStripMenuItem();
            this.mFormatar = new System.Windows.Forms.ToolStripMenuItem();
            this.mFormatarQuebraAutomaticadeLinha = new System.Windows.Forms.ToolStripMenuItem();
            this.mFormatarFonte = new System.Windows.Forms.ToolStripMenuItem();
            this.mExibir = new System.Windows.Forms.ToolStripMenuItem();
            this.mExibirZoom = new System.Windows.Forms.ToolStripMenuItem();
            this.mExibirZoomAmplicar = new System.Windows.Forms.ToolStripMenuItem();
            this.mExibirZoomReduzir = new System.Windows.Forms.ToolStripMenuItem();
            this.mExibirZoomRestaurar = new System.Windows.Forms.ToolStripMenuItem();
            this.mExibirBarradeStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.mAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.mAjudaExibirAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.mAjudaSobreEditordeTexto = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusBarLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.txtConteudo = new System.Windows.Forms.RichTextBox();
            this.toolBarNovo = new System.Windows.Forms.ToolStripButton();
            this.toolBarAbrir = new System.Windows.Forms.ToolStripButton();
            this.toolBarSalvar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBarForFonte = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBarZoom = new System.Windows.Forms.ToolStripButton();
            this.toolBarZoomMenos = new System.Windows.Forms.ToolStripButton();
            this.toolBarZoomMais = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBarAjuda = new System.Windows.Forms.ToolStripButton();
            this.menuBar.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mArquivo,
            this.mEditar,
            this.mFormatar,
            this.mExibir,
            this.mAjuda});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(784, 29);
            this.menuBar.TabIndex = 0;
            this.menuBar.Text = "menuStrip1";
            // 
            // mArquivo
            // 
            this.mArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mArquivoNovo,
            this.mArquivoNovaJanela,
            this.toolStripSeparator1,
            this.mArquivoAbrir,
            this.mArquivoSalvar,
            this.mArquivoSalvarComo,
            this.mArquivoSair});
            this.mArquivo.Name = "mArquivo";
            this.mArquivo.Size = new System.Drawing.Size(80, 25);
            this.mArquivo.Text = "Arquivo";
            // 
            // mArquivoNovo
            // 
            this.mArquivoNovo.Image = global::EditorTXT.Properties.Resources.nova_pagina;
            this.mArquivoNovo.Name = "mArquivoNovo";
            this.mArquivoNovo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mArquivoNovo.Size = new System.Drawing.Size(272, 26);
            this.mArquivoNovo.Text = "Novo";
            this.mArquivoNovo.Click += new System.EventHandler(this.mArquivoNovo_Click);
            // 
            // mArquivoNovaJanela
            // 
            this.mArquivoNovaJanela.Image = global::EditorTXT.Properties.Resources.essay;
            this.mArquivoNovaJanela.Name = "mArquivoNovaJanela";
            this.mArquivoNovaJanela.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.mArquivoNovaJanela.Size = new System.Drawing.Size(272, 26);
            this.mArquivoNovaJanela.Text = "Nova Janela";
            this.mArquivoNovaJanela.Click += new System.EventHandler(this.mArquivoNovaJanela_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(269, 6);
            // 
            // mArquivoAbrir
            // 
            this.mArquivoAbrir.Image = global::EditorTXT.Properties.Resources.folder;
            this.mArquivoAbrir.Name = "mArquivoAbrir";
            this.mArquivoAbrir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mArquivoAbrir.Size = new System.Drawing.Size(272, 26);
            this.mArquivoAbrir.Text = "Abrir";
            this.mArquivoAbrir.Click += new System.EventHandler(this.mArquivoAbrir_Click);
            // 
            // mArquivoSalvar
            // 
            this.mArquivoSalvar.Image = global::EditorTXT.Properties.Resources.floppy_disk;
            this.mArquivoSalvar.Name = "mArquivoSalvar";
            this.mArquivoSalvar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mArquivoSalvar.Size = new System.Drawing.Size(272, 26);
            this.mArquivoSalvar.Text = "Salvar";
            this.mArquivoSalvar.Click += new System.EventHandler(this.mArquivoSalvar_Click);
            // 
            // mArquivoSalvarComo
            // 
            this.mArquivoSalvarComo.Image = global::EditorTXT.Properties.Resources.floppy_disk;
            this.mArquivoSalvarComo.Name = "mArquivoSalvarComo";
            this.mArquivoSalvarComo.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.mArquivoSalvarComo.Size = new System.Drawing.Size(272, 26);
            this.mArquivoSalvarComo.Text = "Salvar Como";
            this.mArquivoSalvarComo.Click += new System.EventHandler(this.mArquivoSalvarComo_Click);
            // 
            // mArquivoSair
            // 
            this.mArquivoSair.Image = global::EditorTXT.Properties.Resources.exit__2_;
            this.mArquivoSair.Name = "mArquivoSair";
            this.mArquivoSair.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mArquivoSair.Size = new System.Drawing.Size(272, 26);
            this.mArquivoSair.Text = "Sair";
            this.mArquivoSair.Click += new System.EventHandler(this.mArquivoSair_Click);
            // 
            // mEditar
            // 
            this.mEditar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mEditarDesfazer,
            this.mEditarRefazer,
            this.toolStripSeparator2,
            this.mEditarRecortar,
            this.mEditarCopiar,
            this.mEditarColar,
            this.mEditarExcluir,
            this.toolStripSeparator3,
            this.mEditarDataHora});
            this.mEditar.Name = "mEditar";
            this.mEditar.Size = new System.Drawing.Size(64, 25);
            this.mEditar.Text = "Editar";
            // 
            // mEditarDesfazer
            // 
            this.mEditarDesfazer.Name = "mEditarDesfazer";
            this.mEditarDesfazer.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.mEditarDesfazer.Size = new System.Drawing.Size(236, 26);
            this.mEditarDesfazer.Text = "Desfazer";
            this.mEditarDesfazer.Click += new System.EventHandler(this.mEditarDesfazer_Click);
            // 
            // mEditarRefazer
            // 
            this.mEditarRefazer.Name = "mEditarRefazer";
            this.mEditarRefazer.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Z)));
            this.mEditarRefazer.Size = new System.Drawing.Size(236, 26);
            this.mEditarRefazer.Text = "Refazer";
            this.mEditarRefazer.Click += new System.EventHandler(this.mEditarRefazer_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(233, 6);
            // 
            // mEditarRecortar
            // 
            this.mEditarRecortar.Name = "mEditarRecortar";
            this.mEditarRecortar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.mEditarRecortar.Size = new System.Drawing.Size(236, 26);
            this.mEditarRecortar.Text = "Recortar";
            this.mEditarRecortar.Click += new System.EventHandler(this.mEditarRecortar_Click);
            // 
            // mEditarCopiar
            // 
            this.mEditarCopiar.Name = "mEditarCopiar";
            this.mEditarCopiar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.mEditarCopiar.Size = new System.Drawing.Size(236, 26);
            this.mEditarCopiar.Text = "Copiar";
            this.mEditarCopiar.Click += new System.EventHandler(this.mEditarCopiar_Click);
            // 
            // mEditarColar
            // 
            this.mEditarColar.Name = "mEditarColar";
            this.mEditarColar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.mEditarColar.Size = new System.Drawing.Size(236, 26);
            this.mEditarColar.Text = "Colar";
            this.mEditarColar.Click += new System.EventHandler(this.mEditarColar_Click);
            // 
            // mEditarExcluir
            // 
            this.mEditarExcluir.Name = "mEditarExcluir";
            this.mEditarExcluir.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.mEditarExcluir.Size = new System.Drawing.Size(236, 26);
            this.mEditarExcluir.Text = "Excluir";
            this.mEditarExcluir.Click += new System.EventHandler(this.mEditarExcluir_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(233, 6);
            // 
            // mEditarDataHora
            // 
            this.mEditarDataHora.Name = "mEditarDataHora";
            this.mEditarDataHora.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.mEditarDataHora.Size = new System.Drawing.Size(236, 26);
            this.mEditarDataHora.Text = "Data e Hora";
            this.mEditarDataHora.Click += new System.EventHandler(this.mEditarDataHora_Click);
            // 
            // mFormatar
            // 
            this.mFormatar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mFormatarQuebraAutomaticadeLinha,
            this.mFormatarFonte});
            this.mFormatar.Name = "mFormatar";
            this.mFormatar.Size = new System.Drawing.Size(88, 25);
            this.mFormatar.Text = "Formatar";
            // 
            // mFormatarQuebraAutomaticadeLinha
            // 
            this.mFormatarQuebraAutomaticadeLinha.Name = "mFormatarQuebraAutomaticadeLinha";
            this.mFormatarQuebraAutomaticadeLinha.Size = new System.Drawing.Size(280, 26);
            this.mFormatarQuebraAutomaticadeLinha.Text = "Quebra automática de linha";
            this.mFormatarQuebraAutomaticadeLinha.Click += new System.EventHandler(this.mFormatarQuebraAutomaticadeLinha_Click);
            // 
            // mFormatarFonte
            // 
            this.mFormatarFonte.Name = "mFormatarFonte";
            this.mFormatarFonte.Size = new System.Drawing.Size(280, 26);
            this.mFormatarFonte.Text = "Fonte";
            this.mFormatarFonte.Click += new System.EventHandler(this.mFormatarFonte_Click);
            // 
            // mExibir
            // 
            this.mExibir.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mExibirZoom,
            this.mExibirBarradeStatus});
            this.mExibir.Name = "mExibir";
            this.mExibir.Size = new System.Drawing.Size(62, 25);
            this.mExibir.Text = "Exibir";
            // 
            // mExibirZoom
            // 
            this.mExibirZoom.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mExibirZoomAmplicar,
            this.mExibirZoomReduzir,
            this.mExibirZoomRestaurar});
            this.mExibirZoom.Name = "mExibirZoom";
            this.mExibirZoom.ShortcutKeyDisplayString = "";
            this.mExibirZoom.Size = new System.Drawing.Size(188, 26);
            this.mExibirZoom.Text = "Zoom";
            // 
            // mExibirZoomAmplicar
            // 
            this.mExibirZoomAmplicar.Name = "mExibirZoomAmplicar";
            this.mExibirZoomAmplicar.ShortcutKeyDisplayString = "Ctrl + sinal de adição";
            this.mExibirZoomAmplicar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Oemplus)));
            this.mExibirZoomAmplicar.Size = new System.Drawing.Size(321, 26);
            this.mExibirZoomAmplicar.Text = "Amplicar";
            // 
            // mExibirZoomReduzir
            // 
            this.mExibirZoomReduzir.Name = "mExibirZoomReduzir";
            this.mExibirZoomReduzir.ShortcutKeyDisplayString = "Ctrl + sinal de subtração";
            this.mExibirZoomReduzir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.OemMinus)));
            this.mExibirZoomReduzir.Size = new System.Drawing.Size(321, 26);
            this.mExibirZoomReduzir.Text = "Reduzir";
            this.mExibirZoomReduzir.Click += new System.EventHandler(this.mExibirZoomReduzir_Click);
            // 
            // mExibirZoomRestaurar
            // 
            this.mExibirZoomRestaurar.Name = "mExibirZoomRestaurar";
            this.mExibirZoomRestaurar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D0)));
            this.mExibirZoomRestaurar.Size = new System.Drawing.Size(321, 26);
            this.mExibirZoomRestaurar.Text = "Restaurar";
            this.mExibirZoomRestaurar.Click += new System.EventHandler(this.mExibirZoomRestaurar_Click);
            // 
            // mExibirBarradeStatus
            // 
            this.mExibirBarradeStatus.Checked = true;
            this.mExibirBarradeStatus.CheckOnClick = true;
            this.mExibirBarradeStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mExibirBarradeStatus.Name = "mExibirBarradeStatus";
            this.mExibirBarradeStatus.Size = new System.Drawing.Size(188, 26);
            this.mExibirBarradeStatus.Text = "Barra de status";
            this.mExibirBarradeStatus.Click += new System.EventHandler(this.mExibirBarradeStatus_Click);
            // 
            // mAjuda
            // 
            this.mAjuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mAjudaExibirAjuda,
            this.mAjudaSobreEditordeTexto});
            this.mAjuda.Name = "mAjuda";
            this.mAjuda.Size = new System.Drawing.Size(64, 25);
            this.mAjuda.Text = "Ajuda";
            // 
            // mAjudaExibirAjuda
            // 
            this.mAjudaExibirAjuda.Image = global::EditorTXT.Properties.Resources.question;
            this.mAjudaExibirAjuda.Name = "mAjudaExibirAjuda";
            this.mAjudaExibirAjuda.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.mAjudaExibirAjuda.Size = new System.Drawing.Size(253, 26);
            this.mAjudaExibirAjuda.Text = "Exibir Ajuda";
            this.mAjudaExibirAjuda.Click += new System.EventHandler(this.mAjudaExibirAjuda_Click);
            // 
            // mAjudaSobreEditordeTexto
            // 
            this.mAjudaSobreEditordeTexto.Name = "mAjudaSobreEditordeTexto";
            this.mAjudaSobreEditordeTexto.Size = new System.Drawing.Size(253, 26);
            this.mAjudaSobreEditordeTexto.Text = "Sobre o Editor de Texto";
            this.mAjudaSobreEditordeTexto.Click += new System.EventHandler(this.mAjudaSobreEditordeTexto_Click);
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBarLabel});
            this.statusBar.Location = new System.Drawing.Point(0, 539);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(784, 22);
            this.statusBar.TabIndex = 1;
            this.statusBar.Text = "statusStrip1";
            // 
            // statusBarLabel
            // 
            this.statusBarLabel.Name = "statusBarLabel";
            this.statusBarLabel.Size = new System.Drawing.Size(38, 17);
            this.statusBarLabel.Text = "100 %";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBarNovo,
            this.toolBarAbrir,
            this.toolBarSalvar,
            this.toolStripSeparator4,
            this.toolBarForFonte,
            this.toolStripSeparator5,
            this.toolBarZoom,
            this.toolBarZoomMenos,
            this.toolBarZoomMais,
            this.toolStripSeparator6,
            this.toolBarAjuda});
            this.toolStrip1.Location = new System.Drawing.Point(0, 29);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 27);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // txtConteudo
            // 
            this.txtConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtConteudo.Location = new System.Drawing.Point(0, 56);
            this.txtConteudo.Name = "txtConteudo";
            this.txtConteudo.Size = new System.Drawing.Size(784, 483);
            this.txtConteudo.TabIndex = 4;
            this.txtConteudo.Text = "";
            this.txtConteudo.WordWrap = false;
            // 
            // toolBarNovo
            // 
            this.toolBarNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBarNovo.Image = global::EditorTXT.Properties.Resources.nova_pagina;
            this.toolBarNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBarNovo.Name = "toolBarNovo";
            this.toolBarNovo.Size = new System.Drawing.Size(23, 24);
            this.toolBarNovo.Text = "Novo";
            this.toolBarNovo.Click += new System.EventHandler(this.toolBarNovo_Click);
            // 
            // toolBarAbrir
            // 
            this.toolBarAbrir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBarAbrir.Image = global::EditorTXT.Properties.Resources.folder;
            this.toolBarAbrir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBarAbrir.Name = "toolBarAbrir";
            this.toolBarAbrir.Size = new System.Drawing.Size(23, 24);
            this.toolBarAbrir.Text = "Abrir";
            this.toolBarAbrir.Click += new System.EventHandler(this.mArquivoAbrir_Click);
            // 
            // toolBarSalvar
            // 
            this.toolBarSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBarSalvar.Image = global::EditorTXT.Properties.Resources.floppy_disk;
            this.toolBarSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBarSalvar.Name = "toolBarSalvar";
            this.toolBarSalvar.Size = new System.Drawing.Size(23, 24);
            this.toolBarSalvar.Text = "Salvar";
            this.toolBarSalvar.Click += new System.EventHandler(this.mArquivoSalvar_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // toolBarForFonte
            // 
            this.toolBarForFonte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolBarForFonte.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.toolBarForFonte.Image = ((System.Drawing.Image)(resources.GetObject("toolBarForFonte.Image")));
            this.toolBarForFonte.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBarForFonte.Name = "toolBarForFonte";
            this.toolBarForFonte.Size = new System.Drawing.Size(24, 24);
            this.toolBarForFonte.Text = "A";
            this.toolBarForFonte.ToolTipText = "Formatar Fonte";
            this.toolBarForFonte.Click += new System.EventHandler(this.mFormatarFonte_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // toolBarZoom
            // 
            this.toolBarZoom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBarZoom.Image = global::EditorTXT.Properties.Resources.analysis_analytics_magnifier_search_locate_magnifyng_glass_icon_153884;
            this.toolBarZoom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBarZoom.Name = "toolBarZoom";
            this.toolBarZoom.Size = new System.Drawing.Size(23, 24);
            this.toolBarZoom.Text = "Zoom 100%";
            this.toolBarZoom.Click += new System.EventHandler(this.mExibirZoomRestaurar_Click);
            // 
            // toolBarZoomMenos
            // 
            this.toolBarZoomMenos.Image = global::EditorTXT.Properties.Resources.analysis_analytics_magnifier_search_locate_magnifyng_glass_icon_153884;
            this.toolBarZoomMenos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBarZoomMenos.Name = "toolBarZoomMenos";
            this.toolBarZoomMenos.Size = new System.Drawing.Size(32, 24);
            this.toolBarZoomMenos.Text = "-";
            this.toolBarZoomMenos.ToolTipText = "Zoom -";
            this.toolBarZoomMenos.Click += new System.EventHandler(this.mExibirZoomReduzir_Click);
            // 
            // toolBarZoomMais
            // 
            this.toolBarZoomMais.Image = global::EditorTXT.Properties.Resources.analysis_analytics_magnifier_search_locate_magnifyng_glass_icon_153884;
            this.toolBarZoomMais.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBarZoomMais.Name = "toolBarZoomMais";
            this.toolBarZoomMais.Size = new System.Drawing.Size(35, 24);
            this.toolBarZoomMais.Text = "+";
            this.toolBarZoomMais.ToolTipText = "Zoom +";
            this.toolBarZoomMais.Click += new System.EventHandler(this.mExibirZoomAmplicar_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 27);
            // 
            // toolBarAjuda
            // 
            this.toolBarAjuda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBarAjuda.Image = global::EditorTXT.Properties.Resources.question;
            this.toolBarAjuda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBarAjuda.Name = "toolBarAjuda";
            this.toolBarAjuda.Size = new System.Drawing.Size(23, 24);
            this.toolBarAjuda.Text = "Ajuda";
            this.toolBarAjuda.Click += new System.EventHandler(this.mAjudaExibirAjuda_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.txtConteudo);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.menuBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuBar;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor de Texto";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuBar;
        private ToolStripMenuItem mArquivo;
        private ToolStripMenuItem mArquivoNovo;
        private ToolStripMenuItem mArquivoNovaJanela;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem mArquivoAbrir;
        private ToolStripMenuItem mArquivoSalvar;
        private ToolStripMenuItem mArquivoSalvarComo;
        private ToolStripMenuItem mArquivoSair;
        private ToolStripMenuItem mEditar;
        private ToolStripMenuItem mEditarDesfazer;
        private ToolStripMenuItem mEditarRefazer;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem mEditarRecortar;
        private ToolStripMenuItem mEditarCopiar;
        private ToolStripMenuItem mEditarColar;
        private ToolStripMenuItem mEditarExcluir;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem mEditarDataHora;
        private ToolStripMenuItem mFormatar;
        private ToolStripMenuItem mFormatarQuebraAutomaticadeLinha;
        private ToolStripMenuItem mExibir;
        private ToolStripMenuItem mAjuda;
        private ToolStripMenuItem mFormatarFonte;
        private ToolStripMenuItem mExibirZoom;
        private ToolStripMenuItem mExibirZoomAmplicar;
        private ToolStripMenuItem mExibirZoomReduzir;
        private ToolStripMenuItem mExibirZoomRestaurar;
        private ToolStripMenuItem mExibirBarradeStatus;
        private ToolStripMenuItem mAjudaExibirAjuda;
        private ToolStripMenuItem mAjudaSobreEditordeTexto;
        private StatusStrip statusBar;
        private ToolStripStatusLabel statusBarLabel;
        private ToolStrip toolStrip1;
        private ToolStripButton toolBarNovo;
        private ToolStripButton toolBarAbrir;
        private ToolStripButton toolBarSalvar;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton toolBarForFonte;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripButton toolBarZoom;
        private ToolStripButton toolBarZoomMenos;
        private ToolStripButton toolBarZoomMais;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripButton toolBarAjuda;
        private RichTextBox txtConteudo;
    }
}