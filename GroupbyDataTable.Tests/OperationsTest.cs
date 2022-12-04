// <copyright file="OperationsTest.cs">Copyright ©  2021</copyright>
using System;
using System.Data;
using GroupbyDataTable.Classes;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GroupbyDataTable.Classes.Tests
{
    /// <summary>This class contains parameterized unit tests for Operations</summary>
    [PexClass(typeof(Operations))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class OperationsTest
    {
        /// <summary>Test stub for Mocked()</summary>
        [PexMethod]
        public DataTable MockedTest()
        {
            DataTable result = Operations.Mocked();
            return result;
            // TODO: add assertions to method OperationsTest.MockedTest()
        }

        /// <summary>Test stub for GroupData(DataTable)</summary>
        [PexMethod]
        public DataTable GroupDataTest(DataTable dt)
        {
            DataTable result = Operations.GroupData(dt);
            return result;
            // TODO: add assertions to method OperationsTest.GroupDataTest(DataTable)
        }
    }
}
