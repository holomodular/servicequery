﻿namespace ServiceQuery.Xunit.Integration
{
    [Collection("Cosmos")]
    public class CosmosComparisonIsLessThanTestsAsync : ComparisonIsLessThanTestsAsyncEfc<TestClass>
    {
        public CosmosComparisonIsLessThanTestsAsync()
        {
            ValidateUInt128 = false;
            ValidateTimeOnly = false;
        }

        public override IQueryable<TestClass> GetTestList()
        {
            return CosmosHelper.GetTestList();
        }

        public override IQueryable<TestClass> GetTestNullCopyList()
        {
            return CosmosHelper.GetTestNullCopyList();
        }

        public override async Task<IQueryable<TestClass>> GetTestListAsync()
        {
            return await CosmosHelper.GetTestListAsync();
        }

        public override async Task<IQueryable<TestClass>> GetTestNullCopyListAsync()
        {
            return await CosmosHelper.GetTestNullCopyListAsync();
        }
    }
}