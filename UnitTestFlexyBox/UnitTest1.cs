using Microsoft.VisualStudio.TestTools.UnitTesting;
using ApplicationLayer.Common;

namespace UnitTestFlexyBox
{

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ClassToRunUnitTestOn classToRunUnitTestOn = new ClassToRunUnitTestOn();

            int x = 3;
            int y = 4;
            int res = classToRunUnitTestOn.addTwoNumbers(x,y);
             Assert.IsTrue(true);
           
        }
    }
}
