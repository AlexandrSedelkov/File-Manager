using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using Ionic.Zip;
using System.Media;

namespace File_Manager
{
    public partial class FileManagerForm : Form
    {
        string contextPath = "";
        string pastPath = "";
        public FileManagerForm()
        {
            InitializeComponent();
        }

        private void FileManagerForm_Load(object sender, EventArgs e)
        {
            Libraries.SetLocalDrive(mainTreeView);

            mainTreeView.AfterSelect += MainTreeView_AfterSelect;
        }

        private void MainTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string newPath = e.Node.FullPath.Replace("\\\\", "\\");
            filePathTextBox.Text = newPath + "\\";

            if (e.Node.GetNodeCount(true) == 0)
            {
                Libraries.GetSubDir(e.Node, e.Node.FullPath);
            }

            LoadInfo(mainListView, filePathTextBox);

            quantityLabel.Text = $"Элементов: {mainListView.Items.Count}";
        }

        private void Open(object sender, EventArgs e)
        {
            SelectItem(mainListView, filePathTextBox);
            quantityLabel.Text = $"Элементов: {mainListView.Items.Count}";
        }

        private void SelectItem(ListView listView, TextBox textBox)
        {
            try
            {
                int pos = listView.SelectedIndices[0];
                if (pos == 0 && listView.SelectedItems[0].Text == "..")
                {
                    try
                    {
                        if (pastPath != null)
                        {
                            DirectoryInfo di = new DirectoryInfo(textBox.Text);
                            if (di.Parent.FullName != Path.GetPathRoot(textBox.Text))
                            {
                                textBox.Text = di.Parent.FullName + (char)92;
                            }
                            else
                            {
                                textBox.Text = di.Parent.FullName;
                            }
                            LoadInfo(listView, textBox);
                        }
                    }
                    catch { }
                }
                else
                {
                    try
                    {
                        string addr = GetPathFileExt(textBox, listView, 0);
                        if (File.Exists(addr))
                        {
                            Process.Start(textBox.Text + listView.SelectedItems[0].Text + listView.SelectedItems[0].SubItems[1].Text);
                        }
                        else
                        {
                            textBox.Text += listView.Items[pos].Text + (char)92;
                        }
                        LoadInfo(listView, textBox);
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка!");
                    }
                }
            }
            catch
            {
            }

        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            RefreshListView();
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            /*Thread copyThread = new Thread(new ThreadStart(Copy));
            copyThread.Start();*/
            try
            {
                contextPath = filePathTextBox.Text + mainListView.SelectedItems[0].Text + mainListView.SelectedItems[0].SubItems[1].Text;
            }
            catch
            {
                MessageBox.Show("Пожалуйста, выберите файл или папку");
            }
        }

        private void RefreshListView()
        {
            Refresh();
            LoadInfo(mainListView, filePathTextBox);
            quantityLabel.Text = $"Элементов: {mainListView.Items.Count}";
        }

        private void RenameButton_Click(object sender, EventArgs e)
        {
            try
            {
                mainListView.SelectedItems[0].BeginEdit();
            }
            catch { }
        }

        private void PasteButton_Click(object sender, EventArgs e)
        {
            PasteFunction(contextPath, 0);
            RefreshListView();
        }

