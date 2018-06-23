using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TestProj.Common {
    public class NotifybleObject : INotifyPropertyChanged {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName]string param = "") {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(param));
        }
    }
}
