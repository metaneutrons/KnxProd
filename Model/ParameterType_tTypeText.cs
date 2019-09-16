using System.ComponentModel;
using System.Xml.Serialization;

namespace KnxProd.Model
{
    public partial class ParameterType_TTypeText : INotifyPropertyChanged, IGetByteSize
    {
        [XmlIgnore]
        public uint SizeInByte
        {
            get
            {
                uint size = SizeInBit / 8;
                if (SizeInBit % 8 != 0)
                    size += 1;

                return size;
            }

            set
            {
                SizeInBit = value * 8;
                OnPropertyChanged(nameof(SizeInByte));
            }
        }
    }
}
