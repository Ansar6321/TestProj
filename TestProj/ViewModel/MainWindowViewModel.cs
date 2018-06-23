using System;
using System.Windows.Input;
using TestProj.Common;
using TestProj.Interfaces;
namespace TestProj.ViewModel {
    public class MainWindowViewModel : NotifybleObject, IMainWindowViewModel {
        public MainWindowViewModel(IMainWindowView view) {
            this.View = view;
            this.View.BindDataContext(this);
        }

        public IMainWindowView View { get; private set; }

        private string login;

        public string Login {
            get { return login; }
            set {
                login = value;
                OnPropertyChanged();
            }
        }

        private string password;

        public string Password {
            get { return password; }
            set {
                password = value;
                OnPropertyChanged();
            }
        }

        private ICommand showData;

        public ICommand ShowData {
            get {
                if (this.showData == null) {
                    this.showData = new RelayCommand(
                            (param) => {
                                this.View.ShowAlert(this.Login, this.Password);
                            },
                            (param) => {
                                if (!(String.IsNullOrEmpty(this.Login) || String.IsNullOrEmpty(this.Password))) {
                                    return true;
                                } else return false;
                            }
                        );
                }
                return showData;
            }
        }
         
    }
}
