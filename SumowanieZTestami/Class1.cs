using Xunit;

namespace SumowanieZTestami
{
    public class Class1
    {
        [Fact]
        public void Sumowanie_zwraca_sume_argumentow()
        {
            // AAA
            // arange
            var x = 2;
            var y = 2;

            // act
            var result = f(x, y);

            // assert
            Assert.Equal(4, result);
        }

        private int f(int x, int y)
        {
            return x + y;
        }
    }
}
