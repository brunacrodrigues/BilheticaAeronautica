namespace BilheticaAeronautica.Forms
{
    partial class FormEditarCliente
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
            button5 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            button4 = new Button();
            txtTelefone = new Syncfusion.Windows.Forms.Grid.GridAwareTextBox();
            txtEmail = new Syncfusion.Windows.Forms.Grid.GridAwareTextBox();
            txtPassaporte = new Syncfusion.Windows.Forms.Grid.GridAwareTextBox();
            txtNomeCompleto = new Syncfusion.Windows.Forms.Grid.GridAwareTextBox();
            lblId = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            panel1 = new Panel();
            btnFechar = new Button();
            panel4 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
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
            btnGuardar.Font = new Font("Gadugi", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.FromArgb(83, 4, 17);
            btnGuardar.Image = Properties.Resources.icons8_confirm_40;
            btnGuardar.Location = new Point(1108, 428);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(413, 57);
            btnGuardar.TabIndex = 51;
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
            label1.Location = new Point(89, 100);
            label1.Name = "label1";
            label1.Size = new Size(231, 40);
            label1.TabIndex = 48;
            label1.Text = "Editar Cliente";
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(83, 14, 17);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.Cornsilk;
            button5.Location = new Point(99, 177);
            button5.Name = "button5";
            button5.Size = new Size(129, 49);
            button5.TabIndex = 126;
            button5.Text = "ID";
            button5.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(83, 14, 17);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Cornsilk;
            button3.Location = new Point(99, 254);
            button3.Name = "button3";
            button3.Size = new Size(129, 66);
            button3.TabIndex = 125;
            button3.Text = "Nome Completo";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(83, 14, 17);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Cornsilk;
            button2.Location = new Point(99, 348);
            button2.Name = "button2";
            button2.Size = new Size(129, 49);
            button2.TabIndex = 124;
            button2.Text = "Passaporte";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(83, 14, 17);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Cornsilk;
            button1.Location = new Point(911, 342);
            button1.Name = "button1";
            button1.Size = new Size(129, 49);
            button1.TabIndex = 123;
            button1.Text = "Telefone";
            button1.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(83, 14, 17);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Cornsilk;
            button4.Location = new Point(911, 259);
            button4.Name = "button4";
            button4.Size = new Size(129, 49);
            button4.TabIndex = 122;
            button4.Text = "Email";
            button4.UseVisualStyleBackColor = false;
            // 
            // txtTelefone
            // 
            txtTelefone.AutoSuggestFormula = false;
            txtTelefone.DisabledBackColor = SystemColors.Window;
            txtTelefone.EnabledBackColor = SystemColors.Window;
            txtTelefone.Font = new Font("Gadugi", 12F);
            txtTelefone.Location = new Point(1056, 347);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(499, 34);
            txtTelefone.TabIndex = 121;
            // 
            // txtEmail
            // 
            txtEmail.AutoSuggestFormula = false;
            txtEmail.DisabledBackColor = SystemColors.Window;
            txtEmail.EnabledBackColor = SystemColors.Window;
            txtEmail.Font = new Font("Gadugi", 12F);
            txtEmail.Location = new Point(1056, 268);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(499, 34);
            txtEmail.TabIndex = 120;
            // 
            // txtPassaporte
            // 
            txtPassaporte.AutoSuggestFormula = false;
            txtPassaporte.DisabledBackColor = SystemColors.Window;
            txtPassaporte.EnabledBackColor = SystemColors.Window;
            txtPassaporte.Font = new Font("Gadugi", 12F);
            txtPassaporte.Location = new Point(244, 357);
            txtPassaporte.Name = "txtPassaporte";
            txtPassaporte.Size = new Size(519, 34);
            txtPassaporte.TabIndex = 119;
            // 
            // txtNomeCompleto
            // 
            txtNomeCompleto.AutoSuggestFormula = false;
            txtNomeCompleto.DisabledBackColor = SystemColors.Window;
            txtNomeCompleto.EnabledBackColor = SystemColors.Window;
            txtNomeCompleto.Font = new Font("Gadugi", 12F);
            txtNomeCompleto.Location = new Point(244, 272);
            txtNomeCompleto.Name = "txtNomeCompleto";
            txtNomeCompleto.Size = new Size(519, 34);
            txtNomeCompleto.TabIndex = 118;
            // 
            // lblId
            // 
            lblId.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblId.ForeColor = Color.FromArgb(83, 4, 17);
            lblId.Location = new Point(244, 191);
            lblId.Name = "lblId";
            lblId.Size = new Size(85, 24);
            lblId.TabIndex = 117;
            lblId.Text = "<none>";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(83, 4, 17);
            panel1.Controls.Add(btnFechar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1650, 56);
            panel1.TabIndex = 204;
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.Firebrick;
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Image = Properties.Resources.icons8_close_50;
            btnFechar.Location = new Point(1569, 0);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(81, 57);
            btnFechar.TabIndex = 97;
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(83, 4, 17);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(1645, 56);
            panel4.Name = "panel4";
            panel4.Size = new Size(5, 495);
            panel4.TabIndex = 206;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(83, 4, 17);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 541);
            panel2.Name = "panel2";
            panel2.Size = new Size(1645, 10);
            panel2.TabIndex = 207;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(83, 4, 17);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 56);
            panel3.Name = "panel3";
            panel3.Size = new Size(5, 485);
            panel3.TabIndex = 208;
            // 
            // dragControl1
            // 
            dragControl1.SelectedControl = this;
            // 
            // dragControl2
            // 
            dragControl2.SelectedControl = panel1;
            // 
            // FormEditarCliente
            // 
            AutoScaleDimensions = new SizeF(13F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1650, 551);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button4);
            Controls.Add(txtTelefone);
            Controls.Add(txtEmail);
            Controls.Add(txtPassaporte);
            Controls.Add(txtNomeCompleto);
            Controls.Add(lblId);
            Controls.Add(btnGuardar);
            Controls.Add(label1);
            Font = new Font("Gadugi", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 4, 5, 4);
            Name = "FormEditarCliente";
            Text = "EditarCliente";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnGuardar;
        private Label label1;
        private Button button5;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button4;
        private Syncfusion.Windows.Forms.Grid.GridAwareTextBox txtTelefone;
        private Syncfusion.Windows.Forms.Grid.GridAwareTextBox txtEmail;
        private Syncfusion.Windows.Forms.Grid.GridAwareTextBox txtPassaporte;
        private Syncfusion.Windows.Forms.Grid.GridAwareTextBox txtNomeCompleto;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblId;
        private Panel panel1;
        private Button btnFechar;
        private Panel panel4;
        private Panel panel2;
        private Panel panel3;
        private DragControl dragControl1;
        private DragControl dragControl2;
    }
}