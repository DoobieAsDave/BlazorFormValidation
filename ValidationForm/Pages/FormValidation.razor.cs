using System;
using ValidationForm.Models;

namespace ValidationForm.Pages
{
    public partial class FormValidation
    {
        public Employee MyEmployee { get; set; }

        protected override void OnInitialized()
        {
            this.MyEmployee = new Employee();
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
