namespace Bluehill.Deconstructors;

public static class VersionDeconstructors {
    public static void Deconstruct(this Version version, out int major, out int minor) {
        major = version.Major;
        minor = version.Minor;
    }

    public static void Deconstruct(this Version version, out int major, out int minor, out int build) {
        major = version.Major;
        minor = version.Minor;
        build = version.Build;
    }

    public static void Deconstruct(this Version version, out int major, out int minor, out int build, out int revision) {
        major = version.Major;
        minor = version.Minor;
        build = version.Build;
        revision = version.Revision;
    }
}
