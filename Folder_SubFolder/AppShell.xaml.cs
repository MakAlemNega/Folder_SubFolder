using Syncfusion.Maui.TreeView;
using System.Linq; // Add this using directive

namespace Folder_SubFolder
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            BindingContext = new FileManagerViewModel();
        }

        private void MenuTreeView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Assuming single selection mode; cast the selected item
            //if (e.AddedItems?.FirstOrDefault() is Folder selectedFolder)
            //{
            //    System.Diagnostics.Debug.WriteLine($"Selected folder: {selectedFolder.Name}");
            //    //IsPresented = false;
            //}
        }
    }
}
