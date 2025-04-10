namespace BilheticaAeronautica
{
    partial class FormEditarAeroporto
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
            btnGuardar = new Button();
            label1 = new Label();
            btnFechar = new Button();
            panel1 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel2 = new Panel();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            txtNome = new Syncfusion.Windows.Forms.Grid.GridAwareTextBox();
            txtIATA = new Syncfusion.Windows.Forms.Grid.GridAwareTextBox();
            lblId = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            button5 = new Button();
            button4 = new Button();
            txtPais = new Syncfusion.Windows.Forms.Grid.GridAwareTextBox();
            txtCidade = new Syncfusion.Windows.Forms.Grid.GridAwareTextBox();
            dragControl1 = new DragControl();
            dragControl2 = new DragControl();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(236, 175, 74);
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = Color.FromArgb(83, 4, 17);
            btnGuardar.Image = Properties.Resources.icons8_confirm_40;
            btnGuardar.Location = new Point(243, 613);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(401, 57);
            btnGuardar.TabIndex = 36;
            btnGuardar.Text = "        Guardar";
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gadugi", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(83, 4, 17);
            label1.Location = new Point(92, 97);
            label1.Name = "label1";
            label1.Size = new Size(287, 40);
            label1.TabIndex = 33;
            label1.Text = "Editar Aeroporto";
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.Firebrick;
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Image = Properties.Resources.icons8_close_50;
            btnFechar.Location = new Point(666, 0);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(81, 57);
            btnFechar.TabIndex = 97;
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(83, 4, 17);
            panel1.Controls.Add(btnFechar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(747, 56);
            panel1.TabIndex = 203;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(83, 4, 17);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 56);
            panel3.Name = "panel3";
            panel3.Size = new Size(5, 681);
            panel3.TabIndex = 204;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(83, 4, 17);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(742, 56);
            panel4.Name = "panel4";
            panel4.Size = new Size(5, 681);
            panel4.TabIndex = 205;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(83, 4, 17);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(5, 732);
            panel2.Name = "panel2";
            panel2.Size = new Size(737, 5);
            panel2.TabIndex = 206;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(83, 14, 17);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Cornsilk;
            button2.Location = new Point(97, 340);
            button2.Name = "button2";
            button2.Size = new Size(129, 49);
            button2.TabIndex = 212;
            button2.Text = "Nome";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(83, 14, 17);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Cornsilk;
            button1.Location = new Point(97, 255);
            button1.Name = "button1";
            button1.Size = new Size(129, 49);
            button1.TabIndex = 211;
            button1.Text = "IATA";
            button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(83, 14, 17);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Cornsilk;
            button3.Location = new Point(97, 175);
            button3.Name = "button3";
            button3.Size = new Size(129, 49);
            button3.TabIndex = 210;
            button3.Text = "ID";
            button3.UseVisualStyleBackColor = false;
            // 
            // txtNome
            // 
            txtNome.AutoSuggestFormula = false;
            txtNome.DisabledBackColor = SystemColors.Window;
            txtNome.EnabledBackColor = SystemColors.Window;
            txtNome.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(244, 355);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(400, 34);
            txtNome.TabIndex = 209;
            // 
            // txtIATA
            // 
            txtIATA.AutoSuggestFormula = false;
            txtIATA.DisabledBackColor = SystemColors.Window;
            txtIATA.EnabledBackColor = SystemColors.Window;
            txtIATA.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIATA.Location = new Point(244, 264);
            txtIATA.Name = "txtIATA";
            txtIATA.Size = new Size(208, 34);
            txtIATA.TabIndex = 208;
            // 
            // lblId
            // 
            lblId.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblId.ForeColor = Color.FromArgb(83, 4, 17);
            lblId.Location = new Point(232, 193);
            lblId.Name = "lblId";
            lblId.Size = new Size(85, 24);
            lblId.TabIndex = 207;
            lblId.Text = "<none>";
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(83, 14, 17);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.Cornsilk;
            button5.Location = new Point(97, 504);
            button5.Name = "button5";
            button5.Size = new Size(129, 49);
            button5.TabIndex = 216;
            button5.Text = "País";
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(83, 14, 17);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Cornsilk;
            button4.Location = new Point(97, 424);
            button4.Name = "button4";
            button4.Size = new Size(129, 49);
            button4.TabIndex = 215;
            button4.Text = "Cidade";
            button4.UseVisualStyleBackColor = false;
            // 
            // txtPais
            // 
            txtPais.AutoSuggestFormula = false;
            txtPais.DisabledBackColor = SystemColors.Window;
            txtPais.EnabledBackColor = SystemColors.Window;
            txtPais.Font = new Font("Gadugi", 12F);
            txtPais.Location = new Point(243, 513);
            txtPais.Name = "txtPais";
            txtPais.Size = new Size(305, 34);
            txtPais.TabIndex = 214;
            // 
            // txtCidade
            // 
            txtCidade.AutoSuggestFormula = false;
            txtCidade.DisabledBackColor = SystemColors.Window;
            txtCidade.EnabledBackColor = SystemColors.Window;
            txtCidade.Font = new Font("Gadugi", 12F);
            txtCidade.Location = new Point(243, 432);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(305, 34);
            txtCidade.TabIndex = 213;
            // 
            // dragControl1
            // 
            dragControl1.SelectedControl = this;
            // 
            // dragControl2
            // 
            dragControl2.SelectedControl = panel1;
            // 
            // FormEditarAeroporto
            // 
            AutoScaleDimensions = new SizeF(14F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(747, 737);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(txtPais);
            Controls.Add(txtCidade);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(txtNome);
            Controls.Add(txtIATA);
            Controls.Add(lblId);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(btnGuardar);
            Controls.Add(label1);
            Font = new Font("Gadugi", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 4, 5, 4);
            Name = "FormEditarAeroporto";
            Text = "EditarAeroporto";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnGuardar;
        private Label label1;
        private Button btnFechar;
        private Panel panel1;
        private Panel panel3;
        private Panel panel4;
        private Panel panel2;
        private Button button2;
        private Button button1;
        private Button button3;
        private Syncfusion.Windows.Forms.Grid.GridAwareTextBox txtNome;
        private Syncfusion.Windows.Forms.Grid.GridAwareTextBox txtIATA;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblId;
        private Button button5;
        private Button button4;
        private Syncfusion.Windows.Forms.Grid.GridAwareTextBox txtPais;
        private Syncfusion.Windows.Forms.Grid.GridAwareTextBox txtCidade;
        private DragControl dragControl1;
        private DragControl dragControl2;
    }
}