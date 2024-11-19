#pragma warning disable CS8669

namespace MetaDslx.Languages.Soal.Symbols.__Impl
{
    using __Model = global::MetaDslx.Modeling.Model;
    using __MetaModel = global::MetaDslx.Modeling.MetaModel;
    using __IModelObject = global::MetaDslx.Modeling.IModelObject;
    using __MetaModelObject = global::MetaDslx.Modeling.MetaModelObject;
    using __ModelEnumInfo = global::MetaDslx.Modeling.ModelEnumInfo;
    using __ModelClassInfo = global::MetaDslx.Modeling.ModelClassInfo;
    using __ModelProperty = global::MetaDslx.Modeling.ModelProperty;
    using __ModelPropertyFlags = global::MetaDslx.Modeling.ModelPropertyFlags;
    using __ModelPropertyInfo = global::MetaDslx.Modeling.ModelPropertyInfo;
    using __ModelPropertySlot = global::MetaDslx.Modeling.ModelPropertySlot;
    using __ModelOperation = global::MetaDslx.Modeling.ModelOperation;
    using __ModelOperationInfo = global::MetaDslx.Modeling.ModelOperationInfo;
    using __ImmutableArray = global::System.Collections.Immutable.ImmutableArray;
    using __ImmutableDictionary = global::System.Collections.Immutable.ImmutableDictionary;
    using __MetaType = global::MetaDslx.CodeAnalysis.MetaType;
    using __MetaSymbol = global::MetaDslx.CodeAnalysis.MetaSymbol;
    using __Type = global::System.Type;
    using __Enum = global::System.Enum;

    internal class Struct_Impl : __MetaModelObject, Struct
    {
        private Struct_Impl(string? id)
            : base(id)
        {
            Soal.__CustomImpl.DocumentedElement(this);
            Soal.__CustomImpl.NamedElement(this);
            Soal.__CustomImpl.AnnotatedElement(this);
            Soal.__CustomImpl.Declaration(this);
            Soal.__CustomImpl.SoalType(this);
            Soal.__CustomImpl.Struct(this);
        }
    
        public override __ModelClassInfo MInfo => __Info.Instance;
    
