/*
 * 작성자: 윤정도
 * 작성일: 2/26/2023 4:54:42 AM
 *
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using SGToolsCommon;
using SGToolsCommon.Command;

namespace WpfApp1
{
    public class ViewModel : Bindable
    {
        private Person _selectedPerson;
        private ObservableCollection<Person> _personList;

        public Person SelectedPerson
        {
            get => _selectedPerson;
            set
            {
                _selectedPerson = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<Person> PersonList
        {
            get => _personList;
            set
            {
                _personList = value;
                OnPropertyChanged();
            }

        }
        public TestCommandCenter Commander { get; }

        public ViewModel()
        {
            _personList = new();
            _personList.Add(new Person()
            {
                FirstName = "A", LastName = "_A", ForegroundColor = Brushes.Red.Color
            });
            _personList.Add(new Person()
            {
                FirstName = "B", LastName = "_B", ForegroundColor = Brushes.DarkRed.Color
            });

            _personList.Add(new Person()
            {
                FirstName = "C",
                LastName = "_C",
                ForegroundColor = Brushes.Aquamarine.Color
            });

            _personList.Add(new Person()
            {
                FirstName = "D",
                LastName = "_D",
                ForegroundColor = Brushes.BurlyWood.Color
            });

            _selectedPerson = _personList[0];
            Commander = new TestCommandCenter(this);
        }
    }
}
