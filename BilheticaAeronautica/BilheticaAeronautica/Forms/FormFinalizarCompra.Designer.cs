namespace BilheticaAeronautica.Forms
{
    partial class FormFinalizarCompra
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
            comboBoxMetodoPagamento = new ComboBox();
            autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            gridViewCarrinho = new DataGridView();
            btnConcluirCompra = new Button();
            txt1 = new TextBox();
            autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            txtCcv = new TextBox();
            lblDataValidade = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            lblCCV = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            groupBoxDados = new GroupBox();
            numericUpDownAnos = new NumericUpDown();
            comboBoxMeses = new ComboBox();
            btnFechar = new Button();
            panel3 = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            panel4 = new Panel();
            dragControl1 = new DragControl();
            dragControl2 = new DragControl();
            ((System.ComponentModel.ISupportInitialize)gridViewCarrinho).BeginInit();
            groupBoxDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAnos).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gadugi", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(83, 4, 17);
            label1.Location = new Point(65, 102);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(287, 40);
            label1.TabIndex = 34;
            label1.Text = "Finalizar Compra";
            // 
            // comboBoxMetodoPagamento
            // 
            comboBoxMetodoPagamento.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMetodoPagamento.FormattingEnabled = true;
            comboBoxMetodoPagamento.Location = new Point(629, 173);
            comboBoxMetodoPagamento.Margin = new Padding(2);
            comboBoxMetodoPagamento.Name = "comboBoxMetodoPagamento";
            comboBoxMetodoPagamento.Size = new Size(333, 29);
            comboBoxMetodoPagamento.TabIndex = 35;
            comboBoxMetodoPagamento.SelectedIndexChanged += comboBoxMetodoPagamento_SelectedIndexChanged;
            // 
            // autoLabel1
            // 
            autoLabel1.BackColor = Color.FromArgb(83, 4, 17);
            autoLabel1.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autoLabel1.ForeColor = Color.White;
            autoLabel1.Location = new Point(629, 141);
            autoLabel1.Margin = new Padding(2, 0, 2, 0);
            autoLabel1.Name = "autoLabel1";
            autoLabel1.Size = new Size(226, 24);
            autoLabel1.TabIndex = 87;
            autoLabel1.Text = "Método de Pagamento";
            // 
            // gridViewCarrinho
            // 
            gridViewCarrinho.AllowUserToAddRows = false;
            gridViewCarrinho.AllowUserToDeleteRows = false;
            gridViewCarrinho.AllowUserToResizeColumns = false;
            gridViewCarrinho.AllowUserToResizeRows = false;
            gridViewCarrinho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gridViewCarrinho.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            gridViewCarrinho.BackgroundColor = Color.White;
            gridViewCarrinho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridViewCarrinho.Location = new Point(65, 145);
            gridViewCarrinho.Name = "gridViewCarrinho";
            gridViewCarrinho.ReadOnly = true;
            gridViewCarrinho.RowHeadersVisible = false;
            gridViewCarrinho.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            gridViewCarrinho.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridViewCarrinho.Size = new Size(521, 361);
            gridViewCarrinho.TabIndex = 88;
            // 
            // btnConcluirCompra
            // 
            btnConcluirCompra.BackColor = Color.FromArgb(236, 175, 74);
            btnConcluirCompra.FlatAppearance.BorderSize = 0;
            btnConcluirCompra.FlatStyle = FlatStyle.Flat;
            btnConcluirCompra.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConcluirCompra.ForeColor = Color.FromArgb(83, 14, 7);
            btnConcluirCompra.Image = Properties.Resources.icons8_confirm_40;
            btnConcluirCompra.Location = new Point(629, 455);
            btnConcluirCompra.Name = "btnConcluirCompra";
            btnConcluirCompra.Size = new Size(333, 51);
            btnConcluirCompra.TabIndex = 89;
            btnConcluirCompra.Text = "    Concluir Compra";
            btnConcluirCompra.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnConcluirCompra.UseVisualStyleBackColor = false;
            btnConcluirCompra.Click += btnConcluirCompra_Click;
            // 
            // txt1
            // 
            txt1.Location = new Point(25, 51);
            txt1.Name = "txt1";
            txt1.Size = new Size(283, 31);
            txt1.TabIndex = 90;
            // 
            // autoLabel2
            // 
            autoLabel2.Font = new Font("Gadugi", 10.8F, FontStyle.Bold);
            autoLabel2.ForeColor = Color.FromArgb(83, 4, 17);
            autoLabel2.Location = new Point(25, 27);
            autoLabel2.Margin = new Padding(2, 0, 2, 0);
            autoLabel2.Name = "autoLabel2";
            autoLabel2.Size = new Size(140, 21);
            autoLabel2.TabIndex = 91;
            autoLabel2.Text = "Número Cartão";
            // 
            // txtCcv
            // 
            txtCcv.Location = new Point(218, 137);
            txtCcv.Name = "txtCcv";
            txtCcv.Size = new Size(90, 31);
            txtCcv.TabIndex = 92;
            // 
            // lblDataValidade
            // 
            lblDataValidade.Font = new Font("Gadugi", 10.8F, FontStyle.Bold);
            lblDataValidade.ForeColor = Color.FromArgb(83, 4, 17);
            lblDataValidade.Location = new Point(25, 109);
            lblDataValidade.Margin = new Padding(2, 0, 2, 0);
            lblDataValidade.Name = "lblDataValidade";
            lblDataValidade.Size = new Size(155, 21);
            lblDataValidade.TabIndex = 94;
            lblDataValidade.Text = "Data de Validade";
            // 
            // lblCCV
            // 
            lblCCV.Font = new Font("Gadugi", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCCV.ForeColor = Color.FromArgb(83, 4, 17);
            lblCCV.Location = new Point(235, 109);
            lblCCV.Margin = new Padding(2, 0, 2, 0);
            lblCCV.Name = "lblCCV";
            lblCCV.Size = new Size(44, 21);
            lblCCV.TabIndex = 95;
            lblCCV.Text = "CCV";
            // 
            // groupBoxDados
            // 
            groupBoxDados.Controls.Add(numericUpDownAnos);
            groupBoxDados.Controls.Add(comboBoxMeses);
            groupBoxDados.Controls.Add(autoLabel2);
            groupBoxDados.Controls.Add(lblCCV);
            groupBoxDados.Controls.Add(txt1);
            groupBoxDados.Controls.Add(lblDataValidade);
            groupBoxDados.Controls.Add(txtCcv);
            groupBoxDados.Location = new Point(629, 213);
            groupBoxDados.Name = "groupBoxDados";
            groupBoxDados.Size = new Size(333, 220);
            groupBoxDados.TabIndex = 96;
            groupBoxDados.TabStop = false;
            groupBoxDados.Visible = false;
            // 
            // numericUpDownAnos
            // 
            numericUpDownAnos.Location = new Point(89, 137);
            numericUpDownAnos.Maximum = new decimal(new int[] { 2040, 0, 0, 0 });
            numericUpDownAnos.Minimum = new decimal(new int[] { 2025, 0, 0, 0 });
            numericUpDownAnos.Name = "numericUpDownAnos";
            numericUpDownAnos.Size = new Size(76, 31);
            numericUpDownAnos.TabIndex = 97;
            numericUpDownAnos.Value = new decimal(new int[] { 2025, 0, 0, 0 });
            // 
            // comboBoxMeses
            // 
            comboBoxMeses.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMeses.FormattingEnabled = true;
            comboBoxMeses.Location = new Point(25, 138);
            comboBoxMeses.Name = "comboBoxMeses";
            comboBoxMeses.Size = new Size(47, 29);
            comboBoxMeses.TabIndex = 96;
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.Firebrick;
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Image = Properties.Resources.icons8_close_50;
            btnFechar.Location = new Point(952, 0);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(81, 56);
            btnFechar.TabIndex = 97;
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(83, 4, 17);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(5, 584);
            panel3.TabIndex = 98;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(83, 4, 17);
            panel1.Controls.Add(btnFechar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(5, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1033, 56);
            panel1.TabIndex = 99;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(83, 4, 17);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(5, 579);
            panel2.Name = "panel2";
            panel2.Size = new Size(1033, 5);
            panel2.TabIndex = 100;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(83, 4, 17);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(1033, 56);
            panel4.Name = "panel4";
            panel4.Size = new Size(5, 523);
            panel4.TabIndex = 101;
            // 
            // dragControl1
            // 
            dragControl1.SelectedControl = this;
            // 
            // dragControl2
            // 
            dragControl2.SelectedControl = panel1;
            // 
            // FormFinalizarCompra
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1038, 584);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(groupBoxDados);
            Controls.Add(btnConcluirCompra);
            Controls.Add(gridViewCarrinho);
            Controls.Add(autoLabel1);
            Controls.Add(comboBoxMetodoPagamento);
            Controls.Add(label1);
            Font = new Font("Gadugi", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormFinalizarCompra";
            Text = "FormFinalizarCompra";
            ((System.ComponentModel.ISupportInitialize)gridViewCarrinho).EndInit();
            groupBoxDados.ResumeLayout(false);
            groupBoxDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAnos).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBoxMetodoPagamento;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private DataGridView gridViewCarrinho;
        private Button btnConcluirCompra;
        private TextBox txt1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel2;
        private TextBox txtCcv;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblDataValidade;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblCCV;
        private GroupBox groupBoxDados;
        private ComboBox comboBoxMeses;
        private NumericUpDown numericUpDownAnos;
        private Button btnFechar;
        private Panel panel3;
        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private DragControl dragControl1;
        private DragControl dragControl2;
    }
}