namespace Bluehill.Deconstructors.Version.Tests;

public sealed class VersionDeconstructorsTest {
    [Fact]
    public void DeconstructTest1() {
        var (major, minor) = new System.Version(1, 2, 3, 4);

        Assert.Equal(1, major);
        Assert.Equal(2, minor);
    }

    [Fact]
    public void DeconstructTest2() {
        var (major, minor, build) = new System.Version(1, 2, 3, 4);

        Assert.Equal(1, major);
        Assert.Equal(2, minor);
        Assert.Equal(3, build);
    }

    [Fact]
    public void DeconstructTest3() {
        var (major, minor, build, revision) = new System.Version(1, 2, 3, 4);

        Assert.Equal(1, major);
        Assert.Equal(2, minor);
        Assert.Equal(3, build);
        Assert.Equal(4, revision);
    }
}