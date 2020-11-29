namespace pecs
{
    partial class frm68
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm68));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.p5 = new System.Windows.Forms.Button();
            this.p4 = new System.Windows.Forms.Button();
            this.p3 = new System.Windows.Forms.Button();
            this.p2 = new System.Windows.Forms.Button();
            this.p1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("新細明體", 56.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(492, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(363, 75);
            this.label2.TabIndex = 51;
            this.label2.Text = "這是什麼?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1250, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 21);
            this.label3.TabIndex = 50;
            this.label3.Text = "離開";
            // 
            // p5
            // 
            this.p5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p5.BackgroundImage")));
            this.p5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.p5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.p5.Location = new System.Drawing.Point(1058, 478);
            this.p5.Name = "p5";
            this.p5.Size = new System.Drawing.Size(258, 216);
            this.p5.TabIndex = 49;
            this.p5.UseVisualStyleBackColor = true;
            this.p5.Click += new System.EventHandler(this.btn_ans_Click);
            // 
            // p4
            // 
            this.p4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p4.BackgroundImage")));
            this.p4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.p4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.p4.Location = new System.Drawing.Point(794, 478);
            this.p4.Name = "p4";
            this.p4.Size = new System.Drawing.Size(258, 216);
            this.p4.TabIndex = 48;
            this.p4.UseVisualStyleBackColor = true;
            this.p4.Click += new System.EventHandler(this.btn_ans_Click);
            // 
            // p3
            // 
            this.p3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p3.BackgroundImage")));
            this.p3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.p3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.p3.Location = new System.Drawing.Point(530, 478);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(258, 216);
            this.p3.TabIndex = 47;
            this.p3.UseVisualStyleBackColor = true;
            this.p3.Click += new System.EventHandler(this.btn_ans_Click);
            // 
            // p2
            // 
            this.p2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p2.BackgroundImage")));
            this.p2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.p2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.p2.Location = new System.Drawing.Point(266, 478);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(258, 216);
            this.p2.TabIndex = 46;
            this.p2.UseVisualStyleBackColor = true;
            this.p2.Click += new System.EventHandler(this.btn_ans_Click);
            // 
            // p1
            // 
            this.p1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p1.BackgroundImage")));
            this.p1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.p1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.p1.Location = new System.Drawing.Point(2, 478);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(258, 216);
            this.p1.TabIndex = 45;
            this.p1.UseVisualStyleBackColor = true;
            this.p1.Click += new System.EventHandler(this.btn_ans_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::pecs.Properties.Resources.imgQuestion;
            this.pictureBox1.Location = new System.Drawing.Point(536, 171);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("新細明體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(392, 225);
            this.label1.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 48);
            this.label1.TabIndex = 43;
            this.label1.Text = "這是";
            // 
            // btn_exit
            // 
            this.btn_exit.Image = global::pecs.Properties.Resources.imgExit;
            this.btn_exit.Location = new System.Drawing.Point(1235, 3);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(81, 96);
            this.btn_exit.TabIndex = 42;
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // frm68
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::pecs.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(1319, 697);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.p5);
            this.Controls.Add(this.p4);
            this.Controls.Add(this.p3);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_exit);
            this.Font = new System.Drawing.Font("新細明體", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(9);
            this.Name = "frm68";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm68";
            this.Load += new System.EventHandler(this.frm68_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button p5;
        private System.Windows.Forms.Button p4;
        private System.Windows.Forms.Button p3;
        private System.Windows.Forms.Button p2;
        private System.Windows.Forms.Button p1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_exit;
    }
}