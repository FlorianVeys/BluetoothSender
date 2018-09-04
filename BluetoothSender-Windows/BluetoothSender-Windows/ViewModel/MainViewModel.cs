using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;

namespace BluetoothSender_Windows.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public ICommand CloseApplication { get; }
        public ICommand MinimizeApplication { get; }
        public ICommand MenuControl { get; }

        public bool VisibilityHistory { get; set; }
        public bool VisibilityEmitter { get; set; }
        public bool VisibilityReceiver { get; set; }

        public MainViewModel()
        {
            CloseApplication = new RelayCommand(CloseAppli);
            MinimizeApplication = new RelayCommand(MinimizeAppli);
            MenuControl = new RelayCommand<string>(changeView);
            DisplayEmitterView();
        }

        private void changeView(string parameter)
        {
            switch (parameter)
            {
                case "History":
                    DisplayHistoryView();
                    break;
                case "Emitter":
                    DisplayEmitterView();
                    break;
                case "Receiver":
                    DisplayReceiverView();
                    break;
            }
        }

        private void DisplayHistoryView()
        {
            VisibilityEmitter = false;
            VisibilityReceiver = false;
            VisibilityHistory = true;
        }

        private void DisplayEmitterView()
        {
            VisibilityEmitter = true;
            VisibilityReceiver = false;
            VisibilityHistory = false;
        }

        private void DisplayReceiverView()
        {
            VisibilityEmitter = false;
            VisibilityReceiver = true;
            VisibilityHistory = false;

        }

        private void CloseAppli()
        {
            App.Current.Shutdown();
        }

        private void MinimizeAppli()
        {
            App.Current.MainWindow.WindowState = WindowState.Minimized;
        }
    }
}