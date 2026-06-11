using AntdUI;
using AngusTools;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Pid_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double SetPosition { get; set; } = 0.0;
        private int SetVelocity { get; set; } = 0;

        private List<double> dtList = [];
        private List<double> SetPosList = [];

        private bool Processing { get; set; } = false;

        private Task TaskProcess;

        private void slider8_ValueChanged(object sender, IntEventArgs e) => SetVelocity = e.Value;

        private void slider8_MouseUp(object sender, MouseEventArgs e) => slider8.Value = SetVelocity = 0;

        private async void BtnStart_Click(object sender, EventArgs e)
        {
            AntdUI.Button btn = sender as AntdUI.Button ?? new AntdUI.Button();
            btn.Loading= true;
            if (btn.Text=="Æô¶¯¸úËæ")
            {
                btn.Text = "Í£Ö¹¸úËæ";
                btn.IconSvg = "PauseCircleOutlined";
                Processing = true;
                TaskProcess = Task.Run(() => Process());
            }
            else
            {
                btn.Text = "Æô¶¯¸úËæ";
                btn.IconSvg = "PlayCircleOutlined";
                Processing = false;
                await TaskProcess;
            }
            btn.Loading = false;
        }

        private void Process()
        {
            DateTime dt20ms = DateTime.Now, dt200ms = DateTime.Now;
            Plot_M.Plot.Clear();
            Plot_M.Plot.Add.ScatterLine(dtList, SetPosList);
            while (Processing)
            {
                DateTime dtNow = DateTime.Now;
                if ((dtNow - dt20ms).TotalMilliseconds>=20)
                {
                    dtList.Add(dtNow.TimeOfDay.TotalMilliseconds);

                    //dtList.Add(dt20ms.TimeOfDay.TotalSeconds);
                    SetPosList.Add(SetPosition += SetVelocity);
                    if (dtList.Count>8000)
                    {
                        dtList.RemoveAt(0);
                        SetPosList.RemoveAt(0);
                    }
                    dt20ms = dtNow;
                }
                if ((dtNow - dt200ms).Microseconds >= 200)
                {
                    Plot_M.Invoke(() =>
                    {
                        Plot_M.Plot.Axes.AutoScale();
                        Plot_M.Refresh();
                    });
                    dt200ms = dtNow;
                }

                    Application.DoEvents();
                Thread.Sleep(0);
            }
        }
    }
}
