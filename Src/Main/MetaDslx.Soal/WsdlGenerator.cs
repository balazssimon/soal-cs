using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Soal //1:1
{
    using __Hidden_WsdlGenerator_1789458322;
    namespace __Hidden_WsdlGenerator_1789458322
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
                __out.AppendLine(); //84:1
                string __tmp2Prefix = "<wsdl:message name=\""; //85:1
                string __tmp3Suffix = "_InputMessage\">"; //85:42
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
                string __tmp5Line = "_"; //85:32
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
                        __out.AppendLine(); //85:57
                    }
                }
                string __tmp7Prefix = "	<wsdl:part name=\"parameters\" element=\""; //86:1
                string __tmp8Suffix = "\"/>"; //86:73
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
                string __tmp10Line = ":"; //86:63
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
                        __out.AppendLine(); //86:76
                    }
                }
                __out.Append("</wsdl:message>"); //87:1
                __out.AppendLine(); //87:16
                if (!op.IsOneway) //88:2
                {
                    __out.AppendLine(); //89:1
                    string __tmp12Prefix = "<wsdl:message name=\""; //90:1
                    string __tmp13Suffix = "_OutputMessage\">"; //90:42
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
                    string __tmp15Line = "_"; //90:32
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
                            __out.AppendLine(); //90:58
                        }
                    }
                    string __tmp17Prefix = "	<wsdl:part name=\"parameters\" element=\""; //91:1
                    string __tmp18Suffix = "Response\"/>"; //91:73
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
                    string __tmp20Line = ":"; //91:63
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
                            __out.AppendLine(); //91:84
                        }
                    }
                    __out.Append("</wsdl:message>"); //92:1
                    __out.AppendLine(); //92:16
                }
            }
            return __out.ToString();
        }

        public string GenerateFaultMessages(Namespace ns) //97:1
        {
            StringBuilder __out = new StringBuilder();
            var __loop7_results = 
                (from ex in __Enumerate((ns.GetInterfaceExceptions()).GetEnumerator()) //98:7
                select new { ex = ex}
                ).ToList(); //98:2
            int __loop7_iteration = 0;
            foreach (var __tmp1 in __loop7_results)
            {
                ++__loop7_iteration;
                var ex = __tmp1.ex;
                __out.AppendLine(); //99:1
                string __tmp2Prefix = "<wsdl:message name=\""; //100:1
                string __tmp3Suffix = "_FaultMessage\">"; //100:30
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
                        __out.AppendLine(); //100:45
                    }
                }
                string __tmp5Prefix = "	<wsdl:part name=\"fault\" element=\""; //101:1
                string __tmp6Suffix = "\"/>"; //101:66
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
                string __tmp8Line = ":"; //101:56
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
                        __out.AppendLine(); //101:69
                    }
                }
                __out.Append("</wsdl:message>"); //102:1
                __out.AppendLine(); //102:16
            }
            return __out.ToString();
        }

        public string GenerateFaultMessages(Interface intf) //106:1
        {
            StringBuilder __out = new StringBuilder();
            var __loop8_results = 
                (from ex in __Enumerate((intf.GetInterfaceExceptions()).GetEnumerator()) //107:7
                select new { ex = ex}
                ).ToList(); //107:2
            int __loop8_iteration = 0;
            foreach (var __tmp1 in __loop8_results)
            {
                ++__loop8_iteration;
                var ex = __tmp1.ex;
                __out.AppendLine(); //108:1
                string __tmp2Prefix = "<wsdl:message name=\""; //109:1
                string __tmp3Suffix = "_FaultMessage\">"; //109:30
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
                        __out.AppendLine(); //109:45
                    }
                }
                string __tmp5Prefix = "	<wsdl:part name=\"fault\" element=\""; //110:1
                string __tmp6Suffix = "\"/>"; //110:66
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
                string __tmp8Line = ":"; //110:56
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
                        __out.AppendLine(); //110:69
                    }
                }
                __out.Append("</wsdl:message>"); //111:1
                __out.AppendLine(); //111:16
            }
            return __out.ToString();
        }

        public string GeneratePortType(Interface intf) //115:1
        {
            StringBuilder __out = new StringBuilder();
            __out.AppendLine(); //116:1
            string __tmp1Prefix = "<wsdl:portType name=\""; //117:1
            string __tmp2Suffix = "\">"; //117:33
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
                    __out.AppendLine(); //117:35
                }
            }
            string __tmp4Prefix = "	"; //118:1
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
                    __out.AppendLine(); //118:28
                }
            }
            __out.Append("</wsdl:portType>"); //119:1
            __out.AppendLine(); //119:17
            return __out.ToString();
        }

        public string GenerateOperations(Interface intf) //122:1
        {
            StringBuilder __out = new StringBuilder();
            var __loop9_results = 
                (from __loop9_var1 in __Enumerate((intf.Operations).GetEnumerator()) //123:7
                from op in __Enumerate((__loop9_var1).GetEnumerator()).OfType<Operation>() //123:24
                select new { __loop9_var1 = __loop9_var1, op = op}
                ).ToList(); //123:2
            int __loop9_iteration = 0;
            foreach (var __tmp1 in __loop9_results)
            {
                ++__loop9_iteration;
                var __loop9_var1 = __tmp1.__loop9_var1;
                var op = __tmp1.op;
                string __tmp2Prefix = "<wsdl:operation name=\""; //124:1
                string __tmp3Suffix = "\">"; //124:32
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
                        __out.AppendLine(); //124:34
                    }
                }
                string __tmp5Prefix = "	<wsdl:input wsaw:action=\""; //125:1
                string __tmp6Suffix = "_InputMessage\"/>"; //125:174
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
                string __tmp8Line = "\" message=\""; //125:102
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
                string __tmp10Line = ":"; //125:144
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
                string __tmp12Line = "_"; //125:164
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
                        __out.AppendLine(); //125:190
                    }
                }
                if (!op.IsOneway) //126:2
                {
                    string __tmp14Prefix = "	<wsdl:output wsaw:action=\""; //127:1
                    string __tmp15Suffix = "_OutputMessage\"/>"; //127:188
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
                    string __tmp17Line = "\" message=\""; //127:116
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
                    string __tmp19Line = ":"; //127:158
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
                    string __tmp21Line = "_"; //127:178
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
                            __out.AppendLine(); //127:205
                        }
                    }
                    var __loop10_results = 
                        (from ex in __Enumerate((op.Exceptions).GetEnumerator()) //128:8
                        select new { ex = ex}
                        ).ToList(); //128:3
                    int __loop10_iteration = 0;
                    foreach (var __tmp23 in __loop10_results)
                    {
                        ++__loop10_iteration;
                        var ex = __tmp23.ex;
                        string __tmp24Prefix = "	<wsdl:fault wsaw:action=\""; //129:1
                        string __tmp25Suffix = "\"/>"; //129:205
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
                        string __tmp27Line = "\" message=\""; //129:123
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
                        string __tmp29Line = ":"; //129:165
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
                        string __tmp31Line = "_FaultMessage\" name=\""; //129:175
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
                                __out.AppendLine(); //129:208
                            }
                        }
                    }
                }
                __out.Append("</wsdl:operation>"); //132:1
                __out.AppendLine(); //132:18
            }
            return __out.ToString();
        }

        public string GenerateWsdlBindingPart(Namespace ns) //136:1
        {
            StringBuilder __out = new StringBuilder();
            var __loop11_results = 
                (from __loop11_var1 in __Enumerate((ns.Declarations).GetEnumerator()) //137:7
                from endp in __Enumerate((__loop11_var1).GetEnumerator()).OfType<Endpoint>() //137:24
                select new { __loop11_var1 = __loop11_var1, endp = endp}
                ).ToList(); //137:2
            int __loop11_iteration = 0;
            foreach (var __tmp1 in __loop11_results)
            {
                ++__loop11_iteration;
                var __loop11_var1 = __tmp1.__loop11_var1;
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
                        __out.AppendLine(); //138:28
                    }
                }
            }
            return __out.ToString();
        }

        public string GenerateWsdlBinding(Endpoint endp) //142:1
        {
            StringBuilder __out = new StringBuilder();
            __out.AppendLine(); //143:1
            string soapPrefix = endp.Binding.GetSoapPrefix(); //144:2
            string __tmp1Prefix = "<wsdl:binding name=\""; //145:1
            string __tmp2Suffix = "\">"; //145:133
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
            string __tmp4Line = "_"; //145:42
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
            string __tmp6Line = "_Binding\" type=\""; //145:62
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
            string __tmp8Line = ":"; //145:111
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
                    __out.AppendLine(); //145:135
                }
            }
            if (endp.Binding.HasPolicy()) //146:3
            {
                string __tmp10Prefix = "	<wsp:PolicyReference URI=\"#"; //147:1
                string __tmp11Suffix = "_Policy\"/>"; //147:48
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
                        __out.AppendLine(); //147:58
                    }
                }
            }
            if (soapPrefix != null) //149:3
            {
                if (endp.Binding.Transport is HttpTransportBindingElement) //150:4
                {
                    string __tmp13Prefix = "	<"; //151:1
                    string __tmp14Suffix = ":binding style=\"document\" transport=\"http://schemas.xmlsoap.org/soap/http\"/>"; //151:15
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
                            __out.Append(__tmp14Suffix);
                            __out.AppendLine(); //151:91
                        }
                    }
                }
                else //152:4
                {
                    string __tmp16Prefix = "	<"; //153:1
                    string __tmp17Suffix = ":binding style=\"document\"/>"; //153:15
                    StringBuilder __tmp18 = new StringBuilder();
                    __tmp18.Append(soapPrefix);
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
                            __out.Append(__tmp17Suffix);
                            __out.AppendLine(); //153:42
                        }
                    }
                }
            }
            var __loop12_results = 
                (from op in __Enumerate((endp.Interface.Operations).GetEnumerator()) //156:8
                select new { op = op}
                ).ToList(); //156:3
            int __loop12_iteration = 0;
            foreach (var __tmp19 in __loop12_results)
            {
                ++__loop12_iteration;
                var op = __tmp19.op;
                string __tmp20Prefix = "	<wsdl:operation name=\""; //157:1
                string __tmp21Suffix = "\">"; //157:33
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
                        __out.Append(__tmp20Prefix);
                        __out.Append(__tmp22Line);
                        __out.Append(__tmp21Suffix);
                        __out.AppendLine(); //157:35
                    }
                }
                if (soapPrefix != null) //158:4
                {
                    string __tmp23Prefix = "		<"; //159:1
                    string __tmp24Suffix = "\"/>"; //159:131
                    StringBuilder __tmp25 = new StringBuilder();
                    __tmp25.Append(soapPrefix);
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
                            __out.Append(__tmp23Prefix);
                            __out.Append(__tmp25Line);
                        }
                    }
                    string __tmp26Line = ":operation style=\"document\" soapAction=\""; //159:16
                    __out.Append(__tmp26Line);
                    StringBuilder __tmp27 = new StringBuilder();
                    __tmp27.Append(op.Interface.Namespace.UriWithSlash() + op.Interface.Name + "/" + op.Name);
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
                            __out.Append(__tmp24Suffix);
                            __out.AppendLine(); //159:134
                        }
                    }
                }
                __out.Append("		<wsdl:input>"); //161:1
                __out.AppendLine(); //161:15
                if (endp.Binding.HasOperationPolicy()) //162:4
                {
                    string __tmp28Prefix = "			<wsp:PolicyReference URI=\"#"; //163:1
                    string __tmp29Suffix = "_Input_Policy\"/>"; //163:50
                    StringBuilder __tmp30 = new StringBuilder();
                    __tmp30.Append(endp.Binding.Name);
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
                            __out.Append(__tmp29Suffix);
                            __out.AppendLine(); //163:66
                        }
                    }
                }
                if (soapPrefix != null) //165:4
                {
                    string __tmp31Prefix = "			<"; //166:1
                    string __tmp32Suffix = ":body use=\"literal\"/>"; //166:17
                    StringBuilder __tmp33 = new StringBuilder();
                    __tmp33.Append(soapPrefix);
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
                            __out.Append(__tmp31Prefix);
                            __out.Append(__tmp33Line);
                            __out.Append(__tmp32Suffix);
                            __out.AppendLine(); //166:38
                        }
                    }
                }
                __out.Append("		</wsdl:input>"); //168:1
                __out.AppendLine(); //168:16
                if (!op.IsOneway) //169:4
                {
                    __out.Append("		<wsdl:output>"); //170:1
                    __out.AppendLine(); //170:16
                    if (endp.Binding.HasOperationPolicy()) //171:5
                    {
                        string __tmp34Prefix = "			<wsp:PolicyReference URI=\"#"; //172:1
                        string __tmp35Suffix = "_Output_Policy\"/>"; //172:50
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
                                __out.AppendLine(); //172:67
                            }
                        }
                    }
                    if (soapPrefix != null) //174:5
                    {
                        string __tmp37Prefix = "			<"; //175:1
                        string __tmp38Suffix = ":body use=\"literal\"/>"; //175:17
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
                                __out.Append(__tmp38Suffix);
                                __out.AppendLine(); //175:38
                            }
                        }
                    }
                    __out.Append("		</wsdl:output>"); //177:1
                    __out.AppendLine(); //177:17
                    var __loop13_results = 
                        (from ex in __Enumerate((op.Exceptions).GetEnumerator()) //178:10
                        select new { ex = ex}
                        ).ToList(); //178:5
                    int __loop13_iteration = 0;
                    foreach (var __tmp40 in __loop13_results)
                    {
                        ++__loop13_iteration;
                        var ex = __tmp40.ex;
                        string __tmp41Prefix = "		<wsdl:fault name=\""; //179:1
                        string __tmp42Suffix = "\">"; //179:30
                        StringBuilder __tmp43 = new StringBuilder();
                        __tmp43.Append(ex.Name);
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
                                __out.Append(__tmp41Prefix);
                                __out.Append(__tmp43Line);
                                __out.Append(__tmp42Suffix);
                                __out.AppendLine(); //179:32
                            }
                        }
                        if (soapPrefix != null) //180:5
                        {
                            string __tmp44Prefix = "			<"; //181:1
                            string __tmp45Suffix = "\" use=\"literal\"/>"; //181:39
                            StringBuilder __tmp46 = new StringBuilder();
                            __tmp46.Append(soapPrefix);
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
                            string __tmp47Line = ":fault name=\""; //181:17
                            __out.Append(__tmp47Line);
                            StringBuilder __tmp48 = new StringBuilder();
                            __tmp48.Append(ex.Name);
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
                                    __out.AppendLine(); //181:56
                                }
                            }
                        }
                        __out.Append("		</wsdl:fault>"); //183:1
                        __out.AppendLine(); //183:16
                    }
                }
                __out.Append("	</wsdl:operation>"); //186:1
                __out.AppendLine(); //186:19
            }
            __out.Append("</wsdl:binding>"); //188:1
            __out.AppendLine(); //188:16
            return __out.ToString();
        }

        public string GenerateWsdlEndpointPart(Namespace ns) //191:1
        {
            StringBuilder __out = new StringBuilder();
            var __loop14_results = 
                (from __loop14_var1 in __Enumerate((ns.Declarations).GetEnumerator()) //192:7
                from endp in __Enumerate((__loop14_var1).GetEnumerator()).OfType<Endpoint>() //192:24
                select new { __loop14_var1 = __loop14_var1, endp = endp}
                ).ToList(); //192:2
            int __loop14_iteration = 0;
            foreach (var __tmp1 in __loop14_results)
            {
                ++__loop14_iteration;
                var __loop14_var1 = __tmp1.__loop14_var1;
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
                        __out.AppendLine(); //193:29
                    }
                }
            }
            return __out.ToString();
        }

        public string GenerateWsdlEndpoint(Endpoint endp) //197:1
        {
            StringBuilder __out = new StringBuilder();
            __out.AppendLine(); //198:1
            string soapPrefix = endp.Binding.GetSoapPrefix(); //199:2
            string __tmp1Prefix = "<wsdl:service name=\""; //200:1
            string __tmp2Suffix = "\">"; //200:32
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
                    __out.AppendLine(); //200:34
                }
            }
            string __tmp4Prefix = "	<wsdl:port name=\""; //201:1
            string __tmp5Suffix = "_Binding\">"; //201:141
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
            string __tmp7Line = "_"; //201:40
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
            string __tmp9Line = "_Port\" binding=\""; //201:60
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
            string __tmp11Line = ":"; //201:99
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
            string __tmp13Line = "_"; //201:121
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
                    __out.AppendLine(); //201:151
                }
            }
            if (soapPrefix != null) //202:3
            {
                string __tmp15Prefix = "		<"; //203:1
                string __tmp16Suffix = "\"/>"; //203:49
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
                string __tmp18Line = ":address location=\""; //203:16
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
                        __out.AppendLine(); //203:52
                    }
                }
            }
            __out.Append("	</wsdl:port>"); //205:1
            __out.AppendLine(); //205:14
            __out.Append("</wsdl:service>"); //206:1
            __out.AppendLine(); //206:16
            return __out.ToString();
        }

        public string GenerateWsdlPoliciesPart(Namespace ns) //211:1
        {
            StringBuilder __out = new StringBuilder();
            var __loop15_results = 
                (from __loop15_var1 in __Enumerate((ns.Declarations).GetEnumerator()) //212:7
                from binding in __Enumerate((__loop15_var1).GetEnumerator()).OfType<Binding>() //212:24
                select new { __loop15_var1 = __loop15_var1, binding = binding}
                ).ToList(); //212:2
            int __loop15_iteration = 0;
            foreach (var __tmp1 in __loop15_results)
            {
                ++__loop15_iteration;
                var __loop15_var1 = __tmp1.__loop15_var1;
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
                        __out.AppendLine(); //213:30
                    }
                }
            }
            return __out.ToString();
        }

        public string GenerateWsdlPolicy(Binding binding) //217:1
        {
            StringBuilder __out = new StringBuilder();
            if (binding.HasPolicy()) //218:2
            {
                __out.AppendLine(); //219:1
                string __tmp1Prefix = "<wsp:Policy wsu:Id=\""; //220:1
                string __tmp2Suffix = "_Policy\">"; //220:35
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
                        __out.AppendLine(); //220:44
                    }
                }
                string __tmp4Prefix = "	"; //221:1
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
                        __out.AppendLine(); //221:32
                    }
                }
                string __tmp7Prefix = "	"; //222:1
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
                        __out.AppendLine(); //222:31
                    }
                }
                string __tmp10Prefix = "	"; //223:1
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
                        __out.AppendLine(); //223:37
                    }
                }
                __out.Append("</wsp:Policy>"); //224:1
                __out.AppendLine(); //224:14
            }
            return __out.ToString();
        }

        public string GenerateHttpsPolicy(Binding binding) //228:1
        {
            StringBuilder __out = new StringBuilder();
            if (binding.Transport is HttpTransportBindingElement && ((HttpTransportBindingElement)binding.Transport).Ssl) //229:2
            {
                __out.Append("<sp:TransportBinding>"); //230:1
                __out.AppendLine(); //230:22
                __out.Append("	<wsp:Policy>"); //231:1
                __out.AppendLine(); //231:14
                __out.Append("		<sp:TransportToken>"); //232:1
                __out.AppendLine(); //232:22
                __out.Append("			<wsp:Policy>"); //233:1
                __out.AppendLine(); //233:16
                if (((HttpTransportBindingElement)binding.Transport).ClientAuthentication) //234:5
                {
                    __out.Append("				<sp:HttpsToken RequireClientCertificate=\"true\"/>"); //235:1
                    __out.AppendLine(); //235:53
                }
                else //236:5
                {
                    __out.Append("				<sp:HttpsToken RequireClientCertificate=\"false\"/>"); //237:1
                    __out.AppendLine(); //237:54
                }
                __out.Append("			</wsp:Policy>"); //239:1
                __out.AppendLine(); //239:17
                __out.Append("		</sp:TransportToken>"); //240:1
                __out.AppendLine(); //240:23
                __out.Append("		<sp:AlgorithmSuite>"); //241:1
                __out.AppendLine(); //241:22
                __out.Append("			<wsp:Policy>"); //242:1
                __out.AppendLine(); //242:16
                __out.Append("				<sp:Basic256/>"); //243:1
                __out.AppendLine(); //243:19
                __out.Append("			</wsp:Policy>"); //244:1
                __out.AppendLine(); //244:17
                __out.Append("		</sp:AlgorithmSuite>"); //245:1
                __out.AppendLine(); //245:23
                __out.Append("		<sp:Layout>"); //246:1
                __out.AppendLine(); //246:14
                __out.Append("			<wsp:Policy>"); //247:1
                __out.AppendLine(); //247:16
                __out.Append("				<sp:Strict/>"); //248:1
                __out.AppendLine(); //248:17
                __out.Append("			</wsp:Policy>"); //249:1
                __out.AppendLine(); //249:17
                __out.Append("		</sp:Layout> "); //250:1
                __out.AppendLine(); //250:16
                __out.Append("	</wsp:Policy>"); //251:1
                __out.AppendLine(); //251:15
                __out.Append("</sp:TransportBinding>"); //252:1
                __out.AppendLine(); //252:23
            }
            return __out.ToString();
        }

        public string GenerateMtomPolicy(Binding binding) //256:1
        {
            StringBuilder __out = new StringBuilder();
            if ((from __loop16_var1 in __Enumerate((binding).GetEnumerator()) //257:13
            from Encodings in __Enumerate((__loop16_var1.Encodings).GetEnumerator()) //257:22
            from enc in __Enumerate((Encodings).GetEnumerator()).OfType<SoapEncodingBindingElement>() //257:33
            where enc.Mtom //257:72
            select new { __loop16_var1 = __loop16_var1, Encodings = Encodings, enc = enc}
            ).GetEnumerator().MoveNext()) //257:2
            {
                __out.Append("<wsoma:OptimizedMimeSerialization/>"); //258:1
                __out.AppendLine(); //258:36
            }
            return __out.ToString();
        }

        public string GenerateAddressingPolicy(Binding binding) //262:1
        {
            StringBuilder __out = new StringBuilder();
            if ((from __loop17_var1 in __Enumerate((binding).GetEnumerator()) //263:13
            from Protocols in __Enumerate((__loop17_var1.Protocols).GetEnumerator()) //263:22
            from __loop17_var2 in __Enumerate((Protocols).GetEnumerator()).OfType<WsAddressingBindingElement>() //263:33
            select new { __loop17_var1 = __loop17_var1, Protocols = Protocols, __loop17_var2 = __loop17_var2}
            ).GetEnumerator().MoveNext()) //263:2
            {
                __out.Append("<wsam:Addressing/>"); //264:1
                __out.AppendLine(); //264:19
            }
            return __out.ToString();
        }

    }
}
