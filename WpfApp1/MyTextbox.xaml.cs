using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MyTextbox.xaml
    /// </summary>
    public partial class MyTextbox : UserControl
    {
        public MyTextbox()
        {
            InitializeComponent();
        }

        private string _myText;

        public string MyText
        {
            get { return _myText; }
            set
            {
                _myText = value;
                if (value == "1")
                {
                    txtName.Background = Brushes.LightYellow;
                }
                else
                {
                    txtName.Background = Brushes.LightBlue;
                }
                
            }
        }



    }
}
