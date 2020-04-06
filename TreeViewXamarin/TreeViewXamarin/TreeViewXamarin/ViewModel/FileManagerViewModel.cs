using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Reflection;
using System.Text;
using Xamarin.Forms;

namespace TreeViewXamarin
{
    public class FileManagerViewModel
    {
        public ObservableCollection<Folder> Folders { get; set; }

        public ObservableCollection<File> Files { get; set; }

        public ObservableCollection<SubFile> SubFiles { get; set; }

        public FileManagerViewModel()
        {
            this.Folders = GetFiles();
        }

        private ObservableCollection<Folder> GetFiles()
        {
            var nodeImageInfo = new ObservableCollection<Folder>();
            Assembly assembly = typeof(MainPage).GetTypeInfo().Assembly;

            var doc = new Folder() { FileName = "Documents", ImageIcon = ImageSource.FromResource("TreeViewXamarin.Icons.treeview_folder.png", assembly) };
            var download = new Folder() { FileName = "Downloads", ImageIcon = ImageSource.FromResource("TreeViewXamarin.Icons.treeview_folder.png", assembly) };
            var mp3 = new Folder() { FileName = "Music", ImageIcon = ImageSource.FromResource("TreeViewXamarin.Icons.treeview_folder.png", assembly) };
            var pictures = new Folder() { FileName = "Pictures", ImageIcon = ImageSource.FromResource("TreeViewXamarin.Icons.treeview_folder.png", assembly) };
            var video = new Folder() { FileName = "Videos", ImageIcon = ImageSource.FromResource("TreeViewXamarin.Icons.treeview_folder.png", assembly) };

            var pollution = new File() { FileName = "Environmental Pollution.docx", ImageIcon = ImageSource.FromResource("TreeViewXamarin.Icons.treeview_word.png", assembly) };
            var globalWarming = new File() { FileName = "Global Warming.ppt", ImageIcon = ImageSource.FromResource("TreeViewXamarin.Icons.treeview_ppt.png", assembly) };
            var sanitation = new File() { FileName = "Sanitation.docx", ImageIcon = ImageSource.FromResource("TreeViewXamarin.Icons.treeview_word.png", assembly) };
            var socialNetwork = new File() { FileName = "Social Network.pdf", ImageIcon = ImageSource.FromResource("TreeViewXamarin.Icons.treeview_pdf.png", assembly) };
            var youthEmpower = new File() { FileName = "Youth Empowerment.pdf", ImageIcon = ImageSource.FromResource("TreeViewXamarin.Icons.treeview_pdf.png", assembly) };

            var games = new File() { FileName = "Game.exe", ImageIcon = ImageSource.FromResource("TreeViewXamarin.Icons.treeview_exe.png", assembly) };
            var tutorials = new File() { FileName = "Tutorials.zip", ImageIcon = ImageSource.FromResource("TreeViewXamarin.Icons.treeview_zip.png", assembly) };
            var typeScript = new File() { FileName = "TypeScript.7z", ImageIcon = ImageSource.FromResource("TreeViewXamarin.Icons.treeview_zip.png", assembly) };
            var uiGuide = new File() { FileName = "UI-Guide.pdf", ImageIcon = ImageSource.FromResource("TreeViewXamarin.Icons.treeview_pdf.png", assembly) };

            var song = new File() { FileName = "Gouttes", ImageIcon = ImageSource.FromResource("TreeViewXamarin.Icons.treeview_mp3.png", assembly) };

            var camera = new File() { FileName = "Camera Roll", ImageIcon = ImageSource.FromResource("TreeViewXamarin.Icons.treeview_folder.png", assembly) };
            var stone = new File() { FileName = "Stone.jpg", ImageIcon = ImageSource.FromResource("TreeViewXamarin.Icons.treeview_png.png", assembly) };
            var wind = new File() { FileName = "Wind.jpg", ImageIcon = ImageSource.FromResource("TreeViewXamarin.Icons.treeview_png.png", assembly) };

            var img0 = new SubFile() { FileName = "WIN_20160726_094117.JPG", ImageIcon = ImageSource.FromResource("TreeViewXamarin.Icons.treeview_img0.png", assembly) };
            var img1 = new SubFile() { FileName = "WIN_20160726_094118.JPG", ImageIcon = ImageSource.FromResource("TreeViewXamarin.Icons.treeview_img1.png", assembly) };

            var video1 = new File() { FileName = "Naturals.mp4", ImageIcon = ImageSource.FromResource("TreeViewXamarin.Icons.treeview_video.png", assembly) };
            var video2 = new File() { FileName = "Wild.mpeg", ImageIcon = ImageSource.FromResource("TreeViewXamarin.Icons.treeview_video.png", assembly) };
            doc.Files = new ObservableCollection<File>
            {
                pollution,
                globalWarming,
                sanitation,
                socialNetwork,
                youthEmpower
            };

            download.Files = new ObservableCollection<File>
            {
                games,
                tutorials,
                typeScript,
                uiGuide
            };

            mp3.Files = new ObservableCollection<File>
            {
                song
            };

            pictures.Files = new ObservableCollection<File>
            {
                camera,
                stone,
                wind
            };
            camera.SubFiles = new ObservableCollection<SubFile>
            {
                img0,
                img1
            };

            video.Files = new ObservableCollection<File>
            {
                video1,
                video2
            };

            nodeImageInfo.Add(doc);
            nodeImageInfo.Add(download);
            nodeImageInfo.Add(mp3);
            nodeImageInfo.Add(pictures);
            nodeImageInfo.Add(video);

            return nodeImageInfo;
        }
    }
}