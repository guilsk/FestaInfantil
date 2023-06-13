namespace FestaInfantil.ModuloCliente
{
    partial class TelaClienteForm
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
            txtNome = new TextBox();
            txtTelefone = new TextBox();
            labelTitulo = new Label();
            txtId = new TextBox();
            label6 = new Label();
            label1 = new Label();
            btnConfirmar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(78, 26);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(214, 23);
            txtNome.TabIndex = 2;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(78, 55);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(214, 23);
            txtTelefone.TabIndex = 3;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Location = new Point(26, 29);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(46, 15);
            labelTitulo.TabIndex = 28;
            labelTitulo.Text = "Nome: ";
            // 
            // txtId
            // 
            txtId.Location = new Point(78, 90);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(38, 23);
            txtId.TabIndex = 29;
            txtId.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(48, 93);
            label6.Name = "label6";
            label6.Size = new Size(24, 15);
            label6.TabIndex = 30;
            label6.Text = "ID: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 58);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 31;
            label1.Text = "Telefone:";
            // 
            // btnConfirmar
            // 
            btnConfirmar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnConfirmar.DialogResult = DialogResult.OK;
            btnConfirmar.Location = new Point(213, 84);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(79, 35);
            btnConfirmar.TabIndex = 32;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(298, 84);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(81, 35);
            btnCancelar.TabIndex = 33;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            
            // 
            // TelaClienteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 125);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(txtId);
            Controls.Add(labelTitulo);
            Controls.Add(txtTelefone);
            Controls.Add(txtNome);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaClienteForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Tela Cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtNome;
        private TextBox txtTelefone;
        private Label labelTitulo;
        private TextBox txtId;
        private Label label6;
        private Label label1;
        private Button btnConfirmar;
        private Button btnCancelar;
    }
}