using SocialAssistInfoSystem.Client.Data.Dto;
using SocialAssistInfoSystem.Client.Data.Enum;
using SocialAssistInfoSystem.Client.Data.ViewModel;
using System.Collections.ObjectModel;
using System.Reflection;

namespace SocialAssistInfoSystem.Client.Util
{
    public static class Extensions
    {
        public static ObservableCollection<T> ToObservableCollection<T>(this IEnumerable<T> source)
            => new ObservableCollection<T>(source);



    //    public static void CopyProperties(object source, object target)
    //    {
    //        // Get the type of the source and target objects
    //        var sourceType = source.GetType();
    //        var targetType = target.GetType();

    //        // Get all the properties of the source and target objects
    //        var sourceProperties = sourceType.GetProperties(BindingFlags.Public | BindingFlags.Instance);
    //        var targetProperties = targetType.GetProperties(BindingFlags.Public | BindingFlags.Instance);

    //        foreach (var sourceProp in sourceProperties)
    //        {
    //            // Find the corresponding target property
    //            var targetProp = targetType.GetProperty(sourceProp.Name);

    //            // If the target property exists and is writable
    //            if (targetProp != null && targetProp.CanWrite)
    //            {
    //                // Check if the source and target property types are compatible
    //                if (targetProp.PropertyType.IsAssignableFrom(sourceProp.PropertyType))
    //                {
    //                    // Set the value of the target property from the source property
    //                    targetProp.SetValue(target, sourceProp.GetValue(source));
    //                }
    //            }
    //        }
    //    }

    //    public static List<TTarget> CopyListProperties<TSource, TTarget>(List<TSource> sourceList)
    //where TTarget : new()
    //    {
    //        if (sourceList == null)
    //            throw new ArgumentNullException(nameof(sourceList));

    //        var resultList = new List<TTarget>();

    //        foreach (var sourceItem in sourceList)
    //        {
    //            TTarget targetItem = new TTarget();
    //            CopyProperties(sourceItem, targetItem);
    //            resultList.Add(targetItem);
    //        }

    //        return resultList;
    //    }

        public static List<ApplicationVM> ConvertList(List<ApplicationDto> Items)
        {
            List<ApplicationVM> lstResult = new List<ApplicationVM>();

            foreach (var item in Items)
            {
                ApplicationVM obj = Convert(item);
                lstResult.Add(obj);
            }

            return lstResult;
        }

        public static ApplicationVM Convert(ApplicationDto objApplicationDTO)
        {
            ApplicationVM objResult = new ApplicationVM();
            objResult.Id = objApplicationDTO.Id;
            objResult.Status = (ApplicationStatus)objApplicationDTO.Status;
            objResult.Profile = new ProfileVm();
            if (objApplicationDTO.Profile != null)
            {
                objResult.Profile.Id = objApplicationDTO.Profile.Id;
                objResult.Profile.FirstName = objApplicationDTO.Profile.FirstName;
                objResult.Profile.MiddleName = objApplicationDTO.Profile.MiddleName;
                objResult.Profile.LastName = objApplicationDTO.Profile.LastName;
                objResult.Profile.MaritalStatus = (MaritalStatus)objApplicationDTO.Profile.MaritalStatus;
                objResult.Profile.Gender = (Gender)objApplicationDTO.Profile.Gender;
                objResult.Profile.DOB = objApplicationDTO.Profile.DOB;
                objResult.Profile.IDOrPassportNo = objApplicationDTO.Profile.IDOrPassportNo;
                objResult.Profile.PhoneNumber = objApplicationDTO.Profile.PhoneNumber;
            }

            objResult.Scheme = new SchemeVM();

            if (objApplicationDTO.Scheme != null)
            {
                objResult.Scheme.Id = objApplicationDTO.Scheme.Id;
                objResult.Scheme.SchemeType = (SchemeOption)objApplicationDTO.Scheme.SchemeType;

                objResult.Scheme.OtherScheme = objApplicationDTO.Scheme.OtherScheme;
            }

            objResult.Address = new AddressVM();
            if (objApplicationDTO.Address != null)
            {
                objResult.Address.Id = objApplicationDTO.Address.Id;
                objResult.Address.Country = objApplicationDTO.Address.Country;
                objResult.Address.Subcountry = objApplicationDTO.Address.Subcountry;
                objResult.Address.Location = objApplicationDTO.Address.Location;
                objResult.Address.SubLocation = objApplicationDTO.Address.SubLocation;
                objResult.Address.Village = objApplicationDTO.Address.Village;
            }



            return objResult;
        }


        #region ViewModel to DTO
        public static List<ApplicationDto> ConvertList(List<ApplicationVM> Items)
        {
            List<ApplicationDto> lstResult = new List<ApplicationDto>();

            foreach (var item in Items)
            {
                ApplicationDto obj = Convert(item);
                lstResult.Add(obj);
            }

            return lstResult;
        }

        public static ApplicationDto Convert(ApplicationVM objApplicationViewModel)
        {
            ApplicationDto objResult = new ApplicationDto();

            objResult.Id = objApplicationViewModel.Id;
            objResult.Status = (int)objApplicationViewModel.Status;

            objResult.Profile = new ProfileDto();
            objResult.Profile.Id = objApplicationViewModel.Id;
            objResult.Profile.FirstName = objApplicationViewModel.Profile.FirstName;
            objResult.Profile.MiddleName = objApplicationViewModel.Profile.MiddleName;
            objResult.Profile.LastName = objApplicationViewModel.Profile.LastName;
            objResult.Profile.MaritalStatus = (int)objApplicationViewModel.Profile.MaritalStatus;
            objResult.Profile.Gender = (int)objApplicationViewModel.Profile.Gender;
            objResult.Profile.DOB = objApplicationViewModel.Profile.DOB;
            objResult.Profile.IDOrPassportNo = objApplicationViewModel.Profile.IDOrPassportNo;
            objResult.Profile.PhoneNumber = objApplicationViewModel.Profile.PhoneNumber;

            objResult.Scheme = new SchemeDto();

            if (objApplicationViewModel.Scheme != null)
            {
                objResult.Scheme.Id = objApplicationViewModel.Scheme.Id;
                objResult.Scheme.SchemeType = (int)objApplicationViewModel.Scheme.SchemeType;
                objResult.Scheme.OtherScheme = objApplicationViewModel.Scheme.OtherScheme;
            }

            objResult.Address = new AddressDto();

            if (objApplicationViewModel.Address != null)
            {

                objResult.Address.Id = objApplicationViewModel.Address.Id;
                objResult.Address.Country = objApplicationViewModel.Address.Country;
                objResult.Address.Subcountry = objApplicationViewModel.Address.Subcountry;
                objResult.Address.Location = objApplicationViewModel.Address.Location;
                objResult.Address.Subcountry = objApplicationViewModel.Address.Subcountry;
                objResult.Address.Village = objApplicationViewModel.Address.Village;
            }

            return objResult;

        }
        #endregion

        #region DTO to EntityModel
        #endregion
    }

}
