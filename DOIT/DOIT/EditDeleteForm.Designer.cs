namespace DOIT
{
    partial class EditDeleteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditDeleteForm));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.cb_block = new System.Windows.Forms.CheckBox();
            this.cb_reminding = new System.Windows.Forms.CheckBox();
            this.rtb_message = new System.Windows.Forms.RichTextBox();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.btn_delete = new System.Windows.Forms.Button();
            this.ch_timeManager = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Сообщение";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(184, 296);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 20;
            this.btn_cancel.Text = "Отмена";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(22, 296);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 19;
            this.btn_save.Text = "Применить";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // cb_block
            // 
            this.cb_block.AutoSize = true;
            this.cb_block.Location = new System.Drawing.Point(88, 207);
            this.cb_block.Name = "cb_block";
            this.cb_block.Size = new System.Drawing.Size(137, 17);
            this.cb_block.TabIndex = 18;
            this.cb_block.Text = "Блокировать систему";
            this.cb_block.UseVisualStyleBackColor = true;
            // 
            // cb_reminding
            // 
            this.cb_reminding.AutoSize = true;
            this.cb_reminding.Location = new System.Drawing.Point(88, 168);
            this.cb_reminding.Name = "cb_reminding";
            this.cb_reminding.Size = new System.Drawing.Size(128, 17);
            this.cb_reminding.TabIndex = 17;
            this.cb_reminding.Text = "Напомнить зарание";
            this.cb_reminding.UseVisualStyleBackColor = true;
            // 
            // rtb_message
            // 
            this.rtb_message.Location = new System.Drawing.Point(31, 101);
            this.rtb_message.MaxLength = 25;
            this.rtb_message.Name = "rtb_message";
            this.rtb_message.Size = new System.Drawing.Size(228, 48);
            this.rtb_message.TabIndex = 16;
            this.rtb_message.Text = "";
            // 
            // timePicker
            // 
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker.Location = new System.Drawing.Point(182, 50);
            this.timePicker.Name = "timePicker";
            this.timePicker.Size = new System.Drawing.Size(77, 20);
            this.timePicker.TabIndex = 15;
            // 
            // datePicker
            // 
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(31, 50);
            this.datePicker.MaxDate = new System.DateTime(2066, 12, 31, 0, 0, 0, 0);
            this.datePicker.MinDate = new System.DateTime(2016, 4, 17, 0, 0, 0, 0);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(77, 20);
            this.datePicker.TabIndex = 14;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(103, 296);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 27;
            this.btn_delete.Text = "Удалить";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // ch_timeManager
            // 
            this.ch_timeManager.AutoSize = true;
            this.ch_timeManager.Location = new System.Drawing.Point(88, 245);
            this.ch_timeManager.Name = "ch_timeManager";
            this.ch_timeManager.Size = new System.Drawing.Size(93, 17);
            this.ch_timeManager.TabIndex = 28;
            this.ch_timeManager.Text = "Time manager";
            this.ch_timeManager.UseVisualStyleBackColor = true;
            this.ch_timeManager.CheckedChanged += new System.EventHandler(this.ch_timeManager_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Время";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Дата";
            // 
            // EditDeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ch_timeManager);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.cb_block);
            this.Controls.Add(this.cb_reminding);
            this.Controls.Add(this.rtb_message);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.datePicker);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditDeleteForm";
            this.Text = "EditDeleteForm";
            this.Load += new System.EventHandler(this.EditDeleteForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.CheckBox cb_block;
        private System.Windows.Forms.CheckBox cb_reminding;
        private System.Windows.Forms.RichTextBox rtb_message;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.CheckBox ch_timeManager;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}