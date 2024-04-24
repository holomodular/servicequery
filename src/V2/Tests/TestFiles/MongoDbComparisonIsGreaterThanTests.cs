﻿namespace ServiceQuery.Xunit.Integration
{
    [Collection("MongoDb")]
    public class MongoDbComparisonIsGreaterThanTests : ComparisonIsGreaterThanTests<MongoDbTestClass>
    {
        public MongoDbComparisonIsGreaterThanTests()
        {
            ValidateUInt128 = false;
        }

        public override IQueryable<MongoDbTestClass> GetTestList()
        {
            return MongoDbHelper.GetTestList();
        }

        public override IQueryable<MongoDbTestClass> GetTestNullCopyList()
        {
            return MongoDbHelper.GetTestNullCopyList();
        }
    }
}