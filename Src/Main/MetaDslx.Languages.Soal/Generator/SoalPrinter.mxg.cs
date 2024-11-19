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
            var __first13 = true;
            #line (12,3)-(12,33) 13 "SoalPrinter.mxg"
            foreach (var ns in namespaces)
            #line hidden
            
            {
                if (__first13)
                {
                    __first13 = false;
                }
                __cb.Push("");
                #line (13,3)-(13,24) 28 "SoalPrinter.mxg"
                __cb.Write(GenerateNamespace(ns));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first13) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (17,9)-(17,41) 22 "SoalPrinter.mxg"
        public string GenerateNamespace(Namespace ns)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            var __first14 = true;
            #line (18,3)-(18,65) 13 "SoalPrinter.mxg"
            if (ns.Declarations.Where(d => !(d is Namespace)).Count() > 0)
            #line hidden
            
            {
                if (__first14)
                {
                    __first14 = false;
                }
                var __first15 = true;
                #line (19,4)-(19,26) 17 "SoalPrinter.mxg"
                if (ns.Prefix != null)
                #line hidden
                
                {
                    if (__first15)
                    {
                        __first15 = false;
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
                    if (__first15)
                    {
                        __first15 = false;
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
                if (!__first15) __cb.AppendLine();
                __cb.Push("");
                #line (24,3)-(24,4) 29 "SoalPrinter.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                var __first16 = true;
                #line (25,5)-(25,64) 17 "SoalPrinter.mxg"
                foreach (var enm in ns.Declarations.OfType<Symbols.Enum>())
                #line hidden
                
                {
                    if (__first16)
                    {
                        __first16 = false;
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
                if (!__first16) __cb.AppendLine();
                var __first17 = true;
                #line (29,5)-(29,65) 17 "SoalPrinter.mxg"
                foreach (var st in ns.Declarations.OfType<Symbols.Struct>())
                #line hidden
                
                {
                    if (__first17)
                    {
                        __first17 = false;
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
                if (!__first17) __cb.AppendLine();
                var __first18 = true;
                #line (33,5)-(33,70) 17 "SoalPrinter.mxg"
                foreach (var intf in ns.Declarations.OfType<Symbols.Interface>())
                #line hidden
                
                {
                    if (__first18)
                    {
                        __first18 = false;
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
                if (!__first18) __cb.AppendLine();
                var __first19 = true;
                #line (37,5)-(37,67) 17 "SoalPrinter.mxg"
                foreach (var bnd in ns.Declarations.OfType<Symbols.Binding>())
                #line hidden
                
                {
                    if (__first19)
                    {
                        __first19 = false;
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
                if (!__first19) __cb.AppendLine();
                var __first20 = true;
                #line (41,5)-(41,69) 17 "SoalPrinter.mxg"
                foreach (var endp in ns.Declarations.OfType<Symbols.Endpoint>())
                #line hidden
                
                {
                    if (__first20)
                    {
                        __first20 = false;
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
                if (!__first20) __cb.AppendLine();
                __cb.Push("");
                #line (45,3)-(45,4) 29 "SoalPrinter.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first14) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (50,9)-(50,65) 22 "SoalPrinter.mxg"
        public string GenerateAnnotations(AnnotatedElement ae, bool isReturn)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            var __first21 = true;
            #line (51,3)-(51,40) 13 "SoalPrinter.mxg"
            foreach (var annot in ae.Annotations)
            #line hidden
            
            {
                if (__first21)
                {
                    __first21 = false;
                }
                __cb.Push("");
                #line (52,4)-(52,7) 28 "SoalPrinter.mxg"
                __cb.Write("[");
                #line hidden
                #line (52,9)-(52,35) 28 "SoalPrinter.mxg"
                __cb.Write(isReturn ? "return: " : "");
                #line hidden
                #line (52,37)-(52,47) 28 "SoalPrinter.mxg"
                __cb.Write(annot.Name);
                #line hidden
                var __first22 = true;
                #line (52,49)-(52,79) 17 "SoalPrinter.mxg"
                if(annot.Properties.Count > 0)
                #line hidden
                
                {
                    if (__first22)
                    {
                        __first22 = false;
                    }
                    #line (52,80)-(52,81) 33 "SoalPrinter.mxg"
                    __cb.Write("(");
                    #line hidden
                    #line (52,82)-(52,117) 32 "SoalPrinter.mxg"
                    __cb.Write(GenerateAnnotationProperties(annot));
                    #line hidden
                    #line (52,118)-(52,119) 33 "SoalPrinter.mxg"
                    __cb.Write(")");
                    #line hidden
                }
                #line (52,128)-(52,131) 28 "SoalPrinter.mxg"
                __cb.Write("]");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first21) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (56,9)-(56,75) 22 "SoalPrinter.mxg"
        public string GenerateAnnotationsSingleLine(AnnotatedElement ae, bool isReturn)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.SingleLineMode = true;
            var __first23 = true;
            #line (58,3)-(58,40) 13 "SoalPrinter.mxg"
            foreach (var annot in ae.Annotations)
            #line hidden
            
            {
                if (__first23)
                {
                    __first23 = false;
                }
                __cb.Push("");
                #line (59,4)-(59,7) 28 "SoalPrinter.mxg"
                __cb.Write("[");
                #line hidden
                #line (59,9)-(59,35) 28 "SoalPrinter.mxg"
                __cb.Write(isReturn ? "return: " : "");
                #line hidden
                #line (59,37)-(59,47) 28 "SoalPrinter.mxg"
                __cb.Write(annot.Name);
                #line hidden
                var __first24 = true;
                #line (59,49)-(59,79) 17 "SoalPrinter.mxg"
                if(annot.Properties.Count > 0)
                #line hidden
                
                {
                    if (__first24)
                    {
                        __first24 = false;
                    }
                    #line (59,80)-(59,81) 33 "SoalPrinter.mxg"
                    __cb.Write("(");
                    #line hidden
                    #line (59,82)-(59,117) 32 "SoalPrinter.mxg"
                    __cb.Write(GenerateAnnotationProperties(annot));
                    #line hidden
                    #line (59,118)-(59,119) 33 "SoalPrinter.mxg"
                    __cb.Write(")");
                    #line hidden
                }
                #line (59,128)-(59,132) 28 "SoalPrinter.mxg"
                __cb.Write("] ");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first23) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (63,9)-(63,56) 22 "SoalPrinter.mxg"
        public string GenerateAnnotationProperties(Annotation annot)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.SingleLineMode = true;
            var __first25 = true;
            #line (65,3)-(65,42) 13 "SoalPrinter.mxg"
            foreach (var prop in annot.Properties) 
            #line hidden
            
            {
                if (__first25)
                {
                    __first25 = false;
                }
                else
                {
                    __cb.Push("");
                    __cb.DontIgnoreLastLineEnd = true;
                    #line (65,52)-(65,56) 32 "SoalPrinter.mxg"
                    __cb.Write(", ");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                __cb.Push("");
                #line (66,4)-(66,13) 28 "SoalPrinter.mxg"
                __cb.Write(prop.Name);
                #line hidden
                #line (66,14)-(66,15) 29 "SoalPrinter.mxg"
                __cb.Write("=");
                #line hidden
                #line (66,16)-(66,48) 28 "SoalPrinter.mxg"
                __cb.Write(GetAnnotationPropertyValue(prop));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first25) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (70,9)-(70,61) 22 "SoalPrinter.mxg"
        public string GenerateEnum(Namespace currentNs, Symbols.Enum enm)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (71,3)-(71,34) 24 "SoalPrinter.mxg"
            __cb.Write(GenerateAnnotations(enm, false));
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (72,2)-(72,6) 25 "SoalPrinter.mxg"
            __cb.Write("enum");
            #line hidden
            #line (72,6)-(72,7) 25 "SoalPrinter.mxg"
            __cb.Write(" ");
            #line hidden
            #line (72,8)-(72,16) 24 "SoalPrinter.mxg"
            __cb.Write(enm.Name);
            #line hidden
            #line (72,18)-(72,45) 24 "SoalPrinter.mxg"
            __cb.Write(GetAncestor(currentNs, enm));
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (73,2)-(73,3) 25 "SoalPrinter.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first26 = true;
            #line (74,4)-(74,42) 13 "SoalPrinter.mxg"
            foreach (var lit in enm.EnumLiterals) 
            #line hidden
            
            {
                if (__first26)
                {
                    __first26 = false;
                }
                else
                {
                    __cb.Push("");
                    __cb.DontIgnoreLastLineEnd = true;
                    #line (74,52)-(74,59) 32 "SoalPrinter.mxg"
                    __cb.Write(",\r\n");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                #line (74,60)-(74,64) 29 "SoalPrinter.mxg"
                __cb.Write("    ");
                #line hidden
                #line (74,65)-(74,100) 28 "SoalPrinter.mxg"
                __cb.Write(GenerateEnumLiteral(currentNs, lit));
                #line hidden
            }
            if (!__first26) __cb.AppendLine();
            __cb.Push("");
            #line (75,2)-(75,3) 25 "SoalPrinter.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (78,9)-(78,67) 22 "SoalPrinter.mxg"
        public string GenerateEnumLiteral(Namespace currentNs, EnumLiteral lit)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (79,3)-(79,34) 24 "SoalPrinter.mxg"
            __cb.Write(GenerateAnnotations(lit, false));
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (80,3)-(80,11) 24 "SoalPrinter.mxg"
            __cb.Write(lit.Name);
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (83,9)-(83,56) 22 "SoalPrinter.mxg"
        public string GenerateStruct(Namespace currentNs, Struct st)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (84,3)-(84,33) 24 "SoalPrinter.mxg"
            __cb.Write(GenerateAnnotations(st, false));
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (85,2)-(85,8) 25 "SoalPrinter.mxg"
            __cb.Write("struct");
            #line hidden
            #line (85,8)-(85,9) 25 "SoalPrinter.mxg"
            __cb.Write(" ");
            #line hidden
            #line (85,10)-(85,17) 24 "SoalPrinter.mxg"
            __cb.Write(st.Name);
            #line hidden
            #line (85,19)-(85,45) 24 "SoalPrinter.mxg"
            __cb.Write(GetAncestor(currentNs, st));
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (86,2)-(86,3) 25 "SoalPrinter.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first27 = true;
            #line (87,4)-(87,39) 13 "SoalPrinter.mxg"
            foreach (var prop in st.Properties)
            #line hidden
            
            {
                if (__first27)
                {
                    __first27 = false;
                }
                __cb.Push("\t");
                #line (88,5)-(88,38) 28 "SoalPrinter.mxg"
                __cb.Write(GenerateProperty(currentNs, prop));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first27) __cb.AppendLine();
            __cb.Push("");
            #line (90,2)-(90,3) 25 "SoalPrinter.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (93,9)-(93,62) 22 "SoalPrinter.mxg"
        public string GenerateProperty(Namespace currentNs, Property prop)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (94,3)-(94,35) 24 "SoalPrinter.mxg"
            __cb.Write(GenerateAnnotations(prop, false));
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (95,3)-(95,37) 24 "SoalPrinter.mxg"
            __cb.Write(GenerateType(currentNs, prop.Type));
            #line hidden
            #line (95,38)-(95,39) 25 "SoalPrinter.mxg"
            __cb.Write(" ");
            #line hidden
            #line (95,40)-(95,49) 24 "SoalPrinter.mxg"
            __cb.Write(prop.Name);
            #line hidden
            #line (95,50)-(95,51) 25 "SoalPrinter.mxg"
            __cb.Write(";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (98,9)-(98,60) 22 "SoalPrinter.mxg"
        public string GenerateRef(Namespace currentNs, Declaration decl)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.SingleLineMode = true;
            var __first28 = true;
            #line (100,3)-(100,20) 13 "SoalPrinter.mxg"
            if (decl != null)
            #line hidden
            
            {
                if (__first28)
                {
                    __first28 = false;
                }
                var __first29 = true;
                #line (101,4)-(101,36) 17 "SoalPrinter.mxg"
                if (decl.Namespace != currentNs)
                #line hidden
                
                {
                    if (__first29)
                    {
                        __first29 = false;
                    }
                    __cb.Push("");
                    #line (102,5)-(102,18) 32 "SoalPrinter.mxg"
                    __cb.Write(decl.FullName);
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (103,4)-(103,8) 17 "SoalPrinter.mxg"
                else
                #line hidden
                
                {
                    if (__first29)
                    {
                        __first29 = false;
                    }
                    __cb.Push("");
                    #line (104,5)-(104,14) 32 "SoalPrinter.mxg"
                    __cb.Write(decl.Name);
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first29) __cb.AppendLine();
            }
            if (!__first28) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (109,9)-(109,55) 22 "SoalPrinter.mxg"
        public string GenerateType(Namespace currentNs, SoalType t)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.SingleLineMode = true;
            var __first30 = true;
            #line (111,3)-(111,26) 13 "SoalPrinter.mxg"
            if (t is PrimitiveType)
            #line hidden
            
            {
                if (__first30)
                {
                    __first30 = false;
                }
                __cb.Push("");
                #line (112,4)-(112,27) 28 "SoalPrinter.mxg"
                __cb.Write(((PrimitiveType)t).Name);
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            #line (113,3)-(113,30) 13 "SoalPrinter.mxg"
            else if (t is NullableType)
            #line hidden
            
            {
                if (__first30)
                {
                    __first30 = false;
                }
                __cb.Push("");
                #line (114,4)-(114,56) 28 "SoalPrinter.mxg"
                __cb.Write(GenerateType(currentNs, ((NullableType)t).InnerType));
                #line hidden
                #line (114,57)-(114,58) 29 "SoalPrinter.mxg"
                __cb.Write("?");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            #line (115,3)-(115,27) 13 "SoalPrinter.mxg"
            else if (t is ArrayType)
            #line hidden
            
            {
                if (__first30)
                {
                    __first30 = false;
                }
                __cb.Push("");
                #line (116,4)-(116,53) 28 "SoalPrinter.mxg"
                __cb.Write(GenerateType(currentNs, ((ArrayType)t).InnerType));
                #line hidden
                #line (116,55)-(116,59) 28 "SoalPrinter.mxg"
                __cb.Write("[]");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            #line (117,3)-(117,29) 13 "SoalPrinter.mxg"
            else if (t is Declaration)
            #line hidden
            
            {
                if (__first30)
                {
                    __first30 = false;
                }
                __cb.Push("");
                #line (118,4)-(118,42) 28 "SoalPrinter.mxg"
                __cb.Write(GenerateRef(currentNs, (Declaration)t));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            #line (119,3)-(119,7) 13 "SoalPrinter.mxg"
            else
            #line hidden
            
            {
                if (__first30)
                {
                    __first30 = false;
                }
                __cb.Push("");
                #line (120,4)-(120,5) 28 "SoalPrinter.mxg"
                __cb.Write(t);
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first30) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (124,9)-(124,63) 22 "SoalPrinter.mxg"
        public string GenerateReturnType(Namespace currentNs, Operation op)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.SingleLineMode = true;
            var __first31 = true;
            #line (126,3)-(126,26) 13 "SoalPrinter.mxg"
            if (op.Result.IsOneway)
            #line hidden
            
            {
                if (__first31)
                {
                    __first31 = false;
                }
                __cb.Push("");
                #line (127,3)-(127,9) 29 "SoalPrinter.mxg"
                __cb.Write("oneway");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            #line (128,3)-(128,7) 13 "SoalPrinter.mxg"
            else
            #line hidden
            
            {
                if (__first31)
                {
                    __first31 = false;
                }
                __cb.Push("");
                #line (129,4)-(129,43) 28 "SoalPrinter.mxg"
                __cb.Write(GenerateType(currentNs, op.Result.Type));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first31) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (133,9)-(133,59) 22 "SoalPrinter.mxg"
        public string GenerateThrows(Namespace currentNs, Operation op)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.SingleLineMode = true;
            var __first32 = true;
            #line (135,3)-(135,31) 13 "SoalPrinter.mxg"
            if (op.Exceptions.Count > 0)
            #line hidden
            
            {
                if (__first32)
                {
                    __first32 = false;
                }
                __cb.Push("");
                #line (136,3)-(136,9) 29 "SoalPrinter.mxg"
                __cb.Write("throws");
                #line hidden
                #line (136,9)-(136,10) 29 "SoalPrinter.mxg"
                __cb.Write(" ");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                var __first33 = true;
                #line (137,4)-(137,38) 17 "SoalPrinter.mxg"
                foreach (var ex in op.Exceptions) 
                #line hidden
                
                {
                    if (__first33)
                    {
                        __first33 = false;
                    }
                    else
                    {
                        __cb.Push("");
                        __cb.DontIgnoreLastLineEnd = true;
                        #line (137,48)-(137,52) 36 "SoalPrinter.mxg"
                        __cb.Write(", ");
                        #line hidden
                        __cb.DontIgnoreLastLineEnd = false;
                        __cb.Pop();
                    }
                    __cb.Push("");
                    #line (138,5)-(138,32) 32 "SoalPrinter.mxg"
                    __cb.Write(GenerateType(currentNs, ex));
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first33) __cb.AppendLine();
            }
            if (!__first32) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (143,9)-(143,63) 22 "SoalPrinter.mxg"
        public string GenerateParameters(Namespace currentNs, Operation op)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.SingleLineMode = true;
            var __first34 = true;
            #line (145,3)-(145,36) 13 "SoalPrinter.mxg"
            foreach (var p in op.Parameters) 
            #line hidden
            
            {
                if (__first34)
                {
                    __first34 = false;
                }
                else
                {
                    __cb.Push("");
                    __cb.DontIgnoreLastLineEnd = true;
                    #line (145,46)-(145,50) 32 "SoalPrinter.mxg"
                    __cb.Write(", ");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                __cb.Push("");
                #line (146,4)-(146,43) 28 "SoalPrinter.mxg"
                __cb.Write(GenerateAnnotationsSingleLine(p, false));
                #line hidden
                #line (146,45)-(146,76) 28 "SoalPrinter.mxg"
                __cb.Write(GenerateType(currentNs, p.Type));
                #line hidden
                #line (146,77)-(146,78) 29 "SoalPrinter.mxg"
                __cb.Write(" ");
                #line hidden
                #line (146,79)-(146,85) 28 "SoalPrinter.mxg"
                __cb.Write(p.Name);
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first34) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (150,9)-(150,62) 22 "SoalPrinter.mxg"
        public string GenerateOperation(Namespace currentNs, Operation op)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (151,3)-(151,33) 24 "SoalPrinter.mxg"
            __cb.Write(GenerateAnnotations(op, false));
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (152,3)-(152,39) 24 "SoalPrinter.mxg"
            __cb.Write(GenerateAnnotations(op.Result, true));
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (153,3)-(153,36) 24 "SoalPrinter.mxg"
            __cb.Write(GenerateReturnType(currentNs, op));
            #line hidden
            #line (153,37)-(153,38) 25 "SoalPrinter.mxg"
            __cb.Write(" ");
            #line hidden
            #line (153,39)-(153,46) 24 "SoalPrinter.mxg"
            __cb.Write(op.Name);
            #line hidden
            #line (153,47)-(153,48) 25 "SoalPrinter.mxg"
            __cb.Write("(");
            #line hidden
            #line (153,49)-(153,82) 24 "SoalPrinter.mxg"
            __cb.Write(GenerateParameters(currentNs, op));
            #line hidden
            #line (153,83)-(153,84) 25 "SoalPrinter.mxg"
            __cb.Write(")");
            #line hidden
            #line (153,85)-(153,114) 24 "SoalPrinter.mxg"
            __cb.Write(GenerateThrows(currentNs, op));
            #line hidden
            #line (153,115)-(153,116) 25 "SoalPrinter.mxg"
            __cb.Write(";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (156,9)-(156,64) 22 "SoalPrinter.mxg"
        public string GenerateInterface(Namespace currentNs, Interface intf)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (157,3)-(157,35) 24 "SoalPrinter.mxg"
            __cb.Write(GenerateAnnotations(intf, false));
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (158,2)-(158,11) 25 "SoalPrinter.mxg"
            __cb.Write("interface");
            #line hidden
            #line (158,11)-(158,12) 25 "SoalPrinter.mxg"
            __cb.Write(" ");
            #line hidden
            #line (158,13)-(158,22) 24 "SoalPrinter.mxg"
            __cb.Write(intf.Name);
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (159,2)-(159,3) 25 "SoalPrinter.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first35 = true;
            #line (160,4)-(160,39) 13 "SoalPrinter.mxg"
            foreach (var op in intf.Operations)
            #line hidden
            
            {
                if (__first35)
                {
                    __first35 = false;
                }
                __cb.Push("\t");
                #line (161,5)-(161,37) 28 "SoalPrinter.mxg"
                __cb.Write(GenerateOperation(currentNs, op));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first35) __cb.AppendLine();
            __cb.Push("");
            #line (163,2)-(163,3) 25 "SoalPrinter.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (166,9)-(166,84) 22 "SoalPrinter.mxg"
        public string GenerateTransportBinding(Namespace currentNs, TransportBindingElement bnd)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            var __first36 = true;
            #line (167,3)-(167,47) 13 "SoalPrinter.mxg"
            if (bnd is HttpTransportBindingElement htbe)
            #line hidden
            
            {
                if (__first36)
                {
                    __first36 = false;
                }
                var __first37 = true;
                #line (168,4)-(168,17) 17 "SoalPrinter.mxg"
                if (htbe.Ssl)
                #line hidden
                
                {
                    if (__first37)
                    {
                        __first37 = false;
                    }
                    __cb.Push("");
                    #line (169,4)-(169,13) 33 "SoalPrinter.mxg"
                    __cb.Write("transport");
                    #line hidden
                    #line (169,13)-(169,14) 33 "SoalPrinter.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (169,14)-(169,18) 33 "SoalPrinter.mxg"
                    __cb.Write("HTTP");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("");
                    #line (170,4)-(170,5) 33 "SoalPrinter.mxg"
                    __cb.Write("{");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("\t");
                    #line (171,5)-(171,8) 33 "SoalPrinter.mxg"
                    __cb.Write("Ssl");
                    #line hidden
                    #line (171,8)-(171,9) 33 "SoalPrinter.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (171,9)-(171,10) 33 "SoalPrinter.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (171,10)-(171,11) 33 "SoalPrinter.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (171,11)-(171,16) 33 "SoalPrinter.mxg"
                    __cb.Write("true;");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("\t");
                    #line (172,5)-(172,25) 33 "SoalPrinter.mxg"
                    __cb.Write("ClientAuthentication");
                    #line hidden
                    #line (172,25)-(172,26) 33 "SoalPrinter.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (172,26)-(172,27) 33 "SoalPrinter.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (172,27)-(172,28) 33 "SoalPrinter.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (172,29)-(172,75) 32 "SoalPrinter.mxg"
                    __cb.Write(htbe.ClientAuthentication.ToString().ToLower());
                    #line hidden
                    #line (172,76)-(172,77) 33 "SoalPrinter.mxg"
                    __cb.Write(";");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("");
                    #line (173,4)-(173,5) 33 "SoalPrinter.mxg"
                    __cb.Write("}");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (174,4)-(174,8) 17 "SoalPrinter.mxg"
                else
                #line hidden
                
                {
                    if (__first37)
                    {
                        __first37 = false;
                    }
                    __cb.Push("");
                    #line (175,4)-(175,13) 33 "SoalPrinter.mxg"
                    __cb.Write("transport");
                    #line hidden
                    #line (175,13)-(175,14) 33 "SoalPrinter.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (175,14)-(175,19) 33 "SoalPrinter.mxg"
                    __cb.Write("HTTP;");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first37) __cb.AppendLine();
            }
            #line (177,3)-(177,52) 13 "SoalPrinter.mxg"
            else if (bnd is RestTransportBindingElement rtbe)
            #line hidden
            
            {
                if (__first36)
                {
                    __first36 = false;
                }
                __cb.Push("");
                #line (178,3)-(178,12) 29 "SoalPrinter.mxg"
                __cb.Write("transport");
                #line hidden
                #line (178,12)-(178,13) 29 "SoalPrinter.mxg"
                __cb.Write(" ");
                #line hidden
                #line (178,13)-(178,18) 29 "SoalPrinter.mxg"
                __cb.Write("REST;");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            #line (179,3)-(179,57) 13 "SoalPrinter.mxg"
            else if (bnd is WebSocketTransportBindingElement wtbe)
            #line hidden
            
            {
                if (__first36)
                {
                    __first36 = false;
                }
                __cb.Push("");
                #line (180,3)-(180,12) 29 "SoalPrinter.mxg"
                __cb.Write("transport");
                #line hidden
                #line (180,12)-(180,13) 29 "SoalPrinter.mxg"
                __cb.Write(" ");
                #line hidden
                #line (180,13)-(180,23) 29 "SoalPrinter.mxg"
                __cb.Write("WebSocket;");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first36) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (184,9)-(184,82) 22 "SoalPrinter.mxg"
        public string GenerateEncodingBinding(Namespace currentNs, EncodingBindingElement bnd)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            var __first38 = true;
            #line (185,3)-(185,46) 13 "SoalPrinter.mxg"
            if (bnd is SoapEncodingBindingElement sebe)
            #line hidden
            
            {
                if (__first38)
                {
                    __first38 = false;
                }
                var __first39 = true;
                #line (186,4)-(186,107) 17 "SoalPrinter.mxg"
                if (sebe.Style != SoapEncodingStyle.DocumentWrapped || sebe.Version != SoapVersion.Soap11 || sebe.Mtom)
                #line hidden
                
                {
                    if (__first39)
                    {
                        __first39 = false;
                    }
                    __cb.Push("");
                    #line (187,4)-(187,12) 33 "SoalPrinter.mxg"
                    __cb.Write("encoding");
                    #line hidden
                    #line (187,12)-(187,13) 33 "SoalPrinter.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (187,13)-(187,17) 33 "SoalPrinter.mxg"
                    __cb.Write("SOAP");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("");
                    #line (188,4)-(188,5) 33 "SoalPrinter.mxg"
                    __cb.Write("{");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    var __first40 = true;
                    #line (189,6)-(189,58) 21 "SoalPrinter.mxg"
                    if (sebe.Style != SoapEncodingStyle.DocumentWrapped)
                    #line hidden
                    
                    {
                        if (__first40)
                        {
                            __first40 = false;
                        }
                        __cb.Push("\t");
                        #line (190,5)-(190,10) 37 "SoalPrinter.mxg"
                        __cb.Write("Style");
                        #line hidden
                        #line (190,10)-(190,11) 37 "SoalPrinter.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (190,11)-(190,12) 37 "SoalPrinter.mxg"
                        __cb.Write("=");
                        #line hidden
                        #line (190,12)-(190,13) 37 "SoalPrinter.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (190,14)-(190,24) 36 "SoalPrinter.mxg"
                        __cb.Write(sebe.Style);
                        #line hidden
                        #line (190,25)-(190,26) 37 "SoalPrinter.mxg"
                        __cb.Write(";");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first40) __cb.AppendLine();
                    var __first41 = true;
                    #line (192,6)-(192,45) 21 "SoalPrinter.mxg"
                    if (sebe.Version != SoapVersion.Soap11)
                    #line hidden
                    
                    {
                        if (__first41)
                        {
                            __first41 = false;
                        }
                        __cb.Push("\t");
                        #line (193,5)-(193,12) 37 "SoalPrinter.mxg"
                        __cb.Write("Version");
                        #line hidden
                        #line (193,12)-(193,13) 37 "SoalPrinter.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (193,13)-(193,14) 37 "SoalPrinter.mxg"
                        __cb.Write("=");
                        #line hidden
                        #line (193,14)-(193,15) 37 "SoalPrinter.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (193,16)-(193,28) 36 "SoalPrinter.mxg"
                        __cb.Write(sebe.Version);
                        #line hidden
                        #line (193,29)-(193,30) 37 "SoalPrinter.mxg"
                        __cb.Write(";");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first41) __cb.AppendLine();
                    var __first42 = true;
                    #line (195,6)-(195,20) 21 "SoalPrinter.mxg"
                    if (sebe.Mtom)
                    #line hidden
                    
                    {
                        if (__first42)
                        {
                            __first42 = false;
                        }
                        __cb.Push("\t");
                        #line (196,5)-(196,9) 37 "SoalPrinter.mxg"
                        __cb.Write("Mtom");
                        #line hidden
                        #line (196,9)-(196,10) 37 "SoalPrinter.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (196,10)-(196,11) 37 "SoalPrinter.mxg"
                        __cb.Write("=");
                        #line hidden
                        #line (196,11)-(196,12) 37 "SoalPrinter.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (196,12)-(196,17) 37 "SoalPrinter.mxg"
                        __cb.Write("true;");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first42) __cb.AppendLine();
                    __cb.Push("");
                    #line (198,4)-(198,5) 33 "SoalPrinter.mxg"
                    __cb.Write("}");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (199,4)-(199,8) 17 "SoalPrinter.mxg"
                else
                #line hidden
                
                {
                    if (__first39)
                    {
                        __first39 = false;
                    }
                    __cb.Push("");
                    #line (200,4)-(200,12) 33 "SoalPrinter.mxg"
                    __cb.Write("encoding");
                    #line hidden
                    #line (200,12)-(200,13) 33 "SoalPrinter.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (200,13)-(200,18) 33 "SoalPrinter.mxg"
                    __cb.Write("SOAP;");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first39) __cb.AppendLine();
            }
            #line (202,3)-(202,50) 13 "SoalPrinter.mxg"
            else if (bnd is XmlEncodingBindingElement xebe)
            #line hidden
            
            {
                if (__first38)
                {
                    __first38 = false;
                }
                __cb.Push("");
                #line (203,3)-(203,11) 29 "SoalPrinter.mxg"
                __cb.Write("encoding");
                #line hidden
                #line (203,11)-(203,12) 29 "SoalPrinter.mxg"
                __cb.Write(" ");
                #line hidden
                #line (203,12)-(203,16) 29 "SoalPrinter.mxg"
                __cb.Write("XML;");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            #line (204,3)-(204,51) 13 "SoalPrinter.mxg"
            else if (bnd is JsonEncodingBindingElement jebe)
            #line hidden
            
            {
                if (__first38)
                {
                    __first38 = false;
                }
                __cb.Push("");
                #line (205,3)-(205,11) 29 "SoalPrinter.mxg"
                __cb.Write("encoding");
                #line hidden
                #line (205,11)-(205,12) 29 "SoalPrinter.mxg"
                __cb.Write(" ");
                #line hidden
                #line (205,12)-(205,17) 29 "SoalPrinter.mxg"
                __cb.Write("JSON;");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first38) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (209,9)-(209,82) 22 "SoalPrinter.mxg"
        public string GenerateProtocolBinding(Namespace currentNs, ProtocolBindingElement bnd)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            var __first43 = true;
            #line (210,3)-(210,41) 13 "SoalPrinter.mxg"
            if (bnd is WsAddressingBindingElement)
            #line hidden
            
            {
                if (__first43)
                {
                    __first43 = false;
                }
                __cb.Push("");
                #line (211,3)-(211,11) 29 "SoalPrinter.mxg"
                __cb.Write("protocol");
                #line hidden
                #line (211,11)-(211,12) 29 "SoalPrinter.mxg"
                __cb.Write(" ");
                #line hidden
                #line (211,12)-(211,25) 29 "SoalPrinter.mxg"
                __cb.Write("WsAddressing;");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first43) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (215,9)-(215,67) 22 "SoalPrinter.mxg"
        public string GenerateBinding(Namespace currentNs, Symbols.Binding bnd)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (216,2)-(216,9) 25 "SoalPrinter.mxg"
            __cb.Write("binding");
            #line hidden
            #line (216,9)-(216,10) 25 "SoalPrinter.mxg"
            __cb.Write(" ");
            #line hidden
            #line (216,11)-(216,19) 24 "SoalPrinter.mxg"
            __cb.Write(bnd.Name);
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (217,2)-(217,3) 25 "SoalPrinter.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("\t");
            #line (218,4)-(218,54) 24 "SoalPrinter.mxg"
            __cb.Write(GenerateTransportBinding(currentNs, bnd.Transport));
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first44 = true;
            #line (219,4)-(219,38) 13 "SoalPrinter.mxg"
            foreach (var enc in bnd.Encodings)
            #line hidden
            
            {
                if (__first44)
                {
                    __first44 = false;
                }
                __cb.Push("\t");
                #line (220,5)-(220,44) 28 "SoalPrinter.mxg"
                __cb.Write(GenerateEncodingBinding(currentNs, enc));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first44) __cb.AppendLine();
            var __first45 = true;
            #line (222,4)-(222,39) 13 "SoalPrinter.mxg"
            foreach (var prot in bnd.Protocols)
            #line hidden
            
            {
                if (__first45)
                {
                    __first45 = false;
                }
                __cb.Push("\t");
                #line (223,5)-(223,45) 28 "SoalPrinter.mxg"
                __cb.Write(GenerateProtocolBinding(currentNs, prot));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first45) __cb.AppendLine();
            __cb.Push("");
            #line (225,2)-(225,3) 25 "SoalPrinter.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (228,9)-(228,62) 22 "SoalPrinter.mxg"
        public string GenerateEndpoint(Namespace currentNs, Endpoint endp)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (229,2)-(229,10) 25 "SoalPrinter.mxg"
            __cb.Write("endpoint");
            #line hidden
            #line (229,10)-(229,11) 25 "SoalPrinter.mxg"
            __cb.Write(" ");
            #line hidden
            #line (229,12)-(229,21) 24 "SoalPrinter.mxg"
            __cb.Write(endp.Name);
            #line hidden
            #line (229,22)-(229,23) 25 "SoalPrinter.mxg"
            __cb.Write(" ");
            #line hidden
            #line (229,23)-(229,24) 25 "SoalPrinter.mxg"
            __cb.Write(":");
            #line hidden
            #line (229,24)-(229,25) 25 "SoalPrinter.mxg"
            __cb.Write(" ");
            #line hidden
            #line (229,26)-(229,64) 24 "SoalPrinter.mxg"
            __cb.Write(GenerateRef(currentNs, endp.Interface));
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (230,2)-(230,3) 25 "SoalPrinter.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("\t");
            #line (231,3)-(231,10) 25 "SoalPrinter.mxg"
            __cb.Write("binding");
            #line hidden
            #line (231,10)-(231,11) 25 "SoalPrinter.mxg"
            __cb.Write(" ");
            #line hidden
            #line (231,12)-(231,48) 24 "SoalPrinter.mxg"
            __cb.Write(GenerateRef(currentNs, endp.Binding));
            #line hidden
            #line (231,49)-(231,50) 25 "SoalPrinter.mxg"
            __cb.Write(";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("\t");
            #line (232,3)-(232,10) 25 "SoalPrinter.mxg"
            __cb.Write("address");
            #line hidden
            #line (232,10)-(232,11) 25 "SoalPrinter.mxg"
            __cb.Write(" ");
            #line hidden
            #line (232,11)-(232,12) 25 "SoalPrinter.mxg"
            __cb.Write("\"");
            #line hidden
            #line (232,13)-(232,25) 24 "SoalPrinter.mxg"
            __cb.Write(endp.Address);
            #line hidden
            #line (232,26)-(232,28) 25 "SoalPrinter.mxg"
            __cb.Write("\";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (233,2)-(233,3) 25 "SoalPrinter.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
    }}