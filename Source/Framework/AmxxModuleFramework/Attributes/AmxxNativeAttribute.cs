namespace GoldSrc.Amxmodx.Framework.Attributes;

public class AmxxNativeAttribute : Attribute
{
    public string Name { get; set; }
    public AmxxNativeAttribute(string Name)
    {
        this.Name = Name;
    }
    public AmxxNativeAttribute()
    {
        this.Name = "";
    }
}
