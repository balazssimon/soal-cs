using MetaDslx.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Soal
{
    public class SoalCompiler : SoalCompilerBase
    {
        private Dictionary<Type, HashSet<string>> allowedAnnotations = new Dictionary<Type, HashSet<string>>();

        public SoalCompiler(string source, string fileName)
            : base(source, fileName)
        {
            this.GlobalScope.BuiltInEntries.Add((ModelObject)SoalInstance.Object);
            this.GlobalScope.BuiltInEntries.Add((ModelObject)SoalInstance.String);
            this.GlobalScope.BuiltInEntries.Add((ModelObject)SoalInstance.Int);
            this.GlobalScope.BuiltInEntries.Add((ModelObject)SoalInstance.Long);
            this.GlobalScope.BuiltInEntries.Add((ModelObject)SoalInstance.Float);
            this.GlobalScope.BuiltInEntries.Add((ModelObject)SoalInstance.Double);
            this.GlobalScope.BuiltInEntries.Add((ModelObject)SoalInstance.Byte);
            this.GlobalScope.BuiltInEntries.Add((ModelObject)SoalInstance.Bool);
            this.GlobalScope.BuiltInEntries.Add((ModelObject)SoalInstance.Void);
            this.GlobalScope.BuiltInEntries.Add((ModelObject)SoalInstance.Date);
            this.GlobalScope.BuiltInEntries.Add((ModelObject)SoalInstance.Time);
            this.GlobalScope.BuiltInEntries.Add((ModelObject)SoalInstance.DateTime);
            this.GlobalScope.BuiltInEntries.Add((ModelObject)SoalInstance.TimeSpan);

            HashSet<string> annotations;

            annotations = new HashSet<string>();
            annotations.Add(SoalAnnotations.NoWrap);
            annotations.Add(SoalAnnotations.Rpc);
            allowedAnnotations.Add(typeof(Interface), annotations);

            annotations = new HashSet<string>();
            annotations.Add(SoalAnnotations.Attribute);
            annotations.Add(SoalAnnotations.Element);
            annotations.Add(SoalAnnotations.Restriction);
            allowedAnnotations.Add(typeof(Property), annotations);

            annotations = new HashSet<string>();
            annotations.Add(SoalAnnotations.Attribute);
            annotations.Add(SoalAnnotations.Element);
            annotations.Add(SoalAnnotations.Restriction);
            allowedAnnotations.Add(typeof(InputParameter), annotations);

            annotations = new HashSet<string>();
            annotations.Add(SoalAnnotations.Attribute);
            annotations.Add(SoalAnnotations.Element);
            annotations.Add(SoalAnnotations.Restriction);
            allowedAnnotations.Add(typeof(OutputParameter), annotations);

            annotations = new HashSet<string>();
            annotations.Add(SoalAnnotations.All);
            annotations.Add(SoalAnnotations.Choice);
            annotations.Add(SoalAnnotations.Type);
            allowedAnnotations.Add(typeof(Struct), annotations);

            annotations = new HashSet<string>();
            annotations.Add(SoalAnnotations.All);
            annotations.Add(SoalAnnotations.Choice);
            annotations.Add(SoalAnnotations.Type);
            allowedAnnotations.Add(typeof(Exception), annotations);

            annotations = new HashSet<string>();
            annotations.Add(SoalAnnotations.Enum);
            allowedAnnotations.Add(typeof(EnumLiteral), annotations);

        }

        protected override void DoCompile()
        {
            base.DoCompile();
            this.Validate();
        }

        private void Validate()
        {
            this.ValidateAnnotations();
            this.ValidateEndpoints();
        }

        private void ValidateAnnotations()
        {
            foreach (var ae in this.Model.CachedInstances.OfType<AnnotatedElement>())
            {
                foreach (var annot in ae.Annotations)
                {
                    bool allowed = false;
                    HashSet<string> validAnnotations = new HashSet<string>();
                    foreach (var entry in this.allowedAnnotations)
                    {
                        if (entry.Key.IsAssignableFrom(ae.GetType()))
                        {
                            foreach (var va in entry.Value)
                            {
                                if (va == annot.Name)
                                {
                                    allowed = true;
                                    break;
                                }
                                validAnnotations.Add(va);
                            }
                        }
                        if (allowed) break;
                    }
                    if (!allowed)
                    {
                        string valids = null;
                        foreach (var va in validAnnotations.OrderBy(s => s))
                        {
                            if (valids == null) valids = "'" + va + "'";
                            else valids += ", '" + va + "'";
                        }
                        if (valids != null)
                        {
                            this.Diagnostics.AddError("Invalid annotation '" + annot.Name + "' on '" + ae + "'. Valid annotations are: " + valids, this.FileName, (ModelObject)ae);
                        }
                        else
                        {
                            this.Diagnostics.AddError("Invalid annotation '" + annot.Name + "' on '" + ae + "'. This element cannot have annotations.", this.FileName, (ModelObject)ae);
                        }
                    }
                }
            }
        }

        private void ValidateEndpoints()
        {
            foreach (var endp in this.Model.CachedInstances.OfType<Endpoint>())
            {
                if (endp.Interface != null && endp.Binding != null)
                {
                    bool rpc = endp.Interface.HasAnnotation(SoalAnnotations.Rpc);
                    bool noWrap = endp.Interface.HasAnnotation(SoalAnnotations.NoWrap);
                    SoapEncodingBindingElement enc = endp.Binding.Encodings.OfType<SoapEncodingBindingElement>().FirstOrDefault();
                    if (enc != null)
                    {
                        switch (enc.Style)
                        {
                            case SoapEncodingStyle.DocumentWrapped:
                                if (rpc)
                                {
                                    this.Diagnostics.AddError("The interface of the endpoint has an '"+SoalAnnotations.Rpc+ "' annotation, but the SOAP binding style for the endpoint is '"+SoapEncodingStyle.DocumentWrapped+ "'. Consider using the '" + SoapEncodingStyle.RpcLiteral + "' style instead, or remove the '" + SoalAnnotations.Rpc + "' annotation from the interface.", this.FileName, (ModelObject)endp);
                                }
                                if (noWrap)
                                {
                                    this.Diagnostics.AddError("The interface of the endpoint has a '" + SoalAnnotations.NoWrap + "' annotation, but the SOAP binding style for the endpoint is '" + SoapEncodingStyle.DocumentWrapped + "'. Consider using the '" + SoapEncodingStyle.DocumentLiteral + "' style instead, or remove the '" + SoalAnnotations.NoWrap + "' annotation from the interface.", this.FileName, (ModelObject)endp);
                                }
                                break;
                            case SoapEncodingStyle.DocumentLiteral:
                                if (rpc)
                                {
                                    this.Diagnostics.AddError("The interface of the endpoint has an '" + SoalAnnotations.Rpc + "' annotation, but the SOAP binding style for the endpoint is '" + SoapEncodingStyle.DocumentLiteral + "'. Consider using the '" + SoapEncodingStyle.RpcLiteral + "' style instead, or remove the '" + SoalAnnotations.Rpc + "' annotation from the interface.", this.FileName, (ModelObject)endp);
                                }
                                if (!noWrap)
                                {
                                    this.Diagnostics.AddError("The interface of the endpoint has no '" + SoalAnnotations.NoWrap + "' annotation, but the SOAP binding style for the endpoint is '" + SoapEncodingStyle.DocumentLiteral + "'. Consider using the '" + SoapEncodingStyle.DocumentWrapped + "' style instead, or add the '" + SoalAnnotations.NoWrap + "' annotation to the interface.", this.FileName, (ModelObject)endp);
                                }
                                break;
                            case SoapEncodingStyle.RpcLiteral:
                                if (!rpc)
                                {
                                    this.Diagnostics.AddError("The interface of the endpoint has no '" + SoalAnnotations.Rpc + "' annotation, but the SOAP binding style for the endpoint is '" + SoapEncodingStyle.RpcLiteral + "'. Consider using the '" + SoapEncodingStyle.DocumentWrapped + "' style instead, or add the '" + SoalAnnotations.Rpc + "' annotation to the interface.", this.FileName, (ModelObject)endp);
                                }
                                break;
                            case SoapEncodingStyle.RpcEncoded:
                                if (!rpc)
                                {
                                    this.Diagnostics.AddError("The interface of the endpoint has no '" + SoalAnnotations.Rpc + "' annotation, but the SOAP binding style for the endpoint is '" + SoapEncodingStyle.RpcEncoded + "'. Consider using the '" + SoapEncodingStyle.DocumentWrapped + "' style instead, or add the '" + SoalAnnotations.Rpc + "' annotation to the interface.", this.FileName, (ModelObject)endp);
                                }
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
        }
    }
}
