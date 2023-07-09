namespace ModelProject
{
    public class Company
    {
        private Guid _id;
        private string? _name;

        public Guid Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
}