using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ionic.Zip;

namespace File_Manager
{
    public partial class ArchiveForm : Form
    {
		private string text;
		private readonly ZipFile zip = new ZipFile();
		private readonly TextBox mainTextBox;
		private readonly ListView listView;
		public ArchiveForm(ZipFile zip, TextBox textBox, ListView listView)
		{
			this.zip = zip;
			this.mainTextBox = textBox;
			this.listView = listView;
			InitializeComponent();
		}

        private void NameButton_Click(object sender, EventArgs e)
        {
			text = nameTextBox.Text;
			this.zip.Save(mainTextBox.Text + text + ".zip");
			this.Close();
		}
    }
}
