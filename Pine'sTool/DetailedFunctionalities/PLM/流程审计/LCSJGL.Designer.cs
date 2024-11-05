namespace Pine_sTool.DetailedFunctionalities.PLM.流程审计
{
    partial class LCSJGL
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
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ZCD_ALL_Button = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.SJSQ_Executed_Button = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.SJSQ_Running_Button = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.SJSQ_Running_Button);
            this.layoutControl1.Controls.Add(this.SJSQ_Executed_Button);
            this.layoutControl1.Controls.Add(this.ZCD_ALL_Button);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1090, 716);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1090, 716);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // ZCD_ALL_Button
            // 
            this.ZCD_ALL_Button.Location = new System.Drawing.Point(12, 12);
            this.ZCD_ALL_Button.Name = "ZCD_ALL_Button";
            this.ZCD_ALL_Button.Size = new System.Drawing.Size(1066, 22);
            this.ZCD_ALL_Button.StyleController = this.layoutControl1;
            this.ZCD_ALL_Button.TabIndex = 4;
            this.ZCD_ALL_Button.Text = "同步主材单(全部)";
            this.ZCD_ALL_Button.Click += new System.EventHandler(this.ZCD_ALL_Button_Click);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.ZCD_ALL_Button;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1070, 26);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 78);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(1070, 618);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // SJSQ_Executed_Button
            // 
            this.SJSQ_Executed_Button.Location = new System.Drawing.Point(12, 38);
            this.SJSQ_Executed_Button.Name = "SJSQ_Executed_Button";
            this.SJSQ_Executed_Button.Size = new System.Drawing.Size(1066, 22);
            this.SJSQ_Executed_Button.StyleController = this.layoutControl1;
            this.SJSQ_Executed_Button.TabIndex = 5;
            this.SJSQ_Executed_Button.Text = "同步数据审签(已执行)";
            this.SJSQ_Executed_Button.Click += new System.EventHandler(this.SJSQ_Executed_Button_Click);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.SJSQ_Executed_Button;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(1070, 26);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // SJSQ_Running_Button
            // 
            this.SJSQ_Running_Button.Location = new System.Drawing.Point(12, 64);
            this.SJSQ_Running_Button.Name = "SJSQ_Running_Button";
            this.SJSQ_Running_Button.Size = new System.Drawing.Size(1066, 22);
            this.SJSQ_Running_Button.StyleController = this.layoutControl1;
            this.SJSQ_Running_Button.TabIndex = 6;
            this.SJSQ_Running_Button.Text = "同步数据审签(正在运行)";
            this.SJSQ_Running_Button.Click += new System.EventHandler(this.SJSQ_Running_Button_Click);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.SJSQ_Running_Button;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 52);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(1070, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // LCSJGL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 716);
            this.Controls.Add(this.layoutControl1);
            this.Name = "LCSJGL";
            this.Text = "流程审计管理";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.SimpleButton SJSQ_Running_Button;
        private DevExpress.XtraEditors.SimpleButton SJSQ_Executed_Button;
        private DevExpress.XtraEditors.SimpleButton ZCD_ALL_Button;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}