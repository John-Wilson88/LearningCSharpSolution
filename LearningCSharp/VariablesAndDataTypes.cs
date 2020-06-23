using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.ObjectModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using Xunit;

namespace LearningCSharp
{
    
    public class VariablesAndDataTypes
    {
        [Fact]
        public void SomeOfTheBuildInTypes()
        {
            int age;
            age = 22;
            Int32 yourAge;
            yourAge = 23;
            string name;
            name = "Jeff";
            String yourName;
            yourName = "John";


            Double pay = 33.22;
            decimal yourPay = 33.22M; // when using the decimal key word the 'M' is required.

            Boolean isAwake = true;
            bool over = 12 > 13;

            int x;

            x = 0;
            Assert.Equal(0, x);
        }

        [Fact]
        public void ImplicitlyTypedLocalVariables()
        {
            // var is for implicit declarations, the compiler changes it with actual type
            var name = "Tom";
            var number = 5;

            //Employee bob = new Employee();
            //var sur = new Employee();



        }

        [Fact]
        public void ValueTypes()
        {
            // structs
            int age = 52;
            DateTime myBirthday  = new DateTime(1969, 4, 20);
            string myName = "Jeff";

            DoubleIt(age);
            Assert.Equal(52, age);
        }
        [Fact]
        public void UsingRefAndOut()
        {
            int y = 50;
            DoubleItRef(ref y);
            Assert.Equal(100, y);
        }

        public void DoubleItRef(ref int x)
        {
            x = x + x; 
        }

        public void GimmeSomething(out int z)
        {
            z = 42;
        }






        public void DoublIt(int x)
        {
            x = x + x;
        }

    }

    

}
