namespace BilheticaAeronautica.Forms
{
    partial class FormAdicionarBilhete
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
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            comboBoxVoos = new ComboBox();
            groupBox2 = new GroupBox();
            btnConfirmar = new Button();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(177, 74);
            numericUpDown1.Margin = new Padding(5, 4, 5, 4);
            numericUpDown1.Maximum = new decimal(new int[] { 4000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(118, 38);
            numericUpDown1.TabIndex = 0;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(177, 152);
            numericUpDown2.Margin = new Padding(5, 4, 5, 4);
            numericUpDown2.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(118, 38);
            numericUpDown2.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(numericUpDown2);
            groupBox1.Location = new Point(79, 288);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(330, 241);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Definir Preço";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gadugi", 13.8F, FontStyle.Bold);
            label1.Location = new Point(28, 76);
            label1.Name = "label1";
            label1.Size = new Size(116, 27);
            label1.TabIndex = 2;
            label1.Text = "Executivo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gadugi", 13.8F, FontStyle.Bold);
            label2.Location = new Point(28, 154);
            label2.Name = "label2";
            label2.Size = new Size(130, 27);
            label2.TabIndex = 3;
            label2.Text = "Económico";
            // 
            // comboBoxVoos
            // 
            comboBoxVoos.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxVoos.FormattingEnabled = true;
            comboBoxVoos.Location = new Point(16, 59);
            comboBoxVoos.Name = "comboBoxVoos";
            comboBoxVoos.Size = new Size(285, 35);
            comboBoxVoos.TabIndex = 4;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBoxVoos);
            groupBox2.Location = new Point(79, 102);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(330, 145);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Selecionar Voo";
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.DarkGoldenrod;
            btnConfirmar.FlatAppearance.BorderSize = 0;
            btnConfirmar.FlatStyle = FlatStyle.Flat;
            btnConfirmar.Location = new Point(522, 423);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(137, 55);
            btnConfirmar.TabIndex = 82;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(522, 102);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(519, 298);
            dataGridView1.TabIndex = 83;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(914, 423);
            button1.Name = "button1";
            button1.Size = new Size(127, 67);
            button1.TabIndex = 84;
            button1.Text = "Vender Bilhetes";
            button1.UseVisualStyleBackColor = false;
            // 
            // FormAdicionarBilhetes
            // 
            AutoScaleDimensions = new SizeF(14F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1181, 614);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(btnConfirmar);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Gadugi", 13.8F, FontStyle.Bold);
            Margin = new Padding(5, 4, 5, 4);
            Name = "FormAdicionarBilhetes";
            Text = "FormAdicionarBilhetes";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private ComboBox comboBoxVoos;
        private GroupBox groupBox2;
        private Button btnConfirmar;
        private DataGridView dataGridView1;
        private Button button1;
    }
}