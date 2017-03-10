using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetaDslx.Languages.Soal.Symbols; //4:1

namespace MetaDslx.Languages.Soal.Generator //1:1
{
    using __Hidden_WsdlGenerator_120336761;
    namespace __Hidden_WsdlGenerator_120336761
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

        private XsdGenerator XsdGenerator = new XsdGenerator(); //5:1

        public __Properties Properties { get; private set; } //7:1

        public class __Properties //7:1
        {
            internal __Properties()
            {
                this.SingleFileWsdl = false; //8:24
                this.SeparateXsdWsdl = false; //9:25
            }
            public bool SingleFileWsdl { get; set; } //8:2
            public bool SeparateXsdWsdl { get; set; } //9:2
        }

        public string Generate(Namespace ns) //12:1
        {
            StringBuilder __out = new StringBuilder();
            __out.Append("<?xml version=\"1.0\" encoding=\"utf-8\"?>"); //13:1
            __out.AppendLine(false); //13:39
            bool __tmp2_outputWritten = false;
            string __tmp3_line = "<wsdl:definitions targetNamespace=\""; //14:1
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
            string __tmp5_line = "\"  "; //14:44
            if (!string.IsNullOrEmpty(__tmp5_line))
            {
                __out.Append(__tmp5_line);
                __tmp2_outputWritten = true;
            }
            if (__tmp2_outputWritten) __out.AppendLine(true);
            if (__tmp2_outputWritten)
            {
                __out.AppendLine(false); //14:47
            }
            bool __tmp7_outputWritten = false;
            string __tmp8_line = "	xmlns:"; //15:1
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
            string __tmp10_line = "=\""; //15:19
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
            string __tmp12_line = "\""; //15:29
            if (!string.IsNullOrEmpty(__tmp12_line))
            {
                __out.Append(__tmp12_line);
                __tmp7_outputWritten = true;
            }
            if (__tmp7_outputWritten) __out.AppendLine(true);
            if (__tmp7_outputWritten)
            {
                __out.AppendLine(false); //15:30
            }
            var __loop1_results = 
                (from ins in __Enumerate((ns.GetImportedNamespaces()).GetEnumerator()) //16:8
                select new { ins = ins}
                ).ToList(); //16:3
            for (int __loop1_iteration = 0; __loop1_iteration < __loop1_results.Count; ++__loop1_iteration)
            {
                var __tmp13 = __loop1_results[__loop1_iteration];
                var ins = __tmp13.ins;
                bool __tmp15_outputWritten = false;
                string __tmp16_line = "	xmlns:"; //17:1
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
                string __tmp18_line = "=\""; //17:20
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
                string __tmp20_line = "\""; //17:31
                if (!string.IsNullOrEmpty(__tmp20_line))
                {
                    __out.Append(__tmp20_line);
                    __tmp15_outputWritten = true;
                }
                if (__tmp15_outputWritten) __out.AppendLine(true);
                if (__tmp15_outputWritten)
                {
                    __out.AppendLine(false); //17:32
                }
            }
            __out.Append("	xmlns:xs=\"http://www.w3.org/2001/XMLSchema\" "); //19:1
            __out.AppendLine(false); //19:46
            __out.Append("	xmlns:wsdl=\"http://schemas.xmlsoap.org/wsdl/\""); //20:1
            __out.AppendLine(false); //20:47
            __out.Append("	xmlns:soap=\"http://schemas.xmlsoap.org/wsdl/soap/\""); //21:1
            __out.AppendLine(false); //21:52
            __out.Append("	xmlns:soap12=\"http://schemas.xmlsoap.org/wsdl/soap12/\""); //22:1
            __out.AppendLine(false); //22:56
            __out.Append("	xmlns:wsaw=\"http://www.w3.org/2006/05/addressing/wsdl\""); //23:1
            __out.AppendLine(false); //23:56
            __out.Append("	xmlns:wsp=\"http://www.w3.org/ns/ws-policy\""); //24:1
            __out.AppendLine(false); //24:44
            __out.Append("	xmlns:wsu=\"http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd\""); //25:1
            __out.AppendLine(false); //25:96
            __out.Append("	xmlns:wsoma=\"http://schemas.xmlsoap.org/ws/2004/09/policy/optimizedmimeserialization\""); //26:1
            __out.AppendLine(false); //26:87
            __out.Append("	xmlns:wsa=\"http://www.w3.org/2005/08/addressing\" "); //27:1
            __out.AppendLine(false); //27:51
            __out.Append("	xmlns:wsam=\"http://www.w3.org/2007/05/addressing/metadata\""); //28:1
            __out.AppendLine(false); //28:60
            __out.Append("	xmlns:wsrmp=\"http://docs.oasis-open.org/ws-rx/wsrmp/200702\""); //29:1
            __out.AppendLine(false); //29:61
            __out.Append("	xmlns:wsat=\"http://schemas.xmlsoap.org/ws/2004/10/wsat\""); //30:1
            __out.AppendLine(false); //30:57
            __out.Append("	xmlns:sp=\"http://docs.oasis-open.org/ws-sx/ws-securitypolicy/200702\""); //31:1
            __out.AppendLine(false); //31:70
            __out.Append("	xmlns:wst=\"http://docs.oasis-open.org/ws-sx/ws-trust/200512\""); //32:1
            __out.AppendLine(false); //32:62
            __out.Append("	xmlns:wsx=\"http://schemas.xmlsoap.org/ws/2004/09/mex\""); //33:1
            __out.AppendLine(false); //33:55
            __out.Append(">"); //34:1
            __out.AppendLine(false); //34:2
            bool __tmp22_outputWritten = false;
            string __tmp21Prefix = "	"; //35:1
            StringBuilder __tmp23 = new StringBuilder();
            __tmp23.Append(GenerateWsdlPoliciesPart(ns));
            using(StreamReader __tmp23Reader = new StreamReader(this.__ToStream(__tmp23.ToString())))
            {
                bool __tmp23_last = __tmp23Reader.EndOfStream;
                while(!__tmp23_last)
                {
                    string __tmp23_line = __tmp23Reader.ReadLine();
                    __tmp23_last = __tmp23Reader.EndOfStream;
                    if (!string.IsNullOrEmpty(__tmp21Prefix))
                    {
                        __out.Append(__tmp21Prefix);
                        __tmp22_outputWritten = true;
                    }
                    if ((__tmp23_last && !string.IsNullOrEmpty(__tmp23_line)) || (!__tmp23_last && __tmp23_line != null))
                    {
                        __out.Append(__tmp23_line);
                        __tmp22_outputWritten = true;
                    }
                    if (!__tmp23_last || __tmp22_outputWritten) __out.AppendLine(true);
                }
            }
            if (__tmp22_outputWritten)
            {
                __out.AppendLine(false); //35:32
            }
            bool __tmp25_outputWritten = false;
            string __tmp24Prefix = "	"; //36:1
            StringBuilder __tmp26 = new StringBuilder();
            __tmp26.Append(GenerateWsdlTypesPart(ns));
            using(StreamReader __tmp26Reader = new StreamReader(this.__ToStream(__tmp26.ToString())))
            {
                bool __tmp26_last = __tmp26Reader.EndOfStream;
                while(!__tmp26_last)
                {
                    string __tmp26_line = __tmp26Reader.ReadLine();
                    __tmp26_last = __tmp26Reader.EndOfStream;
                    if (!string.IsNullOrEmpty(__tmp24Prefix))
                    {
                        __out.Append(__tmp24Prefix);
                        __tmp25_outputWritten = true;
                    }
                    if ((__tmp26_last && !string.IsNullOrEmpty(__tmp26_line)) || (!__tmp26_last && __tmp26_line != null))
                    {
                        __out.Append(__tmp26_line);
                        __tmp25_outputWritten = true;
                    }
                    if (!__tmp26_last || __tmp25_outputWritten) __out.AppendLine(true);
                }
            }
            if (__tmp25_outputWritten)
            {
                __out.AppendLine(false); //36:29
            }
            bool __tmp28_outputWritten = false;
            string __tmp27Prefix = "	"; //37:1
            StringBuilder __tmp29 = new StringBuilder();
            __tmp29.Append(GenerateWsdlAbstractPart(ns));
            using(StreamReader __tmp29Reader = new StreamReader(this.__ToStream(__tmp29.ToString())))
            {
                bool __tmp29_last = __tmp29Reader.EndOfStream;
                while(!__tmp29_last)
                {
                    string __tmp29_line = __tmp29Reader.ReadLine();
                    __tmp29_last = __tmp29Reader.EndOfStream;
                    if (!string.IsNullOrEmpty(__tmp27Prefix))
                    {
                        __out.Append(__tmp27Prefix);
                        __tmp28_outputWritten = true;
                    }
                    if ((__tmp29_last && !string.IsNullOrEmpty(__tmp29_line)) || (!__tmp29_last && __tmp29_line != null))
                    {
                        __out.Append(__tmp29_line);
                        __tmp28_outputWritten = true;
                    }
                    if (!__tmp29_last || __tmp28_outputWritten) __out.AppendLine(true);
                }
            }
            if (__tmp28_outputWritten)
            {
                __out.AppendLine(false); //37:32
            }
            bool __tmp31_outputWritten = false;
            string __tmp30Prefix = "	"; //38:1
            StringBuilder __tmp32 = new StringBuilder();
            __tmp32.Append(GenerateWsdlBindingPart(ns));
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
                __out.AppendLine(false); //38:31
            }
            bool __tmp34_outputWritten = false;
            string __tmp33Prefix = "	"; //39:1
            StringBuilder __tmp35 = new StringBuilder();
            __tmp35.Append(GenerateWsdlEndpointPart(ns));
            using(StreamReader __tmp35Reader = new StreamReader(this.__ToStream(__tmp35.ToString())))
            {
                bool __tmp35_last = __tmp35Reader.EndOfStream;
                while(!__tmp35_last)
                {
                    string __tmp35_line = __tmp35Reader.ReadLine();
                    __tmp35_last = __tmp35Reader.EndOfStream;
                    if (!string.IsNullOrEmpty(__tmp33Prefix))
                    {
                        __out.Append(__tmp33Prefix);
                        __tmp34_outputWritten = true;
                    }
                    if ((__tmp35_last && !string.IsNullOrEmpty(__tmp35_line)) || (!__tmp35_last && __tmp35_line != null))
                    {
                        __out.Append(__tmp35_line);
                        __tmp34_outputWritten = true;
                    }
                    if (!__tmp35_last || __tmp34_outputWritten) __out.AppendLine(true);
                }
            }
            if (__tmp34_outputWritten)
            {
                __out.AppendLine(false); //39:32
            }
            __out.Append("</wsdl:definitions>"); //40:1
            __out.AppendLine(false); //40:20
            return __out.ToString();
        }

        public string GenerateWsdlTypesPart(Namespace ns) //44:1
        {
            StringBuilder __out = new StringBuilder();
            __out.AppendLine(true); //45:1
            __out.Append("<wsdl:types>"); //46:1
            __out.AppendLine(false); //46:13
            if (Properties.SingleFileWsdl) //47:2
            {
                bool __tmp2_outputWritten = false;
                StringBuilder __tmp3 = new StringBuilder();
                __tmp3.Append(XsdGenerator.Generate(ns));
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
                    __out.AppendLine(false); //48:28
                }
            }
            else //49:2
            {
                __out.Append("	<xs:schema>"); //50:1
                __out.AppendLine(false); //50:13
                if (Properties.SeparateXsdWsdl) //51:4
                {
                    bool __tmp5_outputWritten = false;
                    string __tmp6_line = "		<xs:import namespace=\""; //52:1
                    if (!string.IsNullOrEmpty(__tmp6_line))
                    {
                        __out.Append(__tmp6_line);
                        __tmp5_outputWritten = true;
                    }
                    StringBuilder __tmp7 = new StringBuilder();
                    __tmp7.Append(ns.Uri);
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
                    string __tmp8_line = "\" schemaLocation=\"../xsd/"; //52:33
                    if (!string.IsNullOrEmpty(__tmp8_line))
                    {
                        __out.Append(__tmp8_line);
                        __tmp5_outputWritten = true;
                    }
                    StringBuilder __tmp9 = new StringBuilder();
                    __tmp9.Append(ns.FullName);
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
                            if (!__tmp9_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp10_line = ".xsd\"/>"; //52:71
                    if (!string.IsNullOrEmpty(__tmp10_line))
                    {
                        __out.Append(__tmp10_line);
                        __tmp5_outputWritten = true;
                    }
                    if (__tmp5_outputWritten) __out.AppendLine(true);
                    if (__tmp5_outputWritten)
                    {
                        __out.AppendLine(false); //52:78
                    }
                    var __loop2_results = 
                        (from ins in __Enumerate((ns.GetImportedNamespaces()).GetEnumerator()) //53:10
                        select new { ins = ins}
                        ).ToList(); //53:5
                    for (int __loop2_iteration = 0; __loop2_iteration < __loop2_results.Count; ++__loop2_iteration)
                    {
                        var __tmp11 = __loop2_results[__loop2_iteration];
                        var ins = __tmp11.ins;
                        bool __tmp13_outputWritten = false;
                        string __tmp14_line = "		<xs:import namespace=\""; //54:1
                        if (!string.IsNullOrEmpty(__tmp14_line))
                        {
                            __out.Append(__tmp14_line);
                            __tmp13_outputWritten = true;
                        }
                        StringBuilder __tmp15 = new StringBuilder();
                        __tmp15.Append(ins.Uri);
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
                        string __tmp16_line = "\" schemaLocation=\"../xsd/"; //54:34
                        if (!string.IsNullOrEmpty(__tmp16_line))
                        {
                            __out.Append(__tmp16_line);
                            __tmp13_outputWritten = true;
                        }
                        StringBuilder __tmp17 = new StringBuilder();
                        __tmp17.Append(ins.FullName);
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
                        string __tmp18_line = ".xsd\"/>"; //54:73
                        if (!string.IsNullOrEmpty(__tmp18_line))
                        {
                            __out.Append(__tmp18_line);
                            __tmp13_outputWritten = true;
                        }
                        if (__tmp13_outputWritten) __out.AppendLine(true);
                        if (__tmp13_outputWritten)
                        {
                            __out.AppendLine(false); //54:80
                        }
                    }
                }
                else //56:4
                {
                    bool __tmp20_outputWritten = false;
                    string __tmp21_line = "		<xs:import namespace=\""; //57:1
                    if (!string.IsNullOrEmpty(__tmp21_line))
                    {
                        __out.Append(__tmp21_line);
                        __tmp20_outputWritten = true;
                    }
                    StringBuilder __tmp22 = new StringBuilder();
                    __tmp22.Append(ns.Uri);
                    using(StreamReader __tmp22Reader = new StreamReader(this.__ToStream(__tmp22.ToString())))
                    {
                        bool __tmp22_last = __tmp22Reader.EndOfStream;
                        while(!__tmp22_last)
                        {
                            string __tmp22_line = __tmp22Reader.ReadLine();
                            __tmp22_last = __tmp22Reader.EndOfStream;
                            if ((__tmp22_last && !string.IsNullOrEmpty(__tmp22_line)) || (!__tmp22_last && __tmp22_line != null))
                            {
                                __out.Append(__tmp22_line);
                                __tmp20_outputWritten = true;
                            }
                            if (!__tmp22_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp23_line = "\" schemaLocation=\""; //57:33
                    if (!string.IsNullOrEmpty(__tmp23_line))
                    {
                        __out.Append(__tmp23_line);
                        __tmp20_outputWritten = true;
                    }
                    StringBuilder __tmp24 = new StringBuilder();
                    __tmp24.Append(ns.FullName);
                    using(StreamReader __tmp24Reader = new StreamReader(this.__ToStream(__tmp24.ToString())))
                    {
                        bool __tmp24_last = __tmp24Reader.EndOfStream;
                        while(!__tmp24_last)
                        {
                            string __tmp24_line = __tmp24Reader.ReadLine();
                            __tmp24_last = __tmp24Reader.EndOfStream;
                            if ((__tmp24_last && !string.IsNullOrEmpty(__tmp24_line)) || (!__tmp24_last && __tmp24_line != null))
                            {
                                __out.Append(__tmp24_line);
                                __tmp20_outputWritten = true;
                            }
                            if (!__tmp24_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp25_line = ".xsd\"/>"; //57:64
                    if (!string.IsNullOrEmpty(__tmp25_line))
                    {
                        __out.Append(__tmp25_line);
                        __tmp20_outputWritten = true;
                    }
                    if (__tmp20_outputWritten) __out.AppendLine(true);
                    if (__tmp20_outputWritten)
                    {
                        __out.AppendLine(false); //57:71
                    }
                    var __loop3_results = 
                        (from ins in __Enumerate((ns.GetImportedNamespaces()).GetEnumerator()) //58:10
                        select new { ins = ins}
                        ).ToList(); //58:5
                    for (int __loop3_iteration = 0; __loop3_iteration < __loop3_results.Count; ++__loop3_iteration)
                    {
                        var __tmp26 = __loop3_results[__loop3_iteration];
                        var ins = __tmp26.ins;
                        bool __tmp28_outputWritten = false;
                        string __tmp29_line = "		<xs:import namespace=\""; //59:1
                        if (!string.IsNullOrEmpty(__tmp29_line))
                        {
                            __out.Append(__tmp29_line);
                            __tmp28_outputWritten = true;
                        }
                        StringBuilder __tmp30 = new StringBuilder();
                        __tmp30.Append(ins.Uri);
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
                                    __tmp28_outputWritten = true;
                                }
                                if (!__tmp30_last) __out.AppendLine(true);
                            }
                        }
                        string __tmp31_line = "\" schemaLocation=\""; //59:34
                        if (!string.IsNullOrEmpty(__tmp31_line))
                        {
                            __out.Append(__tmp31_line);
                            __tmp28_outputWritten = true;
                        }
                        StringBuilder __tmp32 = new StringBuilder();
                        __tmp32.Append(ins.FullName);
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
                                    __tmp28_outputWritten = true;
                                }
                                if (!__tmp32_last) __out.AppendLine(true);
                            }
                        }
                        string __tmp33_line = ".xsd\"/>"; //59:66
                        if (!string.IsNullOrEmpty(__tmp33_line))
                        {
                            __out.Append(__tmp33_line);
                            __tmp28_outputWritten = true;
                        }
                        if (__tmp28_outputWritten) __out.AppendLine(true);
                        if (__tmp28_outputWritten)
                        {
                            __out.AppendLine(false); //59:73
                        }
                    }
                }
                __out.Append("	</xs:schema>"); //62:1
                __out.AppendLine(false); //62:14
            }
            __out.Append("</wsdl:types>"); //64:1
            __out.AppendLine(false); //64:14
            return __out.ToString();
        }

        public string GenerateWsdlAbstractPart(Namespace ns) //67:1
        {
            StringBuilder __out = new StringBuilder();
            var __loop4_results = 
                (from __loop4_var1 in __Enumerate((ns.Declarations).GetEnumerator()) //68:7
                from intf in __Enumerate((__loop4_var1).GetEnumerator()).OfType<Interface>() //68:24
                select new { __loop4_var1 = __loop4_var1, intf = intf}
                ).ToList(); //68:2
            for (int __loop4_iteration = 0; __loop4_iteration < __loop4_results.Count; ++__loop4_iteration)
            {
                var __tmp1 = __loop4_results[__loop4_iteration];
                var __loop4_var1 = __tmp1.__loop4_var1;
                var intf = __tmp1.intf;
                bool __tmp3_outputWritten = false;
                StringBuilder __tmp4 = new StringBuilder();
                __tmp4.Append(GenerateWsdlAbstractPart(intf));
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
                    __out.AppendLine(false); //69:33
                }
            }
            return __out.ToString();
        }

        public string GenerateWsdlAbstractPart(Interface intf) //73:1
        {
            StringBuilder __out = new StringBuilder();
            bool __tmp2_outputWritten = false;
            StringBuilder __tmp3 = new StringBuilder();
            __tmp3.Append(GenerateMessages(intf));
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
                __out.AppendLine(false); //74:25
            }
            bool __tmp5_outputWritten = false;
            StringBuilder __tmp6 = new StringBuilder();
            __tmp6.Append(GenerateFaultMessages(intf));
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
                __out.AppendLine(false); //75:30
            }
            bool __tmp8_outputWritten = false;
            StringBuilder __tmp9 = new StringBuilder();
            __tmp9.Append(GeneratePortType(intf));
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
                    if (!__tmp9_last || __tmp8_outputWritten) __out.AppendLine(true);
                }
            }
            if (__tmp8_outputWritten)
            {
                __out.AppendLine(false); //76:25
            }
            return __out.ToString();
        }

        public string GenerateMessages(Interface intf) //79:1
        {
            StringBuilder __out = new StringBuilder();
            var __loop5_results = 
                (from __loop5_var1 in __Enumerate((intf.Operations).GetEnumerator()) //80:7
                from op in __Enumerate((__loop5_var1).GetEnumerator()).OfType<Operation>() //80:24
                select new { __loop5_var1 = __loop5_var1, op = op}
                ).ToList(); //80:2
            for (int __loop5_iteration = 0; __loop5_iteration < __loop5_results.Count; ++__loop5_iteration)
            {
                var __tmp1 = __loop5_results[__loop5_iteration];
                var __loop5_var1 = __tmp1.__loop5_var1;
                var op = __tmp1.op;
                if (intf.HasAnnotation(SoalAnnotations.Rpc)) //81:3
                {
                    __out.AppendLine(true); //82:1
                    bool __tmp3_outputWritten = false;
                    string __tmp4_line = "<wsdl:message name=\""; //83:1
                    if (!string.IsNullOrEmpty(__tmp4_line))
                    {
                        __out.Append(__tmp4_line);
                        __tmp3_outputWritten = true;
                    }
                    StringBuilder __tmp5 = new StringBuilder();
                    __tmp5.Append(intf.Name);
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
                    string __tmp6_line = "_"; //83:32
                    if (!string.IsNullOrEmpty(__tmp6_line))
                    {
                        __out.Append(__tmp6_line);
                        __tmp3_outputWritten = true;
                    }
                    StringBuilder __tmp7 = new StringBuilder();
                    __tmp7.Append(op.Name);
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
                                __tmp3_outputWritten = true;
                            }
                            if (!__tmp7_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp8_line = "_InputMessage\">"; //83:42
                    if (!string.IsNullOrEmpty(__tmp8_line))
                    {
                        __out.Append(__tmp8_line);
                        __tmp3_outputWritten = true;
                    }
                    if (__tmp3_outputWritten) __out.AppendLine(true);
                    if (__tmp3_outputWritten)
                    {
                        __out.AppendLine(false); //83:57
                    }
                    var __loop6_results = 
                        (from __loop6_var1 in __Enumerate((op).GetEnumerator()) //84:9
                        from param in __Enumerate((__loop6_var1.Parameters).GetEnumerator()) //84:13
                        select new { __loop6_var1 = __loop6_var1, param = param}
                        ).ToList(); //84:4
                    for (int __loop6_iteration = 0; __loop6_iteration < __loop6_results.Count; ++__loop6_iteration)
                    {
                        var __tmp9 = __loop6_results[__loop6_iteration];
                        var __loop6_var1 = __tmp9.__loop6_var1;
                        var param = __tmp9.param;
                        if (param.Type.IsArrayType() && param.Type.GetCoreType() != SoalInstance.Byte) //85:5
                        {
                            bool __tmp11_outputWritten = false;
                            string __tmp12_line = "	<wsdl:part name=\""; //86:1
                            if (!string.IsNullOrEmpty(__tmp12_line))
                            {
                                __out.Append(__tmp12_line);
                                __tmp11_outputWritten = true;
                            }
                            StringBuilder __tmp13 = new StringBuilder();
                            __tmp13.Append(param.Name);
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
                            string __tmp14_line = "\" type=\""; //86:31
                            if (!string.IsNullOrEmpty(__tmp14_line))
                            {
                                __out.Append(__tmp14_line);
                                __tmp11_outputWritten = true;
                            }
                            StringBuilder __tmp15 = new StringBuilder();
                            __tmp15.Append(intf.Namespace.Prefix);
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
                            string __tmp16_line = ":"; //86:62
                            if (!string.IsNullOrEmpty(__tmp16_line))
                            {
                                __out.Append(__tmp16_line);
                                __tmp11_outputWritten = true;
                            }
                            StringBuilder __tmp17 = new StringBuilder();
                            __tmp17.Append(op.Name + param.Name.ToPascalCase());
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
                                        __tmp11_outputWritten = true;
                                    }
                                    if (!__tmp17_last) __out.AppendLine(true);
                                }
                            }
                            string __tmp18_line = "\"/>"; //86:100
                            if (!string.IsNullOrEmpty(__tmp18_line))
                            {
                                __out.Append(__tmp18_line);
                                __tmp11_outputWritten = true;
                            }
                            if (__tmp11_outputWritten) __out.AppendLine(true);
                            if (__tmp11_outputWritten)
                            {
                                __out.AppendLine(false); //86:103
                            }
                        }
                        else //87:5
                        {
                            bool __tmp20_outputWritten = false;
                            string __tmp21_line = "	<wsdl:part name=\""; //88:1
                            if (!string.IsNullOrEmpty(__tmp21_line))
                            {
                                __out.Append(__tmp21_line);
                                __tmp20_outputWritten = true;
                            }
                            StringBuilder __tmp22 = new StringBuilder();
                            __tmp22.Append(param.Name);
                            using(StreamReader __tmp22Reader = new StreamReader(this.__ToStream(__tmp22.ToString())))
                            {
                                bool __tmp22_last = __tmp22Reader.EndOfStream;
                                while(!__tmp22_last)
                                {
                                    string __tmp22_line = __tmp22Reader.ReadLine();
                                    __tmp22_last = __tmp22Reader.EndOfStream;
                                    if ((__tmp22_last && !string.IsNullOrEmpty(__tmp22_line)) || (!__tmp22_last && __tmp22_line != null))
                                    {
                                        __out.Append(__tmp22_line);
                                        __tmp20_outputWritten = true;
                                    }
                                    if (!__tmp22_last) __out.AppendLine(true);
                                }
                            }
                            string __tmp23_line = "\" type=\""; //88:31
                            if (!string.IsNullOrEmpty(__tmp23_line))
                            {
                                __out.Append(__tmp23_line);
                                __tmp20_outputWritten = true;
                            }
                            StringBuilder __tmp24 = new StringBuilder();
                            __tmp24.Append(param.Type.GetNamespace(intf.Namespace).Prefix);
                            using(StreamReader __tmp24Reader = new StreamReader(this.__ToStream(__tmp24.ToString())))
                            {
                                bool __tmp24_last = __tmp24Reader.EndOfStream;
                                while(!__tmp24_last)
                                {
                                    string __tmp24_line = __tmp24Reader.ReadLine();
                                    __tmp24_last = __tmp24Reader.EndOfStream;
                                    if ((__tmp24_last && !string.IsNullOrEmpty(__tmp24_line)) || (!__tmp24_last && __tmp24_line != null))
                                    {
                                        __out.Append(__tmp24_line);
                                        __tmp20_outputWritten = true;
                                    }
                                    if (!__tmp24_last) __out.AppendLine(true);
                                }
                            }
                            string __tmp25_line = ":"; //88:87
                            if (!string.IsNullOrEmpty(__tmp25_line))
                            {
                                __out.Append(__tmp25_line);
                                __tmp20_outputWritten = true;
                            }
                            StringBuilder __tmp26 = new StringBuilder();
                            __tmp26.Append(param.Type.GetXsdName());
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
                                        __tmp20_outputWritten = true;
                                    }
                                    if (!__tmp26_last) __out.AppendLine(true);
                                }
                            }
                            string __tmp27_line = "\"/>"; //88:113
                            if (!string.IsNullOrEmpty(__tmp27_line))
                            {
                                __out.Append(__tmp27_line);
                                __tmp20_outputWritten = true;
                            }
                            if (__tmp20_outputWritten) __out.AppendLine(true);
                            if (__tmp20_outputWritten)
                            {
                                __out.AppendLine(false); //88:116
                            }
                        }
                    }
                    __out.Append("</wsdl:message>"); //91:1
                    __out.AppendLine(false); //91:16
                    if (!op.Result.IsOneway) //92:4
                    {
                        __out.AppendLine(true); //93:1
                        bool __tmp29_outputWritten = false;
                        string __tmp30_line = "<wsdl:message name=\""; //94:1
                        if (!string.IsNullOrEmpty(__tmp30_line))
                        {
                            __out.Append(__tmp30_line);
                            __tmp29_outputWritten = true;
                        }
                        StringBuilder __tmp31 = new StringBuilder();
                        __tmp31.Append(intf.Name);
                        using(StreamReader __tmp31Reader = new StreamReader(this.__ToStream(__tmp31.ToString())))
                        {
                            bool __tmp31_last = __tmp31Reader.EndOfStream;
                            while(!__tmp31_last)
                            {
                                string __tmp31_line = __tmp31Reader.ReadLine();
                                __tmp31_last = __tmp31Reader.EndOfStream;
                                if ((__tmp31_last && !string.IsNullOrEmpty(__tmp31_line)) || (!__tmp31_last && __tmp31_line != null))
                                {
                                    __out.Append(__tmp31_line);
                                    __tmp29_outputWritten = true;
                                }
                                if (!__tmp31_last) __out.AppendLine(true);
                            }
                        }
                        string __tmp32_line = "_"; //94:32
                        if (!string.IsNullOrEmpty(__tmp32_line))
                        {
                            __out.Append(__tmp32_line);
                            __tmp29_outputWritten = true;
                        }
                        StringBuilder __tmp33 = new StringBuilder();
                        __tmp33.Append(op.Name);
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
                                    __tmp29_outputWritten = true;
                                }
                                if (!__tmp33_last) __out.AppendLine(true);
                            }
                        }
                        string __tmp34_line = "_OutputMessage\">"; //94:42
                        if (!string.IsNullOrEmpty(__tmp34_line))
                        {
                            __out.Append(__tmp34_line);
                            __tmp29_outputWritten = true;
                        }
                        if (__tmp29_outputWritten) __out.AppendLine(true);
                        if (__tmp29_outputWritten)
                        {
                            __out.AppendLine(false); //94:58
                        }
                        if (op.Result.Type != SoalInstance.Void) //95:5
                        {
                            if (op.Result.Type.IsArrayType() && op.Result.Type.GetCoreType() != SoalInstance.Byte) //96:6
                            {
                                bool __tmp36_outputWritten = false;
                                string __tmp37_line = "	<wsdl:part name=\"result\" type=\""; //97:1
                                if (!string.IsNullOrEmpty(__tmp37_line))
                                {
                                    __out.Append(__tmp37_line);
                                    __tmp36_outputWritten = true;
                                }
                                StringBuilder __tmp38 = new StringBuilder();
                                __tmp38.Append(intf.Namespace.Prefix);
                                using(StreamReader __tmp38Reader = new StreamReader(this.__ToStream(__tmp38.ToString())))
                                {
                                    bool __tmp38_last = __tmp38Reader.EndOfStream;
                                    while(!__tmp38_last)
                                    {
                                        string __tmp38_line = __tmp38Reader.ReadLine();
                                        __tmp38_last = __tmp38Reader.EndOfStream;
                                        if ((__tmp38_last && !string.IsNullOrEmpty(__tmp38_line)) || (!__tmp38_last && __tmp38_line != null))
                                        {
                                            __out.Append(__tmp38_line);
                                            __tmp36_outputWritten = true;
                                        }
                                        if (!__tmp38_last) __out.AppendLine(true);
                                    }
                                }
                                string __tmp39_line = ":"; //97:56
                                if (!string.IsNullOrEmpty(__tmp39_line))
                                {
                                    __out.Append(__tmp39_line);
                                    __tmp36_outputWritten = true;
                                }
                                StringBuilder __tmp40 = new StringBuilder();
                                __tmp40.Append(op.Name + "Response");
                                using(StreamReader __tmp40Reader = new StreamReader(this.__ToStream(__tmp40.ToString())))
                                {
                                    bool __tmp40_last = __tmp40Reader.EndOfStream;
                                    while(!__tmp40_last)
                                    {
                                        string __tmp40_line = __tmp40Reader.ReadLine();
                                        __tmp40_last = __tmp40Reader.EndOfStream;
                                        if ((__tmp40_last && !string.IsNullOrEmpty(__tmp40_line)) || (!__tmp40_last && __tmp40_line != null))
                                        {
                                            __out.Append(__tmp40_line);
                                            __tmp36_outputWritten = true;
                                        }
                                        if (!__tmp40_last) __out.AppendLine(true);
                                    }
                                }
                                string __tmp41_line = "\"/>"; //97:79
                                if (!string.IsNullOrEmpty(__tmp41_line))
                                {
                                    __out.Append(__tmp41_line);
                                    __tmp36_outputWritten = true;
                                }
                                if (__tmp36_outputWritten) __out.AppendLine(true);
                                if (__tmp36_outputWritten)
                                {
                                    __out.AppendLine(false); //97:82
                                }
                            }
                            else //98:6
                            {
                                bool __tmp43_outputWritten = false;
                                string __tmp44_line = "	<wsdl:part name=\"result\" type=\""; //99:1
                                if (!string.IsNullOrEmpty(__tmp44_line))
                                {
                                    __out.Append(__tmp44_line);
                                    __tmp43_outputWritten = true;
                                }
                                StringBuilder __tmp45 = new StringBuilder();
                                __tmp45.Append(op.Result.Type.GetNamespace(intf.Namespace).Prefix);
                                using(StreamReader __tmp45Reader = new StreamReader(this.__ToStream(__tmp45.ToString())))
                                {
                                    bool __tmp45_last = __tmp45Reader.EndOfStream;
                                    while(!__tmp45_last)
                                    {
                                        string __tmp45_line = __tmp45Reader.ReadLine();
                                        __tmp45_last = __tmp45Reader.EndOfStream;
                                        if ((__tmp45_last && !string.IsNullOrEmpty(__tmp45_line)) || (!__tmp45_last && __tmp45_line != null))
                                        {
                                            __out.Append(__tmp45_line);
                                            __tmp43_outputWritten = true;
                                        }
                                        if (!__tmp45_last) __out.AppendLine(true);
                                    }
                                }
                                string __tmp46_line = ":"; //99:85
                                if (!string.IsNullOrEmpty(__tmp46_line))
                                {
                                    __out.Append(__tmp46_line);
                                    __tmp43_outputWritten = true;
                                }
                                StringBuilder __tmp47 = new StringBuilder();
                                __tmp47.Append(op.Result.Type.GetXsdName());
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
                                            __tmp43_outputWritten = true;
                                        }
                                        if (!__tmp47_last) __out.AppendLine(true);
                                    }
                                }
                                string __tmp48_line = "\"/>"; //99:115
                                if (!string.IsNullOrEmpty(__tmp48_line))
                                {
                                    __out.Append(__tmp48_line);
                                    __tmp43_outputWritten = true;
                                }
                                if (__tmp43_outputWritten) __out.AppendLine(true);
                                if (__tmp43_outputWritten)
                                {
                                    __out.AppendLine(false); //99:118
                                }
                            }
                        }
                        __out.Append("</wsdl:message>"); //102:1
                        __out.AppendLine(false); //102:16
                    }
                }
                else if (intf.HasAnnotation(SoalAnnotations.NoWrap)) //104:3
                {
                    __out.AppendLine(true); //105:1
                    bool __tmp50_outputWritten = false;
                    string __tmp51_line = "<wsdl:message name=\""; //106:1
                    if (!string.IsNullOrEmpty(__tmp51_line))
                    {
                        __out.Append(__tmp51_line);
                        __tmp50_outputWritten = true;
                    }
                    StringBuilder __tmp52 = new StringBuilder();
                    __tmp52.Append(intf.Name);
                    using(StreamReader __tmp52Reader = new StreamReader(this.__ToStream(__tmp52.ToString())))
                    {
                        bool __tmp52_last = __tmp52Reader.EndOfStream;
                        while(!__tmp52_last)
                        {
                            string __tmp52_line = __tmp52Reader.ReadLine();
                            __tmp52_last = __tmp52Reader.EndOfStream;
                            if ((__tmp52_last && !string.IsNullOrEmpty(__tmp52_line)) || (!__tmp52_last && __tmp52_line != null))
                            {
                                __out.Append(__tmp52_line);
                                __tmp50_outputWritten = true;
                            }
                            if (!__tmp52_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp53_line = "_"; //106:32
                    if (!string.IsNullOrEmpty(__tmp53_line))
                    {
                        __out.Append(__tmp53_line);
                        __tmp50_outputWritten = true;
                    }
                    StringBuilder __tmp54 = new StringBuilder();
                    __tmp54.Append(op.Name);
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
                                __tmp50_outputWritten = true;
                            }
                            if (!__tmp54_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp55_line = "_InputMessage\">"; //106:42
                    if (!string.IsNullOrEmpty(__tmp55_line))
                    {
                        __out.Append(__tmp55_line);
                        __tmp50_outputWritten = true;
                    }
                    if (__tmp50_outputWritten) __out.AppendLine(true);
                    if (__tmp50_outputWritten)
                    {
                        __out.AppendLine(false); //106:57
                    }
                    var __loop7_results = 
                        (from __loop7_var1 in __Enumerate((op).GetEnumerator()) //107:9
                        from param in __Enumerate((__loop7_var1.Parameters).GetEnumerator()) //107:13
                        select new { __loop7_var1 = __loop7_var1, param = param}
                        ).ToList(); //107:4
                    for (int __loop7_iteration = 0; __loop7_iteration < __loop7_results.Count; ++__loop7_iteration)
                    {
                        var __tmp56 = __loop7_results[__loop7_iteration];
                        var __loop7_var1 = __tmp56.__loop7_var1;
                        var param = __tmp56.param;
                        bool __tmp58_outputWritten = false;
                        string __tmp59_line = "	<wsdl:part name=\""; //108:1
                        if (!string.IsNullOrEmpty(__tmp59_line))
                        {
                            __out.Append(__tmp59_line);
                            __tmp58_outputWritten = true;
                        }
                        StringBuilder __tmp60 = new StringBuilder();
                        __tmp60.Append(param.Name);
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
                        string __tmp61_line = "\" element=\""; //108:31
                        if (!string.IsNullOrEmpty(__tmp61_line))
                        {
                            __out.Append(__tmp61_line);
                            __tmp58_outputWritten = true;
                        }
                        StringBuilder __tmp62 = new StringBuilder();
                        __tmp62.Append(intf.Namespace.Prefix);
                        using(StreamReader __tmp62Reader = new StreamReader(this.__ToStream(__tmp62.ToString())))
                        {
                            bool __tmp62_last = __tmp62Reader.EndOfStream;
                            while(!__tmp62_last)
                            {
                                string __tmp62_line = __tmp62Reader.ReadLine();
                                __tmp62_last = __tmp62Reader.EndOfStream;
                                if ((__tmp62_last && !string.IsNullOrEmpty(__tmp62_line)) || (!__tmp62_last && __tmp62_line != null))
                                {
                                    __out.Append(__tmp62_line);
                                    __tmp58_outputWritten = true;
                                }
                                if (!__tmp62_last) __out.AppendLine(true);
                            }
                        }
                        string __tmp63_line = ":"; //108:65
                        if (!string.IsNullOrEmpty(__tmp63_line))
                        {
                            __out.Append(__tmp63_line);
                            __tmp58_outputWritten = true;
                        }
                        StringBuilder __tmp64 = new StringBuilder();
                        __tmp64.Append(op.Name);
                        using(StreamReader __tmp64Reader = new StreamReader(this.__ToStream(__tmp64.ToString())))
                        {
                            bool __tmp64_last = __tmp64Reader.EndOfStream;
                            while(!__tmp64_last)
                            {
                                string __tmp64_line = __tmp64Reader.ReadLine();
                                __tmp64_last = __tmp64Reader.EndOfStream;
                                if ((__tmp64_last && !string.IsNullOrEmpty(__tmp64_line)) || (!__tmp64_last && __tmp64_line != null))
                                {
                                    __out.Append(__tmp64_line);
                                    __tmp58_outputWritten = true;
                                }
                                if (!__tmp64_last) __out.AppendLine(true);
                            }
                        }
                        StringBuilder __tmp65 = new StringBuilder();
                        __tmp65.Append(param.Name.ToPascalCase());
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
                                    __tmp58_outputWritten = true;
                                }
                                if (!__tmp65_last) __out.AppendLine(true);
                            }
                        }
                        string __tmp66_line = "\"/>"; //108:102
                        if (!string.IsNullOrEmpty(__tmp66_line))
                        {
                            __out.Append(__tmp66_line);
                            __tmp58_outputWritten = true;
                        }
                        if (__tmp58_outputWritten) __out.AppendLine(true);
                        if (__tmp58_outputWritten)
                        {
                            __out.AppendLine(false); //108:105
                        }
                    }
                    __out.Append("</wsdl:message>"); //110:1
                    __out.AppendLine(false); //110:16
                    if (!op.Result.IsOneway) //111:4
                    {
                        __out.AppendLine(true); //112:1
                        bool __tmp68_outputWritten = false;
                        string __tmp69_line = "<wsdl:message name=\""; //113:1
                        if (!string.IsNullOrEmpty(__tmp69_line))
                        {
                            __out.Append(__tmp69_line);
                            __tmp68_outputWritten = true;
                        }
                        StringBuilder __tmp70 = new StringBuilder();
                        __tmp70.Append(intf.Name);
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
                                    __tmp68_outputWritten = true;
                                }
                                if (!__tmp70_last) __out.AppendLine(true);
                            }
                        }
                        string __tmp71_line = "_"; //113:32
                        if (!string.IsNullOrEmpty(__tmp71_line))
                        {
                            __out.Append(__tmp71_line);
                            __tmp68_outputWritten = true;
                        }
                        StringBuilder __tmp72 = new StringBuilder();
                        __tmp72.Append(op.Name);
                        using(StreamReader __tmp72Reader = new StreamReader(this.__ToStream(__tmp72.ToString())))
                        {
                            bool __tmp72_last = __tmp72Reader.EndOfStream;
                            while(!__tmp72_last)
                            {
                                string __tmp72_line = __tmp72Reader.ReadLine();
                                __tmp72_last = __tmp72Reader.EndOfStream;
                                if ((__tmp72_last && !string.IsNullOrEmpty(__tmp72_line)) || (!__tmp72_last && __tmp72_line != null))
                                {
                                    __out.Append(__tmp72_line);
                                    __tmp68_outputWritten = true;
                                }
                                if (!__tmp72_last) __out.AppendLine(true);
                            }
                        }
                        string __tmp73_line = "_OutputMessage\">"; //113:42
                        if (!string.IsNullOrEmpty(__tmp73_line))
                        {
                            __out.Append(__tmp73_line);
                            __tmp68_outputWritten = true;
                        }
                        if (__tmp68_outputWritten) __out.AppendLine(true);
                        if (__tmp68_outputWritten)
                        {
                            __out.AppendLine(false); //113:58
                        }
                        if (op.Result.Type != SoalInstance.Void) //114:5
                        {
                            bool __tmp75_outputWritten = false;
                            string __tmp76_line = "	<wsdl:part name=\"result\" element=\""; //115:1
                            if (!string.IsNullOrEmpty(__tmp76_line))
                            {
                                __out.Append(__tmp76_line);
                                __tmp75_outputWritten = true;
                            }
                            StringBuilder __tmp77 = new StringBuilder();
                            __tmp77.Append(intf.Namespace.Prefix);
                            using(StreamReader __tmp77Reader = new StreamReader(this.__ToStream(__tmp77.ToString())))
                            {
                                bool __tmp77_last = __tmp77Reader.EndOfStream;
                                while(!__tmp77_last)
                                {
                                    string __tmp77_line = __tmp77Reader.ReadLine();
                                    __tmp77_last = __tmp77Reader.EndOfStream;
                                    if ((__tmp77_last && !string.IsNullOrEmpty(__tmp77_line)) || (!__tmp77_last && __tmp77_line != null))
                                    {
                                        __out.Append(__tmp77_line);
                                        __tmp75_outputWritten = true;
                                    }
                                    if (!__tmp77_last) __out.AppendLine(true);
                                }
                            }
                            string __tmp78_line = ":"; //115:59
                            if (!string.IsNullOrEmpty(__tmp78_line))
                            {
                                __out.Append(__tmp78_line);
                                __tmp75_outputWritten = true;
                            }
                            StringBuilder __tmp79 = new StringBuilder();
                            __tmp79.Append(op.Name);
                            using(StreamReader __tmp79Reader = new StreamReader(this.__ToStream(__tmp79.ToString())))
                            {
                                bool __tmp79_last = __tmp79Reader.EndOfStream;
                                while(!__tmp79_last)
                                {
                                    string __tmp79_line = __tmp79Reader.ReadLine();
                                    __tmp79_last = __tmp79Reader.EndOfStream;
                                    if ((__tmp79_last && !string.IsNullOrEmpty(__tmp79_line)) || (!__tmp79_last && __tmp79_line != null))
                                    {
                                        __out.Append(__tmp79_line);
                                        __tmp75_outputWritten = true;
                                    }
                                    if (!__tmp79_last) __out.AppendLine(true);
                                }
                            }
                            string __tmp80_line = "Response\"/>"; //115:69
                            if (!string.IsNullOrEmpty(__tmp80_line))
                            {
                                __out.Append(__tmp80_line);
                                __tmp75_outputWritten = true;
                            }
                            if (__tmp75_outputWritten) __out.AppendLine(true);
                            if (__tmp75_outputWritten)
                            {
                                __out.AppendLine(false); //115:80
                            }
                        }
                        __out.Append("</wsdl:message>"); //117:1
                        __out.AppendLine(false); //117:16
                    }
                }
                else //119:3
                {
                    __out.AppendLine(true); //120:1
                    bool __tmp82_outputWritten = false;
                    string __tmp83_line = "<wsdl:message name=\""; //121:1
                    if (!string.IsNullOrEmpty(__tmp83_line))
                    {
                        __out.Append(__tmp83_line);
                        __tmp82_outputWritten = true;
                    }
                    StringBuilder __tmp84 = new StringBuilder();
                    __tmp84.Append(intf.Name);
                    using(StreamReader __tmp84Reader = new StreamReader(this.__ToStream(__tmp84.ToString())))
                    {
                        bool __tmp84_last = __tmp84Reader.EndOfStream;
                        while(!__tmp84_last)
                        {
                            string __tmp84_line = __tmp84Reader.ReadLine();
                            __tmp84_last = __tmp84Reader.EndOfStream;
                            if ((__tmp84_last && !string.IsNullOrEmpty(__tmp84_line)) || (!__tmp84_last && __tmp84_line != null))
                            {
                                __out.Append(__tmp84_line);
                                __tmp82_outputWritten = true;
                            }
                            if (!__tmp84_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp85_line = "_"; //121:32
                    if (!string.IsNullOrEmpty(__tmp85_line))
                    {
                        __out.Append(__tmp85_line);
                        __tmp82_outputWritten = true;
                    }
                    StringBuilder __tmp86 = new StringBuilder();
                    __tmp86.Append(op.Name);
                    using(StreamReader __tmp86Reader = new StreamReader(this.__ToStream(__tmp86.ToString())))
                    {
                        bool __tmp86_last = __tmp86Reader.EndOfStream;
                        while(!__tmp86_last)
                        {
                            string __tmp86_line = __tmp86Reader.ReadLine();
                            __tmp86_last = __tmp86Reader.EndOfStream;
                            if ((__tmp86_last && !string.IsNullOrEmpty(__tmp86_line)) || (!__tmp86_last && __tmp86_line != null))
                            {
                                __out.Append(__tmp86_line);
                                __tmp82_outputWritten = true;
                            }
                            if (!__tmp86_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp87_line = "_InputMessage\">"; //121:42
                    if (!string.IsNullOrEmpty(__tmp87_line))
                    {
                        __out.Append(__tmp87_line);
                        __tmp82_outputWritten = true;
                    }
                    if (__tmp82_outputWritten) __out.AppendLine(true);
                    if (__tmp82_outputWritten)
                    {
                        __out.AppendLine(false); //121:57
                    }
                    bool __tmp89_outputWritten = false;
                    string __tmp90_line = "	<wsdl:part name=\"parameters\" element=\""; //122:1
                    if (!string.IsNullOrEmpty(__tmp90_line))
                    {
                        __out.Append(__tmp90_line);
                        __tmp89_outputWritten = true;
                    }
                    StringBuilder __tmp91 = new StringBuilder();
                    __tmp91.Append(intf.Namespace.Prefix);
                    using(StreamReader __tmp91Reader = new StreamReader(this.__ToStream(__tmp91.ToString())))
                    {
                        bool __tmp91_last = __tmp91Reader.EndOfStream;
                        while(!__tmp91_last)
                        {
                            string __tmp91_line = __tmp91Reader.ReadLine();
                            __tmp91_last = __tmp91Reader.EndOfStream;
                            if ((__tmp91_last && !string.IsNullOrEmpty(__tmp91_line)) || (!__tmp91_last && __tmp91_line != null))
                            {
                                __out.Append(__tmp91_line);
                                __tmp89_outputWritten = true;
                            }
                            if (!__tmp91_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp92_line = ":"; //122:63
                    if (!string.IsNullOrEmpty(__tmp92_line))
                    {
                        __out.Append(__tmp92_line);
                        __tmp89_outputWritten = true;
                    }
                    StringBuilder __tmp93 = new StringBuilder();
                    __tmp93.Append(op.Name);
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
                                __tmp89_outputWritten = true;
                            }
                            if (!__tmp93_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp94_line = "\"/>"; //122:73
                    if (!string.IsNullOrEmpty(__tmp94_line))
                    {
                        __out.Append(__tmp94_line);
                        __tmp89_outputWritten = true;
                    }
                    if (__tmp89_outputWritten) __out.AppendLine(true);
                    if (__tmp89_outputWritten)
                    {
                        __out.AppendLine(false); //122:76
                    }
                    __out.Append("</wsdl:message>"); //123:1
                    __out.AppendLine(false); //123:16
                    if (!op.Result.IsOneway) //124:4
                    {
                        __out.AppendLine(true); //125:1
                        bool __tmp96_outputWritten = false;
                        string __tmp97_line = "<wsdl:message name=\""; //126:1
                        if (!string.IsNullOrEmpty(__tmp97_line))
                        {
                            __out.Append(__tmp97_line);
                            __tmp96_outputWritten = true;
                        }
                        StringBuilder __tmp98 = new StringBuilder();
                        __tmp98.Append(intf.Name);
                        using(StreamReader __tmp98Reader = new StreamReader(this.__ToStream(__tmp98.ToString())))
                        {
                            bool __tmp98_last = __tmp98Reader.EndOfStream;
                            while(!__tmp98_last)
                            {
                                string __tmp98_line = __tmp98Reader.ReadLine();
                                __tmp98_last = __tmp98Reader.EndOfStream;
                                if ((__tmp98_last && !string.IsNullOrEmpty(__tmp98_line)) || (!__tmp98_last && __tmp98_line != null))
                                {
                                    __out.Append(__tmp98_line);
                                    __tmp96_outputWritten = true;
                                }
                                if (!__tmp98_last) __out.AppendLine(true);
                            }
                        }
                        string __tmp99_line = "_"; //126:32
                        if (!string.IsNullOrEmpty(__tmp99_line))
                        {
                            __out.Append(__tmp99_line);
                            __tmp96_outputWritten = true;
                        }
                        StringBuilder __tmp100 = new StringBuilder();
                        __tmp100.Append(op.Name);
                        using(StreamReader __tmp100Reader = new StreamReader(this.__ToStream(__tmp100.ToString())))
                        {
                            bool __tmp100_last = __tmp100Reader.EndOfStream;
                            while(!__tmp100_last)
                            {
                                string __tmp100_line = __tmp100Reader.ReadLine();
                                __tmp100_last = __tmp100Reader.EndOfStream;
                                if ((__tmp100_last && !string.IsNullOrEmpty(__tmp100_line)) || (!__tmp100_last && __tmp100_line != null))
                                {
                                    __out.Append(__tmp100_line);
                                    __tmp96_outputWritten = true;
                                }
                                if (!__tmp100_last) __out.AppendLine(true);
                            }
                        }
                        string __tmp101_line = "_OutputMessage\">"; //126:42
                        if (!string.IsNullOrEmpty(__tmp101_line))
                        {
                            __out.Append(__tmp101_line);
                            __tmp96_outputWritten = true;
                        }
                        if (__tmp96_outputWritten) __out.AppendLine(true);
                        if (__tmp96_outputWritten)
                        {
                            __out.AppendLine(false); //126:58
                        }
                        bool __tmp103_outputWritten = false;
                        string __tmp104_line = "	<wsdl:part name=\"parameters\" element=\""; //127:1
                        if (!string.IsNullOrEmpty(__tmp104_line))
                        {
                            __out.Append(__tmp104_line);
                            __tmp103_outputWritten = true;
                        }
                        StringBuilder __tmp105 = new StringBuilder();
                        __tmp105.Append(intf.Namespace.Prefix);
                        using(StreamReader __tmp105Reader = new StreamReader(this.__ToStream(__tmp105.ToString())))
                        {
                            bool __tmp105_last = __tmp105Reader.EndOfStream;
                            while(!__tmp105_last)
                            {
                                string __tmp105_line = __tmp105Reader.ReadLine();
                                __tmp105_last = __tmp105Reader.EndOfStream;
                                if ((__tmp105_last && !string.IsNullOrEmpty(__tmp105_line)) || (!__tmp105_last && __tmp105_line != null))
                                {
                                    __out.Append(__tmp105_line);
                                    __tmp103_outputWritten = true;
                                }
                                if (!__tmp105_last) __out.AppendLine(true);
                            }
                        }
                        string __tmp106_line = ":"; //127:63
                        if (!string.IsNullOrEmpty(__tmp106_line))
                        {
                            __out.Append(__tmp106_line);
                            __tmp103_outputWritten = true;
                        }
                        StringBuilder __tmp107 = new StringBuilder();
                        __tmp107.Append(op.Name);
                        using(StreamReader __tmp107Reader = new StreamReader(this.__ToStream(__tmp107.ToString())))
                        {
                            bool __tmp107_last = __tmp107Reader.EndOfStream;
                            while(!__tmp107_last)
                            {
                                string __tmp107_line = __tmp107Reader.ReadLine();
                                __tmp107_last = __tmp107Reader.EndOfStream;
                                if ((__tmp107_last && !string.IsNullOrEmpty(__tmp107_line)) || (!__tmp107_last && __tmp107_line != null))
                                {
                                    __out.Append(__tmp107_line);
                                    __tmp103_outputWritten = true;
                                }
                                if (!__tmp107_last) __out.AppendLine(true);
                            }
                        }
                        string __tmp108_line = "Response\"/>"; //127:73
                        if (!string.IsNullOrEmpty(__tmp108_line))
                        {
                            __out.Append(__tmp108_line);
                            __tmp103_outputWritten = true;
                        }
                        if (__tmp103_outputWritten) __out.AppendLine(true);
                        if (__tmp103_outputWritten)
                        {
                            __out.AppendLine(false); //127:84
                        }
                        __out.Append("</wsdl:message>"); //128:1
                        __out.AppendLine(false); //128:16
                    }
                }
            }
            return __out.ToString();
        }

        public string GenerateFaultMessages(Interface intf) //134:1
        {
            StringBuilder __out = new StringBuilder();
            var __loop8_results = 
                (from ex in __Enumerate((intf.GetInterfaceExceptions()).GetEnumerator()) //135:7
                select new { ex = ex}
                ).ToList(); //135:2
            for (int __loop8_iteration = 0; __loop8_iteration < __loop8_results.Count; ++__loop8_iteration)
            {
                var __tmp1 = __loop8_results[__loop8_iteration];
                var ex = __tmp1.ex;
                if (intf.HasAnnotation(SoalAnnotations.Rpc)) //136:3
                {
                    __out.AppendLine(true); //137:1
                    bool __tmp3_outputWritten = false;
                    string __tmp4_line = "<wsdl:message name=\""; //138:1
                    if (!string.IsNullOrEmpty(__tmp4_line))
                    {
                        __out.Append(__tmp4_line);
                        __tmp3_outputWritten = true;
                    }
                    StringBuilder __tmp5 = new StringBuilder();
                    __tmp5.Append(intf.Name);
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
                    string __tmp6_line = "_"; //138:32
                    if (!string.IsNullOrEmpty(__tmp6_line))
                    {
                        __out.Append(__tmp6_line);
                        __tmp3_outputWritten = true;
                    }
                    StringBuilder __tmp7 = new StringBuilder();
                    __tmp7.Append(ex.Name);
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
                                __tmp3_outputWritten = true;
                            }
                            if (!__tmp7_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp8_line = "_FaultMessage\">"; //138:42
                    if (!string.IsNullOrEmpty(__tmp8_line))
                    {
                        __out.Append(__tmp8_line);
                        __tmp3_outputWritten = true;
                    }
                    if (__tmp3_outputWritten) __out.AppendLine(true);
                    if (__tmp3_outputWritten)
                    {
                        __out.AppendLine(false); //138:57
                    }
                    bool __tmp10_outputWritten = false;
                    string __tmp11_line = "	<wsdl:part name=\"fault\" type=\""; //139:1
                    if (!string.IsNullOrEmpty(__tmp11_line))
                    {
                        __out.Append(__tmp11_line);
                        __tmp10_outputWritten = true;
                    }
                    StringBuilder __tmp12 = new StringBuilder();
                    __tmp12.Append(ex.Namespace.Prefix);
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
                                __tmp10_outputWritten = true;
                            }
                            if (!__tmp12_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp13_line = ":"; //139:53
                    if (!string.IsNullOrEmpty(__tmp13_line))
                    {
                        __out.Append(__tmp13_line);
                        __tmp10_outputWritten = true;
                    }
                    StringBuilder __tmp14 = new StringBuilder();
                    __tmp14.Append(ex.Name);
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
                                __tmp10_outputWritten = true;
                            }
                            if (!__tmp14_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp15_line = "\"/>"; //139:63
                    if (!string.IsNullOrEmpty(__tmp15_line))
                    {
                        __out.Append(__tmp15_line);
                        __tmp10_outputWritten = true;
                    }
                    if (__tmp10_outputWritten) __out.AppendLine(true);
                    if (__tmp10_outputWritten)
                    {
                        __out.AppendLine(false); //139:66
                    }
                    __out.Append("</wsdl:message>"); //140:1
                    __out.AppendLine(false); //140:16
                }
                else //141:3
                {
                    __out.AppendLine(true); //142:1
                    bool __tmp17_outputWritten = false;
                    string __tmp18_line = "<wsdl:message name=\""; //143:1
                    if (!string.IsNullOrEmpty(__tmp18_line))
                    {
                        __out.Append(__tmp18_line);
                        __tmp17_outputWritten = true;
                    }
                    StringBuilder __tmp19 = new StringBuilder();
                    __tmp19.Append(intf.Name);
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
                                __tmp17_outputWritten = true;
                            }
                            if (!__tmp19_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp20_line = "_"; //143:32
                    if (!string.IsNullOrEmpty(__tmp20_line))
                    {
                        __out.Append(__tmp20_line);
                        __tmp17_outputWritten = true;
                    }
                    StringBuilder __tmp21 = new StringBuilder();
                    __tmp21.Append(ex.Name);
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
                                __tmp17_outputWritten = true;
                            }
                            if (!__tmp21_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp22_line = "_FaultMessage\">"; //143:42
                    if (!string.IsNullOrEmpty(__tmp22_line))
                    {
                        __out.Append(__tmp22_line);
                        __tmp17_outputWritten = true;
                    }
                    if (__tmp17_outputWritten) __out.AppendLine(true);
                    if (__tmp17_outputWritten)
                    {
                        __out.AppendLine(false); //143:57
                    }
                    bool __tmp24_outputWritten = false;
                    string __tmp25_line = "	<wsdl:part name=\"fault\" element=\""; //144:1
                    if (!string.IsNullOrEmpty(__tmp25_line))
                    {
                        __out.Append(__tmp25_line);
                        __tmp24_outputWritten = true;
                    }
                    StringBuilder __tmp26 = new StringBuilder();
                    __tmp26.Append(ex.Namespace.Prefix);
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
                    string __tmp27_line = ":"; //144:56
                    if (!string.IsNullOrEmpty(__tmp27_line))
                    {
                        __out.Append(__tmp27_line);
                        __tmp24_outputWritten = true;
                    }
                    StringBuilder __tmp28 = new StringBuilder();
                    __tmp28.Append(ex.Name);
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
                    string __tmp29_line = "\"/>"; //144:66
                    if (!string.IsNullOrEmpty(__tmp29_line))
                    {
                        __out.Append(__tmp29_line);
                        __tmp24_outputWritten = true;
                    }
                    if (__tmp24_outputWritten) __out.AppendLine(true);
                    if (__tmp24_outputWritten)
                    {
                        __out.AppendLine(false); //144:69
                    }
                    __out.Append("</wsdl:message>"); //145:1
                    __out.AppendLine(false); //145:16
                }
            }
            return __out.ToString();
        }

        public string GeneratePortType(Interface intf) //150:1
        {
            StringBuilder __out = new StringBuilder();
            __out.AppendLine(true); //151:1
            bool __tmp2_outputWritten = false;
            string __tmp3_line = "<wsdl:portType name=\""; //152:1
            if (!string.IsNullOrEmpty(__tmp3_line))
            {
                __out.Append(__tmp3_line);
                __tmp2_outputWritten = true;
            }
            StringBuilder __tmp4 = new StringBuilder();
            __tmp4.Append(intf.Name);
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
            string __tmp5_line = "\">"; //152:33
            if (!string.IsNullOrEmpty(__tmp5_line))
            {
                __out.Append(__tmp5_line);
                __tmp2_outputWritten = true;
            }
            if (__tmp2_outputWritten) __out.AppendLine(true);
            if (__tmp2_outputWritten)
            {
                __out.AppendLine(false); //152:35
            }
            bool __tmp7_outputWritten = false;
            string __tmp6Prefix = "	"; //153:1
            StringBuilder __tmp8 = new StringBuilder();
            __tmp8.Append(GenerateOperations(intf));
            using(StreamReader __tmp8Reader = new StreamReader(this.__ToStream(__tmp8.ToString())))
            {
                bool __tmp8_last = __tmp8Reader.EndOfStream;
                while(!__tmp8_last)
                {
                    string __tmp8_line = __tmp8Reader.ReadLine();
                    __tmp8_last = __tmp8Reader.EndOfStream;
                    if (!string.IsNullOrEmpty(__tmp6Prefix))
                    {
                        __out.Append(__tmp6Prefix);
                        __tmp7_outputWritten = true;
                    }
                    if ((__tmp8_last && !string.IsNullOrEmpty(__tmp8_line)) || (!__tmp8_last && __tmp8_line != null))
                    {
                        __out.Append(__tmp8_line);
                        __tmp7_outputWritten = true;
                    }
                    if (!__tmp8_last || __tmp7_outputWritten) __out.AppendLine(true);
                }
            }
            if (__tmp7_outputWritten)
            {
                __out.AppendLine(false); //153:28
            }
            __out.Append("</wsdl:portType>"); //154:1
            __out.AppendLine(false); //154:17
            return __out.ToString();
        }

        public string GenerateOperations(Interface intf) //157:1
        {
            StringBuilder __out = new StringBuilder();
            var __loop9_results = 
                (from __loop9_var1 in __Enumerate((intf.Operations).GetEnumerator()) //158:7
                from op in __Enumerate((__loop9_var1).GetEnumerator()).OfType<Operation>() //158:24
                select new { __loop9_var1 = __loop9_var1, op = op}
                ).ToList(); //158:2
            for (int __loop9_iteration = 0; __loop9_iteration < __loop9_results.Count; ++__loop9_iteration)
            {
                var __tmp1 = __loop9_results[__loop9_iteration];
                var __loop9_var1 = __tmp1.__loop9_var1;
                var op = __tmp1.op;
                string action = op.Action != null ? op.Action : intf.Namespace.UriWithSlash() + intf.Name + "/" + op.Name; //159:3
                bool __tmp3_outputWritten = false;
                string __tmp4_line = "<wsdl:operation name=\""; //160:1
                if (!string.IsNullOrEmpty(__tmp4_line))
                {
                    __out.Append(__tmp4_line);
                    __tmp3_outputWritten = true;
                }
                StringBuilder __tmp5 = new StringBuilder();
                __tmp5.Append(op.Name);
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
                string __tmp6_line = "\">"; //160:32
                if (!string.IsNullOrEmpty(__tmp6_line))
                {
                    __out.Append(__tmp6_line);
                    __tmp3_outputWritten = true;
                }
                if (__tmp3_outputWritten) __out.AppendLine(true);
                if (__tmp3_outputWritten)
                {
                    __out.AppendLine(false); //160:34
                }
                bool __tmp8_outputWritten = false;
                string __tmp9_line = "	<wsdl:input wsaw:action=\""; //161:1
                if (!string.IsNullOrEmpty(__tmp9_line))
                {
                    __out.Append(__tmp9_line);
                    __tmp8_outputWritten = true;
                }
                StringBuilder __tmp10 = new StringBuilder();
                __tmp10.Append(action);
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
                string __tmp11_line = "\" message=\""; //161:35
                if (!string.IsNullOrEmpty(__tmp11_line))
                {
                    __out.Append(__tmp11_line);
                    __tmp8_outputWritten = true;
                }
                StringBuilder __tmp12 = new StringBuilder();
                __tmp12.Append(intf.Namespace.Prefix);
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
                string __tmp13_line = ":"; //161:69
                if (!string.IsNullOrEmpty(__tmp13_line))
                {
                    __out.Append(__tmp13_line);
                    __tmp8_outputWritten = true;
                }
                StringBuilder __tmp14 = new StringBuilder();
                __tmp14.Append(intf.Name);
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
                            __tmp8_outputWritten = true;
                        }
                        if (!__tmp14_last) __out.AppendLine(true);
                    }
                }
                string __tmp15_line = "_"; //161:81
                if (!string.IsNullOrEmpty(__tmp15_line))
                {
                    __out.Append(__tmp15_line);
                    __tmp8_outputWritten = true;
                }
                StringBuilder __tmp16 = new StringBuilder();
                __tmp16.Append(op.Name);
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
                            __tmp8_outputWritten = true;
                        }
                        if (!__tmp16_last) __out.AppendLine(true);
                    }
                }
                string __tmp17_line = "_InputMessage\"/>"; //161:91
                if (!string.IsNullOrEmpty(__tmp17_line))
                {
                    __out.Append(__tmp17_line);
                    __tmp8_outputWritten = true;
                }
                if (__tmp8_outputWritten) __out.AppendLine(true);
                if (__tmp8_outputWritten)
                {
                    __out.AppendLine(false); //161:107
                }
                if (!op.Result.IsOneway) //162:2
                {
                    bool __tmp19_outputWritten = false;
                    string __tmp20_line = "	<wsdl:output wsaw:action=\""; //163:1
                    if (!string.IsNullOrEmpty(__tmp20_line))
                    {
                        __out.Append(__tmp20_line);
                        __tmp19_outputWritten = true;
                    }
                    StringBuilder __tmp21 = new StringBuilder();
                    __tmp21.Append(action + "Response");
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
                                __tmp19_outputWritten = true;
                            }
                            if (!__tmp21_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp22_line = "\" message=\""; //163:49
                    if (!string.IsNullOrEmpty(__tmp22_line))
                    {
                        __out.Append(__tmp22_line);
                        __tmp19_outputWritten = true;
                    }
                    StringBuilder __tmp23 = new StringBuilder();
                    __tmp23.Append(intf.Namespace.Prefix);
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
                                __tmp19_outputWritten = true;
                            }
                            if (!__tmp23_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp24_line = ":"; //163:83
                    if (!string.IsNullOrEmpty(__tmp24_line))
                    {
                        __out.Append(__tmp24_line);
                        __tmp19_outputWritten = true;
                    }
                    StringBuilder __tmp25 = new StringBuilder();
                    __tmp25.Append(intf.Name);
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
                                __tmp19_outputWritten = true;
                            }
                            if (!__tmp25_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp26_line = "_"; //163:95
                    if (!string.IsNullOrEmpty(__tmp26_line))
                    {
                        __out.Append(__tmp26_line);
                        __tmp19_outputWritten = true;
                    }
                    StringBuilder __tmp27 = new StringBuilder();
                    __tmp27.Append(op.Name);
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
                                __tmp19_outputWritten = true;
                            }
                            if (!__tmp27_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp28_line = "_OutputMessage\"/>"; //163:105
                    if (!string.IsNullOrEmpty(__tmp28_line))
                    {
                        __out.Append(__tmp28_line);
                        __tmp19_outputWritten = true;
                    }
                    if (__tmp19_outputWritten) __out.AppendLine(true);
                    if (__tmp19_outputWritten)
                    {
                        __out.AppendLine(false); //163:122
                    }
                    var __loop10_results = 
                        (from ex in __Enumerate((op.Exceptions).GetEnumerator()) //164:8
                        select new { ex = ex}
                        ).ToList(); //164:3
                    for (int __loop10_iteration = 0; __loop10_iteration < __loop10_results.Count; ++__loop10_iteration)
                    {
                        var __tmp29 = __loop10_results[__loop10_iteration];
                        var ex = __tmp29.ex;
                        bool __tmp31_outputWritten = false;
                        string __tmp32_line = "	<wsdl:fault wsaw:action=\""; //165:1
                        if (!string.IsNullOrEmpty(__tmp32_line))
                        {
                            __out.Append(__tmp32_line);
                            __tmp31_outputWritten = true;
                        }
                        StringBuilder __tmp33 = new StringBuilder();
                        __tmp33.Append(action + "Fault/" + ex.Name);
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
                        string __tmp34_line = "\" message=\""; //165:56
                        if (!string.IsNullOrEmpty(__tmp34_line))
                        {
                            __out.Append(__tmp34_line);
                            __tmp31_outputWritten = true;
                        }
                        StringBuilder __tmp35 = new StringBuilder();
                        __tmp35.Append(intf.Namespace.Prefix);
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
                        string __tmp36_line = ":"; //165:90
                        if (!string.IsNullOrEmpty(__tmp36_line))
                        {
                            __out.Append(__tmp36_line);
                            __tmp31_outputWritten = true;
                        }
                        StringBuilder __tmp37 = new StringBuilder();
                        __tmp37.Append(intf.Name);
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
                        string __tmp38_line = "_"; //165:102
                        if (!string.IsNullOrEmpty(__tmp38_line))
                        {
                            __out.Append(__tmp38_line);
                            __tmp31_outputWritten = true;
                        }
                        StringBuilder __tmp39 = new StringBuilder();
                        __tmp39.Append(ex.Name);
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
                                    __tmp31_outputWritten = true;
                                }
                                if (!__tmp39_last) __out.AppendLine(true);
                            }
                        }
                        string __tmp40_line = "_FaultMessage\" name=\""; //165:112
                        if (!string.IsNullOrEmpty(__tmp40_line))
                        {
                            __out.Append(__tmp40_line);
                            __tmp31_outputWritten = true;
                        }
                        StringBuilder __tmp41 = new StringBuilder();
                        __tmp41.Append(ex.Name);
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
                                    __tmp31_outputWritten = true;
                                }
                                if (!__tmp41_last) __out.AppendLine(true);
                            }
                        }
                        string __tmp42_line = "\"/>"; //165:142
                        if (!string.IsNullOrEmpty(__tmp42_line))
                        {
                            __out.Append(__tmp42_line);
                            __tmp31_outputWritten = true;
                        }
                        if (__tmp31_outputWritten) __out.AppendLine(true);
                        if (__tmp31_outputWritten)
                        {
                            __out.AppendLine(false); //165:145
                        }
                    }
                }
                __out.Append("</wsdl:operation>"); //168:1
                __out.AppendLine(false); //168:18
            }
            return __out.ToString();
        }

        public string GenerateWsdlBindingPart(Namespace ns) //172:1
        {
            StringBuilder __out = new StringBuilder();
            var __loop11_results = 
                (from __loop11_var1 in __Enumerate((ns.Declarations).GetEnumerator()) //173:7
                from endp in __Enumerate((__loop11_var1).GetEnumerator()).OfType<Endpoint>() //173:24
                select new { __loop11_var1 = __loop11_var1, endp = endp}
                ).ToList(); //173:2
            for (int __loop11_iteration = 0; __loop11_iteration < __loop11_results.Count; ++__loop11_iteration)
            {
                var __tmp1 = __loop11_results[__loop11_iteration];
                var __loop11_var1 = __tmp1.__loop11_var1;
                var endp = __tmp1.endp;
                bool __tmp3_outputWritten = false;
                StringBuilder __tmp4 = new StringBuilder();
                __tmp4.Append(GenerateWsdlBinding(endp));
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
                    __out.AppendLine(false); //174:28
                }
            }
            return __out.ToString();
        }

        public string GenerateWsdlBinding(Endpoint endp) //178:1
        {
            StringBuilder __out = new StringBuilder();
            __out.AppendLine(true); //179:1
            string soapPrefix = endp.Binding.GetSoapPrefix(); //180:2
            bool __tmp2_outputWritten = false;
            string __tmp3_line = "<wsdl:binding name=\""; //181:1
            if (!string.IsNullOrEmpty(__tmp3_line))
            {
                __out.Append(__tmp3_line);
                __tmp2_outputWritten = true;
            }
            StringBuilder __tmp4 = new StringBuilder();
            __tmp4.Append(endp.Interface.Name);
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
            string __tmp5_line = "_"; //181:42
            if (!string.IsNullOrEmpty(__tmp5_line))
            {
                __out.Append(__tmp5_line);
                __tmp2_outputWritten = true;
            }
            StringBuilder __tmp6 = new StringBuilder();
            __tmp6.Append(endp.Binding.Name);
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
            string __tmp7_line = "_Binding\" type=\""; //181:62
            if (!string.IsNullOrEmpty(__tmp7_line))
            {
                __out.Append(__tmp7_line);
                __tmp2_outputWritten = true;
            }
            StringBuilder __tmp8 = new StringBuilder();
            __tmp8.Append(endp.Interface.Namespace.Prefix);
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
            string __tmp9_line = ":"; //181:111
            if (!string.IsNullOrEmpty(__tmp9_line))
            {
                __out.Append(__tmp9_line);
                __tmp2_outputWritten = true;
            }
            StringBuilder __tmp10 = new StringBuilder();
            __tmp10.Append(endp.Interface.Name);
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
            string __tmp11_line = "\">"; //181:133
            if (!string.IsNullOrEmpty(__tmp11_line))
            {
                __out.Append(__tmp11_line);
                __tmp2_outputWritten = true;
            }
            if (__tmp2_outputWritten) __out.AppendLine(true);
            if (__tmp2_outputWritten)
            {
                __out.AppendLine(false); //181:135
            }
            if (endp.Binding.HasPolicy()) //182:3
            {
                bool __tmp13_outputWritten = false;
                string __tmp14_line = "	<wsp:PolicyReference URI=\"#"; //183:1
                if (!string.IsNullOrEmpty(__tmp14_line))
                {
                    __out.Append(__tmp14_line);
                    __tmp13_outputWritten = true;
                }
                StringBuilder __tmp15 = new StringBuilder();
                __tmp15.Append(endp.Binding.Name);
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
                string __tmp16_line = "_Policy\"/>"; //183:48
                if (!string.IsNullOrEmpty(__tmp16_line))
                {
                    __out.Append(__tmp16_line);
                    __tmp13_outputWritten = true;
                }
                if (__tmp13_outputWritten) __out.AppendLine(true);
                if (__tmp13_outputWritten)
                {
                    __out.AppendLine(false); //183:58
                }
            }
            if (soapPrefix != null) //185:3
            {
                if (endp.Binding.Transport is HttpTransportBindingElement) //186:4
                {
                    bool __tmp18_outputWritten = false;
                    string __tmp19_line = "	<"; //187:1
                    if (!string.IsNullOrEmpty(__tmp19_line))
                    {
                        __out.Append(__tmp19_line);
                        __tmp18_outputWritten = true;
                    }
                    StringBuilder __tmp20 = new StringBuilder();
                    __tmp20.Append(soapPrefix);
                    using(StreamReader __tmp20Reader = new StreamReader(this.__ToStream(__tmp20.ToString())))
                    {
                        bool __tmp20_last = __tmp20Reader.EndOfStream;
                        while(!__tmp20_last)
                        {
                            string __tmp20_line = __tmp20Reader.ReadLine();
                            __tmp20_last = __tmp20Reader.EndOfStream;
                            if ((__tmp20_last && !string.IsNullOrEmpty(__tmp20_line)) || (!__tmp20_last && __tmp20_line != null))
                            {
                                __out.Append(__tmp20_line);
                                __tmp18_outputWritten = true;
                            }
                            if (!__tmp20_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp21_line = ":binding style=\""; //187:15
                    if (!string.IsNullOrEmpty(__tmp21_line))
                    {
                        __out.Append(__tmp21_line);
                        __tmp18_outputWritten = true;
                    }
                    StringBuilder __tmp22 = new StringBuilder();
                    __tmp22.Append(endp.Binding.GetWsdlSoapDocRpcStyle());
                    using(StreamReader __tmp22Reader = new StreamReader(this.__ToStream(__tmp22.ToString())))
                    {
                        bool __tmp22_last = __tmp22Reader.EndOfStream;
                        while(!__tmp22_last)
                        {
                            string __tmp22_line = __tmp22Reader.ReadLine();
                            __tmp22_last = __tmp22Reader.EndOfStream;
                            if ((__tmp22_last && !string.IsNullOrEmpty(__tmp22_line)) || (!__tmp22_last && __tmp22_line != null))
                            {
                                __out.Append(__tmp22_line);
                                __tmp18_outputWritten = true;
                            }
                            if (!__tmp22_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp23_line = "\" transport=\"http://schemas.xmlsoap.org/soap/http\"/>"; //187:70
                    if (!string.IsNullOrEmpty(__tmp23_line))
                    {
                        __out.Append(__tmp23_line);
                        __tmp18_outputWritten = true;
                    }
                    if (__tmp18_outputWritten) __out.AppendLine(true);
                    if (__tmp18_outputWritten)
                    {
                        __out.AppendLine(false); //187:122
                    }
                }
                else //188:4
                {
                    bool __tmp25_outputWritten = false;
                    string __tmp26_line = "	<"; //189:1
                    if (!string.IsNullOrEmpty(__tmp26_line))
                    {
                        __out.Append(__tmp26_line);
                        __tmp25_outputWritten = true;
                    }
                    StringBuilder __tmp27 = new StringBuilder();
                    __tmp27.Append(soapPrefix);
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
                                __tmp25_outputWritten = true;
                            }
                            if (!__tmp27_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp28_line = ":binding style=\""; //189:15
                    if (!string.IsNullOrEmpty(__tmp28_line))
                    {
                        __out.Append(__tmp28_line);
                        __tmp25_outputWritten = true;
                    }
                    StringBuilder __tmp29 = new StringBuilder();
                    __tmp29.Append(endp.Binding.GetWsdlSoapDocRpcStyle());
                    using(StreamReader __tmp29Reader = new StreamReader(this.__ToStream(__tmp29.ToString())))
                    {
                        bool __tmp29_last = __tmp29Reader.EndOfStream;
                        while(!__tmp29_last)
                        {
                            string __tmp29_line = __tmp29Reader.ReadLine();
                            __tmp29_last = __tmp29Reader.EndOfStream;
                            if ((__tmp29_last && !string.IsNullOrEmpty(__tmp29_line)) || (!__tmp29_last && __tmp29_line != null))
                            {
                                __out.Append(__tmp29_line);
                                __tmp25_outputWritten = true;
                            }
                            if (!__tmp29_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp30_line = "\"/>"; //189:70
                    if (!string.IsNullOrEmpty(__tmp30_line))
                    {
                        __out.Append(__tmp30_line);
                        __tmp25_outputWritten = true;
                    }
                    if (__tmp25_outputWritten) __out.AppendLine(true);
                    if (__tmp25_outputWritten)
                    {
                        __out.AppendLine(false); //189:73
                    }
                }
            }
            var __loop12_results = 
                (from op in __Enumerate((endp.Interface.Operations).GetEnumerator()) //192:8
                select new { op = op}
                ).ToList(); //192:3
            for (int __loop12_iteration = 0; __loop12_iteration < __loop12_results.Count; ++__loop12_iteration)
            {
                var __tmp31 = __loop12_results[__loop12_iteration];
                var op = __tmp31.op;
                string action = op.Action != null ? op.Action : endp.Interface.Namespace.UriWithSlash() + endp.Interface.Name + "/" + op.Name; //193:4
                bool __tmp33_outputWritten = false;
                string __tmp34_line = "	<wsdl:operation name=\""; //194:1
                if (!string.IsNullOrEmpty(__tmp34_line))
                {
                    __out.Append(__tmp34_line);
                    __tmp33_outputWritten = true;
                }
                StringBuilder __tmp35 = new StringBuilder();
                __tmp35.Append(op.Name);
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
                            __tmp33_outputWritten = true;
                        }
                        if (!__tmp35_last) __out.AppendLine(true);
                    }
                }
                string __tmp36_line = "\">"; //194:33
                if (!string.IsNullOrEmpty(__tmp36_line))
                {
                    __out.Append(__tmp36_line);
                    __tmp33_outputWritten = true;
                }
                if (__tmp33_outputWritten) __out.AppendLine(true);
                if (__tmp33_outputWritten)
                {
                    __out.AppendLine(false); //194:35
                }
                if (soapPrefix != null) //195:4
                {
                    bool __tmp38_outputWritten = false;
                    string __tmp39_line = "		<"; //196:1
                    if (!string.IsNullOrEmpty(__tmp39_line))
                    {
                        __out.Append(__tmp39_line);
                        __tmp38_outputWritten = true;
                    }
                    StringBuilder __tmp40 = new StringBuilder();
                    __tmp40.Append(soapPrefix);
                    using(StreamReader __tmp40Reader = new StreamReader(this.__ToStream(__tmp40.ToString())))
                    {
                        bool __tmp40_last = __tmp40Reader.EndOfStream;
                        while(!__tmp40_last)
                        {
                            string __tmp40_line = __tmp40Reader.ReadLine();
                            __tmp40_last = __tmp40Reader.EndOfStream;
                            if ((__tmp40_last && !string.IsNullOrEmpty(__tmp40_line)) || (!__tmp40_last && __tmp40_line != null))
                            {
                                __out.Append(__tmp40_line);
                                __tmp38_outputWritten = true;
                            }
                            if (!__tmp40_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp41_line = ":operation style=\""; //196:16
                    if (!string.IsNullOrEmpty(__tmp41_line))
                    {
                        __out.Append(__tmp41_line);
                        __tmp38_outputWritten = true;
                    }
                    StringBuilder __tmp42 = new StringBuilder();
                    __tmp42.Append(endp.Binding.GetWsdlSoapDocRpcStyle());
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
                                __tmp38_outputWritten = true;
                            }
                            if (!__tmp42_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp43_line = "\" soapAction=\""; //196:73
                    if (!string.IsNullOrEmpty(__tmp43_line))
                    {
                        __out.Append(__tmp43_line);
                        __tmp38_outputWritten = true;
                    }
                    StringBuilder __tmp44 = new StringBuilder();
                    __tmp44.Append(action);
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
                                __tmp38_outputWritten = true;
                            }
                            if (!__tmp44_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp45_line = "\"/>"; //196:95
                    if (!string.IsNullOrEmpty(__tmp45_line))
                    {
                        __out.Append(__tmp45_line);
                        __tmp38_outputWritten = true;
                    }
                    if (__tmp38_outputWritten) __out.AppendLine(true);
                    if (__tmp38_outputWritten)
                    {
                        __out.AppendLine(false); //196:98
                    }
                }
                __out.Append("		<wsdl:input>"); //198:1
                __out.AppendLine(false); //198:15
                if (endp.Binding.HasOperationPolicy()) //199:4
                {
                    bool __tmp47_outputWritten = false;
                    string __tmp48_line = "			<wsp:PolicyReference URI=\"#"; //200:1
                    if (!string.IsNullOrEmpty(__tmp48_line))
                    {
                        __out.Append(__tmp48_line);
                        __tmp47_outputWritten = true;
                    }
                    StringBuilder __tmp49 = new StringBuilder();
                    __tmp49.Append(endp.Binding.Name);
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
                                __tmp47_outputWritten = true;
                            }
                            if (!__tmp49_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp50_line = "_Input_Policy\"/>"; //200:50
                    if (!string.IsNullOrEmpty(__tmp50_line))
                    {
                        __out.Append(__tmp50_line);
                        __tmp47_outputWritten = true;
                    }
                    if (__tmp47_outputWritten) __out.AppendLine(true);
                    if (__tmp47_outputWritten)
                    {
                        __out.AppendLine(false); //200:66
                    }
                }
                if (soapPrefix != null) //202:4
                {
                    bool __tmp52_outputWritten = false;
                    string __tmp53_line = "			<"; //203:1
                    if (!string.IsNullOrEmpty(__tmp53_line))
                    {
                        __out.Append(__tmp53_line);
                        __tmp52_outputWritten = true;
                    }
                    StringBuilder __tmp54 = new StringBuilder();
                    __tmp54.Append(soapPrefix);
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
                    string __tmp55_line = ":body use=\""; //203:17
                    if (!string.IsNullOrEmpty(__tmp55_line))
                    {
                        __out.Append(__tmp55_line);
                        __tmp52_outputWritten = true;
                    }
                    StringBuilder __tmp56 = new StringBuilder();
                    __tmp56.Append(endp.Binding.GetWsdlSoapEncLitStyle());
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
                    string __tmp57_line = "\"/>"; //203:67
                    if (!string.IsNullOrEmpty(__tmp57_line))
                    {
                        __out.Append(__tmp57_line);
                        __tmp52_outputWritten = true;
                    }
                    if (__tmp52_outputWritten) __out.AppendLine(true);
                    if (__tmp52_outputWritten)
                    {
                        __out.AppendLine(false); //203:70
                    }
                }
                __out.Append("		</wsdl:input>"); //205:1
                __out.AppendLine(false); //205:16
                if (!op.Result.IsOneway) //206:4
                {
                    __out.Append("		<wsdl:output>"); //207:1
                    __out.AppendLine(false); //207:16
                    if (endp.Binding.HasOperationPolicy()) //208:5
                    {
                        bool __tmp59_outputWritten = false;
                        string __tmp60_line = "			<wsp:PolicyReference URI=\"#"; //209:1
                        if (!string.IsNullOrEmpty(__tmp60_line))
                        {
                            __out.Append(__tmp60_line);
                            __tmp59_outputWritten = true;
                        }
                        StringBuilder __tmp61 = new StringBuilder();
                        __tmp61.Append(endp.Binding.Name);
                        using(StreamReader __tmp61Reader = new StreamReader(this.__ToStream(__tmp61.ToString())))
                        {
                            bool __tmp61_last = __tmp61Reader.EndOfStream;
                            while(!__tmp61_last)
                            {
                                string __tmp61_line = __tmp61Reader.ReadLine();
                                __tmp61_last = __tmp61Reader.EndOfStream;
                                if ((__tmp61_last && !string.IsNullOrEmpty(__tmp61_line)) || (!__tmp61_last && __tmp61_line != null))
                                {
                                    __out.Append(__tmp61_line);
                                    __tmp59_outputWritten = true;
                                }
                                if (!__tmp61_last) __out.AppendLine(true);
                            }
                        }
                        string __tmp62_line = "_Output_Policy\"/>"; //209:50
                        if (!string.IsNullOrEmpty(__tmp62_line))
                        {
                            __out.Append(__tmp62_line);
                            __tmp59_outputWritten = true;
                        }
                        if (__tmp59_outputWritten) __out.AppendLine(true);
                        if (__tmp59_outputWritten)
                        {
                            __out.AppendLine(false); //209:67
                        }
                    }
                    if (soapPrefix != null) //211:5
                    {
                        bool __tmp64_outputWritten = false;
                        string __tmp65_line = "			<"; //212:1
                        if (!string.IsNullOrEmpty(__tmp65_line))
                        {
                            __out.Append(__tmp65_line);
                            __tmp64_outputWritten = true;
                        }
                        StringBuilder __tmp66 = new StringBuilder();
                        __tmp66.Append(soapPrefix);
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
                        string __tmp67_line = ":body use=\""; //212:17
                        if (!string.IsNullOrEmpty(__tmp67_line))
                        {
                            __out.Append(__tmp67_line);
                            __tmp64_outputWritten = true;
                        }
                        StringBuilder __tmp68 = new StringBuilder();
                        __tmp68.Append(endp.Binding.GetWsdlSoapEncLitStyle());
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
                        string __tmp69_line = "\"/>"; //212:67
                        if (!string.IsNullOrEmpty(__tmp69_line))
                        {
                            __out.Append(__tmp69_line);
                            __tmp64_outputWritten = true;
                        }
                        if (__tmp64_outputWritten) __out.AppendLine(true);
                        if (__tmp64_outputWritten)
                        {
                            __out.AppendLine(false); //212:70
                        }
                    }
                    __out.Append("		</wsdl:output>"); //214:1
                    __out.AppendLine(false); //214:17
                    var __loop13_results = 
                        (from ex in __Enumerate((op.Exceptions).GetEnumerator()) //215:10
                        select new { ex = ex}
                        ).ToList(); //215:5
                    for (int __loop13_iteration = 0; __loop13_iteration < __loop13_results.Count; ++__loop13_iteration)
                    {
                        var __tmp70 = __loop13_results[__loop13_iteration];
                        var ex = __tmp70.ex;
                        bool __tmp72_outputWritten = false;
                        string __tmp73_line = "		<wsdl:fault name=\""; //216:1
                        if (!string.IsNullOrEmpty(__tmp73_line))
                        {
                            __out.Append(__tmp73_line);
                            __tmp72_outputWritten = true;
                        }
                        StringBuilder __tmp74 = new StringBuilder();
                        __tmp74.Append(ex.Name);
                        using(StreamReader __tmp74Reader = new StreamReader(this.__ToStream(__tmp74.ToString())))
                        {
                            bool __tmp74_last = __tmp74Reader.EndOfStream;
                            while(!__tmp74_last)
                            {
                                string __tmp74_line = __tmp74Reader.ReadLine();
                                __tmp74_last = __tmp74Reader.EndOfStream;
                                if ((__tmp74_last && !string.IsNullOrEmpty(__tmp74_line)) || (!__tmp74_last && __tmp74_line != null))
                                {
                                    __out.Append(__tmp74_line);
                                    __tmp72_outputWritten = true;
                                }
                                if (!__tmp74_last) __out.AppendLine(true);
                            }
                        }
                        string __tmp75_line = "\">"; //216:30
                        if (!string.IsNullOrEmpty(__tmp75_line))
                        {
                            __out.Append(__tmp75_line);
                            __tmp72_outputWritten = true;
                        }
                        if (__tmp72_outputWritten) __out.AppendLine(true);
                        if (__tmp72_outputWritten)
                        {
                            __out.AppendLine(false); //216:32
                        }
                        if (soapPrefix != null) //217:5
                        {
                            bool __tmp77_outputWritten = false;
                            string __tmp78_line = "			<"; //218:1
                            if (!string.IsNullOrEmpty(__tmp78_line))
                            {
                                __out.Append(__tmp78_line);
                                __tmp77_outputWritten = true;
                            }
                            StringBuilder __tmp79 = new StringBuilder();
                            __tmp79.Append(soapPrefix);
                            using(StreamReader __tmp79Reader = new StreamReader(this.__ToStream(__tmp79.ToString())))
                            {
                                bool __tmp79_last = __tmp79Reader.EndOfStream;
                                while(!__tmp79_last)
                                {
                                    string __tmp79_line = __tmp79Reader.ReadLine();
                                    __tmp79_last = __tmp79Reader.EndOfStream;
                                    if ((__tmp79_last && !string.IsNullOrEmpty(__tmp79_line)) || (!__tmp79_last && __tmp79_line != null))
                                    {
                                        __out.Append(__tmp79_line);
                                        __tmp77_outputWritten = true;
                                    }
                                    if (!__tmp79_last) __out.AppendLine(true);
                                }
                            }
                            string __tmp80_line = ":fault name=\""; //218:17
                            if (!string.IsNullOrEmpty(__tmp80_line))
                            {
                                __out.Append(__tmp80_line);
                                __tmp77_outputWritten = true;
                            }
                            StringBuilder __tmp81 = new StringBuilder();
                            __tmp81.Append(ex.Name);
                            using(StreamReader __tmp81Reader = new StreamReader(this.__ToStream(__tmp81.ToString())))
                            {
                                bool __tmp81_last = __tmp81Reader.EndOfStream;
                                while(!__tmp81_last)
                                {
                                    string __tmp81_line = __tmp81Reader.ReadLine();
                                    __tmp81_last = __tmp81Reader.EndOfStream;
                                    if ((__tmp81_last && !string.IsNullOrEmpty(__tmp81_line)) || (!__tmp81_last && __tmp81_line != null))
                                    {
                                        __out.Append(__tmp81_line);
                                        __tmp77_outputWritten = true;
                                    }
                                    if (!__tmp81_last) __out.AppendLine(true);
                                }
                            }
                            string __tmp82_line = "\" use=\""; //218:39
                            if (!string.IsNullOrEmpty(__tmp82_line))
                            {
                                __out.Append(__tmp82_line);
                                __tmp77_outputWritten = true;
                            }
                            StringBuilder __tmp83 = new StringBuilder();
                            __tmp83.Append(endp.Binding.GetWsdlSoapEncLitStyle());
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
                                        __tmp77_outputWritten = true;
                                    }
                                    if (!__tmp83_last) __out.AppendLine(true);
                                }
                            }
                            string __tmp84_line = "\"/>"; //218:85
                            if (!string.IsNullOrEmpty(__tmp84_line))
                            {
                                __out.Append(__tmp84_line);
                                __tmp77_outputWritten = true;
                            }
                            if (__tmp77_outputWritten) __out.AppendLine(true);
                            if (__tmp77_outputWritten)
                            {
                                __out.AppendLine(false); //218:88
                            }
                        }
                        __out.Append("		</wsdl:fault>"); //220:1
                        __out.AppendLine(false); //220:16
                    }
                }
                __out.Append("	</wsdl:operation>"); //223:1
                __out.AppendLine(false); //223:19
            }
            __out.Append("</wsdl:binding>"); //225:1
            __out.AppendLine(false); //225:16
            return __out.ToString();
        }

        public string GenerateWsdlEndpointPart(Namespace ns) //228:1
        {
            StringBuilder __out = new StringBuilder();
            var __loop14_results = 
                (from __loop14_var1 in __Enumerate((ns.Declarations).GetEnumerator()) //229:7
                from endp in __Enumerate((__loop14_var1).GetEnumerator()).OfType<Endpoint>() //229:24
                select new { __loop14_var1 = __loop14_var1, endp = endp}
                ).ToList(); //229:2
            for (int __loop14_iteration = 0; __loop14_iteration < __loop14_results.Count; ++__loop14_iteration)
            {
                var __tmp1 = __loop14_results[__loop14_iteration];
                var __loop14_var1 = __tmp1.__loop14_var1;
                var endp = __tmp1.endp;
                bool __tmp3_outputWritten = false;
                StringBuilder __tmp4 = new StringBuilder();
                __tmp4.Append(GenerateWsdlEndpoint(endp));
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
                    __out.AppendLine(false); //230:29
                }
            }
            return __out.ToString();
        }

        public string GenerateWsdlEndpoint(Endpoint endp) //234:1
        {
            StringBuilder __out = new StringBuilder();
            __out.AppendLine(true); //235:1
            string soapPrefix = endp.Binding.GetSoapPrefix(); //236:2
            bool __tmp2_outputWritten = false;
            string __tmp3_line = "<wsdl:service name=\""; //237:1
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
            string __tmp5_line = "\">"; //237:32
            if (!string.IsNullOrEmpty(__tmp5_line))
            {
                __out.Append(__tmp5_line);
                __tmp2_outputWritten = true;
            }
            if (__tmp2_outputWritten) __out.AppendLine(true);
            if (__tmp2_outputWritten)
            {
                __out.AppendLine(false); //237:34
            }
            bool __tmp7_outputWritten = false;
            string __tmp8_line = "	<wsdl:port name=\""; //238:1
            if (!string.IsNullOrEmpty(__tmp8_line))
            {
                __out.Append(__tmp8_line);
                __tmp7_outputWritten = true;
            }
            StringBuilder __tmp9 = new StringBuilder();
            __tmp9.Append(endp.Interface.Name);
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
            string __tmp10_line = "_"; //238:40
            if (!string.IsNullOrEmpty(__tmp10_line))
            {
                __out.Append(__tmp10_line);
                __tmp7_outputWritten = true;
            }
            StringBuilder __tmp11 = new StringBuilder();
            __tmp11.Append(endp.Binding.Name);
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
            string __tmp12_line = "_Port\" binding=\""; //238:60
            if (!string.IsNullOrEmpty(__tmp12_line))
            {
                __out.Append(__tmp12_line);
                __tmp7_outputWritten = true;
            }
            StringBuilder __tmp13 = new StringBuilder();
            __tmp13.Append(endp.Namespace.Prefix);
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
                        __tmp7_outputWritten = true;
                    }
                    if (!__tmp13_last) __out.AppendLine(true);
                }
            }
            string __tmp14_line = ":"; //238:99
            if (!string.IsNullOrEmpty(__tmp14_line))
            {
                __out.Append(__tmp14_line);
                __tmp7_outputWritten = true;
            }
            StringBuilder __tmp15 = new StringBuilder();
            __tmp15.Append(endp.Interface.Name);
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
                        __tmp7_outputWritten = true;
                    }
                    if (!__tmp15_last) __out.AppendLine(true);
                }
            }
            string __tmp16_line = "_"; //238:121
            if (!string.IsNullOrEmpty(__tmp16_line))
            {
                __out.Append(__tmp16_line);
                __tmp7_outputWritten = true;
            }
            StringBuilder __tmp17 = new StringBuilder();
            __tmp17.Append(endp.Binding.Name);
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
                        __tmp7_outputWritten = true;
                    }
                    if (!__tmp17_last) __out.AppendLine(true);
                }
            }
            string __tmp18_line = "_Binding\">"; //238:141
            if (!string.IsNullOrEmpty(__tmp18_line))
            {
                __out.Append(__tmp18_line);
                __tmp7_outputWritten = true;
            }
            if (__tmp7_outputWritten) __out.AppendLine(true);
            if (__tmp7_outputWritten)
            {
                __out.AppendLine(false); //238:151
            }
            if (soapPrefix != null) //239:3
            {
                bool __tmp20_outputWritten = false;
                string __tmp21_line = "		<"; //240:1
                if (!string.IsNullOrEmpty(__tmp21_line))
                {
                    __out.Append(__tmp21_line);
                    __tmp20_outputWritten = true;
                }
                StringBuilder __tmp22 = new StringBuilder();
                __tmp22.Append(soapPrefix);
                using(StreamReader __tmp22Reader = new StreamReader(this.__ToStream(__tmp22.ToString())))
                {
                    bool __tmp22_last = __tmp22Reader.EndOfStream;
                    while(!__tmp22_last)
                    {
                        string __tmp22_line = __tmp22Reader.ReadLine();
                        __tmp22_last = __tmp22Reader.EndOfStream;
                        if ((__tmp22_last && !string.IsNullOrEmpty(__tmp22_line)) || (!__tmp22_last && __tmp22_line != null))
                        {
                            __out.Append(__tmp22_line);
                            __tmp20_outputWritten = true;
                        }
                        if (!__tmp22_last) __out.AppendLine(true);
                    }
                }
                string __tmp23_line = ":address location=\""; //240:16
                if (!string.IsNullOrEmpty(__tmp23_line))
                {
                    __out.Append(__tmp23_line);
                    __tmp20_outputWritten = true;
                }
                StringBuilder __tmp24 = new StringBuilder();
                __tmp24.Append(endp.Address);
                using(StreamReader __tmp24Reader = new StreamReader(this.__ToStream(__tmp24.ToString())))
                {
                    bool __tmp24_last = __tmp24Reader.EndOfStream;
                    while(!__tmp24_last)
                    {
                        string __tmp24_line = __tmp24Reader.ReadLine();
                        __tmp24_last = __tmp24Reader.EndOfStream;
                        if ((__tmp24_last && !string.IsNullOrEmpty(__tmp24_line)) || (!__tmp24_last && __tmp24_line != null))
                        {
                            __out.Append(__tmp24_line);
                            __tmp20_outputWritten = true;
                        }
                        if (!__tmp24_last) __out.AppendLine(true);
                    }
                }
                string __tmp25_line = "\"/>"; //240:49
                if (!string.IsNullOrEmpty(__tmp25_line))
                {
                    __out.Append(__tmp25_line);
                    __tmp20_outputWritten = true;
                }
                if (__tmp20_outputWritten) __out.AppendLine(true);
                if (__tmp20_outputWritten)
                {
                    __out.AppendLine(false); //240:52
                }
            }
            __out.Append("	</wsdl:port>"); //242:1
            __out.AppendLine(false); //242:14
            __out.Append("</wsdl:service>"); //243:1
            __out.AppendLine(false); //243:16
            return __out.ToString();
        }

        public string GenerateWsdlPoliciesPart(Namespace ns) //248:1
        {
            StringBuilder __out = new StringBuilder();
            var __loop15_results = 
                (from __loop15_var1 in __Enumerate((ns.Declarations).GetEnumerator()) //249:7
                from binding in __Enumerate((__loop15_var1).GetEnumerator()).OfType<Symbols.Binding>() //249:24
                select new { __loop15_var1 = __loop15_var1, binding = binding}
                ).ToList(); //249:2
            for (int __loop15_iteration = 0; __loop15_iteration < __loop15_results.Count; ++__loop15_iteration)
            {
                var __tmp1 = __loop15_results[__loop15_iteration];
                var __loop15_var1 = __tmp1.__loop15_var1;
                var binding = __tmp1.binding;
                bool __tmp3_outputWritten = false;
                StringBuilder __tmp4 = new StringBuilder();
                __tmp4.Append(GenerateWsdlPolicy(binding));
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
                    __out.AppendLine(false); //250:30
                }
            }
            return __out.ToString();
        }

        public string GenerateWsdlPolicy(Symbols.Binding binding) //254:1
        {
            StringBuilder __out = new StringBuilder();
            if (binding.HasPolicy()) //255:2
            {
                __out.AppendLine(true); //256:1
                bool __tmp2_outputWritten = false;
                string __tmp3_line = "<wsp:Policy wsu:Id=\""; //257:1
                if (!string.IsNullOrEmpty(__tmp3_line))
                {
                    __out.Append(__tmp3_line);
                    __tmp2_outputWritten = true;
                }
                StringBuilder __tmp4 = new StringBuilder();
                __tmp4.Append(binding.Name);
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
                string __tmp5_line = "_Policy\">"; //257:35
                if (!string.IsNullOrEmpty(__tmp5_line))
                {
                    __out.Append(__tmp5_line);
                    __tmp2_outputWritten = true;
                }
                if (__tmp2_outputWritten) __out.AppendLine(true);
                if (__tmp2_outputWritten)
                {
                    __out.AppendLine(false); //257:44
                }
                bool __tmp7_outputWritten = false;
                string __tmp6Prefix = "	"; //258:1
                StringBuilder __tmp8 = new StringBuilder();
                __tmp8.Append(GenerateHttpsPolicy(binding));
                using(StreamReader __tmp8Reader = new StreamReader(this.__ToStream(__tmp8.ToString())))
                {
                    bool __tmp8_last = __tmp8Reader.EndOfStream;
                    while(!__tmp8_last)
                    {
                        string __tmp8_line = __tmp8Reader.ReadLine();
                        __tmp8_last = __tmp8Reader.EndOfStream;
                        if (!string.IsNullOrEmpty(__tmp6Prefix))
                        {
                            __out.Append(__tmp6Prefix);
                            __tmp7_outputWritten = true;
                        }
                        if ((__tmp8_last && !string.IsNullOrEmpty(__tmp8_line)) || (!__tmp8_last && __tmp8_line != null))
                        {
                            __out.Append(__tmp8_line);
                            __tmp7_outputWritten = true;
                        }
                        if (!__tmp8_last || __tmp7_outputWritten) __out.AppendLine(true);
                    }
                }
                if (__tmp7_outputWritten)
                {
                    __out.AppendLine(false); //258:32
                }
                bool __tmp10_outputWritten = false;
                string __tmp9Prefix = "	"; //259:1
                StringBuilder __tmp11 = new StringBuilder();
                __tmp11.Append(GenerateMtomPolicy(binding));
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
                    __out.AppendLine(false); //259:31
                }
                bool __tmp13_outputWritten = false;
                string __tmp12Prefix = "	"; //260:1
                StringBuilder __tmp14 = new StringBuilder();
                __tmp14.Append(GenerateAddressingPolicy(binding));
                using(StreamReader __tmp14Reader = new StreamReader(this.__ToStream(__tmp14.ToString())))
                {
                    bool __tmp14_last = __tmp14Reader.EndOfStream;
                    while(!__tmp14_last)
                    {
                        string __tmp14_line = __tmp14Reader.ReadLine();
                        __tmp14_last = __tmp14Reader.EndOfStream;
                        if (!string.IsNullOrEmpty(__tmp12Prefix))
                        {
                            __out.Append(__tmp12Prefix);
                            __tmp13_outputWritten = true;
                        }
                        if ((__tmp14_last && !string.IsNullOrEmpty(__tmp14_line)) || (!__tmp14_last && __tmp14_line != null))
                        {
                            __out.Append(__tmp14_line);
                            __tmp13_outputWritten = true;
                        }
                        if (!__tmp14_last || __tmp13_outputWritten) __out.AppendLine(true);
                    }
                }
                if (__tmp13_outputWritten)
                {
                    __out.AppendLine(false); //260:37
                }
                __out.Append("</wsp:Policy>"); //261:1
                __out.AppendLine(false); //261:14
            }
            return __out.ToString();
        }

        public string GenerateHttpsPolicy(Symbols.Binding binding) //265:1
        {
            StringBuilder __out = new StringBuilder();
            if (binding.Transport is HttpTransportBindingElement && ((HttpTransportBindingElement)binding.Transport).Ssl) //266:2
            {
                __out.Append("<sp:TransportBinding>"); //267:1
                __out.AppendLine(false); //267:22
                __out.Append("	<wsp:Policy>"); //268:1
                __out.AppendLine(false); //268:14
                __out.Append("		<sp:TransportToken>"); //269:1
                __out.AppendLine(false); //269:22
                __out.Append("			<wsp:Policy>"); //270:1
                __out.AppendLine(false); //270:16
                if (((HttpTransportBindingElement)binding.Transport).ClientAuthentication) //271:5
                {
                    __out.Append("				<sp:HttpsToken RequireClientCertificate=\"true\"/>"); //272:1
                    __out.AppendLine(false); //272:53
                }
                else //273:5
                {
                    __out.Append("				<sp:HttpsToken RequireClientCertificate=\"false\"/>"); //274:1
                    __out.AppendLine(false); //274:54
                }
                __out.Append("			</wsp:Policy>"); //276:1
                __out.AppendLine(false); //276:17
                __out.Append("		</sp:TransportToken>"); //277:1
                __out.AppendLine(false); //277:23
                __out.Append("		<sp:AlgorithmSuite>"); //278:1
                __out.AppendLine(false); //278:22
                __out.Append("			<wsp:Policy>"); //279:1
                __out.AppendLine(false); //279:16
                __out.Append("				<sp:Basic256/>"); //280:1
                __out.AppendLine(false); //280:19
                __out.Append("			</wsp:Policy>"); //281:1
                __out.AppendLine(false); //281:17
                __out.Append("		</sp:AlgorithmSuite>"); //282:1
                __out.AppendLine(false); //282:23
                __out.Append("		<sp:Layout>"); //283:1
                __out.AppendLine(false); //283:14
                __out.Append("			<wsp:Policy>"); //284:1
                __out.AppendLine(false); //284:16
                __out.Append("				<sp:Strict/>"); //285:1
                __out.AppendLine(false); //285:17
                __out.Append("			</wsp:Policy>"); //286:1
                __out.AppendLine(false); //286:17
                __out.Append("		</sp:Layout> "); //287:1
                __out.AppendLine(false); //287:16
                __out.Append("	</wsp:Policy>"); //288:1
                __out.AppendLine(false); //288:15
                __out.Append("</sp:TransportBinding>"); //289:1
                __out.AppendLine(false); //289:23
            }
            return __out.ToString();
        }

        public string GenerateMtomPolicy(Symbols.Binding binding) //293:1
        {
            StringBuilder __out = new StringBuilder();
            if ((from __loop16_var1 in __Enumerate((binding).GetEnumerator()) //294:13
            from Encodings in __Enumerate((__loop16_var1.Encodings).GetEnumerator()) //294:22
            from enc in __Enumerate((Encodings).GetEnumerator()).OfType<SoapEncodingBindingElement>() //294:33
            where enc.Mtom //294:72
            select new { __loop16_var1 = __loop16_var1, Encodings = Encodings, enc = enc}
            ).GetEnumerator().MoveNext()) //294:2
            {
                __out.Append("<wsoma:OptimizedMimeSerialization/>"); //295:1
                __out.AppendLine(false); //295:36
            }
            return __out.ToString();
        }

        public string GenerateAddressingPolicy(Symbols.Binding binding) //299:1
        {
            StringBuilder __out = new StringBuilder();
            if ((from __loop17_var1 in __Enumerate((binding).GetEnumerator()) //300:13
            from Protocols in __Enumerate((__loop17_var1.Protocols).GetEnumerator()) //300:22
            from __loop17_var2 in __Enumerate((Protocols).GetEnumerator()).OfType<WsAddressingBindingElement>() //300:33
            select new { __loop17_var1 = __loop17_var1, Protocols = Protocols, __loop17_var2 = __loop17_var2}
            ).GetEnumerator().MoveNext()) //300:2
            {
                __out.Append("<wsam:Addressing/>"); //301:1
                __out.AppendLine(false); //301:19
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
