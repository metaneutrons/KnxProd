using System.ComponentModel;
using System.Xml.Serialization;

namespace KnxProd.Model
{
    public partial class ParameterRef_T : INotifyPropertyChanged
    {
        [XmlIgnore]
        public Parameter_T Parameter { get; set; }
    }
}
