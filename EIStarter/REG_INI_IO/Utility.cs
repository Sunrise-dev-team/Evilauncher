using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace System
{
    public readonly struct Index
    {
        public int Value { get; }
        public bool IsFromEnd { get; }

        public Index(int value, bool isFromEnd = false)
        {
            Value = value;
            IsFromEnd = isFromEnd;
        }

        // Implicit conversion from int to Index
        public static implicit operator Index(int value)
        {
            return new Index(value, isFromEnd: false);
        }

        public static Index Start => new Index(0);

        public static Index End => new Index(0, true);

        // Method to calculate the offset from the start given the collection length
        public int GetOffset(int length)
        {
            if (IsFromEnd)
            {
                return length - Value;
            }
            else
            {
                return Value;
            }
        }
    }

    public readonly struct Range
    {
        public Index Start { get; }
        public Index End { get; }

        public Range(Index start, Index end)
        {
            Start = start;
            End = end;
        }

        public static Range StartAt(Index start) => new Range(start, Index.End);

        public static Range EndAt(Index end) => new Range(Index.Start, end);

        public static Range All => new Range(Index.Start, Index.End);

        // Assuming you want to add some functionality to work with arrays or collections
        // You might need to implement methods or extensions to support slicing with this custom Range type.
    }
}

namespace EIStarter
{
    internal static class Utility
    {
        private static Encoding? _encoding = null;

        public static Encoding Encoding1251
        {
            get
            {
                if (_encoding != null)
                    return _encoding;

                Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                _encoding = Encoding.GetEncoding(1251);
                return _encoding;
            }
        }

        public static byte[] GetBytes<T>(T str) where T : struct
        {
            int size = Marshal.SizeOf(str);
            byte[] arr = new byte[size];

            IntPtr ptr = Marshal.AllocHGlobal(size);
            try
            {
                Marshal.StructureToPtr(str, ptr, true);
                Marshal.Copy(ptr, arr, 0, size);
            }
            finally
            {
                Marshal.FreeHGlobal(ptr);
            }

            return arr;
        }

        public static T ReadStructure<T>(BinaryReader reader) where T : struct
        {
            var size = Marshal.SizeOf(typeof(T));
            var buffer = new byte[size];
            if (reader.Read(buffer, 0, size) != size)
                throw new InvalidDataException();

            var handle = GCHandle.Alloc(buffer, GCHandleType.Pinned);
            try
            {
                return Marshal.PtrToStructure<T>(handle.AddrOfPinnedObject());
            }
            finally
            {
                handle.Free();
            }
        }

        public static DateTime ConvertFromUnixTimestamp(double timestamp)
        {
            return new DateTime(1970, 1, 1, 0, 0, 0, 0).AddSeconds(timestamp);
        }

        public static double ConvertToUnixTimestamp(DateTime date)
        {
            var origin = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return Math.Floor((date - origin).TotalSeconds);
        }

        public static bool FilePathHasInvalidChars(string path)
        {
            return !string.IsNullOrEmpty(path) && path.IndexOfAny(Path.GetInvalidPathChars()) >= 0;
        }

        public static string GetRelativePath(string rootPath, string path)
        {
            if (rootPath == null)
                throw new ArgumentNullException("rootPath");

            if (rootPath.Length == 0)
                throw new ArgumentOutOfRangeException("rootPath", "Root path cannot be empty");

            if (path == null)
                throw new ArgumentNullException("path");

            if (path.Length == 0)
                throw new ArgumentOutOfRangeException("path", "Path cannot be empty");

            var pathNormalized = Path.GetFullPath(path);
            var rootPathNormalized = Path.GetFullPath(rootPath).TrimEnd('\\', '/');

            if (!pathNormalized.StartsWith(rootPathNormalized))
                throw new ArgumentException();

            var res = pathNormalized[(rootPathNormalized.Length + 1)..]; //.Net 8 +
            //var res = pathNormalized.Substring(rootPathNormalized.Length + 1); //.Net FW 4.7.2
            return res;
        }

        public static char ToLowerAscii(char c)
        {
            if (c >= 'A' && c <= 'Z')
                return (char)(c + ('a' - 'A'));

            return c;
        }

        public static string ToLowerAscii(string s)
        {
            if (s == null)
                throw new ArgumentNullException("s");

            string result = string.Empty;
            for (int i = 0; i < s.Length; i++)
                result += ToLowerAscii(s[i]);

            return result;
        }

        public static uint GetEIStringHash32(string value, uint hashTableSize = 0)
        {
            if (value == null)
                throw new ArgumentNullException("value");

            uint hash = 0;
            var valueAsBytes = Encoding1251.GetBytes(ToLowerAscii(value));
            foreach (var character in valueAsBytes)
                hash += character;

            return hashTableSize == 0
                ? hash
                : hash % hashTableSize;
        }

        public static ushort GetEIStringHash16(string value, ushort hashTableSize = 0)
        {
            if (value == null)
                throw new ArgumentNullException("value");

            uint hash = GetEIStringHash32(value, 0);
            return hashTableSize == 0
                ? (ushort)hash
                : (ushort)(hash % hashTableSize);
        }

        public class AsciiIgnoreCaseComparer : IEqualityComparer<string>
        {
            public bool Equals(string? x, string? y)
            {
                if (x == null || y == null)
                    return x == y;

                if (x.Length != y.Length)
                    return false;

                for (int i = 0; i < x.Length; i++)
                {
                    if (ToLowerAscii(x[i]) != ToLowerAscii(y[i]))
                        return false;
                }

                return true;
            }

            public int GetHashCode(string s)
            {
                if (s == null)
                    return 0;

                // From here: http://stackoverflow.com/a/263416
                unchecked
                {
                    int hash = (int)2166136261;
                    for (var i = 0; i < s.Length; i++)
                        hash = hash * 16777619 ^ ToLowerAscii(s[i]).GetHashCode();

                    return hash;
                }
            }
        }

        public static T Clamp<T>(T value, T min, T max) where T : IComparable<T>
        {
            return value.CompareTo(min) < 0 ? min : value.CompareTo(max) > 0 ? max : value;
        }
    }
}
