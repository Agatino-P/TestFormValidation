using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestFormValidation
{
    public class TestViewModel : ViewModelBase
    {
        private string _VMString; public string VMString { get => _VMString; set { Set(() => VMString, ref _VMString, value); }}
        private double _VMDouble; public double VMDouble { get => _VMDouble; set { Set(() => VMDouble, ref _VMDouble, value); }}

        


        public TestViewModel(double vmDouble = -1, string vmString= "empty string")
        {
            VMString = vmString;
            VMDouble = vmDouble;
        }

    }
}
