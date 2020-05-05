using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TestFormValidation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public delegate bool AllFieldsValidatorDelegate();

        public MainWindow()
        {
            InitializeComponent();
        }



        public AllFieldsValidatorDelegate AllFieldsValidator
        {
            get { return (AllFieldsValidatorDelegate)GetValue(AllFieldsValidatorProperty); }
            set { SetValue(AllFieldsValidatorProperty, value); }
        }

        // Using a DependencyProperty as the backing store for AllFieldsValidator.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty AllFieldsValidatorProperty =
            DependencyProperty.Register("AllFieldsValidator", typeof(AllFieldsValidatorDelegate), typeof(MainWindow), 
                new PropertyMetadata(null, AllFieldsValidator_PropertyChanged));

        private static void AllFieldsValidator_PropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d == null)
                return;
            return
        }

        private bool IsValid(DependencyObject obj)
        {
            // The dependency object is valid if it has no errors and all
            // of its children (that are dependency objects) are error-free.
            return !Validation.GetHasError(obj) &&
            LogicalTreeHelper.GetChildren(obj)
            .OfType<DependencyObject>()
            .All(IsValid);
        }
    }
}
