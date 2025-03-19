namespace BilheticaAeronautica
{
    partial class FormAdicionarAviao
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
            components = new System.ComponentModel.Container();
            borderLayout1 = new Syncfusion.Windows.Forms.Tools.BorderLayout(components);
            gradientLabel1 = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            lblId = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            contextMenuStripEx1 = new Syncfusion.Windows.Forms.Tools.ContextMenuStripEx();
            txtModelo = new Syncfusion.Windows.Forms.Grid.GridAwareTextBox();
            gradientLabel3 = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            gradientLabel4 = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            btnRegistar = new Button();
            label1 = new Label();
            gridViewModelos = new DataGridView();
            groupBox1 = new GroupBox();
            comboBoxLugaresPorFila = new ComboBox();
            comboBoxFilasEconomicas = new ComboBox();
            comboBoxFilasExecutivas = new ComboBox();
            btnOk = new Button();
            gradientLabel5 = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            gradientLabel6 = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            gradientLabel7 = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            txtCapacidade = new Syncfusion.Windows.Forms.Grid.GridAwareTextBox();
            btnEditar = new Button();
            btnApagar = new Button();
            ((System.ComponentModel.ISupportInitialize)borderLayout1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridViewModelos).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // borderLayout1
            // 
            borderLayout1.HGap = 0;
            borderLayout1.VGap = 0;
            // 
            // gradientLabel1
            // 
            gradientLabel1.BeforeTouchSize = new Size(129, 49);
            gradientLabel1.BorderSides = Border3DSide.Left | Border3DSide.Top | Border3DSide.Right | Border3DSide.Bottom;
            gradientLabel1.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gradientLabel1.Location = new Point(151, 101);
            gradientLabel1.Name = "gradientLabel1";
            gradientLabel1.Size = new Size(129, 49);
            gradientLabel1.TabIndex = 0;
            gradientLabel1.Text = "Id";
            gradientLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblId
            // 
            lblId.Location = new Point(286, 114);
            lblId.Name = "lblId";
            lblId.Size = new Size(98, 27);
            lblId.TabIndex = 1;
            lblId.Text = "<none>";
            // 
            // contextMenuStripEx1
            // 
            contextMenuStripEx1.ImageScalingSize = new Size(20, 20);
            contextMenuStripEx1.MetroColor = Color.FromArgb(204, 236, 249);
            contextMenuStripEx1.Name = "contextMenuStripEx1";
            contextMenuStripEx1.Size = new Size(61, 4);
            // 
            // txtModelo
            // 
            txtModelo.AutoSuggestFormula = false;
            txtModelo.DisabledBackColor = SystemColors.Window;
            txtModelo.EnabledBackColor = SystemColors.Window;
            txtModelo.Location = new Point(296, 178);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(224, 38);
            txtModelo.TabIndex = 5;
            // 
            // gradientLabel3
            // 
            gradientLabel3.BeforeTouchSize = new Size(129, 49);
            gradientLabel3.BorderSides = Border3DSide.Left | Border3DSide.Top | Border3DSide.Right | Border3DSide.Bottom;
            gradientLabel3.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gradientLabel3.Location = new Point(151, 173);
            gradientLabel3.Name = "gradientLabel3";
            gradientLabel3.Size = new Size(129, 49);
            gradientLabel3.TabIndex = 4;
            gradientLabel3.Text = "Modelo";
            gradientLabel3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gradientLabel4
            // 
            gradientLabel4.BeforeTouchSize = new Size(129, 46);
            gradientLabel4.BorderSides = Border3DSide.Left | Border3DSide.Top | Border3DSide.Right | Border3DSide.Bottom;
            gradientLabel4.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gradientLabel4.Location = new Point(151, 243);
            gradientLabel4.Name = "gradientLabel4";
            gradientLabel4.Size = new Size(129, 46);
            gradientLabel4.TabIndex = 6;
            gradientLabel4.Text = "Capacidade";
            gradientLabel4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnRegistar
            // 
            btnRegistar.BackColor = Color.Navy;
            btnRegistar.FlatAppearance.BorderSize = 0;
            btnRegistar.FlatStyle = FlatStyle.Flat;
            btnRegistar.ForeColor = Color.White;
            btnRegistar.Location = new Point(423, 739);
            btnRegistar.Name = "btnRegistar";
            btnRegistar.Size = new Size(122, 46);
            btnRegistar.TabIndex = 8;
            btnRegistar.Text = "Guardar";
            btnRegistar.UseVisualStyleBackColor = false;
            btnRegistar.Click += btnRegistar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gadugi", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(151, 25);
            label1.Name = "label1";
            label1.Size = new Size(331, 36);
            label1.TabIndex = 9;
            label1.Text = "Criar Modelo de Avião";
            // 
            // gridViewModelos
            // 
            gridViewModelos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridViewModelos.Location = new Point(657, 100);
            gridViewModelos.Name = "gridViewModelos";
            gridViewModelos.RowHeadersWidth = 51;
            gridViewModelos.Size = new Size(803, 685);
            gridViewModelos.TabIndex = 10;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBoxLugaresPorFila);
            groupBox1.Controls.Add(comboBoxFilasEconomicas);
            groupBox1.Controls.Add(comboBoxFilasExecutivas);
            groupBox1.Controls.Add(btnOk);
            groupBox1.Controls.Add(gradientLabel5);
            groupBox1.Controls.Add(gradientLabel6);
            groupBox1.Controls.Add(gradientLabel7);
            groupBox1.Location = new Point(126, 353);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(419, 380);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Configurar Lugares";
            // 
            // comboBoxLugaresPorFila
            // 
            comboBoxLugaresPorFila.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxLugaresPorFila.FormattingEnabled = true;
            comboBoxLugaresPorFila.Location = new Point(187, 242);
            comboBoxLugaresPorFila.Name = "comboBoxLugaresPorFila";
            comboBoxLugaresPorFila.Size = new Size(151, 35);
            comboBoxLugaresPorFila.TabIndex = 32;
            // 
            // comboBoxFilasEconomicas
            // 
            comboBoxFilasEconomicas.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFilasEconomicas.FormattingEnabled = true;
            comboBoxFilasEconomicas.Location = new Point(187, 162);
            comboBoxFilasEconomicas.Name = "comboBoxFilasEconomicas";
            comboBoxFilasEconomicas.Size = new Size(151, 35);
            comboBoxFilasEconomicas.TabIndex = 31;
            // 
            // comboBoxFilasExecutivas
            // 
            comboBoxFilasExecutivas.BackColor = Color.White;
            comboBoxFilasExecutivas.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFilasExecutivas.FormattingEnabled = true;
            comboBoxFilasExecutivas.Location = new Point(187, 82);
            comboBoxFilasExecutivas.Name = "comboBoxFilasExecutivas";
            comboBoxFilasExecutivas.Size = new Size(151, 35);
            comboBoxFilasExecutivas.TabIndex = 30;
            // 
            // btnOk
            // 
            btnOk.BackColor = Color.DarkGoldenrod;
            btnOk.FlatAppearance.BorderSize = 0;
            btnOk.FlatStyle = FlatStyle.Flat;
            btnOk.ForeColor = Color.White;
            btnOk.Location = new Point(324, 316);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(70, 46);
            btnOk.TabIndex = 29;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = false;
            btnOk.Click += btnOk_Click;
            // 
            // gradientLabel5
            // 
            gradientLabel5.BeforeTouchSize = new Size(129, 59);
            gradientLabel5.BorderSides = Border3DSide.Left | Border3DSide.Top | Border3DSide.Right | Border3DSide.Bottom;
            gradientLabel5.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gradientLabel5.Location = new Point(25, 218);
            gradientLabel5.Name = "gradientLabel5";
            gradientLabel5.Size = new Size(129, 59);
            gradientLabel5.TabIndex = 25;
            gradientLabel5.Text = "Lugares por Fila";
            gradientLabel5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gradientLabel6
            // 
            gradientLabel6.BeforeTouchSize = new Size(129, 49);
            gradientLabel6.BorderSides = Border3DSide.Left | Border3DSide.Top | Border3DSide.Right | Border3DSide.Bottom;
            gradientLabel6.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gradientLabel6.Location = new Point(25, 148);
            gradientLabel6.Name = "gradientLabel6";
            gradientLabel6.Size = new Size(129, 49);
            gradientLabel6.TabIndex = 24;
            gradientLabel6.Text = "Filas Económicas";
            gradientLabel6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gradientLabel7
            // 
            gradientLabel7.BeforeTouchSize = new Size(129, 49);
            gradientLabel7.BorderSides = Border3DSide.Left | Border3DSide.Top | Border3DSide.Right | Border3DSide.Bottom;
            gradientLabel7.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gradientLabel7.Location = new Point(25, 68);
            gradientLabel7.Name = "gradientLabel7";
            gradientLabel7.Size = new Size(129, 49);
            gradientLabel7.TabIndex = 23;
            gradientLabel7.Text = "Filas Executivas";
            gradientLabel7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtCapacidade
            // 
            txtCapacidade.AutoSuggestFormula = false;
            txtCapacidade.DisabledBackColor = SystemColors.Window;
            txtCapacidade.Enabled = false;
            txtCapacidade.EnabledBackColor = SystemColors.Window;
            txtCapacidade.Location = new Point(296, 250);
            txtCapacidade.Name = "txtCapacidade";
            txtCapacidade.ReadOnly = true;
            txtCapacidade.Size = new Size(88, 38);
            txtCapacidade.TabIndex = 12;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Navy;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(1466, 687);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(122, 46);
            btnEditar.TabIndex = 13;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnApagar
            // 
            btnApagar.BackColor = Color.Crimson;
            btnApagar.FlatAppearance.BorderSize = 0;
            btnApagar.FlatStyle = FlatStyle.Flat;
            btnApagar.ForeColor = Color.White;
            btnApagar.Location = new Point(1466, 739);
            btnApagar.Name = "btnApagar";
            btnApagar.Size = new Size(122, 46);
            btnApagar.TabIndex = 30;
            btnApagar.Text = "Apagar";
            btnApagar.UseVisualStyleBackColor = false;
            btnApagar.Click += btnApagar_Click;
            // 
            // FormAdicionarAviao
            // 
            AutoScaleDimensions = new SizeF(14F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1617, 945);
            Controls.Add(btnApagar);
            Controls.Add(btnEditar);
            Controls.Add(txtCapacidade);
            Controls.Add(groupBox1);
            Controls.Add(gridViewModelos);
            Controls.Add(label1);
            Controls.Add(btnRegistar);
            Controls.Add(gradientLabel4);
            Controls.Add(txtModelo);
            Controls.Add(gradientLabel3);
            Controls.Add(lblId);
            Controls.Add(gradientLabel1);
            Font = new Font("Gadugi", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "FormAdicionarAviao";
            Text = "CriarAviao";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)borderLayout1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridViewModelos).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.BorderLayout borderLayout1;
        private Syncfusion.Windows.Forms.Tools.GradientLabel gradientLabel1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblId;
        private Syncfusion.Windows.Forms.Tools.ContextMenuStripEx contextMenuStripEx1;
        private Syncfusion.Windows.Forms.Grid.GridAwareTextBox txtModelo;
        private Syncfusion.Windows.Forms.Tools.GradientLabel gradientLabel3;
        private Syncfusion.Windows.Forms.Tools.GradientLabel gradientLabel4;
        private Button btnRegistar;
        private Label label1;
        private DataGridView gridViewModelos;
        private GroupBox groupBox1;
        private Syncfusion.Windows.Forms.Tools.GradientLabel gradientLabel5;
        private Syncfusion.Windows.Forms.Tools.GradientLabel gradientLabel6;
        private Syncfusion.Windows.Forms.Tools.GradientLabel gradientLabel7;
        private Button btnOk;
        private Syncfusion.Windows.Forms.Grid.GridAwareTextBox txtCapacidade;
        private ComboBox comboBoxLugaresPorFila;
        private ComboBox comboBoxFilasEconomicas;
        private ComboBox comboBoxFilasExecutivas;
        private Button btnEditar;
        private Button btnApagar;
    }
}