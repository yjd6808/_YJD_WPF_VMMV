/*
 * 작성자: 윤정도
 * 작성일: 2/26/2023 7:11:20 AM
 *
 */

using SGToolsCommon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public class Person : Bindable
    {
        private Color _foregroundColor;
        private string _firstName;
        private string _lastName;

        [Category("Information")]
        [DisplayName("First Name")]
        [Description("This property uses a TextBox as the default editor.")]
        public string FirstName
        {
            get => _firstName;
            set
            {
                _firstName = value;
                OnPropertyChanged();
            }
        }

        [Category("Information")]
        [DisplayName("Last Name")]
        [Description("dd")]
        public string LastName
        {
            get => _lastName;
            set
            {
                _lastName = value;
                OnPropertyChanged();
            }
        }

        [Category("Information")]
        [DisplayName("Last Name")]
        [Description("dd")]
        public Color ForegroundColor
        {
            get => _foregroundColor;
            set
            {
                _foregroundColor = value;
                OnPropertyChanged();
            }
        }

    }
}
