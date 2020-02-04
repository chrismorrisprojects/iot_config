using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace iot_configuration_manager.ViewModel
{
    public class MainVm : ViewModelBase
    {
        public MainVm()
        {
            RCellVm = new RCellVm(this);

            OnClickLoadIpCsv = new RelayCommand(loadInputCsvAsync, () => true);
            OnClickSetOutputCsv = new RelayCommand(setOutputCsv, () => true);
        }

        public RCellVm RCellVm { get; set; }

        public RelayCommand OnClickLoadIpCsv { get; set; }
        public RelayCommand OnClickSetOutputCsv { get; set; }

        public int SelectedTabIndex { get; set; } = 0;

        private string inputCsvPath = "Path to Input CSV";
        public string InputCsvPath
        {
            get { return inputCsvPath; }
            set
            {
                if (inputCsvPath != value)
                {
                    inputCsvPath = value;
                    RaisePropertyChanged();
                }
            }
        }

        private string outputCsvPath = "Path to Output CSV";
        public string OutputCsvPath
        {
            get { return outputCsvPath; }
            set
            {
                if (outputCsvPath != value)
                {
                    outputCsvPath = value;
                    RaisePropertyChanged();
                }
            }
        }

        private bool? isRebootModemSelected;
        public bool IsRebootModemSelected
        {
            get { return isRebootModemSelected ?? false; }
            set
            {
                if (value != isRebootModemSelected)
                {
                    isRebootModemSelected = value;
                    RaisePropertyChanged();
                }
            }
        }

        private int rebootModemSeconds = 60;
        public string RebootModemSeconds
        {
            get { return rebootModemSeconds.ToString(); }
            set
            {
                int parsedVal;
                if (int.TryParse(value, out parsedVal) && rebootModemSeconds != parsedVal)
                {
                    rebootModemSeconds = parsedVal;
                    RaisePropertyChanged();
                }
            }
        }

        private string username = "Username";
        public string Username
        {
            get { return username; }
            set
            {
                if (username != value)
                {
                    username = value;
                    RaisePropertyChanged();
                }
            }
        }

        private string password = "Password";
        public string Password
        {
            get { return password; }
            set
            {
                if (password != value)
                {
                    password = value;
                    RaisePropertyChanged();
                }
            }
        }

        private int timeoutSeconds = 60;
        public string TimeoutSeconds
        {
            get { return timeoutSeconds.ToString(); }
            set
            {
                int parsedVal;
                if (int.TryParse(value, out parsedVal) && timeoutSeconds != parsedVal)
                {
                    timeoutSeconds = parsedVal;
                    RaisePropertyChanged();
                }
            }
        }

        private int attemptsLimit = 60;
        public string AttemptsLimit
        {
            get { return attemptsLimit.ToString(); }
            set
            {
                int parsedVal;
                if (int.TryParse(value, out parsedVal) && attemptsLimit != parsedVal)
                {
                    attemptsLimit = parsedVal;
                    RaisePropertyChanged();
                }
            }
        }

        private static async void loadInputCsvAsync()
        {
            try
            {
                await Task.Run(() =>
                {
                    Console.WriteLine(@"Load Input Csv Clicked.");
                    Thread.Sleep(2000);
                    Console.WriteLine(@"Load Input Csv Clicked: async demonstrated.");
                });
            }
            catch (Exception)
            {
                throw;
            }
        }

        private static async void setOutputCsv()
        {
            try
            {
                await Task.Run(() =>
                {
                    Console.WriteLine(@"Set Output Csv Clicked.");
                    Thread.Sleep(2000);
                    Console.WriteLine(@"Set Output Csv Clicked: async demonstrated.");
                });
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
