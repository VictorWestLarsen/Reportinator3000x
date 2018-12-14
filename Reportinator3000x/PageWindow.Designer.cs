namespace Reportinator3000x
{
    partial class PageWindow
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
            this.ReportNamePage = new System.Windows.Forms.Label();
            this.labelReportNamePage = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ModuleName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ModuleSerialNr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.EditPage = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.PageNameInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ReportNamePage
            // 
            this.ReportNamePage.AutoSize = true;
            this.ReportNamePage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportNamePage.Location = new System.Drawing.Point(12, 7);
            this.ReportNamePage.Name = "ReportNamePage";
            this.ReportNamePage.Size = new System.Drawing.Size(144, 26);
            this.ReportNamePage.TabIndex = 0;
            this.ReportNamePage.Text = "Report name:";
            // 
            // labelReportNamePage
            // 
            this.labelReportNamePage.AutoSize = true;
            this.labelReportNamePage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReportNamePage.Location = new System.Drawing.Point(149, 7);
            this.labelReportNamePage.Name = "labelReportNamePage";
            this.labelReportNamePage.Size = new System.Drawing.Size(0, 26);
            this.labelReportNamePage.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ModuleName,
            this.ModuleSerialNr});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(17, 119);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(721, 308);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ModuleName
            // 
            this.ModuleName.Tag = "ModuleName";
            this.ModuleName.Text = "Name";
            this.ModuleName.Width = 443;
            // 
            // ModuleSerialNr
            // 
            this.ModuleSerialNr.Tag = "ModuleSerialNr";
            this.ModuleSerialNr.Text = "Serial number";
            this.ModuleSerialNr.Width = 95;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 26);
            this.label1.TabIndex = 13;
            this.label1.Text = "Modules";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(765, 114);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EditPage
            // 
            this.EditPage.Location = new System.Drawing.Point(765, 155);
            this.EditPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EditPage.Name = "EditPage";
            this.EditPage.Size = new System.Drawing.Size(75, 23);
            this.EditPage.TabIndex = 15;
            this.EditPage.Text = "Edit";
            this.EditPage.UseVisualStyleBackColor = true;
            this.EditPage.Click += new System.EventHandler(this.EditPage_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(765, 196);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Remove";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(665, 457);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 17;
            this.button4.Text = "Cancel";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // PageNameInput
            // 
            this.PageNameInput.Location = new System.Drawing.Point(176, 48);
            this.PageNameInput.Margin = new System.Windows.Forms.Padding(4);
            this.PageNameInput.Name = "PageNameInput";
            this.PageNameInput.Size = new System.Drawing.Size(132, 22);
            this.PageNameInput.TabIndex = 18;
            this.PageNameInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 26);
            this.label2.TabIndex = 19;
            this.label2.Text = "Page name:";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(763, 457);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 20;
            this.button5.Text = "Create";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(171, 7);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(142, 26);
            this.NameLabel.TabIndex = 21;
            this.NameLabel.Text = "Report Name";
            // 
            // PageWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 494);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PageNameInput);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.EditPage);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.labelReportNamePage);
            this.Controls.Add(this.ReportNamePage);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PageWindow";
            this.Text = "PageWindow";
            this.Load += new System.EventHandler(this.PageWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ReportNamePage;
        private System.Windows.Forms.Label labelReportNamePage;
        private System.Windows.Forms.ListView listView1;
        public System.Windows.Forms.ColumnHeader ModuleName;
        public System.Windows.Forms.ColumnHeader ModuleSerialNr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button EditPage;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox PageNameInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label NameLabel;
    }
}