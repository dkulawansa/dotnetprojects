using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using SampleStack;

namespace StackTests
{
    [TestClass]
    public class StackUnitTest
    {   // Instantiate stack
        Stack myStack = new Stack();

        [TestMethod]
        public void Stack_With_No_Push()
        {
            // Perform no operation on the stack and verify that the stack is empty
            bool expected = true;
            bool actual = StackProgram.IsStackEmpty(myStack);
            // Assert that there are on elements in the stack
            Assert.AreEqual(expected, actual, "Stack is empty ");
        }

        [TestMethod]
        public void Stack_With_Valid_Pushes()
        {
            // Perform three push operations on the stack to arrange the test
            StackProgram.StackPush(10, myStack);
            StackProgram.StackPush(20, myStack);
            StackProgram.StackPush(30, myStack);
            int expected = 3;
            int actual = StackProgram.StackCount(myStack);

            // Assert that there are three elements in the stack
            Assert.AreEqual(expected, actual, "Number of items pushed to stack");
        }

        [TestMethod]
        public void Stack_Pops_Remove_Last_Push()
        {
            // Perform three push operations on the stack to arrange the test
            StackProgram.StackPush(10, myStack);
            StackProgram.StackPush(20, myStack);
            StackProgram.StackPush(30, myStack);
            object expected = 30;
            int expected_count = 2;
            object actual = StackProgram.StackPop(myStack);
            int actual_count = StackProgram.StackCount(myStack);

            // Verify that there are two element in the stack after Pop operation
            Assert.AreEqual(expected, actual, "Number of items pushed to stack");
            Assert.AreEqual(expected_count, actual_count, "Number of items after a Pop");
        }

        [TestMethod]
        public void Stack_Peek_Give_Top_Item_No_Change_to_Stack()
        {
            // Perform three push operations on the stack to arrange the test
            StackProgram.StackPush(10, myStack);
            StackProgram.StackPush(20, myStack);
            StackProgram.StackPush(30, myStack);
            object expected = 30;
            object actual = StackProgram.StackPeek(myStack);
            int expected_count = 3;
            int actual_count = StackProgram.StackCount(myStack);

            // Verify that there are all three elements in the stack after Peek operation
            Assert.AreEqual(expected, actual, "Number of items pushed to stack is 3");
            Assert.AreEqual(expected_count, actual_count, "Number of items after a Pop");
        }
    }
}
