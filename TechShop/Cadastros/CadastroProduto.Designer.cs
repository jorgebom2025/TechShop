namespace TechShop.App.Cadastros
{
    partial class CadastroProduto
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
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtModelo = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtPreco = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtQuantidadeEstoque = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtAnoLancamento = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtDescricao = new ReaLTaiizor.Controls.MaterialMultiLineTextBoxEdit();
            cboCategoria = new ReaLTaiizor.Controls.MaterialComboBox();
            cboFornecedor = new ReaLTaiizor.Controls.MaterialComboBox();
            txtFabricante = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tabPageConsulta.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            tabControl.SuspendLayout();
            SuspendLayout();
            // 
            // tabPageConsulta
            // 
            tabPageConsulta.Size = new Size(777, 423);
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(498, 369);
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(634, 369);
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(460, 357);
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(544, 357);
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(636, 357);
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(txtFabricante);
            tabPageCadastro.Controls.Add(cboFornecedor);
            tabPageCadastro.Controls.Add(cboCategoria);
            tabPageCadastro.Controls.Add(txtDescricao);
            tabPageCadastro.Controls.Add(txtAnoLancamento);
            tabPageCadastro.Controls.Add(txtQuantidadeEstoque);
            tabPageCadastro.Controls.Add(txtPreco);
            tabPageCadastro.Controls.Add(txtModelo);
            tabPageCadastro.Controls.Add(txtNome);
            tabPageCadastro.Controls.Add(txtId);
            tabPageCadastro.Size = new Size(777, 423);
            tabPageCadastro.Controls.SetChildIndex(btnCancelar, 0);
            tabPageCadastro.Controls.SetChildIndex(btnSalvar, 0);
            tabPageCadastro.Controls.SetChildIndex(txtId, 0);
            tabPageCadastro.Controls.SetChildIndex(txtNome, 0);
            tabPageCadastro.Controls.SetChildIndex(txtModelo, 0);
            tabPageCadastro.Controls.SetChildIndex(txtPreco, 0);
            tabPageCadastro.Controls.SetChildIndex(txtQuantidadeEstoque, 0);
            tabPageCadastro.Controls.SetChildIndex(txtAnoLancamento, 0);
            tabPageCadastro.Controls.SetChildIndex(txtDescricao, 0);
            tabPageCadastro.Controls.SetChildIndex(cboCategoria, 0);
            tabPageCadastro.Controls.SetChildIndex(cboFornecedor, 0);
            tabPageCadastro.Controls.SetChildIndex(txtFabricante, 0);
            // 
            // tabControl
            // 
            tabControl.Size = new Size(785, 451);
            // 
            // txtId
            // 
            txtId.AnimateReadOnly = false;
            txtId.AutoCompleteMode = AutoCompleteMode.None;
            txtId.AutoCompleteSource = AutoCompleteSource.None;
            txtId.BackgroundImageLayout = ImageLayout.None;
            txtId.CharacterCasing = CharacterCasing.Normal;
            txtId.Depth = 0;
            txtId.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtId.HideSelection = true;
            txtId.Hint = "ID";
            txtId.LeadingIcon = null;
            txtId.Location = new Point(12, 25);
            txtId.MaxLength = 32767;
            txtId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtId.Name = "txtId";
            txtId.PasswordChar = '\0';
            txtId.PrefixSuffixText = null;
            txtId.ReadOnly = true;
            txtId.RightToLeft = RightToLeft.No;
            txtId.SelectedText = "";
            txtId.SelectionLength = 0;
            txtId.SelectionStart = 0;
            txtId.ShortcutsEnabled = true;
            txtId.Size = new Size(105, 48);
            txtId.TabIndex = 2;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // txtNome
            // 
            txtNome.AnimateReadOnly = false;
            txtNome.AutoCompleteMode = AutoCompleteMode.None;
            txtNome.AutoCompleteSource = AutoCompleteSource.None;
            txtNome.BackgroundImageLayout = ImageLayout.None;
            txtNome.CharacterCasing = CharacterCasing.Normal;
            txtNome.Depth = 0;
            txtNome.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNome.HideSelection = true;
            txtNome.Hint = "Nome";
            txtNome.LeadingIcon = null;
            txtNome.Location = new Point(123, 25);
            txtNome.MaxLength = 32767;
            txtNome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNome.Name = "txtNome";
            txtNome.PasswordChar = '\0';
            txtNome.PrefixSuffixText = null;
            txtNome.ReadOnly = false;
            txtNome.RightToLeft = RightToLeft.No;
            txtNome.SelectedText = "";
            txtNome.SelectionLength = 0;
            txtNome.SelectionStart = 0;
            txtNome.ShortcutsEnabled = true;
            txtNome.Size = new Size(639, 48);
            txtNome.TabIndex = 3;
            txtNome.TabStop = false;
            txtNome.TextAlign = HorizontalAlignment.Left;
            txtNome.TrailingIcon = null;
            txtNome.UseSystemPasswordChar = false;
            // 
            // txtModelo
            // 
            txtModelo.AnimateReadOnly = false;
            txtModelo.AutoCompleteMode = AutoCompleteMode.None;
            txtModelo.AutoCompleteSource = AutoCompleteSource.None;
            txtModelo.BackgroundImageLayout = ImageLayout.None;
            txtModelo.CharacterCasing = CharacterCasing.Normal;
            txtModelo.Depth = 0;
            txtModelo.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtModelo.HideSelection = true;
            txtModelo.Hint = "Modelo";
            txtModelo.LeadingIcon = null;
            txtModelo.Location = new Point(12, 79);
            txtModelo.MaxLength = 32767;
            txtModelo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtModelo.Name = "txtModelo";
            txtModelo.PasswordChar = '\0';
            txtModelo.PrefixSuffixText = null;
            txtModelo.ReadOnly = false;
            txtModelo.RightToLeft = RightToLeft.No;
            txtModelo.SelectedText = "";
            txtModelo.SelectionLength = 0;
            txtModelo.SelectionStart = 0;
            txtModelo.ShortcutsEnabled = true;
            txtModelo.Size = new Size(493, 48);
            txtModelo.TabIndex = 4;
            txtModelo.TabStop = false;
            txtModelo.TextAlign = HorizontalAlignment.Left;
            txtModelo.TrailingIcon = null;
            txtModelo.UseSystemPasswordChar = false;
            txtModelo.Click += txtEdicao_Click;
            // 
            // txtPreco
            // 
            txtPreco.AnimateReadOnly = false;
            txtPreco.AutoCompleteMode = AutoCompleteMode.None;
            txtPreco.AutoCompleteSource = AutoCompleteSource.None;
            txtPreco.BackgroundImageLayout = ImageLayout.None;
            txtPreco.CharacterCasing = CharacterCasing.Normal;
            txtPreco.Depth = 0;
            txtPreco.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPreco.HideSelection = true;
            txtPreco.Hint = "Preço";
            txtPreco.LeadingIcon = null;
            txtPreco.Location = new Point(511, 79);
            txtPreco.MaxLength = 32767;
            txtPreco.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtPreco.Name = "txtPreco";
            txtPreco.PasswordChar = '\0';
            txtPreco.PrefixSuffixText = null;
            txtPreco.ReadOnly = false;
            txtPreco.RightToLeft = RightToLeft.No;
            txtPreco.SelectedText = "";
            txtPreco.SelectionLength = 0;
            txtPreco.SelectionStart = 0;
            txtPreco.ShortcutsEnabled = true;
            txtPreco.Size = new Size(251, 48);
            txtPreco.TabIndex = 5;
            txtPreco.TabStop = false;
            txtPreco.TextAlign = HorizontalAlignment.Left;
            txtPreco.TrailingIcon = null;
            txtPreco.UseSystemPasswordChar = false;
            // 
            // txtQuantidadeEstoque
            // 
            txtQuantidadeEstoque.AnimateReadOnly = false;
            txtQuantidadeEstoque.AutoCompleteMode = AutoCompleteMode.None;
            txtQuantidadeEstoque.AutoCompleteSource = AutoCompleteSource.None;
            txtQuantidadeEstoque.BackgroundImageLayout = ImageLayout.None;
            txtQuantidadeEstoque.CharacterCasing = CharacterCasing.Normal;
            txtQuantidadeEstoque.Depth = 0;
            txtQuantidadeEstoque.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtQuantidadeEstoque.HideSelection = true;
            txtQuantidadeEstoque.Hint = "Quantidade em Estoque";
            txtQuantidadeEstoque.LeadingIcon = null;
            txtQuantidadeEstoque.Location = new Point(222, 300);
            txtQuantidadeEstoque.MaxLength = 32767;
            txtQuantidadeEstoque.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtQuantidadeEstoque.Name = "txtQuantidadeEstoque";
            txtQuantidadeEstoque.PasswordChar = '\0';
            txtQuantidadeEstoque.PrefixSuffixText = null;
            txtQuantidadeEstoque.ReadOnly = false;
            txtQuantidadeEstoque.RightToLeft = RightToLeft.No;
            txtQuantidadeEstoque.SelectedText = "";
            txtQuantidadeEstoque.SelectionLength = 0;
            txtQuantidadeEstoque.SelectionStart = 0;
            txtQuantidadeEstoque.ShortcutsEnabled = true;
            txtQuantidadeEstoque.Size = new Size(199, 48);
            txtQuantidadeEstoque.TabIndex = 7;
            txtQuantidadeEstoque.TabStop = false;
            txtQuantidadeEstoque.TextAlign = HorizontalAlignment.Left;
            txtQuantidadeEstoque.TrailingIcon = null;
            txtQuantidadeEstoque.UseSystemPasswordChar = false;
            txtQuantidadeEstoque.Click += txtQuantidadeEstoque_Click;
            // 
            // txtAnoLancamento
            // 
            txtAnoLancamento.AllowPromptAsInput = true;
            txtAnoLancamento.AnimateReadOnly = false;
            txtAnoLancamento.AsciiOnly = false;
            txtAnoLancamento.BackgroundImageLayout = ImageLayout.None;
            txtAnoLancamento.BeepOnError = false;
            txtAnoLancamento.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtAnoLancamento.Depth = 0;
            txtAnoLancamento.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAnoLancamento.HidePromptOnLeave = false;
            txtAnoLancamento.HideSelection = true;
            txtAnoLancamento.Hint = "Ano de Lançamento";
            txtAnoLancamento.InsertKeyMode = InsertKeyMode.Default;
            txtAnoLancamento.LeadingIcon = null;
            txtAnoLancamento.Location = new Point(12, 300);
            txtAnoLancamento.Mask = "";
            txtAnoLancamento.MaxLength = 32767;
            txtAnoLancamento.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtAnoLancamento.Name = "txtAnoLancamento";
            txtAnoLancamento.PasswordChar = '\0';
            txtAnoLancamento.PrefixSuffixText = null;
            txtAnoLancamento.PromptChar = '_';
            txtAnoLancamento.ReadOnly = false;
            txtAnoLancamento.RejectInputOnFirstFailure = false;
            txtAnoLancamento.ResetOnPrompt = true;
            txtAnoLancamento.ResetOnSpace = true;
            txtAnoLancamento.RightToLeft = RightToLeft.No;
            txtAnoLancamento.SelectedText = "";
            txtAnoLancamento.SelectionLength = 0;
            txtAnoLancamento.SelectionStart = 0;
            txtAnoLancamento.ShortcutsEnabled = true;
            txtAnoLancamento.Size = new Size(189, 48);
            txtAnoLancamento.SkipLiterals = true;
            txtAnoLancamento.TabIndex = 9;
            txtAnoLancamento.TabStop = false;
            txtAnoLancamento.TextAlign = HorizontalAlignment.Left;
            txtAnoLancamento.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtAnoLancamento.TrailingIcon = null;
            txtAnoLancamento.UseSystemPasswordChar = false;
            txtAnoLancamento.ValidatingType = null;
            // 
            // txtDescricao
            // 
            txtDescricao.AnimateReadOnly = false;
            txtDescricao.BackgroundImageLayout = ImageLayout.None;
            txtDescricao.CharacterCasing = CharacterCasing.Normal;
            txtDescricao.Depth = 0;
            txtDescricao.HideSelection = true;
            txtDescricao.Hint = "Descrição";
            txtDescricao.Location = new Point(12, 194);
            txtDescricao.MaxLength = 32767;
            txtDescricao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.PasswordChar = '\0';
            txtDescricao.ReadOnly = false;
            txtDescricao.ScrollBars = ScrollBars.None;
            txtDescricao.SelectedText = "";
            txtDescricao.SelectionLength = 0;
            txtDescricao.SelectionStart = 0;
            txtDescricao.ShortcutsEnabled = true;
            txtDescricao.Size = new Size(750, 100);
            txtDescricao.TabIndex = 10;
            txtDescricao.TabStop = false;
            txtDescricao.TextAlign = HorizontalAlignment.Left;
            txtDescricao.UseSystemPasswordChar = false;
            // 
            // cboCategoria
            // 
            cboCategoria.AutoResize = false;
            cboCategoria.BackColor = Color.FromArgb(255, 255, 255);
            cboCategoria.Depth = 0;
            cboCategoria.DrawMode = DrawMode.OwnerDrawVariable;
            cboCategoria.DropDownHeight = 174;
            cboCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategoria.DropDownWidth = 121;
            cboCategoria.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboCategoria.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Hint = "Categoria";
            cboCategoria.IntegralHeight = false;
            cboCategoria.ItemHeight = 43;
            cboCategoria.Location = new Point(12, 133);
            cboCategoria.MaxDropDownItems = 4;
            cboCategoria.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(363, 49);
            cboCategoria.StartIndex = 0;
            cboCategoria.TabIndex = 11;
            // 
            // cboFornecedor
            // 
            cboFornecedor.AutoResize = false;
            cboFornecedor.BackColor = Color.FromArgb(255, 255, 255);
            cboFornecedor.Depth = 0;
            cboFornecedor.DrawMode = DrawMode.OwnerDrawVariable;
            cboFornecedor.DropDownHeight = 174;
            cboFornecedor.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFornecedor.DropDownWidth = 121;
            cboFornecedor.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboFornecedor.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboFornecedor.FormattingEnabled = true;
            cboFornecedor.Hint = "Fornecedor";
            cboFornecedor.IntegralHeight = false;
            cboFornecedor.ItemHeight = 43;
            cboFornecedor.Location = new Point(381, 133);
            cboFornecedor.MaxDropDownItems = 4;
            cboFornecedor.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboFornecedor.Name = "cboFornecedor";
            cboFornecedor.Size = new Size(381, 49);
            cboFornecedor.StartIndex = 0;
            cboFornecedor.TabIndex = 12;
            // 
            // txtFabricante
            // 
            txtFabricante.AnimateReadOnly = false;
            txtFabricante.AutoCompleteMode = AutoCompleteMode.None;
            txtFabricante.AutoCompleteSource = AutoCompleteSource.None;
            txtFabricante.BackgroundImageLayout = ImageLayout.None;
            txtFabricante.CharacterCasing = CharacterCasing.Normal;
            txtFabricante.Depth = 0;
            txtFabricante.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtFabricante.HideSelection = true;
            txtFabricante.Hint = "Fabricante";
            txtFabricante.LeadingIcon = null;
            txtFabricante.Location = new Point(427, 300);
            txtFabricante.MaxLength = 32767;
            txtFabricante.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtFabricante.Name = "txtFabricante";
            txtFabricante.PasswordChar = '\0';
            txtFabricante.PrefixSuffixText = null;
            txtFabricante.ReadOnly = false;
            txtFabricante.RightToLeft = RightToLeft.No;
            txtFabricante.SelectedText = "";
            txtFabricante.SelectionLength = 0;
            txtFabricante.SelectionStart = 0;
            txtFabricante.ShortcutsEnabled = true;
            txtFabricante.Size = new Size(335, 48);
            txtFabricante.TabIndex = 13;
            txtFabricante.TabStop = false;
            txtFabricante.TextAlign = HorizontalAlignment.Left;
            txtFabricante.TrailingIcon = null;
            txtFabricante.UseSystemPasswordChar = false;
            // 
            // CadastroProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(791, 518);
            Location = new Point(0, 0);
            Name = "CadastroProduto";
            Text = "Cadastro do Produto";
            tabPageConsulta.ResumeLayout(false);
            tabPageConsulta.PerformLayout();
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            tabControl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtPreco;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtModelo;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNome;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialMultiLineTextBoxEdit txtDescricao;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtAnoLancamento;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtQuantidadeEstoque;
        private ReaLTaiizor.Controls.MaterialComboBox cboFornecedor;
        private ReaLTaiizor.Controls.MaterialComboBox cboCategoria;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtFabricante;
    }
}