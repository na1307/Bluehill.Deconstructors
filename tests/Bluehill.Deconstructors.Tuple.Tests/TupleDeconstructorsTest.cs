namespace Bluehill.Deconstructors.Tuple.Tests;

public sealed class TupleDeconstructorsTest {
    [Fact]
    public void DeconstructTest1() {
        System.Tuple.Create(1).Deconstruct(out var one);
        Assert.Equal(1, one);
    }

    [Fact]
    public void DeconstructTest2() {
        var (one, two) = System.Tuple.Create(1, 2);
        Assert.Equal(1, one);
        Assert.Equal(2, two);
    }

    [Fact]
    public void DeconstructTest3() {
        var (one, two, three) = System.Tuple.Create(1, 2, 3);
        Assert.Equal(1, one);
        Assert.Equal(2, two);
        Assert.Equal(3, three);
    }

    [Fact]
    public void DeconstructTest4() {
        var (one, two, three, four) = System.Tuple.Create(1, 2, 3, 4);
        Assert.Equal(1, one);
        Assert.Equal(2, two);
        Assert.Equal(3, three);
        Assert.Equal(4, four);
    }

    [Fact]
    public void DeconstructTest5() {
        var (one, two, three, four, five) = System.Tuple.Create(1, 2, 3, 4, 5);
        Assert.Equal(1, one);
        Assert.Equal(2, two);
        Assert.Equal(3, three);
        Assert.Equal(4, four);
        Assert.Equal(5, five);
    }

    [Fact]
    public void DeconstructTest6() {
        var (one, two, three, four, five, six) = System.Tuple.Create(1, 2, 3, 4, 5, 6);
        Assert.Equal(1, one);
        Assert.Equal(2, two);
        Assert.Equal(3, three);
        Assert.Equal(4, four);
        Assert.Equal(5, five);
        Assert.Equal(6, six);
    }

    [Fact]
    public void DeconstructTest7() {
        var (one, two, three, four, five, six, seven) = System.Tuple.Create(1, 2, 3, 4, 5, 6, 7);
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
        var (one, two, three, four, five, six, seven, eight) = System.Tuple.Create(1, 2, 3, 4, 5, 6, 7, 8);
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
        var (one, two, three, four, five, six, seven, eight, nine) = new Tuple<int, int, int, int, int, int, int, Tuple<int, int>>(1, 2, 3, 4, 5, 6, 7, System.Tuple.Create(8, 9));
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
        var (one, two, three, four, five, six, seven, eight, nine, ten) = new Tuple<int, int, int, int, int, int, int, Tuple<int, int, int>>(1, 2, 3, 4, 5, 6, 7, System.Tuple.Create(8, 9, 10));
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
        var (one, two, three, four, five, six, seven, eight, nine, ten, eleven) = new Tuple<int, int, int, int, int, int, int, Tuple<int, int, int, int>>(1, 2, 3, 4, 5, 6, 7, System.Tuple.Create(8, 9, 10, 11));
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
        var (one, two, three, four, five, six, seven, eight, nine, ten, eleven, twelve) = new Tuple<int, int, int, int, int, int, int, Tuple<int, int, int, int, int>>(1, 2, 3, 4, 5, 6, 7, System.Tuple.Create(8, 9, 10, 11, 12));
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
        var (one, two, three, four, five, six, seven, eight, nine, ten, eleven, twelve, thirteen) = new Tuple<int, int, int, int, int, int, int, Tuple<int, int, int, int, int, int>>(1, 2, 3, 4, 5, 6, 7, System.Tuple.Create(8, 9, 10, 11, 12, 13));
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
        var (one, two, three, four, five, six, seven, eight, nine, ten, eleven, twelve, thirteen, fourteen) = new Tuple<int, int, int, int, int, int, int, Tuple<int, int, int, int, int, int, int>>(1, 2, 3, 4, 5, 6, 7, System.Tuple.Create(8, 9, 10, 11, 12, 13, 14));
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
        var (one, two, three, four, five, six, seven, eight, nine, ten, eleven, twelve, thirteen, fourteen, fifteen) = new Tuple<int, int, int, int, int, int, int, Tuple<int, int, int, int, int, int, int, Tuple<int>>>(1, 2, 3, 4, 5, 6, 7, System.Tuple.Create(8, 9, 10, 11, 12, 13, 14, 15));
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
        var (one, two, three, four, five, six, seven, eight, nine, ten, eleven, twelve, thirteen, fourteen, fifteen, sixteen) = new Tuple<int, int, int, int, int, int, int, Tuple<int, int, int, int, int, int, int, Tuple<int, int>>>(1, 2, 3, 4, 5, 6, 7, new Tuple<int, int, int, int, int, int, int, Tuple<int, int>>(8, 9, 10, 11, 12, 13, 14, System.Tuple.Create(15, 16)));
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
        Assert.Equal(16, sixteen);
    }

