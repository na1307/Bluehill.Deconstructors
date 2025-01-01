namespace Bluehill.Deconstructors.Wpf.Tests;

public sealed class WpfDeconstructorsTest {
    [Fact]
    public void DeconstructTest1() {
        var (x, y) = new Point(10.0, 6.666);
        Assert.Equal(10.0, Math.Round(x));
        Assert.Equal(7.0, Math.Round(y));
    }

    [Fact]
    public void DeconstructTest2() {
        var (width, height) = new Size(5.0, 8.333);
        Assert.Equal(5.0, Math.Round(width));
        Assert.Equal(8.0, Math.Round(height));
    }

    [Fact]
    public void DeconstructTest3() {
        var (left, top, right, bottom) = new Rect(10.0, 6.666, 5.0, 8.333);
        Assert.Equal(10.0, Math.Round(left));
        Assert.Equal(7.0, Math.Round(top));
        Assert.Equal(15.0, Math.Round(right));
        Assert.Equal(15.0, Math.Round(bottom));
    }

    [Fact]
    public void DeconstructTest4() {
        var (left, top, right, bottom) = new Thickness(1.0, 2.0, 3.0, 4.0);
        Assert.Equal(1, Math.Round(left));
        Assert.Equal(2, Math.Round(top));
        Assert.Equal(3, Math.Round(right));
        Assert.Equal(4, Math.Round(bottom));
    }

    [Fact]
    public void DeconstructTest5() {
        var (tl, tr, br, bl) = new CornerRadius(1.0, 2.0, 3.0, 4.0);
        Assert.Equal(1, Math.Round(tl));
        Assert.Equal(2, Math.Round(tr));
        Assert.Equal(3, Math.Round(br));
        Assert.Equal(4, Math.Round(bl));
    }

    [Fact]
    public void DeconstructTest6() {
        var (alpha, red, green, blue) = Colors.SkyBlue;
        Assert.Equal(255, alpha);
        Assert.Equal(135, red);
        Assert.Equal(206, green);
        Assert.Equal(235, blue);
    }
}