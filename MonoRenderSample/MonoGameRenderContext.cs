using Microsoft.Xna.Framework;
using NodeEditor;
using System;
using System.Collections.Generic;

namespace MonoRenderSample
{
    public class MonoGameRenderContext : INodesContext
    {
        public NodeVisual CurrentProcessingNode { get; set; }
        public event Action<string, NodeVisual, FeedbackType, object, bool> FeedbackInfo;
        
        [Node("Add", "Operators", "Basic", "Adds two input values.", false)]
        public void Add(float a, float b, out float result)
        {
            result = a + b;
        }

        [Node("Substract", "Operators", "Basic", "Substracts two input values.", false)]
        public void Substract(float a, float b, out float result)
        {
            result = a - b;
        }

        [Node("Multiply", "Operators", "Basic", "Multiplies two input values.", false)]
        public void Multiplty(float a, float b, out float result)
        {
            result = a * b;
        }

        [Node("Divide", "Operators", "Basic", "Divides two input values.", false)]
        public void Divid(float a, float b, out float result)
        {
            result = a / b;
        }

        [Node("Color", "Input", "Basic", "Adds two input values.", false)]
        public void Color(byte R, byte G, byte B, byte A, out NodeColor outColor)
        {
            outColor = new NodeColor(R, G, B, A);
        }

        [Node("Vector2", "Input", "Basic", "Adds two input values.", false)]
        public void Vector2(float X, float Y, out NodeVector2 outVector2)
        {
            outVector2 = new NodeVector2(X, Y);
        }

        [Node("Text", "Input", "Basic", "Allows to output a simple value.", false)]
        public void Text(NodeText Text, out NodeText outText)
        {
            outText = Text;
        }

        [Node("List", "Input", "Basic", "Allows to output a simple value.", true)]
        public void InList(NodeVector2 Vector2, out NodeList<NodeVector2> outList)
        {
            outList = new NodeList<NodeVector2>(Vector2);
        }

        [Node("InList", "Input", "Basic", "Allows to output a simple value.", true)]
        public void InList(NodeList<NodeVector2> List)
        {
        }

        //Custom Editor
        [Node("Render Control", "GFX", "Basic", "Shows input value in the message box.", customEditor: typeof(MonoGameRenderControl))]
        public void CustomEditorTest(NodeText Text, NodeVector2 Speed, NodeVector2 Range, NodeColor BackColor)
        {
        }

        [Node("Starter", "Helper", "Basic", "Starts execution", true, true)]
        public void Starter()
        {

        }
    }
}
