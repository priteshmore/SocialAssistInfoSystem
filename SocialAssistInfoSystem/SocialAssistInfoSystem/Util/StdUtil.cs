using SocialAssistInfoSystem.Client.Data;
using SocialAssistInfoSystem.Data.DBEntity;
using SocialAssistInfoSystem.Data.Dto;
using System.Reflection;

namespace SocialAssistInfoSystem.Util
{
    public static class StdUtil
    {
        public static List<Application> ConvertList(List<ApplicationDto> Items)
        {
            List<Application> lstResult = new List<Application>();

            foreach (var item in Items)
            {
                Application obj = Convert(item);
                lstResult.Add(obj);
            }

            return lstResult;
        }

        public static Application Convert(ApplicationDto objApplicationDto)
        {
            Application objResult = new Application();

            objResult.Id = objApplicationDto.Id;
            objResult.Status = objApplicationDto.Status;

            objResult.Profile = new Profile();
            objResult.Profile.Id = objApplicationDto.Profile.Id;
            objResult.Profile.FirstName = objApplicationDto.Profile.FirstName;
            objResult.Profile.MiddleName = objApplicationDto.Profile.MiddleName;
            objResult.Profile.LastName = objApplicationDto.Profile.LastName;
            objResult.Profile.MaritalStatus = objApplicationDto.Profile.MaritalStatus;
            objResult.Profile.Gender = objApplicationDto.Profile.Gender;
            objResult.Profile.DOB = objApplicationDto.Profile.DOB;
            objResult.Profile.PassportNo = objApplicationDto.Profile.PassportNo;
            objResult.Profile.PhoneNumber = objApplicationDto.Profile.PhoneNumber;


            objResult.Scheme = new Scheme();
            objResult.Scheme.Id = objApplicationDto.Scheme.Id;
            objResult.Scheme.SchemeName = objApplicationDto.Scheme.SchemeName.ToString();
            objResult.Scheme.OtherScheme = objApplicationDto.Scheme.OtherScheme;

            objResult.Address = new Address();
            objResult.Address.Id = objApplicationDto.Address.Id;
            objResult.Address.Country = objApplicationDto.Address.Country;
            objResult.Address.Subcountry = objApplicationDto.Address.Subcountry;
            objResult.Address.Location = objApplicationDto.Address.Location;
            objResult.Address.Subcountry = objApplicationDto.Address.Subcountry;
            objResult.Address.Village = objApplicationDto.Address.Village;


            return objResult;

        }


        public static Application UpdateApplicationEntity(ApplicationDto objSource, Application objTarget)
        {
            objTarget.Status = objSource.Status;
            objTarget.Profile.FirstName = objSource.Profile.FirstName;
            objTarget.Profile.MiddleName = objSource.Profile.MiddleName;
            objTarget.Profile.LastName = objSource.Profile.LastName;
            objTarget.Profile.MaritalStatus = objSource.Profile.MaritalStatus;
            objTarget.Profile.Gender = objSource.Profile.Gender;
            objTarget.Profile.DOB = objSource.Profile.DOB;
            objTarget.Profile.PassportNo = objSource.Profile.PassportNo;
            objTarget.Profile.PhoneNumber = objSource.Profile.PhoneNumber;

            objTarget.Scheme.SchemeName = objSource.Scheme.SchemeName.ToString();
            objTarget.Scheme.OtherScheme = objSource.Scheme.OtherScheme;

            objTarget.Address.Country = objSource.Address.Country;
            objTarget.Address.Subcountry = objSource.Address.Subcountry;
            objTarget.Address.Location = objSource.Address.Location;
            objTarget.Address.Subcountry = objSource.Address.Subcountry;
            objTarget.Address.Village = objSource.Address.Village;


            return objTarget;

        }

    }
}
