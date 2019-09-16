using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Xml.Serialization;

namespace KnxProd.Model
{
    public partial class Parameter_T : INotifyPropertyChanged
    {
        [XmlIgnore]
        public ParameterType_T Type { get; set; }

        [XmlIgnore]
        public ObservableCollection<ParameterType_T> AllTypes { get; set; }
    }
}
