namespace primeiraTela
{
    partial class FormSubCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSubCategoria));
            this.pictureBoxSubCategoria = new System.Windows.Forms.PictureBox();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.massaFinaDataSet = new primeiraTela.MassaFinaDataSet();
            this.panelControlBtnSubCategoria = new DevExpress.XtraEditors.PanelControl();
            this.toolStripSubCategoria = new System.Windows.Forms.ToolStrip();
            this.btnSairSubCategoria = new System.Windows.Forms.ToolStripButton();
            this.btnMenu = new System.Windows.Forms.ToolStripButton();
            this.btnExcluirSubCategoria = new System.Windows.Forms.ToolStripButton();
            this.btnInserirSubCategoria = new System.Windows.Forms.ToolStripButton();
            this.btnSalvarSubCategoria = new System.Windows.Forms.ToolStripButton();
            this.panelControlTstripSubcategoria = new DevExpress.XtraEditors.PanelControl();
            this.btnPesquisarSubCategoria = new System.Windows.Forms.PictureBox();
            this.inputInserirSubCategoria = new DevExpress.XtraEditors.TextEdit();
            this.panelControlGridSubCategoria = new DevExpress.XtraEditors.PanelControl();
            this.gridViewSubCategoria = new System.Windows.Forms.DataGridView();
            this.categoriaTableAdapter = new primeiraTela.MassaFinaDataSetTableAdapters.categoriaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSubCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.massaFinaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlBtnSubCategoria)).BeginInit();
            this.toolStripSubCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlTstripSubcategoria)).BeginInit();
            this.panelControlTstripSubcategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPesquisarSubCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputInserirSubCategoria.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlGridSubCategoria)).BeginInit();
            this.panelControlGridSubCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSubCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxSubCategoria
            // 
            this.pictureBoxSubCategoria.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSubCategoria.Image")));
            this.pictureBoxSubCategoria.Location = new System.Drawing.Point(9, 8);
            this.pictureBoxSubCategoria.Name = "pictureBoxSubCategoria";
            this.pictureBoxSubCategoria.Size = new System.Drawing.Size(54, 38);
            this.pictureBoxSubCategoria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxSubCategoria.TabIndex = 30;
            this.pictureBoxSubCategoria.TabStop = false;
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataMember = "categoria";
            this.categoriaBindingSource.DataSource = this.massaFinaDataSet;
            // 
            // massaFinaDataSet
            // 
            this.massaFinaDataSet.DataSetName = "MassaFinaDataSet";
            this.massaFinaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panelControlBtnSubCategoria
            // 
            this.panelControlBtnSubCategoria.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControlBtnSubCategoria.Location = new System.Drawing.Point(0, 226);
            this.panelControlBtnSubCategoria.Name = "panelControlBtnSubCategoria";
            this.panelControlBtnSubCategoria.Size = new System.Drawing.Size(376, 31);
            this.panelControlBtnSubCategoria.TabIndex = 32;
            // 
            // toolStripSubCategoria
            // 
            this.toolStripSubCategoria.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripSubCategoria.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripSubCategoria.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripSubCategoria.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSairSubCategoria,
            this.btnMenu,
            this.btnExcluirSubCategoria,
            this.btnInserirSubCategoria,
            this.btnSalvarSubCategoria});
            this.toolStripSubCategoria.Location = new System.Drawing.Point(2, 37);
            this.toolStripSubCategoria.Name = "toolStripSubCategoria";
            this.toolStripSubCategoria.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripSubCategoria.Size = new System.Drawing.Size(372, 25);
            this.toolStripSubCategoria.TabIndex = 29;
            this.toolStripSubCategoria.Text = "toolStrip1";
            // 
            // btnSairSubCategoria
            // 
            this.btnSairSubCategoria.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSairSubCategoria.Image = ((System.Drawing.Image)(resources.GetObject("btnSairSubCategoria.Image")));
            this.btnSairSubCategoria.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSairSubCategoria.Name = "btnSairSubCategoria";
            this.btnSairSubCategoria.Size = new System.Drawing.Size(46, 22);
            this.btnSairSubCategoria.Text = "Sair";
            this.btnSairSubCategoria.Click += new System.EventHandler(this.btnSairSubCategoria_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(57, 22);
            this.btnMenu.Text = "Menu";
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnExcluirSubCategoria
            // 
            this.btnExcluirSubCategoria.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnExcluirSubCategoria.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirSubCategoria.Image")));
            this.btnExcluirSubCategoria.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcluirSubCategoria.Name = "btnExcluirSubCategoria";
            this.btnExcluirSubCategoria.Size = new System.Drawing.Size(61, 22);
            this.btnExcluirSubCategoria.Text = "Excluir";
            this.btnExcluirSubCategoria.Click += new System.EventHandler(this.btnExcluirSubCategoria_Click);
            // 
            // btnInserirSubCategoria
            // 
            this.btnInserirSubCategoria.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnInserirSubCategoria.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirSubCategoria.Image = ((System.Drawing.Image)(resources.GetObject("btnInserirSubCategoria.Image")));
            this.btnInserirSubCategoria.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInserirSubCategoria.Name = "btnInserirSubCategoria";
            this.btnInserirSubCategoria.Size = new System.Drawing.Size(60, 22);
            this.btnInserirSubCategoria.Text = "Inserir";
            this.btnInserirSubCategoria.Click += new System.EventHandler(this.btnInserirSubCategoria_Click);
            // 
            // btnSalvarSubCategoria
            // 
            this.btnSalvarSubCategoria.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSalvarSubCategoria.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvarSubCategoria.Image")));
            this.btnSalvarSubCategoria.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvarSubCategoria.Name = "btnSalvarSubCategoria";
            this.btnSalvarSubCategoria.Size = new System.Drawing.Size(58, 22);
            this.btnSalvarSubCategoria.Text = "Salvar";
            this.btnSalvarSubCategoria.Click += new System.EventHandler(this.btnSalvarSubCategoria_Click);
            // 
            // panelControlTstripSubcategoria
            // 
            this.panelControlTstripSubcategoria.Controls.Add(this.btnPesquisarSubCategoria);
            this.panelControlTstripSubcategoria.Controls.Add(this.inputInserirSubCategoria);
            this.panelControlTstripSubcategoria.Controls.Add(this.pictureBoxSubCategoria);
            this.panelControlTstripSubcategoria.Controls.Add(this.toolStripSubCategoria);
            this.panelControlTstripSubcategoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControlTstripSubcategoria.Location = new System.Drawing.Point(0, 0);
            this.panelControlTstripSubcategoria.Name = "panelControlTstripSubcategoria";
            this.panelControlTstripSubcategoria.Size = new System.Drawing.Size(376, 64);
            this.panelControlTstripSubcategoria.TabIndex = 31;
            // 
            // btnPesquisarSubCategoria
            // 
            this.btnPesquisarSubCategoria.AccessibleName = "";
            this.btnPesquisarSubCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisarSubCategoria.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisarSubCategoria.Image")));
            this.btnPesquisarSubCategoria.ImageLocation = "";
            this.btnPesquisarSubCategoria.Location = new System.Drawing.Point(321, 8);
            this.btnPesquisarSubCategoria.Name = "btnPesquisarSubCategoria";
            this.btnPesquisarSubCategoria.Size = new System.Drawing.Size(43, 20);
            this.btnPesquisarSubCategoria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnPesquisarSubCategoria.TabIndex = 34;
            this.btnPesquisarSubCategoria.TabStop = false;
            this.btnPesquisarSubCategoria.Tag = "";
            this.btnPesquisarSubCategoria.Click += new System.EventHandler(this.btnPesquisarSubCategoria_Click);
            // 
            // inputInserirSubCategoria
            // 
            this.inputInserirSubCategoria.EditValue = "";
            this.inputInserirSubCategoria.Location = new System.Drawing.Point(72, 8);
            this.inputInserirSubCategoria.Name = "inputInserirSubCategoria";
            this.inputInserirSubCategoria.Properties.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.inputInserirSubCategoria.Properties.Appearance.Options.UseForeColor = true;
            this.inputInserirSubCategoria.Properties.NullValuePrompt = "Insira a Sub categoria";
            this.inputInserirSubCategoria.Size = new System.Drawing.Size(243, 20);
            this.inputInserirSubCategoria.TabIndex = 33;
            // 
            // panelControlGridSubCategoria
            // 
            this.panelControlGridSubCategoria.Controls.Add(this.gridViewSubCategoria);
            this.panelControlGridSubCategoria.Location = new System.Drawing.Point(0, 65);
            this.panelControlGridSubCategoria.Name = "panelControlGridSubCategoria";
            this.panelControlGridSubCategoria.Size = new System.Drawing.Size(373, 158);
            this.panelControlGridSubCategoria.TabIndex = 33;
            // 
            // gridViewSubCategoria
            // 
            this.gridViewSubCategoria.AccessibleName = "";
            this.gridViewSubCategoria.AllowUserToAddRows = false;
            this.gridViewSubCategoria.AllowUserToDeleteRows = false;
            this.gridViewSubCategoria.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridViewSubCategoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridViewSubCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewSubCategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridViewSubCategoria.Location = new System.Drawing.Point(2, 2);
            this.gridViewSubCategoria.Name = "gridViewSubCategoria";
            this.gridViewSubCategoria.ReadOnly = true;
            this.gridViewSubCategoria.Size = new System.Drawing.Size(369, 154);
            this.gridViewSubCategoria.TabIndex = 29;
            this.gridViewSubCategoria.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewSubCategoria_CellDoubleClick);
            this.gridViewSubCategoria.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridViewSubCategoria_CellMouseClick);
            // 
            // categoriaTableAdapter
            // 
            this.categoriaTableAdapter.ClearBeforeFill = true;
            // 
            // FormSubCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 257);
            this.Controls.Add(this.panelControlBtnSubCategoria);
            this.Controls.Add(this.panelControlTstripSubcategoria);
            this.Controls.Add(this.panelControlGridSubCategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSubCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormSubCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSubCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.massaFinaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlBtnSubCategoria)).EndInit();
            this.toolStripSubCategoria.ResumeLayout(false);
            this.toolStripSubCategoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlTstripSubcategoria)).EndInit();
            this.panelControlTstripSubcategoria.ResumeLayout(false);
            this.panelControlTstripSubcategoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPesquisarSubCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputInserirSubCategoria.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlGridSubCategoria)).EndInit();
            this.panelControlGridSubCategoria.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSubCategoria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxSubCategoria;
        private DevExpress.XtraEditors.PanelControl panelControlBtnSubCategoria;
        private System.Windows.Forms.ToolStrip toolStripSubCategoria;
        private System.Windows.Forms.ToolStripButton btnExcluirSubCategoria;
        private DevExpress.XtraEditors.PanelControl panelControlTstripSubcategoria;
        private DevExpress.XtraEditors.PanelControl panelControlGridSubCategoria;
        private DevExpress.XtraEditors.TextEdit inputInserirSubCategoria;
        private MassaFinaDataSet massaFinaDataSet;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private MassaFinaDataSetTableAdapters.categoriaTableAdapter categoriaTableAdapter;
        private System.Windows.Forms.DataGridView gridViewSubCategoria;
        private System.Windows.Forms.PictureBox btnPesquisarSubCategoria;
        private System.Windows.Forms.ToolStripButton btnSairSubCategoria;
        private System.Windows.Forms.ToolStripButton btnMenu;
        private System.Windows.Forms.ToolStripButton btnInserirSubCategoria;
        private System.Windows.Forms.ToolStripButton btnSalvarSubCategoria;
    }
}