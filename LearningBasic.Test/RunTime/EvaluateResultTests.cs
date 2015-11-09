﻿namespace LearningBasic
{
    using System;
    using LearningBasic.RunTime;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class EvaluateResultTests : BaseTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void EvaluateResult_WithNullMessage_ThrowsArgumentNullException()
        {
            var result = new EvaluateResult(null);
        }

        [TestMethod]
        public void EvaluateResult_WithMessage_StoresMessage()
        {
            var result = new EvaluateResult("message");

            Assert.AreEqual("message", result.Message);
        }

        [TestMethod]
        public void EvaluateResult_WithMessage_IsNotNone()
        {
            var result = new EvaluateResult("message");

            Assert.IsTrue(result != EvaluateResult.None);
        }

        [TestMethod]
        public void EvaluateResult_WithFormat_StoresFormattedMessage()
        {
            var result = new EvaluateResult("{0}", "format");

            Assert.AreEqual("format", result.Message);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Message_OfEmptyEvaluateResult_ThrowsInvalidOperationException()
        {
            var message = EvaluateResult.None.Message;
        }

        [TestMethod]
        public void Equals_WithSameMessage_ReturnsTrue()
        {
            var expected = new EvaluateResult("avoid " + "interning");
            var actual = new EvaluateResult("avoid" + " interning");

            var condition = expected.Equals(actual);

            Assert.IsTrue(condition);
        }

        [TestMethod]
        public void Equals_WithNull_ReturnsFalse()
        {
            var value = new EvaluateResult("");

            var condition = value.Equals(null);

            Assert.IsFalse(condition);
        }
    }
}