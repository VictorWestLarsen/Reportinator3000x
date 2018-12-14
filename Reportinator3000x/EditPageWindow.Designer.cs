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
            this.ReportNamePageWindow = new System.Windows.Forms.Label();
            this.NameLabePageWindow = new System.Windows.Forms.Label();
            this.PageLabelEditPage = new System.Windows.Forms.Label();
            this.InputEditPage = new System.Windows.Forms.TextBox();
            this.ModulesListEditPage = new System.Windows.Forms.ListView();
            this.ModulesEditPage = new System.Windows.Forms.Label();
            this.SaveEditPage = new System.Windows.Forms.Button();
            this.CancelEditPage = new System.Windows.Forms.Button();
            this.AddEditPage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ReportNamePageWindow
            // 
            this.ReportNamePageWindow.AutoSize = true;
            this.ReportNamePageWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportNamePageWindow.Location = new System.Drawing.Point(12, 9);
            this.ReportNamePageWindow.Name = "ReportNamePageWindow";
            this.ReportNamePageWindow.Size = new System.Drawing.Size(150, 26);
            this.ReportNamePageWindow.TabIndex = 0;
            this.ReportNamePageWindow.Text = "Report name: ";
            this.ReportNamePageWindow.Click += new System.EventHandler(this.ReportNamePageWindow_Click);
            // 
            // NameLabePageWindow
            // 
            this.NameLabePageWindow.AutoSize = true;
            this.NameLabePageWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabePageWindow.Location = new System.Drawing.Point(168, 9);
            this.NameLabePageWindow.Name = "NameLabePageWindow";
            this.NameLabePageWindow.Size = new System.Drawing.Size(136, 26);
            this.NameLabePageWindow.TabIndex = 1;
            this.NameLabePageWindow.Text = "ReportName";
            this.NameLabePageWindow.Click += new System.EventHandler(this.label1_Click);
            // 
            // PageLabelEditPage
            // 
            this.PageLabelEditPage.AutoSize = true;
            this.PageLabelEditPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageLabelEditPage.Location = new System.Drawing.Point(12, 50);
            this.PageLabelEditPage.Name = "PageLabelEditPage";
            this.PageLabelEditPage.Size = new System.Drawing.Size(130, 26);
            this.PageLabelEditPage.TabIndex = 2;
            this.PageLabelEditPage.Text = "Page name:";
            // 
            // InputEditPage
            // 
            this.InputEditPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputEditPage.Location = new System.Drawing.Point(173, 55);
            this.InputEditPage.Name = "InputEditPage";
            this.InputEditPage.Size = new System.Drawing.Size(131, 22);
            this.InputEditPage.TabIndex = 3;
            // 
            // ModulesListEditPage
            // 
            this.ModulesListEditPage.Location = new System.Drawing.Point(12, 115);
            this.ModulesListEditPage.Name = "ModulesListEditPage";
            this.ModulesListEditPage.Size = new System.Drawing.Size(731, 317);
            this.ModulesListEditPage.TabIndex = 4;
            this.ModulesListEditPage.UseCompatibleStateImageBehavior = false;
            // 
            // ModulesEditPage
            // 
            this.ModulesEditPage.AutoSize = true;
            this.ModulesEditPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModulesEditPage.Location = new System.Drawing.Point(12, 86);
            this.ModulesEditPage.Name = "ModulesEditPage";
            this.ModulesEditPage.Size = new System.Drawing.Size(94, 26);
            this.ModulesEditPage.TabIndex = 5;
            this.ModulesEditPage.Text = "Modules";
            // 
            // SaveEditPage
            // 
            this.SaveEditPage.Location = new System.Drawing.Point(766, 148);
            this.SaveEditPage.Name = "SaveEditPage";
            this.SaveEditPage.Size = new System.Drawing.Size(75, 23);
            this.SaveEditPage.TabIndex = 6;
            this.SaveEditPage.Text = "Save";
            this.SaveEditPage.UseVisualStyleBackColor = true;
            // 
            // CancelEditPage
            // 
            this.CancelEditPage.Location = new System.Drawing.Point(766, 177);
            this.CancelEditPage.Name = "CancelEditPage";
            this.CancelEditPage.Size = new System.Drawing.Size(75, 23);
            this.CancelEditPage.TabIndex = 7;
            this.CancelEditPage.Text = "Cancel";
            this.CancelEditPage.UseVisualStyleBackColor = true;
            // 
            // AddEditPage
            // 
            this.AddEditPage.Location = new System.Drawing.Point(766, 115);
            this.AddEditPage.Name = "AddEditPage";
            this.AddEditPage.Size = new System.Drawing.Size(75, 23);
            this.AddEditPage.TabIndex = 8;
            this.AddEditPage.Text = "Add";
            this.AddEditPage.UseVisualStyleBackColor = true;
            // 
            // EditPageWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 494);
            this.Controls.Add(this.AddEditPage);
            this.Controls.Add(this.CancelEditPage);
            this.Controls.Add(this.SaveEditPage);
            this.Controls.Add(this.ModulesEditPage);
            this.Controls.Add(this.ModulesListEditPage);
            this.Controls.Add(this.InputEditPage);
            this.Controls.Add(this.PageLabelEditPage);
            this.Controls.Add(this.NameLabePageWindow);
            this.Controls.Add(this.ReportNamePageWindow);
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
    }
}