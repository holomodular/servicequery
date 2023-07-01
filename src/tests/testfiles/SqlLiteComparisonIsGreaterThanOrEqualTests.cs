﻿namespace ServiceQuery.Xunit
{
    public class SqlLiteComparisonIsGreaterThanOrEqualTests : ComparisonIsGreaterThanOrEqualTests<TestClass>
    {
        public SqlLiteComparisonIsGreaterThanOrEqualTests()
        {
            ValidateDateTimeOffset = false;
            ValidateTimeSpan = false;
            ValidateUInt128 = false;
            ValidateUInt64 = false;
        }

        public override IQueryable<TestClass> GetTestList()
        {
            return SqlLiteHelper.GetTestList();
        }
    }
}