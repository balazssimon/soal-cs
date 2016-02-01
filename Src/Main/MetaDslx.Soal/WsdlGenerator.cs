using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Soal //1:1
{
    using __Hidden_WsdlGenerator_503503386;
    namespace __Hidden_WsdlGenerator_503503386
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
            __out.Append("	xmlns:wsp=\"http://www.w3.org/ns/ws-policy\""); //23:1
            __out.AppendLine(); //23:44
            __out.Append("	xmlns:wsu=\"http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd\""); //24:1
            __out.AppendLine(); //24:96
            __out.Append("	xmlns:wsoma=\"http://schemas.xmlsoap.org/ws/2004/09/policy/optimizedmimeserialization\""); //25:1
            __out.AppendLine(); //25:87
            __out.Append("	xmlns:wsa=\"http://www.w3.org/2005/08/addressing\" "); //26:1
            __out.AppendLine(); //26:51
            __out.Append("	xmlns:wsam=\"http://www.w3.org/2007/05/addressing/metadata\""); //27:1
            __out.AppendLine(); //27:60
            __out.Append("	xmlns:wsrmp=\"http://docs.oasis-open.org/ws-rx/wsrmp/200702\""); //28:1
            __out.AppendLine(); //28:61
            __out.Append("	xmlns:wsat=\"http://schemas.xmlsoap.org/ws/2004/10/wsat\""); //29:1
            __out.AppendLine(); //29:57
            __out.Append("	xmlns:sp=\"http://docs.oasis-open.org/ws-sx/ws-securitypolicy/200702\""); //30:1
            __out.AppendLine(); //30:70
            __out.Append("	xmlns:wst=\"http://docs.oasis-open.org/ws-sx/ws-trust/200512\""); //31:1
            __out.AppendLine(); //31:62
            __out.Append("	xmlns:wsx=\"http://schemas.xmlsoap.org/ws/2004/09/mex\""); //32:1
            __out.AppendLine(); //32:55
            __out.Append(">"); //33:1
            __out.AppendLine(); //33:2
            string __tmp15Prefix = "	"; //34:1
            string __tmp16Suffix = string.Empty; 
            StringBuilder __tmp17 = new StringBuilder();
            __tmp17.Append(GenerateWsdlPoliciesPart(ns));
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
                    __out.AppendLine(); //34:32
                }
            }
            string __tmp18Prefix = "	"; //35:1
            string __tmp19Suffix = string.Empty; 
            StringBuilder __tmp20 = new StringBuilder();
            __tmp20.Append(GenerateWsdlTypesPart(ns));
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
                    __out.AppendLine(); //35:29
                }
            }
            string __tmp21Prefix = "	"; //36:1
            string __tmp22Suffix = string.Empty; 
            StringBuilder __tmp23 = new StringBuilder();
            __tmp23.Append(GenerateWsdlAbstractPart(ns));
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
                    __out.AppendLine(); //36:32
                }
            }
            string __tmp24Prefix = "	"; //37:1
            string __tmp25Suffix = string.Empty; 
            StringBuilder __tmp26 = new StringBuilder();
            __tmp26.Append(GenerateWsdlBindingPart(ns));
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
                    __out.AppendLine(); //37:31
                }
            }
            string __tmp27Prefix = "	"; //38:1
            string __tmp28Suffix = string.Empty; 
            StringBuilder __tmp29 = new StringBuilder();
            __tmp29.Append(GenerateWsdlEndpointPart(ns));
            using(StreamReader __tmp29Reader = new StreamReader(this.__ToStream(__tmp29.ToString())))
            {
                bool __tmp29_first = true;
                while(__tmp29_first || !__tmp29Reader.EndOfStream)
                {
                    __tmp29_first = false;
                    string __tmp29Line = __tmp29Reader.ReadLine();
                    if (__tmp29Line == null)
                    {
                        __tmp29Line = "";
                    }
                    __out.Append(__tmp27Prefix);
                    __out.Append(__tmp29Line);
                    __out.Append(__tmp28Suffix);
                    __out.AppendLine(); //38:32
                }
            }
            __out.Append("</wsdl:definitions>"); //39:1
            __out.AppendLine(); //39:20
            return __out.ToString();
        }

        public string GenerateWsdlTypesPart(Namespace ns) //43:1
        {
            StringBuilder __out = new StringBuilder();
            __out.AppendLine(); //44:1
            __out.Append("<wsdl:types>"); //45:1
            __out.AppendLine(); //45:13
            if (Properties.SingleFileWsdl) //46:2
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
                        __out.AppendLine(); //47:28
                    }
                }
            }
            else //48:2
            {
                __out.Append("	<xs:schema>"); //49:1
                __out.AppendLine(); //49:13
                if (Properties.SeparateXsdWsdl) //50:4
                {
                    string __tmp4Prefix = "		<xs:import namespace=\""; //51:1
                    string __tmp5Suffix = ".xsd\"/>"; //51:71
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
                    string __tmp7Line = "\" schemaLocation=\"../xsd/"; //51:33
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
                            __out.AppendLine(); //51:78
                        }
                    }
                    var __loop2_results = 
                        (from ins in __Enumerate((ns.GetImportedNamespaces()).GetEnumerator()) //52:10
                        select new { ins = ins}
                        ).ToList(); //52:5
                    int __loop2_iteration = 0;
                    foreach (var __tmp9 in __loop2_results)
                    {
                        ++__loop2_iteration;
                        var ins = __tmp9.ins;
                        string __tmp10Prefix = "		<xs:import namespace=\""; //53:1
                        string __tmp11Suffix = ".xsd\"/>"; //53:73
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
                        string __tmp13Line = "\" schemaLocation=\"../xsd/"; //53:34
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
                                __out.AppendLine(); //53:80
                            }
                        }
                    }
                }
                else //55:4
                {
                    string __tmp15Prefix = "		<xs:import namespace=\""; //56:1
                    string __tmp16Suffix = ".xsd\"/>"; //56:64
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
                    string __tmp18Line = "\" schemaLocation=\""; //56:33
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
                            __out.AppendLine(); //56:71
                        }
                    }
                    var __loop3_results = 
                        (from ins in __Enumerate((ns.GetImportedNamespaces()).GetEnumerator()) //57:10
                        select new { ins = ins}
                        ).ToList(); //57:5
                    int __loop3_iteration = 0;
                    foreach (var __tmp20 in __loop3_results)
                    {
                        ++__loop3_iteration;
                        var ins = __tmp20.ins;
                        string __tmp21Prefix = "		<xs:import namespace=\""; //58:1
                        string __tmp22Suffix = ".xsd\"/>"; //58:66
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
                        string __tmp24Line = "\" schemaLocation=\""; //58:34
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
                                __out.AppendLine(); //58:73
                            }
                        }
                    }
                }
                __out.Append("	</xs:schema>"); //61:1
                __out.AppendLine(); //61:14
            }
            __out.Append("</wsdl:types>"); //63:1
            __out.AppendLine(); //63:14
            return __out.ToString();
        }

        public string GenerateWsdlAbstractPart(Namespace ns) //66:1
        {
            StringBuilder __out = new StringBuilder();
            var __loop4_results = 
                (from __loop4_var1 in __Enumerate((ns.Declarations).GetEnumerator()) //67:7
                from intf in __Enumerate((__loop4_var1).GetEnumerator()).OfType<Interface>() //67:24
                select new { __loop4_var1 = __loop4_var1, intf = intf}
                ).ToList(); //67:2
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
                        __out.AppendLine(); //68:25
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
                    __out.AppendLine(); //70:28
                }
            }
            var __loop5_results = 
                (from __loop5_var1 in __Enumerate((ns.Declarations).GetEnumerator()) //71:7
                from intf in __Enumerate((__loop5_var1).GetEnumerator()).OfType<Interface>() //71:24
                select new { __loop5_var1 = __loop5_var1, intf = intf}
                ).ToList(); //71:2
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
                        __out.AppendLine(); //72:25
                    }
                }
            }
            return __out.ToString();
        }

        public string GenerateWsdlAbstractPart(Interface intf) //76:1
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
                    __out.AppendLine(); //77:25
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
                    __out.AppendLine(); //78:30
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
                    __out.AppendLine(); //79:25
                }
            }
            return __out.ToString();
        }

        public string GenerateMessages(Interface intf) //82:1
        {
            StringBuilder __out = new StringBuilder();
            var __loop6_results = 
                (from __loop6_var1 in __Enumerate((intf.Operations).GetEnumerator()) //83:7
                from op in __Enumerate((__loop6_var1).GetEnumerator()).OfType<Operation>() //83:24
                select new { __loop6_var1 = __loop6_var1, op = op}
                ).ToList(); //83:2
            int __loop6_iteration = 0;
            foreach (var __tmp1 in __loop6_results)
            {
                ++__loop6_iteration;
                var __loop6_var1 = __tmp1.__loop6_var1;
                var op = __tmp1.op;
                if (intf.HasAnnotation(SoalAnnotations.NoWrap)) //84:3
                {
                    __out.AppendLine(); //85:1
                    string __tmp2Prefix = "<wsdl:message name=\""; //86:1
                    string __tmp3Suffix = "_InputMessage\">"; //86:42
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
                    string __tmp5Line = "_"; //86:32
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
                            __out.AppendLine(); //86:57
                        }
                    }
                    var __loop7_results = 
                        (from __loop7_var1 in __Enumerate((op).GetEnumerator()) //87:9
                        from param in __Enumerate((__loop7_var1.Parameters).GetEnumerator()) //87:13
                        select new { __loop7_var1 = __loop7_var1, param = param}
                        ).ToList(); //87:4
                    int __loop7_iteration = 0;
                    foreach (var __tmp7 in __loop7_results)
                    {
                        ++__loop7_iteration;
                        var __loop7_var1 = __tmp7.__loop7_var1;
                        var param = __tmp7.param;
                        string __tmp8Prefix = "	<wsdl:part name=\""; //88:1
                        string __tmp9Suffix = "\"/>"; //88:102
                        StringBuilder __tmp10 = new StringBuilder();
                        __tmp10.Append(param.Name);
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
                            }
                        }
                        string __tmp11Line = "\" element=\""; //88:31
                        __out.Append(__tmp11Line);
                        StringBuilder __tmp12 = new StringBuilder();
                        __tmp12.Append(intf.Namespace.Prefix);
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
                                __out.Append(__tmp12Line);
                            }
                        }
                        string __tmp13Line = ":"; //88:65
                        __out.Append(__tmp13Line);
                        StringBuilder __tmp14 = new StringBuilder();
                        __tmp14.Append(op.Name);
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
                        StringBuilder __tmp15 = new StringBuilder();
                        __tmp15.Append(param.Name.ToPascalCase());
                        using(StreamReader __tmp15Reader = new StreamReader(this.__ToStream(__tmp15.ToString())))
                        {
                            bool __tmp15_first = true;
                            while(__tmp15_first || !__tmp15Reader.EndOfStream)
                            {
                                __tmp15_first = false;
                                string __tmp15Line = __tmp15Reader.ReadLine();
                                if (__tmp15Line == null)
                                {
                                    __tmp15Line = "";
                                }
                                __out.Append(__tmp15Line);
                                __out.Append(__tmp9Suffix);
                                __out.AppendLine(); //88:105
                            }
                        }
                    }
                    __out.Append("</wsdl:message>"); //90:1
                    __out.AppendLine(); //90:16
                    if (!op.IsOneway) //91:4
                    {
                        __out.AppendLine(); //92:1
                        string __tmp16Prefix = "<wsdl:message name=\""; //93:1
                        string __tmp17Suffix = "_OutputMessage\">"; //93:42
                        StringBuilder __tmp18 = new StringBuilder();
                        __tmp18.Append(intf.Name);
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
                        string __tmp19Line = "_"; //93:32
                        __out.Append(__tmp19Line);
                        StringBuilder __tmp20 = new StringBuilder();
                        __tmp20.Append(op.Name);
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
                                __out.AppendLine(); //93:58
                            }
                        }
                        if (op.ReturnType != SoalInstance.Void) //94:5
                        {
                            string __tmp21Prefix = "	<wsdl:part name=\"result\" element=\""; //95:1
                            string __tmp22Suffix = "Response\"/>"; //95:69
                            StringBuilder __tmp23 = new StringBuilder();
                            __tmp23.Append(intf.Namespace.Prefix);
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
                            string __tmp24Line = ":"; //95:59
                            __out.Append(__tmp24Line);
                            StringBuilder __tmp25 = new StringBuilder();
                            __tmp25.Append(op.Name);
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
                                    __out.AppendLine(); //95:80
                                }
                            }
                        }
                        __out.Append("</wsdl:message>"); //97:1
                        __out.AppendLine(); //97:16
                    }
                }
                else if (intf.HasAnnotation(SoalAnnotations.Rpc)) //99:3
                {
                    __out.AppendLine(); //100:1
                    string __tmp26Prefix = "<wsdl:message name=\""; //101:1
                    string __tmp27Suffix = "_InputMessage\">"; //101:42
                    StringBuilder __tmp28 = new StringBuilder();
                    __tmp28.Append(intf.Name);
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
                            __out.Append(__tmp26Prefix);
                            __out.Append(__tmp28Line);
                        }
                    }
                    string __tmp29Line = "_"; //101:32
                    __out.Append(__tmp29Line);
                    StringBuilder __tmp30 = new StringBuilder();
                    __tmp30.Append(op.Name);
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
                            __out.Append(__tmp27Suffix);
                            __out.AppendLine(); //101:57
                        }
                    }
                    var __loop8_results = 
                        (from __loop8_var1 in __Enumerate((op).GetEnumerator()) //102:9
                        from param in __Enumerate((__loop8_var1.Parameters).GetEnumerator()) //102:13
                        select new { __loop8_var1 = __loop8_var1, param = param}
                        ).ToList(); //102:4
                    int __loop8_iteration = 0;
                    foreach (var __tmp31 in __loop8_results)
                    {
                        ++__loop8_iteration;
                        var __loop8_var1 = __tmp31.__loop8_var1;
                        var param = __tmp31.param;
                        string __tmp32Prefix = "	<wsdl:part name=\""; //103:1
                        string __tmp33Suffix = "\"/>"; //103:113
                        StringBuilder __tmp34 = new StringBuilder();
                        __tmp34.Append(param.Name);
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
                        string __tmp35Line = "\" type=\""; //103:31
                        __out.Append(__tmp35Line);
                        StringBuilder __tmp36 = new StringBuilder();
                        __tmp36.Append(param.Type.GetNamespace(intf.Namespace).Prefix);
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
                        string __tmp37Line = ":"; //103:87
                        __out.Append(__tmp37Line);
                        StringBuilder __tmp38 = new StringBuilder();
                        __tmp38.Append(param.Type.GetXsdName());
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
                                __out.Append(__tmp33Suffix);
                                __out.AppendLine(); //103:116
                            }
                        }
                    }
                    __out.Append("</wsdl:message>"); //105:1
                    __out.AppendLine(); //105:16
                    if (!op.IsOneway) //106:4
                    {
                        __out.AppendLine(); //107:1
                        string __tmp39Prefix = "<wsdl:message name=\""; //108:1
                        string __tmp40Suffix = "_OutputMessage\">"; //108:42
                        StringBuilder __tmp41 = new StringBuilder();
                        __tmp41.Append(intf.Name);
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
                                __out.Append(__tmp39Prefix);
                                __out.Append(__tmp41Line);
                            }
                        }
                        string __tmp42Line = "_"; //108:32
                        __out.Append(__tmp42Line);
                        StringBuilder __tmp43 = new StringBuilder();
                        __tmp43.Append(op.Name);
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
                                __out.Append(__tmp40Suffix);
                                __out.AppendLine(); //108:58
                            }
                        }
                        if (op.ReturnType != SoalInstance.Void) //109:5
                        {
                            string __tmp44Prefix = "	<wsdl:part name=\"result\" type=\""; //110:1
                            string __tmp45Suffix = "\"/>"; //110:113
                            StringBuilder __tmp46 = new StringBuilder();
                            __tmp46.Append(op.ReturnType.GetNamespace(intf.Namespace).Prefix);
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
                                    __out.Append(__tmp44Prefix);
                                    __out.Append(__tmp46Line);
                                }
                            }
                            string __tmp47Line = ":"; //110:84
                            __out.Append(__tmp47Line);
                            StringBuilder __tmp48 = new StringBuilder();
                            __tmp48.Append(op.ReturnType.GetXsdName());
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
                                    __out.Append(__tmp45Suffix);
                                    __out.AppendLine(); //110:116
                                }
                            }
                        }
                        __out.Append("</wsdl:message>"); //112:1
                        __out.AppendLine(); //112:16
                    }
                }
                else //114:3
                {
                    __out.AppendLine(); //115:1
                    string __tmp49Prefix = "<wsdl:message name=\""; //116:1
                    string __tmp50Suffix = "_InputMessage\">"; //116:42
                    StringBuilder __tmp51 = new StringBuilder();
                    __tmp51.Append(intf.Name);
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
                        }
                    }
                    string __tmp52Line = "_"; //116:32
                    __out.Append(__tmp52Line);
                    StringBuilder __tmp53 = new StringBuilder();
                    __tmp53.Append(op.Name);
                    using(StreamReader __tmp53Reader = new StreamReader(this.__ToStream(__tmp53.ToString())))
                    {
                        bool __tmp53_first = true;
                        while(__tmp53_first || !__tmp53Reader.EndOfStream)
                        {
                            __tmp53_first = false;
                            string __tmp53Line = __tmp53Reader.ReadLine();
                            if (__tmp53Line == null)
                            {
                                __tmp53Line = "";
                            }
                            __out.Append(__tmp53Line);
                            __out.Append(__tmp50Suffix);
                            __out.AppendLine(); //116:57
                        }
                    }
                    string __tmp54Prefix = "	<wsdl:part name=\"parameters\" element=\""; //117:1
                    string __tmp55Suffix = "\"/>"; //117:73
                    StringBuilder __tmp56 = new StringBuilder();
                    __tmp56.Append(intf.Namespace.Prefix);
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
                            __out.Append(__tmp54Prefix);
                            __out.Append(__tmp56Line);
                        }
                    }
                    string __tmp57Line = ":"; //117:63
                    __out.Append(__tmp57Line);
                    StringBuilder __tmp58 = new StringBuilder();
                    __tmp58.Append(op.Name);
                    using(StreamReader __tmp58Reader = new StreamReader(this.__ToStream(__tmp58.ToString())))
                    {
                        bool __tmp58_first = true;
                        while(__tmp58_first || !__tmp58Reader.EndOfStream)
                        {
                            __tmp58_first = false;
                            string __tmp58Line = __tmp58Reader.ReadLine();
                            if (__tmp58Line == null)
                            {
                                __tmp58Line = "";
                            }
                            __out.Append(__tmp58Line);
                            __out.Append(__tmp55Suffix);
                            __out.AppendLine(); //117:76
                        }
                    }
                    __out.Append("</wsdl:message>"); //118:1
                    __out.AppendLine(); //118:16
                    if (!op.IsOneway) //119:4
                    {
                        __out.AppendLine(); //120:1
                        string __tmp59Prefix = "<wsdl:message name=\""; //121:1
                        string __tmp60Suffix = "_OutputMessage\">"; //121:42
                        StringBuilder __tmp61 = new StringBuilder();
                        __tmp61.Append(intf.Name);
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
                                __out.Append(__tmp59Prefix);
                                __out.Append(__tmp61Line);
                            }
                        }
                        string __tmp62Line = "_"; //121:32
                        __out.Append(__tmp62Line);
                        StringBuilder __tmp63 = new StringBuilder();
                        __tmp63.Append(op.Name);
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
                                __out.Append(__tmp60Suffix);
                                __out.AppendLine(); //121:58
                            }
                        }
                        string __tmp64Prefix = "	<wsdl:part name=\"parameters\" element=\""; //122:1
                        string __tmp65Suffix = "Response\"/>"; //122:73
                        StringBuilder __tmp66 = new StringBuilder();
                        __tmp66.Append(intf.Namespace.Prefix);
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
                            }
                        }
                        string __tmp67Line = ":"; //122:63
                        __out.Append(__tmp67Line);
                        StringBuilder __tmp68 = new StringBuilder();
                        __tmp68.Append(op.Name);
                        using(StreamReader __tmp68Reader = new StreamReader(this.__ToStream(__tmp68.ToString())))
                        {
                            bool __tmp68_first = true;
                            while(__tmp68_first || !__tmp68Reader.EndOfStream)
                            {
                                __tmp68_first = false;
                                string __tmp68Line = __tmp68Reader.ReadLine();
                                if (__tmp68Line == null)
                                {
                                    __tmp68Line = "";
                                }
                                __out.Append(__tmp68Line);
                                __out.Append(__tmp65Suffix);
                                __out.AppendLine(); //122:84
                            }
                        }
                        __out.Append("</wsdl:message>"); //123:1
                        __out.AppendLine(); //123:16
                    }
                }
            }
            return __out.ToString();
        }

        public string GenerateFaultMessages(Namespace ns) //129:1
        {
            StringBuilder __out = new StringBuilder();
            var __loop9_results = 
                (from ex in __Enumerate((ns.GetInterfaceExceptions()).GetEnumerator()) //130:7
                select new { ex = ex}
                ).ToList(); //130:2
            int __loop9_iteration = 0;
            foreach (var __tmp1 in __loop9_results)
            {
                ++__loop9_iteration;
                var ex = __tmp1.ex;
                __out.AppendLine(); //131:1
                string __tmp2Prefix = "<wsdl:message name=\""; //132:1
                string __tmp3Suffix = "_FaultMessage\">"; //132:30
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
                        __out.AppendLine(); //132:45
                    }
                }
                string __tmp5Prefix = "	<wsdl:part name=\"fault\" element=\""; //133:1
                string __tmp6Suffix = "\"/>"; //133:66
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
                string __tmp8Line = ":"; //133:56
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
                        __out.AppendLine(); //133:69
                    }
                }
                __out.Append("</wsdl:message>"); //134:1
                __out.AppendLine(); //134:16
            }
            return __out.ToString();
        }

        public string GenerateFaultMessages(Interface intf) //138:1
        {
            StringBuilder __out = new StringBuilder();
            var __loop10_results = 
                (from ex in __Enumerate((intf.GetInterfaceExceptions()).GetEnumerator()) //139:7
                select new { ex = ex}
                ).ToList(); //139:2
            int __loop10_iteration = 0;
            foreach (var __tmp1 in __loop10_results)
            {
                ++__loop10_iteration;
                var ex = __tmp1.ex;
                __out.AppendLine(); //140:1
                string __tmp2Prefix = "<wsdl:message name=\""; //141:1
                string __tmp3Suffix = "_FaultMessage\">"; //141:30
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
                        __out.AppendLine(); //141:45
                    }
                }
                string __tmp5Prefix = "	<wsdl:part name=\"fault\" element=\""; //142:1
                string __tmp6Suffix = "\"/>"; //142:66
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
                string __tmp8Line = ":"; //142:56
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
                        __out.AppendLine(); //142:69
                    }
                }
                __out.Append("</wsdl:message>"); //143:1
                __out.AppendLine(); //143:16
            }
            return __out.ToString();
        }

        public string GeneratePortType(Interface intf) //147:1
        {
            StringBuilder __out = new StringBuilder();
            __out.AppendLine(); //148:1
            string __tmp1Prefix = "<wsdl:portType name=\""; //149:1
            string __tmp2Suffix = "\">"; //149:33
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
                    __out.AppendLine(); //149:35
                }
            }
            string __tmp4Prefix = "	"; //150:1
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
                    __out.AppendLine(); //150:28
                }
            }
            __out.Append("</wsdl:portType>"); //151:1
            __out.AppendLine(); //151:17
            return __out.ToString();
        }

        public string GenerateOperations(Interface intf) //154:1
        {
            StringBuilder __out = new StringBuilder();
            var __loop11_results = 
                (from __loop11_var1 in __Enumerate((intf.Operations).GetEnumerator()) //155:7
                from op in __Enumerate((__loop11_var1).GetEnumerator()).OfType<Operation>() //155:24
                select new { __loop11_var1 = __loop11_var1, op = op}
                ).ToList(); //155:2
            int __loop11_iteration = 0;
            foreach (var __tmp1 in __loop11_results)
            {
                ++__loop11_iteration;
                var __loop11_var1 = __tmp1.__loop11_var1;
                var op = __tmp1.op;
                string __tmp2Prefix = "<wsdl:operation name=\""; //156:1
                string __tmp3Suffix = "\">"; //156:32
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
                        __out.AppendLine(); //156:34
                    }
                }
                string __tmp5Prefix = "	<wsdl:input wsaw:action=\""; //157:1
                string __tmp6Suffix = "_InputMessage\"/>"; //157:174
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
                string __tmp8Line = "\" message=\""; //157:102
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
                string __tmp10Line = ":"; //157:144
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
                string __tmp12Line = "_"; //157:164
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
                        __out.AppendLine(); //157:190
                    }
                }
                if (!op.IsOneway) //158:2
                {
                    string __tmp14Prefix = "	<wsdl:output wsaw:action=\""; //159:1
                    string __tmp15Suffix = "_OutputMessage\"/>"; //159:188
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
                    string __tmp17Line = "\" message=\""; //159:116
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
                    string __tmp19Line = ":"; //159:158
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
                    string __tmp21Line = "_"; //159:178
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
                            __out.AppendLine(); //159:205
                        }
                    }
                    var __loop12_results = 
                        (from ex in __Enumerate((op.Exceptions).GetEnumerator()) //160:8
                        select new { ex = ex}
                        ).ToList(); //160:3
                    int __loop12_iteration = 0;
                    foreach (var __tmp23 in __loop12_results)
                    {
                        ++__loop12_iteration;
                        var ex = __tmp23.ex;
                        string __tmp24Prefix = "	<wsdl:fault wsaw:action=\""; //161:1
                        string __tmp25Suffix = "\"/>"; //161:205
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
                        string __tmp27Line = "\" message=\""; //161:123
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
                        string __tmp29Line = ":"; //161:165
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
                        string __tmp31Line = "_FaultMessage\" name=\""; //161:175
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
                                __out.AppendLine(); //161:208
                            }
                        }
                    }
                }
                __out.Append("</wsdl:operation>"); //164:1
                __out.AppendLine(); //164:18
            }
            return __out.ToString();
        }

        public string GenerateWsdlBindingPart(Namespace ns) //168:1
        {
            StringBuilder __out = new StringBuilder();
            var __loop13_results = 
                (from __loop13_var1 in __Enumerate((ns.Declarations).GetEnumerator()) //169:7
                from endp in __Enumerate((__loop13_var1).GetEnumerator()).OfType<Endpoint>() //169:24
                select new { __loop13_var1 = __loop13_var1, endp = endp}
                ).ToList(); //169:2
            int __loop13_iteration = 0;
            foreach (var __tmp1 in __loop13_results)
            {
                ++__loop13_iteration;
                var __loop13_var1 = __tmp1.__loop13_var1;
                var endp = __tmp1.endp;
                string __tmp2Prefix = string.Empty;
                string __tmp3Suffix = string.Empty;
                StringBuilder __tmp4 = new StringBuilder();
                __tmp4.Append(GenerateWsdlBinding(endp));
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
                        __out.AppendLine(); //170:28
                    }
                }
            }
            return __out.ToString();
        }

        public string GenerateWsdlBinding(Endpoint endp) //174:1
        {
            StringBuilder __out = new StringBuilder();
            __out.AppendLine(); //175:1
            string soapPrefix = endp.Binding.GetSoapPrefix(); //176:2
            string __tmp1Prefix = "<wsdl:binding name=\""; //177:1
            string __tmp2Suffix = "\">"; //177:133
            StringBuilder __tmp3 = new StringBuilder();
            __tmp3.Append(endp.Interface.Name);
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
            string __tmp4Line = "_"; //177:42
            __out.Append(__tmp4Line);
            StringBuilder __tmp5 = new StringBuilder();
            __tmp5.Append(endp.Binding.Name);
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
            string __tmp6Line = "_Binding\" type=\""; //177:62
            __out.Append(__tmp6Line);
            StringBuilder __tmp7 = new StringBuilder();
            __tmp7.Append(endp.Interface.Namespace.Prefix);
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
            string __tmp8Line = ":"; //177:111
            __out.Append(__tmp8Line);
            StringBuilder __tmp9 = new StringBuilder();
            __tmp9.Append(endp.Interface.Name);
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
                    __out.AppendLine(); //177:135
                }
            }
            if (endp.Binding.HasPolicy()) //178:3
            {
                string __tmp10Prefix = "	<wsp:PolicyReference URI=\"#"; //179:1
                string __tmp11Suffix = "_Policy\"/>"; //179:48
                StringBuilder __tmp12 = new StringBuilder();
                __tmp12.Append(endp.Binding.Name);
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
                        __out.Append(__tmp11Suffix);
                        __out.AppendLine(); //179:58
                    }
                }
            }
            if (soapPrefix != null) //181:3
            {
                if (endp.Binding.Transport is HttpTransportBindingElement) //182:4
                {
                    string __tmp13Prefix = "	<"; //183:1
                    string __tmp14Suffix = "\" transport=\"http://schemas.xmlsoap.org/soap/http\"/>"; //183:70
                    StringBuilder __tmp15 = new StringBuilder();
                    __tmp15.Append(soapPrefix);
                    using(StreamReader __tmp15Reader = new StreamReader(this.__ToStream(__tmp15.ToString())))
                    {
                        bool __tmp15_first = true;
                        while(__tmp15_first || !__tmp15Reader.EndOfStream)
                        {
                            __tmp15_first = false;
                            string __tmp15Line = __tmp15Reader.ReadLine();
                            if (__tmp15Line == null)
                            {
                                __tmp15Line = "";
                            }
                            __out.Append(__tmp13Prefix);
                            __out.Append(__tmp15Line);
                        }
                    }
                    string __tmp16Line = ":binding style=\""; //183:15
                    __out.Append(__tmp16Line);
                    StringBuilder __tmp17 = new StringBuilder();
                    __tmp17.Append(endp.Binding.GetWsdlSoapDocRpcStyle());
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
                            __out.Append(__tmp17Line);
                            __out.Append(__tmp14Suffix);
                            __out.AppendLine(); //183:122
                        }
                    }
                }
                else //184:4
                {
                    string __tmp18Prefix = "	<"; //185:1
                    string __tmp19Suffix = "\"/>"; //185:70
                    StringBuilder __tmp20 = new StringBuilder();
                    __tmp20.Append(soapPrefix);
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
                        }
                    }
                    string __tmp21Line = ":binding style=\""; //185:15
                    __out.Append(__tmp21Line);
                    StringBuilder __tmp22 = new StringBuilder();
                    __tmp22.Append(endp.Binding.GetWsdlSoapDocRpcStyle());
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
                            __out.Append(__tmp19Suffix);
                            __out.AppendLine(); //185:73
                        }
                    }
                }
            }
            var __loop14_results = 
                (from op in __Enumerate((endp.Interface.Operations).GetEnumerator()) //188:8
                select new { op = op}
                ).ToList(); //188:3
            int __loop14_iteration = 0;
            foreach (var __tmp23 in __loop14_results)
            {
                ++__loop14_iteration;
                var op = __tmp23.op;
                string __tmp24Prefix = "	<wsdl:operation name=\""; //189:1
                string __tmp25Suffix = "\">"; //189:33
                StringBuilder __tmp26 = new StringBuilder();
                __tmp26.Append(op.Name);
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
                        __out.AppendLine(); //189:35
                    }
                }
                if (soapPrefix != null) //190:4
                {
                    string __tmp27Prefix = "		<"; //191:1
                    string __tmp28Suffix = "\"/>"; //191:162
                    StringBuilder __tmp29 = new StringBuilder();
                    __tmp29.Append(soapPrefix);
                    using(StreamReader __tmp29Reader = new StreamReader(this.__ToStream(__tmp29.ToString())))
                    {
                        bool __tmp29_first = true;
                        while(__tmp29_first || !__tmp29Reader.EndOfStream)
                        {
                            __tmp29_first = false;
                            string __tmp29Line = __tmp29Reader.ReadLine();
                            if (__tmp29Line == null)
                            {
                                __tmp29Line = "";
                            }
                            __out.Append(__tmp27Prefix);
                            __out.Append(__tmp29Line);
                        }
                    }
                    string __tmp30Line = ":operation style=\""; //191:16
                    __out.Append(__tmp30Line);
                    StringBuilder __tmp31 = new StringBuilder();
                    __tmp31.Append(endp.Binding.GetWsdlSoapDocRpcStyle());
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
                            __out.Append(__tmp31Line);
                        }
                    }
                    string __tmp32Line = "\" soapAction=\""; //191:73
                    __out.Append(__tmp32Line);
                    StringBuilder __tmp33 = new StringBuilder();
                    __tmp33.Append(op.Interface.Namespace.UriWithSlash() + op.Interface.Name + "/" + op.Name);
                    using(StreamReader __tmp33Reader = new StreamReader(this.__ToStream(__tmp33.ToString())))
                    {
                        bool __tmp33_first = true;
                        while(__tmp33_first || !__tmp33Reader.EndOfStream)
                        {
                            __tmp33_first = false;
                            string __tmp33Line = __tmp33Reader.ReadLine();
                            if (__tmp33Line == null)
                            {
                                __tmp33Line = "";
                            }
                            __out.Append(__tmp33Line);
                            __out.Append(__tmp28Suffix);
                            __out.AppendLine(); //191:165
                        }
                    }
                }
                __out.Append("		<wsdl:input>"); //193:1
                __out.AppendLine(); //193:15
                if (endp.Binding.HasOperationPolicy()) //194:4
                {
                    string __tmp34Prefix = "			<wsp:PolicyReference URI=\"#"; //195:1
                    string __tmp35Suffix = "_Input_Policy\"/>"; //195:50
                    StringBuilder __tmp36 = new StringBuilder();
                    __tmp36.Append(endp.Binding.Name);
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
                            __out.Append(__tmp34Prefix);
                            __out.Append(__tmp36Line);
                            __out.Append(__tmp35Suffix);
                            __out.AppendLine(); //195:66
                        }
                    }
                }
                if (soapPrefix != null) //197:4
                {
                    string __tmp37Prefix = "			<"; //198:1
                    string __tmp38Suffix = "\"/>"; //198:67
                    StringBuilder __tmp39 = new StringBuilder();
                    __tmp39.Append(soapPrefix);
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
                    string __tmp40Line = ":body use=\""; //198:17
                    __out.Append(__tmp40Line);
                    StringBuilder __tmp41 = new StringBuilder();
                    __tmp41.Append(endp.Binding.GetWsdlSoapEncLitStyle());
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
                            __out.Append(__tmp38Suffix);
                            __out.AppendLine(); //198:70
                        }
                    }
                }
                __out.Append("		</wsdl:input>"); //200:1
                __out.AppendLine(); //200:16
                if (!op.IsOneway) //201:4
                {
                    __out.Append("		<wsdl:output>"); //202:1
                    __out.AppendLine(); //202:16
                    if (endp.Binding.HasOperationPolicy()) //203:5
                    {
                        string __tmp42Prefix = "			<wsp:PolicyReference URI=\"#"; //204:1
                        string __tmp43Suffix = "_Output_Policy\"/>"; //204:50
                        StringBuilder __tmp44 = new StringBuilder();
                        __tmp44.Append(endp.Binding.Name);
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
                                __out.Append(__tmp43Suffix);
                                __out.AppendLine(); //204:67
                            }
                        }
                    }
                    if (soapPrefix != null) //206:5
                    {
                        string __tmp45Prefix = "			<"; //207:1
                        string __tmp46Suffix = "\"/>"; //207:67
                        StringBuilder __tmp47 = new StringBuilder();
                        __tmp47.Append(soapPrefix);
                        using(StreamReader __tmp47Reader = new StreamReader(this.__ToStream(__tmp47.ToString())))
                        {
                            bool __tmp47_first = true;
                            while(__tmp47_first || !__tmp47Reader.EndOfStream)
                            {
                                __tmp47_first = false;
                                string __tmp47Line = __tmp47Reader.ReadLine();
                                if (__tmp47Line == null)
                                {
                                    __tmp47Line = "";
                                }
                                __out.Append(__tmp45Prefix);
                                __out.Append(__tmp47Line);
                            }
                        }
                        string __tmp48Line = ":body use=\""; //207:17
                        __out.Append(__tmp48Line);
                        StringBuilder __tmp49 = new StringBuilder();
                        __tmp49.Append(endp.Binding.GetWsdlSoapEncLitStyle());
                        using(StreamReader __tmp49Reader = new StreamReader(this.__ToStream(__tmp49.ToString())))
                        {
                            bool __tmp49_first = true;
                            while(__tmp49_first || !__tmp49Reader.EndOfStream)
                            {
                                __tmp49_first = false;
                                string __tmp49Line = __tmp49Reader.ReadLine();
                                if (__tmp49Line == null)
                                {
                                    __tmp49Line = "";
                                }
                                __out.Append(__tmp49Line);
                                __out.Append(__tmp46Suffix);
                                __out.AppendLine(); //207:70
                            }
                        }
                    }
                    __out.Append("		</wsdl:output>"); //209:1
                    __out.AppendLine(); //209:17
                    var __loop15_results = 
                        (from ex in __Enumerate((op.Exceptions).GetEnumerator()) //210:10
                        select new { ex = ex}
                        ).ToList(); //210:5
                    int __loop15_iteration = 0;
                    foreach (var __tmp50 in __loop15_results)
                    {
                        ++__loop15_iteration;
                        var ex = __tmp50.ex;
                        string __tmp51Prefix = "		<wsdl:fault name=\""; //211:1
                        string __tmp52Suffix = "\">"; //211:30
                        StringBuilder __tmp53 = new StringBuilder();
                        __tmp53.Append(ex.Name);
                        using(StreamReader __tmp53Reader = new StreamReader(this.__ToStream(__tmp53.ToString())))
                        {
                            bool __tmp53_first = true;
                            while(__tmp53_first || !__tmp53Reader.EndOfStream)
                            {
                                __tmp53_first = false;
                                string __tmp53Line = __tmp53Reader.ReadLine();
                                if (__tmp53Line == null)
                                {
                                    __tmp53Line = "";
                                }
                                __out.Append(__tmp51Prefix);
                                __out.Append(__tmp53Line);
                                __out.Append(__tmp52Suffix);
                                __out.AppendLine(); //211:32
                            }
                        }
                        if (soapPrefix != null) //212:5
                        {
                            string __tmp54Prefix = "			<"; //213:1
                            string __tmp55Suffix = "\"/>"; //213:85
                            StringBuilder __tmp56 = new StringBuilder();
                            __tmp56.Append(soapPrefix);
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
                                    __out.Append(__tmp54Prefix);
                                    __out.Append(__tmp56Line);
                                }
                            }
                            string __tmp57Line = ":fault name=\""; //213:17
                            __out.Append(__tmp57Line);
                            StringBuilder __tmp58 = new StringBuilder();
                            __tmp58.Append(ex.Name);
                            using(StreamReader __tmp58Reader = new StreamReader(this.__ToStream(__tmp58.ToString())))
                            {
                                bool __tmp58_first = true;
                                while(__tmp58_first || !__tmp58Reader.EndOfStream)
                                {
                                    __tmp58_first = false;
                                    string __tmp58Line = __tmp58Reader.ReadLine();
                                    if (__tmp58Line == null)
                                    {
                                        __tmp58Line = "";
                                    }
                                    __out.Append(__tmp58Line);
                                }
                            }
                            string __tmp59Line = "\" use=\""; //213:39
                            __out.Append(__tmp59Line);
                            StringBuilder __tmp60 = new StringBuilder();
                            __tmp60.Append(endp.Binding.GetWsdlSoapEncLitStyle());
                            using(StreamReader __tmp60Reader = new StreamReader(this.__ToStream(__tmp60.ToString())))
                            {
                                bool __tmp60_first = true;
                                while(__tmp60_first || !__tmp60Reader.EndOfStream)
                                {
                                    __tmp60_first = false;
                                    string __tmp60Line = __tmp60Reader.ReadLine();
                                    if (__tmp60Line == null)
                                    {
                                        __tmp60Line = "";
                                    }
                                    __out.Append(__tmp60Line);
                                    __out.Append(__tmp55Suffix);
                                    __out.AppendLine(); //213:88
                                }
                            }
                        }
                        __out.Append("		</wsdl:fault>"); //215:1
                        __out.AppendLine(); //215:16
                    }
                }
                __out.Append("	</wsdl:operation>"); //218:1
                __out.AppendLine(); //218:19
            }
            __out.Append("</wsdl:binding>"); //220:1
            __out.AppendLine(); //220:16
            return __out.ToString();
        }

        public string GenerateWsdlEndpointPart(Namespace ns) //223:1
        {
            StringBuilder __out = new StringBuilder();
            var __loop16_results = 
                (from __loop16_var1 in __Enumerate((ns.Declarations).GetEnumerator()) //224:7
                from endp in __Enumerate((__loop16_var1).GetEnumerator()).OfType<Endpoint>() //224:24
                select new { __loop16_var1 = __loop16_var1, endp = endp}
                ).ToList(); //224:2
            int __loop16_iteration = 0;
            foreach (var __tmp1 in __loop16_results)
            {
                ++__loop16_iteration;
                var __loop16_var1 = __tmp1.__loop16_var1;
                var endp = __tmp1.endp;
                string __tmp2Prefix = string.Empty;
                string __tmp3Suffix = string.Empty;
                StringBuilder __tmp4 = new StringBuilder();
                __tmp4.Append(GenerateWsdlEndpoint(endp));
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
                        __out.AppendLine(); //225:29
                    }
                }
            }
            return __out.ToString();
        }

        public string GenerateWsdlEndpoint(Endpoint endp) //229:1
        {
            StringBuilder __out = new StringBuilder();
            __out.AppendLine(); //230:1
            string soapPrefix = endp.Binding.GetSoapPrefix(); //231:2
            string __tmp1Prefix = "<wsdl:service name=\""; //232:1
            string __tmp2Suffix = "\">"; //232:32
            StringBuilder __tmp3 = new StringBuilder();
            __tmp3.Append(endp.Name);
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
                    __out.AppendLine(); //232:34
                }
            }
            string __tmp4Prefix = "	<wsdl:port name=\""; //233:1
            string __tmp5Suffix = "_Binding\">"; //233:141
            StringBuilder __tmp6 = new StringBuilder();
            __tmp6.Append(endp.Interface.Name);
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
            string __tmp7Line = "_"; //233:40
            __out.Append(__tmp7Line);
            StringBuilder __tmp8 = new StringBuilder();
            __tmp8.Append(endp.Binding.Name);
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
                }
            }
            string __tmp9Line = "_Port\" binding=\""; //233:60
            __out.Append(__tmp9Line);
            StringBuilder __tmp10 = new StringBuilder();
            __tmp10.Append(endp.Namespace.Prefix);
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
                    __out.Append(__tmp10Line);
                }
            }
            string __tmp11Line = ":"; //233:99
            __out.Append(__tmp11Line);
            StringBuilder __tmp12 = new StringBuilder();
            __tmp12.Append(endp.Interface.Name);
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
                    __out.Append(__tmp12Line);
                }
            }
            string __tmp13Line = "_"; //233:121
            __out.Append(__tmp13Line);
            StringBuilder __tmp14 = new StringBuilder();
            __tmp14.Append(endp.Binding.Name);
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
                    __out.Append(__tmp5Suffix);
                    __out.AppendLine(); //233:151
                }
            }
            if (soapPrefix != null) //234:3
            {
                string __tmp15Prefix = "		<"; //235:1
                string __tmp16Suffix = "\"/>"; //235:49
                StringBuilder __tmp17 = new StringBuilder();
                __tmp17.Append(soapPrefix);
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
                string __tmp18Line = ":address location=\""; //235:16
                __out.Append(__tmp18Line);
                StringBuilder __tmp19 = new StringBuilder();
                __tmp19.Append(endp.Address);
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
                        __out.AppendLine(); //235:52
                    }
                }
            }
            __out.Append("	</wsdl:port>"); //237:1
            __out.AppendLine(); //237:14
            __out.Append("</wsdl:service>"); //238:1
            __out.AppendLine(); //238:16
            return __out.ToString();
        }

        public string GenerateWsdlPoliciesPart(Namespace ns) //243:1
        {
            StringBuilder __out = new StringBuilder();
            var __loop17_results = 
                (from __loop17_var1 in __Enumerate((ns.Declarations).GetEnumerator()) //244:7
                from binding in __Enumerate((__loop17_var1).GetEnumerator()).OfType<Binding>() //244:24
                select new { __loop17_var1 = __loop17_var1, binding = binding}
                ).ToList(); //244:2
            int __loop17_iteration = 0;
            foreach (var __tmp1 in __loop17_results)
            {
                ++__loop17_iteration;
                var __loop17_var1 = __tmp1.__loop17_var1;
                var binding = __tmp1.binding;
                string __tmp2Prefix = string.Empty;
                string __tmp3Suffix = string.Empty;
                StringBuilder __tmp4 = new StringBuilder();
                __tmp4.Append(GenerateWsdlPolicy(binding));
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
                        __out.AppendLine(); //245:30
                    }
                }
            }
            return __out.ToString();
        }

        public string GenerateWsdlPolicy(Binding binding) //249:1
        {
            StringBuilder __out = new StringBuilder();
            if (binding.HasPolicy()) //250:2
            {
                __out.AppendLine(); //251:1
                string __tmp1Prefix = "<wsp:Policy wsu:Id=\""; //252:1
                string __tmp2Suffix = "_Policy\">"; //252:35
                StringBuilder __tmp3 = new StringBuilder();
                __tmp3.Append(binding.Name);
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
                        __out.AppendLine(); //252:44
                    }
                }
                string __tmp4Prefix = "	"; //253:1
                string __tmp5Suffix = string.Empty; 
                StringBuilder __tmp6 = new StringBuilder();
                __tmp6.Append(GenerateHttpsPolicy(binding));
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
                        __out.AppendLine(); //253:32
                    }
                }
                string __tmp7Prefix = "	"; //254:1
                string __tmp8Suffix = string.Empty; 
                StringBuilder __tmp9 = new StringBuilder();
                __tmp9.Append(GenerateMtomPolicy(binding));
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
                        __out.AppendLine(); //254:31
                    }
                }
                string __tmp10Prefix = "	"; //255:1
                string __tmp11Suffix = string.Empty; 
                StringBuilder __tmp12 = new StringBuilder();
                __tmp12.Append(GenerateAddressingPolicy(binding));
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
                        __out.Append(__tmp11Suffix);
                        __out.AppendLine(); //255:37
                    }
                }
                __out.Append("</wsp:Policy>"); //256:1
                __out.AppendLine(); //256:14
            }
            return __out.ToString();
        }

        public string GenerateHttpsPolicy(Binding binding) //260:1
        {
            StringBuilder __out = new StringBuilder();
            if (binding.Transport is HttpTransportBindingElement && ((HttpTransportBindingElement)binding.Transport).Ssl) //261:2
            {
                __out.Append("<sp:TransportBinding>"); //262:1
                __out.AppendLine(); //262:22
                __out.Append("	<wsp:Policy>"); //263:1
                __out.AppendLine(); //263:14
                __out.Append("		<sp:TransportToken>"); //264:1
                __out.AppendLine(); //264:22
                __out.Append("			<wsp:Policy>"); //265:1
                __out.AppendLine(); //265:16
                if (((HttpTransportBindingElement)binding.Transport).ClientAuthentication) //266:5
                {
                    __out.Append("				<sp:HttpsToken RequireClientCertificate=\"true\"/>"); //267:1
                    __out.AppendLine(); //267:53
                }
                else //268:5
                {
                    __out.Append("				<sp:HttpsToken RequireClientCertificate=\"false\"/>"); //269:1
                    __out.AppendLine(); //269:54
                }
                __out.Append("			</wsp:Policy>"); //271:1
                __out.AppendLine(); //271:17
                __out.Append("		</sp:TransportToken>"); //272:1
                __out.AppendLine(); //272:23
                __out.Append("		<sp:AlgorithmSuite>"); //273:1
                __out.AppendLine(); //273:22
                __out.Append("			<wsp:Policy>"); //274:1
                __out.AppendLine(); //274:16
                __out.Append("				<sp:Basic256/>"); //275:1
                __out.AppendLine(); //275:19
                __out.Append("			</wsp:Policy>"); //276:1
                __out.AppendLine(); //276:17
                __out.Append("		</sp:AlgorithmSuite>"); //277:1
                __out.AppendLine(); //277:23
                __out.Append("		<sp:Layout>"); //278:1
                __out.AppendLine(); //278:14
                __out.Append("			<wsp:Policy>"); //279:1
                __out.AppendLine(); //279:16
                __out.Append("				<sp:Strict/>"); //280:1
                __out.AppendLine(); //280:17
                __out.Append("			</wsp:Policy>"); //281:1
                __out.AppendLine(); //281:17
                __out.Append("		</sp:Layout> "); //282:1
                __out.AppendLine(); //282:16
                __out.Append("	</wsp:Policy>"); //283:1
                __out.AppendLine(); //283:15
                __out.Append("</sp:TransportBinding>"); //284:1
                __out.AppendLine(); //284:23
            }
            return __out.ToString();
        }

        public string GenerateMtomPolicy(Binding binding) //288:1
        {
            StringBuilder __out = new StringBuilder();
            if ((from __loop18_var1 in __Enumerate((binding).GetEnumerator()) //289:13
            from Encodings in __Enumerate((__loop18_var1.Encodings).GetEnumerator()) //289:22
            from enc in __Enumerate((Encodings).GetEnumerator()).OfType<SoapEncodingBindingElement>() //289:33
            where enc.Mtom //289:72
            select new { __loop18_var1 = __loop18_var1, Encodings = Encodings, enc = enc}
            ).GetEnumerator().MoveNext()) //289:2
            {
                __out.Append("<wsoma:OptimizedMimeSerialization/>"); //290:1
                __out.AppendLine(); //290:36
            }
            return __out.ToString();
        }

        public string GenerateAddressingPolicy(Binding binding) //294:1
        {
            StringBuilder __out = new StringBuilder();
            if ((from __loop19_var1 in __Enumerate((binding).GetEnumerator()) //295:13
            from Protocols in __Enumerate((__loop19_var1.Protocols).GetEnumerator()) //295:22
            from __loop19_var2 in __Enumerate((Protocols).GetEnumerator()).OfType<WsAddressingBindingElement>() //295:33
            select new { __loop19_var1 = __loop19_var1, Protocols = Protocols, __loop19_var2 = __loop19_var2}
            ).GetEnumerator().MoveNext()) //295:2
            {
                __out.Append("<wsam:Addressing/>"); //296:1
                __out.AppendLine(); //296:19
            }
            return __out.ToString();
        }

    }
}
