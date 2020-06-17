using System;

namespace CodeSamples.Classes
{
    /// <summary>
    /// Only »public« and »internal« (default, if no modifier specified) can be used in namespace level
    /// Source: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/access-modifiers
    /// </summary>
    internal class InternalClass
    {
        /// <summary>
        /// public: The type or member can be accessed by any other code in the same assembly or another assembly that references it.
        /// Usage: general, when member has to be accessible everywhere
        /// </summary>
        public int PublicMember = 0;

        /// <summary>
        /// private: The type or member can be accessed only by code in the same class or struct.
        /// Usage: general, when member has to stay hidden
        /// </summary>
        private int PrivateMember = 0;

        /// <summary>
        /// protected: The type or member can be accessed only by code in the same class, or in a class that is derived from that class.
        /// Usage: e.g. derived class can access member of base abstract class, but no other class can access it
        /// </summary>
        protected int ProtectedMember = 0;

        /// <summary>
        /// internal: The type or member can be accessed by any code in the same assembly, but not from another assembly.
        /// Usage: general, access from same assembly (exe or dll); it's default modifier (for class or struct) if no other is set
        /// </summary>
        internal int InternalMember = 0;

        /// <summary>
        /// protected internal: The type or member can be accessed by any code in the assembly in which it's declared, or from within a derived class in another assembly.
        /// </summary>
        protected internal int ProtectedInternalMember = 0;

        /// <summary>
        /// private protected: The type or member can be accessed only within its declaring assembly, by code in the same class or in a type that is derived from that class.
        /// </summary>
        private protected int PrivateProtectedMember = 0;
    }

    /// <summary>
    /// Members can have all modifiers, even if it is a child class
    /// </summary>
    public class PublicClass
    {
        private class PrivateClassInAnotherClass
        {

        }

        protected class ProtectedClassInAnotherClass
        {

        }

        private protected int PrivateProtectedMember = 0;
    }

    public class AccessModifiersSample : SampleExecute
    {
        public override void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
