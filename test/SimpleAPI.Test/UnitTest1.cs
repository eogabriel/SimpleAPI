using SimpleAPI.Controllers;
using System.Linq;
using Xunit;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {
        WeatherForecastController controller = new WeatherForecastController();

        [Fact]
        public void Get_ReturnsListOfWeatherForecasts()
        {
            var result = controller.Get();

            Assert.Equal(5, result.Count());
        }

        [Fact]
        public void Test2()
        {
            //test
        }

        [Fact]
        public void Test3()
        {

        }
    }
}
