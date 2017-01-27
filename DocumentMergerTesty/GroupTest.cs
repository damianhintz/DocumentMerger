using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DocumentMergerDomena;
using Shouldly;

namespace DocumentMergerTesty
{
    [TestClass]
    public class GroupTest
    {
        [TestMethod]
        public void DocumentGroup_ShouldNotBeMerged()
        {
            var grupa = new DocumentGroup { Folder = @"Samples\Folder" };
            grupa.Folder.ShouldBe(@"Samples\Folder");
            grupa.Nazwa.ShouldBe("Folder");
            grupa.Plik.ShouldBe(@"Samples\Folder\Folder.pdf");
            grupa.Pliki.ShouldBeEmpty();
            grupa.IsMerged.ShouldBeFalse();
        }

        [TestMethod]
        public void DocumentGroup_ShouldBeMerged()
        {
            var grupa = new DocumentGroup { Folder = @"Samples\Folder" };
            grupa.DodajPlik(@"Samples\Folder\Folder.pdf");
            grupa.Folder.ShouldBe(@"Samples\Folder");
            grupa.Nazwa.ShouldBe("Folder");
            grupa.Plik.ShouldBe(@"Samples\Folder\Folder.pdf");
            grupa.Pliki.ShouldHaveSingleItem();
            grupa.IsMerged.ShouldBeTrue();
        }
    }
}
