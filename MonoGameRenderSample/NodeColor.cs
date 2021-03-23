using Microsoft.Xna.Framework;
using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace MonoRenderSample
{
    [Serializable]
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class NodeColor : ISerializable
    {
        [DisplayName("Input")]
        public Color SetColor { get; set; }
        
        public override string ToString()
        {
            return "Color";
        }

        public Vector4 ToVector4()
        {
            return SetColor.ToVector4();
        }

        public NodeColor() { }

        public NodeColor(byte R, byte G, byte B, byte A)
        {
            SetColor = new Color(R, G, B, A);
        }

        private NodeColor(SerializationInfo info, StreamingContext ctx)
        {
            var R = info.GetByte("R");
            var G = info.GetByte("G");
            var B = info.GetByte("B");
            var A = info.GetByte("A");

            SetColor = new Color(R, G, B, A);
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("R", SetColor.R);
            info.AddValue("G", SetColor.G);
            info.AddValue("B", SetColor.B);
            info.AddValue("A", SetColor.A);
        }
    }
}
