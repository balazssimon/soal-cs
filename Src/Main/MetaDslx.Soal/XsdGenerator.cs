using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Soal //1:1
{
    using __Hidden_XsdGenerator_1335098446;
    namespace __Hidden_XsdGenerator_1335098446
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
            this.Properties = new __Properties();
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

        public __Properties Properties { get; private set; } //4:1

        public class __Properties //4:1
        {
            internal __Properties()
            {
                this.ImportXsd = true; //5:19
                this.XsdImportPrefix = ""; //6:27
            }
            public bool ImportXsd { get; set; } //5:2
            public string XsdImportPrefix { get; set; } //6:2
        }

        public string Generate(Namespace ns) //9:1
        {
            StringBuilder __out = new StringBuilder();
            __out.Append("<?xml version=\"1.0\" encoding=\"utf-8\"?>"); //10:1
            __out.AppendLine(); //10:39
            string __tmp1Prefix = "<xs:schema targetNamespace=\""; //11:1
            string __tmp2Suffix = "\""; //11:37
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
                    __out.AppendLine(); //11:38
                }
            }
            __out.Append("		xmlns:xs=\"http://www.w3.org/2001/XMLSchema\""); //12:1
            __out.AppendLine(); //12:46
            string __tmp4Prefix = "		xmlns:"; //13:1
            string __tmp5Suffix = "\""; //13:30
            StringBuilder __tmp6 = new StringBuilder();
            __tmp6.Append(ns.Prefix);
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
                }
            }
            string __tmp7Line = "=\""; //13:20
            __out.Append(__tmp7Line);
            StringBuilder __tmp8 = new StringBuilder();
            __tmp8.Append(ns.Uri);
            using(StreamReader __tmp8Reader = new StreamReader(this.__ToStream(__tmp8.ToString())))
            {
                bool __tmp8_first = true;
                while(__tmp8_first || !__tmp8Reader.EndOfStream)
                {
                    __tmp8_first = false;
                    string __tmp8Line = __tmp8Reader.ReadLine();
                    if (__tmp8Line == null)
                    {
                        __tmp8Line = "";
                    }
                    __out.Append(__tmp8Line);
                    __out.Append(__tmp5Suffix);
                    __out.AppendLine(); //13:31
                }
            }
            if (Properties.ImportXsd) //14:3
            {
                var __loop1_results = 
                    (from ins in __Enumerate((ns.GetImportedNamespaces()).GetEnumerator()) //15:9
                    select new { ins = ins}
                    ).ToList(); //15:4
                int __loop1_iteration = 0;
                foreach (var __tmp9 in __loop1_results)
                {
                    ++__loop1_iteration;
                    var ins = __tmp9.ins;
                    string __tmp10Prefix = "		xmlns:"; //16:1
                    string __tmp11Suffix = "\""; //16:32
                    StringBuilder __tmp12 = new StringBuilder();
                    __tmp12.Append(ins.Prefix);
                    using(StreamReader __tmp12Reader = new StreamReader(this.__ToStream(__tmp12.ToString())))
                    {
                        bool __tmp12_first = true;
                        while(__tmp12_first || !__tmp12Reader.EndOfStream)
                        {
                            __tmp12_first = false;
                            string __tmp12Line = __tmp12Reader.ReadLine();
                            if (__tmp12Line == null)
                            {
                                __tmp12Line = "";
                            }
                            __out.Append(__tmp10Prefix);
                            __out.Append(__tmp12Line);
                        }
                    }
                    string __tmp13Line = "=\""; //16:21
                    __out.Append(__tmp13Line);
                    StringBuilder __tmp14 = new StringBuilder();
                    __tmp14.Append(ins.Uri);
                    using(StreamReader __tmp14Reader = new StreamReader(this.__ToStream(__tmp14.ToString())))
                    {
                        bool __tmp14_first = true;
                        while(__tmp14_first || !__tmp14Reader.EndOfStream)
                        {
                            __tmp14_first = false;
                            string __tmp14Line = __tmp14Reader.ReadLine();
                            if (__tmp14Line == null)
                            {
                                __tmp14Line = "";
                            }
                            __out.Append(__tmp14Line);
                            __out.Append(__tmp11Suffix);
                            __out.AppendLine(); //16:33
                        }
                    }
                }
            }
            __out.Append("		elementFormDefault=\"qualified\">"); //19:1
            __out.AppendLine(); //19:34
            if (Properties.ImportXsd) //20:3
            {
                var __loop2_results = 
                    (from ins in __Enumerate((ns.GetImportedNamespaces()).GetEnumerator()) //21:9
                    select new { ins = ins}
                    ).ToList(); //21:4
                int __loop2_iteration = 0;
                foreach (var __tmp15 in __loop2_results)
                {
                    ++__loop2_iteration;
                    var ins = __tmp15.ins;
                    string __tmp16Prefix = "	<xs:import namespace=\""; //22:1
                    string __tmp17Suffix = ".xsd\"/>"; //22:93
                    StringBuilder __tmp18 = new StringBuilder();
                    __tmp18.Append(ins.Uri);
                    using(StreamReader __tmp18Reader = new StreamReader(this.__ToStream(__tmp18.ToString())))
                    {
                        bool __tmp18_first = true;
                        while(__tmp18_first || !__tmp18Reader.EndOfStream)
                        {
                            __tmp18_first = false;
                            string __tmp18Line = __tmp18Reader.ReadLine();
                            if (__tmp18Line == null)
                            {
                                __tmp18Line = "";
                            }
                            __out.Append(__tmp16Prefix);
                            __out.Append(__tmp18Line);
                        }
                    }
                    string __tmp19Line = "\" schemaLocation=\""; //22:33
                    __out.Append(__tmp19Line);
                    StringBuilder __tmp20 = new StringBuilder();
                    __tmp20.Append(Properties.XsdImportPrefix);
                    using(StreamReader __tmp20Reader = new StreamReader(this.__ToStream(__tmp20.ToString())))
                    {
                        bool __tmp20_first = true;
                        while(__tmp20_first || !__tmp20Reader.EndOfStream)
                        {
                            __tmp20_first = false;
                            string __tmp20Line = __tmp20Reader.ReadLine();
                            if (__tmp20Line == null)
                            {
                                __tmp20Line = "";
                            }
                            __out.Append(__tmp20Line);
                        }
                    }
                    StringBuilder __tmp21 = new StringBuilder();
                    __tmp21.Append(ins.FullName);
                    using(StreamReader __tmp21Reader = new StreamReader(this.__ToStream(__tmp21.ToString())))
                    {
                        bool __tmp21_first = true;
                        while(__tmp21_first || !__tmp21Reader.EndOfStream)
                        {
                            __tmp21_first = false;
                            string __tmp21Line = __tmp21Reader.ReadLine();
                            if (__tmp21Line == null)
                            {
                                __tmp21Line = "";
                            }
                            __out.Append(__tmp21Line);
                            __out.Append(__tmp17Suffix);
                            __out.AppendLine(); //22:100
                        }
                    }
                }
            }
            var __loop3_results = 
                (from arr in __Enumerate((ns.GetArrayTypes()).GetEnumerator()) //25:8
                select new { arr = arr}
                ).ToList(); //25:3
            int __loop3_iteration = 0;
            foreach (var __tmp22 in __loop3_results)
            {
                ++__loop3_iteration;
                var arr = __tmp22.arr;
                __out.AppendLine(); //26:1
                string __tmp23Prefix = "	<xs:element name=\""; //27:1
                string __tmp24Suffix = "\"/>"; //27:76
                StringBuilder __tmp25 = new StringBuilder();
                __tmp25.Append(arr.GetXsdName());
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
                string __tmp26Line = "\" type=\""; //27:38
                __out.Append(__tmp26Line);
                StringBuilder __tmp27 = new StringBuilder();
                __tmp27.Append(ns.Prefix);
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
                string __tmp28Line = ":"; //27:57
                __out.Append(__tmp28Line);
                StringBuilder __tmp29 = new StringBuilder();
                __tmp29.Append(arr.GetXsdName());
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
                        __out.AppendLine(); //27:79
                    }
                }
                string __tmp30Prefix = "	<xs:complexType name=\""; //28:1
                string __tmp31Suffix = "\">"; //28:42
                StringBuilder __tmp32 = new StringBuilder();
                __tmp32.Append(arr.GetXsdName());
                using(StreamReader __tmp32Reader = new StreamReader(this.__ToStream(__tmp32.ToString())))
                {
                    bool __tmp32_first = true;
                    while(__tmp32_first || !__tmp32Reader.EndOfStream)
                    {
                        __tmp32_first = false;
                        string __tmp32Line = __tmp32Reader.ReadLine();
                        if (__tmp32Line == null)
                        {
                            __tmp32Line = "";
                        }
                        __out.Append(__tmp30Prefix);
                        __out.Append(__tmp32Line);
                        __out.Append(__tmp31Suffix);
                        __out.AppendLine(); //28:44
                    }
                }
                __out.Append("		<xs:sequence>"); //29:1
                __out.AppendLine(); //29:16
                string __tmp33Prefix = "			<xs:element name=\""; //30:1
                string __tmp34Suffix = "\"/>"; //30:126
                StringBuilder __tmp35 = new StringBuilder();
                __tmp35.Append(arr.InnerType.GetXsdName());
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
                        __out.Append(__tmp33Prefix);
                        __out.Append(__tmp35Line);
                    }
                }
                string __tmp36Line = "\" type=\""; //30:50
                __out.Append(__tmp36Line);
                StringBuilder __tmp37 = new StringBuilder();
                __tmp37.Append(arr.InnerType.GetNamespace(ns).Prefix);
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
                    }
                }
                string __tmp38Line = ":"; //30:97
                __out.Append(__tmp38Line);
                StringBuilder __tmp39 = new StringBuilder();
                __tmp39.Append(arr.InnerType.GetXsdName());
                using(StreamReader __tmp39Reader = new StreamReader(this.__ToStream(__tmp39.ToString())))
                {
                    bool __tmp39_first = true;
                    while(__tmp39_first || !__tmp39Reader.EndOfStream)
                    {
                        __tmp39_first = false;
                        string __tmp39Line = __tmp39Reader.ReadLine();
                        if (__tmp39Line == null)
                        {
                            __tmp39Line = "";
                        }
                        __out.Append(__tmp39Line);
                        __out.Append(__tmp34Suffix);
                        __out.AppendLine(); //30:129
                    }
                }
                __out.Append("		</xs:sequence>"); //31:1
                __out.AppendLine(); //31:17
                __out.Append("	</xs:complexType>"); //32:1
                __out.AppendLine(); //32:19
            }
            var __loop4_results = 
                (from __loop4_var1 in __Enumerate((ns.Declarations).GetEnumerator()) //34:8
                from etype in __Enumerate((__loop4_var1).GetEnumerator()).OfType<Enum>() //34:25
                select new { __loop4_var1 = __loop4_var1, etype = etype}
                ).ToList(); //34:3
            int __loop4_iteration = 0;
            foreach (var __tmp40 in __loop4_results)
            {
                ++__loop4_iteration;
                var __loop4_var1 = __tmp40.__loop4_var1;
                var etype = __tmp40.etype;
                __out.AppendLine(); //35:1
                string __tmp41Prefix = "	<xs:element name=\""; //36:1
                string __tmp42Suffix = "\"/>"; //36:80
                StringBuilder __tmp43 = new StringBuilder();
                __tmp43.Append(etype.GetXsdName());
                using(StreamReader __tmp43Reader = new StreamReader(this.__ToStream(__tmp43.ToString())))
                {
                    bool __tmp43_first = true;
                    while(__tmp43_first || !__tmp43Reader.EndOfStream)
                    {
                        __tmp43_first = false;
                        string __tmp43Line = __tmp43Reader.ReadLine();
                        if (__tmp43Line == null)
                        {
                            __tmp43Line = "";
                        }
                        __out.Append(__tmp41Prefix);
                        __out.Append(__tmp43Line);
                    }
                }
                string __tmp44Line = "\" type=\""; //36:40
                __out.Append(__tmp44Line);
                StringBuilder __tmp45 = new StringBuilder();
                __tmp45.Append(ns.Prefix);
                using(StreamReader __tmp45Reader = new StreamReader(this.__ToStream(__tmp45.ToString())))
                {
                    bool __tmp45_first = true;
                    while(__tmp45_first || !__tmp45Reader.EndOfStream)
                    {
                        __tmp45_first = false;
                        string __tmp45Line = __tmp45Reader.ReadLine();
                        if (__tmp45Line == null)
                        {
                            __tmp45Line = "";
                        }
                        __out.Append(__tmp45Line);
                    }
                }
                string __tmp46Line = ":"; //36:59
                __out.Append(__tmp46Line);
                StringBuilder __tmp47 = new StringBuilder();
                __tmp47.Append(etype.GetXsdName());
                using(StreamReader __tmp47Reader = new StreamReader(this.__ToStream(__tmp47.ToString())))
                {
                    bool __tmp47_first = true;
                    while(__tmp47_first || !__tmp47Reader.EndOfStream)
                    {
                        __tmp47_first = false;
                        string __tmp47Line = __tmp47Reader.ReadLine();
                        if (__tmp47Line == null)
                        {
                            __tmp47Line = "";
                        }
                        __out.Append(__tmp47Line);
                        __out.Append(__tmp42Suffix);
                        __out.AppendLine(); //36:83
                    }
                }
                string __tmp48Prefix = "	<xs:simpleType name=\""; //37:1
                string __tmp49Suffix = "\">"; //37:43
                StringBuilder __tmp50 = new StringBuilder();
                __tmp50.Append(etype.GetXsdName());
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
                        __out.Append(__tmp48Prefix);
                        __out.Append(__tmp50Line);
                        __out.Append(__tmp49Suffix);
                        __out.AppendLine(); //37:45
                    }
                }
                __out.Append("		<xs:restriction base=\"xs:string\">"); //38:1
                __out.AppendLine(); //38:36
                var __loop5_results = 
                    (from __loop5_var1 in __Enumerate((etype).GetEnumerator()) //39:10
                    from elit in __Enumerate((__loop5_var1.EnumLiterals).GetEnumerator()) //39:17
                    select new { __loop5_var1 = __loop5_var1, elit = elit}
                    ).ToList(); //39:5
                int __loop5_iteration = 0;
                foreach (var __tmp51 in __loop5_results)
                {
                    ++__loop5_iteration;
                    var __loop5_var1 = __tmp51.__loop5_var1;
                    var elit = __tmp51.elit;
                    string __tmp52Prefix = "			<xs:enumeration value=\""; //40:1
                    string __tmp53Suffix = "\"/>"; //40:38
                    StringBuilder __tmp54 = new StringBuilder();
                    __tmp54.Append(elit.Name);
                    using(StreamReader __tmp54Reader = new StreamReader(this.__ToStream(__tmp54.ToString())))
                    {
                        bool __tmp54_first = true;
                        while(__tmp54_first || !__tmp54Reader.EndOfStream)
                        {
                            __tmp54_first = false;
                            string __tmp54Line = __tmp54Reader.ReadLine();
                            if (__tmp54Line == null)
                            {
                                __tmp54Line = "";
                            }
                            __out.Append(__tmp52Prefix);
                            __out.Append(__tmp54Line);
                            __out.Append(__tmp53Suffix);
                            __out.AppendLine(); //40:41
                        }
                    }
                }
                __out.Append("		</xs:restriction>"); //42:1
                __out.AppendLine(); //42:20
                __out.Append("	</xs:simpleType>"); //43:1
                __out.AppendLine(); //43:18
            }
            var __loop6_results = 
                (from __loop6_var1 in __Enumerate((ns.Declarations).GetEnumerator()) //45:8
                from stype in __Enumerate((__loop6_var1).GetEnumerator()).OfType<StructuredType>() //45:25
                select new { __loop6_var1 = __loop6_var1, stype = stype}
                ).ToList(); //45:3
            int __loop6_iteration = 0;
            foreach (var __tmp55 in __loop6_results)
            {
                ++__loop6_iteration;
                var __loop6_var1 = __tmp55.__loop6_var1;
                var stype = __tmp55.stype;
                __out.AppendLine(); //46:1
                string __tmp56Prefix = "	<xs:element name=\""; //47:1
                string __tmp57Suffix = "\"/>"; //47:80
                StringBuilder __tmp58 = new StringBuilder();
                __tmp58.Append(stype.GetXsdName());
                using(StreamReader __tmp58Reader = new StreamReader(this.__ToStream(__tmp58.ToString())))
                {
                    bool __tmp58_first = true;
                    while(__tmp58_first || !__tmp58Reader.EndOfStream)
                    {
                        __tmp58_first = false;
                        string __tmp58Line = __tmp58Reader.ReadLine();
                        if (__tmp58Line == null)
                        {
                            __tmp58Line = "";
                        }
                        __out.Append(__tmp56Prefix);
                        __out.Append(__tmp58Line);
                    }
                }
                string __tmp59Line = "\" type=\""; //47:40
                __out.Append(__tmp59Line);
                StringBuilder __tmp60 = new StringBuilder();
                __tmp60.Append(ns.Prefix);
                using(StreamReader __tmp60Reader = new StreamReader(this.__ToStream(__tmp60.ToString())))
                {
                    bool __tmp60_first = true;
                    while(__tmp60_first || !__tmp60Reader.EndOfStream)
                    {
                        __tmp60_first = false;
                        string __tmp60Line = __tmp60Reader.ReadLine();
                        if (__tmp60Line == null)
                        {
                            __tmp60Line = "";
                        }
                        __out.Append(__tmp60Line);
                    }
                }
                string __tmp61Line = ":"; //47:59
                __out.Append(__tmp61Line);
                StringBuilder __tmp62 = new StringBuilder();
                __tmp62.Append(stype.GetXsdName());
                using(StreamReader __tmp62Reader = new StreamReader(this.__ToStream(__tmp62.ToString())))
                {
                    bool __tmp62_first = true;
                    while(__tmp62_first || !__tmp62Reader.EndOfStream)
                    {
                        __tmp62_first = false;
                        string __tmp62Line = __tmp62Reader.ReadLine();
                        if (__tmp62Line == null)
                        {
                            __tmp62Line = "";
                        }
                        __out.Append(__tmp62Line);
                        __out.Append(__tmp57Suffix);
                        __out.AppendLine(); //47:83
                    }
                }
                string __tmp63Prefix = "	<xs:complexType name=\""; //48:1
                string __tmp64Suffix = "\">"; //48:44
                StringBuilder __tmp65 = new StringBuilder();
                __tmp65.Append(stype.GetXsdName());
                using(StreamReader __tmp65Reader = new StreamReader(this.__ToStream(__tmp65.ToString())))
                {
                    bool __tmp65_first = true;
                    while(__tmp65_first || !__tmp65Reader.EndOfStream)
                    {
                        __tmp65_first = false;
                        string __tmp65Line = __tmp65Reader.ReadLine();
                        if (__tmp65Line == null)
                        {
                            __tmp65Line = "";
                        }
                        __out.Append(__tmp63Prefix);
                        __out.Append(__tmp65Line);
                        __out.Append(__tmp64Suffix);
                        __out.AppendLine(); //48:46
                    }
                }
                __out.Append("		<xs:sequence>"); //49:1
                __out.AppendLine(); //49:16
                var __loop7_results = 
                    (from __loop7_var1 in __Enumerate((stype).GetEnumerator()) //50:10
                    from prop in __Enumerate((__loop7_var1.Properties).GetEnumerator()) //50:17
                    select new { __loop7_var1 = __loop7_var1, prop = prop}
                    ).ToList(); //50:5
                int __loop7_iteration = 0;
                foreach (var __tmp66 in __loop7_results)
                {
                    ++__loop7_iteration;
                    var __loop7_var1 = __tmp66.__loop7_var1;
                    var prop = __tmp66.prop;
                    string __tmp67Prefix = "			<xs:element name=\""; //51:1
                    string __tmp68Suffix = "\"/>"; //51:101
                    StringBuilder __tmp69 = new StringBuilder();
                    __tmp69.Append(prop.Name);
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
                            __out.Append(__tmp67Prefix);
                            __out.Append(__tmp69Line);
                        }
                    }
                    string __tmp70Line = "\" type=\""; //51:33
                    __out.Append(__tmp70Line);
                    StringBuilder __tmp71 = new StringBuilder();
                    __tmp71.Append(prop.Type.GetNamespace(ns).Prefix);
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
                        }
                    }
                    string __tmp72Line = ":"; //51:76
                    __out.Append(__tmp72Line);
                    StringBuilder __tmp73 = new StringBuilder();
                    __tmp73.Append(prop.Type.GetXsdName());
                    using(StreamReader __tmp73Reader = new StreamReader(this.__ToStream(__tmp73.ToString())))
                    {
                        bool __tmp73_first = true;
                        while(__tmp73_first || !__tmp73Reader.EndOfStream)
                        {
                            __tmp73_first = false;
                            string __tmp73Line = __tmp73Reader.ReadLine();
                            if (__tmp73Line == null)
                            {
                                __tmp73Line = "";
                            }
                            __out.Append(__tmp73Line);
                            __out.Append(__tmp68Suffix);
                            __out.AppendLine(); //51:104
                        }
                    }
                }
                __out.Append("		</xs:sequence>"); //53:1
                __out.AppendLine(); //53:17
                __out.Append("	</xs:complexType>"); //54:1
                __out.AppendLine(); //54:19
            }
            var __loop8_results = 
                (from __loop8_var1 in __Enumerate((ns.Declarations).GetEnumerator()) //56:8
                from intf in __Enumerate((__loop8_var1).GetEnumerator()).OfType<Interface>() //56:25
                from op in __Enumerate((intf.Operations).GetEnumerator()) //56:49
                select new { __loop8_var1 = __loop8_var1, intf = intf, op = op}
                ).ToList(); //56:3
            int __loop8_iteration = 0;
            foreach (var __tmp74 in __loop8_results)
            {
                ++__loop8_iteration;
                var __loop8_var1 = __tmp74.__loop8_var1;
                var intf = __tmp74.intf;
                var op = __tmp74.op;
                __out.AppendLine(); //57:1
                string __tmp75Prefix = "	<xs:element name=\""; //58:1
                string __tmp76Suffix = "\"/>"; //58:58
                StringBuilder __tmp77 = new StringBuilder();
                __tmp77.Append(op.Name);
                using(StreamReader __tmp77Reader = new StreamReader(this.__ToStream(__tmp77.ToString())))
                {
                    bool __tmp77_first = true;
                    while(__tmp77_first || !__tmp77Reader.EndOfStream)
                    {
                        __tmp77_first = false;
                        string __tmp77Line = __tmp77Reader.ReadLine();
                        if (__tmp77Line == null)
                        {
                            __tmp77Line = "";
                        }
                        __out.Append(__tmp75Prefix);
                        __out.Append(__tmp77Line);
                    }
                }
                string __tmp78Line = "\" type=\""; //58:29
                __out.Append(__tmp78Line);
                StringBuilder __tmp79 = new StringBuilder();
                __tmp79.Append(ns.Prefix);
                using(StreamReader __tmp79Reader = new StreamReader(this.__ToStream(__tmp79.ToString())))
                {
                    bool __tmp79_first = true;
                    while(__tmp79_first || !__tmp79Reader.EndOfStream)
                    {
                        __tmp79_first = false;
                        string __tmp79Line = __tmp79Reader.ReadLine();
                        if (__tmp79Line == null)
                        {
                            __tmp79Line = "";
                        }
                        __out.Append(__tmp79Line);
                    }
                }
                string __tmp80Line = ":"; //58:48
                __out.Append(__tmp80Line);
                StringBuilder __tmp81 = new StringBuilder();
                __tmp81.Append(op.Name);
                using(StreamReader __tmp81Reader = new StreamReader(this.__ToStream(__tmp81.ToString())))
                {
                    bool __tmp81_first = true;
                    while(__tmp81_first || !__tmp81Reader.EndOfStream)
                    {
                        __tmp81_first = false;
                        string __tmp81Line = __tmp81Reader.ReadLine();
                        if (__tmp81Line == null)
                        {
                            __tmp81Line = "";
                        }
                        __out.Append(__tmp81Line);
                        __out.Append(__tmp76Suffix);
                        __out.AppendLine(); //58:61
                    }
                }
                string __tmp82Prefix = "	<xs:complexType name=\""; //59:1
                string __tmp83Suffix = "\">"; //59:33
                StringBuilder __tmp84 = new StringBuilder();
                __tmp84.Append(op.Name);
                using(StreamReader __tmp84Reader = new StreamReader(this.__ToStream(__tmp84.ToString())))
                {
                    bool __tmp84_first = true;
                    while(__tmp84_first || !__tmp84Reader.EndOfStream)
                    {
                        __tmp84_first = false;
                        string __tmp84Line = __tmp84Reader.ReadLine();
                        if (__tmp84Line == null)
                        {
                            __tmp84Line = "";
                        }
                        __out.Append(__tmp82Prefix);
                        __out.Append(__tmp84Line);
                        __out.Append(__tmp83Suffix);
                        __out.AppendLine(); //59:35
                    }
                }
                __out.Append("		<xs:sequence>"); //60:1
                __out.AppendLine(); //60:16
                var __loop9_results = 
                    (from __loop9_var1 in __Enumerate((op).GetEnumerator()) //61:10
                    from param in __Enumerate((__loop9_var1.Parameters).GetEnumerator()) //61:14
                    select new { __loop9_var1 = __loop9_var1, param = param}
                    ).ToList(); //61:5
                int __loop9_iteration = 0;
                foreach (var __tmp85 in __loop9_results)
                {
                    ++__loop9_iteration;
                    var __loop9_var1 = __tmp85.__loop9_var1;
                    var param = __tmp85.param;
                    string __tmp86Prefix = "			<xs:element name=\""; //62:1
                    string __tmp87Suffix = "\"/>"; //62:104
                    StringBuilder __tmp88 = new StringBuilder();
                    __tmp88.Append(param.Name);
                    using(StreamReader __tmp88Reader = new StreamReader(this.__ToStream(__tmp88.ToString())))
                    {
                        bool __tmp88_first = true;
                        while(__tmp88_first || !__tmp88Reader.EndOfStream)
                        {
                            __tmp88_first = false;
                            string __tmp88Line = __tmp88Reader.ReadLine();
                            if (__tmp88Line == null)
                            {
                                __tmp88Line = "";
                            }
                            __out.Append(__tmp86Prefix);
                            __out.Append(__tmp88Line);
                        }
                    }
                    string __tmp89Line = "\" type=\""; //62:34
                    __out.Append(__tmp89Line);
                    StringBuilder __tmp90 = new StringBuilder();
                    __tmp90.Append(param.Type.GetNamespace(ns).Prefix);
                    using(StreamReader __tmp90Reader = new StreamReader(this.__ToStream(__tmp90.ToString())))
                    {
                        bool __tmp90_first = true;
                        while(__tmp90_first || !__tmp90Reader.EndOfStream)
                        {
                            __tmp90_first = false;
                            string __tmp90Line = __tmp90Reader.ReadLine();
                            if (__tmp90Line == null)
                            {
                                __tmp90Line = "";
                            }
                            __out.Append(__tmp90Line);
                        }
                    }
                    string __tmp91Line = ":"; //62:78
                    __out.Append(__tmp91Line);
                    StringBuilder __tmp92 = new StringBuilder();
                    __tmp92.Append(param.Type.GetXsdName());
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
                            __out.Append(__tmp92Line);
                            __out.Append(__tmp87Suffix);
                            __out.AppendLine(); //62:107
                        }
                    }
                }
                __out.Append("		</xs:sequence>"); //64:1
                __out.AppendLine(); //64:17
                __out.Append("	</xs:complexType>"); //65:1
                __out.AppendLine(); //65:19
                if (!op.IsOneway) //66:4
                {
                    __out.AppendLine(); //67:1
                    string __tmp93Prefix = "	<xs:element name=\""; //68:1
                    string __tmp94Suffix = "Response\"/>"; //68:66
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
                    string __tmp96Line = "Response\" type=\""; //68:29
                    __out.Append(__tmp96Line);
                    StringBuilder __tmp97 = new StringBuilder();
                    __tmp97.Append(ns.Prefix);
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
                    string __tmp98Line = ":"; //68:56
                    __out.Append(__tmp98Line);
                    StringBuilder __tmp99 = new StringBuilder();
                    __tmp99.Append(op.Name);
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
                            __out.AppendLine(); //68:77
                        }
                    }
                    string __tmp100Prefix = "	<xs:complexType name=\""; //69:1
                    string __tmp101Suffix = "Response\">"; //69:33
                    StringBuilder __tmp102 = new StringBuilder();
                    __tmp102.Append(op.Name);
                    using(StreamReader __tmp102Reader = new StreamReader(this.__ToStream(__tmp102.ToString())))
                    {
                        bool __tmp102_first = true;
                        while(__tmp102_first || !__tmp102Reader.EndOfStream)
                        {
                            __tmp102_first = false;
                            string __tmp102Line = __tmp102Reader.ReadLine();
                            if (__tmp102Line == null)
                            {
                                __tmp102Line = "";
                            }
                            __out.Append(__tmp100Prefix);
                            __out.Append(__tmp102Line);
                            __out.Append(__tmp101Suffix);
                            __out.AppendLine(); //69:43
                        }
                    }
                    __out.Append("		<xs:sequence>"); //70:1
                    __out.AppendLine(); //70:16
                    string __tmp103Prefix = "			<xs:element name=\""; //71:1
                    string __tmp104Suffix = "\"/>"; //71:113
                    StringBuilder __tmp105 = new StringBuilder();
                    __tmp105.Append(op.Name);
                    using(StreamReader __tmp105Reader = new StreamReader(this.__ToStream(__tmp105.ToString())))
                    {
                        bool __tmp105_first = true;
                        while(__tmp105_first || !__tmp105Reader.EndOfStream)
                        {
                            __tmp105_first = false;
                            string __tmp105Line = __tmp105Reader.ReadLine();
                            if (__tmp105Line == null)
                            {
                                __tmp105Line = "";
                            }
                            __out.Append(__tmp103Prefix);
                            __out.Append(__tmp105Line);
                        }
                    }
                    string __tmp106Line = "Result\" type=\""; //71:31
                    __out.Append(__tmp106Line);
                    StringBuilder __tmp107 = new StringBuilder();
                    __tmp107.Append(op.ReturnType.GetNamespace(ns).Prefix);
                    using(StreamReader __tmp107Reader = new StreamReader(this.__ToStream(__tmp107.ToString())))
                    {
                        bool __tmp107_first = true;
                        while(__tmp107_first || !__tmp107Reader.EndOfStream)
                        {
                            __tmp107_first = false;
                            string __tmp107Line = __tmp107Reader.ReadLine();
                            if (__tmp107Line == null)
                            {
                                __tmp107Line = "";
                            }
                            __out.Append(__tmp107Line);
                        }
                    }
                    string __tmp108Line = ":"; //71:84
                    __out.Append(__tmp108Line);
                    StringBuilder __tmp109 = new StringBuilder();
                    __tmp109.Append(op.ReturnType.GetXsdName());
                    using(StreamReader __tmp109Reader = new StreamReader(this.__ToStream(__tmp109.ToString())))
                    {
                        bool __tmp109_first = true;
                        while(__tmp109_first || !__tmp109Reader.EndOfStream)
                        {
                            __tmp109_first = false;
                            string __tmp109Line = __tmp109Reader.ReadLine();
                            if (__tmp109Line == null)
                            {
                                __tmp109Line = "";
                            }
                            __out.Append(__tmp109Line);
                            __out.Append(__tmp104Suffix);
                            __out.AppendLine(); //71:116
                        }
                    }
                    __out.Append("		</xs:sequence>"); //72:1
                    __out.AppendLine(); //72:17
                    __out.Append("	</xs:complexType>"); //73:1
                    __out.AppendLine(); //73:19
                }
            }
            __out.Append("</xs:schema>"); //76:1
            __out.AppendLine(); //76:13
            return __out.ToString();
        }

    }
}
