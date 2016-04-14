namespace CashRegister
{
    partial class Form1
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
            this.lblID = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.TextBox();
            this.cmd1 = new System.Windows.Forms.Button();
            this.cmd2 = new System.Windows.Forms.Button();
            this.cmd3 = new System.Windows.Forms.Button();
            this.cmd6 = new System.Windows.Forms.Button();
            this.cmd5 = new System.Windows.Forms.Button();
            this.cmd4 = new System.Windows.Forms.Button();
            this.cmd9 = new System.Windows.Forms.Button();
            this.cmd8 = new System.Windows.Forms.Button();
            this.cmd7 = new System.Windows.Forms.Button();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.cmd0 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Total = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tax = new System.Windows.Forms.Label();
            this.cmdSave = new System.Windows.Forms.Button();
            this.Itemlist = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price";
            // 
            // lblID
            // 
            this.lblID.Location = new System.Drawing.Point(59, 11);
            this.lblID.Margin = new System.Windows.Forms.Padding(2);
            this.lblID.MaxLength = 10;
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(131, 20);
            this.lblID.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.SystemColors.Window;
            this.lblName.Enabled = false;
            this.lblName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblName.Location = new System.Drawing.Point(59, 34);
            this.lblName.Margin = new System.Windows.Forms.Padding(2);
            this.lblName.MaxLength = 20;
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(131, 20);
            this.lblName.TabIndex = 4;
            // 
            // lblPrice
            // 
            this.lblPrice.BackColor = System.Drawing.SystemColors.Window;
            this.lblPrice.Enabled = false;
            this.lblPrice.Location = new System.Drawing.Point(59, 58);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(2);
            this.lblPrice.MaxLength = 15;
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(131, 20);
            this.lblPrice.TabIndex = 5;
            // 
            // cmd1
            // 
            this.cmd1.Location = new System.Drawing.Point(11, 89);
            this.cmd1.Margin = new System.Windows.Forms.Padding(2);
            this.cmd1.Name = "cmd1";
            this.cmd1.Size = new System.Drawing.Size(56, 50);
            this.cmd1.TabIndex = 6;
            this.cmd1.Text = "1";
            this.cmd1.UseVisualStyleBackColor = true;
            this.cmd1.Click += new System.EventHandler(this.cmd1_Click);
            // 
            // cmd2
            // 
            this.cmd2.Location = new System.Drawing.Point(72, 89);
            this.cmd2.Margin = new System.Windows.Forms.Padding(2);
            this.cmd2.Name = "cmd2";
            this.cmd2.Size = new System.Drawing.Size(56, 50);
            this.cmd2.TabIndex = 7;
            this.cmd2.Text = "2";
            this.cmd2.UseVisualStyleBackColor = true;
            this.cmd2.Click += new System.EventHandler(this.cmd2_Click);
            // 
            // cmd3
            // 
            this.cmd3.Location = new System.Drawing.Point(133, 89);
            this.cmd3.Margin = new System.Windows.Forms.Padding(2);
            this.cmd3.Name = "cmd3";
            this.cmd3.Size = new System.Drawing.Size(56, 50);
            this.cmd3.TabIndex = 8;
            this.cmd3.Text = "3";
            this.cmd3.UseVisualStyleBackColor = true;
            this.cmd3.Click += new System.EventHandler(this.cmd3_Click);
            // 
            // cmd6
            // 
            this.cmd6.Location = new System.Drawing.Point(133, 144);
            this.cmd6.Margin = new System.Windows.Forms.Padding(2);
            this.cmd6.Name = "cmd6";
            this.cmd6.Size = new System.Drawing.Size(56, 50);
            this.cmd6.TabIndex = 11;
            this.cmd6.Text = "6";
            this.cmd6.UseVisualStyleBackColor = true;
            this.cmd6.Click += new System.EventHandler(this.cmd6_Click);
            // 
            // cmd5
            // 
            this.cmd5.Location = new System.Drawing.Point(72, 144);
            this.cmd5.Margin = new System.Windows.Forms.Padding(2);
            this.cmd5.Name = "cmd5";
            this.cmd5.Size = new System.Drawing.Size(56, 50);
            this.cmd5.TabIndex = 10;
            this.cmd5.Text = "5";
            this.cmd5.UseVisualStyleBackColor = true;
            this.cmd5.Click += new System.EventHandler(this.cmd5_Click);
            // 
            // cmd4
            // 
            this.cmd4.Location = new System.Drawing.Point(11, 144);
            this.cmd4.Margin = new System.Windows.Forms.Padding(2);
            this.cmd4.Name = "cmd4";
            this.cmd4.Size = new System.Drawing.Size(56, 50);
            this.cmd4.TabIndex = 9;
            this.cmd4.Text = "4";
            this.cmd4.UseVisualStyleBackColor = true;
            this.cmd4.Click += new System.EventHandler(this.cmd4_Click);
            // 
            // cmd9
            // 
            this.cmd9.Location = new System.Drawing.Point(133, 199);
            this.cmd9.Margin = new System.Windows.Forms.Padding(2);
            this.cmd9.Name = "cmd9";
            this.cmd9.Size = new System.Drawing.Size(56, 50);
            this.cmd9.TabIndex = 14;
            this.cmd9.Text = "9";
            this.cmd9.UseVisualStyleBackColor = true;
            this.cmd9.Click += new System.EventHandler(this.cmd9_Click);
            // 
            // cmd8
            // 
            this.cmd8.Location = new System.Drawing.Point(72, 199);
            this.cmd8.Margin = new System.Windows.Forms.Padding(2);
            this.cmd8.Name = "cmd8";
            this.cmd8.Size = new System.Drawing.Size(56, 50);
            this.cmd8.TabIndex = 13;
            this.cmd8.Text = "8";
            this.cmd8.UseVisualStyleBackColor = true;
            this.cmd8.Click += new System.EventHandler(this.cmd8_Click);
            // 
            // cmd7
            // 
            this.cmd7.Location = new System.Drawing.Point(11, 199);
            this.cmd7.Margin = new System.Windows.Forms.Padding(2);
            this.cmd7.Name = "cmd7";
            this.cmd7.Size = new System.Drawing.Size(56, 50);
            this.cmd7.TabIndex = 12;
            this.cmd7.Text = "7";
            this.cmd7.UseVisualStyleBackColor = true;
            this.cmd7.Click += new System.EventHandler(this.cmd7_Click);
            // 
            // cmdAdd
            // 
            this.cmdAdd.Location = new System.Drawing.Point(13, 346);
            this.cmdAdd.Margin = new System.Windows.Forms.Padding(2);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(176, 35);
            this.cmdAdd.TabIndex = 15;
            this.cmdAdd.Text = "Add";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdInsert_Click);
            // 
            // cmdDelete
            // 
            this.cmdDelete.Enabled = false;
            this.cmdDelete.Location = new System.Drawing.Point(11, 307);
            this.cmdDelete.Margin = new System.Windows.Forms.Padding(2);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(176, 35);
            this.cmdDelete.TabIndex = 17;
            this.cmdDelete.Text = "Delete";
            this.cmdDelete.UseVisualStyleBackColor = true;
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // cmd0
            // 
            this.cmd0.Location = new System.Drawing.Point(72, 253);
            this.cmd0.Margin = new System.Windows.Forms.Padding(2);
            this.cmd0.Name = "cmd0";
            this.cmd0.Size = new System.Drawing.Size(56, 50);
            this.cmd0.TabIndex = 19;
            this.cmd0.Text = "0";
            this.cmd0.UseVisualStyleBackColor = true;
            this.cmd0.Click += new System.EventHandler(this.cmd0_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(11, 253);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 50);
            this.button1.TabIndex = 20;
            this.button1.Text = ".";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(134, 253);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 50);
            this.button2.TabIndex = 21;
            this.button2.Text = "Enter";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(451, 399);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(34, 13);
            this.Total.TabIndex = 22;
            this.Total.Text = "Total:";
            // 
            // listBox1
            // 
            this.listBox1.Location = new System.Drawing.Point(210, 11);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(350, 342);
            this.listBox1.TabIndex = 25;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // tax
            // 
            this.tax.AutoSize = true;
            this.tax.Location = new System.Drawing.Point(231, 399);
            this.tax.Name = "tax";
            this.tax.Size = new System.Drawing.Size(28, 13);
            this.tax.TabIndex = 24;
            this.tax.Text = "Tax:";
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(14, 388);
            this.cmdSave.Margin = new System.Windows.Forms.Padding(2);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(176, 35);
            this.cmdSave.TabIndex = 25;
            this.cmdSave.Text = "Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            // 
            // Itemlist
            // 
            this.Itemlist.Location = new System.Drawing.Point(541, 420);
            this.Itemlist.Name = "Itemlist";
            this.Itemlist.Size = new System.Drawing.Size(106, 23);
            this.Itemlist.TabIndex = 26;
            this.Itemlist.Text = "Open Itemlist";
            this.Itemlist.UseVisualStyleBackColor = true;
            this.Itemlist.Click += new System.EventHandler(this.Itemlist_Click);
            // 
            // txtId
            // 
            this.txtId.FormattingEnabled = true;
            this.txtId.Location = new System.Drawing.Point(210, 359);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(121, 21);
            this.txtId.TabIndex = 27;
            this.txtId.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 445);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.Itemlist);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.tax);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmd0);
            this.Controls.Add(this.cmdDelete);
            this.Controls.Add(this.cmdAdd);
            this.Controls.Add(this.cmd9);
            this.Controls.Add(this.cmd8);
            this.Controls.Add(this.cmd7);
            this.Controls.Add(this.cmd6);
            this.Controls.Add(this.cmd5);
            this.Controls.Add(this.cmd4);
            this.Controls.Add(this.cmd3);
            this.Controls.Add(this.cmd2);
            this.Controls.Add(this.cmd1);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Cash Register";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lblID;
        private System.Windows.Forms.TextBox lblName;
        private System.Windows.Forms.TextBox lblPrice;
        private System.Windows.Forms.Button cmd1;
        private System.Windows.Forms.Button cmd2;
        private System.Windows.Forms.Button cmd3;
        private System.Windows.Forms.Button cmd6;
        private System.Windows.Forms.Button cmd5;
        private System.Windows.Forms.Button cmd4;
        private System.Windows.Forms.Button cmd9;
        private System.Windows.Forms.Button cmd8;
        private System.Windows.Forms.Button cmd7;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.Button cmdDelete;
        private System.Windows.Forms.Button cmd0;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label tax;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Button Itemlist;
        private System.Windows.Forms.ComboBox txtId;
    }
}

