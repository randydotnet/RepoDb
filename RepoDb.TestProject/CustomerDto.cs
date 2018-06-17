﻿using RepoDb;
using RepoDb.Attributes;

namespace RepoDb.TestProject
{
    [Map("Customer")]
    public class CustomerDto : DataEntity
    {
        //[Primary]
        public int Id { get; set; }
        //[Ignore(Enumerations.Command.Update | Enumerations.Command.InlineUpdate)]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
    }
}
