namespace BilheticaAeronautica.Forms
{
    partial class FormVenderBilhetes
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
            checkedListBoxLugares = new CheckedListBox();
            comboBoxTipoLugar = new ComboBox();
            label1 = new Label();
            lblNumeroVoo = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            button2 = new Button();
            lblOrigemDestino = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            btnConfirmar = new Button();
            gridViewBilhetesAComprar = new DataGridView();
            groupBox1 = new GroupBox();
            txtNomePassageiro = new TextBox();
            label2 = new Label();
            txtPassaportePassageiro = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtEmailPassageiro = new TextBox();
            label5 = new Label();
            txtTelefonePassageiro = new TextBox();
            btnAdicionarPassageiro = new Button();
            ((System.ComponentModel.ISupportInitialize)gridViewBilhetesAComprar).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // checkedListBoxLugares
            // 
            checkedListBoxLugares.CheckOnClick = true;
            checkedListBoxLugares.FormattingEnabled = true;
            checkedListBoxLugares.Location = new Point(95, 248);
            checkedListBoxLugares.Margin = new Padding(5, 4, 5, 4);
            checkedListBoxLugares.Name = "checkedListBoxLugares";
            checkedListBoxLugares.SelectionMode = SelectionMode.None;
            checkedListBoxLugares.Size = new Size(213, 466);
            checkedListBoxLugares.TabIndex = 1;
            // 
            // comboBoxTipoLugar
            // 
            comboBoxTipoLugar.Font = new Font("Gadugi", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxTipoLugar.FormattingEnabled = true;
            comboBoxTipoLugar.Location = new Point(95, 185);
            comboBoxTipoLugar.Margin = new Padding(5, 4, 5, 4);
            comboBoxTipoLugar.Name = "comboBoxTipoLugar";
            comboBoxTipoLugar.Size = new Size(213, 35);
            comboBoxTipoLugar.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(95, 154);
            label1.Name = "label1";
            label1.Size = new Size(153, 27);
            label1.TabIndex = 3;
            label1.Text = "Tipo de Lugar";
            // 
            // lblNumeroVoo
            // 
            lblNumeroVoo.Location = new Point(230, 67);
            lblNumeroVoo.Name = "lblNumeroVoo";
            lblNumeroVoo.Size = new Size(95, 27);
            lblNumeroVoo.TabIndex = 45;
            lblNumeroVoo.Text = "<none>";
            // 
            // button2
            // 
            button2.BackColor = Color.Navy;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(95, 58);
            button2.Name = "button2";
            button2.Size = new Size(129, 49);
            button2.TabIndex = 44;
            button2.Text = "Nº de Voo";
            button2.UseVisualStyleBackColor = false;
            // 
            // lblOrigemDestino
            // 
            lblOrigemDestino.Location = new Point(898, 67);
            lblOrigemDestino.Name = "lblOrigemDestino";
            lblOrigemDestino.Size = new Size(95, 27);
            lblOrigemDestino.TabIndex = 46;
            lblOrigemDestino.Text = "<none>";
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.DarkGoldenrod;
            btnConfirmar.FlatAppearance.BorderSize = 0;
            btnConfirmar.FlatStyle = FlatStyle.Flat;
            btnConfirmar.Location = new Point(1283, 663);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(137, 51);
            btnConfirmar.TabIndex = 81;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            // 
            // gridViewBilhetesAComprar
            // 
            gridViewBilhetesAComprar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridViewBilhetesAComprar.Location = new Point(898, 154);
            gridViewBilhetesAComprar.Name = "gridViewBilhetesAComprar";
            gridViewBilhetesAComprar.RowHeadersWidth = 51;
            gridViewBilhetesAComprar.Size = new Size(522, 481);
            gridViewBilhetesAComprar.TabIndex = 82;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAdicionarPassageiro);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtTelefonePassageiro);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtEmailPassageiro);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtPassaportePassageiro);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtNomePassageiro);
            groupBox1.Location = new Point(389, 154);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(449, 560);
            groupBox1.TabIndex = 83;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados Passageiro";
            // 
            // txtNomePassageiro
            // 
            txtNomePassageiro.Location = new Point(19, 79);
            txtNomePassageiro.Name = "txtNomePassageiro";
            txtNomePassageiro.Size = new Size(372, 38);
            txtNomePassageiro.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 49);
            label2.Name = "label2";
            label2.Size = new Size(180, 27);
            label2.TabIndex = 4;
            label2.Text = "Nome Completo";
            // 
            // txtPassaportePassageiro
            // 
            txtPassaportePassageiro.Location = new Point(19, 169);
            txtPassaportePassageiro.Name = "txtPassaportePassageiro";
            txtPassaportePassageiro.Size = new Size(372, 38);
            txtPassaportePassageiro.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 139);
            label3.Name = "label3";
            label3.Size = new Size(124, 27);
            label3.TabIndex = 6;
            label3.Text = "Passaporte";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 231);
            label4.Name = "label4";
            label4.Size = new Size(68, 27);
            label4.TabIndex = 8;
            label4.Text = "Email";
            // 
            // txtEmailPassageiro
            // 
            txtEmailPassageiro.Location = new Point(19, 261);
            txtEmailPassageiro.Name = "txtEmailPassageiro";
            txtEmailPassageiro.Size = new Size(372, 38);
            txtEmailPassageiro.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 323);
            label5.Name = "label5";
            label5.Size = new Size(99, 27);
            label5.TabIndex = 10;
            label5.Text = "Telefone";
            // 
            // txtTelefonePassageiro
            // 
            txtTelefonePassageiro.Location = new Point(19, 353);
            txtTelefonePassageiro.Name = "txtTelefonePassageiro";
            txtTelefonePassageiro.Size = new Size(372, 38);
            txtTelefonePassageiro.TabIndex = 9;
            // 
            // btnAdicionarPassageiro
            // 
            btnAdicionarPassageiro.BackColor = Color.DarkGoldenrod;
            btnAdicionarPassageiro.FlatAppearance.BorderSize = 0;
            btnAdicionarPassageiro.FlatStyle = FlatStyle.Flat;
            btnAdicionarPassageiro.Location = new Point(19, 439);
            btnAdicionarPassageiro.Name = "btnAdicionarPassageiro";
            btnAdicionarPassageiro.Size = new Size(372, 57);
            btnAdicionarPassageiro.TabIndex = 82;
            btnAdicionarPassageiro.Text = "Adicionar Passageiro";
            btnAdicionarPassageiro.UseVisualStyleBackColor = false;
            // 
            // FormVenderBilhetes
            // 
            AutoScaleDimensions = new SizeF(13F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1508, 740);
            Controls.Add(groupBox1);
            Controls.Add(gridViewBilhetesAComprar);
            Controls.Add(btnConfirmar);
            Controls.Add(lblOrigemDestino);
            Controls.Add(lblNumeroVoo);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(comboBoxTipoLugar);
            Controls.Add(checkedListBoxLugares);
            Font = new Font("Gadugi", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "FormVenderBilhetes";
            Text = "FormVenderBilhetes";
            ((System.ComponentModel.ISupportInitialize)gridViewBilhetesAComprar).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox checkedListBoxLugares;
        private ComboBox comboBoxTipoLugar;
        private Label label1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblNumeroVoo;
        private Button button2;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblOrigemDestino;
        private Button btnConfirmar;
        private DataGridView gridViewBilhetesAComprar;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox txtNomePassageiro;
        private Label label3;
        private TextBox txtPassaportePassageiro;
        private Label label5;
        private TextBox txtTelefonePassageiro;
        private Label label4;
        private TextBox txtEmailPassageiro;
        private Button btnAdicionarPassageiro;
    }
}