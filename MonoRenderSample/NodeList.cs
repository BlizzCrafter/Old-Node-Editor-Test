using NodeEditor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace MonoRenderSample
{
    [Serializable]
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class NodeList<T>
    {
        [DisplayName("Input")]
        public List<T> SetList { get; set; }

        public override string ToString()
        {
            return "List";
        }

        public NodeList(params T[] nodeType)
        {
            if (SetList == null) SetList = new List<T>();

            foreach (T node in nodeType) SetList.Add(node);
        }
    }
}