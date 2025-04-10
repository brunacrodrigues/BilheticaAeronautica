namespace BilheticaAeronautica.Forms
{
    partial class FormEditarBilhete
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
            lblNumeroVoo = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            button2 = new Button();
            label1 = new Label();
            comboBoxTipoLugar = new ComboBox();
            checkedListBoxLugares = new CheckedListBox();
            groupBox1 = new GroupBox();
            label6 = new Label();
            txtLugarPassageiro = new TextBox();
            label5 = new Label();
            txtTelefonePassageiro = new TextBox();
            label4 = new Label();
            txtEmailPassageiro = new TextBox();
            label3 = new Label();
            txtPassaportePassageiro = new TextBox();
            label2 = new Label();
            txtNomePassageiro = new TextBox();
            btnConfirmarAlteracao = new Button();
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            panel1 = new Panel();
            btnFechar = new Button();
            dragControl1 = new DragControl();
            dragControl2 = new DragControl();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblNumeroVoo
            // 
            lblNumeroVoo.Location = new Point(577, -86);
            lblNumeroVoo.Name = "lblNumeroVoo";
            lblNumeroVoo.Size = new Size(82, 24);
            lblNumeroVoo.TabIndex = 50;
            lblNumeroVoo.Text = "<none>";
            // 
            // button2
            // 
            button2.BackColor = Color.Navy;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(442, -95);
            button2.Name = "button2";
            button2.Size = new Size(129, 49);
            button2.TabIndex = 49;
            button2.Text = "Nº de Voo";
            button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(83, 4, 17);
            label1.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(103, 115);
            label1.Name = "label1";
            label1.Size = new Size(140, 24);
            label1.TabIndex = 48;
            label1.Text = "Tipo de Lugar";
            // 
            // comboBoxTipoLugar
            // 
            comboBoxTipoLugar.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTipoLugar.Font = new Font("Gadugi", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxTipoLugar.FormattingEnabled = true;
            comboBoxTipoLugar.Location = new Point(103, 146);
            comboBoxTipoLugar.Margin = new Padding(5, 4, 5, 4);
            comboBoxTipoLugar.Name = "comboBoxTipoLugar";
            comboBoxTipoLugar.Size = new Size(213, 35);
            comboBoxTipoLugar.TabIndex = 47;
            comboBoxTipoLugar.SelectedIndexChanged += comboBoxTipoLugar_SelectedIndexChanged;
            // 
            // checkedListBoxLugares
            // 
            checkedListBoxLugares.CheckOnClick = true;
            checkedListBoxLugares.FormattingEnabled = true;
            checkedListBoxLugares.Location = new Point(103, 209);
            checkedListBoxLugares.Margin = new Padding(5, 4, 5, 4);
            checkedListBoxLugares.Name = "checkedListBoxLugares";
            checkedListBoxLugares.Size = new Size(213, 526);
            checkedListBoxLugares.TabIndex = 46;
            checkedListBoxLugares.ItemCheck += checkedListBoxLugares_ItemCheck;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtLugarPassageiro);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtTelefonePassageiro);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtEmailPassageiro);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtPassaportePassageiro);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtNomePassageiro);
            groupBox1.Enabled = false;
            groupBox1.Font = new Font("Gadugi", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(83, 4, 17);
            groupBox1.Location = new Point(394, 157);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(449, 505);
            groupBox1.TabIndex = 84;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados Passageiro";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Gadugi", 12F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(83, 4, 17);
            label6.Location = new Point(38, 407);
            label6.Name = "label6";
            label6.Size = new Size(63, 24);
            label6.TabIndex = 12;
            label6.Text = "Lugar";
            // 
            // txtLugarPassageiro
            // 
            txtLugarPassageiro.Font = new Font("Gadugi", 12F);
            txtLugarPassageiro.Location = new Point(42, 437);
            txtLugarPassageiro.Name = "txtLugarPassageiro";
            txtLugarPassageiro.Size = new Size(372, 34);
            txtLugarPassageiro.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Gadugi", 12F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(83, 4, 17);
            label5.Location = new Point(34, 322);
            label5.Name = "label5";
            label5.Size = new Size(93, 24);
            label5.TabIndex = 10;
            label5.Text = "Telefone";
            // 
            // txtTelefonePassageiro
            // 
            txtTelefonePassageiro.Font = new Font("Gadugi", 12F);
            txtTelefonePassageiro.Location = new Point(38, 352);
            txtTelefonePassageiro.Name = "txtTelefonePassageiro";
            txtTelefonePassageiro.Size = new Size(372, 34);
            txtTelefonePassageiro.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Gadugi", 12F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(83, 4, 17);
            label4.Location = new Point(34, 230);
            label4.Name = "label4";
            label4.Size = new Size(62, 24);
            label4.TabIndex = 8;
            label4.Text = "Email";
            // 
            // txtEmailPassageiro
            // 
            txtEmailPassageiro.Font = new Font("Gadugi", 12F);
            txtEmailPassageiro.Location = new Point(38, 260);
            txtEmailPassageiro.Name = "txtEmailPassageiro";
            txtEmailPassageiro.Size = new Size(372, 34);
            txtEmailPassageiro.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Gadugi", 12F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(83, 4, 17);
            label3.Location = new Point(34, 138);
            label3.Name = "label3";
            label3.Size = new Size(113, 24);
            label3.TabIndex = 6;
            label3.Text = "Passaporte";
            // 
            // txtPassaportePassageiro
            // 
            txtPassaportePassageiro.Font = new Font("Gadugi", 12F);
            txtPassaportePassageiro.Location = new Point(38, 168);
            txtPassaportePassageiro.Name = "txtPassaportePassageiro";
            txtPassaportePassageiro.Size = new Size(372, 34);
            txtPassaportePassageiro.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gadugi", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(83, 4, 17);
            label2.Location = new Point(33, 48);
            label2.Name = "label2";
            label2.Size = new Size(164, 24);
            label2.TabIndex = 4;
            label2.Text = "Nome Completo";
            // 
            // txtNomePassageiro
            // 
            txtNomePassageiro.Font = new Font("Gadugi", 12F);
            txtNomePassageiro.Location = new Point(38, 78);
            txtNomePassageiro.Name = "txtNomePassageiro";
            txtNomePassageiro.Size = new Size(372, 34);
            txtNomePassageiro.TabIndex = 0;
            // 
            // btnConfirmarAlteracao
            // 
            btnConfirmarAlteracao.BackColor = Color.FromArgb(236, 175, 74);
            btnConfirmarAlteracao.FlatAppearance.BorderSize = 0;
            btnConfirmarAlteracao.FlatStyle = FlatStyle.Flat;
            btnConfirmarAlteracao.Font = new Font("Gadugi", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmarAlteracao.ForeColor = Color.FromArgb(83, 4, 17);
            btnConfirmarAlteracao.Image = Properties.Resources.icons8_confirm_40;
            btnConfirmarAlteracao.Location = new Point(394, 678);
            btnConfirmarAlteracao.Name = "btnConfirmarAlteracao";
            btnConfirmarAlteracao.Size = new Size(449, 57);
            btnConfirmarAlteracao.TabIndex = 82;
            btnConfirmarAlteracao.Text = "      Confirmar Alteração";
            btnConfirmarAlteracao.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnConfirmarAlteracao.UseVisualStyleBackColor = false;
            btnConfirmarAlteracao.Click += btnConfirmarAlteracao_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(83, 4, 17);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(961, 55);
            panel4.Name = "panel4";
            panel4.Size = new Size(5, 733);
            panel4.TabIndex = 99;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(83, 4, 17);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 55);
            panel3.Name = "panel3";
            panel3.Size = new Size(5, 733);
            panel3.TabIndex = 98;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(83, 4, 17);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 788);
            panel2.Name = "panel2";
            panel2.Size = new Size(966, 5);
            panel2.TabIndex = 97;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(83, 14, 7);
            panel1.Controls.Add(btnFechar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(966, 55);
            panel1.TabIndex = 96;
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.Firebrick;
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Image = Properties.Resources.icons8_close_50;
            btnFechar.Location = new Point(885, 0);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(81, 54);
            btnFechar.TabIndex = 91;
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // dragControl1
            // 
            dragControl1.SelectedControl = this;
            // 
            // dragControl2
            // 
            dragControl2.SelectedControl = panel1;
            // 
            // FormEditarBilhete
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(966, 793);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnConfirmarAlteracao);
            Controls.Add(groupBox1);
            Controls.Add(lblNumeroVoo);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(comboBoxTipoLugar);
            Controls.Add(checkedListBoxLugares);
            Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FormEditarBilhete";
            Text = "FormEditarBilhete";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.AutoLabel lblNumeroVoo;
        private Button button2;
        private Label label1;
        private ComboBox comboBoxTipoLugar;
        private CheckedListBox checkedListBoxLugares;
        private GroupBox groupBox1;
        private Label label5;
        private TextBox txtTelefonePassageiro;
        private Label label4;
        private TextBox txtEmailPassageiro;
        private Label label3;
        private TextBox txtPassaportePassageiro;
        private Label label2;
        private TextBox txtNomePassageiro;
        private Label label6;
        private TextBox txtLugarPassageiro;
        private Button btnConfirmarAlteracao;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private Button btnFechar;
        private DragControl dragControl1;
        private DragControl dragControl2;
    }
}