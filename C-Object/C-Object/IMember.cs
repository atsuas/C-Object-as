using System;
namespace C_Object
{
    public interface IMember
    {
        float Rate { get; }
        string GetName { get; }
    }

    public sealed class SilverMember : IMember
    {
        public float Rate => 1.0f;

        public string GetName()
        {
            return "シルバー";
        }

    public sealed class GoldrMember : IMember
    {
        public float Rate => 0.8f;

            public string GetName()
            {
                return "ゴールド";
            }
        }

    public sealed class PlatinumMember : IMember
    {
        public float Rate => 0.6f;

            public string GetName()
            {
                return "プラチナ";
            }
        }
}
