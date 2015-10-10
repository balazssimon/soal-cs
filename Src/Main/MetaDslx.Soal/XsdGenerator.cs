using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Soal //1:1
{
    using __Hidden_XsdGenerator_289392549;
    namespace __Hidden_XsdGenerator_289392549
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
                string __tmp34Suffix = "\" minOccurs=\"0\" maxOccurs=\"unbounded\"/>"; //30:169
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
                    }
                }
                string __tmp40Line = "\" nillable=\""; //30:126
                __out.Append(__tmp40Line);
                StringBuilder __tmp41 = new StringBuilder();
                __tmp41.Append(arr.InnerType.IsNullableXsd());
                using(StreamReader __tmp41Reader = new StreamReader(this.__ToStream(__tmp41.ToString())))
                {
                    bool __tmp41_first = true;
                    while(__tmp41_first || !__tmp41Reader.EndOfStream)
                    {
                        __tmp41_first = false;
                        string __tmp41Line = __tmp41Reader.ReadLine();
                        if (__tmp41Line == null)
                        {
                            __tmp41Line = "";
                        }
                        __out.Append(__tmp41Line);
                        __out.Append(__tmp34Suffix);
                        __out.AppendLine(); //30:208
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
            foreach (var __tmp42 in __loop4_results)
            {
                ++__loop4_iteration;
                var __loop4_var1 = __tmp42.__loop4_var1;
                var etype = __tmp42.etype;
                __out.AppendLine(); //35:1
                string __tmp43Prefix = "	<xs:element name=\""; //36:1
                string __tmp44Suffix = "\"/>"; //36:80
                StringBuilder __tmp45 = new StringBuilder();
                __tmp45.Append(etype.GetXsdName());
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
                        __out.Append(__tmp43Prefix);
                        __out.Append(__tmp45Line);
                    }
                }
                string __tmp46Line = "\" type=\""; //36:40
                __out.Append(__tmp46Line);
                StringBuilder __tmp47 = new StringBuilder();
                __tmp47.Append(ns.Prefix);
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
                    }
                }
                string __tmp48Line = ":"; //36:59
                __out.Append(__tmp48Line);
                StringBuilder __tmp49 = new StringBuilder();
                __tmp49.Append(etype.GetXsdName());
                using(StreamReader __tmp49Reader = new StreamReader(this.__ToStream(__tmp49.ToString())))
                {
                    bool __tmp49_first = true;
                    while(__tmp49_first || !__tmp49Reader.EndOfStream)
                    {
                        __tmp49_first = false;
                        string __tmp49Line = __tmp49Reader.ReadLine();
                        if (__tmp49Line == null)
                        {
                            __tmp49Line = "";
                        }
                        __out.Append(__tmp49Line);
                        __out.Append(__tmp44Suffix);
                        __out.AppendLine(); //36:83
                    }
                }
                string __tmp50Prefix = "	<xs:simpleType name=\""; //37:1
                string __tmp51Suffix = "\">"; //37:43
                StringBuilder __tmp52 = new StringBuilder();
                __tmp52.Append(etype.GetXsdName());
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
                        __out.Append(__tmp50Prefix);
                        __out.Append(__tmp52Line);
                        __out.Append(__tmp51Suffix);
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
                foreach (var __tmp53 in __loop5_results)
                {
                    ++__loop5_iteration;
                    var __loop5_var1 = __tmp53.__loop5_var1;
                    var elit = __tmp53.elit;
                    string __tmp54Prefix = "			<xs:enumeration value=\""; //40:1
                    string __tmp55Suffix = "\"/>"; //40:38
                    StringBuilder __tmp56 = new StringBuilder();
                    __tmp56.Append(elit.Name);
                    using(StreamReader __tmp56Reader = new StreamReader(this.__ToStream(__tmp56.ToString())))
                    {
                        bool __tmp56_first = true;
                        while(__tmp56_first || !__tmp56Reader.EndOfStream)
                        {
                            __tmp56_first = false;
                            string __tmp56Line = __tmp56Reader.ReadLine();
                            if (__tmp56Line == null)
                            {
                                __tmp56Line = "";
                            }
                            __out.Append(__tmp54Prefix);
                            __out.Append(__tmp56Line);
                            __out.Append(__tmp55Suffix);
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
            foreach (var __tmp57 in __loop6_results)
            {
                ++__loop6_iteration;
                var __loop6_var1 = __tmp57.__loop6_var1;
                var stype = __tmp57.stype;
                __out.AppendLine(); //46:1
                string __tmp58Prefix = "	<xs:element name=\""; //47:1
                string __tmp59Suffix = "\"/>"; //47:80
                StringBuilder __tmp60 = new StringBuilder();
                __tmp60.Append(stype.GetXsdName());
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
                        __out.Append(__tmp58Prefix);
                        __out.Append(__tmp60Line);
                    }
                }
                string __tmp61Line = "\" type=\""; //47:40
                __out.Append(__tmp61Line);
                StringBuilder __tmp62 = new StringBuilder();
                __tmp62.Append(ns.Prefix);
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
                    }
                }
                string __tmp63Line = ":"; //47:59
                __out.Append(__tmp63Line);
                StringBuilder __tmp64 = new StringBuilder();
                __tmp64.Append(stype.GetXsdName());
                using(StreamReader __tmp64Reader = new StreamReader(this.__ToStream(__tmp64.ToString())))
                {
                    bool __tmp64_first = true;
                    while(__tmp64_first || !__tmp64Reader.EndOfStream)
                    {
                        __tmp64_first = false;
                        string __tmp64Line = __tmp64Reader.ReadLine();
                        if (__tmp64Line == null)
                        {
                            __tmp64Line = "";
                        }
                        __out.Append(__tmp64Line);
                        __out.Append(__tmp59Suffix);
                        __out.AppendLine(); //47:83
                    }
                }
                string __tmp65Prefix = "	<xs:complexType name=\""; //48:1
                string __tmp66Suffix = "\">"; //48:44
                StringBuilder __tmp67 = new StringBuilder();
                __tmp67.Append(stype.GetXsdName());
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
                        __out.Append(__tmp66Suffix);
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
                foreach (var __tmp68 in __loop7_results)
                {
                    ++__loop7_iteration;
                    var __loop7_var1 = __tmp68.__loop7_var1;
                    var prop = __tmp68.prop;
                    string __tmp69Prefix = "			<xs:element name=\""; //51:1
                    string __tmp70Suffix = "\"/>"; //51:140
                    StringBuilder __tmp71 = new StringBuilder();
                    __tmp71.Append(prop.Name);
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
                            __out.Append(__tmp69Prefix);
                            __out.Append(__tmp71Line);
                        }
                    }
                    string __tmp72Line = "\" type=\""; //51:33
                    __out.Append(__tmp72Line);
                    StringBuilder __tmp73 = new StringBuilder();
                    __tmp73.Append(prop.Type.GetNamespace(ns).Prefix);
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
                        }
                    }
                    string __tmp74Line = ":"; //51:76
                    __out.Append(__tmp74Line);
                    StringBuilder __tmp75 = new StringBuilder();
                    __tmp75.Append(prop.Type.GetXsdName());
                    using(StreamReader __tmp75Reader = new StreamReader(this.__ToStream(__tmp75.ToString())))
                    {
                        bool __tmp75_first = true;
                        while(__tmp75_first || !__tmp75Reader.EndOfStream)
                        {
                            __tmp75_first = false;
                            string __tmp75Line = __tmp75Reader.ReadLine();
                            if (__tmp75Line == null)
                            {
                                __tmp75Line = "";
                            }
                            __out.Append(__tmp75Line);
                        }
                    }
                    string __tmp76Line = "\" nillable=\""; //51:101
                    __out.Append(__tmp76Line);
                    StringBuilder __tmp77 = new StringBuilder();
                    __tmp77.Append(prop.Type.IsNullableXsd());
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
                            __out.Append(__tmp77Line);
                            __out.Append(__tmp70Suffix);
                            __out.AppendLine(); //51:143
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
            foreach (var __tmp78 in __loop8_results)
            {
                ++__loop8_iteration;
                var __loop8_var1 = __tmp78.__loop8_var1;
                var intf = __tmp78.intf;
                var op = __tmp78.op;
                __out.AppendLine(); //57:1
                string __tmp79Prefix = "	<xs:element name=\""; //58:1
                string __tmp80Suffix = "\"/>"; //58:58
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
                        __out.Append(__tmp79Prefix);
                        __out.Append(__tmp81Line);
                    }
                }
                string __tmp82Line = "\" type=\""; //58:29
                __out.Append(__tmp82Line);
                StringBuilder __tmp83 = new StringBuilder();
                __tmp83.Append(ns.Prefix);
                using(StreamReader __tmp83Reader = new StreamReader(this.__ToStream(__tmp83.ToString())))
                {
                    bool __tmp83_first = true;
                    while(__tmp83_first || !__tmp83Reader.EndOfStream)
                    {
                        __tmp83_first = false;
                        string __tmp83Line = __tmp83Reader.ReadLine();
                        if (__tmp83Line == null)
                        {
                            __tmp83Line = "";
                        }
                        __out.Append(__tmp83Line);
                    }
                }
                string __tmp84Line = ":"; //58:48
                __out.Append(__tmp84Line);
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
                        __out.Append(__tmp85Line);
                        __out.Append(__tmp80Suffix);
                        __out.AppendLine(); //58:61
                    }
                }
                string __tmp86Prefix = "	<xs:complexType name=\""; //59:1
                string __tmp87Suffix = "\">"; //59:33
                StringBuilder __tmp88 = new StringBuilder();
                __tmp88.Append(op.Name);
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
                        __out.Append(__tmp87Suffix);
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
                foreach (var __tmp89 in __loop9_results)
                {
                    ++__loop9_iteration;
                    var __loop9_var1 = __tmp89.__loop9_var1;
                    var param = __tmp89.param;
                    string __tmp90Prefix = "			<xs:element name=\""; //62:1
                    string __tmp91Suffix = "\"/>"; //62:144
                    StringBuilder __tmp92 = new StringBuilder();
                    __tmp92.Append(param.Name);
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
                        }
                    }
                    string __tmp93Line = "\" type=\""; //62:34
                    __out.Append(__tmp93Line);
                    StringBuilder __tmp94 = new StringBuilder();
                    __tmp94.Append(param.Type.GetNamespace(ns).Prefix);
                    using(StreamReader __tmp94Reader = new StreamReader(this.__ToStream(__tmp94.ToString())))
                    {
                        bool __tmp94_first = true;
                        while(__tmp94_first || !__tmp94Reader.EndOfStream)
                        {
                            __tmp94_first = false;
                            string __tmp94Line = __tmp94Reader.ReadLine();
                            if (__tmp94Line == null)
                            {
                                __tmp94Line = "";
                            }
                            __out.Append(__tmp94Line);
                        }
                    }
                    string __tmp95Line = ":"; //62:78
                    __out.Append(__tmp95Line);
                    StringBuilder __tmp96 = new StringBuilder();
                    __tmp96.Append(param.Type.GetXsdName());
                    using(StreamReader __tmp96Reader = new StreamReader(this.__ToStream(__tmp96.ToString())))
                    {
                        bool __tmp96_first = true;
                        while(__tmp96_first || !__tmp96Reader.EndOfStream)
                        {
                            __tmp96_first = false;
                            string __tmp96Line = __tmp96Reader.ReadLine();
                            if (__tmp96Line == null)
                            {
                                __tmp96Line = "";
                            }
                            __out.Append(__tmp96Line);
                        }
                    }
                    string __tmp97Line = "\" nillable=\""; //62:104
                    __out.Append(__tmp97Line);
                    StringBuilder __tmp98 = new StringBuilder();
                    __tmp98.Append(param.Type.IsNullableXsd());
                    using(StreamReader __tmp98Reader = new StreamReader(this.__ToStream(__tmp98.ToString())))
                    {
                        bool __tmp98_first = true;
                        while(__tmp98_first || !__tmp98Reader.EndOfStream)
                        {
                            __tmp98_first = false;
                            string __tmp98Line = __tmp98Reader.ReadLine();
                            if (__tmp98Line == null)
                            {
                                __tmp98Line = "";
                            }
                            __out.Append(__tmp98Line);
                            __out.Append(__tmp91Suffix);
                            __out.AppendLine(); //62:147
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
                    string __tmp99Prefix = "	<xs:element name=\""; //68:1
                    string __tmp100Suffix = "Response\"/>"; //68:66
                    StringBuilder __tmp101 = new StringBuilder();
                    __tmp101.Append(op.Name);
                    using(StreamReader __tmp101Reader = new StreamReader(this.__ToStream(__tmp101.ToString())))
                    {
                        bool __tmp101_first = true;
                        while(__tmp101_first || !__tmp101Reader.EndOfStream)
                        {
                            __tmp101_first = false;
                            string __tmp101Line = __tmp101Reader.ReadLine();
                            if (__tmp101Line == null)
                            {
                                __tmp101Line = "";
                            }
                            __out.Append(__tmp99Prefix);
                            __out.Append(__tmp101Line);
                        }
                    }
                    string __tmp102Line = "Response\" type=\""; //68:29
                    __out.Append(__tmp102Line);
                    StringBuilder __tmp103 = new StringBuilder();
                    __tmp103.Append(ns.Prefix);
                    using(StreamReader __tmp103Reader = new StreamReader(this.__ToStream(__tmp103.ToString())))
                    {
                        bool __tmp103_first = true;
                        while(__tmp103_first || !__tmp103Reader.EndOfStream)
                        {
                            __tmp103_first = false;
                            string __tmp103Line = __tmp103Reader.ReadLine();
                            if (__tmp103Line == null)
                            {
                                __tmp103Line = "";
                            }
                            __out.Append(__tmp103Line);
                        }
                    }
                    string __tmp104Line = ":"; //68:56
                    __out.Append(__tmp104Line);
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
                            __out.Append(__tmp105Line);
                            __out.Append(__tmp100Suffix);
                            __out.AppendLine(); //68:77
                        }
                    }
                    string __tmp106Prefix = "	<xs:complexType name=\""; //69:1
                    string __tmp107Suffix = "Response\">"; //69:33
                    StringBuilder __tmp108 = new StringBuilder();
                    __tmp108.Append(op.Name);
                    using(StreamReader __tmp108Reader = new StreamReader(this.__ToStream(__tmp108.ToString())))
                    {
                        bool __tmp108_first = true;
                        while(__tmp108_first || !__tmp108Reader.EndOfStream)
                        {
                            __tmp108_first = false;
                            string __tmp108Line = __tmp108Reader.ReadLine();
                            if (__tmp108Line == null)
                            {
                                __tmp108Line = "";
                            }
                            __out.Append(__tmp106Prefix);
                            __out.Append(__tmp108Line);
                            __out.Append(__tmp107Suffix);
                            __out.AppendLine(); //69:43
                        }
                    }
                    if (op.ReturnType == SoalInstance.Void) //70:5
                    {
                        __out.Append("		<xs:sequence/>"); //71:1
                        __out.AppendLine(); //71:17
                    }
                    else //72:5
                    {
                        __out.Append("		<xs:sequence>"); //73:1
                        __out.AppendLine(); //73:16
                        string __tmp109Prefix = "			<xs:element name=\""; //74:1
                        string __tmp110Suffix = "\"/>"; //74:156
                        StringBuilder __tmp111 = new StringBuilder();
                        __tmp111.Append(op.Name);
                        using(StreamReader __tmp111Reader = new StreamReader(this.__ToStream(__tmp111.ToString())))
                        {
                            bool __tmp111_first = true;
                            while(__tmp111_first || !__tmp111Reader.EndOfStream)
                            {
                                __tmp111_first = false;
                                string __tmp111Line = __tmp111Reader.ReadLine();
                                if (__tmp111Line == null)
                                {
                                    __tmp111Line = "";
                                }
                                __out.Append(__tmp109Prefix);
                                __out.Append(__tmp111Line);
                            }
                        }
                        string __tmp112Line = "Result\" type=\""; //74:31
                        __out.Append(__tmp112Line);
                        StringBuilder __tmp113 = new StringBuilder();
                        __tmp113.Append(op.ReturnType.GetNamespace(ns).Prefix);
                        using(StreamReader __tmp113Reader = new StreamReader(this.__ToStream(__tmp113.ToString())))
                        {
                            bool __tmp113_first = true;
                            while(__tmp113_first || !__tmp113Reader.EndOfStream)
                            {
                                __tmp113_first = false;
                                string __tmp113Line = __tmp113Reader.ReadLine();
                                if (__tmp113Line == null)
                                {
                                    __tmp113Line = "";
                                }
                                __out.Append(__tmp113Line);
                            }
                        }
                        string __tmp114Line = ":"; //74:84
                        __out.Append(__tmp114Line);
                        StringBuilder __tmp115 = new StringBuilder();
                        __tmp115.Append(op.ReturnType.GetXsdName());
                        using(StreamReader __tmp115Reader = new StreamReader(this.__ToStream(__tmp115.ToString())))
                        {
                            bool __tmp115_first = true;
                            while(__tmp115_first || !__tmp115Reader.EndOfStream)
                            {
                                __tmp115_first = false;
                                string __tmp115Line = __tmp115Reader.ReadLine();
                                if (__tmp115Line == null)
                                {
                                    __tmp115Line = "";
                                }
                                __out.Append(__tmp115Line);
                            }
                        }
                        string __tmp116Line = "\" nillable=\""; //74:113
                        __out.Append(__tmp116Line);
                        StringBuilder __tmp117 = new StringBuilder();
                        __tmp117.Append(op.ReturnType.IsNullableXsd());
                        using(StreamReader __tmp117Reader = new StreamReader(this.__ToStream(__tmp117.ToString())))
                        {
                            bool __tmp117_first = true;
                            while(__tmp117_first || !__tmp117Reader.EndOfStream)
                            {
                                __tmp117_first = false;
                                string __tmp117Line = __tmp117Reader.ReadLine();
                                if (__tmp117Line == null)
                                {
                                    __tmp117Line = "";
                                }
                                __out.Append(__tmp117Line);
                                __out.Append(__tmp110Suffix);
                                __out.AppendLine(); //74:159
                            }
                        }
                        __out.Append("		</xs:sequence>"); //75:1
                        __out.AppendLine(); //75:17
                    }
                    __out.Append("	</xs:complexType>"); //77:1
                    __out.AppendLine(); //77:19
                }
            }
            __out.Append("</xs:schema>"); //80:1
            __out.AppendLine(); //80:13
            return __out.ToString();
        }

    }
}
