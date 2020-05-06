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
    /// Interaction logic for UserControlView.xaml
    /// </summary>
    public partial class UserControlView : UserControl
    {
        public UserControlViewModel VM { get; set; }
        public UserControlView(UserControlViewModel vm)
        {
            VM = vm;
            InitializeComponent();
        }
    }
}
