using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

using NSubstitute;

using Renamer.Engine.Entities;
using Renamer.Engine.NamingPatterns;
using Renamer.Engine.PhysicalRenamer;

namespace Renamer.Engine.UnitTest.NamingPatterns
{
    [TestClass]
    public class RemoveTildesNamingTests
    {
        private readonly string basePath = @"C:\SomeDir\AnotherDir\";

        [TestMethod]
        public async Task Execute_WithFileExtension()
        {
            var currentName = basePath + "Ábc déf.ghí";
            var expectedName = basePath + "Abc def.ghi";

            // arrange
            var renamer = Substitute.For<IRenamer>();
            renamer.Rename(default, default, default).ReturnsForAnyArgs(Task.FromResult<bool>(true));
            var renameSettings = RenameSettingsFactory.RemoveTildes(true);

            // act
            var naming = new RemoveTildesNaming(renamer, renameSettings);
            var namingResult = await naming.Execute(ObjectType.File, currentName);

            // assert
            Assert.IsTrue(namingResult.Success);
            Assert.AreEqual(ObjectType.File, namingResult.ObjectType);
            Assert.AreEqual(currentName, namingResult.OldName);
            Assert.AreEqual(expectedName, namingResult.NewName);
        }

        [TestMethod]
        public async Task Execute_WithoutFileExtension()
        {
            var currentName = basePath + "Ábc déf.ghí";
            var expectedName = basePath + "Abc def.ghí";

            // arrange
            var renamer = Substitute.For<IRenamer>();
            renamer.Rename(default, default, default).ReturnsForAnyArgs(Task.FromResult<bool>(true));
            var renameSettings = RenameSettingsFactory.RemoveTildes(false);

            // act
            var naming = new RemoveTildesNaming(renamer, renameSettings);
            var namingResult = await naming.Execute(ObjectType.File, currentName);

            // assert
            Assert.IsTrue(namingResult.Success);
            Assert.AreEqual(ObjectType.File, namingResult.ObjectType);
            Assert.AreEqual(currentName, namingResult.OldName);
            Assert.AreEqual(expectedName, namingResult.NewName);
        }

        [TestMethod]
        public void Preview_WithFileExtension()
        {
            var currentName = basePath + "Ábc déf.ghí";
            var expectedName = basePath + "Abc def.ghi";

            // arrange
            var renamer = Substitute.For<IRenamer>();
            var renameSettings = RenameSettingsFactory.RemoveTildes(true);

            // act
            var naming = new RemoveTildesNaming(renamer, renameSettings);
            var namingResult = naming.Preview(ObjectType.File, currentName);

            // assert
            Assert.IsFalse(namingResult.Success);
            Assert.AreEqual(ObjectType.File, namingResult.ObjectType);
            Assert.AreEqual(currentName, namingResult.OldName);
            Assert.AreEqual(expectedName, namingResult.NewName);
        }

        [TestMethod]
        public void Preview_WithoutFileExtension()
        {
            var currentName = basePath + "Ábc déf.ghí";
            var expectedName = basePath + "Abc def.ghí";

            // arrange
            var renamer = Substitute.For<IRenamer>();
            var renameSettings = RenameSettingsFactory.RemoveTildes(false);

            // act
            var naming = new RemoveTildesNaming(renamer, renameSettings);
            var namingResult = naming.Preview(ObjectType.File, currentName);

            // assert
            Assert.IsFalse(namingResult.Success);
            Assert.AreEqual(ObjectType.File, namingResult.ObjectType);
            Assert.AreEqual(currentName, namingResult.OldName);
            Assert.AreEqual(expectedName, namingResult.NewName);
        }
    }
}
