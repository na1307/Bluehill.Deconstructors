namespace Bluehill.Deconstructors;

[EditorBrowsable(EditorBrowsableState.Never)]
public static class KeyValuePairDeconstructors {
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static void Deconstruct<TKey, TValue>(this KeyValuePair<TKey, TValue> source, out TKey key, out TValue value) {
        key = source.Key;
        value = source.Value;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static void Deconstruct(this System.Collections.DictionaryEntry source, out object key, out object? value) {
        key = source.Key;
        value = source.Value;
    }
}
