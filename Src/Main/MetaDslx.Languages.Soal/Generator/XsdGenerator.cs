using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetaDslx.Languages.Soal.Symbols; //4:1

namespace MetaDslx.Languages.Soal.Generator //1:1
{
    using __Hidden_XsdGenerator_108465281;
    namespace __Hidden_XsdGenerator_108465281
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

        public __Properties Properties { get; private set; } //6:1

        public class __Properties //6:1
        {
            internal __Properties()
            {
                this.ImportXsd = true; //7:19
            }
            public bool ImportXsd { get; set; } //7:2
        }

        public string Generate(Namespace ns) //10:1
        {
            StringBuilder __out = new StringBuilder();
            __out.Append("<?xml version=\"1.0\" encoding=\"utf-8\"?>"); //11:1
            __out.AppendLine(false); //11:39
            bool __tmp2_outputWritten = false;
            string __tmp3_line = "<xs:schema targetNamespace=\""; //12:1
            if (!string.IsNullOrEmpty(__tmp3_line))
            {
                __out.Append(__tmp3_line);
                __tmp2_outputWritten = true;
            }
            StringBuilder __tmp4 = new StringBuilder();
            __tmp4.Append(ns.Uri);
            using(StreamReader __tmp4Reader = new StreamReader(this.__ToStream(__tmp4.ToString())))
            {
                bool __tmp4_last = __tmp4Reader.EndOfStream;
                while(!__tmp4_last)
                {
                    string __tmp4_line = __tmp4Reader.ReadLine();
                    __tmp4_last = __tmp4Reader.EndOfStream;
                    if ((__tmp4_last && !string.IsNullOrEmpty(__tmp4_line)) || (!__tmp4_last && __tmp4_line != null))
                    {
                        __out.Append(__tmp4_line);
                        __tmp2_outputWritten = true;
                    }
                    if (!__tmp4_last) __out.AppendLine(true);
                }
            }
            string __tmp5_line = "\""; //12:37
            if (!string.IsNullOrEmpty(__tmp5_line))
            {
                __out.Append(__tmp5_line);
                __tmp2_outputWritten = true;
            }
            if (__tmp2_outputWritten) __out.AppendLine(true);
            if (__tmp2_outputWritten)
            {
                __out.AppendLine(false); //12:38
            }
            __out.Append("		xmlns:xs=\"http://www.w3.org/2001/XMLSchema\""); //13:1
            __out.AppendLine(false); //13:46
            bool __tmp7_outputWritten = false;
            string __tmp8_line = "		xmlns:"; //14:1
            if (!string.IsNullOrEmpty(__tmp8_line))
            {
                __out.Append(__tmp8_line);
                __tmp7_outputWritten = true;
            }
            StringBuilder __tmp9 = new StringBuilder();
            __tmp9.Append(ns.Prefix);
            using(StreamReader __tmp9Reader = new StreamReader(this.__ToStream(__tmp9.ToString())))
            {
                bool __tmp9_last = __tmp9Reader.EndOfStream;
                while(!__tmp9_last)
                {
                    string __tmp9_line = __tmp9Reader.ReadLine();
                    __tmp9_last = __tmp9Reader.EndOfStream;
                    if ((__tmp9_last && !string.IsNullOrEmpty(__tmp9_line)) || (!__tmp9_last && __tmp9_line != null))
                    {
                        __out.Append(__tmp9_line);
                        __tmp7_outputWritten = true;
                    }
                    if (!__tmp9_last) __out.AppendLine(true);
                }
            }
            string __tmp10_line = "=\""; //14:20
            if (!string.IsNullOrEmpty(__tmp10_line))
            {
                __out.Append(__tmp10_line);
                __tmp7_outputWritten = true;
            }
            StringBuilder __tmp11 = new StringBuilder();
            __tmp11.Append(ns.Uri);
            using(StreamReader __tmp11Reader = new StreamReader(this.__ToStream(__tmp11.ToString())))
            {
                bool __tmp11_last = __tmp11Reader.EndOfStream;
                while(!__tmp11_last)
                {
                    string __tmp11_line = __tmp11Reader.ReadLine();
                    __tmp11_last = __tmp11Reader.EndOfStream;
                    if ((__tmp11_last && !string.IsNullOrEmpty(__tmp11_line)) || (!__tmp11_last && __tmp11_line != null))
                    {
                        __out.Append(__tmp11_line);
                        __tmp7_outputWritten = true;
                    }
                    if (!__tmp11_last) __out.AppendLine(true);
                }
            }
            string __tmp12_line = "\""; //14:30
            if (!string.IsNullOrEmpty(__tmp12_line))
            {
                __out.Append(__tmp12_line);
                __tmp7_outputWritten = true;
            }
            if (__tmp7_outputWritten) __out.AppendLine(true);
            if (__tmp7_outputWritten)
            {
                __out.AppendLine(false); //14:31
            }
            if (Properties.ImportXsd) //15:3
            {
                var __loop1_results = 
                    (from ins in __Enumerate((ns.GetImportedNamespaces()).GetEnumerator()) //16:9
                    select new { ins = ins}
                    ).ToList(); //16:4
                for (int __loop1_iteration = 0; __loop1_iteration < __loop1_results.Count; ++__loop1_iteration)
                {
                    var __tmp13 = __loop1_results[__loop1_iteration];
                    var ins = __tmp13.ins;
                    bool __tmp15_outputWritten = false;
                    string __tmp16_line = "		xmlns:"; //17:1
                    if (!string.IsNullOrEmpty(__tmp16_line))
                    {
                        __out.Append(__tmp16_line);
                        __tmp15_outputWritten = true;
                    }
                    StringBuilder __tmp17 = new StringBuilder();
                    __tmp17.Append(ins.Prefix);
                    using(StreamReader __tmp17Reader = new StreamReader(this.__ToStream(__tmp17.ToString())))
                    {
                        bool __tmp17_last = __tmp17Reader.EndOfStream;
                        while(!__tmp17_last)
                        {
                            string __tmp17_line = __tmp17Reader.ReadLine();
                            __tmp17_last = __tmp17Reader.EndOfStream;
                            if ((__tmp17_last && !string.IsNullOrEmpty(__tmp17_line)) || (!__tmp17_last && __tmp17_line != null))
                            {
                                __out.Append(__tmp17_line);
                                __tmp15_outputWritten = true;
                            }
                            if (!__tmp17_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp18_line = "=\""; //17:21
                    if (!string.IsNullOrEmpty(__tmp18_line))
                    {
                        __out.Append(__tmp18_line);
                        __tmp15_outputWritten = true;
                    }
                    StringBuilder __tmp19 = new StringBuilder();
                    __tmp19.Append(ins.Uri);
                    using(StreamReader __tmp19Reader = new StreamReader(this.__ToStream(__tmp19.ToString())))
                    {
                        bool __tmp19_last = __tmp19Reader.EndOfStream;
                        while(!__tmp19_last)
                        {
                            string __tmp19_line = __tmp19Reader.ReadLine();
                            __tmp19_last = __tmp19Reader.EndOfStream;
                            if ((__tmp19_last && !string.IsNullOrEmpty(__tmp19_line)) || (!__tmp19_last && __tmp19_line != null))
                            {
                                __out.Append(__tmp19_line);
                                __tmp15_outputWritten = true;
                            }
                            if (!__tmp19_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp20_line = "\""; //17:32
                    if (!string.IsNullOrEmpty(__tmp20_line))
                    {
                        __out.Append(__tmp20_line);
                        __tmp15_outputWritten = true;
                    }
                    if (__tmp15_outputWritten) __out.AppendLine(true);
                    if (__tmp15_outputWritten)
                    {
                        __out.AppendLine(false); //17:33
                    }
                }
            }
            __out.Append("		elementFormDefault=\"qualified\">"); //20:1
            __out.AppendLine(false); //20:34
            if (Properties.ImportXsd) //21:3
            {
                var __loop2_results = 
                    (from ins in __Enumerate((ns.GetImportedNamespaces()).GetEnumerator()) //22:9
                    select new { ins = ins}
                    ).ToList(); //22:4
                for (int __loop2_iteration = 0; __loop2_iteration < __loop2_results.Count; ++__loop2_iteration)
                {
                    var __tmp21 = __loop2_results[__loop2_iteration];
                    var ins = __tmp21.ins;
                    bool __tmp23_outputWritten = false;
                    string __tmp24_line = "	<xs:import namespace=\""; //23:1
                    if (!string.IsNullOrEmpty(__tmp24_line))
                    {
                        __out.Append(__tmp24_line);
                        __tmp23_outputWritten = true;
                    }
                    StringBuilder __tmp25 = new StringBuilder();
                    __tmp25.Append(ins.Uri);
                    using(StreamReader __tmp25Reader = new StreamReader(this.__ToStream(__tmp25.ToString())))
                    {
                        bool __tmp25_last = __tmp25Reader.EndOfStream;
                        while(!__tmp25_last)
                        {
                            string __tmp25_line = __tmp25Reader.ReadLine();
                            __tmp25_last = __tmp25Reader.EndOfStream;
                            if ((__tmp25_last && !string.IsNullOrEmpty(__tmp25_line)) || (!__tmp25_last && __tmp25_line != null))
                            {
                                __out.Append(__tmp25_line);
                                __tmp23_outputWritten = true;
                            }
                            if (!__tmp25_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp26_line = "\" schemaLocation=\""; //23:33
                    if (!string.IsNullOrEmpty(__tmp26_line))
                    {
                        __out.Append(__tmp26_line);
                        __tmp23_outputWritten = true;
                    }
                    StringBuilder __tmp27 = new StringBuilder();
                    __tmp27.Append(ins.FullName);
                    using(StreamReader __tmp27Reader = new StreamReader(this.__ToStream(__tmp27.ToString())))
                    {
                        bool __tmp27_last = __tmp27Reader.EndOfStream;
                        while(!__tmp27_last)
                        {
                            string __tmp27_line = __tmp27Reader.ReadLine();
                            __tmp27_last = __tmp27Reader.EndOfStream;
                            if ((__tmp27_last && !string.IsNullOrEmpty(__tmp27_line)) || (!__tmp27_last && __tmp27_line != null))
                            {
                                __out.Append(__tmp27_line);
                                __tmp23_outputWritten = true;
                            }
                            if (!__tmp27_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp28_line = ".xsd\"/>"; //23:65
                    if (!string.IsNullOrEmpty(__tmp28_line))
                    {
                        __out.Append(__tmp28_line);
                        __tmp23_outputWritten = true;
                    }
                    if (__tmp23_outputWritten) __out.AppendLine(true);
                    if (__tmp23_outputWritten)
                    {
                        __out.AppendLine(false); //23:72
                    }
                }
            }
            var __loop3_results = 
                (from __loop3_var1 in __Enumerate((ns.Declarations).GetEnumerator()) //26:8
                from etype in __Enumerate((__loop3_var1).GetEnumerator()).OfType<Symbols.Enum>() //26:25
                select new { __loop3_var1 = __loop3_var1, etype = etype}
                ).ToList(); //26:3
            for (int __loop3_iteration = 0; __loop3_iteration < __loop3_results.Count; ++__loop3_iteration)
            {
                var __tmp29 = __loop3_results[__loop3_iteration];
                var __loop3_var1 = __tmp29.__loop3_var1;
                var etype = __tmp29.etype;
                __out.AppendLine(true); //27:1
                bool __tmp31_outputWritten = false;
                string __tmp32_line = "	<xs:element name=\""; //28:1
                if (!string.IsNullOrEmpty(__tmp32_line))
                {
                    __out.Append(__tmp32_line);
                    __tmp31_outputWritten = true;
                }
                StringBuilder __tmp33 = new StringBuilder();
                __tmp33.Append(etype.GetXsdName());
                using(StreamReader __tmp33Reader = new StreamReader(this.__ToStream(__tmp33.ToString())))
                {
                    bool __tmp33_last = __tmp33Reader.EndOfStream;
                    while(!__tmp33_last)
                    {
                        string __tmp33_line = __tmp33Reader.ReadLine();
                        __tmp33_last = __tmp33Reader.EndOfStream;
                        if ((__tmp33_last && !string.IsNullOrEmpty(__tmp33_line)) || (!__tmp33_last && __tmp33_line != null))
                        {
                            __out.Append(__tmp33_line);
                            __tmp31_outputWritten = true;
                        }
                        if (!__tmp33_last) __out.AppendLine(true);
                    }
                }
                string __tmp34_line = "\" type=\""; //28:40
                if (!string.IsNullOrEmpty(__tmp34_line))
                {
                    __out.Append(__tmp34_line);
                    __tmp31_outputWritten = true;
                }
                StringBuilder __tmp35 = new StringBuilder();
                __tmp35.Append(ns.Prefix);
                using(StreamReader __tmp35Reader = new StreamReader(this.__ToStream(__tmp35.ToString())))
                {
                    bool __tmp35_last = __tmp35Reader.EndOfStream;
                    while(!__tmp35_last)
                    {
                        string __tmp35_line = __tmp35Reader.ReadLine();
                        __tmp35_last = __tmp35Reader.EndOfStream;
                        if ((__tmp35_last && !string.IsNullOrEmpty(__tmp35_line)) || (!__tmp35_last && __tmp35_line != null))
                        {
                            __out.Append(__tmp35_line);
                            __tmp31_outputWritten = true;
                        }
                        if (!__tmp35_last) __out.AppendLine(true);
                    }
                }
                string __tmp36_line = ":"; //28:59
                if (!string.IsNullOrEmpty(__tmp36_line))
                {
                    __out.Append(__tmp36_line);
                    __tmp31_outputWritten = true;
                }
                StringBuilder __tmp37 = new StringBuilder();
                __tmp37.Append(etype.GetXsdName());
                using(StreamReader __tmp37Reader = new StreamReader(this.__ToStream(__tmp37.ToString())))
                {
                    bool __tmp37_last = __tmp37Reader.EndOfStream;
                    while(!__tmp37_last)
                    {
                        string __tmp37_line = __tmp37Reader.ReadLine();
                        __tmp37_last = __tmp37Reader.EndOfStream;
                        if ((__tmp37_last && !string.IsNullOrEmpty(__tmp37_line)) || (!__tmp37_last && __tmp37_line != null))
                        {
                            __out.Append(__tmp37_line);
                            __tmp31_outputWritten = true;
                        }
                        if (!__tmp37_last) __out.AppendLine(true);
                    }
                }
                string __tmp38_line = "\"/>"; //28:80
                if (!string.IsNullOrEmpty(__tmp38_line))
                {
                    __out.Append(__tmp38_line);
                    __tmp31_outputWritten = true;
                }
                if (__tmp31_outputWritten) __out.AppendLine(true);
                if (__tmp31_outputWritten)
                {
                    __out.AppendLine(false); //28:83
                }
                bool __tmp40_outputWritten = false;
                string __tmp41_line = "	<xs:simpleType name=\""; //29:1
                if (!string.IsNullOrEmpty(__tmp41_line))
                {
                    __out.Append(__tmp41_line);
                    __tmp40_outputWritten = true;
                }
                StringBuilder __tmp42 = new StringBuilder();
                __tmp42.Append(etype.GetXsdName());
                using(StreamReader __tmp42Reader = new StreamReader(this.__ToStream(__tmp42.ToString())))
                {
                    bool __tmp42_last = __tmp42Reader.EndOfStream;
                    while(!__tmp42_last)
                    {
                        string __tmp42_line = __tmp42Reader.ReadLine();
                        __tmp42_last = __tmp42Reader.EndOfStream;
                        if ((__tmp42_last && !string.IsNullOrEmpty(__tmp42_line)) || (!__tmp42_last && __tmp42_line != null))
                        {
                            __out.Append(__tmp42_line);
                            __tmp40_outputWritten = true;
                        }
                        if (!__tmp42_last) __out.AppendLine(true);
                    }
                }
                string __tmp43_line = "\">"; //29:43
                if (!string.IsNullOrEmpty(__tmp43_line))
                {
                    __out.Append(__tmp43_line);
                    __tmp40_outputWritten = true;
                }
                if (__tmp40_outputWritten) __out.AppendLine(true);
                if (__tmp40_outputWritten)
                {
                    __out.AppendLine(false); //29:45
                }
                if (etype.BaseType != null) //30:4
                {
                    bool __tmp45_outputWritten = false;
                    string __tmp46_line = "		<xs:restriction base=\""; //31:1
                    if (!string.IsNullOrEmpty(__tmp46_line))
                    {
                        __out.Append(__tmp46_line);
                        __tmp45_outputWritten = true;
                    }
                    StringBuilder __tmp47 = new StringBuilder();
                    __tmp47.Append(etype.BaseType.GetNamespace(ns).Prefix);
                    using(StreamReader __tmp47Reader = new StreamReader(this.__ToStream(__tmp47.ToString())))
                    {
                        bool __tmp47_last = __tmp47Reader.EndOfStream;
                        while(!__tmp47_last)
                        {
                            string __tmp47_line = __tmp47Reader.ReadLine();
                            __tmp47_last = __tmp47Reader.EndOfStream;
                            if ((__tmp47_last && !string.IsNullOrEmpty(__tmp47_line)) || (!__tmp47_last && __tmp47_line != null))
                            {
                                __out.Append(__tmp47_line);
                                __tmp45_outputWritten = true;
                            }
                            if (!__tmp47_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp48_line = ":"; //31:65
                    if (!string.IsNullOrEmpty(__tmp48_line))
                    {
                        __out.Append(__tmp48_line);
                        __tmp45_outputWritten = true;
                    }
                    StringBuilder __tmp49 = new StringBuilder();
                    __tmp49.Append(etype.BaseType.GetXsdName());
                    using(StreamReader __tmp49Reader = new StreamReader(this.__ToStream(__tmp49.ToString())))
                    {
                        bool __tmp49_last = __tmp49Reader.EndOfStream;
                        while(!__tmp49_last)
                        {
                            string __tmp49_line = __tmp49Reader.ReadLine();
                            __tmp49_last = __tmp49Reader.EndOfStream;
                            if ((__tmp49_last && !string.IsNullOrEmpty(__tmp49_line)) || (!__tmp49_last && __tmp49_line != null))
                            {
                                __out.Append(__tmp49_line);
                                __tmp45_outputWritten = true;
                            }
                            if (!__tmp49_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp50_line = "\">"; //31:95
                    if (!string.IsNullOrEmpty(__tmp50_line))
                    {
                        __out.Append(__tmp50_line);
                        __tmp45_outputWritten = true;
                    }
                    if (__tmp45_outputWritten) __out.AppendLine(true);
                    if (__tmp45_outputWritten)
                    {
                        __out.AppendLine(false); //31:97
                    }
                }
                else //32:4
                {
                    __out.Append("		<xs:restriction base=\"xs:string\">"); //33:1
                    __out.AppendLine(false); //33:36
                }
                var __loop4_results = 
                    (from __loop4_var1 in __Enumerate((etype).GetEnumerator()) //35:10
                    from elit in __Enumerate((__loop4_var1.EnumLiterals).GetEnumerator()) //35:17
                    select new { __loop4_var1 = __loop4_var1, elit = elit}
                    ).ToList(); //35:5
                for (int __loop4_iteration = 0; __loop4_iteration < __loop4_results.Count; ++__loop4_iteration)
                {
                    var __tmp51 = __loop4_results[__loop4_iteration];
                    var __loop4_var1 = __tmp51.__loop4_var1;
                    var elit = __tmp51.elit;
                    if (elit.HasAnnotationProperty(SoalAnnotations.Enum, SoalAnnotationProperties.Name)) //36:6
                    {
                        bool __tmp53_outputWritten = false;
                        string __tmp54_line = "			<xs:enumeration value=\""; //37:1
                        if (!string.IsNullOrEmpty(__tmp54_line))
                        {
                            __out.Append(__tmp54_line);
                            __tmp53_outputWritten = true;
                        }
                        StringBuilder __tmp55 = new StringBuilder();
                        __tmp55.Append(elit.GetAnnotationPropertyValue(SoalAnnotations.Enum, SoalAnnotationProperties.Name));
                        using(StreamReader __tmp55Reader = new StreamReader(this.__ToStream(__tmp55.ToString())))
                        {
                            bool __tmp55_last = __tmp55Reader.EndOfStream;
                            while(!__tmp55_last)
                            {
                                string __tmp55_line = __tmp55Reader.ReadLine();
                                __tmp55_last = __tmp55Reader.EndOfStream;
                                if ((__tmp55_last && !string.IsNullOrEmpty(__tmp55_line)) || (!__tmp55_last && __tmp55_line != null))
                                {
                                    __out.Append(__tmp55_line);
                                    __tmp53_outputWritten = true;
                                }
                                if (!__tmp55_last) __out.AppendLine(true);
                            }
                        }
                        string __tmp56_line = "\"/>"; //37:113
                        if (!string.IsNullOrEmpty(__tmp56_line))
                        {
                            __out.Append(__tmp56_line);
                            __tmp53_outputWritten = true;
                        }
                        if (__tmp53_outputWritten) __out.AppendLine(true);
                        if (__tmp53_outputWritten)
                        {
                            __out.AppendLine(false); //37:116
                        }
                    }
                    else //38:6
                    {
                        bool __tmp58_outputWritten = false;
                        string __tmp59_line = "			<xs:enumeration value=\""; //39:1
                        if (!string.IsNullOrEmpty(__tmp59_line))
                        {
                            __out.Append(__tmp59_line);
                            __tmp58_outputWritten = true;
                        }
                        StringBuilder __tmp60 = new StringBuilder();
                        __tmp60.Append(elit.Name);
                        using(StreamReader __tmp60Reader = new StreamReader(this.__ToStream(__tmp60.ToString())))
                        {
                            bool __tmp60_last = __tmp60Reader.EndOfStream;
                            while(!__tmp60_last)
                            {
                                string __tmp60_line = __tmp60Reader.ReadLine();
                                __tmp60_last = __tmp60Reader.EndOfStream;
                                if ((__tmp60_last && !string.IsNullOrEmpty(__tmp60_line)) || (!__tmp60_last && __tmp60_line != null))
                                {
                                    __out.Append(__tmp60_line);
                                    __tmp58_outputWritten = true;
                                }
                                if (!__tmp60_last) __out.AppendLine(true);
                            }
                        }
                        string __tmp61_line = "\"/>"; //39:38
                        if (!string.IsNullOrEmpty(__tmp61_line))
                        {
                            __out.Append(__tmp61_line);
                            __tmp58_outputWritten = true;
                        }
                        if (__tmp58_outputWritten) __out.AppendLine(true);
                        if (__tmp58_outputWritten)
                        {
                            __out.AppendLine(false); //39:41
                        }
                    }
                }
                __out.Append("		</xs:restriction>"); //42:1
                __out.AppendLine(false); //42:20
                __out.Append("	</xs:simpleType>"); //43:1
                __out.AppendLine(false); //43:18
            }
            var __loop5_results = 
                (from __loop5_var1 in __Enumerate((ns.Declarations).GetEnumerator()) //45:8
                from stype in __Enumerate((__loop5_var1).GetEnumerator()).OfType<Struct>() //45:25
                select new { __loop5_var1 = __loop5_var1, stype = stype}
                ).ToList(); //45:3
            for (int __loop5_iteration = 0; __loop5_iteration < __loop5_results.Count; ++__loop5_iteration)
            {
                var __tmp62 = __loop5_results[__loop5_iteration];
                var __loop5_var1 = __tmp62.__loop5_var1;
                var stype = __tmp62.stype;
                __out.AppendLine(true); //46:1
                bool __tmp64_outputWritten = false;
                string __tmp65_line = "	<xs:element name=\""; //47:1
                if (!string.IsNullOrEmpty(__tmp65_line))
                {
                    __out.Append(__tmp65_line);
                    __tmp64_outputWritten = true;
                }
                StringBuilder __tmp66 = new StringBuilder();
                __tmp66.Append(stype.GetXsdName());
                using(StreamReader __tmp66Reader = new StreamReader(this.__ToStream(__tmp66.ToString())))
                {
                    bool __tmp66_last = __tmp66Reader.EndOfStream;
                    while(!__tmp66_last)
                    {
                        string __tmp66_line = __tmp66Reader.ReadLine();
                        __tmp66_last = __tmp66Reader.EndOfStream;
                        if ((__tmp66_last && !string.IsNullOrEmpty(__tmp66_line)) || (!__tmp66_last && __tmp66_line != null))
                        {
                            __out.Append(__tmp66_line);
                            __tmp64_outputWritten = true;
                        }
                        if (!__tmp66_last) __out.AppendLine(true);
                    }
                }
                string __tmp67_line = "\" type=\""; //47:40
                if (!string.IsNullOrEmpty(__tmp67_line))
                {
                    __out.Append(__tmp67_line);
                    __tmp64_outputWritten = true;
                }
                StringBuilder __tmp68 = new StringBuilder();
                __tmp68.Append(ns.Prefix);
                using(StreamReader __tmp68Reader = new StreamReader(this.__ToStream(__tmp68.ToString())))
                {
                    bool __tmp68_last = __tmp68Reader.EndOfStream;
                    while(!__tmp68_last)
                    {
                        string __tmp68_line = __tmp68Reader.ReadLine();
                        __tmp68_last = __tmp68Reader.EndOfStream;
                        if ((__tmp68_last && !string.IsNullOrEmpty(__tmp68_line)) || (!__tmp68_last && __tmp68_line != null))
                        {
                            __out.Append(__tmp68_line);
                            __tmp64_outputWritten = true;
                        }
                        if (!__tmp68_last) __out.AppendLine(true);
                    }
                }
                string __tmp69_line = ":"; //47:59
                if (!string.IsNullOrEmpty(__tmp69_line))
                {
                    __out.Append(__tmp69_line);
                    __tmp64_outputWritten = true;
                }
                StringBuilder __tmp70 = new StringBuilder();
                __tmp70.Append(stype.GetXsdName());
                using(StreamReader __tmp70Reader = new StreamReader(this.__ToStream(__tmp70.ToString())))
                {
                    bool __tmp70_last = __tmp70Reader.EndOfStream;
                    while(!__tmp70_last)
                    {
                        string __tmp70_line = __tmp70Reader.ReadLine();
                        __tmp70_last = __tmp70Reader.EndOfStream;
                        if ((__tmp70_last && !string.IsNullOrEmpty(__tmp70_line)) || (!__tmp70_last && __tmp70_line != null))
                        {
                            __out.Append(__tmp70_line);
                            __tmp64_outputWritten = true;
                        }
                        if (!__tmp70_last) __out.AppendLine(true);
                    }
                }
                string __tmp71_line = "\"/>"; //47:80
                if (!string.IsNullOrEmpty(__tmp71_line))
                {
                    __out.Append(__tmp71_line);
                    __tmp64_outputWritten = true;
                }
                if (__tmp64_outputWritten) __out.AppendLine(true);
                if (__tmp64_outputWritten)
                {
                    __out.AppendLine(false); //47:83
                }
                bool __tmp73_outputWritten = false;
                string __tmp74_line = "	<xs:complexType name=\""; //48:1
                if (!string.IsNullOrEmpty(__tmp74_line))
                {
                    __out.Append(__tmp74_line);
                    __tmp73_outputWritten = true;
                }
                StringBuilder __tmp75 = new StringBuilder();
                __tmp75.Append(stype.GetXsdName());
                using(StreamReader __tmp75Reader = new StreamReader(this.__ToStream(__tmp75.ToString())))
                {
                    bool __tmp75_last = __tmp75Reader.EndOfStream;
                    while(!__tmp75_last)
                    {
                        string __tmp75_line = __tmp75Reader.ReadLine();
                        __tmp75_last = __tmp75Reader.EndOfStream;
                        if ((__tmp75_last && !string.IsNullOrEmpty(__tmp75_line)) || (!__tmp75_last && __tmp75_line != null))
                        {
                            __out.Append(__tmp75_line);
                            __tmp73_outputWritten = true;
                        }
                        if (!__tmp75_last) __out.AppendLine(true);
                    }
                }
                string __tmp76_line = "\">"; //48:44
                if (!string.IsNullOrEmpty(__tmp76_line))
                {
                    __out.Append(__tmp76_line);
                    __tmp73_outputWritten = true;
                }
                if (__tmp73_outputWritten) __out.AppendLine(true);
                if (__tmp73_outputWritten)
                {
                    __out.AppendLine(false); //48:46
                }
                if (stype.BaseType != null) //49:4
                {
                    __out.Append("		<xs:complexContent>"); //50:1
                    __out.AppendLine(false); //50:22
                    bool __tmp78_outputWritten = false;
                    string __tmp79_line = "			<xs:extension base=\""; //51:1
                    if (!string.IsNullOrEmpty(__tmp79_line))
                    {
                        __out.Append(__tmp79_line);
                        __tmp78_outputWritten = true;
                    }
                    StringBuilder __tmp80 = new StringBuilder();
                    __tmp80.Append(stype.BaseType.GetNamespace(ns).Prefix);
                    using(StreamReader __tmp80Reader = new StreamReader(this.__ToStream(__tmp80.ToString())))
                    {
                        bool __tmp80_last = __tmp80Reader.EndOfStream;
                        while(!__tmp80_last)
                        {
                            string __tmp80_line = __tmp80Reader.ReadLine();
                            __tmp80_last = __tmp80Reader.EndOfStream;
                            if ((__tmp80_last && !string.IsNullOrEmpty(__tmp80_line)) || (!__tmp80_last && __tmp80_line != null))
                            {
                                __out.Append(__tmp80_line);
                                __tmp78_outputWritten = true;
                            }
                            if (!__tmp80_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp81_line = ":"; //51:64
                    if (!string.IsNullOrEmpty(__tmp81_line))
                    {
                        __out.Append(__tmp81_line);
                        __tmp78_outputWritten = true;
                    }
                    StringBuilder __tmp82 = new StringBuilder();
                    __tmp82.Append(stype.BaseType.GetXsdName());
                    using(StreamReader __tmp82Reader = new StreamReader(this.__ToStream(__tmp82.ToString())))
                    {
                        bool __tmp82_last = __tmp82Reader.EndOfStream;
                        while(!__tmp82_last)
                        {
                            string __tmp82_line = __tmp82Reader.ReadLine();
                            __tmp82_last = __tmp82Reader.EndOfStream;
                            if ((__tmp82_last && !string.IsNullOrEmpty(__tmp82_line)) || (!__tmp82_last && __tmp82_line != null))
                            {
                                __out.Append(__tmp82_line);
                                __tmp78_outputWritten = true;
                            }
                            if (!__tmp82_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp83_line = "\">"; //51:94
                    if (!string.IsNullOrEmpty(__tmp83_line))
                    {
                        __out.Append(__tmp83_line);
                        __tmp78_outputWritten = true;
                    }
                    if (__tmp78_outputWritten) __out.AppendLine(true);
                    if (__tmp78_outputWritten)
                    {
                        __out.AppendLine(false); //51:96
                    }
                    bool __tmp85_outputWritten = false;
                    string __tmp84Prefix = "				"; //52:1
                    StringBuilder __tmp86 = new StringBuilder();
                    __tmp86.Append(GenerateStructBody(ns, stype));
                    using(StreamReader __tmp86Reader = new StreamReader(this.__ToStream(__tmp86.ToString())))
                    {
                        bool __tmp86_last = __tmp86Reader.EndOfStream;
                        while(!__tmp86_last)
                        {
                            string __tmp86_line = __tmp86Reader.ReadLine();
                            __tmp86_last = __tmp86Reader.EndOfStream;
                            if (!string.IsNullOrEmpty(__tmp84Prefix))
                            {
                                __out.Append(__tmp84Prefix);
                                __tmp85_outputWritten = true;
                            }
                            if ((__tmp86_last && !string.IsNullOrEmpty(__tmp86_line)) || (!__tmp86_last && __tmp86_line != null))
                            {
                                __out.Append(__tmp86_line);
                                __tmp85_outputWritten = true;
                            }
                            if (!__tmp86_last || __tmp85_outputWritten) __out.AppendLine(true);
                        }
                    }
                    if (__tmp85_outputWritten)
                    {
                        __out.AppendLine(false); //52:36
                    }
                    __out.Append("			</xs:extension>"); //53:1
                    __out.AppendLine(false); //53:19
                    __out.Append("		</xs:complexContent>"); //54:1
                    __out.AppendLine(false); //54:23
                }
                else //55:4
                {
                    bool __tmp88_outputWritten = false;
                    string __tmp87Prefix = "		"; //56:1
                    StringBuilder __tmp89 = new StringBuilder();
                    __tmp89.Append(GenerateStructBody(ns, stype));
                    using(StreamReader __tmp89Reader = new StreamReader(this.__ToStream(__tmp89.ToString())))
                    {
                        bool __tmp89_last = __tmp89Reader.EndOfStream;
                        while(!__tmp89_last)
                        {
                            string __tmp89_line = __tmp89Reader.ReadLine();
                            __tmp89_last = __tmp89Reader.EndOfStream;
                            if (!string.IsNullOrEmpty(__tmp87Prefix))
                            {
                                __out.Append(__tmp87Prefix);
                                __tmp88_outputWritten = true;
                            }
                            if ((__tmp89_last && !string.IsNullOrEmpty(__tmp89_line)) || (!__tmp89_last && __tmp89_line != null))
                            {
                                __out.Append(__tmp89_line);
                                __tmp88_outputWritten = true;
                            }
                            if (!__tmp89_last || __tmp88_outputWritten) __out.AppendLine(true);
                        }
                    }
                    if (__tmp88_outputWritten)
                    {
                        __out.AppendLine(false); //56:34
                    }
                }
                __out.Append("	</xs:complexType>"); //58:1
                __out.AppendLine(false); //58:19
            }
            var __loop6_results = 
                (from __loop6_var1 in __Enumerate((ns.Declarations).GetEnumerator()) //60:8
                from intf in __Enumerate((__loop6_var1).GetEnumerator()).OfType<Interface>() //60:25
                from op in __Enumerate((intf.Operations).GetEnumerator()) //60:49
                select new { __loop6_var1 = __loop6_var1, intf = intf, op = op}
                ).ToList(); //60:3
            for (int __loop6_iteration = 0; __loop6_iteration < __loop6_results.Count; ++__loop6_iteration)
            {
                var __tmp90 = __loop6_results[__loop6_iteration];
                var __loop6_var1 = __tmp90.__loop6_var1;
                var intf = __tmp90.intf;
                var op = __tmp90.op;
                if (intf.HasAnnotation(SoalAnnotations.Rpc)) //61:4
                {
                    var __loop7_results = 
                        (from __loop7_var1 in __Enumerate((op).GetEnumerator()) //62:10
                        from param in __Enumerate((__loop7_var1.Parameters).GetEnumerator()) //62:14
                        where param.Type.IsArrayType() && param.Type.GetCoreType() != SoalInstance.Byte //62:31
                        select new { __loop7_var1 = __loop7_var1, param = param}
                        ).ToList(); //62:5
                    for (int __loop7_iteration = 0; __loop7_iteration < __loop7_results.Count; ++__loop7_iteration)
                    {
                        var __tmp91 = __loop7_results[__loop7_iteration];
                        var __loop7_var1 = __tmp91.__loop7_var1;
                        var param = __tmp91.param;
                        __out.AppendLine(true); //63:1
                        bool __tmp93_outputWritten = false;
                        string __tmp92Prefix = "	"; //64:1
                        StringBuilder __tmp94 = new StringBuilder();
                        __tmp94.Append(GenerateParamType(ns, op.Name + param.Name.ToPascalCase(), param.Type, param));
                        using(StreamReader __tmp94Reader = new StreamReader(this.__ToStream(__tmp94.ToString())))
                        {
                            bool __tmp94_last = __tmp94Reader.EndOfStream;
                            while(!__tmp94_last)
                            {
                                string __tmp94_line = __tmp94Reader.ReadLine();
                                __tmp94_last = __tmp94Reader.EndOfStream;
                                if (!string.IsNullOrEmpty(__tmp92Prefix))
                                {
                                    __out.Append(__tmp92Prefix);
                                    __tmp93_outputWritten = true;
                                }
                                if ((__tmp94_last && !string.IsNullOrEmpty(__tmp94_line)) || (!__tmp94_last && __tmp94_line != null))
                                {
                                    __out.Append(__tmp94_line);
                                    __tmp93_outputWritten = true;
                                }
                                if (!__tmp94_last || __tmp93_outputWritten) __out.AppendLine(true);
                            }
                        }
                        if (__tmp93_outputWritten)
                        {
                            __out.AppendLine(false); //64:81
                        }
                    }
                    if (op.Result.Type.IsArrayType() && op.Result.Type.GetCoreType() != SoalInstance.Byte) //66:5
                    {
                        __out.AppendLine(true); //67:1
                        bool __tmp96_outputWritten = false;
                        string __tmp95Prefix = "	"; //68:1
                        StringBuilder __tmp97 = new StringBuilder();
                        __tmp97.Append(GenerateParamType(ns, op.Name + "Response", op.Result.Type, op.Result));
                        using(StreamReader __tmp97Reader = new StreamReader(this.__ToStream(__tmp97.ToString())))
                        {
                            bool __tmp97_last = __tmp97Reader.EndOfStream;
                            while(!__tmp97_last)
                            {
                                string __tmp97_line = __tmp97Reader.ReadLine();
                                __tmp97_last = __tmp97Reader.EndOfStream;
                                if (!string.IsNullOrEmpty(__tmp95Prefix))
                                {
                                    __out.Append(__tmp95Prefix);
                                    __tmp96_outputWritten = true;
                                }
                                if ((__tmp97_last && !string.IsNullOrEmpty(__tmp97_line)) || (!__tmp97_last && __tmp97_line != null))
                                {
                                    __out.Append(__tmp97_line);
                                    __tmp96_outputWritten = true;
                                }
                                if (!__tmp97_last || __tmp96_outputWritten) __out.AppendLine(true);
                            }
                        }
                        if (__tmp96_outputWritten)
                        {
                            __out.AppendLine(false); //68:74
                        }
                    }
                }
                else //70:4
                {
                    if (intf.HasAnnotation(SoalAnnotations.NoWrap)) //71:5
                    {
                        var __loop8_results = 
                            (from __loop8_var1 in __Enumerate((op).GetEnumerator()) //72:11
                            from param in __Enumerate((__loop8_var1.Parameters).GetEnumerator()) //72:15
                            select new { __loop8_var1 = __loop8_var1, param = param}
                            ).ToList(); //72:6
                        for (int __loop8_iteration = 0; __loop8_iteration < __loop8_results.Count; ++__loop8_iteration)
                        {
                            var __tmp98 = __loop8_results[__loop8_iteration];
                            var __loop8_var1 = __tmp98.__loop8_var1;
                            var param = __tmp98.param;
                            bool __tmp100_outputWritten = false;
                            string __tmp99Prefix = "	"; //73:1
                            StringBuilder __tmp101 = new StringBuilder();
                            __tmp101.Append(GenerateElement(ns, op.Name + param.Name.ToPascalCase(), param.Type, param));
                            using(StreamReader __tmp101Reader = new StreamReader(this.__ToStream(__tmp101.ToString())))
                            {
                                bool __tmp101_last = __tmp101Reader.EndOfStream;
                                while(!__tmp101_last)
                                {
                                    string __tmp101_line = __tmp101Reader.ReadLine();
                                    __tmp101_last = __tmp101Reader.EndOfStream;
                                    if (!string.IsNullOrEmpty(__tmp99Prefix))
                                    {
                                        __out.Append(__tmp99Prefix);
                                        __tmp100_outputWritten = true;
                                    }
                                    if ((__tmp101_last && !string.IsNullOrEmpty(__tmp101_line)) || (!__tmp101_last && __tmp101_line != null))
                                    {
                                        __out.Append(__tmp101_line);
                                        __tmp100_outputWritten = true;
                                    }
                                    if (!__tmp101_last || __tmp100_outputWritten) __out.AppendLine(true);
                                }
                            }
                            if (__tmp100_outputWritten)
                            {
                                __out.AppendLine(false); //73:79
                            }
                        }
                        if (op.Result.Type != SoalInstance.Void) //75:6
                        {
                            bool __tmp103_outputWritten = false;
                            string __tmp102Prefix = "	"; //76:1
                            StringBuilder __tmp104 = new StringBuilder();
                            __tmp104.Append(GenerateElement(ns, op.Name + "Response", op.Result.Type, op.Result));
                            using(StreamReader __tmp104Reader = new StreamReader(this.__ToStream(__tmp104.ToString())))
                            {
                                bool __tmp104_last = __tmp104Reader.EndOfStream;
                                while(!__tmp104_last)
                                {
                                    string __tmp104_line = __tmp104Reader.ReadLine();
                                    __tmp104_last = __tmp104Reader.EndOfStream;
                                    if (!string.IsNullOrEmpty(__tmp102Prefix))
                                    {
                                        __out.Append(__tmp102Prefix);
                                        __tmp103_outputWritten = true;
                                    }
                                    if ((__tmp104_last && !string.IsNullOrEmpty(__tmp104_line)) || (!__tmp104_last && __tmp104_line != null))
                                    {
                                        __out.Append(__tmp104_line);
                                        __tmp103_outputWritten = true;
                                    }
                                    if (!__tmp104_last || __tmp103_outputWritten) __out.AppendLine(true);
                                }
                            }
                            if (__tmp103_outputWritten)
                            {
                                __out.AppendLine(false); //76:72
                            }
                        }
                    }
                    else //78:5
                    {
                        __out.AppendLine(true); //79:1
                        bool __tmp106_outputWritten = false;
                        string __tmp107_line = "	<xs:element name=\""; //80:1
                        if (!string.IsNullOrEmpty(__tmp107_line))
                        {
                            __out.Append(__tmp107_line);
                            __tmp106_outputWritten = true;
                        }
                        StringBuilder __tmp108 = new StringBuilder();
                        __tmp108.Append(op.Name);
                        using(StreamReader __tmp108Reader = new StreamReader(this.__ToStream(__tmp108.ToString())))
                        {
                            bool __tmp108_last = __tmp108Reader.EndOfStream;
                            while(!__tmp108_last)
                            {
                                string __tmp108_line = __tmp108Reader.ReadLine();
                                __tmp108_last = __tmp108Reader.EndOfStream;
                                if ((__tmp108_last && !string.IsNullOrEmpty(__tmp108_line)) || (!__tmp108_last && __tmp108_line != null))
                                {
                                    __out.Append(__tmp108_line);
                                    __tmp106_outputWritten = true;
                                }
                                if (!__tmp108_last) __out.AppendLine(true);
                            }
                        }
                        string __tmp109_line = "\" type=\""; //80:29
                        if (!string.IsNullOrEmpty(__tmp109_line))
                        {
                            __out.Append(__tmp109_line);
                            __tmp106_outputWritten = true;
                        }
                        StringBuilder __tmp110 = new StringBuilder();
                        __tmp110.Append(ns.Prefix);
                        using(StreamReader __tmp110Reader = new StreamReader(this.__ToStream(__tmp110.ToString())))
                        {
                            bool __tmp110_last = __tmp110Reader.EndOfStream;
                            while(!__tmp110_last)
                            {
                                string __tmp110_line = __tmp110Reader.ReadLine();
                                __tmp110_last = __tmp110Reader.EndOfStream;
                                if ((__tmp110_last && !string.IsNullOrEmpty(__tmp110_line)) || (!__tmp110_last && __tmp110_line != null))
                                {
                                    __out.Append(__tmp110_line);
                                    __tmp106_outputWritten = true;
                                }
                                if (!__tmp110_last) __out.AppendLine(true);
                            }
                        }
                        string __tmp111_line = ":"; //80:48
                        if (!string.IsNullOrEmpty(__tmp111_line))
                        {
                            __out.Append(__tmp111_line);
                            __tmp106_outputWritten = true;
                        }
                        StringBuilder __tmp112 = new StringBuilder();
                        __tmp112.Append(op.Name);
                        using(StreamReader __tmp112Reader = new StreamReader(this.__ToStream(__tmp112.ToString())))
                        {
                            bool __tmp112_last = __tmp112Reader.EndOfStream;
                            while(!__tmp112_last)
                            {
                                string __tmp112_line = __tmp112Reader.ReadLine();
                                __tmp112_last = __tmp112Reader.EndOfStream;
                                if ((__tmp112_last && !string.IsNullOrEmpty(__tmp112_line)) || (!__tmp112_last && __tmp112_line != null))
                                {
                                    __out.Append(__tmp112_line);
                                    __tmp106_outputWritten = true;
                                }
                                if (!__tmp112_last) __out.AppendLine(true);
                            }
                        }
                        string __tmp113_line = "\"/>"; //80:58
                        if (!string.IsNullOrEmpty(__tmp113_line))
                        {
                            __out.Append(__tmp113_line);
                            __tmp106_outputWritten = true;
                        }
                        if (__tmp106_outputWritten) __out.AppendLine(true);
                        if (__tmp106_outputWritten)
                        {
                            __out.AppendLine(false); //80:61
                        }
                        bool __tmp115_outputWritten = false;
                        string __tmp116_line = "	<xs:complexType name=\""; //81:1
                        if (!string.IsNullOrEmpty(__tmp116_line))
                        {
                            __out.Append(__tmp116_line);
                            __tmp115_outputWritten = true;
                        }
                        StringBuilder __tmp117 = new StringBuilder();
                        __tmp117.Append(op.Name);
                        using(StreamReader __tmp117Reader = new StreamReader(this.__ToStream(__tmp117.ToString())))
                        {
                            bool __tmp117_last = __tmp117Reader.EndOfStream;
                            while(!__tmp117_last)
                            {
                                string __tmp117_line = __tmp117Reader.ReadLine();
                                __tmp117_last = __tmp117Reader.EndOfStream;
                                if ((__tmp117_last && !string.IsNullOrEmpty(__tmp117_line)) || (!__tmp117_last && __tmp117_line != null))
                                {
                                    __out.Append(__tmp117_line);
                                    __tmp115_outputWritten = true;
                                }
                                if (!__tmp117_last) __out.AppendLine(true);
                            }
                        }
                        string __tmp118_line = "\">"; //81:33
                        if (!string.IsNullOrEmpty(__tmp118_line))
                        {
                            __out.Append(__tmp118_line);
                            __tmp115_outputWritten = true;
                        }
                        if (__tmp115_outputWritten) __out.AppendLine(true);
                        if (__tmp115_outputWritten)
                        {
                            __out.AppendLine(false); //81:35
                        }
                        __out.Append("		<xs:sequence>"); //82:1
                        __out.AppendLine(false); //82:16
                        var __loop9_results = 
                            (from __loop9_var1 in __Enumerate((op).GetEnumerator()) //83:11
                            from param in __Enumerate((__loop9_var1.Parameters).GetEnumerator()) //83:15
                            where !param.HasAnnotation(SoalAnnotations.Attribute) //83:32
                            select new { __loop9_var1 = __loop9_var1, param = param}
                            ).ToList(); //83:6
                        for (int __loop9_iteration = 0; __loop9_iteration < __loop9_results.Count; ++__loop9_iteration)
                        {
                            var __tmp119 = __loop9_results[__loop9_iteration];
                            var __loop9_var1 = __tmp119.__loop9_var1;
                            var param = __tmp119.param;
                            bool __tmp121_outputWritten = false;
                            string __tmp120Prefix = "			"; //84:1
                            StringBuilder __tmp122 = new StringBuilder();
                            __tmp122.Append(GenerateElement(ns, param.Name, param.Type, param));
                            using(StreamReader __tmp122Reader = new StreamReader(this.__ToStream(__tmp122.ToString())))
                            {
                                bool __tmp122_last = __tmp122Reader.EndOfStream;
                                while(!__tmp122_last)
                                {
                                    string __tmp122_line = __tmp122Reader.ReadLine();
                                    __tmp122_last = __tmp122Reader.EndOfStream;
                                    if (!string.IsNullOrEmpty(__tmp120Prefix))
                                    {
                                        __out.Append(__tmp120Prefix);
                                        __tmp121_outputWritten = true;
                                    }
                                    if ((__tmp122_last && !string.IsNullOrEmpty(__tmp122_line)) || (!__tmp122_last && __tmp122_line != null))
                                    {
                                        __out.Append(__tmp122_line);
                                        __tmp121_outputWritten = true;
                                    }
                                    if (!__tmp122_last || __tmp121_outputWritten) __out.AppendLine(true);
                                }
                            }
                            if (__tmp121_outputWritten)
                            {
                                __out.AppendLine(false); //84:56
                            }
                        }
                        __out.Append("		</xs:sequence>"); //86:1
                        __out.AppendLine(false); //86:17
                        var __loop10_results = 
                            (from __loop10_var1 in __Enumerate((op).GetEnumerator()) //87:11
                            from param in __Enumerate((__loop10_var1.Parameters).GetEnumerator()) //87:15
                            where param.HasAnnotation(SoalAnnotations.Attribute) //87:32
                            select new { __loop10_var1 = __loop10_var1, param = param}
                            ).ToList(); //87:6
                        for (int __loop10_iteration = 0; __loop10_iteration < __loop10_results.Count; ++__loop10_iteration)
                        {
                            var __tmp123 = __loop10_results[__loop10_iteration];
                            var __loop10_var1 = __tmp123.__loop10_var1;
                            var param = __tmp123.param;
                            bool __tmp125_outputWritten = false;
                            string __tmp124Prefix = "		"; //88:1
                            StringBuilder __tmp126 = new StringBuilder();
                            __tmp126.Append(GenerateElement(ns, param.Name, param.Type, param));
                            using(StreamReader __tmp126Reader = new StreamReader(this.__ToStream(__tmp126.ToString())))
                            {
                                bool __tmp126_last = __tmp126Reader.EndOfStream;
                                while(!__tmp126_last)
                                {
                                    string __tmp126_line = __tmp126Reader.ReadLine();
                                    __tmp126_last = __tmp126Reader.EndOfStream;
                                    if (!string.IsNullOrEmpty(__tmp124Prefix))
                                    {
                                        __out.Append(__tmp124Prefix);
                                        __tmp125_outputWritten = true;
                                    }
                                    if ((__tmp126_last && !string.IsNullOrEmpty(__tmp126_line)) || (!__tmp126_last && __tmp126_line != null))
                                    {
                                        __out.Append(__tmp126_line);
                                        __tmp125_outputWritten = true;
                                    }
                                    if (!__tmp126_last || __tmp125_outputWritten) __out.AppendLine(true);
                                }
                            }
                            if (__tmp125_outputWritten)
                            {
                                __out.AppendLine(false); //88:55
                            }
                        }
                        __out.Append("	</xs:complexType>"); //90:1
                        __out.AppendLine(false); //90:19
                        if (!op.Result.IsOneway) //91:6
                        {
                            __out.AppendLine(true); //92:1
                            bool __tmp128_outputWritten = false;
                            string __tmp129_line = "	<xs:element name=\""; //93:1
                            if (!string.IsNullOrEmpty(__tmp129_line))
                            {
                                __out.Append(__tmp129_line);
                                __tmp128_outputWritten = true;
                            }
                            StringBuilder __tmp130 = new StringBuilder();
                            __tmp130.Append(op.Name);
                            using(StreamReader __tmp130Reader = new StreamReader(this.__ToStream(__tmp130.ToString())))
                            {
                                bool __tmp130_last = __tmp130Reader.EndOfStream;
                                while(!__tmp130_last)
                                {
                                    string __tmp130_line = __tmp130Reader.ReadLine();
                                    __tmp130_last = __tmp130Reader.EndOfStream;
                                    if ((__tmp130_last && !string.IsNullOrEmpty(__tmp130_line)) || (!__tmp130_last && __tmp130_line != null))
                                    {
                                        __out.Append(__tmp130_line);
                                        __tmp128_outputWritten = true;
                                    }
                                    if (!__tmp130_last) __out.AppendLine(true);
                                }
                            }
                            string __tmp131_line = "Response\" type=\""; //93:29
                            if (!string.IsNullOrEmpty(__tmp131_line))
                            {
                                __out.Append(__tmp131_line);
                                __tmp128_outputWritten = true;
                            }
                            StringBuilder __tmp132 = new StringBuilder();
                            __tmp132.Append(ns.Prefix);
                            using(StreamReader __tmp132Reader = new StreamReader(this.__ToStream(__tmp132.ToString())))
                            {
                                bool __tmp132_last = __tmp132Reader.EndOfStream;
                                while(!__tmp132_last)
                                {
                                    string __tmp132_line = __tmp132Reader.ReadLine();
                                    __tmp132_last = __tmp132Reader.EndOfStream;
                                    if ((__tmp132_last && !string.IsNullOrEmpty(__tmp132_line)) || (!__tmp132_last && __tmp132_line != null))
                                    {
                                        __out.Append(__tmp132_line);
                                        __tmp128_outputWritten = true;
                                    }
                                    if (!__tmp132_last) __out.AppendLine(true);
                                }
                            }
                            string __tmp133_line = ":"; //93:56
                            if (!string.IsNullOrEmpty(__tmp133_line))
                            {
                                __out.Append(__tmp133_line);
                                __tmp128_outputWritten = true;
                            }
                            StringBuilder __tmp134 = new StringBuilder();
                            __tmp134.Append(op.Name);
                            using(StreamReader __tmp134Reader = new StreamReader(this.__ToStream(__tmp134.ToString())))
                            {
                                bool __tmp134_last = __tmp134Reader.EndOfStream;
                                while(!__tmp134_last)
                                {
                                    string __tmp134_line = __tmp134Reader.ReadLine();
                                    __tmp134_last = __tmp134Reader.EndOfStream;
                                    if ((__tmp134_last && !string.IsNullOrEmpty(__tmp134_line)) || (!__tmp134_last && __tmp134_line != null))
                                    {
                                        __out.Append(__tmp134_line);
                                        __tmp128_outputWritten = true;
                                    }
                                    if (!__tmp134_last) __out.AppendLine(true);
                                }
                            }
                            string __tmp135_line = "Response\"/>"; //93:66
                            if (!string.IsNullOrEmpty(__tmp135_line))
                            {
                                __out.Append(__tmp135_line);
                                __tmp128_outputWritten = true;
                            }
                            if (__tmp128_outputWritten) __out.AppendLine(true);
                            if (__tmp128_outputWritten)
                            {
                                __out.AppendLine(false); //93:77
                            }
                            bool __tmp137_outputWritten = false;
                            string __tmp138_line = "	<xs:complexType name=\""; //94:1
                            if (!string.IsNullOrEmpty(__tmp138_line))
                            {
                                __out.Append(__tmp138_line);
                                __tmp137_outputWritten = true;
                            }
                            StringBuilder __tmp139 = new StringBuilder();
                            __tmp139.Append(op.Name);
                            using(StreamReader __tmp139Reader = new StreamReader(this.__ToStream(__tmp139.ToString())))
                            {
                                bool __tmp139_last = __tmp139Reader.EndOfStream;
                                while(!__tmp139_last)
                                {
                                    string __tmp139_line = __tmp139Reader.ReadLine();
                                    __tmp139_last = __tmp139Reader.EndOfStream;
                                    if ((__tmp139_last && !string.IsNullOrEmpty(__tmp139_line)) || (!__tmp139_last && __tmp139_line != null))
                                    {
                                        __out.Append(__tmp139_line);
                                        __tmp137_outputWritten = true;
                                    }
                                    if (!__tmp139_last) __out.AppendLine(true);
                                }
                            }
                            string __tmp140_line = "Response\">"; //94:33
                            if (!string.IsNullOrEmpty(__tmp140_line))
                            {
                                __out.Append(__tmp140_line);
                                __tmp137_outputWritten = true;
                            }
                            if (__tmp137_outputWritten) __out.AppendLine(true);
                            if (__tmp137_outputWritten)
                            {
                                __out.AppendLine(false); //94:43
                            }
                            if (op.Result.Type == SoalInstance.Void || op.Result.HasAnnotation(SoalAnnotations.Attribute)) //95:7
                            {
                                __out.Append("		<xs:sequence/>"); //96:1
                                __out.AppendLine(false); //96:17
                            }
                            else //97:7
                            {
                                __out.Append("		<xs:sequence>"); //98:1
                                __out.AppendLine(false); //98:16
                                bool __tmp142_outputWritten = false;
                                string __tmp141Prefix = "			"; //99:1
                                StringBuilder __tmp143 = new StringBuilder();
                                __tmp143.Append(GenerateElement(ns, op.Name + "Result", op.Result.Type, op.Result));
                                using(StreamReader __tmp143Reader = new StreamReader(this.__ToStream(__tmp143.ToString())))
                                {
                                    bool __tmp143_last = __tmp143Reader.EndOfStream;
                                    while(!__tmp143_last)
                                    {
                                        string __tmp143_line = __tmp143Reader.ReadLine();
                                        __tmp143_last = __tmp143Reader.EndOfStream;
                                        if (!string.IsNullOrEmpty(__tmp141Prefix))
                                        {
                                            __out.Append(__tmp141Prefix);
                                            __tmp142_outputWritten = true;
                                        }
                                        if ((__tmp143_last && !string.IsNullOrEmpty(__tmp143_line)) || (!__tmp143_last && __tmp143_line != null))
                                        {
                                            __out.Append(__tmp143_line);
                                            __tmp142_outputWritten = true;
                                        }
                                        if (!__tmp143_last || __tmp142_outputWritten) __out.AppendLine(true);
                                    }
                                }
                                if (__tmp142_outputWritten)
                                {
                                    __out.AppendLine(false); //99:70
                                }
                                __out.Append("		</xs:sequence>"); //100:1
                                __out.AppendLine(false); //100:17
                            }
                            if (op.Result.HasAnnotation(SoalAnnotations.Attribute)) //102:7
                            {
                                bool __tmp145_outputWritten = false;
                                string __tmp144Prefix = "		"; //103:1
                                StringBuilder __tmp146 = new StringBuilder();
                                __tmp146.Append(GenerateElement(ns, op.Name + "Result", op.Result.Type, op.Result));
                                using(StreamReader __tmp146Reader = new StreamReader(this.__ToStream(__tmp146.ToString())))
                                {
                                    bool __tmp146_last = __tmp146Reader.EndOfStream;
                                    while(!__tmp146_last)
                                    {
                                        string __tmp146_line = __tmp146Reader.ReadLine();
                                        __tmp146_last = __tmp146Reader.EndOfStream;
                                        if (!string.IsNullOrEmpty(__tmp144Prefix))
                                        {
                                            __out.Append(__tmp144Prefix);
                                            __tmp145_outputWritten = true;
                                        }
                                        if ((__tmp146_last && !string.IsNullOrEmpty(__tmp146_line)) || (!__tmp146_last && __tmp146_line != null))
                                        {
                                            __out.Append(__tmp146_line);
                                            __tmp145_outputWritten = true;
                                        }
                                        if (!__tmp146_last || __tmp145_outputWritten) __out.AppendLine(true);
                                    }
                                }
                                if (__tmp145_outputWritten)
                                {
                                    __out.AppendLine(false); //103:69
                                }
                            }
                            __out.Append("	</xs:complexType>"); //105:1
                            __out.AppendLine(false); //105:19
                        }
                    }
                }
            }
            __out.Append("</xs:schema>"); //110:1
            __out.AppendLine(false); //110:13
            return __out.ToString();
        }

        public string GenerateStructBody(Namespace ns, Struct stype) //113:1
        {
            StringBuilder __out = new StringBuilder();
            bool __tmp2_outputWritten = false;
            string __tmp3_line = "<xs:"; //114:1
            if (!string.IsNullOrEmpty(__tmp3_line))
            {
                __out.Append(__tmp3_line);
                __tmp2_outputWritten = true;
            }
            StringBuilder __tmp4 = new StringBuilder();
            __tmp4.Append(GetStructKind(stype));
            using(StreamReader __tmp4Reader = new StreamReader(this.__ToStream(__tmp4.ToString())))
            {
                bool __tmp4_last = __tmp4Reader.EndOfStream;
                while(!__tmp4_last)
                {
                    string __tmp4_line = __tmp4Reader.ReadLine();
                    __tmp4_last = __tmp4Reader.EndOfStream;
                    if ((__tmp4_last && !string.IsNullOrEmpty(__tmp4_line)) || (!__tmp4_last && __tmp4_line != null))
                    {
                        __out.Append(__tmp4_line);
                        __tmp2_outputWritten = true;
                    }
                    if (!__tmp4_last) __out.AppendLine(true);
                }
            }
            string __tmp5_line = ">"; //114:27
            if (!string.IsNullOrEmpty(__tmp5_line))
            {
                __out.Append(__tmp5_line);
                __tmp2_outputWritten = true;
            }
            if (__tmp2_outputWritten) __out.AppendLine(true);
            if (__tmp2_outputWritten)
            {
                __out.AppendLine(false); //114:28
            }
            var __loop11_results = 
                (from __loop11_var1 in __Enumerate((stype).GetEnumerator()) //115:8
                from prop in __Enumerate((__loop11_var1.Properties).GetEnumerator()) //115:15
                where !prop.HasAnnotation(SoalAnnotations.Attribute) //115:31
                select new { __loop11_var1 = __loop11_var1, prop = prop}
                ).ToList(); //115:3
            for (int __loop11_iteration = 0; __loop11_iteration < __loop11_results.Count; ++__loop11_iteration)
            {
                var __tmp6 = __loop11_results[__loop11_iteration];
                var __loop11_var1 = __tmp6.__loop11_var1;
                var prop = __tmp6.prop;
                string newName = prop.GetAnnotationPropertyValue(SoalAnnotations.Element, SoalAnnotationProperties.Name) as string; //116:4
                bool __tmp8_outputWritten = false;
                string __tmp7Prefix = "	"; //117:1
                StringBuilder __tmp9 = new StringBuilder();
                __tmp9.Append(GenerateElement(ns, newName == null ? prop.Name : newName, prop.Type, prop));
                using(StreamReader __tmp9Reader = new StreamReader(this.__ToStream(__tmp9.ToString())))
                {
                    bool __tmp9_last = __tmp9Reader.EndOfStream;
                    while(!__tmp9_last)
                    {
                        string __tmp9_line = __tmp9Reader.ReadLine();
                        __tmp9_last = __tmp9Reader.EndOfStream;
                        if (!string.IsNullOrEmpty(__tmp7Prefix))
                        {
                            __out.Append(__tmp7Prefix);
                            __tmp8_outputWritten = true;
                        }
                        if ((__tmp9_last && !string.IsNullOrEmpty(__tmp9_line)) || (!__tmp9_last && __tmp9_line != null))
                        {
                            __out.Append(__tmp9_line);
                            __tmp8_outputWritten = true;
                        }
                        if (!__tmp9_last || __tmp8_outputWritten) __out.AppendLine(true);
                    }
                }
                if (__tmp8_outputWritten)
                {
                    __out.AppendLine(false); //117:79
                }
            }
            bool __tmp11_outputWritten = false;
            string __tmp12_line = "</xs:"; //119:1
            if (!string.IsNullOrEmpty(__tmp12_line))
            {
                __out.Append(__tmp12_line);
                __tmp11_outputWritten = true;
            }
            StringBuilder __tmp13 = new StringBuilder();
            __tmp13.Append(GetStructKind(stype));
            using(StreamReader __tmp13Reader = new StreamReader(this.__ToStream(__tmp13.ToString())))
            {
                bool __tmp13_last = __tmp13Reader.EndOfStream;
                while(!__tmp13_last)
                {
                    string __tmp13_line = __tmp13Reader.ReadLine();
                    __tmp13_last = __tmp13Reader.EndOfStream;
                    if ((__tmp13_last && !string.IsNullOrEmpty(__tmp13_line)) || (!__tmp13_last && __tmp13_line != null))
                    {
                        __out.Append(__tmp13_line);
                        __tmp11_outputWritten = true;
                    }
                    if (!__tmp13_last) __out.AppendLine(true);
                }
            }
            string __tmp14_line = ">"; //119:28
            if (!string.IsNullOrEmpty(__tmp14_line))
            {
                __out.Append(__tmp14_line);
                __tmp11_outputWritten = true;
            }
            if (__tmp11_outputWritten) __out.AppendLine(true);
            if (__tmp11_outputWritten)
            {
                __out.AppendLine(false); //119:29
            }
            var __loop12_results = 
                (from __loop12_var1 in __Enumerate((stype).GetEnumerator()) //120:7
                from prop in __Enumerate((__loop12_var1.Properties).GetEnumerator()) //120:14
                where prop.HasAnnotation(SoalAnnotations.Attribute) //120:30
                select new { __loop12_var1 = __loop12_var1, prop = prop}
                ).ToList(); //120:2
            for (int __loop12_iteration = 0; __loop12_iteration < __loop12_results.Count; ++__loop12_iteration)
            {
                var __tmp15 = __loop12_results[__loop12_iteration];
                var __loop12_var1 = __tmp15.__loop12_var1;
                var prop = __tmp15.prop;
                string newName = prop.GetAnnotationPropertyValue(SoalAnnotations.Attribute, SoalAnnotationProperties.Name) as string; //121:3
                bool __tmp17_outputWritten = false;
                StringBuilder __tmp18 = new StringBuilder();
                __tmp18.Append(GenerateElement(ns, newName == null ? prop.Name : newName, prop.Type, prop));
                using(StreamReader __tmp18Reader = new StreamReader(this.__ToStream(__tmp18.ToString())))
                {
                    bool __tmp18_last = __tmp18Reader.EndOfStream;
                    while(!__tmp18_last)
                    {
                        string __tmp18_line = __tmp18Reader.ReadLine();
                        __tmp18_last = __tmp18Reader.EndOfStream;
                        if ((__tmp18_last && !string.IsNullOrEmpty(__tmp18_line)) || (!__tmp18_last && __tmp18_line != null))
                        {
                            __out.Append(__tmp18_line);
                            __tmp17_outputWritten = true;
                        }
                        if (!__tmp18_last || __tmp17_outputWritten) __out.AppendLine(true);
                    }
                }
                if (__tmp17_outputWritten)
                {
                    __out.AppendLine(false); //122:78
                }
            }
            return __out.ToString();
        }

        public string GenerateElement(Namespace ns, string name, SoalType t, AnnotatedElement ae) //126:1
        {
            StringBuilder __out = new StringBuilder();
            Annotation restrAnnot = ae.GetAnnotation(SoalAnnotations.Restriction); //127:2
            if (ae.HasAnnotation(SoalAnnotations.Attribute)) //128:2
            {
                bool __tmp2_outputWritten = false;
                string __tmp3_line = "<xs:attribute name=\""; //129:1
                if (!string.IsNullOrEmpty(__tmp3_line))
                {
                    __out.Append(__tmp3_line);
                    __tmp2_outputWritten = true;
                }
                StringBuilder __tmp4 = new StringBuilder();
                __tmp4.Append(name);
                using(StreamReader __tmp4Reader = new StreamReader(this.__ToStream(__tmp4.ToString())))
                {
                    bool __tmp4_last = __tmp4Reader.EndOfStream;
                    while(!__tmp4_last)
                    {
                        string __tmp4_line = __tmp4Reader.ReadLine();
                        __tmp4_last = __tmp4Reader.EndOfStream;
                        if ((__tmp4_last && !string.IsNullOrEmpty(__tmp4_line)) || (!__tmp4_last && __tmp4_line != null))
                        {
                            __out.Append(__tmp4_line);
                            __tmp2_outputWritten = true;
                        }
                        if (!__tmp4_last) __out.AppendLine(true);
                    }
                }
                string __tmp5_line = "\" type=\""; //129:27
                if (!string.IsNullOrEmpty(__tmp5_line))
                {
                    __out.Append(__tmp5_line);
                    __tmp2_outputWritten = true;
                }
                StringBuilder __tmp6 = new StringBuilder();
                __tmp6.Append(t.GetCoreType().GetNamespace(ns).Prefix);
                using(StreamReader __tmp6Reader = new StreamReader(this.__ToStream(__tmp6.ToString())))
                {
                    bool __tmp6_last = __tmp6Reader.EndOfStream;
                    while(!__tmp6_last)
                    {
                        string __tmp6_line = __tmp6Reader.ReadLine();
                        __tmp6_last = __tmp6Reader.EndOfStream;
                        if ((__tmp6_last && !string.IsNullOrEmpty(__tmp6_line)) || (!__tmp6_last && __tmp6_line != null))
                        {
                            __out.Append(__tmp6_line);
                            __tmp2_outputWritten = true;
                        }
                        if (!__tmp6_last) __out.AppendLine(true);
                    }
                }
                string __tmp7_line = ":"; //129:76
                if (!string.IsNullOrEmpty(__tmp7_line))
                {
                    __out.Append(__tmp7_line);
                    __tmp2_outputWritten = true;
                }
                StringBuilder __tmp8 = new StringBuilder();
                __tmp8.Append(t.GetCoreType().GetXsdName());
                using(StreamReader __tmp8Reader = new StreamReader(this.__ToStream(__tmp8.ToString())))
                {
                    bool __tmp8_last = __tmp8Reader.EndOfStream;
                    while(!__tmp8_last)
                    {
                        string __tmp8_line = __tmp8Reader.ReadLine();
                        __tmp8_last = __tmp8Reader.EndOfStream;
                        if ((__tmp8_last && !string.IsNullOrEmpty(__tmp8_line)) || (!__tmp8_last && __tmp8_line != null))
                        {
                            __out.Append(__tmp8_line);
                            __tmp2_outputWritten = true;
                        }
                        if (!__tmp8_last) __out.AppendLine(true);
                    }
                }
                string __tmp9_line = "\""; //129:107
                if (!string.IsNullOrEmpty(__tmp9_line))
                {
                    __out.Append(__tmp9_line);
                    __tmp2_outputWritten = true;
                }
                StringBuilder __tmp10 = new StringBuilder();
                __tmp10.Append(GetAttributeRequired(ae));
                using(StreamReader __tmp10Reader = new StreamReader(this.__ToStream(__tmp10.ToString())))
                {
                    bool __tmp10_last = __tmp10Reader.EndOfStream;
                    while(!__tmp10_last)
                    {
                        string __tmp10_line = __tmp10Reader.ReadLine();
                        __tmp10_last = __tmp10Reader.EndOfStream;
                        if ((__tmp10_last && !string.IsNullOrEmpty(__tmp10_line)) || (!__tmp10_last && __tmp10_line != null))
                        {
                            __out.Append(__tmp10_line);
                            __tmp2_outputWritten = true;
                        }
                        if (!__tmp10_last) __out.AppendLine(true);
                    }
                }
                string __tmp11_line = "/>"; //129:134
                if (!string.IsNullOrEmpty(__tmp11_line))
                {
                    __out.Append(__tmp11_line);
                    __tmp2_outputWritten = true;
                }
                if (__tmp2_outputWritten) __out.AppendLine(true);
                if (__tmp2_outputWritten)
                {
                    __out.AppendLine(false); //129:136
                }
            }
            else //130:2
            {
                if (t.IsArrayType()) //131:3
                {
                    ArrayType array = t is NonNullableType ? (ArrayType)((NonNullableType)t).InnerType : (ArrayType)t; //132:4
                    if (array.GetCoreType() == SoalInstance.Byte) //133:4
                    {
                        bool __tmp13_outputWritten = false;
                        string __tmp14_line = "<xs:element name=\""; //134:1
                        if (!string.IsNullOrEmpty(__tmp14_line))
                        {
                            __out.Append(__tmp14_line);
                            __tmp13_outputWritten = true;
                        }
                        StringBuilder __tmp15 = new StringBuilder();
                        __tmp15.Append(name);
                        using(StreamReader __tmp15Reader = new StreamReader(this.__ToStream(__tmp15.ToString())))
                        {
                            bool __tmp15_last = __tmp15Reader.EndOfStream;
                            while(!__tmp15_last)
                            {
                                string __tmp15_line = __tmp15Reader.ReadLine();
                                __tmp15_last = __tmp15Reader.EndOfStream;
                                if ((__tmp15_last && !string.IsNullOrEmpty(__tmp15_line)) || (!__tmp15_last && __tmp15_line != null))
                                {
                                    __out.Append(__tmp15_line);
                                    __tmp13_outputWritten = true;
                                }
                                if (!__tmp15_last) __out.AppendLine(true);
                            }
                        }
                        string __tmp16_line = "\" type=\""; //134:25
                        if (!string.IsNullOrEmpty(__tmp16_line))
                        {
                            __out.Append(__tmp16_line);
                            __tmp13_outputWritten = true;
                        }
                        StringBuilder __tmp17 = new StringBuilder();
                        __tmp17.Append(t.GetNamespace(ns).Prefix);
                        using(StreamReader __tmp17Reader = new StreamReader(this.__ToStream(__tmp17.ToString())))
                        {
                            bool __tmp17_last = __tmp17Reader.EndOfStream;
                            while(!__tmp17_last)
                            {
                                string __tmp17_line = __tmp17Reader.ReadLine();
                                __tmp17_last = __tmp17Reader.EndOfStream;
                                if ((__tmp17_last && !string.IsNullOrEmpty(__tmp17_line)) || (!__tmp17_last && __tmp17_line != null))
                                {
                                    __out.Append(__tmp17_line);
                                    __tmp13_outputWritten = true;
                                }
                                if (!__tmp17_last) __out.AppendLine(true);
                            }
                        }
                        string __tmp18_line = ":"; //134:60
                        if (!string.IsNullOrEmpty(__tmp18_line))
                        {
                            __out.Append(__tmp18_line);
                            __tmp13_outputWritten = true;
                        }
                        StringBuilder __tmp19 = new StringBuilder();
                        __tmp19.Append(t.GetXsdName());
                        using(StreamReader __tmp19Reader = new StreamReader(this.__ToStream(__tmp19.ToString())))
                        {
                            bool __tmp19_last = __tmp19Reader.EndOfStream;
                            while(!__tmp19_last)
                            {
                                string __tmp19_line = __tmp19Reader.ReadLine();
                                __tmp19_last = __tmp19Reader.EndOfStream;
                                if ((__tmp19_last && !string.IsNullOrEmpty(__tmp19_line)) || (!__tmp19_last && __tmp19_line != null))
                                {
                                    __out.Append(__tmp19_line);
                                    __tmp13_outputWritten = true;
                                }
                                if (!__tmp19_last) __out.AppendLine(true);
                            }
                        }
                        string __tmp20_line = "\" nillable=\""; //134:77
                        if (!string.IsNullOrEmpty(__tmp20_line))
                        {
                            __out.Append(__tmp20_line);
                            __tmp13_outputWritten = true;
                        }
                        StringBuilder __tmp21 = new StringBuilder();
                        __tmp21.Append(t.IsNullableXsd());
                        using(StreamReader __tmp21Reader = new StreamReader(this.__ToStream(__tmp21.ToString())))
                        {
                            bool __tmp21_last = __tmp21Reader.EndOfStream;
                            while(!__tmp21_last)
                            {
                                string __tmp21_line = __tmp21Reader.ReadLine();
                                __tmp21_last = __tmp21Reader.EndOfStream;
                                if ((__tmp21_last && !string.IsNullOrEmpty(__tmp21_line)) || (!__tmp21_last && __tmp21_line != null))
                                {
                                    __out.Append(__tmp21_line);
                                    __tmp13_outputWritten = true;
                                }
                                if (!__tmp21_last) __out.AppendLine(true);
                            }
                        }
                        string __tmp22_line = "\""; //134:108
                        if (!string.IsNullOrEmpty(__tmp22_line))
                        {
                            __out.Append(__tmp22_line);
                            __tmp13_outputWritten = true;
                        }
                        StringBuilder __tmp23 = new StringBuilder();
                        __tmp23.Append(GetElementOptional(ae));
                        using(StreamReader __tmp23Reader = new StreamReader(this.__ToStream(__tmp23.ToString())))
                        {
                            bool __tmp23_last = __tmp23Reader.EndOfStream;
                            while(!__tmp23_last)
                            {
                                string __tmp23_line = __tmp23Reader.ReadLine();
                                __tmp23_last = __tmp23Reader.EndOfStream;
                                if ((__tmp23_last && !string.IsNullOrEmpty(__tmp23_line)) || (!__tmp23_last && __tmp23_line != null))
                                {
                                    __out.Append(__tmp23_line);
                                    __tmp13_outputWritten = true;
                                }
                                if (!__tmp23_last) __out.AppendLine(true);
                            }
                        }
                        string __tmp24_line = "/>"; //134:133
                        if (!string.IsNullOrEmpty(__tmp24_line))
                        {
                            __out.Append(__tmp24_line);
                            __tmp13_outputWritten = true;
                        }
                        if (__tmp13_outputWritten) __out.AppendLine(true);
                        if (__tmp13_outputWritten)
                        {
                            __out.AppendLine(false); //134:135
                        }
                    }
                    else //135:4
                    {
                        object wrapped = ae.GetAnnotationPropertyValue(SoalAnnotations.Element, SoalAnnotationProperties.Wrapped); //136:5
                        if (wrapped != null && (bool)wrapped) //137:5
                        {
                            string items = ae.GetAnnotationPropertyValue(SoalAnnotations.Element, SoalAnnotationProperties.Items) as string; //138:6
                            bool __tmp26_outputWritten = false;
                            string __tmp27_line = "<xs:element name=\""; //139:1
                            if (!string.IsNullOrEmpty(__tmp27_line))
                            {
                                __out.Append(__tmp27_line);
                                __tmp26_outputWritten = true;
                            }
                            StringBuilder __tmp28 = new StringBuilder();
                            __tmp28.Append(name);
                            using(StreamReader __tmp28Reader = new StreamReader(this.__ToStream(__tmp28.ToString())))
                            {
                                bool __tmp28_last = __tmp28Reader.EndOfStream;
                                while(!__tmp28_last)
                                {
                                    string __tmp28_line = __tmp28Reader.ReadLine();
                                    __tmp28_last = __tmp28Reader.EndOfStream;
                                    if ((__tmp28_last && !string.IsNullOrEmpty(__tmp28_line)) || (!__tmp28_last && __tmp28_line != null))
                                    {
                                        __out.Append(__tmp28_line);
                                        __tmp26_outputWritten = true;
                                    }
                                    if (!__tmp28_last) __out.AppendLine(true);
                                }
                            }
                            string __tmp29_line = "\" nillable=\""; //139:25
                            if (!string.IsNullOrEmpty(__tmp29_line))
                            {
                                __out.Append(__tmp29_line);
                                __tmp26_outputWritten = true;
                            }
                            StringBuilder __tmp30 = new StringBuilder();
                            __tmp30.Append(t.IsNullableXsd());
                            using(StreamReader __tmp30Reader = new StreamReader(this.__ToStream(__tmp30.ToString())))
                            {
                                bool __tmp30_last = __tmp30Reader.EndOfStream;
                                while(!__tmp30_last)
                                {
                                    string __tmp30_line = __tmp30Reader.ReadLine();
                                    __tmp30_last = __tmp30Reader.EndOfStream;
                                    if ((__tmp30_last && !string.IsNullOrEmpty(__tmp30_line)) || (!__tmp30_last && __tmp30_line != null))
                                    {
                                        __out.Append(__tmp30_line);
                                        __tmp26_outputWritten = true;
                                    }
                                    if (!__tmp30_last) __out.AppendLine(true);
                                }
                            }
                            string __tmp31_line = "\""; //139:56
                            if (!string.IsNullOrEmpty(__tmp31_line))
                            {
                                __out.Append(__tmp31_line);
                                __tmp26_outputWritten = true;
                            }
                            StringBuilder __tmp32 = new StringBuilder();
                            __tmp32.Append(GetElementOptional(ae));
                            using(StreamReader __tmp32Reader = new StreamReader(this.__ToStream(__tmp32.ToString())))
                            {
                                bool __tmp32_last = __tmp32Reader.EndOfStream;
                                while(!__tmp32_last)
                                {
                                    string __tmp32_line = __tmp32Reader.ReadLine();
                                    __tmp32_last = __tmp32Reader.EndOfStream;
                                    if ((__tmp32_last && !string.IsNullOrEmpty(__tmp32_line)) || (!__tmp32_last && __tmp32_line != null))
                                    {
                                        __out.Append(__tmp32_line);
                                        __tmp26_outputWritten = true;
                                    }
                                    if (!__tmp32_last) __out.AppendLine(true);
                                }
                            }
                            string __tmp33_line = ">"; //139:81
                            if (!string.IsNullOrEmpty(__tmp33_line))
                            {
                                __out.Append(__tmp33_line);
                                __tmp26_outputWritten = true;
                            }
                            if (__tmp26_outputWritten) __out.AppendLine(true);
                            if (__tmp26_outputWritten)
                            {
                                __out.AppendLine(false); //139:82
                            }
                            __out.Append("	<xs:complexType>"); //140:1
                            __out.AppendLine(false); //140:18
                            object sap = ae.GetAnnotationPropertyValue(SoalAnnotations.Element, SoalAnnotationProperties.Sap); //141:6
                            if (sap != null && (bool)sap) //142:6
                            {
                                __out.Append("		<xs:all>"); //143:1
                                __out.AppendLine(false); //143:11
                                __out.Append("			<xs:element name=\"item\" minOccurs=\"0\" maxOccurs=\"unbounded\">"); //144:1
                                __out.AppendLine(false); //144:64
                                __out.Append("				<xs:complexType>"); //145:1
                                __out.AppendLine(false); //145:21
                                __out.Append("					<xs:all>"); //146:1
                                __out.AppendLine(false); //146:14
                                if (restrAnnot != null && array.InnerType.GetCoreType() is PrimitiveType) //147:7
                                {
                                    if (items != null) //148:8
                                    {
                                        bool __tmp35_outputWritten = false;
                                        string __tmp36_line = "						<xs:element name=\""; //149:1
                                        if (!string.IsNullOrEmpty(__tmp36_line))
                                        {
                                            __out.Append(__tmp36_line);
                                            __tmp35_outputWritten = true;
                                        }
                                        StringBuilder __tmp37 = new StringBuilder();
                                        __tmp37.Append(items);
                                        using(StreamReader __tmp37Reader = new StreamReader(this.__ToStream(__tmp37.ToString())))
                                        {
                                            bool __tmp37_last = __tmp37Reader.EndOfStream;
                                            while(!__tmp37_last)
                                            {
                                                string __tmp37_line = __tmp37Reader.ReadLine();
                                                __tmp37_last = __tmp37Reader.EndOfStream;
                                                if ((__tmp37_last && !string.IsNullOrEmpty(__tmp37_line)) || (!__tmp37_last && __tmp37_line != null))
                                                {
                                                    __out.Append(__tmp37_line);
                                                    __tmp35_outputWritten = true;
                                                }
                                                if (!__tmp37_last) __out.AppendLine(true);
                                            }
                                        }
                                        string __tmp38_line = "\" nillable=\""; //149:32
                                        if (!string.IsNullOrEmpty(__tmp38_line))
                                        {
                                            __out.Append(__tmp38_line);
                                            __tmp35_outputWritten = true;
                                        }
                                        StringBuilder __tmp39 = new StringBuilder();
                                        __tmp39.Append(array.InnerType.IsNullableXsd());
                                        using(StreamReader __tmp39Reader = new StreamReader(this.__ToStream(__tmp39.ToString())))
                                        {
                                            bool __tmp39_last = __tmp39Reader.EndOfStream;
                                            while(!__tmp39_last)
                                            {
                                                string __tmp39_line = __tmp39Reader.ReadLine();
                                                __tmp39_last = __tmp39Reader.EndOfStream;
                                                if ((__tmp39_last && !string.IsNullOrEmpty(__tmp39_line)) || (!__tmp39_last && __tmp39_line != null))
                                                {
                                                    __out.Append(__tmp39_line);
                                                    __tmp35_outputWritten = true;
                                                }
                                                if (!__tmp39_last) __out.AppendLine(true);
                                            }
                                        }
                                        string __tmp40_line = "\">"; //149:77
                                        if (!string.IsNullOrEmpty(__tmp40_line))
                                        {
                                            __out.Append(__tmp40_line);
                                            __tmp35_outputWritten = true;
                                        }
                                        if (__tmp35_outputWritten) __out.AppendLine(true);
                                        if (__tmp35_outputWritten)
                                        {
                                            __out.AppendLine(false); //149:79
                                        }
                                    }
                                    else //150:8
                                    {
                                        bool __tmp42_outputWritten = false;
                                        string __tmp43_line = "						<xs:element name=\""; //151:1
                                        if (!string.IsNullOrEmpty(__tmp43_line))
                                        {
                                            __out.Append(__tmp43_line);
                                            __tmp42_outputWritten = true;
                                        }
                                        StringBuilder __tmp44 = new StringBuilder();
                                        __tmp44.Append(array.InnerType.GetXsdName());
                                        using(StreamReader __tmp44Reader = new StreamReader(this.__ToStream(__tmp44.ToString())))
                                        {
                                            bool __tmp44_last = __tmp44Reader.EndOfStream;
                                            while(!__tmp44_last)
                                            {
                                                string __tmp44_line = __tmp44Reader.ReadLine();
                                                __tmp44_last = __tmp44Reader.EndOfStream;
                                                if ((__tmp44_last && !string.IsNullOrEmpty(__tmp44_line)) || (!__tmp44_last && __tmp44_line != null))
                                                {
                                                    __out.Append(__tmp44_line);
                                                    __tmp42_outputWritten = true;
                                                }
                                                if (!__tmp44_last) __out.AppendLine(true);
                                            }
                                        }
                                        string __tmp45_line = "\" nillable=\""; //151:55
                                        if (!string.IsNullOrEmpty(__tmp45_line))
                                        {
                                            __out.Append(__tmp45_line);
                                            __tmp42_outputWritten = true;
                                        }
                                        StringBuilder __tmp46 = new StringBuilder();
                                        __tmp46.Append(array.InnerType.IsNullableXsd());
                                        using(StreamReader __tmp46Reader = new StreamReader(this.__ToStream(__tmp46.ToString())))
                                        {
                                            bool __tmp46_last = __tmp46Reader.EndOfStream;
                                            while(!__tmp46_last)
                                            {
                                                string __tmp46_line = __tmp46Reader.ReadLine();
                                                __tmp46_last = __tmp46Reader.EndOfStream;
                                                if ((__tmp46_last && !string.IsNullOrEmpty(__tmp46_line)) || (!__tmp46_last && __tmp46_line != null))
                                                {
                                                    __out.Append(__tmp46_line);
                                                    __tmp42_outputWritten = true;
                                                }
                                                if (!__tmp46_last) __out.AppendLine(true);
                                            }
                                        }
                                        string __tmp47_line = "\">"; //151:100
                                        if (!string.IsNullOrEmpty(__tmp47_line))
                                        {
                                            __out.Append(__tmp47_line);
                                            __tmp42_outputWritten = true;
                                        }
                                        if (__tmp42_outputWritten) __out.AppendLine(true);
                                        if (__tmp42_outputWritten)
                                        {
                                            __out.AppendLine(false); //151:102
                                        }
                                    }
                                    bool __tmp49_outputWritten = false;
                                    string __tmp48Prefix = "						"; //153:1
                                    StringBuilder __tmp50 = new StringBuilder();
                                    __tmp50.Append(GenerateRestrictions(array.InnerType.GetNamespace(ns).Prefix + ":" + array.InnerType.GetXsdName(), restrAnnot));
                                    using(StreamReader __tmp50Reader = new StreamReader(this.__ToStream(__tmp50.ToString())))
                                    {
                                        bool __tmp50_last = __tmp50Reader.EndOfStream;
                                        while(!__tmp50_last)
                                        {
                                            string __tmp50_line = __tmp50Reader.ReadLine();
                                            __tmp50_last = __tmp50Reader.EndOfStream;
                                            if (!string.IsNullOrEmpty(__tmp48Prefix))
                                            {
                                                __out.Append(__tmp48Prefix);
                                                __tmp49_outputWritten = true;
                                            }
                                            if ((__tmp50_last && !string.IsNullOrEmpty(__tmp50_line)) || (!__tmp50_last && __tmp50_line != null))
                                            {
                                                __out.Append(__tmp50_line);
                                                __tmp49_outputWritten = true;
                                            }
                                            if (!__tmp50_last || __tmp49_outputWritten) __out.AppendLine(true);
                                        }
                                    }
                                    if (__tmp49_outputWritten)
                                    {
                                        __out.AppendLine(false); //153:115
                                    }
                                }
                                else //154:7
                                {
                                    if (items != null) //155:8
                                    {
                                        bool __tmp52_outputWritten = false;
                                        string __tmp53_line = "						<xs:element name=\""; //156:1
                                        if (!string.IsNullOrEmpty(__tmp53_line))
                                        {
                                            __out.Append(__tmp53_line);
                                            __tmp52_outputWritten = true;
                                        }
                                        StringBuilder __tmp54 = new StringBuilder();
                                        __tmp54.Append(items);
                                        using(StreamReader __tmp54Reader = new StreamReader(this.__ToStream(__tmp54.ToString())))
                                        {
                                            bool __tmp54_last = __tmp54Reader.EndOfStream;
                                            while(!__tmp54_last)
                                            {
                                                string __tmp54_line = __tmp54Reader.ReadLine();
                                                __tmp54_last = __tmp54Reader.EndOfStream;
                                                if ((__tmp54_last && !string.IsNullOrEmpty(__tmp54_line)) || (!__tmp54_last && __tmp54_line != null))
                                                {
                                                    __out.Append(__tmp54_line);
                                                    __tmp52_outputWritten = true;
                                                }
                                                if (!__tmp54_last) __out.AppendLine(true);
                                            }
                                        }
                                        string __tmp55_line = "\" type=\""; //156:32
                                        if (!string.IsNullOrEmpty(__tmp55_line))
                                        {
                                            __out.Append(__tmp55_line);
                                            __tmp52_outputWritten = true;
                                        }
                                        StringBuilder __tmp56 = new StringBuilder();
                                        __tmp56.Append(array.InnerType.GetNamespace(ns).Prefix);
                                        using(StreamReader __tmp56Reader = new StreamReader(this.__ToStream(__tmp56.ToString())))
                                        {
                                            bool __tmp56_last = __tmp56Reader.EndOfStream;
                                            while(!__tmp56_last)
                                            {
                                                string __tmp56_line = __tmp56Reader.ReadLine();
                                                __tmp56_last = __tmp56Reader.EndOfStream;
                                                if ((__tmp56_last && !string.IsNullOrEmpty(__tmp56_line)) || (!__tmp56_last && __tmp56_line != null))
                                                {
                                                    __out.Append(__tmp56_line);
                                                    __tmp52_outputWritten = true;
                                                }
                                                if (!__tmp56_last) __out.AppendLine(true);
                                            }
                                        }
                                        string __tmp57_line = ":"; //156:81
                                        if (!string.IsNullOrEmpty(__tmp57_line))
                                        {
                                            __out.Append(__tmp57_line);
                                            __tmp52_outputWritten = true;
                                        }
                                        StringBuilder __tmp58 = new StringBuilder();
                                        __tmp58.Append(array.InnerType.GetXsdName());
                                        using(StreamReader __tmp58Reader = new StreamReader(this.__ToStream(__tmp58.ToString())))
                                        {
                                            bool __tmp58_last = __tmp58Reader.EndOfStream;
                                            while(!__tmp58_last)
                                            {
                                                string __tmp58_line = __tmp58Reader.ReadLine();
                                                __tmp58_last = __tmp58Reader.EndOfStream;
                                                if ((__tmp58_last && !string.IsNullOrEmpty(__tmp58_line)) || (!__tmp58_last && __tmp58_line != null))
                                                {
                                                    __out.Append(__tmp58_line);
                                                    __tmp52_outputWritten = true;
                                                }
                                                if (!__tmp58_last) __out.AppendLine(true);
                                            }
                                        }
                                        string __tmp59_line = "\" nillable=\""; //156:112
                                        if (!string.IsNullOrEmpty(__tmp59_line))
                                        {
                                            __out.Append(__tmp59_line);
                                            __tmp52_outputWritten = true;
                                        }
                                        StringBuilder __tmp60 = new StringBuilder();
                                        __tmp60.Append(array.InnerType.IsNullableXsd());
                                        using(StreamReader __tmp60Reader = new StreamReader(this.__ToStream(__tmp60.ToString())))
                                        {
                                            bool __tmp60_last = __tmp60Reader.EndOfStream;
                                            while(!__tmp60_last)
                                            {
                                                string __tmp60_line = __tmp60Reader.ReadLine();
                                                __tmp60_last = __tmp60Reader.EndOfStream;
                                                if ((__tmp60_last && !string.IsNullOrEmpty(__tmp60_line)) || (!__tmp60_last && __tmp60_line != null))
                                                {
                                                    __out.Append(__tmp60_line);
                                                    __tmp52_outputWritten = true;
                                                }
                                                if (!__tmp60_last) __out.AppendLine(true);
                                            }
                                        }
                                        string __tmp61_line = "\"/>"; //156:157
                                        if (!string.IsNullOrEmpty(__tmp61_line))
                                        {
                                            __out.Append(__tmp61_line);
                                            __tmp52_outputWritten = true;
                                        }
                                        if (__tmp52_outputWritten) __out.AppendLine(true);
                                        if (__tmp52_outputWritten)
                                        {
                                            __out.AppendLine(false); //156:160
                                        }
                                    }
                                    else //157:8
                                    {
                                        bool __tmp63_outputWritten = false;
                                        string __tmp64_line = "						<xs:element name=\""; //158:1
                                        if (!string.IsNullOrEmpty(__tmp64_line))
                                        {
                                            __out.Append(__tmp64_line);
                                            __tmp63_outputWritten = true;
                                        }
                                        StringBuilder __tmp65 = new StringBuilder();
                                        __tmp65.Append(array.InnerType.GetXsdName());
                                        using(StreamReader __tmp65Reader = new StreamReader(this.__ToStream(__tmp65.ToString())))
                                        {
                                            bool __tmp65_last = __tmp65Reader.EndOfStream;
                                            while(!__tmp65_last)
                                            {
                                                string __tmp65_line = __tmp65Reader.ReadLine();
                                                __tmp65_last = __tmp65Reader.EndOfStream;
                                                if ((__tmp65_last && !string.IsNullOrEmpty(__tmp65_line)) || (!__tmp65_last && __tmp65_line != null))
                                                {
                                                    __out.Append(__tmp65_line);
                                                    __tmp63_outputWritten = true;
                                                }
                                                if (!__tmp65_last) __out.AppendLine(true);
                                            }
                                        }
                                        string __tmp66_line = "\" type=\""; //158:55
                                        if (!string.IsNullOrEmpty(__tmp66_line))
                                        {
                                            __out.Append(__tmp66_line);
                                            __tmp63_outputWritten = true;
                                        }
                                        StringBuilder __tmp67 = new StringBuilder();
                                        __tmp67.Append(array.InnerType.GetNamespace(ns).Prefix);
                                        using(StreamReader __tmp67Reader = new StreamReader(this.__ToStream(__tmp67.ToString())))
                                        {
                                            bool __tmp67_last = __tmp67Reader.EndOfStream;
                                            while(!__tmp67_last)
                                            {
                                                string __tmp67_line = __tmp67Reader.ReadLine();
                                                __tmp67_last = __tmp67Reader.EndOfStream;
                                                if ((__tmp67_last && !string.IsNullOrEmpty(__tmp67_line)) || (!__tmp67_last && __tmp67_line != null))
                                                {
                                                    __out.Append(__tmp67_line);
                                                    __tmp63_outputWritten = true;
                                                }
                                                if (!__tmp67_last) __out.AppendLine(true);
                                            }
                                        }
                                        string __tmp68_line = ":"; //158:104
                                        if (!string.IsNullOrEmpty(__tmp68_line))
                                        {
                                            __out.Append(__tmp68_line);
                                            __tmp63_outputWritten = true;
                                        }
                                        StringBuilder __tmp69 = new StringBuilder();
                                        __tmp69.Append(array.InnerType.GetXsdName());
                                        using(StreamReader __tmp69Reader = new StreamReader(this.__ToStream(__tmp69.ToString())))
                                        {
                                            bool __tmp69_last = __tmp69Reader.EndOfStream;
                                            while(!__tmp69_last)
                                            {
                                                string __tmp69_line = __tmp69Reader.ReadLine();
                                                __tmp69_last = __tmp69Reader.EndOfStream;
                                                if ((__tmp69_last && !string.IsNullOrEmpty(__tmp69_line)) || (!__tmp69_last && __tmp69_line != null))
                                                {
                                                    __out.Append(__tmp69_line);
                                                    __tmp63_outputWritten = true;
                                                }
                                                if (!__tmp69_last) __out.AppendLine(true);
                                            }
                                        }
                                        string __tmp70_line = "\" nillable=\""; //158:135
                                        if (!string.IsNullOrEmpty(__tmp70_line))
                                        {
                                            __out.Append(__tmp70_line);
                                            __tmp63_outputWritten = true;
                                        }
                                        StringBuilder __tmp71 = new StringBuilder();
                                        __tmp71.Append(array.InnerType.IsNullableXsd());
                                        using(StreamReader __tmp71Reader = new StreamReader(this.__ToStream(__tmp71.ToString())))
                                        {
                                            bool __tmp71_last = __tmp71Reader.EndOfStream;
                                            while(!__tmp71_last)
                                            {
                                                string __tmp71_line = __tmp71Reader.ReadLine();
                                                __tmp71_last = __tmp71Reader.EndOfStream;
                                                if ((__tmp71_last && !string.IsNullOrEmpty(__tmp71_line)) || (!__tmp71_last && __tmp71_line != null))
                                                {
                                                    __out.Append(__tmp71_line);
                                                    __tmp63_outputWritten = true;
                                                }
                                                if (!__tmp71_last) __out.AppendLine(true);
                                            }
                                        }
                                        string __tmp72_line = "\"/>"; //158:180
                                        if (!string.IsNullOrEmpty(__tmp72_line))
                                        {
                                            __out.Append(__tmp72_line);
                                            __tmp63_outputWritten = true;
                                        }
                                        if (__tmp63_outputWritten) __out.AppendLine(true);
                                        if (__tmp63_outputWritten)
                                        {
                                            __out.AppendLine(false); //158:183
                                        }
                                    }
                                }
                                __out.Append("					</xs:all>"); //161:1
                                __out.AppendLine(false); //161:15
                                __out.Append("				</xs:complexType>"); //162:1
                                __out.AppendLine(false); //162:22
                                __out.Append("			</xs:element>"); //163:1
                                __out.AppendLine(false); //163:17
                                __out.Append("		</xs:all>"); //164:1
                                __out.AppendLine(false); //164:12
                            }
                            else //165:6
                            {
                                __out.Append("		<xs:sequence>"); //166:1
                                __out.AppendLine(false); //166:16
                                if (restrAnnot != null && array.InnerType.GetCoreType() is PrimitiveType) //167:7
                                {
                                    if (items != null) //168:8
                                    {
                                        bool __tmp74_outputWritten = false;
                                        string __tmp75_line = "			<xs:element name=\""; //169:1
                                        if (!string.IsNullOrEmpty(__tmp75_line))
                                        {
                                            __out.Append(__tmp75_line);
                                            __tmp74_outputWritten = true;
                                        }
                                        StringBuilder __tmp76 = new StringBuilder();
                                        __tmp76.Append(items);
                                        using(StreamReader __tmp76Reader = new StreamReader(this.__ToStream(__tmp76.ToString())))
                                        {
                                            bool __tmp76_last = __tmp76Reader.EndOfStream;
                                            while(!__tmp76_last)
                                            {
                                                string __tmp76_line = __tmp76Reader.ReadLine();
                                                __tmp76_last = __tmp76Reader.EndOfStream;
                                                if ((__tmp76_last && !string.IsNullOrEmpty(__tmp76_line)) || (!__tmp76_last && __tmp76_line != null))
                                                {
                                                    __out.Append(__tmp76_line);
                                                    __tmp74_outputWritten = true;
                                                }
                                                if (!__tmp76_last) __out.AppendLine(true);
                                            }
                                        }
                                        string __tmp77_line = "\" nillable=\""; //169:29
                                        if (!string.IsNullOrEmpty(__tmp77_line))
                                        {
                                            __out.Append(__tmp77_line);
                                            __tmp74_outputWritten = true;
                                        }
                                        StringBuilder __tmp78 = new StringBuilder();
                                        __tmp78.Append(array.InnerType.IsNullableXsd());
                                        using(StreamReader __tmp78Reader = new StreamReader(this.__ToStream(__tmp78.ToString())))
                                        {
                                            bool __tmp78_last = __tmp78Reader.EndOfStream;
                                            while(!__tmp78_last)
                                            {
                                                string __tmp78_line = __tmp78Reader.ReadLine();
                                                __tmp78_last = __tmp78Reader.EndOfStream;
                                                if ((__tmp78_last && !string.IsNullOrEmpty(__tmp78_line)) || (!__tmp78_last && __tmp78_line != null))
                                                {
                                                    __out.Append(__tmp78_line);
                                                    __tmp74_outputWritten = true;
                                                }
                                                if (!__tmp78_last) __out.AppendLine(true);
                                            }
                                        }
                                        string __tmp79_line = "\" minOccurs=\"0\" maxOccurs=\"unbounded\">"; //169:74
                                        if (!string.IsNullOrEmpty(__tmp79_line))
                                        {
                                            __out.Append(__tmp79_line);
                                            __tmp74_outputWritten = true;
                                        }
                                        if (__tmp74_outputWritten) __out.AppendLine(true);
                                        if (__tmp74_outputWritten)
                                        {
                                            __out.AppendLine(false); //169:112
                                        }
                                    }
                                    else //170:8
                                    {
                                        bool __tmp81_outputWritten = false;
                                        string __tmp82_line = "			<xs:element name=\""; //171:1
                                        if (!string.IsNullOrEmpty(__tmp82_line))
                                        {
                                            __out.Append(__tmp82_line);
                                            __tmp81_outputWritten = true;
                                        }
                                        StringBuilder __tmp83 = new StringBuilder();
                                        __tmp83.Append(array.InnerType.GetXsdName());
                                        using(StreamReader __tmp83Reader = new StreamReader(this.__ToStream(__tmp83.ToString())))
                                        {
                                            bool __tmp83_last = __tmp83Reader.EndOfStream;
                                            while(!__tmp83_last)
                                            {
                                                string __tmp83_line = __tmp83Reader.ReadLine();
                                                __tmp83_last = __tmp83Reader.EndOfStream;
                                                if ((__tmp83_last && !string.IsNullOrEmpty(__tmp83_line)) || (!__tmp83_last && __tmp83_line != null))
                                                {
                                                    __out.Append(__tmp83_line);
                                                    __tmp81_outputWritten = true;
                                                }
                                                if (!__tmp83_last) __out.AppendLine(true);
                                            }
                                        }
                                        string __tmp84_line = "\" nillable=\""; //171:52
                                        if (!string.IsNullOrEmpty(__tmp84_line))
                                        {
                                            __out.Append(__tmp84_line);
                                            __tmp81_outputWritten = true;
                                        }
                                        StringBuilder __tmp85 = new StringBuilder();
                                        __tmp85.Append(array.InnerType.IsNullableXsd());
                                        using(StreamReader __tmp85Reader = new StreamReader(this.__ToStream(__tmp85.ToString())))
                                        {
                                            bool __tmp85_last = __tmp85Reader.EndOfStream;
                                            while(!__tmp85_last)
                                            {
                                                string __tmp85_line = __tmp85Reader.ReadLine();
                                                __tmp85_last = __tmp85Reader.EndOfStream;
                                                if ((__tmp85_last && !string.IsNullOrEmpty(__tmp85_line)) || (!__tmp85_last && __tmp85_line != null))
                                                {
                                                    __out.Append(__tmp85_line);
                                                    __tmp81_outputWritten = true;
                                                }
                                                if (!__tmp85_last) __out.AppendLine(true);
                                            }
                                        }
                                        string __tmp86_line = "\" minOccurs=\"0\" maxOccurs=\"unbounded\">"; //171:97
                                        if (!string.IsNullOrEmpty(__tmp86_line))
                                        {
                                            __out.Append(__tmp86_line);
                                            __tmp81_outputWritten = true;
                                        }
                                        if (__tmp81_outputWritten) __out.AppendLine(true);
                                        if (__tmp81_outputWritten)
                                        {
                                            __out.AppendLine(false); //171:135
                                        }
                                    }
                                    bool __tmp88_outputWritten = false;
                                    string __tmp87Prefix = "			"; //173:1
                                    StringBuilder __tmp89 = new StringBuilder();
                                    __tmp89.Append(GenerateRestrictions(array.InnerType.GetNamespace(ns).Prefix + ":" + array.InnerType.GetXsdName(), restrAnnot));
                                    using(StreamReader __tmp89Reader = new StreamReader(this.__ToStream(__tmp89.ToString())))
                                    {
                                        bool __tmp89_last = __tmp89Reader.EndOfStream;
                                        while(!__tmp89_last)
                                        {
                                            string __tmp89_line = __tmp89Reader.ReadLine();
                                            __tmp89_last = __tmp89Reader.EndOfStream;
                                            if (!string.IsNullOrEmpty(__tmp87Prefix))
                                            {
                                                __out.Append(__tmp87Prefix);
                                                __tmp88_outputWritten = true;
                                            }
                                            if ((__tmp89_last && !string.IsNullOrEmpty(__tmp89_line)) || (!__tmp89_last && __tmp89_line != null))
                                            {
                                                __out.Append(__tmp89_line);
                                                __tmp88_outputWritten = true;
                                            }
                                            if (!__tmp89_last || __tmp88_outputWritten) __out.AppendLine(true);
                                        }
                                    }
                                    if (__tmp88_outputWritten)
                                    {
                                        __out.AppendLine(false); //173:112
                                    }
                                }
                                else //174:7
                                {
                                    if (items != null) //175:8
                                    {
                                        bool __tmp91_outputWritten = false;
                                        string __tmp92_line = "			<xs:element name=\""; //176:1
                                        if (!string.IsNullOrEmpty(__tmp92_line))
                                        {
                                            __out.Append(__tmp92_line);
                                            __tmp91_outputWritten = true;
                                        }
                                        StringBuilder __tmp93 = new StringBuilder();
                                        __tmp93.Append(items);
                                        using(StreamReader __tmp93Reader = new StreamReader(this.__ToStream(__tmp93.ToString())))
                                        {
                                            bool __tmp93_last = __tmp93Reader.EndOfStream;
                                            while(!__tmp93_last)
                                            {
                                                string __tmp93_line = __tmp93Reader.ReadLine();
                                                __tmp93_last = __tmp93Reader.EndOfStream;
                                                if ((__tmp93_last && !string.IsNullOrEmpty(__tmp93_line)) || (!__tmp93_last && __tmp93_line != null))
                                                {
                                                    __out.Append(__tmp93_line);
                                                    __tmp91_outputWritten = true;
                                                }
                                                if (!__tmp93_last) __out.AppendLine(true);
                                            }
                                        }
                                        string __tmp94_line = "\" type=\""; //176:29
                                        if (!string.IsNullOrEmpty(__tmp94_line))
                                        {
                                            __out.Append(__tmp94_line);
                                            __tmp91_outputWritten = true;
                                        }
                                        StringBuilder __tmp95 = new StringBuilder();
                                        __tmp95.Append(array.InnerType.GetNamespace(ns).Prefix);
                                        using(StreamReader __tmp95Reader = new StreamReader(this.__ToStream(__tmp95.ToString())))
                                        {
                                            bool __tmp95_last = __tmp95Reader.EndOfStream;
                                            while(!__tmp95_last)
                                            {
                                                string __tmp95_line = __tmp95Reader.ReadLine();
                                                __tmp95_last = __tmp95Reader.EndOfStream;
                                                if ((__tmp95_last && !string.IsNullOrEmpty(__tmp95_line)) || (!__tmp95_last && __tmp95_line != null))
                                                {
                                                    __out.Append(__tmp95_line);
                                                    __tmp91_outputWritten = true;
                                                }
                                                if (!__tmp95_last) __out.AppendLine(true);
                                            }
                                        }
                                        string __tmp96_line = ":"; //176:78
                                        if (!string.IsNullOrEmpty(__tmp96_line))
                                        {
                                            __out.Append(__tmp96_line);
                                            __tmp91_outputWritten = true;
                                        }
                                        StringBuilder __tmp97 = new StringBuilder();
                                        __tmp97.Append(array.InnerType.GetXsdName());
                                        using(StreamReader __tmp97Reader = new StreamReader(this.__ToStream(__tmp97.ToString())))
                                        {
                                            bool __tmp97_last = __tmp97Reader.EndOfStream;
                                            while(!__tmp97_last)
                                            {
                                                string __tmp97_line = __tmp97Reader.ReadLine();
                                                __tmp97_last = __tmp97Reader.EndOfStream;
                                                if ((__tmp97_last && !string.IsNullOrEmpty(__tmp97_line)) || (!__tmp97_last && __tmp97_line != null))
                                                {
                                                    __out.Append(__tmp97_line);
                                                    __tmp91_outputWritten = true;
                                                }
                                                if (!__tmp97_last) __out.AppendLine(true);
                                            }
                                        }
                                        string __tmp98_line = "\" nillable=\""; //176:109
                                        if (!string.IsNullOrEmpty(__tmp98_line))
                                        {
                                            __out.Append(__tmp98_line);
                                            __tmp91_outputWritten = true;
                                        }
                                        StringBuilder __tmp99 = new StringBuilder();
                                        __tmp99.Append(array.InnerType.IsNullableXsd());
                                        using(StreamReader __tmp99Reader = new StreamReader(this.__ToStream(__tmp99.ToString())))
                                        {
                                            bool __tmp99_last = __tmp99Reader.EndOfStream;
                                            while(!__tmp99_last)
                                            {
                                                string __tmp99_line = __tmp99Reader.ReadLine();
                                                __tmp99_last = __tmp99Reader.EndOfStream;
                                                if ((__tmp99_last && !string.IsNullOrEmpty(__tmp99_line)) || (!__tmp99_last && __tmp99_line != null))
                                                {
                                                    __out.Append(__tmp99_line);
                                                    __tmp91_outputWritten = true;
                                                }
                                                if (!__tmp99_last) __out.AppendLine(true);
                                            }
                                        }
                                        string __tmp100_line = "\" minOccurs=\"0\" maxOccurs=\"unbounded\"/>"; //176:154
                                        if (!string.IsNullOrEmpty(__tmp100_line))
                                        {
                                            __out.Append(__tmp100_line);
                                            __tmp91_outputWritten = true;
                                        }
                                        if (__tmp91_outputWritten) __out.AppendLine(true);
                                        if (__tmp91_outputWritten)
                                        {
                                            __out.AppendLine(false); //176:193
                                        }
                                    }
                                    else //177:8
                                    {
                                        bool __tmp102_outputWritten = false;
                                        string __tmp103_line = "			<xs:element name=\""; //178:1
                                        if (!string.IsNullOrEmpty(__tmp103_line))
                                        {
                                            __out.Append(__tmp103_line);
                                            __tmp102_outputWritten = true;
                                        }
                                        StringBuilder __tmp104 = new StringBuilder();
                                        __tmp104.Append(array.InnerType.GetXsdName());
                                        using(StreamReader __tmp104Reader = new StreamReader(this.__ToStream(__tmp104.ToString())))
                                        {
                                            bool __tmp104_last = __tmp104Reader.EndOfStream;
                                            while(!__tmp104_last)
                                            {
                                                string __tmp104_line = __tmp104Reader.ReadLine();
                                                __tmp104_last = __tmp104Reader.EndOfStream;
                                                if ((__tmp104_last && !string.IsNullOrEmpty(__tmp104_line)) || (!__tmp104_last && __tmp104_line != null))
                                                {
                                                    __out.Append(__tmp104_line);
                                                    __tmp102_outputWritten = true;
                                                }
                                                if (!__tmp104_last) __out.AppendLine(true);
                                            }
                                        }
                                        string __tmp105_line = "\" type=\""; //178:52
                                        if (!string.IsNullOrEmpty(__tmp105_line))
                                        {
                                            __out.Append(__tmp105_line);
                                            __tmp102_outputWritten = true;
                                        }
                                        StringBuilder __tmp106 = new StringBuilder();
                                        __tmp106.Append(array.InnerType.GetNamespace(ns).Prefix);
                                        using(StreamReader __tmp106Reader = new StreamReader(this.__ToStream(__tmp106.ToString())))
                                        {
                                            bool __tmp106_last = __tmp106Reader.EndOfStream;
                                            while(!__tmp106_last)
                                            {
                                                string __tmp106_line = __tmp106Reader.ReadLine();
                                                __tmp106_last = __tmp106Reader.EndOfStream;
                                                if ((__tmp106_last && !string.IsNullOrEmpty(__tmp106_line)) || (!__tmp106_last && __tmp106_line != null))
                                                {
                                                    __out.Append(__tmp106_line);
                                                    __tmp102_outputWritten = true;
                                                }
                                                if (!__tmp106_last) __out.AppendLine(true);
                                            }
                                        }
                                        string __tmp107_line = ":"; //178:101
                                        if (!string.IsNullOrEmpty(__tmp107_line))
                                        {
                                            __out.Append(__tmp107_line);
                                            __tmp102_outputWritten = true;
                                        }
                                        StringBuilder __tmp108 = new StringBuilder();
                                        __tmp108.Append(array.InnerType.GetXsdName());
                                        using(StreamReader __tmp108Reader = new StreamReader(this.__ToStream(__tmp108.ToString())))
                                        {
                                            bool __tmp108_last = __tmp108Reader.EndOfStream;
                                            while(!__tmp108_last)
                                            {
                                                string __tmp108_line = __tmp108Reader.ReadLine();
                                                __tmp108_last = __tmp108Reader.EndOfStream;
                                                if ((__tmp108_last && !string.IsNullOrEmpty(__tmp108_line)) || (!__tmp108_last && __tmp108_line != null))
                                                {
                                                    __out.Append(__tmp108_line);
                                                    __tmp102_outputWritten = true;
                                                }
                                                if (!__tmp108_last) __out.AppendLine(true);
                                            }
                                        }
                                        string __tmp109_line = "\" nillable=\""; //178:132
                                        if (!string.IsNullOrEmpty(__tmp109_line))
                                        {
                                            __out.Append(__tmp109_line);
                                            __tmp102_outputWritten = true;
                                        }
                                        StringBuilder __tmp110 = new StringBuilder();
                                        __tmp110.Append(array.InnerType.IsNullableXsd());
                                        using(StreamReader __tmp110Reader = new StreamReader(this.__ToStream(__tmp110.ToString())))
                                        {
                                            bool __tmp110_last = __tmp110Reader.EndOfStream;
                                            while(!__tmp110_last)
                                            {
                                                string __tmp110_line = __tmp110Reader.ReadLine();
                                                __tmp110_last = __tmp110Reader.EndOfStream;
                                                if ((__tmp110_last && !string.IsNullOrEmpty(__tmp110_line)) || (!__tmp110_last && __tmp110_line != null))
                                                {
                                                    __out.Append(__tmp110_line);
                                                    __tmp102_outputWritten = true;
                                                }
                                                if (!__tmp110_last) __out.AppendLine(true);
                                            }
                                        }
                                        string __tmp111_line = "\" minOccurs=\"0\" maxOccurs=\"unbounded\"/>"; //178:177
                                        if (!string.IsNullOrEmpty(__tmp111_line))
                                        {
                                            __out.Append(__tmp111_line);
                                            __tmp102_outputWritten = true;
                                        }
                                        if (__tmp102_outputWritten) __out.AppendLine(true);
                                        if (__tmp102_outputWritten)
                                        {
                                            __out.AppendLine(false); //178:216
                                        }
                                    }
                                }
                                __out.Append("		</xs:sequence>"); //181:1
                                __out.AppendLine(false); //181:17
                            }
                            __out.Append("	</xs:complexType>"); //183:1
                            __out.AppendLine(false); //183:19
                            __out.Append("</xs:element>"); //184:1
                            __out.AppendLine(false); //184:14
                        }
                        else //185:5
                        {
                            if (restrAnnot != null && array.InnerType.GetCoreType() is PrimitiveType) //186:6
                            {
                                bool __tmp113_outputWritten = false;
                                string __tmp114_line = "<xs:element name=\""; //187:1
                                if (!string.IsNullOrEmpty(__tmp114_line))
                                {
                                    __out.Append(__tmp114_line);
                                    __tmp113_outputWritten = true;
                                }
                                StringBuilder __tmp115 = new StringBuilder();
                                __tmp115.Append(name);
                                using(StreamReader __tmp115Reader = new StreamReader(this.__ToStream(__tmp115.ToString())))
                                {
                                    bool __tmp115_last = __tmp115Reader.EndOfStream;
                                    while(!__tmp115_last)
                                    {
                                        string __tmp115_line = __tmp115Reader.ReadLine();
                                        __tmp115_last = __tmp115Reader.EndOfStream;
                                        if ((__tmp115_last && !string.IsNullOrEmpty(__tmp115_line)) || (!__tmp115_last && __tmp115_line != null))
                                        {
                                            __out.Append(__tmp115_line);
                                            __tmp113_outputWritten = true;
                                        }
                                        if (!__tmp115_last) __out.AppendLine(true);
                                    }
                                }
                                string __tmp116_line = "\" nillable=\""; //187:25
                                if (!string.IsNullOrEmpty(__tmp116_line))
                                {
                                    __out.Append(__tmp116_line);
                                    __tmp113_outputWritten = true;
                                }
                                StringBuilder __tmp117 = new StringBuilder();
                                __tmp117.Append(array.InnerType.IsNullableXsd());
                                using(StreamReader __tmp117Reader = new StreamReader(this.__ToStream(__tmp117.ToString())))
                                {
                                    bool __tmp117_last = __tmp117Reader.EndOfStream;
                                    while(!__tmp117_last)
                                    {
                                        string __tmp117_line = __tmp117Reader.ReadLine();
                                        __tmp117_last = __tmp117Reader.EndOfStream;
                                        if ((__tmp117_last && !string.IsNullOrEmpty(__tmp117_line)) || (!__tmp117_last && __tmp117_line != null))
                                        {
                                            __out.Append(__tmp117_line);
                                            __tmp113_outputWritten = true;
                                        }
                                        if (!__tmp117_last) __out.AppendLine(true);
                                    }
                                }
                                string __tmp118_line = "\" minOccurs=\"0\" maxOccurs=\"unbounded\">"; //187:70
                                if (!string.IsNullOrEmpty(__tmp118_line))
                                {
                                    __out.Append(__tmp118_line);
                                    __tmp113_outputWritten = true;
                                }
                                if (__tmp113_outputWritten) __out.AppendLine(true);
                                if (__tmp113_outputWritten)
                                {
                                    __out.AppendLine(false); //187:108
                                }
                                bool __tmp120_outputWritten = false;
                                StringBuilder __tmp121 = new StringBuilder();
                                __tmp121.Append(GenerateRestrictions(array.InnerType.GetNamespace(ns).Prefix + ":" + array.InnerType.GetXsdName(), restrAnnot));
                                using(StreamReader __tmp121Reader = new StreamReader(this.__ToStream(__tmp121.ToString())))
                                {
                                    bool __tmp121_last = __tmp121Reader.EndOfStream;
                                    while(!__tmp121_last)
                                    {
                                        string __tmp121_line = __tmp121Reader.ReadLine();
                                        __tmp121_last = __tmp121Reader.EndOfStream;
                                        if ((__tmp121_last && !string.IsNullOrEmpty(__tmp121_line)) || (!__tmp121_last && __tmp121_line != null))
                                        {
                                            __out.Append(__tmp121_line);
                                            __tmp120_outputWritten = true;
                                        }
                                        if (!__tmp121_last || __tmp120_outputWritten) __out.AppendLine(true);
                                    }
                                }
                                if (__tmp120_outputWritten)
                                {
                                    __out.AppendLine(false); //188:109
                                }
                            }
                            else //189:6
                            {
                                bool __tmp123_outputWritten = false;
                                string __tmp124_line = "<xs:element name=\""; //190:1
                                if (!string.IsNullOrEmpty(__tmp124_line))
                                {
                                    __out.Append(__tmp124_line);
                                    __tmp123_outputWritten = true;
                                }
                                StringBuilder __tmp125 = new StringBuilder();
                                __tmp125.Append(name);
                                using(StreamReader __tmp125Reader = new StreamReader(this.__ToStream(__tmp125.ToString())))
                                {
                                    bool __tmp125_last = __tmp125Reader.EndOfStream;
                                    while(!__tmp125_last)
                                    {
                                        string __tmp125_line = __tmp125Reader.ReadLine();
                                        __tmp125_last = __tmp125Reader.EndOfStream;
                                        if ((__tmp125_last && !string.IsNullOrEmpty(__tmp125_line)) || (!__tmp125_last && __tmp125_line != null))
                                        {
                                            __out.Append(__tmp125_line);
                                            __tmp123_outputWritten = true;
                                        }
                                        if (!__tmp125_last) __out.AppendLine(true);
                                    }
                                }
                                string __tmp126_line = "\" type=\""; //190:25
                                if (!string.IsNullOrEmpty(__tmp126_line))
                                {
                                    __out.Append(__tmp126_line);
                                    __tmp123_outputWritten = true;
                                }
                                StringBuilder __tmp127 = new StringBuilder();
                                __tmp127.Append(array.InnerType.GetNamespace(ns).Prefix);
                                using(StreamReader __tmp127Reader = new StreamReader(this.__ToStream(__tmp127.ToString())))
                                {
                                    bool __tmp127_last = __tmp127Reader.EndOfStream;
                                    while(!__tmp127_last)
                                    {
                                        string __tmp127_line = __tmp127Reader.ReadLine();
                                        __tmp127_last = __tmp127Reader.EndOfStream;
                                        if ((__tmp127_last && !string.IsNullOrEmpty(__tmp127_line)) || (!__tmp127_last && __tmp127_line != null))
                                        {
                                            __out.Append(__tmp127_line);
                                            __tmp123_outputWritten = true;
                                        }
                                        if (!__tmp127_last) __out.AppendLine(true);
                                    }
                                }
                                string __tmp128_line = ":"; //190:74
                                if (!string.IsNullOrEmpty(__tmp128_line))
                                {
                                    __out.Append(__tmp128_line);
                                    __tmp123_outputWritten = true;
                                }
                                StringBuilder __tmp129 = new StringBuilder();
                                __tmp129.Append(array.InnerType.GetXsdName());
                                using(StreamReader __tmp129Reader = new StreamReader(this.__ToStream(__tmp129.ToString())))
                                {
                                    bool __tmp129_last = __tmp129Reader.EndOfStream;
                                    while(!__tmp129_last)
                                    {
                                        string __tmp129_line = __tmp129Reader.ReadLine();
                                        __tmp129_last = __tmp129Reader.EndOfStream;
                                        if ((__tmp129_last && !string.IsNullOrEmpty(__tmp129_line)) || (!__tmp129_last && __tmp129_line != null))
                                        {
                                            __out.Append(__tmp129_line);
                                            __tmp123_outputWritten = true;
                                        }
                                        if (!__tmp129_last) __out.AppendLine(true);
                                    }
                                }
                                string __tmp130_line = "\" nillable=\""; //190:105
                                if (!string.IsNullOrEmpty(__tmp130_line))
                                {
                                    __out.Append(__tmp130_line);
                                    __tmp123_outputWritten = true;
                                }
                                StringBuilder __tmp131 = new StringBuilder();
                                __tmp131.Append(array.InnerType.IsNullableXsd());
                                using(StreamReader __tmp131Reader = new StreamReader(this.__ToStream(__tmp131.ToString())))
                                {
                                    bool __tmp131_last = __tmp131Reader.EndOfStream;
                                    while(!__tmp131_last)
                                    {
                                        string __tmp131_line = __tmp131Reader.ReadLine();
                                        __tmp131_last = __tmp131Reader.EndOfStream;
                                        if ((__tmp131_last && !string.IsNullOrEmpty(__tmp131_line)) || (!__tmp131_last && __tmp131_line != null))
                                        {
                                            __out.Append(__tmp131_line);
                                            __tmp123_outputWritten = true;
                                        }
                                        if (!__tmp131_last) __out.AppendLine(true);
                                    }
                                }
                                string __tmp132_line = "\" minOccurs=\"0\" maxOccurs=\"unbounded\"/>"; //190:150
                                if (!string.IsNullOrEmpty(__tmp132_line))
                                {
                                    __out.Append(__tmp132_line);
                                    __tmp123_outputWritten = true;
                                }
                                if (__tmp123_outputWritten) __out.AppendLine(true);
                                if (__tmp123_outputWritten)
                                {
                                    __out.AppendLine(false); //190:189
                                }
                            }
                        }
                    }
                }
                else //194:3
                {
                    if (restrAnnot != null && t.GetCoreType() is PrimitiveType) //195:4
                    {
                        bool __tmp134_outputWritten = false;
                        string __tmp135_line = "<xs:element name=\""; //196:1
                        if (!string.IsNullOrEmpty(__tmp135_line))
                        {
                            __out.Append(__tmp135_line);
                            __tmp134_outputWritten = true;
                        }
                        StringBuilder __tmp136 = new StringBuilder();
                        __tmp136.Append(name);
                        using(StreamReader __tmp136Reader = new StreamReader(this.__ToStream(__tmp136.ToString())))
                        {
                            bool __tmp136_last = __tmp136Reader.EndOfStream;
                            while(!__tmp136_last)
                            {
                                string __tmp136_line = __tmp136Reader.ReadLine();
                                __tmp136_last = __tmp136Reader.EndOfStream;
                                if ((__tmp136_last && !string.IsNullOrEmpty(__tmp136_line)) || (!__tmp136_last && __tmp136_line != null))
                                {
                                    __out.Append(__tmp136_line);
                                    __tmp134_outputWritten = true;
                                }
                                if (!__tmp136_last) __out.AppendLine(true);
                            }
                        }
                        string __tmp137_line = "\" nillable=\""; //196:25
                        if (!string.IsNullOrEmpty(__tmp137_line))
                        {
                            __out.Append(__tmp137_line);
                            __tmp134_outputWritten = true;
                        }
                        StringBuilder __tmp138 = new StringBuilder();
                        __tmp138.Append(t.IsNullableXsd());
                        using(StreamReader __tmp138Reader = new StreamReader(this.__ToStream(__tmp138.ToString())))
                        {
                            bool __tmp138_last = __tmp138Reader.EndOfStream;
                            while(!__tmp138_last)
                            {
                                string __tmp138_line = __tmp138Reader.ReadLine();
                                __tmp138_last = __tmp138Reader.EndOfStream;
                                if ((__tmp138_last && !string.IsNullOrEmpty(__tmp138_line)) || (!__tmp138_last && __tmp138_line != null))
                                {
                                    __out.Append(__tmp138_line);
                                    __tmp134_outputWritten = true;
                                }
                                if (!__tmp138_last) __out.AppendLine(true);
                            }
                        }
                        string __tmp139_line = "\""; //196:56
                        if (!string.IsNullOrEmpty(__tmp139_line))
                        {
                            __out.Append(__tmp139_line);
                            __tmp134_outputWritten = true;
                        }
                        StringBuilder __tmp140 = new StringBuilder();
                        __tmp140.Append(GetElementOptional(ae));
                        using(StreamReader __tmp140Reader = new StreamReader(this.__ToStream(__tmp140.ToString())))
                        {
                            bool __tmp140_last = __tmp140Reader.EndOfStream;
                            while(!__tmp140_last)
                            {
                                string __tmp140_line = __tmp140Reader.ReadLine();
                                __tmp140_last = __tmp140Reader.EndOfStream;
                                if ((__tmp140_last && !string.IsNullOrEmpty(__tmp140_line)) || (!__tmp140_last && __tmp140_line != null))
                                {
                                    __out.Append(__tmp140_line);
                                    __tmp134_outputWritten = true;
                                }
                                if (!__tmp140_last) __out.AppendLine(true);
                            }
                        }
                        string __tmp141_line = ">"; //196:81
                        if (!string.IsNullOrEmpty(__tmp141_line))
                        {
                            __out.Append(__tmp141_line);
                            __tmp134_outputWritten = true;
                        }
                        if (__tmp134_outputWritten) __out.AppendLine(true);
                        if (__tmp134_outputWritten)
                        {
                            __out.AppendLine(false); //196:82
                        }
                        bool __tmp143_outputWritten = false;
                        StringBuilder __tmp144 = new StringBuilder();
                        __tmp144.Append(GenerateRestrictions(t.GetNamespace(ns).Prefix + ":" + t.GetXsdName(), restrAnnot));
                        using(StreamReader __tmp144Reader = new StreamReader(this.__ToStream(__tmp144.ToString())))
                        {
                            bool __tmp144_last = __tmp144Reader.EndOfStream;
                            while(!__tmp144_last)
                            {
                                string __tmp144_line = __tmp144Reader.ReadLine();
                                __tmp144_last = __tmp144Reader.EndOfStream;
                                if ((__tmp144_last && !string.IsNullOrEmpty(__tmp144_line)) || (!__tmp144_last && __tmp144_line != null))
                                {
                                    __out.Append(__tmp144_line);
                                    __tmp143_outputWritten = true;
                                }
                                if (!__tmp144_last || __tmp143_outputWritten) __out.AppendLine(true);
                            }
                        }
                        if (__tmp143_outputWritten)
                        {
                            __out.AppendLine(false); //197:81
                        }
                    }
                    else //198:4
                    {
                        bool __tmp146_outputWritten = false;
                        string __tmp147_line = "<xs:element name=\""; //199:1
                        if (!string.IsNullOrEmpty(__tmp147_line))
                        {
                            __out.Append(__tmp147_line);
                            __tmp146_outputWritten = true;
                        }
                        StringBuilder __tmp148 = new StringBuilder();
                        __tmp148.Append(name);
                        using(StreamReader __tmp148Reader = new StreamReader(this.__ToStream(__tmp148.ToString())))
                        {
                            bool __tmp148_last = __tmp148Reader.EndOfStream;
                            while(!__tmp148_last)
                            {
                                string __tmp148_line = __tmp148Reader.ReadLine();
                                __tmp148_last = __tmp148Reader.EndOfStream;
                                if ((__tmp148_last && !string.IsNullOrEmpty(__tmp148_line)) || (!__tmp148_last && __tmp148_line != null))
                                {
                                    __out.Append(__tmp148_line);
                                    __tmp146_outputWritten = true;
                                }
                                if (!__tmp148_last) __out.AppendLine(true);
                            }
                        }
                        string __tmp149_line = "\" type=\""; //199:25
                        if (!string.IsNullOrEmpty(__tmp149_line))
                        {
                            __out.Append(__tmp149_line);
                            __tmp146_outputWritten = true;
                        }
                        StringBuilder __tmp150 = new StringBuilder();
                        __tmp150.Append(t.GetNamespace(ns).Prefix);
                        using(StreamReader __tmp150Reader = new StreamReader(this.__ToStream(__tmp150.ToString())))
                        {
                            bool __tmp150_last = __tmp150Reader.EndOfStream;
                            while(!__tmp150_last)
                            {
                                string __tmp150_line = __tmp150Reader.ReadLine();
                                __tmp150_last = __tmp150Reader.EndOfStream;
                                if ((__tmp150_last && !string.IsNullOrEmpty(__tmp150_line)) || (!__tmp150_last && __tmp150_line != null))
                                {
                                    __out.Append(__tmp150_line);
                                    __tmp146_outputWritten = true;
                                }
                                if (!__tmp150_last) __out.AppendLine(true);
                            }
                        }
                        string __tmp151_line = ":"; //199:60
                        if (!string.IsNullOrEmpty(__tmp151_line))
                        {
                            __out.Append(__tmp151_line);
                            __tmp146_outputWritten = true;
                        }
                        StringBuilder __tmp152 = new StringBuilder();
                        __tmp152.Append(t.GetXsdName());
                        using(StreamReader __tmp152Reader = new StreamReader(this.__ToStream(__tmp152.ToString())))
                        {
                            bool __tmp152_last = __tmp152Reader.EndOfStream;
                            while(!__tmp152_last)
                            {
                                string __tmp152_line = __tmp152Reader.ReadLine();
                                __tmp152_last = __tmp152Reader.EndOfStream;
                                if ((__tmp152_last && !string.IsNullOrEmpty(__tmp152_line)) || (!__tmp152_last && __tmp152_line != null))
                                {
                                    __out.Append(__tmp152_line);
                                    __tmp146_outputWritten = true;
                                }
                                if (!__tmp152_last) __out.AppendLine(true);
                            }
                        }
                        string __tmp153_line = "\" nillable=\""; //199:77
                        if (!string.IsNullOrEmpty(__tmp153_line))
                        {
                            __out.Append(__tmp153_line);
                            __tmp146_outputWritten = true;
                        }
                        StringBuilder __tmp154 = new StringBuilder();
                        __tmp154.Append(t.IsNullableXsd());
                        using(StreamReader __tmp154Reader = new StreamReader(this.__ToStream(__tmp154.ToString())))
                        {
                            bool __tmp154_last = __tmp154Reader.EndOfStream;
                            while(!__tmp154_last)
                            {
                                string __tmp154_line = __tmp154Reader.ReadLine();
                                __tmp154_last = __tmp154Reader.EndOfStream;
                                if ((__tmp154_last && !string.IsNullOrEmpty(__tmp154_line)) || (!__tmp154_last && __tmp154_line != null))
                                {
                                    __out.Append(__tmp154_line);
                                    __tmp146_outputWritten = true;
                                }
                                if (!__tmp154_last) __out.AppendLine(true);
                            }
                        }
                        string __tmp155_line = "\""; //199:108
                        if (!string.IsNullOrEmpty(__tmp155_line))
                        {
                            __out.Append(__tmp155_line);
                            __tmp146_outputWritten = true;
                        }
                        StringBuilder __tmp156 = new StringBuilder();
                        __tmp156.Append(GetElementOptional(ae));
                        using(StreamReader __tmp156Reader = new StreamReader(this.__ToStream(__tmp156.ToString())))
                        {
                            bool __tmp156_last = __tmp156Reader.EndOfStream;
                            while(!__tmp156_last)
                            {
                                string __tmp156_line = __tmp156Reader.ReadLine();
                                __tmp156_last = __tmp156Reader.EndOfStream;
                                if ((__tmp156_last && !string.IsNullOrEmpty(__tmp156_line)) || (!__tmp156_last && __tmp156_line != null))
                                {
                                    __out.Append(__tmp156_line);
                                    __tmp146_outputWritten = true;
                                }
                                if (!__tmp156_last) __out.AppendLine(true);
                            }
                        }
                        string __tmp157_line = "/>"; //199:133
                        if (!string.IsNullOrEmpty(__tmp157_line))
                        {
                            __out.Append(__tmp157_line);
                            __tmp146_outputWritten = true;
                        }
                        if (__tmp146_outputWritten) __out.AppendLine(true);
                        if (__tmp146_outputWritten)
                        {
                            __out.AppendLine(false); //199:135
                        }
                    }
                }
            }
            return __out.ToString();
        }

        public string GenerateParamType(Namespace ns, string name, SoalType t, AnnotatedElement ae) //205:1
        {
            StringBuilder __out = new StringBuilder();
            Annotation restrAnnot = ae.GetAnnotation(SoalAnnotations.Restriction); //206:2
            if (t.IsArrayType()) //207:2
            {
                ArrayType array = t is NonNullableType ? (ArrayType)((NonNullableType)t).InnerType : (ArrayType)t; //208:3
                if (array.GetCoreType() != SoalInstance.Byte) //209:3
                {
                    string items = ae.GetAnnotationPropertyValue(SoalAnnotations.Element, SoalAnnotationProperties.Items) as string; //210:4
                    bool __tmp2_outputWritten = false;
                    string __tmp3_line = "<xs:complexType name=\""; //211:1
                    if (!string.IsNullOrEmpty(__tmp3_line))
                    {
                        __out.Append(__tmp3_line);
                        __tmp2_outputWritten = true;
                    }
                    StringBuilder __tmp4 = new StringBuilder();
                    __tmp4.Append(name);
                    using(StreamReader __tmp4Reader = new StreamReader(this.__ToStream(__tmp4.ToString())))
                    {
                        bool __tmp4_last = __tmp4Reader.EndOfStream;
                        while(!__tmp4_last)
                        {
                            string __tmp4_line = __tmp4Reader.ReadLine();
                            __tmp4_last = __tmp4Reader.EndOfStream;
                            if ((__tmp4_last && !string.IsNullOrEmpty(__tmp4_line)) || (!__tmp4_last && __tmp4_line != null))
                            {
                                __out.Append(__tmp4_line);
                                __tmp2_outputWritten = true;
                            }
                            if (!__tmp4_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp5_line = "\">"; //211:29
                    if (!string.IsNullOrEmpty(__tmp5_line))
                    {
                        __out.Append(__tmp5_line);
                        __tmp2_outputWritten = true;
                    }
                    if (__tmp2_outputWritten) __out.AppendLine(true);
                    if (__tmp2_outputWritten)
                    {
                        __out.AppendLine(false); //211:31
                    }
                    object sap = ae.GetAnnotationPropertyValue(SoalAnnotations.Element, SoalAnnotationProperties.Sap); //212:4
                    if (sap != null && (bool)sap) //213:4
                    {
                        __out.Append("	<xs:all>"); //214:1
                        __out.AppendLine(false); //214:10
                        __out.Append("		<xs:element name=\"item\" minOccurs=\"0\" maxOccurs=\"unbounded\">"); //215:1
                        __out.AppendLine(false); //215:63
                        __out.Append("			<xs:complexType>"); //216:1
                        __out.AppendLine(false); //216:20
                        __out.Append("				<xs:all>"); //217:1
                        __out.AppendLine(false); //217:13
                        if (restrAnnot != null && array.InnerType.GetCoreType() is PrimitiveType) //218:5
                        {
                            if (items != null) //219:6
                            {
                                bool __tmp7_outputWritten = false;
                                string __tmp8_line = "					<xs:element name=\""; //220:1
                                if (!string.IsNullOrEmpty(__tmp8_line))
                                {
                                    __out.Append(__tmp8_line);
                                    __tmp7_outputWritten = true;
                                }
                                StringBuilder __tmp9 = new StringBuilder();
                                __tmp9.Append(items);
                                using(StreamReader __tmp9Reader = new StreamReader(this.__ToStream(__tmp9.ToString())))
                                {
                                    bool __tmp9_last = __tmp9Reader.EndOfStream;
                                    while(!__tmp9_last)
                                    {
                                        string __tmp9_line = __tmp9Reader.ReadLine();
                                        __tmp9_last = __tmp9Reader.EndOfStream;
                                        if ((__tmp9_last && !string.IsNullOrEmpty(__tmp9_line)) || (!__tmp9_last && __tmp9_line != null))
                                        {
                                            __out.Append(__tmp9_line);
                                            __tmp7_outputWritten = true;
                                        }
                                        if (!__tmp9_last) __out.AppendLine(true);
                                    }
                                }
                                string __tmp10_line = "\" nillable=\""; //220:31
                                if (!string.IsNullOrEmpty(__tmp10_line))
                                {
                                    __out.Append(__tmp10_line);
                                    __tmp7_outputWritten = true;
                                }
                                StringBuilder __tmp11 = new StringBuilder();
                                __tmp11.Append(array.InnerType.IsNullableXsd());
                                using(StreamReader __tmp11Reader = new StreamReader(this.__ToStream(__tmp11.ToString())))
                                {
                                    bool __tmp11_last = __tmp11Reader.EndOfStream;
                                    while(!__tmp11_last)
                                    {
                                        string __tmp11_line = __tmp11Reader.ReadLine();
                                        __tmp11_last = __tmp11Reader.EndOfStream;
                                        if ((__tmp11_last && !string.IsNullOrEmpty(__tmp11_line)) || (!__tmp11_last && __tmp11_line != null))
                                        {
                                            __out.Append(__tmp11_line);
                                            __tmp7_outputWritten = true;
                                        }
                                        if (!__tmp11_last) __out.AppendLine(true);
                                    }
                                }
                                string __tmp12_line = "\">"; //220:76
                                if (!string.IsNullOrEmpty(__tmp12_line))
                                {
                                    __out.Append(__tmp12_line);
                                    __tmp7_outputWritten = true;
                                }
                                if (__tmp7_outputWritten) __out.AppendLine(true);
                                if (__tmp7_outputWritten)
                                {
                                    __out.AppendLine(false); //220:78
                                }
                            }
                            else //221:6
                            {
                                bool __tmp14_outputWritten = false;
                                string __tmp15_line = "					<xs:element name=\""; //222:1
                                if (!string.IsNullOrEmpty(__tmp15_line))
                                {
                                    __out.Append(__tmp15_line);
                                    __tmp14_outputWritten = true;
                                }
                                StringBuilder __tmp16 = new StringBuilder();
                                __tmp16.Append(array.InnerType.GetXsdName());
                                using(StreamReader __tmp16Reader = new StreamReader(this.__ToStream(__tmp16.ToString())))
                                {
                                    bool __tmp16_last = __tmp16Reader.EndOfStream;
                                    while(!__tmp16_last)
                                    {
                                        string __tmp16_line = __tmp16Reader.ReadLine();
                                        __tmp16_last = __tmp16Reader.EndOfStream;
                                        if ((__tmp16_last && !string.IsNullOrEmpty(__tmp16_line)) || (!__tmp16_last && __tmp16_line != null))
                                        {
                                            __out.Append(__tmp16_line);
                                            __tmp14_outputWritten = true;
                                        }
                                        if (!__tmp16_last) __out.AppendLine(true);
                                    }
                                }
                                string __tmp17_line = "\" nillable=\""; //222:54
                                if (!string.IsNullOrEmpty(__tmp17_line))
                                {
                                    __out.Append(__tmp17_line);
                                    __tmp14_outputWritten = true;
                                }
                                StringBuilder __tmp18 = new StringBuilder();
                                __tmp18.Append(array.InnerType.IsNullableXsd());
                                using(StreamReader __tmp18Reader = new StreamReader(this.__ToStream(__tmp18.ToString())))
                                {
                                    bool __tmp18_last = __tmp18Reader.EndOfStream;
                                    while(!__tmp18_last)
                                    {
                                        string __tmp18_line = __tmp18Reader.ReadLine();
                                        __tmp18_last = __tmp18Reader.EndOfStream;
                                        if ((__tmp18_last && !string.IsNullOrEmpty(__tmp18_line)) || (!__tmp18_last && __tmp18_line != null))
                                        {
                                            __out.Append(__tmp18_line);
                                            __tmp14_outputWritten = true;
                                        }
                                        if (!__tmp18_last) __out.AppendLine(true);
                                    }
                                }
                                string __tmp19_line = "\">"; //222:99
                                if (!string.IsNullOrEmpty(__tmp19_line))
                                {
                                    __out.Append(__tmp19_line);
                                    __tmp14_outputWritten = true;
                                }
                                if (__tmp14_outputWritten) __out.AppendLine(true);
                                if (__tmp14_outputWritten)
                                {
                                    __out.AppendLine(false); //222:101
                                }
                            }
                            bool __tmp21_outputWritten = false;
                            string __tmp20Prefix = "					"; //224:1
                            StringBuilder __tmp22 = new StringBuilder();
                            __tmp22.Append(GenerateRestrictions(array.InnerType.GetNamespace(ns).Prefix + ":" + array.InnerType.GetXsdName(), restrAnnot));
                            using(StreamReader __tmp22Reader = new StreamReader(this.__ToStream(__tmp22.ToString())))
                            {
                                bool __tmp22_last = __tmp22Reader.EndOfStream;
                                while(!__tmp22_last)
                                {
                                    string __tmp22_line = __tmp22Reader.ReadLine();
                                    __tmp22_last = __tmp22Reader.EndOfStream;
                                    if (!string.IsNullOrEmpty(__tmp20Prefix))
                                    {
                                        __out.Append(__tmp20Prefix);
                                        __tmp21_outputWritten = true;
                                    }
                                    if ((__tmp22_last && !string.IsNullOrEmpty(__tmp22_line)) || (!__tmp22_last && __tmp22_line != null))
                                    {
                                        __out.Append(__tmp22_line);
                                        __tmp21_outputWritten = true;
                                    }
                                    if (!__tmp22_last || __tmp21_outputWritten) __out.AppendLine(true);
                                }
                            }
                            if (__tmp21_outputWritten)
                            {
                                __out.AppendLine(false); //224:114
                            }
                        }
                        else //225:5
                        {
                            if (items != null) //226:6
                            {
                                bool __tmp24_outputWritten = false;
                                string __tmp25_line = "					<xs:element name=\""; //227:1
                                if (!string.IsNullOrEmpty(__tmp25_line))
                                {
                                    __out.Append(__tmp25_line);
                                    __tmp24_outputWritten = true;
                                }
                                StringBuilder __tmp26 = new StringBuilder();
                                __tmp26.Append(items);
                                using(StreamReader __tmp26Reader = new StreamReader(this.__ToStream(__tmp26.ToString())))
                                {
                                    bool __tmp26_last = __tmp26Reader.EndOfStream;
                                    while(!__tmp26_last)
                                    {
                                        string __tmp26_line = __tmp26Reader.ReadLine();
                                        __tmp26_last = __tmp26Reader.EndOfStream;
                                        if ((__tmp26_last && !string.IsNullOrEmpty(__tmp26_line)) || (!__tmp26_last && __tmp26_line != null))
                                        {
                                            __out.Append(__tmp26_line);
                                            __tmp24_outputWritten = true;
                                        }
                                        if (!__tmp26_last) __out.AppendLine(true);
                                    }
                                }
                                string __tmp27_line = "\" type=\""; //227:31
                                if (!string.IsNullOrEmpty(__tmp27_line))
                                {
                                    __out.Append(__tmp27_line);
                                    __tmp24_outputWritten = true;
                                }
                                StringBuilder __tmp28 = new StringBuilder();
                                __tmp28.Append(array.InnerType.GetNamespace(ns).Prefix);
                                using(StreamReader __tmp28Reader = new StreamReader(this.__ToStream(__tmp28.ToString())))
                                {
                                    bool __tmp28_last = __tmp28Reader.EndOfStream;
                                    while(!__tmp28_last)
                                    {
                                        string __tmp28_line = __tmp28Reader.ReadLine();
                                        __tmp28_last = __tmp28Reader.EndOfStream;
                                        if ((__tmp28_last && !string.IsNullOrEmpty(__tmp28_line)) || (!__tmp28_last && __tmp28_line != null))
                                        {
                                            __out.Append(__tmp28_line);
                                            __tmp24_outputWritten = true;
                                        }
                                        if (!__tmp28_last) __out.AppendLine(true);
                                    }
                                }
                                string __tmp29_line = ":"; //227:80
                                if (!string.IsNullOrEmpty(__tmp29_line))
                                {
                                    __out.Append(__tmp29_line);
                                    __tmp24_outputWritten = true;
                                }
                                StringBuilder __tmp30 = new StringBuilder();
                                __tmp30.Append(array.InnerType.GetXsdName());
                                using(StreamReader __tmp30Reader = new StreamReader(this.__ToStream(__tmp30.ToString())))
                                {
                                    bool __tmp30_last = __tmp30Reader.EndOfStream;
                                    while(!__tmp30_last)
                                    {
                                        string __tmp30_line = __tmp30Reader.ReadLine();
                                        __tmp30_last = __tmp30Reader.EndOfStream;
                                        if ((__tmp30_last && !string.IsNullOrEmpty(__tmp30_line)) || (!__tmp30_last && __tmp30_line != null))
                                        {
                                            __out.Append(__tmp30_line);
                                            __tmp24_outputWritten = true;
                                        }
                                        if (!__tmp30_last) __out.AppendLine(true);
                                    }
                                }
                                string __tmp31_line = "\" nillable=\""; //227:111
                                if (!string.IsNullOrEmpty(__tmp31_line))
                                {
                                    __out.Append(__tmp31_line);
                                    __tmp24_outputWritten = true;
                                }
                                StringBuilder __tmp32 = new StringBuilder();
                                __tmp32.Append(array.InnerType.IsNullableXsd());
                                using(StreamReader __tmp32Reader = new StreamReader(this.__ToStream(__tmp32.ToString())))
                                {
                                    bool __tmp32_last = __tmp32Reader.EndOfStream;
                                    while(!__tmp32_last)
                                    {
                                        string __tmp32_line = __tmp32Reader.ReadLine();
                                        __tmp32_last = __tmp32Reader.EndOfStream;
                                        if ((__tmp32_last && !string.IsNullOrEmpty(__tmp32_line)) || (!__tmp32_last && __tmp32_line != null))
                                        {
                                            __out.Append(__tmp32_line);
                                            __tmp24_outputWritten = true;
                                        }
                                        if (!__tmp32_last) __out.AppendLine(true);
                                    }
                                }
                                string __tmp33_line = "\"/>"; //227:156
                                if (!string.IsNullOrEmpty(__tmp33_line))
                                {
                                    __out.Append(__tmp33_line);
                                    __tmp24_outputWritten = true;
                                }
                                if (__tmp24_outputWritten) __out.AppendLine(true);
                                if (__tmp24_outputWritten)
                                {
                                    __out.AppendLine(false); //227:159
                                }
                            }
                            else //228:6
                            {
                                bool __tmp35_outputWritten = false;
                                string __tmp36_line = "					<xs:element name=\""; //229:1
                                if (!string.IsNullOrEmpty(__tmp36_line))
                                {
                                    __out.Append(__tmp36_line);
                                    __tmp35_outputWritten = true;
                                }
                                StringBuilder __tmp37 = new StringBuilder();
                                __tmp37.Append(array.InnerType.GetXsdName());
                                using(StreamReader __tmp37Reader = new StreamReader(this.__ToStream(__tmp37.ToString())))
                                {
                                    bool __tmp37_last = __tmp37Reader.EndOfStream;
                                    while(!__tmp37_last)
                                    {
                                        string __tmp37_line = __tmp37Reader.ReadLine();
                                        __tmp37_last = __tmp37Reader.EndOfStream;
                                        if ((__tmp37_last && !string.IsNullOrEmpty(__tmp37_line)) || (!__tmp37_last && __tmp37_line != null))
                                        {
                                            __out.Append(__tmp37_line);
                                            __tmp35_outputWritten = true;
                                        }
                                        if (!__tmp37_last) __out.AppendLine(true);
                                    }
                                }
                                string __tmp38_line = "\" type=\""; //229:54
                                if (!string.IsNullOrEmpty(__tmp38_line))
                                {
                                    __out.Append(__tmp38_line);
                                    __tmp35_outputWritten = true;
                                }
                                StringBuilder __tmp39 = new StringBuilder();
                                __tmp39.Append(array.InnerType.GetNamespace(ns).Prefix);
                                using(StreamReader __tmp39Reader = new StreamReader(this.__ToStream(__tmp39.ToString())))
                                {
                                    bool __tmp39_last = __tmp39Reader.EndOfStream;
                                    while(!__tmp39_last)
                                    {
                                        string __tmp39_line = __tmp39Reader.ReadLine();
                                        __tmp39_last = __tmp39Reader.EndOfStream;
                                        if ((__tmp39_last && !string.IsNullOrEmpty(__tmp39_line)) || (!__tmp39_last && __tmp39_line != null))
                                        {
                                            __out.Append(__tmp39_line);
                                            __tmp35_outputWritten = true;
                                        }
                                        if (!__tmp39_last) __out.AppendLine(true);
                                    }
                                }
                                string __tmp40_line = ":"; //229:103
                                if (!string.IsNullOrEmpty(__tmp40_line))
                                {
                                    __out.Append(__tmp40_line);
                                    __tmp35_outputWritten = true;
                                }
                                StringBuilder __tmp41 = new StringBuilder();
                                __tmp41.Append(array.InnerType.GetXsdName());
                                using(StreamReader __tmp41Reader = new StreamReader(this.__ToStream(__tmp41.ToString())))
                                {
                                    bool __tmp41_last = __tmp41Reader.EndOfStream;
                                    while(!__tmp41_last)
                                    {
                                        string __tmp41_line = __tmp41Reader.ReadLine();
                                        __tmp41_last = __tmp41Reader.EndOfStream;
                                        if ((__tmp41_last && !string.IsNullOrEmpty(__tmp41_line)) || (!__tmp41_last && __tmp41_line != null))
                                        {
                                            __out.Append(__tmp41_line);
                                            __tmp35_outputWritten = true;
                                        }
                                        if (!__tmp41_last) __out.AppendLine(true);
                                    }
                                }
                                string __tmp42_line = "\" nillable=\""; //229:134
                                if (!string.IsNullOrEmpty(__tmp42_line))
                                {
                                    __out.Append(__tmp42_line);
                                    __tmp35_outputWritten = true;
                                }
                                StringBuilder __tmp43 = new StringBuilder();
                                __tmp43.Append(array.InnerType.IsNullableXsd());
                                using(StreamReader __tmp43Reader = new StreamReader(this.__ToStream(__tmp43.ToString())))
                                {
                                    bool __tmp43_last = __tmp43Reader.EndOfStream;
                                    while(!__tmp43_last)
                                    {
                                        string __tmp43_line = __tmp43Reader.ReadLine();
                                        __tmp43_last = __tmp43Reader.EndOfStream;
                                        if ((__tmp43_last && !string.IsNullOrEmpty(__tmp43_line)) || (!__tmp43_last && __tmp43_line != null))
                                        {
                                            __out.Append(__tmp43_line);
                                            __tmp35_outputWritten = true;
                                        }
                                        if (!__tmp43_last) __out.AppendLine(true);
                                    }
                                }
                                string __tmp44_line = "\"/>"; //229:179
                                if (!string.IsNullOrEmpty(__tmp44_line))
                                {
                                    __out.Append(__tmp44_line);
                                    __tmp35_outputWritten = true;
                                }
                                if (__tmp35_outputWritten) __out.AppendLine(true);
                                if (__tmp35_outputWritten)
                                {
                                    __out.AppendLine(false); //229:182
                                }
                            }
                        }
                        __out.Append("				</xs:all>"); //232:1
                        __out.AppendLine(false); //232:14
                        __out.Append("			</xs:complexType>"); //233:1
                        __out.AppendLine(false); //233:21
                        __out.Append("		</xs:element>"); //234:1
                        __out.AppendLine(false); //234:16
                        __out.Append("	</xs:all>"); //235:1
                        __out.AppendLine(false); //235:11
                    }
                    else //236:4
                    {
                        __out.Append("	<xs:sequence>"); //237:1
                        __out.AppendLine(false); //237:15
                        if (restrAnnot != null && array.InnerType.GetCoreType() is PrimitiveType) //238:5
                        {
                            if (items != null) //239:6
                            {
                                bool __tmp46_outputWritten = false;
                                string __tmp47_line = "		<xs:element name=\""; //240:1
                                if (!string.IsNullOrEmpty(__tmp47_line))
                                {
                                    __out.Append(__tmp47_line);
                                    __tmp46_outputWritten = true;
                                }
                                StringBuilder __tmp48 = new StringBuilder();
                                __tmp48.Append(items);
                                using(StreamReader __tmp48Reader = new StreamReader(this.__ToStream(__tmp48.ToString())))
                                {
                                    bool __tmp48_last = __tmp48Reader.EndOfStream;
                                    while(!__tmp48_last)
                                    {
                                        string __tmp48_line = __tmp48Reader.ReadLine();
                                        __tmp48_last = __tmp48Reader.EndOfStream;
                                        if ((__tmp48_last && !string.IsNullOrEmpty(__tmp48_line)) || (!__tmp48_last && __tmp48_line != null))
                                        {
                                            __out.Append(__tmp48_line);
                                            __tmp46_outputWritten = true;
                                        }
                                        if (!__tmp48_last) __out.AppendLine(true);
                                    }
                                }
                                string __tmp49_line = "\" nillable=\""; //240:28
                                if (!string.IsNullOrEmpty(__tmp49_line))
                                {
                                    __out.Append(__tmp49_line);
                                    __tmp46_outputWritten = true;
                                }
                                StringBuilder __tmp50 = new StringBuilder();
                                __tmp50.Append(array.InnerType.IsNullableXsd());
                                using(StreamReader __tmp50Reader = new StreamReader(this.__ToStream(__tmp50.ToString())))
                                {
                                    bool __tmp50_last = __tmp50Reader.EndOfStream;
                                    while(!__tmp50_last)
                                    {
                                        string __tmp50_line = __tmp50Reader.ReadLine();
                                        __tmp50_last = __tmp50Reader.EndOfStream;
                                        if ((__tmp50_last && !string.IsNullOrEmpty(__tmp50_line)) || (!__tmp50_last && __tmp50_line != null))
                                        {
                                            __out.Append(__tmp50_line);
                                            __tmp46_outputWritten = true;
                                        }
                                        if (!__tmp50_last) __out.AppendLine(true);
                                    }
                                }
                                string __tmp51_line = "\" minOccurs=\"0\" maxOccurs=\"unbounded\">"; //240:73
                                if (!string.IsNullOrEmpty(__tmp51_line))
                                {
                                    __out.Append(__tmp51_line);
                                    __tmp46_outputWritten = true;
                                }
                                if (__tmp46_outputWritten) __out.AppendLine(true);
                                if (__tmp46_outputWritten)
                                {
                                    __out.AppendLine(false); //240:111
                                }
                            }
                            else //241:6
                            {
                                bool __tmp53_outputWritten = false;
                                string __tmp54_line = "		<xs:element name=\""; //242:1
                                if (!string.IsNullOrEmpty(__tmp54_line))
                                {
                                    __out.Append(__tmp54_line);
                                    __tmp53_outputWritten = true;
                                }
                                StringBuilder __tmp55 = new StringBuilder();
                                __tmp55.Append(array.InnerType.GetXsdName());
                                using(StreamReader __tmp55Reader = new StreamReader(this.__ToStream(__tmp55.ToString())))
                                {
                                    bool __tmp55_last = __tmp55Reader.EndOfStream;
                                    while(!__tmp55_last)
                                    {
                                        string __tmp55_line = __tmp55Reader.ReadLine();
                                        __tmp55_last = __tmp55Reader.EndOfStream;
                                        if ((__tmp55_last && !string.IsNullOrEmpty(__tmp55_line)) || (!__tmp55_last && __tmp55_line != null))
                                        {
                                            __out.Append(__tmp55_line);
                                            __tmp53_outputWritten = true;
                                        }
                                        if (!__tmp55_last) __out.AppendLine(true);
                                    }
                                }
                                string __tmp56_line = "\" nillable=\""; //242:51
                                if (!string.IsNullOrEmpty(__tmp56_line))
                                {
                                    __out.Append(__tmp56_line);
                                    __tmp53_outputWritten = true;
                                }
                                StringBuilder __tmp57 = new StringBuilder();
                                __tmp57.Append(array.InnerType.IsNullableXsd());
                                using(StreamReader __tmp57Reader = new StreamReader(this.__ToStream(__tmp57.ToString())))
                                {
                                    bool __tmp57_last = __tmp57Reader.EndOfStream;
                                    while(!__tmp57_last)
                                    {
                                        string __tmp57_line = __tmp57Reader.ReadLine();
                                        __tmp57_last = __tmp57Reader.EndOfStream;
                                        if ((__tmp57_last && !string.IsNullOrEmpty(__tmp57_line)) || (!__tmp57_last && __tmp57_line != null))
                                        {
                                            __out.Append(__tmp57_line);
                                            __tmp53_outputWritten = true;
                                        }
                                        if (!__tmp57_last) __out.AppendLine(true);
                                    }
                                }
                                string __tmp58_line = "\" minOccurs=\"0\" maxOccurs=\"unbounded\">"; //242:96
                                if (!string.IsNullOrEmpty(__tmp58_line))
                                {
                                    __out.Append(__tmp58_line);
                                    __tmp53_outputWritten = true;
                                }
                                if (__tmp53_outputWritten) __out.AppendLine(true);
                                if (__tmp53_outputWritten)
                                {
                                    __out.AppendLine(false); //242:134
                                }
                            }
                            bool __tmp60_outputWritten = false;
                            string __tmp59Prefix = "		"; //244:1
                            StringBuilder __tmp61 = new StringBuilder();
                            __tmp61.Append(GenerateRestrictions(array.InnerType.GetNamespace(ns).Prefix + ":" + array.InnerType.GetXsdName(), restrAnnot));
                            using(StreamReader __tmp61Reader = new StreamReader(this.__ToStream(__tmp61.ToString())))
                            {
                                bool __tmp61_last = __tmp61Reader.EndOfStream;
                                while(!__tmp61_last)
                                {
                                    string __tmp61_line = __tmp61Reader.ReadLine();
                                    __tmp61_last = __tmp61Reader.EndOfStream;
                                    if (!string.IsNullOrEmpty(__tmp59Prefix))
                                    {
                                        __out.Append(__tmp59Prefix);
                                        __tmp60_outputWritten = true;
                                    }
                                    if ((__tmp61_last && !string.IsNullOrEmpty(__tmp61_line)) || (!__tmp61_last && __tmp61_line != null))
                                    {
                                        __out.Append(__tmp61_line);
                                        __tmp60_outputWritten = true;
                                    }
                                    if (!__tmp61_last || __tmp60_outputWritten) __out.AppendLine(true);
                                }
                            }
                            if (__tmp60_outputWritten)
                            {
                                __out.AppendLine(false); //244:111
                            }
                        }
                        else //245:5
                        {
                            if (items != null) //246:6
                            {
                                bool __tmp63_outputWritten = false;
                                string __tmp64_line = "		<xs:element name=\""; //247:1
                                if (!string.IsNullOrEmpty(__tmp64_line))
                                {
                                    __out.Append(__tmp64_line);
                                    __tmp63_outputWritten = true;
                                }
                                StringBuilder __tmp65 = new StringBuilder();
                                __tmp65.Append(items);
                                using(StreamReader __tmp65Reader = new StreamReader(this.__ToStream(__tmp65.ToString())))
                                {
                                    bool __tmp65_last = __tmp65Reader.EndOfStream;
                                    while(!__tmp65_last)
                                    {
                                        string __tmp65_line = __tmp65Reader.ReadLine();
                                        __tmp65_last = __tmp65Reader.EndOfStream;
                                        if ((__tmp65_last && !string.IsNullOrEmpty(__tmp65_line)) || (!__tmp65_last && __tmp65_line != null))
                                        {
                                            __out.Append(__tmp65_line);
                                            __tmp63_outputWritten = true;
                                        }
                                        if (!__tmp65_last) __out.AppendLine(true);
                                    }
                                }
                                string __tmp66_line = "\" type=\""; //247:28
                                if (!string.IsNullOrEmpty(__tmp66_line))
                                {
                                    __out.Append(__tmp66_line);
                                    __tmp63_outputWritten = true;
                                }
                                StringBuilder __tmp67 = new StringBuilder();
                                __tmp67.Append(array.InnerType.GetNamespace(ns).Prefix);
                                using(StreamReader __tmp67Reader = new StreamReader(this.__ToStream(__tmp67.ToString())))
                                {
                                    bool __tmp67_last = __tmp67Reader.EndOfStream;
                                    while(!__tmp67_last)
                                    {
                                        string __tmp67_line = __tmp67Reader.ReadLine();
                                        __tmp67_last = __tmp67Reader.EndOfStream;
                                        if ((__tmp67_last && !string.IsNullOrEmpty(__tmp67_line)) || (!__tmp67_last && __tmp67_line != null))
                                        {
                                            __out.Append(__tmp67_line);
                                            __tmp63_outputWritten = true;
                                        }
                                        if (!__tmp67_last) __out.AppendLine(true);
                                    }
                                }
                                string __tmp68_line = ":"; //247:77
                                if (!string.IsNullOrEmpty(__tmp68_line))
                                {
                                    __out.Append(__tmp68_line);
                                    __tmp63_outputWritten = true;
                                }
                                StringBuilder __tmp69 = new StringBuilder();
                                __tmp69.Append(array.InnerType.GetXsdName());
                                using(StreamReader __tmp69Reader = new StreamReader(this.__ToStream(__tmp69.ToString())))
                                {
                                    bool __tmp69_last = __tmp69Reader.EndOfStream;
                                    while(!__tmp69_last)
                                    {
                                        string __tmp69_line = __tmp69Reader.ReadLine();
                                        __tmp69_last = __tmp69Reader.EndOfStream;
                                        if ((__tmp69_last && !string.IsNullOrEmpty(__tmp69_line)) || (!__tmp69_last && __tmp69_line != null))
                                        {
                                            __out.Append(__tmp69_line);
                                            __tmp63_outputWritten = true;
                                        }
                                        if (!__tmp69_last) __out.AppendLine(true);
                                    }
                                }
                                string __tmp70_line = "\" nillable=\""; //247:108
                                if (!string.IsNullOrEmpty(__tmp70_line))
                                {
                                    __out.Append(__tmp70_line);
                                    __tmp63_outputWritten = true;
                                }
                                StringBuilder __tmp71 = new StringBuilder();
                                __tmp71.Append(array.InnerType.IsNullableXsd());
                                using(StreamReader __tmp71Reader = new StreamReader(this.__ToStream(__tmp71.ToString())))
                                {
                                    bool __tmp71_last = __tmp71Reader.EndOfStream;
                                    while(!__tmp71_last)
                                    {
                                        string __tmp71_line = __tmp71Reader.ReadLine();
                                        __tmp71_last = __tmp71Reader.EndOfStream;
                                        if ((__tmp71_last && !string.IsNullOrEmpty(__tmp71_line)) || (!__tmp71_last && __tmp71_line != null))
                                        {
                                            __out.Append(__tmp71_line);
                                            __tmp63_outputWritten = true;
                                        }
                                        if (!__tmp71_last) __out.AppendLine(true);
                                    }
                                }
                                string __tmp72_line = "\" minOccurs=\"0\" maxOccurs=\"unbounded\"/>"; //247:153
                                if (!string.IsNullOrEmpty(__tmp72_line))
                                {
                                    __out.Append(__tmp72_line);
                                    __tmp63_outputWritten = true;
                                }
                                if (__tmp63_outputWritten) __out.AppendLine(true);
                                if (__tmp63_outputWritten)
                                {
                                    __out.AppendLine(false); //247:192
                                }
                            }
                            else //248:6
                            {
                                bool __tmp74_outputWritten = false;
                                string __tmp75_line = "		<xs:element name=\""; //249:1
                                if (!string.IsNullOrEmpty(__tmp75_line))
                                {
                                    __out.Append(__tmp75_line);
                                    __tmp74_outputWritten = true;
                                }
                                StringBuilder __tmp76 = new StringBuilder();
                                __tmp76.Append(array.InnerType.GetXsdName());
                                using(StreamReader __tmp76Reader = new StreamReader(this.__ToStream(__tmp76.ToString())))
                                {
                                    bool __tmp76_last = __tmp76Reader.EndOfStream;
                                    while(!__tmp76_last)
                                    {
                                        string __tmp76_line = __tmp76Reader.ReadLine();
                                        __tmp76_last = __tmp76Reader.EndOfStream;
                                        if ((__tmp76_last && !string.IsNullOrEmpty(__tmp76_line)) || (!__tmp76_last && __tmp76_line != null))
                                        {
                                            __out.Append(__tmp76_line);
                                            __tmp74_outputWritten = true;
                                        }
                                        if (!__tmp76_last) __out.AppendLine(true);
                                    }
                                }
                                string __tmp77_line = "\" type=\""; //249:51
                                if (!string.IsNullOrEmpty(__tmp77_line))
                                {
                                    __out.Append(__tmp77_line);
                                    __tmp74_outputWritten = true;
                                }
                                StringBuilder __tmp78 = new StringBuilder();
                                __tmp78.Append(array.InnerType.GetNamespace(ns).Prefix);
                                using(StreamReader __tmp78Reader = new StreamReader(this.__ToStream(__tmp78.ToString())))
                                {
                                    bool __tmp78_last = __tmp78Reader.EndOfStream;
                                    while(!__tmp78_last)
                                    {
                                        string __tmp78_line = __tmp78Reader.ReadLine();
                                        __tmp78_last = __tmp78Reader.EndOfStream;
                                        if ((__tmp78_last && !string.IsNullOrEmpty(__tmp78_line)) || (!__tmp78_last && __tmp78_line != null))
                                        {
                                            __out.Append(__tmp78_line);
                                            __tmp74_outputWritten = true;
                                        }
                                        if (!__tmp78_last) __out.AppendLine(true);
                                    }
                                }
                                string __tmp79_line = ":"; //249:100
                                if (!string.IsNullOrEmpty(__tmp79_line))
                                {
                                    __out.Append(__tmp79_line);
                                    __tmp74_outputWritten = true;
                                }
                                StringBuilder __tmp80 = new StringBuilder();
                                __tmp80.Append(array.InnerType.GetXsdName());
                                using(StreamReader __tmp80Reader = new StreamReader(this.__ToStream(__tmp80.ToString())))
                                {
                                    bool __tmp80_last = __tmp80Reader.EndOfStream;
                                    while(!__tmp80_last)
                                    {
                                        string __tmp80_line = __tmp80Reader.ReadLine();
                                        __tmp80_last = __tmp80Reader.EndOfStream;
                                        if ((__tmp80_last && !string.IsNullOrEmpty(__tmp80_line)) || (!__tmp80_last && __tmp80_line != null))
                                        {
                                            __out.Append(__tmp80_line);
                                            __tmp74_outputWritten = true;
                                        }
                                        if (!__tmp80_last) __out.AppendLine(true);
                                    }
                                }
                                string __tmp81_line = "\" nillable=\""; //249:131
                                if (!string.IsNullOrEmpty(__tmp81_line))
                                {
                                    __out.Append(__tmp81_line);
                                    __tmp74_outputWritten = true;
                                }
                                StringBuilder __tmp82 = new StringBuilder();
                                __tmp82.Append(array.InnerType.IsNullableXsd());
                                using(StreamReader __tmp82Reader = new StreamReader(this.__ToStream(__tmp82.ToString())))
                                {
                                    bool __tmp82_last = __tmp82Reader.EndOfStream;
                                    while(!__tmp82_last)
                                    {
                                        string __tmp82_line = __tmp82Reader.ReadLine();
                                        __tmp82_last = __tmp82Reader.EndOfStream;
                                        if ((__tmp82_last && !string.IsNullOrEmpty(__tmp82_line)) || (!__tmp82_last && __tmp82_line != null))
                                        {
                                            __out.Append(__tmp82_line);
                                            __tmp74_outputWritten = true;
                                        }
                                        if (!__tmp82_last) __out.AppendLine(true);
                                    }
                                }
                                string __tmp83_line = "\" minOccurs=\"0\" maxOccurs=\"unbounded\"/>"; //249:176
                                if (!string.IsNullOrEmpty(__tmp83_line))
                                {
                                    __out.Append(__tmp83_line);
                                    __tmp74_outputWritten = true;
                                }
                                if (__tmp74_outputWritten) __out.AppendLine(true);
                                if (__tmp74_outputWritten)
                                {
                                    __out.AppendLine(false); //249:215
                                }
                            }
                        }
                        __out.Append("	</xs:sequence>"); //252:1
                        __out.AppendLine(false); //252:16
                    }
                    __out.Append("</xs:complexType>"); //254:1
                    __out.AppendLine(false); //254:18
                }
            }
            return __out.ToString();
        }

        public string GenerateRestrictions(string baseType, Annotation ae) //259:1
        {
            StringBuilder __out = new StringBuilder();
            __out.Append("	<xs:simpleType>"); //260:1
            __out.AppendLine(false); //260:17
            bool __tmp2_outputWritten = false;
            string __tmp3_line = "		<xs:restriction base=\""; //261:1
            if (!string.IsNullOrEmpty(__tmp3_line))
            {
                __out.Append(__tmp3_line);
                __tmp2_outputWritten = true;
            }
            StringBuilder __tmp4 = new StringBuilder();
            __tmp4.Append(baseType);
            using(StreamReader __tmp4Reader = new StreamReader(this.__ToStream(__tmp4.ToString())))
            {
                bool __tmp4_last = __tmp4Reader.EndOfStream;
                while(!__tmp4_last)
                {
                    string __tmp4_line = __tmp4Reader.ReadLine();
                    __tmp4_last = __tmp4Reader.EndOfStream;
                    if ((__tmp4_last && !string.IsNullOrEmpty(__tmp4_line)) || (!__tmp4_last && __tmp4_line != null))
                    {
                        __out.Append(__tmp4_line);
                        __tmp2_outputWritten = true;
                    }
                    if (!__tmp4_last) __out.AppendLine(true);
                }
            }
            string __tmp5_line = "\">"; //261:35
            if (!string.IsNullOrEmpty(__tmp5_line))
            {
                __out.Append(__tmp5_line);
                __tmp2_outputWritten = true;
            }
            if (__tmp2_outputWritten) __out.AppendLine(true);
            if (__tmp2_outputWritten)
            {
                __out.AppendLine(false); //261:37
            }
            var __loop13_results = 
                (from __loop13_var1 in __Enumerate((ae).GetEnumerator()) //262:10
                from prop in __Enumerate((__loop13_var1.Properties).GetEnumerator()) //262:14
                select new { __loop13_var1 = __loop13_var1, prop = prop}
                ).ToList(); //262:5
            for (int __loop13_iteration = 0; __loop13_iteration < __loop13_results.Count; ++__loop13_iteration)
            {
                var __tmp6 = __loop13_results[__loop13_iteration];
                var __loop13_var1 = __tmp6.__loop13_var1;
                var prop = __tmp6.prop;
                bool __tmp8_outputWritten = false;
                string __tmp9_line = "			<xs:"; //263:1
                if (!string.IsNullOrEmpty(__tmp9_line))
                {
                    __out.Append(__tmp9_line);
                    __tmp8_outputWritten = true;
                }
                StringBuilder __tmp10 = new StringBuilder();
                __tmp10.Append(prop.Name);
                using(StreamReader __tmp10Reader = new StreamReader(this.__ToStream(__tmp10.ToString())))
                {
                    bool __tmp10_last = __tmp10Reader.EndOfStream;
                    while(!__tmp10_last)
                    {
                        string __tmp10_line = __tmp10Reader.ReadLine();
                        __tmp10_last = __tmp10Reader.EndOfStream;
                        if ((__tmp10_last && !string.IsNullOrEmpty(__tmp10_line)) || (!__tmp10_last && __tmp10_line != null))
                        {
                            __out.Append(__tmp10_line);
                            __tmp8_outputWritten = true;
                        }
                        if (!__tmp10_last) __out.AppendLine(true);
                    }
                }
                string __tmp11_line = " value=\""; //263:19
                if (!string.IsNullOrEmpty(__tmp11_line))
                {
                    __out.Append(__tmp11_line);
                    __tmp8_outputWritten = true;
                }
                StringBuilder __tmp12 = new StringBuilder();
                __tmp12.Append(prop.Value);
                using(StreamReader __tmp12Reader = new StreamReader(this.__ToStream(__tmp12.ToString())))
                {
                    bool __tmp12_last = __tmp12Reader.EndOfStream;
                    while(!__tmp12_last)
                    {
                        string __tmp12_line = __tmp12Reader.ReadLine();
                        __tmp12_last = __tmp12Reader.EndOfStream;
                        if ((__tmp12_last && !string.IsNullOrEmpty(__tmp12_line)) || (!__tmp12_last && __tmp12_line != null))
                        {
                            __out.Append(__tmp12_line);
                            __tmp8_outputWritten = true;
                        }
                        if (!__tmp12_last) __out.AppendLine(true);
                    }
                }
                string __tmp13_line = "\"/>"; //263:39
                if (!string.IsNullOrEmpty(__tmp13_line))
                {
                    __out.Append(__tmp13_line);
                    __tmp8_outputWritten = true;
                }
                if (__tmp8_outputWritten) __out.AppendLine(true);
                if (__tmp8_outputWritten)
                {
                    __out.AppendLine(false); //263:42
                }
            }
            __out.Append("		</xs:restriction>"); //265:1
            __out.AppendLine(false); //265:20
            __out.Append("	</xs:simpleType>"); //266:1
            __out.AppendLine(false); //266:18
            __out.Append("</xs:element>"); //267:1
            __out.AppendLine(false); //267:14
            return __out.ToString();
        }

        public string GetStructKind(Struct st) //270:1
        {
            if (st.HasAnnotation(SoalAnnotations.Choice)) //271:2
            {
                return "choice"; //272:3
            }
            else if (st.HasAnnotation(SoalAnnotations.All)) //273:2
            {
                return "all"; //274:3
            }
            else //275:2
            {
                return "sequence"; //276:3
            }
        }

        public string GetElementOptional(AnnotatedElement ae) //280:1
        {
            object optional = ae.GetAnnotationPropertyValue(SoalAnnotations.Element, SoalAnnotationProperties.Optional); //281:2
            if (optional != null && (bool)optional) //282:2
            {
                return " minOccurs=\"0\""; //283:3
            }
            else //284:2
            {
                return ""; //285:3
            }
        }

        public string GetAttributeRequired(AnnotatedElement ae) //289:1
        {
            object required = ae.GetAnnotationPropertyValue(SoalAnnotations.Attribute, SoalAnnotationProperties.Required); //290:2
            if (required != null && (bool)required) //291:2
            {
                return " use=\"required\""; //292:3
            }
            else //293:2
            {
                return ""; //294:3
            }
        }

        private class StringBuilder
        {
            private bool newLine;
            private System.Text.StringBuilder builder = new System.Text.StringBuilder();
            
            public StringBuilder()
            {
                this.newLine = true;
            }
            
            public void Append(string str)
            {
                if (str == null) return;
                if (!string.IsNullOrEmpty(str))
                {
                    this.newLine = false;
                }
                builder.Append(str);
            }
            
            public void Append(object obj)
            {
                if (obj == null) return;
                string text = obj.ToString();
                this.Append(text);
            }
            
            public void AppendLine(bool force = false)
            {
                if (force || !this.newLine)
                {
                    builder.AppendLine();
                    this.newLine = true;
                }
            }
            
            public override string ToString()
            {
                return builder.ToString();
            }
        }
    }
}
