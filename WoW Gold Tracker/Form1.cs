using System.IO;
using System.Linq;

namespace WoW_Gold_Tracker
{
    public partial class Form1 : Form
    {
        public string defaultpath = @"C:\Program Files (x86)\World of Warcraft";

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            folderBroswer.ShowDialog(this);
            folderBroswer.SelectedPath = @"C:\Program Files (x86)\World of Warcraft";
            txt_path.Text = folderBroswer.SelectedPath;
        }

        public string[] GetPaths()
        {
            string searchFile = "GoldTracker.lua";
            var result = Directory.GetFiles(txt_path.Text, searchFile, SearchOption.AllDirectories).Where(f => f.Contains(searchFile)).Select(f => Path.GetDirectoryName(f)).Distinct().ToArray();
            return result;
        }

        private void button_fetch_Click(object sender, EventArgs e)
        {
            string[] paths = GetPaths();

            for(int i = 0; i < paths.Length; i++)
            {
                paths[i] = paths[i] + "\\GoldTracker.lua";
            }
        }
    }
}