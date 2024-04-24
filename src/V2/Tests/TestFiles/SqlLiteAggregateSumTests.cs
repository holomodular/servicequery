﻿namespace ServiceQuery.Xunit.Integration
{
    [Collection("Sqlite")]
    public class SqlLiteAggregateSumTests : AggregateSumTests<TestClass>
    {
        public SqlLiteAggregateSumTests()
        {
            ValidateDateTimeOffset = false;
            ValidateTimeSpan = false;
            ValidateUInt128 = false;
            ValidateUInt64 = false;
            ValidateDecimal = false;
        }

        public override IQueryable<TestClass> GetTestList()
        {
            return SqlLiteHelper.GetTestList();
        }

        public override IQueryable<TestClass> GetTestNullCopyList()
        {
            return SqlLiteHelper.GetTestNullCopyList();
        }
    }
}