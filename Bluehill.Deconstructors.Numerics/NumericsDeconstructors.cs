namespace Bluehill.Deconstructors;

[EditorBrowsable(EditorBrowsableState.Never)]
public static class NumericsDeconstructors {
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static void Deconstruct(this Vector2 vector, out float x, out float y) {
        x = vector.X;
        y = vector.Y;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static void Deconstruct(this Vector3 vector, out float x, out float y, out float z) {
        x = vector.X;
        y = vector.Y;
        z = vector.Z;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static void Deconstruct(this Vector4 vector, out float x, out float y, out float z, out float w) {
        x = vector.X;
        y = vector.Y;
        z = vector.Z;
        w = vector.W;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static void Deconstruct(this Matrix3x2 matrix, out float m11, out float m12, out float m21, out float m22, out float m31, out float m32) {
        m11 = matrix.M11;
        m12 = matrix.M12;
        m21 = matrix.M21;
        m22 = matrix.M22;
        m31 = matrix.M31;
        m32 = matrix.M32;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static void Deconstruct(this Matrix4x4 matrix, out float m11, out float m12, out float m13, out float m14, out float m21, out float m22, out float m23, out float m24, out float m31, out float m32, out float m33, out float m34, out float m41, out float m42, out float m43, out float m44) {
        m11 = matrix.M11;
        m12 = matrix.M12;
        m13 = matrix.M13;
        m14 = matrix.M14;
        m21 = matrix.M21;
        m22 = matrix.M22;
        m23 = matrix.M23;
        m24 = matrix.M24;
        m31 = matrix.M31;
        m32 = matrix.M32;
        m33 = matrix.M33;
        m34 = matrix.M34;
        m41 = matrix.M41;
        m42 = matrix.M42;
        m43 = matrix.M43;
        m44 = matrix.M44;
    }
}