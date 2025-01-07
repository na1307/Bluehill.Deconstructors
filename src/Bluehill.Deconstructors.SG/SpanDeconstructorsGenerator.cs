using Microsoft.CodeAnalysis;
using System.Diagnostics.CodeAnalysis;

namespace Bluehill.Deconstructors;

[Generator]
[ExcludeFromCodeCoverage]
public sealed class SpanDeconstructorsGenerator : SequenceDeconstructorsGenerator {
    public override void Initialize(IncrementalGeneratorInitializationContext context) => Generate(context, SequenceType.Span);
}
