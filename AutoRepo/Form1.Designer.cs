namespace AutoRepo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDatabaseContext = new System.Windows.Forms.TextBox();
            this.btnDatabaseContext = new System.Windows.Forms.Button();
            this.btnEntitiesDir = new System.Windows.Forms.Button();
            this.txtEntitiesDir = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOutputDir = new System.Windows.Forms.Button();
            this.txtOutputDir = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnGenericInterface = new System.Windows.Forms.Button();
            this.txtGenericInterface = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGenericClass = new System.Windows.Forms.Button();
            this.txtGenericClass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "DATABASE CONTEXT";
            // 
            // txtDatabaseContext
            // 
            this.txtDatabaseContext.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDatabaseContext.Location = new System.Drawing.Point(27, 48);
            this.txtDatabaseContext.Name = "txtDatabaseContext";
            this.txtDatabaseContext.ReadOnly = true;
            this.txtDatabaseContext.Size = new System.Drawing.Size(602, 23);
            this.txtDatabaseContext.TabIndex = 1;
            // 
            // btnDatabaseContext
            // 
            this.btnDatabaseContext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDatabaseContext.Location = new System.Drawing.Point(635, 48);
            this.btnDatabaseContext.Name = "btnDatabaseContext";
            this.btnDatabaseContext.Size = new System.Drawing.Size(75, 23);
            this.btnDatabaseContext.TabIndex = 2;
            this.btnDatabaseContext.Text = "select";
            this.btnDatabaseContext.UseVisualStyleBackColor = true;
            this.btnDatabaseContext.Click += new System.EventHandler(this.btnProjectDir_Click);
            // 
            // btnEntitiesDir
            // 
            this.btnEntitiesDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEntitiesDir.Location = new System.Drawing.Point(635, 107);
            this.btnEntitiesDir.Name = "btnEntitiesDir";
            this.btnEntitiesDir.Size = new System.Drawing.Size(75, 23);
            this.btnEntitiesDir.TabIndex = 5;
            this.btnEntitiesDir.Text = "select";
            this.btnEntitiesDir.UseVisualStyleBackColor = true;
            this.btnEntitiesDir.Click += new System.EventHandler(this.btnEntitiesDir_Click);
            // 
            // txtEntitiesDir
            // 
            this.txtEntitiesDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEntitiesDir.Location = new System.Drawing.Point(27, 107);
            this.txtEntitiesDir.Name = "txtEntitiesDir";
            this.txtEntitiesDir.ReadOnly = true;
            this.txtEntitiesDir.Size = new System.Drawing.Size(602, 23);
            this.txtEntitiesDir.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "ENTITIES DIRECTORY";
            // 
            // btnOutputDir
            // 
            this.btnOutputDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOutputDir.Location = new System.Drawing.Point(635, 170);
            this.btnOutputDir.Name = "btnOutputDir";
            this.btnOutputDir.Size = new System.Drawing.Size(75, 23);
            this.btnOutputDir.TabIndex = 8;
            this.btnOutputDir.Text = "select";
            this.btnOutputDir.UseVisualStyleBackColor = true;
            this.btnOutputDir.Click += new System.EventHandler(this.btnOutputDir_Click);
            // 
            // txtOutputDir
            // 
            this.txtOutputDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutputDir.Location = new System.Drawing.Point(27, 170);
            this.txtOutputDir.Name = "txtOutputDir";
            this.txtOutputDir.ReadOnly = true;
            this.txtOutputDir.Size = new System.Drawing.Size(602, 23);
            this.txtOutputDir.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "OUTPUT DIRECTORY";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnGenericInterface
            // 
            this.btnGenericInterface.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenericInterface.Location = new System.Drawing.Point(635, 251);
            this.btnGenericInterface.Name = "btnGenericInterface";
            this.btnGenericInterface.Size = new System.Drawing.Size(75, 23);
            this.btnGenericInterface.TabIndex = 11;
            this.btnGenericInterface.Text = "select";
            this.btnGenericInterface.UseVisualStyleBackColor = true;
            this.btnGenericInterface.Click += new System.EventHandler(this.btnGenericInterface_Click);
            // 
            // txtGenericInterface
            // 
            this.txtGenericInterface.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGenericInterface.Location = new System.Drawing.Point(27, 251);
            this.txtGenericInterface.Name = "txtGenericInterface";
            this.txtGenericInterface.ReadOnly = true;
            this.txtGenericInterface.Size = new System.Drawing.Size(602, 23);
            this.txtGenericInterface.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "GENERIC INTERFACE";
            // 
            // btnGenericClass
            // 
            this.btnGenericClass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenericClass.Location = new System.Drawing.Point(635, 299);
            this.btnGenericClass.Name = "btnGenericClass";
            this.btnGenericClass.Size = new System.Drawing.Size(75, 23);
            this.btnGenericClass.TabIndex = 14;
            this.btnGenericClass.Text = "select";
            this.btnGenericClass.UseVisualStyleBackColor = true;
            this.btnGenericClass.Click += new System.EventHandler(this.btnGenericClass_Click);
            // 
            // txtGenericClass
            // 
            this.txtGenericClass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGenericClass.Location = new System.Drawing.Point(27, 299);
            this.txtGenericClass.Name = "txtGenericClass";
            this.txtGenericClass.ReadOnly = true;
            this.txtGenericClass.Size = new System.Drawing.Size(602, 23);
            this.txtGenericClass.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "GENERIC CLASS";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(25, 358);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(685, 23);
            this.progressBar1.TabIndex = 15;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(296, 396);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(142, 42);
            this.btnGenerate.TabIndex = 16;
            this.btnGenerate.Text = "GENERATE";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 450);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnGenericClass);
            this.Controls.Add(this.txtGenericClass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnGenericInterface);
            this.Controls.Add(this.txtGenericInterface);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnOutputDir);
            this.Controls.Add(this.txtOutputDir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEntitiesDir);
            this.Controls.Add(this.txtEntitiesDir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDatabaseContext);
            this.Controls.Add(this.txtDatabaseContext);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(751, 489);
            this.MinimumSize = new System.Drawing.Size(751, 489);
            this.Name = "Form1";
            this.Text = "Auto Repo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FolderBrowserDialog folderBrowserDialog1;
        private Label label1;
        private TextBox txtDatabaseContext;
        private Button btnDatabaseContext;
        private Button btnEntitiesDir;
        private TextBox txtEntitiesDir;
        private Label label2;
        private Button btnOutputDir;
        private TextBox txtOutputDir;
        private Label label3;
        private OpenFileDialog openFileDialog1;
        private Button btnGenericInterface;
        private TextBox txtGenericInterface;
        private Label label4;
        private Button btnGenericClass;
        private TextBox txtGenericClass;
        private Label label5;
        private ProgressBar progressBar1;
        private Button btnGenerate;
    }
}