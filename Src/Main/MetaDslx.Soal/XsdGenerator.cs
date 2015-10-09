using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Soal //1:1
{
    using __Hidden_XsdGenerator_1929200244;
    namespace __Hidden_XsdGenerator_1929200244
    {
        internal static class __Extensions
        {
            internal static IEnumerator<T> GetEnumerator<T>(this T item)
            {
                if (item == null) return new List<T>().GetEnumerator();
                else return new List<T> { item }.GetEnumerator();
            }
        }
    }

    public class XsdGenerator //2:1
    {
        private object Instances; //2:1

        public XsdGenerator() //2:1
        {
        }

        public XsdGenerator(object instances) : this() //2:1
        {
            this.Instances = instances;
        }

        private Stream __ToStream(string text)
        {
            MemoryStream stream = new MemoryStream();
            StreamWriter writer = new StreamWriter(stream);
            writer.Write(text);
            writer.Flush();
            stream.Position = 0;
            return stream;
        }

        private static IEnumerable<T> __Enumerate<T>(IEnumerator<T> items)
        {
            while (items.MoveNext())
            {
                yield return items.Current;
            }
        }

        private int counter = 0;
        private int NextCounter()
        {
            return ++counter;
        }

        public string Generate(Namespace ns) //4:1
        {
            StringBuilder __out = new StringBuilder();
            __out.Append("<?xml version=\"1.0\" encoding=\"utf-8\"?>"); //5:1
            __out.AppendLine(); //5:39
            string __tmp1Prefix = "<xs:schema targetNamespace=\""; //6:1
            string __tmp2Suffix = "\""; //6:37
            StringBuilder __tmp3 = new StringBuilder();
            __tmp3.Append(ns.Uri);
            using(StreamReader __tmp3Reader = new StreamReader(this.__ToStream(__tmp3.ToString())))
            {
                bool __tmp3_first = true;
                while(__tmp3_first || !__tmp3Reader.EndOfStream)
                {
                    __tmp3_first = false;
                    string __tmp3Line = __tmp3Reader.ReadLine();
                    if (__tmp3Line == null)
                    {
                        __tmp3Line = "";
                    }
                    __out.Append(__tmp1Prefix);
                    __out.Append(__tmp3Line);
                    __out.Append(__tmp2Suffix);
                    __out.AppendLine(); //6:38
                }
            }
            __out.Append("		xmlns:xs=\"http://www.w3.org/2001/XMLSchema\""); //7:1
            __out.AppendLine(); //7:46
            string __tmp4Prefix = "		xmlns:tns=\""; //8:1
            string __tmp5Suffix = "\""; //8:22
            StringBuilder __tmp6 = new StringBuilder();
            __tmp6.Append(ns.Uri);
            using(StreamReader __tmp6Reader = new StreamReader(this.__ToStream(__tmp6.ToString())))
            {
                bool __tmp6_first = true;
                while(__tmp6_first || !__tmp6Reader.EndOfStream)
                {
                    __tmp6_first = false;
                    string __tmp6Line = __tmp6Reader.ReadLine();
                    if (__tmp6Line == null)
                    {
                        __tmp6Line = "";
                    }
                    __out.Append(__tmp4Prefix);
                    __out.Append(__tmp6Line);
                    __out.Append(__tmp5Suffix);
                    __out.AppendLine(); //8:23
                }
            }
            string __tmp7Prefix = "		xmlns:"; //9:1
            string __tmp8Suffix = "\""; //9:30
            StringBuilder __tmp9 = new StringBuilder();
            __tmp9.Append(ns.Prefix);
            using(StreamReader __tmp9Reader = new StreamReader(this.__ToStream(__tmp9.ToString())))
            {
                bool __tmp9_first = true;
                while(__tmp9_first || !__tmp9Reader.EndOfStream)
                {
                    __tmp9_first = false;
                    string __tmp9Line = __tmp9Reader.ReadLine();
                    if (__tmp9Line == null)
                    {
                        __tmp9Line = "";
                    }
                    __out.Append(__tmp7Prefix);
                    __out.Append(__tmp9Line);
                }
            }
            string __tmp10Line = "=\""; //9:20
            __out.Append(__tmp10Line);
            StringBuilder __tmp11 = new StringBuilder();
            __tmp11.Append(ns.Uri);
            using(StreamReader __tmp11Reader = new StreamReader(this.__ToStream(__tmp11.ToString())))
            {
                bool __tmp11_first = true;
                while(__tmp11_first || !__tmp11Reader.EndOfStream)
                {
                    __tmp11_first = false;
                    string __tmp11Line = __tmp11Reader.ReadLine();
                    if (__tmp11Line == null)
                    {
                        __tmp11Line = "";
                    }
                    __out.Append(__tmp11Line);
                    __out.Append(__tmp8Suffix);
                    __out.AppendLine(); //9:31
                }
            }
            __out.Append("		elementFormDefault=\"qualified\">"); //10:1
            __out.AppendLine(); //10:34
            var __loop1_results = 
                (from arr in __Enumerate((ns.GetArrayTypes()).GetEnumerator()) //11:8
                select new { arr = arr}
                ).ToList(); //11:3
            int __loop1_iteration = 0;
            foreach (var __tmp12 in __loop1_results)
            {
                ++__loop1_iteration;
                var arr = __tmp12.arr;
                __out.AppendLine(); //12:1
                string __tmp13Prefix = "	<xs:element name=\""; //13:1
                string __tmp14Suffix = "\"/>"; //13:76
                StringBuilder __tmp15 = new StringBuilder();
                __tmp15.Append(arr.GetXsdName());
                using(StreamReader __tmp15Reader = new StreamReader(this.__ToStream(__tmp15.ToString())))
                {
                    bool __tmp15_first = true;
                    while(__tmp15_first || !__tmp15Reader.EndOfStream)
                    {
                        __tmp15_first = false;
                        string __tmp15Line = __tmp15Reader.ReadLine();
                        if (__tmp15Line == null)
                        {
                            __tmp15Line = "";
                        }
                        __out.Append(__tmp13Prefix);
                        __out.Append(__tmp15Line);
                    }
                }
                string __tmp16Line = "\" type=\""; //13:38
                __out.Append(__tmp16Line);
                StringBuilder __tmp17 = new StringBuilder();
                __tmp17.Append(ns.Prefix);
                using(StreamReader __tmp17Reader = new StreamReader(this.__ToStream(__tmp17.ToString())))
                {
                    bool __tmp17_first = true;
                    while(__tmp17_first || !__tmp17Reader.EndOfStream)
                    {
                        __tmp17_first = false;
                        string __tmp17Line = __tmp17Reader.ReadLine();
                        if (__tmp17Line == null)
                        {
                            __tmp17Line = "";
                        }
                        __out.Append(__tmp17Line);
                    }
                }
                string __tmp18Line = ":"; //13:57
                __out.Append(__tmp18Line);
                StringBuilder __tmp19 = new StringBuilder();
                __tmp19.Append(arr.GetXsdName());
                using(StreamReader __tmp19Reader = new StreamReader(this.__ToStream(__tmp19.ToString())))
                {
                    bool __tmp19_first = true;
                    while(__tmp19_first || !__tmp19Reader.EndOfStream)
                    {
                        __tmp19_first = false;
                        string __tmp19Line = __tmp19Reader.ReadLine();
                        if (__tmp19Line == null)
                        {
                            __tmp19Line = "";
                        }
                        __out.Append(__tmp19Line);
                        __out.Append(__tmp14Suffix);
                        __out.AppendLine(); //13:79
                    }
                }
                string __tmp20Prefix = "	<xs:complexType name=\""; //14:1
                string __tmp21Suffix = "\">"; //14:42
                StringBuilder __tmp22 = new StringBuilder();
                __tmp22.Append(arr.GetXsdName());
                using(StreamReader __tmp22Reader = new StreamReader(this.__ToStream(__tmp22.ToString())))
                {
                    bool __tmp22_first = true;
                    while(__tmp22_first || !__tmp22Reader.EndOfStream)
                    {
                        __tmp22_first = false;
                        string __tmp22Line = __tmp22Reader.ReadLine();
                        if (__tmp22Line == null)
                        {
                            __tmp22Line = "";
                        }
                        __out.Append(__tmp20Prefix);
                        __out.Append(__tmp22Line);
                        __out.Append(__tmp21Suffix);
                        __out.AppendLine(); //14:44
                    }
                }
                __out.Append("		<xs:sequence>"); //15:1
                __out.AppendLine(); //15:16
                string __tmp23Prefix = "			<xs:element name=\""; //16:1
                string __tmp24Suffix = "\"/>"; //16:126
                StringBuilder __tmp25 = new StringBuilder();
                __tmp25.Append(arr.InnerType.GetXsdName());
                using(StreamReader __tmp25Reader = new StreamReader(this.__ToStream(__tmp25.ToString())))
                {
                    bool __tmp25_first = true;
                    while(__tmp25_first || !__tmp25Reader.EndOfStream)
                    {
                        __tmp25_first = false;
                        string __tmp25Line = __tmp25Reader.ReadLine();
                        if (__tmp25Line == null)
                        {
                            __tmp25Line = "";
                        }
                        __out.Append(__tmp23Prefix);
                        __out.Append(__tmp25Line);
                    }
                }
                string __tmp26Line = "\" type=\""; //16:50
                __out.Append(__tmp26Line);
                StringBuilder __tmp27 = new StringBuilder();
                __tmp27.Append(arr.InnerType.GetNamespace(ns).Prefix);
                using(StreamReader __tmp27Reader = new StreamReader(this.__ToStream(__tmp27.ToString())))
                {
                    bool __tmp27_first = true;
                    while(__tmp27_first || !__tmp27Reader.EndOfStream)
                    {
                        __tmp27_first = false;
                        string __tmp27Line = __tmp27Reader.ReadLine();
                        if (__tmp27Line == null)
                        {
                            __tmp27Line = "";
                        }
                        __out.Append(__tmp27Line);
                    }
                }
                string __tmp28Line = ":"; //16:97
                __out.Append(__tmp28Line);
                StringBuilder __tmp29 = new StringBuilder();
                __tmp29.Append(arr.InnerType.GetXsdName());
                using(StreamReader __tmp29Reader = new StreamReader(this.__ToStream(__tmp29.ToString())))
                {
                    bool __tmp29_first = true;
                    while(__tmp29_first || !__tmp29Reader.EndOfStream)
                    {
                        __tmp29_first = false;
                        string __tmp29Line = __tmp29Reader.ReadLine();
                        if (__tmp29Line == null)
                        {
                            __tmp29Line = "";
                        }
                        __out.Append(__tmp29Line);
                        __out.Append(__tmp24Suffix);
                        __out.AppendLine(); //16:129
                    }
                }
                __out.Append("		</xs:sequence>"); //17:1
                __out.AppendLine(); //17:17
                __out.Append("	</xs:complexType>"); //18:1
                __out.AppendLine(); //18:19
            }
            var __loop2_results = 
                (from __loop2_var1 in __Enumerate((ns.Declarations).GetEnumerator()) //20:8
                from etype in __Enumerate((__loop2_var1).GetEnumerator()).OfType<Enum>() //20:25
                select new { __loop2_var1 = __loop2_var1, etype = etype}
                ).ToList(); //20:3
            int __loop2_iteration = 0;
            foreach (var __tmp30 in __loop2_results)
            {
                ++__loop2_iteration;
                var __loop2_var1 = __tmp30.__loop2_var1;
                var etype = __tmp30.etype;
                __out.AppendLine(); //21:1
                string __tmp31Prefix = "	<xs:element name=\""; //22:1
                string __tmp32Suffix = "\"/>"; //22:80
                StringBuilder __tmp33 = new StringBuilder();
                __tmp33.Append(etype.GetXsdName());
                using(StreamReader __tmp33Reader = new StreamReader(this.__ToStream(__tmp33.ToString())))
                {
                    bool __tmp33_first = true;
                    while(__tmp33_first || !__tmp33Reader.EndOfStream)
                    {
                        __tmp33_first = false;
                        string __tmp33Line = __tmp33Reader.ReadLine();
                        if (__tmp33Line == null)
                        {
                            __tmp33Line = "";
                        }
                        __out.Append(__tmp31Prefix);
                        __out.Append(__tmp33Line);
                    }
                }
                string __tmp34Line = "\" type=\""; //22:40
                __out.Append(__tmp34Line);
                StringBuilder __tmp35 = new StringBuilder();
                __tmp35.Append(ns.Prefix);
                using(StreamReader __tmp35Reader = new StreamReader(this.__ToStream(__tmp35.ToString())))
                {
                    bool __tmp35_first = true;
                    while(__tmp35_first || !__tmp35Reader.EndOfStream)
                    {
                        __tmp35_first = false;
                        string __tmp35Line = __tmp35Reader.ReadLine();
                        if (__tmp35Line == null)
                        {
                            __tmp35Line = "";
                        }
                        __out.Append(__tmp35Line);
                    }
                }
                string __tmp36Line = ":"; //22:59
                __out.Append(__tmp36Line);
                StringBuilder __tmp37 = new StringBuilder();
                __tmp37.Append(etype.GetXsdName());
                using(StreamReader __tmp37Reader = new StreamReader(this.__ToStream(__tmp37.ToString())))
                {
                    bool __tmp37_first = true;
                    while(__tmp37_first || !__tmp37Reader.EndOfStream)
                    {
                        __tmp37_first = false;
                        string __tmp37Line = __tmp37Reader.ReadLine();
                        if (__tmp37Line == null)
                        {
                            __tmp37Line = "";
                        }
                        __out.Append(__tmp37Line);
                        __out.Append(__tmp32Suffix);
                        __out.AppendLine(); //22:83
                    }
                }
                string __tmp38Prefix = "	<xs:simpleType name=\""; //23:1
                string __tmp39Suffix = "\">"; //23:43
                StringBuilder __tmp40 = new StringBuilder();
                __tmp40.Append(etype.GetXsdName());
                using(StreamReader __tmp40Reader = new StreamReader(this.__ToStream(__tmp40.ToString())))
                {
                    bool __tmp40_first = true;
                    while(__tmp40_first || !__tmp40Reader.EndOfStream)
                    {
                        __tmp40_first = false;
                        string __tmp40Line = __tmp40Reader.ReadLine();
                        if (__tmp40Line == null)
                        {
                            __tmp40Line = "";
                        }
                        __out.Append(__tmp38Prefix);
                        __out.Append(__tmp40Line);
                        __out.Append(__tmp39Suffix);
                        __out.AppendLine(); //23:45
                    }
                }
                __out.Append("		<xs:restriction base=\"xs:string\">"); //24:1
                __out.AppendLine(); //24:36
                var __loop3_results = 
                    (from __loop3_var1 in __Enumerate((etype).GetEnumerator()) //25:10
                    from elit in __Enumerate((__loop3_var1.EnumLiterals).GetEnumerator()) //25:17
                    select new { __loop3_var1 = __loop3_var1, elit = elit}
                    ).ToList(); //25:5
                int __loop3_iteration = 0;
                foreach (var __tmp41 in __loop3_results)
                {
                    ++__loop3_iteration;
                    var __loop3_var1 = __tmp41.__loop3_var1;
                    var elit = __tmp41.elit;
                    string __tmp42Prefix = "			<xs:enumeration value=\""; //26:1
                    string __tmp43Suffix = "\"/>"; //26:38
                    StringBuilder __tmp44 = new StringBuilder();
                    __tmp44.Append(elit.Name);
                    using(StreamReader __tmp44Reader = new StreamReader(this.__ToStream(__tmp44.ToString())))
                    {
                        bool __tmp44_first = true;
                        while(__tmp44_first || !__tmp44Reader.EndOfStream)
                        {
                            __tmp44_first = false;
                            string __tmp44Line = __tmp44Reader.ReadLine();
                            if (__tmp44Line == null)
                            {
                                __tmp44Line = "";
                            }
                            __out.Append(__tmp42Prefix);
                            __out.Append(__tmp44Line);
                            __out.Append(__tmp43Suffix);
                            __out.AppendLine(); //26:41
                        }
                    }
                }
                __out.Append("		</xs:restriction>"); //28:1
                __out.AppendLine(); //28:20
                __out.Append("	</xs:simpleType>"); //29:1
                __out.AppendLine(); //29:18
            }
            var __loop4_results = 
                (from __loop4_var1 in __Enumerate((ns.Declarations).GetEnumerator()) //31:8
                from stype in __Enumerate((__loop4_var1).GetEnumerator()).OfType<StructuredType>() //31:25
                select new { __loop4_var1 = __loop4_var1, stype = stype}
                ).ToList(); //31:3
            int __loop4_iteration = 0;
            foreach (var __tmp45 in __loop4_results)
            {
                ++__loop4_iteration;
                var __loop4_var1 = __tmp45.__loop4_var1;
                var stype = __tmp45.stype;
                __out.AppendLine(); //32:1
                string __tmp46Prefix = "	<xs:element name=\""; //33:1
                string __tmp47Suffix = "\"/>"; //33:80
                StringBuilder __tmp48 = new StringBuilder();
                __tmp48.Append(stype.GetXsdName());
                using(StreamReader __tmp48Reader = new StreamReader(this.__ToStream(__tmp48.ToString())))
                {
                    bool __tmp48_first = true;
                    while(__tmp48_first || !__tmp48Reader.EndOfStream)
                    {
                        __tmp48_first = false;
                        string __tmp48Line = __tmp48Reader.ReadLine();
                        if (__tmp48Line == null)
                        {
                            __tmp48Line = "";
                        }
                        __out.Append(__tmp46Prefix);
                        __out.Append(__tmp48Line);
                    }
                }
                string __tmp49Line = "\" type=\""; //33:40
                __out.Append(__tmp49Line);
                StringBuilder __tmp50 = new StringBuilder();
                __tmp50.Append(ns.Prefix);
                using(StreamReader __tmp50Reader = new StreamReader(this.__ToStream(__tmp50.ToString())))
                {
                    bool __tmp50_first = true;
                    while(__tmp50_first || !__tmp50Reader.EndOfStream)
                    {
                        __tmp50_first = false;
                        string __tmp50Line = __tmp50Reader.ReadLine();
                        if (__tmp50Line == null)
                        {
                            __tmp50Line = "";
                        }
                        __out.Append(__tmp50Line);
                    }
                }
                string __tmp51Line = ":"; //33:59
                __out.Append(__tmp51Line);
                StringBuilder __tmp52 = new StringBuilder();
                __tmp52.Append(stype.GetXsdName());
                using(StreamReader __tmp52Reader = new StreamReader(this.__ToStream(__tmp52.ToString())))
                {
                    bool __tmp52_first = true;
                    while(__tmp52_first || !__tmp52Reader.EndOfStream)
                    {
                        __tmp52_first = false;
                        string __tmp52Line = __tmp52Reader.ReadLine();
                        if (__tmp52Line == null)
                        {
                            __tmp52Line = "";
                        }
                        __out.Append(__tmp52Line);
                        __out.Append(__tmp47Suffix);
                        __out.AppendLine(); //33:83
                    }
                }
                string __tmp53Prefix = "	<xs:complexType name=\""; //34:1
                string __tmp54Suffix = "\">"; //34:44
                StringBuilder __tmp55 = new StringBuilder();
                __tmp55.Append(stype.GetXsdName());
                using(StreamReader __tmp55Reader = new StreamReader(this.__ToStream(__tmp55.ToString())))
                {
                    bool __tmp55_first = true;
                    while(__tmp55_first || !__tmp55Reader.EndOfStream)
                    {
                        __tmp55_first = false;
                        string __tmp55Line = __tmp55Reader.ReadLine();
                        if (__tmp55Line == null)
                        {
                            __tmp55Line = "";
                        }
                        __out.Append(__tmp53Prefix);
                        __out.Append(__tmp55Line);
                        __out.Append(__tmp54Suffix);
                        __out.AppendLine(); //34:46
                    }
                }
                __out.Append("		<xs:sequence>"); //35:1
                __out.AppendLine(); //35:16
                var __loop5_results = 
                    (from __loop5_var1 in __Enumerate((stype).GetEnumerator()) //36:10
                    from prop in __Enumerate((__loop5_var1.Properties).GetEnumerator()) //36:17
                    select new { __loop5_var1 = __loop5_var1, prop = prop}
                    ).ToList(); //36:5
                int __loop5_iteration = 0;
                foreach (var __tmp56 in __loop5_results)
                {
                    ++__loop5_iteration;
                    var __loop5_var1 = __tmp56.__loop5_var1;
                    var prop = __tmp56.prop;
                    string __tmp57Prefix = "			<xs:element name=\""; //37:1
                    string __tmp58Suffix = "\"/>"; //37:101
                    StringBuilder __tmp59 = new StringBuilder();
                    __tmp59.Append(prop.Name);
                    using(StreamReader __tmp59Reader = new StreamReader(this.__ToStream(__tmp59.ToString())))
                    {
                        bool __tmp59_first = true;
                        while(__tmp59_first || !__tmp59Reader.EndOfStream)
                        {
                            __tmp59_first = false;
                            string __tmp59Line = __tmp59Reader.ReadLine();
                            if (__tmp59Line == null)
                            {
                                __tmp59Line = "";
                            }
                            __out.Append(__tmp57Prefix);
                            __out.Append(__tmp59Line);
                        }
                    }
                    string __tmp60Line = "\" type=\""; //37:33
                    __out.Append(__tmp60Line);
                    StringBuilder __tmp61 = new StringBuilder();
                    __tmp61.Append(prop.Type.GetNamespace(ns).Prefix);
                    using(StreamReader __tmp61Reader = new StreamReader(this.__ToStream(__tmp61.ToString())))
                    {
                        bool __tmp61_first = true;
                        while(__tmp61_first || !__tmp61Reader.EndOfStream)
                        {
                            __tmp61_first = false;
                            string __tmp61Line = __tmp61Reader.ReadLine();
                            if (__tmp61Line == null)
                            {
                                __tmp61Line = "";
                            }
                            __out.Append(__tmp61Line);
                        }
                    }
                    string __tmp62Line = ":"; //37:76
                    __out.Append(__tmp62Line);
                    StringBuilder __tmp63 = new StringBuilder();
                    __tmp63.Append(prop.Type.GetXsdName());
                    using(StreamReader __tmp63Reader = new StreamReader(this.__ToStream(__tmp63.ToString())))
                    {
                        bool __tmp63_first = true;
                        while(__tmp63_first || !__tmp63Reader.EndOfStream)
                        {
                            __tmp63_first = false;
                            string __tmp63Line = __tmp63Reader.ReadLine();
                            if (__tmp63Line == null)
                            {
                                __tmp63Line = "";
                            }
                            __out.Append(__tmp63Line);
                            __out.Append(__tmp58Suffix);
                            __out.AppendLine(); //37:104
                        }
                    }
                }
                __out.Append("		</xs:sequence>"); //39:1
                __out.AppendLine(); //39:17
                __out.Append("	</xs:complexType>"); //40:1
                __out.AppendLine(); //40:19
            }
            var __loop6_results = 
                (from __loop6_var1 in __Enumerate((ns.Declarations).GetEnumerator()) //42:8
                from intf in __Enumerate((__loop6_var1).GetEnumerator()).OfType<Interface>() //42:25
                from op in __Enumerate((intf.Operations).GetEnumerator()) //42:49
                select new { __loop6_var1 = __loop6_var1, intf = intf, op = op}
                ).ToList(); //42:3
            int __loop6_iteration = 0;
            foreach (var __tmp64 in __loop6_results)
            {
                ++__loop6_iteration;
                var __loop6_var1 = __tmp64.__loop6_var1;
                var intf = __tmp64.intf;
                var op = __tmp64.op;
                __out.AppendLine(); //43:1
                string __tmp65Prefix = "	<xs:element name=\""; //44:1
                string __tmp66Suffix = "\"/>"; //44:58
                StringBuilder __tmp67 = new StringBuilder();
                __tmp67.Append(op.Name);
                using(StreamReader __tmp67Reader = new StreamReader(this.__ToStream(__tmp67.ToString())))
                {
                    bool __tmp67_first = true;
                    while(__tmp67_first || !__tmp67Reader.EndOfStream)
                    {
                        __tmp67_first = false;
                        string __tmp67Line = __tmp67Reader.ReadLine();
                        if (__tmp67Line == null)
                        {
                            __tmp67Line = "";
                        }
                        __out.Append(__tmp65Prefix);
                        __out.Append(__tmp67Line);
                    }
                }
                string __tmp68Line = "\" type=\""; //44:29
                __out.Append(__tmp68Line);
                StringBuilder __tmp69 = new StringBuilder();
                __tmp69.Append(ns.Prefix);
                using(StreamReader __tmp69Reader = new StreamReader(this.__ToStream(__tmp69.ToString())))
                {
                    bool __tmp69_first = true;
                    while(__tmp69_first || !__tmp69Reader.EndOfStream)
                    {
                        __tmp69_first = false;
                        string __tmp69Line = __tmp69Reader.ReadLine();
                        if (__tmp69Line == null)
                        {
                            __tmp69Line = "";
                        }
                        __out.Append(__tmp69Line);
                    }
                }
                string __tmp70Line = ":"; //44:48
                __out.Append(__tmp70Line);
                StringBuilder __tmp71 = new StringBuilder();
                __tmp71.Append(op.Name);
                using(StreamReader __tmp71Reader = new StreamReader(this.__ToStream(__tmp71.ToString())))
                {
                    bool __tmp71_first = true;
                    while(__tmp71_first || !__tmp71Reader.EndOfStream)
                    {
                        __tmp71_first = false;
                        string __tmp71Line = __tmp71Reader.ReadLine();
                        if (__tmp71Line == null)
                        {
                            __tmp71Line = "";
                        }
                        __out.Append(__tmp71Line);
                        __out.Append(__tmp66Suffix);
                        __out.AppendLine(); //44:61
                    }
                }
                string __tmp72Prefix = "	<xs:complexType name=\""; //45:1
                string __tmp73Suffix = "\">"; //45:33
                StringBuilder __tmp74 = new StringBuilder();
                __tmp74.Append(op.Name);
                using(StreamReader __tmp74Reader = new StreamReader(this.__ToStream(__tmp74.ToString())))
                {
                    bool __tmp74_first = true;
                    while(__tmp74_first || !__tmp74Reader.EndOfStream)
                    {
                        __tmp74_first = false;
                        string __tmp74Line = __tmp74Reader.ReadLine();
                        if (__tmp74Line == null)
                        {
                            __tmp74Line = "";
                        }
                        __out.Append(__tmp72Prefix);
                        __out.Append(__tmp74Line);
                        __out.Append(__tmp73Suffix);
                        __out.AppendLine(); //45:35
                    }
                }
                __out.Append("		<xs:sequence>"); //46:1
                __out.AppendLine(); //46:16
                var __loop7_results = 
                    (from __loop7_var1 in __Enumerate((op).GetEnumerator()) //47:10
                    from param in __Enumerate((__loop7_var1.Parameters).GetEnumerator()) //47:14
                    select new { __loop7_var1 = __loop7_var1, param = param}
                    ).ToList(); //47:5
                int __loop7_iteration = 0;
                foreach (var __tmp75 in __loop7_results)
                {
                    ++__loop7_iteration;
                    var __loop7_var1 = __tmp75.__loop7_var1;
                    var param = __tmp75.param;
                    string __tmp76Prefix = "			<xs:element name=\""; //48:1
                    string __tmp77Suffix = "\"/>"; //48:104
                    StringBuilder __tmp78 = new StringBuilder();
                    __tmp78.Append(param.Name);
                    using(StreamReader __tmp78Reader = new StreamReader(this.__ToStream(__tmp78.ToString())))
                    {
                        bool __tmp78_first = true;
                        while(__tmp78_first || !__tmp78Reader.EndOfStream)
                        {
                            __tmp78_first = false;
                            string __tmp78Line = __tmp78Reader.ReadLine();
                            if (__tmp78Line == null)
                            {
                                __tmp78Line = "";
                            }
                            __out.Append(__tmp76Prefix);
                            __out.Append(__tmp78Line);
                        }
                    }
                    string __tmp79Line = "\" type=\""; //48:34
                    __out.Append(__tmp79Line);
                    StringBuilder __tmp80 = new StringBuilder();
                    __tmp80.Append(param.Type.GetNamespace(ns).Prefix);
                    using(StreamReader __tmp80Reader = new StreamReader(this.__ToStream(__tmp80.ToString())))
                    {
                        bool __tmp80_first = true;
                        while(__tmp80_first || !__tmp80Reader.EndOfStream)
                        {
                            __tmp80_first = false;
                            string __tmp80Line = __tmp80Reader.ReadLine();
                            if (__tmp80Line == null)
                            {
                                __tmp80Line = "";
                            }
                            __out.Append(__tmp80Line);
                        }
                    }
                    string __tmp81Line = ":"; //48:78
                    __out.Append(__tmp81Line);
                    StringBuilder __tmp82 = new StringBuilder();
                    __tmp82.Append(param.Type.GetXsdName());
                    using(StreamReader __tmp82Reader = new StreamReader(this.__ToStream(__tmp82.ToString())))
                    {
                        bool __tmp82_first = true;
                        while(__tmp82_first || !__tmp82Reader.EndOfStream)
                        {
                            __tmp82_first = false;
                            string __tmp82Line = __tmp82Reader.ReadLine();
                            if (__tmp82Line == null)
                            {
                                __tmp82Line = "";
                            }
                            __out.Append(__tmp82Line);
                            __out.Append(__tmp77Suffix);
                            __out.AppendLine(); //48:107
                        }
                    }
                }
                __out.Append("		</xs:sequence>"); //50:1
                __out.AppendLine(); //50:17
                __out.Append("	</xs:complexType>"); //51:1
                __out.AppendLine(); //51:19
                if (!op.IsOneway) //52:4
                {
                    __out.AppendLine(); //53:1
                    string __tmp83Prefix = "	<xs:element name=\""; //54:1
                    string __tmp84Suffix = "\"/>"; //54:58
                    StringBuilder __tmp85 = new StringBuilder();
                    __tmp85.Append(op.Name);
                    using(StreamReader __tmp85Reader = new StreamReader(this.__ToStream(__tmp85.ToString())))
                    {
                        bool __tmp85_first = true;
                        while(__tmp85_first || !__tmp85Reader.EndOfStream)
                        {
                            __tmp85_first = false;
                            string __tmp85Line = __tmp85Reader.ReadLine();
                            if (__tmp85Line == null)
                            {
                                __tmp85Line = "";
                            }
                            __out.Append(__tmp83Prefix);
                            __out.Append(__tmp85Line);
                        }
                    }
                    string __tmp86Line = "\" type=\""; //54:29
                    __out.Append(__tmp86Line);
                    StringBuilder __tmp87 = new StringBuilder();
                    __tmp87.Append(ns.Prefix);
                    using(StreamReader __tmp87Reader = new StreamReader(this.__ToStream(__tmp87.ToString())))
                    {
                        bool __tmp87_first = true;
                        while(__tmp87_first || !__tmp87Reader.EndOfStream)
                        {
                            __tmp87_first = false;
                            string __tmp87Line = __tmp87Reader.ReadLine();
                            if (__tmp87Line == null)
                            {
                                __tmp87Line = "";
                            }
                            __out.Append(__tmp87Line);
                        }
                    }
                    string __tmp88Line = ":"; //54:48
                    __out.Append(__tmp88Line);
                    StringBuilder __tmp89 = new StringBuilder();
                    __tmp89.Append(op.Name);
                    using(StreamReader __tmp89Reader = new StreamReader(this.__ToStream(__tmp89.ToString())))
                    {
                        bool __tmp89_first = true;
                        while(__tmp89_first || !__tmp89Reader.EndOfStream)
                        {
                            __tmp89_first = false;
                            string __tmp89Line = __tmp89Reader.ReadLine();
                            if (__tmp89Line == null)
                            {
                                __tmp89Line = "";
                            }
                            __out.Append(__tmp89Line);
                            __out.Append(__tmp84Suffix);
                            __out.AppendLine(); //54:61
                        }
                    }
                    string __tmp90Prefix = "	<xs:complexType name=\""; //55:1
                    string __tmp91Suffix = "Response\">"; //55:33
                    StringBuilder __tmp92 = new StringBuilder();
                    __tmp92.Append(op.Name);
                    using(StreamReader __tmp92Reader = new StreamReader(this.__ToStream(__tmp92.ToString())))
                    {
                        bool __tmp92_first = true;
                        while(__tmp92_first || !__tmp92Reader.EndOfStream)
                        {
                            __tmp92_first = false;
                            string __tmp92Line = __tmp92Reader.ReadLine();
                            if (__tmp92Line == null)
                            {
                                __tmp92Line = "";
                            }
                            __out.Append(__tmp90Prefix);
                            __out.Append(__tmp92Line);
                            __out.Append(__tmp91Suffix);
                            __out.AppendLine(); //55:43
                        }
                    }
                    __out.Append("		<xs:sequence>"); //56:1
                    __out.AppendLine(); //56:16
                    string __tmp93Prefix = "			<xs:element name=\""; //57:1
                    string __tmp94Suffix = "\"/>"; //57:113
                    StringBuilder __tmp95 = new StringBuilder();
                    __tmp95.Append(op.Name);
                    using(StreamReader __tmp95Reader = new StreamReader(this.__ToStream(__tmp95.ToString())))
                    {
                        bool __tmp95_first = true;
                        while(__tmp95_first || !__tmp95Reader.EndOfStream)
                        {
                            __tmp95_first = false;
                            string __tmp95Line = __tmp95Reader.ReadLine();
                            if (__tmp95Line == null)
                            {
                                __tmp95Line = "";
                            }
                            __out.Append(__tmp93Prefix);
                            __out.Append(__tmp95Line);
                        }
                    }
                    string __tmp96Line = "Result\" type=\""; //57:31
                    __out.Append(__tmp96Line);
                    StringBuilder __tmp97 = new StringBuilder();
                    __tmp97.Append(op.ReturnType.GetNamespace(ns).Prefix);
                    using(StreamReader __tmp97Reader = new StreamReader(this.__ToStream(__tmp97.ToString())))
                    {
                        bool __tmp97_first = true;
                        while(__tmp97_first || !__tmp97Reader.EndOfStream)
                        {
                            __tmp97_first = false;
                            string __tmp97Line = __tmp97Reader.ReadLine();
                            if (__tmp97Line == null)
                            {
                                __tmp97Line = "";
                            }
                            __out.Append(__tmp97Line);
                        }
                    }
                    string __tmp98Line = ":"; //57:84
                    __out.Append(__tmp98Line);
                    StringBuilder __tmp99 = new StringBuilder();
                    __tmp99.Append(op.ReturnType.GetXsdName());
                    using(StreamReader __tmp99Reader = new StreamReader(this.__ToStream(__tmp99.ToString())))
                    {
                        bool __tmp99_first = true;
                        while(__tmp99_first || !__tmp99Reader.EndOfStream)
                        {
                            __tmp99_first = false;
                            string __tmp99Line = __tmp99Reader.ReadLine();
                            if (__tmp99Line == null)
                            {
                                __tmp99Line = "";
                            }
                            __out.Append(__tmp99Line);
                            __out.Append(__tmp94Suffix);
                            __out.AppendLine(); //57:116
                        }
                    }
                    __out.Append("		</xs:sequence>"); //58:1
                    __out.AppendLine(); //58:17
                    __out.Append("	</xs:complexType>"); //59:1
                    __out.AppendLine(); //59:19
                }
            }
            __out.Append("</xs:schema>"); //62:1
            __out.AppendLine(); //62:13
            return __out.ToString();
        }

    }
}
