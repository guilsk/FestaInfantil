namespace FestaInfantil.ModuloFesta
{
    partial class TelaFestaForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            cmbBoxCliente = new ComboBox();
            cmbBoxTema = new ComboBox();
            txtEndereco = new TextBox();
            txtData = new DateTimePicker();
            txtHoraInicio = new DateTimePicker();
            txtHoraFim = new DateTimePicker();
            txtValorTotal = new TextBox();
            txtValorEntrada = new TextBox();
            btnSalvar = new Button();
            btnCancelar = new Button();
            label9 = new Label();
            txtId = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 16);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 59);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 1;
            label2.Text = "Tema";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 108);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 2;
            label3.Text = "Endereço";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 157);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 3;
            label4.Text = "Data";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(175, 157);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 4;
            label5.Text = "Início";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(302, 157);
            label6.Name = "label6";
            label6.Size = new Size(27, 15);
            label6.TabIndex = 5;
            label6.Text = "Fim";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 206);
            label7.Name = "label7";
            label7.Size = new Size(61, 15);
            label7.TabIndex = 6;
            label7.Text = "Valor Total";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1, 255);
            label8.Name = "label8";
            label8.Size = new Size(76, 15);
            label8.TabIndex = 7;
            label8.Text = "Valor Entrada";
            // 
            // cmbBoxCliente
            // 
            cmbBoxCliente.FormattingEnabled = true;
            cmbBoxCliente.Location = new Point(92, 12);
            cmbBoxCliente.Name = "cmbBoxCliente";
            cmbBoxCliente.Size = new Size(152, 23);
            cmbBoxCliente.TabIndex = 8;
            // 
            // cmbBoxTema
            // 
            cmbBoxTema.FormattingEnabled = true;
            cmbBoxTema.Location = new Point(92, 55);
            cmbBoxTema.Name = "cmbBoxTema";
            cmbBoxTema.Size = new Size(152, 23);
            cmbBoxTema.TabIndex = 9;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(92, 104);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(323, 23);
            txtEndereco.TabIndex = 10;
            // 
            // txtData
            // 
            txtData.Format = DateTimePickerFormat.Short;
            txtData.Location = new Point(92, 153);
            txtData.Name = "txtData";
            txtData.Size = new Size(75, 23);
            txtData.TabIndex = 11;
            // 
            // txtHoraInicio
            // 
            txtHoraInicio.Format = DateTimePickerFormat.Time;
            txtHoraInicio.Location = new Point(219, 153);
            txtHoraInicio.Name = "txtHoraInicio";
            txtHoraInicio.ShowUpDown = true;
            txtHoraInicio.Size = new Size(75, 23);
            txtHoraInicio.TabIndex = 12;
            // 
            // txtHoraFim
            // 
            txtHoraFim.Format = DateTimePickerFormat.Time;
            txtHoraFim.Location = new Point(337, 153);
            txtHoraFim.Name = "txtHoraFim";
            txtHoraFim.ShowUpDown = true;
            txtHoraFim.Size = new Size(75, 23);
            txtHoraFim.TabIndex = 13;
            // 
            // txtValorTotal
            // 
            txtValorTotal.Location = new Point(92, 202);
            txtValorTotal.Name = "txtValorTotal";
            txtValorTotal.ReadOnly = true;
            txtValorTotal.Size = new Size(152, 23);
            txtValorTotal.TabIndex = 14;
            // 
            // txtValorEntrada
            // 
            txtValorEntrada.Location = new Point(92, 251);
            txtValorEntrada.Name = "txtValorEntrada";
            txtValorEntrada.ReadOnly = true;
            txtValorEntrada.Size = new Size(152, 23);
            txtValorEntrada.TabIndex = 15;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(256, 199);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 75);
            btnSalvar.TabIndex = 17;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(337, 199);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 75);
            btnCancelar.TabIndex = 18;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(272, 16);
            label9.Name = "label9";
            label9.Size = new Size(17, 15);
            label9.TabIndex = 19;
            label9.Text = "Id";
            // 
            // txtId
            // 
            txtId.Location = new Point(295, 12);
            txtId.Name = "txtId";
            txtId.Size = new Size(117, 23);
            txtId.TabIndex = 20;
            // 
            // TelaFestaForm
            // 
            AcceptButton = btnSalvar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new Size(449, 298);
            Controls.Add(txtId);
            Controls.Add(label9);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(txtValorEntrada);
            Controls.Add(txtValorTotal);
            Controls.Add(txtHoraFim);
            Controls.Add(txtHoraInicio);
            Controls.Add(txtData);
            Controls.Add(txtEndereco);
            Controls.Add(cmbBoxTema);
            Controls.Add(cmbBoxCliente);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaFestaForm";
            ShowIcon = false;
            Text = "Cadastro de Festas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private ComboBox cmbBoxCliente;
        private ComboBox cmbBoxTema;
        private TextBox txtEndereco;
        private DateTimePicker txtData;
        private DateTimePicker txtHoraInicio;
        private DateTimePicker txtHoraFim;
        private TextBox txtValorTotal;
        private TextBox txtValorEntrada;
        private Button btnSalvar;
        private Button btnCancelar;
        private Label label9;
        private TextBox txtId;
    }
}