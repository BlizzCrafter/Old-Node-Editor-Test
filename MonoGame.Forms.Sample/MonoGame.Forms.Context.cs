using System;
using NodeEditor;

namespace MonoGame.Forms.Sample
{
    public class MonoGame : INodesContext
    {
        public NodeVisual CurrentProcessingNode { get; set; }
        public event Action<string, NodeVisual, FeedbackType, object, bool> FeedbackInfo;

        [Node("Test", "Helper", "Basic", "Shows input value in the message box.")]
        public void Test(float newValue, out float result)
        {
            result = newValue;
        }

        [Node("Starter", "Helper", "Basic", "Starts execution", true, true)]
        public void Starter()
        {

        }
    }
}
