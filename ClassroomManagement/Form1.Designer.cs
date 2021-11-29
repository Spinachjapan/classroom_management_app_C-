
namespace ClassroomManagement
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.date_textbox = new System.Windows.Forms.MaskedTextBox();
            this.room_textbox = new System.Windows.Forms.MaskedTextBox();
            this.class_textbox = new System.Windows.Forms.MaskedTextBox();
            this.teacher_textbox = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.classroom_gridview = new System.Windows.Forms.DataGridView();
            this.Column0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.find_textfield = new System.Windows.Forms.TextBox();
            this.exit_button = new System.Windows.Forms.Button();
            this.sort_button = new System.Windows.Forms.Button();
            this.save_raf_button = new System.Windows.Forms.Button();
            this.find_button = new System.Windows.Forms.Button();
            this.save_change_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classroom_gridview)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1974, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(72, 36);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(228, 44);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(228, 44);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(228, 44);
            this.saveAsToolStripMenuItem.Text = "Save as";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(228, 44);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.date_textbox);
            this.panel1.Controls.Add(this.room_textbox);
            this.panel1.Controls.Add(this.class_textbox);
            this.panel1.Controls.Add(this.teacher_textbox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 54);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1974, 100);
            this.panel1.TabIndex = 1;
            // 
            // date_textbox
            // 
            this.date_textbox.Location = new System.Drawing.Point(1110, 39);
            this.date_textbox.Name = "date_textbox";
            this.date_textbox.Size = new System.Drawing.Size(153, 31);
            this.date_textbox.TabIndex = 6;
            // 
            // room_textbox
            // 
            this.room_textbox.Location = new System.Drawing.Point(790, 42);
            this.room_textbox.Name = "room_textbox";
            this.room_textbox.Size = new System.Drawing.Size(153, 31);
            this.room_textbox.TabIndex = 5;
            // 
            // class_textbox
            // 
            this.class_textbox.Location = new System.Drawing.Point(441, 42);
            this.class_textbox.Name = "class_textbox";
            this.class_textbox.Size = new System.Drawing.Size(153, 31);
            this.class_textbox.TabIndex = 4;
            // 
            // teacher_textbox
            // 
            this.teacher_textbox.Location = new System.Drawing.Point(131, 42);
            this.teacher_textbox.Name = "teacher_textbox";
            this.teacher_textbox.Size = new System.Drawing.Size(153, 31);
            this.teacher_textbox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1025, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Teacher:";
            // 
            // label2
            // 
            this.label2.AccessibleName = "qqq";
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(363, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Class:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(710, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room:";
            // 
            // classroom_gridview
            // 
            this.classroom_gridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.classroom_gridview.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.classroom_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.classroom_gridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column0,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.classroom_gridview.Location = new System.Drawing.Point(0, 161);
            this.classroom_gridview.Name = "classroom_gridview";
            this.classroom_gridview.RowHeadersWidth = 82;
            this.classroom_gridview.RowTemplate.Height = 33;
            this.classroom_gridview.Size = new System.Drawing.Size(1974, 1012);
            this.classroom_gridview.TabIndex = 2;
            // 
            // Column0
            // 
            this.Column0.HeaderText = "0";
            this.Column0.MinimumWidth = 10;
            this.Column0.Name = "Column0";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "1";
            this.Column1.MinimumWidth = 10;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "2";
            this.Column2.MinimumWidth = 10;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "3";
            this.Column3.MinimumWidth = 10;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "4";
            this.Column4.MinimumWidth = 10;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "5";
            this.Column5.MinimumWidth = 10;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "6";
            this.Column6.MinimumWidth = 10;
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "7";
            this.Column7.MinimumWidth = 10;
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "8";
            this.Column8.MinimumWidth = 10;
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "9";
            this.Column9.MinimumWidth = 10;
            this.Column9.Name = "Column9";
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.find_textfield);
            this.panel2.Controls.Add(this.exit_button);
            this.panel2.Controls.Add(this.sort_button);
            this.panel2.Controls.Add(this.save_raf_button);
            this.panel2.Controls.Add(this.find_button);
            this.panel2.Controls.Add(this.save_change_button);
            this.panel2.Controls.Add(this.clear_button);
            this.panel2.Location = new System.Drawing.Point(0, 1209);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1974, 136);
            this.panel2.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(886, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Search:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(596, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 25);
            this.label5.TabIndex = 7;
            // 
            // find_textfield
            // 
            this.find_textfield.Location = new System.Drawing.Point(800, 64);
            this.find_textfield.Name = "find_textfield";
            this.find_textfield.Size = new System.Drawing.Size(262, 31);
            this.find_textfield.TabIndex = 6;
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(1676, 56);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(183, 47);
            this.exit_button.TabIndex = 5;
            this.exit_button.Text = "Exit";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // sort_button
            // 
            this.sort_button.Location = new System.Drawing.Point(518, 56);
            this.sort_button.Name = "sort_button";
            this.sort_button.Size = new System.Drawing.Size(187, 47);
            this.sort_button.TabIndex = 4;
            this.sort_button.Text = "Sort";
            this.sort_button.UseVisualStyleBackColor = true;
            this.sort_button.Click += new System.EventHandler(this.sort_button_Click);
            // 
            // save_raf_button
            // 
            this.save_raf_button.Location = new System.Drawing.Point(1416, 56);
            this.save_raf_button.Name = "save_raf_button";
            this.save_raf_button.Size = new System.Drawing.Size(205, 47);
            this.save_raf_button.TabIndex = 3;
            this.save_raf_button.Text = "Save RAF";
            this.save_raf_button.UseVisualStyleBackColor = true;
            this.save_raf_button.Click += new System.EventHandler(this.save_raf_button_Click);
            // 
            // find_button
            // 
            this.find_button.Location = new System.Drawing.Point(1156, 58);
            this.find_button.Name = "find_button";
            this.find_button.Size = new System.Drawing.Size(197, 47);
            this.find_button.TabIndex = 2;
            this.find_button.Text = "Find";
            this.find_button.UseVisualStyleBackColor = true;
            this.find_button.Click += new System.EventHandler(this.find_button_Click);
            // 
            // save_change_button
            // 
            this.save_change_button.Location = new System.Drawing.Point(267, 56);
            this.save_change_button.Name = "save_change_button";
            this.save_change_button.Size = new System.Drawing.Size(168, 47);
            this.save_change_button.TabIndex = 1;
            this.save_change_button.Text = "Save Change";
            this.save_change_button.UseVisualStyleBackColor = true;
            this.save_change_button.Click += new System.EventHandler(this.save_change_button_Click);
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(56, 56);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(152, 47);
            this.clear_button.TabIndex = 0;
            this.clear_button.Text = "Clear";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1974, 1559);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.classroom_gridview);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classroom_gridview)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox teacher_textbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox date_textbox;
        private System.Windows.Forms.MaskedTextBox room_textbox;
        private System.Windows.Forms.MaskedTextBox class_textbox;
        private System.Windows.Forms.DataGridView classroom_gridview;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Button sort_button;
        private System.Windows.Forms.Button save_raf_button;
        private System.Windows.Forms.Button find_button;
        private System.Windows.Forms.Button save_change_button;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.TextBox find_textfield;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column0;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

