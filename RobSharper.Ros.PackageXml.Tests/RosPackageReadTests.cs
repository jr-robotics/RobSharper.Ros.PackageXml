using System.Linq;
using FluentAssertions;
using Xunit;

namespace RobSharper.Ros.PackageXml.Tests
{
    public class RosPackageReadTests
    {
        [Theory]
        [InlineData("PackageXmlFiles/v1.package.xml", "control_msgs")]
        [InlineData("PackageXmlFiles/v2.package.xml", "rclcpp_tutorials")]
        public void CanReadNameFromPackageXml(string packageXmlFile, string expectedName)
        {
            var package = PackageXmlReader.ReadPackageXml(packageXmlFile);

            package.Should().NotBeNull();
            package.Name.Should().Be(expectedName);
        }
        
        [Theory]
        [InlineData("PackageXmlFiles/v1.package.xml", "1.5.0")]
        [InlineData("PackageXmlFiles/v2.package.xml", "0.0.0")]
        public void CanReadVersionFromPackageXml(string packageXmlFile, string expectedVersion)
        {
            var package = PackageXmlReader.ReadPackageXml(packageXmlFile);

            package.Should().NotBeNull();
            package.Version.Should().Be(expectedVersion);
        }
        
        [Theory]
        [InlineData("PackageXmlFiles/v1.package.xml", "control_msgs contains base messages and actions useful for")]
        [InlineData("PackageXmlFiles/v2.package.xml", "Package containing tutorials showing how to use the rclcpp API.")]
        [InlineData("PackageXmlFiles/common_msgs.package.xml", "common_msgs contains messages that are widely used by other ROS packages")]
        public void CanReadDescriptionFromPackageXml(string packageXmlFile, string expectedDescription)
        {
            var package = PackageXmlReader.ReadPackageXml(packageXmlFile);

            package.Should().NotBeNull();
            package.Description.Should().StartWith(expectedDescription);
        }

        [Fact]
        public void PackageCanHaveNoAuthors()
        {
            var package = PackageXmlReader.ReadPackageXml("PackageXmlFiles/v2.package.xml");

            package.Authors.Should().BeEmpty();
        }

        [Fact]
        public void PackageCanHaveAuthors()
        {
            var package = PackageXmlReader.ReadPackageXml("PackageXmlFiles/v1.package.xml");

            package.Authors.Count().Should().Be(1);
            package.Authors.First().Name.Should().Be("Stuart Glaser");
            package.Authors.First().Email.Should().Be("sglaser@willowgarage.com");
        }
        
        [Theory]
        [InlineData("PackageXmlFiles/v1.package.xml", "Bence Magyar", "bence.magyar.robotics@gmail.com")]
        [InlineData("PackageXmlFiles/v2.package.xml", "William Woodall", "william@osrfoundation.org")]
        [InlineData("PackageXmlFiles/common_msgs.package.xml", "Tully Foote", "tfoote@osrfoundation.org")]
        public void PackageHasAMaintainer(string packageXmlFile, string expectedName, string expectedEmail)
        {
            var package = PackageXmlReader.ReadPackageXml(packageXmlFile);

            package.Should().NotBeNull();
            package.Maintainers.Count().Should().Be(1);
            package.Maintainers.First().Name.Should().Be(expectedName);
            package.Maintainers.First().Email.Should().Be(expectedEmail);
        }

        [Theory]
        [InlineData("PackageXmlFiles/v1.package.xml", false)]
        [InlineData("PackageXmlFiles/common_msgs.package.xml", true)]
        public void PackageCanBeMetaPackage(string file, bool isMetaPackage)
        {
            var package = PackageXmlReader.ReadPackageXml(file);

            package.IsMetaPackage.Should().Be(isMetaPackage);
        }
        
        [Theory]
        [InlineData("PackageXmlFiles/v1.package.xml", "buildtool_package_dependency")]
        [InlineData("PackageXmlFiles/v1.package.xml", "build_package_dependency")]
        [InlineData("PackageXmlFiles/v1.package.xml", "run_package_dependency")]
        [InlineData("PackageXmlFiles/v2.package.xml", "example_interfaces")]
        [InlineData("PackageXmlFiles/v2.package.xml", "rosidl_default_generators")]
        [InlineData("PackageXmlFiles/v2.package.xml", "ament_cmake")]
        [InlineData("PackageXmlFiles/v2.package.xml", "launch")]
        public void PackageHasDependency(string packageXmlFile, string expectedDependency)
        {
            var package = PackageXmlReader.ReadPackageXml(packageXmlFile);

            package.PackageDependencies.Should().Contain(expectedDependency);
        }
        
        [Theory]
        [InlineData("PackageXmlFiles/v1.package.xml", "BSD")]
        [InlineData("PackageXmlFiles/v2.package.xml", "Apache License 2.0")]
        [InlineData("PackageXmlFiles/common_msgs.package.xml", "BSD")]
        public void PackageHasLicense(string packageXmlFile, string expectedLicense)
        {
            var package = PackageXmlReader.ReadPackageXml(packageXmlFile);

            package.License.Should().Contain(expectedLicense);
        }
    }
}