using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Soal //1:1
{
    using __Hidden_XsdGenerator_754591631;
    namespace __Hidden_XsdGenerator_754591631
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
            string __tmp2Line = "<xs:schema targetNamespace=\""; //10:1
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
            string __tmp6Line = "		xmlns:"; //12:1
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
                    string __tmp13Line = "		xmlns:"; //15:1
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
                    string __tmp20Line = "	<xs:import namespace=\""; //21:1
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
                (from __loop3_var1 in __Enumerate((ns.Declarations).GetEnumerator()) //24:8
                from etype in __Enumerate((__loop3_var1).GetEnumerator()).OfType<Enum>() //24:25
                select new { __loop3_var1 = __loop3_var1, etype = etype}
                ).ToList(); //24:3
            int __loop3_iteration = 0;
            foreach (var __tmp25 in __loop3_results)
            {
                ++__loop3_iteration;
                var __loop3_var1 = __tmp25.__loop3_var1;
                var etype = __tmp25.etype;
                __out.AppendLine(true); //25:1
                string __tmp27Line = "	<xs:element name=\""; //26:1
                if (__tmp27Line != null) __out.Append(__tmp27Line);
                StringBuilder __tmp28 = new StringBuilder();
                __tmp28.Append(etype.GetXsdName());
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
                string __tmp29Line = "\" type=\""; //26:40
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
                string __tmp31Line = ":"; //26:59
                if (__tmp31Line != null) __out.Append(__tmp31Line);
                StringBuilder __tmp32 = new StringBuilder();
                __tmp32.Append(etype.GetXsdName());
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
                string __tmp33Line = "\"/>"; //26:80
                if (__tmp33Line != null) __out.Append(__tmp33Line);
                __out.AppendLine(false); //26:83
                string __tmp35Line = "	<xs:simpleType name=\""; //27:1
                if (__tmp35Line != null) __out.Append(__tmp35Line);
                StringBuilder __tmp36 = new StringBuilder();
                __tmp36.Append(etype.GetXsdName());
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
                string __tmp37Line = "\">"; //27:43
                if (__tmp37Line != null) __out.Append(__tmp37Line);
                __out.AppendLine(false); //27:45
                if (etype.BaseType != null) //28:4
                {
                    string __tmp39Line = "		<xs:restriction base=\""; //29:1
                    if (__tmp39Line != null) __out.Append(__tmp39Line);
                    StringBuilder __tmp40 = new StringBuilder();
                    __tmp40.Append(etype.BaseType.GetNamespace(ns).Prefix);
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
                    string __tmp41Line = ":"; //29:65
                    if (__tmp41Line != null) __out.Append(__tmp41Line);
                    StringBuilder __tmp42 = new StringBuilder();
                    __tmp42.Append(etype.BaseType.GetXsdName());
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
                    string __tmp43Line = "\">"; //29:95
                    if (__tmp43Line != null) __out.Append(__tmp43Line);
                    __out.AppendLine(false); //29:97
                }
                else //30:4
                {
                    __out.Append("		<xs:restriction base=\"xs:string\">"); //31:1
                    __out.AppendLine(false); //31:36
                }
                var __loop4_results = 
                    (from __loop4_var1 in __Enumerate((etype).GetEnumerator()) //33:10
                    from elit in __Enumerate((__loop4_var1.EnumLiterals).GetEnumerator()) //33:17
                    select new { __loop4_var1 = __loop4_var1, elit = elit}
                    ).ToList(); //33:5
                int __loop4_iteration = 0;
                foreach (var __tmp44 in __loop4_results)
                {
                    ++__loop4_iteration;
                    var __loop4_var1 = __tmp44.__loop4_var1;
                    var elit = __tmp44.elit;
                    if (elit.HasAnnotationProperty(SoalAnnotations.Enum, SoalAnnotationProperties.Name)) //34:6
                    {
                        string __tmp46Line = "			<xs:enumeration value=\""; //35:1
                        if (__tmp46Line != null) __out.Append(__tmp46Line);
                        StringBuilder __tmp47 = new StringBuilder();
                        __tmp47.Append(elit.GetAnnotationPropertyValue(SoalAnnotations.Enum, SoalAnnotationProperties.Name));
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
                        string __tmp48Line = "\"/>"; //35:113
                        if (__tmp48Line != null) __out.Append(__tmp48Line);
                        __out.AppendLine(false); //35:116
                    }
                    else //36:6
                    {
                        string __tmp50Line = "			<xs:enumeration value=\""; //37:1
                        if (__tmp50Line != null) __out.Append(__tmp50Line);
                        StringBuilder __tmp51 = new StringBuilder();
                        __tmp51.Append(elit.Name);
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
                        string __tmp52Line = "\"/>"; //37:38
                        if (__tmp52Line != null) __out.Append(__tmp52Line);
                        __out.AppendLine(false); //37:41
                    }
                }
                __out.Append("		</xs:restriction>"); //40:1
                __out.AppendLine(false); //40:20
                __out.Append("	</xs:simpleType>"); //41:1
                __out.AppendLine(false); //41:18
            }
            var __loop5_results = 
                (from __loop5_var1 in __Enumerate((ns.Declarations).GetEnumerator()) //43:8
                from stype in __Enumerate((__loop5_var1).GetEnumerator()).OfType<Struct>() //43:25
                select new { __loop5_var1 = __loop5_var1, stype = stype}
                ).ToList(); //43:3
            int __loop5_iteration = 0;
            foreach (var __tmp53 in __loop5_results)
            {
                ++__loop5_iteration;
                var __loop5_var1 = __tmp53.__loop5_var1;
                var stype = __tmp53.stype;
                __out.AppendLine(true); //44:1
                string __tmp55Line = "	<xs:element name=\""; //45:1
                if (__tmp55Line != null) __out.Append(__tmp55Line);
                StringBuilder __tmp56 = new StringBuilder();
                __tmp56.Append(stype.GetXsdName());
                using(StreamReader __tmp56Reader = new StreamReader(this.__ToStream(__tmp56.ToString())))
                {
                    bool __tmp56_first = true;
                    bool __tmp56_last = __tmp56Reader.EndOfStream;
                    while(__tmp56_first || !__tmp56_last)
                    {
                        __tmp56_first = false;
                        string __tmp56Line = __tmp56Reader.ReadLine();
                        __tmp56_last = __tmp56Reader.EndOfStream;
                        if (__tmp56Line != null) __out.Append(__tmp56Line);
                        if (!__tmp56_last) __out.AppendLine(true);
                    }
                }
                string __tmp57Line = "\" type=\""; //45:40
                if (__tmp57Line != null) __out.Append(__tmp57Line);
                StringBuilder __tmp58 = new StringBuilder();
                __tmp58.Append(ns.Prefix);
                using(StreamReader __tmp58Reader = new StreamReader(this.__ToStream(__tmp58.ToString())))
                {
                    bool __tmp58_first = true;
                    bool __tmp58_last = __tmp58Reader.EndOfStream;
                    while(__tmp58_first || !__tmp58_last)
                    {
                        __tmp58_first = false;
                        string __tmp58Line = __tmp58Reader.ReadLine();
                        __tmp58_last = __tmp58Reader.EndOfStream;
                        if (__tmp58Line != null) __out.Append(__tmp58Line);
                        if (!__tmp58_last) __out.AppendLine(true);
                    }
                }
                string __tmp59Line = ":"; //45:59
                if (__tmp59Line != null) __out.Append(__tmp59Line);
                StringBuilder __tmp60 = new StringBuilder();
                __tmp60.Append(stype.GetXsdName());
                using(StreamReader __tmp60Reader = new StreamReader(this.__ToStream(__tmp60.ToString())))
                {
                    bool __tmp60_first = true;
                    bool __tmp60_last = __tmp60Reader.EndOfStream;
                    while(__tmp60_first || !__tmp60_last)
                    {
                        __tmp60_first = false;
                        string __tmp60Line = __tmp60Reader.ReadLine();
                        __tmp60_last = __tmp60Reader.EndOfStream;
                        if (__tmp60Line != null) __out.Append(__tmp60Line);
                        if (!__tmp60_last) __out.AppendLine(true);
                    }
                }
                string __tmp61Line = "\"/>"; //45:80
                if (__tmp61Line != null) __out.Append(__tmp61Line);
                __out.AppendLine(false); //45:83
                string __tmp63Line = "	<xs:complexType name=\""; //46:1
                if (__tmp63Line != null) __out.Append(__tmp63Line);
                StringBuilder __tmp64 = new StringBuilder();
                __tmp64.Append(stype.GetXsdName());
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
                string __tmp65Line = "\">"; //46:44
                if (__tmp65Line != null) __out.Append(__tmp65Line);
                __out.AppendLine(false); //46:46
                if (stype.BaseType != null) //47:4
                {
                    __out.Append("		<xs:complexContent>"); //48:1
                    __out.AppendLine(false); //48:22
                    string __tmp67Line = "			<xs:extension base=\""; //49:1
                    if (__tmp67Line != null) __out.Append(__tmp67Line);
                    StringBuilder __tmp68 = new StringBuilder();
                    __tmp68.Append(stype.BaseType.GetNamespace(ns).Prefix);
                    using(StreamReader __tmp68Reader = new StreamReader(this.__ToStream(__tmp68.ToString())))
                    {
                        bool __tmp68_first = true;
                        bool __tmp68_last = __tmp68Reader.EndOfStream;
                        while(__tmp68_first || !__tmp68_last)
                        {
                            __tmp68_first = false;
                            string __tmp68Line = __tmp68Reader.ReadLine();
                            __tmp68_last = __tmp68Reader.EndOfStream;
                            if (__tmp68Line != null) __out.Append(__tmp68Line);
                            if (!__tmp68_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp69Line = ":"; //49:64
                    if (__tmp69Line != null) __out.Append(__tmp69Line);
                    StringBuilder __tmp70 = new StringBuilder();
                    __tmp70.Append(stype.BaseType.GetXsdName());
                    using(StreamReader __tmp70Reader = new StreamReader(this.__ToStream(__tmp70.ToString())))
                    {
                        bool __tmp70_first = true;
                        bool __tmp70_last = __tmp70Reader.EndOfStream;
                        while(__tmp70_first || !__tmp70_last)
                        {
                            __tmp70_first = false;
                            string __tmp70Line = __tmp70Reader.ReadLine();
                            __tmp70_last = __tmp70Reader.EndOfStream;
                            if (__tmp70Line != null) __out.Append(__tmp70Line);
                            if (!__tmp70_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp71Line = "\">"; //49:94
                    if (__tmp71Line != null) __out.Append(__tmp71Line);
                    __out.AppendLine(false); //49:96
                    string __tmp72Prefix = "				"; //50:1
                    StringBuilder __tmp73 = new StringBuilder();
                    __tmp73.Append(GenerateStructBody(ns, stype));
                    using(StreamReader __tmp73Reader = new StreamReader(this.__ToStream(__tmp73.ToString())))
                    {
                        bool __tmp73_first = true;
                        bool __tmp73_last = __tmp73Reader.EndOfStream;
                        while(__tmp73_first || !__tmp73_last)
                        {
                            __tmp73_first = false;
                            string __tmp73Line = __tmp73Reader.ReadLine();
                            __tmp73_last = __tmp73Reader.EndOfStream;
                            __out.Append(__tmp72Prefix);
                            if (__tmp73Line != null) __out.Append(__tmp73Line);
                            if (!__tmp73_last) __out.AppendLine(true);
                            __out.AppendLine(false); //50:36
                        }
                    }
                    __out.Append("			</xs:extension>"); //51:1
                    __out.AppendLine(false); //51:19
                    __out.Append("		</xs:complexContent>"); //52:1
                    __out.AppendLine(false); //52:23
                }
                else //53:4
                {
                    string __tmp74Prefix = "		"; //54:1
                    StringBuilder __tmp75 = new StringBuilder();
                    __tmp75.Append(GenerateStructBody(ns, stype));
                    using(StreamReader __tmp75Reader = new StreamReader(this.__ToStream(__tmp75.ToString())))
                    {
                        bool __tmp75_first = true;
                        bool __tmp75_last = __tmp75Reader.EndOfStream;
                        while(__tmp75_first || !__tmp75_last)
                        {
                            __tmp75_first = false;
                            string __tmp75Line = __tmp75Reader.ReadLine();
                            __tmp75_last = __tmp75Reader.EndOfStream;
                            __out.Append(__tmp74Prefix);
                            if (__tmp75Line != null) __out.Append(__tmp75Line);
                            if (!__tmp75_last) __out.AppendLine(true);
                            __out.AppendLine(false); //54:34
                        }
                    }
                }
                __out.Append("	</xs:complexType>"); //56:1
                __out.AppendLine(false); //56:19
            }
            var __loop6_results = 
                (from __loop6_var1 in __Enumerate((ns.Declarations).GetEnumerator()) //58:8
                from intf in __Enumerate((__loop6_var1).GetEnumerator()).OfType<Interface>() //58:25
                from op in __Enumerate((intf.Operations).GetEnumerator()) //58:49
                select new { __loop6_var1 = __loop6_var1, intf = intf, op = op}
                ).ToList(); //58:3
            int __loop6_iteration = 0;
            foreach (var __tmp76 in __loop6_results)
            {
                ++__loop6_iteration;
                var __loop6_var1 = __tmp76.__loop6_var1;
                var intf = __tmp76.intf;
                var op = __tmp76.op;
                if (intf.HasAnnotation(SoalAnnotations.Rpc)) //59:4
                {
                    var __loop7_results = 
                        (from __loop7_var1 in __Enumerate((op).GetEnumerator()) //60:10
                        from param in __Enumerate((__loop7_var1.Parameters).GetEnumerator()) //60:14
                        where param.Type.IsArrayType() && param.Type.GetCoreType() != SoalInstance.Byte //60:31
                        select new { __loop7_var1 = __loop7_var1, param = param}
                        ).ToList(); //60:5
                    int __loop7_iteration = 0;
                    foreach (var __tmp77 in __loop7_results)
                    {
                        ++__loop7_iteration;
                        var __loop7_var1 = __tmp77.__loop7_var1;
                        var param = __tmp77.param;
                        __out.AppendLine(true); //61:1
                        string __tmp78Prefix = "	"; //62:1
                        StringBuilder __tmp79 = new StringBuilder();
                        __tmp79.Append(GenerateParamType(ns, op.Name + param.Name.ToPascalCase(), param.Type, param));
                        using(StreamReader __tmp79Reader = new StreamReader(this.__ToStream(__tmp79.ToString())))
                        {
                            bool __tmp79_first = true;
                            bool __tmp79_last = __tmp79Reader.EndOfStream;
                            while(__tmp79_first || !__tmp79_last)
                            {
                                __tmp79_first = false;
                                string __tmp79Line = __tmp79Reader.ReadLine();
                                __tmp79_last = __tmp79Reader.EndOfStream;
                                __out.Append(__tmp78Prefix);
                                if (__tmp79Line != null) __out.Append(__tmp79Line);
                                if (!__tmp79_last) __out.AppendLine(true);
                                __out.AppendLine(false); //62:81
                            }
                        }
                    }
                    if (op.Result.Type.IsArrayType() && op.Result.Type.GetCoreType() != SoalInstance.Byte) //64:5
                    {
                        __out.AppendLine(true); //65:1
                        string __tmp80Prefix = "	"; //66:1
                        StringBuilder __tmp81 = new StringBuilder();
                        __tmp81.Append(GenerateParamType(ns, op.Name + "Response", op.Result.Type, op.Result));
                        using(StreamReader __tmp81Reader = new StreamReader(this.__ToStream(__tmp81.ToString())))
                        {
                            bool __tmp81_first = true;
                            bool __tmp81_last = __tmp81Reader.EndOfStream;
                            while(__tmp81_first || !__tmp81_last)
                            {
                                __tmp81_first = false;
                                string __tmp81Line = __tmp81Reader.ReadLine();
                                __tmp81_last = __tmp81Reader.EndOfStream;
                                __out.Append(__tmp80Prefix);
                                if (__tmp81Line != null) __out.Append(__tmp81Line);
                                if (!__tmp81_last) __out.AppendLine(true);
                                __out.AppendLine(false); //66:74
                            }
                        }
                    }
                }
                else //68:4
                {
                    if (intf.HasAnnotation(SoalAnnotations.NoWrap)) //69:5
                    {
                        var __loop8_results = 
                            (from __loop8_var1 in __Enumerate((op).GetEnumerator()) //70:11
                            from param in __Enumerate((__loop8_var1.Parameters).GetEnumerator()) //70:15
                            select new { __loop8_var1 = __loop8_var1, param = param}
                            ).ToList(); //70:6
                        int __loop8_iteration = 0;
                        foreach (var __tmp82 in __loop8_results)
                        {
                            ++__loop8_iteration;
                            var __loop8_var1 = __tmp82.__loop8_var1;
                            var param = __tmp82.param;
                            string __tmp83Prefix = "	"; //71:1
                            StringBuilder __tmp84 = new StringBuilder();
                            __tmp84.Append(GenerateElement(ns, op.Name + param.Name.ToPascalCase(), param.Type, param));
                            using(StreamReader __tmp84Reader = new StreamReader(this.__ToStream(__tmp84.ToString())))
                            {
                                bool __tmp84_first = true;
                                bool __tmp84_last = __tmp84Reader.EndOfStream;
                                while(__tmp84_first || !__tmp84_last)
                                {
                                    __tmp84_first = false;
                                    string __tmp84Line = __tmp84Reader.ReadLine();
                                    __tmp84_last = __tmp84Reader.EndOfStream;
                                    __out.Append(__tmp83Prefix);
                                    if (__tmp84Line != null) __out.Append(__tmp84Line);
                                    if (!__tmp84_last) __out.AppendLine(true);
                                    __out.AppendLine(false); //71:79
                                }
                            }
                        }
                        if (op.Result.Type != SoalInstance.Void) //73:6
                        {
                            string __tmp85Prefix = "	"; //74:1
                            StringBuilder __tmp86 = new StringBuilder();
                            __tmp86.Append(GenerateElement(ns, op.Name + "Response", op.Result.Type, op.Result));
                            using(StreamReader __tmp86Reader = new StreamReader(this.__ToStream(__tmp86.ToString())))
                            {
                                bool __tmp86_first = true;
                                bool __tmp86_last = __tmp86Reader.EndOfStream;
                                while(__tmp86_first || !__tmp86_last)
                                {
                                    __tmp86_first = false;
                                    string __tmp86Line = __tmp86Reader.ReadLine();
                                    __tmp86_last = __tmp86Reader.EndOfStream;
                                    __out.Append(__tmp85Prefix);
                                    if (__tmp86Line != null) __out.Append(__tmp86Line);
                                    if (!__tmp86_last) __out.AppendLine(true);
                                    __out.AppendLine(false); //74:72
                                }
                            }
                        }
                    }
                    else //76:5
                    {
                        __out.AppendLine(true); //77:1
                        string __tmp88Line = "	<xs:element name=\""; //78:1
                        if (__tmp88Line != null) __out.Append(__tmp88Line);
                        StringBuilder __tmp89 = new StringBuilder();
                        __tmp89.Append(op.Name);
                        using(StreamReader __tmp89Reader = new StreamReader(this.__ToStream(__tmp89.ToString())))
                        {
                            bool __tmp89_first = true;
                            bool __tmp89_last = __tmp89Reader.EndOfStream;
                            while(__tmp89_first || !__tmp89_last)
                            {
                                __tmp89_first = false;
                                string __tmp89Line = __tmp89Reader.ReadLine();
                                __tmp89_last = __tmp89Reader.EndOfStream;
                                if (__tmp89Line != null) __out.Append(__tmp89Line);
                                if (!__tmp89_last) __out.AppendLine(true);
                            }
                        }
                        string __tmp90Line = "\" type=\""; //78:29
                        if (__tmp90Line != null) __out.Append(__tmp90Line);
                        StringBuilder __tmp91 = new StringBuilder();
                        __tmp91.Append(ns.Prefix);
                        using(StreamReader __tmp91Reader = new StreamReader(this.__ToStream(__tmp91.ToString())))
                        {
                            bool __tmp91_first = true;
                            bool __tmp91_last = __tmp91Reader.EndOfStream;
                            while(__tmp91_first || !__tmp91_last)
                            {
                                __tmp91_first = false;
                                string __tmp91Line = __tmp91Reader.ReadLine();
                                __tmp91_last = __tmp91Reader.EndOfStream;
                                if (__tmp91Line != null) __out.Append(__tmp91Line);
                                if (!__tmp91_last) __out.AppendLine(true);
                            }
                        }
                        string __tmp92Line = ":"; //78:48
                        if (__tmp92Line != null) __out.Append(__tmp92Line);
                        StringBuilder __tmp93 = new StringBuilder();
                        __tmp93.Append(op.Name);
                        using(StreamReader __tmp93Reader = new StreamReader(this.__ToStream(__tmp93.ToString())))
                        {
                            bool __tmp93_first = true;
                            bool __tmp93_last = __tmp93Reader.EndOfStream;
                            while(__tmp93_first || !__tmp93_last)
                            {
                                __tmp93_first = false;
                                string __tmp93Line = __tmp93Reader.ReadLine();
                                __tmp93_last = __tmp93Reader.EndOfStream;
                                if (__tmp93Line != null) __out.Append(__tmp93Line);
                                if (!__tmp93_last) __out.AppendLine(true);
                            }
                        }
                        string __tmp94Line = "\"/>"; //78:58
                        if (__tmp94Line != null) __out.Append(__tmp94Line);
                        __out.AppendLine(false); //78:61
                        string __tmp96Line = "	<xs:complexType name=\""; //79:1
                        if (__tmp96Line != null) __out.Append(__tmp96Line);
                        StringBuilder __tmp97 = new StringBuilder();
                        __tmp97.Append(op.Name);
                        using(StreamReader __tmp97Reader = new StreamReader(this.__ToStream(__tmp97.ToString())))
                        {
                            bool __tmp97_first = true;
                            bool __tmp97_last = __tmp97Reader.EndOfStream;
                            while(__tmp97_first || !__tmp97_last)
                            {
                                __tmp97_first = false;
                                string __tmp97Line = __tmp97Reader.ReadLine();
                                __tmp97_last = __tmp97Reader.EndOfStream;
                                if (__tmp97Line != null) __out.Append(__tmp97Line);
                                if (!__tmp97_last) __out.AppendLine(true);
                            }
                        }
                        string __tmp98Line = "\">"; //79:33
                        if (__tmp98Line != null) __out.Append(__tmp98Line);
                        __out.AppendLine(false); //79:35
                        __out.Append("		<xs:sequence>"); //80:1
                        __out.AppendLine(false); //80:16
                        var __loop9_results = 
                            (from __loop9_var1 in __Enumerate((op).GetEnumerator()) //81:11
                            from param in __Enumerate((__loop9_var1.Parameters).GetEnumerator()) //81:15
                            where !param.HasAnnotation(SoalAnnotations.Attribute) //81:32
                            select new { __loop9_var1 = __loop9_var1, param = param}
                            ).ToList(); //81:6
                        int __loop9_iteration = 0;
                        foreach (var __tmp99 in __loop9_results)
                        {
                            ++__loop9_iteration;
                            var __loop9_var1 = __tmp99.__loop9_var1;
                            var param = __tmp99.param;
                            string __tmp100Prefix = "			"; //82:1
                            StringBuilder __tmp101 = new StringBuilder();
                            __tmp101.Append(GenerateElement(ns, param.Name, param.Type, param));
                            using(StreamReader __tmp101Reader = new StreamReader(this.__ToStream(__tmp101.ToString())))
                            {
                                bool __tmp101_first = true;
                                bool __tmp101_last = __tmp101Reader.EndOfStream;
                                while(__tmp101_first || !__tmp101_last)
                                {
                                    __tmp101_first = false;
                                    string __tmp101Line = __tmp101Reader.ReadLine();
                                    __tmp101_last = __tmp101Reader.EndOfStream;
                                    __out.Append(__tmp100Prefix);
                                    if (__tmp101Line != null) __out.Append(__tmp101Line);
                                    if (!__tmp101_last) __out.AppendLine(true);
                                    __out.AppendLine(false); //82:56
                                }
                            }
                        }
                        __out.Append("		</xs:sequence>"); //84:1
                        __out.AppendLine(false); //84:17
                        var __loop10_results = 
                            (from __loop10_var1 in __Enumerate((op).GetEnumerator()) //85:11
                            from param in __Enumerate((__loop10_var1.Parameters).GetEnumerator()) //85:15
                            where param.HasAnnotation(SoalAnnotations.Attribute) //85:32
                            select new { __loop10_var1 = __loop10_var1, param = param}
                            ).ToList(); //85:6
                        int __loop10_iteration = 0;
                        foreach (var __tmp102 in __loop10_results)
                        {
                            ++__loop10_iteration;
                            var __loop10_var1 = __tmp102.__loop10_var1;
                            var param = __tmp102.param;
                            string __tmp103Prefix = "		"; //86:1
                            StringBuilder __tmp104 = new StringBuilder();
                            __tmp104.Append(GenerateElement(ns, param.Name, param.Type, param));
                            using(StreamReader __tmp104Reader = new StreamReader(this.__ToStream(__tmp104.ToString())))
                            {
                                bool __tmp104_first = true;
                                bool __tmp104_last = __tmp104Reader.EndOfStream;
                                while(__tmp104_first || !__tmp104_last)
                                {
                                    __tmp104_first = false;
                                    string __tmp104Line = __tmp104Reader.ReadLine();
                                    __tmp104_last = __tmp104Reader.EndOfStream;
                                    __out.Append(__tmp103Prefix);
                                    if (__tmp104Line != null) __out.Append(__tmp104Line);
                                    if (!__tmp104_last) __out.AppendLine(true);
                                    __out.AppendLine(false); //86:55
                                }
                            }
                        }
                        __out.Append("	</xs:complexType>"); //88:1
                        __out.AppendLine(false); //88:19
                        if (!op.Result.IsOneway) //89:6
                        {
                            __out.AppendLine(true); //90:1
                            string __tmp106Line = "	<xs:element name=\""; //91:1
                            if (__tmp106Line != null) __out.Append(__tmp106Line);
                            StringBuilder __tmp107 = new StringBuilder();
                            __tmp107.Append(op.Name);
                            using(StreamReader __tmp107Reader = new StreamReader(this.__ToStream(__tmp107.ToString())))
                            {
                                bool __tmp107_first = true;
                                bool __tmp107_last = __tmp107Reader.EndOfStream;
                                while(__tmp107_first || !__tmp107_last)
                                {
                                    __tmp107_first = false;
                                    string __tmp107Line = __tmp107Reader.ReadLine();
                                    __tmp107_last = __tmp107Reader.EndOfStream;
                                    if (__tmp107Line != null) __out.Append(__tmp107Line);
                                    if (!__tmp107_last) __out.AppendLine(true);
                                }
                            }
                            string __tmp108Line = "Response\" type=\""; //91:29
                            if (__tmp108Line != null) __out.Append(__tmp108Line);
                            StringBuilder __tmp109 = new StringBuilder();
                            __tmp109.Append(ns.Prefix);
                            using(StreamReader __tmp109Reader = new StreamReader(this.__ToStream(__tmp109.ToString())))
                            {
                                bool __tmp109_first = true;
                                bool __tmp109_last = __tmp109Reader.EndOfStream;
                                while(__tmp109_first || !__tmp109_last)
                                {
                                    __tmp109_first = false;
                                    string __tmp109Line = __tmp109Reader.ReadLine();
                                    __tmp109_last = __tmp109Reader.EndOfStream;
                                    if (__tmp109Line != null) __out.Append(__tmp109Line);
                                    if (!__tmp109_last) __out.AppendLine(true);
                                }
                            }
                            string __tmp110Line = ":"; //91:56
                            if (__tmp110Line != null) __out.Append(__tmp110Line);
                            StringBuilder __tmp111 = new StringBuilder();
                            __tmp111.Append(op.Name);
                            using(StreamReader __tmp111Reader = new StreamReader(this.__ToStream(__tmp111.ToString())))
                            {
                                bool __tmp111_first = true;
                                bool __tmp111_last = __tmp111Reader.EndOfStream;
                                while(__tmp111_first || !__tmp111_last)
                                {
                                    __tmp111_first = false;
                                    string __tmp111Line = __tmp111Reader.ReadLine();
                                    __tmp111_last = __tmp111Reader.EndOfStream;
                                    if (__tmp111Line != null) __out.Append(__tmp111Line);
                                    if (!__tmp111_last) __out.AppendLine(true);
                                }
                            }
                            string __tmp112Line = "Response\"/>"; //91:66
                            if (__tmp112Line != null) __out.Append(__tmp112Line);
                            __out.AppendLine(false); //91:77
                            string __tmp114Line = "	<xs:complexType name=\""; //92:1
                            if (__tmp114Line != null) __out.Append(__tmp114Line);
                            StringBuilder __tmp115 = new StringBuilder();
                            __tmp115.Append(op.Name);
                            using(StreamReader __tmp115Reader = new StreamReader(this.__ToStream(__tmp115.ToString())))
                            {
                                bool __tmp115_first = true;
                                bool __tmp115_last = __tmp115Reader.EndOfStream;
                                while(__tmp115_first || !__tmp115_last)
                                {
                                    __tmp115_first = false;
                                    string __tmp115Line = __tmp115Reader.ReadLine();
                                    __tmp115_last = __tmp115Reader.EndOfStream;
                                    if (__tmp115Line != null) __out.Append(__tmp115Line);
                                    if (!__tmp115_last) __out.AppendLine(true);
                                }
                            }
                            string __tmp116Line = "Response\">"; //92:33
                            if (__tmp116Line != null) __out.Append(__tmp116Line);
                            __out.AppendLine(false); //92:43
                            if (op.Result.Type == SoalInstance.Void || op.Result.HasAnnotation(SoalAnnotations.Attribute)) //93:7
                            {
                                __out.Append("		<xs:sequence/>"); //94:1
                                __out.AppendLine(false); //94:17
                            }
                            else //95:7
                            {
                                __out.Append("		<xs:sequence>"); //96:1
                                __out.AppendLine(false); //96:16
                                string __tmp117Prefix = "			"; //97:1
                                StringBuilder __tmp118 = new StringBuilder();
                                __tmp118.Append(GenerateElement(ns, op.Name + "Result", op.Result.Type, op.Result));
                                using(StreamReader __tmp118Reader = new StreamReader(this.__ToStream(__tmp118.ToString())))
                                {
                                    bool __tmp118_first = true;
                                    bool __tmp118_last = __tmp118Reader.EndOfStream;
                                    while(__tmp118_first || !__tmp118_last)
                                    {
                                        __tmp118_first = false;
                                        string __tmp118Line = __tmp118Reader.ReadLine();
                                        __tmp118_last = __tmp118Reader.EndOfStream;
                                        __out.Append(__tmp117Prefix);
                                        if (__tmp118Line != null) __out.Append(__tmp118Line);
                                        if (!__tmp118_last) __out.AppendLine(true);
                                        __out.AppendLine(false); //97:70
                                    }
                                }
                                __out.Append("		</xs:sequence>"); //98:1
                                __out.AppendLine(false); //98:17
                            }
                            if (op.Result.HasAnnotation(SoalAnnotations.Attribute)) //100:7
                            {
                                string __tmp119Prefix = "		"; //101:1
                                StringBuilder __tmp120 = new StringBuilder();
                                __tmp120.Append(GenerateElement(ns, op.Name + "Result", op.Result.Type, op.Result));
                                using(StreamReader __tmp120Reader = new StreamReader(this.__ToStream(__tmp120.ToString())))
                                {
                                    bool __tmp120_first = true;
                                    bool __tmp120_last = __tmp120Reader.EndOfStream;
                                    while(__tmp120_first || !__tmp120_last)
                                    {
                                        __tmp120_first = false;
                                        string __tmp120Line = __tmp120Reader.ReadLine();
                                        __tmp120_last = __tmp120Reader.EndOfStream;
                                        __out.Append(__tmp119Prefix);
                                        if (__tmp120Line != null) __out.Append(__tmp120Line);
                                        if (!__tmp120_last) __out.AppendLine(true);
                                        __out.AppendLine(false); //101:69
                                    }
                                }
                            }
                            __out.Append("	</xs:complexType>"); //103:1
                            __out.AppendLine(false); //103:19
                        }
                    }
                }
            }
            __out.Append("</xs:schema>"); //108:1
            __out.AppendLine(false); //108:13
            return __out.ToString();
        }

        public string GenerateStructBody(Namespace ns, Struct stype) //111:1
        {
            StringBuilder __out = new StringBuilder();
            string __tmp2Line = "<xs:"; //112:1
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
            string __tmp4Line = ">"; //112:27
            if (__tmp4Line != null) __out.Append(__tmp4Line);
            __out.AppendLine(false); //112:28
            var __loop11_results = 
                (from __loop11_var1 in __Enumerate((stype).GetEnumerator()) //113:8
                from prop in __Enumerate((__loop11_var1.Properties).GetEnumerator()) //113:15
                where !prop.HasAnnotation(SoalAnnotations.Attribute) //113:31
                select new { __loop11_var1 = __loop11_var1, prop = prop}
                ).ToList(); //113:3
            int __loop11_iteration = 0;
            foreach (var __tmp5 in __loop11_results)
            {
                ++__loop11_iteration;
                var __loop11_var1 = __tmp5.__loop11_var1;
                var prop = __tmp5.prop;
                string newName = prop.GetAnnotationPropertyValue(SoalAnnotations.Element, SoalAnnotationProperties.Name) as string; //114:4
                string __tmp6Prefix = "	"; //115:1
                StringBuilder __tmp7 = new StringBuilder();
                __tmp7.Append(GenerateElement(ns, newName == null ? prop.Name : newName, prop.Type, prop));
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
                        __out.AppendLine(false); //115:79
                    }
                }
            }
            string __tmp9Line = "</xs:"; //117:1
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
            string __tmp11Line = ">"; //117:28
            if (__tmp11Line != null) __out.Append(__tmp11Line);
            __out.AppendLine(false); //117:29
            var __loop12_results = 
                (from __loop12_var1 in __Enumerate((stype).GetEnumerator()) //118:7
                from prop in __Enumerate((__loop12_var1.Properties).GetEnumerator()) //118:14
                where prop.HasAnnotation(SoalAnnotations.Attribute) //118:30
                select new { __loop12_var1 = __loop12_var1, prop = prop}
                ).ToList(); //118:2
            int __loop12_iteration = 0;
            foreach (var __tmp12 in __loop12_results)
            {
                ++__loop12_iteration;
                var __loop12_var1 = __tmp12.__loop12_var1;
                var prop = __tmp12.prop;
                string newName = prop.GetAnnotationPropertyValue(SoalAnnotations.Attribute, SoalAnnotationProperties.Name) as string; //119:3
                StringBuilder __tmp14 = new StringBuilder();
                __tmp14.Append(GenerateElement(ns, newName == null ? prop.Name : newName, prop.Type, prop));
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
                        __out.AppendLine(false); //120:78
                    }
                }
            }
            return __out.ToString();
        }

        public string GenerateElement(Namespace ns, string name, SoalType t, AnnotatedElement ae) //124:1
        {
            StringBuilder __out = new StringBuilder();
            Annotation restrAnnot = ae.GetAnnotation(SoalAnnotations.Restriction); //125:2
            if (ae.HasAnnotation(SoalAnnotations.Attribute)) //126:2
            {
                string __tmp2Line = "<xs:attribute name=\""; //127:1
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
                string __tmp4Line = "\" type=\""; //127:27
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
                string __tmp6Line = ":"; //127:76
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
                string __tmp8Line = "\""; //127:107
                if (__tmp8Line != null) __out.Append(__tmp8Line);
                StringBuilder __tmp9 = new StringBuilder();
                __tmp9.Append(GetAttributeRequired(ae));
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
                string __tmp10Line = "/>"; //127:134
                if (__tmp10Line != null) __out.Append(__tmp10Line);
                __out.AppendLine(false); //127:136
            }
            else //128:2
            {
                if (t.IsArrayType()) //129:3
                {
                    ArrayType array = t is NonNullableType ? (ArrayType)((NonNullableType)t).InnerType : (ArrayType)t; //130:4
                    if (array.GetCoreType() == SoalInstance.Byte) //131:4
                    {
                        string __tmp12Line = "<xs:element name=\""; //132:1
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
                        string __tmp14Line = "\" type=\""; //132:25
                        if (__tmp14Line != null) __out.Append(__tmp14Line);
                        StringBuilder __tmp15 = new StringBuilder();
                        __tmp15.Append(t.GetNamespace(ns).Prefix);
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
                        string __tmp16Line = ":"; //132:60
                        if (__tmp16Line != null) __out.Append(__tmp16Line);
                        StringBuilder __tmp17 = new StringBuilder();
                        __tmp17.Append(t.GetXsdName());
                        using(StreamReader __tmp17Reader = new StreamReader(this.__ToStream(__tmp17.ToString())))
                        {
                            bool __tmp17_first = true;
                            bool __tmp17_last = __tmp17Reader.EndOfStream;
                            while(__tmp17_first || !__tmp17_last)
                            {
                                __tmp17_first = false;
                                string __tmp17Line = __tmp17Reader.ReadLine();
                                __tmp17_last = __tmp17Reader.EndOfStream;
                                if (__tmp17Line != null) __out.Append(__tmp17Line);
                                if (!__tmp17_last) __out.AppendLine(true);
                            }
                        }
                        string __tmp18Line = "\" nillable=\""; //132:77
                        if (__tmp18Line != null) __out.Append(__tmp18Line);
                        StringBuilder __tmp19 = new StringBuilder();
                        __tmp19.Append(t.IsNullableXsd());
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
                        string __tmp20Line = "\""; //132:108
                        if (__tmp20Line != null) __out.Append(__tmp20Line);
                        StringBuilder __tmp21 = new StringBuilder();
                        __tmp21.Append(GetElementOptional(ae));
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
                        string __tmp22Line = "/>"; //132:133
                        if (__tmp22Line != null) __out.Append(__tmp22Line);
                        __out.AppendLine(false); //132:135
                    }
                    else //133:4
                    {
                        object wrapped = ae.GetAnnotationPropertyValue(SoalAnnotations.Element, SoalAnnotationProperties.Wrapped); //134:5
                        if (wrapped != null && (bool)wrapped) //135:5
                        {
                            string items = ae.GetAnnotationPropertyValue(SoalAnnotations.Element, SoalAnnotationProperties.Items) as string; //136:6
                            string __tmp24Line = "<xs:element name=\""; //137:1
                            if (__tmp24Line != null) __out.Append(__tmp24Line);
                            StringBuilder __tmp25 = new StringBuilder();
                            __tmp25.Append(name);
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
                            string __tmp26Line = "\" nillable=\""; //137:25
                            if (__tmp26Line != null) __out.Append(__tmp26Line);
                            StringBuilder __tmp27 = new StringBuilder();
                            __tmp27.Append(t.IsNullableXsd());
                            using(StreamReader __tmp27Reader = new StreamReader(this.__ToStream(__tmp27.ToString())))
                            {
                                bool __tmp27_first = true;
                                bool __tmp27_last = __tmp27Reader.EndOfStream;
                                while(__tmp27_first || !__tmp27_last)
                                {
                                    __tmp27_first = false;
                                    string __tmp27Line = __tmp27Reader.ReadLine();
                                    __tmp27_last = __tmp27Reader.EndOfStream;
                                    if (__tmp27Line != null) __out.Append(__tmp27Line);
                                    if (!__tmp27_last) __out.AppendLine(true);
                                }
                            }
                            string __tmp28Line = "\""; //137:56
                            if (__tmp28Line != null) __out.Append(__tmp28Line);
                            StringBuilder __tmp29 = new StringBuilder();
                            __tmp29.Append(GetElementOptional(ae));
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
                            string __tmp30Line = ">"; //137:81
                            if (__tmp30Line != null) __out.Append(__tmp30Line);
                            __out.AppendLine(false); //137:82
                            __out.Append("	<xs:complexType>"); //138:1
                            __out.AppendLine(false); //138:18
                            object sap = ae.GetAnnotationPropertyValue(SoalAnnotations.Element, SoalAnnotationProperties.Sap); //139:6
                            if (sap != null && (bool)sap) //140:6
                            {
                                __out.Append("		<xs:all>"); //141:1
                                __out.AppendLine(false); //141:11
                                __out.Append("			<xs:element name=\"item\" minOccurs=\"0\" maxOccurs=\"unbounded\">"); //142:1
                                __out.AppendLine(false); //142:64
                                __out.Append("				<xs:complexType>"); //143:1
                                __out.AppendLine(false); //143:21
                                __out.Append("					<xs:all>"); //144:1
                                __out.AppendLine(false); //144:14
                                if (restrAnnot != null && array.InnerType.GetCoreType() is PrimitiveType) //145:7
                                {
                                    if (items != null) //146:8
                                    {
                                        string __tmp32Line = "						<xs:element name=\""; //147:1
                                        if (__tmp32Line != null) __out.Append(__tmp32Line);
                                        StringBuilder __tmp33 = new StringBuilder();
                                        __tmp33.Append(items);
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
                                        string __tmp34Line = "\" nillable=\""; //147:32
                                        if (__tmp34Line != null) __out.Append(__tmp34Line);
                                        StringBuilder __tmp35 = new StringBuilder();
                                        __tmp35.Append(array.InnerType.IsNullableXsd());
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
                                        string __tmp36Line = "\">"; //147:77
                                        if (__tmp36Line != null) __out.Append(__tmp36Line);
                                        __out.AppendLine(false); //147:79
                                    }
                                    else //148:8
                                    {
                                        string __tmp38Line = "						<xs:element name=\""; //149:1
                                        if (__tmp38Line != null) __out.Append(__tmp38Line);
                                        StringBuilder __tmp39 = new StringBuilder();
                                        __tmp39.Append(array.InnerType.GetXsdName());
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
                                        string __tmp40Line = "\" nillable=\""; //149:55
                                        if (__tmp40Line != null) __out.Append(__tmp40Line);
                                        StringBuilder __tmp41 = new StringBuilder();
                                        __tmp41.Append(array.InnerType.IsNullableXsd());
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
                                        string __tmp42Line = "\">"; //149:100
                                        if (__tmp42Line != null) __out.Append(__tmp42Line);
                                        __out.AppendLine(false); //149:102
                                    }
                                    string __tmp43Prefix = "						"; //151:1
                                    StringBuilder __tmp44 = new StringBuilder();
                                    __tmp44.Append(GenerateRestrictions(array.InnerType.GetNamespace(ns).Prefix + ":" + array.InnerType.GetXsdName(), restrAnnot));
                                    using(StreamReader __tmp44Reader = new StreamReader(this.__ToStream(__tmp44.ToString())))
                                    {
                                        bool __tmp44_first = true;
                                        bool __tmp44_last = __tmp44Reader.EndOfStream;
                                        while(__tmp44_first || !__tmp44_last)
                                        {
                                            __tmp44_first = false;
                                            string __tmp44Line = __tmp44Reader.ReadLine();
                                            __tmp44_last = __tmp44Reader.EndOfStream;
                                            __out.Append(__tmp43Prefix);
                                            if (__tmp44Line != null) __out.Append(__tmp44Line);
                                            if (!__tmp44_last) __out.AppendLine(true);
                                            __out.AppendLine(false); //151:115
                                        }
                                    }
                                }
                                else //152:7
                                {
                                    if (items != null) //153:8
                                    {
                                        string __tmp46Line = "						<xs:element name=\""; //154:1
                                        if (__tmp46Line != null) __out.Append(__tmp46Line);
                                        StringBuilder __tmp47 = new StringBuilder();
                                        __tmp47.Append(items);
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
                                        string __tmp48Line = "\" type=\""; //154:32
                                        if (__tmp48Line != null) __out.Append(__tmp48Line);
                                        StringBuilder __tmp49 = new StringBuilder();
                                        __tmp49.Append(array.InnerType.GetNamespace(ns).Prefix);
                                        using(StreamReader __tmp49Reader = new StreamReader(this.__ToStream(__tmp49.ToString())))
                                        {
                                            bool __tmp49_first = true;
                                            bool __tmp49_last = __tmp49Reader.EndOfStream;
                                            while(__tmp49_first || !__tmp49_last)
                                            {
                                                __tmp49_first = false;
                                                string __tmp49Line = __tmp49Reader.ReadLine();
                                                __tmp49_last = __tmp49Reader.EndOfStream;
                                                if (__tmp49Line != null) __out.Append(__tmp49Line);
                                                if (!__tmp49_last) __out.AppendLine(true);
                                            }
                                        }
                                        string __tmp50Line = ":"; //154:81
                                        if (__tmp50Line != null) __out.Append(__tmp50Line);
                                        StringBuilder __tmp51 = new StringBuilder();
                                        __tmp51.Append(array.InnerType.GetXsdName());
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
                                        string __tmp52Line = "\" nillable=\""; //154:112
                                        if (__tmp52Line != null) __out.Append(__tmp52Line);
                                        StringBuilder __tmp53 = new StringBuilder();
                                        __tmp53.Append(array.InnerType.IsNullableXsd());
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
                                        string __tmp54Line = "\"/>"; //154:157
                                        if (__tmp54Line != null) __out.Append(__tmp54Line);
                                        __out.AppendLine(false); //154:160
                                    }
                                    else //155:8
                                    {
                                        string __tmp56Line = "						<xs:element name=\""; //156:1
                                        if (__tmp56Line != null) __out.Append(__tmp56Line);
                                        StringBuilder __tmp57 = new StringBuilder();
                                        __tmp57.Append(array.InnerType.GetXsdName());
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
                                        string __tmp58Line = "\" type=\""; //156:55
                                        if (__tmp58Line != null) __out.Append(__tmp58Line);
                                        StringBuilder __tmp59 = new StringBuilder();
                                        __tmp59.Append(array.InnerType.GetNamespace(ns).Prefix);
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
                                        string __tmp60Line = ":"; //156:104
                                        if (__tmp60Line != null) __out.Append(__tmp60Line);
                                        StringBuilder __tmp61 = new StringBuilder();
                                        __tmp61.Append(array.InnerType.GetXsdName());
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
                                        string __tmp62Line = "\" nillable=\""; //156:135
                                        if (__tmp62Line != null) __out.Append(__tmp62Line);
                                        StringBuilder __tmp63 = new StringBuilder();
                                        __tmp63.Append(array.InnerType.IsNullableXsd());
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
                                        string __tmp64Line = "\"/>"; //156:180
                                        if (__tmp64Line != null) __out.Append(__tmp64Line);
                                        __out.AppendLine(false); //156:183
                                    }
                                }
                                __out.Append("					</xs:all>"); //159:1
                                __out.AppendLine(false); //159:15
                                __out.Append("				</xs:complexType>"); //160:1
                                __out.AppendLine(false); //160:22
                                __out.Append("			</xs:element>"); //161:1
                                __out.AppendLine(false); //161:17
                                __out.Append("		</xs:all>"); //162:1
                                __out.AppendLine(false); //162:12
                            }
                            else //163:6
                            {
                                __out.Append("		<xs:sequence>"); //164:1
                                __out.AppendLine(false); //164:16
                                if (restrAnnot != null && array.InnerType.GetCoreType() is PrimitiveType) //165:7
                                {
                                    if (items != null) //166:8
                                    {
                                        string __tmp66Line = "			<xs:element name=\""; //167:1
                                        if (__tmp66Line != null) __out.Append(__tmp66Line);
                                        StringBuilder __tmp67 = new StringBuilder();
                                        __tmp67.Append(items);
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
                                        string __tmp68Line = "\" nillable=\""; //167:29
                                        if (__tmp68Line != null) __out.Append(__tmp68Line);
                                        StringBuilder __tmp69 = new StringBuilder();
                                        __tmp69.Append(array.InnerType.IsNullableXsd());
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
                                        string __tmp70Line = "\" minOccurs=\"0\" maxOccurs=\"unbounded\">"; //167:74
                                        if (__tmp70Line != null) __out.Append(__tmp70Line);
                                        __out.AppendLine(false); //167:112
                                    }
                                    else //168:8
                                    {
                                        string __tmp72Line = "			<xs:element name=\""; //169:1
                                        if (__tmp72Line != null) __out.Append(__tmp72Line);
                                        StringBuilder __tmp73 = new StringBuilder();
                                        __tmp73.Append(array.InnerType.GetXsdName());
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
                                        string __tmp74Line = "\" nillable=\""; //169:52
                                        if (__tmp74Line != null) __out.Append(__tmp74Line);
                                        StringBuilder __tmp75 = new StringBuilder();
                                        __tmp75.Append(array.InnerType.IsNullableXsd());
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
                                        string __tmp76Line = "\" minOccurs=\"0\" maxOccurs=\"unbounded\">"; //169:97
                                        if (__tmp76Line != null) __out.Append(__tmp76Line);
                                        __out.AppendLine(false); //169:135
                                    }
                                    string __tmp77Prefix = "			"; //171:1
                                    StringBuilder __tmp78 = new StringBuilder();
                                    __tmp78.Append(GenerateRestrictions(array.InnerType.GetNamespace(ns).Prefix + ":" + array.InnerType.GetXsdName(), restrAnnot));
                                    using(StreamReader __tmp78Reader = new StreamReader(this.__ToStream(__tmp78.ToString())))
                                    {
                                        bool __tmp78_first = true;
                                        bool __tmp78_last = __tmp78Reader.EndOfStream;
                                        while(__tmp78_first || !__tmp78_last)
                                        {
                                            __tmp78_first = false;
                                            string __tmp78Line = __tmp78Reader.ReadLine();
                                            __tmp78_last = __tmp78Reader.EndOfStream;
                                            __out.Append(__tmp77Prefix);
                                            if (__tmp78Line != null) __out.Append(__tmp78Line);
                                            if (!__tmp78_last) __out.AppendLine(true);
                                            __out.AppendLine(false); //171:112
                                        }
                                    }
                                }
                                else //172:7
                                {
                                    if (items != null) //173:8
                                    {
                                        string __tmp80Line = "			<xs:element name=\""; //174:1
                                        if (__tmp80Line != null) __out.Append(__tmp80Line);
                                        StringBuilder __tmp81 = new StringBuilder();
                                        __tmp81.Append(items);
                                        using(StreamReader __tmp81Reader = new StreamReader(this.__ToStream(__tmp81.ToString())))
                                        {
                                            bool __tmp81_first = true;
                                            bool __tmp81_last = __tmp81Reader.EndOfStream;
                                            while(__tmp81_first || !__tmp81_last)
                                            {
                                                __tmp81_first = false;
                                                string __tmp81Line = __tmp81Reader.ReadLine();
                                                __tmp81_last = __tmp81Reader.EndOfStream;
                                                if (__tmp81Line != null) __out.Append(__tmp81Line);
                                                if (!__tmp81_last) __out.AppendLine(true);
                                            }
                                        }
                                        string __tmp82Line = "\" type=\""; //174:29
                                        if (__tmp82Line != null) __out.Append(__tmp82Line);
                                        StringBuilder __tmp83 = new StringBuilder();
                                        __tmp83.Append(array.InnerType.GetNamespace(ns).Prefix);
                                        using(StreamReader __tmp83Reader = new StreamReader(this.__ToStream(__tmp83.ToString())))
                                        {
                                            bool __tmp83_first = true;
                                            bool __tmp83_last = __tmp83Reader.EndOfStream;
                                            while(__tmp83_first || !__tmp83_last)
                                            {
                                                __tmp83_first = false;
                                                string __tmp83Line = __tmp83Reader.ReadLine();
                                                __tmp83_last = __tmp83Reader.EndOfStream;
                                                if (__tmp83Line != null) __out.Append(__tmp83Line);
                                                if (!__tmp83_last) __out.AppendLine(true);
                                            }
                                        }
                                        string __tmp84Line = ":"; //174:78
                                        if (__tmp84Line != null) __out.Append(__tmp84Line);
                                        StringBuilder __tmp85 = new StringBuilder();
                                        __tmp85.Append(array.InnerType.GetXsdName());
                                        using(StreamReader __tmp85Reader = new StreamReader(this.__ToStream(__tmp85.ToString())))
                                        {
                                            bool __tmp85_first = true;
                                            bool __tmp85_last = __tmp85Reader.EndOfStream;
                                            while(__tmp85_first || !__tmp85_last)
                                            {
                                                __tmp85_first = false;
                                                string __tmp85Line = __tmp85Reader.ReadLine();
                                                __tmp85_last = __tmp85Reader.EndOfStream;
                                                if (__tmp85Line != null) __out.Append(__tmp85Line);
                                                if (!__tmp85_last) __out.AppendLine(true);
                                            }
                                        }
                                        string __tmp86Line = "\" nillable=\""; //174:109
                                        if (__tmp86Line != null) __out.Append(__tmp86Line);
                                        StringBuilder __tmp87 = new StringBuilder();
                                        __tmp87.Append(array.InnerType.IsNullableXsd());
                                        using(StreamReader __tmp87Reader = new StreamReader(this.__ToStream(__tmp87.ToString())))
                                        {
                                            bool __tmp87_first = true;
                                            bool __tmp87_last = __tmp87Reader.EndOfStream;
                                            while(__tmp87_first || !__tmp87_last)
                                            {
                                                __tmp87_first = false;
                                                string __tmp87Line = __tmp87Reader.ReadLine();
                                                __tmp87_last = __tmp87Reader.EndOfStream;
                                                if (__tmp87Line != null) __out.Append(__tmp87Line);
                                                if (!__tmp87_last) __out.AppendLine(true);
                                            }
                                        }
                                        string __tmp88Line = "\" minOccurs=\"0\" maxOccurs=\"unbounded\"/>"; //174:154
                                        if (__tmp88Line != null) __out.Append(__tmp88Line);
                                        __out.AppendLine(false); //174:193
                                    }
                                    else //175:8
                                    {
                                        string __tmp90Line = "			<xs:element name=\""; //176:1
                                        if (__tmp90Line != null) __out.Append(__tmp90Line);
                                        StringBuilder __tmp91 = new StringBuilder();
                                        __tmp91.Append(array.InnerType.GetXsdName());
                                        using(StreamReader __tmp91Reader = new StreamReader(this.__ToStream(__tmp91.ToString())))
                                        {
                                            bool __tmp91_first = true;
                                            bool __tmp91_last = __tmp91Reader.EndOfStream;
                                            while(__tmp91_first || !__tmp91_last)
                                            {
                                                __tmp91_first = false;
                                                string __tmp91Line = __tmp91Reader.ReadLine();
                                                __tmp91_last = __tmp91Reader.EndOfStream;
                                                if (__tmp91Line != null) __out.Append(__tmp91Line);
                                                if (!__tmp91_last) __out.AppendLine(true);
                                            }
                                        }
                                        string __tmp92Line = "\" type=\""; //176:52
                                        if (__tmp92Line != null) __out.Append(__tmp92Line);
                                        StringBuilder __tmp93 = new StringBuilder();
                                        __tmp93.Append(array.InnerType.GetNamespace(ns).Prefix);
                                        using(StreamReader __tmp93Reader = new StreamReader(this.__ToStream(__tmp93.ToString())))
                                        {
                                            bool __tmp93_first = true;
                                            bool __tmp93_last = __tmp93Reader.EndOfStream;
                                            while(__tmp93_first || !__tmp93_last)
                                            {
                                                __tmp93_first = false;
                                                string __tmp93Line = __tmp93Reader.ReadLine();
                                                __tmp93_last = __tmp93Reader.EndOfStream;
                                                if (__tmp93Line != null) __out.Append(__tmp93Line);
                                                if (!__tmp93_last) __out.AppendLine(true);
                                            }
                                        }
                                        string __tmp94Line = ":"; //176:101
                                        if (__tmp94Line != null) __out.Append(__tmp94Line);
                                        StringBuilder __tmp95 = new StringBuilder();
                                        __tmp95.Append(array.InnerType.GetXsdName());
                                        using(StreamReader __tmp95Reader = new StreamReader(this.__ToStream(__tmp95.ToString())))
                                        {
                                            bool __tmp95_first = true;
                                            bool __tmp95_last = __tmp95Reader.EndOfStream;
                                            while(__tmp95_first || !__tmp95_last)
                                            {
                                                __tmp95_first = false;
                                                string __tmp95Line = __tmp95Reader.ReadLine();
                                                __tmp95_last = __tmp95Reader.EndOfStream;
                                                if (__tmp95Line != null) __out.Append(__tmp95Line);
                                                if (!__tmp95_last) __out.AppendLine(true);
                                            }
                                        }
                                        string __tmp96Line = "\" nillable=\""; //176:132
                                        if (__tmp96Line != null) __out.Append(__tmp96Line);
                                        StringBuilder __tmp97 = new StringBuilder();
                                        __tmp97.Append(array.InnerType.IsNullableXsd());
                                        using(StreamReader __tmp97Reader = new StreamReader(this.__ToStream(__tmp97.ToString())))
                                        {
                                            bool __tmp97_first = true;
                                            bool __tmp97_last = __tmp97Reader.EndOfStream;
                                            while(__tmp97_first || !__tmp97_last)
                                            {
                                                __tmp97_first = false;
                                                string __tmp97Line = __tmp97Reader.ReadLine();
                                                __tmp97_last = __tmp97Reader.EndOfStream;
                                                if (__tmp97Line != null) __out.Append(__tmp97Line);
                                                if (!__tmp97_last) __out.AppendLine(true);
                                            }
                                        }
                                        string __tmp98Line = "\" minOccurs=\"0\" maxOccurs=\"unbounded\"/>"; //176:177
                                        if (__tmp98Line != null) __out.Append(__tmp98Line);
                                        __out.AppendLine(false); //176:216
                                    }
                                }
                                __out.Append("		</xs:sequence>"); //179:1
                                __out.AppendLine(false); //179:17
                            }
                            __out.Append("	</xs:complexType>"); //181:1
                            __out.AppendLine(false); //181:19
                            __out.Append("</xs:element>"); //182:1
                            __out.AppendLine(false); //182:14
                        }
                        else //183:5
                        {
                            if (restrAnnot != null && array.InnerType.GetCoreType() is PrimitiveType) //184:6
                            {
                                string __tmp100Line = "<xs:element name=\""; //185:1
                                if (__tmp100Line != null) __out.Append(__tmp100Line);
                                StringBuilder __tmp101 = new StringBuilder();
                                __tmp101.Append(name);
                                using(StreamReader __tmp101Reader = new StreamReader(this.__ToStream(__tmp101.ToString())))
                                {
                                    bool __tmp101_first = true;
                                    bool __tmp101_last = __tmp101Reader.EndOfStream;
                                    while(__tmp101_first || !__tmp101_last)
                                    {
                                        __tmp101_first = false;
                                        string __tmp101Line = __tmp101Reader.ReadLine();
                                        __tmp101_last = __tmp101Reader.EndOfStream;
                                        if (__tmp101Line != null) __out.Append(__tmp101Line);
                                        if (!__tmp101_last) __out.AppendLine(true);
                                    }
                                }
                                string __tmp102Line = "\" nillable=\""; //185:25
                                if (__tmp102Line != null) __out.Append(__tmp102Line);
                                StringBuilder __tmp103 = new StringBuilder();
                                __tmp103.Append(array.InnerType.IsNullableXsd());
                                using(StreamReader __tmp103Reader = new StreamReader(this.__ToStream(__tmp103.ToString())))
                                {
                                    bool __tmp103_first = true;
                                    bool __tmp103_last = __tmp103Reader.EndOfStream;
                                    while(__tmp103_first || !__tmp103_last)
                                    {
                                        __tmp103_first = false;
                                        string __tmp103Line = __tmp103Reader.ReadLine();
                                        __tmp103_last = __tmp103Reader.EndOfStream;
                                        if (__tmp103Line != null) __out.Append(__tmp103Line);
                                        if (!__tmp103_last) __out.AppendLine(true);
                                    }
                                }
                                string __tmp104Line = "\" minOccurs=\"0\" maxOccurs=\"unbounded\">"; //185:70
                                if (__tmp104Line != null) __out.Append(__tmp104Line);
                                __out.AppendLine(false); //185:108
                                StringBuilder __tmp106 = new StringBuilder();
                                __tmp106.Append(GenerateRestrictions(array.InnerType.GetNamespace(ns).Prefix + ":" + array.InnerType.GetXsdName(), restrAnnot));
                                using(StreamReader __tmp106Reader = new StreamReader(this.__ToStream(__tmp106.ToString())))
                                {
                                    bool __tmp106_first = true;
                                    bool __tmp106_last = __tmp106Reader.EndOfStream;
                                    while(__tmp106_first || !__tmp106_last)
                                    {
                                        __tmp106_first = false;
                                        string __tmp106Line = __tmp106Reader.ReadLine();
                                        __tmp106_last = __tmp106Reader.EndOfStream;
                                        if (__tmp106Line != null) __out.Append(__tmp106Line);
                                        if (!__tmp106_last) __out.AppendLine(true);
                                        __out.AppendLine(false); //186:109
                                    }
                                }
                            }
                            else //187:6
                            {
                                string __tmp108Line = "<xs:element name=\""; //188:1
                                if (__tmp108Line != null) __out.Append(__tmp108Line);
                                StringBuilder __tmp109 = new StringBuilder();
                                __tmp109.Append(name);
                                using(StreamReader __tmp109Reader = new StreamReader(this.__ToStream(__tmp109.ToString())))
                                {
                                    bool __tmp109_first = true;
                                    bool __tmp109_last = __tmp109Reader.EndOfStream;
                                    while(__tmp109_first || !__tmp109_last)
                                    {
                                        __tmp109_first = false;
                                        string __tmp109Line = __tmp109Reader.ReadLine();
                                        __tmp109_last = __tmp109Reader.EndOfStream;
                                        if (__tmp109Line != null) __out.Append(__tmp109Line);
                                        if (!__tmp109_last) __out.AppendLine(true);
                                    }
                                }
                                string __tmp110Line = "\" type=\""; //188:25
                                if (__tmp110Line != null) __out.Append(__tmp110Line);
                                StringBuilder __tmp111 = new StringBuilder();
                                __tmp111.Append(array.InnerType.GetNamespace(ns).Prefix);
                                using(StreamReader __tmp111Reader = new StreamReader(this.__ToStream(__tmp111.ToString())))
                                {
                                    bool __tmp111_first = true;
                                    bool __tmp111_last = __tmp111Reader.EndOfStream;
                                    while(__tmp111_first || !__tmp111_last)
                                    {
                                        __tmp111_first = false;
                                        string __tmp111Line = __tmp111Reader.ReadLine();
                                        __tmp111_last = __tmp111Reader.EndOfStream;
                                        if (__tmp111Line != null) __out.Append(__tmp111Line);
                                        if (!__tmp111_last) __out.AppendLine(true);
                                    }
                                }
                                string __tmp112Line = ":"; //188:74
                                if (__tmp112Line != null) __out.Append(__tmp112Line);
                                StringBuilder __tmp113 = new StringBuilder();
                                __tmp113.Append(array.InnerType.GetXsdName());
                                using(StreamReader __tmp113Reader = new StreamReader(this.__ToStream(__tmp113.ToString())))
                                {
                                    bool __tmp113_first = true;
                                    bool __tmp113_last = __tmp113Reader.EndOfStream;
                                    while(__tmp113_first || !__tmp113_last)
                                    {
                                        __tmp113_first = false;
                                        string __tmp113Line = __tmp113Reader.ReadLine();
                                        __tmp113_last = __tmp113Reader.EndOfStream;
                                        if (__tmp113Line != null) __out.Append(__tmp113Line);
                                        if (!__tmp113_last) __out.AppendLine(true);
                                    }
                                }
                                string __tmp114Line = "\" nillable=\""; //188:105
                                if (__tmp114Line != null) __out.Append(__tmp114Line);
                                StringBuilder __tmp115 = new StringBuilder();
                                __tmp115.Append(array.InnerType.IsNullableXsd());
                                using(StreamReader __tmp115Reader = new StreamReader(this.__ToStream(__tmp115.ToString())))
                                {
                                    bool __tmp115_first = true;
                                    bool __tmp115_last = __tmp115Reader.EndOfStream;
                                    while(__tmp115_first || !__tmp115_last)
                                    {
                                        __tmp115_first = false;
                                        string __tmp115Line = __tmp115Reader.ReadLine();
                                        __tmp115_last = __tmp115Reader.EndOfStream;
                                        if (__tmp115Line != null) __out.Append(__tmp115Line);
                                        if (!__tmp115_last) __out.AppendLine(true);
                                    }
                                }
                                string __tmp116Line = "\" minOccurs=\"0\" maxOccurs=\"unbounded\"/>"; //188:150
                                if (__tmp116Line != null) __out.Append(__tmp116Line);
                                __out.AppendLine(false); //188:189
                            }
                        }
                    }
                }
                else //192:3
                {
                    if (restrAnnot != null && t.GetCoreType() is PrimitiveType) //193:4
                    {
                        string __tmp118Line = "<xs:element name=\""; //194:1
                        if (__tmp118Line != null) __out.Append(__tmp118Line);
                        StringBuilder __tmp119 = new StringBuilder();
                        __tmp119.Append(name);
                        using(StreamReader __tmp119Reader = new StreamReader(this.__ToStream(__tmp119.ToString())))
                        {
                            bool __tmp119_first = true;
                            bool __tmp119_last = __tmp119Reader.EndOfStream;
                            while(__tmp119_first || !__tmp119_last)
                            {
                                __tmp119_first = false;
                                string __tmp119Line = __tmp119Reader.ReadLine();
                                __tmp119_last = __tmp119Reader.EndOfStream;
                                if (__tmp119Line != null) __out.Append(__tmp119Line);
                                if (!__tmp119_last) __out.AppendLine(true);
                            }
                        }
                        string __tmp120Line = "\" nillable=\""; //194:25
                        if (__tmp120Line != null) __out.Append(__tmp120Line);
                        StringBuilder __tmp121 = new StringBuilder();
                        __tmp121.Append(t.IsNullableXsd());
                        using(StreamReader __tmp121Reader = new StreamReader(this.__ToStream(__tmp121.ToString())))
                        {
                            bool __tmp121_first = true;
                            bool __tmp121_last = __tmp121Reader.EndOfStream;
                            while(__tmp121_first || !__tmp121_last)
                            {
                                __tmp121_first = false;
                                string __tmp121Line = __tmp121Reader.ReadLine();
                                __tmp121_last = __tmp121Reader.EndOfStream;
                                if (__tmp121Line != null) __out.Append(__tmp121Line);
                                if (!__tmp121_last) __out.AppendLine(true);
                            }
                        }
                        string __tmp122Line = "\""; //194:56
                        if (__tmp122Line != null) __out.Append(__tmp122Line);
                        StringBuilder __tmp123 = new StringBuilder();
                        __tmp123.Append(GetElementOptional(ae));
                        using(StreamReader __tmp123Reader = new StreamReader(this.__ToStream(__tmp123.ToString())))
                        {
                            bool __tmp123_first = true;
                            bool __tmp123_last = __tmp123Reader.EndOfStream;
                            while(__tmp123_first || !__tmp123_last)
                            {
                                __tmp123_first = false;
                                string __tmp123Line = __tmp123Reader.ReadLine();
                                __tmp123_last = __tmp123Reader.EndOfStream;
                                if (__tmp123Line != null) __out.Append(__tmp123Line);
                                if (!__tmp123_last) __out.AppendLine(true);
                            }
                        }
                        string __tmp124Line = ">"; //194:81
                        if (__tmp124Line != null) __out.Append(__tmp124Line);
                        __out.AppendLine(false); //194:82
                        StringBuilder __tmp126 = new StringBuilder();
                        __tmp126.Append(GenerateRestrictions(t.GetNamespace(ns).Prefix + ":" + t.GetXsdName(), restrAnnot));
                        using(StreamReader __tmp126Reader = new StreamReader(this.__ToStream(__tmp126.ToString())))
                        {
                            bool __tmp126_first = true;
                            bool __tmp126_last = __tmp126Reader.EndOfStream;
                            while(__tmp126_first || !__tmp126_last)
                            {
                                __tmp126_first = false;
                                string __tmp126Line = __tmp126Reader.ReadLine();
                                __tmp126_last = __tmp126Reader.EndOfStream;
                                if (__tmp126Line != null) __out.Append(__tmp126Line);
                                if (!__tmp126_last) __out.AppendLine(true);
                                __out.AppendLine(false); //195:81
                            }
                        }
                    }
                    else //196:4
                    {
                        string __tmp128Line = "<xs:element name=\""; //197:1
                        if (__tmp128Line != null) __out.Append(__tmp128Line);
                        StringBuilder __tmp129 = new StringBuilder();
                        __tmp129.Append(name);
                        using(StreamReader __tmp129Reader = new StreamReader(this.__ToStream(__tmp129.ToString())))
                        {
                            bool __tmp129_first = true;
                            bool __tmp129_last = __tmp129Reader.EndOfStream;
                            while(__tmp129_first || !__tmp129_last)
                            {
                                __tmp129_first = false;
                                string __tmp129Line = __tmp129Reader.ReadLine();
                                __tmp129_last = __tmp129Reader.EndOfStream;
                                if (__tmp129Line != null) __out.Append(__tmp129Line);
                                if (!__tmp129_last) __out.AppendLine(true);
                            }
                        }
                        string __tmp130Line = "\" type=\""; //197:25
                        if (__tmp130Line != null) __out.Append(__tmp130Line);
                        StringBuilder __tmp131 = new StringBuilder();
                        __tmp131.Append(t.GetNamespace(ns).Prefix);
                        using(StreamReader __tmp131Reader = new StreamReader(this.__ToStream(__tmp131.ToString())))
                        {
                            bool __tmp131_first = true;
                            bool __tmp131_last = __tmp131Reader.EndOfStream;
                            while(__tmp131_first || !__tmp131_last)
                            {
                                __tmp131_first = false;
                                string __tmp131Line = __tmp131Reader.ReadLine();
                                __tmp131_last = __tmp131Reader.EndOfStream;
                                if (__tmp131Line != null) __out.Append(__tmp131Line);
                                if (!__tmp131_last) __out.AppendLine(true);
                            }
                        }
                        string __tmp132Line = ":"; //197:60
                        if (__tmp132Line != null) __out.Append(__tmp132Line);
                        StringBuilder __tmp133 = new StringBuilder();
                        __tmp133.Append(t.GetXsdName());
                        using(StreamReader __tmp133Reader = new StreamReader(this.__ToStream(__tmp133.ToString())))
                        {
                            bool __tmp133_first = true;
                            bool __tmp133_last = __tmp133Reader.EndOfStream;
                            while(__tmp133_first || !__tmp133_last)
                            {
                                __tmp133_first = false;
                                string __tmp133Line = __tmp133Reader.ReadLine();
                                __tmp133_last = __tmp133Reader.EndOfStream;
                                if (__tmp133Line != null) __out.Append(__tmp133Line);
                                if (!__tmp133_last) __out.AppendLine(true);
                            }
                        }
                        string __tmp134Line = "\" nillable=\""; //197:77
                        if (__tmp134Line != null) __out.Append(__tmp134Line);
                        StringBuilder __tmp135 = new StringBuilder();
                        __tmp135.Append(t.IsNullableXsd());
                        using(StreamReader __tmp135Reader = new StreamReader(this.__ToStream(__tmp135.ToString())))
                        {
                            bool __tmp135_first = true;
                            bool __tmp135_last = __tmp135Reader.EndOfStream;
                            while(__tmp135_first || !__tmp135_last)
                            {
                                __tmp135_first = false;
                                string __tmp135Line = __tmp135Reader.ReadLine();
                                __tmp135_last = __tmp135Reader.EndOfStream;
                                if (__tmp135Line != null) __out.Append(__tmp135Line);
                                if (!__tmp135_last) __out.AppendLine(true);
                            }
                        }
                        string __tmp136Line = "\""; //197:108
                        if (__tmp136Line != null) __out.Append(__tmp136Line);
                        StringBuilder __tmp137 = new StringBuilder();
                        __tmp137.Append(GetElementOptional(ae));
                        using(StreamReader __tmp137Reader = new StreamReader(this.__ToStream(__tmp137.ToString())))
                        {
                            bool __tmp137_first = true;
                            bool __tmp137_last = __tmp137Reader.EndOfStream;
                            while(__tmp137_first || !__tmp137_last)
                            {
                                __tmp137_first = false;
                                string __tmp137Line = __tmp137Reader.ReadLine();
                                __tmp137_last = __tmp137Reader.EndOfStream;
                                if (__tmp137Line != null) __out.Append(__tmp137Line);
                                if (!__tmp137_last) __out.AppendLine(true);
                            }
                        }
                        string __tmp138Line = "/>"; //197:133
                        if (__tmp138Line != null) __out.Append(__tmp138Line);
                        __out.AppendLine(false); //197:135
                    }
                }
            }
            return __out.ToString();
        }

        public string GenerateParamType(Namespace ns, string name, SoalType t, AnnotatedElement ae) //203:1
        {
            StringBuilder __out = new StringBuilder();
            Annotation restrAnnot = ae.GetAnnotation(SoalAnnotations.Restriction); //204:2
            if (t.IsArrayType()) //205:2
            {
                ArrayType array = t is NonNullableType ? (ArrayType)((NonNullableType)t).InnerType : (ArrayType)t; //206:3
                if (array.GetCoreType() != SoalInstance.Byte) //207:3
                {
                    string items = ae.GetAnnotationPropertyValue(SoalAnnotations.Element, SoalAnnotationProperties.Items) as string; //208:4
                    string __tmp2Line = "<xs:complexType name=\""; //209:1
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
                    string __tmp4Line = "\">"; //209:29
                    if (__tmp4Line != null) __out.Append(__tmp4Line);
                    __out.AppendLine(false); //209:31
                    object sap = ae.GetAnnotationPropertyValue(SoalAnnotations.Element, SoalAnnotationProperties.Sap); //210:4
                    if (sap != null && (bool)sap) //211:4
                    {
                        __out.Append("	<xs:all>"); //212:1
                        __out.AppendLine(false); //212:10
                        __out.Append("		<xs:element name=\"item\" minOccurs=\"0\" maxOccurs=\"unbounded\">"); //213:1
                        __out.AppendLine(false); //213:63
                        __out.Append("			<xs:complexType>"); //214:1
                        __out.AppendLine(false); //214:20
                        __out.Append("				<xs:all>"); //215:1
                        __out.AppendLine(false); //215:13
                        if (restrAnnot != null && array.InnerType.GetCoreType() is PrimitiveType) //216:5
                        {
                            if (items != null) //217:6
                            {
                                string __tmp6Line = "					<xs:element name=\""; //218:1
                                if (__tmp6Line != null) __out.Append(__tmp6Line);
                                StringBuilder __tmp7 = new StringBuilder();
                                __tmp7.Append(items);
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
                                string __tmp8Line = "\" nillable=\""; //218:31
                                if (__tmp8Line != null) __out.Append(__tmp8Line);
                                StringBuilder __tmp9 = new StringBuilder();
                                __tmp9.Append(array.InnerType.IsNullableXsd());
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
                                string __tmp10Line = "\">"; //218:76
                                if (__tmp10Line != null) __out.Append(__tmp10Line);
                                __out.AppendLine(false); //218:78
                            }
                            else //219:6
                            {
                                string __tmp12Line = "					<xs:element name=\""; //220:1
                                if (__tmp12Line != null) __out.Append(__tmp12Line);
                                StringBuilder __tmp13 = new StringBuilder();
                                __tmp13.Append(array.InnerType.GetXsdName());
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
                                string __tmp14Line = "\" nillable=\""; //220:54
                                if (__tmp14Line != null) __out.Append(__tmp14Line);
                                StringBuilder __tmp15 = new StringBuilder();
                                __tmp15.Append(array.InnerType.IsNullableXsd());
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
                                string __tmp16Line = "\">"; //220:99
                                if (__tmp16Line != null) __out.Append(__tmp16Line);
                                __out.AppendLine(false); //220:101
                            }
                            string __tmp17Prefix = "					"; //222:1
                            StringBuilder __tmp18 = new StringBuilder();
                            __tmp18.Append(GenerateRestrictions(array.InnerType.GetNamespace(ns).Prefix + ":" + array.InnerType.GetXsdName(), restrAnnot));
                            using(StreamReader __tmp18Reader = new StreamReader(this.__ToStream(__tmp18.ToString())))
                            {
                                bool __tmp18_first = true;
                                bool __tmp18_last = __tmp18Reader.EndOfStream;
                                while(__tmp18_first || !__tmp18_last)
                                {
                                    __tmp18_first = false;
                                    string __tmp18Line = __tmp18Reader.ReadLine();
                                    __tmp18_last = __tmp18Reader.EndOfStream;
                                    __out.Append(__tmp17Prefix);
                                    if (__tmp18Line != null) __out.Append(__tmp18Line);
                                    if (!__tmp18_last) __out.AppendLine(true);
                                    __out.AppendLine(false); //222:114
                                }
                            }
                        }
                        else //223:5
                        {
                            if (items != null) //224:6
                            {
                                string __tmp20Line = "					<xs:element name=\""; //225:1
                                if (__tmp20Line != null) __out.Append(__tmp20Line);
                                StringBuilder __tmp21 = new StringBuilder();
                                __tmp21.Append(items);
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
                                string __tmp22Line = "\" type=\""; //225:31
                                if (__tmp22Line != null) __out.Append(__tmp22Line);
                                StringBuilder __tmp23 = new StringBuilder();
                                __tmp23.Append(array.InnerType.GetNamespace(ns).Prefix);
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
                                string __tmp24Line = ":"; //225:80
                                if (__tmp24Line != null) __out.Append(__tmp24Line);
                                StringBuilder __tmp25 = new StringBuilder();
                                __tmp25.Append(array.InnerType.GetXsdName());
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
                                string __tmp26Line = "\" nillable=\""; //225:111
                                if (__tmp26Line != null) __out.Append(__tmp26Line);
                                StringBuilder __tmp27 = new StringBuilder();
                                __tmp27.Append(array.InnerType.IsNullableXsd());
                                using(StreamReader __tmp27Reader = new StreamReader(this.__ToStream(__tmp27.ToString())))
                                {
                                    bool __tmp27_first = true;
                                    bool __tmp27_last = __tmp27Reader.EndOfStream;
                                    while(__tmp27_first || !__tmp27_last)
                                    {
                                        __tmp27_first = false;
                                        string __tmp27Line = __tmp27Reader.ReadLine();
                                        __tmp27_last = __tmp27Reader.EndOfStream;
                                        if (__tmp27Line != null) __out.Append(__tmp27Line);
                                        if (!__tmp27_last) __out.AppendLine(true);
                                    }
                                }
                                string __tmp28Line = "\"/>"; //225:156
                                if (__tmp28Line != null) __out.Append(__tmp28Line);
                                __out.AppendLine(false); //225:159
                            }
                            else //226:6
                            {
                                string __tmp30Line = "					<xs:element name=\""; //227:1
                                if (__tmp30Line != null) __out.Append(__tmp30Line);
                                StringBuilder __tmp31 = new StringBuilder();
                                __tmp31.Append(array.InnerType.GetXsdName());
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
                                string __tmp32Line = "\" type=\""; //227:54
                                if (__tmp32Line != null) __out.Append(__tmp32Line);
                                StringBuilder __tmp33 = new StringBuilder();
                                __tmp33.Append(array.InnerType.GetNamespace(ns).Prefix);
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
                                string __tmp34Line = ":"; //227:103
                                if (__tmp34Line != null) __out.Append(__tmp34Line);
                                StringBuilder __tmp35 = new StringBuilder();
                                __tmp35.Append(array.InnerType.GetXsdName());
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
                                string __tmp36Line = "\" nillable=\""; //227:134
                                if (__tmp36Line != null) __out.Append(__tmp36Line);
                                StringBuilder __tmp37 = new StringBuilder();
                                __tmp37.Append(array.InnerType.IsNullableXsd());
                                using(StreamReader __tmp37Reader = new StreamReader(this.__ToStream(__tmp37.ToString())))
                                {
                                    bool __tmp37_first = true;
                                    bool __tmp37_last = __tmp37Reader.EndOfStream;
                                    while(__tmp37_first || !__tmp37_last)
                                    {
                                        __tmp37_first = false;
                                        string __tmp37Line = __tmp37Reader.ReadLine();
                                        __tmp37_last = __tmp37Reader.EndOfStream;
                                        if (__tmp37Line != null) __out.Append(__tmp37Line);
                                        if (!__tmp37_last) __out.AppendLine(true);
                                    }
                                }
                                string __tmp38Line = "\"/>"; //227:179
                                if (__tmp38Line != null) __out.Append(__tmp38Line);
                                __out.AppendLine(false); //227:182
                            }
                        }
                        __out.Append("				</xs:all>"); //230:1
                        __out.AppendLine(false); //230:14
                        __out.Append("			</xs:complexType>"); //231:1
                        __out.AppendLine(false); //231:21
                        __out.Append("		</xs:element>"); //232:1
                        __out.AppendLine(false); //232:16
                        __out.Append("	</xs:all>"); //233:1
                        __out.AppendLine(false); //233:11
                    }
                    else //234:4
                    {
                        __out.Append("	<xs:sequence>"); //235:1
                        __out.AppendLine(false); //235:15
                        if (restrAnnot != null && array.InnerType.GetCoreType() is PrimitiveType) //236:5
                        {
                            if (items != null) //237:6
                            {
                                string __tmp40Line = "		<xs:element name=\""; //238:1
                                if (__tmp40Line != null) __out.Append(__tmp40Line);
                                StringBuilder __tmp41 = new StringBuilder();
                                __tmp41.Append(items);
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
                                string __tmp42Line = "\" nillable=\""; //238:28
                                if (__tmp42Line != null) __out.Append(__tmp42Line);
                                StringBuilder __tmp43 = new StringBuilder();
                                __tmp43.Append(array.InnerType.IsNullableXsd());
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
                                string __tmp44Line = "\" minOccurs=\"0\" maxOccurs=\"unbounded\">"; //238:73
                                if (__tmp44Line != null) __out.Append(__tmp44Line);
                                __out.AppendLine(false); //238:111
                            }
                            else //239:6
                            {
                                string __tmp46Line = "		<xs:element name=\""; //240:1
                                if (__tmp46Line != null) __out.Append(__tmp46Line);
                                StringBuilder __tmp47 = new StringBuilder();
                                __tmp47.Append(array.InnerType.GetXsdName());
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
                                string __tmp48Line = "\" nillable=\""; //240:51
                                if (__tmp48Line != null) __out.Append(__tmp48Line);
                                StringBuilder __tmp49 = new StringBuilder();
                                __tmp49.Append(array.InnerType.IsNullableXsd());
                                using(StreamReader __tmp49Reader = new StreamReader(this.__ToStream(__tmp49.ToString())))
                                {
                                    bool __tmp49_first = true;
                                    bool __tmp49_last = __tmp49Reader.EndOfStream;
                                    while(__tmp49_first || !__tmp49_last)
                                    {
                                        __tmp49_first = false;
                                        string __tmp49Line = __tmp49Reader.ReadLine();
                                        __tmp49_last = __tmp49Reader.EndOfStream;
                                        if (__tmp49Line != null) __out.Append(__tmp49Line);
                                        if (!__tmp49_last) __out.AppendLine(true);
                                    }
                                }
                                string __tmp50Line = "\" minOccurs=\"0\" maxOccurs=\"unbounded\">"; //240:96
                                if (__tmp50Line != null) __out.Append(__tmp50Line);
                                __out.AppendLine(false); //240:134
                            }
                            string __tmp51Prefix = "		"; //242:1
                            StringBuilder __tmp52 = new StringBuilder();
                            __tmp52.Append(GenerateRestrictions(array.InnerType.GetNamespace(ns).Prefix + ":" + array.InnerType.GetXsdName(), restrAnnot));
                            using(StreamReader __tmp52Reader = new StreamReader(this.__ToStream(__tmp52.ToString())))
                            {
                                bool __tmp52_first = true;
                                bool __tmp52_last = __tmp52Reader.EndOfStream;
                                while(__tmp52_first || !__tmp52_last)
                                {
                                    __tmp52_first = false;
                                    string __tmp52Line = __tmp52Reader.ReadLine();
                                    __tmp52_last = __tmp52Reader.EndOfStream;
                                    __out.Append(__tmp51Prefix);
                                    if (__tmp52Line != null) __out.Append(__tmp52Line);
                                    if (!__tmp52_last) __out.AppendLine(true);
                                    __out.AppendLine(false); //242:111
                                }
                            }
                        }
                        else //243:5
                        {
                            if (items != null) //244:6
                            {
                                string __tmp54Line = "		<xs:element name=\""; //245:1
                                if (__tmp54Line != null) __out.Append(__tmp54Line);
                                StringBuilder __tmp55 = new StringBuilder();
                                __tmp55.Append(items);
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
                                string __tmp56Line = "\" type=\""; //245:28
                                if (__tmp56Line != null) __out.Append(__tmp56Line);
                                StringBuilder __tmp57 = new StringBuilder();
                                __tmp57.Append(array.InnerType.GetNamespace(ns).Prefix);
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
                                string __tmp58Line = ":"; //245:77
                                if (__tmp58Line != null) __out.Append(__tmp58Line);
                                StringBuilder __tmp59 = new StringBuilder();
                                __tmp59.Append(array.InnerType.GetXsdName());
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
                                string __tmp60Line = "\" nillable=\""; //245:108
                                if (__tmp60Line != null) __out.Append(__tmp60Line);
                                StringBuilder __tmp61 = new StringBuilder();
                                __tmp61.Append(array.InnerType.IsNullableXsd());
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
                                string __tmp62Line = "\" minOccurs=\"0\" maxOccurs=\"unbounded\"/>"; //245:153
                                if (__tmp62Line != null) __out.Append(__tmp62Line);
                                __out.AppendLine(false); //245:192
                            }
                            else //246:6
                            {
                                string __tmp64Line = "		<xs:element name=\""; //247:1
                                if (__tmp64Line != null) __out.Append(__tmp64Line);
                                StringBuilder __tmp65 = new StringBuilder();
                                __tmp65.Append(array.InnerType.GetXsdName());
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
                                string __tmp66Line = "\" type=\""; //247:51
                                if (__tmp66Line != null) __out.Append(__tmp66Line);
                                StringBuilder __tmp67 = new StringBuilder();
                                __tmp67.Append(array.InnerType.GetNamespace(ns).Prefix);
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
                                string __tmp68Line = ":"; //247:100
                                if (__tmp68Line != null) __out.Append(__tmp68Line);
                                StringBuilder __tmp69 = new StringBuilder();
                                __tmp69.Append(array.InnerType.GetXsdName());
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
                                string __tmp70Line = "\" nillable=\""; //247:131
                                if (__tmp70Line != null) __out.Append(__tmp70Line);
                                StringBuilder __tmp71 = new StringBuilder();
                                __tmp71.Append(array.InnerType.IsNullableXsd());
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
                                string __tmp72Line = "\" minOccurs=\"0\" maxOccurs=\"unbounded\"/>"; //247:176
                                if (__tmp72Line != null) __out.Append(__tmp72Line);
                                __out.AppendLine(false); //247:215
                            }
                        }
                        __out.Append("	</xs:sequence>"); //250:1
                        __out.AppendLine(false); //250:16
                    }
                    __out.Append("</xs:complexType>"); //252:1
                    __out.AppendLine(false); //252:18
                }
            }
            return __out.ToString();
        }

        public string GenerateRestrictions(string baseType, Annotation ae) //257:1
        {
            StringBuilder __out = new StringBuilder();
            __out.Append("	<xs:simpleType>"); //258:1
            __out.AppendLine(false); //258:17
            string __tmp2Line = "		<xs:restriction base=\""; //259:1
            if (__tmp2Line != null) __out.Append(__tmp2Line);
            StringBuilder __tmp3 = new StringBuilder();
            __tmp3.Append(baseType);
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
            string __tmp4Line = "\">"; //259:35
            if (__tmp4Line != null) __out.Append(__tmp4Line);
            __out.AppendLine(false); //259:37
            var __loop13_results = 
                (from __loop13_var1 in __Enumerate((ae).GetEnumerator()) //260:10
                from prop in __Enumerate((__loop13_var1.Properties).GetEnumerator()) //260:14
                select new { __loop13_var1 = __loop13_var1, prop = prop}
                ).ToList(); //260:5
            int __loop13_iteration = 0;
            foreach (var __tmp5 in __loop13_results)
            {
                ++__loop13_iteration;
                var __loop13_var1 = __tmp5.__loop13_var1;
                var prop = __tmp5.prop;
                string __tmp7Line = "			<xs:"; //261:1
                if (__tmp7Line != null) __out.Append(__tmp7Line);
                StringBuilder __tmp8 = new StringBuilder();
                __tmp8.Append(prop.Name);
                using(StreamReader __tmp8Reader = new StreamReader(this.__ToStream(__tmp8.ToString())))
                {
                    bool __tmp8_first = true;
                    bool __tmp8_last = __tmp8Reader.EndOfStream;
                    while(__tmp8_first || !__tmp8_last)
                    {
                        __tmp8_first = false;
                        string __tmp8Line = __tmp8Reader.ReadLine();
                        __tmp8_last = __tmp8Reader.EndOfStream;
                        if (__tmp8Line != null) __out.Append(__tmp8Line);
                        if (!__tmp8_last) __out.AppendLine(true);
                    }
                }
                string __tmp9Line = " value=\""; //261:19
                if (__tmp9Line != null) __out.Append(__tmp9Line);
                StringBuilder __tmp10 = new StringBuilder();
                __tmp10.Append(prop.Value);
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
                string __tmp11Line = "\"/>"; //261:39
                if (__tmp11Line != null) __out.Append(__tmp11Line);
                __out.AppendLine(false); //261:42
            }
            __out.Append("		</xs:restriction>"); //263:1
            __out.AppendLine(false); //263:20
            __out.Append("	</xs:simpleType>"); //264:1
            __out.AppendLine(false); //264:18
            __out.Append("</xs:element>"); //265:1
            __out.AppendLine(false); //265:14
            return __out.ToString();
        }

        public string GetStructKind(Struct st) //268:1
        {
            if (st.HasAnnotation(SoalAnnotations.Choice)) //269:2
            {
                return "choice"; //270:3
            }
            else if (st.HasAnnotation(SoalAnnotations.All)) //271:2
            {
                return "all"; //272:3
            }
            else //273:2
            {
                return "sequence"; //274:3
            }
        }

        public string GetElementOptional(AnnotatedElement ae) //278:1
        {
            object optional = ae.GetAnnotationPropertyValue(SoalAnnotations.Element, SoalAnnotationProperties.Optional); //279:2
            if (optional != null && (bool)optional) //280:2
            {
                return " minOccurs=\"0\""; //281:3
            }
            else //282:2
            {
                return ""; //283:3
            }
        }

        public string GetAttributeRequired(AnnotatedElement ae) //287:1
        {
            object required = ae.GetAnnotationPropertyValue(SoalAnnotations.Attribute, SoalAnnotationProperties.Required); //288:2
            if (required != null && (bool)required) //289:2
            {
                return " use=\"required\""; //290:3
            }
            else //291:2
            {
                return ""; //292:3
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
