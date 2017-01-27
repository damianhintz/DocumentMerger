using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DocumentMergerDomena;
using Shouldly;

namespace DocumentMergerTesty
{
    [TestClass]
    public class ClassifierTest
    {
        [TestMethod]
        public void DocumentsClassifier_ShouldClassifyFilesByFolder()
        {
            var repo = new DocumentRepo();
            var reader = new DocumentsReader(repo);
            reader.Wczytaj("Samples");
            repo.Pliki.Count().ShouldBe(8);
            var klasyfikator = new DocumentsClassifier();
            var grupy = klasyfikator.ClassifyDocuments(repo.Pliki).ToList();
            grupy.Count.ShouldBe(4);
            var grupa1 = grupy.Single(g => g.Folder.Equals(@"Samples\Folder1"));
            grupa1.Pliki.Count().ShouldBe(1);
            var grupa2 = grupy.Single(g => g.Nazwa.Equals("Folder2"));
            grupa2.Pliki.Count().ShouldBe(2);
            var grupa3 = grupy.Single(g => g.Folder.EndsWith("Folder3"));
            grupa3.Pliki.Count().ShouldBe(3);
            var grupa4 = grupy.Single(g => g.Folder.EndsWith("Folder4"));
            grupa4.Pliki.Count().ShouldBe(2);
        }
    }
}
