using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using PackageA;

namespace PackageB
{
    public class ClassOfPackageB
    {
        public string GetName()
        {
            return "PackageB";
        }

        public string GetVersion()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var fileVersionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);
            string productVersion = fileVersionInfo.ProductVersion;
            return productVersion;
        }

        public string GetSummary()
        {            
            return $"{GetName()} v. {GetVersion()} {Environment.NewLine}{GetInformationAboutUsedPackages()}";
        }

        private static string GetInformationAboutUsedPackages()
        {
            var classOfPackageA = new ClassOfPackageA();
            var packageInfo = classOfPackageA.GetSummary();
            return $"Used package: {packageInfo}";
        }
    }
}
