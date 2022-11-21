namespace Bluehill.Deconstructors;

public static class DrawingDeconstructors {
    public static void Deconstruct(this Point point, out int x, out int y) {
        x = point.X;
        y = point.Y;
    }

    public static void Deconstruct(this PointF point, out float x, out float y) {
        x = point.X;
        y = point.Y;
    }

    public static void Deconstruct(this Size size, out int width, out int height) {
        width = size.Width;
        height = size.Height;
    }

    public static void Deconstruct(this SizeF size, out float width, out float height) {
        width = size.Width;
        height = size.Height;
    }

    public static void Deconstruct(this Rectangle rectangle, out int left, out int top, out int right, out int bottom) {
        left = rectangle.Left;
        top = rectangle.Top;
        right = rectangle.Right;
        bottom = rectangle.Bottom;
    }

    public static void Deconstruct(this RectangleF rectangle, out float left, out float top, out float right, out float bottom) {
        left = rectangle.Left;
        top = rectangle.Top;
        right = rectangle.Right;
        bottom = rectangle.Bottom;
    }

    public static void Deconstruct(this Color color, out byte red, out byte green, out byte blue, out byte alpha) {
        red = color.R;
        green = color.G;
        blue = color.B;
        alpha = color.A;
    }
}