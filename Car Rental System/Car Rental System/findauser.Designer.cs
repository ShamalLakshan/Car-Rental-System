namespace Car_Rental_System
{
    partial class findauser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(findauser));
            this.label1 = new System.Windows.Forms.Label();
            this.btnshowdgv2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnback = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(105, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 45);
            this.label1.TabIndex = 19;
            this.label1.Text = "Show Data";
            // 
            // btnshowdgv2
            // 
            this.btnshowdgv2.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnshowdgv2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnshowdgv2.BackgroundImage")));
            this.btnshowdgv2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnshowdgv2.Location = new System.Drawing.Point(377, 226);
            this.btnshowdgv2.Name = "btnshowdgv2";
            this.btnshowdgv2.Size = new System.Drawing.Size(103, 88);
            this.btnshowdgv2.TabIndex = 18;
            this.btnshowdgv2.UseVisualStyleBackColor = false;
            this.btnshowdgv2.Click += new System.EventHandler(this.btnshowdgv2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(82, 331);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(818, 452);
            this.dataGridView2.TabIndex = 17;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(289, 30);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(372, 146);
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // btnback
            // 
            this.btnback.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnback.BackgroundImage")));
            this.btnback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnback.Location = new System.Drawing.Point(803, 12);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(72, 72);
            this.btnback.TabIndex = 15;
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnexit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnexit.BackgroundImage")));
            this.btnexit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnexit.Location = new System.Drawing.Point(898, 12);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(72, 72);
            this.btnexit.TabIndex = 14;
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // findauser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(982, 953);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnshowdgv2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnexit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "findauser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "findauser";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnshowdgv2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnexit;
    }
}