        public MetaDslx.Languages.Soal.Symbols.Struct BaseType
        {
            get => MGet<MetaDslx.Languages.Soal.Symbols.Struct>(Soal.Struct_BaseType);
            set => MSet<MetaDslx.Languages.Soal.Symbols.Struct>(Soal.Struct_BaseType, value);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<MetaDslx.Languages.Soal.Symbols.Property> Properties
        {
            get => MGetCollection<Property>(Soal.Struct_Properties);
        }
    
        public string FullName
        {
            get => Soal.__CustomImpl.Declaration_FullName(this);
        }
    
        public MetaDslx.Languages.Soal.Symbols.Namespace? Namespace
        {
            get => MGet<MetaDslx.Languages.Soal.Symbols.Namespace?>(Soal.Declaration_Namespace);
            set => MSet<MetaDslx.Languages.Soal.Symbols.Namespace?>(Soal.Declaration_Namespace, value);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<MetaDslx.Languages.Soal.Symbols.Annotation> Annotations
        {
            get => MGetCollection<Annotation>(Soal.AnnotatedElement_Annotations);
        }
    
        public string Name
        {
            get => MGet<string>(Soal.NamedElement_Name);
            set => MSet<string>(Soal.NamedElement_Name, value);
        }
    
        public string Documentation
        {
            get => MGet<string>(Soal.DocumentedElement_Documentation);
            set => MSet<string>(Soal.DocumentedElement_Documentation, value);
        }
    
    
        global::System.Collections.Generic.IList<string> DocumentedElement.GetDocumentationLines() => Soal.__CustomImpl.DocumentedElement_GetDocumentationLines(this);
    
        internal class __Info : __ModelClassInfo
        {
            public static readonly __Info Instance = new __Info();
    
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _baseTypes;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _allBaseTypes;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _declaredProperties;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _allDeclaredProperties;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _publicProperties;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> _publicPropertiesByName;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> _modelPropertyInfos;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _declaredOperations;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _allDeclaredOperations;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _publicOperations;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> _modelOperationInfos;
    
            private __Info() 
            {
                _baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Soal.SoalTypeInfo);
                _allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Soal.SoalTypeInfo, Soal.DeclarationInfo, Soal.AnnotatedElementInfo, Soal.NamedElementInfo, Soal.DocumentedElementInfo);
                _declaredProperties = __ImmutableArray.Create<__ModelProperty>(Soal.Struct_BaseType, Soal.Struct_Properties);
                _allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Soal.Struct_BaseType, Soal.Struct_Properties, Soal.Declaration_FullName, Soal.Declaration_Namespace, Soal.AnnotatedElement_Annotations, Soal.NamedElement_Name, Soal.DocumentedElement_Documentation);
                _publicProperties = __ImmutableArray.Create<__ModelProperty>(Soal.Struct_BaseType, Soal.Struct_Properties, Soal.Declaration_FullName, Soal.Declaration_Namespace, Soal.AnnotatedElement_Annotations, Soal.NamedElement_Name, Soal.DocumentedElement_Documentation);
                var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
                publicPropertiesByName.Add("BaseType", Soal.Struct_BaseType);
                publicPropertiesByName.Add("Properties", Soal.Struct_Properties);
                publicPropertiesByName.Add("FullName", Soal.Declaration_FullName);
                publicPropertiesByName.Add("Namespace", Soal.Declaration_Namespace);
                publicPropertiesByName.Add("Annotations", Soal.AnnotatedElement_Annotations);
                publicPropertiesByName.Add("Name", Soal.NamedElement_Name);
                publicPropertiesByName.Add("Documentation", Soal.DocumentedElement_Documentation);
                _publicPropertiesByName = publicPropertiesByName.ToImmutable();
                var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
                modelPropertyInfos.Add(Soal.Struct_BaseType, new __ModelPropertyInfo(new __ModelPropertySlot(Soal.Struct_BaseType, __ImmutableArray.Create<__ModelProperty>(Soal.Struct_BaseType), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Soal.Struct_Properties, new __ModelPropertyInfo(new __ModelPropertySlot(Soal.Struct_Properties, __ImmutableArray.Create<__ModelProperty>(Soal.Struct_Properties), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Soal.Declaration_FullName, new __ModelPropertyInfo(new __ModelPropertySlot(Soal.Declaration_FullName, __ImmutableArray.Create<__ModelProperty>(Soal.Declaration_FullName), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Soal.Declaration_Namespace, new __ModelPropertyInfo(new __ModelPropertySlot(Soal.Declaration_Namespace, __ImmutableArray.Create<__ModelProperty>(Soal.Declaration_Namespace), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Soal.Namespace_Declarations), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Soal.AnnotatedElement_Annotations, new __ModelPropertyInfo(new __ModelPropertySlot(Soal.AnnotatedElement_Annotations, __ImmutableArray.Create<__ModelProperty>(Soal.AnnotatedElement_Annotations), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Soal.NamedElement_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Soal.NamedElement_Name, __ImmutableArray.Create<__ModelProperty>(Soal.NamedElement_Name), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Soal.DocumentedElement_Documentation, new __ModelPropertyInfo(new __ModelPropertySlot(Soal.DocumentedElement_Documentation, __ImmutableArray.Create<__ModelProperty>(Soal.DocumentedElement_Documentation), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                _modelPropertyInfos = modelPropertyInfos.ToImmutable();
    
                _declaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>(Soal.DocumentedElement_GetDocumentationLines);
                _publicOperations = __ImmutableArray.Create<__ModelOperation>(Soal.DocumentedElement_GetDocumentationLines);
                var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
                    modelOperationInfos.Add(Soal.DocumentedElement_GetDocumentationLines, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                _modelOperationInfos = modelOperationInfos.ToImmutable();
            }
    
            public override __MetaModel MetaModel => Soal.MInstance;
            public override __MetaType MetaType => typeof(Struct);
    
            public override __MetaType SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.TypeSymbol);
            public override __ModelProperty? NameProperty => Soal.NamedElement_Name;
            public override __ModelProperty? TypeProperty => null;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> BaseTypes => _baseTypes;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> AllBaseTypes => _allBaseTypes;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> DeclaredProperties => _declaredProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> AllDeclaredProperties => _allDeclaredProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> PublicProperties => _publicProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> DeclaredOperations => _declaredOperations;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> AllDeclaredOperations => _allDeclaredOperations;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> PublicOperations => _publicOperations;
    
            protected override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> PublicPropertiesByName => _publicPropertiesByName;
            protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> ModelPropertyInfos => _modelPropertyInfos;
            protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> ModelOperationInfos => _modelOperationInfos;
    
            public override __IModelObject? Create(__Model? model = null, string? id = null)
            {
                var result = new Struct_Impl(id);
                if (model is not null) model.AttachObject(result);
                return result;
            }
    
            public override string ToString()
            {
                return "Soal.StructInfo";
            }
        }
    }
}
