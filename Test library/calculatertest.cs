using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using calculator2;
using Xunit;

namespace Test_library
{
    public class CalculaterTest
    {

        Operation Operation = new Operation();
        [Theory]
        [InlineData(4,4,8)]
        [InlineData(5,5,10)]
        public void Add_simpleValueShouldCalculate(double x,double y,double Expected)
        {
            //Arrange
            double expected = Expected;


            //Act
            Double Actual = Operation.Add(x, y);

            //Assert
            Assert.Equal(expected, Actual);
        }
        [Theory]
        [InlineData(4, 4, 0)]
        [InlineData(5, 5, 0)]
        public void Subtraction_simpleValueShouldCalculate(double x, double y, double Expected)
        {
            //Arrange
            double expected = Expected;


            //Act
            Double Actual = Operation.Subtract(x, y);

            //Assert
            Assert.Equal(expected, Actual);
        }
        [Theory]
        [InlineData(4, 4, 18)]
        [InlineData(5, 5, 25)]
        public void Multiply_SimpleValuesShouldCalculate(double x, double y, double Expected)
        {
            //Arrange
            double expected = Expected;

            //Act
            Double Actual = Operation.Multiply(x, y);

            //Assert
            Assert.Equal(expected, Actual);


        }
    }
}
