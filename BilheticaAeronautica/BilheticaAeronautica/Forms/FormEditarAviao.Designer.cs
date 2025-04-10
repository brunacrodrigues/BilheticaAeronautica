namespace BilheticaAeronautica
{
    partial class FormEditarAviao
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
            label1 = new Label();
            btnGuardar = new Button();
            checkBoxEstado = new CheckBox();
            btnOk = new Button();
            button5 = new Button();
            txtCapacidade = new Syncfusion.Windows.Forms.Grid.GridAwareTextBox();
            groupBoxLugares = new GroupBox();
            label6 = new Label();
            label7 = new Label();
            numericUpDownLugaresEconomicos = new NumericUpDown();
            numericUpDownLugaresExecutivos = new NumericUpDown();
            txtModelo = new Syncfusion.Windows.Forms.Grid.GridAwareTextBox();
            lblId = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            button1 = new Button();
            button3 = new Button();
            panel3 = new Panel();
            panel2 = new Panel();
            btnFechar = new Button();
            dragControl1 = new DragControl();
            panel1 = new Panel();
            dragControl2 = new DragControl();
            panel4 = new Panel();
            groupBoxLugares.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownLugaresEconomicos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownLugaresExecutivos).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gadugi", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(83, 4, 17);
            label1.Location = new Point(91, 102);
            label1.Name = "label1";
            label1.Size = new Size(392, 40);
            label1.TabIndex = 19;
            label1.Text = "Editar Modelo de Avião";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(236, 175, 74);
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Gadugi", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.FromArgb(83, 4, 17);
            btnGuardar.Image = Properties.Resources.icons8_confirm_40;
            btnGuardar.Location = new Point(847, 460);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(413, 57);
            btnGuardar.TabIndex = 18;
            btnGuardar.Text = "        Guardar";
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // checkBoxEstado
            // 
            checkBoxEstado.AutoSize = true;
            checkBoxEstado.ForeColor = Color.FromArgb(83, 4, 13);
            checkBoxEstado.Location = new Point(1150, 129);
            checkBoxEstado.Name = "checkBoxEstado";
            checkBoxEstado.Size = new Size(85, 31);
            checkBoxEstado.TabIndex = 22;
            checkBoxEstado.Text = "none";
            checkBoxEstado.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            btnOk.BackColor = Color.FromArgb(83, 4, 17);
            btnOk.FlatAppearance.BorderSize = 0;
            btnOk.FlatStyle = FlatStyle.Flat;
            btnOk.ForeColor = Color.White;
            btnOk.Location = new Point(323, 137);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(65, 46);
            btnOk.TabIndex = 29;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = false;
            btnOk.Click += btnOk_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(83, 14, 17);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.Cornsilk;
            button5.Location = new Point(100, 256);
            button5.Name = "button5";
            button5.Size = new Size(129, 49);
            button5.TabIndex = 99;
            button5.Text = "Modelo";
            button5.UseVisualStyleBackColor = false;
            // 
            // txtCapacidade
            // 
            txtCapacidade.AutoSuggestFormula = false;
            txtCapacidade.DisabledBackColor = SystemColors.Window;
            txtCapacidade.Enabled = false;
            txtCapacidade.EnabledBackColor = SystemColors.Window;
            txtCapacidade.Font = new Font("Gadugi", 12F);
            txtCapacidade.Location = new Point(244, 357);
            txtCapacidade.Name = "txtCapacidade";
            txtCapacidade.ReadOnly = true;
            txtCapacidade.Size = new Size(133, 34);
            txtCapacidade.TabIndex = 98;
            // 
            // groupBoxLugares
            // 
            groupBoxLugares.Controls.Add(label6);
            groupBoxLugares.Controls.Add(label7);
            groupBoxLugares.Controls.Add(btnOk);
            groupBoxLugares.Controls.Add(numericUpDownLugaresEconomicos);
            groupBoxLugares.Controls.Add(numericUpDownLugaresExecutivos);
            groupBoxLugares.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxLugares.ForeColor = Color.FromArgb(83, 4, 17);
            groupBoxLugares.Location = new Point(847, 187);
            groupBoxLugares.Name = "groupBoxLugares";
            groupBoxLugares.Size = new Size(413, 210);
            groupBoxLugares.TabIndex = 97;
            groupBoxLugares.TabStop = false;
            groupBoxLugares.Text = "Configurar Capacidade";
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
            // txtModelo
            // 
            txtModelo.AutoSuggestFormula = false;
            txtModelo.DisabledBackColor = SystemColors.Window;
            txtModelo.EnabledBackColor = SystemColors.Window;
            txtModelo.Font = new Font("Gadugi", 12F);
            txtModelo.Location = new Point(244, 265);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(508, 34);
            txtModelo.TabIndex = 95;
            // 
            // lblId
            // 
            lblId.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblId.ForeColor = Color.FromArgb(83, 4, 17);
            lblId.Location = new Point(244, 187);
            lblId.Name = "lblId";
            lblId.Size = new Size(85, 24);
            lblId.TabIndex = 94;
            lblId.Text = "<none>";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(83, 14, 17);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Cornsilk;
            button1.Location = new Point(100, 187);
            button1.Name = "button1";
            button1.Size = new Size(129, 32);
            button1.TabIndex = 100;
            button1.Text = "Id";
            button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(83, 14, 17);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Cornsilk;
            button3.Location = new Point(100, 348);
            button3.Name = "button3";
            button3.Size = new Size(129, 49);
            button3.TabIndex = 101;
            button3.Text = "Capacidade";
            button3.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(83, 4, 17);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(5, 575);
            panel3.TabIndex = 205;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(83, 4, 17);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 575);
            panel2.Name = "panel2";
            panel2.Size = new Size(1340, 5);
            panel2.TabIndex = 207;
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.Firebrick;
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Image = Properties.Resources.icons8_close_50;
            btnFechar.Location = new Point(1254, -1);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(81, 57);
            btnFechar.TabIndex = 97;
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // dragControl1
            // 
            dragControl1.SelectedControl = panel1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(83, 4, 17);
            panel1.Controls.Add(btnFechar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(5, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1335, 56);
            panel1.TabIndex = 206;
            // 
            // dragControl2
            // 
            dragControl2.SelectedControl = this;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(83, 4, 17);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(1335, 56);
            panel4.Name = "panel4";
            panel4.Size = new Size(5, 519);
            panel4.TabIndex = 208;
            // 
            // FormEditarAviao
            // 
            AutoScaleDimensions = new SizeF(13F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1340, 580);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(button5);
            Controls.Add(txtCapacidade);
            Controls.Add(groupBoxLugares);
            Controls.Add(txtModelo);
            Controls.Add(lblId);
            Controls.Add(checkBoxEstado);
            Controls.Add(label1);
            Controls.Add(btnGuardar);
            Font = new Font("Gadugi", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 4, 5, 4);
            Name = "FormEditarAviao";
            Text = "EditarAviao";
            groupBoxLugares.ResumeLayout(false);
            groupBoxLugares.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownLugaresEconomicos).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownLugaresExecutivos).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnGuardar;
        private CheckBox checkBoxEstado;
        private Button btnOk;
        private Button button5;
        private Syncfusion.Windows.Forms.Grid.GridAwareTextBox txtCapacidade;
        private GroupBox groupBoxLugares;
        private Label label6;
        private Label label7;
        private NumericUpDown numericUpDownLugaresEconomicos;
        private NumericUpDown numericUpDownLugaresExecutivos;
        private Syncfusion.Windows.Forms.Grid.GridAwareTextBox txtModelo;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblId;
        private Button button1;
        private Button button3;
        private Panel panel3;
        private Panel panel2;
        private Button btnFechar;
        private DragControl dragControl1;
        private DragControl dragControl2;
        private Panel panel1;
        private Panel panel4;
    }
}