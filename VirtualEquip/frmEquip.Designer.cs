
namespace VirtualEquip
{
    partial class frmEquip
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStart = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStop = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sbLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sbLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbEqInterval = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dtBegin = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbEqTotal = new System.Windows.Forms.TextBox();
            this.tbEqAtmos = new System.Windows.Forms.TextBox();
            this.tbEqOzon = new System.Windows.Forms.TextBox();
            this.tbEqWind = new System.Windows.Forms.TextBox();
            this.tbEqHumid = new System.Windows.Forms.TextBox();
            this.tbEqTemp = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbEqOperCount = new System.Windows.Forms.TextBox();
            this.tbEqBattery = new System.Windows.Forms.TextBox();
            this.tbEqModel = new System.Windows.Forms.TextBox();
            this.tbEqOperState = new System.Windows.Forms.TextBox();
            this.tbEqLineNum = new System.Windows.Forms.TextBox();
            this.tbEqCode = new System.Windows.Forms.TextBox();
            this.tbMonitor = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dtBeginClock = new System.Windows.Forms.DateTimePicker();
            this.dtEndClock = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.configToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(660, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuStart,
            this.mnuStop,
            this.toolStripSeparator1,
            this.mnuExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mnuStart
            // 
            this.mnuStart.Name = "mnuStart";
            this.mnuStart.Size = new System.Drawing.Size(99, 22);
            this.mnuStart.Text = "Start";
            this.mnuStart.Click += new System.EventHandler(this.mnuStart_Click);
            // 
            // mnuStop
            // 
            this.mnuStop.Name = "mnuStop";
            this.mnuStop.Size = new System.Drawing.Size(180, 22);
            this.mnuStop.Text = "Stop";
            this.mnuStop.Click += new System.EventHandler(this.mnuStop_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(96, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(99, 22);
            this.mnuExit.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // configToolStripMenuItem
            // 
            this.configToolStripMenuItem.Name = "configToolStripMenuItem";
            this.configToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.configToolStripMenuItem.Text = "Config";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sbLabel1,
            this.sbLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 410);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(660, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // sbLabel1
            // 
            this.sbLabel1.AutoSize = false;
            this.sbLabel1.Name = "sbLabel1";
            this.sbLabel1.Size = new System.Drawing.Size(100, 17);
            this.sbLabel1.Text = "127.0.0.1";
            this.sbLabel1.DoubleClick += new System.EventHandler(this.sbLabel1_DoubleClick);
            // 
            // sbLabel2
            // 
            this.sbLabel2.Name = "sbLabel2";
            this.sbLabel2.Size = new System.Drawing.Size(35, 17);
            this.sbLabel2.Text = "9001";
            this.sbLabel2.DoubleClick += new System.EventHandler(this.sbLabel2_DoubleClick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tbMonitor);
            this.splitContainer1.Size = new System.Drawing.Size(660, 386);
            this.splitContainer1.SplitterDistance = 341;
            this.splitContainer1.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtEndClock);
            this.groupBox3.Controls.Add(this.dtBeginClock);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.tbEqInterval);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.dtEnd);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.dtBegin);
            this.groupBox3.Location = new System.Drawing.Point(5, 264);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(333, 109);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "가동 정보";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(172, 78);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(17, 12);
            this.label16.TabIndex = 6;
            this.label16.Text = "초";
            // 
            // tbEqInterval
            // 
            this.tbEqInterval.Location = new System.Drawing.Point(66, 75);
            this.tbEqInterval.Name = "tbEqInterval";
            this.tbEqInterval.Size = new System.Drawing.Size(100, 21);
            this.tbEqInterval.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 78);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 12);
            this.label15.TabIndex = 4;
            this.label15.Text = "시간간격";
            // 
            // dtEnd
            // 
            this.dtEnd.Location = new System.Drawing.Point(66, 48);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(100, 21);
            this.dtEnd.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 54);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 12);
            this.label14.TabIndex = 2;
            this.label14.Text = "종료시간";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 1;
            this.label13.Text = "시작시간";
            // 
            // dtBegin
            // 
            this.dtBegin.Location = new System.Drawing.Point(66, 21);
            this.dtBegin.Name = "dtBegin";
            this.dtBegin.Size = new System.Drawing.Size(100, 21);
            this.dtBegin.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tbEqTotal);
            this.groupBox2.Controls.Add(this.tbEqAtmos);
            this.groupBox2.Controls.Add(this.tbEqOzon);
            this.groupBox2.Controls.Add(this.tbEqWind);
            this.groupBox2.Controls.Add(this.tbEqHumid);
            this.groupBox2.Controls.Add(this.tbEqTemp);
            this.groupBox2.Location = new System.Drawing.Point(5, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(333, 114);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "환경 정보";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(275, 79);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 11;
            this.label12.Text = "상태";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 10;
            this.label11.Text = "대기";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(275, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 9;
            this.label10.Text = "오존";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 8;
            this.label9.Text = "풍속";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(275, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 7;
            this.label8.Text = "습도";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "온도";
            // 
            // tbEqTotal
            // 
            this.tbEqTotal.Location = new System.Drawing.Point(170, 76);
            this.tbEqTotal.Name = "tbEqTotal";
            this.tbEqTotal.Size = new System.Drawing.Size(100, 21);
            this.tbEqTotal.TabIndex = 5;
            // 
            // tbEqAtmos
            // 
            this.tbEqAtmos.Location = new System.Drawing.Point(63, 76);
            this.tbEqAtmos.Name = "tbEqAtmos";
            this.tbEqAtmos.Size = new System.Drawing.Size(100, 21);
            this.tbEqAtmos.TabIndex = 4;
            // 
            // tbEqOzon
            // 
            this.tbEqOzon.Location = new System.Drawing.Point(170, 47);
            this.tbEqOzon.Name = "tbEqOzon";
            this.tbEqOzon.Size = new System.Drawing.Size(100, 21);
            this.tbEqOzon.TabIndex = 3;
            // 
            // tbEqWind
            // 
            this.tbEqWind.Location = new System.Drawing.Point(63, 48);
            this.tbEqWind.Name = "tbEqWind";
            this.tbEqWind.Size = new System.Drawing.Size(100, 21);
            this.tbEqWind.TabIndex = 2;
            // 
            // tbEqHumid
            // 
            this.tbEqHumid.Location = new System.Drawing.Point(170, 20);
            this.tbEqHumid.Name = "tbEqHumid";
            this.tbEqHumid.Size = new System.Drawing.Size(100, 21);
            this.tbEqHumid.TabIndex = 1;
            // 
            // tbEqTemp
            // 
            this.tbEqTemp.Location = new System.Drawing.Point(63, 20);
            this.tbEqTemp.Name = "tbEqTemp";
            this.tbEqTemp.Size = new System.Drawing.Size(100, 21);
            this.tbEqTemp.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbEqOperCount);
            this.groupBox1.Controls.Add(this.tbEqBattery);
            this.groupBox1.Controls.Add(this.tbEqModel);
            this.groupBox1.Controls.Add(this.tbEqOperState);
            this.groupBox1.Controls.Add(this.tbEqLineNum);
            this.groupBox1.Controls.Add(this.tbEqCode);
            this.groupBox1.Location = new System.Drawing.Point(5, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 113);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "장비 상태 정보";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(275, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "가동횟수";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(274, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "BatteryV";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(274, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "장비모델";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "가동여부";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "Line No.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "장비코드";
            // 
            // tbEqOperCount
            // 
            this.tbEqOperCount.Location = new System.Drawing.Point(169, 76);
            this.tbEqOperCount.Name = "tbEqOperCount";
            this.tbEqOperCount.Size = new System.Drawing.Size(100, 21);
            this.tbEqOperCount.TabIndex = 5;
            // 
            // tbEqBattery
            // 
            this.tbEqBattery.Location = new System.Drawing.Point(169, 48);
            this.tbEqBattery.Name = "tbEqBattery";
            this.tbEqBattery.Size = new System.Drawing.Size(100, 21);
            this.tbEqBattery.TabIndex = 4;
            // 
            // tbEqModel
            // 
            this.tbEqModel.Location = new System.Drawing.Point(169, 20);
            this.tbEqModel.Name = "tbEqModel";
            this.tbEqModel.Size = new System.Drawing.Size(100, 21);
            this.tbEqModel.TabIndex = 3;
            // 
            // tbEqOperState
            // 
            this.tbEqOperState.Location = new System.Drawing.Point(63, 75);
            this.tbEqOperState.Name = "tbEqOperState";
            this.tbEqOperState.Size = new System.Drawing.Size(100, 21);
            this.tbEqOperState.TabIndex = 2;
            // 
            // tbEqLineNum
            // 
            this.tbEqLineNum.Location = new System.Drawing.Point(63, 48);
            this.tbEqLineNum.Name = "tbEqLineNum";
            this.tbEqLineNum.Size = new System.Drawing.Size(100, 21);
            this.tbEqLineNum.TabIndex = 1;
            // 
            // tbEqCode
            // 
            this.tbEqCode.Location = new System.Drawing.Point(63, 20);
            this.tbEqCode.Name = "tbEqCode";
            this.tbEqCode.Size = new System.Drawing.Size(100, 21);
            this.tbEqCode.TabIndex = 0;
            // 
            // tbMonitor
            // 
            this.tbMonitor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMonitor.Location = new System.Drawing.Point(3, 4);
            this.tbMonitor.Multiline = true;
            this.tbMonitor.Name = "tbMonitor";
            this.tbMonitor.Size = new System.Drawing.Size(309, 379);
            this.tbMonitor.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dtBeginClock
            // 
            this.dtBeginClock.Location = new System.Drawing.Point(174, 21);
            this.dtBeginClock.Name = "dtBeginClock";
            this.dtBeginClock.ShowUpDown = true;
            this.dtBeginClock.Size = new System.Drawing.Size(130, 21);
            this.dtBeginClock.TabIndex = 7;
            this.dtBeginClock.Value = new System.DateTime(2021, 4, 21, 13, 46, 0, 0);
            // 
            // dtEndClock
            // 
            this.dtEndClock.Location = new System.Drawing.Point(174, 48);
            this.dtEndClock.Name = "dtEndClock";
            this.dtEndClock.Size = new System.Drawing.Size(130, 21);
            this.dtEndClock.TabIndex = 8;
            // 
            // frmEquip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 432);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmEquip";
            this.Text = "Virtual Equipment";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel sbLabel1;
        private System.Windows.Forms.ToolStripStatusLabel sbLabel2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbEqTotal;
        private System.Windows.Forms.TextBox tbEqAtmos;
        private System.Windows.Forms.TextBox tbEqOzon;
        private System.Windows.Forms.TextBox tbEqWind;
        private System.Windows.Forms.TextBox tbEqHumid;
        private System.Windows.Forms.TextBox tbEqTemp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbEqOperCount;
        private System.Windows.Forms.TextBox tbEqBattery;
        private System.Windows.Forms.TextBox tbEqModel;
        private System.Windows.Forms.TextBox tbEqOperState;
        private System.Windows.Forms.TextBox tbEqLineNum;
        private System.Windows.Forms.TextBox tbEqCode;
        private System.Windows.Forms.TextBox tbMonitor;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbEqInterval;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtBegin;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuStart;
        private System.Windows.Forms.ToolStripMenuItem mnuStop;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DateTimePicker dtEndClock;
        private System.Windows.Forms.DateTimePicker dtBeginClock;
    }
}

