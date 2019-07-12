using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace WpfApp1
{
    public class ValidatedTextBox : TextBox
    {

        public ValidatedTextBox()
        {

        }

        public bool IsSpaceAllowed { get; set; }

        //public bool IsSpaceAllowed
        //{
        //    get { return (bool)GetValue(IsSpaceAllowedProperty); }
        //    set { SetValue(IsSpaceAllowedProperty, value); }
        //}

        //// Using a DependencyProperty as the backing store for IsSpaceAllowed.  This enables animation, styling, binding, etc...
        //public static readonly DependencyProperty IsSpaceAllowedProperty =
        //    DependencyProperty.Register("IsSpaceAllowed", typeof(bool), typeof(ValidatedTextBox));

        protected override void OnPreviewKeyDown(KeyEventArgs e)
        {
            base.OnPreviewKeyDown(e);
            if (!IsSpaceAllowed && (e.Key == Key.Space))
            {
                e.Handled = true;
            }
        }

        


    }
}
