namespace Bluehill.Deconstructors.Numerics.Tests;

public sealed class NumericsDeconstructorsTest {
    [Fact]
    public void DeconstructTest1() {
        var (x, y) = new Vector2(10, 8);

        Assert.Equal(10, x);
        Assert.Equal(8, y);
    }

    [Fact]
    public void DeconstructTest2() {
        var (x, y, z) = new Vector3(10, 8, 5);

        Assert.Equal(10, x);
        Assert.Equal(8, y);
        Assert.Equal(5, z);
    }

    [Fact]
    public void DeconstructTest3() {
        var (x, y, z, w) = new Vector4(10, 8, 5, 3);

        Assert.Equal(10, x);
        Assert.Equal(8, y);
        Assert.Equal(5, z);
        Assert.Equal(3, w);
    }

    [Fact]
    public void DeconstructTest4() {
        var (m11, m12, m21, m22, m31, m32) = new Matrix3x2(11, 12, 21, 22, 31, 32);

        Assert.Equal(11, m11);
        Assert.Equal(12, m12);
        Assert.Equal(21, m21);
        Assert.Equal(22, m22);
        Assert.Equal(31, m31);
        Assert.Equal(32, m32);
    }

    [Fact]
    public void DeconstructTest5() {
        var (m11, m12, m13, m14, m21, m22, m23, m24, m31, m32, m33, m34, m41, m42, m43, m44) = new Matrix4x4(11, 12, 13, 14, 21, 22, 23, 24, 31, 32, 33, 34, 41, 42, 43, 44);

        Assert.Equal(11, m11);
        Assert.Equal(12, m12);
        Assert.Equal(13, m13);
        Assert.Equal(14, m14);
        Assert.Equal(21, m21);
        Assert.Equal(22, m22);
        Assert.Equal(23, m23);
        Assert.Equal(24, m24);
        Assert.Equal(31, m31);
        Assert.Equal(32, m32);
        Assert.Equal(33, m33);
        Assert.Equal(34, m34);
        Assert.Equal(41, m41);
        Assert.Equal(42, m42);
        Assert.Equal(43, m43);
        Assert.Equal(44, m44);
    }
}