using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Soal //1:1
{
    using __Hidden_SoalPrinter_1382163557;
    namespace __Hidden_SoalPrinter_1382163557
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
        private IEnumerable<MetaDslx.Core.ModelObject> Instances; //2:1

        public SoalPrinter() //2:1
        {
        }

        public SoalPrinter(IEnumerable<MetaDslx.Core.ModelObject> instances) : this() //2:1
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

        public string Generate() //4:1
        {
            StringBuilder __out = new StringBuilder();
            var __loop1_results = 
                (from __loop1_var1 in __Enumerate((Instances).GetEnumerator()) //5:7
                from ns in __Enumerate((__loop1_var1).GetEnumerator()).OfType<Namespace>() //5:18
                select new { __loop1_var1 = __loop1_var1, ns = ns}
                ).ToList(); //5:2
            int __loop1_iteration = 0;
            foreach (var __tmp1 in __loop1_results)
            {
                ++__loop1_iteration;
                var __loop1_var1 = __tmp1.__loop1_var1;
                var ns = __tmp1.ns;
                StringBuilder __tmp3 = new StringBuilder();
                __tmp3.Append(GenerateNamespace(ns));
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
                        __out.AppendLine(false); //6:24
                    }
                }
            }
            return __out.ToString();
        }

        public string GenerateNamespace(Namespace ns) //10:1
        {
            StringBuilder __out = new StringBuilder();
            if (ns.Declarations.Count > 0) //11:2
            {
                if (ns.Prefix != null) //12:2
                {
                    string __tmp2Line = "namespace "; //13:1
                    if (__tmp2Line != null) __out.Append(__tmp2Line);
                    StringBuilder __tmp3 = new StringBuilder();
                    __tmp3.Append(ns.FullName);
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
                    string __tmp4Line = " = "; //13:24
                    if (__tmp4Line != null) __out.Append(__tmp4Line);
                    StringBuilder __tmp5 = new StringBuilder();
                    __tmp5.Append(ns.Prefix);
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
                    string __tmp6Line = ":\""; //13:38
                    if (__tmp6Line != null) __out.Append(__tmp6Line);
                    StringBuilder __tmp7 = new StringBuilder();
                    __tmp7.Append(ns.Uri);
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
                    string __tmp8Line = "\""; //13:48
                    if (__tmp8Line != null) __out.Append(__tmp8Line);
                    __out.AppendLine(false); //13:49
                }
                else //14:2
                {
                    string __tmp10Line = "namespace "; //15:1
                    if (__tmp10Line != null) __out.Append(__tmp10Line);
                    StringBuilder __tmp11 = new StringBuilder();
                    __tmp11.Append(ns.FullName);
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
                    string __tmp12Line = " = \""; //15:24
                    if (__tmp12Line != null) __out.Append(__tmp12Line);
                    StringBuilder __tmp13 = new StringBuilder();
                    __tmp13.Append(ns.Uri);
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
                    string __tmp14Line = "\""; //15:36
                    if (__tmp14Line != null) __out.Append(__tmp14Line);
                    __out.AppendLine(false); //15:37
                }
                __out.Append("{"); //17:1
                __out.AppendLine(false); //17:2
                var __loop2_results = 
                    (from __loop2_var1 in __Enumerate((ns).GetEnumerator()) //18:8
                    from Declarations in __Enumerate((__loop2_var1.Declarations).GetEnumerator()) //18:12
                    from enm in __Enumerate((Declarations).GetEnumerator()).OfType<Enum>() //18:26
                    select new { __loop2_var1 = __loop2_var1, Declarations = Declarations, enm = enm}
                    ).ToList(); //18:3
                int __loop2_iteration = 0;
                foreach (var __tmp15 in __loop2_results)
                {
                    ++__loop2_iteration;
                    var __loop2_var1 = __tmp15.__loop2_var1;
                    var Declarations = __tmp15.Declarations;
                    var enm = __tmp15.enm;
                    string __tmp16Prefix = "	"; //19:1
                    StringBuilder __tmp17 = new StringBuilder();
                    __tmp17.Append(GenerateEnum(ns, enm));
                    using(StreamReader __tmp17Reader = new StreamReader(this.__ToStream(__tmp17.ToString())))
                    {
                        bool __tmp17_first = true;
                        bool __tmp17_last = __tmp17Reader.EndOfStream;
                        while(__tmp17_first || !__tmp17_last)
                        {
                            __tmp17_first = false;
                            string __tmp17Line = __tmp17Reader.ReadLine();
                            __tmp17_last = __tmp17Reader.EndOfStream;
                            __out.Append(__tmp16Prefix);
                            if (__tmp17Line != null) __out.Append(__tmp17Line);
                            if (!__tmp17_last) __out.AppendLine(true);
                            __out.AppendLine(false); //19:25
                        }
                    }
                    __out.AppendLine(true); //20:1
                }
                var __loop3_results = 
                    (from __loop3_var1 in __Enumerate((ns).GetEnumerator()) //22:8
                    from Declarations in __Enumerate((__loop3_var1.Declarations).GetEnumerator()) //22:12
                    from st in __Enumerate((Declarations).GetEnumerator()).OfType<Struct>() //22:26
                    select new { __loop3_var1 = __loop3_var1, Declarations = Declarations, st = st}
                    ).ToList(); //22:3
                int __loop3_iteration = 0;
                foreach (var __tmp18 in __loop3_results)
                {
                    ++__loop3_iteration;
                    var __loop3_var1 = __tmp18.__loop3_var1;
                    var Declarations = __tmp18.Declarations;
                    var st = __tmp18.st;
                    string __tmp19Prefix = "	"; //23:1
                    StringBuilder __tmp20 = new StringBuilder();
                    __tmp20.Append(GenerateStruct(ns, st));
                    using(StreamReader __tmp20Reader = new StreamReader(this.__ToStream(__tmp20.ToString())))
                    {
                        bool __tmp20_first = true;
                        bool __tmp20_last = __tmp20Reader.EndOfStream;
                        while(__tmp20_first || !__tmp20_last)
                        {
                            __tmp20_first = false;
                            string __tmp20Line = __tmp20Reader.ReadLine();
                            __tmp20_last = __tmp20Reader.EndOfStream;
                            __out.Append(__tmp19Prefix);
                            if (__tmp20Line != null) __out.Append(__tmp20Line);
                            if (!__tmp20_last) __out.AppendLine(true);
                            __out.AppendLine(false); //23:26
                        }
                    }
                    __out.AppendLine(true); //24:1
                }
                var __loop4_results = 
                    (from __loop4_var1 in __Enumerate((ns).GetEnumerator()) //26:8
                    from Declarations in __Enumerate((__loop4_var1.Declarations).GetEnumerator()) //26:12
                    from intf in __Enumerate((Declarations).GetEnumerator()).OfType<Interface>() //26:26
                    select new { __loop4_var1 = __loop4_var1, Declarations = Declarations, intf = intf}
                    ).ToList(); //26:3
                int __loop4_iteration = 0;
                foreach (var __tmp21 in __loop4_results)
                {
                    ++__loop4_iteration;
                    var __loop4_var1 = __tmp21.__loop4_var1;
                    var Declarations = __tmp21.Declarations;
                    var intf = __tmp21.intf;
                    string __tmp22Prefix = "	"; //27:1
                    StringBuilder __tmp23 = new StringBuilder();
                    __tmp23.Append(GenerateInterface(ns, intf));
                    using(StreamReader __tmp23Reader = new StreamReader(this.__ToStream(__tmp23.ToString())))
                    {
                        bool __tmp23_first = true;
                        bool __tmp23_last = __tmp23Reader.EndOfStream;
                        while(__tmp23_first || !__tmp23_last)
                        {
                            __tmp23_first = false;
                            string __tmp23Line = __tmp23Reader.ReadLine();
                            __tmp23_last = __tmp23Reader.EndOfStream;
                            __out.Append(__tmp22Prefix);
                            if (__tmp23Line != null) __out.Append(__tmp23Line);
                            if (!__tmp23_last) __out.AppendLine(true);
                            __out.AppendLine(false); //27:31
                        }
                    }
                    __out.AppendLine(true); //28:1
                }
                var __loop5_results = 
                    (from __loop5_var1 in __Enumerate((ns).GetEnumerator()) //30:8
                    from Declarations in __Enumerate((__loop5_var1.Declarations).GetEnumerator()) //30:12
                    from bnd in __Enumerate((Declarations).GetEnumerator()).OfType<Binding>() //30:26
                    select new { __loop5_var1 = __loop5_var1, Declarations = Declarations, bnd = bnd}
                    ).ToList(); //30:3
                int __loop5_iteration = 0;
                foreach (var __tmp24 in __loop5_results)
                {
                    ++__loop5_iteration;
                    var __loop5_var1 = __tmp24.__loop5_var1;
                    var Declarations = __tmp24.Declarations;
                    var bnd = __tmp24.bnd;
                    string __tmp25Prefix = "	"; //31:1
                    StringBuilder __tmp26 = new StringBuilder();
                    __tmp26.Append(GenerateBinding(ns, bnd));
                    using(StreamReader __tmp26Reader = new StreamReader(this.__ToStream(__tmp26.ToString())))
                    {
                        bool __tmp26_first = true;
                        bool __tmp26_last = __tmp26Reader.EndOfStream;
                        while(__tmp26_first || !__tmp26_last)
                        {
                            __tmp26_first = false;
                            string __tmp26Line = __tmp26Reader.ReadLine();
                            __tmp26_last = __tmp26Reader.EndOfStream;
                            __out.Append(__tmp25Prefix);
                            if (__tmp26Line != null) __out.Append(__tmp26Line);
                            if (!__tmp26_last) __out.AppendLine(true);
                            __out.AppendLine(false); //31:28
                        }
                    }
                    __out.AppendLine(true); //32:1
                }
                var __loop6_results = 
                    (from __loop6_var1 in __Enumerate((ns).GetEnumerator()) //34:8
                    from Declarations in __Enumerate((__loop6_var1.Declarations).GetEnumerator()) //34:12
                    from endp in __Enumerate((Declarations).GetEnumerator()).OfType<Endpoint>() //34:26
                    select new { __loop6_var1 = __loop6_var1, Declarations = Declarations, endp = endp}
                    ).ToList(); //34:3
                int __loop6_iteration = 0;
                foreach (var __tmp27 in __loop6_results)
                {
                    ++__loop6_iteration;
                    var __loop6_var1 = __tmp27.__loop6_var1;
                    var Declarations = __tmp27.Declarations;
                    var endp = __tmp27.endp;
                    string __tmp28Prefix = "	"; //35:1
                    StringBuilder __tmp29 = new StringBuilder();
                    __tmp29.Append(GenerateEndpoint(ns, endp));
                    using(StreamReader __tmp29Reader = new StreamReader(this.__ToStream(__tmp29.ToString())))
                    {
                        bool __tmp29_first = true;
                        bool __tmp29_last = __tmp29Reader.EndOfStream;
                        while(__tmp29_first || !__tmp29_last)
                        {
                            __tmp29_first = false;
                            string __tmp29Line = __tmp29Reader.ReadLine();
                            __tmp29_last = __tmp29Reader.EndOfStream;
                            __out.Append(__tmp28Prefix);
                            if (__tmp29Line != null) __out.Append(__tmp29Line);
                            if (!__tmp29_last) __out.AppendLine(true);
                            __out.AppendLine(false); //35:30
                        }
                    }
                    __out.AppendLine(true); //36:1
                }
                __out.Append("}"); //38:1
                __out.AppendLine(false); //38:2
                __out.AppendLine(true); //39:1
            }
            return __out.ToString();
        }

        public string GetAncestor(Namespace currentNs, SoalType st) //43:1
        {
            if (st is Enum) //44:2
            {
                Enum baseType = ((Enum)st).BaseType; //45:3
                if (baseType != null) //46:3
                {
                    if (baseType.Namespace == currentNs) //47:4
                    {
                        return " : " + baseType.Name; //48:5
                    }
                    else //49:4
                    {
                        return " : " + baseType.FullName(); //50:5
                    }
                }
            }
            else if (st is Struct) //53:2
            {
                Struct baseType = ((Struct)st).BaseType; //54:3
                if (baseType != null) //55:3
                {
                    if (baseType.Namespace == currentNs) //56:4
                    {
                        return " : " + baseType.Name; //57:5
                    }
                    else //58:4
                    {
                        return " : " + baseType.FullName(); //59:5
                    }
                }
            }
            return ""; //63:2
        }

        public string GenerateAnnotations(AnnotatedElement ae, bool isReturn) //66:1
        {
            StringBuilder __out = new StringBuilder();
            var __loop7_results = 
                (from __loop7_var1 in __Enumerate((ae).GetEnumerator()) //67:7
                from annot in __Enumerate((__loop7_var1.Annotations).GetEnumerator()) //67:11
                select new { __loop7_var1 = __loop7_var1, annot = annot}
                ).ToList(); //67:2
            int __loop7_iteration = 0;
            foreach (var __tmp1 in __loop7_results)
            {
                ++__loop7_iteration;
                var __loop7_var1 = __tmp1.__loop7_var1;
                var annot = __tmp1.annot;
                StringBuilder __tmp3 = new StringBuilder();
                __tmp3.Append("[");
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
                StringBuilder __tmp4 = new StringBuilder();
                __tmp4.Append(isReturn ? "return: " : "");
                using(StreamReader __tmp4Reader = new StreamReader(this.__ToStream(__tmp4.ToString())))
                {
                    bool __tmp4_first = true;
                    bool __tmp4_last = __tmp4Reader.EndOfStream;
                    while(__tmp4_first || !__tmp4_last)
                    {
                        __tmp4_first = false;
                        string __tmp4Line = __tmp4Reader.ReadLine();
                        __tmp4_last = __tmp4Reader.EndOfStream;
                        if (__tmp4Line != null) __out.Append(__tmp4Line);
                        if (!__tmp4_last) __out.AppendLine(true);
                    }
                }
                StringBuilder __tmp5 = new StringBuilder();
                __tmp5.Append(annot.Name);
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
                if (annot.Properties.Count > 0) //68:47
                {
                    string __tmp7Line = "("; //68:78
                    if (__tmp7Line != null) __out.Append(__tmp7Line);
                    StringBuilder __tmp8 = new StringBuilder();
                    __tmp8.Append(GenerateAnnotationProperties(annot));
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
                    string __tmp9Line = ")"; //68:116
                    if (__tmp9Line != null) __out.Append(__tmp9Line);
                }
                StringBuilder __tmp11 = new StringBuilder();
                __tmp11.Append("]");
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
                        __out.AppendLine(false); //68:130
                    }
                }
            }
            return __out.ToString();
        }

        public string GenerateAnnotationsSingleLine(AnnotatedElement ae, bool isReturn) //72:1
        {
            StringBuilder __out = new StringBuilder();
            var __loop8_results = 
                (from __loop8_var1 in __Enumerate((ae).GetEnumerator()) //73:7
                from annot in __Enumerate((__loop8_var1.Annotations).GetEnumerator()) //73:11
                select new { __loop8_var1 = __loop8_var1, annot = annot}
                ).ToList(); //73:2
            int __loop8_iteration = 0;
            foreach (var __tmp1 in __loop8_results)
            {
                ++__loop8_iteration;
                var __loop8_var1 = __tmp1.__loop8_var1;
                var annot = __tmp1.annot;
                StringBuilder __tmp3 = new StringBuilder();
                __tmp3.Append("[");
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
                StringBuilder __tmp4 = new StringBuilder();
                __tmp4.Append(isReturn ? "return: " : "");
                using(StreamReader __tmp4Reader = new StreamReader(this.__ToStream(__tmp4.ToString())))
                {
                    bool __tmp4_first = true;
                    bool __tmp4_last = __tmp4Reader.EndOfStream;
                    while(__tmp4_first || !__tmp4_last)
                    {
                        __tmp4_first = false;
                        string __tmp4Line = __tmp4Reader.ReadLine();
                        __tmp4_last = __tmp4Reader.EndOfStream;
                        if (__tmp4Line != null) __out.Append(__tmp4Line);
                        if (!__tmp4_last) __out.AppendLine(true);
                    }
                }
                StringBuilder __tmp5 = new StringBuilder();
                __tmp5.Append(annot.Name);
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
                if (annot.Properties.Count > 0) //74:47
                {
                    string __tmp7Line = "("; //74:78
                    if (__tmp7Line != null) __out.Append(__tmp7Line);
                    StringBuilder __tmp8 = new StringBuilder();
                    __tmp8.Append(GenerateAnnotationProperties(annot));
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
                    string __tmp9Line = ")"; //74:116
                    if (__tmp9Line != null) __out.Append(__tmp9Line);
                }
                StringBuilder __tmp11 = new StringBuilder();
                __tmp11.Append("]");
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
            }
            return __out.ToString();
        }

        public string GenerateAnnotationProperties(Annotation annot) //78:1
        {
            StringBuilder __out = new StringBuilder();
            var __loop9_results = 
                (from __loop9_var1 in __Enumerate((annot).GetEnumerator()) //79:7
                from prop in __Enumerate((__loop9_var1.Properties).GetEnumerator()) //79:14
                select new { __loop9_var1 = __loop9_var1, prop = prop}
                ).ToList(); //79:2
            int __loop9_iteration = 0;
            string delim = ""; //79:31
            foreach (var __tmp1 in __loop9_results)
            {
                ++__loop9_iteration;
                if (__loop9_iteration >= 2) //79:50
                {
                    delim = ", "; //79:50
                }
                var __loop9_var1 = __tmp1.__loop9_var1;
                var prop = __tmp1.prop;
                StringBuilder __tmp3 = new StringBuilder();
                __tmp3.Append(delim);
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
                StringBuilder __tmp4 = new StringBuilder();
                __tmp4.Append(prop.Name);
                using(StreamReader __tmp4Reader = new StreamReader(this.__ToStream(__tmp4.ToString())))
                {
                    bool __tmp4_first = true;
                    bool __tmp4_last = __tmp4Reader.EndOfStream;
                    while(__tmp4_first || !__tmp4_last)
                    {
                        __tmp4_first = false;
                        string __tmp4Line = __tmp4Reader.ReadLine();
                        __tmp4_last = __tmp4Reader.EndOfStream;
                        if (__tmp4Line != null) __out.Append(__tmp4Line);
                        if (!__tmp4_last) __out.AppendLine(true);
                    }
                }
                string __tmp5Line = "="; //80:19
                if (__tmp5Line != null) __out.Append(__tmp5Line);
                StringBuilder __tmp6 = new StringBuilder();
                __tmp6.Append(GetAnnotationPropertyValue(prop));
                using(StreamReader __tmp6Reader = new StreamReader(this.__ToStream(__tmp6.ToString())))
                {
                    bool __tmp6_first = true;
                    bool __tmp6_last = __tmp6Reader.EndOfStream;
                    while(__tmp6_first || !__tmp6_last)
                    {
                        __tmp6_first = false;
                        string __tmp6Line = __tmp6Reader.ReadLine();
                        __tmp6_last = __tmp6Reader.EndOfStream;
                        if (__tmp6Line != null) __out.Append(__tmp6Line);
                        if (!__tmp6_last) __out.AppendLine(true);
                    }
                }
            }
            return __out.ToString();
        }

        public string GetAnnotationPropertyValue(AnnotationProperty prop) //84:1
        {
            if (prop.Value == null) //85:2
            {
                return string.Empty; //86:3
            }
            if (prop.Value is string) //88:2
            {
                return "\"" + prop.Value + "\""; //89:3
            }
            else if (prop.Value is bool) //90:2
            {
                return prop.Value.ToString().ToLower(); //91:3
            }
            else //92:2
            {
                return prop.Value.ToString(); //93:3
            }
        }

        public string GenerateEnum(Namespace currentNs, Enum enm) //97:1
        {
            StringBuilder __out = new StringBuilder();
            StringBuilder __tmp2 = new StringBuilder();
            __tmp2.Append(GenerateAnnotations(enm, false));
            using(StreamReader __tmp2Reader = new StreamReader(this.__ToStream(__tmp2.ToString())))
            {
                bool __tmp2_first = true;
                bool __tmp2_last = __tmp2Reader.EndOfStream;
                while(__tmp2_first || !__tmp2_last)
                {
                    __tmp2_first = false;
                    string __tmp2Line = __tmp2Reader.ReadLine();
                    __tmp2_last = __tmp2Reader.EndOfStream;
                    if (__tmp2Line != null) __out.Append(__tmp2Line);
                    if (!__tmp2_last) __out.AppendLine(true);
                    __out.AppendLine(false); //98:34
                }
            }
            string __tmp4Line = "enum "; //99:1
            if (__tmp4Line != null) __out.Append(__tmp4Line);
            StringBuilder __tmp5 = new StringBuilder();
            __tmp5.Append(enm.Name);
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
            string __tmp6Line = " "; //99:16
            if (__tmp6Line != null) __out.Append(__tmp6Line);
            StringBuilder __tmp7 = new StringBuilder();
            __tmp7.Append(GetAncestor(currentNs, enm));
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
                    __out.AppendLine(false); //99:46
                }
            }
            __out.Append("{"); //100:1
            __out.AppendLine(false); //100:2
            var __loop10_results = 
                (from lit in __Enumerate((enm.EnumLiterals).GetEnumerator()) //101:8
                select new { lit = lit}
                ).ToList(); //101:3
            int __loop10_iteration = 0;
            string delim = ","; //101:30
            foreach (var __tmp8 in __loop10_results)
            {
                ++__loop10_iteration;
                var lit = __tmp8.lit;
                string __tmp9Prefix = "	"; //102:1
                StringBuilder __tmp10 = new StringBuilder();
                __tmp10.Append(GenerateEnumLiteral(currentNs, lit));
                using(StreamReader __tmp10Reader = new StreamReader(this.__ToStream(__tmp10.ToString())))
                {
                    bool __tmp10_first = true;
                    bool __tmp10_last = __tmp10Reader.EndOfStream;
                    while(__tmp10_first || !__tmp10_last)
                    {
                        __tmp10_first = false;
                        string __tmp10Line = __tmp10Reader.ReadLine();
                        __tmp10_last = __tmp10Reader.EndOfStream;
                        __out.Append(__tmp9Prefix);
                        if (__tmp10Line != null) __out.Append(__tmp10Line);
                        if (!__tmp10_last) __out.AppendLine(true);
                    }
                }
                StringBuilder __tmp11 = new StringBuilder();
                __tmp11.Append(delim);
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
                        __out.AppendLine(false); //102:46
                    }
                }
            }
            __out.Append("}"); //104:1
            __out.AppendLine(false); //104:2
            return __out.ToString();
        }

        public string GenerateEnumLiteral(Namespace currentNs, EnumLiteral lit) //107:1
        {
            StringBuilder __out = new StringBuilder();
            StringBuilder __tmp2 = new StringBuilder();
            __tmp2.Append(GenerateAnnotations(lit, false));
            using(StreamReader __tmp2Reader = new StreamReader(this.__ToStream(__tmp2.ToString())))
            {
                bool __tmp2_first = true;
                bool __tmp2_last = __tmp2Reader.EndOfStream;
                while(__tmp2_first || !__tmp2_last)
                {
                    __tmp2_first = false;
                    string __tmp2Line = __tmp2Reader.ReadLine();
                    __tmp2_last = __tmp2Reader.EndOfStream;
                    if (__tmp2Line != null) __out.Append(__tmp2Line);
                    if (!__tmp2_last) __out.AppendLine(true);
                    __out.AppendLine(false); //108:34
                }
            }
            StringBuilder __tmp4 = new StringBuilder();
            __tmp4.Append(lit.Name);
            using(StreamReader __tmp4Reader = new StreamReader(this.__ToStream(__tmp4.ToString())))
            {
                bool __tmp4_first = true;
                bool __tmp4_last = __tmp4Reader.EndOfStream;
                while(__tmp4_first || !__tmp4_last)
                {
                    __tmp4_first = false;
                    string __tmp4Line = __tmp4Reader.ReadLine();
                    __tmp4_last = __tmp4Reader.EndOfStream;
                    if (__tmp4Line != null) __out.Append(__tmp4Line);
                    if (!__tmp4_last) __out.AppendLine(true);
                    __out.AppendLine(false); //109:11
                }
            }
            return __out.ToString();
        }

        public string GenerateStruct(Namespace currentNs, Struct st) //112:1
        {
            StringBuilder __out = new StringBuilder();
            StringBuilder __tmp2 = new StringBuilder();
            __tmp2.Append(GenerateAnnotations(st, false));
            using(StreamReader __tmp2Reader = new StreamReader(this.__ToStream(__tmp2.ToString())))
            {
                bool __tmp2_first = true;
                bool __tmp2_last = __tmp2Reader.EndOfStream;
                while(__tmp2_first || !__tmp2_last)
                {
                    __tmp2_first = false;
                    string __tmp2Line = __tmp2Reader.ReadLine();
                    __tmp2_last = __tmp2Reader.EndOfStream;
                    if (__tmp2Line != null) __out.Append(__tmp2Line);
                    if (!__tmp2_last) __out.AppendLine(true);
                    __out.AppendLine(false); //113:33
                }
            }
            string __tmp4Line = "struct "; //114:1
            if (__tmp4Line != null) __out.Append(__tmp4Line);
            StringBuilder __tmp5 = new StringBuilder();
            __tmp5.Append(st.Name);
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
            StringBuilder __tmp6 = new StringBuilder();
            __tmp6.Append(GetAncestor(currentNs, st));
            using(StreamReader __tmp6Reader = new StreamReader(this.__ToStream(__tmp6.ToString())))
            {
                bool __tmp6_first = true;
                bool __tmp6_last = __tmp6Reader.EndOfStream;
                while(__tmp6_first || !__tmp6_last)
                {
                    __tmp6_first = false;
                    string __tmp6Line = __tmp6Reader.ReadLine();
                    __tmp6_last = __tmp6Reader.EndOfStream;
                    if (__tmp6Line != null) __out.Append(__tmp6Line);
                    if (!__tmp6_last) __out.AppendLine(true);
                    __out.AppendLine(false); //114:45
                }
            }
            __out.Append("{"); //115:1
            __out.AppendLine(false); //115:2
            var __loop11_results = 
                (from __loop11_var1 in __Enumerate((st).GetEnumerator()) //116:8
                from prop in __Enumerate((__loop11_var1.Properties).GetEnumerator()) //116:12
                select new { __loop11_var1 = __loop11_var1, prop = prop}
                ).ToList(); //116:3
            int __loop11_iteration = 0;
            foreach (var __tmp7 in __loop11_results)
            {
                ++__loop11_iteration;
                var __loop11_var1 = __tmp7.__loop11_var1;
                var prop = __tmp7.prop;
                string __tmp8Prefix = "	"; //117:1
                StringBuilder __tmp9 = new StringBuilder();
                __tmp9.Append(GenerateProperty(currentNs, prop));
                using(StreamReader __tmp9Reader = new StreamReader(this.__ToStream(__tmp9.ToString())))
                {
                    bool __tmp9_first = true;
                    bool __tmp9_last = __tmp9Reader.EndOfStream;
                    while(__tmp9_first || !__tmp9_last)
                    {
                        __tmp9_first = false;
                        string __tmp9Line = __tmp9Reader.ReadLine();
                        __tmp9_last = __tmp9Reader.EndOfStream;
                        __out.Append(__tmp8Prefix);
                        if (__tmp9Line != null) __out.Append(__tmp9Line);
                        if (!__tmp9_last) __out.AppendLine(true);
                        __out.AppendLine(false); //117:37
                    }
                }
            }
            __out.Append("}"); //119:1
            __out.AppendLine(false); //119:2
            return __out.ToString();
        }

        public string GenerateProperty(Namespace currentNs, Property prop) //122:1
        {
            StringBuilder __out = new StringBuilder();
            StringBuilder __tmp2 = new StringBuilder();
            __tmp2.Append(GenerateAnnotations(prop, false));
            using(StreamReader __tmp2Reader = new StreamReader(this.__ToStream(__tmp2.ToString())))
            {
                bool __tmp2_first = true;
                bool __tmp2_last = __tmp2Reader.EndOfStream;
                while(__tmp2_first || !__tmp2_last)
                {
                    __tmp2_first = false;
                    string __tmp2Line = __tmp2Reader.ReadLine();
                    __tmp2_last = __tmp2Reader.EndOfStream;
                    if (__tmp2Line != null) __out.Append(__tmp2Line);
                    if (!__tmp2_last) __out.AppendLine(true);
                    __out.AppendLine(false); //123:35
                }
            }
            StringBuilder __tmp4 = new StringBuilder();
            __tmp4.Append(GenerateType(currentNs, prop.Type));
            using(StreamReader __tmp4Reader = new StreamReader(this.__ToStream(__tmp4.ToString())))
            {
                bool __tmp4_first = true;
                bool __tmp4_last = __tmp4Reader.EndOfStream;
                while(__tmp4_first || !__tmp4_last)
                {
                    __tmp4_first = false;
                    string __tmp4Line = __tmp4Reader.ReadLine();
                    __tmp4_last = __tmp4Reader.EndOfStream;
                    if (__tmp4Line != null) __out.Append(__tmp4Line);
                    if (!__tmp4_last) __out.AppendLine(true);
                }
            }
            string __tmp5Line = " "; //124:37
            if (__tmp5Line != null) __out.Append(__tmp5Line);
            StringBuilder __tmp6 = new StringBuilder();
            __tmp6.Append(prop.Name);
            using(StreamReader __tmp6Reader = new StreamReader(this.__ToStream(__tmp6.ToString())))
            {
                bool __tmp6_first = true;
                bool __tmp6_last = __tmp6Reader.EndOfStream;
                while(__tmp6_first || !__tmp6_last)
                {
                    __tmp6_first = false;
                    string __tmp6Line = __tmp6Reader.ReadLine();
                    __tmp6_last = __tmp6Reader.EndOfStream;
                    if (__tmp6Line != null) __out.Append(__tmp6Line);
                    if (!__tmp6_last) __out.AppendLine(true);
                }
            }
            string __tmp7Line = ";"; //124:49
            if (__tmp7Line != null) __out.Append(__tmp7Line);
            __out.AppendLine(false); //124:50
            return __out.ToString();
        }

        public string GenerateRef(Namespace currentNs, Declaration decl) //127:1
        {
            StringBuilder __out = new StringBuilder();
            if (decl != null) //128:2
            {
                if (decl.Namespace != currentNs) //129:2
                {
                    StringBuilder __tmp2 = new StringBuilder();
                    __tmp2.Append(decl.FullName());
                    using(StreamReader __tmp2Reader = new StreamReader(this.__ToStream(__tmp2.ToString())))
                    {
                        bool __tmp2_first = true;
                        bool __tmp2_last = __tmp2Reader.EndOfStream;
                        while(__tmp2_first || !__tmp2_last)
                        {
                            __tmp2_first = false;
                            string __tmp2Line = __tmp2Reader.ReadLine();
                            __tmp2_last = __tmp2Reader.EndOfStream;
                            if (__tmp2Line != null) __out.Append(__tmp2Line);
                            if (!__tmp2_last) __out.AppendLine(true);
                        }
                    }
                }
                else //131:2
                {
                    StringBuilder __tmp4 = new StringBuilder();
                    __tmp4.Append(decl.Name);
                    using(StreamReader __tmp4Reader = new StreamReader(this.__ToStream(__tmp4.ToString())))
                    {
                        bool __tmp4_first = true;
                        bool __tmp4_last = __tmp4Reader.EndOfStream;
                        while(__tmp4_first || !__tmp4_last)
                        {
                            __tmp4_first = false;
                            string __tmp4Line = __tmp4Reader.ReadLine();
                            __tmp4_last = __tmp4Reader.EndOfStream;
                            if (__tmp4Line != null) __out.Append(__tmp4Line);
                            if (!__tmp4_last) __out.AppendLine(true);
                        }
                    }
                }
            }
            return __out.ToString();
        }

        public string GenerateType(Namespace currentNs, SoalType t) //137:1
        {
            StringBuilder __out = new StringBuilder();
            if (t is PrimitiveType) //138:2
            {
                StringBuilder __tmp2 = new StringBuilder();
                __tmp2.Append(((PrimitiveType)t).Name);
                using(StreamReader __tmp2Reader = new StreamReader(this.__ToStream(__tmp2.ToString())))
                {
                    bool __tmp2_first = true;
                    bool __tmp2_last = __tmp2Reader.EndOfStream;
                    while(__tmp2_first || !__tmp2_last)
                    {
                        __tmp2_first = false;
                        string __tmp2Line = __tmp2Reader.ReadLine();
                        __tmp2_last = __tmp2Reader.EndOfStream;
                        if (__tmp2Line != null) __out.Append(__tmp2Line);
                        if (!__tmp2_last) __out.AppendLine(true);
                    }
                }
            }
            else if (t is NullableType) //140:2
            {
                StringBuilder __tmp4 = new StringBuilder();
                __tmp4.Append(GenerateType(currentNs, ((NullableType)t).InnerType));
                using(StreamReader __tmp4Reader = new StreamReader(this.__ToStream(__tmp4.ToString())))
                {
                    bool __tmp4_first = true;
                    bool __tmp4_last = __tmp4Reader.EndOfStream;
                    while(__tmp4_first || !__tmp4_last)
                    {
                        __tmp4_first = false;
                        string __tmp4Line = __tmp4Reader.ReadLine();
                        __tmp4_last = __tmp4Reader.EndOfStream;
                        if (__tmp4Line != null) __out.Append(__tmp4Line);
                        if (!__tmp4_last) __out.AppendLine(true);
                    }
                }
                string __tmp5Line = "?"; //141:55
                if (__tmp5Line != null) __out.Append(__tmp5Line);
            }
            else if (t is NonNullableType) //142:2
            {
                StringBuilder __tmp7 = new StringBuilder();
                __tmp7.Append(GenerateType(currentNs, ((NonNullableType)t).InnerType));
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
                string __tmp8Line = "!"; //143:58
                if (__tmp8Line != null) __out.Append(__tmp8Line);
            }
            else if (t is ArrayType) //144:2
            {
                StringBuilder __tmp10 = new StringBuilder();
                __tmp10.Append(GenerateType(currentNs, ((ArrayType)t).InnerType));
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
                StringBuilder __tmp11 = new StringBuilder();
                __tmp11.Append("[]");
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
            }
            else if (t is Declaration) //146:2
            {
                StringBuilder __tmp13 = new StringBuilder();
                __tmp13.Append(GenerateRef(currentNs, (Declaration)t));
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
                        __out.AppendLine(false); //147:41
                    }
                }
            }
            else //148:2
            {
                StringBuilder __tmp15 = new StringBuilder();
                __tmp15.Append(t);
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
            }
            return __out.ToString();
        }

        public string GenerateReturnType(Namespace currentNs, Operation op) //153:1
        {
            StringBuilder __out = new StringBuilder();
            if (op.Result.IsOneway) //154:2
            {
                __out.Append("oneway"); //155:1
            }
            else //156:2
            {
                StringBuilder __tmp2 = new StringBuilder();
                __tmp2.Append(GenerateType(currentNs, op.Result.Type));
                using(StreamReader __tmp2Reader = new StreamReader(this.__ToStream(__tmp2.ToString())))
                {
                    bool __tmp2_first = true;
                    bool __tmp2_last = __tmp2Reader.EndOfStream;
                    while(__tmp2_first || !__tmp2_last)
                    {
                        __tmp2_first = false;
                        string __tmp2Line = __tmp2Reader.ReadLine();
                        __tmp2_last = __tmp2Reader.EndOfStream;
                        if (__tmp2Line != null) __out.Append(__tmp2Line);
                        if (!__tmp2_last) __out.AppendLine(true);
                    }
                }
            }
            return __out.ToString();
        }

        public string GenerateThrows(Namespace currentNs, Operation op) //161:1
        {
            StringBuilder __out = new StringBuilder();
            var __loop12_results = 
                (from __loop12_var1 in __Enumerate((op).GetEnumerator()) //162:7
                from ex in __Enumerate((__loop12_var1.Exceptions).GetEnumerator()) //162:11
                select new { __loop12_var1 = __loop12_var1, ex = ex}
                ).ToList(); //162:2
            int __loop12_iteration = 0;
            string delim = " throws "; //162:26
            foreach (var __tmp1 in __loop12_results)
            {
                ++__loop12_iteration;
                if (__loop12_iteration >= 2) //162:53
                {
                    delim = ", "; //162:53
                }
                var __loop12_var1 = __tmp1.__loop12_var1;
                var ex = __tmp1.ex;
                StringBuilder __tmp3 = new StringBuilder();
                __tmp3.Append(delim);
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
                StringBuilder __tmp4 = new StringBuilder();
                __tmp4.Append(GenerateType(currentNs, ex));
                using(StreamReader __tmp4Reader = new StreamReader(this.__ToStream(__tmp4.ToString())))
                {
                    bool __tmp4_first = true;
                    bool __tmp4_last = __tmp4Reader.EndOfStream;
                    while(__tmp4_first || !__tmp4_last)
                    {
                        __tmp4_first = false;
                        string __tmp4Line = __tmp4Reader.ReadLine();
                        __tmp4_last = __tmp4Reader.EndOfStream;
                        if (__tmp4Line != null) __out.Append(__tmp4Line);
                        if (!__tmp4_last) __out.AppendLine(true);
                        __out.AppendLine(false); //163:37
                    }
                }
            }
            return __out.ToString();
        }

        public string GenerateParameters(Namespace currentNs, Operation op) //167:1
        {
            StringBuilder __out = new StringBuilder();
            var __loop13_results = 
                (from __loop13_var1 in __Enumerate((op).GetEnumerator()) //168:7
                from p in __Enumerate((__loop13_var1.Parameters).GetEnumerator()) //168:11
                select new { __loop13_var1 = __loop13_var1, p = p}
                ).ToList(); //168:2
            int __loop13_iteration = 0;
            string delim = ""; //168:25
            foreach (var __tmp1 in __loop13_results)
            {
                ++__loop13_iteration;
                if (__loop13_iteration >= 2) //168:44
                {
                    delim = ", "; //168:44
                }
                var __loop13_var1 = __tmp1.__loop13_var1;
                var p = __tmp1.p;
                StringBuilder __tmp3 = new StringBuilder();
                __tmp3.Append(delim);
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
                StringBuilder __tmp4 = new StringBuilder();
                __tmp4.Append(GenerateAnnotationsSingleLine(p, false));
                using(StreamReader __tmp4Reader = new StreamReader(this.__ToStream(__tmp4.ToString())))
                {
                    bool __tmp4_first = true;
                    bool __tmp4_last = __tmp4Reader.EndOfStream;
                    while(__tmp4_first || !__tmp4_last)
                    {
                        __tmp4_first = false;
                        string __tmp4Line = __tmp4Reader.ReadLine();
                        __tmp4_last = __tmp4Reader.EndOfStream;
                        if (__tmp4Line != null) __out.Append(__tmp4Line);
                        if (!__tmp4_last) __out.AppendLine(true);
                    }
                }
                StringBuilder __tmp5 = new StringBuilder();
                __tmp5.Append(GenerateType(currentNs, p.Type));
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
                string __tmp6Line = " "; //169:82
                if (__tmp6Line != null) __out.Append(__tmp6Line);
                StringBuilder __tmp7 = new StringBuilder();
                __tmp7.Append(p.Name);
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
            }
            return __out.ToString();
        }

        public string GenerateOperation(Namespace currentNs, Operation op) //173:1
        {
            StringBuilder __out = new StringBuilder();
            StringBuilder __tmp2 = new StringBuilder();
            __tmp2.Append(GenerateAnnotations(op, false));
            using(StreamReader __tmp2Reader = new StreamReader(this.__ToStream(__tmp2.ToString())))
            {
                bool __tmp2_first = true;
                bool __tmp2_last = __tmp2Reader.EndOfStream;
                while(__tmp2_first || !__tmp2_last)
                {
                    __tmp2_first = false;
                    string __tmp2Line = __tmp2Reader.ReadLine();
                    __tmp2_last = __tmp2Reader.EndOfStream;
                    if (__tmp2Line != null) __out.Append(__tmp2Line);
                    if (!__tmp2_last) __out.AppendLine(true);
                    __out.AppendLine(false); //174:33
                }
            }
            StringBuilder __tmp4 = new StringBuilder();
            __tmp4.Append(GenerateAnnotations(op.Result, true));
            using(StreamReader __tmp4Reader = new StreamReader(this.__ToStream(__tmp4.ToString())))
            {
                bool __tmp4_first = true;
                bool __tmp4_last = __tmp4Reader.EndOfStream;
                while(__tmp4_first || !__tmp4_last)
                {
                    __tmp4_first = false;
                    string __tmp4Line = __tmp4Reader.ReadLine();
                    __tmp4_last = __tmp4Reader.EndOfStream;
                    if (__tmp4Line != null) __out.Append(__tmp4Line);
                    if (!__tmp4_last) __out.AppendLine(true);
                    __out.AppendLine(false); //175:39
                }
            }
            StringBuilder __tmp6 = new StringBuilder();
            __tmp6.Append(GenerateReturnType(currentNs, op));
            using(StreamReader __tmp6Reader = new StreamReader(this.__ToStream(__tmp6.ToString())))
            {
                bool __tmp6_first = true;
                bool __tmp6_last = __tmp6Reader.EndOfStream;
                while(__tmp6_first || !__tmp6_last)
                {
                    __tmp6_first = false;
                    string __tmp6Line = __tmp6Reader.ReadLine();
                    __tmp6_last = __tmp6Reader.EndOfStream;
                    if (__tmp6Line != null) __out.Append(__tmp6Line);
                    if (!__tmp6_last) __out.AppendLine(true);
                }
            }
            string __tmp7Line = " "; //176:36
            if (__tmp7Line != null) __out.Append(__tmp7Line);
            StringBuilder __tmp8 = new StringBuilder();
            __tmp8.Append(op.Name);
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
            string __tmp9Line = "("; //176:46
            if (__tmp9Line != null) __out.Append(__tmp9Line);
            StringBuilder __tmp10 = new StringBuilder();
            __tmp10.Append(GenerateParameters(currentNs, op));
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
            string __tmp11Line = ")"; //176:82
            if (__tmp11Line != null) __out.Append(__tmp11Line);
            StringBuilder __tmp12 = new StringBuilder();
            __tmp12.Append(GenerateThrows(currentNs, op));
            using(StreamReader __tmp12Reader = new StreamReader(this.__ToStream(__tmp12.ToString())))
            {
                bool __tmp12_first = true;
                bool __tmp12_last = __tmp12Reader.EndOfStream;
                while(__tmp12_first || !__tmp12_last)
                {
                    __tmp12_first = false;
                    string __tmp12Line = __tmp12Reader.ReadLine();
                    __tmp12_last = __tmp12Reader.EndOfStream;
                    if (__tmp12Line != null) __out.Append(__tmp12Line);
                    if (!__tmp12_last) __out.AppendLine(true);
                }
            }
            string __tmp13Line = ";"; //176:114
            if (__tmp13Line != null) __out.Append(__tmp13Line);
            __out.AppendLine(false); //176:115
            return __out.ToString();
        }

        public string GenerateInterface(Namespace currentNs, Interface intf) //179:1
        {
            StringBuilder __out = new StringBuilder();
            StringBuilder __tmp2 = new StringBuilder();
            __tmp2.Append(GenerateAnnotations(intf, false));
            using(StreamReader __tmp2Reader = new StreamReader(this.__ToStream(__tmp2.ToString())))
            {
                bool __tmp2_first = true;
                bool __tmp2_last = __tmp2Reader.EndOfStream;
                while(__tmp2_first || !__tmp2_last)
                {
                    __tmp2_first = false;
                    string __tmp2Line = __tmp2Reader.ReadLine();
                    __tmp2_last = __tmp2Reader.EndOfStream;
                    if (__tmp2Line != null) __out.Append(__tmp2Line);
                    if (!__tmp2_last) __out.AppendLine(true);
                    __out.AppendLine(false); //180:35
                }
            }
            string __tmp4Line = "interface "; //181:1
            if (__tmp4Line != null) __out.Append(__tmp4Line);
            StringBuilder __tmp5 = new StringBuilder();
            __tmp5.Append(intf.Name);
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
                    __out.AppendLine(false); //181:22
                }
            }
            __out.Append("{"); //182:1
            __out.AppendLine(false); //182:2
            var __loop14_results = 
                (from __loop14_var1 in __Enumerate((intf).GetEnumerator()) //183:8
                from op in __Enumerate((__loop14_var1.Operations).GetEnumerator()) //183:14
                select new { __loop14_var1 = __loop14_var1, op = op}
                ).ToList(); //183:3
            int __loop14_iteration = 0;
            foreach (var __tmp6 in __loop14_results)
            {
                ++__loop14_iteration;
                var __loop14_var1 = __tmp6.__loop14_var1;
                var op = __tmp6.op;
                string __tmp7Prefix = "	"; //184:1
                StringBuilder __tmp8 = new StringBuilder();
                __tmp8.Append(GenerateOperation(currentNs, op));
                using(StreamReader __tmp8Reader = new StreamReader(this.__ToStream(__tmp8.ToString())))
                {
                    bool __tmp8_first = true;
                    bool __tmp8_last = __tmp8Reader.EndOfStream;
                    while(__tmp8_first || !__tmp8_last)
                    {
                        __tmp8_first = false;
                        string __tmp8Line = __tmp8Reader.ReadLine();
                        __tmp8_last = __tmp8Reader.EndOfStream;
                        __out.Append(__tmp7Prefix);
                        if (__tmp8Line != null) __out.Append(__tmp8Line);
                        if (!__tmp8_last) __out.AppendLine(true);
                        __out.AppendLine(false); //184:36
                    }
                }
            }
            __out.Append("}"); //186:1
            __out.AppendLine(false); //186:2
            return __out.ToString();
        }

        public string GenerateTransportBinding(Namespace currentNs, TransportBindingElement bnd) //189:1
        {
            StringBuilder __out = new StringBuilder();
            var __tmp1 = bnd; //190:10
            if (bnd is HttpTransportBindingElement) //191:2
            {
                if (((HttpTransportBindingElement)bnd).Ssl) //192:3
                {
                    __out.Append("transport HTTP"); //193:1
                    __out.AppendLine(false); //193:15
                    __out.Append("{"); //194:1
                    __out.AppendLine(false); //194:2
                    __out.Append("	Ssl = true;"); //195:1
                    __out.AppendLine(false); //195:13
                    string __tmp3Line = "	ClientAuthentication = "; //196:1
                    if (__tmp3Line != null) __out.Append(__tmp3Line);
                    StringBuilder __tmp4 = new StringBuilder();
                    __tmp4.Append(((HttpTransportBindingElement)bnd).ClientAuthentication.ToString().ToLower());
                    using(StreamReader __tmp4Reader = new StreamReader(this.__ToStream(__tmp4.ToString())))
                    {
                        bool __tmp4_first = true;
                        bool __tmp4_last = __tmp4Reader.EndOfStream;
                        while(__tmp4_first || !__tmp4_last)
                        {
                            __tmp4_first = false;
                            string __tmp4Line = __tmp4Reader.ReadLine();
                            __tmp4_last = __tmp4Reader.EndOfStream;
                            if (__tmp4Line != null) __out.Append(__tmp4Line);
                            if (!__tmp4_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp5Line = ";"; //196:72
                    if (__tmp5Line != null) __out.Append(__tmp5Line);
                    __out.AppendLine(false); //196:73
                    __out.Append("}"); //197:1
                    __out.AppendLine(false); //197:2
                }
                else //198:3
                {
                    __out.Append("transport HTTP;"); //199:1
                    __out.AppendLine(false); //199:16
                }
            }
            else if (bnd is RestTransportBindingElement) //201:2
            {
                __out.Append("transport REST;"); //201:39
                __out.AppendLine(false); //201:54
            }
            else if (bnd is WebSocketTransportBindingElement) //202:2
            {
                __out.Append("transport WebSocket;"); //202:44
                __out.AppendLine(false); //202:64
            }//203:2
            return __out.ToString();
        }

        public string GenerateEncodingBinding(Namespace currentNs, EncodingBindingElement bnd) //206:1
        {
            StringBuilder __out = new StringBuilder();
            var __tmp1 = bnd; //207:10
            if (bnd is SoapEncodingBindingElement) //208:2
            {
                if (((SoapEncodingBindingElement)bnd).Style != SoapEncodingStyle.DocumentWrapped || ((SoapEncodingBindingElement)bnd).Version != SoapVersion.Soap11 || ((SoapEncodingBindingElement)bnd).Mtom) //209:2
                {
                    __out.Append("encoding SOAP"); //210:1
                    __out.AppendLine(false); //210:14
                    __out.Append("{"); //211:1
                    __out.AppendLine(false); //211:2
                    if (((SoapEncodingBindingElement)bnd).Style != SoapEncodingStyle.DocumentWrapped) //212:3
                    {
                        string __tmp3Line = "	Style = "; //213:1
                        if (__tmp3Line != null) __out.Append(__tmp3Line);
                        StringBuilder __tmp4 = new StringBuilder();
                        __tmp4.Append(((SoapEncodingBindingElement)bnd).Style);
                        using(StreamReader __tmp4Reader = new StreamReader(this.__ToStream(__tmp4.ToString())))
                        {
                            bool __tmp4_first = true;
                            bool __tmp4_last = __tmp4Reader.EndOfStream;
                            while(__tmp4_first || !__tmp4_last)
                            {
                                __tmp4_first = false;
                                string __tmp4Line = __tmp4Reader.ReadLine();
                                __tmp4_last = __tmp4Reader.EndOfStream;
                                if (__tmp4Line != null) __out.Append(__tmp4Line);
                                if (!__tmp4_last) __out.AppendLine(true);
                            }
                        }
                        string __tmp5Line = ";"; //213:21
                        if (__tmp5Line != null) __out.Append(__tmp5Line);
                        __out.AppendLine(false); //213:22
                    }
                    if (((SoapEncodingBindingElement)bnd).Version != SoapVersion.Soap11) //215:3
                    {
                        string __tmp7Line = "	Version = "; //216:1
                        if (__tmp7Line != null) __out.Append(__tmp7Line);
                        StringBuilder __tmp8 = new StringBuilder();
                        __tmp8.Append(((SoapEncodingBindingElement)bnd).Version);
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
                        string __tmp9Line = ";"; //216:25
                        if (__tmp9Line != null) __out.Append(__tmp9Line);
                        __out.AppendLine(false); //216:26
                    }
                    if (((SoapEncodingBindingElement)bnd).Mtom) //218:3
                    {
                        __out.Append("	Mtom = true;"); //219:1
                        __out.AppendLine(false); //219:14
                    }
                    __out.Append("}"); //221:1
                    __out.AppendLine(false); //221:2
                }
                else //222:2
                {
                    __out.Append("encoding SOAP;"); //223:1
                    __out.AppendLine(false); //223:15
                }
            }
            else if (bnd is XmlEncodingBindingElement) //225:2
            {
                __out.Append("encoding XML;"); //225:37
                __out.AppendLine(false); //225:50
            }
            else if (bnd is JsonEncodingBindingElement) //226:2
            {
                __out.Append("encoding JSON;"); //226:38
                __out.AppendLine(false); //226:52
            }//227:2
            return __out.ToString();
        }

        public string GenerateProtocolBinding(Namespace currentNs, ProtocolBindingElement bnd) //230:1
        {
            StringBuilder __out = new StringBuilder();
            var __tmp1 = bnd; //231:10
            if (bnd is WsAddressingBindingElement) //232:2
            {
                __out.Append("protocol WsAddressing;"); //232:38
                __out.AppendLine(false); //232:60
            }//233:2
            return __out.ToString();
        }

        public string GenerateBinding(Namespace currentNs, Binding bnd) //236:1
        {
            StringBuilder __out = new StringBuilder();
            string __tmp2Line = "binding "; //237:1
            if (__tmp2Line != null) __out.Append(__tmp2Line);
            StringBuilder __tmp3 = new StringBuilder();
            __tmp3.Append(bnd.Name);
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
                    __out.AppendLine(false); //237:19
                }
            }
            __out.Append("{"); //238:1
            __out.AppendLine(false); //238:2
            string __tmp4Prefix = "	"; //239:1
            StringBuilder __tmp5 = new StringBuilder();
            __tmp5.Append(GenerateTransportBinding(currentNs, bnd.Transport));
            using(StreamReader __tmp5Reader = new StreamReader(this.__ToStream(__tmp5.ToString())))
            {
                bool __tmp5_first = true;
                bool __tmp5_last = __tmp5Reader.EndOfStream;
                while(__tmp5_first || !__tmp5_last)
                {
                    __tmp5_first = false;
                    string __tmp5Line = __tmp5Reader.ReadLine();
                    __tmp5_last = __tmp5Reader.EndOfStream;
                    __out.Append(__tmp4Prefix);
                    if (__tmp5Line != null) __out.Append(__tmp5Line);
                    if (!__tmp5_last) __out.AppendLine(true);
                    __out.AppendLine(false); //239:54
                }
            }
            var __loop15_results = 
                (from __loop15_var1 in __Enumerate((bnd).GetEnumerator()) //240:8
                from enc in __Enumerate((__loop15_var1.Encodings).GetEnumerator()) //240:13
                select new { __loop15_var1 = __loop15_var1, enc = enc}
                ).ToList(); //240:3
            int __loop15_iteration = 0;
            foreach (var __tmp6 in __loop15_results)
            {
                ++__loop15_iteration;
                var __loop15_var1 = __tmp6.__loop15_var1;
                var enc = __tmp6.enc;
                string __tmp7Prefix = "	"; //241:1
                StringBuilder __tmp8 = new StringBuilder();
                __tmp8.Append(GenerateEncodingBinding(currentNs, enc));
                using(StreamReader __tmp8Reader = new StreamReader(this.__ToStream(__tmp8.ToString())))
                {
                    bool __tmp8_first = true;
                    bool __tmp8_last = __tmp8Reader.EndOfStream;
                    while(__tmp8_first || !__tmp8_last)
                    {
                        __tmp8_first = false;
                        string __tmp8Line = __tmp8Reader.ReadLine();
                        __tmp8_last = __tmp8Reader.EndOfStream;
                        __out.Append(__tmp7Prefix);
                        if (__tmp8Line != null) __out.Append(__tmp8Line);
                        if (!__tmp8_last) __out.AppendLine(true);
                        __out.AppendLine(false); //241:43
                    }
                }
            }
            var __loop16_results = 
                (from __loop16_var1 in __Enumerate((bnd).GetEnumerator()) //243:8
                from prot in __Enumerate((__loop16_var1.Protocols).GetEnumerator()) //243:13
                select new { __loop16_var1 = __loop16_var1, prot = prot}
                ).ToList(); //243:3
            int __loop16_iteration = 0;
            foreach (var __tmp9 in __loop16_results)
            {
                ++__loop16_iteration;
                var __loop16_var1 = __tmp9.__loop16_var1;
                var prot = __tmp9.prot;
                string __tmp10Prefix = "	"; //244:1
                StringBuilder __tmp11 = new StringBuilder();
                __tmp11.Append(GenerateProtocolBinding(currentNs, prot));
                using(StreamReader __tmp11Reader = new StreamReader(this.__ToStream(__tmp11.ToString())))
                {
                    bool __tmp11_first = true;
                    bool __tmp11_last = __tmp11Reader.EndOfStream;
                    while(__tmp11_first || !__tmp11_last)
                    {
                        __tmp11_first = false;
                        string __tmp11Line = __tmp11Reader.ReadLine();
                        __tmp11_last = __tmp11Reader.EndOfStream;
                        __out.Append(__tmp10Prefix);
                        if (__tmp11Line != null) __out.Append(__tmp11Line);
                        if (!__tmp11_last) __out.AppendLine(true);
                        __out.AppendLine(false); //244:44
                    }
                }
            }
            __out.Append("}"); //246:1
            __out.AppendLine(false); //246:2
            return __out.ToString();
        }

        public string GenerateEndpoint(Namespace currentNs, Endpoint endp) //249:1
        {
            StringBuilder __out = new StringBuilder();
            string __tmp2Line = "endpoint "; //250:1
            if (__tmp2Line != null) __out.Append(__tmp2Line);
            StringBuilder __tmp3 = new StringBuilder();
            __tmp3.Append(endp.Name);
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
            string __tmp4Line = " : "; //250:21
            if (__tmp4Line != null) __out.Append(__tmp4Line);
            StringBuilder __tmp5 = new StringBuilder();
            __tmp5.Append(GenerateRef(currentNs, endp.Interface));
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
                    __out.AppendLine(false); //250:64
                }
            }
            __out.Append("{"); //251:1
            __out.AppendLine(false); //251:2
            string __tmp7Line = "	binding "; //252:1
            if (__tmp7Line != null) __out.Append(__tmp7Line);
            StringBuilder __tmp8 = new StringBuilder();
            __tmp8.Append(GenerateRef(currentNs, endp.Binding));
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
            string __tmp9Line = ";"; //252:48
            if (__tmp9Line != null) __out.Append(__tmp9Line);
            __out.AppendLine(false); //252:49
            string __tmp11Line = "	address \""; //253:1
            if (__tmp11Line != null) __out.Append(__tmp11Line);
            StringBuilder __tmp12 = new StringBuilder();
            __tmp12.Append(endp.Address);
            using(StreamReader __tmp12Reader = new StreamReader(this.__ToStream(__tmp12.ToString())))
            {
                bool __tmp12_first = true;
                bool __tmp12_last = __tmp12Reader.EndOfStream;
                while(__tmp12_first || !__tmp12_last)
                {
                    __tmp12_first = false;
                    string __tmp12Line = __tmp12Reader.ReadLine();
                    __tmp12_last = __tmp12Reader.EndOfStream;
                    if (__tmp12Line != null) __out.Append(__tmp12Line);
                    if (!__tmp12_last) __out.AppendLine(true);
                }
            }
            string __tmp13Line = "\";"; //253:25
            if (__tmp13Line != null) __out.Append(__tmp13Line);
            __out.AppendLine(false); //253:27
            __out.Append("}"); //254:1
            __out.AppendLine(false); //254:2
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
