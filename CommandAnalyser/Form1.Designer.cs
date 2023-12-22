namespace CommandAnalyser
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.CommandPanel = new System.Windows.Forms.Panel();
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.TestBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmdImage = new System.Windows.Forms.PictureBox();
            this.TestSaveToJSON = new System.Windows.Forms.Button();
            this.ControlPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmdImage)).BeginInit();
            this.SuspendLayout();
            // 
            // CommandPanel
            // 
            this.CommandPanel.AutoScroll = true;
            this.CommandPanel.BackColor = System.Drawing.Color.Black;
            this.CommandPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.CommandPanel.Location = new System.Drawing.Point(806, 0);
            this.CommandPanel.Name = "CommandPanel";
            this.CommandPanel.Size = new System.Drawing.Size(493, 571);
            this.CommandPanel.TabIndex = 0;
            // 
            // ControlPanel
            // 
            this.ControlPanel.BackColor = System.Drawing.Color.Silver;
            this.ControlPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ControlPanel.Controls.Add(this.TestSaveToJSON);
            this.ControlPanel.Controls.Add(this.TestBtn);
            this.ControlPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ControlPanel.Location = new System.Drawing.Point(0, 362);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(806, 209);
            this.ControlPanel.TabIndex = 1;
            // 
            // TestBtn
            // 
            this.TestBtn.Location = new System.Drawing.Point(688, 17);
            this.TestBtn.Name = "TestBtn";
            this.TestBtn.Size = new System.Drawing.Size(103, 32);
            this.TestBtn.TabIndex = 0;
            this.TestBtn.Text = "test";
            this.TestBtn.UseVisualStyleBackColor = true;
            this.TestBtn.Click += new System.EventHandler(this.TestBtn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cmdImage);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(806, 362);
            this.panel3.TabIndex = 2;
            // 
            // cmdImage
            // 
            this.cmdImage.Image = global::CommandAnalyser.Properties.Resources.cmd;
            this.cmdImage.Location = new System.Drawing.Point(776, 12);
            this.cmdImage.Name = "cmdImage";
            this.cmdImage.Size = new System.Drawing.Size(24, 24);
            this.cmdImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cmdImage.TabIndex = 0;
            this.cmdImage.TabStop = false;
            // 
            // TestSaveToJSON
            // 
            this.TestSaveToJSON.Location = new System.Drawing.Point(688, 55);
            this.TestSaveToJSON.Name = "TestSaveToJSON";
            this.TestSaveToJSON.Size = new System.Drawing.Size(103, 30);
            this.TestSaveToJSON.TabIndex = 1;
            this.TestSaveToJSON.Text = "test save to JSON";
            this.TestSaveToJSON.UseVisualStyleBackColor = true;
            this.TestSaveToJSON.Click += new System.EventHandler(this.TestSaveToJSON_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 571);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.ControlPanel);
            this.Controls.Add(this.CommandPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ControlPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmdImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel CommandPanel;
        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button TestBtn;
        private System.Windows.Forms.PictureBox cmdImage;
        private System.Windows.Forms.Button TestSaveToJSON;
    }
}

