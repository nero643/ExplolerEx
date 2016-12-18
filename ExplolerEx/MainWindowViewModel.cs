using Microsoft.WindowsAPICodePack.Shell;
using Livet;
using Reactive.Bindings;

namespace ExplolerEx.ViewModels
{
    public class MainWindowViewModel : ViewModel
    {
        public MainWindowViewModel()
        {
            this.Exp = new Microsoft.WindowsAPICodePack.Controls.WindowsPresentationFoundation.ExplorerBrowser();
        }

        public Microsoft.WindowsAPICodePack.Controls.WindowsPresentationFoundation.ExplorerBrowser Exp { get; private set; }

        public void InitialLoad()
        {
            this.Exp.ExplorerBrowserControl.Navigate((ShellObject)KnownFolders.Desktop);
        }
    }
}
