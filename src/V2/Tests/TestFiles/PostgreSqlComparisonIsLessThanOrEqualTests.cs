﻿namespace ServiceQuery.Xunit.Integration
{
    [Collection("Postgres")]
    public class PostgreSqlComparisonIsLessThanOrEqualTests : ComparisonIsLessThanOrEqualTests<TestClass>
    {
        public PostgreSqlComparisonIsLessThanOrEqualTests()
        {
            ValidateUInt128 = false;
        }

        public override IQueryable<TestClass> GetTestList()
        {
            return PostgreSqlHelper.GetTestList();
        }

        public override IQueryable<TestClass> GetTestNullCopyList()
        {
            return PostgreSqlHelper.GetTestNullCopyList();
        }
    }
}