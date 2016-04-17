namespace DOIT
{
    partial class MessageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageForm));
            this.pb = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTime1 = new System.Windows.Forms.Label();
            this.lblMess = new System.Windows.Forms.Label();
            this.but1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            this.SuspendLayout();
            // 
            // pb
            // 
            this.pb.Image = ((System.Drawing.Image)(resources.GetObject("pb.Image")));
            this.pb.Location = new System.Drawing.Point(2, 31);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(300, 200);
            this.pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb.TabIndex = 0;
            this.pb.TabStop = false;
            this.pb.Click += new System.EventHandler(this.pb_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTime1
            // 
            this.lblTime1.AutoSize = true;
            this.lblTime1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTime1.Location = new System.Drawing.Point(146, 151);
            this.lblTime1.Name = "lblTime1";
            this.lblTime1.Size = new System.Drawing.Size(0, 46);
            this.lblTime1.TabIndex = 1;
            // 
            // lblMess
            // 
            this.lblMess.AutoSize = true;
            this.lblMess.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMess.Location = new System.Drawing.Point(64, 139);
            this.lblMess.Name = "lblMess";
            this.lblMess.Size = new System.Drawing.Size(64, 25);
            this.lblMess.TabIndex = 2;
            this.lblMess.Text = "label1";
            // 
            // but1
            // 
            this.but1.Location = new System.Drawing.Point(153, 195);
            this.but1.Name = "but1";
            this.but1.Size = new System.Drawing.Size(75, 23);
            this.but1.TabIndex = 3;
            this.but1.Text = "Закрыть";
            this.but1.UseVisualStyleBackColor = true;
            this.but1.Visible = false;
            this.but1.Click += new System.EventHandler(this.but1_Click);
            // 
            // MessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.but1);
            this.Controls.Add(this.lblMess);
            this.Controls.Add(this.lblTime1);
            this.Controls.Add(this.pb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MessageForm";
            this.Text = "MessageForm";
            this.Load += new System.EventHandler(this.MessageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTime1;
        private System.Windows.Forms.Label lblMess;
        private System.Windows.Forms.Button but1;
    }
}