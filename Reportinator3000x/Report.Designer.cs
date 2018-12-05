namespace Reportinator3000x
{
    partial class Report
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CustomerInput = new System.Windows.Forms.TextBox();
            this.NameInput = new System.Windows.Forms.TextBox();
            this.IntervalInput = new System.Windows.Forms.TextBox();
            this.EmailInput = new System.Windows.Forms.TextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Page = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PageNr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Interval:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 94);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Report name:";
            // 
            // CustomerInput
            // 
            this.CustomerInput.Location = new System.Drawing.Point(114, 9);
            this.CustomerInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CustomerInput.Name = "CustomerInput";
            this.CustomerInput.Size = new System.Drawing.Size(133, 20);
            this.CustomerInput.TabIndex = 4;
            this.CustomerInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // NameInput
            // 
            this.NameInput.Location = new System.Drawing.Point(114, 98);
            this.NameInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(133, 20);
            this.NameInput.TabIndex = 5;
            // 
            // IntervalInput
            // 
            this.IntervalInput.ForeColor = System.Drawing.SystemColors.GrayText;
            this.IntervalInput.Location = new System.Drawing.Point(114, 67);
            this.IntervalInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.IntervalInput.Name = "IntervalInput";
            this.IntervalInput.Size = new System.Drawing.Size(133, 20);
            this.IntervalInput.TabIndex = 6;
            // 
            // EmailInput
            // 
            this.EmailInput.Location = new System.Drawing.Point(114, 36);
            this.EmailInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EmailInput.Name = "EmailInput";
            this.EmailInput.Size = new System.Drawing.Size(133, 20);
            this.EmailInput.TabIndex = 7;
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
            this.checkedListBox1.Location = new System.Drawing.Point(114, 131);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(133, 199);
            this.checkedListBox1.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(2, 131);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Logo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(264, 98);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Pages:";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Page,
            this.PageNr});
            this.listView1.Location = new System.Drawing.Point(268, 131);
            this.listView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(296, 211);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(578, 131);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 12;
            this.button1.Tag = "AddPage";
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(578, 154);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 19);
            this.button2.TabIndex = 13;
            this.button2.Tag = "EditPage";
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(578, 178);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 19);
            this.button3.TabIndex = 14;
            this.button3.Tag = "RemovePage";
            this.button3.Text = "Remove";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(66, 372);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 19);
            this.button4.TabIndex = 15;
            this.button4.Tag = "ReportCancel";
            this.button4.Text = "Cancel";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(5, 372);
            this.button5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(56, 19);
            this.button5.TabIndex = 16;
            this.button5.Tag = "ReportCreate";
            this.button5.Text = "Create";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 401);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.EmailInput);
            this.Controls.Add(this.IntervalInput);
            this.Controls.Add(this.NameInput);
            this.Controls.Add(this.CustomerInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Report";
            this.Text = "Report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CustomerInput;
        private System.Windows.Forms.TextBox NameInput;
        private System.Windows.Forms.TextBox IntervalInput;
        private System.Windows.Forms.TextBox EmailInput;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView listView1;
        public System.Windows.Forms.ColumnHeader Page;
        public System.Windows.Forms.ColumnHeader PageNr;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}