using System;
using System.Collections.Generic;

namespace Pine_sTool.DetailedFunctionalities.MouseClickProgram
{
    public partial class ClickSettingForm : DevExpress.XtraEditors.XtraForm
    {
        public ClickSettingForm()
        {
            InitializeComponent();
        }

        private void ClickSettingForm_Load(object sender, EventArgs e)
        {
            X_AxisTextEdit.Text = Pine_sTool.Properties.Settings.Default.Xaxis.ToString();
            Y_AxisTextEdit.Text = Pine_sTool.Properties.Settings.Default.Yaxis.ToString();
            SpanDurationTextEdit.Text = Pine_sTool.Properties.Settings.Default.SpanDuration.ToString();
            SyncClickTimesTextEdit.Text = Pine_sTool.Properties.Settings.Default.SyncClickTimes.ToString();
        }

        private void StartClick_Click(object sender, EventArgs e)
        {
            if (MinFormCheckEdit.Checked == true)
            { elementDic["最小化到通知栏"] = "是"; }
            else { elementDic["最小化到通知栏"] = "否"; }

            if (AppointedCheckEdit.Checked == true)
            {
                elementDic["点击模式"] = "指定位置点击";
                elementDic["指定位置点击-点击间隔"] = SpanDurationTextEdit.Text.ToString();
                elementDic["指定位置点击-X轴"] = X_AxisTextEdit.Text.ToString();
                elementDic["指定位置点击-Y轴"] = Y_AxisTextEdit.Text.ToString();
                elementDic["同时刻点击次数"] = SyncClickTimesTextEdit.Text.ToString();
            }
            else if (true)
            {
                //...
            }

            myEvent(elementDic);
            //系统设置范围是用户是可读可写的，设置范围是应用程序是只读的
            try
            {
                Pine_sTool.Properties.Settings.Default.Xaxis = int.Parse(X_AxisTextEdit.Text.ToString());
                Pine_sTool.Properties.Settings.Default.Yaxis = int.Parse(Y_AxisTextEdit.Text.ToString());
                Pine_sTool.Properties.Settings.Default.SpanDuration = int.Parse(SpanDurationTextEdit.Text.ToString());
                Pine_sTool.Properties.Settings.Default.SyncClickTimes = int.Parse(SyncClickTimesTextEdit.Text.ToString());
                Pine_sTool.Properties.Settings.Default.Save();
            }
            catch (Exception) { }

            this.Close();
        }

        public delegate void MyDelegate(Dictionary<string, string> dic);

        public event MyDelegate myEvent;

