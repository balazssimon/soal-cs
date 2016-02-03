using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Soal //1:1
{
    using __Hidden_XsdGenerator_1824218337;
    namespace __Hidden_XsdGenerator_1824218337
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
                var __tmp67 = stype; //48:11
                if (stype is Struct) //49:4
                {
                    if (((Struct)stype).BaseType != null) //50:5
                    {
                        __out.Append("		<xs:complexContent>"); //51:1
                        __out.AppendLine(); //51:22
                        string __tmp68Prefix = "			<xs:extension base=\""; //52:1
                        string __tmp69Suffix = "\">"; //52:94
                        StringBuilder __tmp70 = new StringBuilder();
                        __tmp70.Append(((Struct)stype).BaseType.GetNamespace(ns).Prefix);
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
                        string __tmp71Line = ":"; //52:64
                        __out.Append(__tmp71Line);
                        StringBuilder __tmp72 = new StringBuilder();
                        __tmp72.Append(((Struct)stype).BaseType.GetXsdName());
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
                                __out.Append(__tmp69Suffix);
                                __out.AppendLine(); //52:96
                            }
                        }
                        string __tmp73Prefix = "				"; //53:1
                        string __tmp74Suffix = string.Empty; 
                        StringBuilder __tmp75 = new StringBuilder();
                        __tmp75.Append(GenerateStructuredTypeBody(ns, ((Struct)stype)));
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
                                __out.Append(__tmp73Prefix);
                                __out.Append(__tmp75Line);
                                __out.Append(__tmp74Suffix);
                                __out.AppendLine(); //53:44
                            }
                        }
                        __out.Append("			</xs:extension>"); //54:1
                        __out.AppendLine(); //54:19
                        __out.Append("		</xs:complexContent>"); //55:1
                        __out.AppendLine(); //55:23
                    }
                    else //56:5
                    {
                        string __tmp76Prefix = "		"; //57:1
                        string __tmp77Suffix = string.Empty; 
                        StringBuilder __tmp78 = new StringBuilder();
                        __tmp78.Append(GenerateStructuredTypeBody(ns, ((Struct)stype)));
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
                                __out.Append(__tmp77Suffix);
                                __out.AppendLine(); //57:42
                            }
                        }
                    }
                }
                else if (stype is Exception) //59:4
                {
                    if (((Exception)stype).BaseType != null) //60:5
                    {
                        __out.Append("		<xs:complexContent>"); //61:1
                        __out.AppendLine(); //61:22
                        string __tmp79Prefix = "			<xs:extension base=\""; //62:1
                        string __tmp80Suffix = "\">"; //62:94
                        StringBuilder __tmp81 = new StringBuilder();
                        __tmp81.Append(((Exception)stype).BaseType.GetNamespace(ns).Prefix);
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
                        string __tmp82Line = ":"; //62:64
                        __out.Append(__tmp82Line);
                        StringBuilder __tmp83 = new StringBuilder();
                        __tmp83.Append(((Exception)stype).BaseType.GetXsdName());
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
                                __out.Append(__tmp80Suffix);
                                __out.AppendLine(); //62:96
                            }
                        }
                        string __tmp84Prefix = "				"; //63:1
                        string __tmp85Suffix = string.Empty; 
                        StringBuilder __tmp86 = new StringBuilder();
                        __tmp86.Append(GenerateStructuredTypeBody(ns, ((Exception)stype)));
                        using(StreamReader __tmp86Reader = new StreamReader(this.__ToStream(__tmp86.ToString())))
                        {
                            bool __tmp86_first = true;
                            while(__tmp86_first || !__tmp86Reader.EndOfStream)
                            {
                                __tmp86_first = false;
                                string __tmp86Line = __tmp86Reader.ReadLine();
                                if (__tmp86Line == null)
                                {
                                    __tmp86Line = "";
                                }
                                __out.Append(__tmp84Prefix);
                                __out.Append(__tmp86Line);
                                __out.Append(__tmp85Suffix);
                                __out.AppendLine(); //63:44
                            }
                        }
                        __out.Append("			</xs:extension>"); //64:1
                        __out.AppendLine(); //64:19
                        __out.Append("		</xs:complexContent>"); //65:1
                        __out.AppendLine(); //65:23
                    }
                    else //66:5
                    {
                        string __tmp87Prefix = "		"; //67:1
                        string __tmp88Suffix = string.Empty; 
                        StringBuilder __tmp89 = new StringBuilder();
                        __tmp89.Append(GenerateStructuredTypeBody(ns, ((Exception)stype)));
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
                                __out.Append(__tmp87Prefix);
                                __out.Append(__tmp89Line);
                                __out.Append(__tmp88Suffix);
                                __out.AppendLine(); //67:42
                            }
                        }
                    }
                }
                else if (stype is Entity) //69:4
                {
                    if (((Entity)stype).BaseType != null) //70:5
                    {
                        __out.Append("		<xs:complexContent>"); //71:1
                        __out.AppendLine(); //71:22
                        string __tmp90Prefix = "			<xs:extension base=\""; //72:1
                        string __tmp91Suffix = "\">"; //72:94
                        StringBuilder __tmp92 = new StringBuilder();
                        __tmp92.Append(((Entity)stype).BaseType.GetNamespace(ns).Prefix);
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
                        string __tmp93Line = ":"; //72:64
                        __out.Append(__tmp93Line);
                        StringBuilder __tmp94 = new StringBuilder();
                        __tmp94.Append(((Entity)stype).BaseType.GetXsdName());
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
                                __out.Append(__tmp91Suffix);
                                __out.AppendLine(); //72:96
                            }
                        }
                        string __tmp95Prefix = "				"; //73:1
                        string __tmp96Suffix = string.Empty; 
                        StringBuilder __tmp97 = new StringBuilder();
                        __tmp97.Append(GenerateStructuredTypeBody(ns, ((Entity)stype)));
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
                                __out.Append(__tmp95Prefix);
                                __out.Append(__tmp97Line);
                                __out.Append(__tmp96Suffix);
                                __out.AppendLine(); //73:44
                            }
                        }
                        __out.Append("			</xs:extension>"); //74:1
                        __out.AppendLine(); //74:19
                        __out.Append("		</xs:complexContent>"); //75:1
                        __out.AppendLine(); //75:23
                    }
                    else //76:5
                    {
                        string __tmp98Prefix = "		"; //77:1
                        string __tmp99Suffix = string.Empty; 
                        StringBuilder __tmp100 = new StringBuilder();
                        __tmp100.Append(GenerateStructuredTypeBody(ns, ((Entity)stype)));
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
                                __out.Append(__tmp99Suffix);
                                __out.AppendLine(); //77:42
                            }
                        }
                    }
                }
                else //79:4
                {
                    string __tmp101Prefix = "		"; //80:1
                    string __tmp102Suffix = string.Empty; 
                    StringBuilder __tmp103 = new StringBuilder();
                    __tmp103.Append(GenerateStructuredTypeBody(ns, stype));
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
                            __out.Append(__tmp101Prefix);
                            __out.Append(__tmp103Line);
                            __out.Append(__tmp102Suffix);
                            __out.AppendLine(); //80:42
                        }
                    }
                }//81:4
                __out.Append("	</xs:complexType>"); //82:1
                __out.AppendLine(); //82:19
            }
            var __loop7_results = 
                (from __loop7_var1 in __Enumerate((ns.Declarations).GetEnumerator()) //84:8
                from intf in __Enumerate((__loop7_var1).GetEnumerator()).OfType<Interface>() //84:25
                from op in __Enumerate((intf.Operations).GetEnumerator()) //84:49
                select new { __loop7_var1 = __loop7_var1, intf = intf, op = op}
                ).ToList(); //84:3
            int __loop7_iteration = 0;
            foreach (var __tmp104 in __loop7_results)
            {
                ++__loop7_iteration;
                var __loop7_var1 = __tmp104.__loop7_var1;
                var intf = __tmp104.intf;
                var op = __tmp104.op;
                if (!intf.HasAnnotation(SoalAnnotations.Rpc)) //85:4
                {
                    if (intf.HasAnnotation(SoalAnnotations.NoWrap)) //86:4
                    {
                        var __loop8_results = 
                            (from __loop8_var1 in __Enumerate((op).GetEnumerator()) //87:10
                            from param in __Enumerate((__loop8_var1.Parameters).GetEnumerator()) //87:14
                            select new { __loop8_var1 = __loop8_var1, param = param}
                            ).ToList(); //87:5
                        int __loop8_iteration = 0;
                        foreach (var __tmp105 in __loop8_results)
                        {
                            ++__loop8_iteration;
                            var __loop8_var1 = __tmp105.__loop8_var1;
                            var param = __tmp105.param;
                            string __tmp106Prefix = "	"; //88:1
                            string __tmp107Suffix = string.Empty; 
                            StringBuilder __tmp108 = new StringBuilder();
                            __tmp108.Append(GenerateElement(ns, op.Name + param.Name.ToPascalCase(), param.Type, param.Annotations));
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
                                    __out.AppendLine(); //88:91
                                }
                            }
                        }
                        if (op.ReturnType != SoalInstance.Void) //90:5
                        {
                            string __tmp109Prefix = "	"; //91:1
                            string __tmp110Suffix = string.Empty; 
                            StringBuilder __tmp111 = new StringBuilder();
                            __tmp111.Append(GenerateElement(ns, op.Name + "Response", op.ReturnType, op.ReturnAnnotations));
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
                                    __out.AppendLine(); //91:80
                                }
                            }
                        }
                    }
                    else //93:4
                    {
                        __out.AppendLine(); //94:1
                        string __tmp112Prefix = "	<xs:element name=\""; //95:1
                        string __tmp113Suffix = "\"/>"; //95:58
                        StringBuilder __tmp114 = new StringBuilder();
                        __tmp114.Append(op.Name);
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
                                __out.Append(__tmp112Prefix);
                                __out.Append(__tmp114Line);
                            }
                        }
                        string __tmp115Line = "\" type=\""; //95:29
                        __out.Append(__tmp115Line);
                        StringBuilder __tmp116 = new StringBuilder();
                        __tmp116.Append(ns.Prefix);
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
                            }
                        }
                        string __tmp117Line = ":"; //95:48
                        __out.Append(__tmp117Line);
                        StringBuilder __tmp118 = new StringBuilder();
                        __tmp118.Append(op.Name);
                        using(StreamReader __tmp118Reader = new StreamReader(this.__ToStream(__tmp118.ToString())))
                        {
                            bool __tmp118_first = true;
                            while(__tmp118_first || !__tmp118Reader.EndOfStream)
                            {
                                __tmp118_first = false;
                                string __tmp118Line = __tmp118Reader.ReadLine();
                                if (__tmp118Line == null)
                                {
                                    __tmp118Line = "";
                                }
                                __out.Append(__tmp118Line);
                                __out.Append(__tmp113Suffix);
                                __out.AppendLine(); //95:61
                            }
                        }
                        string __tmp119Prefix = "	<xs:complexType name=\""; //96:1
                        string __tmp120Suffix = "\">"; //96:33
                        StringBuilder __tmp121 = new StringBuilder();
                        __tmp121.Append(op.Name);
                        using(StreamReader __tmp121Reader = new StreamReader(this.__ToStream(__tmp121.ToString())))
                        {
                            bool __tmp121_first = true;
                            while(__tmp121_first || !__tmp121Reader.EndOfStream)
                            {
                                __tmp121_first = false;
                                string __tmp121Line = __tmp121Reader.ReadLine();
                                if (__tmp121Line == null)
                                {
                                    __tmp121Line = "";
                                }
                                __out.Append(__tmp119Prefix);
                                __out.Append(__tmp121Line);
                                __out.Append(__tmp120Suffix);
                                __out.AppendLine(); //96:35
                            }
                        }
                        __out.Append("		<xs:sequence>"); //97:1
                        __out.AppendLine(); //97:16
                        var __loop9_results = 
                            (from __loop9_var1 in __Enumerate((op).GetEnumerator()) //98:10
                            from param in __Enumerate((__loop9_var1.Parameters).GetEnumerator()) //98:14
                            where !param.HasAnnotation(SoalAnnotations.Attribute) //98:31
                            select new { __loop9_var1 = __loop9_var1, param = param}
                            ).ToList(); //98:5
                        int __loop9_iteration = 0;
                        foreach (var __tmp122 in __loop9_results)
                        {
                            ++__loop9_iteration;
                            var __loop9_var1 = __tmp122.__loop9_var1;
                            var param = __tmp122.param;
                            string __tmp123Prefix = "			"; //99:1
                            string __tmp124Suffix = string.Empty; 
                            StringBuilder __tmp125 = new StringBuilder();
                            __tmp125.Append(GenerateElement(ns, param.Name, param.Type, param.Annotations));
                            using(StreamReader __tmp125Reader = new StreamReader(this.__ToStream(__tmp125.ToString())))
                            {
                                bool __tmp125_first = true;
                                while(__tmp125_first || !__tmp125Reader.EndOfStream)
                                {
                                    __tmp125_first = false;
                                    string __tmp125Line = __tmp125Reader.ReadLine();
                                    if (__tmp125Line == null)
                                    {
                                        __tmp125Line = "";
                                    }
                                    __out.Append(__tmp123Prefix);
                                    __out.Append(__tmp125Line);
                                    __out.Append(__tmp124Suffix);
                                    __out.AppendLine(); //99:68
                                }
                            }
                        }
                        __out.Append("		</xs:sequence>"); //101:1
                        __out.AppendLine(); //101:17
                        var __loop10_results = 
                            (from __loop10_var1 in __Enumerate((op).GetEnumerator()) //102:9
                            from param in __Enumerate((__loop10_var1.Parameters).GetEnumerator()) //102:13
                            where param.HasAnnotation(SoalAnnotations.Attribute) //102:30
                            select new { __loop10_var1 = __loop10_var1, param = param}
                            ).ToList(); //102:4
                        int __loop10_iteration = 0;
                        foreach (var __tmp126 in __loop10_results)
                        {
                            ++__loop10_iteration;
                            var __loop10_var1 = __tmp126.__loop10_var1;
                            var param = __tmp126.param;
                            string __tmp127Prefix = "		"; //103:1
                            string __tmp128Suffix = string.Empty; 
                            StringBuilder __tmp129 = new StringBuilder();
                            __tmp129.Append(GenerateElement(ns, param.Name, param.Type, param.Annotations));
                            using(StreamReader __tmp129Reader = new StreamReader(this.__ToStream(__tmp129.ToString())))
                            {
                                bool __tmp129_first = true;
                                while(__tmp129_first || !__tmp129Reader.EndOfStream)
                                {
                                    __tmp129_first = false;
                                    string __tmp129Line = __tmp129Reader.ReadLine();
                                    if (__tmp129Line == null)
                                    {
                                        __tmp129Line = "";
                                    }
                                    __out.Append(__tmp127Prefix);
                                    __out.Append(__tmp129Line);
                                    __out.Append(__tmp128Suffix);
                                    __out.AppendLine(); //103:67
                                }
                            }
                        }
                        __out.Append("	</xs:complexType>"); //105:1
                        __out.AppendLine(); //105:19
                        if (!op.IsOneway) //106:4
                        {
                            __out.AppendLine(); //107:1
                            string __tmp130Prefix = "	<xs:element name=\""; //108:1
                            string __tmp131Suffix = "Response\"/>"; //108:66
                            StringBuilder __tmp132 = new StringBuilder();
                            __tmp132.Append(op.Name);
                            using(StreamReader __tmp132Reader = new StreamReader(this.__ToStream(__tmp132.ToString())))
                            {
                                bool __tmp132_first = true;
                                while(__tmp132_first || !__tmp132Reader.EndOfStream)
                                {
                                    __tmp132_first = false;
                                    string __tmp132Line = __tmp132Reader.ReadLine();
                                    if (__tmp132Line == null)
                                    {
                                        __tmp132Line = "";
                                    }
                                    __out.Append(__tmp130Prefix);
                                    __out.Append(__tmp132Line);
                                }
                            }
                            string __tmp133Line = "Response\" type=\""; //108:29
                            __out.Append(__tmp133Line);
                            StringBuilder __tmp134 = new StringBuilder();
                            __tmp134.Append(ns.Prefix);
                            using(StreamReader __tmp134Reader = new StreamReader(this.__ToStream(__tmp134.ToString())))
                            {
                                bool __tmp134_first = true;
                                while(__tmp134_first || !__tmp134Reader.EndOfStream)
                                {
                                    __tmp134_first = false;
                                    string __tmp134Line = __tmp134Reader.ReadLine();
                                    if (__tmp134Line == null)
                                    {
                                        __tmp134Line = "";
                                    }
                                    __out.Append(__tmp134Line);
                                }
                            }
                            string __tmp135Line = ":"; //108:56
                            __out.Append(__tmp135Line);
                            StringBuilder __tmp136 = new StringBuilder();
                            __tmp136.Append(op.Name);
                            using(StreamReader __tmp136Reader = new StreamReader(this.__ToStream(__tmp136.ToString())))
                            {
                                bool __tmp136_first = true;
                                while(__tmp136_first || !__tmp136Reader.EndOfStream)
                                {
                                    __tmp136_first = false;
                                    string __tmp136Line = __tmp136Reader.ReadLine();
                                    if (__tmp136Line == null)
                                    {
                                        __tmp136Line = "";
                                    }
                                    __out.Append(__tmp136Line);
                                    __out.Append(__tmp131Suffix);
                                    __out.AppendLine(); //108:77
                                }
                            }
                            string __tmp137Prefix = "	<xs:complexType name=\""; //109:1
                            string __tmp138Suffix = "Response\">"; //109:33
                            StringBuilder __tmp139 = new StringBuilder();
                            __tmp139.Append(op.Name);
                            using(StreamReader __tmp139Reader = new StreamReader(this.__ToStream(__tmp139.ToString())))
                            {
                                bool __tmp139_first = true;
                                while(__tmp139_first || !__tmp139Reader.EndOfStream)
                                {
                                    __tmp139_first = false;
                                    string __tmp139Line = __tmp139Reader.ReadLine();
                                    if (__tmp139Line == null)
                                    {
                                        __tmp139Line = "";
                                    }
                                    __out.Append(__tmp137Prefix);
                                    __out.Append(__tmp139Line);
                                    __out.Append(__tmp138Suffix);
                                    __out.AppendLine(); //109:43
                                }
                            }
                            if (op.ReturnType == SoalInstance.Void || op.ReturnAnnotations.ContainsAnnotation(SoalAnnotations.Attribute)) //110:5
                            {
                                __out.Append("		<xs:sequence/>"); //111:1
                                __out.AppendLine(); //111:17
                            }
                            else //112:5
                            {
                                __out.Append("		<xs:sequence>"); //113:1
                                __out.AppendLine(); //113:16
                                string __tmp140Prefix = "			"; //114:1
                                string __tmp141Suffix = string.Empty; 
                                StringBuilder __tmp142 = new StringBuilder();
                                __tmp142.Append(GenerateElement(ns, op.Name + "Result", op.ReturnType, op.ReturnAnnotations));
                                using(StreamReader __tmp142Reader = new StreamReader(this.__ToStream(__tmp142.ToString())))
                                {
                                    bool __tmp142_first = true;
                                    while(__tmp142_first || !__tmp142Reader.EndOfStream)
                                    {
                                        __tmp142_first = false;
                                        string __tmp142Line = __tmp142Reader.ReadLine();
                                        if (__tmp142Line == null)
                                        {
                                            __tmp142Line = "";
                                        }
                                        __out.Append(__tmp140Prefix);
                                        __out.Append(__tmp142Line);
                                        __out.Append(__tmp141Suffix);
                                        __out.AppendLine(); //114:80
                                    }
                                }
                                __out.Append("		</xs:sequence>"); //115:1
                                __out.AppendLine(); //115:17
                            }
                            if (op.ReturnAnnotations.ContainsAnnotation(SoalAnnotations.Attribute)) //117:4
                            {
                                string __tmp143Prefix = "		"; //118:1
                                string __tmp144Suffix = string.Empty; 
                                StringBuilder __tmp145 = new StringBuilder();
                                __tmp145.Append(GenerateElement(ns, op.Name + "Result", op.ReturnType, op.ReturnAnnotations));
                                using(StreamReader __tmp145Reader = new StreamReader(this.__ToStream(__tmp145.ToString())))
                                {
                                    bool __tmp145_first = true;
                                    while(__tmp145_first || !__tmp145Reader.EndOfStream)
                                    {
                                        __tmp145_first = false;
                                        string __tmp145Line = __tmp145Reader.ReadLine();
                                        if (__tmp145Line == null)
                                        {
                                            __tmp145Line = "";
                                        }
                                        __out.Append(__tmp143Prefix);
                                        __out.Append(__tmp145Line);
                                        __out.Append(__tmp144Suffix);
                                        __out.AppendLine(); //118:79
                                    }
                                }
                            }
                            __out.Append("	</xs:complexType>"); //120:1
                            __out.AppendLine(); //120:19
                        }
                    }
                }
            }
            __out.Append("</xs:schema>"); //125:1
            __out.AppendLine(); //125:13
            return __out.ToString();
        }

        public string GenerateStructuredTypeBody(Namespace ns, StructuredType stype) //128:1
        {
            StringBuilder __out = new StringBuilder();
            string __tmp1Prefix = "<xs:"; //129:1
            string __tmp2Suffix = ">"; //129:27
            StringBuilder __tmp3 = new StringBuilder();
            __tmp3.Append(GetStructKind(stype));
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
                    __out.AppendLine(); //129:28
                }
            }
            var __loop11_results = 
                (from __loop11_var1 in __Enumerate((stype).GetEnumerator()) //130:8
                from prop in __Enumerate((__loop11_var1.Properties).GetEnumerator()) //130:15
                where !prop.HasAnnotation(SoalAnnotations.Attribute) //130:31
                select new { __loop11_var1 = __loop11_var1, prop = prop}
                ).ToList(); //130:3
            int __loop11_iteration = 0;
            foreach (var __tmp4 in __loop11_results)
            {
                ++__loop11_iteration;
                var __loop11_var1 = __tmp4.__loop11_var1;
                var prop = __tmp4.prop;
                string __tmp5Prefix = "	"; //131:1
                string __tmp6Suffix = string.Empty; 
                StringBuilder __tmp7 = new StringBuilder();
                __tmp7.Append(GenerateElement(ns, prop.Name, prop.Type, prop.Annotations));
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
                        __out.Append(__tmp5Prefix);
                        __out.Append(__tmp7Line);
                        __out.Append(__tmp6Suffix);
                        __out.AppendLine(); //131:63
                    }
                }
            }
            string __tmp8Prefix = "</xs:"; //133:1
            string __tmp9Suffix = ">"; //133:28
            StringBuilder __tmp10 = new StringBuilder();
            __tmp10.Append(GetStructKind(stype));
            using(StreamReader __tmp10Reader = new StreamReader(this.__ToStream(__tmp10.ToString())))
            {
                bool __tmp10_first = true;
                while(__tmp10_first || !__tmp10Reader.EndOfStream)
                {
                    __tmp10_first = false;
                    string __tmp10Line = __tmp10Reader.ReadLine();
                    if (__tmp10Line == null)
                    {
                        __tmp10Line = "";
                    }
                    __out.Append(__tmp8Prefix);
                    __out.Append(__tmp10Line);
                    __out.Append(__tmp9Suffix);
                    __out.AppendLine(); //133:29
                }
            }
            var __loop12_results = 
                (from __loop12_var1 in __Enumerate((stype).GetEnumerator()) //134:7
                from prop in __Enumerate((__loop12_var1.Properties).GetEnumerator()) //134:14
                where prop.HasAnnotation(SoalAnnotations.Attribute) //134:30
                select new { __loop12_var1 = __loop12_var1, prop = prop}
                ).ToList(); //134:2
            int __loop12_iteration = 0;
            foreach (var __tmp11 in __loop12_results)
            {
                ++__loop12_iteration;
                var __loop12_var1 = __tmp11.__loop12_var1;
                var prop = __tmp11.prop;
                string __tmp12Prefix = string.Empty;
                string __tmp13Suffix = string.Empty;
                StringBuilder __tmp14 = new StringBuilder();
                __tmp14.Append(GenerateElement(ns, prop.Name, prop.Type, prop.Annotations));
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
                        __out.Append(__tmp12Prefix);
                        __out.Append(__tmp14Line);
                        __out.Append(__tmp13Suffix);
                        __out.AppendLine(); //135:62
                    }
                }
            }
            return __out.ToString();
        }

        public string GenerateElement(Namespace ns, string name, SoalType t, IList<Annotation> annots) //139:1
        {
            StringBuilder __out = new StringBuilder();
            if (annots.ContainsAnnotation(SoalAnnotations.Attribute)) //140:2
            {
                if ((t is ArrayType || (t is NonNullableType && ((NonNullableType)t).InnerType is ArrayType)) && annots.ContainsAnnotation(SoalAnnotations.NoWrap)) //141:3
                {
                    if (t is ArrayType) //142:4
                    {
                        string __tmp1Prefix = "<xs:attribute name=\""; //143:1
                        string __tmp2Suffix = "/>"; //143:156
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
                        string __tmp4Line = "\" type=\""; //143:27
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
                        string __tmp6Line = ":"; //143:85
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
                        string __tmp8Line = "\""; //143:125
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
                                __out.AppendLine(); //143:158
                            }
                        }
                    }
                    else //144:4
                    {
                        string __tmp10Prefix = "<xs:attribute name=\""; //145:1
                        string __tmp11Suffix = "/>"; //145:214
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
                        string __tmp13Line = "\" type=\""; //145:27
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
                        string __tmp15Line = ":"; //145:114
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
                        string __tmp17Line = "\""; //145:183
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
                                __out.AppendLine(); //145:216
                            }
                        }
                    }
                }
                else //147:3
                {
                    string __tmp19Prefix = "<xs:attribute name=\""; //148:1
                    string __tmp20Suffix = "/>"; //148:110
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
                    string __tmp22Line = "\" type=\""; //148:27
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
                    string __tmp24Line = ":"; //148:62
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
                    string __tmp26Line = "\""; //148:79
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
                            __out.AppendLine(); //148:112
                        }
                    }
                }
            }
            else //150:2
            {
                if ((t is ArrayType || (t is NonNullableType && ((NonNullableType)t).InnerType is ArrayType)) && annots.ContainsAnnotation(SoalAnnotations.NoWrap)) //151:3
                {
                    if (t is ArrayType) //152:4
                    {
                        string __tmp28Prefix = "<xs:element name=\""; //153:1
                        string __tmp29Suffix = "\" minOccurs=\"0\" maxOccurs=\"unbounded\"/>"; //153:177
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
                        string __tmp31Line = "\" type=\""; //153:25
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
                        string __tmp33Line = ":"; //153:83
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
                        string __tmp35Line = "\" nillable=\""; //153:123
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
                                __out.AppendLine(); //153:216
                            }
                        }
                    }
                    else //154:4
                    {
                        string __tmp37Prefix = "<xs:element name=\""; //155:1
                        string __tmp38Suffix = "\" minOccurs=\"0\" maxOccurs=\"unbounded\"/>"; //155:264
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
                        string __tmp40Line = "\" type=\""; //155:25
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
                        string __tmp42Line = ":"; //155:112
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
                        string __tmp44Line = "\" nillable=\""; //155:181
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
                                __out.AppendLine(); //155:303
                            }
                        }
                    }
                }
                else //157:3
                {
                    string __tmp46Prefix = "<xs:element name=\""; //158:1
                    string __tmp47Suffix = "/>"; //158:137
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
                    string __tmp49Line = "\" type=\""; //158:25
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
                    string __tmp51Line = ":"; //158:60
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
                    string __tmp53Line = "\" nillable=\""; //158:77
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
                        }
                    }
                    string __tmp55Line = "\""; //158:108
                    __out.Append(__tmp55Line);
                    StringBuilder __tmp56 = new StringBuilder();
                    __tmp56.Append(GetElementOptional(annots));
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
                            __out.Append(__tmp56Line);
                            __out.Append(__tmp47Suffix);
                            __out.AppendLine(); //158:139
                        }
                    }
                }
            }
            return __out.ToString();
        }

        public string GetStructKind(StructuredType st) //163:1
        {
            if (st.HasAnnotation(SoalAnnotations.Choice)) //164:2
            {
                return "choice"; //165:3
            }
            else if (st.HasAnnotation(SoalAnnotations.All)) //166:2
            {
                return "all"; //167:3
            }
            else //168:2
            {
                return "sequence"; //169:3
            }
        }

        public string GetElementOptional(IList<Annotation> annots) //173:1
        {
            if (!annots.ContainsAnnotation(SoalAnnotations.Attribute) && annots.ContainsAnnotation(SoalAnnotations.Optional)) //174:2
            {
                return " minOccurs=\"0\""; //175:3
            }
            else //176:2
            {
                return ""; //177:3
            }
        }

        public string GetAttributeRequired(IList<Annotation> annots) //181:1
        {
            if (annots.ContainsAnnotation(SoalAnnotations.Attribute) && annots.ContainsAnnotation(SoalAnnotations.Required)) //182:2
            {
                return " use=\"required\""; //183:3
            }
            else //184:2
            {
                return ""; //185:3
            }
        }

    }
}
