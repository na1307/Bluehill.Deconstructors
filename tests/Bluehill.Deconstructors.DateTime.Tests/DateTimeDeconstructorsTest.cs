namespace Bluehill.Deconstructors.DateTime.Tests;

public sealed class DateTimeDeconstructorsTest {
    private static readonly System.DateTime now = System.DateTime.Now;

    [Fact]
    public void DeconstructTest1() {
        var (dateOnly, timeOnly) = now;
        Assert.Equal(new DateOnly(now.Year, now.Month, now.Day), dateOnly);
        Assert.Equal(new TimeOnly(now.TimeOfDay.Ticks), timeOnly);
    }

    [Fact]
    public void DeconstructTest2() {
        var (year, month, day) = now;
        Assert.Equal(now.Year, year);
        Assert.Equal(now.Month, month);
        Assert.Equal(now.Day, day);
    }

    [Fact]
    public void DeconstructTest3() {
        var (year, month, day, hour, minute) = now;
        Assert.Equal(now.Year, year);
        Assert.Equal(now.Month, month);
        Assert.Equal(now.Day, day);
        Assert.Equal(now.Hour, hour);
        Assert.Equal(now.Minute, minute);
    }

    [Fact]
    public void DeconstructTest4() {
        var (year, month, day, hour, minute, second) = now;
        Assert.Equal(now.Year, year);
        Assert.Equal(now.Month, month);
        Assert.Equal(now.Day, day);
        Assert.Equal(now.Hour, hour);
        Assert.Equal(now.Minute, minute);
        Assert.Equal(now.Second, second);
    }

    [Fact]
    public void DeconstructTest5() {
        var (year, month, day, hour, minute, second, millisecond) = now;
        Assert.Equal(now.Year, year);
        Assert.Equal(now.Month, month);
        Assert.Equal(now.Day, day);
        Assert.Equal(now.Hour, hour);
        Assert.Equal(now.Minute, minute);
        Assert.Equal(now.Second, second);
        Assert.Equal(now.Millisecond, millisecond);
    }

    [Fact]
    public void DeconstructTest6() {
        var (year, month, day, hour, minute, second, millisecond, microsecond) = now;
        Assert.Equal(now.Year, year);
        Assert.Equal(now.Month, month);
        Assert.Equal(now.Day, day);
        Assert.Equal(now.Hour, hour);
        Assert.Equal(now.Minute, minute);
        Assert.Equal(now.Second, second);
        Assert.Equal(now.Millisecond, millisecond);
        Assert.Equal(now.Microsecond, microsecond);
    }

    [Fact]
    public void DeconstructTest7() {
        var (year, month, day, hour, minute, second, millisecond, microsecond, nanosecond) = now;
        Assert.Equal(now.Year, year);
        Assert.Equal(now.Month, month);
        Assert.Equal(now.Day, day);
        Assert.Equal(now.Hour, hour);
        Assert.Equal(now.Minute, minute);
        Assert.Equal(now.Second, second);
        Assert.Equal(now.Millisecond, millisecond);
        Assert.Equal(now.Microsecond, microsecond);
        Assert.Equal(now.Nanosecond, nanosecond);
    }

    [Fact]
    public void DeconstructTest8() {
        var ((year, month, day), _) = now;
        Assert.Equal(now.Year, year);
        Assert.Equal(now.Month, month);
        Assert.Equal(now.Day, day);
    }

    [Fact]
    public void DeconstructTest9() {
        var (_, (hour, minute)) = now;
        Assert.Equal(now.Hour, hour);
        Assert.Equal(now.Minute, minute);
    }

    [Fact]
    public void DeconstructTest10() {
        var (_, (hour, minute, second)) = now;
        Assert.Equal(now.Hour, hour);
        Assert.Equal(now.Minute, minute);
        Assert.Equal(now.Second, second);
    }

    [Fact]
    public void DeconstructTest11() {
        var (_, (hour, minute, second, millisecond)) = now;
        Assert.Equal(now.Hour, hour);
        Assert.Equal(now.Minute, minute);
        Assert.Equal(now.Second, second);
        Assert.Equal(now.Millisecond, millisecond);
    }

    [Fact]
    public void DeconstructTest12() {
        var (_, (hour, minute, second, millisecond, microsecond)) = now;
        Assert.Equal(now.Hour, hour);
        Assert.Equal(now.Minute, minute);
        Assert.Equal(now.Second, second);
        Assert.Equal(now.Millisecond, millisecond);
        Assert.Equal(now.Microsecond, microsecond);
    }

    [Fact]
    public void DeconstructTest13() {
        var (_, (hour, minute, second, millisecond, microsecond, nanosecond)) = now;
        Assert.Equal(now.Hour, hour);
        Assert.Equal(now.Minute, minute);
        Assert.Equal(now.Second, second);
        Assert.Equal(now.Millisecond, millisecond);
        Assert.Equal(now.Microsecond, microsecond);
        Assert.Equal(now.Nanosecond, nanosecond);
    }

    [Fact]
    public void DeconstructTest14() {
        var dtoNow = DateTimeOffset.Now;
        var (dateOnly, timeOnly, timeSpan) = dtoNow;
        Assert.Equal(new DateOnly(dtoNow.Year, dtoNow.Month, dtoNow.Day), dateOnly);
        Assert.Equal(new TimeOnly(dtoNow.TimeOfDay.Ticks), timeOnly);
        Assert.Equal(dtoNow.Offset, timeSpan);
    }
}