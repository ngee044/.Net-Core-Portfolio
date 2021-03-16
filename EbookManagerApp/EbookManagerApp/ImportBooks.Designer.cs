namespace EbookManagerApp
{
    partial class ImportBooks
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportBooks));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btnSelectSourceFolder = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCancelNewStorageSpace = new System.Windows.Forms.Button();
            this.btnSaveNewStorageSpace = new System.Windows.Forms.Button();
            this.btnAddNewStorageSpace = new System.Windows.Forms.Button();
            this.lblStorageSpaceDescription = new System.Windows.Forms.Label();
            this.lblEbookCount = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.DlVirtualStorageSpaces = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.btnAddBookToStorageSpace = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "docx16.png");
            this.imageList1.Images.SetKeyName(1, "docxx16.png");
            this.imageList1.Images.SetKeyName(2, "epubx16.png");
            this.imageList1.Images.SetKeyName(3, "folder_exp_x16.png");
            this.imageList1.Images.SetKeyName(4, "folder-close-x16.png");
            this.imageList1.Images.SetKeyName(5, "pdfx16.png");
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(24, 55);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(528, 213);
            this.treeView1.TabIndex = 0;
            // 
            // btnSelectSourceFolder
            // 
            this.btnSelectSourceFolder.Location = new System.Drawing.Point(24, 26);
            this.btnSelectSourceFolder.Name = "btnSelectSourceFolder";
            this.btnSelectSourceFolder.Size = new System.Drawing.Size(168, 23);
            this.btnSelectSourceFolder.TabIndex = 1;
            this.btnSelectSourceFolder.Text = "Select source folder";
            this.btnSelectSourceFolder.UseVisualStyleBackColor = true;
            this.btnSelectSourceFolder.Click += new System.EventHandler(this.btnSelectSourceFolder_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.btnCancelNewStorageSpace);
            this.groupBox1.Controls.Add(this.btnSaveNewStorageSpace);
            this.groupBox1.Controls.Add(this.btnAddNewStorageSpace);
            this.groupBox1.Controls.Add(this.lblStorageSpaceDescription);
            this.groupBox1.Controls.Add(this.lblEbookCount);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.DlVirtualStorageSpaces);
            this.groupBox1.Location = new System.Drawing.Point(24, 283);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(528, 226);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Virtual storage spaces";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(194, 72);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(282, 112);
            this.textBox1.TabIndex = 3;
            // 
            // btnCancelNewStorageSpace
            // 
            this.btnCancelNewStorageSpace.Location = new System.Drawing.Point(409, 23);
            this.btnCancelNewStorageSpace.Name = "btnCancelNewStorageSpace";
            this.btnCancelNewStorageSpace.Size = new System.Drawing.Size(67, 23);
            this.btnCancelNewStorageSpace.TabIndex = 2;
            this.btnCancelNewStorageSpace.Text = "cancel";
            this.btnCancelNewStorageSpace.UseVisualStyleBackColor = true;
            // 
            // btnSaveNewStorageSpace
            // 
            this.btnSaveNewStorageSpace.Location = new System.Drawing.Point(330, 23);
            this.btnSaveNewStorageSpace.Name = "btnSaveNewStorageSpace";
            this.btnSaveNewStorageSpace.Size = new System.Drawing.Size(64, 23);
            this.btnSaveNewStorageSpace.TabIndex = 2;
            this.btnSaveNewStorageSpace.Text = "save";
            this.btnSaveNewStorageSpace.UseVisualStyleBackColor = true;
            // 
            // btnAddNewStorageSpace
            // 
            this.btnAddNewStorageSpace.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewStorageSpace.Image")));
            this.btnAddNewStorageSpace.Location = new System.Drawing.Point(134, 21);
            this.btnAddNewStorageSpace.Name = "btnAddNewStorageSpace";
            this.btnAddNewStorageSpace.Size = new System.Drawing.Size(34, 23);
            this.btnAddNewStorageSpace.TabIndex = 2;
            this.btnAddNewStorageSpace.UseVisualStyleBackColor = true;
            // 
            // lblStorageSpaceDescription
            // 
            this.lblStorageSpaceDescription.AutoSize = true;
            this.lblStorageSpaceDescription.Location = new System.Drawing.Point(192, 57);
            this.lblStorageSpaceDescription.Name = "lblStorageSpaceDescription";
            this.lblStorageSpaceDescription.Size = new System.Drawing.Size(159, 12);
            this.lblStorageSpaceDescription.TabIndex = 1;
            this.lblStorageSpaceDescription.Text = "Storage Space Description:";
            // 
            // lblEbookCount
            // 
            this.lblEbookCount.AutoSize = true;
            this.lblEbookCount.Location = new System.Drawing.Point(6, 57);
            this.lblEbookCount.Name = "lblEbookCount";
            this.lblEbookCount.Size = new System.Drawing.Size(86, 12);
            this.lblEbookCount.TabIndex = 1;
            this.lblEbookCount.Text = "lblEbookCount";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(194, 23);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 20);
            this.comboBox2.TabIndex = 0;
            // 
            // DlVirtualStorageSpaces
            // 
            this.DlVirtualStorageSpaces.FormattingEnabled = true;
            this.DlVirtualStorageSpaces.Location = new System.Drawing.Point(7, 21);
            this.DlVirtualStorageSpaces.Name = "DlVirtualStorageSpaces";
            this.DlVirtualStorageSpaces.Size = new System.Drawing.Size(121, 20);
            this.DlVirtualStorageSpaces.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(575, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(518, 213);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "File details";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(144, 115);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(308, 21);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(144, 88);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(308, 21);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(144, 180);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(308, 21);
            this.textBox5.TabIndex = 1;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(144, 147);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(308, 21);
            this.textBox4.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(144, 61);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(308, 21);
            this.textBox3.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "Size:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "File path:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "Created:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "Last accessed:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "File extension:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(144, 27);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(308, 21);
            this.textBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "File name:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dateTimePicker3);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.textBox12);
            this.groupBox3.Controls.Add(this.textBox11);
            this.groupBox3.Controls.Add(this.textBox10);
            this.groupBox3.Controls.Add(this.textBox9);
            this.groupBox3.Controls.Add(this.textBox8);
            this.groupBox3.Controls.Add(this.textBox7);
            this.groupBox3.Controls.Add(this.textBox6);
            this.groupBox3.Controls.Add(this.btnAddBookToStorageSpace);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(575, 283);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(518, 309);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Book details";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(133, 171);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(308, 21);
            this.dateTimePicker3.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(27, 230);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 12);
            this.label14.TabIndex = 0;
            this.label14.Text = "Classification:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(27, 201);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 12);
            this.label13.TabIndex = 0;
            this.label13.Text = "Category:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 177);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 12);
            this.label12.TabIndex = 0;
            this.label12.Text = "Date published:";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(133, 225);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(308, 21);
            this.textBox12.TabIndex = 1;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(133, 198);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(308, 21);
            this.textBox11.TabIndex = 1;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(133, 144);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(308, 21);
            this.textBox10.TabIndex = 1;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(133, 117);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(308, 21);
            this.textBox9.TabIndex = 1;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(133, 90);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(308, 21);
            this.textBox8.TabIndex = 1;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(133, 63);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(308, 21);
            this.textBox7.TabIndex = 1;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(133, 31);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(308, 21);
            this.textBox6.TabIndex = 1;
            // 
            // btnAddBookToStorageSpace
            // 
            this.btnAddBookToStorageSpace.Image = ((System.Drawing.Image)(resources.GetObject("btnAddBookToStorageSpace.Image")));
            this.btnAddBookToStorageSpace.Location = new System.Drawing.Point(82, 269);
            this.btnAddBookToStorageSpace.Name = "btnAddBookToStorageSpace";
            this.btnAddBookToStorageSpace.Size = new System.Drawing.Size(41, 34);
            this.btnAddBookToStorageSpace.TabIndex = 2;
            this.btnAddBookToStorageSpace.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 147);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 12);
            this.label11.TabIndex = 0;
            this.label11.Text = "ISBN:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "Price";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "Publisher:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "Author:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "Title:";
            // 
            // ImportBooks
            // 
            this.AcceptButton = this.btnSelectSourceFolder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 602);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSelectSourceFolder);
            this.Controls.Add(this.treeView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ImportBooks";
            this.Text = "ImportBooks";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btnSelectSourceFolder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancelNewStorageSpace;
        private System.Windows.Forms.Button btnSaveNewStorageSpace;
        private System.Windows.Forms.Button btnAddNewStorageSpace;
        private System.Windows.Forms.Label lblEbookCount;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox DlVirtualStorageSpaces;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblStorageSpaceDescription;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button btnAddBookToStorageSpace;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}