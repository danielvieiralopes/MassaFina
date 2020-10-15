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
            this.btnCadastrarCategoria = new System.Windows.Forms.Button();
            this.btnCancelarCategoria = new System.Windows.Forms.Button();
            this.panelControlBtnCategoria = new DevExpress.XtraEditors.PanelControl();
            this.toolStripCategoria = new System.Windows.Forms.ToolStrip();
            this.btnExcluirCategoria = new System.Windows.Forms.ToolStripButton();
            this.btnEditarCategoria = new System.Windows.Forms.ToolStripButton();
            this.panelControlGridCategoria = new DevExpress.XtraEditors.PanelControl();
            this.panelControlTstripCategoria = new DevExpress.XtraEditors.PanelControl();
            this.btnInserirCategoria = new DevExpress.XtraEditors.SimpleButton();
            this.inputInserirCategoria = new DevExpress.XtraEditors.TextEdit();
            this.pictureBoxCategoria = new System.Windows.Forms.PictureBox();
            this.massaFinaDataSet1 = new primeiraTela.MassaFinaDataSet();
            this.gridViewCategoria = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlBtnCategoria)).BeginInit();
            this.panelControlBtnCategoria.SuspendLayout();
            this.toolStripCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlGridCategoria)).BeginInit();
            this.panelControlGridCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlTstripCategoria)).BeginInit();
            this.panelControlTstripCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputInserirCategoria.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.massaFinaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadastrarCategoria
            // 
            this.btnCadastrarCategoria.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnCadastrarCategoria.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarCategoria.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrarCategoria.Image")));
            this.btnCadastrarCategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarCategoria.Location = new System.Drawing.Point(17, 9);
            this.btnCadastrarCategoria.Name = "btnCadastrarCategoria";
            this.btnCadastrarCategoria.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnCadastrarCategoria.Size = new System.Drawing.Size(168, 36);
            this.btnCadastrarCategoria.TabIndex = 25;
            this.btnCadastrarCategoria.Text = "Cadastrar";
            this.btnCadastrarCategoria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastrarCategoria.UseVisualStyleBackColor = false;
            this.btnCadastrarCategoria.Click += new System.EventHandler(this.btnCadastrarCategoria_Click);
            // 
            // btnCancelarCategoria
            // 
            this.btnCancelarCategoria.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnCancelarCategoria.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarCategoria.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarCategoria.Image")));
            this.btnCancelarCategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarCategoria.Location = new System.Drawing.Point(201, 9);
            this.btnCancelarCategoria.Name = "btnCancelarCategoria";
            this.btnCancelarCategoria.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnCancelarCategoria.Size = new System.Drawing.Size(168, 36);
            this.btnCancelarCategoria.TabIndex = 26;
            this.btnCancelarCategoria.Text = "Cancelar";
            this.btnCancelarCategoria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelarCategoria.UseVisualStyleBackColor = false;
            this.btnCancelarCategoria.Click += new System.EventHandler(this.btnCancelarCategoria_Click);
            // 
            // panelControlBtnCategoria
            // 
            this.panelControlBtnCategoria.Controls.Add(this.btnCancelarCategoria);
            this.panelControlBtnCategoria.Controls.Add(this.btnCadastrarCategoria);
            this.panelControlBtnCategoria.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControlBtnCategoria.Location = new System.Drawing.Point(0, 209);
            this.panelControlBtnCategoria.Name = "panelControlBtnCategoria";
            this.panelControlBtnCategoria.Size = new System.Drawing.Size(384, 52);
            this.panelControlBtnCategoria.TabIndex = 28;
            // 
            // toolStripCategoria
            // 
            this.toolStripCategoria.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripCategoria.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripCategoria.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripCategoria.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExcluirCategoria,
            this.btnEditarCategoria});
            this.toolStripCategoria.Location = new System.Drawing.Point(2, 25);
            this.toolStripCategoria.Name = "toolStripCategoria";
            this.toolStripCategoria.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripCategoria.Size = new System.Drawing.Size(380, 25);
            this.toolStripCategoria.TabIndex = 29;
            this.toolStripCategoria.Text = "toolStrip1";
            // 
            // btnExcluirCategoria
            // 
            this.btnExcluirCategoria.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnExcluirCategoria.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirCategoria.Image")));
            this.btnExcluirCategoria.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcluirCategoria.Name = "btnExcluirCategoria";
            this.btnExcluirCategoria.Size = new System.Drawing.Size(61, 22);
            this.btnExcluirCategoria.Text = "Excluir";
            // 
            // btnEditarCategoria
            // 
            this.btnEditarCategoria.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnEditarCategoria.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarCategoria.Image")));
            this.btnEditarCategoria.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditarCategoria.Name = "btnEditarCategoria";
            this.btnEditarCategoria.Size = new System.Drawing.Size(58, 22);
            this.btnEditarCategoria.Text = "Editar";
            this.btnEditarCategoria.Click += new System.EventHandler(this.btnEditarCategoria_Click);
            // 
            // panelControlGridCategoria
            // 
            this.panelControlGridCategoria.Controls.Add(this.gridViewCategoria);
            this.panelControlGridCategoria.Location = new System.Drawing.Point(0, 56);
            this.panelControlGridCategoria.Name = "panelControlGridCategoria";
            this.panelControlGridCategoria.Size = new System.Drawing.Size(384, 149);
            this.panelControlGridCategoria.TabIndex = 30;
            // 
            // panelControlTstripCategoria
            // 
            this.panelControlTstripCategoria.Controls.Add(this.btnInserirCategoria);
            this.panelControlTstripCategoria.Controls.Add(this.inputInserirCategoria);
            this.panelControlTstripCategoria.Controls.Add(this.pictureBoxCategoria);
            this.panelControlTstripCategoria.Controls.Add(this.toolStripCategoria);
            this.panelControlTstripCategoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControlTstripCategoria.Location = new System.Drawing.Point(0, 0);
            this.panelControlTstripCategoria.Name = "panelControlTstripCategoria";
            this.panelControlTstripCategoria.Size = new System.Drawing.Size(384, 52);
            this.panelControlTstripCategoria.TabIndex = 0;
            this.panelControlTstripCategoria.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl2_Paint);
            // 
            // btnInserirCategoria
            // 
            this.btnInserirCategoria.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnInserirCategoria.Appearance.Options.UseFont = true;
            this.btnInserirCategoria.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnInserirCategoria.ImageOptions.Image")));
            this.btnInserirCategoria.Location = new System.Drawing.Point(232, 5);
            this.btnInserirCategoria.Name = "btnInserirCategoria";
            this.btnInserirCategoria.Size = new System.Drawing.Size(24, 20);
            this.btnInserirCategoria.TabIndex = 32;
            this.btnInserirCategoria.Click += new System.EventHandler(this.btnInserirCategoria_Click);
            // 
            // inputInserirCategoria
            // 
            this.inputInserirCategoria.EditValue = "";
            this.inputInserirCategoria.Location = new System.Drawing.Point(72, 5);
            this.inputInserirCategoria.Name = "inputInserirCategoria";
            this.inputInserirCategoria.Properties.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.inputInserirCategoria.Properties.Appearance.Options.UseForeColor = true;
            this.inputInserirCategoria.Properties.NullValuePrompt = "Insira a categoria";
            this.inputInserirCategoria.Size = new System.Drawing.Size(154, 20);
            this.inputInserirCategoria.TabIndex = 31;
            // 
            // pictureBoxCategoria
            // 
            this.pictureBoxCategoria.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCategoria.Image")));
            this.pictureBoxCategoria.Location = new System.Drawing.Point(12, 5);
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
            // gridViewCategoria
            // 
            this.gridViewCategoria.AccessibleName = "";
            this.gridViewCategoria.AllowUserToAddRows = false;
            this.gridViewCategoria.AllowUserToDeleteRows = false;
            this.gridViewCategoria.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridViewCategoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridViewCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewCategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridViewCategoria.Location = new System.Drawing.Point(2, 2);
            this.gridViewCategoria.Name = "gridViewCategoria";
            this.gridViewCategoria.ReadOnly = true;
            this.gridViewCategoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewCategoria.Size = new System.Drawing.Size(380, 145);
            this.gridViewCategoria.TabIndex = 28;
            this.gridViewCategoria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewCategoria_CellContentClick);
            // 
            // FormCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.panelControlTstripCategoria);
            this.Controls.Add(this.panelControlGridCategoria);
            this.Controls.Add(this.panelControlBtnCategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCategoria";
            this.Load += new System.EventHandler(this.FormCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlBtnCategoria)).EndInit();
            this.panelControlBtnCategoria.ResumeLayout(false);
            this.toolStripCategoria.ResumeLayout(false);
            this.toolStripCategoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlGridCategoria)).EndInit();
            this.panelControlGridCategoria.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlTstripCategoria)).EndInit();
            this.panelControlTstripCategoria.ResumeLayout(false);
            this.panelControlTstripCategoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputInserirCategoria.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.massaFinaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCategoria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrarCategoria;
        private System.Windows.Forms.Button btnCancelarCategoria;
        private DevExpress.XtraEditors.PanelControl panelControlBtnCategoria;
        private System.Windows.Forms.ToolStrip toolStripCategoria;
        private System.Windows.Forms.ToolStripButton btnExcluirCategoria;
        private System.Windows.Forms.ToolStripButton btnEditarCategoria;
        private DevExpress.XtraEditors.PanelControl panelControlGridCategoria;
        private DevExpress.XtraEditors.PanelControl panelControlTstripCategoria;
        private System.Windows.Forms.PictureBox pictureBoxCategoria;
        private DevExpress.XtraEditors.SimpleButton btnInserirCategoria;
        private DevExpress.XtraEditors.TextEdit inputInserirCategoria;
        private System.Windows.Forms.DataGridView gridViewCategoria;
        private MassaFinaDataSet massaFinaDataSet1;
    }
}