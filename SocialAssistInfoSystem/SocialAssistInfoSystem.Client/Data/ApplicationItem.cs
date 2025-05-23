﻿using SocialAssistInfoSystem.Client.Data.Enum;
using SocialAssistInfoSystem.Client.Data.ViewModel;

namespace SocialAssistInfoSystem.Client.Data
{
    public class ApplicationViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public DateTime? DOB { get; set; }

        public Gender Gender { get; set; }

        public MaritalStatus MaritalStatus { get; set; }

        public SchemeOption Scheme { get; set; }

        public int PassportNo { get; set; }

        public string PhoneNumber { get; set; }

        public string OtherScheme { get; set; }

        public AddressVM Address { get; set; }

    }
}
