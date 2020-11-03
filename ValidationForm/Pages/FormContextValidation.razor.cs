using System;
using Microsoft.AspNetCore.Components.Forms;
using ValidationForm.Models;

namespace ValidationForm.Pages
{
    public partial class FormContextValidation
    {
        public Employee MyEmployee { get; set; }

        private EditContext _editContext;
        private bool _isFormInvalid;

        protected override void OnInitialized()
        {
            this.MyEmployee = new Employee();

            this._editContext = new EditContext(this.MyEmployee);
            this._editContext.OnFieldChanged += EditContext_OnFieldChanged;
        }

        private void EditContext_OnFieldChanged(object sender, FieldChangedEventArgs e)
        {
            this._isFormInvalid = !_editContext.Validate();
            this.StateHasChanged();
        }

        public void HandleValidSubmit()
        {
            Console.WriteLine("success");
        }

        public void HandleInvalidSubmit()
        {
            Console.WriteLine("failure");
        }
    }
}
