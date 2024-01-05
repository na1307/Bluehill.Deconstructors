namespace Bluehill.Deconstructors.Span.Test;

public sealed class SpanDeconstructorsTest {
    private static readonly int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

    [Fact]
    public void DeconstructTest1() {
        ((Span<int>)array).Deconstruct(out var one);
        Assert.Equal(1, one);
    }

    [Fact]
    public void DeconstructTest2() {
        var (one, two) = (Span<int>)array;
        Assert.Equal(1, one);
        Assert.Equal(2, two);
    }

    [Fact]
    public void DeconstructTest3() {
        var (one, two, three) = (Span<int>)array;
        Assert.Equal(1, one);
        Assert.Equal(2, two);
        Assert.Equal(3, three);
    }

    [Fact]
    public void DeconstructTest4() {
        var (one, two, three, four) = (Span<int>)array;
        Assert.Equal(1, one);
        Assert.Equal(2, two);
        Assert.Equal(3, three);
        Assert.Equal(4, four);
    }

    [Fact]
    public void DeconstructTest5() {
        var (one, two, three, four, five) = (Span<int>)array;
        Assert.Equal(1, one);
        Assert.Equal(2, two);
        Assert.Equal(3, three);
        Assert.Equal(4, four);
        Assert.Equal(5, five);
    }

    [Fact]
    public void DeconstructTest6() {
        var (one, two, three, four, five, six) = (Span<int>)array;
        Assert.Equal(1, one);
        Assert.Equal(2, two);
        Assert.Equal(3, three);
        Assert.Equal(4, four);
        Assert.Equal(5, five);
        Assert.Equal(6, six);
    }

    [Fact]
    public void DeconstructTest7() {
        var (one, two, three, four, five, six, seven) = (Span<int>)array;
        Assert.Equal(1, one);
        Assert.Equal(2, two);
        Assert.Equal(3, three);
        Assert.Equal(4, four);
        Assert.Equal(5, five);
        Assert.Equal(6, six);
        Assert.Equal(7, seven);
    }

    [Fact]
    public void DeconstructTest8() {
        var (one, two, three, four, five, six, seven, eight) = (Span<int>)array;
        Assert.Equal(1, one);
        Assert.Equal(2, two);
        Assert.Equal(3, three);
        Assert.Equal(4, four);
        Assert.Equal(5, five);
        Assert.Equal(6, six);
        Assert.Equal(7, seven);
        Assert.Equal(8, eight);
    }

    [Fact]
    public void DeconstructTest9() {
        var (one, two, three, four, five, six, seven, eight, nine) = (Span<int>)array;
        Assert.Equal(1, one);
        Assert.Equal(2, two);
        Assert.Equal(3, three);
        Assert.Equal(4, four);
        Assert.Equal(5, five);
        Assert.Equal(6, six);
        Assert.Equal(7, seven);
        Assert.Equal(8, eight);
        Assert.Equal(9, nine);
    }

    [Fact]
    public void DeconstructTest10() {
        var (one, two, three, four, five, six, seven, eight, nine, ten) = (Span<int>)array;
        Assert.Equal(1, one);
        Assert.Equal(2, two);
        Assert.Equal(3, three);
        Assert.Equal(4, four);
        Assert.Equal(5, five);
        Assert.Equal(6, six);
        Assert.Equal(7, seven);
        Assert.Equal(8, eight);
        Assert.Equal(9, nine);
        Assert.Equal(10, ten);
    }

    [Fact]
    public void DeconstructTest11() {
        var (one, two, three, four, five, six, seven, eight, nine, ten, eleven) = (Span<int>)array;
        Assert.Equal(1, one);
        Assert.Equal(2, two);
        Assert.Equal(3, three);
        Assert.Equal(4, four);
        Assert.Equal(5, five);
        Assert.Equal(6, six);
        Assert.Equal(7, seven);
        Assert.Equal(8, eight);
        Assert.Equal(9, nine);
        Assert.Equal(10, ten);
        Assert.Equal(11, eleven);
    }

    [Fact]
    public void DeconstructTest12() {
        var (one, two, three, four, five, six, seven, eight, nine, ten, eleven, twelve) = (Span<int>)array;
        Assert.Equal(1, one);
        Assert.Equal(2, two);
        Assert.Equal(3, three);
        Assert.Equal(4, four);
        Assert.Equal(5, five);
        Assert.Equal(6, six);
        Assert.Equal(7, seven);
        Assert.Equal(8, eight);
        Assert.Equal(9, nine);
        Assert.Equal(10, ten);
        Assert.Equal(11, eleven);
        Assert.Equal(12, twelve);
    }

