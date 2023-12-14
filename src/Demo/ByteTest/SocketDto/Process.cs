﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocketDto;

/// <summary>
/// 操作系统进程信息
/// </summary>
public class Process
{
    /// <summary>
    /// 进程ID
    /// </summary>
    public int PID { get; set; }

    /// <summary>
    /// 进程名称
    /// </summary>
    public string ProcessName { get; set; }

    /// <summary>
    /// 进程类型
    /// </summary>
    public string Type { get; set; }

    /// <summary>
    /// 进程状态
    /// </summary>
    public string Status { get; set; }

    /// <summary>
    /// 发布者
    /// </summary>
    public string Publisher { get; set; }

    /// <summary>
    /// 命令行
    /// </summary>
    public string CommandLine { get; set; }

    /// <summary>
    /// CPU使用率
    /// </summary>
    public double CPUUsage { get; set; }

    /// <summary>
    /// 内存使用大小
    /// </summary>
    public double MemoryUsage { get; set; }

    /// <summary>
    /// 磁盘使用大小
    /// </summary>
    public double DiskUsage { get; set; }

    /// <summary>
    /// 网络使用值
    /// </summary>
    public double NetworkUsage { get; set; }

    /// <summary>
    /// GPU
    /// </summary>
    public double GPU { get; set; }

    /// <summary>
    /// GPU引擎
    /// </summary>
    public string GPUEngine { get; set; }

    /// <summary>
    /// 电源使用情况
    /// </summary>
    public byte PowerUsage { get; set; }

    /// <summary>
    /// 电源使用情况趋势
    /// </summary>
    public byte PowerUsageTrend { get; set; }
}