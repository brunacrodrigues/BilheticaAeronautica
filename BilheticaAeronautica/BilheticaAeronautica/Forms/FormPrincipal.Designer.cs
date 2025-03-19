namespace BilheticaAeronautica
{
    partial class FormPrincipal
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
            btnVoos = new Button();
            btnAvioes = new Button();
            btnDestinos = new Button();
            btnBilhetes = new Button();
            SuspendLayout();
            // 
            // btnVoos
            // 
            btnVoos.BackColor = Color.DarkGoldenrod;
            btnVoos.FlatAppearance.BorderSize = 0;
            btnVoos.FlatStyle = FlatStyle.Flat;
            btnVoos.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoos.ForeColor = Color.White;
            btnVoos.Location = new Point(124, 103);
            btnVoos.Name = "btnVoos";
            btnVoos.Size = new Size(143, 64);
            btnVoos.TabIndex = 0;
            btnVoos.Text = "Voos";
            btnVoos.UseVisualStyleBackColor = false;
            btnVoos.Click += btnVoos_Click;
            // 
            // btnAvioes
            // 
            btnAvioes.BackColor = Color.DarkGoldenrod;
            btnAvioes.FlatAppearance.BorderSize = 0;
            btnAvioes.FlatStyle = FlatStyle.Flat;
            btnAvioes.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAvioes.ForeColor = Color.White;
            btnAvioes.Location = new Point(124, 201);
            btnAvioes.Name = "btnAvioes";
            btnAvioes.Size = new Size(143, 64);
            btnAvioes.TabIndex = 1;
            btnAvioes.Text = "Aviões";
            btnAvioes.UseVisualStyleBackColor = false;
            btnAvioes.Click += btnAvioes_Click;
            // 
            // btnDestinos
            // 
            btnDestinos.BackColor = Color.DarkGoldenrod;
            btnDestinos.FlatAppearance.BorderSize = 0;
            btnDestinos.FlatStyle = FlatStyle.Flat;
            btnDestinos.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDestinos.ForeColor = Color.White;
            btnDestinos.Location = new Point(124, 301);
            btnDestinos.Name = "btnDestinos";
            btnDestinos.Size = new Size(143, 64);
            btnDestinos.TabIndex = 2;
            btnDestinos.Text = "Destinos";
            btnDestinos.UseVisualStyleBackColor = false;
            btnDestinos.Click += btnDestinos_Click;
            // 
            // btnBilhetes
            // 
            btnBilhetes.BackColor = Color.DarkGoldenrod;
            btnBilhetes.FlatAppearance.BorderSize = 0;
            btnBilhetes.FlatStyle = FlatStyle.Flat;
            btnBilhetes.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBilhetes.ForeColor = Color.White;
            btnBilhetes.Location = new Point(124, 402);
            btnBilhetes.Name = "btnBilhetes";
            btnBilhetes.Size = new Size(143, 64);
            btnBilhetes.TabIndex = 3;
            btnBilhetes.Text = "Bilhetes";
            btnBilhetes.UseVisualStyleBackColor = false;
            btnBilhetes.Click += btnBilhetes_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1125, 774);
            Controls.Add(btnBilhetes);
            Controls.Add(btnDestinos);
            Controls.Add(btnAvioes);
            Controls.Add(btnVoos);
            Name = "FormPrincipal";
            Text = "FormPrincipal";
            FormClosing += FormPrincipal_FormClosing;
            Load += FormPrincipal_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnVoos;
        private Button btnAvioes;
        private Button btnDestinos;
        private Button btnBilhetes;
    }
}