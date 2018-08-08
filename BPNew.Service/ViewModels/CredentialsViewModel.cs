
using BPNew.Service.ViewModels.Validations;
using FluentValidation.Attributes;

namespace BPNew.Service.ViewModels
{
    [Validator(typeof(CredentialsViewModelValidator))]
    public class CredentialsViewModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
