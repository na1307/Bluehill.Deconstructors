namespace Bluehill.Deconstructors.KeyValuePair.Tests;

public sealed class KeyValuePairDeconstructorsTest {
    [Fact]
    public void DeconstructTest1() {
        KeyValuePairDeconstructors.Deconstruct(new KeyValuePair<int, int>(5, 3), out var key, out var value);
        Assert.Equal(5, key);
        Assert.Equal(3, value);
    }

    [Fact]
    public void DeconstructTest2() {
        KeyValuePairDeconstructors.Deconstruct(new System.Collections.DictionaryEntry(5, 3), out var key, out var value);
        Assert.Equal(5, (int)key);
        Assert.Equal(3, (int)value!);
    }
}