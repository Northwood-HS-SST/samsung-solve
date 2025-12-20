using System;
using System.Collections.Generic;
using System.Text;

namespace app_shared.Models
{
    internal class User
    {
        public readonly UInt32 UserId;


        public string FirstName { get; internal set; }
        public string LastName { get; internal set; }
        public UInt16 ZipCode { get; internal set; }
        public DateOnly Birthdate { get; internal set; }


    }
}
