namespace primeiraTela
{
    partial class FormCadastroProduto
    {
        public string foto = "";

        public FormCadastroProduto()
        {
            InitializeComponent();
        }


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroProduto));
            this.btnCancelarProduto = new System.Windows.Forms.Button();
            this.btnCadastrarProduto = new System.Windows.Forms.Button();
            this.inputDescricaoCadastroProduto = new DevExpress.XtraEditors.TextEdit();
            this.inputQtdeCadastroProduto = new DevExpress.XtraEditors.TextEdit();
            this.inputNomeCadastroProduto = new DevExpress.XtraEditors.TextEdit();
            this.pbImagemProduto = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.inputValidadeCadastroProduto = new DevExpress.XtraEditors.TextEdit();
            this.inputMargemCadastroProduto = new DevExpress.XtraEditors.TextEdit();
            this.inputVendaCadastroProduto = new DevExpress.XtraEditors.TextEdit();
            this.panelBotoesCadastroProduto = new DevExpress.XtraEditors.PanelControl();
            this.panelDadosCadastroProduto = new DevExpress.XtraEditors.PanelControl();
            this.inputCustoCadastroProduto = new DevExpress.XtraEditors.TextEdit();
            this.btnCarregarFotoProduto = new DevExpress.XtraEditors.SimpleButton();
            this.btnRemoverFotoProduto = new DevExpress.XtraEditors.SimpleButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unidadeDeMedidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lkUpEditCategoriaCadastroProduto = new DevExpress.XtraEditors.LookUpEdit();
            this.lkUpEditMateriaCadastroProduto = new DevExpress.XtraEditors.LookUpEdit();
            this.lkUpEditUndMedidaCadastroProduto = new DevExpress.XtraEditors.LookUpEdit();
            this.lkUpEditSubCategoriaCadastroProduto = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.inputDescricaoCadastroProduto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputQtdeCadastroProduto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputNomeCadastroProduto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputValidadeCadastroProduto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputMargemCadastroProduto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputVendaCadastroProduto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelBotoesCadastroProduto)).BeginInit();
            this.panelBotoesCadastroProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelDadosCadastroProduto)).BeginInit();
            this.panelDadosCadastroProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputCustoCadastroProduto.Properties)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkUpEditCategoriaCadastroProduto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkUpEditMateriaCadastroProduto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkUpEditUndMedidaCadastroProduto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkUpEditSubCategoriaCadastroProduto.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelarProduto
            // 
            this.btnCancelarProduto.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnCancelarProduto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarProduto.Image")));
            this.btnCancelarProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarProduto.Location = new System.Drawing.Point(396, 33);
            this.btnCancelarProduto.Name = "btnCancelarProduto";
            this.btnCancelarProduto.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnCancelarProduto.Size = new System.Drawing.Size(168, 36);
            this.btnCancelarProduto.TabIndex = 25;
            this.btnCancelarProduto.Text = "Cancelar";
            this.btnCancelarProduto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelarProduto.UseVisualStyleBackColor = false;
            this.btnCancelarProduto.Click += new System.EventHandler(this.btnCancelarProduto_Click);
            // 
            // btnCadastrarProduto
            // 
            this.btnCadastrarProduto.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnCadastrarProduto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrarProduto.Image")));
            this.btnCadastrarProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarProduto.Location = new System.Drawing.Point(188, 33);
            this.btnCadastrarProduto.Name = "btnCadastrarProduto";
            this.btnCadastrarProduto.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnCadastrarProduto.Size = new System.Drawing.Size(168, 36);
            this.btnCadastrarProduto.TabIndex = 24;
            this.btnCadastrarProduto.Text = "Cadastrar";
            this.btnCadastrarProduto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastrarProduto.UseVisualStyleBackColor = false;
            this.btnCadastrarProduto.Click += new System.EventHandler(this.btnCadastrarProduto_Click);
            // 
            // inputDescricaoCadastroProduto
            // 
            this.inputDescricaoCadastroProduto.EditValue = "";
            this.inputDescricaoCadastroProduto.Location = new System.Drawing.Point(104, 88);
            this.inputDescricaoCadastroProduto.Name = "inputDescricaoCadastroProduto";
            this.inputDescricaoCadastroProduto.Properties.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.inputDescricaoCadastroProduto.Properties.Appearance.Options.UseForeColor = true;
            this.inputDescricaoCadastroProduto.Properties.NullValuePrompt = "Marca";
            this.inputDescricaoCadastroProduto.Size = new System.Drawing.Size(153, 20);
            this.inputDescricaoCadastroProduto.TabIndex = 14;
            // 
            // inputQtdeCadastroProduto
            // 
            this.inputQtdeCadastroProduto.EditValue = "";
            this.inputQtdeCadastroProduto.Location = new System.Drawing.Point(320, 174);
            this.inputQtdeCadastroProduto.Name = "inputQtdeCadastroProduto";
            this.inputQtdeCadastroProduto.Properties.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.inputQtdeCadastroProduto.Properties.Appearance.Options.UseForeColor = true;
            this.inputQtdeCadastroProduto.Properties.NullValuePrompt = "Quantidade";
            this.inputQtdeCadastroProduto.Size = new System.Drawing.Size(78, 20);
            this.inputQtdeCadastroProduto.TabIndex = 20;
            this.inputQtdeCadastroProduto.EditValueChanged += new System.EventHandler(this.inputQtdeCadastroProduto_EditValueChanged);
            this.inputQtdeCadastroProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputQtdeCadastroProduto_KeyPress);
            this.inputQtdeCadastroProduto.Leave += new System.EventHandler(this.inputQtdeCadastroProduto_Leave);
            // 
            // inputNomeCadastroProduto
            // 
            this.inputNomeCadastroProduto.EditValue = "";
            this.inputNomeCadastroProduto.Location = new System.Drawing.Point(104, 49);
            this.inputNomeCadastroProduto.Name = "inputNomeCadastroProduto";
            this.inputNomeCadastroProduto.Properties.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.inputNomeCadastroProduto.Properties.Appearance.Options.UseForeColor = true;
            this.inputNomeCadastroProduto.Properties.NullText = "Descrição do Produto";
            this.inputNomeCadastroProduto.Properties.NullValuePrompt = "Descrição do Produto";
            this.inputNomeCadastroProduto.Size = new System.Drawing.Size(560, 20);
            this.inputNomeCadastroProduto.TabIndex = 13;
            this.inputNomeCadastroProduto.EditValueChanged += new System.EventHandler(this.inputNomeCadastroProduto_EditValueChanged);
            this.inputNomeCadastroProduto.Click += new System.EventHandler(this.inputDescricaoCadastroProduto_Click);
            this.inputNomeCadastroProduto.Leave += new System.EventHandler(this.inputDescricaoCadastroProduto_Leave);
            // 
            // pbImagemProduto
            // 
            this.pbImagemProduto.Image = ((System.Drawing.Image)(resources.GetObject("pbImagemProduto.Image")));
            this.pbImagemProduto.Location = new System.Drawing.Point(308, 27);
            this.pbImagemProduto.Name = "pbImagemProduto";
            this.pbImagemProduto.Size = new System.Drawing.Size(211, 131);
            this.pbImagemProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbImagemProduto.TabIndex = 12;
            this.pbImagemProduto.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // inputValidadeCadastroProduto
            // 
            this.inputValidadeCadastroProduto.EditValue = "";
            this.inputValidadeCadastroProduto.Location = new System.Drawing.Point(104, 174);
            this.inputValidadeCadastroProduto.Name = "inputValidadeCadastroProduto";
            this.inputValidadeCadastroProduto.Properties.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.inputValidadeCadastroProduto.Properties.Appearance.Options.UseForeColor = true;
            this.inputValidadeCadastroProduto.Properties.NullValuePrompt = "Validade";
            this.inputValidadeCadastroProduto.Size = new System.Drawing.Size(83, 20);
            this.inputValidadeCadastroProduto.TabIndex = 18;
            // 
            // inputMargemCadastroProduto
            // 
            this.inputMargemCadastroProduto.EditValue = "";
            this.inputMargemCadastroProduto.Location = new System.Drawing.Point(494, 174);
            this.inputMargemCadastroProduto.Name = "inputMargemCadastroProduto";
            this.inputMargemCadastroProduto.Properties.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.inputMargemCadastroProduto.Properties.Appearance.Options.UseForeColor = true;
            this.inputMargemCadastroProduto.Properties.NullValuePrompt = "Margem";
            this.inputMargemCadastroProduto.Size = new System.Drawing.Size(84, 20);
            this.inputMargemCadastroProduto.TabIndex = 22;
            this.inputMargemCadastroProduto.EditValueChanged += new System.EventHandler(this.inputMargemCadastroProduto_EditValueChanged);
            this.inputMargemCadastroProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputMargemCadastroProduto_KeyPress);
            this.inputMargemCadastroProduto.Leave += new System.EventHandler(this.inputMargemCadastroProduto_Leave);
            // 
            // inputVendaCadastroProduto
            // 
            this.inputVendaCadastroProduto.EditValue = "";
            this.inputVendaCadastroProduto.Location = new System.Drawing.Point(585, 174);
            this.inputVendaCadastroProduto.Name = "inputVendaCadastroProduto";
            this.inputVendaCadastroProduto.Properties.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.inputVendaCadastroProduto.Properties.Appearance.Options.UseForeColor = true;
            this.inputVendaCadastroProduto.Properties.NullValuePrompt = "Venda";
            this.inputVendaCadastroProduto.Size = new System.Drawing.Size(79, 20);
            this.inputVendaCadastroProduto.TabIndex = 23;
            this.inputVendaCadastroProduto.EditValueChanged += new System.EventHandler(this.inputVendaCadastroProduto_EditValueChanged);
            this.inputVendaCadastroProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputVendaCadastroProduto_KeyPress);
            this.inputVendaCadastroProduto.Leave += new System.EventHandler(this.inputVendaCadastroProduto_Leave);
            // 
            // panelBotoesCadastroProduto
            // 
            this.panelBotoesCadastroProduto.Controls.Add(this.btnCancelarProduto);
            this.panelBotoesCadastroProduto.Controls.Add(this.btnCadastrarProduto);
            this.panelBotoesCadastroProduto.Location = new System.Drawing.Point(12, 473);
            this.panelBotoesCadastroProduto.Name = "panelBotoesCadastroProduto";
            this.panelBotoesCadastroProduto.Size = new System.Drawing.Size(770, 100);
            this.panelBotoesCadastroProduto.TabIndex = 27;
            // 
            // panelDadosCadastroProduto
            // 
            this.panelDadosCadastroProduto.Controls.Add(this.lkUpEditUndMedidaCadastroProduto);
            this.panelDadosCadastroProduto.Controls.Add(this.lkUpEditSubCategoriaCadastroProduto);
            this.panelDadosCadastroProduto.Controls.Add(this.lkUpEditMateriaCadastroProduto);
            this.panelDadosCadastroProduto.Controls.Add(this.lkUpEditCategoriaCadastroProduto);
            this.panelDadosCadastroProduto.Controls.Add(this.inputCustoCadastroProduto);
            this.panelDadosCadastroProduto.Controls.Add(this.inputNomeCadastroProduto);
            this.panelDadosCadastroProduto.Controls.Add(this.inputVendaCadastroProduto);
            this.panelDadosCadastroProduto.Controls.Add(this.inputQtdeCadastroProduto);
            this.panelDadosCadastroProduto.Controls.Add(this.inputMargemCadastroProduto);
            this.panelDadosCadastroProduto.Controls.Add(this.inputDescricaoCadastroProduto);
            this.panelDadosCadastroProduto.Controls.Add(this.inputValidadeCadastroProduto);
            this.panelDadosCadastroProduto.Location = new System.Drawing.Point(12, 199);
            this.panelDadosCadastroProduto.Name = "panelDadosCadastroProduto";
            this.panelDadosCadastroProduto.Size = new System.Drawing.Size(776, 242);
            this.panelDadosCadastroProduto.TabIndex = 28;
            // 
            // inputCustoCadastroProduto
            // 
            this.inputCustoCadastroProduto.EditValue = "";
            this.inputCustoCadastroProduto.Location = new System.Drawing.Point(404, 174);
            this.inputCustoCadastroProduto.Name = "inputCustoCadastroProduto";
            this.inputCustoCadastroProduto.Properties.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.inputCustoCadastroProduto.Properties.Appearance.Options.UseForeColor = true;
            this.inputCustoCadastroProduto.Properties.NullValuePrompt = "Custo";
            this.inputCustoCadastroProduto.Size = new System.Drawing.Size(84, 20);
            this.inputCustoCadastroProduto.TabIndex = 21;
            this.inputCustoCadastroProduto.EditValueChanged += new System.EventHandler(this.inputCustoCadastroProduto_EditValueChanged);
            this.inputCustoCadastroProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputCustoCadastroProduto_KeyPress);
            this.inputCustoCadastroProduto.Leave += new System.EventHandler(this.inputCustoCadastroProduto_Leave);
            // 
            // btnCarregarFotoProduto
            // 
            this.btnCarregarFotoProduto.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCarregarFotoProduto.ImageOptions.Image")));
            this.btnCarregarFotoProduto.Location = new System.Drawing.Point(308, 164);
            this.btnCarregarFotoProduto.Name = "btnCarregarFotoProduto";
            this.btnCarregarFotoProduto.Size = new System.Drawing.Size(100, 25);
            this.btnCarregarFotoProduto.TabIndex = 11;
            this.btnCarregarFotoProduto.Text = "Carregar foto";
            // 
            // btnRemoverFotoProduto
            // 
            this.btnRemoverFotoProduto.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoverFotoProduto.ImageOptions.Image")));
            this.btnRemoverFotoProduto.Location = new System.Drawing.Point(419, 164);
            this.btnRemoverFotoProduto.Name = "btnRemoverFotoProduto";
            this.btnRemoverFotoProduto.Size = new System.Drawing.Size(100, 25);
            this.btnRemoverFotoProduto.TabIndex = 12;
            this.btnRemoverFotoProduto.Text = "Remover foto";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoriaToolStripMenuItem,
            this.subCategoriaToolStripMenuItem,
            this.unidadeDeMedidaToolStripMenuItem});
            this.cadastroToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.cadastroToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cadastroToolStripMenuItem.Image")));
            this.cadastroToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.cadastroToolStripMenuItem.Text = "Inserir/Excluir";
            this.cadastroToolStripMenuItem.Click += new System.EventHandler(this.cadastroToolStripMenuItem_Click);
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.categoriaToolStripMenuItem.Text = "Categoria";
            this.categoriaToolStripMenuItem.Click += new System.EventHandler(this.categoriaToolStripMenuItem_Click);
            // 
            // subCategoriaToolStripMenuItem
            // 
            this.subCategoriaToolStripMenuItem.Name = "subCategoriaToolStripMenuItem";
            this.subCategoriaToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.subCategoriaToolStripMenuItem.Text = "Sub Categoria";
            this.subCategoriaToolStripMenuItem.Click += new System.EventHandler(this.subCategoriaToolStripMenuItem_Click);
            // 
            // unidadeDeMedidaToolStripMenuItem
            // 
            this.unidadeDeMedidaToolStripMenuItem.Name = "unidadeDeMedidaToolStripMenuItem";
            this.unidadeDeMedidaToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.unidadeDeMedidaToolStripMenuItem.Text = "Unidade de Medida";
            this.unidadeDeMedidaToolStripMenuItem.Click += new System.EventHandler(this.unidadeDeMedidaToolStripMenuItem_Click);
            // 
            // lkUpEditCategoriaCadastroProduto
            // 
            this.lkUpEditCategoriaCadastroProduto.Location = new System.Drawing.Point(286, 89);
            this.lkUpEditCategoriaCadastroProduto.Name = "lkUpEditCategoriaCadastroProduto";
            this.lkUpEditCategoriaCadastroProduto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkUpEditCategoriaCadastroProduto.Properties.NullText = "";
            this.lkUpEditCategoriaCadastroProduto.Properties.NullValuePrompt = "Selecione a categoria";
            this.lkUpEditCategoriaCadastroProduto.Properties.ShowHeader = false;
            this.lkUpEditCategoriaCadastroProduto.Size = new System.Drawing.Size(175, 20);
            this.lkUpEditCategoriaCadastroProduto.TabIndex = 30;
            this.lkUpEditCategoriaCadastroProduto.EditValueChanged += new System.EventHandler(this.lkUpEditCategoriaCadastroProduto_EditValueChanged);
            this.lkUpEditCategoriaCadastroProduto.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lkUpEditCategoriaCadastroProduto_MouseDoubleClick);
            // 
            // lkUpEditMateriaCadastroProduto
            // 
            this.lkUpEditMateriaCadastroProduto.Location = new System.Drawing.Point(104, 134);
            this.lkUpEditMateriaCadastroProduto.Name = "lkUpEditMateriaCadastroProduto";
            this.lkUpEditMateriaCadastroProduto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkUpEditMateriaCadastroProduto.Properties.NullText = "";
            this.lkUpEditMateriaCadastroProduto.Properties.NullValuePrompt = "Materia prima";
            this.lkUpEditMateriaCadastroProduto.Properties.ShowHeader = false;
            this.lkUpEditMateriaCadastroProduto.Size = new System.Drawing.Size(560, 20);
            this.lkUpEditMateriaCadastroProduto.TabIndex = 31;
            // 
            // lkUpEditUndMedidaCadastroProduto
            // 
            this.lkUpEditUndMedidaCadastroProduto.Location = new System.Drawing.Point(193, 174);
            this.lkUpEditUndMedidaCadastroProduto.Name = "lkUpEditUndMedidaCadastroProduto";
            this.lkUpEditUndMedidaCadastroProduto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkUpEditUndMedidaCadastroProduto.Properties.NullText = "";
            this.lkUpEditUndMedidaCadastroProduto.Properties.NullValuePrompt = "Unidade de medida";
            this.lkUpEditUndMedidaCadastroProduto.Properties.ShowHeader = false;
            this.lkUpEditUndMedidaCadastroProduto.Size = new System.Drawing.Size(119, 20);
            this.lkUpEditUndMedidaCadastroProduto.TabIndex = 32;
            this.lkUpEditUndMedidaCadastroProduto.EditValueChanged += new System.EventHandler(this.lkUpEditUndMedidaCadastroProduto_EditValueChanged);
            this.lkUpEditUndMedidaCadastroProduto.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lkUpEditUndMedidaCadastroProduto_MouseDoubleClick);
            // 
            // lkUpEditSubCategoriaCadastroProduto
            // 
            this.lkUpEditSubCategoriaCadastroProduto.Location = new System.Drawing.Point(494, 89);
            this.lkUpEditSubCategoriaCadastroProduto.Name = "lkUpEditSubCategoriaCadastroProduto";
            this.lkUpEditSubCategoriaCadastroProduto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkUpEditSubCategoriaCadastroProduto.Properties.NullText = "";
            this.lkUpEditSubCategoriaCadastroProduto.Properties.NullValuePrompt = "Sub categoria";
            this.lkUpEditSubCategoriaCadastroProduto.Properties.ShowHeader = false;
            this.lkUpEditSubCategoriaCadastroProduto.Size = new System.Drawing.Size(170, 20);
            this.lkUpEditSubCategoriaCadastroProduto.TabIndex = 33;
            this.lkUpEditSubCategoriaCadastroProduto.DoubleClick += new System.EventHandler(this.lkUpEditSubCategoriaCadastroProduto_DoubleClick);
            this.lkUpEditSubCategoriaCadastroProduto.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lkUpEditSubCategoriaCadastroProduto_MouseDoubleClick);
            // 
            // FormCadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnRemoverFotoProduto);
            this.Controls.Add(this.btnCarregarFotoProduto);
            this.Controls.Add(this.panelDadosCadastroProduto);
            this.Controls.Add(this.panelBotoesCadastroProduto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbImagemProduto);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormCadastroProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormCadastroProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inputDescricaoCadastroProduto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputQtdeCadastroProduto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputNomeCadastroProduto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputValidadeCadastroProduto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputMargemCadastroProduto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputVendaCadastroProduto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelBotoesCadastroProduto)).EndInit();
            this.panelBotoesCadastroProduto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelDadosCadastroProduto)).EndInit();
            this.panelDadosCadastroProduto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inputCustoCadastroProduto.Properties)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkUpEditCategoriaCadastroProduto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkUpEditMateriaCadastroProduto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkUpEditUndMedidaCadastroProduto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkUpEditSubCategoriaCadastroProduto.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancelarProduto;
        private System.Windows.Forms.Button btnCadastrarProduto;
        private DevExpress.XtraEditors.TextEdit inputDescricaoCadastroProduto;
        private DevExpress.XtraEditors.TextEdit inputQtdeCadastroProduto;
        private DevExpress.XtraEditors.TextEdit inputNomeCadastroProduto;
        private System.Windows.Forms.PictureBox pbImagemProduto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.TextEdit inputValidadeCadastroProduto;
        private DevExpress.XtraEditors.TextEdit inputMargemCadastroProduto;
        private DevExpress.XtraEditors.TextEdit inputVendaCadastroProduto;
        private DevExpress.XtraEditors.PanelControl panelBotoesCadastroProduto;
        private DevExpress.XtraEditors.PanelControl panelDadosCadastroProduto;
        private DevExpress.XtraEditors.SimpleButton btnCarregarFotoProduto;
        private DevExpress.XtraEditors.SimpleButton btnRemoverFotoProduto;
        private DevExpress.XtraEditors.TextEdit inputCustoCadastroProduto;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subCategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unidadeDeMedidaToolStripMenuItem;
        private DevExpress.XtraEditors.LookUpEdit lkUpEditCategoriaCadastroProduto;
        private DevExpress.XtraEditors.LookUpEdit lkUpEditMateriaCadastroProduto;
        private DevExpress.XtraEditors.LookUpEdit lkUpEditUndMedidaCadastroProduto;
        private DevExpress.XtraEditors.LookUpEdit lkUpEditSubCategoriaCadastroProduto;
    }
}