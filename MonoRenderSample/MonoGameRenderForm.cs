using NodeEditor;
using System.IO;
using System.Windows.Forms;

namespace MonoRenderSample
{
    public partial class MonoGameRenderForm : Form
    {
        MonoGameRenderContext context = new MonoGameRenderContext();

        public MonoGameRenderForm()
        {
            InitializeComponent();

            FormClosing += MonoRenderForm_FormClosing;
        }

        private void MonoRenderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            byte[] bytes = controlNodeEditor.nodesControl.Serialize();

            using (var file = new FileStream(Path.Combine(Application.StartupPath, "NodeGraph.txt"), FileMode.Create, FileAccess.Write))
            {
                file.Write(bytes, 0, bytes.Length);
            }
        }

        private void MonoRenderSample_Load(object sender, System.EventArgs e)
        {
            controlNodeEditor.nodesControl.Context = context;
            controlNodeEditor.nodesControl.OnNodeContextSelected += NodesControl_OnNodeContextSelected;
            controlNodeEditor.propertyGrid.PropertyValueChanged += PropertyGrid_PropertyValueChanged;

            if (File.Exists(Path.Combine(Application.StartupPath, "NodeGraph.txt")))
            {
                byte[] loadedBytes = File.ReadAllBytes(Path.Combine(Application.StartupPath, "NodeGraph.txt"));
                controlNodeEditor.nodesControl.Deserialize(loadedBytes);
            }
        }

        private void PropertyGrid_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            controlNodeEditor.nodesControl.Execute();
            controlNodeEditor.propertyGrid.Refresh();
        }

        private void NodesControl_OnNodeContextSelected(object obj)
        {
            controlNodeEditor.propertyGrid.SelectedObject = obj;
            controlNodeEditor.propertyGrid.ExpandAllGridItems();

            //var selectedNodes = controlNodeEditor.nodesControl.GetSelectedNodes();
            //foreach (NodeVisual node in selectedNodes)
            //{
            //    controlNodeEditor.nodesControl.ExecuteResolving(node.Name);
            //}            
        }
    }
}
