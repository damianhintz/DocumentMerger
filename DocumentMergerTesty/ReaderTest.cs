using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DocumentMergerDomena;
using Shouldly;

namespace DocumentMergerTesty
{
    [TestClass]
    public class ReaderTest
    {
        [TestMethod]
        public void DocumentsReader_ShouldHaveDefaults()
        {
            var repo = new DocumentRepo();
            var reader = new DocumentsReader(repo);
            reader.Repo.ShouldBeSameAs(repo);
        }
    }
}
