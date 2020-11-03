using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;

namespace ValidationForm.Pages
{
    public partial class FormInputWatcher
    {
        [Parameter]
        public EventCallback<string> FieldChanged { get; set; }

        [CascadingParameter]
        protected EditContext EditContext
        {
            get => editContext;
            set
            {
                editContext = value;
                EditContext.OnFieldChanged += EditContext_OnFieldChanged;
            }
        }

        private EditContext editContext;

        public bool Validate() => this.EditContext?.Validate() ?? false;

        private async void EditContext_OnFieldChanged(object sender, FieldChangedEventArgs e)
        {
            await this.FieldChanged.InvokeAsync(e.FieldIdentifier.FieldName);
        }
    }
}