# ROS Package XML for .NET
> Handle ROS package.xml files with ease

ROS Package XML allows you to parse ROS package.xml files.
It supports package XML versions 1, 2 and 3.

## Installation

ROS Package XML for .Net is available as [NuGet Package](https://www.nuget.org/packages/RobSharper.Ros.PackageXml/).

[![](https://img.shields.io/nuget/v/RobSharper.Ros.PackageXml.svg?logo=nuget)](https://www.nuget.org/packages/RobSharper.Ros.PackageXml/)


```
dotnet add package RobSharper.Ros.PackageXml
``` 

### Supported .NET versions
 
* **.NET Standard 2.0**
    * .NET Core 2.0 or later
    * .NET Framework 4.6.1 or later
    * Mono 5.4 or later
    * Xamarin.iOS 10.14 or later
    * Xamarin.Mac 3.8 or later
    * Xamarin.Android 8.0 or later
    * Universal Windows Platform 10.0.16299 or later

### Dependencies

* none

## Usage

```CSharp
var package = PackageXmlReader.ReadPackageXml(filename);
```

Or if you want to work with the inner xml elements:

```CSharp
var version = PackageXmlReader.GetFormatVersion(filename);

switch (version)
{
    case 1:
        var v1Package = PackageXmlReader.ReadV1PackageXml(filename);
        break;
    case 2:
        var v2Package = PackageXmlReader.ReadV2PackageXml(filename);
        break;
    case 3:
        var v3Package = PackageXmlReader.ReadV3PackageXml(filename);
        break;
    default:
        throw new NotSupportedException();
}
```

## Contributing
### How to update data contracts

Data files are generated from ROS Package XSD Files using Microsoft xsd.exe (https://docs.microsoft.com/en-us/dotnet/standard/serialization/xml-schema-definition-tool-xsd-exe).
ROS XSD Files are located in the VX (e.g. V2) folder. 

Use ```build.ps1``` powershell script to generate  a new version of the package.
The script takes the path to xsd.exe as only argument.

Generating code with xsd.exe requires you to use Windows!

**Example - How to generate package.xml V2 code in powerhsell:**

```powershell
.\build.ps1 "C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.7.2 Tools\xsd.exe"
``` 

### Resources

- http://wiki.ros.org/catkin/package.xml
- http://download.ros.org/schema/
- http://download.ros.org/schema/package_format1.xsd
- http://download.ros.org/schema/package_format2.xsd
- http://download.ros.org/schema/package_format3.xsd


## License

This project is licensed under the [BSD 3-clause](LICENSE) license. [Learn more](https://choosealicense.com/licenses/bsd-3-clause/)