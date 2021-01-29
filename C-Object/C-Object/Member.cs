using System;
namespace C_Object
{
    public abstract class Member
    {
        public abstract float Rate { get; }
        public abstract string GetName();

        public float GetRate()
        {
            if (DateTime.Now.Day == 12)
            {
                return 0.5f;
            }

            if (DateTime.Now.Day == 30)
            {
                return 0.5f;
            }

            return Rate;
        }
    }

    public sealed class SilverMember : Member
    {

        protected override float Rate => 1.0f;

        public override string GetName()
        {
            return "シルバー";
        }

        public sealed class GoldrMember : Member
        {
            protected override float Rate => 0.8f;

            public override string GetName()
            {
                return "ゴールド";
            }
        }

        public sealed class PlatinumMember : Member
        {
            protected override float Rate => 0.6f;

            public override string GetName()
            {
                return "プラチナ";
            }
        }
    }
}