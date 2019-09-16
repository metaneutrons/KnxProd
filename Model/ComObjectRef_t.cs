using System.ComponentModel;
using System.Xml.Serialization;

namespace KnxProd.Model
{
    public partial class ComObjectRef_T : INotifyPropertyChanged
    {
        [XmlIgnore]
        public ComObject_T ComObject { get; set; }
    }
}
