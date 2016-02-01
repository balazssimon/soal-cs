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
            annotations.Add(SoalAnnotations.NoWrap);
            allowedAnnotations.Add(typeof(Property), annotations);

            annotations = new HashSet<string>();
            annotations.Add(SoalAnnotations.NoWrap);
            allowedAnnotations.Add(typeof(Parameter), annotations);

            annotations = new HashSet<string>();
            annotations.Add(SoalAnnotations.All);
            annotations.Add(SoalAnnotations.Choice);
            allowedAnnotations.Add(typeof(Struct), annotations);

            annotations = new HashSet<string>();
            annotations.Add(SoalAnnotations.All);
            annotations.Add(SoalAnnotations.Choice);
            allowedAnnotations.Add(typeof(Exception), annotations);

        }

        protected override void DoCompile()
        {
            base.DoCompile();
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
    }
}
