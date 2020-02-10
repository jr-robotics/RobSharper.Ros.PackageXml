namespace RobSharper.Ros.PackageXml
{
    public class PackageUrl
    {
        public PackageUrlType Type { get; }
        public string Url { get; }
        
        public PackageUrl(string url, PackageUrlType type)
        {
            Type = type;
            Url = url;
        }

        public override string ToString()
        {
            return Url;
        }

        protected bool Equals(PackageUrl other)
        {
            return Type == other.Type && Url == other.Url;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((PackageUrl) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((int) Type * 397) ^ (Url != null ? Url.GetHashCode() : 0);
            }
        }

        public static PackageUrl Create(string url, V1.UrlTypeEnum urlType)
        {
            var mappedType = PackageUrlType.Unknown;

            switch (urlType)
            {
                case V1.UrlTypeEnum.bugtracker:
                    mappedType = PackageUrlType.Bugtracker;
                    break;
                case V1.UrlTypeEnum.website:
                    mappedType = PackageUrlType.Website;
                    break;
                case V1.UrlTypeEnum.repository:
                    mappedType = PackageUrlType.Repository;
                    break;
            }

            return new PackageUrl(url, mappedType);
        }

        public static PackageUrl Create(string url, V2.UrlTypeEnum urlType)
        {
            var mappedType = PackageUrlType.Unknown;

            switch (urlType)
            {
                case V2.UrlTypeEnum.bugtracker:
                    mappedType = PackageUrlType.Bugtracker;
                    break;
                case V2.UrlTypeEnum.website:
                    mappedType = PackageUrlType.Website;
                    break;
                case V2.UrlTypeEnum.repository:
                    mappedType = PackageUrlType.Repository;
                    break;
            }

            return new PackageUrl(url, mappedType);
        }

        public static PackageUrl Create(string url, V3.UrlTypeEnum urlType)
        {
            var mappedType = PackageUrlType.Unknown;

            switch (urlType)
            {
                case V3.UrlTypeEnum.bugtracker:
                    mappedType = PackageUrlType.Bugtracker;
                    break;
                case V3.UrlTypeEnum.website:
                    mappedType = PackageUrlType.Website;
                    break;
                case V3.UrlTypeEnum.repository:
                    mappedType = PackageUrlType.Repository;
                    break;
            }

            return new PackageUrl(url, mappedType);
        }
    }
}