#pragma warning disable CS8669

namespace MetaDslx.Languages.Soal.Symbols
{
    using __MetaMetaModel = global::MetaDslx.Languages.MetaModel.Model.Meta;
    using __MetaModelFactory = global::MetaDslx.Languages.MetaModel.Model.MetaModelFactory;
    using __Model = global::MetaDslx.Modeling.Model;
    using __MetaModel = global::MetaDslx.Modeling.MetaModel;
    using __IModelObject = global::MetaDslx.Modeling.IModelObject;
    using __ModelFactory = global::MetaDslx.Modeling.ModelFactory;
    using __MultiModelFactory = global::MetaDslx.Modeling.MultiModelFactory;
    using __ModelVersion = global::MetaDslx.Modeling.ModelVersion;
    using __ModelEnumInfo = global::MetaDslx.Modeling.ModelEnumInfo;
    using __ModelClassInfo = global::MetaDslx.Modeling.ModelClassInfo;
    using __ModelProperty = global::MetaDslx.Modeling.ModelProperty;
    using __ModelPropertyFlags = global::MetaDslx.Modeling.ModelPropertyFlags;
    using __ModelOperation = global::MetaDslx.Modeling.ModelOperation;
    using __ModelOperationInfo = global::MetaDslx.Modeling.ModelOperationInfo;
    using __ImmutableArray = global::System.Collections.Immutable.ImmutableArray;
    using __ImmutableDictionary = global::System.Collections.Immutable.ImmutableDictionary;
    using __MetaType = global::MetaDslx.CodeAnalysis.MetaType;
    using __MetaSymbol = global::MetaDslx.CodeAnalysis.MetaSymbol;
    using __Type = global::System.Type;
    using __Enum = global::System.Enum;

    public interface Component : global::MetaDslx.Languages.Soal.Symbols.SoalType
    {
        MetaDslx.Languages.Soal.Symbols.Component BaseComponent { get; set; }
        MetaDslx.Languages.Soal.Symbols.Implementation Implementation { get; set; }
        bool IsAbstract { get; set; }
        MetaDslx.Languages.Soal.Symbols.ProgrammingLanguage Language { get; set; }
        global::MetaDslx.Modeling.ICollectionSlot<MetaDslx.Languages.Soal.Symbols.Port> Ports { get; }
        global::MetaDslx.Modeling.ICollectionSlot<MetaDslx.Languages.Soal.Symbols.Property> Properties { get; }
        global::MetaDslx.Modeling.ICollectionSlot<MetaDslx.Languages.Soal.Symbols.Reference> References { get; }
        global::MetaDslx.Modeling.ICollectionSlot<MetaDslx.Languages.Soal.Symbols.Service> Services { get; }
    
    }
}
