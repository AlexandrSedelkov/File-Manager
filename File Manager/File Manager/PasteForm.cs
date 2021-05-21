using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Manager
{
    public partial class PasteForm : Form
    {
        short formIndex;
        public PasteForm()
        {
            InitializeComponent();
        }

        private void OverwriteButton_Click(object sender, EventArgs e)
        {
            formIndex = 0;
            this.Close();
        }

        private void OverwriteAllButton_Click(object sender, EventArgs e)
        {
            formIndex = 1;
            this.Close();
        }

        private void SkipButton_Click(object sender, EventArgs e)
        {
            formIndex = 2;
            this.Close();
        }

        private void SkipAllButton_Click(object sender, EventArgs e)
        {
            formIndex = 3;
            this.Close();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            formIndex = 4;
            this.Close();
        }

        public short ApplyOrder()
        {
            return formIndex;
        }
    }
}
