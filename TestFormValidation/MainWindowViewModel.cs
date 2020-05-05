using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Data;

namespace TestFormValidation
{
    public class MainWindowViewModel : ViewModelBase
    {
        private bool _canSave; public bool CanSave { get => _canSave; set { Set(() => CanSave, ref _canSave, value); }}
        private double _dvalue; public double Dvalue { get => _dvalue; set { Set(() => Dvalue, ref _dvalue, value); }}
        private string _svalue; public string Svalue { get => _svalue; set { Set(() => Svalue, ref _svalue, value); }}

        private RelayCommand _saveCmd;
        public RelayCommand SaveCmd => _saveCmd ?? (_saveCmd = new RelayCommand(
            () => saveCmdExecuted(),
            () => saveCmdCanExecute()
            ));

        private void saveCmdExecuted()
        {
            MessageBox.Show("Saved!");
        }

        private bool  saveCmdCanExecute()
        {
            BindingOperations.GetSourceUpdatingBindings()
            return true;
        }
    }
}
