using System.Windows;
using TestProj.Interfaces;

namespace TestProj {
    public partial class MainWindow : Window, IMainWindowView
    {
        public MainWindow()
        {
            InitializeComponent();


        }

        public void BindDataContext(IMainWindowViewModel mainWindowViewModel) {
            this.DataContext = mainWindowViewModel;
        }

        public void ShowAlert(string text, string caption) {
            MessageBox.Show(text, caption);
        }
    }
}
