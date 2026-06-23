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
            AntdUI.SliderMarkItem sliderMarkItem1 = new AntdUI.SliderMarkItem();
            AntdUI.SliderMarkItem sliderMarkItem2 = new AntdUI.SliderMarkItem();
            AntdUI.SliderMarkItem sliderMarkItem3 = new AntdUI.SliderMarkItem();
            AntdUI.SliderMarkItem sliderMarkItem4 = new AntdUI.SliderMarkItem();
            AntdUI.SliderMarkItem sliderMarkItem5 = new AntdUI.SliderMarkItem();
            panel1 = new Panel();
            panel2 = new Panel();
            Plot_M = new ScottPlot.WinForms.FormsPlot();
            panel3 = new Panel();
            BtnStart = new AntdUI.Button();
            slider8 = new AntdUI.Slider();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(401, 744);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(Plot_M);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(401, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1077, 509);
            panel2.TabIndex = 1;
            // 
            // Plot_M
            // 
            Plot_M.Dock = DockStyle.Fill;
            Plot_M.Location = new Point(0, 0);
            Plot_M.Margin = new Padding(5);
            Plot_M.Name = "Plot_M";
            Plot_M.Size = new Size(1077, 509);
            Plot_M.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.Controls.Add(BtnStart);
            panel3.Controls.Add(slider8);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(401, 509);
            panel3.Name = "panel3";
            panel3.Size = new Size(1077, 235);
            panel3.TabIndex = 2;
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
            slider8.Location = new Point(1023, 0);
            sliderMarkItem1.Text = "-10";
            sliderMarkItem1.Value = -10;
            sliderMarkItem2.Text = "-5";
            sliderMarkItem2.Value = -5;
            sliderMarkItem3.Text = "0";
            sliderMarkItem4.Text = "5";
            sliderMarkItem4.Value = 5;
            sliderMarkItem5.Text = "10";
            sliderMarkItem5.Value = 10;
            slider8.Marks.Add(sliderMarkItem1);
            slider8.Marks.Add(sliderMarkItem2);
            slider8.Marks.Add(sliderMarkItem3);
            slider8.Marks.Add(sliderMarkItem4);
            slider8.Marks.Add(sliderMarkItem5);
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
    }
}
