﻿namespace ServiceQuery.Xunit
{
    [Collection("Postgres")]
    public class PostgreSqlComparisonStartsWithTests : ComparisonStartsWithTests<TestClass>
    {
        public PostgreSqlComparisonStartsWithTests()
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