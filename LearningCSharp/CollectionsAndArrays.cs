using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Sdk;

namespace LearningCSharp
{
    public class CollectionsAndArrays
    {
        [Fact]
        public void UsingAnOldSchoolArrayList()
        {
            var favoriteNumber = new ArrayList();
            favoriteNumber.Add(9);
            favoriteNumber.Add(20);
            favoriteNumber.Add(42);
            favoriteNumber.Add(108);


            Assert.Equal(9, favoriteNumber[0]);
            Assert.Equal(108, favoriteNumber[3]);

            Assert.Throws<ArgumentOutOfRangeException>(() => favoriteNumber[99]);

            var firstTwo = (int)favoriteNumber[0] + (int)favoriteNumber[1];
            Assert.Equal(29, firstTwo);

            favoriteNumber.Add("Tacos");
            // the elements in an ArrayList are objects
        }

        [Fact]
        public void UsingGenericList()
        {
            // List of int - generics provide parametric polymorphism.
            var favoriteNumbers = new List<int>();
            favoriteNumbers.Add(9);
            favoriteNumbers.Add(10);

            var firstTwo = favoriteNumbers[0] + favoriteNumbers[1];
            Assert.Equal(19, firstTwo);
        }
           
        [Fact]
        public void InitializingAndEnumeratingAList()
        {
            var friends = new List<string>
            {
                "Sean",
                "Amy",
                "Jessika",
                "Tim"
            };

            Assert.Equal("Sean", friends[0]);

            var friendString = "";
            foreach(string friend in friends)
            {
                friendString += friend;

            }
            Assert.Equal("SeanAmyJessikaTim", friendString);
        }

        [Fact]
        public void UsingDeictionary()
        {
            var friends = new Dictionary<char, string>();
            friends.Add('s', "Sean");
            friends.Add('d', "David");

            Assert.Equal("David", friends['d']);
        }

        [Fact]
        public void InitializingAndEnumeratingADictionary()
        {
            var friends = new Dictionary<char, string>
            {
                {'s', "Sean" },
                {'d', "David" },
                {'b', "Sean" }
            };

            Assert.Equal("David", friends['d']);
        }

    }
}