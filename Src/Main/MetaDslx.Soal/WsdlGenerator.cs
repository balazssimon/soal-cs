using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Soal //1:1
{
    using __Hidden_WsdlGenerator_314538470;
    namespace __Hidden_WsdlGenerator_314538470
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
            __out.AppendLine(false); //12:39
            string __tmp2Line = "<wsdl:definitions targetNamespace=\""; //13:1
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
            string __tmp4Line = "\"  "; //13:44
            if (__tmp4Line != null) __out.Append(__tmp4Line);
            __out.AppendLine(false); //13:47
            string __tmp6Line = "	xmlns:"; //14:1
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
            string __tmp8Line = "=\""; //14:19
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
            string __tmp10Line = "\""; //14:29
            if (__tmp10Line != null) __out.Append(__tmp10Line);
            __out.AppendLine(false); //14:30
            var __loop1_results = 
                (from ins in __Enumerate((ns.GetImportedNamespaces()).GetEnumerator()) //15:8
                select new { ins = ins}
                ).ToList(); //15:3
            int __loop1_iteration = 0;
            foreach (var __tmp11 in __loop1_results)
            {
                ++__loop1_iteration;
                var ins = __tmp11.ins;
                string __tmp13Line = "	xmlns:"; //16:1
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
                string __tmp15Line = "=\""; //16:20
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
                string __tmp17Line = "\""; //16:31
                if (__tmp17Line != null) __out.Append(__tmp17Line);
                __out.AppendLine(false); //16:32
            }
            __out.Append("	xmlns:xs=\"http://www.w3.org/2001/XMLSchema\" "); //18:1
            __out.AppendLine(false); //18:46
            __out.Append("	xmlns:wsdl=\"http://schemas.xmlsoap.org/wsdl/\""); //19:1
            __out.AppendLine(false); //19:47
            __out.Append("	xmlns:soap=\"http://schemas.xmlsoap.org/wsdl/soap/\""); //20:1
            __out.AppendLine(false); //20:52
            __out.Append("	xmlns:soap12=\"http://schemas.xmlsoap.org/wsdl/soap12/\""); //21:1
            __out.AppendLine(false); //21:56
            __out.Append("	xmlns:wsaw=\"http://www.w3.org/2006/05/addressing/wsdl\""); //22:1
            __out.AppendLine(false); //22:56
            __out.Append("	xmlns:wsp=\"http://www.w3.org/ns/ws-policy\""); //23:1
            __out.AppendLine(false); //23:44
            __out.Append("	xmlns:wsu=\"http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd\""); //24:1
            __out.AppendLine(false); //24:96
            __out.Append("	xmlns:wsoma=\"http://schemas.xmlsoap.org/ws/2004/09/policy/optimizedmimeserialization\""); //25:1
            __out.AppendLine(false); //25:87
            __out.Append("	xmlns:wsa=\"http://www.w3.org/2005/08/addressing\" "); //26:1
            __out.AppendLine(false); //26:51
            __out.Append("	xmlns:wsam=\"http://www.w3.org/2007/05/addressing/metadata\""); //27:1
            __out.AppendLine(false); //27:60
            __out.Append("	xmlns:wsrmp=\"http://docs.oasis-open.org/ws-rx/wsrmp/200702\""); //28:1
            __out.AppendLine(false); //28:61
            __out.Append("	xmlns:wsat=\"http://schemas.xmlsoap.org/ws/2004/10/wsat\""); //29:1
            __out.AppendLine(false); //29:57
            __out.Append("	xmlns:sp=\"http://docs.oasis-open.org/ws-sx/ws-securitypolicy/200702\""); //30:1
            __out.AppendLine(false); //30:70
            __out.Append("	xmlns:wst=\"http://docs.oasis-open.org/ws-sx/ws-trust/200512\""); //31:1
            __out.AppendLine(false); //31:62
            __out.Append("	xmlns:wsx=\"http://schemas.xmlsoap.org/ws/2004/09/mex\""); //32:1
            __out.AppendLine(false); //32:55
            __out.Append(">"); //33:1
            __out.AppendLine(false); //33:2
            string __tmp18Prefix = "	"; //34:1
            StringBuilder __tmp19 = new StringBuilder();
            __tmp19.Append(GenerateWsdlPoliciesPart(ns));
            using(StreamReader __tmp19Reader = new StreamReader(this.__ToStream(__tmp19.ToString())))
            {
                bool __tmp19_first = true;
                bool __tmp19_last = __tmp19Reader.EndOfStream;
                while(__tmp19_first || !__tmp19_last)
                {
                    __tmp19_first = false;
                    string __tmp19Line = __tmp19Reader.ReadLine();
                    __tmp19_last = __tmp19Reader.EndOfStream;
                    __out.Append(__tmp18Prefix);
                    if (__tmp19Line != null) __out.Append(__tmp19Line);
                    if (!__tmp19_last) __out.AppendLine(true);
                    __out.AppendLine(false); //34:32
                }
            }
            string __tmp20Prefix = "	"; //35:1
            StringBuilder __tmp21 = new StringBuilder();
            __tmp21.Append(GenerateWsdlTypesPart(ns));
            using(StreamReader __tmp21Reader = new StreamReader(this.__ToStream(__tmp21.ToString())))
            {
                bool __tmp21_first = true;
                bool __tmp21_last = __tmp21Reader.EndOfStream;
                while(__tmp21_first || !__tmp21_last)
                {
                    __tmp21_first = false;
                    string __tmp21Line = __tmp21Reader.ReadLine();
                    __tmp21_last = __tmp21Reader.EndOfStream;
                    __out.Append(__tmp20Prefix);
                    if (__tmp21Line != null) __out.Append(__tmp21Line);
                    if (!__tmp21_last) __out.AppendLine(true);
                    __out.AppendLine(false); //35:29
                }
            }
            string __tmp22Prefix = "	"; //36:1
            StringBuilder __tmp23 = new StringBuilder();
            __tmp23.Append(GenerateWsdlAbstractPart(ns));
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
                    __out.AppendLine(false); //36:32
                }
            }
            string __tmp24Prefix = "	"; //37:1
            StringBuilder __tmp25 = new StringBuilder();
            __tmp25.Append(GenerateWsdlBindingPart(ns));
            using(StreamReader __tmp25Reader = new StreamReader(this.__ToStream(__tmp25.ToString())))
            {
                bool __tmp25_first = true;
                bool __tmp25_last = __tmp25Reader.EndOfStream;
                while(__tmp25_first || !__tmp25_last)
                {
                    __tmp25_first = false;
                    string __tmp25Line = __tmp25Reader.ReadLine();
                    __tmp25_last = __tmp25Reader.EndOfStream;
                    __out.Append(__tmp24Prefix);
                    if (__tmp25Line != null) __out.Append(__tmp25Line);
                    if (!__tmp25_last) __out.AppendLine(true);
                    __out.AppendLine(false); //37:31
                }
            }
            string __tmp26Prefix = "	"; //38:1
            StringBuilder __tmp27 = new StringBuilder();
            __tmp27.Append(GenerateWsdlEndpointPart(ns));
            using(StreamReader __tmp27Reader = new StreamReader(this.__ToStream(__tmp27.ToString())))
            {
                bool __tmp27_first = true;
                bool __tmp27_last = __tmp27Reader.EndOfStream;
                while(__tmp27_first || !__tmp27_last)
                {
                    __tmp27_first = false;
                    string __tmp27Line = __tmp27Reader.ReadLine();
                    __tmp27_last = __tmp27Reader.EndOfStream;
                    __out.Append(__tmp26Prefix);
                    if (__tmp27Line != null) __out.Append(__tmp27Line);
                    if (!__tmp27_last) __out.AppendLine(true);
                    __out.AppendLine(false); //38:32
                }
            }
            __out.Append("</wsdl:definitions>"); //39:1
            __out.AppendLine(false); //39:20
            return __out.ToString();
        }

        public string GenerateWsdlTypesPart(Namespace ns) //43:1
        {
            StringBuilder __out = new StringBuilder();
            __out.AppendLine(true); //44:1
            __out.Append("<wsdl:types>"); //45:1
            __out.AppendLine(false); //45:13
            if (Properties.SingleFileWsdl) //46:2
            {
                StringBuilder __tmp2 = new StringBuilder();
                __tmp2.Append(XsdGenerator.Generate(ns));
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
                        __out.AppendLine(false); //47:28
                    }
                }
            }
            else //48:2
            {
                __out.Append("	<xs:schema>"); //49:1
                __out.AppendLine(false); //49:13
                if (Properties.SeparateXsdWsdl) //50:4
                {
                    string __tmp4Line = "		<xs:import namespace=\""; //51:1
                    if (__tmp4Line != null) __out.Append(__tmp4Line);
                    StringBuilder __tmp5 = new StringBuilder();
                    __tmp5.Append(ns.Uri);
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
                    string __tmp6Line = "\" schemaLocation=\"../xsd/"; //51:33
                    if (__tmp6Line != null) __out.Append(__tmp6Line);
                    StringBuilder __tmp7 = new StringBuilder();
                    __tmp7.Append(ns.FullName);
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
                    string __tmp8Line = ".xsd\"/>"; //51:71
                    if (__tmp8Line != null) __out.Append(__tmp8Line);
                    __out.AppendLine(false); //51:78
                    var __loop2_results = 
                        (from ins in __Enumerate((ns.GetImportedNamespaces()).GetEnumerator()) //52:10
                        select new { ins = ins}
                        ).ToList(); //52:5
                    int __loop2_iteration = 0;
                    foreach (var __tmp9 in __loop2_results)
                    {
                        ++__loop2_iteration;
                        var ins = __tmp9.ins;
                        string __tmp11Line = "		<xs:import namespace=\""; //53:1
                        if (__tmp11Line != null) __out.Append(__tmp11Line);
                        StringBuilder __tmp12 = new StringBuilder();
                        __tmp12.Append(ins.Uri);
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
                        string __tmp13Line = "\" schemaLocation=\"../xsd/"; //53:34
                        if (__tmp13Line != null) __out.Append(__tmp13Line);
                        StringBuilder __tmp14 = new StringBuilder();
                        __tmp14.Append(ins.FullName);
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
                        string __tmp15Line = ".xsd\"/>"; //53:73
                        if (__tmp15Line != null) __out.Append(__tmp15Line);
                        __out.AppendLine(false); //53:80
                    }
                }
                else //55:4
                {
                    string __tmp17Line = "		<xs:import namespace=\""; //56:1
                    if (__tmp17Line != null) __out.Append(__tmp17Line);
                    StringBuilder __tmp18 = new StringBuilder();
                    __tmp18.Append(ns.Uri);
                    using(StreamReader __tmp18Reader = new StreamReader(this.__ToStream(__tmp18.ToString())))
                    {
                        bool __tmp18_first = true;
                        bool __tmp18_last = __tmp18Reader.EndOfStream;
                        while(__tmp18_first || !__tmp18_last)
                        {
                            __tmp18_first = false;
                            string __tmp18Line = __tmp18Reader.ReadLine();
                            __tmp18_last = __tmp18Reader.EndOfStream;
                            if (__tmp18Line != null) __out.Append(__tmp18Line);
                            if (!__tmp18_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp19Line = "\" schemaLocation=\""; //56:33
                    if (__tmp19Line != null) __out.Append(__tmp19Line);
                    StringBuilder __tmp20 = new StringBuilder();
                    __tmp20.Append(ns.FullName);
                    using(StreamReader __tmp20Reader = new StreamReader(this.__ToStream(__tmp20.ToString())))
                    {
                        bool __tmp20_first = true;
                        bool __tmp20_last = __tmp20Reader.EndOfStream;
                        while(__tmp20_first || !__tmp20_last)
                        {
                            __tmp20_first = false;
                            string __tmp20Line = __tmp20Reader.ReadLine();
                            __tmp20_last = __tmp20Reader.EndOfStream;
                            if (__tmp20Line != null) __out.Append(__tmp20Line);
                            if (!__tmp20_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp21Line = ".xsd\"/>"; //56:64
                    if (__tmp21Line != null) __out.Append(__tmp21Line);
                    __out.AppendLine(false); //56:71
                    var __loop3_results = 
                        (from ins in __Enumerate((ns.GetImportedNamespaces()).GetEnumerator()) //57:10
                        select new { ins = ins}
                        ).ToList(); //57:5
                    int __loop3_iteration = 0;
                    foreach (var __tmp22 in __loop3_results)
                    {
                        ++__loop3_iteration;
                        var ins = __tmp22.ins;
                        string __tmp24Line = "		<xs:import namespace=\""; //58:1
                        if (__tmp24Line != null) __out.Append(__tmp24Line);
                        StringBuilder __tmp25 = new StringBuilder();
                        __tmp25.Append(ins.Uri);
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
                        string __tmp26Line = "\" schemaLocation=\""; //58:34
                        if (__tmp26Line != null) __out.Append(__tmp26Line);
                        StringBuilder __tmp27 = new StringBuilder();
                        __tmp27.Append(ins.FullName);
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
                        string __tmp28Line = ".xsd\"/>"; //58:66
                        if (__tmp28Line != null) __out.Append(__tmp28Line);
                        __out.AppendLine(false); //58:73
                    }
                }
                __out.Append("	</xs:schema>"); //61:1
                __out.AppendLine(false); //61:14
            }
            __out.Append("</wsdl:types>"); //63:1
            __out.AppendLine(false); //63:14
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
                StringBuilder __tmp3 = new StringBuilder();
                __tmp3.Append(GenerateWsdlAbstractPart(intf));
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
                        __out.AppendLine(false); //68:33
                    }
                }
            }
            return __out.ToString();
        }

        public string GenerateWsdlAbstractPart(Interface intf) //72:1
        {
            StringBuilder __out = new StringBuilder();
            StringBuilder __tmp2 = new StringBuilder();
            __tmp2.Append(GenerateMessages(intf));
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
                    __out.AppendLine(false); //73:25
                }
            }
            StringBuilder __tmp4 = new StringBuilder();
            __tmp4.Append(GenerateFaultMessages(intf));
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
                    __out.AppendLine(false); //74:30
                }
            }
            StringBuilder __tmp6 = new StringBuilder();
            __tmp6.Append(GeneratePortType(intf));
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
                    __out.AppendLine(false); //75:25
                }
            }
            return __out.ToString();
        }

        public string GenerateMessages(Interface intf) //78:1
        {
            StringBuilder __out = new StringBuilder();
            var __loop5_results = 
                (from __loop5_var1 in __Enumerate((intf.Operations).GetEnumerator()) //79:7
                from op in __Enumerate((__loop5_var1).GetEnumerator()).OfType<Operation>() //79:24
                select new { __loop5_var1 = __loop5_var1, op = op}
                ).ToList(); //79:2
            int __loop5_iteration = 0;
            foreach (var __tmp1 in __loop5_results)
            {
                ++__loop5_iteration;
                var __loop5_var1 = __tmp1.__loop5_var1;
                var op = __tmp1.op;
                if (intf.HasAnnotation(SoalAnnotations.Rpc)) //80:3
                {
                    __out.AppendLine(true); //81:1
                    string __tmp3Line = "<wsdl:message name=\""; //82:1
                    if (__tmp3Line != null) __out.Append(__tmp3Line);
                    StringBuilder __tmp4 = new StringBuilder();
                    __tmp4.Append(intf.Name);
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
                    string __tmp5Line = "_"; //82:32
                    if (__tmp5Line != null) __out.Append(__tmp5Line);
                    StringBuilder __tmp6 = new StringBuilder();
                    __tmp6.Append(op.Name);
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
                    string __tmp7Line = "_InputMessage\">"; //82:42
                    if (__tmp7Line != null) __out.Append(__tmp7Line);
                    __out.AppendLine(false); //82:57
                    var __loop6_results = 
                        (from __loop6_var1 in __Enumerate((op).GetEnumerator()) //83:9
                        from param in __Enumerate((__loop6_var1.Parameters).GetEnumerator()) //83:13
                        select new { __loop6_var1 = __loop6_var1, param = param}
                        ).ToList(); //83:4
                    int __loop6_iteration = 0;
                    foreach (var __tmp8 in __loop6_results)
                    {
                        ++__loop6_iteration;
                        var __loop6_var1 = __tmp8.__loop6_var1;
                        var param = __tmp8.param;
                        if (param.Type.IsArrayType() && param.Type.GetCoreType() != SoalInstance.Byte) //84:5
                        {
                            string __tmp10Line = "	<wsdl:part name=\""; //85:1
                            if (__tmp10Line != null) __out.Append(__tmp10Line);
                            StringBuilder __tmp11 = new StringBuilder();
                            __tmp11.Append(param.Name);
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
                            string __tmp12Line = "\" type=\""; //85:31
                            if (__tmp12Line != null) __out.Append(__tmp12Line);
                            StringBuilder __tmp13 = new StringBuilder();
                            __tmp13.Append(intf.Namespace.Prefix);
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
                            string __tmp14Line = ":"; //85:62
                            if (__tmp14Line != null) __out.Append(__tmp14Line);
                            StringBuilder __tmp15 = new StringBuilder();
                            __tmp15.Append(op.Name + param.Name.ToPascalCase());
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
                            string __tmp16Line = "\"/>"; //85:100
                            if (__tmp16Line != null) __out.Append(__tmp16Line);
                            __out.AppendLine(false); //85:103
                        }
                        else //86:5
                        {
                            string __tmp18Line = "	<wsdl:part name=\""; //87:1
                            if (__tmp18Line != null) __out.Append(__tmp18Line);
                            StringBuilder __tmp19 = new StringBuilder();
                            __tmp19.Append(param.Name);
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
                            string __tmp20Line = "\" type=\""; //87:31
                            if (__tmp20Line != null) __out.Append(__tmp20Line);
                            StringBuilder __tmp21 = new StringBuilder();
                            __tmp21.Append(param.Type.GetNamespace(intf.Namespace).Prefix);
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
                            string __tmp22Line = ":"; //87:87
                            if (__tmp22Line != null) __out.Append(__tmp22Line);
                            StringBuilder __tmp23 = new StringBuilder();
                            __tmp23.Append(param.Type.GetXsdName());
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
                            string __tmp24Line = "\"/>"; //87:113
                            if (__tmp24Line != null) __out.Append(__tmp24Line);
                            __out.AppendLine(false); //87:116
                        }
                    }
                    __out.Append("</wsdl:message>"); //90:1
                    __out.AppendLine(false); //90:16
                    if (!op.Result.IsOneway) //91:4
                    {
                        __out.AppendLine(true); //92:1
                        string __tmp26Line = "<wsdl:message name=\""; //93:1
                        if (__tmp26Line != null) __out.Append(__tmp26Line);
                        StringBuilder __tmp27 = new StringBuilder();
                        __tmp27.Append(intf.Name);
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
                        string __tmp28Line = "_"; //93:32
                        if (__tmp28Line != null) __out.Append(__tmp28Line);
                        StringBuilder __tmp29 = new StringBuilder();
                        __tmp29.Append(op.Name);
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
                        string __tmp30Line = "_OutputMessage\">"; //93:42
                        if (__tmp30Line != null) __out.Append(__tmp30Line);
                        __out.AppendLine(false); //93:58
                        if (op.Result.Type != SoalInstance.Void) //94:5
                        {
                            if (op.Result.Type.IsArrayType() && op.Result.Type.GetCoreType() != SoalInstance.Byte) //95:6
                            {
                                string __tmp32Line = "	<wsdl:part name=\"result\" type=\""; //96:1
                                if (__tmp32Line != null) __out.Append(__tmp32Line);
                                StringBuilder __tmp33 = new StringBuilder();
                                __tmp33.Append(intf.Namespace.Prefix);
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
                                string __tmp34Line = ":"; //96:56
                                if (__tmp34Line != null) __out.Append(__tmp34Line);
                                StringBuilder __tmp35 = new StringBuilder();
                                __tmp35.Append(op.Name + "Response");
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
                                string __tmp36Line = "\"/>"; //96:79
                                if (__tmp36Line != null) __out.Append(__tmp36Line);
                                __out.AppendLine(false); //96:82
                            }
                            else //97:6
                            {
                                string __tmp38Line = "	<wsdl:part name=\"result\" type=\""; //98:1
                                if (__tmp38Line != null) __out.Append(__tmp38Line);
                                StringBuilder __tmp39 = new StringBuilder();
                                __tmp39.Append(op.Result.Type.GetNamespace(intf.Namespace).Prefix);
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
                                string __tmp40Line = ":"; //98:85
                                if (__tmp40Line != null) __out.Append(__tmp40Line);
                                StringBuilder __tmp41 = new StringBuilder();
                                __tmp41.Append(op.Result.Type.GetXsdName());
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
                                string __tmp42Line = "\"/>"; //98:115
                                if (__tmp42Line != null) __out.Append(__tmp42Line);
                                __out.AppendLine(false); //98:118
                            }
                        }
                        __out.Append("</wsdl:message>"); //101:1
                        __out.AppendLine(false); //101:16
                    }
                }
                else if (intf.HasAnnotation(SoalAnnotations.NoWrap)) //103:3
                {
                    __out.AppendLine(true); //104:1
                    string __tmp44Line = "<wsdl:message name=\""; //105:1
                    if (__tmp44Line != null) __out.Append(__tmp44Line);
                    StringBuilder __tmp45 = new StringBuilder();
                    __tmp45.Append(intf.Name);
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
                    string __tmp46Line = "_"; //105:32
                    if (__tmp46Line != null) __out.Append(__tmp46Line);
                    StringBuilder __tmp47 = new StringBuilder();
                    __tmp47.Append(op.Name);
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
                    string __tmp48Line = "_InputMessage\">"; //105:42
                    if (__tmp48Line != null) __out.Append(__tmp48Line);
                    __out.AppendLine(false); //105:57
                    var __loop7_results = 
                        (from __loop7_var1 in __Enumerate((op).GetEnumerator()) //106:9
                        from param in __Enumerate((__loop7_var1.Parameters).GetEnumerator()) //106:13
                        select new { __loop7_var1 = __loop7_var1, param = param}
                        ).ToList(); //106:4
                    int __loop7_iteration = 0;
                    foreach (var __tmp49 in __loop7_results)
                    {
                        ++__loop7_iteration;
                        var __loop7_var1 = __tmp49.__loop7_var1;
                        var param = __tmp49.param;
                        string __tmp51Line = "	<wsdl:part name=\""; //107:1
                        if (__tmp51Line != null) __out.Append(__tmp51Line);
                        StringBuilder __tmp52 = new StringBuilder();
                        __tmp52.Append(param.Name);
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
                        string __tmp53Line = "\" element=\""; //107:31
                        if (__tmp53Line != null) __out.Append(__tmp53Line);
                        StringBuilder __tmp54 = new StringBuilder();
                        __tmp54.Append(intf.Namespace.Prefix);
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
                        string __tmp55Line = ":"; //107:65
                        if (__tmp55Line != null) __out.Append(__tmp55Line);
                        StringBuilder __tmp56 = new StringBuilder();
                        __tmp56.Append(op.Name);
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
                        StringBuilder __tmp57 = new StringBuilder();
                        __tmp57.Append(param.Name.ToPascalCase());
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
                        string __tmp58Line = "\"/>"; //107:102
                        if (__tmp58Line != null) __out.Append(__tmp58Line);
                        __out.AppendLine(false); //107:105
                    }
                    __out.Append("</wsdl:message>"); //109:1
                    __out.AppendLine(false); //109:16
                    if (!op.Result.IsOneway) //110:4
                    {
                        __out.AppendLine(true); //111:1
                        string __tmp60Line = "<wsdl:message name=\""; //112:1
                        if (__tmp60Line != null) __out.Append(__tmp60Line);
                        StringBuilder __tmp61 = new StringBuilder();
                        __tmp61.Append(intf.Name);
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
                        string __tmp62Line = "_"; //112:32
                        if (__tmp62Line != null) __out.Append(__tmp62Line);
                        StringBuilder __tmp63 = new StringBuilder();
                        __tmp63.Append(op.Name);
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
                        string __tmp64Line = "_OutputMessage\">"; //112:42
                        if (__tmp64Line != null) __out.Append(__tmp64Line);
                        __out.AppendLine(false); //112:58
                        if (op.Result.Type != SoalInstance.Void) //113:5
                        {
                            string __tmp66Line = "	<wsdl:part name=\"result\" element=\""; //114:1
                            if (__tmp66Line != null) __out.Append(__tmp66Line);
                            StringBuilder __tmp67 = new StringBuilder();
                            __tmp67.Append(intf.Namespace.Prefix);
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
                            string __tmp68Line = ":"; //114:59
                            if (__tmp68Line != null) __out.Append(__tmp68Line);
                            StringBuilder __tmp69 = new StringBuilder();
                            __tmp69.Append(op.Name);
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
                            string __tmp70Line = "Response\"/>"; //114:69
                            if (__tmp70Line != null) __out.Append(__tmp70Line);
                            __out.AppendLine(false); //114:80
                        }
                        __out.Append("</wsdl:message>"); //116:1
                        __out.AppendLine(false); //116:16
                    }
                }
                else //118:3
                {
                    __out.AppendLine(true); //119:1
                    string __tmp72Line = "<wsdl:message name=\""; //120:1
                    if (__tmp72Line != null) __out.Append(__tmp72Line);
                    StringBuilder __tmp73 = new StringBuilder();
                    __tmp73.Append(intf.Name);
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
                    string __tmp74Line = "_"; //120:32
                    if (__tmp74Line != null) __out.Append(__tmp74Line);
                    StringBuilder __tmp75 = new StringBuilder();
                    __tmp75.Append(op.Name);
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
                    string __tmp76Line = "_InputMessage\">"; //120:42
                    if (__tmp76Line != null) __out.Append(__tmp76Line);
                    __out.AppendLine(false); //120:57
                    string __tmp78Line = "	<wsdl:part name=\"parameters\" element=\""; //121:1
                    if (__tmp78Line != null) __out.Append(__tmp78Line);
                    StringBuilder __tmp79 = new StringBuilder();
                    __tmp79.Append(intf.Namespace.Prefix);
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
                    string __tmp80Line = ":"; //121:63
                    if (__tmp80Line != null) __out.Append(__tmp80Line);
                    StringBuilder __tmp81 = new StringBuilder();
                    __tmp81.Append(op.Name);
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
                    string __tmp82Line = "\"/>"; //121:73
                    if (__tmp82Line != null) __out.Append(__tmp82Line);
                    __out.AppendLine(false); //121:76
                    __out.Append("</wsdl:message>"); //122:1
                    __out.AppendLine(false); //122:16
                    if (!op.Result.IsOneway) //123:4
                    {
                        __out.AppendLine(true); //124:1
                        string __tmp84Line = "<wsdl:message name=\""; //125:1
                        if (__tmp84Line != null) __out.Append(__tmp84Line);
                        StringBuilder __tmp85 = new StringBuilder();
                        __tmp85.Append(intf.Name);
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
                        string __tmp86Line = "_"; //125:32
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
                        string __tmp88Line = "_OutputMessage\">"; //125:42
                        if (__tmp88Line != null) __out.Append(__tmp88Line);
                        __out.AppendLine(false); //125:58
                        string __tmp90Line = "	<wsdl:part name=\"parameters\" element=\""; //126:1
                        if (__tmp90Line != null) __out.Append(__tmp90Line);
                        StringBuilder __tmp91 = new StringBuilder();
                        __tmp91.Append(intf.Namespace.Prefix);
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
                        string __tmp92Line = ":"; //126:63
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
                        string __tmp94Line = "Response\"/>"; //126:73
                        if (__tmp94Line != null) __out.Append(__tmp94Line);
                        __out.AppendLine(false); //126:84
                        __out.Append("</wsdl:message>"); //127:1
                        __out.AppendLine(false); //127:16
                    }
                }
            }
            return __out.ToString();
        }

        public string GenerateFaultMessages(Interface intf) //133:1
        {
            StringBuilder __out = new StringBuilder();
            var __loop8_results = 
                (from ex in __Enumerate((intf.GetInterfaceExceptions()).GetEnumerator()) //134:7
                select new { ex = ex}
                ).ToList(); //134:2
            int __loop8_iteration = 0;
            foreach (var __tmp1 in __loop8_results)
            {
                ++__loop8_iteration;
                var ex = __tmp1.ex;
                if (intf.HasAnnotation(SoalAnnotations.Rpc)) //135:3
                {
                    __out.AppendLine(true); //136:1
                    string __tmp3Line = "<wsdl:message name=\""; //137:1
                    if (__tmp3Line != null) __out.Append(__tmp3Line);
                    StringBuilder __tmp4 = new StringBuilder();
                    __tmp4.Append(intf.Name);
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
                    string __tmp5Line = "_"; //137:32
                    if (__tmp5Line != null) __out.Append(__tmp5Line);
                    StringBuilder __tmp6 = new StringBuilder();
                    __tmp6.Append(ex.Name);
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
                    string __tmp7Line = "_FaultMessage\">"; //137:42
                    if (__tmp7Line != null) __out.Append(__tmp7Line);
                    __out.AppendLine(false); //137:57
                    string __tmp9Line = "	<wsdl:part name=\"fault\" type=\""; //138:1
                    if (__tmp9Line != null) __out.Append(__tmp9Line);
                    StringBuilder __tmp10 = new StringBuilder();
                    __tmp10.Append(ex.Namespace.Prefix);
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
                    string __tmp11Line = ":"; //138:53
                    if (__tmp11Line != null) __out.Append(__tmp11Line);
                    StringBuilder __tmp12 = new StringBuilder();
                    __tmp12.Append(ex.Name);
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
                    string __tmp13Line = "\"/>"; //138:63
                    if (__tmp13Line != null) __out.Append(__tmp13Line);
                    __out.AppendLine(false); //138:66
                    __out.Append("</wsdl:message>"); //139:1
                    __out.AppendLine(false); //139:16
                }
                else //140:3
                {
                    __out.AppendLine(true); //141:1
                    string __tmp15Line = "<wsdl:message name=\""; //142:1
                    if (__tmp15Line != null) __out.Append(__tmp15Line);
                    StringBuilder __tmp16 = new StringBuilder();
                    __tmp16.Append(intf.Name);
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
                    string __tmp17Line = "_"; //142:32
                    if (__tmp17Line != null) __out.Append(__tmp17Line);
                    StringBuilder __tmp18 = new StringBuilder();
                    __tmp18.Append(ex.Name);
                    using(StreamReader __tmp18Reader = new StreamReader(this.__ToStream(__tmp18.ToString())))
                    {
                        bool __tmp18_first = true;
                        bool __tmp18_last = __tmp18Reader.EndOfStream;
                        while(__tmp18_first || !__tmp18_last)
                        {
                            __tmp18_first = false;
                            string __tmp18Line = __tmp18Reader.ReadLine();
                            __tmp18_last = __tmp18Reader.EndOfStream;
                            if (__tmp18Line != null) __out.Append(__tmp18Line);
                            if (!__tmp18_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp19Line = "_FaultMessage\">"; //142:42
                    if (__tmp19Line != null) __out.Append(__tmp19Line);
                    __out.AppendLine(false); //142:57
                    string __tmp21Line = "	<wsdl:part name=\"fault\" element=\""; //143:1
                    if (__tmp21Line != null) __out.Append(__tmp21Line);
                    StringBuilder __tmp22 = new StringBuilder();
                    __tmp22.Append(ex.Namespace.Prefix);
                    using(StreamReader __tmp22Reader = new StreamReader(this.__ToStream(__tmp22.ToString())))
                    {
                        bool __tmp22_first = true;
                        bool __tmp22_last = __tmp22Reader.EndOfStream;
                        while(__tmp22_first || !__tmp22_last)
                        {
                            __tmp22_first = false;
                            string __tmp22Line = __tmp22Reader.ReadLine();
                            __tmp22_last = __tmp22Reader.EndOfStream;
                            if (__tmp22Line != null) __out.Append(__tmp22Line);
                            if (!__tmp22_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp23Line = ":"; //143:56
                    if (__tmp23Line != null) __out.Append(__tmp23Line);
                    StringBuilder __tmp24 = new StringBuilder();
                    __tmp24.Append(ex.Name);
                    using(StreamReader __tmp24Reader = new StreamReader(this.__ToStream(__tmp24.ToString())))
                    {
                        bool __tmp24_first = true;
                        bool __tmp24_last = __tmp24Reader.EndOfStream;
                        while(__tmp24_first || !__tmp24_last)
                        {
                            __tmp24_first = false;
                            string __tmp24Line = __tmp24Reader.ReadLine();
                            __tmp24_last = __tmp24Reader.EndOfStream;
                            if (__tmp24Line != null) __out.Append(__tmp24Line);
                            if (!__tmp24_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp25Line = "\"/>"; //143:66
                    if (__tmp25Line != null) __out.Append(__tmp25Line);
                    __out.AppendLine(false); //143:69
                    __out.Append("</wsdl:message>"); //144:1
                    __out.AppendLine(false); //144:16
                }
            }
            return __out.ToString();
        }

        public string GeneratePortType(Interface intf) //149:1
        {
            StringBuilder __out = new StringBuilder();
            __out.AppendLine(true); //150:1
            string __tmp2Line = "<wsdl:portType name=\""; //151:1
            if (__tmp2Line != null) __out.Append(__tmp2Line);
            StringBuilder __tmp3 = new StringBuilder();
            __tmp3.Append(intf.Name);
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
            string __tmp4Line = "\">"; //151:33
            if (__tmp4Line != null) __out.Append(__tmp4Line);
            __out.AppendLine(false); //151:35
            string __tmp5Prefix = "	"; //152:1
            StringBuilder __tmp6 = new StringBuilder();
            __tmp6.Append(GenerateOperations(intf));
            using(StreamReader __tmp6Reader = new StreamReader(this.__ToStream(__tmp6.ToString())))
            {
                bool __tmp6_first = true;
                bool __tmp6_last = __tmp6Reader.EndOfStream;
                while(__tmp6_first || !__tmp6_last)
                {
                    __tmp6_first = false;
                    string __tmp6Line = __tmp6Reader.ReadLine();
                    __tmp6_last = __tmp6Reader.EndOfStream;
                    __out.Append(__tmp5Prefix);
                    if (__tmp6Line != null) __out.Append(__tmp6Line);
                    if (!__tmp6_last) __out.AppendLine(true);
                    __out.AppendLine(false); //152:28
                }
            }
            __out.Append("</wsdl:portType>"); //153:1
            __out.AppendLine(false); //153:17
            return __out.ToString();
        }

        public string GenerateOperations(Interface intf) //156:1
        {
            StringBuilder __out = new StringBuilder();
            var __loop9_results = 
                (from __loop9_var1 in __Enumerate((intf.Operations).GetEnumerator()) //157:7
                from op in __Enumerate((__loop9_var1).GetEnumerator()).OfType<Operation>() //157:24
                select new { __loop9_var1 = __loop9_var1, op = op}
                ).ToList(); //157:2
            int __loop9_iteration = 0;
            foreach (var __tmp1 in __loop9_results)
            {
                ++__loop9_iteration;
                var __loop9_var1 = __tmp1.__loop9_var1;
                var op = __tmp1.op;
                string action = op.Action != null ? op.Action : intf.Namespace.UriWithSlash() + intf.Name + "/" + op.Name; //158:3
                string __tmp3Line = "<wsdl:operation name=\""; //159:1
                if (__tmp3Line != null) __out.Append(__tmp3Line);
                StringBuilder __tmp4 = new StringBuilder();
                __tmp4.Append(op.Name);
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
                string __tmp5Line = "\">"; //159:32
                if (__tmp5Line != null) __out.Append(__tmp5Line);
                __out.AppendLine(false); //159:34
                string __tmp7Line = "	<wsdl:input wsaw:action=\""; //160:1
                if (__tmp7Line != null) __out.Append(__tmp7Line);
                StringBuilder __tmp8 = new StringBuilder();
                __tmp8.Append(action);
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
                string __tmp9Line = "\" message=\""; //160:35
                if (__tmp9Line != null) __out.Append(__tmp9Line);
                StringBuilder __tmp10 = new StringBuilder();
                __tmp10.Append(intf.Namespace.Prefix);
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
                string __tmp11Line = ":"; //160:69
                if (__tmp11Line != null) __out.Append(__tmp11Line);
                StringBuilder __tmp12 = new StringBuilder();
                __tmp12.Append(intf.Name);
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
                string __tmp13Line = "_"; //160:81
                if (__tmp13Line != null) __out.Append(__tmp13Line);
                StringBuilder __tmp14 = new StringBuilder();
                __tmp14.Append(op.Name);
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
                string __tmp15Line = "_InputMessage\"/>"; //160:91
                if (__tmp15Line != null) __out.Append(__tmp15Line);
                __out.AppendLine(false); //160:107
                if (!op.Result.IsOneway) //161:2
                {
                    string __tmp17Line = "	<wsdl:output wsaw:action=\""; //162:1
                    if (__tmp17Line != null) __out.Append(__tmp17Line);
                    StringBuilder __tmp18 = new StringBuilder();
                    __tmp18.Append(action + "Response");
                    using(StreamReader __tmp18Reader = new StreamReader(this.__ToStream(__tmp18.ToString())))
                    {
                        bool __tmp18_first = true;
                        bool __tmp18_last = __tmp18Reader.EndOfStream;
                        while(__tmp18_first || !__tmp18_last)
                        {
                            __tmp18_first = false;
                            string __tmp18Line = __tmp18Reader.ReadLine();
                            __tmp18_last = __tmp18Reader.EndOfStream;
                            if (__tmp18Line != null) __out.Append(__tmp18Line);
                            if (!__tmp18_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp19Line = "\" message=\""; //162:49
                    if (__tmp19Line != null) __out.Append(__tmp19Line);
                    StringBuilder __tmp20 = new StringBuilder();
                    __tmp20.Append(intf.Namespace.Prefix);
                    using(StreamReader __tmp20Reader = new StreamReader(this.__ToStream(__tmp20.ToString())))
                    {
                        bool __tmp20_first = true;
                        bool __tmp20_last = __tmp20Reader.EndOfStream;
                        while(__tmp20_first || !__tmp20_last)
                        {
                            __tmp20_first = false;
                            string __tmp20Line = __tmp20Reader.ReadLine();
                            __tmp20_last = __tmp20Reader.EndOfStream;
                            if (__tmp20Line != null) __out.Append(__tmp20Line);
                            if (!__tmp20_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp21Line = ":"; //162:83
                    if (__tmp21Line != null) __out.Append(__tmp21Line);
                    StringBuilder __tmp22 = new StringBuilder();
                    __tmp22.Append(intf.Name);
                    using(StreamReader __tmp22Reader = new StreamReader(this.__ToStream(__tmp22.ToString())))
                    {
                        bool __tmp22_first = true;
                        bool __tmp22_last = __tmp22Reader.EndOfStream;
                        while(__tmp22_first || !__tmp22_last)
                        {
                            __tmp22_first = false;
                            string __tmp22Line = __tmp22Reader.ReadLine();
                            __tmp22_last = __tmp22Reader.EndOfStream;
                            if (__tmp22Line != null) __out.Append(__tmp22Line);
                            if (!__tmp22_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp23Line = "_"; //162:95
                    if (__tmp23Line != null) __out.Append(__tmp23Line);
                    StringBuilder __tmp24 = new StringBuilder();
                    __tmp24.Append(op.Name);
                    using(StreamReader __tmp24Reader = new StreamReader(this.__ToStream(__tmp24.ToString())))
                    {
                        bool __tmp24_first = true;
                        bool __tmp24_last = __tmp24Reader.EndOfStream;
                        while(__tmp24_first || !__tmp24_last)
                        {
                            __tmp24_first = false;
                            string __tmp24Line = __tmp24Reader.ReadLine();
                            __tmp24_last = __tmp24Reader.EndOfStream;
                            if (__tmp24Line != null) __out.Append(__tmp24Line);
                            if (!__tmp24_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp25Line = "_OutputMessage\"/>"; //162:105
                    if (__tmp25Line != null) __out.Append(__tmp25Line);
                    __out.AppendLine(false); //162:122
                    var __loop10_results = 
                        (from ex in __Enumerate((op.Exceptions).GetEnumerator()) //163:8
                        select new { ex = ex}
                        ).ToList(); //163:3
                    int __loop10_iteration = 0;
                    foreach (var __tmp26 in __loop10_results)
                    {
                        ++__loop10_iteration;
                        var ex = __tmp26.ex;
                        string __tmp28Line = "	<wsdl:fault wsaw:action=\""; //164:1
                        if (__tmp28Line != null) __out.Append(__tmp28Line);
                        StringBuilder __tmp29 = new StringBuilder();
                        __tmp29.Append(action + "Fault/" + ex.Name);
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
                        string __tmp30Line = "\" message=\""; //164:56
                        if (__tmp30Line != null) __out.Append(__tmp30Line);
                        StringBuilder __tmp31 = new StringBuilder();
                        __tmp31.Append(intf.Namespace.Prefix);
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
                        string __tmp32Line = ":"; //164:90
                        if (__tmp32Line != null) __out.Append(__tmp32Line);
                        StringBuilder __tmp33 = new StringBuilder();
                        __tmp33.Append(intf.Name);
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
                        string __tmp34Line = "_"; //164:102
                        if (__tmp34Line != null) __out.Append(__tmp34Line);
                        StringBuilder __tmp35 = new StringBuilder();
                        __tmp35.Append(ex.Name);
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
                        string __tmp36Line = "_FaultMessage\" name=\""; //164:112
                        if (__tmp36Line != null) __out.Append(__tmp36Line);
                        StringBuilder __tmp37 = new StringBuilder();
                        __tmp37.Append(ex.Name);
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
                        string __tmp38Line = "\"/>"; //164:142
                        if (__tmp38Line != null) __out.Append(__tmp38Line);
                        __out.AppendLine(false); //164:145
                    }
                }
                __out.Append("</wsdl:operation>"); //167:1
                __out.AppendLine(false); //167:18
            }
            return __out.ToString();
        }

        public string GenerateWsdlBindingPart(Namespace ns) //171:1
        {
            StringBuilder __out = new StringBuilder();
            var __loop11_results = 
                (from __loop11_var1 in __Enumerate((ns.Declarations).GetEnumerator()) //172:7
                from endp in __Enumerate((__loop11_var1).GetEnumerator()).OfType<Endpoint>() //172:24
                select new { __loop11_var1 = __loop11_var1, endp = endp}
                ).ToList(); //172:2
            int __loop11_iteration = 0;
            foreach (var __tmp1 in __loop11_results)
            {
                ++__loop11_iteration;
                var __loop11_var1 = __tmp1.__loop11_var1;
                var endp = __tmp1.endp;
                StringBuilder __tmp3 = new StringBuilder();
                __tmp3.Append(GenerateWsdlBinding(endp));
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
                        __out.AppendLine(false); //173:28
                    }
                }
            }
            return __out.ToString();
        }

        public string GenerateWsdlBinding(Endpoint endp) //177:1
        {
            StringBuilder __out = new StringBuilder();
            __out.AppendLine(true); //178:1
            string soapPrefix = endp.Binding.GetSoapPrefix(); //179:2
            string __tmp2Line = "<wsdl:binding name=\""; //180:1
            if (__tmp2Line != null) __out.Append(__tmp2Line);
            StringBuilder __tmp3 = new StringBuilder();
            __tmp3.Append(endp.Interface.Name);
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
            string __tmp4Line = "_"; //180:42
            if (__tmp4Line != null) __out.Append(__tmp4Line);
            StringBuilder __tmp5 = new StringBuilder();
            __tmp5.Append(endp.Binding.Name);
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
            string __tmp6Line = "_Binding\" type=\""; //180:62
            if (__tmp6Line != null) __out.Append(__tmp6Line);
            StringBuilder __tmp7 = new StringBuilder();
            __tmp7.Append(endp.Interface.Namespace.Prefix);
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
            string __tmp8Line = ":"; //180:111
            if (__tmp8Line != null) __out.Append(__tmp8Line);
            StringBuilder __tmp9 = new StringBuilder();
            __tmp9.Append(endp.Interface.Name);
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
            string __tmp10Line = "\">"; //180:133
            if (__tmp10Line != null) __out.Append(__tmp10Line);
            __out.AppendLine(false); //180:135
            if (endp.Binding.HasPolicy()) //181:3
            {
                string __tmp12Line = "	<wsp:PolicyReference URI=\"#"; //182:1
                if (__tmp12Line != null) __out.Append(__tmp12Line);
                StringBuilder __tmp13 = new StringBuilder();
                __tmp13.Append(endp.Binding.Name);
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
                string __tmp14Line = "_Policy\"/>"; //182:48
                if (__tmp14Line != null) __out.Append(__tmp14Line);
                __out.AppendLine(false); //182:58
            }
            if (soapPrefix != null) //184:3
            {
                if (endp.Binding.Transport is HttpTransportBindingElement) //185:4
                {
                    string __tmp16Line = "	<"; //186:1
                    if (__tmp16Line != null) __out.Append(__tmp16Line);
                    StringBuilder __tmp17 = new StringBuilder();
                    __tmp17.Append(soapPrefix);
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
                    string __tmp18Line = ":binding style=\""; //186:15
                    if (__tmp18Line != null) __out.Append(__tmp18Line);
                    StringBuilder __tmp19 = new StringBuilder();
                    __tmp19.Append(endp.Binding.GetWsdlSoapDocRpcStyle());
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
                    string __tmp20Line = "\" transport=\"http://schemas.xmlsoap.org/soap/http\"/>"; //186:70
                    if (__tmp20Line != null) __out.Append(__tmp20Line);
                    __out.AppendLine(false); //186:122
                }
                else //187:4
                {
                    string __tmp22Line = "	<"; //188:1
                    if (__tmp22Line != null) __out.Append(__tmp22Line);
                    StringBuilder __tmp23 = new StringBuilder();
                    __tmp23.Append(soapPrefix);
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
                    string __tmp24Line = ":binding style=\""; //188:15
                    if (__tmp24Line != null) __out.Append(__tmp24Line);
                    StringBuilder __tmp25 = new StringBuilder();
                    __tmp25.Append(endp.Binding.GetWsdlSoapDocRpcStyle());
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
                    string __tmp26Line = "\"/>"; //188:70
                    if (__tmp26Line != null) __out.Append(__tmp26Line);
                    __out.AppendLine(false); //188:73
                }
            }
            var __loop12_results = 
                (from op in __Enumerate((endp.Interface.Operations).GetEnumerator()) //191:8
                select new { op = op}
                ).ToList(); //191:3
            int __loop12_iteration = 0;
            foreach (var __tmp27 in __loop12_results)
            {
                ++__loop12_iteration;
                var op = __tmp27.op;
                string action = op.Action != null ? op.Action : endp.Interface.Namespace.UriWithSlash() + endp.Interface.Name + "/" + op.Name; //192:4
                string __tmp29Line = "	<wsdl:operation name=\""; //193:1
                if (__tmp29Line != null) __out.Append(__tmp29Line);
                StringBuilder __tmp30 = new StringBuilder();
                __tmp30.Append(op.Name);
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
                string __tmp31Line = "\">"; //193:33
                if (__tmp31Line != null) __out.Append(__tmp31Line);
                __out.AppendLine(false); //193:35
                if (soapPrefix != null) //194:4
                {
                    string __tmp33Line = "		<"; //195:1
                    if (__tmp33Line != null) __out.Append(__tmp33Line);
                    StringBuilder __tmp34 = new StringBuilder();
                    __tmp34.Append(soapPrefix);
                    using(StreamReader __tmp34Reader = new StreamReader(this.__ToStream(__tmp34.ToString())))
                    {
                        bool __tmp34_first = true;
                        bool __tmp34_last = __tmp34Reader.EndOfStream;
                        while(__tmp34_first || !__tmp34_last)
                        {
                            __tmp34_first = false;
                            string __tmp34Line = __tmp34Reader.ReadLine();
                            __tmp34_last = __tmp34Reader.EndOfStream;
                            if (__tmp34Line != null) __out.Append(__tmp34Line);
                            if (!__tmp34_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp35Line = ":operation style=\""; //195:16
                    if (__tmp35Line != null) __out.Append(__tmp35Line);
                    StringBuilder __tmp36 = new StringBuilder();
                    __tmp36.Append(endp.Binding.GetWsdlSoapDocRpcStyle());
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
                    string __tmp37Line = "\" soapAction=\""; //195:73
                    if (__tmp37Line != null) __out.Append(__tmp37Line);
                    StringBuilder __tmp38 = new StringBuilder();
                    __tmp38.Append(action);
                    using(StreamReader __tmp38Reader = new StreamReader(this.__ToStream(__tmp38.ToString())))
                    {
                        bool __tmp38_first = true;
                        bool __tmp38_last = __tmp38Reader.EndOfStream;
                        while(__tmp38_first || !__tmp38_last)
                        {
                            __tmp38_first = false;
                            string __tmp38Line = __tmp38Reader.ReadLine();
                            __tmp38_last = __tmp38Reader.EndOfStream;
                            if (__tmp38Line != null) __out.Append(__tmp38Line);
                            if (!__tmp38_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp39Line = "\"/>"; //195:95
                    if (__tmp39Line != null) __out.Append(__tmp39Line);
                    __out.AppendLine(false); //195:98
                }
                __out.Append("		<wsdl:input>"); //197:1
                __out.AppendLine(false); //197:15
                if (endp.Binding.HasOperationPolicy()) //198:4
                {
                    string __tmp41Line = "			<wsp:PolicyReference URI=\"#"; //199:1
                    if (__tmp41Line != null) __out.Append(__tmp41Line);
                    StringBuilder __tmp42 = new StringBuilder();
                    __tmp42.Append(endp.Binding.Name);
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
                    string __tmp43Line = "_Input_Policy\"/>"; //199:50
                    if (__tmp43Line != null) __out.Append(__tmp43Line);
                    __out.AppendLine(false); //199:66
                }
                if (soapPrefix != null) //201:4
                {
                    string __tmp45Line = "			<"; //202:1
                    if (__tmp45Line != null) __out.Append(__tmp45Line);
                    StringBuilder __tmp46 = new StringBuilder();
                    __tmp46.Append(soapPrefix);
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
                    string __tmp47Line = ":body use=\""; //202:17
                    if (__tmp47Line != null) __out.Append(__tmp47Line);
                    StringBuilder __tmp48 = new StringBuilder();
                    __tmp48.Append(endp.Binding.GetWsdlSoapEncLitStyle());
                    using(StreamReader __tmp48Reader = new StreamReader(this.__ToStream(__tmp48.ToString())))
                    {
                        bool __tmp48_first = true;
                        bool __tmp48_last = __tmp48Reader.EndOfStream;
                        while(__tmp48_first || !__tmp48_last)
                        {
                            __tmp48_first = false;
                            string __tmp48Line = __tmp48Reader.ReadLine();
                            __tmp48_last = __tmp48Reader.EndOfStream;
                            if (__tmp48Line != null) __out.Append(__tmp48Line);
                            if (!__tmp48_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp49Line = "\"/>"; //202:67
                    if (__tmp49Line != null) __out.Append(__tmp49Line);
                    __out.AppendLine(false); //202:70
                }
                __out.Append("		</wsdl:input>"); //204:1
                __out.AppendLine(false); //204:16
                if (!op.Result.IsOneway) //205:4
                {
                    __out.Append("		<wsdl:output>"); //206:1
                    __out.AppendLine(false); //206:16
                    if (endp.Binding.HasOperationPolicy()) //207:5
                    {
                        string __tmp51Line = "			<wsp:PolicyReference URI=\"#"; //208:1
                        if (__tmp51Line != null) __out.Append(__tmp51Line);
                        StringBuilder __tmp52 = new StringBuilder();
                        __tmp52.Append(endp.Binding.Name);
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
                        string __tmp53Line = "_Output_Policy\"/>"; //208:50
                        if (__tmp53Line != null) __out.Append(__tmp53Line);
                        __out.AppendLine(false); //208:67
                    }
                    if (soapPrefix != null) //210:5
                    {
                        string __tmp55Line = "			<"; //211:1
                        if (__tmp55Line != null) __out.Append(__tmp55Line);
                        StringBuilder __tmp56 = new StringBuilder();
                        __tmp56.Append(soapPrefix);
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
                        string __tmp57Line = ":body use=\""; //211:17
                        if (__tmp57Line != null) __out.Append(__tmp57Line);
                        StringBuilder __tmp58 = new StringBuilder();
                        __tmp58.Append(endp.Binding.GetWsdlSoapEncLitStyle());
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
                        string __tmp59Line = "\"/>"; //211:67
                        if (__tmp59Line != null) __out.Append(__tmp59Line);
                        __out.AppendLine(false); //211:70
                    }
                    __out.Append("		</wsdl:output>"); //213:1
                    __out.AppendLine(false); //213:17
                    var __loop13_results = 
                        (from ex in __Enumerate((op.Exceptions).GetEnumerator()) //214:10
                        select new { ex = ex}
                        ).ToList(); //214:5
                    int __loop13_iteration = 0;
                    foreach (var __tmp60 in __loop13_results)
                    {
                        ++__loop13_iteration;
                        var ex = __tmp60.ex;
                        string __tmp62Line = "		<wsdl:fault name=\""; //215:1
                        if (__tmp62Line != null) __out.Append(__tmp62Line);
                        StringBuilder __tmp63 = new StringBuilder();
                        __tmp63.Append(ex.Name);
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
                        string __tmp64Line = "\">"; //215:30
                        if (__tmp64Line != null) __out.Append(__tmp64Line);
                        __out.AppendLine(false); //215:32
                        if (soapPrefix != null) //216:5
                        {
                            string __tmp66Line = "			<"; //217:1
                            if (__tmp66Line != null) __out.Append(__tmp66Line);
                            StringBuilder __tmp67 = new StringBuilder();
                            __tmp67.Append(soapPrefix);
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
                            string __tmp68Line = ":fault name=\""; //217:17
                            if (__tmp68Line != null) __out.Append(__tmp68Line);
                            StringBuilder __tmp69 = new StringBuilder();
                            __tmp69.Append(ex.Name);
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
                            string __tmp70Line = "\" use=\""; //217:39
                            if (__tmp70Line != null) __out.Append(__tmp70Line);
                            StringBuilder __tmp71 = new StringBuilder();
                            __tmp71.Append(endp.Binding.GetWsdlSoapEncLitStyle());
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
                            string __tmp72Line = "\"/>"; //217:85
                            if (__tmp72Line != null) __out.Append(__tmp72Line);
                            __out.AppendLine(false); //217:88
                        }
                        __out.Append("		</wsdl:fault>"); //219:1
                        __out.AppendLine(false); //219:16
                    }
                }
                __out.Append("	</wsdl:operation>"); //222:1
                __out.AppendLine(false); //222:19
            }
            __out.Append("</wsdl:binding>"); //224:1
            __out.AppendLine(false); //224:16
            return __out.ToString();
        }

        public string GenerateWsdlEndpointPart(Namespace ns) //227:1
        {
            StringBuilder __out = new StringBuilder();
            var __loop14_results = 
                (from __loop14_var1 in __Enumerate((ns.Declarations).GetEnumerator()) //228:7
                from endp in __Enumerate((__loop14_var1).GetEnumerator()).OfType<Endpoint>() //228:24
                select new { __loop14_var1 = __loop14_var1, endp = endp}
                ).ToList(); //228:2
            int __loop14_iteration = 0;
            foreach (var __tmp1 in __loop14_results)
            {
                ++__loop14_iteration;
                var __loop14_var1 = __tmp1.__loop14_var1;
                var endp = __tmp1.endp;
                StringBuilder __tmp3 = new StringBuilder();
                __tmp3.Append(GenerateWsdlEndpoint(endp));
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
                        __out.AppendLine(false); //229:29
                    }
                }
            }
            return __out.ToString();
        }

        public string GenerateWsdlEndpoint(Endpoint endp) //233:1
        {
            StringBuilder __out = new StringBuilder();
            __out.AppendLine(true); //234:1
            string soapPrefix = endp.Binding.GetSoapPrefix(); //235:2
            string __tmp2Line = "<wsdl:service name=\""; //236:1
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
            string __tmp4Line = "\">"; //236:32
            if (__tmp4Line != null) __out.Append(__tmp4Line);
            __out.AppendLine(false); //236:34
            string __tmp6Line = "	<wsdl:port name=\""; //237:1
            if (__tmp6Line != null) __out.Append(__tmp6Line);
            StringBuilder __tmp7 = new StringBuilder();
            __tmp7.Append(endp.Interface.Name);
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
            string __tmp8Line = "_"; //237:40
            if (__tmp8Line != null) __out.Append(__tmp8Line);
            StringBuilder __tmp9 = new StringBuilder();
            __tmp9.Append(endp.Binding.Name);
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
            string __tmp10Line = "_Port\" binding=\""; //237:60
            if (__tmp10Line != null) __out.Append(__tmp10Line);
            StringBuilder __tmp11 = new StringBuilder();
            __tmp11.Append(endp.Namespace.Prefix);
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
            string __tmp12Line = ":"; //237:99
            if (__tmp12Line != null) __out.Append(__tmp12Line);
            StringBuilder __tmp13 = new StringBuilder();
            __tmp13.Append(endp.Interface.Name);
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
            string __tmp14Line = "_"; //237:121
            if (__tmp14Line != null) __out.Append(__tmp14Line);
            StringBuilder __tmp15 = new StringBuilder();
            __tmp15.Append(endp.Binding.Name);
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
            string __tmp16Line = "_Binding\">"; //237:141
            if (__tmp16Line != null) __out.Append(__tmp16Line);
            __out.AppendLine(false); //237:151
            if (soapPrefix != null) //238:3
            {
                string __tmp18Line = "		<"; //239:1
                if (__tmp18Line != null) __out.Append(__tmp18Line);
                StringBuilder __tmp19 = new StringBuilder();
                __tmp19.Append(soapPrefix);
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
                string __tmp20Line = ":address location=\""; //239:16
                if (__tmp20Line != null) __out.Append(__tmp20Line);
                StringBuilder __tmp21 = new StringBuilder();
                __tmp21.Append(endp.Address);
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
                string __tmp22Line = "\"/>"; //239:49
                if (__tmp22Line != null) __out.Append(__tmp22Line);
                __out.AppendLine(false); //239:52
            }
            __out.Append("	</wsdl:port>"); //241:1
            __out.AppendLine(false); //241:14
            __out.Append("</wsdl:service>"); //242:1
            __out.AppendLine(false); //242:16
            return __out.ToString();
        }

        public string GenerateWsdlPoliciesPart(Namespace ns) //247:1
        {
            StringBuilder __out = new StringBuilder();
            var __loop15_results = 
                (from __loop15_var1 in __Enumerate((ns.Declarations).GetEnumerator()) //248:7
                from binding in __Enumerate((__loop15_var1).GetEnumerator()).OfType<Binding>() //248:24
                select new { __loop15_var1 = __loop15_var1, binding = binding}
                ).ToList(); //248:2
            int __loop15_iteration = 0;
            foreach (var __tmp1 in __loop15_results)
            {
                ++__loop15_iteration;
                var __loop15_var1 = __tmp1.__loop15_var1;
                var binding = __tmp1.binding;
                StringBuilder __tmp3 = new StringBuilder();
                __tmp3.Append(GenerateWsdlPolicy(binding));
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
                        __out.AppendLine(false); //249:30
                    }
                }
            }
            return __out.ToString();
        }

        public string GenerateWsdlPolicy(Binding binding) //253:1
        {
            StringBuilder __out = new StringBuilder();
            if (binding.HasPolicy()) //254:2
            {
                __out.AppendLine(true); //255:1
                string __tmp2Line = "<wsp:Policy wsu:Id=\""; //256:1
                if (__tmp2Line != null) __out.Append(__tmp2Line);
                StringBuilder __tmp3 = new StringBuilder();
                __tmp3.Append(binding.Name);
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
                string __tmp4Line = "_Policy\">"; //256:35
                if (__tmp4Line != null) __out.Append(__tmp4Line);
                __out.AppendLine(false); //256:44
                string __tmp5Prefix = "	"; //257:1
                StringBuilder __tmp6 = new StringBuilder();
                __tmp6.Append(GenerateHttpsPolicy(binding));
                using(StreamReader __tmp6Reader = new StreamReader(this.__ToStream(__tmp6.ToString())))
                {
                    bool __tmp6_first = true;
                    bool __tmp6_last = __tmp6Reader.EndOfStream;
                    while(__tmp6_first || !__tmp6_last)
                    {
                        __tmp6_first = false;
                        string __tmp6Line = __tmp6Reader.ReadLine();
                        __tmp6_last = __tmp6Reader.EndOfStream;
                        __out.Append(__tmp5Prefix);
                        if (__tmp6Line != null) __out.Append(__tmp6Line);
                        if (!__tmp6_last) __out.AppendLine(true);
                        __out.AppendLine(false); //257:32
                    }
                }
                string __tmp7Prefix = "	"; //258:1
                StringBuilder __tmp8 = new StringBuilder();
                __tmp8.Append(GenerateMtomPolicy(binding));
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
                        __out.AppendLine(false); //258:31
                    }
                }
                string __tmp9Prefix = "	"; //259:1
                StringBuilder __tmp10 = new StringBuilder();
                __tmp10.Append(GenerateAddressingPolicy(binding));
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
                        __out.AppendLine(false); //259:37
                    }
                }
                __out.Append("</wsp:Policy>"); //260:1
                __out.AppendLine(false); //260:14
            }
            return __out.ToString();
        }

        public string GenerateHttpsPolicy(Binding binding) //264:1
        {
            StringBuilder __out = new StringBuilder();
            if (binding.Transport is HttpTransportBindingElement && ((HttpTransportBindingElement)binding.Transport).Ssl) //265:2
            {
                __out.Append("<sp:TransportBinding>"); //266:1
                __out.AppendLine(false); //266:22
                __out.Append("	<wsp:Policy>"); //267:1
                __out.AppendLine(false); //267:14
                __out.Append("		<sp:TransportToken>"); //268:1
                __out.AppendLine(false); //268:22
                __out.Append("			<wsp:Policy>"); //269:1
                __out.AppendLine(false); //269:16
                if (((HttpTransportBindingElement)binding.Transport).ClientAuthentication) //270:5
                {
                    __out.Append("				<sp:HttpsToken RequireClientCertificate=\"true\"/>"); //271:1
                    __out.AppendLine(false); //271:53
                }
                else //272:5
                {
                    __out.Append("				<sp:HttpsToken RequireClientCertificate=\"false\"/>"); //273:1
                    __out.AppendLine(false); //273:54
                }
                __out.Append("			</wsp:Policy>"); //275:1
                __out.AppendLine(false); //275:17
                __out.Append("		</sp:TransportToken>"); //276:1
                __out.AppendLine(false); //276:23
                __out.Append("		<sp:AlgorithmSuite>"); //277:1
                __out.AppendLine(false); //277:22
                __out.Append("			<wsp:Policy>"); //278:1
                __out.AppendLine(false); //278:16
                __out.Append("				<sp:Basic256/>"); //279:1
                __out.AppendLine(false); //279:19
                __out.Append("			</wsp:Policy>"); //280:1
                __out.AppendLine(false); //280:17
                __out.Append("		</sp:AlgorithmSuite>"); //281:1
                __out.AppendLine(false); //281:23
                __out.Append("		<sp:Layout>"); //282:1
                __out.AppendLine(false); //282:14
                __out.Append("			<wsp:Policy>"); //283:1
                __out.AppendLine(false); //283:16
                __out.Append("				<sp:Strict/>"); //284:1
                __out.AppendLine(false); //284:17
                __out.Append("			</wsp:Policy>"); //285:1
                __out.AppendLine(false); //285:17
                __out.Append("		</sp:Layout> "); //286:1
                __out.AppendLine(false); //286:16
                __out.Append("	</wsp:Policy>"); //287:1
                __out.AppendLine(false); //287:15
                __out.Append("</sp:TransportBinding>"); //288:1
                __out.AppendLine(false); //288:23
            }
            return __out.ToString();
        }

        public string GenerateMtomPolicy(Binding binding) //292:1
        {
            StringBuilder __out = new StringBuilder();
            if ((from __loop16_var1 in __Enumerate((binding).GetEnumerator()) //293:13
            from Encodings in __Enumerate((__loop16_var1.Encodings).GetEnumerator()) //293:22
            from enc in __Enumerate((Encodings).GetEnumerator()).OfType<SoapEncodingBindingElement>() //293:33
            where enc.Mtom //293:72
            select new { __loop16_var1 = __loop16_var1, Encodings = Encodings, enc = enc}
            ).GetEnumerator().MoveNext()) //293:2
            {
                __out.Append("<wsoma:OptimizedMimeSerialization/>"); //294:1
                __out.AppendLine(false); //294:36
            }
            return __out.ToString();
        }

        public string GenerateAddressingPolicy(Binding binding) //298:1
        {
            StringBuilder __out = new StringBuilder();
            if ((from __loop17_var1 in __Enumerate((binding).GetEnumerator()) //299:13
            from Protocols in __Enumerate((__loop17_var1.Protocols).GetEnumerator()) //299:22
            from __loop17_var2 in __Enumerate((Protocols).GetEnumerator()).OfType<WsAddressingBindingElement>() //299:33
            select new { __loop17_var1 = __loop17_var1, Protocols = Protocols, __loop17_var2 = __loop17_var2}
            ).GetEnumerator().MoveNext()) //299:2
            {
                __out.Append("<wsam:Addressing/>"); //300:1
                __out.AppendLine(false); //300:19
            }
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
