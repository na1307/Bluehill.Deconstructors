namespace Bluehill.Deconstructors;

public static class DateTimeDeconstructors {
#if NET6_0_OR_GREATER && !NET8_0_OR_GREATER
    public static void Deconstruct(this DateTime dateTime, out DateOnly date, out TimeOnly time) {
        date = DateOnly.FromDateTime(dateTime);
        time = TimeOnly.FromDateTime(dateTime);
    }

#endif
#if !NET8_0_OR_GREATER
    public static void Deconstruct(this DateTime dateTime, out int year, out int month, out int day) {
        year = dateTime.Year;
        month = dateTime.Month;
        day = dateTime.Day;
    }

#endif
    public static void Deconstruct(this DateTime dateTime, out int year, out int month, out int day, out int hour, out int minute) {
        year = dateTime.Year;
        month = dateTime.Month;
        day = dateTime.Day;
        hour = dateTime.Hour;
        minute = dateTime.Minute;
    }

    public static void Deconstruct(this DateTime dateTime, out int year, out int month, out int day, out int hour, out int minute, out int second) {
        year = dateTime.Year;
        month = dateTime.Month;
        day = dateTime.Day;
        hour = dateTime.Hour;
        minute = dateTime.Minute;
        second = dateTime.Second;
    }

    public static void Deconstruct(this DateTime dateTime, out int year, out int month, out int day, out int hour, out int minute, out int second, out int millisecond) {
        year = dateTime.Year;
        month = dateTime.Month;
        day = dateTime.Day;
        hour = dateTime.Hour;
        minute = dateTime.Minute;
        second = dateTime.Second;
        millisecond = dateTime.Millisecond;
    }

    public static void Deconstruct(this DateTime dateTime, out int year, out int month, out int day, out int hour, out int minute, out int second, out int millisecond, out int microsecond) {
        year = dateTime.Year;
        month = dateTime.Month;
        day = dateTime.Day;
        hour = dateTime.Hour;
        minute = dateTime.Minute;
        second = dateTime.Second;
        millisecond = dateTime.Millisecond;
#if NET7_0_OR_GREATER
        microsecond = dateTime.Microsecond;
#else
        microsecond = (int)Math.Floor(dateTime.Ticks % TimeSpan.TicksPerMillisecond / 10d);
#endif
    }

    public static void Deconstruct(this DateTime dateTime, out int year, out int month, out int day, out int hour, out int minute, out int second, out int millisecond, out int microsecond, out int nanosecond) {
        year = dateTime.Year;
        month = dateTime.Month;
        day = dateTime.Day;
        hour = dateTime.Hour;
        minute = dateTime.Minute;
        second = dateTime.Second;
        millisecond = dateTime.Millisecond;
#if NET7_0_OR_GREATER
        microsecond = dateTime.Microsecond;
        nanosecond = dateTime.Nanosecond;
#else
        microsecond = (int)Math.Floor(dateTime.Ticks % TimeSpan.TicksPerMillisecond / 10d);
        nanosecond = (int)(dateTime.Ticks % TimeSpan.TicksPerMillisecond % 10) * 100;
#endif
    }
#if NET6_0_OR_GREATER

#if !NET8_0_OR_GREATER
    public static void Deconstruct(this DateOnly date, out int year, out int month, out int day) {
        year = date.Year;
        month = date.Month;
        day = date.Day;
    }

    public static void Deconstruct(this TimeOnly time, out int hour, out int minute) {
        hour = time.Hour;
        minute = time.Minute;
    }

    public static void Deconstruct(this TimeOnly time, out int hour, out int minute, out int second) {
        hour = time.Hour;
        minute = time.Minute;
        second = time.Second;
    }

    public static void Deconstruct(this TimeOnly time, out int hour, out int minute, out int second, out int millisecond) {
        hour = time.Hour;
        minute = time.Minute;
        second = time.Second;
        millisecond = time.Millisecond;
    }

    public static void Deconstruct(this TimeOnly time, out int hour, out int minute, out int second, out int millisecond, out int microsecond) {
        hour = time.Hour;
        minute = time.Minute;
        second = time.Second;
        millisecond = time.Millisecond;
#if NET7_0_OR_GREATER
        microsecond = time.Microsecond;
#else
        microsecond = (int)Math.Floor(time.Ticks % TimeSpan.TicksPerMillisecond / 10d);
#endif
    }

#endif
    public static void Deconstruct(this TimeOnly time, out int hour, out int minute, out int second, out int millisecond, out int microsecond, out int nanosecond) {
        hour = time.Hour;
        minute = time.Minute;
        second = time.Second;
        millisecond = time.Millisecond;
#if NET7_0_OR_GREATER
        microsecond = time.Microsecond;
        nanosecond = time.Nanosecond;
#else
        microsecond = (int)Math.Floor(time.Ticks % TimeSpan.TicksPerMillisecond / 10d);
        nanosecond = (int)(time.Ticks % TimeSpan.TicksPerMillisecond % 10) * 100;
#endif
    }
#if !NET8_0_OR_GREATER

    public static void Deconstruct(this DateTimeOffset dateTimeOffset, out DateOnly date, out TimeOnly time, out TimeSpan offset) {
        date = DateOnly.FromDateTime(dateTimeOffset.DateTime);
        time = TimeOnly.FromDateTime(dateTimeOffset.DateTime);
        offset = dateTimeOffset.Offset;
    }
#endif
#endif
}
