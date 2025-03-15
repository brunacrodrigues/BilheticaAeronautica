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
            gradientLabel4 = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            txtModelo = new Syncfusion.Windows.Forms.Grid.GridAwareTextBox();
            gradientLabel3 = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            txtMarca = new Syncfusion.Windows.Forms.Grid.GridAwareTextBox();
            gradientLabel2 = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            LblId = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            gradientLabel1 = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            groupBox1 = new GroupBox();
            comboBoxLugaresPorFila = new ComboBox();
            comboBoxFilasEconomicas = new ComboBox();
            comboBoxFilasExecutivas = new ComboBox();
            btnOk = new Button();
            gradientLabel5 = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            gradientLabel6 = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            gradientLabel7 = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            txtCapacidade = new Syncfusion.Windows.Forms.Grid.GridAwareTextBox();
            checkBoxEstado = new CheckBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gadugi", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(118, 49);
            label1.Name = "label1";
            label1.Size = new Size(347, 36);
            label1.TabIndex = 19;
            label1.Text = "Editar Modelo de Avião";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Navy;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Gadugi", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(538, 862);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(122, 46);
            btnGuardar.TabIndex = 18;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // gradientLabel4
            // 
            gradientLabel4.BeforeTouchSize = new Size(129, 46);
            gradientLabel4.BorderSides = Border3DSide.Left | Border3DSide.Top | Border3DSide.Right | Border3DSide.Bottom;
            gradientLabel4.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gradientLabel4.Location = new Point(118, 364);
            gradientLabel4.Name = "gradientLabel4";
            gradientLabel4.Size = new Size(129, 46);
            gradientLabel4.TabIndex = 16;
            gradientLabel4.Text = "Capacidade";
            gradientLabel4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtModelo
            // 
            txtModelo.AutoSuggestFormula = false;
            txtModelo.DisabledBackColor = SystemColors.Window;
            txtModelo.EnabledBackColor = SystemColors.Window;
            txtModelo.Location = new Point(263, 299);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(224, 38);
            txtModelo.TabIndex = 15;
            // 
            // gradientLabel3
            // 
            gradientLabel3.BeforeTouchSize = new Size(129, 49);
            gradientLabel3.BorderSides = Border3DSide.Left | Border3DSide.Top | Border3DSide.Right | Border3DSide.Bottom;
            gradientLabel3.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gradientLabel3.Location = new Point(118, 294);
            gradientLabel3.Name = "gradientLabel3";
            gradientLabel3.Size = new Size(129, 49);
            gradientLabel3.TabIndex = 14;
            gradientLabel3.Text = "Modelo";
            gradientLabel3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtMarca
            // 
            txtMarca.AutoSuggestFormula = false;
            txtMarca.DisabledBackColor = SystemColors.Window;
            txtMarca.EnabledBackColor = SystemColors.Window;
            txtMarca.Location = new Point(263, 219);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(224, 38);
            txtMarca.TabIndex = 13;
            // 
            // gradientLabel2
            // 
            gradientLabel2.BeforeTouchSize = new Size(129, 49);
            gradientLabel2.BorderSides = Border3DSide.Left | Border3DSide.Top | Border3DSide.Right | Border3DSide.Bottom;
            gradientLabel2.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gradientLabel2.Location = new Point(118, 214);
            gradientLabel2.Name = "gradientLabel2";
            gradientLabel2.Size = new Size(129, 49);
            gradientLabel2.TabIndex = 12;
            gradientLabel2.Text = "Marca";
            gradientLabel2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblId
            // 
            LblId.Font = new Font("Gadugi", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblId.Location = new Point(253, 147);
            LblId.Name = "LblId";
            LblId.Size = new Size(98, 27);
            LblId.TabIndex = 11;
            LblId.Text = "<none>";
            // 
            // gradientLabel1
            // 
            gradientLabel1.BeforeTouchSize = new Size(129, 49);
            gradientLabel1.BorderSides = Border3DSide.Left | Border3DSide.Top | Border3DSide.Right | Border3DSide.Bottom;
            gradientLabel1.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gradientLabel1.Location = new Point(118, 134);
            gradientLabel1.Name = "gradientLabel1";
            gradientLabel1.Size = new Size(129, 49);
            gradientLabel1.TabIndex = 10;
            gradientLabel1.Text = "Id";
            gradientLabel1.TextAlign = ContentAlignment.MiddleCenter;
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
            groupBox1.Font = new Font("Gadugi", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(105, 450);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(419, 366);
            groupBox1.TabIndex = 20;
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
            btnOk.BackColor = Color.Navy;
            btnOk.FlatAppearance.BorderSize = 0;
            btnOk.FlatStyle = FlatStyle.Flat;
            btnOk.ForeColor = Color.White;
            btnOk.Location = new Point(325, 303);
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
            txtCapacidade.Location = new Point(263, 372);
            txtCapacidade.Name = "txtCapacidade";
            txtCapacidade.ReadOnly = true;
            txtCapacidade.Size = new Size(88, 38);
            txtCapacidade.TabIndex = 21;
            // 
            // checkBoxEstado
            // 
            checkBoxEstado.AutoSize = true;
            checkBoxEstado.Location = new Point(538, 134);
            checkBoxEstado.Name = "checkBoxEstado";
            checkBoxEstado.Size = new Size(85, 31);
            checkBoxEstado.TabIndex = 22;
            checkBoxEstado.Text = "none";
            checkBoxEstado.UseVisualStyleBackColor = true;
            // 
            // FormEditarAviao
            // 
            AutoScaleDimensions = new SizeF(13F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(719, 946);
            Controls.Add(checkBoxEstado);
            Controls.Add(txtCapacidade);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(btnGuardar);
            Controls.Add(gradientLabel4);
            Controls.Add(txtModelo);
            Controls.Add(gradientLabel3);
            Controls.Add(txtMarca);
            Controls.Add(gradientLabel2);
            Controls.Add(LblId);
            Controls.Add(gradientLabel1);
            Font = new Font("Gadugi", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "FormEditarAviao";
            Text = "EditarAviao";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnGuardar;
        private Syncfusion.Windows.Forms.Tools.GradientLabel gradientLabel4;
        private Syncfusion.Windows.Forms.Grid.GridAwareTextBox txtModelo;
        private Syncfusion.Windows.Forms.Tools.GradientLabel gradientLabel3;
        private Syncfusion.Windows.Forms.Grid.GridAwareTextBox txtMarca;
        private Syncfusion.Windows.Forms.Tools.GradientLabel gradientLabel2;
        private Syncfusion.Windows.Forms.Tools.AutoLabel LblId;
        private Syncfusion.Windows.Forms.Tools.GradientLabel gradientLabel1;
        private GroupBox groupBox1;
        private ComboBox comboBoxLugaresPorFila;
        private ComboBox comboBoxFilasEconomicas;
        private ComboBox comboBoxFilasExecutivas;
        private Button btnOk;
        private Syncfusion.Windows.Forms.Tools.GradientLabel gradientLabel5;
        private Syncfusion.Windows.Forms.Tools.GradientLabel gradientLabel6;
        private Syncfusion.Windows.Forms.Tools.GradientLabel gradientLabel7;
        private Syncfusion.Windows.Forms.Grid.GridAwareTextBox txtCapacidade;
        private CheckBox checkBoxEstado;
    }
}