using algo05_array;
using Xunit;

namespace algo05_array_tests
{
    public class MyArray_Tests
    {
        public MyArray<int> Arrays { get; set; }

        public MyArray_Tests()
        {
        }

        [Fact]
        public void Can_Insert()
        {
            Arrays = new MyArray<int>(10);

            Arrays.Insert(0, 1);
            Arrays.Insert(1, 2);
            Arrays.Insert(2, 3);
            Arrays.Insert(1, 22);
            Arrays.Insert(7, 7);
            Arrays.Insert(9, 10);
            Arrays.Insert(9, 11);

            Assert.Equal(10, Arrays.Length);
        }

        [Fact]
        public void Can_Delete()
        {
            Arrays = new MyArray<int>(10);

            Arrays.Delete(0);
            Arrays.Delete(9);

            Arrays.Insert(0, 1);
            Arrays.Insert(1, 2);
            Arrays.Insert(2, 3);
            Arrays.Insert(1, 22);
            Arrays.Insert(7, 7);
            Arrays.Insert(9, 10);
            Arrays.Insert(9, 11);

            Arrays.Delete(0);
            Arrays.Delete(2);
            Arrays.Delete(9);

            Assert.Equal(8, Arrays.Length);
        }

        [Fact]
        public void Can_IndexOf()
        {
            Arrays = new MyArray<int>(10);

            var zeroPis_ZeroVal = Arrays.IndexOf(0);
            var onePis_OtherValue = Arrays.IndexOf(1);

            Arrays.Insert(0, 1);
            Arrays.Insert(1, 2);
            Arrays.Insert(2, 3);
            Arrays.Insert(1, 22);
            Arrays.Insert(7, 7);
            Arrays.Insert(9, 10);
            Arrays.Insert(9, 11);

            var zeroPis_SomeVal = Arrays.IndexOf(0);
            var onePis_SomeVal = Arrays.IndexOf(1);
            var sevebPis_SomeVal = Arrays.IndexOf(7);
            var tenPis_SomeVal = Arrays.IndexOf(10);
            var elvPis_SomeVal = Arrays.IndexOf(11);

            Assert.Equal(-1, zeroPis_ZeroVal);
            Assert.Equal(-1, onePis_OtherValue);
            Assert.Equal(4, zeroPis_SomeVal);
            Assert.Equal(0, onePis_SomeVal);
            Assert.Equal(7, sevebPis_SomeVal);
            Assert.Equal(-1, tenPis_SomeVal);
            Assert.Equal(9, elvPis_SomeVal);
        }
    }
}