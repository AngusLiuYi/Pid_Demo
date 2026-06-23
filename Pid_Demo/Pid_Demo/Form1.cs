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

        /// <summary>
        /// 当前给定目标位置
        /// </summary>
        private double SetPosition { get; set; } = 0.0;

        /// <summary>
        /// 当前给定目标速度
        /// </summary>
        private int SetVelocity { get; set; } = 0;

        /// <summary>
        /// 当前反馈目标位置
        /// </summary>
        private double ActPosition { get; set; } = 0.0;

        /// <summary>
        /// 当前反馈目标速度
        /// </summary>
        private int ActVelocity { get; set; } = 0;

        /// <summary>
        /// 时间数组
        /// 用于图标X轴时间坐标
        /// </summary>
        private List<double> dtList = [];

        /// <summary>
        /// 目标位置数组
        /// 用于图表显示曲线
        /// </summary>
        private List<double> SetPosList = [];

        /// <summary>
        /// 当前位置数组，用于图表显示曲线
        /// </summary>
        private List<double> ActPosList = [];

        /// <summary>
        /// 流程是否正在运行
        /// </summary>
        private bool Processing { get; set; } = false;

        /// <summary>
        /// 异步刷新目标位置任务
        /// </summary>
        private Task TaskProcess;

        /// <summary>
        /// 点动按钮，鼠标按下时，给定目标速度值
        /// 获取当前点动速度值，给定目标位置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void slider8_ValueChanged(object sender, IntEventArgs e) => SetVelocity = e.Value;

        /// <summary>
        /// 点动停止事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void slider8_MouseUp(object sender, MouseEventArgs e) => slider8.Value = SetVelocity = 0;

        /// <summary>
        /// 流程启动/停止按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void BtnStart_Click(object sender, EventArgs e)
        {
            AntdUI.Button btn = sender as AntdUI.Button ?? new AntdUI.Button();
            btn.Loading= true;
            if (btn.Text=="启动跟随")
            {
                btn.Text = "停止跟随";
                btn.IconSvg = "PauseCircleOutlined";

                //启动流程
                Processing = true;
                TaskProcess = Task.Run(() => Process());
            }
            else
            {
                btn.Text = "启动跟随";
                btn.IconSvg = "PlayCircleOutlined";

                //停止流程
                Processing = false;
                await TaskProcess;
            }
            btn.Loading = false;
        }

        private SimSystem simSystem = new();
        private void Process()
        {
            //获取当前时间戳
            DateTime dtNow = DateTime.Now;
            //定义20ms与200ms时间戳，用于控制刷新频率
            DateTime dt20ms = dtNow, dt200ms = dtNow;

            //清除图表数据
            Plot_M.Plot.Clear();
            //默认创建目标位置曲线
            Plot_M.Plot.Add.ScatterLine(dtList, SetPosList);
            Plot_M.Plot.Add.ScatterLine(dtList, ActPosList);

            //开启流程
            while (Processing)
            {
                dtNow = DateTime.Now;
                //20ms时间间隔，刷新目标位置数据
                if ((dtNow - dt20ms).TotalMilliseconds>=20)
                {
                    //获取当前时间及目标位置数据
                    dtList.Add(dtNow.TimeOfDay.TotalMilliseconds);

                    SetPosition = Math.Max(-1000, Math.Min(SetPosition += SetVelocity, 1000));
                    SetPosList.Add(SetPosition);

                    ActPosition =simSystem.Update(SetPosition-simSystem.CurrentValue);
                    ActPosList.Add(ActPosition);

                    //限制数据量，避免内存占用过大
                    if (dtList.Count>3000)
                    {
                        dtList.RemoveAt(0);
                        SetPosList.RemoveAt(0);
                    }
                    //更新时间戳
                    dt20ms = dtNow;
                }

                //200ms时间间隔，刷新图表显示
                if ((dtNow - dt200ms).Microseconds >= 200)
                {
                    Plot_M.Invoke(() =>
                    {
                        Plot_M.Plot.Axes.AutoScale();
                        Plot_M.Refresh();
                    });

                    //更新时间戳
                    dt200ms = dtNow;
                }

                //释放CPU资源，避免UI线程阻塞
                Application.DoEvents();
                Thread.Sleep(0);
            }
        }
    }
}