        private short PasteFunction(string sourcePath, int pos)
        {
            short index = 0;
            string text = filePathTextBox.Text;
            string destinationPath = filePathTextBox.Text + Path.GetFileName(sourcePath);

            PasteForm paste;

            try
            {
                if (File.Exists(sourcePath))
                {
                    if (File.Exists(destinationPath))
                    {
                        paste = new PasteForm();
                        paste.ShowDialog();
                        index = paste.ApplyOrder();
                        if (index == 0 || index == 1)
                            File.Copy(sourcePath, destinationPath, true);
                    }
                    else
                    {
                        File.Copy(sourcePath, destinationPath);
                    }
                }
                else
                {

                    Directory.CreateDirectory(destinationPath);

                    foreach (string dir in Directory.GetDirectories(sourcePath, "*", SearchOption.AllDirectories))
                    {

                        Directory.CreateDirectory(Path.Combine(destinationPath, dir.Substring(sourcePath.Length + 1)));

                    }

                    foreach (string file_name in System.IO.Directory.GetFiles(sourcePath, "*", SearchOption.AllDirectories))
                    {
                        if (File.Exists(Path.Combine(destinationPath, file_name.Substring(sourcePath.Length + 1))))
                        {
                            if (index != 1)
                            {
                                paste = new PasteForm();
                                paste.ShowDialog();
                                index = paste.ApplyOrder();
                            }
                            if (index == 0)
                            {
                                File.Copy(file_name, Path.Combine(destinationPath, file_name.Substring(sourcePath.Length + 1)), true);
                                continue;
                            }
                            else if (index == 1)
                            {

                                File.Copy(file_name, Path.Combine(destinationPath, file_name.Substring(sourcePath.Length + 1)), true);
                                continue;
                            }
                            else if (index == 3)
                            {
                                foreach (string file_name1 in Directory.GetFiles(sourcePath, "*", SearchOption.AllDirectories))
                                {
                                    if (!File.Exists(Path.Combine(destinationPath, file_name1.Substring(sourcePath.Length + 1))))
                                        File.Copy(file_name1, Path.Combine(destinationPath, file_name1.Substring(sourcePath.Length + 1)));
                                }
                                break;
                            }
                            else if (index == 2)
                            {
                                continue;
                            }
                            else
                            {
                                break;
                            }
                        }
                        File.Copy(file_name, Path.Combine(destinationPath, file_name.Substring(sourcePath.Length + 1)));
                    }

                }
            }
            catch { }
        
            return index;
        }

        private string GetPathFileExt(TextBox textBox, ListView listView, int index)
        {
            return textBox.Text + listView.SelectedItems[index].Text + listView.SelectedItems[index].SubItems[1].Text;
        }

