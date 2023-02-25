/*
 * 작성자: 윤정도
 * 작성일: 2/26/2023 4:55:15 AM
 *
 */

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
using SGToolsCommon.Command;

namespace WpfApp1
{
    public class TestCommandCenter : CommandCenter
    {
        public Command BtnCommand { get; }

        public TestCommandCenter(ViewModel vm)
        {
            Add(BtnCommand = new BtnCommand(vm));
        }
    }
}
