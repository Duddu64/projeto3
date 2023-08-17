using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;

namespace pjt3
{
    public partial class FormAluno : MaterialForm
    {
        string alunosFilename = "alunos.txt";
        bool isAlteracao=true;
        int indexselecionado = 0;
        public FormAluno()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click_1(object sender, EventArgs e)
        {

        }

        private void materialTextBoxEdit3_Click(object sender, EventArgs e)
        {

        }

        private void materialComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtdata_Click(object sender, EventArgs e)
        {

        }

        private void FormAluno_Load(object sender, EventArgs e)
        {

        }

        private void txtmaricula_Click(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (ValidarFormulario())
            {
                Salvar();
                materialTabControl1.SelectedIndex = 1;
            }
        }

        private void Salvar()
        {
            var line = $"{txtmaricula.Text};" +
                       $"{txtdata.Text};" +
                       $"{txtnome.Text};" +
                       $"{txtendereco.Text};" +
                       $"{txtbairro.Text};" +
                       $"{txtcidade.Text};" +
                       $"{txtuf.Text};" +
                       $"{txtsenha.Text};";

            if (isAlteracao)
            {
                var file = new StreamWriter(alunosFilename, true);
                file.WriteLine(line);
                file.Close();
            }
            else
            {
                var file = File.ReadAllLines(alunosFilename);
                file[indexselecionado] = line;
                File.WriteAllLines(alunosFilename, file);
            }
            LimpaCampos();
        }

        private bool ValidarFormulario()
        {
            if (string.IsNullOrEmpty(txtmaricula.Text))
            {
                MessageBox.Show("Mátricula é Obrigátoria", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmaricula.Focus();

                return false;
            }
            if (string.IsNullOrEmpty(txtnome.Text))
            {
                MessageBox.Show("Nome é Obrigátoria", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtnome.Focus();

                return false;
            }
            if (string.IsNullOrEmpty(txtsenha.Text))
            {
                MessageBox.Show("Senha é Obrigátoria", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtsenha.Focus();

                return false;
            }
            if (string.IsNullOrEmpty(txtdata.Text))
            {
                MessageBox.Show("Data é Obrigátoria", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtdata.Focus();

                return false;
            }
            if (string.IsNullOrEmpty(txtcidade.Text))
            {
                MessageBox.Show("Cidade é Obrigátoria", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtcidade.Focus();

                return false;
            }
            if(string.IsNullOrEmpty(txtendereco.Text))
            {
                MessageBox.Show("Cidade é Obrigátoria", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtendereco.Focus();

                return false;
            }
            return true;
        }

        private void Carregalist()
        {
            Cursor.Current= Cursors.WaitCursor;
            listView1.Columns.Clear();
            listView1.Items.Clear();

            listView1.Columns.Add("Matricula");
            listView1.Columns.Add("Data");
            listView1.Columns.Add("Nome");
            listView1.Columns.Add("Endereço");
            listView1.Columns.Add("Bairro");
            listView1.Columns.Add("Cidade");
            listView1.Columns.Add("UF");
            listView1.Columns.Add("Senha");

            var lines = File.ReadAllLines(alunosFilename);
            foreach (var line in lines) { 
                var campos = line.Split(';');
                listView1.Items.Add(new ListViewItem(campos));
            }
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            Cursor.Current = Cursors.Default;
        }

        private void tabPages2_Enter(object sender, EventArgs e) {
            Carregalist();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
            if ((e.ItemIndex%2) == 1)
            {
                e.Item.BackColor = Color.FromArgb(230, 230, 255);
                e.Item.UseItemStyleForSubItems= true;
            }
        }

        private void LimpaCampos()
        {
            isAlteracao = false;
            foreach(var control in tabPage1.Controls)
            {
                if (control is MaterialTextBoxEdit)
                {
                    ((MaterialTextBoxEdit)control).Clear();
                }
                if (control is MaterialMaskedTextBox)
                {
                    ((MaterialMaskedTextBox)control).Clear();
                }
            }
        }


        private void materialButton1_Click(object sender, EventArgs e)
        {
            LimpaCampos();
            materialTabControl1.SelectedIndex = 0;
            txtmaricula.Focus();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja cancelar a operação?", "IFSP", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                LimpaCampos();
                materialTabControl1.SelectedIndex = 1;
                txtmaricula.Focus();
            }
            else
            {

            }
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            Editar();

        }
        private void Editar()
        {
            if (listView1.SelectedIndices.Count>0)
            {
                indexselecionado = listView1.SelectedItems[0].Index;
                isAlteracao = true;
                var item = listView1.SelectedItems[0];
                txtmaricula.Text = item.SubItems[0].Text;
                txtdata.Text = item.SubItems[1].Text;
                txtnome.Text = item.SubItems[2].Text;
                txtendereco.Text = item.SubItems[3].Text;
                txtbairro.Text = item.SubItems[4].Text;
                txtcidade.Text = item.SubItems[5].Text;
                txtuf.Text = item.SubItems[6].Text;
                txtsenha.Text = item.SubItems[7].Text;
                materialTabControl1.SelectedIndex = 0;
                txtmaricula.Focus();
            }
            else
            {
                MessageBox.Show("Selecione algum aluno", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tabPage1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Editar();
        }
        private void Deletar()
        {
            var file = File.ReadAllLines(alunosFilename).ToList();
            file.RemoveAt(indexselecionado);
            File.WriteAllLines(alunosFilename, file);
        }
        private void btnexcluir_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0)
            {
                if (MessageBox.Show("Deseja realmente deletar?", "IFSP", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    indexselecionado = listView1.SelectedItems[0].Index;
                    Deletar();
                    Carregalist();
                }
            }
            else
            {
                MessageBox.Show("Selecione algum aluno", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
                
        }
    }
}
