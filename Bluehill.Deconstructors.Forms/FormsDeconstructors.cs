namespace Bluehill.Deconstructors;

public static class FormsDeconstructors {
    public static void Deconstruct(this Padding padding, out int left, out int top, out int right, out int bottom) {
        left = padding.Left;
        top = padding.Top;
        right = padding.Right;
        bottom = padding.Bottom;
    }

    public static void Deconstruct(this TableLayoutPanelCellPosition position, out int row, out int column) {
        row = position.Row;
        column = position.Column;
    }
}