using System.Collections.ObjectModel;

namespace Folder_SubFolder
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            // Set the BindingContext here (ensure only one instantiation)
            BindingContext = new FileManagerViewModel();
        }
    }

    // Folder model representing each node in the tree.
    public class Folder
    {
        public string Name { get; set; }
        public ObservableCollection<Folder> SubFolders { get; set; }

        public Folder(string name)
        {
            Name = name;
            SubFolders = new ObservableCollection<Folder>();
        }
    }

    // ViewModel holding the root folders; no need to mark this class as partial.
    public class FileManagerViewModel
    {
        public ObservableCollection<Folder> Folders { get; private set; }

        public FileManagerViewModel()
        {
            Folders = new ObservableCollection<Folder>
            {
                new Folder("Documents")
                {
                    SubFolders =
                    {
                        new Folder("Work"),
                        new Folder("Personal")
                    }
                },
                new Folder("Pictures")
                {
                    SubFolders =
                    {
                        new Folder("Vacations"),
                        new Folder("Family")
                    }
                }
            };
        }
    }
}
