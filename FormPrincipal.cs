using ReaLTaiizor.Forms;

namespace pjt3
{
    public partial class FormPrincipal : MaterialForm
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cadastroDeAlunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAluno form = new FormAluno();
            form.MdiParent= this;
            form.Show();
        }
    }
}