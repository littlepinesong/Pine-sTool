namespace MoveAndClickMouse.IPandHostName
{
    partial class IPandHostName
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.IPtoHostNameSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.HostNametoIPsimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.HostNameTextEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.IPtextEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.HostNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.IPtextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HostNameTextEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IPtextEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HostNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IPtextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.IPtoHostNameSimpleButton);
            this.layoutControl1.Controls.Add(this.HostNameTextEdit);
            this.layoutControl1.Controls.Add(this.IPtextEdit);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(500, 103);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(500, 103);
            this.Root.TextVisible = false;
            // 
            // IPtoHostNameSimpleButton
            // 
            this.IPtoHostNameSimpleButton.Location = new System.Drawing.Point(12, 60);
            this.IPtoHostNameSimpleButton.Name = "IPtoHostNameSimpleButton";
            this.IPtoHostNameSimpleButton.Size = new System.Drawing.Size(476, 22);
            this.IPtoHostNameSimpleButton.StyleController = this.layoutControl1;
            this.IPtoHostNameSimpleButton.TabIndex = 6;
            this.IPtoHostNameSimpleButton.Text = "IP转换为主机名";
            this.IPtoHostNameSimpleButton.Click += new System.EventHandler(this.IPtoHostNameSimpleButton_Click);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.IPtoHostNameSimpleButton;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(480, 35);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // HostNametoIPsimpleButton
            // 
            this.HostNametoIPsimpleButton.Location = new System.Drawing.Point(12, 60);
            this.HostNametoIPsimpleButton.Name = "HostNametoIPsimpleButton";
            this.HostNametoIPsimpleButton.Size = new System.Drawing.Size(476, 22);
            this.HostNametoIPsimpleButton.StyleController = this.layoutControl2;
            this.HostNametoIPsimpleButton.TabIndex = 7;
            this.HostNametoIPsimpleButton.Text = "主机名转换为IP";
            this.HostNametoIPsimpleButton.Click += new System.EventHandler(this.HostNametoIPsimpleButton_Click);
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.HostNametoIPsimpleButton);
            this.layoutControl2.Controls.Add(this.HostNameTextEdit1);
            this.layoutControl2.Controls.Add(this.IPtextEdit1);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.layoutControl2.Location = new System.Drawing.Point(490, 0);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup1;
            this.layoutControl2.Size = new System.Drawing.Size(500, 103);
            this.layoutControl2.TabIndex = 1;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem6,
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(500, 103);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.HostNametoIPsimpleButton;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(480, 35);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // HostNameTextEdit1
            // 
            this.HostNameTextEdit1.Location = new System.Drawing.Point(60, 12);
            this.HostNameTextEdit1.Name = "HostNameTextEdit1";
            this.HostNameTextEdit1.Size = new System.Drawing.Size(428, 20);
            this.HostNameTextEdit1.StyleController = this.layoutControl2;
            this.HostNameTextEdit1.TabIndex = 5;
            // 
            // IPtextEdit1
            // 
            this.IPtextEdit1.Enabled = false;
            this.IPtextEdit1.Location = new System.Drawing.Point(60, 36);
            this.IPtextEdit1.Name = "IPtextEdit1";
            this.IPtextEdit1.Size = new System.Drawing.Size(428, 20);
            this.IPtextEdit1.StyleController = this.layoutControl2;
            this.IPtextEdit1.TabIndex = 4;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.IPtextEdit1;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(480, 24);
            this.layoutControlItem4.Text = "IP地址";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(36, 14);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.HostNameTextEdit1;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(480, 24);
            this.layoutControlItem5.Text = "主机名";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(36, 14);
            // 
            // HostNameTextEdit
            // 
            this.HostNameTextEdit.Enabled = false;
            this.HostNameTextEdit.Location = new System.Drawing.Point(60, 36);
            this.HostNameTextEdit.Name = "HostNameTextEdit";
            this.HostNameTextEdit.Size = new System.Drawing.Size(428, 20);
            this.HostNameTextEdit.StyleController = this.layoutControl1;
            this.HostNameTextEdit.TabIndex = 5;
            // 
            // IPtextEdit
            // 
            this.IPtextEdit.Location = new System.Drawing.Point(60, 12);
            this.IPtextEdit.Name = "IPtextEdit";
            this.IPtextEdit.Size = new System.Drawing.Size(428, 20);
            this.IPtextEdit.StyleController = this.layoutControl1;
            this.IPtextEdit.TabIndex = 4;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.IPtextEdit;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(480, 24);
            this.layoutControlItem1.Text = "IP地址";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(36, 14);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.HostNameTextEdit;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(480, 24);
            this.layoutControlItem2.Text = "主机名";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(36, 14);
            // 
            // IPandHostName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 103);
            this.Controls.Add(this.layoutControl2);
            this.Controls.Add(this.layoutControl1);
            this.Name = "IPandHostName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IP/主机名";
            this.Load += new System.EventHandler(this.IPandHostName_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HostNameTextEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IPtextEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HostNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IPtextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton IPtoHostNameSimpleButton;
        private DevExpress.XtraEditors.TextEdit HostNameTextEdit;
        private DevExpress.XtraEditors.TextEdit IPtextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.TextEdit IPtextEdit1;
        private DevExpress.XtraEditors.TextEdit HostNameTextEdit1;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraEditors.SimpleButton HostNametoIPsimpleButton;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}