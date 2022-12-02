using System.Windows.Forms;

namespace AutoRepo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProjectDir_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtProjectDir.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnEntitiesDir_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtEntitiesDir.Text = folderBrowserDialog1.SelectedPath;

                string[] files = Directory.GetFiles(folderBrowserDialog1.SelectedPath);
                MessageBox.Show("Files found: " + files.Length.ToString(), "Message");
            }
        }

        private void btnOutputDir_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtOutputDir.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnGenericInterface_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                //Get the path of specified file
                txtGenericInterface.Text = openFileDialog1.FileName;                
            }
        }

        private void btnGenericClass_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                //Get the path of specified file
                txtGenericClass.Text = openFileDialog1.FileName;
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch(Exception ex)
            {

            }
        }
    }
}