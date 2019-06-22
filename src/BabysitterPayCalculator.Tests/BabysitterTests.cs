﻿using BabySitterPayCalculator.Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BabysitterPayCalculator.Tests
{
    [TestClass]
    public class BabysitterTests
    {
        private Babysitter Babysitter;

        /// <summary>
        ///     Initializes before each test.
        /// </summary>
        [TestInitialize]
        public void TestInitialize()
        {
            Babysitter = new Babysitter();
        }

        [TestMethod]
        public void Babysitter_MinimumStartTime_ReturnsValuePassed()
        {
            // Arrange.
            var minimumStartTime = new TimeSpan(1);

            // Act.
            Babysitter.MinimumStartTime = minimumStartTime;

            // Assert.
            Assert.AreEqual(minimumStartTime, Babysitter.MinimumStartTime);
        }
    }
}
