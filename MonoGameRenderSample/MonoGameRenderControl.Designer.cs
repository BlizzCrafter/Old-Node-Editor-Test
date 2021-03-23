namespace MonoRenderSample
{
    partial class MonoGameRenderControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonoGameRenderControl));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripDropDownButtonDebug = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItemFPS = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemShowCursor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemShowCamPosition = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButtonAutoInvalidation = new System.Windows.Forms.ToolStripDropDownButton();
            this.testDraw1 = new MonoRenderSample.TestDraw();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButtonDebug,
            this.toolStripDropDownButtonAutoInvalidation});
            this.statusStrip1.Location = new System.Drawing.Point(0, 224);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(300, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripDropDownButtonDebug
            // 
            this.toolStripDropDownButtonDebug.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButtonDebug.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFPS,
            this.toolStripMenuItemShowCursor,
            this.toolStripMenuItemShowCamPosition});
            this.toolStripDropDownButtonDebug.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonDebug.Image")));
            this.toolStripDropDownButtonDebug.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonDebug.Name = "toolStripDropDownButtonDebug";
            this.toolStripDropDownButtonDebug.Size = new System.Drawing.Size(68, 24);
            this.toolStripDropDownButtonDebug.Text = "Debug";
            // 
            // toolStripMenuItemFPS
            // 
            this.toolStripMenuItemFPS.Checked = true;
            this.toolStripMenuItemFPS.CheckOnClick = true;
            this.toolStripMenuItemFPS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItemFPS.Name = "toolStripMenuItemFPS";
            this.toolStripMenuItemFPS.Size = new System.Drawing.Size(231, 26);
            this.toolStripMenuItemFPS.Text = "Show FPS";
            this.toolStripMenuItemFPS.CheckedChanged += new System.EventHandler(this.toolStripMenuItemFPS_CheckedChanged);
            // 
            // toolStripMenuItemShowCursor
            // 
            this.toolStripMenuItemShowCursor.Checked = true;
            this.toolStripMenuItemShowCursor.CheckOnClick = true;
            this.toolStripMenuItemShowCursor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItemShowCursor.Name = "toolStripMenuItemShowCursor";
            this.toolStripMenuItemShowCursor.Size = new System.Drawing.Size(231, 26);
            this.toolStripMenuItemShowCursor.Text = "Show Cursor Position";
            this.toolStripMenuItemShowCursor.CheckedChanged += new System.EventHandler(this.toolStripMenuItemShowCursor_CheckedChanged);
            // 
            // toolStripMenuItemShowCamPosition
            // 
            this.toolStripMenuItemShowCamPosition.CheckOnClick = true;
            this.toolStripMenuItemShowCamPosition.Name = "toolStripMenuItemShowCamPosition";
            this.toolStripMenuItemShowCamPosition.Size = new System.Drawing.Size(231, 26);
            this.toolStripMenuItemShowCamPosition.Text = "Show Camera Position";
            this.toolStripMenuItemShowCamPosition.CheckedChanged += new System.EventHandler(this.toolStripMenuItemShowCamPosition_CheckedChanged);
            // 
            // toolStripDropDownButtonAutoInvalidation
            // 
            this.toolStripDropDownButtonAutoInvalidation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButtonAutoInvalidation.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonAutoInvalidation.Image")));
            this.toolStripDropDownButtonAutoInvalidation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonAutoInvalidation.Name = "toolStripDropDownButtonAutoInvalidation";
            this.toolStripDropDownButtonAutoInvalidation.Size = new System.Drawing.Size(72, 24);
            this.toolStripDropDownButtonAutoInvalidation.Text = "Update";
            this.toolStripDropDownButtonAutoInvalidation.Click += new System.EventHandler(this.toolStripDropDownButtonAutoInvalidation_Click);
            // 
            // testDraw1
            // 
            this.testDraw1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.testDraw1.Location = new System.Drawing.Point(0, 0);
            this.testDraw1.Name = "testDraw1";
            this.testDraw1.Size = new System.Drawing.Size(300, 250);
            this.testDraw1.TabIndex = 0;
            this.testDraw1.Text = "testDraw1";
            // 
            // MonoRenderControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.testDraw1);
            this.Name = "MonoRenderControl";
            this.Size = new System.Drawing.Size(300, 250);
            this.Load += new System.EventHandler(this.MonoRenderControl_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TestDraw testDraw1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonDebug;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFPS;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemShowCursor;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemShowCamPosition;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonAutoInvalidation;
    }
}
