using System;
using ValidationForm.Models;

namespace ValidationForm.Pages
{
    public partial class FormInputWatcherValidation
    {
        public Employee MyEmployee { get; set; }

        public FormInputWatcher InputWatcher;
        private bool _isFormInvalid;

        public FormInputWatcherValidation(FormInputWatcher inputWatcher)
        {
            this.InputWatcher = inputWatcher;
        }

        protected override void OnInitialized()
        {
            this.MyEmployee = new Employee();
        }

        private void FieldChanged(string fieldName)
        {
            this._isFormInvalid = !InputWatcher.Validate();
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
