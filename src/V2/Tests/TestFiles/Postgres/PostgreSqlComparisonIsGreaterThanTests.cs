﻿namespace ServiceQuery.Xunit.Integration
{
    [Collection("Postgres")]
    public class PostgreSqlComparisonIsGreaterThanTests : ComparisonIsGreaterThanTests<TestClass>
    {
        public PostgreSqlComparisonIsGreaterThanTests()
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

        public override async Task<IQueryable<TestClass>> GetTestListAsync()
        {
            return await PostgreSqlHelper.GetTestListAsync();
        }

        public override async Task<IQueryable<TestClass>> GetTestNullCopyListAsync()
        {
            return await PostgreSqlHelper.GetTestNullCopyListAsync();
        }
    }

    [Collection("Postgres")]
    public class PostgreSqlComparisonIsGreaterThanTestsAsync : ComparisonIsGreaterThanTestsAsyncEfc<TestClass>
    {
        public PostgreSqlComparisonIsGreaterThanTestsAsync()
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

        public override async Task<IQueryable<TestClass>> GetTestListAsync()
        {
            return await PostgreSqlHelper.GetTestListAsync();
        }

        public override async Task<IQueryable<TestClass>> GetTestNullCopyListAsync()
        {
            return await PostgreSqlHelper.GetTestNullCopyListAsync();
        }
    }
}