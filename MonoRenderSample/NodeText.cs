using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace MonoRenderSample
{
    [Serializable]
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class NodeText : ISerializable
    {
        [DisplayName("Input")]
        public string SetText { get; set; }

        public override string ToString()
        {
            return "String";
        }

        public NodeText()
        {
        }

        private NodeText(SerializationInfo info, StreamingContext ctx)
        {
            SetText = info.GetString("NodeText");
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("NodeText", SetText);
        }
    }
}
