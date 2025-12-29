namespace OPPS
{
    internal abstract class AbstractClass1 : AbstractClass2
    {
        public AbstractClass1() { }

         

    }

    internal abstract class AbstractClass2 : AbstractClass3
    {
        public AbstractClass2() { }

        public override void Print()
        {
            throw new System.NotImplementedException();
        }


    }

    internal abstract class AbstractClass3
    {
        public AbstractClass3() { }

        public abstract void Print();

    }
}
