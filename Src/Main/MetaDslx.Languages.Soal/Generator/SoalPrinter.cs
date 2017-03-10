using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetaDslx.Core; //4:1
using MetaDslx.Languages.Soal.Symbols; //5:1

namespace MetaDslx.Languages.Soal.Generator //1:1
{
    using __Hidden_SoalPrinter_856917770;
    namespace __Hidden_SoalPrinter_856917770
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


    public class SoalPrinter //2:1
    {
        private IEnumerable<ISymbol> Instances; //2:1

        public SoalPrinter() //2:1
        {
        }

        public SoalPrinter(IEnumerable<ISymbol> instances) : this() //2:1
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

        public string Generate() //7:1
        {
            StringBuilder __out = new StringBuilder();
            var __loop1_results = 
                (from __loop1_var1 in __Enumerate((Instances).GetEnumerator()) //8:7
                from ns in __Enumerate((__loop1_var1).GetEnumerator()).OfType<Namespace>() //8:18
                select new { __loop1_var1 = __loop1_var1, ns = ns}
                ).ToList(); //8:2
            for (int __loop1_iteration = 0; __loop1_iteration < __loop1_results.Count; ++__loop1_iteration)
            {
                var __tmp1 = __loop1_results[__loop1_iteration];
                var __loop1_var1 = __tmp1.__loop1_var1;
                var ns = __tmp1.ns;
                bool __tmp3_outputWritten = false;
                StringBuilder __tmp4 = new StringBuilder();
                __tmp4.Append(GenerateNamespace(ns));
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
                            __tmp3_outputWritten = true;
                        }
                        if (!__tmp4_last || __tmp3_outputWritten) __out.AppendLine(true);
                    }
                }
                if (__tmp3_outputWritten)
                {
                    __out.AppendLine(false); //9:24
                }
            }
            return __out.ToString();
        }

        public string GenerateNamespace(Namespace ns) //13:1
        {
            StringBuilder __out = new StringBuilder();
            if (ns.Declarations.Count > 0) //14:2
            {
                if (ns.Prefix != null) //15:2
                {
                    bool __tmp2_outputWritten = false;
                    string __tmp3_line = "namespace "; //16:1
                    if (!string.IsNullOrEmpty(__tmp3_line))
                    {
                        __out.Append(__tmp3_line);
                        __tmp2_outputWritten = true;
                    }
                    StringBuilder __tmp4 = new StringBuilder();
                    __tmp4.Append(ns.FullName);
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
                    string __tmp5_line = " = "; //16:24
                    if (!string.IsNullOrEmpty(__tmp5_line))
                    {
                        __out.Append(__tmp5_line);
                        __tmp2_outputWritten = true;
                    }
                    StringBuilder __tmp6 = new StringBuilder();
                    __tmp6.Append(ns.Prefix);
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
                    string __tmp7_line = ":\""; //16:38
                    if (!string.IsNullOrEmpty(__tmp7_line))
                    {
                        __out.Append(__tmp7_line);
                        __tmp2_outputWritten = true;
                    }
                    StringBuilder __tmp8 = new StringBuilder();
                    __tmp8.Append(ns.Uri);
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
                    string __tmp9_line = "\""; //16:48
                    if (!string.IsNullOrEmpty(__tmp9_line))
                    {
                        __out.Append(__tmp9_line);
                        __tmp2_outputWritten = true;
                    }
                    if (__tmp2_outputWritten) __out.AppendLine(true);
                    if (__tmp2_outputWritten)
                    {
                        __out.AppendLine(false); //16:49
                    }
                }
                else //17:2
                {
                    bool __tmp11_outputWritten = false;
                    string __tmp12_line = "namespace "; //18:1
                    if (!string.IsNullOrEmpty(__tmp12_line))
                    {
                        __out.Append(__tmp12_line);
                        __tmp11_outputWritten = true;
                    }
                    StringBuilder __tmp13 = new StringBuilder();
                    __tmp13.Append(ns.FullName);
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
                    string __tmp14_line = " = \""; //18:24
                    if (!string.IsNullOrEmpty(__tmp14_line))
                    {
                        __out.Append(__tmp14_line);
                        __tmp11_outputWritten = true;
                    }
                    StringBuilder __tmp15 = new StringBuilder();
                    __tmp15.Append(ns.Uri);
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
                                __tmp11_outputWritten = true;
                            }
                            if (!__tmp15_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp16_line = "\""; //18:36
                    if (!string.IsNullOrEmpty(__tmp16_line))
                    {
                        __out.Append(__tmp16_line);
                        __tmp11_outputWritten = true;
                    }
                    if (__tmp11_outputWritten) __out.AppendLine(true);
                    if (__tmp11_outputWritten)
                    {
                        __out.AppendLine(false); //18:37
                    }
                }
                __out.Append("{"); //20:1
                __out.AppendLine(false); //20:2
                var __loop2_results = 
                    (from __loop2_var1 in __Enumerate((ns).GetEnumerator()) //21:8
                    from Declarations in __Enumerate((__loop2_var1.Declarations).GetEnumerator()) //21:12
                    from enm in __Enumerate((Declarations).GetEnumerator()).OfType<Symbols.Enum>() //21:26
                    select new { __loop2_var1 = __loop2_var1, Declarations = Declarations, enm = enm}
                    ).ToList(); //21:3
                for (int __loop2_iteration = 0; __loop2_iteration < __loop2_results.Count; ++__loop2_iteration)
                {
                    var __tmp17 = __loop2_results[__loop2_iteration];
                    var __loop2_var1 = __tmp17.__loop2_var1;
                    var Declarations = __tmp17.Declarations;
                    var enm = __tmp17.enm;
                    bool __tmp19_outputWritten = false;
                    string __tmp18Prefix = "	"; //22:1
                    StringBuilder __tmp20 = new StringBuilder();
                    __tmp20.Append(GenerateEnum(ns, enm));
                    using(StreamReader __tmp20Reader = new StreamReader(this.__ToStream(__tmp20.ToString())))
                    {
                        bool __tmp20_last = __tmp20Reader.EndOfStream;
                        while(!__tmp20_last)
                        {
                            string __tmp20_line = __tmp20Reader.ReadLine();
                            __tmp20_last = __tmp20Reader.EndOfStream;
                            if (!string.IsNullOrEmpty(__tmp18Prefix))
                            {
                                __out.Append(__tmp18Prefix);
                                __tmp19_outputWritten = true;
                            }
                            if ((__tmp20_last && !string.IsNullOrEmpty(__tmp20_line)) || (!__tmp20_last && __tmp20_line != null))
                            {
                                __out.Append(__tmp20_line);
                                __tmp19_outputWritten = true;
                            }
                            if (!__tmp20_last || __tmp19_outputWritten) __out.AppendLine(true);
                        }
                    }
                    if (__tmp19_outputWritten)
                    {
                        __out.AppendLine(false); //22:25
                    }
                    __out.AppendLine(true); //23:1
                }
                var __loop3_results = 
                    (from __loop3_var1 in __Enumerate((ns).GetEnumerator()) //25:8
                    from Declarations in __Enumerate((__loop3_var1.Declarations).GetEnumerator()) //25:12
                    from st in __Enumerate((Declarations).GetEnumerator()).OfType<Struct>() //25:26
                    select new { __loop3_var1 = __loop3_var1, Declarations = Declarations, st = st}
                    ).ToList(); //25:3
                for (int __loop3_iteration = 0; __loop3_iteration < __loop3_results.Count; ++__loop3_iteration)
                {
                    var __tmp21 = __loop3_results[__loop3_iteration];
                    var __loop3_var1 = __tmp21.__loop3_var1;
                    var Declarations = __tmp21.Declarations;
                    var st = __tmp21.st;
                    bool __tmp23_outputWritten = false;
                    string __tmp22Prefix = "	"; //26:1
                    StringBuilder __tmp24 = new StringBuilder();
                    __tmp24.Append(GenerateStruct(ns, st));
                    using(StreamReader __tmp24Reader = new StreamReader(this.__ToStream(__tmp24.ToString())))
                    {
                        bool __tmp24_last = __tmp24Reader.EndOfStream;
                        while(!__tmp24_last)
                        {
                            string __tmp24_line = __tmp24Reader.ReadLine();
                            __tmp24_last = __tmp24Reader.EndOfStream;
                            if (!string.IsNullOrEmpty(__tmp22Prefix))
                            {
                                __out.Append(__tmp22Prefix);
                                __tmp23_outputWritten = true;
                            }
                            if ((__tmp24_last && !string.IsNullOrEmpty(__tmp24_line)) || (!__tmp24_last && __tmp24_line != null))
                            {
                                __out.Append(__tmp24_line);
                                __tmp23_outputWritten = true;
                            }
                            if (!__tmp24_last || __tmp23_outputWritten) __out.AppendLine(true);
                        }
                    }
                    if (__tmp23_outputWritten)
                    {
                        __out.AppendLine(false); //26:26
                    }
                    __out.AppendLine(true); //27:1
                }
                var __loop4_results = 
                    (from __loop4_var1 in __Enumerate((ns).GetEnumerator()) //29:8
                    from Declarations in __Enumerate((__loop4_var1.Declarations).GetEnumerator()) //29:12
                    from intf in __Enumerate((Declarations).GetEnumerator()).OfType<Interface>() //29:26
                    select new { __loop4_var1 = __loop4_var1, Declarations = Declarations, intf = intf}
                    ).ToList(); //29:3
                for (int __loop4_iteration = 0; __loop4_iteration < __loop4_results.Count; ++__loop4_iteration)
                {
                    var __tmp25 = __loop4_results[__loop4_iteration];
                    var __loop4_var1 = __tmp25.__loop4_var1;
                    var Declarations = __tmp25.Declarations;
                    var intf = __tmp25.intf;
                    bool __tmp27_outputWritten = false;
                    string __tmp26Prefix = "	"; //30:1
                    StringBuilder __tmp28 = new StringBuilder();
                    __tmp28.Append(GenerateInterface(ns, intf));
                    using(StreamReader __tmp28Reader = new StreamReader(this.__ToStream(__tmp28.ToString())))
                    {
                        bool __tmp28_last = __tmp28Reader.EndOfStream;
                        while(!__tmp28_last)
                        {
                            string __tmp28_line = __tmp28Reader.ReadLine();
                            __tmp28_last = __tmp28Reader.EndOfStream;
                            if (!string.IsNullOrEmpty(__tmp26Prefix))
                            {
                                __out.Append(__tmp26Prefix);
                                __tmp27_outputWritten = true;
                            }
                            if ((__tmp28_last && !string.IsNullOrEmpty(__tmp28_line)) || (!__tmp28_last && __tmp28_line != null))
                            {
                                __out.Append(__tmp28_line);
                                __tmp27_outputWritten = true;
                            }
                            if (!__tmp28_last || __tmp27_outputWritten) __out.AppendLine(true);
                        }
                    }
                    if (__tmp27_outputWritten)
                    {
                        __out.AppendLine(false); //30:31
                    }
                    __out.AppendLine(true); //31:1
                }
                var __loop5_results = 
                    (from __loop5_var1 in __Enumerate((ns).GetEnumerator()) //33:8
                    from Declarations in __Enumerate((__loop5_var1.Declarations).GetEnumerator()) //33:12
                    from bnd in __Enumerate((Declarations).GetEnumerator()).OfType<Symbols.Binding>() //33:26
                    select new { __loop5_var1 = __loop5_var1, Declarations = Declarations, bnd = bnd}
                    ).ToList(); //33:3
                for (int __loop5_iteration = 0; __loop5_iteration < __loop5_results.Count; ++__loop5_iteration)
                {
                    var __tmp29 = __loop5_results[__loop5_iteration];
                    var __loop5_var1 = __tmp29.__loop5_var1;
                    var Declarations = __tmp29.Declarations;
                    var bnd = __tmp29.bnd;
                    bool __tmp31_outputWritten = false;
                    string __tmp30Prefix = "	"; //34:1
                    StringBuilder __tmp32 = new StringBuilder();
                    __tmp32.Append(GenerateBinding(ns, bnd));
                    using(StreamReader __tmp32Reader = new StreamReader(this.__ToStream(__tmp32.ToString())))
                    {
                        bool __tmp32_last = __tmp32Reader.EndOfStream;
                        while(!__tmp32_last)
                        {
                            string __tmp32_line = __tmp32Reader.ReadLine();
                            __tmp32_last = __tmp32Reader.EndOfStream;
                            if (!string.IsNullOrEmpty(__tmp30Prefix))
                            {
                                __out.Append(__tmp30Prefix);
                                __tmp31_outputWritten = true;
                            }
                            if ((__tmp32_last && !string.IsNullOrEmpty(__tmp32_line)) || (!__tmp32_last && __tmp32_line != null))
                            {
                                __out.Append(__tmp32_line);
                                __tmp31_outputWritten = true;
                            }
                            if (!__tmp32_last || __tmp31_outputWritten) __out.AppendLine(true);
                        }
                    }
                    if (__tmp31_outputWritten)
                    {
                        __out.AppendLine(false); //34:28
                    }
                    __out.AppendLine(true); //35:1
                }
                var __loop6_results = 
                    (from __loop6_var1 in __Enumerate((ns).GetEnumerator()) //37:8
                    from Declarations in __Enumerate((__loop6_var1.Declarations).GetEnumerator()) //37:12
                    from endp in __Enumerate((Declarations).GetEnumerator()).OfType<Endpoint>() //37:26
                    select new { __loop6_var1 = __loop6_var1, Declarations = Declarations, endp = endp}
                    ).ToList(); //37:3
                for (int __loop6_iteration = 0; __loop6_iteration < __loop6_results.Count; ++__loop6_iteration)
                {
                    var __tmp33 = __loop6_results[__loop6_iteration];
                    var __loop6_var1 = __tmp33.__loop6_var1;
                    var Declarations = __tmp33.Declarations;
                    var endp = __tmp33.endp;
                    bool __tmp35_outputWritten = false;
                    string __tmp34Prefix = "	"; //38:1
                    StringBuilder __tmp36 = new StringBuilder();
                    __tmp36.Append(GenerateEndpoint(ns, endp));
                    using(StreamReader __tmp36Reader = new StreamReader(this.__ToStream(__tmp36.ToString())))
                    {
                        bool __tmp36_last = __tmp36Reader.EndOfStream;
                        while(!__tmp36_last)
                        {
                            string __tmp36_line = __tmp36Reader.ReadLine();
                            __tmp36_last = __tmp36Reader.EndOfStream;
                            if (!string.IsNullOrEmpty(__tmp34Prefix))
                            {
                                __out.Append(__tmp34Prefix);
                                __tmp35_outputWritten = true;
                            }
                            if ((__tmp36_last && !string.IsNullOrEmpty(__tmp36_line)) || (!__tmp36_last && __tmp36_line != null))
                            {
                                __out.Append(__tmp36_line);
                                __tmp35_outputWritten = true;
                            }
                            if (!__tmp36_last || __tmp35_outputWritten) __out.AppendLine(true);
                        }
                    }
                    if (__tmp35_outputWritten)
                    {
                        __out.AppendLine(false); //38:30
                    }
                    __out.AppendLine(true); //39:1
                }
                __out.Append("}"); //41:1
                __out.AppendLine(false); //41:2
                __out.AppendLine(true); //42:1
            }
            return __out.ToString();
        }

        public string GetAncestor(Namespace currentNs, SoalType st) //46:1
        {
            var __tmp1 = st; //47:10
            if (st is Symbols.Enum) //48:2
            {
                Symbols.Enum baseType = ((Symbols.Enum)st).BaseType; //49:3
                if (baseType != null) //50:3
                {
                    if (baseType.Namespace == currentNs) //51:4
                    {
                        return " : " + baseType.Name; //52:5
                    }
                    else //53:4
                    {
                        return " : " + baseType.FullName; //54:5
                    }
                }
            }
            else if (st is Struct) //57:2
            {
                Struct baseType = ((Struct)st).BaseType; //58:3
                if (baseType != null) //59:3
                {
                    if (baseType.Namespace == currentNs) //60:4
                    {
                        return " : " + baseType.Name; //61:5
                    }
                    else //62:4
                    {
                        return " : " + baseType.FullName; //63:5
                    }
                }
            }//66:2
            return ""; //67:2
        }

        public string GenerateAnnotations(AnnotatedElement ae, bool isReturn) //70:1
        {
            StringBuilder __out = new StringBuilder();
            var __loop7_results = 
                (from __loop7_var1 in __Enumerate((ae).GetEnumerator()) //71:7
                from annot in __Enumerate((__loop7_var1.Annotations).GetEnumerator()) //71:11
                select new { __loop7_var1 = __loop7_var1, annot = annot}
                ).ToList(); //71:2
            for (int __loop7_iteration = 0; __loop7_iteration < __loop7_results.Count; ++__loop7_iteration)
            {
                var __tmp1 = __loop7_results[__loop7_iteration];
                var __loop7_var1 = __tmp1.__loop7_var1;
                var annot = __tmp1.annot;
                bool __tmp3_outputWritten = false;
                StringBuilder __tmp4 = new StringBuilder();
                __tmp4.Append("[");
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
                            __tmp3_outputWritten = true;
                        }
                        if (!__tmp4_last) __out.AppendLine(true);
                    }
                }
                StringBuilder __tmp5 = new StringBuilder();
                __tmp5.Append(isReturn ? "return: " : "");
                using(StreamReader __tmp5Reader = new StreamReader(this.__ToStream(__tmp5.ToString())))
                {
                    bool __tmp5_last = __tmp5Reader.EndOfStream;
                    while(!__tmp5_last)
                    {
                        string __tmp5_line = __tmp5Reader.ReadLine();
                        __tmp5_last = __tmp5Reader.EndOfStream;
                        if ((__tmp5_last && !string.IsNullOrEmpty(__tmp5_line)) || (!__tmp5_last && __tmp5_line != null))
                        {
                            __out.Append(__tmp5_line);
                            __tmp3_outputWritten = true;
                        }
                        if (!__tmp5_last) __out.AppendLine(true);
                    }
                }
                StringBuilder __tmp6 = new StringBuilder();
                __tmp6.Append(annot.Name);
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
                            __tmp3_outputWritten = true;
                        }
                        if (!__tmp6_last) __out.AppendLine(true);
                    }
                }
                if (annot.Properties.Count > 0) //72:47
                {
                    string __tmp8_line = "("; //72:78
                    if (!string.IsNullOrEmpty(__tmp8_line))
                    {
                        __out.Append(__tmp8_line);
                        __tmp3_outputWritten = true;
                    }
                    StringBuilder __tmp9 = new StringBuilder();
                    __tmp9.Append(GenerateAnnotationProperties(annot));
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
                                __tmp3_outputWritten = true;
                            }
                            if (!__tmp9_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp10_line = ")"; //72:116
                    if (!string.IsNullOrEmpty(__tmp10_line))
                    {
                        __out.Append(__tmp10_line);
                        __tmp3_outputWritten = true;
                    }
                }
                StringBuilder __tmp12 = new StringBuilder();
                __tmp12.Append("]");
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
                            __tmp3_outputWritten = true;
                        }
                        if (!__tmp12_last || __tmp3_outputWritten) __out.AppendLine(true);
                    }
                }
                if (__tmp3_outputWritten)
                {
                    __out.AppendLine(false); //72:130
                }
            }
            return __out.ToString();
        }

        public string GenerateAnnotationsSingleLine(AnnotatedElement ae, bool isReturn) //76:1
        {
            StringBuilder __out = new StringBuilder();
            var __loop8_results = 
                (from __loop8_var1 in __Enumerate((ae).GetEnumerator()) //77:7
                from annot in __Enumerate((__loop8_var1.Annotations).GetEnumerator()) //77:11
                select new { __loop8_var1 = __loop8_var1, annot = annot}
                ).ToList(); //77:2
            for (int __loop8_iteration = 0; __loop8_iteration < __loop8_results.Count; ++__loop8_iteration)
            {
                var __tmp1 = __loop8_results[__loop8_iteration];
                var __loop8_var1 = __tmp1.__loop8_var1;
                var annot = __tmp1.annot;
                StringBuilder __tmp4 = new StringBuilder();
                __tmp4.Append("[");
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
                        }
                        if (!__tmp4_last) __out.AppendLine(true);
                    }
                }
                StringBuilder __tmp5 = new StringBuilder();
                __tmp5.Append(isReturn ? "return: " : "");
                using(StreamReader __tmp5Reader = new StreamReader(this.__ToStream(__tmp5.ToString())))
                {
                    bool __tmp5_last = __tmp5Reader.EndOfStream;
                    while(!__tmp5_last)
                    {
                        string __tmp5_line = __tmp5Reader.ReadLine();
                        __tmp5_last = __tmp5Reader.EndOfStream;
                        if ((__tmp5_last && !string.IsNullOrEmpty(__tmp5_line)) || (!__tmp5_last && __tmp5_line != null))
                        {
                            __out.Append(__tmp5_line);
                        }
                        if (!__tmp5_last) __out.AppendLine(true);
                    }
                }
                StringBuilder __tmp6 = new StringBuilder();
                __tmp6.Append(annot.Name);
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
                        }
                        if (!__tmp6_last) __out.AppendLine(true);
                    }
                }
                if (annot.Properties.Count > 0) //78:47
                {
                    string __tmp8_line = "("; //78:78
                    if (!string.IsNullOrEmpty(__tmp8_line))
                    {
                        __out.Append(__tmp8_line);
                    }
                    StringBuilder __tmp9 = new StringBuilder();
                    __tmp9.Append(GenerateAnnotationProperties(annot));
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
                            }
                            if (!__tmp9_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp10_line = ")"; //78:116
                    if (!string.IsNullOrEmpty(__tmp10_line))
                    {
                        __out.Append(__tmp10_line);
                    }
                }
                StringBuilder __tmp12 = new StringBuilder();
                __tmp12.Append("]");
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
                        }
                    }
                }
            }
            return __out.ToString();
        }

        public string GenerateAnnotationProperties(Annotation annot) //82:1
        {
            StringBuilder __out = new StringBuilder();
            var __loop9_results = 
                (from __loop9_var1 in __Enumerate((annot).GetEnumerator()) //83:7
                from prop in __Enumerate((__loop9_var1.Properties).GetEnumerator()) //83:14
                select new { __loop9_var1 = __loop9_var1, prop = prop}
                ).ToList(); //83:2
            for (int __loop9_iteration = 0; __loop9_iteration < __loop9_results.Count; ++__loop9_iteration)
            {
                string comma; //83:29
                if (__loop9_iteration+1 < __loop9_results.Count) comma = ", ";
                else comma = string.Empty;
                var __tmp1 = __loop9_results[__loop9_iteration];
                var __loop9_var1 = __tmp1.__loop9_var1;
                var prop = __tmp1.prop;
                StringBuilder __tmp4 = new StringBuilder();
                __tmp4.Append(prop.Name);
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
                        }
                        if (!__tmp4_last) __out.AppendLine(true);
                    }
                }
                string __tmp5_line = "="; //84:12
                if (!string.IsNullOrEmpty(__tmp5_line))
                {
                    __out.Append(__tmp5_line);
                }
                StringBuilder __tmp6 = new StringBuilder();
                __tmp6.Append(GetAnnotationPropertyValue(prop));
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
                        }
                        if (!__tmp6_last) __out.AppendLine(true);
                    }
                }
                StringBuilder __tmp7 = new StringBuilder();
                __tmp7.Append(comma);
                using(StreamReader __tmp7Reader = new StreamReader(this.__ToStream(__tmp7.ToString())))
                {
                    bool __tmp7_last = __tmp7Reader.EndOfStream;
                    while(!__tmp7_last)
                    {
                        string __tmp7_line = __tmp7Reader.ReadLine();
                        __tmp7_last = __tmp7Reader.EndOfStream;
                        if ((__tmp7_last && !string.IsNullOrEmpty(__tmp7_line)) || (!__tmp7_last && __tmp7_line != null))
                        {
                            __out.Append(__tmp7_line);
                        }
                    }
                }
            }
            return __out.ToString();
        }

        public string GetAnnotationPropertyValue(AnnotationProperty prop) //88:1
        {
            if (prop.Value == null) //89:2
            {
                return string.Empty; //90:3
            }
            if (prop.Value is string) //92:2
            {
                return "\"" + prop.Value + "\""; //93:3
            }
            else if (prop.Value is bool) //94:2
            {
                return prop.Value.ToString().ToLower(); //95:3
            }
            else //96:2
            {
                return prop.Value.ToString(); //97:3
            }
        }

        public string GenerateEnum(Namespace currentNs, Symbols.Enum enm) //101:1
        {
            StringBuilder __out = new StringBuilder();
            bool __tmp2_outputWritten = false;
            StringBuilder __tmp3 = new StringBuilder();
            __tmp3.Append(GenerateAnnotations(enm, false));
            using(StreamReader __tmp3Reader = new StreamReader(this.__ToStream(__tmp3.ToString())))
            {
                bool __tmp3_last = __tmp3Reader.EndOfStream;
                while(!__tmp3_last)
                {
                    string __tmp3_line = __tmp3Reader.ReadLine();
                    __tmp3_last = __tmp3Reader.EndOfStream;
                    if ((__tmp3_last && !string.IsNullOrEmpty(__tmp3_line)) || (!__tmp3_last && __tmp3_line != null))
                    {
                        __out.Append(__tmp3_line);
                        __tmp2_outputWritten = true;
                    }
                    if (!__tmp3_last || __tmp2_outputWritten) __out.AppendLine(true);
                }
            }
            if (__tmp2_outputWritten)
            {
                __out.AppendLine(false); //102:34
            }
            bool __tmp5_outputWritten = false;
            string __tmp6_line = "enum "; //103:1
            if (!string.IsNullOrEmpty(__tmp6_line))
            {
                __out.Append(__tmp6_line);
                __tmp5_outputWritten = true;
            }
            StringBuilder __tmp7 = new StringBuilder();
            __tmp7.Append(enm.Name);
            using(StreamReader __tmp7Reader = new StreamReader(this.__ToStream(__tmp7.ToString())))
            {
                bool __tmp7_last = __tmp7Reader.EndOfStream;
                while(!__tmp7_last)
                {
                    string __tmp7_line = __tmp7Reader.ReadLine();
                    __tmp7_last = __tmp7Reader.EndOfStream;
                    if ((__tmp7_last && !string.IsNullOrEmpty(__tmp7_line)) || (!__tmp7_last && __tmp7_line != null))
                    {
                        __out.Append(__tmp7_line);
                        __tmp5_outputWritten = true;
                    }
                    if (!__tmp7_last) __out.AppendLine(true);
                }
            }
            string __tmp8_line = " "; //103:16
            if (!string.IsNullOrEmpty(__tmp8_line))
            {
                __out.Append(__tmp8_line);
                __tmp5_outputWritten = true;
            }
            StringBuilder __tmp9 = new StringBuilder();
            __tmp9.Append(GetAncestor(currentNs, enm));
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
                        __tmp5_outputWritten = true;
                    }
                    if (!__tmp9_last || __tmp5_outputWritten) __out.AppendLine(true);
                }
            }
            if (__tmp5_outputWritten)
            {
                __out.AppendLine(false); //103:46
            }
            __out.Append("{"); //104:1
            __out.AppendLine(false); //104:2
            var __loop10_results = 
                (from lit in __Enumerate((enm.EnumLiterals).GetEnumerator()) //105:8
                select new { lit = lit}
                ).ToList(); //105:3
            for (int __loop10_iteration = 0; __loop10_iteration < __loop10_results.Count; ++__loop10_iteration)
            {
                string comma; //105:28
                if (__loop10_iteration+1 < __loop10_results.Count) comma = ",";
                else comma = string.Empty;
                var __tmp10 = __loop10_results[__loop10_iteration];
                var lit = __tmp10.lit;
                bool __tmp12_outputWritten = false;
                string __tmp11Prefix = "	"; //106:1
                StringBuilder __tmp13 = new StringBuilder();
                __tmp13.Append(GenerateEnumLiteral(currentNs, lit));
                using(StreamReader __tmp13Reader = new StreamReader(this.__ToStream(__tmp13.ToString())))
                {
                    bool __tmp13_last = __tmp13Reader.EndOfStream;
                    while(!__tmp13_last)
                    {
                        string __tmp13_line = __tmp13Reader.ReadLine();
                        __tmp13_last = __tmp13Reader.EndOfStream;
                        if (!string.IsNullOrEmpty(__tmp11Prefix))
                        {
                            __out.Append(__tmp11Prefix);
                            __tmp12_outputWritten = true;
                        }
                        if ((__tmp13_last && !string.IsNullOrEmpty(__tmp13_line)) || (!__tmp13_last && __tmp13_line != null))
                        {
                            __out.Append(__tmp13_line);
                            __tmp12_outputWritten = true;
                        }
                        if (!__tmp13_last) __out.AppendLine(true);
                    }
                }
                StringBuilder __tmp14 = new StringBuilder();
                __tmp14.Append(comma);
                using(StreamReader __tmp14Reader = new StreamReader(this.__ToStream(__tmp14.ToString())))
                {
                    bool __tmp14_last = __tmp14Reader.EndOfStream;
                    while(!__tmp14_last)
                    {
                        string __tmp14_line = __tmp14Reader.ReadLine();
                        __tmp14_last = __tmp14Reader.EndOfStream;
                        if ((__tmp14_last && !string.IsNullOrEmpty(__tmp14_line)) || (!__tmp14_last && __tmp14_line != null))
                        {
                            __out.Append(__tmp14_line);
                            __tmp12_outputWritten = true;
                        }
                        if (!__tmp14_last || __tmp12_outputWritten) __out.AppendLine(true);
                    }
                }
                if (__tmp12_outputWritten)
                {
                    __out.AppendLine(false); //106:46
                }
            }
            __out.Append("}"); //108:1
            __out.AppendLine(false); //108:2
            return __out.ToString();
        }

        public string GenerateEnumLiteral(Namespace currentNs, EnumLiteral lit) //111:1
        {
            StringBuilder __out = new StringBuilder();
            bool __tmp2_outputWritten = false;
            StringBuilder __tmp3 = new StringBuilder();
            __tmp3.Append(GenerateAnnotations(lit, false));
            using(StreamReader __tmp3Reader = new StreamReader(this.__ToStream(__tmp3.ToString())))
            {
                bool __tmp3_last = __tmp3Reader.EndOfStream;
                while(!__tmp3_last)
                {
                    string __tmp3_line = __tmp3Reader.ReadLine();
                    __tmp3_last = __tmp3Reader.EndOfStream;
                    if ((__tmp3_last && !string.IsNullOrEmpty(__tmp3_line)) || (!__tmp3_last && __tmp3_line != null))
                    {
                        __out.Append(__tmp3_line);
                        __tmp2_outputWritten = true;
                    }
                    if (!__tmp3_last || __tmp2_outputWritten) __out.AppendLine(true);
                }
            }
            if (__tmp2_outputWritten)
            {
                __out.AppendLine(false); //112:34
            }
            bool __tmp5_outputWritten = false;
            StringBuilder __tmp6 = new StringBuilder();
            __tmp6.Append(lit.Name);
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
                        __tmp5_outputWritten = true;
                    }
                    if (!__tmp6_last || __tmp5_outputWritten) __out.AppendLine(true);
                }
            }
            if (__tmp5_outputWritten)
            {
                __out.AppendLine(false); //113:11
            }
            return __out.ToString();
        }

        public string GenerateStruct(Namespace currentNs, Struct st) //116:1
        {
            StringBuilder __out = new StringBuilder();
            bool __tmp2_outputWritten = false;
            StringBuilder __tmp3 = new StringBuilder();
            __tmp3.Append(GenerateAnnotations(st, false));
            using(StreamReader __tmp3Reader = new StreamReader(this.__ToStream(__tmp3.ToString())))
            {
                bool __tmp3_last = __tmp3Reader.EndOfStream;
                while(!__tmp3_last)
                {
                    string __tmp3_line = __tmp3Reader.ReadLine();
                    __tmp3_last = __tmp3Reader.EndOfStream;
                    if ((__tmp3_last && !string.IsNullOrEmpty(__tmp3_line)) || (!__tmp3_last && __tmp3_line != null))
                    {
                        __out.Append(__tmp3_line);
                        __tmp2_outputWritten = true;
                    }
                    if (!__tmp3_last || __tmp2_outputWritten) __out.AppendLine(true);
                }
            }
            if (__tmp2_outputWritten)
            {
                __out.AppendLine(false); //117:33
            }
            bool __tmp5_outputWritten = false;
            string __tmp6_line = "struct "; //118:1
            if (!string.IsNullOrEmpty(__tmp6_line))
            {
                __out.Append(__tmp6_line);
                __tmp5_outputWritten = true;
            }
            StringBuilder __tmp7 = new StringBuilder();
            __tmp7.Append(st.Name);
            using(StreamReader __tmp7Reader = new StreamReader(this.__ToStream(__tmp7.ToString())))
            {
                bool __tmp7_last = __tmp7Reader.EndOfStream;
                while(!__tmp7_last)
                {
                    string __tmp7_line = __tmp7Reader.ReadLine();
                    __tmp7_last = __tmp7Reader.EndOfStream;
                    if ((__tmp7_last && !string.IsNullOrEmpty(__tmp7_line)) || (!__tmp7_last && __tmp7_line != null))
                    {
                        __out.Append(__tmp7_line);
                        __tmp5_outputWritten = true;
                    }
                    if (!__tmp7_last) __out.AppendLine(true);
                }
            }
            StringBuilder __tmp8 = new StringBuilder();
            __tmp8.Append(GetAncestor(currentNs, st));
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
                        __tmp5_outputWritten = true;
                    }
                    if (!__tmp8_last || __tmp5_outputWritten) __out.AppendLine(true);
                }
            }
            if (__tmp5_outputWritten)
            {
                __out.AppendLine(false); //118:45
            }
            __out.Append("{"); //119:1
            __out.AppendLine(false); //119:2
            var __loop11_results = 
                (from __loop11_var1 in __Enumerate((st).GetEnumerator()) //120:8
                from prop in __Enumerate((__loop11_var1.Properties).GetEnumerator()) //120:12
                select new { __loop11_var1 = __loop11_var1, prop = prop}
                ).ToList(); //120:3
            for (int __loop11_iteration = 0; __loop11_iteration < __loop11_results.Count; ++__loop11_iteration)
            {
                var __tmp9 = __loop11_results[__loop11_iteration];
                var __loop11_var1 = __tmp9.__loop11_var1;
                var prop = __tmp9.prop;
                bool __tmp11_outputWritten = false;
                string __tmp10Prefix = "	"; //121:1
                StringBuilder __tmp12 = new StringBuilder();
                __tmp12.Append(GenerateProperty(currentNs, prop));
                using(StreamReader __tmp12Reader = new StreamReader(this.__ToStream(__tmp12.ToString())))
                {
                    bool __tmp12_last = __tmp12Reader.EndOfStream;
                    while(!__tmp12_last)
                    {
                        string __tmp12_line = __tmp12Reader.ReadLine();
                        __tmp12_last = __tmp12Reader.EndOfStream;
                        if (!string.IsNullOrEmpty(__tmp10Prefix))
                        {
                            __out.Append(__tmp10Prefix);
                            __tmp11_outputWritten = true;
                        }
                        if ((__tmp12_last && !string.IsNullOrEmpty(__tmp12_line)) || (!__tmp12_last && __tmp12_line != null))
                        {
                            __out.Append(__tmp12_line);
                            __tmp11_outputWritten = true;
                        }
                        if (!__tmp12_last || __tmp11_outputWritten) __out.AppendLine(true);
                    }
                }
                if (__tmp11_outputWritten)
                {
                    __out.AppendLine(false); //121:37
                }
            }
            __out.Append("}"); //123:1
            __out.AppendLine(false); //123:2
            return __out.ToString();
        }

        public string GenerateProperty(Namespace currentNs, Property prop) //126:1
        {
            StringBuilder __out = new StringBuilder();
            bool __tmp2_outputWritten = false;
            StringBuilder __tmp3 = new StringBuilder();
            __tmp3.Append(GenerateAnnotations(prop, false));
            using(StreamReader __tmp3Reader = new StreamReader(this.__ToStream(__tmp3.ToString())))
            {
                bool __tmp3_last = __tmp3Reader.EndOfStream;
                while(!__tmp3_last)
                {
                    string __tmp3_line = __tmp3Reader.ReadLine();
                    __tmp3_last = __tmp3Reader.EndOfStream;
                    if ((__tmp3_last && !string.IsNullOrEmpty(__tmp3_line)) || (!__tmp3_last && __tmp3_line != null))
                    {
                        __out.Append(__tmp3_line);
                        __tmp2_outputWritten = true;
                    }
                    if (!__tmp3_last || __tmp2_outputWritten) __out.AppendLine(true);
                }
            }
            if (__tmp2_outputWritten)
            {
                __out.AppendLine(false); //127:35
            }
            bool __tmp5_outputWritten = false;
            StringBuilder __tmp6 = new StringBuilder();
            __tmp6.Append(GenerateType(currentNs, prop.Type));
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
                        __tmp5_outputWritten = true;
                    }
                    if (!__tmp6_last) __out.AppendLine(true);
                }
            }
            string __tmp7_line = " "; //128:37
            if (!string.IsNullOrEmpty(__tmp7_line))
            {
                __out.Append(__tmp7_line);
                __tmp5_outputWritten = true;
            }
            StringBuilder __tmp8 = new StringBuilder();
            __tmp8.Append(prop.Name);
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
                        __tmp5_outputWritten = true;
                    }
                    if (!__tmp8_last) __out.AppendLine(true);
                }
            }
            string __tmp9_line = ";"; //128:49
            if (!string.IsNullOrEmpty(__tmp9_line))
            {
                __out.Append(__tmp9_line);
                __tmp5_outputWritten = true;
            }
            if (__tmp5_outputWritten) __out.AppendLine(true);
            if (__tmp5_outputWritten)
            {
                __out.AppendLine(false); //128:50
            }
            return __out.ToString();
        }

        public string GenerateRef(Namespace currentNs, Declaration decl) //131:1
        {
            StringBuilder __out = new StringBuilder();
            if (decl != null) //132:2
            {
                if (decl.Namespace != currentNs) //133:2
                {
                    StringBuilder __tmp3 = new StringBuilder();
                    __tmp3.Append(decl.FullName);
                    using(StreamReader __tmp3Reader = new StreamReader(this.__ToStream(__tmp3.ToString())))
                    {
                        bool __tmp3_last = __tmp3Reader.EndOfStream;
                        while(!__tmp3_last)
                        {
                            string __tmp3_line = __tmp3Reader.ReadLine();
                            __tmp3_last = __tmp3Reader.EndOfStream;
                            if ((__tmp3_last && !string.IsNullOrEmpty(__tmp3_line)) || (!__tmp3_last && __tmp3_line != null))
                            {
                                __out.Append(__tmp3_line);
                            }
                        }
                    }
                }
                else //135:2
                {
                    StringBuilder __tmp6 = new StringBuilder();
                    __tmp6.Append(decl.Name);
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
                            }
                        }
                    }
                }
            }
            return __out.ToString();
        }

        public string GenerateType(Namespace currentNs, SoalType t) //141:1
        {
            StringBuilder __out = new StringBuilder();
            if (t is PrimitiveType) //142:2
            {
                StringBuilder __tmp3 = new StringBuilder();
                __tmp3.Append(((PrimitiveType)t).Name);
                using(StreamReader __tmp3Reader = new StreamReader(this.__ToStream(__tmp3.ToString())))
                {
                    bool __tmp3_last = __tmp3Reader.EndOfStream;
                    while(!__tmp3_last)
                    {
                        string __tmp3_line = __tmp3Reader.ReadLine();
                        __tmp3_last = __tmp3Reader.EndOfStream;
                        if ((__tmp3_last && !string.IsNullOrEmpty(__tmp3_line)) || (!__tmp3_last && __tmp3_line != null))
                        {
                            __out.Append(__tmp3_line);
                        }
                    }
                }
            }
            else if (t is NullableType) //144:2
            {
                StringBuilder __tmp6 = new StringBuilder();
                __tmp6.Append(GenerateType(currentNs, ((NullableType)t).InnerType));
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
                        }
                        if (!__tmp6_last) __out.AppendLine(true);
                    }
                }
                string __tmp7_line = "?"; //145:55
                if (!string.IsNullOrEmpty(__tmp7_line))
                {
                    __out.Append(__tmp7_line);
                }
            }
            else if (t is NonNullableType) //146:2
            {
                StringBuilder __tmp10 = new StringBuilder();
                __tmp10.Append(GenerateType(currentNs, ((NonNullableType)t).InnerType));
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
                        }
                        if (!__tmp10_last) __out.AppendLine(true);
                    }
                }
                string __tmp11_line = "!"; //147:58
                if (!string.IsNullOrEmpty(__tmp11_line))
                {
                    __out.Append(__tmp11_line);
                }
            }
            else if (t is ArrayType) //148:2
            {
                StringBuilder __tmp14 = new StringBuilder();
                __tmp14.Append(GenerateType(currentNs, ((ArrayType)t).InnerType));
                using(StreamReader __tmp14Reader = new StreamReader(this.__ToStream(__tmp14.ToString())))
                {
                    bool __tmp14_last = __tmp14Reader.EndOfStream;
                    while(!__tmp14_last)
                    {
                        string __tmp14_line = __tmp14Reader.ReadLine();
                        __tmp14_last = __tmp14Reader.EndOfStream;
                        if ((__tmp14_last && !string.IsNullOrEmpty(__tmp14_line)) || (!__tmp14_last && __tmp14_line != null))
                        {
                            __out.Append(__tmp14_line);
                        }
                        if (!__tmp14_last) __out.AppendLine(true);
                    }
                }
                StringBuilder __tmp15 = new StringBuilder();
                __tmp15.Append("[]");
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
                        }
                    }
                }
            }
            else if (t is Declaration) //150:2
            {
                bool __tmp17_outputWritten = false;
                StringBuilder __tmp18 = new StringBuilder();
                __tmp18.Append(GenerateRef(currentNs, (Declaration)t));
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
                    __out.AppendLine(false); //151:41
                }
            }
            else //152:2
            {
                StringBuilder __tmp21 = new StringBuilder();
                __tmp21.Append(t);
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
                        }
                    }
                }
            }
            return __out.ToString();
        }

        public string GenerateReturnType(Namespace currentNs, Operation op) //157:1
        {
            StringBuilder __out = new StringBuilder();
            if (op.Result.IsOneway) //158:2
            {
                __out.Append("oneway"); //159:1
            }
            else //160:2
            {
                StringBuilder __tmp3 = new StringBuilder();
                __tmp3.Append(GenerateType(currentNs, op.Result.Type));
                using(StreamReader __tmp3Reader = new StreamReader(this.__ToStream(__tmp3.ToString())))
                {
                    bool __tmp3_last = __tmp3Reader.EndOfStream;
                    while(!__tmp3_last)
                    {
                        string __tmp3_line = __tmp3Reader.ReadLine();
                        __tmp3_last = __tmp3Reader.EndOfStream;
                        if ((__tmp3_last && !string.IsNullOrEmpty(__tmp3_line)) || (!__tmp3_last && __tmp3_line != null))
                        {
                            __out.Append(__tmp3_line);
                        }
                    }
                }
            }
            return __out.ToString();
        }

        public string GenerateThrows(Namespace currentNs, Operation op) //165:1
        {
            StringBuilder __out = new StringBuilder();
            if ((from __loop12_var1 in __Enumerate((op).GetEnumerator()) //166:14
            from ex in __Enumerate((__loop12_var1.Exceptions).GetEnumerator()) //166:18
            select new { __loop12_var1 = __loop12_var1, ex = ex}
            ).GetEnumerator().MoveNext()) //166:2
            {
                __out.Append(" throws "); //167:1
                var __loop13_results = 
                    (from __loop13_var1 in __Enumerate((op).GetEnumerator()) //168:8
                    from ex in __Enumerate((__loop13_var1.Exceptions).GetEnumerator()) //168:12
                    select new { __loop13_var1 = __loop13_var1, ex = ex}
                    ).ToList(); //168:3
                for (int __loop13_iteration = 0; __loop13_iteration < __loop13_results.Count; ++__loop13_iteration)
                {
                    string comma; //168:25
                    if (__loop13_iteration+1 < __loop13_results.Count) comma = ", ";
                    else comma = string.Empty;
                    var __tmp1 = __loop13_results[__loop13_iteration];
                    var __loop13_var1 = __tmp1.__loop13_var1;
                    var ex = __tmp1.ex;
                    StringBuilder __tmp4 = new StringBuilder();
                    __tmp4.Append(GenerateType(currentNs, ex));
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
                            }
                            if (!__tmp4_last) __out.AppendLine(true);
                        }
                    }
                    StringBuilder __tmp5 = new StringBuilder();
                    __tmp5.Append(comma);
                    using(StreamReader __tmp5Reader = new StreamReader(this.__ToStream(__tmp5.ToString())))
                    {
                        bool __tmp5_last = __tmp5Reader.EndOfStream;
                        while(!__tmp5_last)
                        {
                            string __tmp5_line = __tmp5Reader.ReadLine();
                            __tmp5_last = __tmp5Reader.EndOfStream;
                            if ((__tmp5_last && !string.IsNullOrEmpty(__tmp5_line)) || (!__tmp5_last && __tmp5_line != null))
                            {
                                __out.Append(__tmp5_line);
                            }
                        }
                    }
                }
            }
            return __out.ToString();
        }

        public string GenerateParameters(Namespace currentNs, Operation op) //174:1
        {
            StringBuilder __out = new StringBuilder();
            var __loop14_results = 
                (from __loop14_var1 in __Enumerate((op).GetEnumerator()) //175:7
                from p in __Enumerate((__loop14_var1.Parameters).GetEnumerator()) //175:11
                select new { __loop14_var1 = __loop14_var1, p = p}
                ).ToList(); //175:2
            for (int __loop14_iteration = 0; __loop14_iteration < __loop14_results.Count; ++__loop14_iteration)
            {
                string comma; //175:23
                if (__loop14_iteration+1 < __loop14_results.Count) comma = ", ";
                else comma = string.Empty;
                var __tmp1 = __loop14_results[__loop14_iteration];
                var __loop14_var1 = __tmp1.__loop14_var1;
                var p = __tmp1.p;
                StringBuilder __tmp4 = new StringBuilder();
                __tmp4.Append(GenerateAnnotationsSingleLine(p, false));
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
                        }
                        if (!__tmp4_last) __out.AppendLine(true);
                    }
                }
                StringBuilder __tmp5 = new StringBuilder();
                __tmp5.Append(GenerateType(currentNs, p.Type));
                using(StreamReader __tmp5Reader = new StreamReader(this.__ToStream(__tmp5.ToString())))
                {
                    bool __tmp5_last = __tmp5Reader.EndOfStream;
                    while(!__tmp5_last)
                    {
                        string __tmp5_line = __tmp5Reader.ReadLine();
                        __tmp5_last = __tmp5Reader.EndOfStream;
                        if ((__tmp5_last && !string.IsNullOrEmpty(__tmp5_line)) || (!__tmp5_last && __tmp5_line != null))
                        {
                            __out.Append(__tmp5_line);
                        }
                        if (!__tmp5_last) __out.AppendLine(true);
                    }
                }
                string __tmp6_line = " "; //176:75
                if (!string.IsNullOrEmpty(__tmp6_line))
                {
                    __out.Append(__tmp6_line);
                }
                StringBuilder __tmp7 = new StringBuilder();
                __tmp7.Append(p.Name);
                using(StreamReader __tmp7Reader = new StreamReader(this.__ToStream(__tmp7.ToString())))
                {
                    bool __tmp7_last = __tmp7Reader.EndOfStream;
                    while(!__tmp7_last)
                    {
                        string __tmp7_line = __tmp7Reader.ReadLine();
                        __tmp7_last = __tmp7Reader.EndOfStream;
                        if ((__tmp7_last && !string.IsNullOrEmpty(__tmp7_line)) || (!__tmp7_last && __tmp7_line != null))
                        {
                            __out.Append(__tmp7_line);
                        }
                        if (!__tmp7_last) __out.AppendLine(true);
                    }
                }
                StringBuilder __tmp8 = new StringBuilder();
                __tmp8.Append(comma);
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
                        }
                    }
                }
            }
            return __out.ToString();
        }

        public string GenerateOperation(Namespace currentNs, Operation op) //180:1
        {
            StringBuilder __out = new StringBuilder();
            bool __tmp2_outputWritten = false;
            StringBuilder __tmp3 = new StringBuilder();
            __tmp3.Append(GenerateAnnotations(op, false));
            using(StreamReader __tmp3Reader = new StreamReader(this.__ToStream(__tmp3.ToString())))
            {
                bool __tmp3_last = __tmp3Reader.EndOfStream;
                while(!__tmp3_last)
                {
                    string __tmp3_line = __tmp3Reader.ReadLine();
                    __tmp3_last = __tmp3Reader.EndOfStream;
                    if ((__tmp3_last && !string.IsNullOrEmpty(__tmp3_line)) || (!__tmp3_last && __tmp3_line != null))
                    {
                        __out.Append(__tmp3_line);
                        __tmp2_outputWritten = true;
                    }
                    if (!__tmp3_last || __tmp2_outputWritten) __out.AppendLine(true);
                }
            }
            if (__tmp2_outputWritten)
            {
                __out.AppendLine(false); //181:33
            }
            bool __tmp5_outputWritten = false;
            StringBuilder __tmp6 = new StringBuilder();
            __tmp6.Append(GenerateAnnotations(op.Result, true));
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
                        __tmp5_outputWritten = true;
                    }
                    if (!__tmp6_last || __tmp5_outputWritten) __out.AppendLine(true);
                }
            }
            if (__tmp5_outputWritten)
            {
                __out.AppendLine(false); //182:39
            }
            bool __tmp8_outputWritten = false;
            StringBuilder __tmp9 = new StringBuilder();
            __tmp9.Append(GenerateReturnType(currentNs, op));
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
                        __tmp8_outputWritten = true;
                    }
                    if (!__tmp9_last) __out.AppendLine(true);
                }
            }
            string __tmp10_line = " "; //183:36
            if (!string.IsNullOrEmpty(__tmp10_line))
            {
                __out.Append(__tmp10_line);
                __tmp8_outputWritten = true;
            }
            StringBuilder __tmp11 = new StringBuilder();
            __tmp11.Append(op.Name);
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
                        __tmp8_outputWritten = true;
                    }
                    if (!__tmp11_last) __out.AppendLine(true);
                }
            }
            string __tmp12_line = "("; //183:46
            if (!string.IsNullOrEmpty(__tmp12_line))
            {
                __out.Append(__tmp12_line);
                __tmp8_outputWritten = true;
            }
            StringBuilder __tmp13 = new StringBuilder();
            __tmp13.Append(GenerateParameters(currentNs, op));
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
                        __tmp8_outputWritten = true;
                    }
                    if (!__tmp13_last) __out.AppendLine(true);
                }
            }
            string __tmp14_line = ")"; //183:82
            if (!string.IsNullOrEmpty(__tmp14_line))
            {
                __out.Append(__tmp14_line);
                __tmp8_outputWritten = true;
            }
            StringBuilder __tmp15 = new StringBuilder();
            __tmp15.Append(GenerateThrows(currentNs, op));
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
                        __tmp8_outputWritten = true;
                    }
                    if (!__tmp15_last) __out.AppendLine(true);
                }
            }
            string __tmp16_line = ";"; //183:114
            if (!string.IsNullOrEmpty(__tmp16_line))
            {
                __out.Append(__tmp16_line);
                __tmp8_outputWritten = true;
            }
            if (__tmp8_outputWritten) __out.AppendLine(true);
            if (__tmp8_outputWritten)
            {
                __out.AppendLine(false); //183:115
            }
            return __out.ToString();
        }

        public string GenerateInterface(Namespace currentNs, Interface intf) //186:1
        {
            StringBuilder __out = new StringBuilder();
            bool __tmp2_outputWritten = false;
            StringBuilder __tmp3 = new StringBuilder();
            __tmp3.Append(GenerateAnnotations(intf, false));
            using(StreamReader __tmp3Reader = new StreamReader(this.__ToStream(__tmp3.ToString())))
            {
                bool __tmp3_last = __tmp3Reader.EndOfStream;
                while(!__tmp3_last)
                {
                    string __tmp3_line = __tmp3Reader.ReadLine();
                    __tmp3_last = __tmp3Reader.EndOfStream;
                    if ((__tmp3_last && !string.IsNullOrEmpty(__tmp3_line)) || (!__tmp3_last && __tmp3_line != null))
                    {
                        __out.Append(__tmp3_line);
                        __tmp2_outputWritten = true;
                    }
                    if (!__tmp3_last || __tmp2_outputWritten) __out.AppendLine(true);
                }
            }
            if (__tmp2_outputWritten)
            {
                __out.AppendLine(false); //187:35
            }
            bool __tmp5_outputWritten = false;
            string __tmp6_line = "interface "; //188:1
            if (!string.IsNullOrEmpty(__tmp6_line))
            {
                __out.Append(__tmp6_line);
                __tmp5_outputWritten = true;
            }
            StringBuilder __tmp7 = new StringBuilder();
            __tmp7.Append(intf.Name);
            using(StreamReader __tmp7Reader = new StreamReader(this.__ToStream(__tmp7.ToString())))
            {
                bool __tmp7_last = __tmp7Reader.EndOfStream;
                while(!__tmp7_last)
                {
                    string __tmp7_line = __tmp7Reader.ReadLine();
                    __tmp7_last = __tmp7Reader.EndOfStream;
                    if ((__tmp7_last && !string.IsNullOrEmpty(__tmp7_line)) || (!__tmp7_last && __tmp7_line != null))
                    {
                        __out.Append(__tmp7_line);
                        __tmp5_outputWritten = true;
                    }
                    if (!__tmp7_last || __tmp5_outputWritten) __out.AppendLine(true);
                }
            }
            if (__tmp5_outputWritten)
            {
                __out.AppendLine(false); //188:22
            }
            __out.Append("{"); //189:1
            __out.AppendLine(false); //189:2
            var __loop15_results = 
                (from __loop15_var1 in __Enumerate((intf).GetEnumerator()) //190:8
                from op in __Enumerate((__loop15_var1.Operations).GetEnumerator()) //190:14
                select new { __loop15_var1 = __loop15_var1, op = op}
                ).ToList(); //190:3
            for (int __loop15_iteration = 0; __loop15_iteration < __loop15_results.Count; ++__loop15_iteration)
            {
                var __tmp8 = __loop15_results[__loop15_iteration];
                var __loop15_var1 = __tmp8.__loop15_var1;
                var op = __tmp8.op;
                bool __tmp10_outputWritten = false;
                string __tmp9Prefix = "	"; //191:1
                StringBuilder __tmp11 = new StringBuilder();
                __tmp11.Append(GenerateOperation(currentNs, op));
                using(StreamReader __tmp11Reader = new StreamReader(this.__ToStream(__tmp11.ToString())))
                {
                    bool __tmp11_last = __tmp11Reader.EndOfStream;
                    while(!__tmp11_last)
                    {
                        string __tmp11_line = __tmp11Reader.ReadLine();
                        __tmp11_last = __tmp11Reader.EndOfStream;
                        if (!string.IsNullOrEmpty(__tmp9Prefix))
                        {
                            __out.Append(__tmp9Prefix);
                            __tmp10_outputWritten = true;
                        }
                        if ((__tmp11_last && !string.IsNullOrEmpty(__tmp11_line)) || (!__tmp11_last && __tmp11_line != null))
                        {
                            __out.Append(__tmp11_line);
                            __tmp10_outputWritten = true;
                        }
                        if (!__tmp11_last || __tmp10_outputWritten) __out.AppendLine(true);
                    }
                }
                if (__tmp10_outputWritten)
                {
                    __out.AppendLine(false); //191:36
                }
            }
            __out.Append("}"); //193:1
            __out.AppendLine(false); //193:2
            return __out.ToString();
        }

        public string GenerateTransportBinding(Namespace currentNs, TransportBindingElement bnd) //196:1
        {
            StringBuilder __out = new StringBuilder();
            var __tmp1 = bnd; //197:10
            if (bnd is HttpTransportBindingElement) //198:2
            {
                if (((HttpTransportBindingElement)bnd).Ssl) //199:3
                {
                    __out.Append("transport HTTP"); //200:1
                    __out.AppendLine(false); //200:15
                    __out.Append("{"); //201:1
                    __out.AppendLine(false); //201:2
                    __out.Append("	Ssl = true;"); //202:1
                    __out.AppendLine(false); //202:13
                    bool __tmp3_outputWritten = false;
                    string __tmp4_line = "	ClientAuthentication = "; //203:1
                    if (!string.IsNullOrEmpty(__tmp4_line))
                    {
                        __out.Append(__tmp4_line);
                        __tmp3_outputWritten = true;
                    }
                    StringBuilder __tmp5 = new StringBuilder();
                    __tmp5.Append(((HttpTransportBindingElement)bnd).ClientAuthentication.ToString().ToLower());
                    using(StreamReader __tmp5Reader = new StreamReader(this.__ToStream(__tmp5.ToString())))
                    {
                        bool __tmp5_last = __tmp5Reader.EndOfStream;
                        while(!__tmp5_last)
                        {
                            string __tmp5_line = __tmp5Reader.ReadLine();
                            __tmp5_last = __tmp5Reader.EndOfStream;
                            if ((__tmp5_last && !string.IsNullOrEmpty(__tmp5_line)) || (!__tmp5_last && __tmp5_line != null))
                            {
                                __out.Append(__tmp5_line);
                                __tmp3_outputWritten = true;
                            }
                            if (!__tmp5_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp6_line = ";"; //203:72
                    if (!string.IsNullOrEmpty(__tmp6_line))
                    {
                        __out.Append(__tmp6_line);
                        __tmp3_outputWritten = true;
                    }
                    if (__tmp3_outputWritten) __out.AppendLine(true);
                    if (__tmp3_outputWritten)
                    {
                        __out.AppendLine(false); //203:73
                    }
                    __out.Append("}"); //204:1
                    __out.AppendLine(false); //204:2
                }
                else //205:3
                {
                    __out.Append("transport HTTP;"); //206:1
                    __out.AppendLine(false); //206:16
                }
            }
            else if (bnd is RestTransportBindingElement) //208:2
            {
                __out.Append("transport REST;"); //208:39
                __out.AppendLine(false); //208:54
            }
            else if (bnd is WebSocketTransportBindingElement) //209:2
            {
                __out.Append("transport WebSocket;"); //209:44
                __out.AppendLine(false); //209:64
            }//210:2
            return __out.ToString();
        }

        public string GenerateEncodingBinding(Namespace currentNs, EncodingBindingElement bnd) //213:1
        {
            StringBuilder __out = new StringBuilder();
            var __tmp1 = bnd; //214:10
            if (bnd is SoapEncodingBindingElement) //215:2
            {
                if (((SoapEncodingBindingElement)bnd).Style != SoapEncodingStyle.DocumentWrapped || ((SoapEncodingBindingElement)bnd).Version != SoapVersion.Soap11 || ((SoapEncodingBindingElement)bnd).Mtom) //216:2
                {
                    __out.Append("encoding SOAP"); //217:1
                    __out.AppendLine(false); //217:14
                    __out.Append("{"); //218:1
                    __out.AppendLine(false); //218:2
                    if (((SoapEncodingBindingElement)bnd).Style != SoapEncodingStyle.DocumentWrapped) //219:3
                    {
                        bool __tmp3_outputWritten = false;
                        string __tmp4_line = "	Style = "; //220:1
                        if (!string.IsNullOrEmpty(__tmp4_line))
                        {
                            __out.Append(__tmp4_line);
                            __tmp3_outputWritten = true;
                        }
                        StringBuilder __tmp5 = new StringBuilder();
                        __tmp5.Append(((SoapEncodingBindingElement)bnd).Style);
                        using(StreamReader __tmp5Reader = new StreamReader(this.__ToStream(__tmp5.ToString())))
                        {
                            bool __tmp5_last = __tmp5Reader.EndOfStream;
                            while(!__tmp5_last)
                            {
                                string __tmp5_line = __tmp5Reader.ReadLine();
                                __tmp5_last = __tmp5Reader.EndOfStream;
                                if ((__tmp5_last && !string.IsNullOrEmpty(__tmp5_line)) || (!__tmp5_last && __tmp5_line != null))
                                {
                                    __out.Append(__tmp5_line);
                                    __tmp3_outputWritten = true;
                                }
                                if (!__tmp5_last) __out.AppendLine(true);
                            }
                        }
                        string __tmp6_line = ";"; //220:21
                        if (!string.IsNullOrEmpty(__tmp6_line))
                        {
                            __out.Append(__tmp6_line);
                            __tmp3_outputWritten = true;
                        }
                        if (__tmp3_outputWritten) __out.AppendLine(true);
                        if (__tmp3_outputWritten)
                        {
                            __out.AppendLine(false); //220:22
                        }
                    }
                    if (((SoapEncodingBindingElement)bnd).Version != SoapVersion.Soap11) //222:3
                    {
                        bool __tmp8_outputWritten = false;
                        string __tmp9_line = "	Version = "; //223:1
                        if (!string.IsNullOrEmpty(__tmp9_line))
                        {
                            __out.Append(__tmp9_line);
                            __tmp8_outputWritten = true;
                        }
                        StringBuilder __tmp10 = new StringBuilder();
                        __tmp10.Append(((SoapEncodingBindingElement)bnd).Version);
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
                        string __tmp11_line = ";"; //223:25
                        if (!string.IsNullOrEmpty(__tmp11_line))
                        {
                            __out.Append(__tmp11_line);
                            __tmp8_outputWritten = true;
                        }
                        if (__tmp8_outputWritten) __out.AppendLine(true);
                        if (__tmp8_outputWritten)
                        {
                            __out.AppendLine(false); //223:26
                        }
                    }
                    if (((SoapEncodingBindingElement)bnd).Mtom) //225:3
                    {
                        __out.Append("	Mtom = true;"); //226:1
                        __out.AppendLine(false); //226:14
                    }
                    __out.Append("}"); //228:1
                    __out.AppendLine(false); //228:2
                }
                else //229:2
                {
                    __out.Append("encoding SOAP;"); //230:1
                    __out.AppendLine(false); //230:15
                }
            }
            else if (bnd is XmlEncodingBindingElement) //232:2
            {
                __out.Append("encoding XML;"); //232:37
                __out.AppendLine(false); //232:50
            }
            else if (bnd is JsonEncodingBindingElement) //233:2
            {
                __out.Append("encoding JSON;"); //233:38
                __out.AppendLine(false); //233:52
            }//234:2
            return __out.ToString();
        }

        public string GenerateProtocolBinding(Namespace currentNs, ProtocolBindingElement bnd) //237:1
        {
            StringBuilder __out = new StringBuilder();
            var __tmp1 = bnd; //238:10
            if (bnd is WsAddressingBindingElement) //239:2
            {
                __out.Append("protocol WsAddressing;"); //239:38
                __out.AppendLine(false); //239:60
            }//240:2
            return __out.ToString();
        }

        public string GenerateBinding(Namespace currentNs, Symbols.Binding bnd) //243:1
        {
            StringBuilder __out = new StringBuilder();
            bool __tmp2_outputWritten = false;
            string __tmp3_line = "binding "; //244:1
            if (!string.IsNullOrEmpty(__tmp3_line))
            {
                __out.Append(__tmp3_line);
                __tmp2_outputWritten = true;
            }
            StringBuilder __tmp4 = new StringBuilder();
            __tmp4.Append(bnd.Name);
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
                    if (!__tmp4_last || __tmp2_outputWritten) __out.AppendLine(true);
                }
            }
            if (__tmp2_outputWritten)
            {
                __out.AppendLine(false); //244:19
            }
            __out.Append("{"); //245:1
            __out.AppendLine(false); //245:2
            bool __tmp6_outputWritten = false;
            string __tmp5Prefix = "	"; //246:1
            StringBuilder __tmp7 = new StringBuilder();
            __tmp7.Append(GenerateTransportBinding(currentNs, bnd.Transport));
            using(StreamReader __tmp7Reader = new StreamReader(this.__ToStream(__tmp7.ToString())))
            {
                bool __tmp7_last = __tmp7Reader.EndOfStream;
                while(!__tmp7_last)
                {
                    string __tmp7_line = __tmp7Reader.ReadLine();
                    __tmp7_last = __tmp7Reader.EndOfStream;
                    if (!string.IsNullOrEmpty(__tmp5Prefix))
                    {
                        __out.Append(__tmp5Prefix);
                        __tmp6_outputWritten = true;
                    }
                    if ((__tmp7_last && !string.IsNullOrEmpty(__tmp7_line)) || (!__tmp7_last && __tmp7_line != null))
                    {
                        __out.Append(__tmp7_line);
                        __tmp6_outputWritten = true;
                    }
                    if (!__tmp7_last || __tmp6_outputWritten) __out.AppendLine(true);
                }
            }
            if (__tmp6_outputWritten)
            {
                __out.AppendLine(false); //246:54
            }
            var __loop16_results = 
                (from __loop16_var1 in __Enumerate((bnd).GetEnumerator()) //247:8
                from enc in __Enumerate((__loop16_var1.Encodings).GetEnumerator()) //247:13
                select new { __loop16_var1 = __loop16_var1, enc = enc}
                ).ToList(); //247:3
            for (int __loop16_iteration = 0; __loop16_iteration < __loop16_results.Count; ++__loop16_iteration)
            {
                var __tmp8 = __loop16_results[__loop16_iteration];
                var __loop16_var1 = __tmp8.__loop16_var1;
                var enc = __tmp8.enc;
                bool __tmp10_outputWritten = false;
                string __tmp9Prefix = "	"; //248:1
                StringBuilder __tmp11 = new StringBuilder();
                __tmp11.Append(GenerateEncodingBinding(currentNs, enc));
                using(StreamReader __tmp11Reader = new StreamReader(this.__ToStream(__tmp11.ToString())))
                {
                    bool __tmp11_last = __tmp11Reader.EndOfStream;
                    while(!__tmp11_last)
                    {
                        string __tmp11_line = __tmp11Reader.ReadLine();
                        __tmp11_last = __tmp11Reader.EndOfStream;
                        if (!string.IsNullOrEmpty(__tmp9Prefix))
                        {
                            __out.Append(__tmp9Prefix);
                            __tmp10_outputWritten = true;
                        }
                        if ((__tmp11_last && !string.IsNullOrEmpty(__tmp11_line)) || (!__tmp11_last && __tmp11_line != null))
                        {
                            __out.Append(__tmp11_line);
                            __tmp10_outputWritten = true;
                        }
                        if (!__tmp11_last || __tmp10_outputWritten) __out.AppendLine(true);
                    }
                }
                if (__tmp10_outputWritten)
                {
                    __out.AppendLine(false); //248:43
                }
            }
            var __loop17_results = 
                (from __loop17_var1 in __Enumerate((bnd).GetEnumerator()) //250:8
                from prot in __Enumerate((__loop17_var1.Protocols).GetEnumerator()) //250:13
                select new { __loop17_var1 = __loop17_var1, prot = prot}
                ).ToList(); //250:3
            for (int __loop17_iteration = 0; __loop17_iteration < __loop17_results.Count; ++__loop17_iteration)
            {
                var __tmp12 = __loop17_results[__loop17_iteration];
                var __loop17_var1 = __tmp12.__loop17_var1;
                var prot = __tmp12.prot;
                bool __tmp14_outputWritten = false;
                string __tmp13Prefix = "	"; //251:1
                StringBuilder __tmp15 = new StringBuilder();
                __tmp15.Append(GenerateProtocolBinding(currentNs, prot));
                using(StreamReader __tmp15Reader = new StreamReader(this.__ToStream(__tmp15.ToString())))
                {
                    bool __tmp15_last = __tmp15Reader.EndOfStream;
                    while(!__tmp15_last)
                    {
                        string __tmp15_line = __tmp15Reader.ReadLine();
                        __tmp15_last = __tmp15Reader.EndOfStream;
                        if (!string.IsNullOrEmpty(__tmp13Prefix))
                        {
                            __out.Append(__tmp13Prefix);
                            __tmp14_outputWritten = true;
                        }
                        if ((__tmp15_last && !string.IsNullOrEmpty(__tmp15_line)) || (!__tmp15_last && __tmp15_line != null))
                        {
                            __out.Append(__tmp15_line);
                            __tmp14_outputWritten = true;
                        }
                        if (!__tmp15_last || __tmp14_outputWritten) __out.AppendLine(true);
                    }
                }
                if (__tmp14_outputWritten)
                {
                    __out.AppendLine(false); //251:44
                }
            }
            __out.Append("}"); //253:1
            __out.AppendLine(false); //253:2
            return __out.ToString();
        }

        public string GenerateEndpoint(Namespace currentNs, Endpoint endp) //256:1
        {
            StringBuilder __out = new StringBuilder();
            bool __tmp2_outputWritten = false;
            string __tmp3_line = "endpoint "; //257:1
            if (!string.IsNullOrEmpty(__tmp3_line))
            {
                __out.Append(__tmp3_line);
                __tmp2_outputWritten = true;
            }
            StringBuilder __tmp4 = new StringBuilder();
            __tmp4.Append(endp.Name);
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
            string __tmp5_line = " : "; //257:21
            if (!string.IsNullOrEmpty(__tmp5_line))
            {
                __out.Append(__tmp5_line);
                __tmp2_outputWritten = true;
            }
            StringBuilder __tmp6 = new StringBuilder();
            __tmp6.Append(GenerateRef(currentNs, endp.Interface));
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
                    if (!__tmp6_last || __tmp2_outputWritten) __out.AppendLine(true);
                }
            }
            if (__tmp2_outputWritten)
            {
                __out.AppendLine(false); //257:64
            }
            __out.Append("{"); //258:1
            __out.AppendLine(false); //258:2
            bool __tmp8_outputWritten = false;
            string __tmp9_line = "	binding "; //259:1
            if (!string.IsNullOrEmpty(__tmp9_line))
            {
                __out.Append(__tmp9_line);
                __tmp8_outputWritten = true;
            }
            StringBuilder __tmp10 = new StringBuilder();
            __tmp10.Append(GenerateRef(currentNs, endp.Binding));
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
            string __tmp11_line = ";"; //259:48
            if (!string.IsNullOrEmpty(__tmp11_line))
            {
                __out.Append(__tmp11_line);
                __tmp8_outputWritten = true;
            }
            if (__tmp8_outputWritten) __out.AppendLine(true);
            if (__tmp8_outputWritten)
            {
                __out.AppendLine(false); //259:49
            }
            bool __tmp13_outputWritten = false;
            string __tmp14_line = "	address \""; //260:1
            if (!string.IsNullOrEmpty(__tmp14_line))
            {
                __out.Append(__tmp14_line);
                __tmp13_outputWritten = true;
            }
            StringBuilder __tmp15 = new StringBuilder();
            __tmp15.Append(endp.Address);
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
            string __tmp16_line = "\";"; //260:25
            if (!string.IsNullOrEmpty(__tmp16_line))
            {
                __out.Append(__tmp16_line);
                __tmp13_outputWritten = true;
            }
            if (__tmp13_outputWritten) __out.AppendLine(true);
            if (__tmp13_outputWritten)
            {
                __out.AppendLine(false); //260:27
            }
            __out.Append("}"); //261:1
            __out.AppendLine(false); //261:2
            return __out.ToString();
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
