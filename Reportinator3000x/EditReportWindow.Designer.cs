namespace Reportinator3000x
{
    partial class EditReportWindow
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
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CustomerInput = new System.Windows.Forms.TextBox();
            this.EmailInput = new System.Windows.Forms.TextBox();
            this.IntervalInput = new System.Windows.Forms.TextBox();
            this.ReportNameInput = new System.Windows.Forms.TextBox();
            this.PageList = new System.Windows.Forms.ListView();
            this.Page = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PageNr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label6 = new System.Windows.Forms.Label();
            this.AddPageButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.RemovePageButton_click = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(573, 365);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(56, 25);
            this.button5.TabIndex = 17;
            this.button5.Tag = "ReportCreate";
            this.button5.Text = "Modify";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(513, 365);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 25);
            this.button4.TabIndex = 18;
            this.button4.Tag = "ReportCancel";
            this.button4.Text = "Cancel";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Ford",
            "Audi",
            "BMW",
            "Renault",
            "Citroën",
            "Dacia",
            "Lancia",
            "Lada",
            "Mitsubishi",
            "Mazda",
            "Kia",
            "Hyundai",
            "Nissan",
            "Honda",
            "Isuzu",
            "Mercedes-Benz",
            "Bugatti",
            "Saab",
            "Volvo",
            "Daihatsu",
            "Jeep",
            "Cadillac",
            "Hummer",
            "Range Rover",
            "Land Rover",
            "Mini",
            "Dodge",
            "Chervolet",
            "Corvette",
            "Jaguar",
            "Aston Martin",
            "Oldsmobile",
            "Volkswagen",
            "Opel",
            "Toyota",
            "Subaru",
            "Brabus",
            "Alfa Romeo",
            "Fiat",
            "Ferrari",
            "Lamborghini",
            "McLaren",
            "Zenvo",
            "Ariel",
            "Noble",
            "Caterham",
            "Lotus",
            "Tesla",
            "Škoda",
            "Abarth",
            "Acura",
            "Arash",
            "Ascari",
            "Bentley",
            "Bowler",
            "BAC",
            "Bristol Cars",
            "Brooke Cars",
            "Buick",
            "Caparo",
            "Chery",
            "Chrysler",
            "Datsun",
            "Donkervoort",
            "Fisker",
            "Ginetta",
            "GMC",
            "Hennessey",
            "Holden",
            "Infinity",
            "Joss",
            "Kamaz",
            "Koenigsegg",
            "KTM",
            "Lexus",
            "Lister",
            "Lincoln",
            "Mahindra",
            "Maserati",
            "Mastretta",
            "MG",
            "Morgan",
            "Pagani",
            "Perodua",
            "Porsche",
            "Proton",
            "Radical",
            "Ram",
            "Roewe",
            "Rolls-Royce",
            "RUF",
            "Saleen",
            "Scion",
            "Seat",
            "Smart",
            "SRT",
            "SsangYong",
            "Superformance",
            "Tata",
            "TVR",
            "Ultima",
            "Vauxhall",
            "Venturi",
            "Westfield",
            "Wiesmann"});
            this.checkedListBox1.Location = new System.Drawing.Point(142, 120);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(133, 214);
            this.checkedListBox1.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(2, 120);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 22);
            this.label5.TabIndex = 20;
            this.label5.Text = "Logo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 87);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 22);
            this.label4.TabIndex = 21;
            this.label4.Text = "Report name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 22);
            this.label3.TabIndex = 22;
            this.label3.Text = "Interval:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 22);
            this.label2.TabIndex = 23;
            this.label2.Text = "Email:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 22);
            this.label1.TabIndex = 24;
            this.label1.Text = "Customer:";
            // 
            // CustomerInput
            // 
            this.CustomerInput.Location = new System.Drawing.Point(142, 11);
            this.CustomerInput.Margin = new System.Windows.Forms.Padding(2);
            this.CustomerInput.Name = "CustomerInput";
            this.CustomerInput.Size = new System.Drawing.Size(133, 20);
            this.CustomerInput.TabIndex = 25;
            this.CustomerInput.TextChanged += new System.EventHandler(this.CustomerInput_TextChanged);
            // 
            // EmailInput
            // 
            this.EmailInput.Location = new System.Drawing.Point(142, 36);
            this.EmailInput.Margin = new System.Windows.Forms.Padding(2);
            this.EmailInput.Name = "EmailInput";
            this.EmailInput.Size = new System.Drawing.Size(133, 20);
            this.EmailInput.TabIndex = 26;
            // 
            // IntervalInput
            // 
            this.IntervalInput.Location = new System.Drawing.Point(142, 63);
            this.IntervalInput.Margin = new System.Windows.Forms.Padding(2);
            this.IntervalInput.Name = "IntervalInput";
            this.IntervalInput.Size = new System.Drawing.Size(133, 20);
            this.IntervalInput.TabIndex = 27;
            // 
            // ReportNameInput
            // 
            this.ReportNameInput.Location = new System.Drawing.Point(142, 89);
            this.ReportNameInput.Margin = new System.Windows.Forms.Padding(2);
            this.ReportNameInput.Name = "ReportNameInput";
            this.ReportNameInput.Size = new System.Drawing.Size(133, 20);
            this.ReportNameInput.TabIndex = 28;
            // 
            // PageList
            // 
            this.PageList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Page,
            this.PageNr});
            this.PageList.Location = new System.Drawing.Point(288, 120);
            this.PageList.Margin = new System.Windows.Forms.Padding(2);
            this.PageList.MultiSelect = false;
            this.PageList.Name = "PageList";
            this.PageList.Size = new System.Drawing.Size(261, 214);
            this.PageList.TabIndex = 29;
            this.PageList.UseCompatibleStateImageBehavior = false;
            this.PageList.View = System.Windows.Forms.View.Details;
            // 
            // Page
            // 
            this.Page.Tag = "Page";
            this.Page.Text = "Page";
            this.Page.Width = 327;
            // 
            // PageNr
            // 
            this.PageNr.Tag = "Page";
            this.PageNr.Text = "PageNr";
            this.PageNr.Width = 63;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(284, 87);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 22);
            this.label6.TabIndex = 30;
            this.label6.Text = "Pages:";
            // 
            // AddPageButton
            // 
            this.AddPageButton.Location = new System.Drawing.Point(573, 123);
            this.AddPageButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddPageButton.Name = "AddPageButton";
            this.AddPageButton.Size = new System.Drawing.Size(56, 19);
            this.AddPageButton.TabIndex = 31;
            this.AddPageButton.Tag = "AddPage";
            this.AddPageButton.Text = "Add";
            this.AddPageButton.UseVisualStyleBackColor = true;
            this.AddPageButton.Click += new System.EventHandler(this.AddPageButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(573, 146);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 19);
            this.button2.TabIndex = 32;
            this.button2.Tag = "EditPage";
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // RemovePageButton_click
            // 
            this.RemovePageButton_click.Location = new System.Drawing.Point(573, 169);
            this.RemovePageButton_click.Margin = new System.Windows.Forms.Padding(2);
            this.RemovePageButton_click.Name = "RemovePageButton_click";
            this.RemovePageButton_click.Size = new System.Drawing.Size(56, 19);
            this.RemovePageButton_click.TabIndex = 33;
            this.RemovePageButton_click.Tag = "RemovePage";
            this.RemovePageButton_click.Text = "Remove";
            this.RemovePageButton_click.UseVisualStyleBackColor = true;
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(473, 85);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(75, 23);
            this.RefreshButton.TabIndex = 34;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // EditReportWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 401);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.RemovePageButton_click);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.AddPageButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PageList);
            this.Controls.Add(this.ReportNameInput);
            this.Controls.Add(this.IntervalInput);
            this.Controls.Add(this.EmailInput);
            this.Controls.Add(this.CustomerInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Name = "EditReportWindow";
            this.Text = "Edit Report";
            this.Load += new System.EventHandler(this.EditReportWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CustomerInput;
        private System.Windows.Forms.TextBox EmailInput;
        private System.Windows.Forms.TextBox IntervalInput;
        private System.Windows.Forms.TextBox ReportNameInput;
        private System.Windows.Forms.ListView PageList;
        public System.Windows.Forms.ColumnHeader Page;
        public System.Windows.Forms.ColumnHeader PageNr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AddPageButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button RemovePageButton_click;
        private System.Windows.Forms.Button RefreshButton;
    }
}