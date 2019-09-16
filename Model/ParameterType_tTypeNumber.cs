using System.ComponentModel;
using System.Xml.Serialization;

namespace KnxProd.Model
{
    public partial class ParameterType_TTypeNumber : INotifyPropertyChanged, IGetByteSize
    {
        [XmlIgnore]
        public uint SizeInByte
        {
            get
            {
                return 4;
            }
        }
    }
}
