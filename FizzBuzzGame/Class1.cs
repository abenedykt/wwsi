using System;
using Xunit;

namespace FizzBuzzGame
{
    public class Class1
    {
        [Fact]
        public void FizzBuzzGame_returns_1_when_play_1()
        {
            var game = new FizzBuzz();
            var result = game.Play(1);
            Assert.Equal(1, result);
        }

        [Fact]
        public void FizzBuzzGame_returns_Fizz_when_play_3()
        {
            var game = new FizzBuzz();
            var result = game.Play(3);
            Assert.Equal("Fizz", result);
        }

        [Fact]
        public void FizzBuzzGame_returns_Buzz_when_play_5()
        {
            var game = new FizzBuzz();
            var result = game.Play(5);
            Assert.Equal("Buzz", result);
        }

        [Fact]
        public void FizzBuzzGame_returns_FizzBuzz_when_play_15()
        {
            var game = new FizzBuzz();
            var result = game.Play(15);
            Assert.Equal("FizzBuzz", result);
        }


        [Fact]
        public void FizzBuzzGame_throws_exception_when_play_negative_number()
        {
            var game = new FizzBuzz();
            Assert.Throws<CannotPlayThisValueException>(() => game.Play(-1));
        }

    }

    internal class CannotPlayThisValueException : Exception
    {
    }

    internal class FizzBuzz
    {
        public FizzBuzz()
        {
        }

        internal object Play(int v)
        {
            if (v % 3 == 0 && v % 5 == 0)
            {
                return "FizzBuzz";
            }

            if (v % 3 == 0)
            {
                return "Fizz";
            }

            if (v % 5 == 0)
            {
                return "Buzz";
            }

            if (v < 1) throw new CannotPlayThisValueException();
            return v;
        }
    }
}
