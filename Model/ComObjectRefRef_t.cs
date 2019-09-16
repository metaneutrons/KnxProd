using System.ComponentModel;
using System.Xml.Serialization;

namespace KnxProd.Model
{
    public partial class ComObjectRefRef_T : INotifyPropertyChanged
    {
        [XmlIgnore]
        public ComObjectRef_T ComObjectRef { get; set; }
    }
}
