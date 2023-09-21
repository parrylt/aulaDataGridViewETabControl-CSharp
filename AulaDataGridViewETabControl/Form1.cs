using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AulaDataGridViewETabControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show ("Tem certeza que deseja sair?", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(textBoxCodigo.Text, textBoxNome.Text);
            limpar();
            buttonInserir.Enabled = true;
            buttonAdd.Enabled = false;
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            textBoxCodigo.Text = "";
            textBoxNome.Text = "";
            dataGridView1.Rows.Clear();
        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Insert(1, textBoxCodigo.Text, textBoxNome.Text);
            limpar();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Cells[0].RowIndex);
        }

        private void limpar()
        {
            textBoxCodigo.Clear();
            textBoxNome.Clear();
            textBoxCodigo.Focus();
        }
    }
}
