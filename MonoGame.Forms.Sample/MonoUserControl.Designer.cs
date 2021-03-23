namespace MonoGame.Forms.Sample
{
    partial class MonoUserControl
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.testDraw1 = new TestDraw();
            this.SuspendLayout();
            // 
            // testDraw1
            // 
            this.testDraw1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.testDraw1.Location = new System.Drawing.Point(0, 0);
            this.testDraw1.Name = "testDraw1";
            this.testDraw1.Size = new System.Drawing.Size(324, 212);
            this.testDraw1.TabIndex = 0;
            this.testDraw1.Text = "testDraw1";
            // 
            // MonoUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.testDraw1);
            this.Name = "MonoUserControl";
            this.Size = new System.Drawing.Size(324, 212);
            this.ResumeLayout(false);

        }

        #endregion

        private TestDraw testDraw1;
    }
}
