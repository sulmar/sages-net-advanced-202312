using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackExample;

internal class Article
{
    public string Title { get; set; }
    public string Content { get; set; }    
    public string Notes { get; set; }

    public override string ToString() => $"{Title} {Content} {Notes}";
}


