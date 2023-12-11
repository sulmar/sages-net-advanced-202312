using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp.ViewModels;

internal partial class CustomersViewModel
{
    public ICommand SendCommand { get; set; }
    public ICommand PrintCommand { get; set; }
}
