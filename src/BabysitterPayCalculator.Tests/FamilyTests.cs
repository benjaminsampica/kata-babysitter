﻿using BabysitterPayCalculator.Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BabysitterPayCalculator.Tests
{
    [TestClass]
    public class FamilyTests
    {
        [TestMethod]
        public void Family_AddFamilyHourlyRate_SuccessfullyAddsFamilyHourlyRate()
        {
            // Arrange.
            var family = new Family();
            var familyHourlyRate = new FamilyHourlyRate();

            // Act.
            family.AddFamilyHourlyRate(familyHourlyRate); 

            // Assert.
            var expectedFamilyHourlyRates = 1;
            Assert.AreEqual(expectedFamilyHourlyRates, family.FamilyHourlyRates.Count);
        }
    }
}
