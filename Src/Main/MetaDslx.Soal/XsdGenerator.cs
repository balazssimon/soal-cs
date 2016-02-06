using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Soal //1:1
{
    using __Hidden_XsdGenerator_1645829794;
    namespace __Hidden_XsdGenerator_1645829794
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
                string __tmp26Prefix = string.Empty;
                string __tmp27Line = "	<xs:element name=\""; //26:1
                __out.Append(__tmp26Prefix);
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
                string __tmp34Prefix = string.Empty;
                string __tmp35Line = "	<xs:simpleType name=\""; //27:1
                __out.Append(__tmp34Prefix);
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
                __out.Append("		<xs:restriction base=\"xs:string\">"); //28:1
                __out.AppendLine(false); //28:36
                var __loop4_results = 
                    (from __loop4_var1 in __Enumerate((etype).GetEnumerator()) //29:10
                    from elit in __Enumerate((__loop4_var1.EnumLiterals).GetEnumerator()) //29:17
                    select new { __loop4_var1 = __loop4_var1, elit = elit}
                    ).ToList(); //29:5
                int __loop4_iteration = 0;
                foreach (var __tmp38 in __loop4_results)
                {
                    ++__loop4_iteration;
                    var __loop4_var1 = __tmp38.__loop4_var1;
                    var elit = __tmp38.elit;
                    if (elit.HasAnnotationProperty(SoalAnnotations.Enum, SoalAnnotationProperties.Name)) //30:6
                    {
                        string __tmp39Prefix = string.Empty;
                        string __tmp40Line = "			<xs:enumeration value=\""; //31:1
                        __out.Append(__tmp39Prefix);
                        if (__tmp40Line != null) __out.Append(__tmp40Line);
                        StringBuilder __tmp41 = new StringBuilder();
                        __tmp41.Append(elit.GetAnnotationPropertyValue(SoalAnnotations.Enum, SoalAnnotationProperties.Name));
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
                        string __tmp42Line = "\"/>"; //31:113
                        if (__tmp42Line != null) __out.Append(__tmp42Line);
                        __out.AppendLine(false); //31:116
                    }
                    else //32:6
                    {
                        string __tmp43Prefix = string.Empty;
                        string __tmp44Line = "			<xs:enumeration value=\""; //33:1
                        __out.Append(__tmp43Prefix);
                        if (__tmp44Line != null) __out.Append(__tmp44Line);
                        StringBuilder __tmp45 = new StringBuilder();
                        __tmp45.Append(elit.Name);
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
                        string __tmp46Line = "\"/>"; //33:38
                        if (__tmp46Line != null) __out.Append(__tmp46Line);
                        __out.AppendLine(false); //33:41
                    }
                }
                __out.Append("		</xs:restriction>"); //36:1
                __out.AppendLine(false); //36:20
                __out.Append("	</xs:simpleType>"); //37:1
                __out.AppendLine(false); //37:18
            }
            var __loop5_results = 
                (from __loop5_var1 in __Enumerate((ns.Declarations).GetEnumerator()) //39:8
                from stype in __Enumerate((__loop5_var1).GetEnumerator()).OfType<Struct>() //39:25
                select new { __loop5_var1 = __loop5_var1, stype = stype}
                ).ToList(); //39:3
            int __loop5_iteration = 0;
            foreach (var __tmp47 in __loop5_results)
            {
                ++__loop5_iteration;
                var __loop5_var1 = __tmp47.__loop5_var1;
                var stype = __tmp47.stype;
                __out.AppendLine(true); //40:1
                string __tmp48Prefix = string.Empty;
                string __tmp49Line = "	<xs:element name=\""; //41:1
                __out.Append(__tmp48Prefix);
                if (__tmp49Line != null) __out.Append(__tmp49Line);
                StringBuilder __tmp50 = new StringBuilder();
                __tmp50.Append(stype.GetXsdName());
                using(StreamReader __tmp50Reader = new StreamReader(this.__ToStream(__tmp50.ToString())))
                {
                    bool __tmp50_first = true;
                    bool __tmp50_last = __tmp50Reader.EndOfStream;
                    while(__tmp50_first || !__tmp50_last)
                    {
                        __tmp50_first = false;
                        string __tmp50Line = __tmp50Reader.ReadLine();
                        __tmp50_last = __tmp50Reader.EndOfStream;
                        if (__tmp50Line != null) __out.Append(__tmp50Line);
                        if (!__tmp50_last) __out.AppendLine(true);
                    }
                }
                string __tmp51Line = "\" type=\""; //41:40
                if (__tmp51Line != null) __out.Append(__tmp51Line);
                StringBuilder __tmp52 = new StringBuilder();
                __tmp52.Append(ns.Prefix);
                using(StreamReader __tmp52Reader = new StreamReader(this.__ToStream(__tmp52.ToString())))
                {
                    bool __tmp52_first = true;
                    bool __tmp52_last = __tmp52Reader.EndOfStream;
                    while(__tmp52_first || !__tmp52_last)
                    {
                        __tmp52_first = false;
                        string __tmp52Line = __tmp52Reader.ReadLine();
                        __tmp52_last = __tmp52Reader.EndOfStream;
                        if (__tmp52Line != null) __out.Append(__tmp52Line);
                        if (!__tmp52_last) __out.AppendLine(true);
                    }
                }
                string __tmp53Line = ":"; //41:59
                if (__tmp53Line != null) __out.Append(__tmp53Line);
                StringBuilder __tmp54 = new StringBuilder();
                __tmp54.Append(stype.GetXsdName());
                using(StreamReader __tmp54Reader = new StreamReader(this.__ToStream(__tmp54.ToString())))
                {
                    bool __tmp54_first = true;
                    bool __tmp54_last = __tmp54Reader.EndOfStream;
                    while(__tmp54_first || !__tmp54_last)
                    {
                        __tmp54_first = false;
                        string __tmp54Line = __tmp54Reader.ReadLine();
                        __tmp54_last = __tmp54Reader.EndOfStream;
                        if (__tmp54Line != null) __out.Append(__tmp54Line);
                        if (!__tmp54_last) __out.AppendLine(true);
                    }
                }
                string __tmp55Line = "\"/>"; //41:80
                if (__tmp55Line != null) __out.Append(__tmp55Line);
                __out.AppendLine(false); //41:83
                string __tmp56Prefix = string.Empty;
                string __tmp57Line = "	<xs:complexType name=\""; //42:1
                __out.Append(__tmp56Prefix);
                if (__tmp57Line != null) __out.Append(__tmp57Line);
                StringBuilder __tmp58 = new StringBuilder();
                __tmp58.Append(stype.GetXsdName());
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
                string __tmp59Line = "\">"; //42:44
                if (__tmp59Line != null) __out.Append(__tmp59Line);
                __out.AppendLine(false); //42:46
                if (stype.BaseType != null) //43:4
                {
                    __out.Append("		<xs:complexContent>"); //44:1
                    __out.AppendLine(false); //44:22
                    string __tmp60Prefix = string.Empty;
                    string __tmp61Line = "			<xs:extension base=\""; //45:1
                    __out.Append(__tmp60Prefix);
                    if (__tmp61Line != null) __out.Append(__tmp61Line);
                    StringBuilder __tmp62 = new StringBuilder();
                    __tmp62.Append(stype.BaseType.GetNamespace(ns).Prefix);
                    using(StreamReader __tmp62Reader = new StreamReader(this.__ToStream(__tmp62.ToString())))
                    {
                        bool __tmp62_first = true;
                        bool __tmp62_last = __tmp62Reader.EndOfStream;
                        while(__tmp62_first || !__tmp62_last)
                        {
                            __tmp62_first = false;
                            string __tmp62Line = __tmp62Reader.ReadLine();
                            __tmp62_last = __tmp62Reader.EndOfStream;
                            if (__tmp62Line != null) __out.Append(__tmp62Line);
                            if (!__tmp62_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp63Line = ":"; //45:64
                    if (__tmp63Line != null) __out.Append(__tmp63Line);
                    StringBuilder __tmp64 = new StringBuilder();
                    __tmp64.Append(stype.BaseType.GetXsdName());
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
                    string __tmp65Line = "\">"; //45:94
                    if (__tmp65Line != null) __out.Append(__tmp65Line);
                    __out.AppendLine(false); //45:96
                    string __tmp66Prefix = "				"; //46:1
                    StringBuilder __tmp67 = new StringBuilder();
                    __tmp67.Append(GenerateStructBody(ns, stype));
                    using(StreamReader __tmp67Reader = new StreamReader(this.__ToStream(__tmp67.ToString())))
                    {
                        bool __tmp67_first = true;
                        bool __tmp67_last = __tmp67Reader.EndOfStream;
                        while(__tmp67_first || !__tmp67_last)
                        {
                            __tmp67_first = false;
                            string __tmp67Line = __tmp67Reader.ReadLine();
                            __tmp67_last = __tmp67Reader.EndOfStream;
                            __out.Append(__tmp66Prefix);
                            if (__tmp67Line != null) __out.Append(__tmp67Line);
                            if (!__tmp67_last) __out.AppendLine(true);
                            __out.AppendLine(false); //46:36
                        }
                    }
                    __out.Append("			</xs:extension>"); //47:1
                    __out.AppendLine(false); //47:19
                    __out.Append("		</xs:complexContent>"); //48:1
                    __out.AppendLine(false); //48:23
                }
                else //49:4
                {
                    string __tmp68Prefix = "		"; //50:1
                    StringBuilder __tmp69 = new StringBuilder();
                    __tmp69.Append(GenerateStructBody(ns, stype));
                    using(StreamReader __tmp69Reader = new StreamReader(this.__ToStream(__tmp69.ToString())))
                    {
                        bool __tmp69_first = true;
                        bool __tmp69_last = __tmp69Reader.EndOfStream;
                        while(__tmp69_first || !__tmp69_last)
                        {
                            __tmp69_first = false;
                            string __tmp69Line = __tmp69Reader.ReadLine();
                            __tmp69_last = __tmp69Reader.EndOfStream;
                            __out.Append(__tmp68Prefix);
                            if (__tmp69Line != null) __out.Append(__tmp69Line);
                            if (!__tmp69_last) __out.AppendLine(true);
                            __out.AppendLine(false); //50:34
                        }
                    }
                }
                __out.Append("	</xs:complexType>"); //52:1
                __out.AppendLine(false); //52:19
            }
            var __loop6_results = 
                (from __loop6_var1 in __Enumerate((ns.Declarations).GetEnumerator()) //54:8
                from intf in __Enumerate((__loop6_var1).GetEnumerator()).OfType<Interface>() //54:25
                from op in __Enumerate((intf.Operations).GetEnumerator()) //54:49
                select new { __loop6_var1 = __loop6_var1, intf = intf, op = op}
                ).ToList(); //54:3
            int __loop6_iteration = 0;
            foreach (var __tmp70 in __loop6_results)
            {
                ++__loop6_iteration;
                var __loop6_var1 = __tmp70.__loop6_var1;
                var intf = __tmp70.intf;
                var op = __tmp70.op;
                if (intf.HasAnnotation(SoalAnnotations.Rpc)) //55:4
                {
                    var __loop7_results = 
                        (from __loop7_var1 in __Enumerate((op).GetEnumerator()) //56:10
                        from param in __Enumerate((__loop7_var1.Parameters).GetEnumerator()) //56:14
                        where param.Type.IsArrayType() && param.Type.GetCoreType() != SoalInstance.Byte //56:31
                        select new { __loop7_var1 = __loop7_var1, param = param}
                        ).ToList(); //56:5
                    int __loop7_iteration = 0;
                    foreach (var __tmp71 in __loop7_results)
                    {
                        ++__loop7_iteration;
                        var __loop7_var1 = __tmp71.__loop7_var1;
                        var param = __tmp71.param;
                        __out.AppendLine(true); //57:1
                        string __tmp72Prefix = "	"; //58:1
                        StringBuilder __tmp73 = new StringBuilder();
                        __tmp73.Append(GenerateParamType(ns, op.Name + param.Name.ToPascalCase(), param.Type, param.Annotations));
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
                                __out.AppendLine(false); //58:93
                            }
                        }
                    }
                    if (op.ReturnType.IsArrayType() && op.ReturnType.GetCoreType() != SoalInstance.Byte) //60:5
                    {
                        __out.AppendLine(true); //61:1
                        string __tmp74Prefix = "	"; //62:1
                        StringBuilder __tmp75 = new StringBuilder();
                        __tmp75.Append(GenerateParamType(ns, op.Name + "Response", op.ReturnType, op.ReturnAnnotations));
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
                                __out.AppendLine(false); //62:84
                            }
                        }
                    }
                }
                else //64:4
                {
                    if (intf.HasAnnotation(SoalAnnotations.NoWrap)) //65:5
                    {
                        var __loop8_results = 
                            (from __loop8_var1 in __Enumerate((op).GetEnumerator()) //66:11
                            from param in __Enumerate((__loop8_var1.Parameters).GetEnumerator()) //66:15
                            select new { __loop8_var1 = __loop8_var1, param = param}
                            ).ToList(); //66:6
                        int __loop8_iteration = 0;
                        foreach (var __tmp76 in __loop8_results)
                        {
                            ++__loop8_iteration;
                            var __loop8_var1 = __tmp76.__loop8_var1;
                            var param = __tmp76.param;
                            string __tmp77Prefix = "	"; //67:1
                            StringBuilder __tmp78 = new StringBuilder();
                            __tmp78.Append(GenerateElement(ns, op.Name + param.Name.ToPascalCase(), param.Type, param.Annotations));
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
                                    __out.AppendLine(false); //67:91
                                }
                            }
                        }
                        if (op.ReturnType != SoalInstance.Void) //69:6
                        {
                            string __tmp79Prefix = "	"; //70:1
                            StringBuilder __tmp80 = new StringBuilder();
                            __tmp80.Append(GenerateElement(ns, op.Name + "Response", op.ReturnType, op.ReturnAnnotations));
                            using(StreamReader __tmp80Reader = new StreamReader(this.__ToStream(__tmp80.ToString())))
                            {
                                bool __tmp80_first = true;
                                bool __tmp80_last = __tmp80Reader.EndOfStream;
                                while(__tmp80_first || !__tmp80_last)
                                {
                                    __tmp80_first = false;
                                    string __tmp80Line = __tmp80Reader.ReadLine();
                                    __tmp80_last = __tmp80Reader.EndOfStream;
                                    __out.Append(__tmp79Prefix);
                                    if (__tmp80Line != null) __out.Append(__tmp80Line);
                                    if (!__tmp80_last) __out.AppendLine(true);
                                    __out.AppendLine(false); //70:82
                                }
                            }
                        }
                    }
                    else //72:5
                    {
                        __out.AppendLine(true); //73:1
                        string __tmp81Prefix = string.Empty;
                        string __tmp82Line = "	<xs:element name=\""; //74:1
                        __out.Append(__tmp81Prefix);
                        if (__tmp82Line != null) __out.Append(__tmp82Line);
                        StringBuilder __tmp83 = new StringBuilder();
                        __tmp83.Append(op.Name);
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
                        string __tmp84Line = "\" type=\""; //74:29
                        if (__tmp84Line != null) __out.Append(__tmp84Line);
                        StringBuilder __tmp85 = new StringBuilder();
                        __tmp85.Append(ns.Prefix);
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
                        string __tmp86Line = ":"; //74:48
                        if (__tmp86Line != null) __out.Append(__tmp86Line);
                        StringBuilder __tmp87 = new StringBuilder();
                        __tmp87.Append(op.Name);
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
                        string __tmp88Line = "\"/>"; //74:58
                        if (__tmp88Line != null) __out.Append(__tmp88Line);
                        __out.AppendLine(false); //74:61
                        string __tmp89Prefix = string.Empty;
                        string __tmp90Line = "	<xs:complexType name=\""; //75:1
                        __out.Append(__tmp89Prefix);
                        if (__tmp90Line != null) __out.Append(__tmp90Line);
                        StringBuilder __tmp91 = new StringBuilder();
                        __tmp91.Append(op.Name);
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
                        string __tmp92Line = "\">"; //75:33
                        if (__tmp92Line != null) __out.Append(__tmp92Line);
                        __out.AppendLine(false); //75:35
                        __out.Append("		<xs:sequence>"); //76:1
                        __out.AppendLine(false); //76:16
                        var __loop9_results = 
                            (from __loop9_var1 in __Enumerate((op).GetEnumerator()) //77:11
                            from param in __Enumerate((__loop9_var1.Parameters).GetEnumerator()) //77:15
                            where !param.HasAnnotation(SoalAnnotations.Attribute) //77:32
                            select new { __loop9_var1 = __loop9_var1, param = param}
                            ).ToList(); //77:6
                        int __loop9_iteration = 0;
                        foreach (var __tmp93 in __loop9_results)
                        {
                            ++__loop9_iteration;
                            var __loop9_var1 = __tmp93.__loop9_var1;
                            var param = __tmp93.param;
                            string __tmp94Prefix = "			"; //78:1
                            StringBuilder __tmp95 = new StringBuilder();
                            __tmp95.Append(GenerateElement(ns, param.Name, param.Type, param.Annotations));
                            using(StreamReader __tmp95Reader = new StreamReader(this.__ToStream(__tmp95.ToString())))
                            {
                                bool __tmp95_first = true;
                                bool __tmp95_last = __tmp95Reader.EndOfStream;
                                while(__tmp95_first || !__tmp95_last)
                                {
                                    __tmp95_first = false;
                                    string __tmp95Line = __tmp95Reader.ReadLine();
                                    __tmp95_last = __tmp95Reader.EndOfStream;
                                    __out.Append(__tmp94Prefix);
                                    if (__tmp95Line != null) __out.Append(__tmp95Line);
                                    if (!__tmp95_last) __out.AppendLine(true);
                                    __out.AppendLine(false); //78:68
                                }
                            }
                        }
                        __out.Append("		</xs:sequence>"); //80:1
                        __out.AppendLine(false); //80:17
                        var __loop10_results = 
                            (from __loop10_var1 in __Enumerate((op).GetEnumerator()) //81:11
                            from param in __Enumerate((__loop10_var1.Parameters).GetEnumerator()) //81:15
                            where param.HasAnnotation(SoalAnnotations.Attribute) //81:32
                            select new { __loop10_var1 = __loop10_var1, param = param}
                            ).ToList(); //81:6
                        int __loop10_iteration = 0;
                        foreach (var __tmp96 in __loop10_results)
                        {
                            ++__loop10_iteration;
                            var __loop10_var1 = __tmp96.__loop10_var1;
                            var param = __tmp96.param;
                            string __tmp97Prefix = "		"; //82:1
                            StringBuilder __tmp98 = new StringBuilder();
                            __tmp98.Append(GenerateElement(ns, param.Name, param.Type, param.Annotations));
                            using(StreamReader __tmp98Reader = new StreamReader(this.__ToStream(__tmp98.ToString())))
                            {
                                bool __tmp98_first = true;
                                bool __tmp98_last = __tmp98Reader.EndOfStream;
                                while(__tmp98_first || !__tmp98_last)
                                {
                                    __tmp98_first = false;
                                    string __tmp98Line = __tmp98Reader.ReadLine();
                                    __tmp98_last = __tmp98Reader.EndOfStream;
                                    __out.Append(__tmp97Prefix);
                                    if (__tmp98Line != null) __out.Append(__tmp98Line);
                                    if (!__tmp98_last) __out.AppendLine(true);
                                    __out.AppendLine(false); //82:67
                                }
                            }
                        }
                        __out.Append("	</xs:complexType>"); //84:1
                        __out.AppendLine(false); //84:19
                        if (!op.IsOneway) //85:6
                        {
                            __out.AppendLine(true); //86:1
                            string __tmp99Prefix = string.Empty;
                            string __tmp100Line = "	<xs:element name=\""; //87:1
                            __out.Append(__tmp99Prefix);
                            if (__tmp100Line != null) __out.Append(__tmp100Line);
                            StringBuilder __tmp101 = new StringBuilder();
                            __tmp101.Append(op.Name);
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
                            string __tmp102Line = "Response\" type=\""; //87:29
                            if (__tmp102Line != null) __out.Append(__tmp102Line);
                            StringBuilder __tmp103 = new StringBuilder();
                            __tmp103.Append(ns.Prefix);
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
                            string __tmp104Line = ":"; //87:56
                            if (__tmp104Line != null) __out.Append(__tmp104Line);
                            StringBuilder __tmp105 = new StringBuilder();
                            __tmp105.Append(op.Name);
                            using(StreamReader __tmp105Reader = new StreamReader(this.__ToStream(__tmp105.ToString())))
                            {
                                bool __tmp105_first = true;
                                bool __tmp105_last = __tmp105Reader.EndOfStream;
                                while(__tmp105_first || !__tmp105_last)
                                {
                                    __tmp105_first = false;
                                    string __tmp105Line = __tmp105Reader.ReadLine();
                                    __tmp105_last = __tmp105Reader.EndOfStream;
                                    if (__tmp105Line != null) __out.Append(__tmp105Line);
                                    if (!__tmp105_last) __out.AppendLine(true);
                                }
                            }
                            string __tmp106Line = "Response\"/>"; //87:66
                            if (__tmp106Line != null) __out.Append(__tmp106Line);
                            __out.AppendLine(false); //87:77
                            string __tmp107Prefix = string.Empty;
                            string __tmp108Line = "	<xs:complexType name=\""; //88:1
                            __out.Append(__tmp107Prefix);
                            if (__tmp108Line != null) __out.Append(__tmp108Line);
                            StringBuilder __tmp109 = new StringBuilder();
                            __tmp109.Append(op.Name);
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
                            string __tmp110Line = "Response\">"; //88:33
                            if (__tmp110Line != null) __out.Append(__tmp110Line);
                            __out.AppendLine(false); //88:43
                            if (op.ReturnType == SoalInstance.Void || op.ReturnAnnotations.ContainsAnnotation(SoalAnnotations.Attribute)) //89:7
                            {
                                __out.Append("		<xs:sequence/>"); //90:1
                                __out.AppendLine(false); //90:17
                            }
                            else //91:7
                            {
                                __out.Append("		<xs:sequence>"); //92:1
                                __out.AppendLine(false); //92:16
                                string __tmp111Prefix = "			"; //93:1
                                StringBuilder __tmp112 = new StringBuilder();
                                __tmp112.Append(GenerateElement(ns, op.Name + "Result", op.ReturnType, op.ReturnAnnotations));
                                using(StreamReader __tmp112Reader = new StreamReader(this.__ToStream(__tmp112.ToString())))
                                {
                                    bool __tmp112_first = true;
                                    bool __tmp112_last = __tmp112Reader.EndOfStream;
                                    while(__tmp112_first || !__tmp112_last)
                                    {
                                        __tmp112_first = false;
                                        string __tmp112Line = __tmp112Reader.ReadLine();
                                        __tmp112_last = __tmp112Reader.EndOfStream;
                                        __out.Append(__tmp111Prefix);
                                        if (__tmp112Line != null) __out.Append(__tmp112Line);
                                        if (!__tmp112_last) __out.AppendLine(true);
                                        __out.AppendLine(false); //93:80
                                    }
                                }
                                __out.Append("		</xs:sequence>"); //94:1
                                __out.AppendLine(false); //94:17
                            }
                            if (op.ReturnAnnotations.ContainsAnnotation(SoalAnnotations.Attribute)) //96:7
                            {
                                string __tmp113Prefix = "		"; //97:1
                                StringBuilder __tmp114 = new StringBuilder();
                                __tmp114.Append(GenerateElement(ns, op.Name + "Result", op.ReturnType, op.ReturnAnnotations));
                                using(StreamReader __tmp114Reader = new StreamReader(this.__ToStream(__tmp114.ToString())))
                                {
                                    bool __tmp114_first = true;
                                    bool __tmp114_last = __tmp114Reader.EndOfStream;
                                    while(__tmp114_first || !__tmp114_last)
                                    {
                                        __tmp114_first = false;
                                        string __tmp114Line = __tmp114Reader.ReadLine();
                                        __tmp114_last = __tmp114Reader.EndOfStream;
                                        __out.Append(__tmp113Prefix);
                                        if (__tmp114Line != null) __out.Append(__tmp114Line);
                                        if (!__tmp114_last) __out.AppendLine(true);
                                        __out.AppendLine(false); //97:79
                                    }
                                }
                            }
                            __out.Append("	</xs:complexType>"); //99:1
                            __out.AppendLine(false); //99:19
                        }
                    }
                }
            }
            __out.Append("</xs:schema>"); //104:1
            __out.AppendLine(false); //104:13
            return __out.ToString();
        }

        public string GenerateStructBody(Namespace ns, Struct stype) //107:1
        {
            StringBuilder __out = new StringBuilder();
            string __tmp1Prefix = string.Empty;
            string __tmp2Line = "<xs:"; //108:1
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
            string __tmp4Line = ">"; //108:27
            if (__tmp4Line != null) __out.Append(__tmp4Line);
            __out.AppendLine(false); //108:28
            var __loop11_results = 
                (from __loop11_var1 in __Enumerate((stype).GetEnumerator()) //109:8
                from prop in __Enumerate((__loop11_var1.Properties).GetEnumerator()) //109:15
                where !prop.HasAnnotation(SoalAnnotations.Attribute) //109:31
                select new { __loop11_var1 = __loop11_var1, prop = prop}
                ).ToList(); //109:3
            int __loop11_iteration = 0;
            foreach (var __tmp5 in __loop11_results)
            {
                ++__loop11_iteration;
                var __loop11_var1 = __tmp5.__loop11_var1;
                var prop = __tmp5.prop;
                string newName = prop.GetAnnotationPropertyValue(SoalAnnotations.Element, SoalAnnotationProperties.Name) as string; //110:4
                string __tmp6Prefix = "	"; //111:1
                StringBuilder __tmp7 = new StringBuilder();
                __tmp7.Append(GenerateElement(ns, newName == null ? prop.Name : newName, prop.Type, prop.Annotations));
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
                        __out.AppendLine(false); //111:91
                    }
                }
            }
            string __tmp8Prefix = string.Empty;
            string __tmp9Line = "</xs:"; //113:1
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
            string __tmp11Line = ">"; //113:28
            if (__tmp11Line != null) __out.Append(__tmp11Line);
            __out.AppendLine(false); //113:29
            var __loop12_results = 
                (from __loop12_var1 in __Enumerate((stype).GetEnumerator()) //114:7
                from prop in __Enumerate((__loop12_var1.Properties).GetEnumerator()) //114:14
                where prop.HasAnnotation(SoalAnnotations.Attribute) //114:30
                select new { __loop12_var1 = __loop12_var1, prop = prop}
                ).ToList(); //114:2
            int __loop12_iteration = 0;
            foreach (var __tmp12 in __loop12_results)
            {
                ++__loop12_iteration;
                var __loop12_var1 = __tmp12.__loop12_var1;
                var prop = __tmp12.prop;
                string newName = prop.GetAnnotationPropertyValue(SoalAnnotations.Attribute, SoalAnnotationProperties.Name) as string; //115:3
                string __tmp13Prefix = string.Empty;
                StringBuilder __tmp14 = new StringBuilder();
                __tmp14.Append(GenerateElement(ns, newName == null ? prop.Name : newName, prop.Type, prop.Annotations));
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
                        __out.AppendLine(false); //116:90
                    }
                }
            }
            return __out.ToString();
        }

        public string GenerateElement(Namespace ns, string name, SoalType t, IList<Annotation> annots) //120:1
        {
            StringBuilder __out = new StringBuilder();
            if (annots.ContainsAnnotation(SoalAnnotations.Attribute)) //121:2
            {
                string __tmp1Prefix = string.Empty;
                string __tmp2Line = "<xs:attribute name=\""; //122:1
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
                string __tmp4Line = "\" type=\""; //122:27
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
                string __tmp6Line = ":"; //122:76
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
                string __tmp8Line = "\""; //122:107
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
                string __tmp10Line = "/>"; //122:138
                if (__tmp10Line != null) __out.Append(__tmp10Line);
                __out.AppendLine(false); //122:140
            }
            else //123:2
            {
                if (t.IsArrayType()) //124:3
                {
                    ArrayType array = t is NonNullableType ? (ArrayType)((NonNullableType)t).InnerType : (ArrayType)t; //125:4
                    if (array.GetCoreType() == SoalInstance.Byte) //126:4
                    {
                        string __tmp11Prefix = string.Empty;
                        string __tmp12Line = "<xs:element name=\""; //127:1
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
                        string __tmp14Line = "\" type=\""; //127:25
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
                        string __tmp16Line = ":"; //127:60
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
                        string __tmp18Line = "\" nillable=\""; //127:77
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
                        string __tmp20Line = "\""; //127:108
                        if (__tmp20Line != null) __out.Append(__tmp20Line);
                        StringBuilder __tmp21 = new StringBuilder();
                        __tmp21.Append(GetElementOptional(annots));
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
                        string __tmp22Line = "/>"; //127:137
                        if (__tmp22Line != null) __out.Append(__tmp22Line);
                        __out.AppendLine(false); //127:139
                    }
                    else //128:4
                    {
                        object wrapped = annots.GetAnnotationPropertyValue(SoalAnnotations.Element, SoalAnnotationProperties.Wrapped); //129:5
                        if (wrapped != null && (bool)wrapped) //130:5
                        {
                            string items = annots.GetAnnotationPropertyValue(SoalAnnotations.Element, SoalAnnotationProperties.Items) as string; //131:6
                            string __tmp23Prefix = string.Empty;
                            string __tmp24Line = "<xs:element name=\""; //132:1
                            __out.Append(__tmp23Prefix);
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
                            string __tmp26Line = "\" nillable=\""; //132:25
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
                            string __tmp28Line = "\""; //132:56
                            if (__tmp28Line != null) __out.Append(__tmp28Line);
                            StringBuilder __tmp29 = new StringBuilder();
                            __tmp29.Append(GetElementOptional(annots));
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
                            string __tmp30Line = ">"; //132:85
                            if (__tmp30Line != null) __out.Append(__tmp30Line);
                            __out.AppendLine(false); //132:86
                            __out.Append("	<xs:complexType>"); //133:1
                            __out.AppendLine(false); //133:18
                            object sap = annots.GetAnnotationPropertyValue(SoalAnnotations.Element, SoalAnnotationProperties.Sap); //134:6
                            if (sap != null && (bool)sap) //135:6
                            {
                                __out.Append("		<xs:all>"); //136:1
                                __out.AppendLine(false); //136:11
                                __out.Append("			<xs:element name=\"item\" minOccurs=\"0\" maxOccurs=\"unbounded\">"); //137:1
                                __out.AppendLine(false); //137:64
                                __out.Append("				<xs:complexType>"); //138:1
                                __out.AppendLine(false); //138:21
                                __out.Append("					<xs:all>"); //139:1
                                __out.AppendLine(false); //139:14
                                if (items != null) //140:7
                                {
                                    string __tmp31Prefix = string.Empty;
                                    string __tmp32Line = "						<xs:element name=\""; //141:1
                                    __out.Append(__tmp31Prefix);
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
                                    string __tmp34Line = "\" type=\""; //141:32
                                    if (__tmp34Line != null) __out.Append(__tmp34Line);
                                    StringBuilder __tmp35 = new StringBuilder();
                                    __tmp35.Append(array.InnerType.GetNamespace(ns).Prefix);
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
                                    string __tmp36Line = ":"; //141:81
                                    if (__tmp36Line != null) __out.Append(__tmp36Line);
                                    StringBuilder __tmp37 = new StringBuilder();
                                    __tmp37.Append(array.InnerType.GetXsdName());
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
                                    string __tmp38Line = "\" nillable=\""; //141:112
                                    if (__tmp38Line != null) __out.Append(__tmp38Line);
                                    StringBuilder __tmp39 = new StringBuilder();
                                    __tmp39.Append(array.InnerType.IsNullableXsd());
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
                                    string __tmp40Line = "\"/>"; //141:157
                                    if (__tmp40Line != null) __out.Append(__tmp40Line);
                                    __out.AppendLine(false); //141:160
                                }
                                else //142:7
                                {
                                    string __tmp41Prefix = string.Empty;
                                    string __tmp42Line = "						<xs:element name=\""; //143:1
                                    __out.Append(__tmp41Prefix);
                                    if (__tmp42Line != null) __out.Append(__tmp42Line);
                                    StringBuilder __tmp43 = new StringBuilder();
                                    __tmp43.Append(array.InnerType.GetXsdName());
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
                                    string __tmp44Line = "\" type=\""; //143:55
                                    if (__tmp44Line != null) __out.Append(__tmp44Line);
                                    StringBuilder __tmp45 = new StringBuilder();
                                    __tmp45.Append(array.InnerType.GetNamespace(ns).Prefix);
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
                                    string __tmp46Line = ":"; //143:104
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
                                    string __tmp48Line = "\" nillable=\""; //143:135
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
                                    string __tmp50Line = "\"/>"; //143:180
                                    if (__tmp50Line != null) __out.Append(__tmp50Line);
                                    __out.AppendLine(false); //143:183
                                }
                                __out.Append("					</xs:all>"); //145:1
                                __out.AppendLine(false); //145:15
                                __out.Append("				</xs:complexType>"); //146:1
                                __out.AppendLine(false); //146:22
                                __out.Append("			</xs:element>"); //147:1
                                __out.AppendLine(false); //147:17
                                __out.Append("		</xs:all>"); //148:1
                                __out.AppendLine(false); //148:12
                            }
                            else //149:6
                            {
                                __out.Append("		<xs:sequence>"); //150:1
                                __out.AppendLine(false); //150:16
                                if (items != null) //151:7
                                {
                                    string __tmp51Prefix = string.Empty;
                                    string __tmp52Line = "			<xs:element name=\""; //152:1
                                    __out.Append(__tmp51Prefix);
                                    if (__tmp52Line != null) __out.Append(__tmp52Line);
                                    StringBuilder __tmp53 = new StringBuilder();
                                    __tmp53.Append(items);
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
                                    string __tmp54Line = "\" type=\""; //152:29
                                    if (__tmp54Line != null) __out.Append(__tmp54Line);
                                    StringBuilder __tmp55 = new StringBuilder();
                                    __tmp55.Append(array.InnerType.GetNamespace(ns).Prefix);
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
                                    string __tmp56Line = ":"; //152:78
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
                                    string __tmp58Line = "\" nillable=\""; //152:109
                                    if (__tmp58Line != null) __out.Append(__tmp58Line);
                                    StringBuilder __tmp59 = new StringBuilder();
                                    __tmp59.Append(array.InnerType.IsNullableXsd());
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
                                    string __tmp60Line = "\" minOccurs=\"0\" maxOccurs=\"unbounded\"/>"; //152:154
                                    if (__tmp60Line != null) __out.Append(__tmp60Line);
                                    __out.AppendLine(false); //152:193
                                }
                                else //153:7
                                {
                                    string __tmp61Prefix = string.Empty;
                                    string __tmp62Line = "			<xs:element name=\""; //154:1
                                    __out.Append(__tmp61Prefix);
                                    if (__tmp62Line != null) __out.Append(__tmp62Line);
                                    StringBuilder __tmp63 = new StringBuilder();
                                    __tmp63.Append(array.InnerType.GetXsdName());
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
                                    string __tmp64Line = "\" type=\""; //154:52
                                    if (__tmp64Line != null) __out.Append(__tmp64Line);
                                    StringBuilder __tmp65 = new StringBuilder();
                                    __tmp65.Append(array.InnerType.GetNamespace(ns).Prefix);
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
                                    string __tmp66Line = ":"; //154:101
                                    if (__tmp66Line != null) __out.Append(__tmp66Line);
                                    StringBuilder __tmp67 = new StringBuilder();
                                    __tmp67.Append(array.InnerType.GetXsdName());
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
                                    string __tmp68Line = "\" nillable=\""; //154:132
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
                                    string __tmp70Line = "\" minOccurs=\"0\" maxOccurs=\"unbounded\"/>"; //154:177
                                    if (__tmp70Line != null) __out.Append(__tmp70Line);
                                    __out.AppendLine(false); //154:216
                                }
                                __out.Append("		</xs:sequence>"); //156:1
                                __out.AppendLine(false); //156:17
                            }
                            __out.Append("	</xs:complexType>"); //158:1
                            __out.AppendLine(false); //158:19
                            __out.Append("</xs:element>"); //159:1
                            __out.AppendLine(false); //159:14
                        }
                        else //160:5
                        {
                            string __tmp71Prefix = string.Empty;
                            string __tmp72Line = "<xs:element name=\""; //161:1
                            __out.Append(__tmp71Prefix);
                            if (__tmp72Line != null) __out.Append(__tmp72Line);
                            StringBuilder __tmp73 = new StringBuilder();
                            __tmp73.Append(name);
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
                            string __tmp74Line = "\" type=\""; //161:25
                            if (__tmp74Line != null) __out.Append(__tmp74Line);
                            StringBuilder __tmp75 = new StringBuilder();
                            __tmp75.Append(array.InnerType.GetNamespace(ns).Prefix);
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
                            string __tmp76Line = ":"; //161:74
                            if (__tmp76Line != null) __out.Append(__tmp76Line);
                            StringBuilder __tmp77 = new StringBuilder();
                            __tmp77.Append(array.InnerType.GetXsdName());
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
                            string __tmp78Line = "\" nillable=\""; //161:105
                            if (__tmp78Line != null) __out.Append(__tmp78Line);
                            StringBuilder __tmp79 = new StringBuilder();
                            __tmp79.Append(array.InnerType.IsNullableXsd());
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
                            string __tmp80Line = "\" minOccurs=\"0\" maxOccurs=\"unbounded\"/>"; //161:150
                            if (__tmp80Line != null) __out.Append(__tmp80Line);
                            __out.AppendLine(false); //161:189
                        }
                    }
                }
                else //164:3
                {
                    string __tmp81Prefix = string.Empty;
                    string __tmp82Line = "<xs:element name=\""; //165:1
                    __out.Append(__tmp81Prefix);
                    if (__tmp82Line != null) __out.Append(__tmp82Line);
                    StringBuilder __tmp83 = new StringBuilder();
                    __tmp83.Append(name);
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
                    string __tmp84Line = "\" type=\""; //165:25
                    if (__tmp84Line != null) __out.Append(__tmp84Line);
                    StringBuilder __tmp85 = new StringBuilder();
                    __tmp85.Append(t.GetNamespace(ns).Prefix);
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
                    string __tmp86Line = ":"; //165:60
                    if (__tmp86Line != null) __out.Append(__tmp86Line);
                    StringBuilder __tmp87 = new StringBuilder();
                    __tmp87.Append(t.GetXsdName());
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
                    string __tmp88Line = "\" nillable=\""; //165:77
                    if (__tmp88Line != null) __out.Append(__tmp88Line);
                    StringBuilder __tmp89 = new StringBuilder();
                    __tmp89.Append(t.IsNullableXsd());
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
                    string __tmp90Line = "\""; //165:108
                    if (__tmp90Line != null) __out.Append(__tmp90Line);
                    StringBuilder __tmp91 = new StringBuilder();
                    __tmp91.Append(GetElementOptional(annots));
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
                    string __tmp92Line = "/>"; //165:137
                    if (__tmp92Line != null) __out.Append(__tmp92Line);
                    __out.AppendLine(false); //165:139
                }
            }
            return __out.ToString();
        }

        public string GenerateParamType(Namespace ns, string name, SoalType t, IList<Annotation> annots) //170:1
        {
            StringBuilder __out = new StringBuilder();
            if (t.IsArrayType()) //171:2
            {
                ArrayType array = t is NonNullableType ? (ArrayType)((NonNullableType)t).InnerType : (ArrayType)t; //172:3
                if (array.GetCoreType() != SoalInstance.Byte) //173:3
                {
                    string items = annots.GetAnnotationPropertyValue(SoalAnnotations.Element, SoalAnnotationProperties.Items) as string; //174:4
                    string __tmp1Prefix = string.Empty;
                    string __tmp2Line = "<xs:complexType name=\""; //175:1
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
                    string __tmp4Line = "\">"; //175:29
                    if (__tmp4Line != null) __out.Append(__tmp4Line);
                    __out.AppendLine(false); //175:31
                    object sap = annots.GetAnnotationPropertyValue(SoalAnnotations.Element, SoalAnnotationProperties.Sap); //176:4
                    if (sap != null && (bool)sap) //177:4
                    {
                        __out.Append("	<xs:all>"); //178:1
                        __out.AppendLine(false); //178:10
                        __out.Append("		<xs:element name=\"item\" minOccurs=\"0\" maxOccurs=\"unbounded\">"); //179:1
                        __out.AppendLine(false); //179:63
                        __out.Append("			<xs:complexType>"); //180:1
                        __out.AppendLine(false); //180:20
                        __out.Append("				<xs:all>"); //181:1
                        __out.AppendLine(false); //181:13
                        if (items != null) //182:5
                        {
                            string __tmp5Prefix = string.Empty;
                            string __tmp6Line = "					<xs:element name=\""; //183:1
                            __out.Append(__tmp5Prefix);
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
                            string __tmp8Line = "\" type=\""; //183:31
                            if (__tmp8Line != null) __out.Append(__tmp8Line);
                            StringBuilder __tmp9 = new StringBuilder();
                            __tmp9.Append(array.InnerType.GetNamespace(ns).Prefix);
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
                            string __tmp10Line = ":"; //183:80
                            if (__tmp10Line != null) __out.Append(__tmp10Line);
                            StringBuilder __tmp11 = new StringBuilder();
                            __tmp11.Append(array.InnerType.GetXsdName());
                            using(StreamReader __tmp11Reader = new StreamReader(this.__ToStream(__tmp11.ToString())))
                            {
                                bool __tmp11_first = true;
                                bool __tmp11_last = __tmp11Reader.EndOfStream;
                                while(__tmp11_first || !__tmp11_last)
                                {
                                    __tmp11_first = false;
                                    string __tmp11Line = __tmp11Reader.ReadLine();
                                    __tmp11_last = __tmp11Reader.EndOfStream;
                                    if (__tmp11Line != null) __out.Append(__tmp11Line);
                                    if (!__tmp11_last) __out.AppendLine(true);
                                }
                            }
                            string __tmp12Line = "\" nillable=\""; //183:111
                            if (__tmp12Line != null) __out.Append(__tmp12Line);
                            StringBuilder __tmp13 = new StringBuilder();
                            __tmp13.Append(array.InnerType.IsNullableXsd());
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
                            string __tmp14Line = "\"/>"; //183:156
                            if (__tmp14Line != null) __out.Append(__tmp14Line);
                            __out.AppendLine(false); //183:159
                        }
                        else //184:5
                        {
                            string __tmp15Prefix = string.Empty;
                            string __tmp16Line = "					<xs:element name=\""; //185:1
                            __out.Append(__tmp15Prefix);
                            if (__tmp16Line != null) __out.Append(__tmp16Line);
                            StringBuilder __tmp17 = new StringBuilder();
                            __tmp17.Append(array.InnerType.GetXsdName());
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
                            string __tmp18Line = "\" type=\""; //185:54
                            if (__tmp18Line != null) __out.Append(__tmp18Line);
                            StringBuilder __tmp19 = new StringBuilder();
                            __tmp19.Append(array.InnerType.GetNamespace(ns).Prefix);
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
                            string __tmp20Line = ":"; //185:103
                            if (__tmp20Line != null) __out.Append(__tmp20Line);
                            StringBuilder __tmp21 = new StringBuilder();
                            __tmp21.Append(array.InnerType.GetXsdName());
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
                            string __tmp22Line = "\" nillable=\""; //185:134
                            if (__tmp22Line != null) __out.Append(__tmp22Line);
                            StringBuilder __tmp23 = new StringBuilder();
                            __tmp23.Append(array.InnerType.IsNullableXsd());
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
                            string __tmp24Line = "\"/>"; //185:179
                            if (__tmp24Line != null) __out.Append(__tmp24Line);
                            __out.AppendLine(false); //185:182
                        }
                        __out.Append("				</xs:all>"); //187:1
                        __out.AppendLine(false); //187:14
                        __out.Append("			</xs:complexType>"); //188:1
                        __out.AppendLine(false); //188:21
                        __out.Append("		</xs:element>"); //189:1
                        __out.AppendLine(false); //189:16
                        __out.Append("	</xs:all>"); //190:1
                        __out.AppendLine(false); //190:11
                    }
                    else //191:4
                    {
                        __out.Append("	<xs:sequence>"); //192:1
                        __out.AppendLine(false); //192:15
                        if (items != null) //193:5
                        {
                            string __tmp25Prefix = string.Empty;
                            string __tmp26Line = "		<xs:element name=\""; //194:1
                            __out.Append(__tmp25Prefix);
                            if (__tmp26Line != null) __out.Append(__tmp26Line);
                            StringBuilder __tmp27 = new StringBuilder();
                            __tmp27.Append(items);
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
                            string __tmp28Line = "\" type=\""; //194:28
                            if (__tmp28Line != null) __out.Append(__tmp28Line);
                            StringBuilder __tmp29 = new StringBuilder();
                            __tmp29.Append(array.InnerType.GetNamespace(ns).Prefix);
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
                            string __tmp30Line = ":"; //194:77
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
                            string __tmp32Line = "\" nillable=\""; //194:108
                            if (__tmp32Line != null) __out.Append(__tmp32Line);
                            StringBuilder __tmp33 = new StringBuilder();
                            __tmp33.Append(array.InnerType.IsNullableXsd());
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
                            string __tmp34Line = "\" minOccurs=\"0\" maxOccurs=\"unbounded\"/>"; //194:153
                            if (__tmp34Line != null) __out.Append(__tmp34Line);
                            __out.AppendLine(false); //194:192
                        }
                        else //195:5
                        {
                            string __tmp35Prefix = string.Empty;
                            string __tmp36Line = "		<xs:element name=\""; //196:1
                            __out.Append(__tmp35Prefix);
                            if (__tmp36Line != null) __out.Append(__tmp36Line);
                            StringBuilder __tmp37 = new StringBuilder();
                            __tmp37.Append(array.InnerType.GetXsdName());
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
                            string __tmp38Line = "\" type=\""; //196:51
                            if (__tmp38Line != null) __out.Append(__tmp38Line);
                            StringBuilder __tmp39 = new StringBuilder();
                            __tmp39.Append(array.InnerType.GetNamespace(ns).Prefix);
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
                            string __tmp40Line = ":"; //196:100
                            if (__tmp40Line != null) __out.Append(__tmp40Line);
                            StringBuilder __tmp41 = new StringBuilder();
                            __tmp41.Append(array.InnerType.GetXsdName());
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
                            string __tmp42Line = "\" nillable=\""; //196:131
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
                            string __tmp44Line = "\" minOccurs=\"0\" maxOccurs=\"unbounded\"/>"; //196:176
                            if (__tmp44Line != null) __out.Append(__tmp44Line);
                            __out.AppendLine(false); //196:215
                        }
                        __out.Append("	</xs:sequence>"); //198:1
                        __out.AppendLine(false); //198:16
                    }
                    __out.Append("</xs:complexType>"); //200:1
                    __out.AppendLine(false); //200:18
                }
            }
            return __out.ToString();
        }

        public string GetStructKind(Struct st) //205:1
        {
            if (st.HasAnnotation(SoalAnnotations.Choice)) //206:2
            {
                return "choice"; //207:3
            }
            else if (st.HasAnnotation(SoalAnnotations.All)) //208:2
            {
                return "all"; //209:3
            }
            else //210:2
            {
                return "sequence"; //211:3
            }
        }

        public string GetElementOptional(IList<Annotation> annots) //215:1
        {
            object optional = annots.GetAnnotationPropertyValue(SoalAnnotations.Element, SoalAnnotationProperties.Optional); //216:2
            if (optional != null && (bool)optional) //217:2
            {
                return " minOccurs=\"0\""; //218:3
            }
            else //219:2
            {
                return ""; //220:3
            }
        }

        public string GetAttributeRequired(IList<Annotation> annots) //224:1
        {
            object required = annots.GetAnnotationPropertyValue(SoalAnnotations.Attribute, SoalAnnotationProperties.Required); //225:2
            if (required != null && (bool)required) //226:2
            {
                return " use=\"required\""; //227:3
            }
            else //228:2
            {
                return ""; //229:3
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
