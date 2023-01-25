namespace Bluehill.Deconstructors.DateTime.Test;

public sealed class DateTimeDeconstructorsTest {
    static readonly System.DateTime now = System.DateTime.Now;

    [Fact]
    public void DeconstructTest1() {
        var (dateOnly, timeOnly) = now;
    }

    [Fact]
    public void DeconstructTest2() {
        var (year, month, day) = now;
    }

    [Fact]
    public void DeconstructTest3() {
        var (year, month, day, hour, minute) = now;
    }

    [Fact]
    public void DeconstructTest4() {
        var (year, month, day, hour, minute, second) = now;
    }

    [Fact]
    public void DeconstructTest5() {
        var (year, month, day, hour, minute, second, millisecond) = now;
    }

    [Fact]
    public void DeconstructTest6() {
        var (year, month, day, hour, minute, second, millisecond, microsecond) = now;
    }

    [Fact]
    public void DeconstructTest7() {
        var (year, month, day, hour, minute, second, millisecond, microsecond, nanosecond) = now;
    }

    [Fact]
    public void DeconstructTest8() {
        var ((year, month, day), _) = now;
    }

    [Fact]
    public void DeconstructTest9() {
        var (_, (hour, minute)) = now;
    }

    [Fact]
    public void DeconstructTest10() {
        var (_, (hour, minute, second)) = now;
    }

    [Fact]
    public void DeconstructTest11() {
        var (_, (hour, minute, second, millisecond)) = now;
    }

    [Fact]
    public void DeconstructTest12() {
        var (_, (hour, minute, second, millisecond, microsecond)) = now;
    }

    [Fact]
    public void DeconstructTest13() {
        var (_, (hour, minute, second, millisecond, microsecond, nanosecond)) = now;
    }

    [Fact]
    public void DeconstructTest14() {
        var (dateOnly, timeOnly, timeSpan) = DateTimeOffset.Now;
    }
}