using System;
using System.Collections.Generic;
using System.Linq;

namespace RobSharper.Ros.PackageXml
{
    public class RosPackage
    {
        public string Name { get; private set; }
        
        public string Version { get; private set; }
        
        public string Description { get; private set; }
        
        public IEnumerable<Contact> Maintainers { get; private set; }
        
        public IEnumerable<Contact> Authors { get; private set; }
        
        public IEnumerable<PackageUrl> Urls { get; private set; }
        
        public IEnumerable<string> PackageDependencies { get; private set; }
        
        public IEnumerable<string> License { get; private set; }
        
        public bool IsMetaPackage { get; private set; }

        public int PackageXmlVersion { get; private set; }
        
        private RosPackage()
        {
            
        }
        
        public RosPackage(string name, string version, string description,
            IEnumerable<string> license,
            IEnumerable<Contact> maintainers, IEnumerable<Contact> authors = null,
            IEnumerable<PackageUrl> urls = null, IEnumerable<string> packageDependencies = null,
            bool isMetaPackage = default, int packageXmlVersion = default)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Version = version ?? throw new ArgumentNullException(nameof(version));
            Description = description ?? throw new ArgumentNullException(nameof(description));
            License = license ?? throw new ArgumentNullException(nameof(license));
            Maintainers = maintainers ?? throw new ArgumentNullException(nameof(maintainers));
            Authors = authors ?? Enumerable.Empty<Contact>();
            Urls = urls ?? Enumerable.Empty<PackageUrl>();
            PackageDependencies = packageDependencies ?? Enumerable.Empty<string>();
            IsMetaPackage = isMetaPackage;
            PackageXmlVersion = packageXmlVersion;
        }

        public static explicit operator RosPackage(V1.package package)
        {
            return new RosPackage
            {
                PackageXmlVersion = 1,
                Name = package.name,
                Version = package.version,
                Description = FormatDescription(string.Concat(package.description.Any.Select(x => x.OuterXml))),
                License = package.license?.ToList() ?? Enumerable.Empty<string>(),
                Authors = package.author?
                    .Select(a => new Contact(a.Value, a.email))
                    .ToList() ?? Enumerable.Empty<Contact>(),
                Maintainers = package.maintainer?
                    .Select(m => new Contact(m.Value, m.email))
                    .ToList() ?? Enumerable.Empty<Contact>(),
                Urls = package.url?
                    .Select(u => PackageUrl.Create(u.Value, u.type))
                    .ToList() ?? Enumerable.Empty<PackageUrl>(),
                PackageDependencies = package.Items?
                    .Select(x => x.Value)
                    .Where(x => x != null)
                    .ToList() ?? Enumerable.Empty<string>(),
                IsMetaPackage = package.export?.Any != null && 
                                package.export.Any.Any(x => "metapackage".Equals(x.Name, StringComparison.InvariantCultureIgnoreCase))
            };
        }

        public static explicit operator RosPackage(V2.package package)
        {
            return new RosPackage
            {
                PackageXmlVersion = 2,
                Name = package.name,
                Version = package.version,
                Description = FormatDescription(string.Concat(package.description.Any.Select(x => x.OuterXml))),
                License = package.license?.ToList() ?? Enumerable.Empty<string>(),
                Authors = package.author?
                    .Select(a => new Contact(a.Value, a.email))
                    .ToList() ?? Enumerable.Empty<Contact>(),
                Maintainers = package.maintainer?
                    .Select(m => new Contact(m.Value, m.email))
                    .ToList() ?? Enumerable.Empty<Contact>(),
                Urls = package.url?
                    .Select(u => PackageUrl.Create(u.Value, u.type))
                    .ToList() ?? Enumerable.Empty<PackageUrl>(),
                PackageDependencies = package.Items?
                    .Select(x => x.Value)
                    .Where(x => x != null)
                    .ToList() ?? Enumerable.Empty<string>(),
                IsMetaPackage = package.export?.Any != null && 
                                package.export.Any.Any(x => "metapackage".Equals(x.Name, StringComparison.InvariantCultureIgnoreCase))
            };
        }
        
        public static explicit operator RosPackage(V3.package package)
        {
            return new RosPackage
            {
                PackageXmlVersion = 3,
                Name = package.name,
                Version = package.version,
                Description = FormatDescription(string.Concat(package.description.Any.Select(x => x.OuterXml))),
                License = package.license?
                    .Select(l => l.Value)
                    .Where(l => l != null)
                    .ToList() ?? Enumerable.Empty<string>(),
                Authors = package.author?
                    .Select(a => new Contact(a.Value, a.email))
                    .ToList() ?? Enumerable.Empty<Contact>(),
                Maintainers = package.maintainer?
                    .Select(m => new Contact(m.Value, m.email))
                    .ToList() ?? Enumerable.Empty<Contact>(),
                Urls = package.url?
                    .Select(u => PackageUrl.Create(u.Value, u.type))
                    .ToList() ?? Enumerable.Empty<PackageUrl>(),
                PackageDependencies = package.Items?
                    .Select(x => x.Value)
                    .Where(x => x != null)
                    .ToList() ?? Enumerable.Empty<string>(),
                IsMetaPackage = package.export?.Any != null && 
                                package.export.Any.Any(x => "metapackage".Equals(x.Name, StringComparison.InvariantCultureIgnoreCase))
            };
        }

        private static string FormatDescription(string content)
        {
            if (content == null)
                return null;
            
            return content.Trim();
        }
    }
}