    [Fact]
    public void DeconstructTest17() {
        var (one, two, three, four, five, six, seven, eight, nine, ten, eleven, twelve, thirteen, fourteen, fifteen, sixteen, seventeen) = new Tuple<int, int, int, int, int, int, int, Tuple<int, int, int, int, int, int, int, Tuple<int, int, int>>>(1, 2, 3, 4, 5, 6, 7, new Tuple<int, int, int, int, int, int, int, Tuple<int, int, int>>(8, 9, 10, 11, 12, 13, 14, System.Tuple.Create(15, 16, 17)));
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
        Assert.Equal(16, sixteen);
        Assert.Equal(17, seventeen);
    }

    [Fact]
    public void DeconstructTest18() {
        var (one, two, three, four, five, six, seven, eight, nine, ten, eleven, twelve, thirteen, fourteen, fifteen, sixteen, seventeen, eighteen) = new Tuple<int, int, int, int, int, int, int, Tuple<int, int, int, int, int, int, int, Tuple<int, int, int, int>>>(1, 2, 3, 4, 5, 6, 7, new Tuple<int, int, int, int, int, int, int, Tuple<int, int, int, int>>(8, 9, 10, 11, 12, 13, 14, System.Tuple.Create(15, 16, 17, 18)));
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
        Assert.Equal(16, sixteen);
        Assert.Equal(17, seventeen);
        Assert.Equal(18, eighteen);
    }

    [Fact]
    public void DeconstructTest19() {
        var (one, two, three, four, five, six, seven, eight, nine, ten, eleven, twelve, thirteen, fourteen, fifteen, sixteen, seventeen, eighteen, nineteen) = new Tuple<int, int, int, int, int, int, int, Tuple<int, int, int, int, int, int, int, Tuple<int, int, int, int, int>>>(1, 2, 3, 4, 5, 6, 7, new Tuple<int, int, int, int, int, int, int, Tuple<int, int, int, int, int>>(8, 9, 10, 11, 12, 13, 14, System.Tuple.Create(15, 16, 17, 18, 19)));
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
        Assert.Equal(16, sixteen);
        Assert.Equal(17, seventeen);
        Assert.Equal(18, eighteen);
        Assert.Equal(19, nineteen);
    }

    [Fact]
    public void DeconstructTest20() {
        var (one, two, three, four, five, six, seven, eight, nine, ten, eleven, twelve, thirteen, fourteen, fifteen, sixteen, seventeen, eighteen, nineteen, twenty) = new Tuple<int, int, int, int, int, int, int, Tuple<int, int, int, int, int, int, int, Tuple<int, int, int, int, int, int>>>(1, 2, 3, 4, 5, 6, 7, new Tuple<int, int, int, int, int, int, int, Tuple<int, int, int, int, int, int>>(8, 9, 10, 11, 12, 13, 14, System.Tuple.Create(15, 16, 17, 18, 19, 20)));
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
        Assert.Equal(16, sixteen);
        Assert.Equal(17, seventeen);
        Assert.Equal(18, eighteen);
        Assert.Equal(19, nineteen);
        Assert.Equal(20, twenty);
    }

    [Fact]
    public void DeconstructTest21() {
        var (one, two, three, four, five, six, seven, eight, nine, ten, eleven, twelve, thirteen, fourteen, fifteen, sixteen, seventeen, eighteen, nineteen, twenty, twentyone) = new Tuple<int, int, int, int, int, int, int, Tuple<int, int, int, int, int, int, int, Tuple<int, int, int, int, int, int, int>>>(1, 2, 3, 4, 5, 6, 7, new Tuple<int, int, int, int, int, int, int, Tuple<int, int, int, int, int, int, int>>(8, 9, 10, 11, 12, 13, 14, System.Tuple.Create(15, 16, 17, 18, 19, 20, 21)));
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
        Assert.Equal(16, sixteen);
        Assert.Equal(17, seventeen);
        Assert.Equal(18, eighteen);
        Assert.Equal(19, nineteen);
        Assert.Equal(20, twenty);
        Assert.Equal(21, twentyone);
    }
}
