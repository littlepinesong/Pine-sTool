﻿//namespace Pine_sTool.DetailedFunctionalities
//{
//    partial class ProcessControl
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        /// <summary>
//        /// Required method for Designer support - do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
//            this.GetAllProcessSimpleButton = new DevExpress.XtraEditors.SimpleButton();
//            this.ProcessGridControl = new DevExpress.XtraGrid.GridControl();
//            this.ProcessGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
//            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
//            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
//            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
//            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
//            this.layoutControl1.SuspendLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.ProcessGridControl)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.ProcessGridView)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
//            this.SuspendLayout();
//            // 
//            // layoutControl1
//            // 
//            this.layoutControl1.Controls.Add(this.GetAllProcessSimpleButton);
//            this.layoutControl1.Controls.Add(this.ProcessGridControl);
//            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
//            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
//            this.layoutControl1.Name = "layoutControl1";
//            this.layoutControl1.Root = this.Root;
//            this.layoutControl1.Size = new System.Drawing.Size(965, 869);
//            this.layoutControl1.TabIndex = 0;
//            this.layoutControl1.Text = "layoutControl1";
//            // 
//            // GetAllProcessSimpleButton
//            // 
//            this.GetAllProcessSimpleButton.Location = new System.Drawing.Point(12, 12);
//            this.GetAllProcessSimpleButton.Name = "GetAllProcessSimpleButton";
//            this.GetAllProcessSimpleButton.Size = new System.Drawing.Size(941, 22);
//            this.GetAllProcessSimpleButton.StyleController = this.layoutControl1;
//            this.GetAllProcessSimpleButton.TabIndex = 5;
//            this.GetAllProcessSimpleButton.Text = "获取所有进程";
//            this.GetAllProcessSimpleButton.Click += new System.EventHandler(this.GetAllProcessSimpleButton_Click);
//            // 
//            // ProcessGridControl
//            // 
//            this.ProcessGridControl.Location = new System.Drawing.Point(12, 38);
//            this.ProcessGridControl.MainView = this.ProcessGridView;
//            this.ProcessGridControl.Name = "ProcessGridControl";
//            this.ProcessGridControl.Size = new System.Drawing.Size(941, 819);
//            this.ProcessGridControl.TabIndex = 4;
//            this.ProcessGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
//            this.ProcessGridView});
//            this.ProcessGridControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProcessGridControl_MouseDown);
//            // 
//            // ProcessGridView
//            // 
//            this.ProcessGridView.GridControl = this.ProcessGridControl;
//            this.ProcessGridView.Name = "ProcessGridView";
//            // 
//            // Root
//            // 
//            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
//            this.Root.GroupBordersVisible = false;
//            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
//            this.layoutControlItem1,
//            this.layoutControlItem2});
//            this.Root.Name = "Root";
//            this.Root.Size = new System.Drawing.Size(965, 869);
//            this.Root.TextVisible = false;
//            // 
//            // layoutControlItem1
//            // 
//            this.layoutControlItem1.Control = this.ProcessGridControl;
//            this.layoutControlItem1.Location = new System.Drawing.Point(0, 26);
//            this.layoutControlItem1.Name = "layoutControlItem1";
//            this.layoutControlItem1.Size = new System.Drawing.Size(945, 823);
//            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
//            this.layoutControlItem1.TextVisible = false;
//            // 
//            // layoutControlItem2
//            // 
//            this.layoutControlItem2.Control = this.GetAllProcessSimpleButton;
//            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
//            this.layoutControlItem2.Name = "layoutControlItem2";
//            this.layoutControlItem2.Size = new System.Drawing.Size(945, 26);
//            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
//            this.layoutControlItem2.TextVisible = false;
//            // 
//            // ProcessControl
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.ClientSize = new System.Drawing.Size(965, 869);
//            this.Controls.Add(this.layoutControl1);
//            this.IconOptions.LargeImage = global::Pine_sTool.Properties.Resources.properties_32x32;
//            this.Name = "ProcessControl";
//            this.Text = "进程控制器";
//            this.Load += new System.EventHandler(this.ProcessControl_Load);
//            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
//            this.layoutControl1.ResumeLayout(false);
//            ((System.ComponentModel.ISupportInitialize)(this.ProcessGridControl)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.ProcessGridView)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
//            this.ResumeLayout(false);

//        }

//        #endregion

//        private DevExpress.XtraLayout.LayoutControl layoutControl1;
//        private DevExpress.XtraEditors.SimpleButton GetAllProcessSimpleButton;
//        private DevExpress.XtraGrid.GridControl ProcessGridControl;
//        private DevExpress.XtraGrid.Views.Grid.GridView ProcessGridView;
//        private DevExpress.XtraLayout.LayoutControlGroup Root;
//        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
//        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
//    }
//}