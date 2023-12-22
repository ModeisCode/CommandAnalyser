namespace CommandAnalyser
{
    partial class CommandPanelComponent
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

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.commandPictureBox = new System.Windows.Forms.PictureBox();
            this.CommandTextBox = new System.Windows.Forms.TextBox();
            this.CommandDescriptionRTB = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.commandPictureBox)).BeginInit();
            // 
            // commandPictureBox
            // 
            this.commandPictureBox.Location = new System.Drawing.Point(0, 0);
            this.commandPictureBox.Name = "commandPictureBox";
            this.commandPictureBox.Size = new System.Drawing.Size(100, 50);
            this.commandPictureBox.TabIndex = 0;
            this.commandPictureBox.TabStop = false;
            // 
            // CommandTextBox
            // 
            this.CommandTextBox.Location = new System.Drawing.Point(0, 0);
            this.CommandTextBox.Name = "CommandTextBox";
            this.CommandTextBox.Size = new System.Drawing.Size(100, 20);
            this.CommandTextBox.TabIndex = 0;
            // 
            // CommandDescriptionRTB
            // 
            this.CommandDescriptionRTB.Location = new System.Drawing.Point(0, 0);
            this.CommandDescriptionRTB.Name = "CommandDescriptionRTB";
            this.CommandDescriptionRTB.Size = new System.Drawing.Size(100, 96);
            this.CommandDescriptionRTB.TabIndex = 0;
            this.CommandDescriptionRTB.Text = "";
            ((System.ComponentModel.ISupportInitialize)(this.commandPictureBox)).EndInit();

        }

        #endregion

        private System.Windows.Forms.PictureBox commandPictureBox;
        private System.Windows.Forms.TextBox CommandTextBox;
        private System.Windows.Forms.RichTextBox CommandDescriptionRTB;
    }
}
