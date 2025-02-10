namespace Bluehill.Deconstructors.DateTime.Tests;

public sealed class DateTimeDeconstructorsTest {
    private static readonly System.DateTime Now = System.DateTime.Now;

    [Fact]
    public void DeconstructTest1() {
        var (dateOnly, timeOnly) = Now;
        Assert.Equal(new DateOnly(Now.Year, Now.Month, Now.Day), dateOnly);
        Assert.Equal(new TimeOnly(Now.TimeOfDay.Ticks), timeOnly);
    }

    [Fact]
    public void DeconstructTest2() {
        var (year, month, day) = Now;
        Assert.Equal(Now.Year, year);
        Assert.Equal(Now.Month, month);
        Assert.Equal(Now.Day, day);
    }

    [Fact]
    public void DeconstructTest3() {
        var (year, month, day, hour, minute) = Now;
        Assert.Equal(Now.Year, year);
        Assert.Equal(Now.Month, month);
        Assert.Equal(Now.Day, day);
        Assert.Equal(Now.Hour, hour);
        Assert.Equal(Now.Minute, minute);
    }

    [Fact]
    public void DeconstructTest4() {
        var (year, month, day, hour, minute, second) = Now;
        Assert.Equal(Now.Year, year);
        Assert.Equal(Now.Month, month);
        Assert.Equal(Now.Day, day);
        Assert.Equal(Now.Hour, hour);
        Assert.Equal(Now.Minute, minute);
        Assert.Equal(Now.Second, second);
    }

    [Fact]
    public void DeconstructTest5() {
        var (year, month, day, hour, minute, second, millisecond) = Now;
        Assert.Equal(Now.Year, year);
        Assert.Equal(Now.Month, month);
        Assert.Equal(Now.Day, day);
        Assert.Equal(Now.Hour, hour);
        Assert.Equal(Now.Minute, minute);
        Assert.Equal(Now.Second, second);
        Assert.Equal(Now.Millisecond, millisecond);
    }

    [Fact]
    public void DeconstructTest6() {
        var (year, month, day, hour, minute, second, millisecond, microsecond) = Now;
        Assert.Equal(Now.Year, year);
        Assert.Equal(Now.Month, month);
        Assert.Equal(Now.Day, day);
        Assert.Equal(Now.Hour, hour);
        Assert.Equal(Now.Minute, minute);
        Assert.Equal(Now.Second, second);
        Assert.Equal(Now.Millisecond, millisecond);
        Assert.Equal(Now.Microsecond, microsecond);
    }

    [Fact]
    public void DeconstructTest7() {
        var (year, month, day, hour, minute, second, millisecond, microsecond, nanosecond) = Now;
        Assert.Equal(Now.Year, year);
        Assert.Equal(Now.Month, month);
        Assert.Equal(Now.Day, day);
        Assert.Equal(Now.Hour, hour);
        Assert.Equal(Now.Minute, minute);
        Assert.Equal(Now.Second, second);
        Assert.Equal(Now.Millisecond, millisecond);
        Assert.Equal(Now.Microsecond, microsecond);
        Assert.Equal(Now.Nanosecond, nanosecond);
    }

    [Fact]
    public void DeconstructTest8() {
        var ((year, month, day), _) = Now;
        Assert.Equal(Now.Year, year);
        Assert.Equal(Now.Month, month);
        Assert.Equal(Now.Day, day);
    }

    [Fact]
    public void DeconstructTest9() {
        var (_, (hour, minute)) = Now;
        Assert.Equal(Now.Hour, hour);
        Assert.Equal(Now.Minute, minute);
    }

    [Fact]
    public void DeconstructTest10() {
        var (_, (hour, minute, second)) = Now;
        Assert.Equal(Now.Hour, hour);
        Assert.Equal(Now.Minute, minute);
        Assert.Equal(Now.Second, second);
    }

    [Fact]
    public void DeconstructTest11() {
        var (_, (hour, minute, second, millisecond)) = Now;
        Assert.Equal(Now.Hour, hour);
        Assert.Equal(Now.Minute, minute);
        Assert.Equal(Now.Second, second);
        Assert.Equal(Now.Millisecond, millisecond);
    }

    [Fact]
    public void DeconstructTest12() {
        var (_, (hour, minute, second, millisecond, microsecond)) = Now;
        Assert.Equal(Now.Hour, hour);
        Assert.Equal(Now.Minute, minute);
        Assert.Equal(Now.Second, second);
        Assert.Equal(Now.Millisecond, millisecond);
        Assert.Equal(Now.Microsecond, microsecond);
    }

    [Fact]
    public void DeconstructTest13() {
        var (_, (hour, minute, second, millisecond, microsecond, nanosecond)) = Now;
        Assert.Equal(Now.Hour, hour);
        Assert.Equal(Now.Minute, minute);
        Assert.Equal(Now.Second, second);
        Assert.Equal(Now.Millisecond, millisecond);
        Assert.Equal(Now.Microsecond, microsecond);
        Assert.Equal(Now.Nanosecond, nanosecond);
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
