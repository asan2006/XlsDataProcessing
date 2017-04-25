using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace XlsDataProcessing.Unit
{
    public partial class FolderList : UserControl
    {
        public FolderList()
        {
            InitializeComponent();
        }

        public List<DirectoryInfo> foldersList
        {
            get
            {
                List<DirectoryInfo> ls = new List<DirectoryInfo>();
                if (lbFolder.Items.Count > 0)
                {
                    foreach (var item in lbFolder.Items)
                    {
                        ls.Add(new DirectoryInfo(item.ToString()));
                    }
                }
                return ls;
            }
        }

        public List<FileInfo> xlsFileList
        {
            get
            {
                List<FileInfo> ls = new List<FileInfo>();
                if (lbFolder.Items.Count > 0)
                {
                    foreach (var f in lbFolder.Items)
                    {
                        DirectoryInfo di = new DirectoryInfo(f.ToString());
                        FileInfo[] fis = di.GetFiles("*.xlsx");
                        ls.AddRange(fis);
                    }
                }
                return ls;
            }
        }

        private void lbFolder_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                Boolean bol = true;
                var strFolders = (String[])e.Data.GetData(DataFormats.FileDrop);
                foreach (var s in strFolders)
                {
                    if (!System.IO.Directory.Exists(s))
                        bol = false;
                }
                if (bol)
                    e.Effect = DragDropEffects.Link;
            }
        }

        private void lbFolder_DragDrop(object sender, DragEventArgs e)
        {
            Boolean bol = true;
            var strFolders = (String[])e.Data.GetData(DataFormats.FileDrop);
            foreach (var s in strFolders)
            {
                if (!System.IO.Directory.Exists(s))
                    bol = false;
            }
            if (bol)
            {
                foreach (var folder in strFolders)
                {
                    if (!lbFolder.Items.Contains(folder))
                        lbFolder.Items.Add(folder);
                }
            }
        }
        /// <summary>
        /// 右键删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lbFolder.SelectedIndex >= 0)
                lbFolder.Items.RemoveAt(lbFolder.SelectedIndex);
        }
        /// <summary>
        /// 右键清空
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbFolder.Items.Clear();
        }
    }
}