        private Dictionary<string, string> elementDic = new Dictionary<string, string>()
        {
            {"最小化到通知栏","是" },
            {"点击模式","指定位置点击" },
            {"指定位置点击-点击间隔","30" },
            {"指定位置点击-X轴", Pine_sTool.Properties.Settings.Default.Xaxis.ToString() },
            {"指定位置点击-Y轴",Pine_sTool.Properties.Settings.Default.Yaxis.ToString() },
            {"同时刻点击次数","1" },
        };

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClickSettingForm));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.StartClick = new DevExpress.XtraEditors.SimpleButton();
            this.checkEdit5 = new DevExpress.XtraEditors.CheckEdit();
            this.checkEdit4 = new DevExpress.XtraEditors.CheckEdit();
            this.checkEdit3 = new DevExpress.XtraEditors.CheckEdit();
            this.Y_AxisTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.X_AxisTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.SyncClickTimesTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.SpanDurationTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.AppointedCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.MinFormCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.X = new DevExpress.XtraLayout.LayoutControlItem();
            this.Y = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Y_AxisTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.X_AxisTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SyncClickTimesTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpanDurationTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppointedCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinFormCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            this.SuspendLayout();
            //
            // layoutControl1
            //
            this.layoutControl1.Controls.Add(this.StartClick);
            this.layoutControl1.Controls.Add(this.checkEdit5);
            this.layoutControl1.Controls.Add(this.checkEdit4);
            this.layoutControl1.Controls.Add(this.checkEdit3);
            this.layoutControl1.Controls.Add(this.Y_AxisTextEdit);
            this.layoutControl1.Controls.Add(this.X_AxisTextEdit);
            this.layoutControl1.Controls.Add(this.SyncClickTimesTextEdit);
            this.layoutControl1.Controls.Add(this.SpanDurationTextEdit);
            this.layoutControl1.Controls.Add(this.AppointedCheckEdit);
            this.layoutControl1.Controls.Add(this.MinFormCheckEdit);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(529, 261);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            //
            // StartClick
            //
            this.StartClick.Location = new System.Drawing.Point(12, 227);
            this.StartClick.Name = "StartClick";
            this.StartClick.Size = new System.Drawing.Size(505, 22);
            this.StartClick.StyleController = this.layoutControl1;
            this.StartClick.TabIndex = 13;
            this.StartClick.Text = "开始点击";
            this.StartClick.Click += new System.EventHandler(this.StartClick_Click);
            //
            // checkEdit5
            //
            this.checkEdit5.Location = new System.Drawing.Point(12, 192);
            this.checkEdit5.Name = "checkEdit5";
            this.checkEdit5.Properties.Caption = "特殊形状点击";
            this.checkEdit5.Size = new System.Drawing.Size(505, 19);
            this.checkEdit5.StyleController = this.layoutControl1;
            this.checkEdit5.TabIndex = 12;
            //
            // checkEdit4
            //
            this.checkEdit4.Location = new System.Drawing.Point(12, 159);
            this.checkEdit4.Name = "checkEdit4";
            this.checkEdit4.Properties.Caption = "代理点击";
            this.checkEdit4.Size = new System.Drawing.Size(505, 19);
            this.checkEdit4.StyleController = this.layoutControl1;
            this.checkEdit4.TabIndex = 11;
            //
            // checkEdit3
            //
            this.checkEdit3.Location = new System.Drawing.Point(12, 126);
            this.checkEdit3.Name = "checkEdit3";
            this.checkEdit3.Properties.Caption = "当前鼠标位置（偏移）点击";
            this.checkEdit3.Size = new System.Drawing.Size(505, 19);
            this.checkEdit3.StyleController = this.layoutControl1;
            this.checkEdit3.TabIndex = 10;
            //
            // Y_AxisTextEdit
            //
            this.Y_AxisTextEdit.Location = new System.Drawing.Point(413, 92);
            this.Y_AxisTextEdit.Name = "Y_AxisTextEdit";
            this.Y_AxisTextEdit.Size = new System.Drawing.Size(104, 20);
            this.Y_AxisTextEdit.StyleController = this.layoutControl1;
            this.Y_AxisTextEdit.TabIndex = 9;
            //
            // X_AxisTextEdit
            //
            this.X_AxisTextEdit.Location = new System.Drawing.Point(159, 92);
            this.X_AxisTextEdit.Name = "X_AxisTextEdit";
            this.X_AxisTextEdit.Size = new System.Drawing.Size(103, 20);
            this.X_AxisTextEdit.StyleController = this.layoutControl1;
            this.X_AxisTextEdit.TabIndex = 8;
            //
            // SyncClickTimesTextEdit
            //
            this.SyncClickTimesTextEdit.Location = new System.Drawing.Point(413, 68);
            this.SyncClickTimesTextEdit.Name = "SyncClickTimesTextEdit";
            this.SyncClickTimesTextEdit.Size = new System.Drawing.Size(104, 20);
            this.SyncClickTimesTextEdit.StyleController = this.layoutControl1;
            this.SyncClickTimesTextEdit.TabIndex = 7;
            //
            // SpanDurationTextEdit
            //
            this.SpanDurationTextEdit.Location = new System.Drawing.Point(159, 68);
            this.SpanDurationTextEdit.Name = "SpanDurationTextEdit";
            this.SpanDurationTextEdit.Size = new System.Drawing.Size(103, 20);
            this.SpanDurationTextEdit.StyleController = this.layoutControl1;
            this.SpanDurationTextEdit.TabIndex = 6;
            //
            // AppointedCheckEdit
            //
            this.AppointedCheckEdit.Location = new System.Drawing.Point(12, 45);
            this.AppointedCheckEdit.Name = "AppointedCheckEdit";
            this.AppointedCheckEdit.Properties.Caption = "指定位置点击";
            this.AppointedCheckEdit.Size = new System.Drawing.Size(505, 19);
            this.AppointedCheckEdit.StyleController = this.layoutControl1;
            this.AppointedCheckEdit.TabIndex = 5;
            //
            // MinFormCheckEdit
            //
            this.MinFormCheckEdit.Location = new System.Drawing.Point(12, 12);
            this.MinFormCheckEdit.Name = "MinFormCheckEdit";
            this.MinFormCheckEdit.Properties.Caption = "主界面最小化到通知栏";
            this.MinFormCheckEdit.Size = new System.Drawing.Size(505, 19);
            this.MinFormCheckEdit.StyleController = this.layoutControl1;
            this.MinFormCheckEdit.TabIndex = 4;
            //
            // layoutControlGroup1
            //
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.X,
            this.Y,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.layoutControlItem9,
            this.emptySpaceItem2,
            this.emptySpaceItem3,
            this.emptySpaceItem4,
            this.emptySpaceItem5,
            this.layoutControlItem10});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(529, 261);
            this.layoutControlGroup1.TextVisible = false;
            //
            // layoutControlItem1
            //
            this.layoutControlItem1.Control = this.MinFormCheckEdit;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(509, 23);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            //
            // emptySpaceItem1
            //
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 203);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(509, 12);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            //
            // layoutControlItem2
            //
            this.layoutControlItem2.Control = this.AppointedCheckEdit;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 33);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(509, 23);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            //
            // layoutControlItem3
            //
            this.layoutControlItem3.Control = this.SpanDurationTextEdit;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 56);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(254, 24);
            this.layoutControlItem3.Text = "点击时间间隔（单位：秒）";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(144, 14);
            //
            // layoutControlItem4
            //
            this.layoutControlItem4.Control = this.SyncClickTimesTextEdit;
            this.layoutControlItem4.Location = new System.Drawing.Point(254, 56);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(255, 24);
            this.layoutControlItem4.Text = "同时刻点击次数";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(144, 14);
            //
            // X
            //
            this.X.Control = this.X_AxisTextEdit;
            this.X.Location = new System.Drawing.Point(0, 80);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(254, 24);
            this.X.Text = "X轴（单位：像素）";
            this.X.TextSize = new System.Drawing.Size(144, 14);
            //
            // Y
            //
            this.Y.Control = this.Y_AxisTextEdit;
            this.Y.Location = new System.Drawing.Point(254, 80);
            this.Y.Name = "Y";
            this.Y.Size = new System.Drawing.Size(255, 24);
            this.Y.Text = "Y轴（单位：像素）";
            this.Y.TextSize = new System.Drawing.Size(144, 14);
            //
            // layoutControlItem7
            //
            this.layoutControlItem7.Control = this.checkEdit3;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 114);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(509, 23);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            //
            // layoutControlItem8
            //
            this.layoutControlItem8.Control = this.checkEdit4;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 147);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(509, 23);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            //
            // layoutControlItem9
            //
            this.layoutControlItem9.Control = this.checkEdit5;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 180);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(509, 23);
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            //
            // emptySpaceItem2
            //
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 23);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(509, 10);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            //
            // emptySpaceItem3
            //
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 104);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(509, 10);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            //
            // emptySpaceItem4
            //
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(0, 137);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(509, 10);
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            //
            // emptySpaceItem5
            //
            this.emptySpaceItem5.AllowHotTrack = false;
            this.emptySpaceItem5.Location = new System.Drawing.Point(0, 170);
            this.emptySpaceItem5.Name = "emptySpaceItem5";
            this.emptySpaceItem5.Size = new System.Drawing.Size(509, 10);
            this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
            //
            // layoutControlItem10
            //
            this.layoutControlItem10.Control = this.StartClick;
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 215);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(509, 26);
            this.layoutControlItem10.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem10.TextVisible = false;
            //
            // ClickSettingForm
            //
            this.ClientSize = new System.Drawing.Size(529, 261);
            this.Controls.Add(this.layoutControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClickSettingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "点击设置";
            this.Load += new System.EventHandler(this.ClickSettingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Y_AxisTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.X_AxisTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SyncClickTimesTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpanDurationTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppointedCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinFormCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            this.ResumeLayout(false);
        }

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton StartClick;
        private DevExpress.XtraEditors.CheckEdit checkEdit5;
        private DevExpress.XtraEditors.CheckEdit checkEdit4;
        private DevExpress.XtraEditors.CheckEdit checkEdit3;
        private DevExpress.XtraEditors.TextEdit Y_AxisTextEdit;
        private DevExpress.XtraEditors.TextEdit X_AxisTextEdit;
        private DevExpress.XtraEditors.TextEdit SyncClickTimesTextEdit;
        private DevExpress.XtraEditors.TextEdit SpanDurationTextEdit;
        private DevExpress.XtraEditors.CheckEdit AppointedCheckEdit;
        private DevExpress.XtraEditors.CheckEdit MinFormCheckEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem X;
        private DevExpress.XtraLayout.LayoutControlItem Y;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
    }
}