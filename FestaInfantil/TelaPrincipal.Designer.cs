namespace FestaInfantil
{
    partial class TelaPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tpMenuCadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.festaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aluguelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelRegistros = new System.Windows.Forms.Panel();
            this.lbRodape = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnInserir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAdicionarItensTema = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExcluirItensTema = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnFecharAluguel = new System.Windows.Forms.ToolStripButton();
            this.labelTipoCadastro = new System.Windows.Forms.ToolStripLabel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tpMenuCadastros});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(682, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tpMenuCadastros
            // 
            this.tpMenuCadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.temasToolStripMenuItem,
            this.festaToolStripMenuItem,
            this.aluguelToolStripMenuItem});
            this.tpMenuCadastros.Name = "tpMenuCadastros";
            this.tpMenuCadastros.Size = new System.Drawing.Size(71, 20);
            this.tpMenuCadastros.Text = "Cadastros";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // temasToolStripMenuItem
            // 
            this.temasToolStripMenuItem.Name = "temasToolStripMenuItem";
            this.temasToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.temasToolStripMenuItem.Text = "Temas";
            this.temasToolStripMenuItem.Click += new System.EventHandler(this.temasToolStripMenuItem_Click);
            // 
            // festaToolStripMenuItem
            // 
            this.festaToolStripMenuItem.Name = "festaToolStripMenuItem";
            this.festaToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.festaToolStripMenuItem.Text = "Festa";
            // 
            // aluguelToolStripMenuItem
            // 
            this.aluguelToolStripMenuItem.Name = "aluguelToolStripMenuItem";
            this.aluguelToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aluguelToolStripMenuItem.Text = "Aluguel";
            // 
            // panelRegistros
            // 
            this.panelRegistros.Location = new System.Drawing.Point(0, 53);
            this.panelRegistros.MaximumSize = new System.Drawing.Size(682, 276);
            this.panelRegistros.MinimumSize = new System.Drawing.Size(682, 276);
            this.panelRegistros.Name = "panelRegistros";
            this.panelRegistros.Size = new System.Drawing.Size(682, 276);
            this.panelRegistros.TabIndex = 1;
            // 
            // lbRodape
            // 
            this.lbRodape.AutoSize = true;
            this.lbRodape.Location = new System.Drawing.Point(12, 332);
            this.lbRodape.Name = "lbRodape";
            this.lbRodape.Size = new System.Drawing.Size(47, 15);
            this.lbRodape.TabIndex = 0;
            this.lbRodape.Text = "RodaPe";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Enabled = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnInserir,
            this.toolStripSeparator3,
            this.btnEditar,
            this.toolStripSeparator1,
            this.btnExcluir,
            this.toolStripSeparator2,
            this.btnAdicionarItensTema,
            this.toolStripSeparator4,
            this.btnExcluirItensTema,
            this.toolStripSeparator5,
            this.btnFecharAluguel,
            this.labelTipoCadastro});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(682, 31);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnInserir
            // 
            this.btnInserir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnInserir.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInserir.Image = ((System.Drawing.Image)(resources.GetObject("btnInserir.Image")));
            this.btnInserir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnInserir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(28, 28);
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click_1);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 31);
            // 
            // btnEditar
            // 
            this.btnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(28, 28);
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click_1);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // btnExcluir
            // 
            this.btnExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(28, 28);
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click_1);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // btnAdicionarItensTema
            // 
            this.btnAdicionarItensTema.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAdicionarItensTema.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionarItensTema.Image")));
            this.btnAdicionarItensTema.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAdicionarItensTema.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdicionarItensTema.Name = "btnAdicionarItensTema";
            this.btnAdicionarItensTema.Size = new System.Drawing.Size(28, 28);
            this.btnAdicionarItensTema.Click += new System.EventHandler(this.btnAdicionarItensTema_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 31);
            // 
            // btnExcluirItensTema
            // 
            this.btnExcluirItensTema.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExcluirItensTema.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirItensTema.Image")));
            this.btnExcluirItensTema.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnExcluirItensTema.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcluirItensTema.Name = "btnExcluirItensTema";
            this.btnExcluirItensTema.Size = new System.Drawing.Size(28, 28);
            this.btnExcluirItensTema.Click += new System.EventHandler(this.btnExcluirItensTema_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 31);
            // 
            // btnFecharAluguel
            // 
            this.btnFecharAluguel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFecharAluguel.Image = ((System.Drawing.Image)(resources.GetObject("btnFecharAluguel.Image")));
            this.btnFecharAluguel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnFecharAluguel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFecharAluguel.Name = "btnFecharAluguel";
            this.btnFecharAluguel.Size = new System.Drawing.Size(28, 28);
            // 
            // labelTipoCadastro
            // 
            this.labelTipoCadastro.Name = "labelTipoCadastro";
            this.labelTipoCadastro.Size = new System.Drawing.Size(80, 28);
            this.labelTipoCadastro.Text = "Tipo Cadastro";
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 350);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lbRodape);
            this.Controls.Add(this.panelRegistros);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(698, 389);
            this.MinimumSize = new System.Drawing.Size(698, 389);
            this.Name = "TelaPrincipal";
            this.ShowIcon = false;
            this.Text = "Infantil";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tpMenuCadastros;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem temasToolStripMenuItem;
        private ToolStripMenuItem festaToolStripMenuItem;
        private ToolStripMenuItem aluguelToolStripMenuItem;
        private Panel panelRegistros;
        private Label lbRodape;
        private ToolStrip toolStrip1;
        private ToolStripButton btnInserir;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton btnEditar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnExcluir;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btnAdicionarItensTema;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton btnExcluirItensTema;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripButton btnFecharAluguel;
        private ToolStripLabel labelTipoCadastro;
    }
}