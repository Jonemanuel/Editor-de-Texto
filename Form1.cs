namespace EditorTXT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #region Menu Arquivo
        private void mArquivoNovo_Click(object sender, EventArgs e)
        {
            txtConteudo.Clear();
            mArquivoSalvar.Enabled = true;
            Text = Application.ProductName;
        }

        private void mArquivoNovaJanela_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(() => Application.Run(new Form1 ()));
            t.SetApartmentState(ApartmentState.STA);
            t.Start();

        }
        

        private void mArquivoAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Abrir ...";
            dialog.Filter = "rich text file|*.rtf|texto|#.txt|todos|*.*";

            DialogResult result = dialog.ShowDialog();

            if (result != DialogResult.Cancel && result != DialogResult.Abort) 
            {
                if (File.Exists(dialog.FileName)) 
                {
                    FileInfo file = new FileInfo(dialog.FileName);
                    Text = Application.ProductName + " - " + file.Name;

                    Gerenciador.Folderpath = file.DirectoryName + "\\";
                    Gerenciador.FileName = file.Name.Remove(file.Name.LastIndexOf("."));
                    Gerenciador.FileExt = file.Extension;
                    
                    StreamReader stream = null;
                    mArquivoSalvar.Enabled = true;

                    try
                    {
                        stream = new StreamReader(file.FullName, true);
                        txtConteudo.Text = stream.ReadToEnd();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Formato de Arquivo não suportado \n" + ex.Message);
                    }
                    finally
                    {
                        stream.Close();
                    }
                }
            }

        }

        private void mArquivoSalvar_Click(object sender, EventArgs e)
        {
            if (File.Exists(Gerenciador.FilePath))
            {
                SalvarArquivo(Gerenciador.FilePath);
            }
            else
            { 
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Title = "Salvar ...";
                dialog.Filter = "rich text file | *.rtf|text|*.txt|todos|*.*";
                dialog.CheckFileExists = false;
                dialog.CheckFileExists = true;

                var result = dialog.ShowDialog();
                if (result != DialogResult.Cancel && result != DialogResult.Abort) 
                {
                    SalvarArquivo(dialog.FileName);
                }
            }
        }

        private void SalvarArquivo(string path)
        {
            //Objeto responsável por escrever Arquivo
            StreamWriter writer = null;

            try 
            {
                writer = new StreamWriter(path, false);
                writer.Write(txtConteudo.Text);

                FileInfo file = new FileInfo(path);
                Gerenciador.Folderpath = file.DirectoryName + "\\";
                Gerenciador.FileName = file.Name.Remove(file.Name.LastIndexOf("."));
                Gerenciador.FileExt = file.Extension;
                
                mArquivoSalvar.Enabled = false;
            } 
            catch (Exception ex)
            {
                MessageBox.Show("Erro Salvar Arquivo: \n" + ex.Message);
            } 
            finally 
            {
                writer.Close();
            }
        }
        private void mArquivoSalvarComo_Click(object sender, EventArgs e)
        {

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = "Salvar Como...";
            dialog.Filter = "rich text file | *.rtf|text|*.txt|todos|*.*";
            dialog.CheckFileExists = false;
            dialog.CheckFileExists = true;

            var result = dialog.ShowDialog();
            if (result != DialogResult.Cancel && result != DialogResult.Abort)
            {
                SalvarArquivo(dialog.FileName);
            }

        }

        private void mArquivoSair_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja Realmente sair ?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        #endregion

        #region Menu Editar

        private void mEditarDesfazer_Click(object sender, EventArgs e)
        {
            txtConteudo.Undo();
        }

        private void mEditarRefazer_Click(object sender, EventArgs e)
        {
            txtConteudo.Redo();
        }

        private void mEditarRecortar_Click(object sender, EventArgs e)
        {
            txtConteudo.Cut();
        }

        private void mEditarCopiar_Click(object sender, EventArgs e)
        {
            txtConteudo.Copy();
        }

        private void mEditarColar_Click(object sender, EventArgs e)
        {
            txtConteudo.Paste();
        }

        private void mEditarExcluir_Click(object sender, EventArgs e)
        {
            txtConteudo.Text.Remove(txtConteudo.SelectionStart, txtConteudo.SelectedText.Length);
        }

        private void mEditarDataHora_Click(object sender, EventArgs e)
        {
            int index = txtConteudo.SelectionStart;
            string dataHora = DateTime.Now.ToString();

            if (txtConteudo.SelectionStart == txtConteudo.Text.Length) 
            {
                txtConteudo.Text = txtConteudo.Text + dataHora;
                txtConteudo.SelectionStart = index + dataHora.Length;
                return;
            }

            string temp = "";
            for (int i = 0; i < txtConteudo.Text.Length; i++) 
            {
                if (i == txtConteudo.SelectionStart)
                {
                    temp += dataHora;
                    temp += txtConteudo.Text[i];
                }
                else 
                {
                    temp += txtConteudo.Text[i];
                }
            }

            txtConteudo.Text = temp;
            txtConteudo.SelectionStart = index + dataHora.Length;
        }
        #endregion

        #region Menu Formatar
        private void mFormatarQuebraAutomaticadeLinha_Click(object sender, EventArgs e)
        {
            txtConteudo.WordWrap = mFormatarQuebraAutomaticadeLinha.Checked;
        }

        private void mFormatarFonte_Click(object sender, EventArgs e)
        {
            FontDialog fonte = new FontDialog();
            fonte.ShowColor = true;
            fonte.ShowEffects = true;

            fonte.Font = txtConteudo.Font;
            fonte.Color = txtConteudo.ForeColor;

            DialogResult result= fonte.ShowDialog();

            if (result == DialogResult.OK) 
            {
                txtConteudo.Font = fonte.Font;
                txtConteudo.ForeColor = fonte.Color;
            }
        }

        #endregion

        #region Menu Exibir
        private void mExibirZoomAmplicar_Click(object sender, EventArgs e)
        {
            txtConteudo.ZoomFactor += 0.1f;
            AtualizarZoomStatusBar(txtConteudo.ZoomFactor);
        }

        private void mExibirZoomReduzir_Click(object sender, EventArgs e)
        {
            txtConteudo.ZoomFactor -= 0.1f;
            AtualizarZoomStatusBar(txtConteudo.ZoomFactor);

        }

        private void mExibirZoomRestaurar_Click(object sender, EventArgs e)
        {
            txtConteudo.ZoomFactor = 1f;
            AtualizarZoomStatusBar(txtConteudo.ZoomFactor);
        }
        

        private void mExibirBarradeStatus_Click(object sender, EventArgs e)
        {
            statusBar.Visible = mExibirBarradeStatus.Checked;
        }

        private void AtualizarZoomStatusBar(float zoom)
        {
            statusBarLabel.Text = $"{Math.Round(zoom*100)}%";
        }

        #endregion

        #region Menu Ajuda
        private void mAjudaExibirAjuda_Click(object sender, EventArgs e)
        {
            FormAjuda f = new FormAjuda();
            f.Show();
        }

        private void mAjudaSobreEditordeTexto_Click(object sender, EventArgs e)
        {
            FormSobre f = new FormSobre();
            f.Show();
        }

        #endregion

        //Barra de Ferramentas - Novo

        private void toolBarNovo_Click(object sender, EventArgs e)
        {
            mArquivoNovo_Click(sender, e);
        }
    }
}