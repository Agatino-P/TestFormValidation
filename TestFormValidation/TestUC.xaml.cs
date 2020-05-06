using System.Windows;
using System.Windows.Controls;

namespace TestFormValidation
{
    /// <summary>
    /// Interaction logic for TestUC.xaml
    /// </summary>
    public partial class TestUC : UserControl
    {

        public double UCDouble
        {
            get { return (double)GetValue(UCDoubleProperty); }
            set { SetValue(UCDoubleProperty, value); }
        }
        public static readonly DependencyProperty UCDoubleProperty =
            DependencyProperty.Register("UCDouble", typeof(double), typeof(TestUC), new PropertyMetadata(0d));


        public string UCString
        {
            get { return (string)GetValue(UCStringProperty); }
            set { SetValue(UCStringProperty, value); }
        }

        // Using a DependencyProperty as the backing store for UCString.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty UCStringProperty =
            DependencyProperty.Register("UCString", typeof(string), typeof(TestUC), new PropertyMetadata(null));



        public TestUC()
        {
            InitializeComponent();
        }

    }


}
