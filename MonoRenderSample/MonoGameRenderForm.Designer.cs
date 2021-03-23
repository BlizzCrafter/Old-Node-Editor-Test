namespace MonoRenderSample
{
    partial class MonoGameRenderForm
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

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.controlNodeEditor = new SampleCommon.ControlNodeEditor();
            this.SuspendLayout();
            // 
            // controlNodeEditor
            // 
            this.controlNodeEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlNodeEditor.Location = new System.Drawing.Point(0, 0);
            this.controlNodeEditor.Margin = new System.Windows.Forms.Padding(4);
            this.controlNodeEditor.Name = "controlNodeEditor";
            this.controlNodeEditor.Size = new System.Drawing.Size(1396, 578);
            this.controlNodeEditor.TabIndex = 0;
            // 
            // MonoGameRenderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1396, 578);
            this.Controls.Add(this.controlNodeEditor);
            this.Name = "MonoGameRenderForm";
            this.Text = "Mono Render Sample";
            this.Load += new System.EventHandler(this.MonoRenderSample_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private SampleCommon.ControlNodeEditor controlNodeEditor;
    }
}

