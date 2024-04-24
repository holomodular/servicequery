﻿namespace ServiceQuery.Xunit.Integration
{
    [Collection("SqlServer")]
    public class SqlServerComparisonIsGreaterThanTests : ComparisonIsGreaterThanTests<TestClass>
    {
        public SqlServerComparisonIsGreaterThanTests()
        {
            ValidateUInt128 = false;
        }

        public override IQueryable<TestClass> GetTestList()
        {
            return SqlServerHelper.GetTestList();
        }

        public override IQueryable<TestClass> GetTestNullCopyList()
        {
            return SqlServerHelper.GetTestNullCopyList();
        }
    }
}