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

    internal class Assembly_Impl : __MetaModelObject, Assembly
    {
        private Assembly_Impl(string? id)
            : base(id)
        {
            Soal.__CustomImpl.DocumentedElement(this);
            Soal.__CustomImpl.NamedElement(this);
            Soal.__CustomImpl.AnnotatedElement(this);
            Soal.__CustomImpl.Declaration(this);
            Soal.__CustomImpl.SoalType(this);
            Soal.__CustomImpl.Component(this);
            Soal.__CustomImpl.Composite(this);
            Soal.__CustomImpl.Assembly(this);
        }
    
        public override __ModelClassInfo MInfo => __Info.Instance;
    
        public global::MetaDslx.Modeling.ICollectionSlot<MetaDslx.Languages.Soal.Symbols.Component> Components
        {
            get => MGetCollection<Component>(Soal.Composite_Components);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<MetaDslx.Languages.Soal.Symbols.Wire> Wires
        {
            get => MGetCollection<Wire>(Soal.Composite_Wires);
        }
    
        public MetaDslx.Languages.Soal.Symbols.Component BaseComponent
        {
            get => MGet<MetaDslx.Languages.Soal.Symbols.Component>(Soal.Component_BaseComponent);
            set => MSet<MetaDslx.Languages.Soal.Symbols.Component>(Soal.Component_BaseComponent, value);
        }
    
        public MetaDslx.Languages.Soal.Symbols.Implementation Implementation
        {
            get => MGet<MetaDslx.Languages.Soal.Symbols.Implementation>(Soal.Component_Implementation);
            set => MSet<MetaDslx.Languages.Soal.Symbols.Implementation>(Soal.Component_Implementation, value);
        }
    
        public bool IsAbstract
        {
            get => MGet<bool>(Soal.Component_IsAbstract);
            set => MSet<bool>(Soal.Component_IsAbstract, value);
        }
    
        public MetaDslx.Languages.Soal.Symbols.ProgrammingLanguage Language
        {
            get => MGet<MetaDslx.Languages.Soal.Symbols.ProgrammingLanguage>(Soal.Component_Language);
            set => MSet<MetaDslx.Languages.Soal.Symbols.ProgrammingLanguage>(Soal.Component_Language, value);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<MetaDslx.Languages.Soal.Symbols.Port> Ports
        {
            get => MGetCollection<Port>(Soal.Component_Ports);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<MetaDslx.Languages.Soal.Symbols.Property> Properties
        {
            get => MGetCollection<Property>(Soal.Component_Properties);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<MetaDslx.Languages.Soal.Symbols.Reference> References
        {
            get => MGetCollection<Reference>(Soal.Component_References);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<MetaDslx.Languages.Soal.Symbols.Service> Services
        {
            get => MGetCollection<Service>(Soal.Component_Services);
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
                _baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Soal.CompositeInfo);
                _allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Soal.CompositeInfo, Soal.ComponentInfo, Soal.SoalTypeInfo, Soal.DeclarationInfo, Soal.AnnotatedElementInfo, Soal.NamedElementInfo, Soal.DocumentedElementInfo);
                _declaredProperties = __ImmutableArray.Create<__ModelProperty>();
                _allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Soal.Composite_Components, Soal.Composite_Wires, Soal.Component_BaseComponent, Soal.Component_Implementation, Soal.Component_IsAbstract, Soal.Component_Language, Soal.Component_Ports, Soal.Component_Properties, Soal.Component_References, Soal.Component_Services, Soal.Declaration_FullName, Soal.Declaration_Namespace, Soal.AnnotatedElement_Annotations, Soal.NamedElement_Name, Soal.DocumentedElement_Documentation);
                _publicProperties = __ImmutableArray.Create<__ModelProperty>(Soal.Composite_Components, Soal.Composite_Wires, Soal.Component_BaseComponent, Soal.Component_Implementation, Soal.Component_IsAbstract, Soal.Component_Language, Soal.Component_Ports, Soal.Component_Properties, Soal.Component_References, Soal.Component_Services, Soal.Declaration_FullName, Soal.Declaration_Namespace, Soal.AnnotatedElement_Annotations, Soal.NamedElement_Name, Soal.DocumentedElement_Documentation);
                var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
                publicPropertiesByName.Add("Components", Soal.Composite_Components);
                publicPropertiesByName.Add("Wires", Soal.Composite_Wires);
                publicPropertiesByName.Add("BaseComponent", Soal.Component_BaseComponent);
                publicPropertiesByName.Add("Implementation", Soal.Component_Implementation);
                publicPropertiesByName.Add("IsAbstract", Soal.Component_IsAbstract);
                publicPropertiesByName.Add("Language", Soal.Component_Language);
                publicPropertiesByName.Add("Ports", Soal.Component_Ports);
                publicPropertiesByName.Add("Properties", Soal.Component_Properties);
                publicPropertiesByName.Add("References", Soal.Component_References);
                publicPropertiesByName.Add("Services", Soal.Component_Services);
                publicPropertiesByName.Add("FullName", Soal.Declaration_FullName);
                publicPropertiesByName.Add("Namespace", Soal.Declaration_Namespace);
                publicPropertiesByName.Add("Annotations", Soal.AnnotatedElement_Annotations);
                publicPropertiesByName.Add("Name", Soal.NamedElement_Name);
                publicPropertiesByName.Add("Documentation", Soal.DocumentedElement_Documentation);
                _publicPropertiesByName = publicPropertiesByName.ToImmutable();
                var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
                modelPropertyInfos.Add(Soal.Composite_Components, new __ModelPropertyInfo(new __ModelPropertySlot(Soal.Composite_Components, __ImmutableArray.Create<__ModelProperty>(Soal.Composite_Components), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Soal.Composite_Wires, new __ModelPropertyInfo(new __ModelPropertySlot(Soal.Composite_Wires, __ImmutableArray.Create<__ModelProperty>(Soal.Composite_Wires), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Soal.Component_BaseComponent, new __ModelPropertyInfo(new __ModelPropertySlot(Soal.Component_BaseComponent, __ImmutableArray.Create<__ModelProperty>(Soal.Component_BaseComponent), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Soal.Component_Implementation, new __ModelPropertyInfo(new __ModelPropertySlot(Soal.Component_Implementation, __ImmutableArray.Create<__ModelProperty>(Soal.Component_Implementation), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Soal.Component_IsAbstract, new __ModelPropertyInfo(new __ModelPropertySlot(Soal.Component_IsAbstract, __ImmutableArray.Create<__ModelProperty>(Soal.Component_IsAbstract), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Soal.Component_Language, new __ModelPropertyInfo(new __ModelPropertySlot(Soal.Component_Language, __ImmutableArray.Create<__ModelProperty>(Soal.Component_Language), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Soal.Component_Ports, new __ModelPropertyInfo(new __ModelPropertySlot(Soal.Component_Ports, __ImmutableArray.Create<__ModelProperty>(Soal.Component_Ports), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Soal.Port_Component), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Soal.Component_References, Soal.Component_Services), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Soal.Component_Properties, new __ModelPropertyInfo(new __ModelPropertySlot(Soal.Component_Properties, __ImmutableArray.Create<__ModelProperty>(Soal.Component_Properties), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Soal.Component_References, new __ModelPropertyInfo(new __ModelPropertySlot(Soal.Component_References, __ImmutableArray.Create<__ModelProperty>(Soal.Component_References), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Soal.Component_Ports), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Soal.Component_Services, new __ModelPropertyInfo(new __ModelPropertySlot(Soal.Component_Services, __ImmutableArray.Create<__ModelProperty>(Soal.Component_Services), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Soal.Component_Ports), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
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
            public override __MetaType MetaType => typeof(Assembly);
    
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
                var result = new Assembly_Impl(id);
                if (model is not null) model.AttachObject(result);
                return result;
            }
    
            public override string ToString()
            {
                return "Soal.AssemblyInfo";
            }
        }
    }
}
