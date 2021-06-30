
namespace dp_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.theme_but = new System.Windows.Forms.Button();
            this.date_err = new System.Windows.Forms.Label();
            this.name_err = new System.Windows.Forms.Label();
            this.Time_text_box = new System.Windows.Forms.TextBox();
            this.Date_text_box = new System.Windows.Forms.TextBox();
            this.Descr_text_box = new System.Windows.Forms.TextBox();
            this.Name_text_box = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(726, 658);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(23, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AllowDrop = true;
            this.label4.AutoEllipsis = true;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(23, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "Description";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.theme_but);
            this.splitContainer1.Panel2.Controls.Add(this.date_err);
            this.splitContainer1.Panel2.Controls.Add(this.name_err);
            this.splitContainer1.Panel2.Controls.Add(this.Time_text_box);
            this.splitContainer1.Panel2.Controls.Add(this.Date_text_box);
            this.splitContainer1.Panel2.Controls.Add(this.Descr_text_box);
            this.splitContainer1.Panel2.Controls.Add(this.Name_text_box);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Size = new System.Drawing.Size(1240, 690);
            this.splitContainer1.SplitterDistance = 413;
            this.splitContainer1.TabIndex = 10;
            // 
            // theme_but
            // 
            this.theme_but.Location = new System.Drawing.Point(788, 3);
            this.theme_but.Name = "theme_but";
            this.theme_but.Size = new System.Drawing.Size(32, 28);
            this.theme_but.TabIndex = 16;
            this.theme_but.UseVisualStyleBackColor = true;
            this.theme_but.Click += new System.EventHandler(this.theme_but_Click);
            // 
            // date_err
            // 
            this.date_err.AutoSize = true;
            this.date_err.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.date_err.ForeColor = System.Drawing.Color.Red;
            this.date_err.Location = new System.Drawing.Point(116, 45);
            this.date_err.Name = "date_err";
            this.date_err.Size = new System.Drawing.Size(0, 15);
            this.date_err.TabIndex = 15;
            // 
            // name_err
            // 
            this.name_err.AutoSize = true;
            this.name_err.ForeColor = System.Drawing.Color.Red;
            this.name_err.Location = new System.Drawing.Point(126, 122);
            this.name_err.Name = "name_err";
            this.name_err.Size = new System.Drawing.Size(0, 20);
            this.name_err.TabIndex = 14;
            // 
            // Time_text_box
            // 
            this.Time_text_box.Location = new System.Drawing.Point(357, 64);
            this.Time_text_box.Multiline = true;
            this.Time_text_box.Name = "Time_text_box";
            this.Time_text_box.Size = new System.Drawing.Size(320, 27);
            this.Time_text_box.TabIndex = 13;
            // 
            // Date_text_box
            // 
            this.Date_text_box.Location = new System.Drawing.Point(23, 64);
            this.Date_text_box.Name = "Date_text_box";
            this.Date_text_box.Size = new System.Drawing.Size(307, 27);
            this.Date_text_box.TabIndex = 12;
            // 
            // Descr_text_box
            // 
            this.Descr_text_box.CausesValidation = false;
            this.Descr_text_box.Location = new System.Drawing.Point(23, 272);
            this.Descr_text_box.Multiline = true;
            this.Descr_text_box.Name = "Descr_text_box";
            this.Descr_text_box.Size = new System.Drawing.Size(654, 374);
            this.Descr_text_box.TabIndex = 11;
            // 
            // Name_text_box
            // 
            this.Name_text_box.Location = new System.Drawing.Point(23, 147);
            this.Name_text_box.Multiline = true;
            this.Name_text_box.Name = "Name_text_box";
            this.Name_text_box.Size = new System.Drawing.Size(654, 88);
            this.Name_text_box.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 736);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox Time_text_box;
        private System.Windows.Forms.TextBox Date_text_box;
        private System.Windows.Forms.TextBox Descr_text_box;
        private System.Windows.Forms.TextBox Name_text_box;
        private System.Windows.Forms.Label name_err;
        private System.Windows.Forms.Label date_err;
        private System.Windows.Forms.Button theme_but;
    }
}