        private void LoadInfo(ListView listView, TextBox textBox)
        {
            listView.Items.Clear();
            pastPath = textBox.Text;

            try
            {
                string[] ourDir = Directory.GetDirectories(textBox.Text);
                foreach (string folder in ourDir)
                {
                    if ((new FileInfo(folder).Attributes & FileAttributes.Hidden) != FileAttributes.Hidden)
                    {

                        string[] array = new string[5];
                        array[0] = Path.GetFileName(folder);

                        ListViewItem item = new ListViewItem(array);
                        item.ImageIndex = 0;
                        listView.Items.Add(item);
                    }

                }
                ourDir = Directory.GetFiles(textBox.Text);
                foreach (string files in ourDir)
                {

                    if ((new FileInfo(files).Attributes & FileAttributes.Hidden) != FileAttributes.Hidden)
                    {
                        string[] array = new string[4];
                        array[0] = Path.GetFileNameWithoutExtension(files);
                        array[1] = Path.GetExtension(files);
                        double size = new FileInfo(files).Length;

                        ListViewItem item = new ListViewItem(array);
                        iconList.Images.Add(files, Icon.ExtractAssociatedIcon(files));
                        item.ImageIndex = iconList.Images.Keys.IndexOf(files);
                        listView.Items.Add(item);
                    }
                }
            }
            catch
            {
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            CallOutDeleteFunction();
        }

        private void CallOutDeleteFunction()
        {
            if (mainListView.SelectedItems.Count > 0)
            {
                int index = mainListView.SelectedItems.Count - 1;

                string sourcePath = filePathTextBox.Text;
                while (index != -1)
                {
                    string fileName = mainListView.SelectedItems[index].Text + mainListView.SelectedItems[index].SubItems[1].Text;
                    string path = GetPathFileExt(filePathTextBox, mainListView, index);
                    if (AskBeforeDelete(path, fileName))
                    {
                        DeleteFunction(path);

                    }
                    index--;
                }
                RefreshListView();
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите файл или папку");
            }

        }

        private void DeleteFunction(string path)
        {

            if (File.Exists(path))
            {
                File.Delete(path);
            }
            else
            {
                DirectoryInfo di = new DirectoryInfo(path);
                foreach (FileInfo file in di.GetFiles())
                {
                    file.Delete();
                }
                foreach (DirectoryInfo dir in di.GetDirectories())
                {
                    dir.Delete(true);
                }
                Directory.Delete(path);
            }
        }

        private bool AskBeforeDelete(string path, string fileName)
        {
            DialogResult text;
            if (File.Exists(path))
            {
                text = MessageBox.Show("Вы точно хотите удалить " + $"{fileName} ?", "Удаление", MessageBoxButtons.YesNo);
                if (text == DialogResult.Yes)
                {
                    return true;
                }
            }
            else
            {
                text = MessageBox.Show("Вы точно хотите удалить " + $" {fileName} ?", "Удаление", MessageBoxButtons.YesNo);
                if (text == DialogResult.Yes)
                {
                    return true;
                }
            }
            return false;
        }

        private void PropertiesButton_Click(object sender, EventArgs e)
        {
            try
            {
                string strFilePath = filePathTextBox.Text + mainListView.SelectedItems[0].SubItems[0].Text + mainListView.SelectedItems[0].SubItems[1].Text;

                if (File.Exists(strFilePath))
                {
                    FileInfo oFileInfo = new FileInfo(strFilePath);
                    MessageBox.Show("Имя: " + oFileInfo.Name + "\nРазмер: " + oFileInfo.Length.ToString() + " Bytes", "Свойства");
                }
                else
                {
                    DirectoryInfo oDirInfo = new DirectoryInfo(strFilePath);
                    long filesLength = DirectoryLength(strFilePath);
                    int dirCount = DirectoriesCount(strFilePath);
                    MessageBox.Show("Имя: " + oDirInfo.Name + "\nРазмер: " + filesLength.ToString() + " Bytes" + "\nПапок: " + dirCount.ToString() + " | Файлов: " + FilesCount(strFilePath), "Свойства");
                }
            }
            catch 
            { 
                MessageBox.Show("Пожалуйста, выберите файл или папку"); 
            }
        }

        private long DirectoryLength(string path)
        {
            long filesLength = 0;
            try
            {
                DirectoryInfo fDir = new DirectoryInfo(path);
                foreach (FileInfo file in fDir.GetFiles("*.*", SearchOption.AllDirectories))
                {
                    filesLength += file.Length;
                }
            }
            catch (Exception exc) 
            { 
                MessageBox.Show(exc.Message); 
            }

            return filesLength;
        }

        private int DirectoriesCount(string path)
        {
            int dirCount = 0;

            try
            {
                DirectoryInfo fDir = new DirectoryInfo(path);
                foreach (DirectoryInfo dir in fDir.GetDirectories("*.*", SearchOption.AllDirectories))
                {
                    dirCount++;
                }
            }
            catch { }

            return dirCount;
        }

        private int FilesCount(string path)
        {
            int filesCount = 0;

            try
            {
                DirectoryInfo fDir = new DirectoryInfo(path);
                foreach (FileInfo file in fDir.GetFiles("*.*", SearchOption.AllDirectories))
                {
                    filesCount++;
                }
            }
            catch { }

            return filesCount;
        }

        private void CreateNewFolderButton_Click(object sender, EventArgs e)
        {
            CallOutNewFolderFunction();
        }

        private void CallOutNewFolderFunction()
        {
            try
            {
                string fileAddr = filePathTextBox.Text + "Новая папка";
                if (Directory.Exists(fileAddr))
                {
                    int i = 1;                  
                    fileAddr += " (" + i.ToString() + ")";
                }
                Directory.CreateDirectory(fileAddr);

                RefreshListView();
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так!");
            }
        }

        private async void CompressButton_Click(object sender, EventArgs e)
        {
            await Compress();
        }

        private async Task Compress()
        {
            try
            {
                using (ZipFile zip = new ZipFile())
                {
                    zip.AlternateEncodingUsage = ZipOption.Always;
                    zip.AlternateEncoding = Encoding.GetEncoding(866);
                    foreach (ListViewItem item in mainListView.SelectedItems)
                    {
                        string path = filePathTextBox.Text + item.SubItems[0].Text + item.SubItems[1].Text;
                        if (File.Exists(path))
                        {
                            await Task.Run(() => zip.AddFile(path, ""));
                        }
                        else
                        {
                            await Task.Run(() => zip.AddDirectory(path, Path.GetFileName(path)));
                        }
                    }
                    ArchiveForm archiveForm = new ArchiveForm(zip, filePathTextBox, mainListView);
                    archiveForm.ShowDialog();
                    LoadInfo(mainListView, filePathTextBox);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void ListStyleButton_Click(object sender, EventArgs e)
        {
            mainListView.View = View.List;
        }

        private void GridStyleButton_Click(object sender, EventArgs e)
        {
            mainListView.View = View.LargeIcon;
        }
    }
}


