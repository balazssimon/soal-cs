#pragma warning disable CS8669
#line (1,10)-(1,44) 10 "PlantUmlGenerator.mxg"
namespace MetaDslx.Languages.Soal.Generator
#line hidden

{
    #line (3,1)-(3,6) 5 "PlantUmlGenerator.mxg"
    using
    #line hidden
    global::
    #line (3,7)-(3,13) 13 "PlantUmlGenerator.mxg"
    System;
    #line hidden
    #line (4,1)-(4,6) 5 "PlantUmlGenerator.mxg"
    using
    #line hidden
    global::
    #line (4,7)-(4,25) 13 "PlantUmlGenerator.mxg"
    System.Collections;
    #line hidden
    #line (5,1)-(5,6) 5 "PlantUmlGenerator.mxg"
    using
    #line hidden
    global::
    #line (5,7)-(5,33) 13 "PlantUmlGenerator.mxg"
    System.Collections.Generic;
    #line hidden
    #line (6,1)-(6,6) 5 "PlantUmlGenerator.mxg"
    using
    #line hidden
    global::
    #line (6,7)-(6,18) 13 "PlantUmlGenerator.mxg"
    System.Linq;
    #line hidden
    #line (7,1)-(7,6) 5 "PlantUmlGenerator.mxg"
    using
    #line hidden
    global::
    #line (7,7)-(7,38) 13 "PlantUmlGenerator.mxg"
    MetaDslx.Languages.Soal.Symbols;
    #line hidden
    #line (8,1)-(8,6) 5 "PlantUmlGenerator.mxg"
    using
    #line hidden
    global::
    #line (8,7)-(8,24) 13 "PlantUmlGenerator.mxg"
    MetaDslx.Modeling;
    #line hidden
    
    #line (10,10)-(10,28) 25 "PlantUmlGenerator.mxg"
    public partial class PlantUmlGenerator
    #line hidden
    {
        #line (12,9)-(12,80) 22 "PlantUmlGenerator.mxg"
        public string Generate(string name, string title, IEnumerable<IModelObject> objects)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (13,2)-(13,11) 25 "PlantUmlGenerator.mxg"
            __cb.Write("@startuml");
            #line hidden
            #line (13,11)-(13,12) 25 "PlantUmlGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (13,13)-(13,17) 24 "PlantUmlGenerator.mxg"
            __cb.Write(name);
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (15,2)-(15,6) 25 "PlantUmlGenerator.mxg"
            __cb.Write("skin");
            #line hidden
            #line (15,6)-(15,7) 25 "PlantUmlGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (15,7)-(15,11) 25 "PlantUmlGenerator.mxg"
            __cb.Write("rose");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (16,2)-(16,6) 25 "PlantUmlGenerator.mxg"
            __cb.Write("hide");
            #line hidden
            #line (16,6)-(16,7) 25 "PlantUmlGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (16,7)-(16,13) 25 "PlantUmlGenerator.mxg"
            __cb.Write("circle");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (17,2)-(17,11) 25 "PlantUmlGenerator.mxg"
            __cb.Write("skinparam");
            #line hidden
            #line (17,11)-(17,12) 25 "PlantUmlGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (17,12)-(17,34) 25 "PlantUmlGenerator.mxg"
            __cb.Write("classAttributeIconSize");
            #line hidden
            #line (17,34)-(17,35) 25 "PlantUmlGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (17,35)-(17,36) 25 "PlantUmlGenerator.mxg"
            __cb.Write("0");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (19,2)-(19,7) 25 "PlantUmlGenerator.mxg"
            __cb.Write("title");
            #line hidden
            #line (19,7)-(19,8) 25 "PlantUmlGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (19,9)-(19,14) 24 "PlantUmlGenerator.mxg"
            __cb.Write(title);
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            var __first1 = true;
            #line (21,3)-(21,54) 13 "PlantUmlGenerator.mxg"
            foreach (var enm in objects.OfType<Symbols.Enum>())
            #line hidden
            
            {
                if (__first1)
                {
                    __first1 = false;
                }
                __cb.Push("");
                #line (22,3)-(22,7) 29 "PlantUmlGenerator.mxg"
                __cb.Write("enum");
                #line hidden
                #line (22,7)-(22,8) 29 "PlantUmlGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (22,9)-(22,17) 28 "PlantUmlGenerator.mxg"
                __cb.Write(enm.Name);
                #line hidden
                #line (22,18)-(22,19) 29 "PlantUmlGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (22,19)-(22,21) 29 "PlantUmlGenerator.mxg"
                __cb.Write("as");
                #line hidden
                #line (22,21)-(22,22) 29 "PlantUmlGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (22,22)-(22,38) 29 "PlantUmlGenerator.mxg"
                __cb.Write("\"<<enumeration>>");
                #line hidden
                #line (22,38)-(22,39) 29 "PlantUmlGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (22,39)-(22,41) 29 "PlantUmlGenerator.mxg"
                __cb.Write("\\n");
                #line hidden
                #line (22,41)-(22,42) 29 "PlantUmlGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (22,43)-(22,51) 28 "PlantUmlGenerator.mxg"
                __cb.Write(enm.Name);
                #line hidden
                #line (22,52)-(22,53) 29 "PlantUmlGenerator.mxg"
                __cb.Write("\"");
                #line hidden
                #line (22,53)-(22,54) 29 "PlantUmlGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (22,54)-(22,55) 29 "PlantUmlGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                var __first2 = true;
                #line (23,5)-(23,41) 17 "PlantUmlGenerator.mxg"
                foreach (var el in enm.EnumLiterals)
                #line hidden
                
                {
                    if (__first2)
                    {
                        __first2 = false;
                    }
                    __cb.Push("\t");
                    #line (24,6)-(24,13) 32 "PlantUmlGenerator.mxg"
                    __cb.Write(el.Name);
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first2) __cb.AppendLine();
                __cb.Push("");
                #line (26,3)-(26,4) 29 "PlantUmlGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first1) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            var __first3 = true;
            #line (29,3)-(29,47) 13 "PlantUmlGenerator.mxg"
            foreach (var st in objects.OfType<Struct>())
            #line hidden
            
            {
                if (__first3)
                {
                    __first3 = false;
                }
                __cb.Push("");
                #line (30,3)-(30,8) 29 "PlantUmlGenerator.mxg"
                __cb.Write("class");
                #line hidden
                #line (30,8)-(30,9) 29 "PlantUmlGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (30,10)-(30,17) 28 "PlantUmlGenerator.mxg"
                __cb.Write(st.Name);
                #line hidden
                var __first4 = true;
                #line (30,19)-(30,64) 17 "PlantUmlGenerator.mxg"
                if (st.HasAnnotation(SoalAnnotations.Choice))
                #line hidden
                
                {
                    if (__first4)
                    {
                        __first4 = false;
                    }
                    #line (30,65)-(30,66) 33 "PlantUmlGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (30,66)-(30,68) 33 "PlantUmlGenerator.mxg"
                    __cb.Write("as");
                    #line hidden
                    #line (30,68)-(30,69) 33 "PlantUmlGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (30,69)-(30,80) 33 "PlantUmlGenerator.mxg"
                    __cb.Write("\"<<choice>>");
                    #line hidden
                    #line (30,80)-(30,81) 33 "PlantUmlGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (30,81)-(30,83) 33 "PlantUmlGenerator.mxg"
                    __cb.Write("\\n");
                    #line hidden
                    #line (30,83)-(30,84) 33 "PlantUmlGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (30,85)-(30,92) 32 "PlantUmlGenerator.mxg"
                    __cb.Write(st.Name);
                    #line hidden
                    #line (30,93)-(30,94) 33 "PlantUmlGenerator.mxg"
                    __cb.Write("\"");
                    #line hidden
                }
                var __first5 = true;
                #line (30,103)-(30,145) 17 "PlantUmlGenerator.mxg"
                if (st.HasAnnotation(SoalAnnotations.All))
                #line hidden
                
                {
                    if (__first5)
                    {
                        __first5 = false;
                    }
                    #line (30,146)-(30,147) 33 "PlantUmlGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (30,147)-(30,149) 33 "PlantUmlGenerator.mxg"
                    __cb.Write("as");
                    #line hidden
                    #line (30,149)-(30,150) 33 "PlantUmlGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (30,150)-(30,158) 33 "PlantUmlGenerator.mxg"
                    __cb.Write("\"<<all>>");
                    #line hidden
                    #line (30,158)-(30,159) 33 "PlantUmlGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (30,159)-(30,161) 33 "PlantUmlGenerator.mxg"
                    __cb.Write("\\n");
                    #line hidden
                    #line (30,161)-(30,162) 33 "PlantUmlGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (30,163)-(30,170) 32 "PlantUmlGenerator.mxg"
                    __cb.Write(st.Name);
                    #line hidden
                    #line (30,171)-(30,172) 33 "PlantUmlGenerator.mxg"
                    __cb.Write("\"");
                    #line hidden
                }
                #line (30,180)-(30,181) 29 "PlantUmlGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (30,181)-(30,182) 29 "PlantUmlGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                var __first6 = true;
                #line (31,5)-(31,37) 17 "PlantUmlGenerator.mxg"
                foreach (var p in st.Properties)
                #line hidden
                
                {
                    if (__first6)
                    {
                        __first6 = false;
                    }
                    #line (32,6)-(32,35) 21 "PlantUmlGenerator.mxg"
                    var ct = p.Type.GetCoreType();
                    #line hidden
                    
                    var __first7 = true;
                    #line (33,6)-(33,51) 21 "PlantUmlGenerator.mxg"
                    if (!(ct is Struct) && !(ct is Symbols.Enum))
                    #line hidden
                    
                    {
                        if (__first7)
                        {
                            __first7 = false;
                        }
                        #line (34,7)-(34,13) 36 "PlantUmlGenerator.mxg"
                        __cb.Write(p.Name);
                        #line hidden
                        #line (34,14)-(34,15) 37 "PlantUmlGenerator.mxg"
                        __cb.Write(":");
                        #line hidden
                        #line (34,15)-(34,16) 37 "PlantUmlGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (34,17)-(34,42) 36 "PlantUmlGenerator.mxg"
                        __cb.Write(p.Type.GetCoreType().Name);
                        #line hidden
                        var __first8 = true;
                        #line (34,44)-(34,69) 25 "PlantUmlGenerator.mxg"
                        if (p.Type.IsArrayType())
                        #line hidden
                        
                        {
                            if (__first8)
                            {
                                __first8 = false;
                            }
                            #line (34,71)-(34,75) 40 "PlantUmlGenerator.mxg"
                            __cb.Write("[]");
                            #line hidden
                        }
                        if (!__first8) __cb.AppendLine();
                    }
                    if (!__first7) __cb.AppendLine();
                }
                if (!__first6) __cb.AppendLine();
                __cb.Push("");
                #line (37,3)-(37,4) 29 "PlantUmlGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first3) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            var __first9 = true;
            #line (40,3)-(40,78) 13 "PlantUmlGenerator.mxg"
            foreach (var st in objects.OfType<Struct>().Where(t => t.BaseType != null))
            #line hidden
            
            {
                if (__first9)
                {
                    __first9 = false;
                }
                __cb.Push("");
                #line (41,4)-(41,20) 28 "PlantUmlGenerator.mxg"
                __cb.Write(st.BaseType.Name);
                #line hidden
                #line (41,21)-(41,22) 29 "PlantUmlGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (41,22)-(41,30) 29 "PlantUmlGenerator.mxg"
                __cb.Write("<|-down-");
                #line hidden
                #line (41,30)-(41,31) 29 "PlantUmlGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (41,32)-(41,39) 28 "PlantUmlGenerator.mxg"
                __cb.Write(st.Name);
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first9) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            var __first10 = true;
            #line (44,3)-(44,47) 13 "PlantUmlGenerator.mxg"
            foreach (var st in objects.OfType<Struct>())
            #line hidden
            
            {
                if (__first10)
                {
                    __first10 = false;
                }
                var __first11 = true;
                #line (45,4)-(45,36) 17 "PlantUmlGenerator.mxg"
                foreach (var p in st.Properties)
                #line hidden
                
                {
                    if (__first11)
                    {
                        __first11 = false;
                    }
                    #line (46,5)-(46,34) 21 "PlantUmlGenerator.mxg"
                    var ct = p.Type.GetCoreType();
                    #line hidden
                    
                    var __first12 = true;
                    #line (47,5)-(47,44) 21 "PlantUmlGenerator.mxg"
                    if (ct is Struct || ct is Symbols.Enum)
                    #line hidden
                    
                    {
                        if (__first12)
                        {
                            __first12 = false;
                        }
                        __cb.Push("");
                        #line (48,6)-(48,13) 36 "PlantUmlGenerator.mxg"
                        __cb.Write(st.Name);
                        #line hidden
                        #line (48,14)-(48,15) 37 "PlantUmlGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (48,15)-(48,23) 37 "PlantUmlGenerator.mxg"
                        __cb.Write("*-down->");
                        #line hidden
                        #line (48,23)-(48,24) 37 "PlantUmlGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (48,24)-(48,25) 37 "PlantUmlGenerator.mxg"
                        __cb.Write("\"");
                        #line hidden
                        #line (48,26)-(48,32) 36 "PlantUmlGenerator.mxg"
                        __cb.Write(p.Name);
                        #line hidden
                        var __first13 = true;
                        #line (48,34)-(48,59) 25 "PlantUmlGenerator.mxg"
                        if (p.Type.IsArrayType())
                        #line hidden
                        
                        {
                            if (__first13)
                            {
                                __first13 = false;
                            }
                            #line (48,60)-(48,61) 41 "PlantUmlGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (48,61)-(48,63) 41 "PlantUmlGenerator.mxg"
                            __cb.Write("\\n");
                            #line hidden
                            #line (48,63)-(48,64) 41 "PlantUmlGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (48,64)-(48,68) 41 "PlantUmlGenerator.mxg"
                            __cb.Write("0..*");
                            #line hidden
                        }
                        #line (48,76)-(48,77) 37 "PlantUmlGenerator.mxg"
                        __cb.Write("\"");
                        #line hidden
                        #line (48,77)-(48,78) 37 "PlantUmlGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (48,79)-(48,86) 36 "PlantUmlGenerator.mxg"
                        __cb.Write(ct.Name);
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first12) __cb.AppendLine();
                }
                if (!__first11) __cb.AppendLine();
            }
            if (!__first10) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (53,2)-(53,9) 25 "PlantUmlGenerator.mxg"
            __cb.Write("@enduml");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
    }}