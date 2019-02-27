using NUnit.Framework;
using System;

namespace ExploreMars.Tests
{
    [TestFixture]
    public class RowerTests
    {
        private Grid grid;
        [SetUp]
        public void SetUp()
        {
            grid = new Grid();
        }

        [Test]
        public void first_input_should_be_the_size_of_the_grid()
        {
            var input = "5 5";

            grid.Input(input);

            Assert.That(grid.Width, Is.EqualTo(5));
            Assert.That(grid.Height, Is.EqualTo(5));
        }

        [Test]
        public void second_input_should_be_the_starting_cordinates_of_the_rower()
        {
            var inputOne = "5 5";
            var inputTwo = "1 2 N";
            grid.Input(inputOne);

            var position = grid.Input(inputTwo);

            Assert.That(position, Is.EqualTo(inputTwo));
        }

        [Test]
        public void after_the_third_input_should_return_the_new_position_of_the_rower()
        {
            var inputOne = "5 5";
            var inputTwo = "1 2 N";
            var inputThree = "LMLMLMLMM";
            var expectedCordinates = "1 3 N";
            grid.Input(inputOne);
            grid.Input(inputTwo);

            var position = grid.Input(inputThree);

            Assert.That(position, Is.EqualTo(expectedCordinates));
        }

        [Test]
        public void forth_input_should_be_the_starting_coordinates_of_a_new_rower()
        {
            var inputOne = "5 5";
            var inputTwo = "1 2 N";
            var inputThree = "LMLMLMLMM";
            var inputFour = "3 3 E";
            var expectedCordinates = "3 3 E";
            grid.Input(inputOne);
            grid.Input(inputTwo);
            grid.Input(inputThree);

            var position = grid.Input(inputFour);

            Assert.That(position, Is.EqualTo(expectedCordinates));
        }

        [Test]
        public void after_the_fifth_input_should_return_the_new_position_of_the_rower()
        {
            var inputOne = "5 5";
            var inputTwo = "1 2 N";
            var inputThree = "LMLMLMLMM";
            var inputFour = "3 3 E";
            var inputFive = "MMRMMRMRRM";
            var expectedCordinates = "5 1 E";
            grid.Input(inputOne);
            grid.Input(inputTwo);
            grid.Input(inputThree);
            grid.Input(inputFour);

            var position = grid.Input(inputFive);

            Assert.That(position, Is.EqualTo(expectedCordinates));
        }

        [TestCase("5 B")]
        [TestCase("A B")]
        [TestCase("Z 1")]
        [TestCase("1")]
        public void should_throw_an_error_when_the_size_input_is_invalid(string input)
        {
            Assert.Throws<InvalidOperationException>(() => grid.Input(input), "Invalid Input");
        }

        [TestCase("A 1 N")]
        [TestCase("1 1 R")]
        [TestCase("4 B S")]
        public void should_not_land_the_rower_when_landing_input_is_invalid(string input)
        {
            grid.Input("4 4");

            Assert.Throws<InvalidOperationException>(() => grid.Input(input), "Invalid Input");
        }
    }
}
