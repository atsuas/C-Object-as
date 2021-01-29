using System;
namespace C_Object
{
    public static class MemberFactory
    {
        public enum MemberKind
        {
            Silver,
            Gold,
            Platinum,
        }

        public static IMember Create(MemberKind member)
        {
            if (member == MemberKind.Gold)
            {
                return new GoldMember();
            }

            if (member == MemberKind.Platinum)
            {
                return new PlatinumMember();
            }

            return new SilverMember();
        }
    }
}
