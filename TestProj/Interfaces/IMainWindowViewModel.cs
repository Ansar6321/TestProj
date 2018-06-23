using System.Windows.Input;

namespace TestProj.Interfaces {
    public interface IMainWindowViewModel {
        IMainWindowView View { get; }
        ICommand ShowData { get; }
    }
}
