using System;
using System.Collections.Generic;
using System.IO;
using B3.Data.Domain;
using B3.Data.Repository.Interfaces;
using NUnit.Framework;

namespace B3.Data.Repository.Test
{
    public class Product:IEntity
    {
        public Guid Id { get; set; }
    }

    public class TestRepository:IReadOnlyRepository<Product>, IWriteOnlyRepository<Product>
    {
        public Product GetById(Guid id)
        {
            return new Product();
        }

        public IEnumerable<Product> GetAll()
        {
            return new List<Product>();
        }

        Product IWriteOnlyRepository<Product>.Insert(Product item)
        {
            return item;
        }

        public Product Update(Product item)
        {
            throw new NotImplementedException();
        }

        public Product Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Product Delete(Product item)
        {
            throw new NotImplementedException();
        }
    }

    [TestFixture]
    public class RepositoryTest
    {
        [Test]
        public void UnitOfWork_StateUnderTest_ExpectedBehavior()
        {
            IWriteOnlyRepository<Product> d = new TestRepository();
            
            var response = d.Insert(null);

            Assert.That(response, Is.Not.Null);
        }
    }
}
