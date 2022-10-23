﻿#if !NET20 && !NETSTANDARD
using System.Windows;

namespace Bluehill.Deconstructors;

partial class Deconstructors {
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static void Deconstruct(this System.Windows.Point point, out double x, out double y) {
        x = point.X;
        y = point.Y;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static void Deconstruct(this System.Windows.Size size, out double width, out double height) {
        width = size.Width;
        height = size.Height;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static void Deconstruct(this Rect rectangle, out double left, out double top, out double right, out double bottom) {
        left = rectangle.Left;
        top = rectangle.Top;
        right = rectangle.Right;
        bottom = rectangle.Bottom;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static void Deconstruct(this Thickness thickness, out double left, out double top, out double right, out double bottom) {
        left = thickness.Left;
        top = thickness.Top;
        right = thickness.Right;
        bottom = thickness.Bottom;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static void Deconstruct(this System.Windows.Media.Color color, out byte red, out byte green, out byte blue, out byte alpha) {
        red = color.R;
        green = color.G;
        blue = color.B;
        alpha = color.A;
    }
}
#endif