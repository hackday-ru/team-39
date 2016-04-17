namespace DOIT
{
    partial class AddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddForm));
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.rtb_message = new System.Windows.Forms.RichTextBox();
            this.cb_reminding = new System.Windows.Forms.CheckBox();
            this.cb_block = new System.Windows.Forms.CheckBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.ch_time = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // datePicker
            // 
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(36, 46);
            this.datePicker.MaxDate = new System.DateTime(2066, 12, 31, 0, 0, 0, 0);
            this.datePicker.MinDate = new System.DateTime(2016, 4, 17, 0, 0, 0, 0);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(77, 20);
            this.datePicker.TabIndex = 0;
            // 
            // rtb_message
            // 
            this.rtb_message.Location = new System.Drawing.Point(36, 94);
            this.rtb_message.MaxLength = 25;
            this.rtb_message.Name = "rtb_message";
            this.rtb_message.Size = new System.Drawing.Size(224, 52);
            this.rtb_message.TabIndex = 2;
            this.rtb_message.Text = "";
            // 
            // cb_reminding
            // 
            this.cb_reminding.AutoSize = true;
            this.cb_reminding.Location = new System.Drawing.Point(89, 167);
            this.cb_reminding.Name = "cb_reminding";
            this.cb_reminding.Size = new System.Drawing.Size(128, 17);
            this.cb_reminding.TabIndex = 3;
            this.cb_reminding.Text = "Напомнить зарание";
            this.cb_reminding.UseVisualStyleBackColor = true;
            this.cb_reminding.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cb_block
            // 
            this.cb_block.AutoSize = true;
            this.cb_block.Location = new System.Drawing.Point(89, 204);
            this.cb_block.Name = "cb_block";
            this.cb_block.Size = new System.Drawing.Size(137, 17);
            this.cb_block.TabIndex = 4;
            this.cb_block.Text = "Блокировать систему";
            this.cb_block.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(36, 308);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 5;
            this.btn_add.Text = "Добавить";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(174, 308);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 6;
            this.btn_cancel.Text = "Отмена";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Сообщение";
            // 
            // timePicker
            // 
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker.Location = new System.Drawing.Point(183, 46);
            this.timePicker.Name = "timePicker";
            this.timePicker.Size = new System.Drawing.Size(77, 20);
            this.timePicker.TabIndex = 1;
            // 
            // ch_time
            // 
            this.ch_time.AutoSize = true;
            this.ch_time.Location = new System.Drawing.Point(89, 241);
            this.ch_time.Name = "ch_time";
            this.ch_time.Size = new System.Drawing.Size(93, 17);
            this.ch_time.TabIndex = 14;
            this.ch_time.Text = "Time manager";
            this.ch_time.UseVisualStyleBackColor = true;
            this.ch_time.CheckedChanged += new System.EventHandler(this.ch_time_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Дата";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Время";
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ch_time);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.cb_block);
            this.Controls.Add(this.cb_reminding);
            this.Controls.Add(this.rtb_message);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.datePicker);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddForm";
            this.Text = "Уже пора";
            this.Load += new System.EventHandler(this.AddForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.RichTextBox rtb_message;
        private System.Windows.Forms.CheckBox cb_reminding;
        private System.Windows.Forms.CheckBox cb_block;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.CheckBox ch_time;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}