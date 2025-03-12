namespace BilheticaAeronautica
{
    partial class CriarAviao
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
            ((System.ComponentModel.ISupportInitialize)borderLayout1).BeginInit();
            SuspendLayout();
            // 
            // borderLayout1
            // 
            borderLayout1.HGap = 0;
            borderLayout1.VGap = 0;
            // 
            // CriarAviao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1231, 748);
            Name = "CriarAviao";
            Text = "CriarAviao";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)borderLayout1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.BorderLayout borderLayout1;
    }
}