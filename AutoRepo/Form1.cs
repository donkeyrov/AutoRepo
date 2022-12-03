using System.Windows.Forms;
using System.IO;

namespace AutoRepo
{
    public partial class Form1 : Form
    {
        string[] files = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnProjectDir_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                //Get the path of specified file
                txtDatabaseContext.Text = openFileDialog1.SafeFileName.Split('.')[0];
            }
        }

        private void btnEntitiesDir_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtEntitiesDir.Text = folderBrowserDialog1.SelectedPath;

                files = Directory.GetFiles((folderBrowserDialog1.SelectedPath));
                //MessageBox.Show("Files found: " + files.Length.ToString(), "Message");
                progressBar1.Minimum = 0;
                progressBar1.Maximum = files.Length;
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
                txtGenericInterface.Text = openFileDialog1.SafeFileName.Split('.')[0]; ;                
            }
        }

        private void btnGenericClass_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                //Get the path of specified file
                txtGenericClass.Text = openFileDialog1.SafeFileName.Split('.')[0]; ;
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {                
                foreach (var file in files)
                {
                    progressBar1.Value += 1;

                    string[] fileParts = file.Split('\\');
                    string entityName = fileParts[fileParts.Length - 1].Split('.')[0];

                    //check if it exitis
                    string repoName = $"{entityName}Repository";
                    string interfaceName = $"I{entityName}Repository";

                    string fullInterfaceName = $"\\\\?\\{txtOutputDir.Text}\\{interfaceName}.cs";

                    if (!File.Exists(fullInterfaceName))
                    {
                        string fileInput = "";
                        //create interface
                        StreamWriter sw = new StreamWriter(fullInterfaceName, false);

                        fileInput = $"using IDEAL_PAYROLL.Entities;";
                        sw.WriteLine(fileInput);
                        sw.WriteLine("");
                        fileInput = $"namespace IDEAL_PAYROLL.Repositories";
                        sw.WriteLine(fileInput);
                        fileInput = "{";
                        sw.WriteLine(fileInput);
                        fileInput = $"\tpublic interface {interfaceName}: {txtGenericInterface.Text}<{entityName}>";
                        sw.WriteLine(fileInput);
                        fileInput = "\t{";
                        sw.WriteLine(fileInput);
                        sw.WriteLine("");
                        fileInput = "\t}";
                        sw.WriteLine(fileInput);
                        fileInput = "}";
                        sw.WriteLine(fileInput);
                        sw.Close();
                    }

                    string fullRepoName = $"\\\\?\\{txtOutputDir.Text}\\{repoName}.cs";

                    if (!File.Exists(fullRepoName))
                    {
                        string fileInput = "";
                        //create interface
                        StreamWriter sw = new StreamWriter(fullRepoName, false);

                        fileInput = $"using IDEAL_PAYROLL.Entities;";
                        sw.WriteLine(fileInput);
                        sw.WriteLine("");
                        fileInput = $"namespace IDEAL_PAYROLL.Repositories";
                        sw.WriteLine(fileInput);
                        fileInput = "{";
                        sw.WriteLine(fileInput);
                        fileInput = $"\tpublic class {repoName}: {txtGenericClass.Text}<{entityName}>, {interfaceName}";
                        sw.WriteLine(fileInput);
                        fileInput = "\t{";
                        sw.WriteLine(fileInput);

                        fileInput = $"\t\tpublic {repoName}({txtDatabaseContext.Text} db):base(db)";
                        sw.WriteLine(fileInput);
                        fileInput = "\t\t{";
                        sw.WriteLine(fileInput);
                        sw.WriteLine("");
                        sw.WriteLine(fileInput);
                        fileInput = "\t\t}";
                        sw.WriteLine(fileInput);

                        fileInput = "\t}";
                        sw.WriteLine(fileInput);
                        fileInput = "}";
                        sw.WriteLine(fileInput);
                        sw.Close();
                    }
                }
                MessageBox.Show("Auto Repo has Completed Processing");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}