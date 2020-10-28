﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Profile.Domain.CreateProfileWorkflow
{
    public struct CreateProfileCmd
    {
        
        public string FirstName { get; private set; }
        public string MiddleName { get; set; }
       
        public string LastName { get; private set; }
       
        public string EmailAddress { get; private set; }

        public CreateProfileCmd(string firstName, string middleName, string lastName, string emailAddress)
        {
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            MiddleName = middleName;
        }
    }
}