/*
 * 작성자: 윤정도
 * 작성일: 2/26/2023 4:58:31 AM
 *
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using SGToolsCommon.Command;

namespace WpfApp1
{
    public class BtnCommand : Command   
    {
        ViewModel _viewModel;

        public BtnCommand(ViewModel viewModel) : base("BtnCommand", "버튼 클릭시 발생하는 이벤트")
        {
            _viewModel = viewModel;
        }

        public override void Execute(object? parameter)
        {
            Person? p = parameter as Person;

            if (p == null)
            {
                MessageBox.Show("이상한 펄슨입니다.");
                return;
            }

            _viewModel.SelectedPerson = p;
        }
    }
}
