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
            this.btnCancelarSubCategoria = new System.Windows.Forms.Button();
            this.btnCadastrarSubCategoria = new System.Windows.Forms.Button();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.massaFinaDataSet = new primeiraTela.MassaFinaDataSet();
            this.panelControlBtnSubCategoria = new DevExpress.XtraEditors.PanelControl();
            this.toolStripSubCategoria = new System.Windows.Forms.ToolStrip();
            this.btnExcluirSubCategoria = new System.Windows.Forms.ToolStripButton();
            this.btnEditarSubCategoria = new System.Windows.Forms.ToolStripButton();
            this.panelControlTstripSubcategoria = new DevExpress.XtraEditors.PanelControl();
            this.btnInserirCategoria = new DevExpress.XtraEditors.SimpleButton();
            this.inputInserirSubCategoria = new DevExpress.XtraEditors.TextEdit();
            this.panelControlGridSubCategoria = new DevExpress.XtraEditors.PanelControl();
            this.categoriaTableAdapter = new primeiraTela.MassaFinaDataSetTableAdapters.categoriaTableAdapter();
            this.gridViewSubCategoria = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSubCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.massaFinaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlBtnSubCategoria)).BeginInit();
            this.panelControlBtnSubCategoria.SuspendLayout();
            this.toolStripSubCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlTstripSubcategoria)).BeginInit();
            this.panelControlTstripSubcategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputInserirSubCategoria.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlGridSubCategoria)).BeginInit();
            this.panelControlGridSubCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSubCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxSubCategoria
            // 
            this.pictureBoxSubCategoria.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSubCategoria.Image")));
            this.pictureBoxSubCategoria.Location = new System.Drawing.Point(12, 5);
            this.pictureBoxSubCategoria.Name = "pictureBoxSubCategoria";
            this.pictureBoxSubCategoria.Size = new System.Drawing.Size(54, 38);
            this.pictureBoxSubCategoria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxSubCategoria.TabIndex = 30;
            this.pictureBoxSubCategoria.TabStop = false;
            // 
            // btnCancelarSubCategoria
            // 
            this.btnCancelarSubCategoria.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnCancelarSubCategoria.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarSubCategoria.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarSubCategoria.Image")));
            this.btnCancelarSubCategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarSubCategoria.Location = new System.Drawing.Point(194, 9);
            this.btnCancelarSubCategoria.Name = "btnCancelarSubCategoria";
            this.btnCancelarSubCategoria.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnCancelarSubCategoria.Size = new System.Drawing.Size(168, 36);
            this.btnCancelarSubCategoria.TabIndex = 26;
            this.btnCancelarSubCategoria.Text = "Cancelar";
            this.btnCancelarSubCategoria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelarSubCategoria.UseVisualStyleBackColor = false;
            this.btnCancelarSubCategoria.Click += new System.EventHandler(this.btnCancelarSubCategoria_Click);
            // 
            // btnCadastrarSubCategoria
            // 
            this.btnCadastrarSubCategoria.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnCadastrarSubCategoria.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarSubCategoria.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrarSubCategoria.Image")));
            this.btnCadastrarSubCategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarSubCategoria.Location = new System.Drawing.Point(10, 9);
            this.btnCadastrarSubCategoria.Name = "btnCadastrarSubCategoria";
            this.btnCadastrarSubCategoria.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnCadastrarSubCategoria.Size = new System.Drawing.Size(168, 36);
            this.btnCadastrarSubCategoria.TabIndex = 25;
            this.btnCadastrarSubCategoria.Text = "Cadastrar";
            this.btnCadastrarSubCategoria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastrarSubCategoria.UseVisualStyleBackColor = false;
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
            this.panelControlBtnSubCategoria.Controls.Add(this.btnCancelarSubCategoria);
            this.panelControlBtnSubCategoria.Controls.Add(this.btnCadastrarSubCategoria);
            this.panelControlBtnSubCategoria.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControlBtnSubCategoria.Location = new System.Drawing.Point(0, 205);
            this.panelControlBtnSubCategoria.Name = "panelControlBtnSubCategoria";
            this.panelControlBtnSubCategoria.Size = new System.Drawing.Size(376, 52);
            this.panelControlBtnSubCategoria.TabIndex = 32;
            // 
            // toolStripSubCategoria
            // 
            this.toolStripSubCategoria.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripSubCategoria.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripSubCategoria.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripSubCategoria.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExcluirSubCategoria,
            this.btnEditarSubCategoria});
            this.toolStripSubCategoria.Location = new System.Drawing.Point(2, 25);
            this.toolStripSubCategoria.Name = "toolStripSubCategoria";
            this.toolStripSubCategoria.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripSubCategoria.Size = new System.Drawing.Size(372, 25);
            this.toolStripSubCategoria.TabIndex = 29;
            this.toolStripSubCategoria.Text = "toolStrip1";
            // 
            // btnExcluirSubCategoria
            // 
            this.btnExcluirSubCategoria.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnExcluirSubCategoria.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirSubCategoria.Image")));
            this.btnExcluirSubCategoria.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcluirSubCategoria.Name = "btnExcluirSubCategoria";
            this.btnExcluirSubCategoria.Size = new System.Drawing.Size(61, 22);
            this.btnExcluirSubCategoria.Text = "Excluir";
            // 
            // btnEditarSubCategoria
            // 
            this.btnEditarSubCategoria.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnEditarSubCategoria.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarSubCategoria.Image")));
            this.btnEditarSubCategoria.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditarSubCategoria.Name = "btnEditarSubCategoria";
            this.btnEditarSubCategoria.Size = new System.Drawing.Size(58, 22);
            this.btnEditarSubCategoria.Text = "Editar";
            // 
            // panelControlTstripSubcategoria
            // 
            this.panelControlTstripSubcategoria.Controls.Add(this.btnInserirCategoria);
            this.panelControlTstripSubcategoria.Controls.Add(this.inputInserirSubCategoria);
            this.panelControlTstripSubcategoria.Controls.Add(this.pictureBoxSubCategoria);
            this.panelControlTstripSubcategoria.Controls.Add(this.toolStripSubCategoria);
            this.panelControlTstripSubcategoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControlTstripSubcategoria.Location = new System.Drawing.Point(0, 0);
            this.panelControlTstripSubcategoria.Name = "panelControlTstripSubcategoria";
            this.panelControlTstripSubcategoria.Size = new System.Drawing.Size(376, 52);
            this.panelControlTstripSubcategoria.TabIndex = 31;
            // 
            // btnInserirCategoria
            // 
            this.btnInserirCategoria.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnInserirCategoria.Appearance.Options.UseFont = true;
            this.btnInserirCategoria.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnInserirCategoria.ImageOptions.Image")));
            this.btnInserirCategoria.Location = new System.Drawing.Point(232, 5);
            this.btnInserirCategoria.Name = "btnInserirCategoria";
            this.btnInserirCategoria.Size = new System.Drawing.Size(24, 20);
            this.btnInserirCategoria.TabIndex = 34;
            this.btnInserirCategoria.Click += new System.EventHandler(this.btnInserirCategoria_Click);
            // 
            // inputInserirSubCategoria
            // 
            this.inputInserirSubCategoria.EditValue = "";
            this.inputInserirSubCategoria.Location = new System.Drawing.Point(72, 5);
            this.inputInserirSubCategoria.Name = "inputInserirSubCategoria";
            this.inputInserirSubCategoria.Properties.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.inputInserirSubCategoria.Properties.Appearance.Options.UseForeColor = true;
            this.inputInserirSubCategoria.Properties.NullValuePrompt = "Insira a Sub categoria";
            this.inputInserirSubCategoria.Size = new System.Drawing.Size(154, 20);
            this.inputInserirSubCategoria.TabIndex = 33;
            // 
            // panelControlGridSubCategoria
            // 
            this.panelControlGridSubCategoria.Controls.Add(this.gridViewSubCategoria);
            this.panelControlGridSubCategoria.Location = new System.Drawing.Point(0, 56);
            this.panelControlGridSubCategoria.Name = "panelControlGridSubCategoria";
            this.panelControlGridSubCategoria.Size = new System.Drawing.Size(376, 149);
            this.panelControlGridSubCategoria.TabIndex = 33;
            // 
            // categoriaTableAdapter
            // 
            this.categoriaTableAdapter.ClearBeforeFill = true;
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
            this.gridViewSubCategoria.Size = new System.Drawing.Size(372, 145);
            this.gridViewSubCategoria.TabIndex = 29;
            this.gridViewSubCategoria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewSubCategoria_CellContentClick);
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
            this.panelControlBtnSubCategoria.ResumeLayout(false);
            this.toolStripSubCategoria.ResumeLayout(false);
            this.toolStripSubCategoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlTstripSubcategoria)).EndInit();
            this.panelControlTstripSubcategoria.ResumeLayout(false);
            this.panelControlTstripSubcategoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputInserirSubCategoria.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlGridSubCategoria)).EndInit();
            this.panelControlGridSubCategoria.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSubCategoria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxSubCategoria;
        private System.Windows.Forms.Button btnCancelarSubCategoria;
        private System.Windows.Forms.Button btnCadastrarSubCategoria;
        private DevExpress.XtraEditors.PanelControl panelControlBtnSubCategoria;
        private System.Windows.Forms.ToolStrip toolStripSubCategoria;
        private System.Windows.Forms.ToolStripButton btnExcluirSubCategoria;
        private System.Windows.Forms.ToolStripButton btnEditarSubCategoria;
        private DevExpress.XtraEditors.PanelControl panelControlTstripSubcategoria;
        private DevExpress.XtraEditors.PanelControl panelControlGridSubCategoria;
        private DevExpress.XtraEditors.SimpleButton btnInserirCategoria;
        private DevExpress.XtraEditors.TextEdit inputInserirSubCategoria;
        private MassaFinaDataSet massaFinaDataSet;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private MassaFinaDataSetTableAdapters.categoriaTableAdapter categoriaTableAdapter;
        private System.Windows.Forms.DataGridView gridViewSubCategoria;
    }
}