using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomObjectTest
{
    public partial class Form1 : Form
    {
        CustomObjectContext context = new CustomObjectContext();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Context assignment
            controlNodeEditor.nodesControl.Context = context;
            controlNodeEditor.nodesControl.OnNodeContextSelected += NodesControl_OnNodeContextSelected;
        }

        private void NodesControl_OnNodeContextSelected(object obj)
        {
            controlNodeEditor.propertyGrid.SelectedObject = obj;
        }
    }
}
