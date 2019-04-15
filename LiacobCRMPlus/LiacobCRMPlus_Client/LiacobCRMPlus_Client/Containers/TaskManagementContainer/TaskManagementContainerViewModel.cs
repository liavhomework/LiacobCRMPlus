using LiacobCRMPlus_Client.Dialog;
using LiacobCRMPlus_Client.ViewModelsBase;
using MahApps.Metro.Controls.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace LiacobCRMPlus_Client.Containers
{
    public class TaskManagementContainerViewModel: ViewModelBase
    {
        private ResourceDictionary DialogDictionary = new ResourceDictionary() { Source = new Uri("pack://application:,,,/MaterialDesignThemes.MahApps;component/Themes/MaterialDesignTheme.MahApps.Dialogs.xaml") };

        public ICommand NewTaskDialogCommand { get; }

        public TaskManagementContainerViewModel()
        {
            NewTaskDialogCommand = new AnotherCommandImplementation(_ => InputDialog());
        }

        private void InputDialog()
        {
            var metroDialogSettings = new MetroDialogSettings
            {
                NegativeButtonText = "CANCEL"
            };

            DialogCoordinator.Instance.ShowInputAsync(this, "MahApps Dialog", "Using Material Design Themes");
        }
    }
}
