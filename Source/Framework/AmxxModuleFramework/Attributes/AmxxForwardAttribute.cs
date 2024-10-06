using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldSrc.Amxmodx.Framework.Attributes;

public class AmxxForwardAttribute : Attribute
{
    public string Name { get; set; }
    public AmxxForwardAttribute(string Name)
    {
        this.Name = Name;
    }
    public AmxxForwardAttribute()
    {
        this.Name = "";
    }
}

