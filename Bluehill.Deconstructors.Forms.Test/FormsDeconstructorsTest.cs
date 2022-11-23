namespace Bluehill.Deconstructors.Forms.Test;

public sealed class FormsDeconstructorsTest {
    [Fact]
    public void DeconstructTest1() {
        var (left, top, right, bottom) = new Padding(1, 2, 3, 4);
        Assert.Equal(1, left);
        Assert.Equal(2, top);
        Assert.Equal(3, right);
        Assert.Equal(4, bottom);
    }

    [Fact]
    public void DeconstructTest2() {
        var (column, row) = new TableLayoutPanelCellPosition(3, 1);
        Assert.Equal(3, column);
        Assert.Equal(1, row);
    }
}