namespace Pid_Demo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AntdUI.SliderMarkItem sliderMarkItem6 = new AntdUI.SliderMarkItem();
            AntdUI.SliderMarkItem sliderMarkItem7 = new AntdUI.SliderMarkItem();
            AntdUI.SliderMarkItem sliderMarkItem8 = new AntdUI.SliderMarkItem();
            AntdUI.SliderMarkItem sliderMarkItem9 = new AntdUI.SliderMarkItem();
            AntdUI.SliderMarkItem sliderMarkItem10 = new AntdUI.SliderMarkItem();
            panel1 = new Panel();
            InProbability = new AntdUI.Input();
            InDamping = new AntdUI.Input();
            InNoiseStrength = new AntdUI.Input();
            InInertia = new AntdUI.Input();
            panel2 = new Panel();
            Plot_M = new ScottPlot.WinForms.FormsPlot();
            panel3 = new Panel();
            BtnClear = new AntdUI.Button();
            BtnStart = new AntdUI.Button();
            slider8 = new AntdUI.Slider();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(InProbability);
            panel1.Controls.Add(InDamping);
            panel1.Controls.Add(InNoiseStrength);
            panel1.Controls.Add(InInertia);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(238, 744);
            panel1.TabIndex = 0;
            // 
            // InProbability
            // 
            InProbability.Dock = DockStyle.Top;
            InProbability.Location = new Point(0, 132);
            InProbability.Name = "InProbability";
            InProbability.PrefixFore = Color.Blue;
            InProbability.PrefixSvg = "";
            InProbability.PrefixText = "干扰概率";
            InProbability.Radius = 10;
            InProbability.Size = new Size(238, 44);
            InProbability.TabIndex = 8;
            InProbability.Text = "321";
            InProbability.TextAlign = HorizontalAlignment.Right;
            InProbability.TextChanged += InInertia_TextChanged;
            // 
            // InDamping
            // 
            InDamping.Dock = DockStyle.Top;
            InDamping.Location = new Point(0, 88);
            InDamping.Name = "InDamping";
            InDamping.PrefixFore = Color.Blue;
            InDamping.PrefixSvg = "";
            InDamping.PrefixText = "阻尼系数";
            InDamping.Radius = 10;
            InDamping.Size = new Size(238, 44);
            InDamping.TabIndex = 7;
            InDamping.Text = "321";
            InDamping.TextAlign = HorizontalAlignment.Right;
            InDamping.TextChanged += InInertia_TextChanged;
            // 
            // InNoiseStrength
            // 
            InNoiseStrength.Dock = DockStyle.Top;
            InNoiseStrength.Location = new Point(0, 44);
            InNoiseStrength.Name = "InNoiseStrength";
            InNoiseStrength.PrefixFore = Color.Blue;
            InNoiseStrength.PrefixSvg = "";
            InNoiseStrength.PrefixText = "随机干扰强度";
            InNoiseStrength.Radius = 10;
            InNoiseStrength.Size = new Size(238, 44);
            InNoiseStrength.TabIndex = 6;
            InNoiseStrength.Text = "321";
            InNoiseStrength.TextAlign = HorizontalAlignment.Right;
            InNoiseStrength.TextChanged += InInertia_TextChanged;
            // 
            // InInertia
            // 
            InInertia.Dock = DockStyle.Top;
            InInertia.Location = new Point(0, 0);
            InInertia.Name = "InInertia";
            InInertia.PrefixFore = Color.Blue;
            InInertia.PrefixSvg = "";
            InInertia.PrefixText = "物理惯性系数";
            InInertia.Radius = 10;
            InInertia.Size = new Size(238, 44);
            InInertia.TabIndex = 5;
            InInertia.Text = "321";
            InInertia.TextAlign = HorizontalAlignment.Right;
            InInertia.TextChanged += InInertia_TextChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(Plot_M);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(238, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1240, 509);
            panel2.TabIndex = 1;
            // 
            // Plot_M
            // 
            Plot_M.Dock = DockStyle.Fill;
            Plot_M.Location = new Point(0, 0);
            Plot_M.Margin = new Padding(5);
            Plot_M.Name = "Plot_M";
            Plot_M.Size = new Size(1240, 509);
            Plot_M.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.Controls.Add(BtnClear);
            panel3.Controls.Add(BtnStart);
            panel3.Controls.Add(slider8);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(238, 509);
            panel3.Name = "panel3";
            panel3.Size = new Size(1240, 235);
            panel3.TabIndex = 2;
            // 
            // BtnClear
            // 
            BtnClear.Location = new Point(755, 6);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(128, 52);
            BtnClear.TabIndex = 8;
            BtnClear.Text = "清空";
            BtnClear.Type = AntdUI.TTypeMini.Error;
            BtnClear.Click += BtnClear_Click;
            // 
            // BtnStart
            // 
            BtnStart.AutoSizeMode = AntdUI.TAutoSize.Auto;
            BtnStart.BackExtend = "135, #6253E1, #04BEFE";
            BtnStart.IconSvg = "PlayCircleOutlined";
            BtnStart.Location = new Point(889, 6);
            BtnStart.Name = "BtnStart";
            BtnStart.Size = new Size(128, 52);
            BtnStart.TabIndex = 7;
            BtnStart.Text = "启动跟随";
            BtnStart.Type = AntdUI.TTypeMini.Primary;
            BtnStart.Click += BtnStart_Click;
            // 
            // slider8
            // 
            slider8.Align = AntdUI.TAlignMini.Bottom;
            slider8.Dock = DockStyle.Right;
            slider8.Location = new Point(1186, 0);
            sliderMarkItem6.Text = "-10";
            sliderMarkItem6.Value = -10;
            sliderMarkItem7.Text = "-5";
            sliderMarkItem7.Value = -5;
            sliderMarkItem8.Text = "0";
            sliderMarkItem9.Text = "5";
            sliderMarkItem9.Value = 5;
            sliderMarkItem10.Text = "10";
            sliderMarkItem10.Value = 10;
            slider8.Marks.Add(sliderMarkItem6);
            slider8.Marks.Add(sliderMarkItem7);
            slider8.Marks.Add(sliderMarkItem8);
            slider8.Marks.Add(sliderMarkItem9);
            slider8.Marks.Add(sliderMarkItem10);
            slider8.MaxValue = 10;
            slider8.MinValue = -10;
            slider8.Name = "slider8";
            slider8.Padding = new Padding(0, 0, 34, 0);
            slider8.Size = new Size(54, 235);
            slider8.TabIndex = 2;
            slider8.ValueChanged += slider8_ValueChanged;
            slider8.MouseUp += slider8_MouseUp;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1478, 744);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private ScottPlot.WinForms.FormsPlot Plot_M;
        private AntdUI.Slider slider8;
        private AntdUI.Button BtnStart;
        private AntdUI.Button BtnClear;
        private AntdUI.Input InInertia;
        private AntdUI.Input InNoiseStrength;
        private AntdUI.Input InProbability;
        private AntdUI.Input InDamping;
    }
}
