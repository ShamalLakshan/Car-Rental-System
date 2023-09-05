namespace Car_Rental_System
{
    partial class Findacar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Findacar));
            this.btnback = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.carsDataSet = new Car_Rental_System.CarsDataSet();
            this.carsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnshowdgv = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnback
            // 
            this.btnback.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnback.BackgroundImage")));
            this.btnback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnback.Location = new System.Drawing.Point(803, 12);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(72, 72);
            this.btnback.TabIndex = 7;
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
            this.btnexit.TabIndex = 6;
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(289, 30);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(372, 146);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(82, 331);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(818, 452);
            this.dataGridView1.TabIndex = 11;
            // 
            // carsDataSet
            // 
            this.carsDataSet.DataSetName = "CarsDataSet";
            this.carsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carsDataSetBindingSource
            // 
            this.carsDataSetBindingSource.DataSource = this.carsDataSet;
            this.carsDataSetBindingSource.Position = 0;
            // 
            // btnshowdgv
            // 
            this.btnshowdgv.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnshowdgv.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnshowdgv.BackgroundImage")));
            this.btnshowdgv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnshowdgv.Location = new System.Drawing.Point(377, 226);
            this.btnshowdgv.Name = "btnshowdgv";
            this.btnshowdgv.Size = new System.Drawing.Size(103, 88);
            this.btnshowdgv.TabIndex = 12;
            this.btnshowdgv.UseVisualStyleBackColor = false;
            this.btnshowdgv.Click += new System.EventHandler(this.btnshowdgv_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(105, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 45);
            this.label1.TabIndex = 13;
            this.label1.Text = "Show Data";
            // 
            // Findacar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(982, 953);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnshowdgv);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnexit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Findacar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Findacar";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CarsDataSet carsDataSet;
        private System.Windows.Forms.BindingSource carsDataSetBindingSource;
        private System.Windows.Forms.Button btnshowdgv;
        private System.Windows.Forms.Label label1;
    }
}