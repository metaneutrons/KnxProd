using System.ComponentModel;
using System.Xml.Serialization;

namespace KnxProd.Model
{
    public partial class ParameterType_TTypeFloat : INotifyPropertyChanged, IGetByteSize
    {
        [XmlIgnore]
        public uint SizeInByte => 4; // only float for now
    }
}
