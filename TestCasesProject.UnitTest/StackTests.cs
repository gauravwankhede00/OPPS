using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestCasesProject.UnitTest
{
    [TestFixture]
    class StackTests
    {
        TestNinja.Fundamentals.Stack<string> stack;
        [SetUp]
        public void SetUp()
        {
            stack = new TestNinja.Fundamentals.Stack<string>();
        }
        [Test]
        public void Push_EmptyValue_ThrowArgumentNullException()
        {
            Assert.That(() => stack.Push(null), Throws.Exception.TypeOf<ArgumentNullException>());
        }
        [Test]
        public void Push_PushValue_Return2()
        {
            stack.Push("GAURAV");
            stack.Push("Komal");
            Assert.That(stack.Count, Is.EqualTo(2));
        }
        [Test]
        public void Push_Pop_ReturnInvalidOperationException()
        {
            stack.Push("GAURAV");
            stack.Pop();

            Assert.That(() => stack.Pop(), Throws.Exception.TypeOf<InvalidOperationException>());
        }

        [Test]
        public void Push_Pop_Return1()
        {
            stack.Push("GAURAV");
            stack.Push("Komal");
            stack.Pop();

            Assert.That(stack.Count, Is.EqualTo(1));
        }

    }
}
