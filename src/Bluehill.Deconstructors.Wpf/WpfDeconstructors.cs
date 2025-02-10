namespace Bluehill.Deconstructors;

[EditorBrowsable(EditorBrowsableState.Never)]
public static class WpfDeconstructors {
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static void Deconstruct(this Point point, out double x, out double y) {
        x = point.X;
        y = point.Y;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static void Deconstruct(this Size size, out double width, out double height) {
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
    public static void Deconstruct(this CornerRadius cornerRadius, out double topLeft, out double topRight, out double bottomRight, out double bottomLeft) {
        topLeft = cornerRadius.TopLeft;
        topRight = cornerRadius.TopRight;
        bottomRight = cornerRadius.BottomRight;
        bottomLeft = cornerRadius.BottomLeft;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static void Deconstruct(this Color color, out byte alpha, out byte red, out byte green, out byte blue) {
        alpha = color.A;
        red = color.R;
        green = color.G;
        blue = color.B;
    }
}
