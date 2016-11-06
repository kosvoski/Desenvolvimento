using System;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication
{
    public partial class FormFuncionario : Form
    {   
        public FormFuncionario()
        {
            InitializeComponent();
        }

        private void funcionarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            string caminhoDaFoto = @"../../../../WebApplication/WebApplication" + fotoTextBox.Text;
            if (fotoPictureBox.Image == null)
            {
                fotoTextBox.Text = "";
            }

            this.Validate();
            this.funcionarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetFuncionario);

            if (fotoTextBox.Text != "")
            {
                fotoPictureBox.Image.Save(caminhoDaFoto);
            }
            else
            {
                caminhoDaFoto = @"../../../../WebApplication/WebApplication/Content/Uploads/";
                string[] fotoList = Directory.GetFiles(caminhoDaFoto, idTextBox.Text + ".*");
                foreach (string foto in fotoList)
                {
                    File.Delete(foto);
                }
            }             

            MessageBox.Show("Dados Salvos");
        }

        private void FormFuncionario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetFuncionario.Funcionario' table. You can move, or remove it, as needed.
            this.funcionarioTableAdapter.Fill(this.dataSetFuncionario.Funcionario);

        }

        private void funcionarioBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            DataView dataTableView = funcionarioBindingSource.List as DataView;

            DataRowView rowView = dataTableView.AddNew();

            rowView["id"] = 0;

            e.NewObject = rowView;

            funcionarioBindingSource.MoveLast();
        }
                
        private void fotoTextBox_TextChanged(object sender, EventArgs e)
        {
            string caminhoDaFoto = @"../../../../WebApplication/WebApplication" + fotoTextBox.Text;
            if (File.Exists(caminhoDaFoto))
            {
                fotoPictureBox.ImageLocation = caminhoDaFoto;
            }
            else
            {
                fotoPictureBox.Image = null; // ImageLocation = "";
            }
        }

        private void CarregarFotoButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Image Files(*.BMP; *.JPG; *.GIF; *.PNG)| *.BMP; *.JPG; *.GIF; *.PNG";

            if (file.ShowDialog() == DialogResult.OK)
            {
                //string caminhoDaFoto = @"../../../../WebApplication/WebApplication/Content/Uploads/" idTextBox.Text + Path.GetExtension(file.FileName);
                fotoTextBox.Text = "/Content/Uploads/" + idTextBox.Text + Path.GetExtension(file.FileName);
                fotoPictureBox.ImageLocation = file.FileName;
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja apagar o registro?", "Atenção", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string caminhoDaFoto = @"../../../../WebApplication/WebApplication" + fotoTextBox.Text;

                funcionarioBindingSource.RemoveCurrent();
                funcionarioBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(dataSetFuncionario);
                
                if (File.Exists(caminhoDaFoto))
                {
                    File.Delete(caminhoDaFoto);
                }

            }            
        }

        private void RefreshFuncionario()
        {
            funcionarioBindingSource.CancelEdit();
            funcionarioTableAdapter.Fill(dataSetFuncionario.Funcionario);
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            funcionarioBindingSource.CancelEdit();
            funcionarioBindingSource.MoveFirst();
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            funcionarioBindingSource.CancelEdit();
            funcionarioBindingSource.MovePrevious();
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            funcionarioBindingSource.CancelEdit();
            funcionarioBindingSource.MoveNext();
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            funcionarioBindingSource.CancelEdit();
            funcionarioBindingSource.MoveLast();
        }

        private void salarioTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',')
                {
                    e.Handled = (txt.Text.Contains(","));
                }
                else
                    e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fotoPictureBox.Image != null)
            {
                if (MessageBox.Show("Deseja remover a imagem?", "Atenção", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    fotoTextBox.Text = "";
                }
            }
            
        }

        private void funcionarioBindingNavigatorRefreshItem_Click(object sender, EventArgs e)
        {
            RefreshFuncionario();
        }
    }
}
