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
using System.Reflection;

namespace LimeKit
{
    public partial class frmLimeKit : Form
    {
        List<CResource> resources;


        public frmLimeKit()
        {
            resources = new List<CResource>(3);


            InitializeComponent();
        }

        private void toolStripMenuItemDbg_Click(object sender, EventArgs e)
        {
            CResource res;

            res = LoadFile();

            propertyGridMain.SelectedObject = res;
        }

        public CResource LoadFile()
        {
            using (var of = new OpenFileDialog())
            {
                if (of.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        return CResourceManager.LoadResource(of.FileName);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                }
            }
            return null;
        }

        private void loadFile1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                resources.Add(LoadFile());
            }
            catch (Exception)
            {
                Console.WriteLine(e);
            }
        }

        private void loadFile2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                resources.Add(LoadFile());
            }
            catch (Exception)
            {
                Console.WriteLine(e);
            }
        }

        private void loadFile3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                resources[2] = LoadFile();
            }
            catch (Exception)
            {
                Console.WriteLine(e);
            }
        }

        private void compareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (resources[0] == null || resources[1] == null)
            {
                return;
            }
            var ret = DeepCompare(resources[0], resources[1]);
            

        }

        public bool DeepCompare( object obj, object another)
        {
            if (ReferenceEquals(obj, another)) return true;
            if ((obj == null) || (another == null)) return false;
            //Compare two object's class, return false if they are difference
            if (obj.GetType() != another.GetType()) return false;

            var result = true;
            //Get all properties of obj
            //And compare each other
            textBoxLog.Clear();

            var props = GetAllPropsRecursive(obj);
            foreach (var property in props)
            {
                var objValue = property.GetValue(obj);
                var anotherValue = property.GetValue(another);

                if (!(objValue == null || anotherValue == null))
                {
                    if (!objValue.Equals(anotherValue))
                    {
                        string finalstring = "";

                        finalstring += "------------------------\r\n";
                        finalstring += $"{property.Name}\r\n";
                        finalstring += $"File1: {objValue}\r\n";
                        finalstring += $"File2: {anotherValue}\r\n";
                        finalstring += "------------------------\r\n";
                        textBoxLog.AppendText(finalstring);
                    }
                }
            }

            return result;
        }

        private List<PropertyInfo> GetAllPropsRecursive(object input)
        {
            List<PropertyInfo> result = new List<PropertyInfo>();

            List<PropertyInfo> initialprops = input.GetType().GetProperties().ToList();

            foreach (PropertyInfo p in initialprops)
            {
                var val = p.GetValue(input);
                var props = GetAllPropsRecursive(p);
                foreach (PropertyInfo p2 in props)
                {
                    if (!result.Contains(p2))
                        result.Add(p2);
                }
            }

            return result;
        }
    }
}
