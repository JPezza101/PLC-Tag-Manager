using libplctag.DataTypes.Simple;
using libplctag.DataTypes;
using libplctag;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tag_Manager
{
    internal class Mappers
    {
        public static string ReadSingleTagData(string name, string type)
        {
            switch (type)
            {
                case "BOOL":
                    var tagBool = new TagBool()
                    {
                        Name = name,
                        Gateway = Form1.ipConfig.Gateway,
                        Path = Form1.ipConfig.Path,
                        PlcType = (PlcType)Enum.Parse(typeof(PlcType), Form1.ipConfig.CpuType),
                        Protocol = (Protocol)Enum.Parse(typeof(Protocol), Form1.ipConfig.CommType),
                        Timeout = TimeSpan.FromSeconds(5)
                    };
                    var dataBool = tagBool.Read();

                    return dataBool.ToString();

                case "SINT":
                    var tagSint = new TagSint()
                    {
                        Name = name,
                        Gateway = Form1.ipConfig.Gateway,
                        Path = Form1.ipConfig.Path,
                        PlcType = (PlcType)Enum.Parse(typeof(PlcType), Form1.ipConfig.CpuType),
                        Protocol = (Protocol)Enum.Parse(typeof(Protocol), Form1.ipConfig.CommType),
                        Timeout = TimeSpan.FromSeconds(5)
                    };

                    return tagSint.Read().ToString();

                case "INT":
                    var tagInt = new TagInt()
                    {
                        Name = name,
                        Gateway = Form1.ipConfig.Gateway,
                        Path = Form1.ipConfig.Path,
                        PlcType = (PlcType)Enum.Parse(typeof(PlcType), Form1.ipConfig.CpuType),
                        Protocol = (Protocol)Enum.Parse(typeof(Protocol), Form1.ipConfig.CommType),
                        Timeout = TimeSpan.FromSeconds(5)
                    };

                    return tagInt.Read().ToString();

                case "DINT":
                    var tagDint = new TagDint()
                    {
                        Name = name,
                        Gateway = Form1.ipConfig.Gateway,
                        Path = Form1.ipConfig.Path,
                        PlcType = (PlcType)Enum.Parse(typeof(PlcType), Form1.ipConfig.CpuType),
                        Protocol = (Protocol)Enum.Parse(typeof(Protocol), Form1.ipConfig.CommType),
                        Timeout = TimeSpan.FromSeconds(5)
                    };

                    return tagDint.Read().ToString();

                case "REAL":
                    var tagReal = new TagReal()
                    {
                        Name = name,
                        Gateway = Form1.ipConfig.Gateway,
                        Path = Form1.ipConfig.Path,
                        PlcType = (PlcType)Enum.Parse(typeof(PlcType), Form1.ipConfig.CpuType),
                        Protocol = (Protocol)Enum.Parse(typeof(Protocol), Form1.ipConfig.CommType),
                        Timeout = TimeSpan.FromSeconds(5)
                    };

                    return tagReal.Read().ToString();

                case "LINT":
                    var tagLint = new TagLint()
                    {
                        Name = name,
                        Gateway = Form1.ipConfig.Gateway,
                        Path = Form1.ipConfig.Path,
                        PlcType = (PlcType)Enum.Parse(typeof(PlcType), Form1.ipConfig.CpuType),
                        Protocol = (Protocol)Enum.Parse(typeof(Protocol), Form1.ipConfig.CommType),
                        Timeout = TimeSpan.FromSeconds(5)
                    };

                    return tagLint.Read().ToString();

                case "ASCII":
                    var tagAscii = new TagString()
                    {
                        Name = name,
                        Gateway = Form1.ipConfig.Gateway,
                        Path = Form1.ipConfig.Path,
                        PlcType = (PlcType)Enum.Parse(typeof(PlcType), Form1.ipConfig.CpuType),
                        Protocol = (Protocol)Enum.Parse(typeof(Protocol), Form1.ipConfig.CommType),
                        Timeout = TimeSpan.FromSeconds(5)
                    };

                    return tagAscii.Read().ToString();

                case "STRING":
                    var tagString = new TagString()
                    {
                        Name = name,
                        Gateway = Form1.ipConfig.Gateway,
                        Path = Form1.ipConfig.Path,
                        PlcType = (PlcType)Enum.Parse(typeof(PlcType), Form1.ipConfig.CpuType),
                        Protocol = (Protocol)Enum.Parse(typeof(Protocol), Form1.ipConfig.CommType),
                        Timeout = TimeSpan.FromSeconds(5)
                    };

                    return tagString.Read().ToString();

                default:
                    return "TYPE NOT FOUND";
            }
        }

        public static TagInfo[] ReadControllerTagInfo()
        {
            var tags = new Tag<TagInfoPlcMapper, TagInfo[]>()
            {
                Name = "@tags",
                Gateway = Form1.ipConfig.Gateway,
                Path = Form1.ipConfig.Path,
                PlcType = (PlcType)Enum.Parse(typeof(PlcType), Form1.ipConfig.CpuType),
                Protocol = (Protocol)Enum.Parse(typeof(Protocol), Form1.ipConfig.CommType),
                Timeout = TimeSpan.FromSeconds(5)
            };

            var info = tags.Read();
            return info;
        }

        public static TagInfo[] ReadProgramTagInfo(string progName)
        {
            var tags = new Tag<TagInfoPlcMapper, TagInfo[]>()
            {
                Name = $"{progName}.@tags",
                Gateway = Form1.ipConfig.Gateway,
                Path = Form1.ipConfig.Path,
                PlcType = (PlcType)Enum.Parse(typeof(PlcType), Form1.ipConfig.CpuType),
                Protocol = (Protocol)Enum.Parse(typeof(Protocol), Form1.ipConfig.CommType),
                Timeout = TimeSpan.FromSeconds(5)
            };

            var info = tags.Read();
            return info;
        }

        public static UdtInfo ReadUdtInfo(int udtID)
        {
            var udt = new Tag<UdtInfoPlcMapper, UdtInfo>()
            {
                Name = $"@udt/{udtID}",
                Gateway = Form1.ipConfig.Gateway,
                Path = Form1.ipConfig.Path,
                PlcType = (PlcType)Enum.Parse(typeof(PlcType), Form1.ipConfig.CpuType),
                Protocol = (Protocol)Enum.Parse(typeof(Protocol), Form1.ipConfig.CommType),
                Timeout = TimeSpan.FromSeconds(5)
            };

            var info = udt.Read();
            return info;
        }

        public static void WriteSingleTagData(string name, string type, string data)
        {
            switch (type)
            {
                case "BOOL":
                    var tagBool = new TagBool()
                    {
                        Name = name,
                        Gateway = Form1.ipConfig.Gateway,
                        Path = Form1.ipConfig.Path,
                        PlcType = (PlcType)Enum.Parse(typeof(PlcType), Form1.ipConfig.CpuType),
                        Protocol = (Protocol)Enum.Parse(typeof(Protocol), Form1.ipConfig.CommType),
                        Timeout = TimeSpan.FromSeconds(5)
                    };

                    tagBool.Write(Convert.ToBoolean(data));
                    break;

                case "SINT":
                    var tagSint = new TagSint()
                    {
                        Name = name,
                        Gateway = Form1.ipConfig.Gateway,
                        Path = Form1.ipConfig.Path,
                        PlcType = (PlcType)Enum.Parse(typeof(PlcType), Form1.ipConfig.CpuType),
                        Protocol = (Protocol)Enum.Parse(typeof(Protocol), Form1.ipConfig.CommType),
                        Timeout = TimeSpan.FromSeconds(5)
                    };

                    short numSint;
                    short.TryParse(data, out numSint);
                    tagSint.Write(Convert.ToSByte(data));
                    break;

                case "INT":
                    var tagInt = new Tag<IntPlcMapper, short>()
                    {
                        Name = name,
                        Gateway = Form1.ipConfig.Gateway,
                        Path = Form1.ipConfig.Path,
                        PlcType = (PlcType)Enum.Parse(typeof(PlcType), Form1.ipConfig.CpuType),
                        Protocol = (Protocol)Enum.Parse(typeof(Protocol), Form1.ipConfig.CommType),
                        Timeout = TimeSpan.FromSeconds(5),
                    };

                    short numInt;
                    short.TryParse(data, out numInt);
                    tagInt.Write(numInt);
                    break;

                case "DINT":
                    var tagDint = new TagDint()
                    {
                        Name = name,
                        Gateway = Form1.ipConfig.Gateway,
                        Path = Form1.ipConfig.Path,
                        PlcType = (PlcType)Enum.Parse(typeof(PlcType), Form1.ipConfig.CpuType),
                        Protocol = (Protocol)Enum.Parse(typeof(Protocol), Form1.ipConfig.CommType),
                        Timeout = TimeSpan.FromSeconds(5)
                    };

                    int numDint;
                    int.TryParse(data, out numDint);
                    tagDint.Write(numDint);
                    break;

                case "REAL":
                    var tagReal = new TagReal()
                    {
                        Name = name,
                        Gateway = Form1.ipConfig.Gateway,
                        Path = Form1.ipConfig.Path,
                        PlcType = (PlcType)Enum.Parse(typeof(PlcType), Form1.ipConfig.CpuType),
                        Protocol = (Protocol)Enum.Parse(typeof(Protocol), Form1.ipConfig.CommType),
                        Timeout = TimeSpan.FromSeconds(5)
                    };

                    float numReal;
                    float.TryParse(data, out numReal);
                    tagReal.Write(numReal);
                    break;

                case "LINT":
                    var tagLint = new TagLint()
                    {
                        Name = name,
                        Gateway = Form1.ipConfig.Gateway,
                        Path = Form1.ipConfig.Path,
                        PlcType = (PlcType)Enum.Parse(typeof(PlcType), Form1.ipConfig.CpuType),
                        Protocol = (Protocol)Enum.Parse(typeof(Protocol), Form1.ipConfig.CommType),
                        Timeout = TimeSpan.FromSeconds(5)
                    };

                    int numLint;
                    int.TryParse(data, out numLint);
                    tagLint.Write(numLint);
                    break;

                case "ASCII":
                    var tagAscii = new TagString()
                    {
                        Name = name,
                        Gateway = Form1.ipConfig.Gateway,
                        Path = Form1.ipConfig.Path,
                        PlcType = (PlcType)Enum.Parse(typeof(PlcType), Form1.ipConfig.CpuType),
                        Protocol = (Protocol)Enum.Parse(typeof(Protocol), Form1.ipConfig.CommType),
                        Timeout = TimeSpan.FromSeconds(5)
                    };
                    tagAscii.Write(data);
                    break;

                case "STRING":
                    var tagString = new TagString()
                    {
                        Name = name,
                        Gateway = Form1.ipConfig.Gateway,
                        Path = Form1.ipConfig.Path,
                        PlcType = (PlcType)Enum.Parse(typeof(PlcType), Form1.ipConfig.CpuType),
                        Protocol = (Protocol)Enum.Parse(typeof(Protocol), Form1.ipConfig.CommType),
                        Timeout = TimeSpan.FromSeconds(5)
                    };
                    tagString.Write(data);
                    break;

                default:
                    break;
            }
        }

    }
}
