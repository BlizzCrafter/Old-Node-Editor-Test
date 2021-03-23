using System.Windows.Forms;
using NodeEditor;
using MonoGame.Forms;
using Microsoft.Xna.Framework;

namespace MonoRenderSample
{
    public partial class MonoGameRenderControl : UserControl
    {
        public MonoGameRenderControl()
        {
            InitializeComponent();

            testDraw1.UpdateNodeContext = UpdateNodeContext;
        }

        private void UpdateNodeContext()
        {
            var node = (Tag as NodeVisual);
            if (node != null)
            {
                dynamic context = node.GetNodeContext();

                if (!string.IsNullOrEmpty(context.Text.SetText)) testDraw1.TestString = context.Text.SetText;
                if (context.Speed != null) testDraw1.SinSpeed = context.Speed.SetVector2;
                if (context.Range != null) testDraw1.SinRange = context.Range.SetVector2;
                if (context.BackColor != null && context.BackColor.ToVector4() != Vector4.Zero) testDraw1.BackGroundColor = context.BackColor;
                else testDraw1.BackGroundColor = testDraw1.DefaultBackGroundColor;
            }
        }

        private void toolStripMenuItemFPS_CheckedChanged(object sender, System.EventArgs e)
        {
            testDraw1.Editor.ShowFPS = toolStripMenuItemFPS.Checked;
        }

        private void toolStripMenuItemShowCursor_CheckedChanged(object sender, System.EventArgs e)
        {
            testDraw1.Editor.ShowCursorPosition = toolStripMenuItemShowCursor.Checked;
        }

        private void toolStripMenuItemShowCamPosition_CheckedChanged(object sender, System.EventArgs e)
        {
            testDraw1.Editor.ShowCamPosition = toolStripMenuItemShowCamPosition.Checked;
        }

        private void MonoRenderControl_Load(object sender, System.EventArgs e)
        {
            toolStripMenuItemFPS.Checked = testDraw1.Editor.ShowFPS;
            toolStripMenuItemShowCursor.Checked = testDraw1.Editor.ShowCursorPosition;
            toolStripMenuItemShowCamPosition.Checked = testDraw1.Editor.ShowCamPosition;
        }

        private void toolStripDropDownButtonAutoInvalidation_Click(object sender, System.EventArgs e)
        {
        }
    }
}
