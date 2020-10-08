namespace primeiraTela
{
    public partial class FormMenu
    {

      

        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnOrçamento = new System.Windows.Forms.Button();
            this.btnFinanceiro = new System.Windows.Forms.Button();
            this.btnPedidos = new System.Windows.Forms.Button();
            this.btnVendas = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnProduto = new System.Windows.Forms.Button();
            this.btnAjuste = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.btnOrçamento);
            this.panelMenu.Controls.Add(this.btnFinanceiro);
            this.panelMenu.Controls.Add(this.btnPedidos);
            this.panelMenu.Controls.Add(this.btnVendas);
            this.panelMenu.Controls.Add(this.btnClientes);
            this.panelMenu.Controls.Add(this.btnProduto);
            this.panelMenu.Location = new System.Drawing.Point(128, 147);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(544, 317);
            this.panelMenu.TabIndex = 0;
            // 
            // btnOrçamento
            // 
            this.btnOrçamento.FlatAppearance.BorderSize = 0;
            this.btnOrçamento.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOrçamento.Image = ((System.Drawing.Image)(resources.GetObject("btnOrçamento.Image")));
            this.btnOrçamento.Location = new System.Drawing.Point(382, 181);
            this.btnOrçamento.Name = "btnOrçamento";
            this.btnOrçamento.Size = new System.Drawing.Size(120, 100);
            this.btnOrçamento.TabIndex = 8;
            this.btnOrçamento.Text = "Orçamento";
            this.btnOrçamento.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOrçamento.UseVisualStyleBackColor = true;
            this.btnOrçamento.Click += new System.EventHandler(this.btnOrçamento_Click);
            // 
            // btnFinanceiro
            // 
            this.btnFinanceiro.FlatAppearance.BorderSize = 0;
            this.btnFinanceiro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFinanceiro.Image = ((System.Drawing.Image)(resources.GetObject("btnFinanceiro.Image")));
            this.btnFinanceiro.Location = new System.Drawing.Point(46, 181);
            this.btnFinanceiro.Name = "btnFinanceiro";
            this.btnFinanceiro.Size = new System.Drawing.Size(120, 100);
            this.btnFinanceiro.TabIndex = 6;
            this.btnFinanceiro.Text = "Financeiro";
            this.btnFinanceiro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFinanceiro.UseVisualStyleBackColor = true;
            this.btnFinanceiro.Click += new System.EventHandler(this.btnFinanceiro_Click);
            // 
            // btnPedidos
            // 
            this.btnPedidos.FlatAppearance.BorderSize = 0;
            this.btnPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPedidos.Image = ((System.Drawing.Image)(resources.GetObject("btnPedidos.Image")));
            this.btnPedidos.Location = new System.Drawing.Point(209, 181);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(120, 100);
            this.btnPedidos.TabIndex = 7;
            this.btnPedidos.Text = "Pedidos";
            this.btnPedidos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPedidos.UseVisualStyleBackColor = true;
            this.btnPedidos.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnVendas
            // 
            this.btnVendas.FlatAppearance.BorderSize = 0;
            this.btnVendas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVendas.Image = ((System.Drawing.Image)(resources.GetObject("btnVendas.Image")));
            this.btnVendas.Location = new System.Drawing.Point(382, 37);
            this.btnVendas.Name = "btnVendas";
            this.btnVendas.Size = new System.Drawing.Size(120, 100);
            this.btnVendas.TabIndex = 5;
            this.btnVendas.Text = "Vendas";
            this.btnVendas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVendas.UseVisualStyleBackColor = true;
            this.btnVendas.Click += new System.EventHandler(this.btnVendas_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.Image")));
            this.btnClientes.Location = new System.Drawing.Point(209, 37);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(120, 100);
            this.btnClientes.TabIndex = 4;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnProduto
            // 
            this.btnProduto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnProduto.FlatAppearance.BorderSize = 0;
            this.btnProduto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnProduto.Image")));
            this.btnProduto.Location = new System.Drawing.Point(46, 37);
            this.btnProduto.Name = "btnProduto";
            this.btnProduto.Size = new System.Drawing.Size(120, 100);
            this.btnProduto.TabIndex = 3;
            this.btnProduto.Text = "Produtos";
            this.btnProduto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProduto.UseVisualStyleBackColor = true;
            this.btnProduto.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAjuste
            // 
            this.btnAjuste.FlatAppearance.BorderSize = 0;
            this.btnAjuste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjuste.Image = ((System.Drawing.Image)(resources.GetObject("btnAjuste.Image")));
            this.btnAjuste.Location = new System.Drawing.Point(674, 12);
            this.btnAjuste.Name = "btnAjuste";
            this.btnAjuste.Size = new System.Drawing.Size(45, 45);
            this.btnAjuste.TabIndex = 1;
            this.btnAjuste.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(725, 12);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(45, 45);
            this.btnSair.TabIndex = 2;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.button8_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnAjuste);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.GrayText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  ";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnAjuste;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnOrçamento;
        private System.Windows.Forms.Button btnFinanceiro;
        private System.Windows.Forms.Button btnPedidos;
        private System.Windows.Forms.Button btnVendas;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnProduto;
    }
}

