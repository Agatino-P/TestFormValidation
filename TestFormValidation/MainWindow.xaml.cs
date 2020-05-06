using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace TestFormValidation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {



        public TestViewModel TestVM
        {
            get { return (TestViewModel)GetValue(TestVMProperty); }
            set { SetValue(TestVMProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ViewModel.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TestVMProperty =
            DependencyProperty.Register("TestVM", typeof(TestViewModel), typeof(MainWindow), new PropertyMetadata(null));


        public MainWindow()
        {
            InitializeComponent();
            
            TestVM = new TestViewModel(6);
            TestVM.VMString = "TestVM String";
            TestVM.VMDouble = 111;
            MainContent.Content = TestVM;
 

        }

        private void DockPanel_Error(object sender, ValidationErrorEventArgs e)
        {
            MessageBox.Show("Basta errori!");
        }

        /*
            public delegate bool AllFieldsValidatorDelegate();
                public string TestLabel
                {
                    get { return (string)GetValue(TestLabelProperty); }
                    set { SetValue(TestLabelProperty, value); }
                }
                public static readonly DependencyProperty TestLabelProperty =
                    DependencyProperty.Register("TestLabel", typeof(string), typeof(MainWindow), new PropertyMetadata(null));


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
                    //if (d == null)
                    //    return;
                    //return
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
                */
    }

}
