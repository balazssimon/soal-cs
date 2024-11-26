#pragma warning disable CS8669
#line (1,10)-(1,44) 10 "SoalPrinter.mxg"
namespace MetaDslx.Languages.Soal.Generator
#line hidden

{
    #line (3,1)-(3,6) 5 "SoalPrinter.mxg"
    using
    #line hidden
    global::
    #line (3,7)-(3,13) 13 "SoalPrinter.mxg"
    System;
    #line hidden
    #line (4,1)-(4,6) 5 "SoalPrinter.mxg"
    using
    #line hidden
    global::
    #line (4,7)-(4,33) 13 "SoalPrinter.mxg"
    System.Collections.Generic;
    #line hidden
    #line (5,1)-(5,6) 5 "SoalPrinter.mxg"
    using
    #line hidden
    global::
    #line (5,7)-(5,18) 13 "SoalPrinter.mxg"
    System.Linq;
    #line hidden
    #line (6,1)-(6,6) 5 "SoalPrinter.mxg"
    using
    #line hidden
    global::
    #line (6,7)-(6,24) 13 "SoalPrinter.mxg"
    MetaDslx.Modeling;
    #line hidden
    #line (7,1)-(7,6) 5 "SoalPrinter.mxg"
    using
    #line hidden
    global::
    #line (7,7)-(7,38) 13 "SoalPrinter.mxg"
    MetaDslx.Languages.Soal.Symbols;
    #line hidden
    
    #line (9,10)-(9,22) 25 "SoalPrinter.mxg"
    public partial class SoalPrinter
    #line hidden
    {
        #line (11,9)-(11,53) 22 "SoalPrinter.mxg"
        public string Generate(IEnumerable<Namespace> namespaces)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            var __first14 = true;
            #line (12,3)-(12,33) 13 "SoalPrinter.mxg"
            foreach (var ns in namespaces)
            #line hidden
            
            {
                if (__first14)
                {
                    __first14 = false;
                }
                __cb.Push("");
                #line (13,3)-(13,24) 28 "SoalPrinter.mxg"
                __cb.Write(GenerateNamespace(ns));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first14) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (17,9)-(17,41) 22 "SoalPrinter.mxg"
        public string GenerateNamespace(Namespace ns)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            var __first15 = true;
            #line (18,3)-(18,65) 13 "SoalPrinter.mxg"
            if (ns.Declarations.Where(d => !(d is Namespace)).Count() > 0)
            #line hidden
            
            {
                if (__first15)
                {
                    __first15 = false;
                }
                var __first16 = true;
                #line (19,4)-(19,26) 17 "SoalPrinter.mxg"
                if (ns.Prefix != null)
                #line hidden
                
                {
                    if (__first16)
                    {
                        __first16 = false;
                    }
                    __cb.Push("");
                    #line (20,3)-(20,12) 33 "SoalPrinter.mxg"
                    __cb.Write("namespace");
                    #line hidden
                    #line (20,12)-(20,13) 33 "SoalPrinter.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (20,14)-(20,25) 32 "SoalPrinter.mxg"
                    __cb.Write(ns.FullName);
                    #line hidden
                    #line (20,26)-(20,27) 33 "SoalPrinter.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (20,27)-(20,28) 33 "SoalPrinter.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (20,28)-(20,29) 33 "SoalPrinter.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (20,30)-(20,39) 32 "SoalPrinter.mxg"
                    __cb.Write(ns.Prefix);
                    #line hidden
                    #line (20,40)-(20,42) 33 "SoalPrinter.mxg"
                    __cb.Write(":\"");
                    #line hidden
                    #line (20,43)-(20,49) 32 "SoalPrinter.mxg"
                    __cb.Write(ns.Uri);
                    #line hidden
                    #line (20,50)-(20,51) 33 "SoalPrinter.mxg"
                    __cb.Write("\"");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (21,4)-(21,8) 17 "SoalPrinter.mxg"
                else
                #line hidden
                
                {
                    if (__first16)
                    {
                        __first16 = false;
                    }
                    __cb.Push("");
                    #line (22,3)-(22,12) 33 "SoalPrinter.mxg"
                    __cb.Write("namespace");
                    #line hidden
                    #line (22,12)-(22,13) 33 "SoalPrinter.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (22,14)-(22,25) 32 "SoalPrinter.mxg"
                    __cb.Write(ns.FullName);
                    #line hidden
                    #line (22,26)-(22,27) 33 "SoalPrinter.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (22,27)-(22,28) 33 "SoalPrinter.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (22,28)-(22,29) 33 "SoalPrinter.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (22,29)-(22,30) 33 "SoalPrinter.mxg"
                    __cb.Write("\"");
                    #line hidden
                    #line (22,31)-(22,37) 32 "SoalPrinter.mxg"
                    __cb.Write(ns.Uri);
                    #line hidden
                    #line (22,38)-(22,39) 33 "SoalPrinter.mxg"
                    __cb.Write("\"");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first16) __cb.AppendLine();
                __cb.Push("");
                #line (24,3)-(24,4) 29 "SoalPrinter.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                var __first17 = true;
                #line (25,5)-(25,64) 17 "SoalPrinter.mxg"
                foreach (var enm in ns.Declarations.OfType<Symbols.Enum>())
                #line hidden
                
                {
                    if (__first17)
                    {
                        __first17 = false;
                    }
                    __cb.Push("\t");
                    #line (26,6)-(26,27) 32 "SoalPrinter.mxg"
                    __cb.Write(GenerateEnum(ns, enm));
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.WriteLine();
                    __cb.Pop();
                }
                if (!__first17) __cb.AppendLine();
                var __first18 = true;
                #line (29,5)-(29,65) 17 "SoalPrinter.mxg"
                foreach (var st in ns.Declarations.OfType<Symbols.Struct>())
                #line hidden
                
                {
                    if (__first18)
                    {
                        __first18 = false;
                    }
                    __cb.Push("\t");
                    #line (30,6)-(30,28) 32 "SoalPrinter.mxg"
                    __cb.Write(GenerateStruct(ns, st));
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.WriteLine();
                    __cb.Pop();
                }
                if (!__first18) __cb.AppendLine();
                var __first19 = true;
                #line (33,5)-(33,70) 17 "SoalPrinter.mxg"
                foreach (var intf in ns.Declarations.OfType<Symbols.Interface>())
                #line hidden
                
                {
                    if (__first19)
                    {
                        __first19 = false;
                    }
                    __cb.Push("\t");
                    #line (34,6)-(34,33) 32 "SoalPrinter.mxg"
                    __cb.Write(GenerateInterface(ns, intf));
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.WriteLine();
                    __cb.Pop();
                }
                if (!__first19) __cb.AppendLine();
                var __first20 = true;
                #line (37,5)-(37,67) 17 "SoalPrinter.mxg"
                foreach (var bnd in ns.Declarations.OfType<Symbols.Binding>())
                #line hidden
                
                {
                    if (__first20)
                    {
                        __first20 = false;
                    }
                    __cb.Push("\t");
                    #line (38,6)-(38,30) 32 "SoalPrinter.mxg"
                    __cb.Write(GenerateBinding(ns, bnd));
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.WriteLine();
                    __cb.Pop();
                }
                if (!__first20) __cb.AppendLine();
                var __first21 = true;
                #line (41,5)-(41,69) 17 "SoalPrinter.mxg"
                foreach (var endp in ns.Declarations.OfType<Symbols.Endpoint>())
                #line hidden
                
                {
                    if (__first21)
                    {
                        __first21 = false;
                    }
                    __cb.Push("\t");
                    #line (42,6)-(42,32) 32 "SoalPrinter.mxg"
                    __cb.Write(GenerateEndpoint(ns, endp));
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.WriteLine();
                    __cb.Pop();
                }
                if (!__first21) __cb.AppendLine();
                __cb.Push("");
                #line (45,3)-(45,4) 29 "SoalPrinter.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first15) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (50,9)-(50,53) 22 "SoalPrinter.mxg"
        public string GenerateDocumentation(DocumentedElement de)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            var __first22 = true;
            #line (51,3)-(51,51) 13 "SoalPrinter.mxg"
            foreach (var line in de.GetDocumentationLines())
            #line hidden
            
            {
                if (__first22)
                {
                    __first22 = false;
                }
                __cb.Push("");
                #line (52,3)-(52,6) 29 "SoalPrinter.mxg"
                __cb.Write("///");
                #line hidden
                #line (52,6)-(52,7) 29 "SoalPrinter.mxg"
                __cb.Write(" ");
                #line hidden
                #line (52,8)-(52,12) 28 "SoalPrinter.mxg"
                __cb.Write(line);
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first22) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (56,9)-(56,65) 22 "SoalPrinter.mxg"
        public string GenerateAnnotations(AnnotatedElement ae, bool isReturn)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            var __first23 = true;
            #line (57,3)-(57,40) 13 "SoalPrinter.mxg"
            foreach (var annot in ae.Annotations)
            #line hidden
            
            {
                if (__first23)
                {
                    __first23 = false;
                }
                __cb.Push("");
                #line (58,4)-(58,7) 28 "SoalPrinter.mxg"
                __cb.Write("[");
                #line hidden
                #line (58,9)-(58,35) 28 "SoalPrinter.mxg"
                __cb.Write(isReturn ? "return: " : "");
                #line hidden
                #line (58,37)-(58,47) 28 "SoalPrinter.mxg"
                __cb.Write(annot.Name);
                #line hidden
                var __first24 = true;
                #line (58,49)-(58,79) 17 "SoalPrinter.mxg"
                if(annot.Properties.Count > 0)
                #line hidden
                
                {
                    if (__first24)
                    {
                        __first24 = false;
                    }
                    #line (58,80)-(58,81) 33 "SoalPrinter.mxg"
                    __cb.Write("(");
                    #line hidden
                    #line (58,82)-(58,117) 32 "SoalPrinter.mxg"
                    __cb.Write(GenerateAnnotationProperties(annot));
                    #line hidden
                    #line (58,118)-(58,119) 33 "SoalPrinter.mxg"
                    __cb.Write(")");
                    #line hidden
                }
                #line (58,128)-(58,131) 28 "SoalPrinter.mxg"
                __cb.Write("]");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first23) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (62,9)-(62,75) 22 "SoalPrinter.mxg"
        public string GenerateAnnotationsSingleLine(AnnotatedElement ae, bool isReturn)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.SingleLineMode = true;
            var __first25 = true;
            #line (64,3)-(64,40) 13 "SoalPrinter.mxg"
            foreach (var annot in ae.Annotations)
            #line hidden
            
            {
                if (__first25)
                {
                    __first25 = false;
                }
                __cb.Push("");
                #line (65,4)-(65,7) 28 "SoalPrinter.mxg"
                __cb.Write("[");
                #line hidden
                #line (65,9)-(65,35) 28 "SoalPrinter.mxg"
                __cb.Write(isReturn ? "return: " : "");
                #line hidden
                #line (65,37)-(65,47) 28 "SoalPrinter.mxg"
                __cb.Write(annot.Name);
                #line hidden
                var __first26 = true;
                #line (65,49)-(65,79) 17 "SoalPrinter.mxg"
                if(annot.Properties.Count > 0)
                #line hidden
                
                {
                    if (__first26)
                    {
                        __first26 = false;
                    }
                    #line (65,80)-(65,81) 33 "SoalPrinter.mxg"
                    __cb.Write("(");
                    #line hidden
                    #line (65,82)-(65,117) 32 "SoalPrinter.mxg"
                    __cb.Write(GenerateAnnotationProperties(annot));
                    #line hidden
                    #line (65,118)-(65,119) 33 "SoalPrinter.mxg"
                    __cb.Write(")");
                    #line hidden
                }
                #line (65,128)-(65,132) 28 "SoalPrinter.mxg"
                __cb.Write("] ");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first25) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (69,9)-(69,56) 22 "SoalPrinter.mxg"
        public string GenerateAnnotationProperties(Annotation annot)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.SingleLineMode = true;
            var __first27 = true;
            #line (71,3)-(71,42) 13 "SoalPrinter.mxg"
            foreach (var prop in annot.Properties) 
            #line hidden
            
            {
                if (__first27)
                {
                    __first27 = false;
                }
                else
                {
                    __cb.Push("");
                    __cb.DontIgnoreLastLineEnd = true;
                    #line (71,52)-(71,56) 32 "SoalPrinter.mxg"
                    __cb.Write(", ");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                __cb.Push("");
                #line (72,4)-(72,13) 28 "SoalPrinter.mxg"
                __cb.Write(prop.Name);
                #line hidden
                #line (72,14)-(72,15) 29 "SoalPrinter.mxg"
                __cb.Write("=");
                #line hidden
                #line (72,16)-(72,48) 28 "SoalPrinter.mxg"
                __cb.Write(GetAnnotationPropertyValue(prop));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first27) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (76,9)-(76,61) 22 "SoalPrinter.mxg"
        public string GenerateEnum(Namespace currentNs, Symbols.Enum enm)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (77,3)-(77,29) 24 "SoalPrinter.mxg"
            __cb.Write(GenerateDocumentation(enm));
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (78,3)-(78,34) 24 "SoalPrinter.mxg"
            __cb.Write(GenerateAnnotations(enm, false));
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (79,2)-(79,6) 25 "SoalPrinter.mxg"
            __cb.Write("enum");
            #line hidden
            #line (79,6)-(79,7) 25 "SoalPrinter.mxg"
            __cb.Write(" ");
            #line hidden
            #line (79,8)-(79,16) 24 "SoalPrinter.mxg"
            __cb.Write(enm.Name);
            #line hidden
            #line (79,18)-(79,45) 24 "SoalPrinter.mxg"
            __cb.Write(GetAncestor(currentNs, enm));
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (80,2)-(80,3) 25 "SoalPrinter.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first28 = true;
            #line (81,4)-(81,52) 13 "SoalPrinter.mxg"
            for (int i = 0; i < enm.EnumLiterals.Count; ++i)
            #line hidden
            
            {
                if (__first28)
                {
                    __first28 = false;
                }
                #line (82,5)-(82,34) 17 "SoalPrinter.mxg"
                var lit = enm.EnumLiterals[i];
                #line hidden
                
                __cb.Push("\t");
                #line (83,5)-(83,81) 28 "SoalPrinter.mxg"
                __cb.Write(GenerateEnumLiteral(currentNs, lit, i+1 < enm.EnumLiterals.Count ? "," : ""));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first28) __cb.AppendLine();
            __cb.Push("");
            #line (85,2)-(85,3) 25 "SoalPrinter.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (88,9)-(88,81) 22 "SoalPrinter.mxg"
        public string GenerateEnumLiteral(Namespace currentNs, EnumLiteral lit, string delim)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (89,3)-(89,29) 24 "SoalPrinter.mxg"
            __cb.Write(GenerateDocumentation(lit));
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (90,3)-(90,34) 24 "SoalPrinter.mxg"
            __cb.Write(GenerateAnnotations(lit, false));
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (91,3)-(91,11) 24 "SoalPrinter.mxg"
            __cb.Write(lit.Name);
            #line hidden
            #line (91,13)-(91,18) 24 "SoalPrinter.mxg"
            __cb.Write(delim);
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (94,9)-(94,56) 22 "SoalPrinter.mxg"
        public string GenerateStruct(Namespace currentNs, Struct st)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (95,3)-(95,28) 24 "SoalPrinter.mxg"
            __cb.Write(GenerateDocumentation(st));
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (96,3)-(96,33) 24 "SoalPrinter.mxg"
            __cb.Write(GenerateAnnotations(st, false));
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (97,2)-(97,8) 25 "SoalPrinter.mxg"
            __cb.Write("struct");
            #line hidden
            #line (97,8)-(97,9) 25 "SoalPrinter.mxg"
            __cb.Write(" ");
            #line hidden
            #line (97,10)-(97,17) 24 "SoalPrinter.mxg"
            __cb.Write(st.Name);
            #line hidden
            #line (97,19)-(97,45) 24 "SoalPrinter.mxg"
            __cb.Write(GetAncestor(currentNs, st));
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (98,2)-(98,3) 25 "SoalPrinter.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first29 = true;
            #line (99,4)-(99,39) 13 "SoalPrinter.mxg"
            foreach (var prop in st.Properties)
            #line hidden
            
            {
                if (__first29)
                {
                    __first29 = false;
                }
                __cb.Push("\t");
                #line (100,5)-(100,38) 28 "SoalPrinter.mxg"
                __cb.Write(GenerateProperty(currentNs, prop));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first29) __cb.AppendLine();
            __cb.Push("");
            #line (102,2)-(102,3) 25 "SoalPrinter.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (105,9)-(105,62) 22 "SoalPrinter.mxg"
        public string GenerateProperty(Namespace currentNs, Property prop)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (106,3)-(106,30) 24 "SoalPrinter.mxg"
            __cb.Write(GenerateDocumentation(prop));
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (107,3)-(107,35) 24 "SoalPrinter.mxg"
            __cb.Write(GenerateAnnotations(prop, false));
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (108,3)-(108,37) 24 "SoalPrinter.mxg"
            __cb.Write(GenerateType(currentNs, prop.Type));
            #line hidden
            #line (108,38)-(108,39) 25 "SoalPrinter.mxg"
            __cb.Write(" ");
            #line hidden
            #line (108,40)-(108,49) 24 "SoalPrinter.mxg"
            __cb.Write(prop.Name);
            #line hidden
            #line (108,50)-(108,51) 25 "SoalPrinter.mxg"
            __cb.Write(";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (111,9)-(111,60) 22 "SoalPrinter.mxg"
        public string GenerateRef(Namespace currentNs, Declaration decl)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.SingleLineMode = true;
            var __first30 = true;
            #line (113,3)-(113,20) 13 "SoalPrinter.mxg"
            if (decl != null)
            #line hidden
            
            {
                if (__first30)
                {
                    __first30 = false;
                }
                var __first31 = true;
                #line (114,4)-(114,36) 17 "SoalPrinter.mxg"
                if (decl.Namespace != currentNs)
                #line hidden
                
                {
                    if (__first31)
                    {
                        __first31 = false;
                    }
                    __cb.Push("");
                    #line (115,5)-(115,18) 32 "SoalPrinter.mxg"
                    __cb.Write(decl.FullName);
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (116,4)-(116,8) 17 "SoalPrinter.mxg"
                else
                #line hidden
                
                {
                    if (__first31)
                    {
                        __first31 = false;
                    }
                    __cb.Push("");
                    #line (117,5)-(117,14) 32 "SoalPrinter.mxg"
                    __cb.Write(decl.Name);
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first31) __cb.AppendLine();
            }
            if (!__first30) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (122,9)-(122,55) 22 "SoalPrinter.mxg"
        public string GenerateType(Namespace currentNs, SoalType t)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.SingleLineMode = true;
            var __first32 = true;
            #line (124,3)-(124,26) 13 "SoalPrinter.mxg"
            if (t is PrimitiveType)
            #line hidden
            
            {
                if (__first32)
                {
                    __first32 = false;
                }
                __cb.Push("");
                #line (125,4)-(125,27) 28 "SoalPrinter.mxg"
                __cb.Write(((PrimitiveType)t).Name);
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            #line (126,3)-(126,30) 13 "SoalPrinter.mxg"
            else if (t is NullableType)
            #line hidden
            
            {
                if (__first32)
                {
                    __first32 = false;
                }
                __cb.Push("");
                #line (127,4)-(127,56) 28 "SoalPrinter.mxg"
                __cb.Write(GenerateType(currentNs, ((NullableType)t).InnerType));
                #line hidden
                #line (127,57)-(127,58) 29 "SoalPrinter.mxg"
                __cb.Write("?");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            #line (128,3)-(128,27) 13 "SoalPrinter.mxg"
            else if (t is ArrayType)
            #line hidden
            
            {
                if (__first32)
                {
                    __first32 = false;
                }
                __cb.Push("");
                #line (129,4)-(129,53) 28 "SoalPrinter.mxg"
                __cb.Write(GenerateType(currentNs, ((ArrayType)t).InnerType));
                #line hidden
                #line (129,55)-(129,59) 28 "SoalPrinter.mxg"
                __cb.Write("[]");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            #line (130,3)-(130,29) 13 "SoalPrinter.mxg"
            else if (t is Declaration)
            #line hidden
            
            {
                if (__first32)
                {
                    __first32 = false;
                }
                __cb.Push("");
                #line (131,4)-(131,42) 28 "SoalPrinter.mxg"
                __cb.Write(GenerateRef(currentNs, (Declaration)t));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            #line (132,3)-(132,7) 13 "SoalPrinter.mxg"
            else
            #line hidden
            
            {
                if (__first32)
                {
                    __first32 = false;
                }
                __cb.Push("");
                #line (133,4)-(133,5) 28 "SoalPrinter.mxg"
                __cb.Write(t);
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first32) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (137,9)-(137,63) 22 "SoalPrinter.mxg"
        public string GenerateReturnType(Namespace currentNs, Operation op)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.SingleLineMode = true;
            var __first33 = true;
            #line (139,3)-(139,26) 13 "SoalPrinter.mxg"
            if (op.Result.IsOneway)
            #line hidden
            
            {
                if (__first33)
                {
                    __first33 = false;
                }
                __cb.Push("");
                #line (140,3)-(140,9) 29 "SoalPrinter.mxg"
                __cb.Write("oneway");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            #line (141,3)-(141,7) 13 "SoalPrinter.mxg"
            else
            #line hidden
            
            {
                if (__first33)
                {
                    __first33 = false;
                }
                __cb.Push("");
                #line (142,4)-(142,43) 28 "SoalPrinter.mxg"
                __cb.Write(GenerateType(currentNs, op.Result.Type));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first33) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (146,9)-(146,59) 22 "SoalPrinter.mxg"
        public string GenerateThrows(Namespace currentNs, Operation op)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.SingleLineMode = true;
            var __first34 = true;
            #line (148,3)-(148,31) 13 "SoalPrinter.mxg"
            if (op.Exceptions.Count > 0)
            #line hidden
            
            {
                if (__first34)
                {
                    __first34 = false;
                }
                __cb.Push("");
                #line (149,3)-(149,9) 29 "SoalPrinter.mxg"
                __cb.Write("throws");
                #line hidden
                #line (149,9)-(149,10) 29 "SoalPrinter.mxg"
                __cb.Write(" ");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                var __first35 = true;
                #line (150,4)-(150,38) 17 "SoalPrinter.mxg"
                foreach (var ex in op.Exceptions) 
                #line hidden
                
                {
                    if (__first35)
                    {
                        __first35 = false;
                    }
                    else
                    {
                        __cb.Push("");
                        __cb.DontIgnoreLastLineEnd = true;
                        #line (150,48)-(150,52) 36 "SoalPrinter.mxg"
                        __cb.Write(", ");
                        #line hidden
                        __cb.DontIgnoreLastLineEnd = false;
                        __cb.Pop();
                    }
                    __cb.Push("");
                    #line (151,5)-(151,32) 32 "SoalPrinter.mxg"
                    __cb.Write(GenerateType(currentNs, ex));
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first35) __cb.AppendLine();
            }
            if (!__first34) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (156,9)-(156,63) 22 "SoalPrinter.mxg"
        public string GenerateParameters(Namespace currentNs, Operation op)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.SingleLineMode = true;
            var __first36 = true;
            #line (158,3)-(158,36) 13 "SoalPrinter.mxg"
            foreach (var p in op.Parameters) 
            #line hidden
            
            {
                if (__first36)
                {
                    __first36 = false;
                }
                else
                {
                    __cb.Push("");
                    __cb.DontIgnoreLastLineEnd = true;
                    #line (158,46)-(158,50) 32 "SoalPrinter.mxg"
                    __cb.Write(", ");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                __cb.Push("");
                #line (159,4)-(159,43) 28 "SoalPrinter.mxg"
                __cb.Write(GenerateAnnotationsSingleLine(p, false));
                #line hidden
                #line (159,45)-(159,76) 28 "SoalPrinter.mxg"
                __cb.Write(GenerateType(currentNs, p.Type));
                #line hidden
                #line (159,77)-(159,78) 29 "SoalPrinter.mxg"
                __cb.Write(" ");
                #line hidden
                #line (159,79)-(159,85) 28 "SoalPrinter.mxg"
                __cb.Write(p.Name);
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first36) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (163,9)-(163,62) 22 "SoalPrinter.mxg"
        public string GenerateOperation(Namespace currentNs, Operation op)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (164,3)-(164,28) 24 "SoalPrinter.mxg"
            __cb.Write(GenerateDocumentation(op));
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (165,3)-(165,33) 24 "SoalPrinter.mxg"
            __cb.Write(GenerateAnnotations(op, false));
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (166,3)-(166,39) 24 "SoalPrinter.mxg"
            __cb.Write(GenerateAnnotations(op.Result, true));
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (167,3)-(167,36) 24 "SoalPrinter.mxg"
            __cb.Write(GenerateReturnType(currentNs, op));
            #line hidden
            #line (167,37)-(167,38) 25 "SoalPrinter.mxg"
            __cb.Write(" ");
            #line hidden
            #line (167,39)-(167,46) 24 "SoalPrinter.mxg"
            __cb.Write(op.Name);
            #line hidden
            #line (167,47)-(167,48) 25 "SoalPrinter.mxg"
            __cb.Write("(");
            #line hidden
            #line (167,49)-(167,82) 24 "SoalPrinter.mxg"
            __cb.Write(GenerateParameters(currentNs, op));
            #line hidden
            #line (167,83)-(167,84) 25 "SoalPrinter.mxg"
            __cb.Write(")");
            #line hidden
            #line (167,85)-(167,114) 24 "SoalPrinter.mxg"
            __cb.Write(GenerateThrows(currentNs, op));
            #line hidden
            #line (167,115)-(167,116) 25 "SoalPrinter.mxg"
            __cb.Write(";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (170,9)-(170,64) 22 "SoalPrinter.mxg"
        public string GenerateInterface(Namespace currentNs, Interface intf)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (171,3)-(171,30) 24 "SoalPrinter.mxg"
            __cb.Write(GenerateDocumentation(intf));
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (172,3)-(172,35) 24 "SoalPrinter.mxg"
            __cb.Write(GenerateAnnotations(intf, false));
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (173,2)-(173,11) 25 "SoalPrinter.mxg"
            __cb.Write("interface");
            #line hidden
            #line (173,11)-(173,12) 25 "SoalPrinter.mxg"
            __cb.Write(" ");
            #line hidden
            #line (173,13)-(173,22) 24 "SoalPrinter.mxg"
            __cb.Write(intf.Name);
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (174,2)-(174,3) 25 "SoalPrinter.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first37 = true;
            #line (175,4)-(175,39) 13 "SoalPrinter.mxg"
            foreach (var op in intf.Operations)
            #line hidden
            
            {
                if (__first37)
                {
                    __first37 = false;
                }
                __cb.Push("\t");
                #line (176,5)-(176,37) 28 "SoalPrinter.mxg"
                __cb.Write(GenerateOperation(currentNs, op));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first37) __cb.AppendLine();
            __cb.Push("");
            #line (178,2)-(178,3) 25 "SoalPrinter.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (181,9)-(181,84) 22 "SoalPrinter.mxg"
        public string GenerateTransportBinding(Namespace currentNs, TransportBindingElement bnd)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            var __first38 = true;
            #line (182,3)-(182,47) 13 "SoalPrinter.mxg"
            if (bnd is HttpTransportBindingElement htbe)
            #line hidden
            
            {
                if (__first38)
                {
                    __first38 = false;
                }
                var __first39 = true;
                #line (183,4)-(183,17) 17 "SoalPrinter.mxg"
                if (htbe.Ssl)
                #line hidden
                
                {
                    if (__first39)
                    {
                        __first39 = false;
                    }
                    __cb.Push("");
                    #line (184,4)-(184,13) 33 "SoalPrinter.mxg"
                    __cb.Write("transport");
                    #line hidden
                    #line (184,13)-(184,14) 33 "SoalPrinter.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (184,14)-(184,18) 33 "SoalPrinter.mxg"
                    __cb.Write("HTTP");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("");
                    #line (185,4)-(185,5) 33 "SoalPrinter.mxg"
                    __cb.Write("{");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("\t");
                    #line (186,5)-(186,8) 33 "SoalPrinter.mxg"
                    __cb.Write("Ssl");
                    #line hidden
                    #line (186,8)-(186,9) 33 "SoalPrinter.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (186,9)-(186,10) 33 "SoalPrinter.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (186,10)-(186,11) 33 "SoalPrinter.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (186,11)-(186,16) 33 "SoalPrinter.mxg"
                    __cb.Write("true;");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("\t");
                    #line (187,5)-(187,25) 33 "SoalPrinter.mxg"
                    __cb.Write("ClientAuthentication");
                    #line hidden
                    #line (187,25)-(187,26) 33 "SoalPrinter.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (187,26)-(187,27) 33 "SoalPrinter.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (187,27)-(187,28) 33 "SoalPrinter.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (187,29)-(187,75) 32 "SoalPrinter.mxg"
                    __cb.Write(htbe.ClientAuthentication.ToString().ToLower());
                    #line hidden
                    #line (187,76)-(187,77) 33 "SoalPrinter.mxg"
                    __cb.Write(";");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("");
                    #line (188,4)-(188,5) 33 "SoalPrinter.mxg"
                    __cb.Write("}");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (189,4)-(189,8) 17 "SoalPrinter.mxg"
                else
                #line hidden
                
                {
                    if (__first39)
                    {
                        __first39 = false;
                    }
                    __cb.Push("");
                    #line (190,4)-(190,13) 33 "SoalPrinter.mxg"
                    __cb.Write("transport");
                    #line hidden
                    #line (190,13)-(190,14) 33 "SoalPrinter.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (190,14)-(190,19) 33 "SoalPrinter.mxg"
                    __cb.Write("HTTP;");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first39) __cb.AppendLine();
            }
            #line (192,3)-(192,52) 13 "SoalPrinter.mxg"
            else if (bnd is RestTransportBindingElement rtbe)
            #line hidden
            
            {
                if (__first38)
                {
                    __first38 = false;
                }
                __cb.Push("");
                #line (193,3)-(193,12) 29 "SoalPrinter.mxg"
                __cb.Write("transport");
                #line hidden
                #line (193,12)-(193,13) 29 "SoalPrinter.mxg"
                __cb.Write(" ");
                #line hidden
                #line (193,13)-(193,18) 29 "SoalPrinter.mxg"
                __cb.Write("REST;");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            #line (194,3)-(194,57) 13 "SoalPrinter.mxg"
            else if (bnd is WebSocketTransportBindingElement wtbe)
            #line hidden
            
            {
                if (__first38)
                {
                    __first38 = false;
                }
                __cb.Push("");
                #line (195,3)-(195,12) 29 "SoalPrinter.mxg"
                __cb.Write("transport");
                #line hidden
                #line (195,12)-(195,13) 29 "SoalPrinter.mxg"
                __cb.Write(" ");
                #line hidden
                #line (195,13)-(195,23) 29 "SoalPrinter.mxg"
                __cb.Write("WebSocket;");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first38) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (199,9)-(199,82) 22 "SoalPrinter.mxg"
        public string GenerateEncodingBinding(Namespace currentNs, EncodingBindingElement bnd)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            var __first40 = true;
            #line (200,3)-(200,46) 13 "SoalPrinter.mxg"
            if (bnd is SoapEncodingBindingElement sebe)
            #line hidden
            
            {
                if (__first40)
                {
                    __first40 = false;
                }
                var __first41 = true;
                #line (201,4)-(201,107) 17 "SoalPrinter.mxg"
                if (sebe.Style != SoapEncodingStyle.DocumentWrapped || sebe.Version != SoapVersion.Soap11 || sebe.Mtom)
                #line hidden
                
                {
                    if (__first41)
                    {
                        __first41 = false;
                    }
                    __cb.Push("");
                    #line (202,4)-(202,12) 33 "SoalPrinter.mxg"
                    __cb.Write("encoding");
                    #line hidden
                    #line (202,12)-(202,13) 33 "SoalPrinter.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (202,13)-(202,17) 33 "SoalPrinter.mxg"
                    __cb.Write("SOAP");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("");
                    #line (203,4)-(203,5) 33 "SoalPrinter.mxg"
                    __cb.Write("{");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    var __first42 = true;
                    #line (204,6)-(204,58) 21 "SoalPrinter.mxg"
                    if (sebe.Style != SoapEncodingStyle.DocumentWrapped)
                    #line hidden
                    
                    {
                        if (__first42)
                        {
                            __first42 = false;
                        }
                        __cb.Push("\t");
                        #line (205,5)-(205,10) 37 "SoalPrinter.mxg"
                        __cb.Write("Style");
                        #line hidden
                        #line (205,10)-(205,11) 37 "SoalPrinter.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (205,11)-(205,12) 37 "SoalPrinter.mxg"
                        __cb.Write("=");
                        #line hidden
                        #line (205,12)-(205,13) 37 "SoalPrinter.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (205,14)-(205,24) 36 "SoalPrinter.mxg"
                        __cb.Write(sebe.Style);
                        #line hidden
                        #line (205,25)-(205,26) 37 "SoalPrinter.mxg"
                        __cb.Write(";");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first42) __cb.AppendLine();
                    var __first43 = true;
                    #line (207,6)-(207,45) 21 "SoalPrinter.mxg"
                    if (sebe.Version != SoapVersion.Soap11)
                    #line hidden
                    
                    {
                        if (__first43)
                        {
                            __first43 = false;
                        }
                        __cb.Push("\t");
                        #line (208,5)-(208,12) 37 "SoalPrinter.mxg"
                        __cb.Write("Version");
                        #line hidden
                        #line (208,12)-(208,13) 37 "SoalPrinter.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (208,13)-(208,14) 37 "SoalPrinter.mxg"
                        __cb.Write("=");
                        #line hidden
                        #line (208,14)-(208,15) 37 "SoalPrinter.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (208,16)-(208,28) 36 "SoalPrinter.mxg"
                        __cb.Write(sebe.Version);
                        #line hidden
                        #line (208,29)-(208,30) 37 "SoalPrinter.mxg"
                        __cb.Write(";");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first43) __cb.AppendLine();
                    var __first44 = true;
                    #line (210,6)-(210,20) 21 "SoalPrinter.mxg"
                    if (sebe.Mtom)
                    #line hidden
                    
                    {
                        if (__first44)
                        {
                            __first44 = false;
                        }
                        __cb.Push("\t");
                        #line (211,5)-(211,9) 37 "SoalPrinter.mxg"
                        __cb.Write("Mtom");
                        #line hidden
                        #line (211,9)-(211,10) 37 "SoalPrinter.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (211,10)-(211,11) 37 "SoalPrinter.mxg"
                        __cb.Write("=");
                        #line hidden
                        #line (211,11)-(211,12) 37 "SoalPrinter.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (211,12)-(211,17) 37 "SoalPrinter.mxg"
                        __cb.Write("true;");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first44) __cb.AppendLine();
                    __cb.Push("");
                    #line (213,4)-(213,5) 33 "SoalPrinter.mxg"
                    __cb.Write("}");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (214,4)-(214,8) 17 "SoalPrinter.mxg"
                else
                #line hidden
                
                {
                    if (__first41)
                    {
                        __first41 = false;
                    }
                    __cb.Push("");
                    #line (215,4)-(215,12) 33 "SoalPrinter.mxg"
                    __cb.Write("encoding");
                    #line hidden
                    #line (215,12)-(215,13) 33 "SoalPrinter.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (215,13)-(215,18) 33 "SoalPrinter.mxg"
                    __cb.Write("SOAP;");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first41) __cb.AppendLine();
            }
            #line (217,3)-(217,50) 13 "SoalPrinter.mxg"
            else if (bnd is XmlEncodingBindingElement xebe)
            #line hidden
            
            {
                if (__first40)
                {
                    __first40 = false;
                }
                __cb.Push("");
                #line (218,3)-(218,11) 29 "SoalPrinter.mxg"
                __cb.Write("encoding");
                #line hidden
                #line (218,11)-(218,12) 29 "SoalPrinter.mxg"
                __cb.Write(" ");
                #line hidden
                #line (218,12)-(218,16) 29 "SoalPrinter.mxg"
                __cb.Write("XML;");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            #line (219,3)-(219,51) 13 "SoalPrinter.mxg"
            else if (bnd is JsonEncodingBindingElement jebe)
            #line hidden
            
            {
                if (__first40)
                {
                    __first40 = false;
                }
                __cb.Push("");
                #line (220,3)-(220,11) 29 "SoalPrinter.mxg"
                __cb.Write("encoding");
                #line hidden
                #line (220,11)-(220,12) 29 "SoalPrinter.mxg"
                __cb.Write(" ");
                #line hidden
                #line (220,12)-(220,17) 29 "SoalPrinter.mxg"
                __cb.Write("JSON;");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first40) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (224,9)-(224,82) 22 "SoalPrinter.mxg"
        public string GenerateProtocolBinding(Namespace currentNs, ProtocolBindingElement bnd)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            var __first45 = true;
            #line (225,3)-(225,41) 13 "SoalPrinter.mxg"
            if (bnd is WsAddressingBindingElement)
            #line hidden
            
            {
                if (__first45)
                {
                    __first45 = false;
                }
                __cb.Push("");
                #line (226,3)-(226,11) 29 "SoalPrinter.mxg"
                __cb.Write("protocol");
                #line hidden
                #line (226,11)-(226,12) 29 "SoalPrinter.mxg"
                __cb.Write(" ");
                #line hidden
                #line (226,12)-(226,25) 29 "SoalPrinter.mxg"
                __cb.Write("WsAddressing;");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first45) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (230,9)-(230,67) 22 "SoalPrinter.mxg"
        public string GenerateBinding(Namespace currentNs, Symbols.Binding bnd)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (231,2)-(231,9) 25 "SoalPrinter.mxg"
            __cb.Write("binding");
            #line hidden
            #line (231,9)-(231,10) 25 "SoalPrinter.mxg"
            __cb.Write(" ");
            #line hidden
            #line (231,11)-(231,19) 24 "SoalPrinter.mxg"
            __cb.Write(bnd.Name);
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (232,2)-(232,3) 25 "SoalPrinter.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("\t");
            #line (233,4)-(233,54) 24 "SoalPrinter.mxg"
            __cb.Write(GenerateTransportBinding(currentNs, bnd.Transport));
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first46 = true;
            #line (234,4)-(234,38) 13 "SoalPrinter.mxg"
            foreach (var enc in bnd.Encodings)
            #line hidden
            
            {
                if (__first46)
                {
                    __first46 = false;
                }
                __cb.Push("\t");
                #line (235,5)-(235,44) 28 "SoalPrinter.mxg"
                __cb.Write(GenerateEncodingBinding(currentNs, enc));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first46) __cb.AppendLine();
            var __first47 = true;
            #line (237,4)-(237,39) 13 "SoalPrinter.mxg"
            foreach (var prot in bnd.Protocols)
            #line hidden
            
            {
                if (__first47)
                {
                    __first47 = false;
                }
                __cb.Push("\t");
                #line (238,5)-(238,45) 28 "SoalPrinter.mxg"
                __cb.Write(GenerateProtocolBinding(currentNs, prot));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first47) __cb.AppendLine();
            __cb.Push("");
            #line (240,2)-(240,3) 25 "SoalPrinter.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (243,9)-(243,62) 22 "SoalPrinter.mxg"
        public string GenerateEndpoint(Namespace currentNs, Endpoint endp)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (244,2)-(244,10) 25 "SoalPrinter.mxg"
            __cb.Write("endpoint");
            #line hidden
            #line (244,10)-(244,11) 25 "SoalPrinter.mxg"
            __cb.Write(" ");
            #line hidden
            #line (244,12)-(244,21) 24 "SoalPrinter.mxg"
            __cb.Write(endp.Name);
            #line hidden
            #line (244,22)-(244,23) 25 "SoalPrinter.mxg"
            __cb.Write(" ");
            #line hidden
            #line (244,23)-(244,24) 25 "SoalPrinter.mxg"
            __cb.Write(":");
            #line hidden
            #line (244,24)-(244,25) 25 "SoalPrinter.mxg"
            __cb.Write(" ");
            #line hidden
            #line (244,26)-(244,64) 24 "SoalPrinter.mxg"
            __cb.Write(GenerateRef(currentNs, endp.Interface));
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (245,2)-(245,3) 25 "SoalPrinter.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("\t");
            #line (246,3)-(246,10) 25 "SoalPrinter.mxg"
            __cb.Write("binding");
            #line hidden
            #line (246,10)-(246,11) 25 "SoalPrinter.mxg"
            __cb.Write(" ");
            #line hidden
            #line (246,12)-(246,48) 24 "SoalPrinter.mxg"
            __cb.Write(GenerateRef(currentNs, endp.Binding));
            #line hidden
            #line (246,49)-(246,50) 25 "SoalPrinter.mxg"
            __cb.Write(";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("\t");
            #line (247,3)-(247,10) 25 "SoalPrinter.mxg"
            __cb.Write("address");
            #line hidden
            #line (247,10)-(247,11) 25 "SoalPrinter.mxg"
            __cb.Write(" ");
            #line hidden
            #line (247,11)-(247,12) 25 "SoalPrinter.mxg"
            __cb.Write("\"");
            #line hidden
            #line (247,13)-(247,25) 24 "SoalPrinter.mxg"
            __cb.Write(endp.Address);
            #line hidden
            #line (247,26)-(247,28) 25 "SoalPrinter.mxg"
            __cb.Write("\";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (248,2)-(248,3) 25 "SoalPrinter.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
    }}