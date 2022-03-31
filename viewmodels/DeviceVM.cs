using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4.viewmodels
{
    class DeviceVM
    {
        public string ImageSource { get; }
        public string Description {get; }
        public DeviceVM(string imageSource, string description)
        {
            ImageSource = imageSource;
            Description = description;

        }
    }
}
