using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace iot_configuration_manager.ViewModel
{
    public class RCellVm : DeviceTabBase
    {
        public RCellVm(MainVm mainVm)
        {
            Main = mainVm;

            OnClickTempButton = new RelayCommand(testTempButton);
        }

        public RelayCommand OnClickTempButton { get; set; }

        private async void testTempButton()
        {
            await Task.Run(() =>
            {
                Console.WriteLine(@"RCell viewmodel finally recognized by view, thank god.");
                Console.WriteLine($@"Properties from the main vm can be accessed like this: {Main.InputCsvPath}.");
            });
        }
    }
}
