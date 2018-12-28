using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CR2W;
using CR2W.IO;
using CR2W.Types.W3;
using CR2W.Types;

namespace LimeKit
{
    public partial class frmLimeKit : Form
    {
        public frmLimeKit()
        {
            InitializeComponent();
        }

        private void toolStripMenuItemDbg_Click(object sender, EventArgs e)
        {
            SelectFile();
        }

        void SelectFile()
        {
            using (var of = new OpenFileDialog())
            {
                if (of.ShowDialog() == DialogResult.OK)
                {
                   

                    CResource res;
                    try
                    {
                        res = CResourceManager.LoadResource(of.FileName);
                        
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        return;
                    }

                    propertyGridMain.SelectedObject = res;
                }
            }
        }
    }
}
