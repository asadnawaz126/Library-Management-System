namespace WindowsFormsApp1
{
    partial class HomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.load_Artifacts = new System.Windows.Forms.Button();
            this.goToSearchPage = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(901, 338);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Catalog of Artifacts";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // load_Artifacts
            // 
            this.load_Artifacts.Location = new System.Drawing.Point(200, 59);
            this.load_Artifacts.Name = "load_Artifacts";
            this.load_Artifacts.Size = new System.Drawing.Size(107, 23);
            this.load_Artifacts.TabIndex = 2;
            this.load_Artifacts.Text = "View Artifacts\r\n";
            this.load_Artifacts.UseVisualStyleBackColor = true;
            this.load_Artifacts.Click += new System.EventHandler(this.button1_Click);
            // 
            // goToSearchPage
            // 
            this.goToSearchPage.Location = new System.Drawing.Point(296, 443);
            this.goToSearchPage.Name = "goToSearchPage";
            this.goToSearchPage.Size = new System.Drawing.Size(134, 23);
            this.goToSearchPage.TabIndex = 3;
            this.goToSearchPage.Text = "Go To Search Page";
            this.goToSearchPage.UseVisualStyleBackColor = true;
            this.goToSearchPage.Click += new System.EventHandler(this.goToSearchPage_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(447, 443);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Issue A Book";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 478);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.goToSearchPage);
            this.Controls.Add(this.load_Artifacts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "HomePage";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.HomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button load_Artifacts;
        private System.Windows.Forms.Button goToSearchPage;
        private System.Windows.Forms.Button button1;
    }
}