    [Fact]
    public void DeconstructTest13() {
        var (one, two, three, four, five, six, seven, eight, nine, ten, eleven, twelve, thirteen) = (Span<int>)array;
        Assert.Equal(1, one);
        Assert.Equal(2, two);
        Assert.Equal(3, three);
        Assert.Equal(4, four);
        Assert.Equal(5, five);
        Assert.Equal(6, six);
        Assert.Equal(7, seven);
        Assert.Equal(8, eight);
        Assert.Equal(9, nine);
        Assert.Equal(10, ten);
        Assert.Equal(11, eleven);
        Assert.Equal(12, twelve);
        Assert.Equal(13, thirteen);
    }

    [Fact]
    public void DeconstructTest14() {
        var (one, two, three, four, five, six, seven, eight, nine, ten, eleven, twelve, thirteen, fourteen) = (Span<int>)array;
        Assert.Equal(1, one);
        Assert.Equal(2, two);
        Assert.Equal(3, three);
        Assert.Equal(4, four);
        Assert.Equal(5, five);
        Assert.Equal(6, six);
        Assert.Equal(7, seven);
        Assert.Equal(8, eight);
        Assert.Equal(9, nine);
        Assert.Equal(10, ten);
        Assert.Equal(11, eleven);
        Assert.Equal(12, twelve);
        Assert.Equal(13, thirteen);
        Assert.Equal(14, fourteen);
    }

    [Fact]
    public void DeconstructTest15() {
        var (one, two, three, four, five, six, seven, eight, nine, ten, eleven, twelve, thirteen, fourteen, fifteen) = (Span<int>)array;
        Assert.Equal(1, one);
        Assert.Equal(2, two);
        Assert.Equal(3, three);
        Assert.Equal(4, four);
        Assert.Equal(5, five);
        Assert.Equal(6, six);
        Assert.Equal(7, seven);
        Assert.Equal(8, eight);
        Assert.Equal(9, nine);
        Assert.Equal(10, ten);
        Assert.Equal(11, eleven);
        Assert.Equal(12, twelve);
        Assert.Equal(13, thirteen);
        Assert.Equal(14, fourteen);
        Assert.Equal(15, fifteen);
    }

    [Fact]
    public void DeconstructTest16() {
        ((ReadOnlySpan<int>)array).Deconstruct(out var one);
        Assert.Equal(1, one);
    }

    [Fact]
    public void DeconstructTest17() {
        var (one, two) = (ReadOnlySpan<int>)array;
        Assert.Equal(1, one);
        Assert.Equal(2, two);
    }

    [Fact]
    public void DeconstructTest18() {
        var (one, two, three) = (ReadOnlySpan<int>)array;
        Assert.Equal(1, one);
        Assert.Equal(2, two);
        Assert.Equal(3, three);
    }

    [Fact]
    public void DeconstructTest19() {
        var (one, two, three, four) = (ReadOnlySpan<int>)array;
        Assert.Equal(1, one);
        Assert.Equal(2, two);
        Assert.Equal(3, three);
        Assert.Equal(4, four);
    }

    [Fact]
    public void DeconstructTest20() {
        var (one, two, three, four, five) = (ReadOnlySpan<int>)array;
        Assert.Equal(1, one);
        Assert.Equal(2, two);
        Assert.Equal(3, three);
        Assert.Equal(4, four);
        Assert.Equal(5, five);
    }

    [Fact]
    public void DeconstructTest21() {
        var (one, two, three, four, five, six) = (ReadOnlySpan<int>)array;
        Assert.Equal(1, one);
        Assert.Equal(2, two);
        Assert.Equal(3, three);
        Assert.Equal(4, four);
        Assert.Equal(5, five);
        Assert.Equal(6, six);
    }

    [Fact]
    public void DeconstructTest22() {
        var (one, two, three, four, five, six, seven) = (ReadOnlySpan<int>)array;
        Assert.Equal(1, one);
        Assert.Equal(2, two);
        Assert.Equal(3, three);
        Assert.Equal(4, four);
        Assert.Equal(5, five);
        Assert.Equal(6, six);
        Assert.Equal(7, seven);
    }

    [Fact]
    public void DeconstructTest23() {
        var (one, two, three, four, five, six, seven, eight) = (ReadOnlySpan<int>)array;
        Assert.Equal(1, one);
        Assert.Equal(2, two);
        Assert.Equal(3, three);
        Assert.Equal(4, four);
        Assert.Equal(5, five);
        Assert.Equal(6, six);
        Assert.Equal(7, seven);
        Assert.Equal(8, eight);
    }

