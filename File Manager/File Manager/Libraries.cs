using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Manager
{
    class Libraries
    {
        public static void SetLocalDrive(TreeView tv)
        {
            DriveInfo[] lDrives = DriveInfo.GetDrives();

            foreach (DriveInfo item in lDrives)
            {
                TreeNode tn = new TreeNode(item.Name);
                tv.Nodes.Add(tn);

                GetSubDir(tn, tn.FullPath);
            }
        }

        public static void GetDirectories(string path, ListView lv)
        {
            try
            {
                lv.Clear();

                string[] dirs = Directory.GetDirectories(path);

                AddListViewItems(dirs, lv, 0);

                string[] files = Directory.GetFiles(path);

                AddListViewItems(files, lv, 1);
            }
            catch (Exception)
            {
                lv.Clear();
            }
        }

        private static void AddListViewItems(string[] items, ListView lv, int picture)
        {
            foreach (string item in items)
            {
                string[] tmp = item.Split(('\\'));

                lv.Items.Add(tmp[tmp.Length - 1], picture);
            }
        }

        public static void GetSubDir(TreeNode tn, string path)
        {
            try
            {
                string[] dirs = Directory.GetDirectories(tn.FullPath);

                foreach (string item in dirs)
                {
                    string[] tmp = item.Split('\\');

                    TreeNode ntr = new TreeNode(tmp[tmp.Length - 1]);

                    tn.Nodes.Add(ntr);
                }
            }
            catch (Exception)
            {
            }
        }

        public static void SearchNode(TreeView tv, string path)
        {
            TreeNode res = null;

            foreach (TreeNode tn in tv.Nodes)
            {
                Searching(tn.Nodes, path, ref res);

                if (res != null)
                {
                    tv.Focus();
                    tv.SelectedNode = res;

                    return;
                }
            }
        }

        private static void Searching(TreeNodeCollection tnc, string path, ref TreeNode res)
        {
            foreach (TreeNode tn in tnc)
            {
                if (tn.FullPath == path)
                {
                    res = tn;
                }

                Searching(tn.Nodes, path, ref res);
            }
        }
    }
}
