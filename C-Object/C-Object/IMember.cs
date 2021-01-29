using System;
namespace C_Object
{
    public interface IMember
    {
        float Rate { get; }
    }

    public sealed class SilverMember : IMember
    {
        public float Rate => 1.0f;
    }

    public sealed class GoldrMember : IMember
    {
        public float Rate => 0.8f;
    }

    public sealed class PlatinumMember : IMember
    {
        public float Rate => 0.6f;
    }
}
