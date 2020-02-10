namespace RobSharper.Ros.PackageXml
{
    public class Contact
    {
        public string Email { get; }
        public string Name { get; }
        
        public Contact(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public override string ToString()
        {
            if (string.IsNullOrEmpty(Email))
                return Name;

            if (string.IsNullOrEmpty(Name))
                return Email;
            
            return $"{Name} ({Email})";
        }

        protected bool Equals(Contact other)
        {
            return Email == other.Email && Name == other.Name;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Contact) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((Email != null ? Email.GetHashCode() : 0) * 397) ^ (Name != null ? Name.GetHashCode() : 0);
            }
        }
    }
}