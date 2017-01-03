using NUnit.Framework;

namespace PackageB.Test.Unit
{

    [TestFixture]
    public class ProgrammTest
    {
        [Test]
        public void GetName_NameIsNotEmpty()
        {
            var subject = new ClassOfPackageB();
            Assert.IsNotNullOrEmpty(subject.GetName());
        }
    }
}
