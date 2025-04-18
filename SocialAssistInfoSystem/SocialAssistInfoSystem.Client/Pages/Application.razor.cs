using FluentValidation;
using Microsoft.AspNetCore.Components;
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

        private ApplicationModel m_objApplicationModel = new ApplicationModel();
        #endregion

        #region Property
        [Inject] 
        ISnackbar Snackbar { get; set; }

        string Country = "Austria";
        string Subcountry = "";
        string Location = "";
        string SubLocation = "";
        string Village = "";
        #endregion

        #region Method
        private async Task Submit()
        {
            await m_objMudForm.Validate();

            if (m_objMudForm.IsValid)
            {
                Snackbar.Add("Submitted!");
            }
        }
        #endregion
    }
}
