using System.ComponentModel;
using System.Xml.Serialization;

namespace KnxProd.Model
{
    public partial class ParameterRefRef_T : INotifyPropertyChanged
    {
        [XmlIgnore]
        public ParameterRef_T ParameterRef { get; set; }
    }
}
