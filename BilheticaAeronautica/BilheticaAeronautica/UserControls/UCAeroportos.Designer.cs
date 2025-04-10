namespace BilheticaAeronautica.UserControls
{
    partial class UCAeroportos
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
            gridViewAeroportos = new DataGridView();
            btnApagar = new Button();
            btnEditar = new Button();
            txtPais = new Syncfusion.Windows.Forms.Grid.GridAwareTextBox();
            btnGuardar = new Button();
            txtCidade = new Syncfusion.Windows.Forms.Grid.GridAwareTextBox();
            label1 = new Label();
            txtNome = new Syncfusion.Windows.Forms.Grid.GridAwareTextBox();
            txtIATA = new Syncfusion.Windows.Forms.Grid.GridAwareTextBox();
            lblId = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            label2 = new Label();
            panel1 = new Panel();
            button3 = new Button();
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)gridViewAeroportos).BeginInit();
            SuspendLayout();
            // 
            // gridViewAeroportos
            // 
            gridViewAeroportos.AllowUserToAddRows = false;
            gridViewAeroportos.AllowUserToDeleteRows = false;
            gridViewAeroportos.AllowUserToResizeColumns = false;
            gridViewAeroportos.AllowUserToResizeRows = false;
            gridViewAeroportos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            gridViewAeroportos.BackgroundColor = Color.White;
            gridViewAeroportos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridViewAeroportos.Location = new Point(107, 529);
            gridViewAeroportos.MultiSelect = false;
            gridViewAeroportos.Name = "gridViewAeroportos";
            gridViewAeroportos.ReadOnly = true;
            gridViewAeroportos.RowHeadersVisible = false;
            gridViewAeroportos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            gridViewAeroportos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridViewAeroportos.Size = new Size(1246, 450);
            gridViewAeroportos.TabIndex = 61;
            // 
            // btnApagar
            // 
            btnApagar.BackColor = Color.Firebrick;
            btnApagar.FlatAppearance.BorderSize = 0;
            btnApagar.FlatStyle = FlatStyle.Flat;
            btnApagar.Font = new Font("Gadugi", 12F, FontStyle.Bold);
            btnApagar.ForeColor = Color.White;
            btnApagar.Image = Properties.Resources.icons8_cancel_30;
            btnApagar.Location = new Point(1359, 916);
            btnApagar.Name = "btnApagar";
            btnApagar.Size = new Size(207, 63);
            btnApagar.TabIndex = 60;
            btnApagar.Text = "  Apagar";
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
            btnEditar.Location = new Point(1360, 850);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(206, 60);
            btnEditar.TabIndex = 59;
            btnEditar.Text = "  Editar";
            btnEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // txtPais
            // 
            txtPais.AutoSuggestFormula = false;
            txtPais.DisabledBackColor = SystemColors.Window;
            txtPais.EnabledBackColor = SystemColors.Window;
            txtPais.Font = new Font("Gadugi", 12F);
            txtPais.Location = new Point(1048, 215);
            txtPais.Name = "txtPais";
            txtPais.Size = new Size(305, 34);
            txtPais.TabIndex = 58;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(236, 175, 74);
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Gadugi", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.FromArgb(83, 4, 17);
            btnGuardar.Image = Properties.Resources.icons8_confirm_40;
            btnGuardar.Location = new Point(902, 310);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(451, 57);
            btnGuardar.TabIndex = 56;
            btnGuardar.Text = "        Guardar Aeroporto";
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtCidade
            // 
            txtCidade.AutoSuggestFormula = false;
            txtCidade.DisabledBackColor = SystemColors.Window;
            txtCidade.EnabledBackColor = SystemColors.Window;
            txtCidade.Font = new Font("Gadugi", 12F);
            txtCidade.Location = new Point(1048, 134);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(305, 34);
            txtCidade.TabIndex = 55;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gadugi", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(83, 4, 17);
            label1.Location = new Point(107, 48);
            label1.Name = "label1";
            label1.Size = new Size(444, 40);
            label1.TabIndex = 53;
            label1.Text = "Adicionar Novo Aeroporto";
            // 
            // txtNome
            // 
            txtNome.AutoSuggestFormula = false;
            txtNome.DisabledBackColor = SystemColors.Window;
            txtNome.EnabledBackColor = SystemColors.Window;
            txtNome.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(257, 310);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(501, 34);
            txtNome.TabIndex = 52;
            // 
            // txtIATA
            // 
            txtIATA.AutoSuggestFormula = false;
            txtIATA.DisabledBackColor = SystemColors.Window;
            txtIATA.EnabledBackColor = SystemColors.Window;
            txtIATA.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIATA.Location = new Point(257, 215);
            txtIATA.Name = "txtIATA";
            txtIATA.Size = new Size(208, 34);
            txtIATA.TabIndex = 50;
            // 
            // lblId
            // 
            lblId.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblId.ForeColor = Color.FromArgb(83, 4, 17);
            lblId.Location = new Point(245, 137);
            lblId.Name = "lblId";
            lblId.Size = new Size(85, 24);
            lblId.TabIndex = 48;
            lblId.Text = "<none>";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gadugi", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(83, 4, 17);
            label2.Location = new Point(107, 473);
            label2.Name = "label2";
            label2.Size = new Size(382, 40);
            label2.TabIndex = 62;
            label2.Text = "Aeroportos Registados";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(83, 4, 17);
            panel1.Location = new Point(0, 418);
            panel1.Name = "panel1";
            panel1.Size = new Size(1646, 23);
            panel1.TabIndex = 109;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(83, 14, 17);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Cornsilk;
            button3.Location = new Point(110, 119);
            button3.Name = "button3";
            button3.Size = new Size(129, 49);
            button3.TabIndex = 186;
            button3.Text = "ID";
            button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(83, 14, 17);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Cornsilk;
            button1.Location = new Point(110, 206);
            button1.Name = "button1";
            button1.Size = new Size(129, 49);
            button1.TabIndex = 187;
            button1.Text = "IATA";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(83, 14, 17);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Cornsilk;
            button2.Location = new Point(110, 295);
            button2.Name = "button2";
            button2.Size = new Size(129, 49);
            button2.TabIndex = 188;
            button2.Text = "Nome";
            button2.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(83, 14, 17);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Cornsilk;
            button4.Location = new Point(902, 126);
            button4.Name = "button4";
            button4.Size = new Size(129, 49);
            button4.TabIndex = 189;
            button4.Text = "Cidade";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(83, 14, 17);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.Cornsilk;
            button5.Location = new Point(902, 206);
            button5.Name = "button5";
            button5.Size = new Size(129, 49);
            button5.TabIndex = 190;
            button5.Text = "País";
            button5.UseVisualStyleBackColor = false;
            // 
            // UCAeroportos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(gridViewAeroportos);
            Controls.Add(btnApagar);
            Controls.Add(btnEditar);
            Controls.Add(txtPais);
            Controls.Add(btnGuardar);
            Controls.Add(txtCidade);
            Controls.Add(label1);
            Controls.Add(txtNome);
            Controls.Add(txtIATA);
            Controls.Add(lblId);
            Name = "UCAeroportos";
            Size = new Size(1643, 1026);
            ((System.ComponentModel.ISupportInitialize)gridViewAeroportos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridViewAeroportos;
        private Button btnApagar;
        private Button btnEditar;
        private Syncfusion.Windows.Forms.Grid.GridAwareTextBox txtPais;
        private Button btnGuardar;
        private Syncfusion.Windows.Forms.Grid.GridAwareTextBox txtCidade;
        private Label label1;
        private Syncfusion.Windows.Forms.Grid.GridAwareTextBox txtNome;
        private Syncfusion.Windows.Forms.Grid.GridAwareTextBox txtIATA;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblId;
        private Label label2;
        private Panel panel1;
        private Button button3;
        private Button button1;
        private Button button2;
        private Button button4;
        private Button button5;
    }
}
