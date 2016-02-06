using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Soal //1:1
{
    using __Hidden_XsdGenerator_99968071;
    namespace __Hidden_XsdGenerator_99968071
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
            __out.AppendLine(false); //9:39
            string __tmp1Prefix = string.Empty;
            string __tmp2Line = "<xs:schema targetNamespace=\""; //10:1
            __out.Append(__tmp1Prefix);
            if (__tmp2Line != null) __out.Append(__tmp2Line);
            StringBuilder __tmp3 = new StringBuilder();
            __tmp3.Append(ns.Uri);
            using(StreamReader __tmp3Reader = new StreamReader(this.__ToStream(__tmp3.ToString())))
            {
                bool __tmp3_first = true;
                bool __tmp3_last = __tmp3Reader.EndOfStream;
                while(__tmp3_first || !__tmp3_last)
                {
                    __tmp3_first = false;
                    string __tmp3Line = __tmp3Reader.ReadLine();
                    __tmp3_last = __tmp3Reader.EndOfStream;
                    if (__tmp3Line != null) __out.Append(__tmp3Line);
                    if (!__tmp3_last) __out.AppendLine(true);
                }
            }
            string __tmp4Line = "\""; //10:37
            if (__tmp4Line != null) __out.Append(__tmp4Line);
            __out.AppendLine(false); //10:38
            __out.Append("		xmlns:xs=\"http://www.w3.org/2001/XMLSchema\""); //11:1
            __out.AppendLine(false); //11:46
            string __tmp5Prefix = string.Empty;
            string __tmp6Line = "		xmlns:"; //12:1
            __out.Append(__tmp5Prefix);
            if (__tmp6Line != null) __out.Append(__tmp6Line);
            StringBuilder __tmp7 = new StringBuilder();
            __tmp7.Append(ns.Prefix);
            using(StreamReader __tmp7Reader = new StreamReader(this.__ToStream(__tmp7.ToString())))
            {
                bool __tmp7_first = true;
                bool __tmp7_last = __tmp7Reader.EndOfStream;
                while(__tmp7_first || !__tmp7_last)
                {
                    __tmp7_first = false;
                    string __tmp7Line = __tmp7Reader.ReadLine();
                    __tmp7_last = __tmp7Reader.EndOfStream;
                    if (__tmp7Line != null) __out.Append(__tmp7Line);
                    if (!__tmp7_last) __out.AppendLine(true);
                }
            }
            string __tmp8Line = "=\""; //12:20
            if (__tmp8Line != null) __out.Append(__tmp8Line);
            StringBuilder __tmp9 = new StringBuilder();
            __tmp9.Append(ns.Uri);
            using(StreamReader __tmp9Reader = new StreamReader(this.__ToStream(__tmp9.ToString())))
            {
                bool __tmp9_first = true;
                bool __tmp9_last = __tmp9Reader.EndOfStream;
                while(__tmp9_first || !__tmp9_last)
                {
                    __tmp9_first = false;
                    string __tmp9Line = __tmp9Reader.ReadLine();
                    __tmp9_last = __tmp9Reader.EndOfStream;
                    if (__tmp9Line != null) __out.Append(__tmp9Line);
                    if (!__tmp9_last) __out.AppendLine(true);
                }
            }
            string __tmp10Line = "\""; //12:30
            if (__tmp10Line != null) __out.Append(__tmp10Line);
            __out.AppendLine(false); //12:31
            if (Properties.ImportXsd) //13:3
            {
                var __loop1_results = 
                    (from ins in __Enumerate((ns.GetImportedNamespaces()).GetEnumerator()) //14:9
                    select new { ins = ins}
                    ).ToList(); //14:4
                int __loop1_iteration = 0;
                foreach (var __tmp11 in __loop1_results)
                {
                    ++__loop1_iteration;
                    var ins = __tmp11.ins;
                    string __tmp12Prefix = string.Empty;
                    string __tmp13Line = "		xmlns:"; //15:1
                    __out.Append(__tmp12Prefix);
                    if (__tmp13Line != null) __out.Append(__tmp13Line);
                    StringBuilder __tmp14 = new StringBuilder();
                    __tmp14.Append(ins.Prefix);
                    using(StreamReader __tmp14Reader = new StreamReader(this.__ToStream(__tmp14.ToString())))
                    {
                        bool __tmp14_first = true;
                        bool __tmp14_last = __tmp14Reader.EndOfStream;
                        while(__tmp14_first || !__tmp14_last)
                        {
                            __tmp14_first = false;
                            string __tmp14Line = __tmp14Reader.ReadLine();
                            __tmp14_last = __tmp14Reader.EndOfStream;
                            if (__tmp14Line != null) __out.Append(__tmp14Line);
                            if (!__tmp14_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp15Line = "=\""; //15:21
                    if (__tmp15Line != null) __out.Append(__tmp15Line);
                    StringBuilder __tmp16 = new StringBuilder();
                    __tmp16.Append(ins.Uri);
                    using(StreamReader __tmp16Reader = new StreamReader(this.__ToStream(__tmp16.ToString())))
                    {
                        bool __tmp16_first = true;
                        bool __tmp16_last = __tmp16Reader.EndOfStream;
                        while(__tmp16_first || !__tmp16_last)
                        {
                            __tmp16_first = false;
                            string __tmp16Line = __tmp16Reader.ReadLine();
                            __tmp16_last = __tmp16Reader.EndOfStream;
                            if (__tmp16Line != null) __out.Append(__tmp16Line);
                            if (!__tmp16_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp17Line = "\""; //15:32
                    if (__tmp17Line != null) __out.Append(__tmp17Line);
                    __out.AppendLine(false); //15:33
                }
            }
            __out.Append("		elementFormDefault=\"qualified\">"); //18:1
            __out.AppendLine(false); //18:34
            if (Properties.ImportXsd) //19:3
            {
                var __loop2_results = 
                    (from ins in __Enumerate((ns.GetImportedNamespaces()).GetEnumerator()) //20:9
                    select new { ins = ins}
                    ).ToList(); //20:4
                int __loop2_iteration = 0;
                foreach (var __tmp18 in __loop2_results)
                {
                    ++__loop2_iteration;
                    var ins = __tmp18.ins;
                    string __tmp19Prefix = string.Empty;
                    string __tmp20Line = "	<xs:import namespace=\""; //21:1
                    __out.Append(__tmp19Prefix);
                    if (__tmp20Line != null) __out.Append(__tmp20Line);
                    StringBuilder __tmp21 = new StringBuilder();
                    __tmp21.Append(ins.Uri);
                    using(StreamReader __tmp21Reader = new StreamReader(this.__ToStream(__tmp21.ToString())))
                    {
                        bool __tmp21_first = true;
                        bool __tmp21_last = __tmp21Reader.EndOfStream;
                        while(__tmp21_first || !__tmp21_last)
                        {
                            __tmp21_first = false;
                            string __tmp21Line = __tmp21Reader.ReadLine();
                            __tmp21_last = __tmp21Reader.EndOfStream;
                            if (__tmp21Line != null) __out.Append(__tmp21Line);
                            if (!__tmp21_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp22Line = "\" schemaLocation=\""; //21:33
                    if (__tmp22Line != null) __out.Append(__tmp22Line);
                    StringBuilder __tmp23 = new StringBuilder();
                    __tmp23.Append(ins.FullName);
                    using(StreamReader __tmp23Reader = new StreamReader(this.__ToStream(__tmp23.ToString())))
                    {
                        bool __tmp23_first = true;
                        bool __tmp23_last = __tmp23Reader.EndOfStream;
                        while(__tmp23_first || !__tmp23_last)
                        {
                            __tmp23_first = false;
                            string __tmp23Line = __tmp23Reader.ReadLine();
                            __tmp23_last = __tmp23Reader.EndOfStream;
                            if (__tmp23Line != null) __out.Append(__tmp23Line);
                            if (!__tmp23_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp24Line = ".xsd\"/>"; //21:65
                    if (__tmp24Line != null) __out.Append(__tmp24Line);
                    __out.AppendLine(false); //21:72
                }
            }
            var __loop3_results = 
                (from arr in __Enumerate((ns.GetArrayTypes()).GetEnumerator()) //24:8
                select new { arr = arr}
                ).ToList(); //24:3
            int __loop3_iteration = 0;
            foreach (var __tmp25 in __loop3_results)
            {
                ++__loop3_iteration;
                var arr = __tmp25.arr;
                __out.AppendLine(true); //25:1
                string __tmp26Prefix = string.Empty;
                string __tmp27Line = "	<xs:element name=\""; //26:1
                __out.Append(__tmp26Prefix);
                if (__tmp27Line != null) __out.Append(__tmp27Line);
                StringBuilder __tmp28 = new StringBuilder();
                __tmp28.Append(arr.GetXsdName());
                using(StreamReader __tmp28Reader = new StreamReader(this.__ToStream(__tmp28.ToString())))
                {
                    bool __tmp28_first = true;
                    bool __tmp28_last = __tmp28Reader.EndOfStream;
                    while(__tmp28_first || !__tmp28_last)
                    {
                        __tmp28_first = false;
                        string __tmp28Line = __tmp28Reader.ReadLine();
                        __tmp28_last = __tmp28Reader.EndOfStream;
                        if (__tmp28Line != null) __out.Append(__tmp28Line);
                        if (!__tmp28_last) __out.AppendLine(true);
                    }
                }
                string __tmp29Line = "\" type=\""; //26:38
                if (__tmp29Line != null) __out.Append(__tmp29Line);
                StringBuilder __tmp30 = new StringBuilder();
                __tmp30.Append(ns.Prefix);
                using(StreamReader __tmp30Reader = new StreamReader(this.__ToStream(__tmp30.ToString())))
                {
                    bool __tmp30_first = true;
                    bool __tmp30_last = __tmp30Reader.EndOfStream;
                    while(__tmp30_first || !__tmp30_last)
                    {
                        __tmp30_first = false;
                        string __tmp30Line = __tmp30Reader.ReadLine();
                        __tmp30_last = __tmp30Reader.EndOfStream;
                        if (__tmp30Line != null) __out.Append(__tmp30Line);
                        if (!__tmp30_last) __out.AppendLine(true);
                    }
                }
                string __tmp31Line = ":"; //26:57
                if (__tmp31Line != null) __out.Append(__tmp31Line);
                StringBuilder __tmp32 = new StringBuilder();
                __tmp32.Append(arr.GetXsdName());
                using(StreamReader __tmp32Reader = new StreamReader(this.__ToStream(__tmp32.ToString())))
                {
                    bool __tmp32_first = true;
                    bool __tmp32_last = __tmp32Reader.EndOfStream;
                    while(__tmp32_first || !__tmp32_last)
                    {
                        __tmp32_first = false;
                        string __tmp32Line = __tmp32Reader.ReadLine();
                        __tmp32_last = __tmp32Reader.EndOfStream;
                        if (__tmp32Line != null) __out.Append(__tmp32Line);
                        if (!__tmp32_last) __out.AppendLine(true);
                    }
                }
                string __tmp33Line = "\"/>"; //26:76
                if (__tmp33Line != null) __out.Append(__tmp33Line);
                __out.AppendLine(false); //26:79
                string __tmp34Prefix = string.Empty;
                string __tmp35Line = "	<xs:complexType name=\""; //27:1
                __out.Append(__tmp34Prefix);
                if (__tmp35Line != null) __out.Append(__tmp35Line);
                StringBuilder __tmp36 = new StringBuilder();
                __tmp36.Append(arr.GetXsdName());
                using(StreamReader __tmp36Reader = new StreamReader(this.__ToStream(__tmp36.ToString())))
                {
                    bool __tmp36_first = true;
                    bool __tmp36_last = __tmp36Reader.EndOfStream;
                    while(__tmp36_first || !__tmp36_last)
                    {
                        __tmp36_first = false;
                        string __tmp36Line = __tmp36Reader.ReadLine();
                        __tmp36_last = __tmp36Reader.EndOfStream;
                        if (__tmp36Line != null) __out.Append(__tmp36Line);
                        if (!__tmp36_last) __out.AppendLine(true);
                    }
                }
                string __tmp37Line = "\">"; //27:42
                if (__tmp37Line != null) __out.Append(__tmp37Line);
                __out.AppendLine(false); //27:44
                __out.Append("		<xs:sequence>"); //28:1
                __out.AppendLine(false); //28:16
                string __tmp38Prefix = string.Empty;
                string __tmp39Line = "			<xs:element name=\""; //29:1
                __out.Append(__tmp38Prefix);
                if (__tmp39Line != null) __out.Append(__tmp39Line);
                StringBuilder __tmp40 = new StringBuilder();
                __tmp40.Append(arr.InnerType.GetXsdName());
                using(StreamReader __tmp40Reader = new StreamReader(this.__ToStream(__tmp40.ToString())))
                {
                    bool __tmp40_first = true;
                    bool __tmp40_last = __tmp40Reader.EndOfStream;
                    while(__tmp40_first || !__tmp40_last)
                    {
                        __tmp40_first = false;
                        string __tmp40Line = __tmp40Reader.ReadLine();
                        __tmp40_last = __tmp40Reader.EndOfStream;
                        if (__tmp40Line != null) __out.Append(__tmp40Line);
                        if (!__tmp40_last) __out.AppendLine(true);
                    }
                }
                string __tmp41Line = "\" type=\""; //29:50
                if (__tmp41Line != null) __out.Append(__tmp41Line);
                StringBuilder __tmp42 = new StringBuilder();
                __tmp42.Append(arr.InnerType.GetNamespace(ns).Prefix);
                using(StreamReader __tmp42Reader = new StreamReader(this.__ToStream(__tmp42.ToString())))
                {
                    bool __tmp42_first = true;
                    bool __tmp42_last = __tmp42Reader.EndOfStream;
                    while(__tmp42_first || !__tmp42_last)
                    {
                        __tmp42_first = false;
                        string __tmp42Line = __tmp42Reader.ReadLine();
                        __tmp42_last = __tmp42Reader.EndOfStream;
                        if (__tmp42Line != null) __out.Append(__tmp42Line);
                        if (!__tmp42_last) __out.AppendLine(true);
                    }
                }
                string __tmp43Line = ":"; //29:97
                if (__tmp43Line != null) __out.Append(__tmp43Line);
                StringBuilder __tmp44 = new StringBuilder();
                __tmp44.Append(arr.InnerType.GetXsdName());
                using(StreamReader __tmp44Reader = new StreamReader(this.__ToStream(__tmp44.ToString())))
                {
                    bool __tmp44_first = true;
                    bool __tmp44_last = __tmp44Reader.EndOfStream;
                    while(__tmp44_first || !__tmp44_last)
                    {
                        __tmp44_first = false;
                        string __tmp44Line = __tmp44Reader.ReadLine();
                        __tmp44_last = __tmp44Reader.EndOfStream;
                        if (__tmp44Line != null) __out.Append(__tmp44Line);
                        if (!__tmp44_last) __out.AppendLine(true);
                    }
                }
                string __tmp45Line = "\" nillable=\""; //29:126
                if (__tmp45Line != null) __out.Append(__tmp45Line);
                StringBuilder __tmp46 = new StringBuilder();
                __tmp46.Append(arr.InnerType.IsNullableXsd());
                using(StreamReader __tmp46Reader = new StreamReader(this.__ToStream(__tmp46.ToString())))
                {
                    bool __tmp46_first = true;
                    bool __tmp46_last = __tmp46Reader.EndOfStream;
                    while(__tmp46_first || !__tmp46_last)
                    {
                        __tmp46_first = false;
                        string __tmp46Line = __tmp46Reader.ReadLine();
                        __tmp46_last = __tmp46Reader.EndOfStream;
                        if (__tmp46Line != null) __out.Append(__tmp46Line);
                        if (!__tmp46_last) __out.AppendLine(true);
                    }
                }
                string __tmp47Line = "\" minOccurs=\"0\" maxOccurs=\"unbounded\"/>"; //29:169
                if (__tmp47Line != null) __out.Append(__tmp47Line);
                __out.AppendLine(false); //29:208
                __out.Append("		</xs:sequence>"); //30:1
                __out.AppendLine(false); //30:17
                __out.Append("	</xs:complexType>"); //31:1
                __out.AppendLine(false); //31:19
            }
            var __loop4_results = 
                (from __loop4_var1 in __Enumerate((ns.Declarations).GetEnumerator()) //33:8
                from etype in __Enumerate((__loop4_var1).GetEnumerator()).OfType<Enum>() //33:25
                select new { __loop4_var1 = __loop4_var1, etype = etype}
                ).ToList(); //33:3
            int __loop4_iteration = 0;
            foreach (var __tmp48 in __loop4_results)
            {
                ++__loop4_iteration;
                var __loop4_var1 = __tmp48.__loop4_var1;
                var etype = __tmp48.etype;
                __out.AppendLine(true); //34:1
                string __tmp49Prefix = string.Empty;
                string __tmp50Line = "	<xs:element name=\""; //35:1
                __out.Append(__tmp49Prefix);
                if (__tmp50Line != null) __out.Append(__tmp50Line);
                StringBuilder __tmp51 = new StringBuilder();
                __tmp51.Append(etype.GetXsdName());
                using(StreamReader __tmp51Reader = new StreamReader(this.__ToStream(__tmp51.ToString())))
                {
                    bool __tmp51_first = true;
                    bool __tmp51_last = __tmp51Reader.EndOfStream;
                    while(__tmp51_first || !__tmp51_last)
                    {
                        __tmp51_first = false;
                        string __tmp51Line = __tmp51Reader.ReadLine();
                        __tmp51_last = __tmp51Reader.EndOfStream;
                        if (__tmp51Line != null) __out.Append(__tmp51Line);
                        if (!__tmp51_last) __out.AppendLine(true);
                    }
                }
                string __tmp52Line = "\" type=\""; //35:40
                if (__tmp52Line != null) __out.Append(__tmp52Line);
                StringBuilder __tmp53 = new StringBuilder();
                __tmp53.Append(ns.Prefix);
                using(StreamReader __tmp53Reader = new StreamReader(this.__ToStream(__tmp53.ToString())))
                {
                    bool __tmp53_first = true;
                    bool __tmp53_last = __tmp53Reader.EndOfStream;
                    while(__tmp53_first || !__tmp53_last)
                    {
                        __tmp53_first = false;
                        string __tmp53Line = __tmp53Reader.ReadLine();
                        __tmp53_last = __tmp53Reader.EndOfStream;
                        if (__tmp53Line != null) __out.Append(__tmp53Line);
                        if (!__tmp53_last) __out.AppendLine(true);
                    }
                }
                string __tmp54Line = ":"; //35:59
                if (__tmp54Line != null) __out.Append(__tmp54Line);
                StringBuilder __tmp55 = new StringBuilder();
                __tmp55.Append(etype.GetXsdName());
                using(StreamReader __tmp55Reader = new StreamReader(this.__ToStream(__tmp55.ToString())))
                {
                    bool __tmp55_first = true;
                    bool __tmp55_last = __tmp55Reader.EndOfStream;
                    while(__tmp55_first || !__tmp55_last)
                    {
                        __tmp55_first = false;
                        string __tmp55Line = __tmp55Reader.ReadLine();
                        __tmp55_last = __tmp55Reader.EndOfStream;
                        if (__tmp55Line != null) __out.Append(__tmp55Line);
                        if (!__tmp55_last) __out.AppendLine(true);
                    }
                }
                string __tmp56Line = "\"/>"; //35:80
                if (__tmp56Line != null) __out.Append(__tmp56Line);
                __out.AppendLine(false); //35:83
                string __tmp57Prefix = string.Empty;
                string __tmp58Line = "	<xs:simpleType name=\""; //36:1
                __out.Append(__tmp57Prefix);
                if (__tmp58Line != null) __out.Append(__tmp58Line);
                StringBuilder __tmp59 = new StringBuilder();
                __tmp59.Append(etype.GetXsdName());
                using(StreamReader __tmp59Reader = new StreamReader(this.__ToStream(__tmp59.ToString())))
                {
                    bool __tmp59_first = true;
                    bool __tmp59_last = __tmp59Reader.EndOfStream;
                    while(__tmp59_first || !__tmp59_last)
                    {
                        __tmp59_first = false;
                        string __tmp59Line = __tmp59Reader.ReadLine();
                        __tmp59_last = __tmp59Reader.EndOfStream;
                        if (__tmp59Line != null) __out.Append(__tmp59Line);
                        if (!__tmp59_last) __out.AppendLine(true);
                    }
                }
                string __tmp60Line = "\">"; //36:43
                if (__tmp60Line != null) __out.Append(__tmp60Line);
                __out.AppendLine(false); //36:45
                __out.Append("		<xs:restriction base=\"xs:string\">"); //37:1
                __out.AppendLine(false); //37:36
                var __loop5_results = 
                    (from __loop5_var1 in __Enumerate((etype).GetEnumerator()) //38:10
                    from elit in __Enumerate((__loop5_var1.EnumLiterals).GetEnumerator()) //38:17
                    select new { __loop5_var1 = __loop5_var1, elit = elit}
                    ).ToList(); //38:5
                int __loop5_iteration = 0;
                foreach (var __tmp61 in __loop5_results)
                {
                    ++__loop5_iteration;
                    var __loop5_var1 = __tmp61.__loop5_var1;
                    var elit = __tmp61.elit;
                    string __tmp62Prefix = string.Empty;
                    string __tmp63Line = "			<xs:enumeration value=\""; //39:1
                    __out.Append(__tmp62Prefix);
                    if (__tmp63Line != null) __out.Append(__tmp63Line);
                    StringBuilder __tmp64 = new StringBuilder();
                    __tmp64.Append(elit.Name);
                    using(StreamReader __tmp64Reader = new StreamReader(this.__ToStream(__tmp64.ToString())))
                    {
                        bool __tmp64_first = true;
                        bool __tmp64_last = __tmp64Reader.EndOfStream;
                        while(__tmp64_first || !__tmp64_last)
                        {
                            __tmp64_first = false;
                            string __tmp64Line = __tmp64Reader.ReadLine();
                            __tmp64_last = __tmp64Reader.EndOfStream;
                            if (__tmp64Line != null) __out.Append(__tmp64Line);
                            if (!__tmp64_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp65Line = "\"/>"; //39:38
                    if (__tmp65Line != null) __out.Append(__tmp65Line);
                    __out.AppendLine(false); //39:41
                }
                __out.Append("		</xs:restriction>"); //41:1
                __out.AppendLine(false); //41:20
                __out.Append("	</xs:simpleType>"); //42:1
                __out.AppendLine(false); //42:18
            }
            var __loop6_results = 
                (from __loop6_var1 in __Enumerate((ns.Declarations).GetEnumerator()) //44:8
                from stype in __Enumerate((__loop6_var1).GetEnumerator()).OfType<StructuredType>() //44:25
                select new { __loop6_var1 = __loop6_var1, stype = stype}
                ).ToList(); //44:3
            int __loop6_iteration = 0;
            foreach (var __tmp66 in __loop6_results)
            {
                ++__loop6_iteration;
                var __loop6_var1 = __tmp66.__loop6_var1;
                var stype = __tmp66.stype;
                __out.AppendLine(true); //45:1
                string __tmp67Prefix = string.Empty;
                string __tmp68Line = "	<xs:element name=\""; //46:1
                __out.Append(__tmp67Prefix);
                if (__tmp68Line != null) __out.Append(__tmp68Line);
                StringBuilder __tmp69 = new StringBuilder();
                __tmp69.Append(stype.GetXsdName());
                using(StreamReader __tmp69Reader = new StreamReader(this.__ToStream(__tmp69.ToString())))
                {
                    bool __tmp69_first = true;
                    bool __tmp69_last = __tmp69Reader.EndOfStream;
                    while(__tmp69_first || !__tmp69_last)
                    {
                        __tmp69_first = false;
                        string __tmp69Line = __tmp69Reader.ReadLine();
                        __tmp69_last = __tmp69Reader.EndOfStream;
                        if (__tmp69Line != null) __out.Append(__tmp69Line);
                        if (!__tmp69_last) __out.AppendLine(true);
                    }
                }
                string __tmp70Line = "\" type=\""; //46:40
                if (__tmp70Line != null) __out.Append(__tmp70Line);
                StringBuilder __tmp71 = new StringBuilder();
                __tmp71.Append(ns.Prefix);
                using(StreamReader __tmp71Reader = new StreamReader(this.__ToStream(__tmp71.ToString())))
                {
                    bool __tmp71_first = true;
                    bool __tmp71_last = __tmp71Reader.EndOfStream;
                    while(__tmp71_first || !__tmp71_last)
                    {
                        __tmp71_first = false;
                        string __tmp71Line = __tmp71Reader.ReadLine();
                        __tmp71_last = __tmp71Reader.EndOfStream;
                        if (__tmp71Line != null) __out.Append(__tmp71Line);
                        if (!__tmp71_last) __out.AppendLine(true);
                    }
                }
                string __tmp72Line = ":"; //46:59
                if (__tmp72Line != null) __out.Append(__tmp72Line);
                StringBuilder __tmp73 = new StringBuilder();
                __tmp73.Append(stype.GetXsdName());
                using(StreamReader __tmp73Reader = new StreamReader(this.__ToStream(__tmp73.ToString())))
                {
                    bool __tmp73_first = true;
                    bool __tmp73_last = __tmp73Reader.EndOfStream;
                    while(__tmp73_first || !__tmp73_last)
                    {
                        __tmp73_first = false;
                        string __tmp73Line = __tmp73Reader.ReadLine();
                        __tmp73_last = __tmp73Reader.EndOfStream;
                        if (__tmp73Line != null) __out.Append(__tmp73Line);
                        if (!__tmp73_last) __out.AppendLine(true);
                    }
                }
                string __tmp74Line = "\"/>"; //46:80
                if (__tmp74Line != null) __out.Append(__tmp74Line);
                __out.AppendLine(false); //46:83
                string __tmp75Prefix = string.Empty;
                string __tmp76Line = "	<xs:complexType name=\""; //47:1
                __out.Append(__tmp75Prefix);
                if (__tmp76Line != null) __out.Append(__tmp76Line);
                StringBuilder __tmp77 = new StringBuilder();
                __tmp77.Append(stype.GetXsdName());
                using(StreamReader __tmp77Reader = new StreamReader(this.__ToStream(__tmp77.ToString())))
                {
                    bool __tmp77_first = true;
                    bool __tmp77_last = __tmp77Reader.EndOfStream;
                    while(__tmp77_first || !__tmp77_last)
                    {
                        __tmp77_first = false;
                        string __tmp77Line = __tmp77Reader.ReadLine();
                        __tmp77_last = __tmp77Reader.EndOfStream;
                        if (__tmp77Line != null) __out.Append(__tmp77Line);
                        if (!__tmp77_last) __out.AppendLine(true);
                    }
                }
                string __tmp78Line = "\">"; //47:44
                if (__tmp78Line != null) __out.Append(__tmp78Line);
                __out.AppendLine(false); //47:46
                var __tmp79 = stype; //48:11
                if (stype is Struct) //49:4
                {
                    if (((Struct)stype).BaseType != null) //50:5
                    {
                        __out.Append("		<xs:complexContent>"); //51:1
                        __out.AppendLine(false); //51:22
                        string __tmp80Prefix = string.Empty;
                        string __tmp81Line = "			<xs:extension base=\""; //52:1
                        __out.Append(__tmp80Prefix);
                        if (__tmp81Line != null) __out.Append(__tmp81Line);
                        StringBuilder __tmp82 = new StringBuilder();
                        __tmp82.Append(((Struct)stype).BaseType.GetNamespace(ns).Prefix);
                        using(StreamReader __tmp82Reader = new StreamReader(this.__ToStream(__tmp82.ToString())))
                        {
                            bool __tmp82_first = true;
                            bool __tmp82_last = __tmp82Reader.EndOfStream;
                            while(__tmp82_first || !__tmp82_last)
                            {
                                __tmp82_first = false;
                                string __tmp82Line = __tmp82Reader.ReadLine();
                                __tmp82_last = __tmp82Reader.EndOfStream;
                                if (__tmp82Line != null) __out.Append(__tmp82Line);
                                if (!__tmp82_last) __out.AppendLine(true);
                            }
                        }
                        string __tmp83Line = ":"; //52:64
                        if (__tmp83Line != null) __out.Append(__tmp83Line);
                        StringBuilder __tmp84 = new StringBuilder();
                        __tmp84.Append(((Struct)stype).BaseType.GetXsdName());
                        using(StreamReader __tmp84Reader = new StreamReader(this.__ToStream(__tmp84.ToString())))
                        {
                            bool __tmp84_first = true;
                            bool __tmp84_last = __tmp84Reader.EndOfStream;
                            while(__tmp84_first || !__tmp84_last)
                            {
                                __tmp84_first = false;
                                string __tmp84Line = __tmp84Reader.ReadLine();
                                __tmp84_last = __tmp84Reader.EndOfStream;
                                if (__tmp84Line != null) __out.Append(__tmp84Line);
                                if (!__tmp84_last) __out.AppendLine(true);
                            }
                        }
                        string __tmp85Line = "\">"; //52:94
                        if (__tmp85Line != null) __out.Append(__tmp85Line);
                        __out.AppendLine(false); //52:96
                        string __tmp86Prefix = "				"; //53:1
                        StringBuilder __tmp87 = new StringBuilder();
                        __tmp87.Append(GenerateStructuredTypeBody(ns, ((Struct)stype)));
                        using(StreamReader __tmp87Reader = new StreamReader(this.__ToStream(__tmp87.ToString())))
                        {
                            bool __tmp87_first = true;
                            bool __tmp87_last = __tmp87Reader.EndOfStream;
                            while(__tmp87_first || !__tmp87_last)
                            {
                                __tmp87_first = false;
                                string __tmp87Line = __tmp87Reader.ReadLine();
                                __tmp87_last = __tmp87Reader.EndOfStream;
                                __out.Append(__tmp86Prefix);
                                if (__tmp87Line != null) __out.Append(__tmp87Line);
                                if (!__tmp87_last) __out.AppendLine(true);
                                __out.AppendLine(false); //53:44
                            }
                        }
                        __out.Append("			</xs:extension>"); //54:1
                        __out.AppendLine(false); //54:19
                        __out.Append("		</xs:complexContent>"); //55:1
                        __out.AppendLine(false); //55:23
                    }
                    else //56:5
                    {
                        string __tmp88Prefix = "		"; //57:1
                        StringBuilder __tmp89 = new StringBuilder();
                        __tmp89.Append(GenerateStructuredTypeBody(ns, ((Struct)stype)));
                        using(StreamReader __tmp89Reader = new StreamReader(this.__ToStream(__tmp89.ToString())))
                        {
                            bool __tmp89_first = true;
                            bool __tmp89_last = __tmp89Reader.EndOfStream;
                            while(__tmp89_first || !__tmp89_last)
                            {
                                __tmp89_first = false;
                                string __tmp89Line = __tmp89Reader.ReadLine();
                                __tmp89_last = __tmp89Reader.EndOfStream;
                                __out.Append(__tmp88Prefix);
                                if (__tmp89Line != null) __out.Append(__tmp89Line);
                                if (!__tmp89_last) __out.AppendLine(true);
                                __out.AppendLine(false); //57:42
                            }
                        }
                    }
                }
                else if (stype is Exception) //59:4
                {
                    if (((Exception)stype).BaseType != null) //60:5
                    {
                        __out.Append("		<xs:complexContent>"); //61:1
                        __out.AppendLine(false); //61:22
                        string __tmp90Prefix = string.Empty;
                        string __tmp91Line = "			<xs:extension base=\""; //62:1
                        __out.Append(__tmp90Prefix);
                        if (__tmp91Line != null) __out.Append(__tmp91Line);
                        StringBuilder __tmp92 = new StringBuilder();
                        __tmp92.Append(((Exception)stype).BaseType.GetNamespace(ns).Prefix);
                        using(StreamReader __tmp92Reader = new StreamReader(this.__ToStream(__tmp92.ToString())))
                        {
                            bool __tmp92_first = true;
                            bool __tmp92_last = __tmp92Reader.EndOfStream;
                            while(__tmp92_first || !__tmp92_last)
                            {
                                __tmp92_first = false;
                                string __tmp92Line = __tmp92Reader.ReadLine();
                                __tmp92_last = __tmp92Reader.EndOfStream;
                                if (__tmp92Line != null) __out.Append(__tmp92Line);
                                if (!__tmp92_last) __out.AppendLine(true);
                            }
                        }
                        string __tmp93Line = ":"; //62:64
                        if (__tmp93Line != null) __out.Append(__tmp93Line);
                        StringBuilder __tmp94 = new StringBuilder();
                        __tmp94.Append(((Exception)stype).BaseType.GetXsdName());
                        using(StreamReader __tmp94Reader = new StreamReader(this.__ToStream(__tmp94.ToString())))
                        {
                            bool __tmp94_first = true;
                            bool __tmp94_last = __tmp94Reader.EndOfStream;
                            while(__tmp94_first || !__tmp94_last)
                            {
                                __tmp94_first = false;
                                string __tmp94Line = __tmp94Reader.ReadLine();
                                __tmp94_last = __tmp94Reader.EndOfStream;
                                if (__tmp94Line != null) __out.Append(__tmp94Line);
                                if (!__tmp94_last) __out.AppendLine(true);
                            }
                        }
                        string __tmp95Line = "\">"; //62:94
                        if (__tmp95Line != null) __out.Append(__tmp95Line);
                        __out.AppendLine(false); //62:96
                        string __tmp96Prefix = "				"; //63:1
                        StringBuilder __tmp97 = new StringBuilder();
                        __tmp97.Append(GenerateStructuredTypeBody(ns, ((Exception)stype)));
                        using(StreamReader __tmp97Reader = new StreamReader(this.__ToStream(__tmp97.ToString())))
                        {
                            bool __tmp97_first = true;
                            bool __tmp97_last = __tmp97Reader.EndOfStream;
                            while(__tmp97_first || !__tmp97_last)
                            {
                                __tmp97_first = false;
                                string __tmp97Line = __tmp97Reader.ReadLine();
                                __tmp97_last = __tmp97Reader.EndOfStream;
                                __out.Append(__tmp96Prefix);
                                if (__tmp97Line != null) __out.Append(__tmp97Line);
                                if (!__tmp97_last) __out.AppendLine(true);
                                __out.AppendLine(false); //63:44
                            }
                        }
                        __out.Append("			</xs:extension>"); //64:1
                        __out.AppendLine(false); //64:19
                        __out.Append("		</xs:complexContent>"); //65:1
                        __out.AppendLine(false); //65:23
                    }
                    else //66:5
                    {
                        string __tmp98Prefix = "		"; //67:1
                        StringBuilder __tmp99 = new StringBuilder();
                        __tmp99.Append(GenerateStructuredTypeBody(ns, ((Exception)stype)));
                        using(StreamReader __tmp99Reader = new StreamReader(this.__ToStream(__tmp99.ToString())))
                        {
                            bool __tmp99_first = true;
                            bool __tmp99_last = __tmp99Reader.EndOfStream;
                            while(__tmp99_first || !__tmp99_last)
                            {
                                __tmp99_first = false;
                                string __tmp99Line = __tmp99Reader.ReadLine();
                                __tmp99_last = __tmp99Reader.EndOfStream;
                                __out.Append(__tmp98Prefix);
                                if (__tmp99Line != null) __out.Append(__tmp99Line);
                                if (!__tmp99_last) __out.AppendLine(true);
                                __out.AppendLine(false); //67:42
                            }
                        }
                    }
                }
                else if (stype is Entity) //69:4
                {
                    if (((Entity)stype).BaseType != null) //70:5
                    {
                        __out.Append("		<xs:complexContent>"); //71:1
                        __out.AppendLine(false); //71:22
                        string __tmp100Prefix = string.Empty;
                        string __tmp101Line = "			<xs:extension base=\""; //72:1
                        __out.Append(__tmp100Prefix);
                        if (__tmp101Line != null) __out.Append(__tmp101Line);
                        StringBuilder __tmp102 = new StringBuilder();
                        __tmp102.Append(((Entity)stype).BaseType.GetNamespace(ns).Prefix);
                        using(StreamReader __tmp102Reader = new StreamReader(this.__ToStream(__tmp102.ToString())))
                        {
                            bool __tmp102_first = true;
                            bool __tmp102_last = __tmp102Reader.EndOfStream;
                            while(__tmp102_first || !__tmp102_last)
                            {
                                __tmp102_first = false;
                                string __tmp102Line = __tmp102Reader.ReadLine();
                                __tmp102_last = __tmp102Reader.EndOfStream;
                                if (__tmp102Line != null) __out.Append(__tmp102Line);
                                if (!__tmp102_last) __out.AppendLine(true);
                            }
                        }
                        string __tmp103Line = ":"; //72:64
                        if (__tmp103Line != null) __out.Append(__tmp103Line);
                        StringBuilder __tmp104 = new StringBuilder();
                        __tmp104.Append(((Entity)stype).BaseType.GetXsdName());
                        using(StreamReader __tmp104Reader = new StreamReader(this.__ToStream(__tmp104.ToString())))
                        {
                            bool __tmp104_first = true;
                            bool __tmp104_last = __tmp104Reader.EndOfStream;
                            while(__tmp104_first || !__tmp104_last)
                            {
                                __tmp104_first = false;
                                string __tmp104Line = __tmp104Reader.ReadLine();
                                __tmp104_last = __tmp104Reader.EndOfStream;
                                if (__tmp104Line != null) __out.Append(__tmp104Line);
                                if (!__tmp104_last) __out.AppendLine(true);
                            }
                        }
                        string __tmp105Line = "\">"; //72:94
                        if (__tmp105Line != null) __out.Append(__tmp105Line);
                        __out.AppendLine(false); //72:96
                        string __tmp106Prefix = "				"; //73:1
                        StringBuilder __tmp107 = new StringBuilder();
                        __tmp107.Append(GenerateStructuredTypeBody(ns, ((Entity)stype)));
                        using(StreamReader __tmp107Reader = new StreamReader(this.__ToStream(__tmp107.ToString())))
                        {
                            bool __tmp107_first = true;
                            bool __tmp107_last = __tmp107Reader.EndOfStream;
                            while(__tmp107_first || !__tmp107_last)
                            {
                                __tmp107_first = false;
                                string __tmp107Line = __tmp107Reader.ReadLine();
                                __tmp107_last = __tmp107Reader.EndOfStream;
                                __out.Append(__tmp106Prefix);
                                if (__tmp107Line != null) __out.Append(__tmp107Line);
                                if (!__tmp107_last) __out.AppendLine(true);
                                __out.AppendLine(false); //73:44
                            }
                        }
                        __out.Append("			</xs:extension>"); //74:1
                        __out.AppendLine(false); //74:19
                        __out.Append("		</xs:complexContent>"); //75:1
                        __out.AppendLine(false); //75:23
                    }
                    else //76:5
                    {
                        string __tmp108Prefix = "		"; //77:1
                        StringBuilder __tmp109 = new StringBuilder();
                        __tmp109.Append(GenerateStructuredTypeBody(ns, ((Entity)stype)));
                        using(StreamReader __tmp109Reader = new StreamReader(this.__ToStream(__tmp109.ToString())))
                        {
                            bool __tmp109_first = true;
                            bool __tmp109_last = __tmp109Reader.EndOfStream;
                            while(__tmp109_first || !__tmp109_last)
                            {
                                __tmp109_first = false;
                                string __tmp109Line = __tmp109Reader.ReadLine();
                                __tmp109_last = __tmp109Reader.EndOfStream;
                                __out.Append(__tmp108Prefix);
                                if (__tmp109Line != null) __out.Append(__tmp109Line);
                                if (!__tmp109_last) __out.AppendLine(true);
                                __out.AppendLine(false); //77:42
                            }
                        }
                    }
                }
                else //79:4
                {
                    string __tmp110Prefix = "		"; //80:1
                    StringBuilder __tmp111 = new StringBuilder();
                    __tmp111.Append(GenerateStructuredTypeBody(ns, stype));
                    using(StreamReader __tmp111Reader = new StreamReader(this.__ToStream(__tmp111.ToString())))
                    {
                        bool __tmp111_first = true;
                        bool __tmp111_last = __tmp111Reader.EndOfStream;
                        while(__tmp111_first || !__tmp111_last)
                        {
                            __tmp111_first = false;
                            string __tmp111Line = __tmp111Reader.ReadLine();
                            __tmp111_last = __tmp111Reader.EndOfStream;
                            __out.Append(__tmp110Prefix);
                            if (__tmp111Line != null) __out.Append(__tmp111Line);
                            if (!__tmp111_last) __out.AppendLine(true);
                            __out.AppendLine(false); //80:42
                        }
                    }
                }//81:4
                __out.Append("	</xs:complexType>"); //82:1
                __out.AppendLine(false); //82:19
            }
            var __loop7_results = 
                (from __loop7_var1 in __Enumerate((ns.Declarations).GetEnumerator()) //84:8
                from intf in __Enumerate((__loop7_var1).GetEnumerator()).OfType<Interface>() //84:25
                from op in __Enumerate((intf.Operations).GetEnumerator()) //84:49
                select new { __loop7_var1 = __loop7_var1, intf = intf, op = op}
                ).ToList(); //84:3
            int __loop7_iteration = 0;
            foreach (var __tmp112 in __loop7_results)
            {
                ++__loop7_iteration;
                var __loop7_var1 = __tmp112.__loop7_var1;
                var intf = __tmp112.intf;
                var op = __tmp112.op;
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
                        foreach (var __tmp113 in __loop8_results)
                        {
                            ++__loop8_iteration;
                            var __loop8_var1 = __tmp113.__loop8_var1;
                            var param = __tmp113.param;
                            string __tmp114Prefix = "	"; //88:1
                            StringBuilder __tmp115 = new StringBuilder();
                            __tmp115.Append(GenerateElement(ns, op.Name + param.Name.ToPascalCase(), param.Type, param.Annotations));
                            using(StreamReader __tmp115Reader = new StreamReader(this.__ToStream(__tmp115.ToString())))
                            {
                                bool __tmp115_first = true;
                                bool __tmp115_last = __tmp115Reader.EndOfStream;
                                while(__tmp115_first || !__tmp115_last)
                                {
                                    __tmp115_first = false;
                                    string __tmp115Line = __tmp115Reader.ReadLine();
                                    __tmp115_last = __tmp115Reader.EndOfStream;
                                    __out.Append(__tmp114Prefix);
                                    if (__tmp115Line != null) __out.Append(__tmp115Line);
                                    if (!__tmp115_last) __out.AppendLine(true);
                                    __out.AppendLine(false); //88:91
                                }
                            }
                        }
                        if (op.ReturnType != SoalInstance.Void) //90:5
                        {
                            string __tmp116Prefix = "	"; //91:1
                            StringBuilder __tmp117 = new StringBuilder();
                            __tmp117.Append(GenerateElement(ns, op.Name + "Response", op.ReturnType, op.ReturnAnnotations));
                            using(StreamReader __tmp117Reader = new StreamReader(this.__ToStream(__tmp117.ToString())))
                            {
                                bool __tmp117_first = true;
                                bool __tmp117_last = __tmp117Reader.EndOfStream;
                                while(__tmp117_first || !__tmp117_last)
                                {
                                    __tmp117_first = false;
                                    string __tmp117Line = __tmp117Reader.ReadLine();
                                    __tmp117_last = __tmp117Reader.EndOfStream;
                                    __out.Append(__tmp116Prefix);
                                    if (__tmp117Line != null) __out.Append(__tmp117Line);
                                    if (!__tmp117_last) __out.AppendLine(true);
                                    __out.AppendLine(false); //91:80
                                }
                            }
                        }
                    }
                    else //93:4
                    {
                        __out.AppendLine(true); //94:1
                        string __tmp118Prefix = string.Empty;
                        string __tmp119Line = "	<xs:element name=\""; //95:1
                        __out.Append(__tmp118Prefix);
                        if (__tmp119Line != null) __out.Append(__tmp119Line);
                        StringBuilder __tmp120 = new StringBuilder();
                        __tmp120.Append(op.Name);
                        using(StreamReader __tmp120Reader = new StreamReader(this.__ToStream(__tmp120.ToString())))
                        {
                            bool __tmp120_first = true;
                            bool __tmp120_last = __tmp120Reader.EndOfStream;
                            while(__tmp120_first || !__tmp120_last)
                            {
                                __tmp120_first = false;
                                string __tmp120Line = __tmp120Reader.ReadLine();
                                __tmp120_last = __tmp120Reader.EndOfStream;
                                if (__tmp120Line != null) __out.Append(__tmp120Line);
                                if (!__tmp120_last) __out.AppendLine(true);
                            }
                        }
                        string __tmp121Line = "\" type=\""; //95:29
                        if (__tmp121Line != null) __out.Append(__tmp121Line);
                        StringBuilder __tmp122 = new StringBuilder();
                        __tmp122.Append(ns.Prefix);
                        using(StreamReader __tmp122Reader = new StreamReader(this.__ToStream(__tmp122.ToString())))
                        {
                            bool __tmp122_first = true;
                            bool __tmp122_last = __tmp122Reader.EndOfStream;
                            while(__tmp122_first || !__tmp122_last)
                            {
                                __tmp122_first = false;
                                string __tmp122Line = __tmp122Reader.ReadLine();
                                __tmp122_last = __tmp122Reader.EndOfStream;
                                if (__tmp122Line != null) __out.Append(__tmp122Line);
                                if (!__tmp122_last) __out.AppendLine(true);
                            }
                        }
                        string __tmp123Line = ":"; //95:48
                        if (__tmp123Line != null) __out.Append(__tmp123Line);
                        StringBuilder __tmp124 = new StringBuilder();
                        __tmp124.Append(op.Name);
                        using(StreamReader __tmp124Reader = new StreamReader(this.__ToStream(__tmp124.ToString())))
                        {
                            bool __tmp124_first = true;
                            bool __tmp124_last = __tmp124Reader.EndOfStream;
                            while(__tmp124_first || !__tmp124_last)
                            {
                                __tmp124_first = false;
                                string __tmp124Line = __tmp124Reader.ReadLine();
                                __tmp124_last = __tmp124Reader.EndOfStream;
                                if (__tmp124Line != null) __out.Append(__tmp124Line);
                                if (!__tmp124_last) __out.AppendLine(true);
                            }
                        }
                        string __tmp125Line = "\"/>"; //95:58
                        if (__tmp125Line != null) __out.Append(__tmp125Line);
                        __out.AppendLine(false); //95:61
                        string __tmp126Prefix = string.Empty;
                        string __tmp127Line = "	<xs:complexType name=\""; //96:1
                        __out.Append(__tmp126Prefix);
                        if (__tmp127Line != null) __out.Append(__tmp127Line);
                        StringBuilder __tmp128 = new StringBuilder();
                        __tmp128.Append(op.Name);
                        using(StreamReader __tmp128Reader = new StreamReader(this.__ToStream(__tmp128.ToString())))
                        {
                            bool __tmp128_first = true;
                            bool __tmp128_last = __tmp128Reader.EndOfStream;
                            while(__tmp128_first || !__tmp128_last)
                            {
                                __tmp128_first = false;
                                string __tmp128Line = __tmp128Reader.ReadLine();
                                __tmp128_last = __tmp128Reader.EndOfStream;
                                if (__tmp128Line != null) __out.Append(__tmp128Line);
                                if (!__tmp128_last) __out.AppendLine(true);
                            }
                        }
                        string __tmp129Line = "\">"; //96:33
                        if (__tmp129Line != null) __out.Append(__tmp129Line);
                        __out.AppendLine(false); //96:35
                        __out.Append("		<xs:sequence>"); //97:1
                        __out.AppendLine(false); //97:16
                        var __loop9_results = 
                            (from __loop9_var1 in __Enumerate((op).GetEnumerator()) //98:10
                            from param in __Enumerate((__loop9_var1.Parameters).GetEnumerator()) //98:14
                            where !param.HasAnnotation(SoalAnnotations.Attribute) //98:31
                            select new { __loop9_var1 = __loop9_var1, param = param}
                            ).ToList(); //98:5
                        int __loop9_iteration = 0;
                        foreach (var __tmp130 in __loop9_results)
                        {
                            ++__loop9_iteration;
                            var __loop9_var1 = __tmp130.__loop9_var1;
                            var param = __tmp130.param;
                            string __tmp131Prefix = "			"; //99:1
                            StringBuilder __tmp132 = new StringBuilder();
                            __tmp132.Append(GenerateElement(ns, param.Name, param.Type, param.Annotations));
                            using(StreamReader __tmp132Reader = new StreamReader(this.__ToStream(__tmp132.ToString())))
                            {
                                bool __tmp132_first = true;
                                bool __tmp132_last = __tmp132Reader.EndOfStream;
                                while(__tmp132_first || !__tmp132_last)
                                {
                                    __tmp132_first = false;
                                    string __tmp132Line = __tmp132Reader.ReadLine();
                                    __tmp132_last = __tmp132Reader.EndOfStream;
                                    __out.Append(__tmp131Prefix);
                                    if (__tmp132Line != null) __out.Append(__tmp132Line);
                                    if (!__tmp132_last) __out.AppendLine(true);
                                    __out.AppendLine(false); //99:68
                                }
                            }
                        }
                        __out.Append("		</xs:sequence>"); //101:1
                        __out.AppendLine(false); //101:17
                        var __loop10_results = 
                            (from __loop10_var1 in __Enumerate((op).GetEnumerator()) //102:9
                            from param in __Enumerate((__loop10_var1.Parameters).GetEnumerator()) //102:13
                            where param.HasAnnotation(SoalAnnotations.Attribute) //102:30
                            select new { __loop10_var1 = __loop10_var1, param = param}
                            ).ToList(); //102:4
                        int __loop10_iteration = 0;
                        foreach (var __tmp133 in __loop10_results)
                        {
                            ++__loop10_iteration;
                            var __loop10_var1 = __tmp133.__loop10_var1;
                            var param = __tmp133.param;
                            string __tmp134Prefix = "		"; //103:1
                            StringBuilder __tmp135 = new StringBuilder();
                            __tmp135.Append(GenerateElement(ns, param.Name, param.Type, param.Annotations));
                            using(StreamReader __tmp135Reader = new StreamReader(this.__ToStream(__tmp135.ToString())))
                            {
                                bool __tmp135_first = true;
                                bool __tmp135_last = __tmp135Reader.EndOfStream;
                                while(__tmp135_first || !__tmp135_last)
                                {
                                    __tmp135_first = false;
                                    string __tmp135Line = __tmp135Reader.ReadLine();
                                    __tmp135_last = __tmp135Reader.EndOfStream;
                                    __out.Append(__tmp134Prefix);
                                    if (__tmp135Line != null) __out.Append(__tmp135Line);
                                    if (!__tmp135_last) __out.AppendLine(true);
                                    __out.AppendLine(false); //103:67
                                }
                            }
                        }
                        __out.Append("	</xs:complexType>"); //105:1
                        __out.AppendLine(false); //105:19
                        if (!op.IsOneway) //106:4
                        {
                            __out.AppendLine(true); //107:1
                            string __tmp136Prefix = string.Empty;
                            string __tmp137Line = "	<xs:element name=\""; //108:1
                            __out.Append(__tmp136Prefix);
                            if (__tmp137Line != null) __out.Append(__tmp137Line);
                            StringBuilder __tmp138 = new StringBuilder();
                            __tmp138.Append(op.Name);
                            using(StreamReader __tmp138Reader = new StreamReader(this.__ToStream(__tmp138.ToString())))
                            {
                                bool __tmp138_first = true;
                                bool __tmp138_last = __tmp138Reader.EndOfStream;
                                while(__tmp138_first || !__tmp138_last)
                                {
                                    __tmp138_first = false;
                                    string __tmp138Line = __tmp138Reader.ReadLine();
                                    __tmp138_last = __tmp138Reader.EndOfStream;
                                    if (__tmp138Line != null) __out.Append(__tmp138Line);
                                    if (!__tmp138_last) __out.AppendLine(true);
                                }
                            }
                            string __tmp139Line = "Response\" type=\""; //108:29
                            if (__tmp139Line != null) __out.Append(__tmp139Line);
                            StringBuilder __tmp140 = new StringBuilder();
                            __tmp140.Append(ns.Prefix);
                            using(StreamReader __tmp140Reader = new StreamReader(this.__ToStream(__tmp140.ToString())))
                            {
                                bool __tmp140_first = true;
                                bool __tmp140_last = __tmp140Reader.EndOfStream;
                                while(__tmp140_first || !__tmp140_last)
                                {
                                    __tmp140_first = false;
                                    string __tmp140Line = __tmp140Reader.ReadLine();
                                    __tmp140_last = __tmp140Reader.EndOfStream;
                                    if (__tmp140Line != null) __out.Append(__tmp140Line);
                                    if (!__tmp140_last) __out.AppendLine(true);
                                }
                            }
                            string __tmp141Line = ":"; //108:56
                            if (__tmp141Line != null) __out.Append(__tmp141Line);
                            StringBuilder __tmp142 = new StringBuilder();
                            __tmp142.Append(op.Name);
                            using(StreamReader __tmp142Reader = new StreamReader(this.__ToStream(__tmp142.ToString())))
                            {
                                bool __tmp142_first = true;
                                bool __tmp142_last = __tmp142Reader.EndOfStream;
                                while(__tmp142_first || !__tmp142_last)
                                {
                                    __tmp142_first = false;
                                    string __tmp142Line = __tmp142Reader.ReadLine();
                                    __tmp142_last = __tmp142Reader.EndOfStream;
                                    if (__tmp142Line != null) __out.Append(__tmp142Line);
                                    if (!__tmp142_last) __out.AppendLine(true);
                                }
                            }
                            string __tmp143Line = "Response\"/>"; //108:66
                            if (__tmp143Line != null) __out.Append(__tmp143Line);
                            __out.AppendLine(false); //108:77
                            string __tmp144Prefix = string.Empty;
                            string __tmp145Line = "	<xs:complexType name=\""; //109:1
                            __out.Append(__tmp144Prefix);
                            if (__tmp145Line != null) __out.Append(__tmp145Line);
                            StringBuilder __tmp146 = new StringBuilder();
                            __tmp146.Append(op.Name);
                            using(StreamReader __tmp146Reader = new StreamReader(this.__ToStream(__tmp146.ToString())))
                            {
                                bool __tmp146_first = true;
                                bool __tmp146_last = __tmp146Reader.EndOfStream;
                                while(__tmp146_first || !__tmp146_last)
                                {
                                    __tmp146_first = false;
                                    string __tmp146Line = __tmp146Reader.ReadLine();
                                    __tmp146_last = __tmp146Reader.EndOfStream;
                                    if (__tmp146Line != null) __out.Append(__tmp146Line);
                                    if (!__tmp146_last) __out.AppendLine(true);
                                }
                            }
                            string __tmp147Line = "Response\">"; //109:33
                            if (__tmp147Line != null) __out.Append(__tmp147Line);
                            __out.AppendLine(false); //109:43
                            if (op.ReturnType == SoalInstance.Void || op.ReturnAnnotations.ContainsAnnotation(SoalAnnotations.Attribute)) //110:5
                            {
                                __out.Append("		<xs:sequence/>"); //111:1
                                __out.AppendLine(false); //111:17
                            }
                            else //112:5
                            {
                                __out.Append("		<xs:sequence>"); //113:1
                                __out.AppendLine(false); //113:16
                                string __tmp148Prefix = "			"; //114:1
                                StringBuilder __tmp149 = new StringBuilder();
                                __tmp149.Append(GenerateElement(ns, op.Name + "Result", op.ReturnType, op.ReturnAnnotations));
                                using(StreamReader __tmp149Reader = new StreamReader(this.__ToStream(__tmp149.ToString())))
                                {
                                    bool __tmp149_first = true;
                                    bool __tmp149_last = __tmp149Reader.EndOfStream;
                                    while(__tmp149_first || !__tmp149_last)
                                    {
                                        __tmp149_first = false;
                                        string __tmp149Line = __tmp149Reader.ReadLine();
                                        __tmp149_last = __tmp149Reader.EndOfStream;
                                        __out.Append(__tmp148Prefix);
                                        if (__tmp149Line != null) __out.Append(__tmp149Line);
                                        if (!__tmp149_last) __out.AppendLine(true);
                                        __out.AppendLine(false); //114:80
                                    }
                                }
                                __out.Append("		</xs:sequence>"); //115:1
                                __out.AppendLine(false); //115:17
                            }
                            if (op.ReturnAnnotations.ContainsAnnotation(SoalAnnotations.Attribute)) //117:4
                            {
                                string __tmp150Prefix = "		"; //118:1
                                StringBuilder __tmp151 = new StringBuilder();
                                __tmp151.Append(GenerateElement(ns, op.Name + "Result", op.ReturnType, op.ReturnAnnotations));
                                using(StreamReader __tmp151Reader = new StreamReader(this.__ToStream(__tmp151.ToString())))
                                {
                                    bool __tmp151_first = true;
                                    bool __tmp151_last = __tmp151Reader.EndOfStream;
                                    while(__tmp151_first || !__tmp151_last)
                                    {
                                        __tmp151_first = false;
                                        string __tmp151Line = __tmp151Reader.ReadLine();
                                        __tmp151_last = __tmp151Reader.EndOfStream;
                                        __out.Append(__tmp150Prefix);
                                        if (__tmp151Line != null) __out.Append(__tmp151Line);
                                        if (!__tmp151_last) __out.AppendLine(true);
                                        __out.AppendLine(false); //118:79
                                    }
                                }
                            }
                            __out.Append("	</xs:complexType>"); //120:1
                            __out.AppendLine(false); //120:19
                        }
                    }
                }
            }
            __out.Append("</xs:schema>"); //125:1
            __out.AppendLine(false); //125:13
            return __out.ToString();
        }

        public string GenerateStructuredTypeBody(Namespace ns, StructuredType stype) //128:1
        {
            StringBuilder __out = new StringBuilder();
            string __tmp1Prefix = string.Empty;
            string __tmp2Line = "<xs:"; //129:1
            __out.Append(__tmp1Prefix);
            if (__tmp2Line != null) __out.Append(__tmp2Line);
            StringBuilder __tmp3 = new StringBuilder();
            __tmp3.Append(GetStructKind(stype));
            using(StreamReader __tmp3Reader = new StreamReader(this.__ToStream(__tmp3.ToString())))
            {
                bool __tmp3_first = true;
                bool __tmp3_last = __tmp3Reader.EndOfStream;
                while(__tmp3_first || !__tmp3_last)
                {
                    __tmp3_first = false;
                    string __tmp3Line = __tmp3Reader.ReadLine();
                    __tmp3_last = __tmp3Reader.EndOfStream;
                    if (__tmp3Line != null) __out.Append(__tmp3Line);
                    if (!__tmp3_last) __out.AppendLine(true);
                }
            }
            string __tmp4Line = ">"; //129:27
            if (__tmp4Line != null) __out.Append(__tmp4Line);
            __out.AppendLine(false); //129:28
            var __loop11_results = 
                (from __loop11_var1 in __Enumerate((stype).GetEnumerator()) //130:8
                from prop in __Enumerate((__loop11_var1.Properties).GetEnumerator()) //130:15
                where !prop.HasAnnotation(SoalAnnotations.Attribute) //130:31
                select new { __loop11_var1 = __loop11_var1, prop = prop}
                ).ToList(); //130:3
            int __loop11_iteration = 0;
            foreach (var __tmp5 in __loop11_results)
            {
                ++__loop11_iteration;
                var __loop11_var1 = __tmp5.__loop11_var1;
                var prop = __tmp5.prop;
                string __tmp6Prefix = "	"; //131:1
                StringBuilder __tmp7 = new StringBuilder();
                __tmp7.Append(GenerateElement(ns, prop.Name, prop.Type, prop.Annotations));
                using(StreamReader __tmp7Reader = new StreamReader(this.__ToStream(__tmp7.ToString())))
                {
                    bool __tmp7_first = true;
                    bool __tmp7_last = __tmp7Reader.EndOfStream;
                    while(__tmp7_first || !__tmp7_last)
                    {
                        __tmp7_first = false;
                        string __tmp7Line = __tmp7Reader.ReadLine();
                        __tmp7_last = __tmp7Reader.EndOfStream;
                        __out.Append(__tmp6Prefix);
                        if (__tmp7Line != null) __out.Append(__tmp7Line);
                        if (!__tmp7_last) __out.AppendLine(true);
                        __out.AppendLine(false); //131:63
                    }
                }
            }
            string __tmp8Prefix = string.Empty;
            string __tmp9Line = "</xs:"; //133:1
            __out.Append(__tmp8Prefix);
            if (__tmp9Line != null) __out.Append(__tmp9Line);
            StringBuilder __tmp10 = new StringBuilder();
            __tmp10.Append(GetStructKind(stype));
            using(StreamReader __tmp10Reader = new StreamReader(this.__ToStream(__tmp10.ToString())))
            {
                bool __tmp10_first = true;
                bool __tmp10_last = __tmp10Reader.EndOfStream;
                while(__tmp10_first || !__tmp10_last)
                {
                    __tmp10_first = false;
                    string __tmp10Line = __tmp10Reader.ReadLine();
                    __tmp10_last = __tmp10Reader.EndOfStream;
                    if (__tmp10Line != null) __out.Append(__tmp10Line);
                    if (!__tmp10_last) __out.AppendLine(true);
                }
            }
            string __tmp11Line = ">"; //133:28
            if (__tmp11Line != null) __out.Append(__tmp11Line);
            __out.AppendLine(false); //133:29
            var __loop12_results = 
                (from __loop12_var1 in __Enumerate((stype).GetEnumerator()) //134:7
                from prop in __Enumerate((__loop12_var1.Properties).GetEnumerator()) //134:14
                where prop.HasAnnotation(SoalAnnotations.Attribute) //134:30
                select new { __loop12_var1 = __loop12_var1, prop = prop}
                ).ToList(); //134:2
            int __loop12_iteration = 0;
            foreach (var __tmp12 in __loop12_results)
            {
                ++__loop12_iteration;
                var __loop12_var1 = __tmp12.__loop12_var1;
                var prop = __tmp12.prop;
                string __tmp13Prefix = string.Empty;
                StringBuilder __tmp14 = new StringBuilder();
                __tmp14.Append(GenerateElement(ns, prop.Name, prop.Type, prop.Annotations));
                using(StreamReader __tmp14Reader = new StreamReader(this.__ToStream(__tmp14.ToString())))
                {
                    bool __tmp14_first = true;
                    bool __tmp14_last = __tmp14Reader.EndOfStream;
                    while(__tmp14_first || !__tmp14_last)
                    {
                        __tmp14_first = false;
                        string __tmp14Line = __tmp14Reader.ReadLine();
                        __tmp14_last = __tmp14Reader.EndOfStream;
                        __out.Append(__tmp13Prefix);
                        if (__tmp14Line != null) __out.Append(__tmp14Line);
                        if (!__tmp14_last) __out.AppendLine(true);
                        __out.AppendLine(false); //135:62
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
                string __tmp1Prefix = string.Empty;
                string __tmp2Line = "<xs:attribute name=\""; //141:1
                __out.Append(__tmp1Prefix);
                if (__tmp2Line != null) __out.Append(__tmp2Line);
                StringBuilder __tmp3 = new StringBuilder();
                __tmp3.Append(name);
                using(StreamReader __tmp3Reader = new StreamReader(this.__ToStream(__tmp3.ToString())))
                {
                    bool __tmp3_first = true;
                    bool __tmp3_last = __tmp3Reader.EndOfStream;
                    while(__tmp3_first || !__tmp3_last)
                    {
                        __tmp3_first = false;
                        string __tmp3Line = __tmp3Reader.ReadLine();
                        __tmp3_last = __tmp3Reader.EndOfStream;
                        if (__tmp3Line != null) __out.Append(__tmp3Line);
                        if (!__tmp3_last) __out.AppendLine(true);
                    }
                }
                string __tmp4Line = "\" type=\""; //141:27
                if (__tmp4Line != null) __out.Append(__tmp4Line);
                StringBuilder __tmp5 = new StringBuilder();
                __tmp5.Append(t.GetCoreType().GetNamespace(ns).Prefix);
                using(StreamReader __tmp5Reader = new StreamReader(this.__ToStream(__tmp5.ToString())))
                {
                    bool __tmp5_first = true;
                    bool __tmp5_last = __tmp5Reader.EndOfStream;
                    while(__tmp5_first || !__tmp5_last)
                    {
                        __tmp5_first = false;
                        string __tmp5Line = __tmp5Reader.ReadLine();
                        __tmp5_last = __tmp5Reader.EndOfStream;
                        if (__tmp5Line != null) __out.Append(__tmp5Line);
                        if (!__tmp5_last) __out.AppendLine(true);
                    }
                }
                string __tmp6Line = ":"; //141:76
                if (__tmp6Line != null) __out.Append(__tmp6Line);
                StringBuilder __tmp7 = new StringBuilder();
                __tmp7.Append(t.GetCoreType().GetXsdName());
                using(StreamReader __tmp7Reader = new StreamReader(this.__ToStream(__tmp7.ToString())))
                {
                    bool __tmp7_first = true;
                    bool __tmp7_last = __tmp7Reader.EndOfStream;
                    while(__tmp7_first || !__tmp7_last)
                    {
                        __tmp7_first = false;
                        string __tmp7Line = __tmp7Reader.ReadLine();
                        __tmp7_last = __tmp7Reader.EndOfStream;
                        if (__tmp7Line != null) __out.Append(__tmp7Line);
                        if (!__tmp7_last) __out.AppendLine(true);
                    }
                }
                string __tmp8Line = "\""; //141:107
                if (__tmp8Line != null) __out.Append(__tmp8Line);
                StringBuilder __tmp9 = new StringBuilder();
                __tmp9.Append(GetAttributeRequired(annots));
                using(StreamReader __tmp9Reader = new StreamReader(this.__ToStream(__tmp9.ToString())))
                {
                    bool __tmp9_first = true;
                    bool __tmp9_last = __tmp9Reader.EndOfStream;
                    while(__tmp9_first || !__tmp9_last)
                    {
                        __tmp9_first = false;
                        string __tmp9Line = __tmp9Reader.ReadLine();
                        __tmp9_last = __tmp9Reader.EndOfStream;
                        if (__tmp9Line != null) __out.Append(__tmp9Line);
                        if (!__tmp9_last) __out.AppendLine(true);
                    }
                }
                string __tmp10Line = "/>"; //141:138
                if (__tmp10Line != null) __out.Append(__tmp10Line);
                __out.AppendLine(false); //141:140
            }
            else //142:2
            {
                if (t.IsArrayType()) //143:3
                {
                    object wrapped = annots.GetAnnotationPropertyValue(SoalAnnotations.Element, SoalAnnotationProperties.Wrapped); //144:4
                    if (wrapped != null && (bool)wrapped) //145:4
                    {
                        object sap = annots.GetAnnotationPropertyValue(SoalAnnotations.Element, SoalAnnotationProperties.Sap); //146:5
                        if (sap != null && (bool)sap) //147:5
                        {
                            string __tmp11Prefix = string.Empty;
                            string __tmp12Line = "<xs:element name=\""; //148:1
                            __out.Append(__tmp11Prefix);
                            if (__tmp12Line != null) __out.Append(__tmp12Line);
                            StringBuilder __tmp13 = new StringBuilder();
                            __tmp13.Append(name);
                            using(StreamReader __tmp13Reader = new StreamReader(this.__ToStream(__tmp13.ToString())))
                            {
                                bool __tmp13_first = true;
                                bool __tmp13_last = __tmp13Reader.EndOfStream;
                                while(__tmp13_first || !__tmp13_last)
                                {
                                    __tmp13_first = false;
                                    string __tmp13Line = __tmp13Reader.ReadLine();
                                    __tmp13_last = __tmp13Reader.EndOfStream;
                                    if (__tmp13Line != null) __out.Append(__tmp13Line);
                                    if (!__tmp13_last) __out.AppendLine(true);
                                }
                            }
                            string __tmp14Line = "\" nillable=\""; //148:25
                            if (__tmp14Line != null) __out.Append(__tmp14Line);
                            StringBuilder __tmp15 = new StringBuilder();
                            __tmp15.Append(t.IsNullableXsd());
                            using(StreamReader __tmp15Reader = new StreamReader(this.__ToStream(__tmp15.ToString())))
                            {
                                bool __tmp15_first = true;
                                bool __tmp15_last = __tmp15Reader.EndOfStream;
                                while(__tmp15_first || !__tmp15_last)
                                {
                                    __tmp15_first = false;
                                    string __tmp15Line = __tmp15Reader.ReadLine();
                                    __tmp15_last = __tmp15Reader.EndOfStream;
                                    if (__tmp15Line != null) __out.Append(__tmp15Line);
                                    if (!__tmp15_last) __out.AppendLine(true);
                                }
                            }
                            string __tmp16Line = "\">"; //148:56
                            if (__tmp16Line != null) __out.Append(__tmp16Line);
                            __out.AppendLine(false); //148:58
                            __out.Append("	<xs:complexType>"); //149:1
                            __out.AppendLine(false); //149:18
                            __out.Append("		<xs:all>"); //150:1
                            __out.AppendLine(false); //150:11
                            __out.Append("			<xs:element name=\"item\" minOccurs=\"0\" maxOccurs=\"unbounded\">"); //151:1
                            __out.AppendLine(false); //151:64
                            __out.Append("				<xs:complexType>"); //152:1
                            __out.AppendLine(false); //152:21
                            __out.Append("					<xs:all>"); //153:1
                            __out.AppendLine(false); //153:14
                            if (t is ArrayType) //154:6
                            {
                                string __tmp17Prefix = string.Empty;
                                string __tmp18Line = "						<xs:element name=\""; //155:1
                                __out.Append(__tmp17Prefix);
                                if (__tmp18Line != null) __out.Append(__tmp18Line);
                                StringBuilder __tmp19 = new StringBuilder();
                                __tmp19.Append(((ArrayType)t).InnerType.GetXsdName());
                                using(StreamReader __tmp19Reader = new StreamReader(this.__ToStream(__tmp19.ToString())))
                                {
                                    bool __tmp19_first = true;
                                    bool __tmp19_last = __tmp19Reader.EndOfStream;
                                    while(__tmp19_first || !__tmp19_last)
                                    {
                                        __tmp19_first = false;
                                        string __tmp19Line = __tmp19Reader.ReadLine();
                                        __tmp19_last = __tmp19Reader.EndOfStream;
                                        if (__tmp19Line != null) __out.Append(__tmp19Line);
                                        if (!__tmp19_last) __out.AppendLine(true);
                                    }
                                }
                                string __tmp20Line = "\" type=\""; //155:64
                                if (__tmp20Line != null) __out.Append(__tmp20Line);
                                StringBuilder __tmp21 = new StringBuilder();
                                __tmp21.Append(((ArrayType)t).InnerType.GetNamespace(ns).Prefix);
                                using(StreamReader __tmp21Reader = new StreamReader(this.__ToStream(__tmp21.ToString())))
                                {
                                    bool __tmp21_first = true;
                                    bool __tmp21_last = __tmp21Reader.EndOfStream;
                                    while(__tmp21_first || !__tmp21_last)
                                    {
                                        __tmp21_first = false;
                                        string __tmp21Line = __tmp21Reader.ReadLine();
                                        __tmp21_last = __tmp21Reader.EndOfStream;
                                        if (__tmp21Line != null) __out.Append(__tmp21Line);
                                        if (!__tmp21_last) __out.AppendLine(true);
                                    }
                                }
                                string __tmp22Line = ":"; //155:122
                                if (__tmp22Line != null) __out.Append(__tmp22Line);
                                StringBuilder __tmp23 = new StringBuilder();
                                __tmp23.Append(((ArrayType)t).InnerType.GetXsdName());
                                using(StreamReader __tmp23Reader = new StreamReader(this.__ToStream(__tmp23.ToString())))
                                {
                                    bool __tmp23_first = true;
                                    bool __tmp23_last = __tmp23Reader.EndOfStream;
                                    while(__tmp23_first || !__tmp23_last)
                                    {
                                        __tmp23_first = false;
                                        string __tmp23Line = __tmp23Reader.ReadLine();
                                        __tmp23_last = __tmp23Reader.EndOfStream;
                                        if (__tmp23Line != null) __out.Append(__tmp23Line);
                                        if (!__tmp23_last) __out.AppendLine(true);
                                    }
                                }
                                string __tmp24Line = "\" nillable=\""; //155:162
                                if (__tmp24Line != null) __out.Append(__tmp24Line);
                                StringBuilder __tmp25 = new StringBuilder();
                                __tmp25.Append(((ArrayType)t).InnerType.IsNullableXsd());
                                using(StreamReader __tmp25Reader = new StreamReader(this.__ToStream(__tmp25.ToString())))
                                {
                                    bool __tmp25_first = true;
                                    bool __tmp25_last = __tmp25Reader.EndOfStream;
                                    while(__tmp25_first || !__tmp25_last)
                                    {
                                        __tmp25_first = false;
                                        string __tmp25Line = __tmp25Reader.ReadLine();
                                        __tmp25_last = __tmp25Reader.EndOfStream;
                                        if (__tmp25Line != null) __out.Append(__tmp25Line);
                                        if (!__tmp25_last) __out.AppendLine(true);
                                    }
                                }
                                string __tmp26Line = "\"/>"; //155:216
                                if (__tmp26Line != null) __out.Append(__tmp26Line);
                                __out.AppendLine(false); //155:219
                            }
                            else //156:6
                            {
                                string __tmp27Prefix = string.Empty;
                                string __tmp28Line = "						<xs:element name=\""; //157:1
                                __out.Append(__tmp27Prefix);
                                if (__tmp28Line != null) __out.Append(__tmp28Line);
                                StringBuilder __tmp29 = new StringBuilder();
                                __tmp29.Append(((ArrayType)((NonNullableType)t).InnerType).InnerType.GetXsdName());
                                using(StreamReader __tmp29Reader = new StreamReader(this.__ToStream(__tmp29.ToString())))
                                {
                                    bool __tmp29_first = true;
                                    bool __tmp29_last = __tmp29Reader.EndOfStream;
                                    while(__tmp29_first || !__tmp29_last)
                                    {
                                        __tmp29_first = false;
                                        string __tmp29Line = __tmp29Reader.ReadLine();
                                        __tmp29_last = __tmp29Reader.EndOfStream;
                                        if (__tmp29Line != null) __out.Append(__tmp29Line);
                                        if (!__tmp29_last) __out.AppendLine(true);
                                    }
                                }
                                string __tmp30Line = "\" type=\""; //157:93
                                if (__tmp30Line != null) __out.Append(__tmp30Line);
                                StringBuilder __tmp31 = new StringBuilder();
                                __tmp31.Append(((ArrayType)((NonNullableType)t).InnerType).InnerType.GetNamespace(ns).Prefix);
                                using(StreamReader __tmp31Reader = new StreamReader(this.__ToStream(__tmp31.ToString())))
                                {
                                    bool __tmp31_first = true;
                                    bool __tmp31_last = __tmp31Reader.EndOfStream;
                                    while(__tmp31_first || !__tmp31_last)
                                    {
                                        __tmp31_first = false;
                                        string __tmp31Line = __tmp31Reader.ReadLine();
                                        __tmp31_last = __tmp31Reader.EndOfStream;
                                        if (__tmp31Line != null) __out.Append(__tmp31Line);
                                        if (!__tmp31_last) __out.AppendLine(true);
                                    }
                                }
                                string __tmp32Line = ":"; //157:180
                                if (__tmp32Line != null) __out.Append(__tmp32Line);
                                StringBuilder __tmp33 = new StringBuilder();
                                __tmp33.Append(((ArrayType)((NonNullableType)t).InnerType).InnerType.GetXsdName());
                                using(StreamReader __tmp33Reader = new StreamReader(this.__ToStream(__tmp33.ToString())))
                                {
                                    bool __tmp33_first = true;
                                    bool __tmp33_last = __tmp33Reader.EndOfStream;
                                    while(__tmp33_first || !__tmp33_last)
                                    {
                                        __tmp33_first = false;
                                        string __tmp33Line = __tmp33Reader.ReadLine();
                                        __tmp33_last = __tmp33Reader.EndOfStream;
                                        if (__tmp33Line != null) __out.Append(__tmp33Line);
                                        if (!__tmp33_last) __out.AppendLine(true);
                                    }
                                }
                                string __tmp34Line = "\" nillable=\""; //157:249
                                if (__tmp34Line != null) __out.Append(__tmp34Line);
                                StringBuilder __tmp35 = new StringBuilder();
                                __tmp35.Append(((ArrayType)((NonNullableType)t).InnerType).InnerType.IsNullableXsd());
                                using(StreamReader __tmp35Reader = new StreamReader(this.__ToStream(__tmp35.ToString())))
                                {
                                    bool __tmp35_first = true;
                                    bool __tmp35_last = __tmp35Reader.EndOfStream;
                                    while(__tmp35_first || !__tmp35_last)
                                    {
                                        __tmp35_first = false;
                                        string __tmp35Line = __tmp35Reader.ReadLine();
                                        __tmp35_last = __tmp35Reader.EndOfStream;
                                        if (__tmp35Line != null) __out.Append(__tmp35Line);
                                        if (!__tmp35_last) __out.AppendLine(true);
                                    }
                                }
                                string __tmp36Line = "\"/>"; //157:332
                                if (__tmp36Line != null) __out.Append(__tmp36Line);
                                __out.AppendLine(false); //157:335
                            }
                            __out.Append("					</xs:all>"); //159:1
                            __out.AppendLine(false); //159:15
                            __out.Append("				</xs:complexType>"); //160:1
                            __out.AppendLine(false); //160:22
                            __out.Append("			</xs:element>"); //161:1
                            __out.AppendLine(false); //161:17
                            __out.Append("		</xs:all>"); //162:1
                            __out.AppendLine(false); //162:12
                            __out.Append("	</xs:complexType>"); //163:1
                            __out.AppendLine(false); //163:19
                            __out.Append("</xs:element>"); //164:1
                            __out.AppendLine(false); //164:14
                        }
                        else //165:5
                        {
                            string __tmp37Prefix = string.Empty;
                            string __tmp38Line = "<xs:element name=\""; //166:1
                            __out.Append(__tmp37Prefix);
                            if (__tmp38Line != null) __out.Append(__tmp38Line);
                            StringBuilder __tmp39 = new StringBuilder();
                            __tmp39.Append(name);
                            using(StreamReader __tmp39Reader = new StreamReader(this.__ToStream(__tmp39.ToString())))
                            {
                                bool __tmp39_first = true;
                                bool __tmp39_last = __tmp39Reader.EndOfStream;
                                while(__tmp39_first || !__tmp39_last)
                                {
                                    __tmp39_first = false;
                                    string __tmp39Line = __tmp39Reader.ReadLine();
                                    __tmp39_last = __tmp39Reader.EndOfStream;
                                    if (__tmp39Line != null) __out.Append(__tmp39Line);
                                    if (!__tmp39_last) __out.AppendLine(true);
                                }
                            }
                            string __tmp40Line = "\" type=\""; //166:25
                            if (__tmp40Line != null) __out.Append(__tmp40Line);
                            StringBuilder __tmp41 = new StringBuilder();
                            __tmp41.Append(t.GetNamespace(ns).Prefix);
                            using(StreamReader __tmp41Reader = new StreamReader(this.__ToStream(__tmp41.ToString())))
                            {
                                bool __tmp41_first = true;
                                bool __tmp41_last = __tmp41Reader.EndOfStream;
                                while(__tmp41_first || !__tmp41_last)
                                {
                                    __tmp41_first = false;
                                    string __tmp41Line = __tmp41Reader.ReadLine();
                                    __tmp41_last = __tmp41Reader.EndOfStream;
                                    if (__tmp41Line != null) __out.Append(__tmp41Line);
                                    if (!__tmp41_last) __out.AppendLine(true);
                                }
                            }
                            string __tmp42Line = ":"; //166:60
                            if (__tmp42Line != null) __out.Append(__tmp42Line);
                            StringBuilder __tmp43 = new StringBuilder();
                            __tmp43.Append(t.GetXsdName());
                            using(StreamReader __tmp43Reader = new StreamReader(this.__ToStream(__tmp43.ToString())))
                            {
                                bool __tmp43_first = true;
                                bool __tmp43_last = __tmp43Reader.EndOfStream;
                                while(__tmp43_first || !__tmp43_last)
                                {
                                    __tmp43_first = false;
                                    string __tmp43Line = __tmp43Reader.ReadLine();
                                    __tmp43_last = __tmp43Reader.EndOfStream;
                                    if (__tmp43Line != null) __out.Append(__tmp43Line);
                                    if (!__tmp43_last) __out.AppendLine(true);
                                }
                            }
                            string __tmp44Line = "\" nillable=\""; //166:77
                            if (__tmp44Line != null) __out.Append(__tmp44Line);
                            StringBuilder __tmp45 = new StringBuilder();
                            __tmp45.Append(t.IsNullableXsd());
                            using(StreamReader __tmp45Reader = new StreamReader(this.__ToStream(__tmp45.ToString())))
                            {
                                bool __tmp45_first = true;
                                bool __tmp45_last = __tmp45Reader.EndOfStream;
                                while(__tmp45_first || !__tmp45_last)
                                {
                                    __tmp45_first = false;
                                    string __tmp45Line = __tmp45Reader.ReadLine();
                                    __tmp45_last = __tmp45Reader.EndOfStream;
                                    if (__tmp45Line != null) __out.Append(__tmp45Line);
                                    if (!__tmp45_last) __out.AppendLine(true);
                                }
                            }
                            string __tmp46Line = "\""; //166:108
                            if (__tmp46Line != null) __out.Append(__tmp46Line);
                            StringBuilder __tmp47 = new StringBuilder();
                            __tmp47.Append(GetElementOptional(annots));
                            using(StreamReader __tmp47Reader = new StreamReader(this.__ToStream(__tmp47.ToString())))
                            {
                                bool __tmp47_first = true;
                                bool __tmp47_last = __tmp47Reader.EndOfStream;
                                while(__tmp47_first || !__tmp47_last)
                                {
                                    __tmp47_first = false;
                                    string __tmp47Line = __tmp47Reader.ReadLine();
                                    __tmp47_last = __tmp47Reader.EndOfStream;
                                    if (__tmp47Line != null) __out.Append(__tmp47Line);
                                    if (!__tmp47_last) __out.AppendLine(true);
                                }
                            }
                            string __tmp48Line = "/>"; //166:137
                            if (__tmp48Line != null) __out.Append(__tmp48Line);
                            __out.AppendLine(false); //166:139
                        }
                    }
                    else //168:4
                    {
                        if (t is ArrayType) //169:5
                        {
                            string __tmp49Prefix = string.Empty;
                            string __tmp50Line = "<xs:element name=\""; //170:1
                            __out.Append(__tmp49Prefix);
                            if (__tmp50Line != null) __out.Append(__tmp50Line);
                            StringBuilder __tmp51 = new StringBuilder();
                            __tmp51.Append(name);
                            using(StreamReader __tmp51Reader = new StreamReader(this.__ToStream(__tmp51.ToString())))
                            {
                                bool __tmp51_first = true;
                                bool __tmp51_last = __tmp51Reader.EndOfStream;
                                while(__tmp51_first || !__tmp51_last)
                                {
                                    __tmp51_first = false;
                                    string __tmp51Line = __tmp51Reader.ReadLine();
                                    __tmp51_last = __tmp51Reader.EndOfStream;
                                    if (__tmp51Line != null) __out.Append(__tmp51Line);
                                    if (!__tmp51_last) __out.AppendLine(true);
                                }
                            }
                            string __tmp52Line = "\" type=\""; //170:25
                            if (__tmp52Line != null) __out.Append(__tmp52Line);
                            StringBuilder __tmp53 = new StringBuilder();
                            __tmp53.Append(((ArrayType)t).InnerType.GetNamespace(ns).Prefix);
                            using(StreamReader __tmp53Reader = new StreamReader(this.__ToStream(__tmp53.ToString())))
                            {
                                bool __tmp53_first = true;
                                bool __tmp53_last = __tmp53Reader.EndOfStream;
                                while(__tmp53_first || !__tmp53_last)
                                {
                                    __tmp53_first = false;
                                    string __tmp53Line = __tmp53Reader.ReadLine();
                                    __tmp53_last = __tmp53Reader.EndOfStream;
                                    if (__tmp53Line != null) __out.Append(__tmp53Line);
                                    if (!__tmp53_last) __out.AppendLine(true);
                                }
                            }
                            string __tmp54Line = ":"; //170:83
                            if (__tmp54Line != null) __out.Append(__tmp54Line);
                            StringBuilder __tmp55 = new StringBuilder();
                            __tmp55.Append(((ArrayType)t).InnerType.GetXsdName());
                            using(StreamReader __tmp55Reader = new StreamReader(this.__ToStream(__tmp55.ToString())))
                            {
                                bool __tmp55_first = true;
                                bool __tmp55_last = __tmp55Reader.EndOfStream;
                                while(__tmp55_first || !__tmp55_last)
                                {
                                    __tmp55_first = false;
                                    string __tmp55Line = __tmp55Reader.ReadLine();
                                    __tmp55_last = __tmp55Reader.EndOfStream;
                                    if (__tmp55Line != null) __out.Append(__tmp55Line);
                                    if (!__tmp55_last) __out.AppendLine(true);
                                }
                            }
                            string __tmp56Line = "\" nillable=\""; //170:123
                            if (__tmp56Line != null) __out.Append(__tmp56Line);
                            StringBuilder __tmp57 = new StringBuilder();
                            __tmp57.Append(((ArrayType)t).InnerType.IsNullableXsd());
                            using(StreamReader __tmp57Reader = new StreamReader(this.__ToStream(__tmp57.ToString())))
                            {
                                bool __tmp57_first = true;
                                bool __tmp57_last = __tmp57Reader.EndOfStream;
                                while(__tmp57_first || !__tmp57_last)
                                {
                                    __tmp57_first = false;
                                    string __tmp57Line = __tmp57Reader.ReadLine();
                                    __tmp57_last = __tmp57Reader.EndOfStream;
                                    if (__tmp57Line != null) __out.Append(__tmp57Line);
                                    if (!__tmp57_last) __out.AppendLine(true);
                                }
                            }
                            string __tmp58Line = "\" minOccurs=\"0\" maxOccurs=\"unbounded\"/>"; //170:177
                            if (__tmp58Line != null) __out.Append(__tmp58Line);
                            __out.AppendLine(false); //170:216
                        }
                        else //171:5
                        {
                            string __tmp59Prefix = string.Empty;
                            string __tmp60Line = "<xs:element name=\""; //172:1
                            __out.Append(__tmp59Prefix);
                            if (__tmp60Line != null) __out.Append(__tmp60Line);
                            StringBuilder __tmp61 = new StringBuilder();
                            __tmp61.Append(name);
                            using(StreamReader __tmp61Reader = new StreamReader(this.__ToStream(__tmp61.ToString())))
                            {
                                bool __tmp61_first = true;
                                bool __tmp61_last = __tmp61Reader.EndOfStream;
                                while(__tmp61_first || !__tmp61_last)
                                {
                                    __tmp61_first = false;
                                    string __tmp61Line = __tmp61Reader.ReadLine();
                                    __tmp61_last = __tmp61Reader.EndOfStream;
                                    if (__tmp61Line != null) __out.Append(__tmp61Line);
                                    if (!__tmp61_last) __out.AppendLine(true);
                                }
                            }
                            string __tmp62Line = "\" type=\""; //172:25
                            if (__tmp62Line != null) __out.Append(__tmp62Line);
                            StringBuilder __tmp63 = new StringBuilder();
                            __tmp63.Append(((ArrayType)((NonNullableType)t).InnerType).InnerType.GetNamespace(ns).Prefix);
                            using(StreamReader __tmp63Reader = new StreamReader(this.__ToStream(__tmp63.ToString())))
                            {
                                bool __tmp63_first = true;
                                bool __tmp63_last = __tmp63Reader.EndOfStream;
                                while(__tmp63_first || !__tmp63_last)
                                {
                                    __tmp63_first = false;
                                    string __tmp63Line = __tmp63Reader.ReadLine();
                                    __tmp63_last = __tmp63Reader.EndOfStream;
                                    if (__tmp63Line != null) __out.Append(__tmp63Line);
                                    if (!__tmp63_last) __out.AppendLine(true);
                                }
                            }
                            string __tmp64Line = ":"; //172:112
                            if (__tmp64Line != null) __out.Append(__tmp64Line);
                            StringBuilder __tmp65 = new StringBuilder();
                            __tmp65.Append(((ArrayType)((NonNullableType)t).InnerType).InnerType.GetXsdName());
                            using(StreamReader __tmp65Reader = new StreamReader(this.__ToStream(__tmp65.ToString())))
                            {
                                bool __tmp65_first = true;
                                bool __tmp65_last = __tmp65Reader.EndOfStream;
                                while(__tmp65_first || !__tmp65_last)
                                {
                                    __tmp65_first = false;
                                    string __tmp65Line = __tmp65Reader.ReadLine();
                                    __tmp65_last = __tmp65Reader.EndOfStream;
                                    if (__tmp65Line != null) __out.Append(__tmp65Line);
                                    if (!__tmp65_last) __out.AppendLine(true);
                                }
                            }
                            string __tmp66Line = "\" nillable=\""; //172:181
                            if (__tmp66Line != null) __out.Append(__tmp66Line);
                            StringBuilder __tmp67 = new StringBuilder();
                            __tmp67.Append(((ArrayType)((NonNullableType)t).InnerType).InnerType.IsNullableXsd());
                            using(StreamReader __tmp67Reader = new StreamReader(this.__ToStream(__tmp67.ToString())))
                            {
                                bool __tmp67_first = true;
                                bool __tmp67_last = __tmp67Reader.EndOfStream;
                                while(__tmp67_first || !__tmp67_last)
                                {
                                    __tmp67_first = false;
                                    string __tmp67Line = __tmp67Reader.ReadLine();
                                    __tmp67_last = __tmp67Reader.EndOfStream;
                                    if (__tmp67Line != null) __out.Append(__tmp67Line);
                                    if (!__tmp67_last) __out.AppendLine(true);
                                }
                            }
                            string __tmp68Line = "\" minOccurs=\"0\" maxOccurs=\"unbounded\"/>"; //172:264
                            if (__tmp68Line != null) __out.Append(__tmp68Line);
                            __out.AppendLine(false); //172:303
                        }
                    }
                }
                else //175:3
                {
                    string __tmp69Prefix = string.Empty;
                    string __tmp70Line = "<xs:element name=\""; //176:1
                    __out.Append(__tmp69Prefix);
                    if (__tmp70Line != null) __out.Append(__tmp70Line);
                    StringBuilder __tmp71 = new StringBuilder();
                    __tmp71.Append(name);
                    using(StreamReader __tmp71Reader = new StreamReader(this.__ToStream(__tmp71.ToString())))
                    {
                        bool __tmp71_first = true;
                        bool __tmp71_last = __tmp71Reader.EndOfStream;
                        while(__tmp71_first || !__tmp71_last)
                        {
                            __tmp71_first = false;
                            string __tmp71Line = __tmp71Reader.ReadLine();
                            __tmp71_last = __tmp71Reader.EndOfStream;
                            if (__tmp71Line != null) __out.Append(__tmp71Line);
                            if (!__tmp71_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp72Line = "\" type=\""; //176:25
                    if (__tmp72Line != null) __out.Append(__tmp72Line);
                    StringBuilder __tmp73 = new StringBuilder();
                    __tmp73.Append(t.GetNamespace(ns).Prefix);
                    using(StreamReader __tmp73Reader = new StreamReader(this.__ToStream(__tmp73.ToString())))
                    {
                        bool __tmp73_first = true;
                        bool __tmp73_last = __tmp73Reader.EndOfStream;
                        while(__tmp73_first || !__tmp73_last)
                        {
                            __tmp73_first = false;
                            string __tmp73Line = __tmp73Reader.ReadLine();
                            __tmp73_last = __tmp73Reader.EndOfStream;
                            if (__tmp73Line != null) __out.Append(__tmp73Line);
                            if (!__tmp73_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp74Line = ":"; //176:60
                    if (__tmp74Line != null) __out.Append(__tmp74Line);
                    StringBuilder __tmp75 = new StringBuilder();
                    __tmp75.Append(t.GetXsdName());
                    using(StreamReader __tmp75Reader = new StreamReader(this.__ToStream(__tmp75.ToString())))
                    {
                        bool __tmp75_first = true;
                        bool __tmp75_last = __tmp75Reader.EndOfStream;
                        while(__tmp75_first || !__tmp75_last)
                        {
                            __tmp75_first = false;
                            string __tmp75Line = __tmp75Reader.ReadLine();
                            __tmp75_last = __tmp75Reader.EndOfStream;
                            if (__tmp75Line != null) __out.Append(__tmp75Line);
                            if (!__tmp75_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp76Line = "\" nillable=\""; //176:77
                    if (__tmp76Line != null) __out.Append(__tmp76Line);
                    StringBuilder __tmp77 = new StringBuilder();
                    __tmp77.Append(t.IsNullableXsd());
                    using(StreamReader __tmp77Reader = new StreamReader(this.__ToStream(__tmp77.ToString())))
                    {
                        bool __tmp77_first = true;
                        bool __tmp77_last = __tmp77Reader.EndOfStream;
                        while(__tmp77_first || !__tmp77_last)
                        {
                            __tmp77_first = false;
                            string __tmp77Line = __tmp77Reader.ReadLine();
                            __tmp77_last = __tmp77Reader.EndOfStream;
                            if (__tmp77Line != null) __out.Append(__tmp77Line);
                            if (!__tmp77_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp78Line = "\""; //176:108
                    if (__tmp78Line != null) __out.Append(__tmp78Line);
                    StringBuilder __tmp79 = new StringBuilder();
                    __tmp79.Append(GetElementOptional(annots));
                    using(StreamReader __tmp79Reader = new StreamReader(this.__ToStream(__tmp79.ToString())))
                    {
                        bool __tmp79_first = true;
                        bool __tmp79_last = __tmp79Reader.EndOfStream;
                        while(__tmp79_first || !__tmp79_last)
                        {
                            __tmp79_first = false;
                            string __tmp79Line = __tmp79Reader.ReadLine();
                            __tmp79_last = __tmp79Reader.EndOfStream;
                            if (__tmp79Line != null) __out.Append(__tmp79Line);
                            if (!__tmp79_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp80Line = "/>"; //176:137
                    if (__tmp80Line != null) __out.Append(__tmp80Line);
                    __out.AppendLine(false); //176:139
                }
            }
            return __out.ToString();
        }

        public string GetStructKind(StructuredType st) //181:1
        {
            if (st.HasAnnotation(SoalAnnotations.Choice)) //182:2
            {
                return "choice"; //183:3
            }
            else if (st.HasAnnotation(SoalAnnotations.All)) //184:2
            {
                return "all"; //185:3
            }
            else //186:2
            {
                return "sequence"; //187:3
            }
        }

        public string GetElementOptional(IList<Annotation> annots) //191:1
        {
            object optional = annots.GetAnnotationPropertyValue(SoalAnnotations.Element, SoalAnnotationProperties.Optional); //192:2
            if (optional != null && (bool)optional) //193:2
            {
                return " minOccurs=\"0\""; //194:3
            }
            else //195:2
            {
                return ""; //196:3
            }
        }

        public string GetAttributeRequired(IList<Annotation> annots) //200:1
        {
            object required = annots.GetAnnotationPropertyValue(SoalAnnotations.Attribute, SoalAnnotationProperties.Required); //201:2
            if (required != null && (bool)required) //202:2
            {
                return " use=\"required\""; //203:3
            }
            else //204:2
            {
                return ""; //205:3
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
