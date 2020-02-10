using System;
using System.Xml;
using System.Xml.Serialization;

namespace RobSharper.Ros.PackageXml
{
    public static class PackageXmlReader
    {
        public static int GetFormatVersion(string packageXmlFilePath)
        {
            if (packageXmlFilePath == null) throw new ArgumentNullException(nameof(packageXmlFilePath));
            var reader = new XmlTextReader(packageXmlFilePath);

            return GetFormatVersion(reader);
        }
        
        public static int GetFormatVersion(XmlTextReader packageXml)
        {
            var version = -1;
            while (packageXml.Read())
            {
                if (packageXml.Name.Equals("package", StringComparison.InvariantCultureIgnoreCase))
                {
                    if (packageXml.AttributeCount == 0)
                    {
                        version = 1;
                    }
                    else
                    {
                        var versionAttribute = packageXml.GetAttribute("format");
                        int.TryParse(versionAttribute, out version);
                    }
                    break;
                }
            }

            return version;
        }

        public static RosPackage ReadPackageXml(string filename)
        {
            var v = GetFormatVersion(filename);

            switch (v)
            {
                case 1:
                    return (RosPackage) ReadV1PackageXml(filename);
                case 2:
                    return (RosPackage) ReadV2PackageXml(filename);
                case 3:
                    return (RosPackage) ReadV3PackageXml(filename);
            }
            
            throw new NotSupportedException($"Package XML version {v} is not supported.");
        }

        public static V1.package ReadV1PackageXml(string filename)
        {
            if (filename == null) throw new ArgumentNullException(nameof(filename));
            var xmlReader = new XmlTextReader(filename);
            
            return ReadV1PackageXml(xmlReader);
        }

        private static V1.package ReadV1PackageXml(XmlTextReader xmlReader)
        {
            var serializer = new XmlSerializer(typeof(V1.package));
            var package = (V1.package) serializer.Deserialize(xmlReader);

            return package;
        }

        public static V2.package ReadV2PackageXml(string filename)
        {
            if (filename == null) throw new ArgumentNullException(nameof(filename));
            var xmlReader = new XmlTextReader(filename);
            
            return ReadV2PackageXml(xmlReader);
        }

        private static V2.package ReadV2PackageXml(XmlTextReader xmlReader)
        {
            var serializer = new XmlSerializer(typeof(V2.package));
            var package = (V2.package) serializer.Deserialize(xmlReader);

            return package;
        }

        public static V3.package ReadV3PackageXml(string filename)
        {
            if (filename == null) throw new ArgumentNullException(nameof(filename));
            var xmlReader = new XmlTextReader(filename);
            
            return ReadV3PackageXml(xmlReader);
        }

        private static V3.package ReadV3PackageXml(XmlTextReader xmlReader)
        {
            var serializer = new XmlSerializer(typeof(V3.package));
            var package = (V3.package) serializer.Deserialize(xmlReader);

            return package;
        }
    }
}