﻿namespace Reportinator3000x
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
            this.DropdownModules = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ParameterPanel = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
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
            // DropdownModules
            // 
            this.DropdownModules.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DropdownModules.FormattingEnabled = true;
            this.DropdownModules.Location = new System.Drawing.Point(163, 82);
            this.DropdownModules.Name = "DropdownModules";
            this.DropdownModules.Size = new System.Drawing.Size(121, 21);
            this.DropdownModules.TabIndex = 18;
            this.DropdownModules.Tag = "DropdownModules";
            this.DropdownModules.SelectedIndexChanged += new System.EventHandler(this.DropdownModules_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 22);
            this.label1.TabIndex = 19;
            this.label1.Text = "Choose Modules:";
            // 
            // ParameterPanel
            // 
            this.ParameterPanel.ColumnCount = 2;
            this.ParameterPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ParameterPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ParameterPanel.Location = new System.Drawing.Point(13, 123);
            this.ParameterPanel.Name = "ParameterPanel";
            this.ParameterPanel.RowCount = 3;
            this.ParameterPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ParameterPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ParameterPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.ParameterPanel.Size = new System.Drawing.Size(314, 133);
            this.ParameterPanel.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(386, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 22;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddModuleBtn);
            // 
            // ModulesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 282);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ParameterPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DropdownModules);
            this.Controls.Add(this.labelPageNrModules);
            this.Controls.Add(this.PageNrModules);
            this.Controls.Add(this.labelReportNameModules);
            this.Controls.Add(this.ReportNameModules);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ModulesWindow";
            this.Text = "ModulesWindow";
            this.Load += new System.EventHandler(this.ModulesWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ReportNameModules;
        private System.Windows.Forms.Label labelReportNameModules;
        private System.Windows.Forms.Label PageNrModules;
        private System.Windows.Forms.Label labelPageNrModules;
        private System.Windows.Forms.ComboBox DropdownModules;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel ParameterPanel;
        private System.Windows.Forms.Button button1;
    }
}