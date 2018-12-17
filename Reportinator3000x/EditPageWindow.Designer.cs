namespace Reportinator3000x
{
    partial class EditPageWindow
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Name");
            this.ReportNamePageWindow = new System.Windows.Forms.Label();
            this.NameLabePageWindow = new System.Windows.Forms.Label();
            this.PageLabelEditPage = new System.Windows.Forms.Label();
            this.InputEditPage = new System.Windows.Forms.TextBox();
            this.ModulesListEditPage = new System.Windows.Forms.ListView();
            this.ModulesEditPage = new System.Windows.Forms.Label();
            this.SaveEditPage = new System.Windows.Forms.Button();
            this.CancelEditPage = new System.Windows.Forms.Button();
            this.AddEditPage = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ReportNamePageWindow
            // 
            this.ReportNamePageWindow.AutoSize = true;
            this.ReportNamePageWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportNamePageWindow.Location = new System.Drawing.Point(9, 7);
            this.ReportNamePageWindow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ReportNamePageWindow.Name = "ReportNamePageWindow";
            this.ReportNamePageWindow.Size = new System.Drawing.Size(123, 22);
            this.ReportNamePageWindow.TabIndex = 0;
            this.ReportNamePageWindow.Text = "Report name: ";
            this.ReportNamePageWindow.Click += new System.EventHandler(this.ReportNamePageWindow_Click);
            // 
            // NameLabePageWindow
            // 
            this.NameLabePageWindow.AutoSize = true;
            this.NameLabePageWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabePageWindow.Location = new System.Drawing.Point(126, 7);
            this.NameLabePageWindow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameLabePageWindow.Name = "NameLabePageWindow";
            this.NameLabePageWindow.Size = new System.Drawing.Size(111, 22);
            this.NameLabePageWindow.TabIndex = 1;
            this.NameLabePageWindow.Text = "ReportName";
            this.NameLabePageWindow.Click += new System.EventHandler(this.label1_Click);
            // 
            // PageLabelEditPage
            // 
            this.PageLabelEditPage.AutoSize = true;
            this.PageLabelEditPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageLabelEditPage.Location = new System.Drawing.Point(9, 41);
            this.PageLabelEditPage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PageLabelEditPage.Name = "PageLabelEditPage";
            this.PageLabelEditPage.Size = new System.Drawing.Size(106, 22);
            this.PageLabelEditPage.TabIndex = 2;
            this.PageLabelEditPage.Text = "Page name:";
            // 
            // InputEditPage
            // 
            this.InputEditPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputEditPage.Location = new System.Drawing.Point(130, 45);
            this.InputEditPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.InputEditPage.Name = "InputEditPage";
            this.InputEditPage.Size = new System.Drawing.Size(99, 19);
            this.InputEditPage.TabIndex = 3;
            // 
            // ModulesListEditPage
            // 
            this.ModulesListEditPage.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.ModulesListEditPage.Location = new System.Drawing.Point(9, 93);
            this.ModulesListEditPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ModulesListEditPage.Name = "ModulesListEditPage";
            this.ModulesListEditPage.Size = new System.Drawing.Size(549, 258);
            this.ModulesListEditPage.TabIndex = 4;
            this.ModulesListEditPage.UseCompatibleStateImageBehavior = false;
            // 
            // ModulesEditPage
            // 
            this.ModulesEditPage.AutoSize = true;
            this.ModulesEditPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModulesEditPage.Location = new System.Drawing.Point(9, 70);
            this.ModulesEditPage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ModulesEditPage.Name = "ModulesEditPage";
            this.ModulesEditPage.Size = new System.Drawing.Size(77, 22);
            this.ModulesEditPage.TabIndex = 5;
            this.ModulesEditPage.Text = "Modules";
            // 
            // SaveEditPage
            // 
            this.SaveEditPage.Location = new System.Drawing.Point(574, 120);
            this.SaveEditPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SaveEditPage.Name = "SaveEditPage";
            this.SaveEditPage.Size = new System.Drawing.Size(56, 19);
            this.SaveEditPage.TabIndex = 6;
            this.SaveEditPage.Text = "Save";
            this.SaveEditPage.UseVisualStyleBackColor = true;
            // 
            // CancelEditPage
            // 
            this.CancelEditPage.Location = new System.Drawing.Point(574, 144);
            this.CancelEditPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CancelEditPage.Name = "CancelEditPage";
            this.CancelEditPage.Size = new System.Drawing.Size(56, 19);
            this.CancelEditPage.TabIndex = 7;
            this.CancelEditPage.Text = "Cancel";
            this.CancelEditPage.UseVisualStyleBackColor = true;
            // 
            // AddEditPage
            // 
            this.AddEditPage.Location = new System.Drawing.Point(574, 93);
            this.AddEditPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddEditPage.Name = "AddEditPage";
            this.AddEditPage.Size = new System.Drawing.Size(56, 19);
            this.AddEditPage.TabIndex = 8;
            this.AddEditPage.Text = "Add";
            this.AddEditPage.UseVisualStyleBackColor = true;
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(502, 69);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(56, 19);
            this.refreshButton.TabIndex = 9;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // EditPageWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 401);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.AddEditPage);
            this.Controls.Add(this.CancelEditPage);
            this.Controls.Add(this.SaveEditPage);
            this.Controls.Add(this.ModulesEditPage);
            this.Controls.Add(this.ModulesListEditPage);
            this.Controls.Add(this.InputEditPage);
            this.Controls.Add(this.PageLabelEditPage);
            this.Controls.Add(this.NameLabePageWindow);
            this.Controls.Add(this.ReportNamePageWindow);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EditPageWindow";
            this.Text = "EditPageWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ReportNamePageWindow;
        private System.Windows.Forms.Label NameLabePageWindow;
        private System.Windows.Forms.Label PageLabelEditPage;
        private System.Windows.Forms.TextBox InputEditPage;
        private System.Windows.Forms.ListView ModulesListEditPage;
        private System.Windows.Forms.Label ModulesEditPage;
        private System.Windows.Forms.Button SaveEditPage;
        private System.Windows.Forms.Button CancelEditPage;
        private System.Windows.Forms.Button AddEditPage;
        private System.Windows.Forms.Button refreshButton;
    }
}