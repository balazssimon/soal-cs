using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Soal //1:1
{
    using __Hidden_XsdGenerator_2127638323;
    namespace __Hidden_XsdGenerator_2127638323
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
            }
            public bool ImportXsd { get; set; } //5:2
        }

        public string Generate(Namespace ns) //8:1
        {
            StringBuilder __out = new StringBuilder();
            __out.Append("<?xml version=\"1.0\" encoding=\"utf-8\"?>"); //9:1
            __out.AppendLine(); //9:39
            string __tmp1Prefix = "<xs:schema targetNamespace=\""; //10:1
            string __tmp2Suffix = "\""; //10:37
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
                    __out.AppendLine(); //10:38
                }
            }
            __out.Append("		xmlns:xs=\"http://www.w3.org/2001/XMLSchema\""); //11:1
            __out.AppendLine(); //11:46
            string __tmp4Prefix = "		xmlns:"; //12:1
            string __tmp5Suffix = "\""; //12:30
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
            string __tmp7Line = "=\""; //12:20
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
                    __out.AppendLine(); //12:31
                }
            }
            if (Properties.ImportXsd) //13:3
            {
                var __loop1_results = 
                    (from ins in __Enumerate((ns.GetImportedNamespaces()).GetEnumerator()) //14:9
                    select new { ins = ins}
                    ).ToList(); //14:4
                int __loop1_iteration = 0;
                foreach (var __tmp9 in __loop1_results)
                {
                    ++__loop1_iteration;
                    var ins = __tmp9.ins;
                    string __tmp10Prefix = "		xmlns:"; //15:1
                    string __tmp11Suffix = "\""; //15:32
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
                    string __tmp13Line = "=\""; //15:21
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
                            __out.AppendLine(); //15:33
                        }
                    }
                }
            }
            __out.Append("		elementFormDefault=\"qualified\">"); //18:1
            __out.AppendLine(); //18:34
            if (Properties.ImportXsd) //19:3
            {
                var __loop2_results = 
                    (from ins in __Enumerate((ns.GetImportedNamespaces()).GetEnumerator()) //20:9
                    select new { ins = ins}
                    ).ToList(); //20:4
                int __loop2_iteration = 0;
                foreach (var __tmp15 in __loop2_results)
                {
                    ++__loop2_iteration;
                    var ins = __tmp15.ins;
                    string __tmp16Prefix = "	<xs:import namespace=\""; //21:1
                    string __tmp17Suffix = ".xsd\"/>"; //21:65
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
                    string __tmp19Line = "\" schemaLocation=\""; //21:33
                    __out.Append(__tmp19Line);
                    StringBuilder __tmp20 = new StringBuilder();
                    __tmp20.Append(ins.FullName);
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
                            __out.Append(__tmp17Suffix);
                            __out.AppendLine(); //21:72
                        }
                    }
                }
            }
            var __loop3_results = 
                (from arr in __Enumerate((ns.GetArrayTypes()).GetEnumerator()) //24:8
                select new { arr = arr}
                ).ToList(); //24:3
            int __loop3_iteration = 0;
            foreach (var __tmp21 in __loop3_results)
            {
                ++__loop3_iteration;
                var arr = __tmp21.arr;
                __out.AppendLine(); //25:1
                string __tmp22Prefix = "	<xs:element name=\""; //26:1
                string __tmp23Suffix = "\"/>"; //26:76
                StringBuilder __tmp24 = new StringBuilder();
                __tmp24.Append(arr.GetXsdName());
                using(StreamReader __tmp24Reader = new StreamReader(this.__ToStream(__tmp24.ToString())))
                {
                    bool __tmp24_first = true;
                    while(__tmp24_first || !__tmp24Reader.EndOfStream)
                    {
                        __tmp24_first = false;
                        string __tmp24Line = __tmp24Reader.ReadLine();
                        if (__tmp24Line == null)
                        {
                            __tmp24Line = "";
                        }
                        __out.Append(__tmp22Prefix);
                        __out.Append(__tmp24Line);
                    }
                }
                string __tmp25Line = "\" type=\""; //26:38
                __out.Append(__tmp25Line);
                StringBuilder __tmp26 = new StringBuilder();
                __tmp26.Append(ns.Prefix);
                using(StreamReader __tmp26Reader = new StreamReader(this.__ToStream(__tmp26.ToString())))
                {
                    bool __tmp26_first = true;
                    while(__tmp26_first || !__tmp26Reader.EndOfStream)
                    {
                        __tmp26_first = false;
                        string __tmp26Line = __tmp26Reader.ReadLine();
                        if (__tmp26Line == null)
                        {
                            __tmp26Line = "";
                        }
                        __out.Append(__tmp26Line);
                    }
                }
                string __tmp27Line = ":"; //26:57
                __out.Append(__tmp27Line);
                StringBuilder __tmp28 = new StringBuilder();
                __tmp28.Append(arr.GetXsdName());
                using(StreamReader __tmp28Reader = new StreamReader(this.__ToStream(__tmp28.ToString())))
                {
                    bool __tmp28_first = true;
                    while(__tmp28_first || !__tmp28Reader.EndOfStream)
                    {
                        __tmp28_first = false;
                        string __tmp28Line = __tmp28Reader.ReadLine();
                        if (__tmp28Line == null)
                        {
                            __tmp28Line = "";
                        }
                        __out.Append(__tmp28Line);
                        __out.Append(__tmp23Suffix);
                        __out.AppendLine(); //26:79
                    }
                }
                string __tmp29Prefix = "	<xs:complexType name=\""; //27:1
                string __tmp30Suffix = "\">"; //27:42
                StringBuilder __tmp31 = new StringBuilder();
                __tmp31.Append(arr.GetXsdName());
                using(StreamReader __tmp31Reader = new StreamReader(this.__ToStream(__tmp31.ToString())))
                {
                    bool __tmp31_first = true;
                    while(__tmp31_first || !__tmp31Reader.EndOfStream)
                    {
                        __tmp31_first = false;
                        string __tmp31Line = __tmp31Reader.ReadLine();
                        if (__tmp31Line == null)
                        {
                            __tmp31Line = "";
                        }
                        __out.Append(__tmp29Prefix);
                        __out.Append(__tmp31Line);
                        __out.Append(__tmp30Suffix);
                        __out.AppendLine(); //27:44
                    }
                }
                __out.Append("		<xs:sequence>"); //28:1
                __out.AppendLine(); //28:16
                string __tmp32Prefix = "			<xs:element name=\""; //29:1
                string __tmp33Suffix = "\" minOccurs=\"0\" maxOccurs=\"unbounded\"/>"; //29:169
                StringBuilder __tmp34 = new StringBuilder();
                __tmp34.Append(arr.InnerType.GetXsdName());
                using(StreamReader __tmp34Reader = new StreamReader(this.__ToStream(__tmp34.ToString())))
                {
                    bool __tmp34_first = true;
                    while(__tmp34_first || !__tmp34Reader.EndOfStream)
                    {
                        __tmp34_first = false;
                        string __tmp34Line = __tmp34Reader.ReadLine();
                        if (__tmp34Line == null)
                        {
                            __tmp34Line = "";
                        }
                        __out.Append(__tmp32Prefix);
                        __out.Append(__tmp34Line);
                    }
                }
                string __tmp35Line = "\" type=\""; //29:50
                __out.Append(__tmp35Line);
                StringBuilder __tmp36 = new StringBuilder();
                __tmp36.Append(arr.InnerType.GetNamespace(ns).Prefix);
                using(StreamReader __tmp36Reader = new StreamReader(this.__ToStream(__tmp36.ToString())))
                {
                    bool __tmp36_first = true;
                    while(__tmp36_first || !__tmp36Reader.EndOfStream)
                    {
                        __tmp36_first = false;
                        string __tmp36Line = __tmp36Reader.ReadLine();
                        if (__tmp36Line == null)
                        {
                            __tmp36Line = "";
                        }
                        __out.Append(__tmp36Line);
                    }
                }
                string __tmp37Line = ":"; //29:97
                __out.Append(__tmp37Line);
                StringBuilder __tmp38 = new StringBuilder();
                __tmp38.Append(arr.InnerType.GetXsdName());
                using(StreamReader __tmp38Reader = new StreamReader(this.__ToStream(__tmp38.ToString())))
                {
                    bool __tmp38_first = true;
                    while(__tmp38_first || !__tmp38Reader.EndOfStream)
                    {
                        __tmp38_first = false;
                        string __tmp38Line = __tmp38Reader.ReadLine();
                        if (__tmp38Line == null)
                        {
                            __tmp38Line = "";
                        }
                        __out.Append(__tmp38Line);
                    }
                }
                string __tmp39Line = "\" nillable=\""; //29:126
                __out.Append(__tmp39Line);
                StringBuilder __tmp40 = new StringBuilder();
                __tmp40.Append(arr.InnerType.IsNullableXsd());
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
                        __out.Append(__tmp40Line);
                        __out.Append(__tmp33Suffix);
                        __out.AppendLine(); //29:208
                    }
                }
                __out.Append("		</xs:sequence>"); //30:1
                __out.AppendLine(); //30:17
                __out.Append("	</xs:complexType>"); //31:1
                __out.AppendLine(); //31:19
            }
            var __loop4_results = 
                (from __loop4_var1 in __Enumerate((ns.Declarations).GetEnumerator()) //33:8
                from etype in __Enumerate((__loop4_var1).GetEnumerator()).OfType<Enum>() //33:25
                select new { __loop4_var1 = __loop4_var1, etype = etype}
                ).ToList(); //33:3
            int __loop4_iteration = 0;
            foreach (var __tmp41 in __loop4_results)
            {
                ++__loop4_iteration;
                var __loop4_var1 = __tmp41.__loop4_var1;
                var etype = __tmp41.etype;
                __out.AppendLine(); //34:1
                string __tmp42Prefix = "	<xs:element name=\""; //35:1
                string __tmp43Suffix = "\"/>"; //35:80
                StringBuilder __tmp44 = new StringBuilder();
                __tmp44.Append(etype.GetXsdName());
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
                    }
                }
                string __tmp45Line = "\" type=\""; //35:40
                __out.Append(__tmp45Line);
                StringBuilder __tmp46 = new StringBuilder();
                __tmp46.Append(ns.Prefix);
                using(StreamReader __tmp46Reader = new StreamReader(this.__ToStream(__tmp46.ToString())))
                {
                    bool __tmp46_first = true;
                    while(__tmp46_first || !__tmp46Reader.EndOfStream)
                    {
                        __tmp46_first = false;
                        string __tmp46Line = __tmp46Reader.ReadLine();
                        if (__tmp46Line == null)
                        {
                            __tmp46Line = "";
                        }
                        __out.Append(__tmp46Line);
                    }
                }
                string __tmp47Line = ":"; //35:59
                __out.Append(__tmp47Line);
                StringBuilder __tmp48 = new StringBuilder();
                __tmp48.Append(etype.GetXsdName());
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
                        __out.Append(__tmp48Line);
                        __out.Append(__tmp43Suffix);
                        __out.AppendLine(); //35:83
                    }
                }
                string __tmp49Prefix = "	<xs:simpleType name=\""; //36:1
                string __tmp50Suffix = "\">"; //36:43
                StringBuilder __tmp51 = new StringBuilder();
                __tmp51.Append(etype.GetXsdName());
                using(StreamReader __tmp51Reader = new StreamReader(this.__ToStream(__tmp51.ToString())))
                {
                    bool __tmp51_first = true;
                    while(__tmp51_first || !__tmp51Reader.EndOfStream)
                    {
                        __tmp51_first = false;
                        string __tmp51Line = __tmp51Reader.ReadLine();
                        if (__tmp51Line == null)
                        {
                            __tmp51Line = "";
                        }
                        __out.Append(__tmp49Prefix);
                        __out.Append(__tmp51Line);
                        __out.Append(__tmp50Suffix);
                        __out.AppendLine(); //36:45
                    }
                }
                __out.Append("		<xs:restriction base=\"xs:string\">"); //37:1
                __out.AppendLine(); //37:36
                var __loop5_results = 
                    (from __loop5_var1 in __Enumerate((etype).GetEnumerator()) //38:10
                    from elit in __Enumerate((__loop5_var1.EnumLiterals).GetEnumerator()) //38:17
                    select new { __loop5_var1 = __loop5_var1, elit = elit}
                    ).ToList(); //38:5
                int __loop5_iteration = 0;
                foreach (var __tmp52 in __loop5_results)
                {
                    ++__loop5_iteration;
                    var __loop5_var1 = __tmp52.__loop5_var1;
                    var elit = __tmp52.elit;
                    string __tmp53Prefix = "			<xs:enumeration value=\""; //39:1
                    string __tmp54Suffix = "\"/>"; //39:38
                    StringBuilder __tmp55 = new StringBuilder();
                    __tmp55.Append(elit.Name);
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
                            __out.AppendLine(); //39:41
                        }
                    }
                }
                __out.Append("		</xs:restriction>"); //41:1
                __out.AppendLine(); //41:20
                __out.Append("	</xs:simpleType>"); //42:1
                __out.AppendLine(); //42:18
            }
            var __loop6_results = 
                (from __loop6_var1 in __Enumerate((ns.Declarations).GetEnumerator()) //44:8
                from stype in __Enumerate((__loop6_var1).GetEnumerator()).OfType<StructuredType>() //44:25
                select new { __loop6_var1 = __loop6_var1, stype = stype}
                ).ToList(); //44:3
            int __loop6_iteration = 0;
            foreach (var __tmp56 in __loop6_results)
            {
                ++__loop6_iteration;
                var __loop6_var1 = __tmp56.__loop6_var1;
                var stype = __tmp56.stype;
                __out.AppendLine(); //45:1
                string __tmp57Prefix = "	<xs:element name=\""; //46:1
                string __tmp58Suffix = "\"/>"; //46:80
                StringBuilder __tmp59 = new StringBuilder();
                __tmp59.Append(stype.GetXsdName());
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
                string __tmp60Line = "\" type=\""; //46:40
                __out.Append(__tmp60Line);
                StringBuilder __tmp61 = new StringBuilder();
                __tmp61.Append(ns.Prefix);
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
                string __tmp62Line = ":"; //46:59
                __out.Append(__tmp62Line);
                StringBuilder __tmp63 = new StringBuilder();
                __tmp63.Append(stype.GetXsdName());
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
                        __out.AppendLine(); //46:83
                    }
                }
                string __tmp64Prefix = "	<xs:complexType name=\""; //47:1
                string __tmp65Suffix = "\">"; //47:44
                StringBuilder __tmp66 = new StringBuilder();
                __tmp66.Append(stype.GetXsdName());
                using(StreamReader __tmp66Reader = new StreamReader(this.__ToStream(__tmp66.ToString())))
                {
                    bool __tmp66_first = true;
                    while(__tmp66_first || !__tmp66Reader.EndOfStream)
                    {
                        __tmp66_first = false;
                        string __tmp66Line = __tmp66Reader.ReadLine();
                        if (__tmp66Line == null)
                        {
                            __tmp66Line = "";
                        }
                        __out.Append(__tmp64Prefix);
                        __out.Append(__tmp66Line);
                        __out.Append(__tmp65Suffix);
                        __out.AppendLine(); //47:46
                    }
                }
                string __tmp67Prefix = "		<xs:"; //48:1
                string __tmp68Suffix = ">"; //48:29
                StringBuilder __tmp69 = new StringBuilder();
                __tmp69.Append(GetStructKind(stype));
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
                        __out.Append(__tmp68Suffix);
                        __out.AppendLine(); //48:30
                    }
                }
                var __loop7_results = 
                    (from __loop7_var1 in __Enumerate((stype).GetEnumerator()) //49:10
                    from prop in __Enumerate((__loop7_var1.Properties).GetEnumerator()) //49:17
                    select new { __loop7_var1 = __loop7_var1, prop = prop}
                    ).ToList(); //49:5
                int __loop7_iteration = 0;
                foreach (var __tmp70 in __loop7_results)
                {
                    ++__loop7_iteration;
                    var __loop7_var1 = __tmp70.__loop7_var1;
                    var prop = __tmp70.prop;
                    string __tmp71Prefix = "			"; //50:1
                    string __tmp72Suffix = string.Empty; 
                    StringBuilder __tmp73 = new StringBuilder();
                    __tmp73.Append(GenerateElement(ns, prop.Name, prop.Type, prop.Annotations));
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
                            __out.Append(__tmp71Prefix);
                            __out.Append(__tmp73Line);
                            __out.Append(__tmp72Suffix);
                            __out.AppendLine(); //50:65
                        }
                    }
                }
                string __tmp74Prefix = "		</xs:"; //52:1
                string __tmp75Suffix = ">"; //52:30
                StringBuilder __tmp76 = new StringBuilder();
                __tmp76.Append(GetStructKind(stype));
                using(StreamReader __tmp76Reader = new StreamReader(this.__ToStream(__tmp76.ToString())))
                {
                    bool __tmp76_first = true;
                    while(__tmp76_first || !__tmp76Reader.EndOfStream)
                    {
                        __tmp76_first = false;
                        string __tmp76Line = __tmp76Reader.ReadLine();
                        if (__tmp76Line == null)
                        {
                            __tmp76Line = "";
                        }
                        __out.Append(__tmp74Prefix);
                        __out.Append(__tmp76Line);
                        __out.Append(__tmp75Suffix);
                        __out.AppendLine(); //52:31
                    }
                }
                __out.Append("	</xs:complexType>"); //53:1
                __out.AppendLine(); //53:19
            }
            var __loop8_results = 
                (from __loop8_var1 in __Enumerate((ns.Declarations).GetEnumerator()) //55:8
                from intf in __Enumerate((__loop8_var1).GetEnumerator()).OfType<Interface>() //55:25
                from op in __Enumerate((intf.Operations).GetEnumerator()) //55:49
                select new { __loop8_var1 = __loop8_var1, intf = intf, op = op}
                ).ToList(); //55:3
            int __loop8_iteration = 0;
            foreach (var __tmp77 in __loop8_results)
            {
                ++__loop8_iteration;
                var __loop8_var1 = __tmp77.__loop8_var1;
                var intf = __tmp77.intf;
                var op = __tmp77.op;
                if (!intf.HasAnnotation(SoalAnnotations.Rpc)) //56:4
                {
                    if (intf.HasAnnotation(SoalAnnotations.NoWrap)) //57:4
                    {
                        var __loop9_results = 
                            (from __loop9_var1 in __Enumerate((op).GetEnumerator()) //58:10
                            from param in __Enumerate((__loop9_var1.Parameters).GetEnumerator()) //58:14
                            select new { __loop9_var1 = __loop9_var1, param = param}
                            ).ToList(); //58:5
                        int __loop9_iteration = 0;
                        foreach (var __tmp78 in __loop9_results)
                        {
                            ++__loop9_iteration;
                            var __loop9_var1 = __tmp78.__loop9_var1;
                            var param = __tmp78.param;
                            string __tmp79Prefix = "	"; //59:1
                            string __tmp80Suffix = string.Empty; 
                            StringBuilder __tmp81 = new StringBuilder();
                            __tmp81.Append(GenerateElement(ns, op.Name + param.Name.ToPascalCase(), param.Type, param.Annotations));
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
                                    __out.Append(__tmp80Suffix);
                                    __out.AppendLine(); //59:91
                                }
                            }
                        }
                        if (op.ReturnType != SoalInstance.Void) //61:5
                        {
                            string __tmp82Prefix = "	"; //62:1
                            string __tmp83Suffix = string.Empty; 
                            StringBuilder __tmp84 = new StringBuilder();
                            __tmp84.Append(GenerateElement(ns, op.Name + "Response", op.ReturnType, op.ReturnAnnotations));
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
                                    __out.AppendLine(); //62:80
                                }
                            }
                        }
                    }
                    else //64:4
                    {
                        __out.AppendLine(); //65:1
                        string __tmp85Prefix = "	<xs:element name=\""; //66:1
                        string __tmp86Suffix = "\"/>"; //66:58
                        StringBuilder __tmp87 = new StringBuilder();
                        __tmp87.Append(op.Name);
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
                                __out.Append(__tmp85Prefix);
                                __out.Append(__tmp87Line);
                            }
                        }
                        string __tmp88Line = "\" type=\""; //66:29
                        __out.Append(__tmp88Line);
                        StringBuilder __tmp89 = new StringBuilder();
                        __tmp89.Append(ns.Prefix);
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
                            }
                        }
                        string __tmp90Line = ":"; //66:48
                        __out.Append(__tmp90Line);
                        StringBuilder __tmp91 = new StringBuilder();
                        __tmp91.Append(op.Name);
                        using(StreamReader __tmp91Reader = new StreamReader(this.__ToStream(__tmp91.ToString())))
                        {
                            bool __tmp91_first = true;
                            while(__tmp91_first || !__tmp91Reader.EndOfStream)
                            {
                                __tmp91_first = false;
                                string __tmp91Line = __tmp91Reader.ReadLine();
                                if (__tmp91Line == null)
                                {
                                    __tmp91Line = "";
                                }
                                __out.Append(__tmp91Line);
                                __out.Append(__tmp86Suffix);
                                __out.AppendLine(); //66:61
                            }
                        }
                        string __tmp92Prefix = "	<xs:complexType name=\""; //67:1
                        string __tmp93Suffix = "\">"; //67:33
                        StringBuilder __tmp94 = new StringBuilder();
                        __tmp94.Append(op.Name);
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
                                __out.Append(__tmp92Prefix);
                                __out.Append(__tmp94Line);
                                __out.Append(__tmp93Suffix);
                                __out.AppendLine(); //67:35
                            }
                        }
                        __out.Append("		<xs:sequence>"); //68:1
                        __out.AppendLine(); //68:16
                        var __loop10_results = 
                            (from __loop10_var1 in __Enumerate((op).GetEnumerator()) //69:10
                            from param in __Enumerate((__loop10_var1.Parameters).GetEnumerator()) //69:14
                            select new { __loop10_var1 = __loop10_var1, param = param}
                            ).ToList(); //69:5
                        int __loop10_iteration = 0;
                        foreach (var __tmp95 in __loop10_results)
                        {
                            ++__loop10_iteration;
                            var __loop10_var1 = __tmp95.__loop10_var1;
                            var param = __tmp95.param;
                            string __tmp96Prefix = "			"; //70:1
                            string __tmp97Suffix = string.Empty; 
                            StringBuilder __tmp98 = new StringBuilder();
                            __tmp98.Append(GenerateElement(ns, param.Name, param.Type, param.Annotations));
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
                                    __out.Append(__tmp96Prefix);
                                    __out.Append(__tmp98Line);
                                    __out.Append(__tmp97Suffix);
                                    __out.AppendLine(); //70:68
                                }
                            }
                        }
                        __out.Append("		</xs:sequence>"); //72:1
                        __out.AppendLine(); //72:17
                        __out.Append("	</xs:complexType>"); //73:1
                        __out.AppendLine(); //73:19
                        if (!op.IsOneway) //74:4
                        {
                            __out.AppendLine(); //75:1
                            string __tmp99Prefix = "	<xs:element name=\""; //76:1
                            string __tmp100Suffix = "Response\"/>"; //76:66
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
                            string __tmp102Line = "Response\" type=\""; //76:29
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
                            string __tmp104Line = ":"; //76:56
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
                                    __out.AppendLine(); //76:77
                                }
                            }
                            string __tmp106Prefix = "	<xs:complexType name=\""; //77:1
                            string __tmp107Suffix = "Response\">"; //77:33
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
                                    __out.AppendLine(); //77:43
                                }
                            }
                            if (op.ReturnType == SoalInstance.Void) //78:5
                            {
                                __out.Append("		<xs:sequence/>"); //79:1
                                __out.AppendLine(); //79:17
                            }
                            else //80:5
                            {
                                __out.Append("		<xs:sequence>"); //81:1
                                __out.AppendLine(); //81:16
                                string __tmp109Prefix = "			"; //82:1
                                string __tmp110Suffix = string.Empty; 
                                StringBuilder __tmp111 = new StringBuilder();
                                __tmp111.Append(GenerateElement(ns, op.Name + "Result", op.ReturnType, op.ReturnAnnotations));
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
                                        __out.Append(__tmp110Suffix);
                                        __out.AppendLine(); //82:80
                                    }
                                }
                                __out.Append("		</xs:sequence>"); //83:1
                                __out.AppendLine(); //83:17
                            }
                            __out.Append("	</xs:complexType>"); //85:1
                            __out.AppendLine(); //85:19
                        }
                    }
                }
            }
            __out.Append("</xs:schema>"); //90:1
            __out.AppendLine(); //90:13
            return __out.ToString();
        }

        public string GenerateElement(Namespace ns, string name, SoalType t, IList<Annotation> annots) //93:1
        {
            StringBuilder __out = new StringBuilder();
            if (annots.ContainsAnnotation(SoalAnnotations.Attribute)) //94:2
            {
                if ((t is ArrayType || (t is NonNullableType && ((NonNullableType)t).InnerType is ArrayType)) && annots.ContainsAnnotation(SoalAnnotations.NoWrap)) //95:3
                {
                    if (t is ArrayType) //96:4
                    {
                        string __tmp1Prefix = "<xs:attribute name=\""; //97:1
                        string __tmp2Suffix = "/>"; //97:156
                        StringBuilder __tmp3 = new StringBuilder();
                        __tmp3.Append(name);
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
                            }
                        }
                        string __tmp4Line = "\" type=\""; //97:27
                        __out.Append(__tmp4Line);
                        StringBuilder __tmp5 = new StringBuilder();
                        __tmp5.Append(((ArrayType)t).InnerType.GetNamespace(ns).Prefix);
                        using(StreamReader __tmp5Reader = new StreamReader(this.__ToStream(__tmp5.ToString())))
                        {
                            bool __tmp5_first = true;
                            while(__tmp5_first || !__tmp5Reader.EndOfStream)
                            {
                                __tmp5_first = false;
                                string __tmp5Line = __tmp5Reader.ReadLine();
                                if (__tmp5Line == null)
                                {
                                    __tmp5Line = "";
                                }
                                __out.Append(__tmp5Line);
                            }
                        }
                        string __tmp6Line = ":"; //97:85
                        __out.Append(__tmp6Line);
                        StringBuilder __tmp7 = new StringBuilder();
                        __tmp7.Append(((ArrayType)t).InnerType.GetXsdName());
                        using(StreamReader __tmp7Reader = new StreamReader(this.__ToStream(__tmp7.ToString())))
                        {
                            bool __tmp7_first = true;
                            while(__tmp7_first || !__tmp7Reader.EndOfStream)
                            {
                                __tmp7_first = false;
                                string __tmp7Line = __tmp7Reader.ReadLine();
                                if (__tmp7Line == null)
                                {
                                    __tmp7Line = "";
                                }
                                __out.Append(__tmp7Line);
                            }
                        }
                        string __tmp8Line = "\""; //97:125
                        __out.Append(__tmp8Line);
                        StringBuilder __tmp9 = new StringBuilder();
                        __tmp9.Append(GetAttributeRequired(annots));
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
                                __out.Append(__tmp9Line);
                                __out.Append(__tmp2Suffix);
                                __out.AppendLine(); //97:158
                            }
                        }
                    }
                    else //98:4
                    {
                        string __tmp10Prefix = "<xs:attribute name=\""; //99:1
                        string __tmp11Suffix = "/>"; //99:214
                        StringBuilder __tmp12 = new StringBuilder();
                        __tmp12.Append(name);
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
                        string __tmp13Line = "\" type=\""; //99:27
                        __out.Append(__tmp13Line);
                        StringBuilder __tmp14 = new StringBuilder();
                        __tmp14.Append(((ArrayType)((NonNullableType)t).InnerType).InnerType.GetNamespace(ns).Prefix);
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
                            }
                        }
                        string __tmp15Line = ":"; //99:114
                        __out.Append(__tmp15Line);
                        StringBuilder __tmp16 = new StringBuilder();
                        __tmp16.Append(((ArrayType)((NonNullableType)t).InnerType).InnerType.GetXsdName());
                        using(StreamReader __tmp16Reader = new StreamReader(this.__ToStream(__tmp16.ToString())))
                        {
                            bool __tmp16_first = true;
                            while(__tmp16_first || !__tmp16Reader.EndOfStream)
                            {
                                __tmp16_first = false;
                                string __tmp16Line = __tmp16Reader.ReadLine();
                                if (__tmp16Line == null)
                                {
                                    __tmp16Line = "";
                                }
                                __out.Append(__tmp16Line);
                            }
                        }
                        string __tmp17Line = "\""; //99:183
                        __out.Append(__tmp17Line);
                        StringBuilder __tmp18 = new StringBuilder();
                        __tmp18.Append(GetAttributeRequired(annots));
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
                                __out.Append(__tmp18Line);
                                __out.Append(__tmp11Suffix);
                                __out.AppendLine(); //99:216
                            }
                        }
                    }
                }
                else //101:3
                {
                    string __tmp19Prefix = "<xs:attribute name=\""; //102:1
                    string __tmp20Suffix = "/>"; //102:110
                    StringBuilder __tmp21 = new StringBuilder();
                    __tmp21.Append(name);
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
                            __out.Append(__tmp19Prefix);
                            __out.Append(__tmp21Line);
                        }
                    }
                    string __tmp22Line = "\" type=\""; //102:27
                    __out.Append(__tmp22Line);
                    StringBuilder __tmp23 = new StringBuilder();
                    __tmp23.Append(t.GetNamespace(ns).Prefix);
                    using(StreamReader __tmp23Reader = new StreamReader(this.__ToStream(__tmp23.ToString())))
                    {
                        bool __tmp23_first = true;
                        while(__tmp23_first || !__tmp23Reader.EndOfStream)
                        {
                            __tmp23_first = false;
                            string __tmp23Line = __tmp23Reader.ReadLine();
                            if (__tmp23Line == null)
                            {
                                __tmp23Line = "";
                            }
                            __out.Append(__tmp23Line);
                        }
                    }
                    string __tmp24Line = ":"; //102:62
                    __out.Append(__tmp24Line);
                    StringBuilder __tmp25 = new StringBuilder();
                    __tmp25.Append(t.GetXsdName());
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
                            __out.Append(__tmp25Line);
                        }
                    }
                    string __tmp26Line = "\""; //102:79
                    __out.Append(__tmp26Line);
                    StringBuilder __tmp27 = new StringBuilder();
                    __tmp27.Append(GetAttributeRequired(annots));
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
                            __out.Append(__tmp20Suffix);
                            __out.AppendLine(); //102:112
                        }
                    }
                }
            }
            else //104:2
            {
                if ((t is ArrayType || (t is NonNullableType && ((NonNullableType)t).InnerType is ArrayType)) && annots.ContainsAnnotation(SoalAnnotations.NoWrap)) //105:3
                {
                    if (t is ArrayType) //106:4
                    {
                        string __tmp28Prefix = "<xs:element name=\""; //107:1
                        string __tmp29Suffix = "\" minOccurs=\"0\" maxOccurs=\"unbounded\"/>"; //107:177
                        StringBuilder __tmp30 = new StringBuilder();
                        __tmp30.Append(name);
                        using(StreamReader __tmp30Reader = new StreamReader(this.__ToStream(__tmp30.ToString())))
                        {
                            bool __tmp30_first = true;
                            while(__tmp30_first || !__tmp30Reader.EndOfStream)
                            {
                                __tmp30_first = false;
                                string __tmp30Line = __tmp30Reader.ReadLine();
                                if (__tmp30Line == null)
                                {
                                    __tmp30Line = "";
                                }
                                __out.Append(__tmp28Prefix);
                                __out.Append(__tmp30Line);
                            }
                        }
                        string __tmp31Line = "\" type=\""; //107:25
                        __out.Append(__tmp31Line);
                        StringBuilder __tmp32 = new StringBuilder();
                        __tmp32.Append(((ArrayType)t).InnerType.GetNamespace(ns).Prefix);
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
                                __out.Append(__tmp32Line);
                            }
                        }
                        string __tmp33Line = ":"; //107:83
                        __out.Append(__tmp33Line);
                        StringBuilder __tmp34 = new StringBuilder();
                        __tmp34.Append(((ArrayType)t).InnerType.GetXsdName());
                        using(StreamReader __tmp34Reader = new StreamReader(this.__ToStream(__tmp34.ToString())))
                        {
                            bool __tmp34_first = true;
                            while(__tmp34_first || !__tmp34Reader.EndOfStream)
                            {
                                __tmp34_first = false;
                                string __tmp34Line = __tmp34Reader.ReadLine();
                                if (__tmp34Line == null)
                                {
                                    __tmp34Line = "";
                                }
                                __out.Append(__tmp34Line);
                            }
                        }
                        string __tmp35Line = "\" nillable=\""; //107:123
                        __out.Append(__tmp35Line);
                        StringBuilder __tmp36 = new StringBuilder();
                        __tmp36.Append(((ArrayType)t).InnerType.IsNullableXsd());
                        using(StreamReader __tmp36Reader = new StreamReader(this.__ToStream(__tmp36.ToString())))
                        {
                            bool __tmp36_first = true;
                            while(__tmp36_first || !__tmp36Reader.EndOfStream)
                            {
                                __tmp36_first = false;
                                string __tmp36Line = __tmp36Reader.ReadLine();
                                if (__tmp36Line == null)
                                {
                                    __tmp36Line = "";
                                }
                                __out.Append(__tmp36Line);
                                __out.Append(__tmp29Suffix);
                                __out.AppendLine(); //107:216
                            }
                        }
                    }
                    else //108:4
                    {
                        string __tmp37Prefix = "<xs:element name=\""; //109:1
                        string __tmp38Suffix = "\" minOccurs=\"0\" maxOccurs=\"unbounded\"/>"; //109:264
                        StringBuilder __tmp39 = new StringBuilder();
                        __tmp39.Append(name);
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
                                __out.Append(__tmp37Prefix);
                                __out.Append(__tmp39Line);
                            }
                        }
                        string __tmp40Line = "\" type=\""; //109:25
                        __out.Append(__tmp40Line);
                        StringBuilder __tmp41 = new StringBuilder();
                        __tmp41.Append(((ArrayType)((NonNullableType)t).InnerType).InnerType.GetNamespace(ns).Prefix);
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
                            }
                        }
                        string __tmp42Line = ":"; //109:112
                        __out.Append(__tmp42Line);
                        StringBuilder __tmp43 = new StringBuilder();
                        __tmp43.Append(((ArrayType)((NonNullableType)t).InnerType).InnerType.GetXsdName());
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
                                __out.Append(__tmp43Line);
                            }
                        }
                        string __tmp44Line = "\" nillable=\""; //109:181
                        __out.Append(__tmp44Line);
                        StringBuilder __tmp45 = new StringBuilder();
                        __tmp45.Append(((ArrayType)((NonNullableType)t).InnerType).InnerType.IsNullableXsd());
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
                                __out.Append(__tmp38Suffix);
                                __out.AppendLine(); //109:303
                            }
                        }
                    }
                }
                else //111:3
                {
                    string __tmp46Prefix = "<xs:element name=\""; //112:1
                    string __tmp47Suffix = "\"/>"; //112:108
                    StringBuilder __tmp48 = new StringBuilder();
                    __tmp48.Append(name);
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
                    string __tmp49Line = "\" type=\""; //112:25
                    __out.Append(__tmp49Line);
                    StringBuilder __tmp50 = new StringBuilder();
                    __tmp50.Append(t.GetNamespace(ns).Prefix);
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
                    string __tmp51Line = ":"; //112:60
                    __out.Append(__tmp51Line);
                    StringBuilder __tmp52 = new StringBuilder();
                    __tmp52.Append(t.GetXsdName());
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
                        }
                    }
                    string __tmp53Line = "\" nillable=\""; //112:77
                    __out.Append(__tmp53Line);
                    StringBuilder __tmp54 = new StringBuilder();
                    __tmp54.Append(t.IsNullableXsd());
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
                            __out.Append(__tmp54Line);
                            __out.Append(__tmp47Suffix);
                            __out.AppendLine(); //112:111
                        }
                    }
                }
            }
            return __out.ToString();
        }

        public string GetStructKind(StructuredType st) //117:1
        {
            if (st.HasAnnotation(SoalAnnotations.Choice)) //118:2
            {
                return "choice"; //119:3
            }
            else if (st.HasAnnotation(SoalAnnotations.All)) //120:2
            {
                return "all"; //121:3
            }
            else //122:2
            {
                return "sequence"; //123:3
            }
        }

        public string GetAttributeRequired(IList<Annotation> annots) //127:1
        {
            if (annots.ContainsAnnotation(SoalAnnotations.Attribute)) //128:2
            {
                return " use=\"required\""; //129:3
            }
            else //130:2
            {
                return ""; //131:3
            }
        }

    }
}