    [Fact]
    public void DeconstructTest24() {
        var (one, two, three, four, five, six, seven, eight, nine) = (ReadOnlySpan<int>)array;
        Assert.Equal(1, one);
        Assert.Equal(2, two);
        Assert.Equal(3, three);
        Assert.Equal(4, four);
        Assert.Equal(5, five);
        Assert.Equal(6, six);
        Assert.Equal(7, seven);
        Assert.Equal(8, eight);
        Assert.Equal(9, nine);
    }

    [Fact]
    public void DeconstructTest25() {
        var (one, two, three, four, five, six, seven, eight, nine, ten) = (ReadOnlySpan<int>)array;
        Assert.Equal(1, one);
        Assert.Equal(2, two);
        Assert.Equal(3, three);
        Assert.Equal(4, four);
        Assert.Equal(5, five);
        Assert.Equal(6, six);
        Assert.Equal(7, seven);
        Assert.Equal(8, eight);
        Assert.Equal(9, nine);
        Assert.Equal(10, ten);
    }

    [Fact]
    public void DeconstructTest26() {
        var (one, two, three, four, five, six, seven, eight, nine, ten, eleven) = (ReadOnlySpan<int>)array;
        Assert.Equal(1, one);
        Assert.Equal(2, two);
        Assert.Equal(3, three);
        Assert.Equal(4, four);
        Assert.Equal(5, five);
        Assert.Equal(6, six);
        Assert.Equal(7, seven);
        Assert.Equal(8, eight);
        Assert.Equal(9, nine);
        Assert.Equal(10, ten);
        Assert.Equal(11, eleven);
    }

    [Fact]
    public void DeconstructTest27() {
        var (one, two, three, four, five, six, seven, eight, nine, ten, eleven, twelve) = (ReadOnlySpan<int>)array;
        Assert.Equal(1, one);
        Assert.Equal(2, two);
        Assert.Equal(3, three);
        Assert.Equal(4, four);
        Assert.Equal(5, five);
        Assert.Equal(6, six);
        Assert.Equal(7, seven);
        Assert.Equal(8, eight);
        Assert.Equal(9, nine);
        Assert.Equal(10, ten);
        Assert.Equal(11, eleven);
        Assert.Equal(12, twelve);
    }

    [Fact]
    public void DeconstructTest28() {
        var (one, two, three, four, five, six, seven, eight, nine, ten, eleven, twelve, thirteen) = (ReadOnlySpan<int>)array;
        Assert.Equal(1, one);
        Assert.Equal(2, two);
        Assert.Equal(3, three);
        Assert.Equal(4, four);
        Assert.Equal(5, five);
        Assert.Equal(6, six);
        Assert.Equal(7, seven);
        Assert.Equal(8, eight);
        Assert.Equal(9, nine);
        Assert.Equal(10, ten);
        Assert.Equal(11, eleven);
        Assert.Equal(12, twelve);
        Assert.Equal(13, thirteen);
    }

    [Fact]
    public void DeconstructTest29() {
        var (one, two, three, four, five, six, seven, eight, nine, ten, eleven, twelve, thirteen, fourteen) = (ReadOnlySpan<int>)array;
        Assert.Equal(1, one);
        Assert.Equal(2, two);
        Assert.Equal(3, three);
        Assert.Equal(4, four);
        Assert.Equal(5, five);
        Assert.Equal(6, six);
        Assert.Equal(7, seven);
        Assert.Equal(8, eight);
        Assert.Equal(9, nine);
        Assert.Equal(10, ten);
        Assert.Equal(11, eleven);
        Assert.Equal(12, twelve);
        Assert.Equal(13, thirteen);
        Assert.Equal(14, fourteen);
    }

    [Fact]
    public void DeconstructTest30() {
        var (one, two, three, four, five, six, seven, eight, nine, ten, eleven, twelve, thirteen, fourteen, fifteen) = (ReadOnlySpan<int>)array;
        Assert.Equal(1, one);
        Assert.Equal(2, two);
        Assert.Equal(3, three);
        Assert.Equal(4, four);
        Assert.Equal(5, five);
        Assert.Equal(6, six);
        Assert.Equal(7, seven);
        Assert.Equal(8, eight);
        Assert.Equal(9, nine);
        Assert.Equal(10, ten);
        Assert.Equal(11, eleven);
        Assert.Equal(12, twelve);
        Assert.Equal(13, thirteen);
        Assert.Equal(14, fourteen);
        Assert.Equal(15, fifteen);
    }
}