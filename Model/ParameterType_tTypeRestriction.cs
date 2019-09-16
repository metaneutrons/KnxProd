using System.ComponentModel;
using System.Xml.Serialization;

namespace KnxProd.Model
{
    public partial class ParameterType_TTypeRestriction : INotifyPropertyChanged, IGetByteSize
    {
        [XmlIgnore]
        public uint SizeInByte
        {
            get
            {
                return 1; // should be enough
            }
        }
    }
}
