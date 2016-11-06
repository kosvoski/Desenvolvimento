using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Boolean formFechado = true;
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name.ToUpper() == "FORMFUNCIONARIO")
                {
                    form.BringToFront();
                    formFechado = false;
                    break;
                }
            }

            if (formFechado)
            {
                FormFuncionario formFuncionario = new FormFuncionario();
                formFuncionario.Show();
            }
            
        }
    }
}
