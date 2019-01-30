using DesignPatternsLearning.Singleton;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternsLearning.Test.Singleton
{
    [TestClass]
    public class BasicSingletonTest
    {
        [TestMethod]
        public void ShouldUseTheSameInstace()
        {
            var instance1 = BasicSingleton.Instance;
            var instance2 = BasicSingleton.Instance;

            Assert.AreEqual(instance1, instance2);
        }
    }
}
