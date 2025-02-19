using UnityEngine;
using UdonSharp;
using Koyashiro.UdonTest;

namespace Koyashiro.GenericDataContainer.Tests
{
    [AddComponentMenu("")]
    public class GetValueTest : UdonSharpBehaviour
    {
        public TestUserDefinedClass testUserDefinedClass;

        public void Start()
        {
            var list = DataList<int>.New(new int[] { 100, 200, 300, 400 });

            Assert.Equal(100, list.GetValue(0), this);
            Assert.Equal(200, list.GetValue(1), this);
            Assert.Equal(300, list.GetValue(2), this);
            Assert.Equal(400, list.GetValue(3), this);

            var list2 = DataList<TestUserDefinedClass>.New();
            list2.Add(testUserDefinedClass);
            var value = list2.GetValue(0);
            Assert.Equal("Hello, world!", value.field, this);
        }
    }
}
