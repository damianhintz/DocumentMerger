using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DocumentMergerDomena;
using Shouldly;

namespace DocumentMergerTesty
{
    [TestClass]
    public class RepoTest
    {
        [TestMethod]
        public void DocumentRepo_ShouldBeEmpty()
        {
            var repo = new DocumentRepo();
            repo.Pliki.ShouldBeEmpty();
        }
    }
}
