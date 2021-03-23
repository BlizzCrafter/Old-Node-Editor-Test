using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NodeEditor;

namespace MathSample
{
    public partial class NodeButton : UserControl
    {
        public float test = 0f;

        public NodeButton()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var node = (Tag as NodeVisual);
            dynamic context = node.GetNodeContext();

            test += context.newValue;

            MessageBox.Show(test.ToString());
        }
    }
}
