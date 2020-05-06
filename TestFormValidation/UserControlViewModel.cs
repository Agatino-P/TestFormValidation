using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestFormValidation 
{
    public class UserControlViewModel : ViewModelBase
    {

        private double _ucDouble; public double UCDouble { get => _ucDouble; set { Set(() => UCDouble, ref _ucDouble, value); }}

        public UserControlViewModel()
        {
            UCDouble = 1;
        }

    }
}
