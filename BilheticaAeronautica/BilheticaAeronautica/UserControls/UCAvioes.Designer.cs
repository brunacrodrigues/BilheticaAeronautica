namespace BilheticaAeronautica.UserControls
{
    partial class UCAvioes
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
            txtCapacidade = new Syncfusion.Windows.Forms.Grid.GridAwareTextBox();
            groupBox1 = new GroupBox();
            label6 = new Label();
            label7 = new Label();
            numericUpDownLugaresEconomicos = new NumericUpDown();
            numericUpDownLugaresExecutivos = new NumericUpDown();
            btnOk = new Button();
            label1 = new Label();
            btnRegistar = new Button();
            txtModelo = new Syncfusion.Windows.Forms.Grid.GridAwareTextBox();
            lblId = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            btnApagar = new Button();
            btnEditar = new Button();
            gridViewModelos = new DataGridView();
            button5 = new Button();
            button1 = new Button();
            button3 = new Button();
            label2 = new Label();
            panel1 = new Panel();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownLugaresEconomicos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownLugaresExecutivos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridViewModelos).BeginInit();
            SuspendLayout();
            // 
            // txtCapacidade
            // 
            txtCapacidade.AutoSuggestFormula = false;
            txtCapacidade.DisabledBackColor = SystemColors.Window;
            txtCapacidade.Enabled = false;
            txtCapacidade.EnabledBackColor = SystemColors.Window;
            txtCapacidade.Font = new Font("Gadugi", 12F);
            txtCapacidade.Location = new Point(243, 284);
            txtCapacidade.Name = "txtCapacidade";
            txtCapacidade.ReadOnly = true;
            txtCapacidade.Size = new Size(133, 34);
            txtCapacidade.TabIndex = 21;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(numericUpDownLugaresEconomicos);
            groupBox1.Controls.Add(numericUpDownLugaresExecutivos);
            groupBox1.Controls.Add(btnOk);
            groupBox1.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(83, 4, 17);
            groupBox1.Location = new Point(933, 98);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(413, 210);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Configurar Capacidade";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(83, 4, 17);
            label6.Font = new Font("Gadugi", 12F, FontStyle.Bold);
            label6.ForeColor = Color.Cornsilk;
            label6.Location = new Point(26, 158);
            label6.Name = "label6";
            label6.Size = new Size(113, 24);
            label6.TabIndex = 33;
            label6.Text = "Económico";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(83, 4, 17);
            label7.Font = new Font("Gadugi", 12F, FontStyle.Bold);
            label7.ForeColor = Color.Cornsilk;
            label7.Location = new Point(26, 79);
            label7.Name = "label7";
            label7.Size = new Size(102, 24);
            label7.TabIndex = 32;
            label7.Text = "Executivo";
            // 
            // numericUpDownLugaresEconomicos
            // 
            numericUpDownLugaresEconomicos.Font = new Font("Gadugi", 12F);
            numericUpDownLugaresEconomicos.Location = new Point(181, 148);
            numericUpDownLugaresEconomicos.Maximum = new decimal(new int[] { 600, 0, 0, 0 });
            numericUpDownLugaresEconomicos.Minimum = new decimal(new int[] { 50, 0, 0, 0 });
            numericUpDownLugaresEconomicos.Name = "numericUpDownLugaresEconomicos";
            numericUpDownLugaresEconomicos.Size = new Size(82, 34);
            numericUpDownLugaresEconomicos.TabIndex = 31;
            numericUpDownLugaresEconomicos.Value = new decimal(new int[] { 50, 0, 0, 0 });
            // 
            // numericUpDownLugaresExecutivos
            // 
            numericUpDownLugaresExecutivos.Font = new Font("Gadugi", 12F);
            numericUpDownLugaresExecutivos.Location = new Point(181, 69);
            numericUpDownLugaresExecutivos.Minimum = new decimal(new int[] { 20, 0, 0, 0 });
            numericUpDownLugaresExecutivos.Name = "numericUpDownLugaresExecutivos";
            numericUpDownLugaresExecutivos.Size = new Size(82, 34);
            numericUpDownLugaresExecutivos.TabIndex = 30;
            numericUpDownLugaresExecutivos.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // btnOk
            // 
            btnOk.BackColor = Color.FromArgb(83, 4, 17);
            btnOk.FlatAppearance.BorderSize = 0;
            btnOk.FlatStyle = FlatStyle.Flat;
            btnOk.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOk.ForeColor = Color.White;
            btnOk.Location = new Point(325, 136);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(65, 46);
            btnOk.TabIndex = 29;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = false;
            btnOk.Click += btnOk_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gadugi", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(83, 4, 17);
            label1.Location = new Point(99, 29);
            label1.Name = "label1";
            label1.Size = new Size(429, 40);
            label1.TabIndex = 19;
            label1.Text = "Registar Modelo de Avião";
            // 
            // btnRegistar
            // 
            btnRegistar.BackColor = Color.FromArgb(236, 175, 74);
            btnRegistar.FlatAppearance.BorderSize = 0;
            btnRegistar.FlatStyle = FlatStyle.Flat;
            btnRegistar.Font = new Font("Gadugi", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistar.ForeColor = Color.FromArgb(83, 4, 17);
            btnRegistar.Image = Properties.Resources.icons8_confirm_40;
            btnRegistar.Location = new Point(933, 332);
            btnRegistar.Name = "btnRegistar";
            btnRegistar.Size = new Size(413, 57);
            btnRegistar.TabIndex = 18;
            btnRegistar.Text = "        Registar Modelo";
            btnRegistar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRegistar.UseVisualStyleBackColor = false;
            btnRegistar.Click += btnRegistar_Click;
            // 
            // txtModelo
            // 
            txtModelo.AutoSuggestFormula = false;
            txtModelo.DisabledBackColor = SystemColors.Window;
            txtModelo.EnabledBackColor = SystemColors.Window;
            txtModelo.Font = new Font("Gadugi", 12F);
            txtModelo.Location = new Point(243, 192);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(533, 34);
            txtModelo.TabIndex = 16;
            // 
            // lblId
            // 
            lblId.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblId.ForeColor = Color.FromArgb(83, 4, 17);
            lblId.Location = new Point(243, 114);
            lblId.Name = "lblId";
            lblId.Size = new Size(85, 24);
            lblId.TabIndex = 14;
            lblId.Text = "<none>";
            // 
            // btnApagar
            // 
            btnApagar.BackColor = Color.Firebrick;
            btnApagar.FlatAppearance.BorderSize = 0;
            btnApagar.FlatStyle = FlatStyle.Flat;
            btnApagar.Font = new Font("Gadugi", 12F, FontStyle.Bold);
            btnApagar.ForeColor = Color.White;
            btnApagar.Image = Properties.Resources.icons8_cancel_30;
            btnApagar.Location = new Point(1352, 920);
            btnApagar.Name = "btnApagar";
            btnApagar.Size = new Size(206, 63);
            btnApagar.TabIndex = 33;
            btnApagar.Text = "  Apagar Modelo";
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
            btnEditar.Location = new Point(1352, 851);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(206, 63);
            btnEditar.TabIndex = 32;
            btnEditar.Text = "  Editar Modelo";
            btnEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // gridViewModelos
            // 
            gridViewModelos.AllowUserToAddRows = false;
            gridViewModelos.AllowUserToDeleteRows = false;
            gridViewModelos.AllowUserToResizeColumns = false;
            gridViewModelos.AllowUserToResizeRows = false;
            gridViewModelos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gridViewModelos.BackgroundColor = Color.White;
            gridViewModelos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridViewModelos.Location = new Point(99, 568);
            gridViewModelos.Name = "gridViewModelos";
            gridViewModelos.ReadOnly = true;
            gridViewModelos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            gridViewModelos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridViewModelos.Size = new Size(1247, 415);
            gridViewModelos.TabIndex = 31;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(83, 14, 17);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.Cornsilk;
            button5.Location = new Point(99, 183);
            button5.Name = "button5";
            button5.Size = new Size(129, 49);
            button5.TabIndex = 91;
            button5.Text = "Modelo";
            button5.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(83, 14, 17);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Cornsilk;
            button1.Location = new Point(99, 114);
            button1.Name = "button1";
            button1.Size = new Size(129, 32);
            button1.TabIndex = 92;
            button1.Text = "ID";
            button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(83, 14, 17);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Cornsilk;
            button3.Location = new Point(99, 275);
            button3.Name = "button3";
            button3.Size = new Size(129, 49);
            button3.TabIndex = 93;
            button3.Text = "Capacidade";
            button3.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gadugi", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(83, 4, 17);
            label2.Location = new Point(99, 511);
            label2.Name = "label2";
            label2.Size = new Size(339, 40);
            label2.TabIndex = 94;
            label2.Text = "Modelos Registados";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(83, 4, 17);
            panel1.Location = new Point(0, 448);
            panel1.Name = "panel1";
            panel1.Size = new Size(1646, 23);
            panel1.TabIndex = 109;
            // 
            // UCAvioes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(button5);
            Controls.Add(btnApagar);
            Controls.Add(btnEditar);
            Controls.Add(gridViewModelos);
            Controls.Add(txtCapacidade);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(btnRegistar);
            Controls.Add(txtModelo);
            Controls.Add(lblId);
            Name = "UCAvioes";
            Size = new Size(1643, 1026);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownLugaresEconomicos).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownLugaresExecutivos).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridViewModelos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Syncfusion.Windows.Forms.Grid.GridAwareTextBox txtCapacidade;
        private GroupBox groupBox1;
        private NumericUpDown numericUpDownLugaresEconomicos;
        private NumericUpDown numericUpDownLugaresExecutivos;
        private Button btnOk;
        private Label label1;
        private Button btnRegistar;
        private Syncfusion.Windows.Forms.Grid.GridAwareTextBox txtModelo;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblId;
        private Button btnApagar;
        private Button btnEditar;
        private DataGridView gridViewModelos;
        private Button button5;
        private Button button1;
        private Button button3;
        private Label label7;
        private Label label6;
        private Label label2;
        private Panel panel1;
    }
}
