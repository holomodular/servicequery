﻿namespace ServiceQuery.Xunit
{
    public class AggregateCountTests : AggregateCountTests<TestClass>
    {
        public override IQueryable<TestClass> GetTestList()
        {
            return new TestClass().GetDefaultList().AsQueryable();
        }
    }

    public abstract class AggregateCountTests<T> : BaseTest<T> where T : class
    {
        [Fact]
        public async Task CountStandardTest()
        {
            var sourceQueryable = GetTestList();
            IServiceQuery serviceQuery;
            double? result;

            serviceQuery = ServiceQueryBuilder.New().Count().Build();
            result = serviceQuery.ExecuteAggregate<T>(sourceQueryable);
            Assert.True(result == 4);
            result = await serviceQuery.ExecuteAggregateAsync<T>(sourceQueryable);
            Assert.True(result == 4);

            serviceQuery = ServiceQueryBuilder.New()
                .IsEqual(nameof(TestClass.IntVal), "1")
                .Count().Build();
            result = serviceQuery.ExecuteAggregate<T>(sourceQueryable);
            Assert.True(result == 1);
        }

        [Fact]
        public async Task CountRequestTest()
        {
            var sourceQueryable = GetTestList();
            IServiceQueryRequest serviceQuery;
            double? result;

            serviceQuery = ServiceQueryRequestBuilder.New().Count().Build();
            result = serviceQuery.GetServiceQuery().ExecuteAggregate<T>(sourceQueryable);
            Assert.True(result == 4);
            result = await serviceQuery.GetServiceQuery().ExecuteAggregateAsync<T>(sourceQueryable);
            Assert.True(result == 4);

            serviceQuery = ServiceQueryRequestBuilder.New()
                .IsEqual(nameof(TestClass.IntVal), "1")
                .Count().Build();
            result = serviceQuery.GetServiceQuery().ExecuteAggregate<T>(sourceQueryable);
            Assert.True(result == 1);
        }
    }
}