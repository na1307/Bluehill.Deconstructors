namespace Bluehill.Deconstructors.List.Tests;

public sealed class ListDeconstructorsTest {
    private static readonly int[] Array = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15];

    [Fact]
    public void DeconstructTest1() {
        Array.Deconstruct(out var one);
        Assert.Equal(1, one);
    }

    [Fact]
    public void DeconstructTest2() {
        var (one, two) = Array;
        Assert.Equal(1, one);
        Assert.Equal(2, two);
    }

    [Fact]
    public void DeconstructTest3() {
        var (one, two, three) = Array;
        Assert.Equal(1, one);
        Assert.Equal(2, two);
        Assert.Equal(3, three);
    }

    [Fact]
    public void DeconstructTest4() {
        var (one, two, three, four) = Array;
        Assert.Equal(1, one);
        Assert.Equal(2, two);
        Assert.Equal(3, three);
        Assert.Equal(4, four);
    }

    [Fact]
    public void DeconstructTest5() {
        var (one, two, three, four, five) = Array;
        Assert.Equal(1, one);
        Assert.Equal(2, two);
        Assert.Equal(3, three);
        Assert.Equal(4, four);
        Assert.Equal(5, five);
    }

    [Fact]
    public void DeconstructTest6() {
        var (one, two, three, four, five, six) = Array;
        Assert.Equal(1, one);
        Assert.Equal(2, two);
        Assert.Equal(3, three);
        Assert.Equal(4, four);
        Assert.Equal(5, five);
        Assert.Equal(6, six);
    }

    [Fact]
    public void DeconstructTest7() {
        var (one, two, three, four, five, six, seven) = Array;
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
        var (one, two, three, four, five, six, seven, eight) = Array;
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
        var (one, two, three, four, five, six, seven, eight, nine) = Array;
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
        var (one, two, three, four, five, six, seven, eight, nine, ten) = Array;
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
        var (one, two, three, four, five, six, seven, eight, nine, ten, eleven) = Array;
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
        var (one, two, three, four, five, six, seven, eight, nine, ten, eleven, twelve) = Array;
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
        var (one, two, three, four, five, six, seven, eight, nine, ten, eleven, twelve, thirteen) = Array;
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
        var (one, two, three, four, five, six, seven, eight, nine, ten, eleven, twelve, thirteen, fourteen) = Array;
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
        var (one, two, three, four, five, six, seven, eight, nine, ten, eleven, twelve, thirteen, fourteen, fifteen) = Array;
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
