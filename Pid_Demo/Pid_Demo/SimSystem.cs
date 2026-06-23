using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pid_Demo
{
    internal class SimSystem
    {
        /// <summary>
        /// 当前值（初始50）
        /// </summary>
        public double CurrentValue { get; private set; } = 0.0;

        /// <summary>
        /// 物理惯性系数（越大越迟钝，整定越慢）
        /// </summary>
        public double Inertia { get; set; } = 0.15;

        /// <summary>
        /// 随机干扰强度（越大越容易震荡/过冲）
        /// </summary>
        public double NoiseStrength { get; set; } = 1.2;

        /// <summary>
        /// 阻尼系数（越小越容易震荡）
        /// </summary>
        public double Damping { get; set; } = 0.92;

        /// <summary>
        /// 上一时刻速度（惯性模拟）
        /// </summary>
        private double _lastSpeed;

        /// <summary>
        /// 随机数生成器
        /// </summary>
        private readonly Random _random = new Random();

        /// <summary>
        /// 核心：系统更新
        /// </summary>
        /// <param name="pidOutput">PID控制器输出</param>
        /// <returns>带干扰的实际当前值</returns>
        public double Update(double pidOutput)
        {
            // 1. 计算带惯性的运动速度
            double speed = pidOutput * Inertia + _lastSpeed * Damping;

            // 2. 生成随机干扰（含15%概率突发强干扰）
            double noise = (_random.NextDouble() * 2 - 1) * NoiseStrength;
            if (_random.NextDouble() < 0.15) noise *= 3;

            // 3. 更新当前值
            CurrentValue += speed + noise;

            // 4. 保存状态
            _lastSpeed = speed;

            // 限制范围（避免异常）
            CurrentValue = Math.Max(-1000, Math.Min(1000, CurrentValue));

            return CurrentValue;
        }
    }
}
