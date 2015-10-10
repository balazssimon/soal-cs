using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Soal //1:1
{
    using __Hidden_XsdGenerator_760419659;
    namespace __Hidden_XsdGenerator_760419659
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
                __out.Append("		<xs:sequence>"); //48:1
                __out.AppendLine(); //48:16
                var __loop7_results = 
                    (from __loop7_var1 in __Enumerate((stype).GetEnumerator()) //49:10
                    from prop in __Enumerate((__loop7_var1.Properties).GetEnumerator()) //49:17
                    select new { __loop7_var1 = __loop7_var1, prop = prop}
                    ).ToList(); //49:5
                int __loop7_iteration = 0;
                foreach (var __tmp67 in __loop7_results)
                {
                    ++__loop7_iteration;
                    var __loop7_var1 = __tmp67.__loop7_var1;
                    var prop = __tmp67.prop;
                    string __tmp68Prefix = "			<xs:element name=\""; //50:1
                    string __tmp69Suffix = "\"/>"; //50:140
                    StringBuilder __tmp70 = new StringBuilder();
                    __tmp70.Append(prop.Name);
                    using(StreamReader __tmp70Reader = new StreamReader(this.__ToStream(__tmp70.ToString())))
                    {
                        bool __tmp70_first = true;
                        while(__tmp70_first || !__tmp70Reader.EndOfStream)
                        {
                            __tmp70_first = false;
                            string __tmp70Line = __tmp70Reader.ReadLine();
                            if (__tmp70Line == null)
                            {
                                __tmp70Line = "";
                            }
                            __out.Append(__tmp68Prefix);
                            __out.Append(__tmp70Line);
                        }
                    }
                    string __tmp71Line = "\" type=\""; //50:33
                    __out.Append(__tmp71Line);
                    StringBuilder __tmp72 = new StringBuilder();
                    __tmp72.Append(prop.Type.GetNamespace(ns).Prefix);
                    using(StreamReader __tmp72Reader = new StreamReader(this.__ToStream(__tmp72.ToString())))
                    {
                        bool __tmp72_first = true;
                        while(__tmp72_first || !__tmp72Reader.EndOfStream)
                        {
                            __tmp72_first = false;
                            string __tmp72Line = __tmp72Reader.ReadLine();
                            if (__tmp72Line == null)
                            {
                                __tmp72Line = "";
                            }
                            __out.Append(__tmp72Line);
                        }
                    }
                    string __tmp73Line = ":"; //50:76
                    __out.Append(__tmp73Line);
                    StringBuilder __tmp74 = new StringBuilder();
                    __tmp74.Append(prop.Type.GetXsdName());
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
                            __out.Append(__tmp74Line);
                        }
                    }
                    string __tmp75Line = "\" nillable=\""; //50:101
                    __out.Append(__tmp75Line);
                    StringBuilder __tmp76 = new StringBuilder();
                    __tmp76.Append(prop.Type.IsNullableXsd());
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
                            __out.Append(__tmp76Line);
                            __out.Append(__tmp69Suffix);
                            __out.AppendLine(); //50:143
                        }
                    }
                }
                __out.Append("		</xs:sequence>"); //52:1
                __out.AppendLine(); //52:17
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
                __out.AppendLine(); //56:1
                string __tmp78Prefix = "	<xs:element name=\""; //57:1
                string __tmp79Suffix = "\"/>"; //57:58
                StringBuilder __tmp80 = new StringBuilder();
                __tmp80.Append(op.Name);
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
                        __out.Append(__tmp78Prefix);
                        __out.Append(__tmp80Line);
                    }
                }
                string __tmp81Line = "\" type=\""; //57:29
                __out.Append(__tmp81Line);
                StringBuilder __tmp82 = new StringBuilder();
                __tmp82.Append(ns.Prefix);
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
                    }
                }
                string __tmp83Line = ":"; //57:48
                __out.Append(__tmp83Line);
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
                        __out.Append(__tmp84Line);
                        __out.Append(__tmp79Suffix);
                        __out.AppendLine(); //57:61
                    }
                }
                string __tmp85Prefix = "	<xs:complexType name=\""; //58:1
                string __tmp86Suffix = "\">"; //58:33
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
                        __out.Append(__tmp86Suffix);
                        __out.AppendLine(); //58:35
                    }
                }
                __out.Append("		<xs:sequence>"); //59:1
                __out.AppendLine(); //59:16
                var __loop9_results = 
                    (from __loop9_var1 in __Enumerate((op).GetEnumerator()) //60:10
                    from param in __Enumerate((__loop9_var1.Parameters).GetEnumerator()) //60:14
                    select new { __loop9_var1 = __loop9_var1, param = param}
                    ).ToList(); //60:5
                int __loop9_iteration = 0;
                foreach (var __tmp88 in __loop9_results)
                {
                    ++__loop9_iteration;
                    var __loop9_var1 = __tmp88.__loop9_var1;
                    var param = __tmp88.param;
                    string __tmp89Prefix = "			<xs:element name=\""; //61:1
                    string __tmp90Suffix = "\"/>"; //61:144
                    StringBuilder __tmp91 = new StringBuilder();
                    __tmp91.Append(param.Name);
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
                            __out.Append(__tmp89Prefix);
                            __out.Append(__tmp91Line);
                        }
                    }
                    string __tmp92Line = "\" type=\""; //61:34
                    __out.Append(__tmp92Line);
                    StringBuilder __tmp93 = new StringBuilder();
                    __tmp93.Append(param.Type.GetNamespace(ns).Prefix);
                    using(StreamReader __tmp93Reader = new StreamReader(this.__ToStream(__tmp93.ToString())))
                    {
                        bool __tmp93_first = true;
                        while(__tmp93_first || !__tmp93Reader.EndOfStream)
                        {
                            __tmp93_first = false;
                            string __tmp93Line = __tmp93Reader.ReadLine();
                            if (__tmp93Line == null)
                            {
                                __tmp93Line = "";
                            }
                            __out.Append(__tmp93Line);
                        }
                    }
                    string __tmp94Line = ":"; //61:78
                    __out.Append(__tmp94Line);
                    StringBuilder __tmp95 = new StringBuilder();
                    __tmp95.Append(param.Type.GetXsdName());
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
                            __out.Append(__tmp95Line);
                        }
                    }
                    string __tmp96Line = "\" nillable=\""; //61:104
                    __out.Append(__tmp96Line);
                    StringBuilder __tmp97 = new StringBuilder();
                    __tmp97.Append(param.Type.IsNullableXsd());
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
                            __out.Append(__tmp90Suffix);
                            __out.AppendLine(); //61:147
                        }
                    }
                }
                __out.Append("		</xs:sequence>"); //63:1
                __out.AppendLine(); //63:17
                __out.Append("	</xs:complexType>"); //64:1
                __out.AppendLine(); //64:19
                if (!op.IsOneway) //65:4
                {
                    __out.AppendLine(); //66:1
                    string __tmp98Prefix = "	<xs:element name=\""; //67:1
                    string __tmp99Suffix = "Response\"/>"; //67:66
                    StringBuilder __tmp100 = new StringBuilder();
                    __tmp100.Append(op.Name);
                    using(StreamReader __tmp100Reader = new StreamReader(this.__ToStream(__tmp100.ToString())))
                    {
                        bool __tmp100_first = true;
                        while(__tmp100_first || !__tmp100Reader.EndOfStream)
                        {
                            __tmp100_first = false;
                            string __tmp100Line = __tmp100Reader.ReadLine();
                            if (__tmp100Line == null)
                            {
                                __tmp100Line = "";
                            }
                            __out.Append(__tmp98Prefix);
                            __out.Append(__tmp100Line);
                        }
                    }
                    string __tmp101Line = "Response\" type=\""; //67:29
                    __out.Append(__tmp101Line);
                    StringBuilder __tmp102 = new StringBuilder();
                    __tmp102.Append(ns.Prefix);
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
                            __out.Append(__tmp102Line);
                        }
                    }
                    string __tmp103Line = ":"; //67:56
                    __out.Append(__tmp103Line);
                    StringBuilder __tmp104 = new StringBuilder();
                    __tmp104.Append(op.Name);
                    using(StreamReader __tmp104Reader = new StreamReader(this.__ToStream(__tmp104.ToString())))
                    {
                        bool __tmp104_first = true;
                        while(__tmp104_first || !__tmp104Reader.EndOfStream)
                        {
                            __tmp104_first = false;
                            string __tmp104Line = __tmp104Reader.ReadLine();
                            if (__tmp104Line == null)
                            {
                                __tmp104Line = "";
                            }
                            __out.Append(__tmp104Line);
                            __out.Append(__tmp99Suffix);
                            __out.AppendLine(); //67:77
                        }
                    }
                    string __tmp105Prefix = "	<xs:complexType name=\""; //68:1
                    string __tmp106Suffix = "Response\">"; //68:33
                    StringBuilder __tmp107 = new StringBuilder();
                    __tmp107.Append(op.Name);
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
                            __out.Append(__tmp105Prefix);
                            __out.Append(__tmp107Line);
                            __out.Append(__tmp106Suffix);
                            __out.AppendLine(); //68:43
                        }
                    }
                    if (op.ReturnType == SoalInstance.Void) //69:5
                    {
                        __out.Append("		<xs:sequence/>"); //70:1
                        __out.AppendLine(); //70:17
                    }
                    else //71:5
                    {
                        __out.Append("		<xs:sequence>"); //72:1
                        __out.AppendLine(); //72:16
                        string __tmp108Prefix = "			<xs:element name=\""; //73:1
                        string __tmp109Suffix = "\"/>"; //73:156
                        StringBuilder __tmp110 = new StringBuilder();
                        __tmp110.Append(op.Name);
                        using(StreamReader __tmp110Reader = new StreamReader(this.__ToStream(__tmp110.ToString())))
                        {
                            bool __tmp110_first = true;
                            while(__tmp110_first || !__tmp110Reader.EndOfStream)
                            {
                                __tmp110_first = false;
                                string __tmp110Line = __tmp110Reader.ReadLine();
                                if (__tmp110Line == null)
                                {
                                    __tmp110Line = "";
                                }
                                __out.Append(__tmp108Prefix);
                                __out.Append(__tmp110Line);
                            }
                        }
                        string __tmp111Line = "Result\" type=\""; //73:31
                        __out.Append(__tmp111Line);
                        StringBuilder __tmp112 = new StringBuilder();
                        __tmp112.Append(op.ReturnType.GetNamespace(ns).Prefix);
                        using(StreamReader __tmp112Reader = new StreamReader(this.__ToStream(__tmp112.ToString())))
                        {
                            bool __tmp112_first = true;
                            while(__tmp112_first || !__tmp112Reader.EndOfStream)
                            {
                                __tmp112_first = false;
                                string __tmp112Line = __tmp112Reader.ReadLine();
                                if (__tmp112Line == null)
                                {
                                    __tmp112Line = "";
                                }
                                __out.Append(__tmp112Line);
                            }
                        }
                        string __tmp113Line = ":"; //73:84
                        __out.Append(__tmp113Line);
                        StringBuilder __tmp114 = new StringBuilder();
                        __tmp114.Append(op.ReturnType.GetXsdName());
                        using(StreamReader __tmp114Reader = new StreamReader(this.__ToStream(__tmp114.ToString())))
                        {
                            bool __tmp114_first = true;
                            while(__tmp114_first || !__tmp114Reader.EndOfStream)
                            {
                                __tmp114_first = false;
                                string __tmp114Line = __tmp114Reader.ReadLine();
                                if (__tmp114Line == null)
                                {
                                    __tmp114Line = "";
                                }
                                __out.Append(__tmp114Line);
                            }
                        }
                        string __tmp115Line = "\" nillable=\""; //73:113
                        __out.Append(__tmp115Line);
                        StringBuilder __tmp116 = new StringBuilder();
                        __tmp116.Append(op.ReturnType.IsNullableXsd());
                        using(StreamReader __tmp116Reader = new StreamReader(this.__ToStream(__tmp116.ToString())))
                        {
                            bool __tmp116_first = true;
                            while(__tmp116_first || !__tmp116Reader.EndOfStream)
                            {
                                __tmp116_first = false;
                                string __tmp116Line = __tmp116Reader.ReadLine();
                                if (__tmp116Line == null)
                                {
                                    __tmp116Line = "";
                                }
                                __out.Append(__tmp116Line);
                                __out.Append(__tmp109Suffix);
                                __out.AppendLine(); //73:159
                            }
                        }
                        __out.Append("		</xs:sequence>"); //74:1
                        __out.AppendLine(); //74:17
                    }
                    __out.Append("	</xs:complexType>"); //76:1
                    __out.AppendLine(); //76:19
                }
            }
            __out.Append("</xs:schema>"); //79:1
            __out.AppendLine(); //79:13
            return __out.ToString();
        }

    }
}
