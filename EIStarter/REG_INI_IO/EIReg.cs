using System;
using System.Collections.Generic;
using System.IO;

namespace EIStarter
{
    public class EIRegFile
    {
        public bool isLoaded = false;

        private readonly Dictionary<string, Section> _sections =
            new(new Utility.AsciiIgnoreCaseComparer());

        private const uint RegSignature = 0x45AB3EFB;

        public void Load(string filePath)
        {
            var data = File.ReadAllBytes(filePath);
            if (data.Length < 6 || BitConverter.ToUInt32(data, 0) != RegSignature)
                throw new InvalidDataException();

            ushort sectionCount = BitConverter.ToUInt16(data, 4);
            int offset = 6;

            _sections.Clear();
            for (int i = 0; i < sectionCount; i++)
            {
                var section = ReadSection(data, BitConverter.ToUInt16(data, offset + 2));
                _sections[section.Name] = section;
                offset += 6;
            }
            isLoaded = true;
        }

        static private Section ReadSection(byte[] data, int offset)
        {
            int sectionOffset = offset;
            ushort valueCount = BitConverter.ToUInt16(data, offset);
            ushort nameLength = BitConverter.ToUInt16(data, offset + 2);
            string name = Utility.Encoding1251.GetString(data, offset + 4, nameLength);
            offset += 4 + nameLength;

            var section = new Section(name);

            for (int i = 0; i < valueCount; i++)
            {
                var val = ReadValue(data, sectionOffset + BitConverter.ToUInt16(data, offset + 2));
                section.Values.Add(val.Name, val);
                offset += 6;
            }

            return section;
        }

        static private Value ReadValue(byte[] data, int offset)
        {
            var type = (ValueType)data[offset];
            var nameLength = BitConverter.ToUInt16(data, offset + 1);
            var name = Utility.Encoding1251.GetString(data, offset + 3, nameLength);
            offset += 3 + nameLength;

            object valueData;
            switch (type)
            {
                case ValueType.VT_DWORD:
                    valueData = BitConverter.ToUInt32(data, offset);
                    break;
                case ValueType.VT_FLOAT:
                    valueData = BitConverter.ToSingle(data, offset);
                    break;
                case ValueType.VT_STRING:
                    ushort stringLength = BitConverter.ToUInt16(data, offset);
                    valueData = Utility.Encoding1251.GetString(data, offset + 2, stringLength);
                    break;
                default:
                    valueData = String.Empty;
                    break;
                    //throw new InvalidDataException("Unexpected value type");
            }

            return new Value(name, type, valueData);
        }

        public float GetFloat(string sectionName, string valueName, float defaultValue)
        {
            if (_sections.TryGetValue(sectionName, out Section? section) &&
                section.Values.TryGetValue(valueName, out Value? value) &&
                value.Type == ValueType.VT_FLOAT)
                return (float)value.Data;
            return defaultValue;
        }

        public uint GetDword(string sectionName, string valueName, uint defaultValue)
        {
            if (_sections.TryGetValue(sectionName, out Section? section) &&
                section.Values.TryGetValue(valueName, out Value? value) &&
                value.Type == ValueType.VT_DWORD)
                return (uint)value.Data;
            return defaultValue;
        }

        public string GetString(string valueName, string sectionName, string defaultValue)
        {
            if (_sections.TryGetValue(sectionName, out Section? section) &&
                section.Values.TryGetValue(valueName, out Value? value) &&
                value.Type == ValueType.VT_STRING)
                return (string)value.Data;
            return defaultValue;
        }

        private class Section
        {
            public string Name { get; }
            public Dictionary<string, Value> Values { get; }

            public Section(string name)
            {
                Name = name;
                Values = new Dictionary<string, Value>(new Utility.AsciiIgnoreCaseComparer());
            }
        }

        private class Value
        {
            public string Name { get; }
            public ValueType Type { get; }
            public object Data { get; set; }

            public Value(string name, ValueType type, object data)
            {
                Name = name;
                Type = type;
                Data = data;
            }
        }

        public enum ValueType : byte
        {
            VT_DWORD = 0,
            VT_FLOAT = 1,
            VT_STRING = 2,
            VT_ARR = 0x80,
            VT_DWORD_ARR = VT_DWORD | VT_ARR,
            VT_FLOAT_ARR = VT_FLOAT | VT_ARR,
            VT_STRING_ARR = VT_STRING | VT_ARR,
            VT_UNKNOWN = 255
        }
    }
}
