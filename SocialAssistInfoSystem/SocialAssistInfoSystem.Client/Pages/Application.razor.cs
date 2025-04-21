using FluentValidation;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using MudBlazor;
using SocialAssistInfoSystem.Client.Data;

namespace SocialAssistInfoSystem.Client.Pages
{
    /// <summary>
    /// Application
    /// </summary>
    public partial class Application
    {
        #region Member
        private MudForm m_objMudForm;

        private OrderModelFluentValidator m_objOrderValidator = new OrderModelFluentValidator();

        private OrderDetailsModelFluentValidator m_objOrderDetailsValidator = new OrderDetailsModelFluentValidator();

        private ApplicationVM m_objApplicationModel = new ApplicationVM();
        #endregion

        #region Property
        [Inject] 
        ISnackbar Snackbar { get; set; }

        string Country = "Austria";
        string Subcountry = "";
        string Location = "";
        string SubLocation = "";
        string Village = "";

        public List<String> CountryItems { get; set; } = new List<string>();
        public List<String> SubcountryItems { get; set; } = new List<string>();

        public List<String> LocationItems { get; set; } = new List<string>();
        public List<String> SubLocationItems { get; set; } = new List<string>();

        public List<String> VillageItems { get; set; } = new List<string>();

        #endregion

        protected override void OnInitialized()
        {
            base.OnInitialized();
            CountryItems = new List<string>();
            CountryItems.Add("India");
            CountryItems.Add("Japan");
            CountryItems.Add("United States");

        }

        #region Method
        private async Task Submit()
        {
            await m_objMudForm.Validate();

            if (m_objMudForm.IsValid)
            {

                Snackbar.Add("Submitted!");
            }
        }

        private void OnCountrySelected(ChangeEventArgs e) 
        {
            if (!string.IsNullOrEmpty(Country)) 
            {
                SetSubCountry(Country);
            }
        }

        void SetSubCountry(string sCountry) 
        {
            SubcountryItems.Clear();
            SubcountryItems.Add("Maharastra");
            SubcountryItems.Add("Gujrat");
            SubcountryItems.Add("Rajasthan");
            SubcountryItems.Add("Punjab");
        }
        #endregion
    }
}
