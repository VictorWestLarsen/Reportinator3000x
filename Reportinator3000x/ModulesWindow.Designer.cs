namespace Reportinator3000x
{
    partial class ModulesWindow
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
            this.ReportNameModules = new System.Windows.Forms.Label();
            this.labelReportNameModules = new System.Windows.Forms.Label();
            this.PageNrModules = new System.Windows.Forms.Label();
            this.labelPageNrModules = new System.Windows.Forms.Label();
            this.Parameters = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ParameterName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MinValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaxValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ReportNameModules
            // 
            this.ReportNameModules.AutoSize = true;
            this.ReportNameModules.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportNameModules.Location = new System.Drawing.Point(9, 7);
            this.ReportNameModules.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ReportNameModules.Name = "ReportNameModules";
            this.ReportNameModules.Size = new System.Drawing.Size(118, 22);
            this.ReportNameModules.TabIndex = 0;
            this.ReportNameModules.Text = "Report name:";
            // 
            // labelReportNameModules
            // 
            this.labelReportNameModules.AutoSize = true;
            this.labelReportNameModules.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReportNameModules.Location = new System.Drawing.Point(122, 7);
            this.labelReportNameModules.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelReportNameModules.Name = "labelReportNameModules";
            this.labelReportNameModules.Size = new System.Drawing.Size(111, 22);
            this.labelReportNameModules.TabIndex = 1;
            this.labelReportNameModules.Tag = "labelReportNameModules";
            this.labelReportNameModules.Text = "ReportName";
            // 
            // PageNrModules
            // 
            this.PageNrModules.AutoSize = true;
            this.PageNrModules.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageNrModules.Location = new System.Drawing.Point(9, 44);
            this.PageNrModules.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PageNrModules.Name = "PageNrModules";
            this.PageNrModules.Size = new System.Drawing.Size(122, 22);
            this.PageNrModules.TabIndex = 2;
            this.PageNrModules.Text = "Page number:";
            // 
            // labelPageNrModules
            // 
            this.labelPageNrModules.AutoSize = true;
            this.labelPageNrModules.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPageNrModules.Location = new System.Drawing.Point(127, 44);
            this.labelPageNrModules.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPageNrModules.Name = "labelPageNrModules";
            this.labelPageNrModules.Size = new System.Drawing.Size(71, 22);
            this.labelPageNrModules.TabIndex = 3;
            this.labelPageNrModules.Tag = "labelPageNrModules";
            this.labelPageNrModules.Text = "PageNr";
            // 
            // Parameters
            // 
            this.Parameters.AutoSize = true;
            this.Parameters.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Parameters.Location = new System.Drawing.Point(10, 93);
            this.Parameters.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Parameters.Name = "Parameters";
            this.Parameters.Size = new System.Drawing.Size(102, 22);
            this.Parameters.TabIndex = 4;
            this.Parameters.Text = "Parameters";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ParameterName,
            this.Type,
            this.MinValue,
            this.MaxValue});
            this.listView1.Location = new System.Drawing.Point(13, 116);
            this.listView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(545, 246);
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // ParameterName
            // 
            this.ParameterName.Tag = "ParameterName";
            this.ParameterName.Text = "Name";
            this.ParameterName.Width = 253;
            // 
            // Type
            // 
            this.Type.Tag = "Type";
            this.Type.Text = "Type";
            this.Type.Width = 69;
            // 
            // MinValue
            // 
            this.MinValue.Tag = "Min Value";
            this.MinValue.Text = "Minimum Value";
            this.MinValue.Width = 105;
            // 
            // MaxValue
            // 
            this.MaxValue.Tag = "MaxValue";
            this.MaxValue.Text = "Maximum Value";
            this.MaxValue.Width = 109;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(574, 116);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 14;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(574, 149);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 19);
            this.button2.TabIndex = 15;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(574, 181);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 19);
            this.button3.TabIndex = 16;
            this.button3.Text = "Remove";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(574, 343);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 19);
            this.button4.TabIndex = 17;
            this.button4.Text = "Cancel";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // ModulesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 401);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Parameters);
            this.Controls.Add(this.labelPageNrModules);
            this.Controls.Add(this.PageNrModules);
            this.Controls.Add(this.labelReportNameModules);
            this.Controls.Add(this.ReportNameModules);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ModulesWindow";
            this.Text = "ModulesWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ReportNameModules;
        private System.Windows.Forms.Label labelReportNameModules;
        private System.Windows.Forms.Label PageNrModules;
        private System.Windows.Forms.Label labelPageNrModules;
        private System.Windows.Forms.Label Parameters;
        private System.Windows.Forms.ListView listView1;
        public System.Windows.Forms.ColumnHeader ParameterName;
        public System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader MinValue;
        private System.Windows.Forms.ColumnHeader MaxValue;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}