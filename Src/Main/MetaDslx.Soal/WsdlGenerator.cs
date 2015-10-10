using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Soal //1:1
{
    using __Hidden_WsdlGenerator_108169900;
    namespace __Hidden_WsdlGenerator_108169900
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

    public class WsdlGenerator //2:1
    {
        private object Instances; //2:1

        public WsdlGenerator() //2:1
        {
            this.Properties = new __Properties();
        }

        public WsdlGenerator(object instances) : this() //2:1
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

        private XsdGenerator XsdGenerator = new XsdGenerator(); //4:1

        public __Properties Properties { get; private set; } //6:1

        public class __Properties //6:1
        {
            internal __Properties()
            {
                this.SingleFileWsdl = false; //7:24
                this.SeparateXsdWsdl = false; //8:25
            }
            public bool SingleFileWsdl { get; set; } //7:2
            public bool SeparateXsdWsdl { get; set; } //8:2
        }

        public string Generate(Namespace ns) //11:1
        {
            StringBuilder __out = new StringBuilder();
            __out.Append("<?xml version=\"1.0\" encoding=\"utf-8\"?>"); //12:1
            __out.AppendLine(); //12:39
            string __tmp1Prefix = "<wsdl:definitions targetNamespace=\""; //13:1
            string __tmp2Suffix = "\"  "; //13:44
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
                    __out.AppendLine(); //13:47
                }
            }
            string __tmp4Prefix = "	xmlns:"; //14:1
            string __tmp5Suffix = "\""; //14:29
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
            string __tmp7Line = "=\""; //14:19
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
                    __out.AppendLine(); //14:30
                }
            }
            var __loop1_results = 
                (from ins in __Enumerate((ns.GetImportedNamespaces()).GetEnumerator()) //15:8
                select new { ins = ins}
                ).ToList(); //15:3
            int __loop1_iteration = 0;
            foreach (var __tmp9 in __loop1_results)
            {
                ++__loop1_iteration;
                var ins = __tmp9.ins;
                string __tmp10Prefix = "	xmlns:"; //16:1
                string __tmp11Suffix = "\""; //16:31
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
                string __tmp13Line = "=\""; //16:20
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
                        __out.AppendLine(); //16:32
                    }
                }
            }
            __out.Append("	xmlns:xs=\"http://www.w3.org/2001/XMLSchema\" "); //18:1
            __out.AppendLine(); //18:46
            __out.Append("	xmlns:wsdl=\"http://schemas.xmlsoap.org/wsdl/\""); //19:1
            __out.AppendLine(); //19:47
            __out.Append("	xmlns:soap=\"http://schemas.xmlsoap.org/wsdl/soap/\""); //20:1
            __out.AppendLine(); //20:52
            __out.Append("	xmlns:soap12=\"http://schemas.xmlsoap.org/wsdl/soap12/\""); //21:1
            __out.AppendLine(); //21:56
            __out.Append("	xmlns:wsaw=\"http://www.w3.org/2006/05/addressing/wsdl\""); //22:1
            __out.AppendLine(); //22:56
            __out.Append(">"); //23:1
            __out.AppendLine(); //23:2
            string __tmp15Prefix = "	"; //24:1
            string __tmp16Suffix = string.Empty; 
            StringBuilder __tmp17 = new StringBuilder();
            __tmp17.Append(GenerateWsdlTypesPart(ns));
            using(StreamReader __tmp17Reader = new StreamReader(this.__ToStream(__tmp17.ToString())))
            {
                bool __tmp17_first = true;
                while(__tmp17_first || !__tmp17Reader.EndOfStream)
                {
                    __tmp17_first = false;
                    string __tmp17Line = __tmp17Reader.ReadLine();
                    if (__tmp17Line == null)
                    {
                        __tmp17Line = "";
                    }
                    __out.Append(__tmp15Prefix);
                    __out.Append(__tmp17Line);
                    __out.Append(__tmp16Suffix);
                    __out.AppendLine(); //24:29
                }
            }
            string __tmp18Prefix = "	"; //25:1
            string __tmp19Suffix = string.Empty; 
            StringBuilder __tmp20 = new StringBuilder();
            __tmp20.Append(GenerateWsdlAbstractPart(ns));
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
                    __out.Append(__tmp18Prefix);
                    __out.Append(__tmp20Line);
                    __out.Append(__tmp19Suffix);
                    __out.AppendLine(); //25:32
                }
            }
            string __tmp21Prefix = "	"; //26:1
            string __tmp22Suffix = string.Empty; 
            StringBuilder __tmp23 = new StringBuilder();
            __tmp23.Append(GenerateWsdlBindingPart(ns));
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
                    __out.Append(__tmp21Prefix);
                    __out.Append(__tmp23Line);
                    __out.Append(__tmp22Suffix);
                    __out.AppendLine(); //26:31
                }
            }
            string __tmp24Prefix = "	"; //27:1
            string __tmp25Suffix = string.Empty; 
            StringBuilder __tmp26 = new StringBuilder();
            __tmp26.Append(GenerateWsdlEndpointPart(ns));
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
                    __out.Append(__tmp24Prefix);
                    __out.Append(__tmp26Line);
                    __out.Append(__tmp25Suffix);
                    __out.AppendLine(); //27:32
                }
            }
            __out.Append("</wsdl:definitions>"); //28:1
            __out.AppendLine(); //28:20
            return __out.ToString();
        }

        public string GenerateWsdlTypesPart(Namespace ns) //31:1
        {
            StringBuilder __out = new StringBuilder();
            __out.Append("<wsdl:types>"); //32:1
            __out.AppendLine(); //32:13
            if (Properties.SingleFileWsdl) //33:2
            {
                string __tmp1Prefix = string.Empty;
                string __tmp2Suffix = string.Empty;
                StringBuilder __tmp3 = new StringBuilder();
                __tmp3.Append(XsdGenerator.Generate(ns));
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
                        __out.AppendLine(); //34:28
                    }
                }
            }
            else //35:2
            {
                __out.Append("	<xs:schema>"); //36:1
                __out.AppendLine(); //36:13
                if (Properties.SeparateXsdWsdl) //37:4
                {
                    string __tmp4Prefix = "		<xs:import namespace=\""; //38:1
                    string __tmp5Suffix = ".xsd\"/>"; //38:71
                    StringBuilder __tmp6 = new StringBuilder();
                    __tmp6.Append(ns.Uri);
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
                    string __tmp7Line = "\" schemaLocation=\"../xsd/"; //38:33
                    __out.Append(__tmp7Line);
                    StringBuilder __tmp8 = new StringBuilder();
                    __tmp8.Append(ns.FullName);
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
                            __out.AppendLine(); //38:78
                        }
                    }
                    var __loop2_results = 
                        (from ins in __Enumerate((ns.GetImportedNamespaces()).GetEnumerator()) //39:10
                        select new { ins = ins}
                        ).ToList(); //39:5
                    int __loop2_iteration = 0;
                    foreach (var __tmp9 in __loop2_results)
                    {
                        ++__loop2_iteration;
                        var ins = __tmp9.ins;
                        string __tmp10Prefix = "		<xs:import namespace=\""; //40:1
                        string __tmp11Suffix = ".xsd\"/>"; //40:73
                        StringBuilder __tmp12 = new StringBuilder();
                        __tmp12.Append(ins.Uri);
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
                        string __tmp13Line = "\" schemaLocation=\"../xsd/"; //40:34
                        __out.Append(__tmp13Line);
                        StringBuilder __tmp14 = new StringBuilder();
                        __tmp14.Append(ins.FullName);
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
                                __out.AppendLine(); //40:80
                            }
                        }
                    }
                }
                else //42:4
                {
                    string __tmp15Prefix = "		<xs:import namespace=\""; //43:1
                    string __tmp16Suffix = ".xsd\"/>"; //43:64
                    StringBuilder __tmp17 = new StringBuilder();
                    __tmp17.Append(ns.Uri);
                    using(StreamReader __tmp17Reader = new StreamReader(this.__ToStream(__tmp17.ToString())))
                    {
                        bool __tmp17_first = true;
                        while(__tmp17_first || !__tmp17Reader.EndOfStream)
                        {
                            __tmp17_first = false;
                            string __tmp17Line = __tmp17Reader.ReadLine();
                            if (__tmp17Line == null)
                            {
                                __tmp17Line = "";
                            }
                            __out.Append(__tmp15Prefix);
                            __out.Append(__tmp17Line);
                        }
                    }
                    string __tmp18Line = "\" schemaLocation=\""; //43:33
                    __out.Append(__tmp18Line);
                    StringBuilder __tmp19 = new StringBuilder();
                    __tmp19.Append(ns.FullName);
                    using(StreamReader __tmp19Reader = new StreamReader(this.__ToStream(__tmp19.ToString())))
                    {
                        bool __tmp19_first = true;
                        while(__tmp19_first || !__tmp19Reader.EndOfStream)
                        {
                            __tmp19_first = false;
                            string __tmp19Line = __tmp19Reader.ReadLine();
                            if (__tmp19Line == null)
                            {
                                __tmp19Line = "";
                            }
                            __out.Append(__tmp19Line);
                            __out.Append(__tmp16Suffix);
                            __out.AppendLine(); //43:71
                        }
                    }
                    var __loop3_results = 
                        (from ins in __Enumerate((ns.GetImportedNamespaces()).GetEnumerator()) //44:10
                        select new { ins = ins}
                        ).ToList(); //44:5
                    int __loop3_iteration = 0;
                    foreach (var __tmp20 in __loop3_results)
                    {
                        ++__loop3_iteration;
                        var ins = __tmp20.ins;
                        string __tmp21Prefix = "		<xs:import namespace=\""; //45:1
                        string __tmp22Suffix = ".xsd\"/>"; //45:66
                        StringBuilder __tmp23 = new StringBuilder();
                        __tmp23.Append(ins.Uri);
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
                                __out.Append(__tmp21Prefix);
                                __out.Append(__tmp23Line);
                            }
                        }
                        string __tmp24Line = "\" schemaLocation=\""; //45:34
                        __out.Append(__tmp24Line);
                        StringBuilder __tmp25 = new StringBuilder();
                        __tmp25.Append(ins.FullName);
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
                                __out.Append(__tmp22Suffix);
                                __out.AppendLine(); //45:73
                            }
                        }
                    }
                }
                __out.Append("	</xs:schema>"); //48:1
                __out.AppendLine(); //48:14
            }
            __out.Append("</wsdl:types>"); //50:1
            __out.AppendLine(); //50:14
            return __out.ToString();
        }

        public string GenerateWsdlAbstractPart(Namespace ns) //53:1
        {
            StringBuilder __out = new StringBuilder();
            var __loop4_results = 
                (from __loop4_var1 in __Enumerate((ns.Declarations).GetEnumerator()) //54:7
                from intf in __Enumerate((__loop4_var1).GetEnumerator()).OfType<Interface>() //54:24
                select new { __loop4_var1 = __loop4_var1, intf = intf}
                ).ToList(); //54:2
            int __loop4_iteration = 0;
            foreach (var __tmp1 in __loop4_results)
            {
                ++__loop4_iteration;
                var __loop4_var1 = __tmp1.__loop4_var1;
                var intf = __tmp1.intf;
                string __tmp2Prefix = string.Empty;
                string __tmp3Suffix = string.Empty;
                StringBuilder __tmp4 = new StringBuilder();
                __tmp4.Append(GenerateMessages(intf));
                using(StreamReader __tmp4Reader = new StreamReader(this.__ToStream(__tmp4.ToString())))
                {
                    bool __tmp4_first = true;
                    while(__tmp4_first || !__tmp4Reader.EndOfStream)
                    {
                        __tmp4_first = false;
                        string __tmp4Line = __tmp4Reader.ReadLine();
                        if (__tmp4Line == null)
                        {
                            __tmp4Line = "";
                        }
                        __out.Append(__tmp2Prefix);
                        __out.Append(__tmp4Line);
                        __out.Append(__tmp3Suffix);
                        __out.AppendLine(); //55:25
                    }
                }
            }
            string __tmp5Prefix = string.Empty;
            string __tmp6Suffix = string.Empty;
            StringBuilder __tmp7 = new StringBuilder();
            __tmp7.Append(GenerateFaultMessages(ns));
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
                    __out.AppendLine(); //57:28
                }
            }
            var __loop5_results = 
                (from __loop5_var1 in __Enumerate((ns.Declarations).GetEnumerator()) //58:7
                from intf in __Enumerate((__loop5_var1).GetEnumerator()).OfType<Interface>() //58:24
                select new { __loop5_var1 = __loop5_var1, intf = intf}
                ).ToList(); //58:2
            int __loop5_iteration = 0;
            foreach (var __tmp8 in __loop5_results)
            {
                ++__loop5_iteration;
                var __loop5_var1 = __tmp8.__loop5_var1;
                var intf = __tmp8.intf;
                string __tmp9Prefix = string.Empty;
                string __tmp10Suffix = string.Empty;
                StringBuilder __tmp11 = new StringBuilder();
                __tmp11.Append(GeneratePortType(intf));
                using(StreamReader __tmp11Reader = new StreamReader(this.__ToStream(__tmp11.ToString())))
                {
                    bool __tmp11_first = true;
                    while(__tmp11_first || !__tmp11Reader.EndOfStream)
                    {
                        __tmp11_first = false;
                        string __tmp11Line = __tmp11Reader.ReadLine();
                        if (__tmp11Line == null)
                        {
                            __tmp11Line = "";
                        }
                        __out.Append(__tmp9Prefix);
                        __out.Append(__tmp11Line);
                        __out.Append(__tmp10Suffix);
                        __out.AppendLine(); //59:25
                    }
                }
            }
            return __out.ToString();
        }

        public string GenerateWsdlAbstractPart(Interface intf) //63:1
        {
            StringBuilder __out = new StringBuilder();
            string __tmp1Prefix = string.Empty;
            string __tmp2Suffix = string.Empty;
            StringBuilder __tmp3 = new StringBuilder();
            __tmp3.Append(GenerateMessages(intf));
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
                    __out.AppendLine(); //64:25
                }
            }
            string __tmp4Prefix = string.Empty;
            string __tmp5Suffix = string.Empty;
            StringBuilder __tmp6 = new StringBuilder();
            __tmp6.Append(GenerateFaultMessages(intf));
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
                    __out.Append(__tmp5Suffix);
                    __out.AppendLine(); //65:30
                }
            }
            string __tmp7Prefix = string.Empty;
            string __tmp8Suffix = string.Empty;
            StringBuilder __tmp9 = new StringBuilder();
            __tmp9.Append(GeneratePortType(intf));
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
                    __out.Append(__tmp7Prefix);
                    __out.Append(__tmp9Line);
                    __out.Append(__tmp8Suffix);
                    __out.AppendLine(); //66:25
                }
            }
            return __out.ToString();
        }

        public string GenerateMessages(Interface intf) //69:1
        {
            StringBuilder __out = new StringBuilder();
            var __loop6_results = 
                (from __loop6_var1 in __Enumerate((intf.Operations).GetEnumerator()) //70:7
                from op in __Enumerate((__loop6_var1).GetEnumerator()).OfType<Operation>() //70:24
                select new { __loop6_var1 = __loop6_var1, op = op}
                ).ToList(); //70:2
            int __loop6_iteration = 0;
            foreach (var __tmp1 in __loop6_results)
            {
                ++__loop6_iteration;
                var __loop6_var1 = __tmp1.__loop6_var1;
                var op = __tmp1.op;
                __out.AppendLine(); //71:1
                string __tmp2Prefix = "<wsdl:message name=\""; //72:1
                string __tmp3Suffix = "_InputMessage\">"; //72:42
                StringBuilder __tmp4 = new StringBuilder();
                __tmp4.Append(intf.Name);
                using(StreamReader __tmp4Reader = new StreamReader(this.__ToStream(__tmp4.ToString())))
                {
                    bool __tmp4_first = true;
                    while(__tmp4_first || !__tmp4Reader.EndOfStream)
                    {
                        __tmp4_first = false;
                        string __tmp4Line = __tmp4Reader.ReadLine();
                        if (__tmp4Line == null)
                        {
                            __tmp4Line = "";
                        }
                        __out.Append(__tmp2Prefix);
                        __out.Append(__tmp4Line);
                    }
                }
                string __tmp5Line = "_"; //72:32
                __out.Append(__tmp5Line);
                StringBuilder __tmp6 = new StringBuilder();
                __tmp6.Append(op.Name);
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
                        __out.Append(__tmp6Line);
                        __out.Append(__tmp3Suffix);
                        __out.AppendLine(); //72:57
                    }
                }
                string __tmp7Prefix = "	<wsdl:part name=\"parameters\" element=\""; //73:1
                string __tmp8Suffix = "\"/>"; //73:73
                StringBuilder __tmp9 = new StringBuilder();
                __tmp9.Append(intf.Namespace.Prefix);
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
                        __out.Append(__tmp7Prefix);
                        __out.Append(__tmp9Line);
                    }
                }
                string __tmp10Line = ":"; //73:63
                __out.Append(__tmp10Line);
                StringBuilder __tmp11 = new StringBuilder();
                __tmp11.Append(op.Name);
                using(StreamReader __tmp11Reader = new StreamReader(this.__ToStream(__tmp11.ToString())))
                {
                    bool __tmp11_first = true;
                    while(__tmp11_first || !__tmp11Reader.EndOfStream)
                    {
                        __tmp11_first = false;
                        string __tmp11Line = __tmp11Reader.ReadLine();
                        if (__tmp11Line == null)
                        {
                            __tmp11Line = "";
                        }
                        __out.Append(__tmp11Line);
                        __out.Append(__tmp8Suffix);
                        __out.AppendLine(); //73:76
                    }
                }
                __out.Append("</wsdl:message>"); //74:1
                __out.AppendLine(); //74:16
                if (!op.IsOneway) //75:2
                {
                    __out.AppendLine(); //76:1
                    string __tmp12Prefix = "<wsdl:message name=\""; //77:1
                    string __tmp13Suffix = "_OutputMessage\">"; //77:42
                    StringBuilder __tmp14 = new StringBuilder();
                    __tmp14.Append(intf.Name);
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
                        }
                    }
                    string __tmp15Line = "_"; //77:32
                    __out.Append(__tmp15Line);
                    StringBuilder __tmp16 = new StringBuilder();
                    __tmp16.Append(op.Name);
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
                            __out.Append(__tmp13Suffix);
                            __out.AppendLine(); //77:58
                        }
                    }
                    string __tmp17Prefix = "	<wsdl:part name=\"parameters\" element=\""; //78:1
                    string __tmp18Suffix = "Response\"/>"; //78:73
                    StringBuilder __tmp19 = new StringBuilder();
                    __tmp19.Append(intf.Namespace.Prefix);
                    using(StreamReader __tmp19Reader = new StreamReader(this.__ToStream(__tmp19.ToString())))
                    {
                        bool __tmp19_first = true;
                        while(__tmp19_first || !__tmp19Reader.EndOfStream)
                        {
                            __tmp19_first = false;
                            string __tmp19Line = __tmp19Reader.ReadLine();
                            if (__tmp19Line == null)
                            {
                                __tmp19Line = "";
                            }
                            __out.Append(__tmp17Prefix);
                            __out.Append(__tmp19Line);
                        }
                    }
                    string __tmp20Line = ":"; //78:63
                    __out.Append(__tmp20Line);
                    StringBuilder __tmp21 = new StringBuilder();
                    __tmp21.Append(op.Name);
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
                            __out.Append(__tmp18Suffix);
                            __out.AppendLine(); //78:84
                        }
                    }
                    __out.Append("</wsdl:message>"); //79:1
                    __out.AppendLine(); //79:16
                }
            }
            return __out.ToString();
        }

        public string GenerateFaultMessages(Namespace ns) //84:1
        {
            StringBuilder __out = new StringBuilder();
            var __loop7_results = 
                (from ex in __Enumerate((ns.GetInterfaceExceptions()).GetEnumerator()) //85:7
                select new { ex = ex}
                ).ToList(); //85:2
            int __loop7_iteration = 0;
            foreach (var __tmp1 in __loop7_results)
            {
                ++__loop7_iteration;
                var ex = __tmp1.ex;
                __out.AppendLine(); //86:1
                string __tmp2Prefix = "<wsdl:message name=\""; //87:1
                string __tmp3Suffix = "_FaultMessage\">"; //87:30
                StringBuilder __tmp4 = new StringBuilder();
                __tmp4.Append(ex.Name);
                using(StreamReader __tmp4Reader = new StreamReader(this.__ToStream(__tmp4.ToString())))
                {
                    bool __tmp4_first = true;
                    while(__tmp4_first || !__tmp4Reader.EndOfStream)
                    {
                        __tmp4_first = false;
                        string __tmp4Line = __tmp4Reader.ReadLine();
                        if (__tmp4Line == null)
                        {
                            __tmp4Line = "";
                        }
                        __out.Append(__tmp2Prefix);
                        __out.Append(__tmp4Line);
                        __out.Append(__tmp3Suffix);
                        __out.AppendLine(); //87:45
                    }
                }
                string __tmp5Prefix = "	<wsdl:part name=\"fault\" element=\""; //88:1
                string __tmp6Suffix = "\"/>"; //88:66
                StringBuilder __tmp7 = new StringBuilder();
                __tmp7.Append(ex.Namespace.Prefix);
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
                    }
                }
                string __tmp8Line = ":"; //88:56
                __out.Append(__tmp8Line);
                StringBuilder __tmp9 = new StringBuilder();
                __tmp9.Append(ex.Name);
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
                        __out.Append(__tmp6Suffix);
                        __out.AppendLine(); //88:69
                    }
                }
                __out.Append("</wsdl:message>"); //89:1
                __out.AppendLine(); //89:16
            }
            return __out.ToString();
        }

        public string GenerateFaultMessages(Interface intf) //93:1
        {
            StringBuilder __out = new StringBuilder();
            var __loop8_results = 
                (from ex in __Enumerate((intf.GetInterfaceExceptions()).GetEnumerator()) //94:7
                select new { ex = ex}
                ).ToList(); //94:2
            int __loop8_iteration = 0;
            foreach (var __tmp1 in __loop8_results)
            {
                ++__loop8_iteration;
                var ex = __tmp1.ex;
                __out.AppendLine(); //95:1
                string __tmp2Prefix = "<wsdl:message name=\""; //96:1
                string __tmp3Suffix = "_FaultMessage\">"; //96:30
                StringBuilder __tmp4 = new StringBuilder();
                __tmp4.Append(ex.Name);
                using(StreamReader __tmp4Reader = new StreamReader(this.__ToStream(__tmp4.ToString())))
                {
                    bool __tmp4_first = true;
                    while(__tmp4_first || !__tmp4Reader.EndOfStream)
                    {
                        __tmp4_first = false;
                        string __tmp4Line = __tmp4Reader.ReadLine();
                        if (__tmp4Line == null)
                        {
                            __tmp4Line = "";
                        }
                        __out.Append(__tmp2Prefix);
                        __out.Append(__tmp4Line);
                        __out.Append(__tmp3Suffix);
                        __out.AppendLine(); //96:45
                    }
                }
                string __tmp5Prefix = "	<wsdl:part name=\"fault\" element=\""; //97:1
                string __tmp6Suffix = "\"/>"; //97:66
                StringBuilder __tmp7 = new StringBuilder();
                __tmp7.Append(ex.Namespace.Prefix);
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
                    }
                }
                string __tmp8Line = ":"; //97:56
                __out.Append(__tmp8Line);
                StringBuilder __tmp9 = new StringBuilder();
                __tmp9.Append(ex.Name);
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
                        __out.Append(__tmp6Suffix);
                        __out.AppendLine(); //97:69
                    }
                }
                __out.Append("</wsdl:message>"); //98:1
                __out.AppendLine(); //98:16
            }
            return __out.ToString();
        }

        public string GeneratePortType(Interface intf) //102:1
        {
            StringBuilder __out = new StringBuilder();
            __out.AppendLine(); //103:1
            string __tmp1Prefix = "<wsdl:portType name=\""; //104:1
            string __tmp2Suffix = "\">"; //104:33
            StringBuilder __tmp3 = new StringBuilder();
            __tmp3.Append(intf.Name);
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
                    __out.AppendLine(); //104:35
                }
            }
            string __tmp4Prefix = "	"; //105:1
            string __tmp5Suffix = string.Empty; 
            StringBuilder __tmp6 = new StringBuilder();
            __tmp6.Append(GenerateOperations(intf));
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
                    __out.Append(__tmp5Suffix);
                    __out.AppendLine(); //105:28
                }
            }
            __out.Append("</wsdl:portType>"); //106:1
            __out.AppendLine(); //106:17
            return __out.ToString();
        }

        public string GenerateOperations(Interface intf) //109:1
        {
            StringBuilder __out = new StringBuilder();
            var __loop9_results = 
                (from __loop9_var1 in __Enumerate((intf.Operations).GetEnumerator()) //110:7
                from op in __Enumerate((__loop9_var1).GetEnumerator()).OfType<Operation>() //110:24
                select new { __loop9_var1 = __loop9_var1, op = op}
                ).ToList(); //110:2
            int __loop9_iteration = 0;
            foreach (var __tmp1 in __loop9_results)
            {
                ++__loop9_iteration;
                var __loop9_var1 = __tmp1.__loop9_var1;
                var op = __tmp1.op;
                string __tmp2Prefix = "<wsdl:operation name=\""; //111:1
                string __tmp3Suffix = "\">"; //111:32
                StringBuilder __tmp4 = new StringBuilder();
                __tmp4.Append(op.Name);
                using(StreamReader __tmp4Reader = new StreamReader(this.__ToStream(__tmp4.ToString())))
                {
                    bool __tmp4_first = true;
                    while(__tmp4_first || !__tmp4Reader.EndOfStream)
                    {
                        __tmp4_first = false;
                        string __tmp4Line = __tmp4Reader.ReadLine();
                        if (__tmp4Line == null)
                        {
                            __tmp4Line = "";
                        }
                        __out.Append(__tmp2Prefix);
                        __out.Append(__tmp4Line);
                        __out.Append(__tmp3Suffix);
                        __out.AppendLine(); //111:34
                    }
                }
                string __tmp5Prefix = "	<wsdl:input wsaw:action=\""; //112:1
                string __tmp6Suffix = "_InputMessage\"/>"; //112:174
                StringBuilder __tmp7 = new StringBuilder();
                __tmp7.Append(op.Interface.Namespace.UriWithSlash() + op.Interface.Name + "/" + op.Name);
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
                    }
                }
                string __tmp8Line = "\" message=\""; //112:102
                __out.Append(__tmp8Line);
                StringBuilder __tmp9 = new StringBuilder();
                __tmp9.Append(op.Interface.Namespace.Prefix);
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
                    }
                }
                string __tmp10Line = ":"; //112:144
                __out.Append(__tmp10Line);
                StringBuilder __tmp11 = new StringBuilder();
                __tmp11.Append(op.Interface.Name);
                using(StreamReader __tmp11Reader = new StreamReader(this.__ToStream(__tmp11.ToString())))
                {
                    bool __tmp11_first = true;
                    while(__tmp11_first || !__tmp11Reader.EndOfStream)
                    {
                        __tmp11_first = false;
                        string __tmp11Line = __tmp11Reader.ReadLine();
                        if (__tmp11Line == null)
                        {
                            __tmp11Line = "";
                        }
                        __out.Append(__tmp11Line);
                    }
                }
                string __tmp12Line = "_"; //112:164
                __out.Append(__tmp12Line);
                StringBuilder __tmp13 = new StringBuilder();
                __tmp13.Append(op.Name);
                using(StreamReader __tmp13Reader = new StreamReader(this.__ToStream(__tmp13.ToString())))
                {
                    bool __tmp13_first = true;
                    while(__tmp13_first || !__tmp13Reader.EndOfStream)
                    {
                        __tmp13_first = false;
                        string __tmp13Line = __tmp13Reader.ReadLine();
                        if (__tmp13Line == null)
                        {
                            __tmp13Line = "";
                        }
                        __out.Append(__tmp13Line);
                        __out.Append(__tmp6Suffix);
                        __out.AppendLine(); //112:190
                    }
                }
                if (!op.IsOneway) //113:2
                {
                    string __tmp14Prefix = "	<wsdl:output wsaw:action=\""; //114:1
                    string __tmp15Suffix = "_OutputMessage\"/>"; //114:188
                    StringBuilder __tmp16 = new StringBuilder();
                    __tmp16.Append(op.Interface.Namespace.UriWithSlash() + op.Interface.Name + "/" + op.Name + "Response");
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
                            __out.Append(__tmp14Prefix);
                            __out.Append(__tmp16Line);
                        }
                    }
                    string __tmp17Line = "\" message=\""; //114:116
                    __out.Append(__tmp17Line);
                    StringBuilder __tmp18 = new StringBuilder();
                    __tmp18.Append(op.Interface.Namespace.Prefix);
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
                        }
                    }
                    string __tmp19Line = ":"; //114:158
                    __out.Append(__tmp19Line);
                    StringBuilder __tmp20 = new StringBuilder();
                    __tmp20.Append(op.Interface.Name);
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
                    string __tmp21Line = "_"; //114:178
                    __out.Append(__tmp21Line);
                    StringBuilder __tmp22 = new StringBuilder();
                    __tmp22.Append(op.Name);
                    using(StreamReader __tmp22Reader = new StreamReader(this.__ToStream(__tmp22.ToString())))
                    {
                        bool __tmp22_first = true;
                        while(__tmp22_first || !__tmp22Reader.EndOfStream)
                        {
                            __tmp22_first = false;
                            string __tmp22Line = __tmp22Reader.ReadLine();
                            if (__tmp22Line == null)
                            {
                                __tmp22Line = "";
                            }
                            __out.Append(__tmp22Line);
                            __out.Append(__tmp15Suffix);
                            __out.AppendLine(); //114:205
                        }
                    }
                }
                var __loop10_results = 
                    (from ex in __Enumerate((op.Exceptions).GetEnumerator()) //116:8
                    select new { ex = ex}
                    ).ToList(); //116:3
                int __loop10_iteration = 0;
                foreach (var __tmp23 in __loop10_results)
                {
                    ++__loop10_iteration;
                    var ex = __tmp23.ex;
                    string __tmp24Prefix = "	<wsdl:fault wsaw:action=\""; //117:1
                    string __tmp25Suffix = "\"/>"; //117:205
                    StringBuilder __tmp26 = new StringBuilder();
                    __tmp26.Append(op.Interface.Namespace.UriWithSlash() + op.Interface.Name + "/" + op.Name + "Fault/" + ex.Name);
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
                            __out.Append(__tmp24Prefix);
                            __out.Append(__tmp26Line);
                        }
                    }
                    string __tmp27Line = "\" message=\""; //117:123
                    __out.Append(__tmp27Line);
                    StringBuilder __tmp28 = new StringBuilder();
                    __tmp28.Append(op.Interface.Namespace.Prefix);
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
                        }
                    }
                    string __tmp29Line = ":"; //117:165
                    __out.Append(__tmp29Line);
                    StringBuilder __tmp30 = new StringBuilder();
                    __tmp30.Append(ex.Name);
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
                            __out.Append(__tmp30Line);
                        }
                    }
                    string __tmp31Line = "_FaultMessage\" name=\""; //117:175
                    __out.Append(__tmp31Line);
                    StringBuilder __tmp32 = new StringBuilder();
                    __tmp32.Append(ex.Name);
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
                            __out.Append(__tmp25Suffix);
                            __out.AppendLine(); //117:208
                        }
                    }
                }
                __out.Append("</wsdl:operation>"); //119:1
                __out.AppendLine(); //119:18
            }
            return __out.ToString();
        }

        public string GenerateWsdlBindingPart(Namespace ns) //123:1
        {
            StringBuilder __out = new StringBuilder();
            return __out.ToString();
        }

        public string GenerateWsdlEndpointPart(Namespace ns) //126:1
        {
            StringBuilder __out = new StringBuilder();
            return __out.ToString();
        }

    }
}
