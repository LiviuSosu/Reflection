namespace Reflection
{
    public class PrivateClass
    {
        public PrivateClass()
        {
            subPrivateClass = new SubPrivateClass();
        }

        private SubPrivateClass subPrivateClass;
    }

    public class SubPrivateClass
    {
        public SubPrivateClass()
        {
            privateField = 10;
        }

        private int privateField;
    }
}
