using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeBasedProgramming;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field )]
public class ImageAttribute : Attribute
{
    public string Filename { get; private set; }
    
    public ImageAttribute(string filename)
    {
        this.Filename = filename;
    }

    public ImageAttribute(string filename, float opacity)
    {
        this.Filename = filename;
    }

}
