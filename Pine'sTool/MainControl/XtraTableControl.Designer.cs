namespace Pine_sTool.MainControl
{
    partial class XtraTableControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainXtraTabControl = new DevExpress.XtraTab.XtraTabControl();
            ((System.ComponentModel.ISupportInitialize)(this.MainXtraTabControl)).BeginInit();
            this.SuspendLayout();
            // 
            // MainXtraTabControl
            // 
            this.MainXtraTabControl.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPagesAndTabControlHeader;
            this.MainXtraTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainXtraTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainXtraTabControl.Name = "MainXtraTabControl";
            this.MainXtraTabControl.Size = new System.Drawing.Size(1800, 1000);
            this.MainXtraTabControl.TabIndex = 0;
            this.MainXtraTabControl.CloseButtonClick += new System.EventHandler(this.MainXtraTabControl_CloseButtonClick);
            // 
            // XtraTableControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainXtraTabControl);
            this.Name = "XtraTableControl";
            this.Size = new System.Drawing.Size(1800, 1000);
            ((System.ComponentModel.ISupportInitialize)(this.MainXtraTabControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraTab.XtraTabControl MainXtraTabControl;
    }
}
