using ReaLTaiizor.Forms;

namespace pjt3
{
    partial class FormAluno : MaterialForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAluno));
            this.materialTabControl1 = new ReaLTaiizor.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btncancel = new ReaLTaiizor.Controls.MaterialButton();
            this.btnsave = new ReaLTaiizor.Controls.MaterialButton();
            this.txtuf = new ReaLTaiizor.Controls.MaterialComboBox();
            this.txtcidade = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txtmaricula = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txtdata = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            this.txtendereco = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txtbairro = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txtsenha = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txtnome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnexcluir = new ReaLTaiizor.Controls.MaterialButton();
            this.btneditar = new ReaLTaiizor.Controls.MaterialButton();
            this.btnnovo = new ReaLTaiizor.Controls.MaterialButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(125, 67);
            this.materialTabControl1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(720, 456);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btncancel);
            this.tabPage1.Controls.Add(this.btnsave);
            this.tabPage1.Controls.Add(this.txtuf);
            this.tabPage1.Controls.Add(this.txtcidade);
            this.tabPage1.Controls.Add(this.txtmaricula);
            this.tabPage1.Controls.Add(this.txtdata);
            this.tabPage1.Controls.Add(this.txtendereco);
            this.tabPage1.Controls.Add(this.txtbairro);
            this.tabPage1.Controls.Add(this.txtsenha);
            this.tabPage1.Controls.Add(this.txtnome);
            this.tabPage1.ImageKey = "form.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(712, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastro";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            this.tabPage1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tabPage1_MouseDoubleClick);
            // 
            // btncancel
            // 
            this.btncancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btncancel.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btncancel.Depth = 0;
            this.btncancel.HighEmphasis = true;
            this.btncancel.Icon = null;
            this.btncancel.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btncancel.Location = new System.Drawing.Point(486, 376);
            this.btncancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btncancel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btncancel.Name = "btncancel";
            this.btncancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btncancel.Size = new System.Drawing.Size(96, 36);
            this.btncancel.TabIndex = 8;
            this.btncancel.Text = "Cancelar";
            this.btncancel.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btncancel.UseAccentColor = false;
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnsave
            // 
            this.btnsave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnsave.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnsave.Depth = 0;
            this.btnsave.HighEmphasis = true;
            this.btnsave.Icon = null;
            this.btnsave.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnsave.Location = new System.Drawing.Point(608, 376);
            this.btnsave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnsave.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnsave.Name = "btnsave";
            this.btnsave.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnsave.Size = new System.Drawing.Size(76, 36);
            this.btnsave.TabIndex = 9;
            this.btnsave.Text = "Salvar";
            this.btnsave.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnsave.UseAccentColor = false;
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txtuf
            // 
            this.txtuf.AutoResize = false;
            this.txtuf.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtuf.Depth = 0;
            this.txtuf.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.txtuf.DropDownHeight = 174;
            this.txtuf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtuf.DropDownWidth = 121;
            this.txtuf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtuf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtuf.FormattingEnabled = true;
            this.txtuf.Hint = "UF";
            this.txtuf.IntegralHeight = false;
            this.txtuf.ItemHeight = 43;
            this.txtuf.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MS",
            "MT",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.txtuf.Location = new System.Drawing.Point(568, 264);
            this.txtuf.MaxDropDownItems = 4;
            this.txtuf.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtuf.Name = "txtuf";
            this.txtuf.Size = new System.Drawing.Size(116, 49);
            this.txtuf.StartIndex = 0;
            this.txtuf.TabIndex = 6;
            this.txtuf.SelectedIndexChanged += new System.EventHandler(this.materialComboBox1_SelectedIndexChanged);
            // 
            // txtcidade
            // 
            this.txtcidade.AnimateReadOnly = false;
            this.txtcidade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtcidade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtcidade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtcidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtcidade.Depth = 0;
            this.txtcidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtcidade.HideSelection = true;
            this.txtcidade.Hint = "Cidade";
            this.txtcidade.LeadingIcon = null;
            this.txtcidade.Location = new System.Drawing.Point(24, 265);
            this.txtcidade.MaxLength = 32767;
            this.txtcidade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtcidade.Name = "txtcidade";
            this.txtcidade.PasswordChar = '\0';
            this.txtcidade.PrefixSuffixText = null;
            this.txtcidade.ReadOnly = false;
            this.txtcidade.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtcidade.SelectedText = "";
            this.txtcidade.SelectionLength = 0;
            this.txtcidade.SelectionStart = 0;
            this.txtcidade.ShortcutsEnabled = true;
            this.txtcidade.Size = new System.Drawing.Size(538, 48);
            this.txtcidade.TabIndex = 5;
            this.txtcidade.TabStop = false;
            this.txtcidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtcidade.TrailingIcon = null;
            this.txtcidade.UseSystemPasswordChar = false;
            // 
            // txtmaricula
            // 
            this.txtmaricula.AnimateReadOnly = false;
            this.txtmaricula.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtmaricula.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtmaricula.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtmaricula.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtmaricula.Depth = 0;
            this.txtmaricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtmaricula.HideSelection = true;
            this.txtmaricula.Hint = "Matricula";
            this.txtmaricula.LeadingIcon = null;
            this.txtmaricula.Location = new System.Drawing.Point(24, 48);
            this.txtmaricula.MaxLength = 32767;
            this.txtmaricula.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtmaricula.Name = "txtmaricula";
            this.txtmaricula.PasswordChar = '\0';
            this.txtmaricula.PrefixSuffixText = null;
            this.txtmaricula.ReadOnly = false;
            this.txtmaricula.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtmaricula.SelectedText = "";
            this.txtmaricula.SelectionLength = 0;
            this.txtmaricula.SelectionStart = 0;
            this.txtmaricula.ShortcutsEnabled = true;
            this.txtmaricula.Size = new System.Drawing.Size(404, 48);
            this.txtmaricula.TabIndex = 0;
            this.txtmaricula.TabStop = false;
            this.txtmaricula.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtmaricula.TrailingIcon = null;
            this.txtmaricula.UseSystemPasswordChar = false;
            this.txtmaricula.Click += new System.EventHandler(this.txtmaricula_Click);
            // 
            // txtdata
            // 
            this.txtdata.AllowPromptAsInput = true;
            this.txtdata.AnimateReadOnly = false;
            this.txtdata.AsciiOnly = false;
            this.txtdata.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtdata.BeepOnError = false;
            this.txtdata.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtdata.Depth = 0;
            this.txtdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtdata.HidePromptOnLeave = false;
            this.txtdata.HideSelection = true;
            this.txtdata.Hint = "Data de Nascimento";
            this.txtdata.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtdata.LeadingIcon = null;
            this.txtdata.Location = new System.Drawing.Point(434, 48);
            this.txtdata.Mask = "99/99/9999";
            this.txtdata.MaxLength = 32767;
            this.txtdata.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtdata.Name = "txtdata";
            this.txtdata.PasswordChar = '\0';
            this.txtdata.PrefixSuffixText = null;
            this.txtdata.PromptChar = '_';
            this.txtdata.ReadOnly = false;
            this.txtdata.RejectInputOnFirstFailure = false;
            this.txtdata.ResetOnPrompt = true;
            this.txtdata.ResetOnSpace = true;
            this.txtdata.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtdata.SelectedText = "";
            this.txtdata.SelectionLength = 0;
            this.txtdata.SelectionStart = 0;
            this.txtdata.ShortcutsEnabled = true;
            this.txtdata.Size = new System.Drawing.Size(250, 48);
            this.txtdata.SkipLiterals = true;
            this.txtdata.TabIndex = 1;
            this.txtdata.TabStop = false;
            this.txtdata.Text = "  /  /";
            this.txtdata.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtdata.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtdata.TrailingIcon = null;
            this.txtdata.UseSystemPasswordChar = false;
            this.txtdata.ValidatingType = null;
            this.txtdata.Click += new System.EventHandler(this.txtdata_Click);
            // 
            // txtendereco
            // 
            this.txtendereco.AnimateReadOnly = false;
            this.txtendereco.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtendereco.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtendereco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtendereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtendereco.Depth = 0;
            this.txtendereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtendereco.HideSelection = true;
            this.txtendereco.Hint = "Endereço";
            this.txtendereco.LeadingIcon = null;
            this.txtendereco.Location = new System.Drawing.Point(24, 156);
            this.txtendereco.MaxLength = 32767;
            this.txtendereco.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtendereco.Name = "txtendereco";
            this.txtendereco.PasswordChar = '\0';
            this.txtendereco.PrefixSuffixText = null;
            this.txtendereco.ReadOnly = false;
            this.txtendereco.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtendereco.SelectedText = "";
            this.txtendereco.SelectionLength = 0;
            this.txtendereco.SelectionStart = 0;
            this.txtendereco.ShortcutsEnabled = true;
            this.txtendereco.Size = new System.Drawing.Size(660, 48);
            this.txtendereco.TabIndex = 3;
            this.txtendereco.TabStop = false;
            this.txtendereco.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtendereco.TrailingIcon = null;
            this.txtendereco.UseSystemPasswordChar = false;
            this.txtendereco.Click += new System.EventHandler(this.materialTextBoxEdit3_Click);
            // 
            // txtbairro
            // 
            this.txtbairro.AnimateReadOnly = false;
            this.txtbairro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtbairro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtbairro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtbairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtbairro.Depth = 0;
            this.txtbairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtbairro.HideSelection = true;
            this.txtbairro.Hint = "Bairro";
            this.txtbairro.LeadingIcon = null;
            this.txtbairro.Location = new System.Drawing.Point(24, 210);
            this.txtbairro.MaxLength = 32767;
            this.txtbairro.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtbairro.Name = "txtbairro";
            this.txtbairro.PasswordChar = '\0';
            this.txtbairro.PrefixSuffixText = null;
            this.txtbairro.ReadOnly = false;
            this.txtbairro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtbairro.SelectedText = "";
            this.txtbairro.SelectionLength = 0;
            this.txtbairro.SelectionStart = 0;
            this.txtbairro.ShortcutsEnabled = true;
            this.txtbairro.Size = new System.Drawing.Size(660, 48);
            this.txtbairro.TabIndex = 4;
            this.txtbairro.TabStop = false;
            this.txtbairro.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtbairro.TrailingIcon = null;
            this.txtbairro.UseSystemPasswordChar = false;
            // 
            // txtsenha
            // 
            this.txtsenha.AnimateReadOnly = false;
            this.txtsenha.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtsenha.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtsenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtsenha.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtsenha.Depth = 0;
            this.txtsenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtsenha.HideSelection = true;
            this.txtsenha.Hint = "Senha";
            this.txtsenha.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("txtsenha.LeadingIcon")));
            this.txtsenha.Location = new System.Drawing.Point(24, 319);
            this.txtsenha.MaxLength = 32767;
            this.txtsenha.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.PasswordChar = '*';
            this.txtsenha.PrefixSuffixText = null;
            this.txtsenha.ReadOnly = false;
            this.txtsenha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtsenha.SelectedText = "";
            this.txtsenha.SelectionLength = 0;
            this.txtsenha.SelectionStart = 0;
            this.txtsenha.ShortcutsEnabled = true;
            this.txtsenha.Size = new System.Drawing.Size(660, 48);
            this.txtsenha.TabIndex = 7;
            this.txtsenha.TabStop = false;
            this.txtsenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtsenha.TrailingIcon = null;
            this.txtsenha.UseSystemPasswordChar = false;
            // 
            // txtnome
            // 
            this.txtnome.AnimateReadOnly = false;
            this.txtnome.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtnome.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtnome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtnome.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtnome.Depth = 0;
            this.txtnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtnome.HideSelection = true;
            this.txtnome.Hint = "Nome";
            this.txtnome.LeadingIcon = null;
            this.txtnome.Location = new System.Drawing.Point(24, 102);
            this.txtnome.MaxLength = 32767;
            this.txtnome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtnome.Name = "txtnome";
            this.txtnome.PasswordChar = '\0';
            this.txtnome.PrefixSuffixText = null;
            this.txtnome.ReadOnly = false;
            this.txtnome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtnome.SelectedText = "";
            this.txtnome.SelectionLength = 0;
            this.txtnome.SelectionStart = 0;
            this.txtnome.ShortcutsEnabled = true;
            this.txtnome.Size = new System.Drawing.Size(660, 48);
            this.txtnome.TabIndex = 2;
            this.txtnome.TabStop = false;
            this.txtnome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtnome.TrailingIcon = null;
            this.txtnome.UseSystemPasswordChar = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnexcluir);
            this.tabPage2.Controls.Add(this.btneditar);
            this.tabPage2.Controls.Add(this.btnnovo);
            this.tabPage2.Controls.Add(this.listView1);
            this.tabPage2.ImageKey = "search.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(712, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click_1);
            this.tabPage2.Enter += new System.EventHandler(this.tabPages2_Enter);
            // 
            // btnexcluir
            // 
            this.btnexcluir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnexcluir.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnexcluir.Depth = 0;
            this.btnexcluir.HighEmphasis = true;
            this.btnexcluir.Icon = null;
            this.btnexcluir.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnexcluir.Location = new System.Drawing.Point(405, 367);
            this.btnexcluir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnexcluir.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnexcluir.Size = new System.Drawing.Size(80, 36);
            this.btnexcluir.TabIndex = 3;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnexcluir.UseAccentColor = false;
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // btneditar
            // 
            this.btneditar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btneditar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btneditar.Depth = 0;
            this.btneditar.HighEmphasis = true;
            this.btneditar.Icon = null;
            this.btneditar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btneditar.Location = new System.Drawing.Point(524, 367);
            this.btneditar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btneditar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btneditar.Name = "btneditar";
            this.btneditar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btneditar.Size = new System.Drawing.Size(71, 36);
            this.btneditar.TabIndex = 2;
            this.btneditar.Text = "Editar";
            this.btneditar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btneditar.UseAccentColor = false;
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btnnovo
            // 
            this.btnnovo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnnovo.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnnovo.Depth = 0;
            this.btnnovo.HighEmphasis = true;
            this.btnnovo.Icon = null;
            this.btnnovo.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnnovo.Location = new System.Drawing.Point(631, 367);
            this.btnnovo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnnovo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnnovo.Name = "btnnovo";
            this.btnnovo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnnovo.Size = new System.Drawing.Size(64, 36);
            this.btnnovo.TabIndex = 1;
            this.btnnovo.Text = "Novo";
            this.btnnovo.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnnovo.UseAccentColor = false;
            this.btnnovo.UseVisualStyleBackColor = true;
            this.btnnovo.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // listView1
            // 
            this.listView1.AllowDrop = true;
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(6, 6);
            this.listView1.Name = "listView1";
            this.listView1.OwnerDraw = true;
            this.listView1.Size = new System.Drawing.Size(700, 352);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.listView1_DrawItem);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "search.png");
            this.imageList1.Images.SetKeyName(1, "form.png");
            // 
            // FormAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 551);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "FormAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Aluno";
            this.Load += new System.EventHandler(this.FormAluno_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTabControl materialTabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtendereco;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtbairro;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtsenha;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtnome;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtdata;
        private ReaLTaiizor.Controls.MaterialComboBox txtuf;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtcidade;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtmaricula;
        private ReaLTaiizor.Controls.MaterialButton btncancel;
        private ReaLTaiizor.Controls.MaterialButton btnsave;
        private ImageList imageList1;
        private ListView listView1;
        private ReaLTaiizor.Controls.MaterialButton btnexcluir;
        private ReaLTaiizor.Controls.MaterialButton btneditar;
        private ReaLTaiizor.Controls.MaterialButton btnnovo;
    }
}