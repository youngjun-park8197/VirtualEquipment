using jsLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtualEquip
{
    public partial class frmEquip : Form
    {
        public frmEquip()
        {
            InitializeComponent();
        }

        iniFile inif = new iniFile(".\\VirtualEquip.ini");
        private void Form1_Load(object sender, EventArgs e)
        {
            tbEqCode.Text       = inif.GetString("Equipment", "EqCode", "00001");
            tbEqModel.Text      = inif.GetString("Equipment", "EqModel", "000000");
            tbEqLineNum.Text    = inif.GetString("Equipment", "EqLineNum", "00001");
            tbEqBattery.Text    = inif.GetString("Equipment", "EqBattery", "00001");
            tbEqOperState.Text  = inif.GetString("Equipment", "EqOperState", "00001");
            tbEqOperCount.Text  = inif.GetString("Equipment", "EqOperCount", "00001");

            tbEqTemp.Text       = inif.GetString("Environment", "EqTemp", "00001");
            tbEqHumid.Text      = inif.GetString("Environment", "EqHumid", "00001");
            tbEqWind.Text       = inif.GetString("Environment", "EqWind", "00001");
            tbEqOzon.Text       = inif.GetString("Environment", "EqOzon", "00001");
            tbEqAtmos.Text      = inif.GetString("Environment", "EqAtmos", "00001");
            tbEqTotal.Text      = inif.GetString("Environment", "EqTotal", "00001");

            dtBegin.Value = new DateTime(long.Parse(inif.GetString("Operation", "StartTime", "0")));
            dtEnd.Value = new DateTime(long.Parse(inif.GetString("Operation", "StopTime", "0")));
            tbEqInterval.Text = inif.GetString("Operation", "Interval", "5");

            int x1, x2, y1, y2;

            sbLabel1.Text = inif.GetString("Server", "IP", "127.0.0.1");
            sbLabel2.Text = inif.GetString("Server", "Port", "9001");

            x1 = int.Parse(inif.GetString("Form", "LocationX", "0"));
            y1 = int.Parse(inif.GetString("Form", "LocationY", "0"));
            this.Location = new Point(x1, y1);


            x2 = int.Parse(inif.GetString("Form", "SizeX", "500"));
            y2 = int.Parse(inif.GetString("Form", "SizeY", "500"));
            this.Size = new Size(x2, y2);

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            inif.SetString("Equipment", "EqCode",       tbEqCode.Text);
            inif.SetString("Equipment", "EqModel",      tbEqModel.Text);
            inif.SetString("Equipment", "EqLineNum",    tbEqLineNum.Text);
            inif.SetString("Equipment", "EqBattery",    tbEqBattery.Text);
            inif.SetString("Equipment", "EqOperState",  tbEqOperState.Text);
            inif.SetString("Equipment", "EqOperCount",  tbEqOperCount.Text);
                                                        
            inif.SetString("Environment", "EqTemp",     tbEqTemp.Text);
            inif.SetString("Environment", "EqHumid",    tbEqHumid.Text);
            inif.SetString("Environment", "EqWind",     tbEqWind.Text);
            inif.SetString("Environment", "EqOzon",     tbEqOzon.Text);
            inif.SetString("Environment", "EqAtmos",    tbEqAtmos.Text);
            inif.SetString("Environment", "EqTotal",    tbEqTotal.Text);

            inif.SetString("Operation", "StartDate",    dtBegin.Value.Ticks.ToString());
            inif.SetString("Operation", "StopDate",     dtEnd.Value.Ticks.ToString());
            inif.SetString("Operation", "StartTime",    dtBeginClock.Value.Ticks.ToString());
            inif.SetString("Operation", "StopTime",     dtEndClock.Value.Ticks.ToString());
            inif.SetString("Operation", "Interval",     tbEqInterval.Text);

            inif.SetString("Server", "IP",              sbLabel1.Text);
            inif.SetString("Server", "Port",            sbLabel2.Text);

            inif.SetString("Form", "LocationX",         $"{Location.X}");
            inif.SetString("Form", "LocationY",         $"{Location.Y}");
            inif.SetString("Form", "SizeX",             $"{Size.Width}");
            inif.SetString("Form", "SizeY",             $"{Size.Height}");

            if (threadRead != null) threadRead.Abort();
        }


        Socket sock = null;
        Thread threadRead = null;

        delegate void cbAddText(string str);
        void AddText(string str)
        {
            if(tbMonitor.InvokeRequired)
            {
                cbAddText cb = new cbAddText(AddText);
                Invoke(cb, new object[] { str });
            }
            else
            {
                tbMonitor.AppendText(str);
            }
        }


        void ReadProcess()
        {
            Socket lsock = sock;
            while(true)
            {
                lsock = sock;
                if (jslib.IsAlive(lsock) && lsock.Available > 0)
                {
                    byte[] bArr = new byte[lsock.Available]; // 읽어들여야하는 만큼 배열 생성(필요 버퍼 확보)
                    lsock.Receive(bArr);
                    AddText(Encoding.Default.GetString(bArr) + "\r\n"); 
                }
                Thread.Sleep(100);
            }
        }


        private void mnuStart_Click(object sender, EventArgs e) // 처음 수행 시
        {
            if(sock == null) sock.Close(); // 재시작 상황
            
            sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            sock.Connect(sbLabel1.Text, int.Parse(sbLabel2.Text)); // 소켓 연결 
            
            if(threadRead == null) threadRead.Abort(); // 재시작 상황
           
            threadRead = new Thread(ReadProcess);
            threadRead.Start(); // 스레드까지 정상적으로 수행

            try
            {
                timer1.Interval = int.Parse(tbEqInterval.Text) * 1000;
                timer1.Start();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        private void mnuStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if(threadRead != null) { threadRead.Abort(); threadRead = null; }
            if(sock != null) { sock.Close(); sock = null; }
        }


        private void sbLabel1_DoubleClick(object sender, EventArgs e)
        {
            string str = jslib.GetInput("IP Address");
            if (str != "") sbLabel1.Text = str;
        }

        private void sbLabel2_DoubleClick(object sender, EventArgs e)
        {
            string str = jslib.GetInput("Port");
            if (str != "") sbLabel2.Text = str;
        }


        char STX = '\u0002';
        char ETX = '\u0003';
        /*
            int n = 123;
            string ss = "123";  // string -> int.parse
            string str = $"[{n}]"; // -> [123]
            string str = $"[{n,6}]"; // -> [___123]
            string str = $"[{n,-6}]"; // -> [123___]
            string str = $"[{n,6:D5}]"; // -> [_00123]
            
            < 텍스트명>        : <문자열타입(자릿수)>
            tbEqCode.Text      : string(5)
            tbEqModel.Text     : string(6)
            tbEqLineNum.Text   : string(5)
            tbEqBattery.Text   : string(5)
            tbEqOperState.Text : int(1)
            tbEqOperCount.Text : int(5)
            tbEqTemp.Text      : int(4)
            tbEqHumid.Text     : int(4)
            tbEqWind.Text      : int(4)
            tbEqOzon.Text      : int(4)
            tbEqAtmos.Text     : int(1)
            tbEqTotal.Text     : int(4)
            총 48 자릿수
        */

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            if(CheckInTime())
            {
                SetRandomValue();
                // Packet 구성 : 패킷의 전,후에 [02]STX [03]ETX 문자를 덧붙임
                // send package : byte[] 로 구성
                string str = $"{STX}";
                str += $"{tbEqCode.Text,5}{tbEqModel.Text,6}{tbEqLineNum.Text,5}{float.Parse(tbEqBattery.Text),5:F2}";
                str += $"{tbEqOperState.Text,1}{int.Parse(tbEqOperCount.Text):D5}";
                str += $"{int.Parse(tbEqHumid.Text):D4}{int.Parse(tbEqHumid.Text):D4}{int.Parse(tbEqWind.Text):D4}";
                str += $"{int.Parse(tbEqOzon.Text):D4}{int.Parse(tbEqAtmos.Text):D1}{int.Parse(tbEqTotal.Text):D4}";
                str += $"{ETX}";

                byte[] ba = Encoding.Default.GetBytes(str);

                if (jslib.IsAlive(sock))
                {
                    sock.Send(ba);
                    tbEqOperCount.Text = $"{int.Parse(tbEqOperCount.Text) + 1}";
                }
            }
            timer1.Start();
        }


        void SetRandomValue()
        {
            Random r = new Random();
            tbEqTemp.Text   = $"{r.Next(0, 99)}";
            tbEqHumid.Text  = $"{r.Next(0, 99)}";
            tbEqWind.Text   = $"{r.Next(0, 99)}";
            tbEqOzon.Text   = $"{r.Next(0, 99)}";
        }


        bool CheckInTime()
        {
            DateTime dt = DateTime.Now;
            DateTime st = dtBegin.Value.Date + dtBeginClock.Value.TimeOfDay;
            DateTime et = dtEnd.Value.Date + dtEndClock.Value.TimeOfDay;

            return st < dt && dt < et;
        }

    }
}
