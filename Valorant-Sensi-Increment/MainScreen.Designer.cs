
namespace Valorant_Sensi_Increment {
    partial class MainScreen {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.selected_file = new System.Windows.Forms.Label();
            this.file_browse_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.confirm_target_btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.target_sensitivity_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.current_sensitivity_label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.daily_inc_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.done_btn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.file_already_operated_label = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.MainWorker = new System.ComponentModel.BackgroundWorker();
            this.Tray_Icon = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(127, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(117, 13);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://github.com/f-lat";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.selected_file);
            this.groupBox1.Controls.Add(this.file_browse_btn);
            this.groupBox1.Location = new System.Drawing.Point(12, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 60);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select your Config file:";
            // 
            // selected_file
            // 
            this.selected_file.AutoSize = true;
            this.selected_file.BackColor = System.Drawing.SystemColors.Control;
            this.selected_file.ForeColor = System.Drawing.Color.Blue;
            this.selected_file.Location = new System.Drawing.Point(124, 24);
            this.selected_file.Name = "selected_file";
            this.selected_file.Size = new System.Drawing.Size(58, 13);
            this.selected_file.TabIndex = 2;
            this.selected_file.Text = "<filename>";
            // 
            // file_browse_btn
            // 
            this.file_browse_btn.Location = new System.Drawing.Point(259, 19);
            this.file_browse_btn.Name = "file_browse_btn";
            this.file_browse_btn.Size = new System.Drawing.Size(75, 23);
            this.file_browse_btn.TabIndex = 1;
            this.file_browse_btn.Text = "Browse";
            this.file_browse_btn.UseVisualStyleBackColor = true;
            this.file_browse_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Follow me on Github: ";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.confirm_target_btn);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.target_sensitivity_box);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.current_sensitivity_label);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(340, 145);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Duration";
            // 
            // confirm_target_btn
            // 
            this.confirm_target_btn.Location = new System.Drawing.Point(259, 112);
            this.confirm_target_btn.Name = "confirm_target_btn";
            this.confirm_target_btn.Size = new System.Drawing.Size(75, 23);
            this.confirm_target_btn.TabIndex = 7;
            this.confirm_target_btn.Text = "Confirm";
            this.confirm_target_btn.UseVisualStyleBackColor = true;
            this.confirm_target_btn.Click += new System.EventHandler(this.confirm_target_btn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Target Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(112, 76);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // target_sensitivity_box
            // 
            this.target_sensitivity_box.Location = new System.Drawing.Point(112, 50);
            this.target_sensitivity_box.Name = "target_sensitivity_box";
            this.target_sensitivity_box.Size = new System.Drawing.Size(70, 20);
            this.target_sensitivity_box.TabIndex = 4;
            this.target_sensitivity_box.Text = "Enter Target";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Target Sensitivity:";
            // 
            // current_sensitivity_label
            // 
            this.current_sensitivity_label.AutoSize = true;
            this.current_sensitivity_label.Location = new System.Drawing.Point(109, 25);
            this.current_sensitivity_label.Name = "current_sensitivity_label";
            this.current_sensitivity_label.Size = new System.Drawing.Size(64, 13);
            this.current_sensitivity_label.TabIndex = 2;
            this.current_sensitivity_label.Text = "<sensitivity>";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Current Sensitivity: ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.daily_inc_label);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(12, 290);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(340, 54);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Increment";
            // 
            // daily_inc_label
            // 
            this.daily_inc_label.AutoSize = true;
            this.daily_inc_label.Location = new System.Drawing.Point(96, 26);
            this.daily_inc_label.Name = "daily_inc_label";
            this.daily_inc_label.Size = new System.Drawing.Size(0, 13);
            this.daily_inc_label.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Daily Increment:";
            // 
            // done_btn
            // 
            this.done_btn.Enabled = false;
            this.done_btn.Location = new System.Drawing.Point(277, 386);
            this.done_btn.Name = "done_btn";
            this.done_btn.Size = new System.Drawing.Size(75, 23);
            this.done_btn.TabIndex = 11;
            this.done_btn.Text = "Done";
            this.done_btn.UseVisualStyleBackColor = true;
            this.done_btn.Click += new System.EventHandler(this.done_btn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "File Being Operated: ";
            // 
            // file_already_operated_label
            // 
            this.file_already_operated_label.AutoSize = true;
            this.file_already_operated_label.Location = new System.Drawing.Point(136, 35);
            this.file_already_operated_label.Name = "file_already_operated_label";
            this.file_already_operated_label.Size = new System.Drawing.Size(106, 13);
            this.file_already_operated_label.TabIndex = 14;
            this.file_already_operated_label.Text = "<alreadyselectedfile>";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 360);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(95, 17);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "Run at Startup";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // MainWorker
            // 
            this.MainWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.MainWorker_DoWork);
            // 
            // Tray_Icon
            // 
            this.Tray_Icon.BalloonTipTitle = "Valorant Sensi Incrementer";
            this.Tray_Icon.Icon = ((System.Drawing.Icon)(resources.GetObject("Tray_Icon.Icon")));
            this.Tray_Icon.Text = "Valorant Sensi Incrementer";
            this.Tray_Icon.Visible = true;
            this.Tray_Icon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Tray_Icon_MouseDoubleClick);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 421);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.file_already_operated_label);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.done_btn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.linkLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainScreen";
            this.Text = "Valorant Sensitivity Incrementer";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button file_browse_btn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label selected_file;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label current_sensitivity_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox target_sensitivity_box;
        private System.Windows.Forms.Button confirm_target_btn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label daily_inc_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button done_btn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label file_already_operated_label;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.ComponentModel.BackgroundWorker MainWorker;
        private System.Windows.Forms.NotifyIcon Tray_Icon;
    }
}