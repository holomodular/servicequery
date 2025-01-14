﻿using Microsoft.EntityFrameworkCore;

namespace ServiceQuery.Xunit
{
    public class SqlServerInMemHelper
    {
        public static IQueryable<TestClass> GetTestList()
        {
            var builder = new DbContextOptionsBuilder<SqlServerInMemTestContext>();
            builder.UseInMemoryDatabase(Guid.NewGuid().ToString());
            var _context = new SqlServerInMemTestContext(builder.Options);
            var list = new TestClass().GetDefaultList();
            foreach (var item in list)
                _context.TestClasses.Add(item);
            _context.SaveChanges();
            return _context.TestClasses.AsQueryable<TestClass>();
        }

        public static IQueryable<TestClass> GetTestNullCopyList()
        {
            var builder = new DbContextOptionsBuilder<SqlServerInMemTestContext>();
            builder.UseInMemoryDatabase(Guid.NewGuid().ToString());
            var _context = new SqlServerInMemTestContext(builder.Options);
            var list = new TestNullCopyClass().GetDefaultList();
            foreach (var item in list)
            {
                var temp = (TestNullCopyClass)item;
                temp.CopyToNullVals();
                _context.TestNullCopyClasses.Add(temp);
            }
            _context.SaveChanges();
            return _context.TestNullCopyClasses.AsQueryable<TestClass>();
        }

        public static async Task<IQueryable<TestClass>> GetTestListAsync()
        {
            var builder = new DbContextOptionsBuilder<SqlServerInMemTestContext>();
            builder.UseInMemoryDatabase(Guid.NewGuid().ToString());
            var _context = new SqlServerInMemTestContext(builder.Options);
            var list = new TestClass().GetDefaultList();
            foreach (var item in list)
                await _context.TestClasses.AddAsync(item);
            await _context.SaveChangesAsync();
            return _context.TestClasses.AsQueryable<TestClass>();
        }

        public static async Task<IQueryable<TestClass>> GetTestNullCopyListAsync()
        {
            var builder = new DbContextOptionsBuilder<SqlServerInMemTestContext>();
            builder.UseInMemoryDatabase(Guid.NewGuid().ToString());
            var _context = new SqlServerInMemTestContext(builder.Options);
            var list = new TestNullCopyClass().GetDefaultList();
            foreach (var item in list)
            {
                var temp = (TestNullCopyClass)item;
                temp.CopyToNullVals();
                await _context.TestNullCopyClasses.AddAsync(temp);
            }
            await _context.SaveChangesAsync();
            return _context.TestNullCopyClasses.AsQueryable<TestClass>();
        }
    }
}