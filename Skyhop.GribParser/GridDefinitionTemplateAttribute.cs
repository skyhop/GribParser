using System;

namespace Skyhop.GribParser
{
    [AttributeUsage(AttributeTargets.Class)]
    public class GridDefinitionTemplateAttribute : Attribute
    {
        public int TemplateNumber { get; set; }

        public GridDefinitionTemplateAttribute()
        {
            
        }
    }
}
