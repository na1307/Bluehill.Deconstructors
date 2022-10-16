#if NETFRAMEWORK || (NETCOREAPP && !NETCOREAPP2_0_OR_GREATER) || (NETSTANDARD && !NETSTANDARD2_1_OR_GREATER)
using System.ComponentModel;

namespace Bluehill.Deconstructors;

partial class Deconstructors {
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static void Deconstruct<TKey, TValue>(this KeyValuePair<TKey, TValue> keyValuePair, out TKey key, out TValue value) {
        key = keyValuePair.Key;
        value = keyValuePair.Value;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static void Deconstruct(this System.Collections.DictionaryEntry dictionaryEntry, out object key, out object? value) {
        key = dictionaryEntry.Key;
        value = dictionaryEntry.Value;
    }
}
#endif