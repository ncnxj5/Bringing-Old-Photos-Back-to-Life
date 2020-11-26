namespace WindowsFormsApplication1
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
            this.sub_folder = new System.Windows.Forms.CheckBox();
            this.start_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.file_list = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.source_text = new System.Windows.Forms.TextBox();
            this.dest_text = new System.Windows.Forms.TextBox();
            this.scratch_mode = new System.Windows.Forms.CheckBox();
            this.select_temp_but = new System.Windows.Forms.Button();
            this.temp_folder = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.output = new System.Windows.Forms.Label();
            this.watcher = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sub_folder
            // 
            this.sub_folder.AutoSize = true;
            this.sub_folder.Enabled = false;
            this.sub_folder.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sub_folder.Location = new System.Drawing.Point(357, 269);
            this.sub_folder.Name = "sub_folder";
            this.sub_folder.Size = new System.Drawing.Size(135, 21);
            this.sub_folder.TabIndex = 0;
            this.sub_folder.Text = "contains subfolder";
            this.sub_folder.UseVisualStyleBackColor = true;
            // 
            // start_button
            // 
            this.start_button.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.start_button.Location = new System.Drawing.Point(142, 350);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(353, 52);
            this.start_button.TabIndex = 1;
            this.start_button.Text = "Start";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(0, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Source Folder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Temp Folder";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(-1, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Output Folder";
            // 
            // file_list
            // 
            this.file_list.FormattingEnabled = true;
            this.file_list.ItemHeight = 12;
            this.file_list.Location = new System.Drawing.Point(0, 74);
            this.file_list.Name = "file_list";
            this.file_list.Size = new System.Drawing.Size(498, 160);
            this.file_list.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(401, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 24);
            this.button1.TabIndex = 7;
            this.button1.Text = "Select";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(401, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Select";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // source_text
            // 
            this.source_text.Location = new System.Drawing.Point(109, 10);
            this.source_text.Name = "source_text";
            this.source_text.Size = new System.Drawing.Size(295, 21);
            this.source_text.TabIndex = 9;
            this.source_text.TextChanged += new System.EventHandler(this.source_text_TextChanged);
            // 
            // dest_text
            // 
            this.dest_text.Location = new System.Drawing.Point(109, 45);
            this.dest_text.Name = "dest_text";
            this.dest_text.Size = new System.Drawing.Size(295, 21);
            this.dest_text.TabIndex = 10;
            this.dest_text.Text = "D:\\OldPhotoOutput";
            // 
            // scratch_mode
            // 
            this.scratch_mode.AutoSize = true;
            this.scratch_mode.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.scratch_mode.Location = new System.Drawing.Point(357, 294);
            this.scratch_mode.Name = "scratch_mode";
            this.scratch_mode.Size = new System.Drawing.Size(120, 21);
            this.scratch_mode.TabIndex = 11;
            this.scratch_mode.Text = "contains scratch";
            this.scratch_mode.UseVisualStyleBackColor = true;
            // 
            // select_temp_but
            // 
            this.select_temp_but.Location = new System.Drawing.Point(401, 240);
            this.select_temp_but.Name = "select_temp_but";
            this.select_temp_but.Size = new System.Drawing.Size(91, 23);
            this.select_temp_but.TabIndex = 12;
            this.select_temp_but.Text = "select";
            this.select_temp_but.UseVisualStyleBackColor = true;
            this.select_temp_but.Click += new System.EventHandler(this.select_temp_but_Click);
            // 
            // temp_folder
            // 
            this.temp_folder.Location = new System.Drawing.Point(109, 240);
            this.temp_folder.Name = "temp_folder";
            this.temp_folder.Size = new System.Drawing.Size(295, 21);
            this.temp_folder.TabIndex = 13;
            this.temp_folder.Text = "D:\\OldPhotoTemp";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(3, 321);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(492, 23);
            this.progressBar.TabIndex = 14;
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.Location = new System.Drawing.Point(2, 278);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(35, 12);
            this.output.TabIndex = 15;
            this.output.Text = "Ready";
            // 
            // watcher
            // 
            this.watcher.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.watcher.Location = new System.Drawing.Point(0, 351);
            this.watcher.Name = "watcher";
            this.watcher.Size = new System.Drawing.Size(136, 51);
            this.watcher.TabIndex = 16;
            this.watcher.Text = "Watch Dog";
            this.watcher.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 17;
            this.label3.Text = "Hold On..";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(495, 408);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.watcher);
            this.Controls.Add(this.output);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.temp_folder);
            this.Controls.Add(this.select_temp_but);
            this.Controls.Add(this.scratch_mode);
            this.Controls.Add(this.dest_text);
            this.Controls.Add(this.source_text);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.file_list);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.sub_folder);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.8D;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Old Photo Repair";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox sub_folder;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox file_list;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox source_text;
        private System.Windows.Forms.TextBox dest_text;
        private System.Windows.Forms.CheckBox scratch_mode;
        private System.Windows.Forms.Button select_temp_but;
        private System.Windows.Forms.TextBox temp_folder;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label output;
        private System.Windows.Forms.Button watcher;
        private System.Windows.Forms.Label label3;
    }
}

