using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;

namespace BluetoothSender_Windows.ViewModel
{
    public class EmitterViewModel : ViewModelBase
    {
        public ICommand RefreshDevicesList { get; }

        public EmitterViewModel()
        {
            RefreshDevicesList = new RelayCommand(RefreshList);
        }

        private void RefreshList()
        {
            //TODO
        }
    }
}
