#if NETFRAMEWORK || (NETCOREAPP && !NETCOREAPP2_0_OR_GREATER && !NETCOREAPP3_0_OR_GREATER) || (NETSTANDARD && !NETSTANDARD2_1_OR_GREATER)
namespace Bluehill.Deconstructors;

public static class KeyValuePairDeconstructors {
    public static void Deconstruct<TKey, TValue>(this KeyValuePair<TKey, TValue> source, out TKey key, out TValue value) {
        key = source.Key;
        value = source.Value;
    }

    public static void Deconstruct(this System.Collections.DictionaryEntry source, out object key, out object? value) {
        key = source.Key;
        value = source.Value;
    }
}
#endif