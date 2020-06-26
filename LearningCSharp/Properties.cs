using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LearningCSharp
{
    public class Properties
    {
       
        [Fact]
        public void AssigningDataToAnObject()
        {
            var emp = new Employee();

            emp.FirstName = "Robert";

            Assert.Equal("Robert", emp.FirstName);
            Assert.Equal(50000, emp.Salary);

            emp.GiveRaise(5000);
            Assert.Equal(55000, emp.Salary);
        }

        [Fact]
        public void UsingObjectInitializers()
        {
            var sue = new Employee();
            sue.FirstName = "Susan";
            sue.LastName = "Smith";

            var sean = new Employee
            {
                FirstName = "Sean",
                LastName = "Carlin"
            };

        }


        [Fact]
        public void MyStuff()
        {
            var things = new BoxOfThings<string>();
            things[0] = "bread";
            things[1] = "milk";
            things[2] = "Shampo";

            Assert.Equal("milk", things[1]);

            var favoriteNumbers = new BoxOfThings<int>();
            favoriteNumbers[0] = 9;
            favoriteNumbers[1] = 20;

            var answer = favoriteNumbers[0] + favoriteNumbers[1];
        }

        [Fact]
        public void SwappingVariableValues()
        {
           // var helpers = new Helpers();
            int x = 10;
            int y = 20;

        //    Helpers.Swap<int>(ref x, ref y);

            Assert.Equal(20, x);
            Assert.Equal(10, y);
        }

       

    }

}
