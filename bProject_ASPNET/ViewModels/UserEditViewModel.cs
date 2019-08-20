using System;
namespace bProject_ASPNET.ViewModels
{
    public class UserEditViewModel : CreateViewModel
    {
        public int ID { get; set; }
        public string ExistingPhotoPath { get; set; }
    }
}
