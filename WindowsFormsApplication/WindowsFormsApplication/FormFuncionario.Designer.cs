namespace WindowsFormsApplication
{
    partial class FormFuncionario
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nome_completoLabel;
            System.Windows.Forms.Label enderecoLabel;
            System.Windows.Forms.Label cidadeLabel;
            System.Windows.Forms.Label descricao_cargoLabel;
            System.Windows.Forms.Label salarioLabel;
            System.Windows.Forms.Label cepLabel;
            System.Windows.Forms.Label telefoneLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFuncionario));
            this.dataSetFuncionario = new WindowsFormsApplication.DataSetFuncionario();
            this.funcionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.funcionarioTableAdapter = new WindowsFormsApplication.DataSetFuncionarioTableAdapters.FuncionarioTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication.DataSetFuncionarioTableAdapters.TableAdapterManager();
            this.funcionarioBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.funcionarioBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.funcionarioBindingNavigatorRefreshItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.fotoTextBox = new System.Windows.Forms.TextBox();
            this.nome_completoTextBox = new System.Windows.Forms.TextBox();
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.cidadeTextBox = new System.Windows.Forms.TextBox();
            this.descricao_cargoTextBox = new System.Windows.Forms.TextBox();
            this.fotoPictureBox = new System.Windows.Forms.PictureBox();
            this.CarregarFotoButton = new System.Windows.Forms.Button();
            this.telefoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.CepMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.salarioTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            idLabel = new System.Windows.Forms.Label();
            nome_completoLabel = new System.Windows.Forms.Label();
            enderecoLabel = new System.Windows.Forms.Label();
            cidadeLabel = new System.Windows.Forms.Label();
            descricao_cargoLabel = new System.Windows.Forms.Label();
            salarioLabel = new System.Windows.Forms.Label();
            cepLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetFuncionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingNavigator)).BeginInit();
            this.funcionarioBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(15, 34);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(40, 13);
            idLabel.TabIndex = 1;
            idLabel.Text = "Código";
            // 
            // nome_completoLabel
            // 
            nome_completoLabel.AutoSize = true;
            nome_completoLabel.Location = new System.Drawing.Point(15, 74);
            nome_completoLabel.Name = "nome_completoLabel";
            nome_completoLabel.Size = new System.Drawing.Size(35, 13);
            nome_completoLabel.TabIndex = 5;
            nome_completoLabel.Text = "Nome";
            // 
            // enderecoLabel
            // 
            enderecoLabel.AutoSize = true;
            enderecoLabel.Location = new System.Drawing.Point(15, 194);
            enderecoLabel.Name = "enderecoLabel";
            enderecoLabel.Size = new System.Drawing.Size(53, 13);
            enderecoLabel.TabIndex = 7;
            enderecoLabel.Text = "Endereço";
            // 
            // cidadeLabel
            // 
            cidadeLabel.AutoSize = true;
            cidadeLabel.Location = new System.Drawing.Point(15, 234);
            cidadeLabel.Name = "cidadeLabel";
            cidadeLabel.Size = new System.Drawing.Size(40, 13);
            cidadeLabel.TabIndex = 9;
            cidadeLabel.Text = "Cidade";
            // 
            // descricao_cargoLabel
            // 
            descricao_cargoLabel.AutoSize = true;
            descricao_cargoLabel.Location = new System.Drawing.Point(15, 314);
            descricao_cargoLabel.Name = "descricao_cargoLabel";
            descricao_cargoLabel.Size = new System.Drawing.Size(101, 13);
            descricao_cargoLabel.TabIndex = 11;
            descricao_cargoLabel.Text = "Descrição do Cargo";
            // 
            // salarioLabel
            // 
            salarioLabel.AutoSize = true;
            salarioLabel.Location = new System.Drawing.Point(15, 274);
            salarioLabel.Name = "salarioLabel";
            salarioLabel.Size = new System.Drawing.Size(39, 13);
            salarioLabel.TabIndex = 13;
            salarioLabel.Text = "Salário";
            // 
            // cepLabel
            // 
            cepLabel.AutoSize = true;
            cepLabel.Location = new System.Drawing.Point(15, 154);
            cepLabel.Name = "cepLabel";
            cepLabel.Size = new System.Drawing.Size(28, 13);
            cepLabel.TabIndex = 15;
            cepLabel.Text = "CEP";
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Location = new System.Drawing.Point(15, 114);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(49, 13);
            telefoneLabel.TabIndex = 17;
            telefoneLabel.Text = "Telefone";
            // 
            // dataSetFuncionario
            // 
            this.dataSetFuncionario.DataSetName = "DataSetFuncionario";
            this.dataSetFuncionario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // funcionarioBindingSource
            // 
            this.funcionarioBindingSource.DataMember = "Funcionario";
            this.funcionarioBindingSource.DataSource = this.dataSetFuncionario;
            this.funcionarioBindingSource.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.funcionarioBindingSource_AddingNew);
            // 
            // funcionarioTableAdapter
            // 
            this.funcionarioTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FuncionarioTableAdapter = this.funcionarioTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication.DataSetFuncionarioTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // funcionarioBindingNavigator
            // 
            this.funcionarioBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.funcionarioBindingNavigator.BindingSource = this.funcionarioBindingSource;
            this.funcionarioBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.funcionarioBindingNavigator.DeleteItem = null;
            this.funcionarioBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.funcionarioBindingNavigatorSaveItem,
            this.toolStripSeparator1,
            this.funcionarioBindingNavigatorRefreshItem});
            this.funcionarioBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.funcionarioBindingNavigator.MoveFirstItem = null;
            this.funcionarioBindingNavigator.MoveLastItem = null;
            this.funcionarioBindingNavigator.MoveNextItem = null;
            this.funcionarioBindingNavigator.MovePreviousItem = null;
            this.funcionarioBindingNavigator.Name = "funcionarioBindingNavigator";
            this.funcionarioBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.funcionarioBindingNavigator.Size = new System.Drawing.Size(955, 25);
            this.funcionarioBindingNavigator.TabIndex = 0;
            this.funcionarioBindingNavigator.Text = "bindingNavigator";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.ToolTipText = "Novo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total de items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Primeirio";
            this.bindingNavigatorMoveFirstItem.Click += new System.EventHandler(this.bindingNavigatorMoveFirstItem_Click);
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Anterior";
            this.bindingNavigatorMovePreviousItem.Click += new System.EventHandler(this.bindingNavigatorMovePreviousItem_Click);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Próximo";
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Último";
            this.bindingNavigatorMoveLastItem.Click += new System.EventHandler(this.bindingNavigatorMoveLastItem_Click);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.ToolTipText = "Apagar";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // funcionarioBindingNavigatorSaveItem
            // 
            this.funcionarioBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.funcionarioBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("funcionarioBindingNavigatorSaveItem.Image")));
            this.funcionarioBindingNavigatorSaveItem.Name = "funcionarioBindingNavigatorSaveItem";
            this.funcionarioBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.funcionarioBindingNavigatorSaveItem.Text = "Save Data";
            this.funcionarioBindingNavigatorSaveItem.ToolTipText = "Salvar";
            this.funcionarioBindingNavigatorSaveItem.Click += new System.EventHandler(this.funcionarioBindingNavigatorSaveItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // funcionarioBindingNavigatorRefreshItem
            // 
            this.funcionarioBindingNavigatorRefreshItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.funcionarioBindingNavigatorRefreshItem.Image = ((System.Drawing.Image)(resources.GetObject("funcionarioBindingNavigatorRefreshItem.Image")));
            this.funcionarioBindingNavigatorRefreshItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.funcionarioBindingNavigatorRefreshItem.Name = "funcionarioBindingNavigatorRefreshItem";
            this.funcionarioBindingNavigatorRefreshItem.Size = new System.Drawing.Size(23, 22);
            this.funcionarioBindingNavigatorRefreshItem.Text = "toolStripButton";
            this.funcionarioBindingNavigatorRefreshItem.ToolTipText = "Atualizar dados";
            this.funcionarioBindingNavigatorRefreshItem.Click += new System.EventHandler(this.funcionarioBindingNavigatorRefreshItem_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(15, 50);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // fotoTextBox
            // 
            this.fotoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "foto", true));
            this.fotoTextBox.Location = new System.Drawing.Point(541, 398);
            this.fotoTextBox.Name = "fotoTextBox";
            this.fotoTextBox.ReadOnly = true;
            this.fotoTextBox.Size = new System.Drawing.Size(343, 20);
            this.fotoTextBox.TabIndex = 7;
            this.fotoTextBox.TabStop = false;
            this.fotoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fotoTextBox.TextChanged += new System.EventHandler(this.fotoTextBox_TextChanged);
            // 
            // nome_completoTextBox
            // 
            this.nome_completoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "nome_completo", true));
            this.nome_completoTextBox.Location = new System.Drawing.Point(15, 90);
            this.nome_completoTextBox.MaxLength = 60;
            this.nome_completoTextBox.Name = "nome_completoTextBox";
            this.nome_completoTextBox.Size = new System.Drawing.Size(508, 20);
            this.nome_completoTextBox.TabIndex = 0;
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "endereco", true));
            this.enderecoTextBox.Location = new System.Drawing.Point(15, 210);
            this.enderecoTextBox.MaxLength = 60;
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Size = new System.Drawing.Size(508, 20);
            this.enderecoTextBox.TabIndex = 3;
            // 
            // cidadeTextBox
            // 
            this.cidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "cidade", true));
            this.cidadeTextBox.Location = new System.Drawing.Point(15, 250);
            this.cidadeTextBox.MaxLength = 60;
            this.cidadeTextBox.Name = "cidadeTextBox";
            this.cidadeTextBox.Size = new System.Drawing.Size(508, 20);
            this.cidadeTextBox.TabIndex = 4;
            // 
            // descricao_cargoTextBox
            // 
            this.descricao_cargoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "descricao_cargo", true));
            this.descricao_cargoTextBox.Location = new System.Drawing.Point(15, 330);
            this.descricao_cargoTextBox.MaxLength = 1000;
            this.descricao_cargoTextBox.Multiline = true;
            this.descricao_cargoTextBox.Name = "descricao_cargoTextBox";
            this.descricao_cargoTextBox.Size = new System.Drawing.Size(508, 88);
            this.descricao_cargoTextBox.TabIndex = 6;
            // 
            // fotoPictureBox
            // 
            this.fotoPictureBox.Location = new System.Drawing.Point(541, 50);
            this.fotoPictureBox.Name = "fotoPictureBox";
            this.fotoPictureBox.Size = new System.Drawing.Size(402, 342);
            this.fotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoPictureBox.TabIndex = 18;
            this.fotoPictureBox.TabStop = false;
            // 
            // CarregarFotoButton
            // 
            this.CarregarFotoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarregarFotoButton.Location = new System.Drawing.Point(888, 397);
            this.CarregarFotoButton.Name = "CarregarFotoButton";
            this.CarregarFotoButton.Size = new System.Drawing.Size(27, 22);
            this.CarregarFotoButton.TabIndex = 19;
            this.CarregarFotoButton.Text = "...";
            this.CarregarFotoButton.UseVisualStyleBackColor = true;
            this.CarregarFotoButton.Click += new System.EventHandler(this.CarregarFotoButton_Click);
            // 
            // telefoneMaskedTextBox
            // 
            this.telefoneMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "telefone", true));
            this.telefoneMaskedTextBox.Location = new System.Drawing.Point(15, 130);
            this.telefoneMaskedTextBox.Mask = "99 9000 0000";
            this.telefoneMaskedTextBox.Name = "telefoneMaskedTextBox";
            this.telefoneMaskedTextBox.PromptChar = ' ';
            this.telefoneMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.telefoneMaskedTextBox.TabIndex = 1;
            // 
            // CepMaskedTextBox
            // 
            this.CepMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "cep", true));
            this.CepMaskedTextBox.Location = new System.Drawing.Point(15, 170);
            this.CepMaskedTextBox.Mask = "#####-###";
            this.CepMaskedTextBox.Name = "CepMaskedTextBox";
            this.CepMaskedTextBox.PromptChar = ' ';
            this.CepMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.CepMaskedTextBox.TabIndex = 2;
            // 
            // salarioTextBox
            // 
            this.salarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "salario", true));
            this.salarioTextBox.Location = new System.Drawing.Point(15, 290);
            this.salarioTextBox.MaxLength = 20;
            this.salarioTextBox.Name = "salarioTextBox";
            this.salarioTextBox.Size = new System.Drawing.Size(100, 20);
            this.salarioTextBox.TabIndex = 5;
            this.salarioTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.salarioTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.salarioTextBox_KeyPress);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(917, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 22);
            this.button1.TabIndex = 20;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 435);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.salarioTextBox);
            this.Controls.Add(this.CepMaskedTextBox);
            this.Controls.Add(this.telefoneMaskedTextBox);
            this.Controls.Add(this.CarregarFotoButton);
            this.Controls.Add(this.fotoPictureBox);
            this.Controls.Add(telefoneLabel);
            this.Controls.Add(cepLabel);
            this.Controls.Add(salarioLabel);
            this.Controls.Add(descricao_cargoLabel);
            this.Controls.Add(this.descricao_cargoTextBox);
            this.Controls.Add(cidadeLabel);
            this.Controls.Add(this.cidadeTextBox);
            this.Controls.Add(enderecoLabel);
            this.Controls.Add(this.enderecoTextBox);
            this.Controls.Add(nome_completoLabel);
            this.Controls.Add(this.nome_completoTextBox);
            this.Controls.Add(this.fotoTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.funcionarioBindingNavigator);
            this.Name = "FormFuncionario";
            this.Text = "Cadastro de Funcionário";
            this.Load += new System.EventHandler(this.FormFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetFuncionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingNavigator)).EndInit();
            this.funcionarioBindingNavigator.ResumeLayout(false);
            this.funcionarioBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSetFuncionario dataSetFuncionario;
        private System.Windows.Forms.BindingSource funcionarioBindingSource;
        private DataSetFuncionarioTableAdapters.FuncionarioTableAdapter funcionarioTableAdapter;
        private DataSetFuncionarioTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator funcionarioBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton funcionarioBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox fotoTextBox;
        private System.Windows.Forms.TextBox nome_completoTextBox;
        private System.Windows.Forms.TextBox enderecoTextBox;
        private System.Windows.Forms.TextBox cidadeTextBox;
        private System.Windows.Forms.TextBox descricao_cargoTextBox;
        private System.Windows.Forms.PictureBox fotoPictureBox;
        private System.Windows.Forms.Button CarregarFotoButton;
        private System.Windows.Forms.MaskedTextBox telefoneMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox CepMaskedTextBox;
        private System.Windows.Forms.TextBox salarioTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton funcionarioBindingNavigatorRefreshItem;
    }
}