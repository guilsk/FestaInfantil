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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbBoxCliente = new System.Windows.Forms.ComboBox();
            this.cmbBoxTema = new System.Windows.Forms.ComboBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.DateTimePicker();
            this.txtHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.txtHoraFim = new System.Windows.Forms.DateTimePicker();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.txtValorEntrada = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.listaItens = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tema:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Endereço:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(214, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Início:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(323, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fim:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 351);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Valor Total:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1, 400);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Valor Entrada:";
            // 
            // cmbBoxCliente
            // 
            this.cmbBoxCliente.FormattingEnabled = true;
            this.cmbBoxCliente.Location = new System.Drawing.Point(92, 12);
            this.cmbBoxCliente.Name = "cmbBoxCliente";
            this.cmbBoxCliente.Size = new System.Drawing.Size(152, 23);
            this.cmbBoxCliente.TabIndex = 8;
            this.cmbBoxCliente.SelectedIndexChanged += new System.EventHandler(this.cmbBoxCliente_SelectedIndexChanged);
            // 
            // cmbBoxTema
            // 
            this.cmbBoxTema.FormattingEnabled = true;
            this.cmbBoxTema.Location = new System.Drawing.Point(92, 55);
            this.cmbBoxTema.Name = "cmbBoxTema";
            this.cmbBoxTema.Size = new System.Drawing.Size(152, 23);
            this.cmbBoxTema.TabIndex = 9;
            this.cmbBoxTema.SelectedValueChanged += new System.EventHandler(this.cmbBoxTema_SelectedValueChanged);
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(92, 249);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(323, 23);
            this.txtEndereco.TabIndex = 10;
            // 
            // txtData
            // 
            this.txtData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtData.Location = new System.Drawing.Point(92, 298);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(116, 23);
            this.txtData.TabIndex = 11;
            // 
            // txtHoraInicio
            // 
            this.txtHoraInicio.CustomFormat = "HH:mm";
            this.txtHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtHoraInicio.Location = new System.Drawing.Point(259, 298);
            this.txtHoraInicio.Name = "txtHoraInicio";
            this.txtHoraInicio.ShowUpDown = true;
            this.txtHoraInicio.Size = new System.Drawing.Size(53, 23);
            this.txtHoraInicio.TabIndex = 12;
            // 
            // txtHoraFim
            // 
            this.txtHoraFim.CustomFormat = "HH:mm";
            this.txtHoraFim.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtHoraFim.Location = new System.Drawing.Point(359, 298);
            this.txtHoraFim.Name = "txtHoraFim";
            this.txtHoraFim.ShowUpDown = true;
            this.txtHoraFim.Size = new System.Drawing.Size(53, 23);
            this.txtHoraFim.TabIndex = 13;
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Location = new System.Drawing.Point(92, 347);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.ReadOnly = true;
            this.txtValorTotal.Size = new System.Drawing.Size(152, 23);
            this.txtValorTotal.TabIndex = 14;
            // 
            // txtValorEntrada
            // 
            this.txtValorEntrada.Location = new System.Drawing.Point(92, 396);
            this.txtValorEntrada.Name = "txtValorEntrada";
            this.txtValorEntrada.ReadOnly = true;
            this.txtValorEntrada.Size = new System.Drawing.Size(152, 23);
            this.txtValorEntrada.TabIndex = 15;
            // 
            // btnSalvar
            // 
            this.btnSalvar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSalvar.Location = new System.Drawing.Point(259, 344);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 75);
            this.btnSalvar.TabIndex = 17;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(340, 344);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 75);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(272, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 15);
            this.label9.TabIndex = 19;
            this.label9.Text = "Id:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(295, 12);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(117, 23);
            this.txtId.TabIndex = 20;
            this.txtId.Text = "0";
            // 
            // listaItens
            // 
            this.listaItens.FormattingEnabled = true;
            this.listaItens.Location = new System.Drawing.Point(92, 84);
            this.listaItens.Name = "listaItens";
            this.listaItens.Size = new System.Drawing.Size(320, 148);
            this.listaItens.TabIndex = 21;
            this.listaItens.SelectedIndexChanged += new System.EventHandler(this.listaItens_SelectedValueChanged);
            // 
            // TelaFestaForm
            // 
            this.AcceptButton = this.btnSalvar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(430, 432);
            this.Controls.Add(this.listaItens);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtValorEntrada);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.txtHoraFim);
            this.Controls.Add(this.txtHoraInicio);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.cmbBoxTema);
            this.Controls.Add(this.cmbBoxCliente);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaFestaForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Festas";
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private CheckedListBox listaItens;
    }
}