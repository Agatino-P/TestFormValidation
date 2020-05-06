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

        private TestViewModel _containedTestViewModel;
            public TestViewModel ContainedTestViewModel { get => _containedTestViewModel; set { Set(() => ContainedTestViewModel, ref _containedTestViewModel, value); }}
        
        //TestViewModel ContainedTestViewModel

        public MainWindowViewModel()
        {
            Dvalue = 2;
            Svalue = "2";
            ContainedTestViewModel = new TestViewModel(11, "ContainedTestViewModel");

        }
        private void saveCmdExecuted()
        {
            MessageBox.Show(Dvalue.ToString(), "MainWindowViewModel Property");
            MessageBox.Show(ContainedTestViewModel.VMDouble.ToString(), "MainWindowViewModel Property");
        }

        private bool  saveCmdCanExecute()
        {
            //BindingOperations.GetSourceUpdatingBindings();
            return true;
        }
    }
}
