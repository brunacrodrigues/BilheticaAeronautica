namespace BilheticaAeronautica.UserControls
{
    partial class UCClientes
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnApagar = new Button();
            btnEditar = new Button();
            txtTelefone = new Syncfusion.Windows.Forms.Grid.GridAwareTextBox();
            btnGuardar = new Button();
            txtEmail = new Syncfusion.Windows.Forms.Grid.GridAwareTextBox();
            label1 = new Label();
            txtPassaporte = new Syncfusion.Windows.Forms.Grid.GridAwareTextBox();
            txtNomeCompleto = new Syncfusion.Windows.Forms.Grid.GridAwareTextBox();
            lblId = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            label2 = new Label();
            panel1 = new Panel();
            gridViewClientes = new DataGridView();
            button4 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)gridViewClientes).BeginInit();
            SuspendLayout();
            // 
            // btnApagar
            // 
            btnApagar.BackColor = Color.Firebrick;
            btnApagar.FlatAppearance.BorderSize = 0;
            btnApagar.FlatStyle = FlatStyle.Flat;
            btnApagar.Font = new Font("Gadugi", 12F, FontStyle.Bold);
            btnApagar.ForeColor = Color.White;
            btnApagar.Image = Properties.Resources.icons8_cancel_30;
            btnApagar.Location = new Point(1356, 907);
            btnApagar.Name = "btnApagar";
            btnApagar.Size = new Size(206, 63);
            btnApagar.TabIndex = 59;
            btnApagar.Text = "  Apagar Cliente";
            btnApagar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnApagar.UseVisualStyleBackColor = false;
            btnApagar.Click += btnApagar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Black;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Gadugi", 12F, FontStyle.Bold);
            btnEditar.ForeColor = Color.White;
            btnEditar.Image = Properties.Resources.icons8_edit_30;
            btnEditar.Location = new Point(1356, 842);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(206, 60);
            btnEditar.TabIndex = 58;
            btnEditar.Text = "  Editar Cliente";
            btnEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // txtTelefone
            // 
            txtTelefone.AutoSuggestFormula = false;
            txtTelefone.DisabledBackColor = SystemColors.Window;
            txtTelefone.EnabledBackColor = SystemColors.Window;
            txtTelefone.Font = new Font("Gadugi", 12F);
            txtTelefone.Location = new Point(1061, 287);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(499, 34);
            txtTelefone.TabIndex = 57;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(236, 175, 74);
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Gadugi", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.FromArgb(83, 4, 17);
            btnGuardar.Image = Properties.Resources.icons8_confirm_40;
            btnGuardar.Location = new Point(1111, 357);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(401, 57);
            btnGuardar.TabIndex = 55;
            btnGuardar.Text = "        Registar Cliente";
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtEmail
            // 
            txtEmail.AutoSuggestFormula = false;
            txtEmail.DisabledBackColor = SystemColors.Window;
            txtEmail.EnabledBackColor = SystemColors.Window;
            txtEmail.Font = new Font("Gadugi", 12F);
            txtEmail.Location = new Point(1061, 198);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(499, 34);
            txtEmail.TabIndex = 54;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gadugi", 19.8000011F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(83, 4, 17);
            label1.Location = new Point(104, 27);
            label1.Name = "label1";
            label1.Size = new Size(268, 40);
            label1.TabIndex = 52;
            label1.Text = "Registar Cliente";
            // 
            // txtPassaporte
            // 
            txtPassaporte.AutoSuggestFormula = false;
            txtPassaporte.DisabledBackColor = SystemColors.Window;
            txtPassaporte.EnabledBackColor = SystemColors.Window;
            txtPassaporte.Font = new Font("Gadugi", 12F);
            txtPassaporte.Location = new Point(249, 287);
            txtPassaporte.Name = "txtPassaporte";
            txtPassaporte.Size = new Size(519, 34);
            txtPassaporte.TabIndex = 51;
            // 
            // txtNomeCompleto
            // 
            txtNomeCompleto.AutoSuggestFormula = false;
            txtNomeCompleto.DisabledBackColor = SystemColors.Window;
            txtNomeCompleto.EnabledBackColor = SystemColors.Window;
            txtNomeCompleto.Font = new Font("Gadugi", 12F);
            txtNomeCompleto.Location = new Point(249, 202);
            txtNomeCompleto.Name = "txtNomeCompleto";
            txtNomeCompleto.Size = new Size(519, 34);
            txtNomeCompleto.TabIndex = 49;
            // 
            // lblId
            // 
            lblId.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblId.ForeColor = Color.FromArgb(83, 4, 17);
            lblId.Location = new Point(249, 121);
            lblId.Name = "lblId";
            lblId.Size = new Size(85, 24);
            lblId.TabIndex = 47;
            lblId.Text = "<none>";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gadugi", 19.8000011F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(83, 4, 17);
            label2.Location = new Point(104, 509);
            label2.Name = "label2";
            label2.Size = new Size(326, 40);
            label2.TabIndex = 61;
            label2.Text = "Clientes Registados";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(83, 4, 17);
            panel1.Location = new Point(0, 460);
            panel1.Name = "panel1";
            panel1.Size = new Size(1643, 23);
            panel1.TabIndex = 110;
            // 
            // gridViewClientes
            // 
            gridViewClientes.AllowUserToAddRows = false;
            gridViewClientes.AllowUserToDeleteRows = false;
            gridViewClientes.AllowUserToResizeColumns = false;
            gridViewClientes.AllowUserToResizeRows = false;
            gridViewClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gridViewClientes.BackgroundColor = Color.White;
            gridViewClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridViewClientes.GridColor = Color.White;
            gridViewClientes.Location = new Point(104, 576);
            gridViewClientes.Name = "gridViewClientes";
            gridViewClientes.ReadOnly = true;
            gridViewClientes.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            gridViewClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridViewClientes.Size = new Size(1246, 394);
            gridViewClientes.TabIndex = 111;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(83, 14, 17);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Cornsilk;
            button4.Location = new Point(916, 189);
            button4.Name = "button4";
            button4.Size = new Size(129, 49);
            button4.TabIndex = 112;
            button4.Text = "Email";
            button4.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(83, 14, 17);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Cornsilk;
            button1.Location = new Point(916, 278);
            button1.Name = "button1";
            button1.Size = new Size(129, 49);
            button1.TabIndex = 113;
            button1.Text = "Telefone";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(83, 14, 17);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Cornsilk;
            button2.Location = new Point(104, 278);
            button2.Name = "button2";
            button2.Size = new Size(129, 49);
            button2.TabIndex = 114;
            button2.Text = "Passaporte";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(83, 14, 17);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Cornsilk;
            button3.Location = new Point(104, 184);
            button3.Name = "button3";
            button3.Size = new Size(129, 66);
            button3.TabIndex = 115;
            button3.Text = "Nome Completo";
            button3.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(83, 14, 17);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.Cornsilk;
            button5.Location = new Point(104, 107);
            button5.Name = "button5";
            button5.Size = new Size(129, 49);
            button5.TabIndex = 116;
            button5.Text = "ID";
            button5.UseVisualStyleBackColor = false;
            // 
            // UCClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button4);
            Controls.Add(gridViewClientes);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(btnApagar);
            Controls.Add(btnEditar);
            Controls.Add(txtTelefone);
            Controls.Add(btnGuardar);
            Controls.Add(txtEmail);
            Controls.Add(label1);
            Controls.Add(txtPassaporte);
            Controls.Add(txtNomeCompleto);
            Controls.Add(lblId);
            Name = "UCClientes";
            Size = new Size(1643, 1026);
            ((System.ComponentModel.ISupportInitialize)gridViewClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnApagar;
        private Button btnEditar;
        private Syncfusion.Windows.Forms.Grid.GridAwareTextBox txtTelefone;
        private Button btnGuardar;
        private Syncfusion.Windows.Forms.Grid.GridAwareTextBox txtEmail;
        private Label label1;
        private Syncfusion.Windows.Forms.Grid.GridAwareTextBox txtPassaporte;
        private Syncfusion.Windows.Forms.Grid.GridAwareTextBox txtNomeCompleto;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblId;
        private Label label2;
        private Panel panel1;
        private DataGridView gridViewClientes;
        private Button button4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button5;
    }
}
