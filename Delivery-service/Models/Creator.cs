using System;

namespace Models
{
    public class Creator
    {
        public Creator(string _name)
        {
            Name = _name;
        }
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string[] PhoneNumbers { get; set; }
        public string Address { get; set; }

        void Create() { }
        void Delete() { }
    }
}
