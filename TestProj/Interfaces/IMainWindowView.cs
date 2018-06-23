namespace TestProj.Interfaces {
    public interface IMainWindowView {
        void ShowAlert(string text, string caption);
        void BindDataContext(IMainWindowViewModel mainWindowViewModel);

    }
}
