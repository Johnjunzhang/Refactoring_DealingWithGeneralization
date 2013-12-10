using DealingWithGeneralization.ReplaceInheritanceWithDelegation;
using Xunit;

namespace DealingWithGeneralizationFacts
{
    public class ReplaceInheritanceWithDelegationFact
    {
        [Fact]
        public void should_get_size_for_my_stack()
        {
            var myStack = new MyStack();
            myStack.Push(2);
            Assert.Equal(1, myStack.Size());
        }

        [Fact]
        public void should_get_is_empty_for_my_stack()
        {
            var myStack = new MyStack();
            myStack.Push(2);
            Assert.False(myStack.IsEmpty());

            myStack.Pop();
            Assert.True(myStack.IsEmpty());
        }
    }
}