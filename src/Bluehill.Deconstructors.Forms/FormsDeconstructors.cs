namespace Bluehill.Deconstructors;

[EditorBrowsable(EditorBrowsableState.Never)]
public static class FormsDeconstructors {
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static void Deconstruct(this Padding padding, out int left, out int top, out int right, out int bottom) {
        left = padding.Left;
        top = padding.Top;
        right = padding.Right;
        bottom = padding.Bottom;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static void Deconstruct(this TableLayoutPanelCellPosition position, out int column, out int row) {
        column = position.Column;
        row = position.Row;
    }
}
