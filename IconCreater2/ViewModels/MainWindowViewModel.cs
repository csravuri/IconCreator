using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace IconCreater2.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private string sourceImagePath;

        public string SourceImagePath
        {
            get => sourceImagePath;
            set => SetProperty(ref sourceImagePath, value);
        }

        public ICommand ImagePathButtonClickedCommand { get; }

        public event PropertyChangedEventHandler PropertyChanged;

        public MainWindowViewModel()
        {
            //ImagePathButtonClickedCommand = CommandManager.AddExecutedHandler()
        }

        public void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, e);
        }

        protected bool SetProperty<T>(ref T backstore, T value, [CallerMemberName] string propertyName = "")
        {
            if (EqualityComparer<T>.Default.Equals(backstore, value))
                return false;

            backstore = value;
            OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
            return true;
        }
    }
}
