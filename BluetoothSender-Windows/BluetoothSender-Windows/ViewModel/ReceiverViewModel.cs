using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace BluetoothSender_Windows.ViewModel
{
    public class ReceiverViewModel : ViewModelBase
    {
        private bool _bluetoothServiceIsActive;

        public bool BluetoothServiceActive
        {
            get => _bluetoothServiceIsActive;
            set
            {
                if (_bluetoothServiceIsActive != value)
                {
                    _bluetoothServiceIsActive = value;
                    if (value)
                    {
                        BluetoothServiceStart();
                    }
                    else
                    {
                        BluetoothServiceStop();
                    }
                    RaisePropertyChanged(nameof(BluetoothServiceActive));
                }
            }
        }

        public ReceiverViewModel()
        {
            //TODO
        }

        private void BluetoothServiceStart()
        {
            //TODO
        }

        private void BluetoothServiceStop()
        {
            //TODO
        }

    }
}
