using Microsoft.Xna.Framework;
using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace MonoRenderSample
{
    [Serializable]
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class NodeVector2 : ISerializable
    {
        [DisplayName("Input")]
        public Vector2 SetVector2 { get; set; }

        public override string ToString()
        {
            return "Vector2";
        }

        public NodeVector2() { }

        public NodeVector2(float X, float Y)
        {
            SetVector2 = new Vector2(X, Y);
        }

        private NodeVector2(SerializationInfo info, StreamingContext ctx)
        {
            var X = info.GetSingle("X");
            var Y = info.GetSingle("Y");

            SetVector2 = new Vector2(X, Y);
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("X", SetVector2.X);
            info.AddValue("Y", SetVector2.Y);
        }
    }
}
