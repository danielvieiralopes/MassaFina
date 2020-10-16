namespace primeiraTela
{
    partial class FormCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCategoria));
            this.toolStripCategoria = new System.Windows.Forms.ToolStrip();
            this.btnSairCategoria = new System.Windows.Forms.ToolStripButton();
            this.btnMenu = new System.Windows.Forms.ToolStripButton();
            this.btnExcluirCategoria = new System.Windows.Forms.ToolStripButton();
            this.btnInserirCategoria = new System.Windows.Forms.ToolStripButton();
            this.btnSalvarCategoria = new System.Windows.Forms.ToolStripButton();
            this.panelControlGridCategoria = new DevExpress.XtraEditors.PanelControl();
            this.gridViewCategoria = new System.Windows.Forms.DataGridView();
            this.panelControlTstripCategoria = new DevExpress.XtraEditors.PanelControl();
            this.btnPesquisarCategoria = new System.Windows.Forms.PictureBox();
            this.inputInserirCategoria = new DevExpress.XtraEditors.TextEdit();
            this.pictureBoxCategoria = new System.Windows.Forms.PictureBox();
            this.massaFinaDataSet1 = new primeiraTela.MassaFinaDataSet();
            this.panelControlBtnCategoria = new DevExpress.XtraEditors.PanelControl();
            this.toolStripCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlGridCategoria)).BeginInit();
            this.panelControlGridCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlTstripCategoria)).BeginInit();
            this.panelControlTstripCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPesquisarCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputInserirCategoria.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.massaFinaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlBtnCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripCategoria
            // 
            this.toolStripCategoria.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripCategoria.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripCategoria.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripCategoria.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSairCategoria,
            this.btnMenu,
            this.btnExcluirCategoria,
            this.btnInserirCategoria,
            this.btnSalvarCategoria});
            this.toolStripCategoria.Location = new System.Drawing.Point(2, 42);
            this.toolStripCategoria.Name = "toolStripCategoria";
            this.toolStripCategoria.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripCategoria.Size = new System.Drawing.Size(399, 25);
            this.toolStripCategoria.TabIndex = 29;
            this.toolStripCategoria.Text = "toolStrip1";
            // 
            // btnSairCategoria
            // 
            this.btnSairCategoria.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSairCategoria.Image = ((System.Drawing.Image)(resources.GetObject("btnSairCategoria.Image")));
            this.btnSairCategoria.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSairCategoria.Name = "btnSairCategoria";
            this.btnSairCategoria.Size = new System.Drawing.Size(46, 22);
            this.btnSairCategoria.Text = "Sair";
            this.btnSairCategoria.Click += new System.EventHandler(this.btnSairCategoria_Click);
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
            // btnExcluirCategoria
            // 
            this.btnExcluirCategoria.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnExcluirCategoria.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirCategoria.Image")));
            this.btnExcluirCategoria.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcluirCategoria.Name = "btnExcluirCategoria";
            this.btnExcluirCategoria.Size = new System.Drawing.Size(61, 22);
            this.btnExcluirCategoria.Text = "Excluir";
            this.btnExcluirCategoria.Click += new System.EventHandler(this.btnExcluirCategoria_Click);
            // 
            // btnInserirCategoria
            // 
            this.btnInserirCategoria.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnInserirCategoria.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirCategoria.Image = ((System.Drawing.Image)(resources.GetObject("btnInserirCategoria.Image")));
            this.btnInserirCategoria.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInserirCategoria.Name = "btnInserirCategoria";
            this.btnInserirCategoria.Size = new System.Drawing.Size(60, 22);
            this.btnInserirCategoria.Text = "Inserir";
            this.btnInserirCategoria.Click += new System.EventHandler(this.btnInserirCategoria_Click);
            // 
            // btnSalvarCategoria
            // 
            this.btnSalvarCategoria.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSalvarCategoria.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvarCategoria.Image")));
            this.btnSalvarCategoria.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvarCategoria.Name = "btnSalvarCategoria";
            this.btnSalvarCategoria.Size = new System.Drawing.Size(58, 22);
            this.btnSalvarCategoria.Text = "Salvar";
            this.btnSalvarCategoria.Click += new System.EventHandler(this.btnSalvarCategoria_Click);
            // 
            // panelControlGridCategoria
            // 
            this.panelControlGridCategoria.Controls.Add(this.gridViewCategoria);
            this.panelControlGridCategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControlGridCategoria.Location = new System.Drawing.Point(0, 0);
            this.panelControlGridCategoria.Name = "panelControlGridCategoria";
            this.panelControlGridCategoria.Size = new System.Drawing.Size(403, 234);
            this.panelControlGridCategoria.TabIndex = 30;
            // 
            // gridViewCategoria
            // 
            this.gridViewCategoria.AccessibleName = "";
            this.gridViewCategoria.AllowUserToAddRows = false;
            this.gridViewCategoria.AllowUserToDeleteRows = false;
            this.gridViewCategoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridViewCategoria.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridViewCategoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridViewCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewCategoria.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridViewCategoria.Location = new System.Drawing.Point(2, 70);
            this.gridViewCategoria.Name = "gridViewCategoria";
            this.gridViewCategoria.ReadOnly = true;
            this.gridViewCategoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewCategoria.Size = new System.Drawing.Size(399, 162);
            this.gridViewCategoria.TabIndex = 28;
            this.gridViewCategoria.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewCategoria_CellDoubleClick);
            this.gridViewCategoria.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridViewCategoria_CellMouseClick);
            // 
            // panelControlTstripCategoria
            // 
            this.panelControlTstripCategoria.Controls.Add(this.btnPesquisarCategoria);
            this.panelControlTstripCategoria.Controls.Add(this.inputInserirCategoria);
            this.panelControlTstripCategoria.Controls.Add(this.pictureBoxCategoria);
            this.panelControlTstripCategoria.Controls.Add(this.toolStripCategoria);
            this.panelControlTstripCategoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControlTstripCategoria.Location = new System.Drawing.Point(0, 0);
            this.panelControlTstripCategoria.Name = "panelControlTstripCategoria";
            this.panelControlTstripCategoria.Size = new System.Drawing.Size(403, 69);
            this.panelControlTstripCategoria.TabIndex = 0;
            // 
            // btnPesquisarCategoria
            // 
            this.btnPesquisarCategoria.AccessibleName = "";
            this.btnPesquisarCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisarCategoria.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisarCategoria.Image")));
            this.btnPesquisarCategoria.ImageLocation = "";
            this.btnPesquisarCategoria.Location = new System.Drawing.Point(356, 12);
            this.btnPesquisarCategoria.Name = "btnPesquisarCategoria";
            this.btnPesquisarCategoria.Size = new System.Drawing.Size(43, 20);
            this.btnPesquisarCategoria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnPesquisarCategoria.TabIndex = 33;
            this.btnPesquisarCategoria.TabStop = false;
            this.btnPesquisarCategoria.Tag = "";
            this.btnPesquisarCategoria.Click += new System.EventHandler(this.btnPesquisarCategoria_Click);
            // 
            // inputInserirCategoria
            // 
            this.inputInserirCategoria.EditValue = "";
            this.inputInserirCategoria.Location = new System.Drawing.Point(72, 12);
            this.inputInserirCategoria.Name = "inputInserirCategoria";
            this.inputInserirCategoria.Properties.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.inputInserirCategoria.Properties.Appearance.Options.UseForeColor = true;
            this.inputInserirCategoria.Properties.NullValuePrompt = "Insira a categoria";
            this.inputInserirCategoria.Size = new System.Drawing.Size(278, 20);
            this.inputInserirCategoria.TabIndex = 31;
            this.inputInserirCategoria.EditValueChanged += new System.EventHandler(this.inputInserirCategoria_EditValueChanged);
            // 
            // pictureBoxCategoria
            // 
            this.pictureBoxCategoria.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCategoria.Image")));
            this.pictureBoxCategoria.Location = new System.Drawing.Point(9, 8);
            this.pictureBoxCategoria.Name = "pictureBoxCategoria";
            this.pictureBoxCategoria.Size = new System.Drawing.Size(54, 38);
            this.pictureBoxCategoria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxCategoria.TabIndex = 30;
            this.pictureBoxCategoria.TabStop = false;
            // 
            // massaFinaDataSet1
            // 
            this.massaFinaDataSet1.DataSetName = "MassaFinaDataSet";
            this.massaFinaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panelControlBtnCategoria
            // 
            this.panelControlBtnCategoria.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControlBtnCategoria.Location = new System.Drawing.Point(0, 234);
            this.panelControlBtnCategoria.Name = "panelControlBtnCategoria";
            this.panelControlBtnCategoria.Size = new System.Drawing.Size(403, 27);
            this.panelControlBtnCategoria.TabIndex = 28;
            // 
            // FormCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 261);
            this.Controls.Add(this.panelControlTstripCategoria);
            this.Controls.Add(this.panelControlGridCategoria);
            this.Controls.Add(this.panelControlBtnCategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCategoria";
            this.Load += new System.EventHandler(this.FormCategoria_Load);
            this.toolStripCategoria.ResumeLayout(false);
            this.toolStripCategoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlGridCategoria)).EndInit();
            this.panelControlGridCategoria.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlTstripCategoria)).EndInit();
            this.panelControlTstripCategoria.ResumeLayout(false);
            this.panelControlTstripCategoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPesquisarCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputInserirCategoria.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.massaFinaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlBtnCategoria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStripCategoria;
        private System.Windows.Forms.ToolStripButton btnSairCategoria;
        private DevExpress.XtraEditors.PanelControl panelControlGridCategoria;
        private DevExpress.XtraEditors.PanelControl panelControlTstripCategoria;
        private System.Windows.Forms.PictureBox pictureBoxCategoria;
        private DevExpress.XtraEditors.TextEdit inputInserirCategoria;
        private System.Windows.Forms.DataGridView gridViewCategoria;
        private MassaFinaDataSet massaFinaDataSet1;
        private System.Windows.Forms.ToolStripButton btnInserirCategoria;
        private System.Windows.Forms.ToolStripButton btnSalvarCategoria;
        private System.Windows.Forms.ToolStripButton btnExcluirCategoria;
        private DevExpress.XtraEditors.PanelControl panelControlBtnCategoria;
        private System.Windows.Forms.PictureBox btnPesquisarCategoria;
        private System.Windows.Forms.ToolStripButton btnMenu;
    }
}