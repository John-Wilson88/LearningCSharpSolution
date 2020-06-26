using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LearningCSharp
{
    class VariousOopStuff
    {
        public void MakingARetiree()
        {
            var earl = new Retiree()
            {
                FirstName = "Earl",
                LastName = "Jones"
            };

            Assert.Equal("Earl", earl.FirstName);
            Assert.Equal("Jones", earl.LastName);
            Assert.Equal(38000M, earl.Pension);

        }
    }
}
