﻿namespace primeiraTela
{
    partial class FormClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClientes));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.inputPesquisarCliente = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnCadastrar = new System.Windows.Forms.ToolStripButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.gridCliente = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colunaCodCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colunaNomeCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colunaEndereçpCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colunaSituacaoCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colunaSaldoCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // inputPesquisarCliente
            // 
            this.inputPesquisarCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputPesquisarCliente.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputPesquisarCliente.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.inputPesquisarCliente.Location = new System.Drawing.Point(117, 12);
            this.inputPesquisarCliente.Name = "inputPesquisarCliente";
            this.inputPesquisarCliente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.inputPesquisarCliente.Size = new System.Drawing.Size(428, 19);
            this.inputPesquisarCliente.TabIndex = 13;
            this.inputPesquisarCliente.Text = "Pesquisar cliente";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.ImageLocation = "";
            this.pictureBox2.Location = new System.Drawing.Point(551, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(117, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 1);
            this.panel1.TabIndex = 15;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.pictureBox1);
            this.panelControl1.Controls.Add(this.btnSair);
            this.panelControl1.Controls.Add(this.btnMenu);
            this.panelControl1.Controls.Add(this.inputPesquisarCliente);
            this.panelControl1.Controls.Add(this.pictureBox2);
            this.panelControl1.Controls.Add(this.panel1);
            this.panelControl1.Controls.Add(this.toolStrip1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(800, 100);
            this.panelControl1.TabIndex = 16;
            // 
            // btnSair
            // 
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(760, 12);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(28, 27);
            this.btnSair.TabIndex = 18;
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.Location = new System.Drawing.Point(724, 12);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(30, 27);
            this.btnMenu.TabIndex = 17;
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExcluir,
            this.btnEditar,
            this.btnCadastrar});
            this.toolStrip1.Location = new System.Drawing.Point(2, 73);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(796, 25);
            this.toolStrip1.TabIndex = 19;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(61, 22);
            this.btnExcluir.Text = "Excluir";
            // 
            // btnEditar
            // 
            this.btnEditar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(58, 22);
            this.btnEditar.Text = "Editar";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(77, 22);
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.pictureBox3);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 504);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(800, 96);
            this.panelControl2.TabIndex = 17;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(605, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(195, 96);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.gridCliente);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(0, 100);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(800, 404);
            this.panelControl3.TabIndex = 18;
            // 
            // gridCliente
            // 
            this.gridCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCliente.Location = new System.Drawing.Point(2, 2);
            this.gridCliente.MainView = this.gridView2;
            this.gridCliente.Name = "gridCliente";
            this.gridCliente.Size = new System.Drawing.Size(796, 400);
            this.gridCliente.TabIndex = 20;
            this.gridCliente.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colunaCodCliente,
            this.colunaNomeCliente,
            this.colunaEndereçpCliente,
            this.colunaSituacaoCliente,
            this.colunaSaldoCliente});
            this.gridView2.GridControl = this.gridCliente;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsCustomization.AllowGroup = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colunaCodCliente
            // 
            this.colunaCodCliente.FieldName = "Código";
            this.colunaCodCliente.Name = "colunaCodCliente";
            this.colunaCodCliente.Visible = true;
            this.colunaCodCliente.VisibleIndex = 0;
            // 
            // colunaNomeCliente
            // 
            this.colunaNomeCliente.FieldName = "Nome";
            this.colunaNomeCliente.Name = "colunaNomeCliente";
            this.colunaNomeCliente.Visible = true;
            this.colunaNomeCliente.VisibleIndex = 1;
            // 
            // colunaEndereçpCliente
            // 
            this.colunaEndereçpCliente.FieldName = "Endereço";
            this.colunaEndereçpCliente.Name = "colunaEndereçpCliente";
            this.colunaEndereçpCliente.Visible = true;
            this.colunaEndereçpCliente.VisibleIndex = 2;
            // 
            // colunaSituacaoCliente
            // 
            this.colunaSituacaoCliente.FieldName = "Situação";
            this.colunaSituacaoCliente.Name = "colunaSituacaoCliente";
            this.colunaSituacaoCliente.Visible = true;
            this.colunaSituacaoCliente.VisibleIndex = 3;
            // 
            // colunaSaldoCliente
            // 
            this.colunaSaldoCliente.FieldName = "Saldo";
            this.colunaSaldoCliente.Name = "colunaSaldoCliente";
            this.colunaSaldoCliente.Visible = true;
            this.colunaSaldoCliente.VisibleIndex = 4;
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox inputPesquisarCliente;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnExcluir;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton btnCadastrar;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraGrid.GridControl gridCliente;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colunaCodCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colunaNomeCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colunaEndereçpCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colunaSituacaoCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colunaSaldoCliente;
    }
}