﻿using System.Windows;

namespace UserGuideForMVVM.Controls;

public class GuidVo
{
    public FrameworkElement Uc { get; set; } = null!;
    public string? Content { get; set; } = null!;
    public int Width { get; set; } = 220;
    public int Height { get; set; }
}