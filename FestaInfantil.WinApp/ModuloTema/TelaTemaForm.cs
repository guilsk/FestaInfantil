using FestaInfantil.Compartilhado;
using System;
using System.Collections.Generic;

namespace FestaInfantil.ModuloTema {
    public partial class TelaTemaForm : Form {
        public TelaTemaForm() {
            InitializeComponent();

            this.ConfigurarDialog();
        }

        public Tema ObterTema() {
            int id = Convert.ToInt32(txtId.Text);
            string nome = txtNome.Text;

            return new Tema(id, nome);
        }

        internal void ConfigurarTela(Tema tema) {
            txtId.Text = tema.id.ToString();
            txtNome.Text = tema.nome;
        }
    }
}
