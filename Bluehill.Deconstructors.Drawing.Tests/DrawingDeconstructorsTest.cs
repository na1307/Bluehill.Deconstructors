namespace Bluehill.Deconstructors.Drawing.Tests;

public sealed class DrawingDeconstructorsTest {
    [Fact]
    public void DeconstructTest1() {
        var (x, y) = new Point(10, 6);
        Assert.Equal(10, x);
        Assert.Equal(6, y);
    }

    [Fact]
    public void DeconstructTest2() {
        var (x, y) = new PointF(10.0F, 6.666F);
        Assert.Equal(10.0, Math.Round(x));
        Assert.Equal(7.0, Math.Round(y));
    }

    [Fact]
    public void DeconstructTest3() {
        var (width, height) = new Size(5, 8);
        Assert.Equal(5, width);
        Assert.Equal(8, height);
    }

    [Fact]
    public void DeconstructTest4() {
        var (width, height) = new SizeF(5.0F, 8.333F);
        Assert.Equal(5.0, Math.Round(width));
        Assert.Equal(8.0, Math.Round(height));
    }

    [Fact]
    public void DeconstructTest5() {
        var (left, top, right, bottom) = new Rectangle(10, 6, 5, 8);
        Assert.Equal(10, left);
        Assert.Equal(6, top);
        Assert.Equal(15, right);
        Assert.Equal(14, bottom);
    }

    [Fact]
    public void DeconstructTest6() {
        var (left, top, right, bottom) = new RectangleF(10.0F, 6.666F, 5.0F, 8.333F);
        Assert.Equal(10.0, Math.Round(left));
        Assert.Equal(7.0, Math.Round(top));
        Assert.Equal(15.0, Math.Round(right));
        Assert.Equal(15.0, Math.Round(bottom));
    }

    [Fact]
    public void DeconstructTest7() {
        var (alpha, red, green, blue) = Color.SkyBlue;
        Assert.Equal(255, alpha);
        Assert.Equal(135, red);
        Assert.Equal(206, green);
        Assert.Equal(235, blue);
    }
}