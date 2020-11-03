using Microsoft.AspNetCore.Components;

namespace ValidationForm.Controls
{
    public partial class MyInputText
    {
        [Parameter]
        //[Required]
        //[StringLength(20)]
        public string Value { get; set; }
    }
}
