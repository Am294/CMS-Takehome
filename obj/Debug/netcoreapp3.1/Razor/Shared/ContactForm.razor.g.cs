#pragma checksum "C:\Users\7339R\Documents\Epitec\CMS\Shared\ContactForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32703d82306e97b999a9d65b68d02685ec869b48"
// <auto-generated/>
#pragma warning disable 1591
namespace CMS.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\7339R\Documents\Epitec\CMS\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\7339R\Documents\Epitec\CMS\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\7339R\Documents\Epitec\CMS\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\7339R\Documents\Epitec\CMS\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\7339R\Documents\Epitec\CMS\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\7339R\Documents\Epitec\CMS\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\7339R\Documents\Epitec\CMS\_Imports.razor"
using CMS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\7339R\Documents\Epitec\CMS\_Imports.razor"
using CMS.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\7339R\Documents\Epitec\CMS\_Imports.razor"
using CMS.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\7339R\Documents\Epitec\CMS\_Imports.razor"
using CMS.DBCommands;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\7339R\Documents\Epitec\CMS\Shared\ContactForm.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
    public partial class ContactForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h1");
            __builder.AddContent(1, 
#nullable restore
#line 5 "C:\Users\7339R\Documents\Epitec\CMS\Shared\ContactForm.razor"
     Mode

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(2, " Contact");
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n<hr>\r\n");
#nullable restore
#line 7 "C:\Users\7339R\Documents\Epitec\CMS\Shared\ContactForm.razor"
 if (Contact != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(5);
            __builder.AddAttribute(6, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 9 "C:\Users\7339R\Documents\Epitec\CMS\Shared\ContactForm.razor"
                      Contact

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "OnInvalidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 10 "C:\Users\7339R\Documents\Epitec\CMS\Shared\ContactForm.razor"
                               (async () => await HandleSubmitAsync(false))

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(8, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 11 "C:\Users\7339R\Documents\Epitec\CMS\Shared\ContactForm.razor"
                             (async () => await HandleSubmitAsync(true))

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(10, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(11);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(13);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(14, "\r\n        ");
                __builder2.OpenElement(15, "p");
                __builder2.AddMarkupContent(16, "\r\n            ");
                __builder2.OpenElement(17, "label");
                __builder2.AddMarkupContent(18, "\r\n                First Name\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(19);
                __builder2.AddAttribute(20, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 17 "C:\Users\7339R\Documents\Epitec\CMS\Shared\ContactForm.razor"
                                        Contact.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Contact.FirstName = __value, Contact.FirstName))));
                __builder2.AddAttribute(22, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Contact.FirstName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(23, "\r\n                ");
                __builder2.OpenElement(24, "ConcurrencyField");
                __builder2.AddAttribute(25, "Model", 
#nullable restore
#line 18 "C:\Users\7339R\Documents\Epitec\CMS\Shared\ContactForm.razor"
                                          Contact

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(26, "DbModel", 
#nullable restore
#line 19 "C:\Users\7339R\Documents\Epitec\CMS\Shared\ContactForm.razor"
                                            DbContact

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(27, "Property", "obj => obj?.FirstName");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n        ");
                __builder2.OpenElement(31, "p");
                __builder2.AddMarkupContent(32, "\r\n        \r\n            ");
                __builder2.OpenElement(33, "label");
                __builder2.AddMarkupContent(34, "\r\n                Last Name\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(35);
                __builder2.AddAttribute(36, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "C:\Users\7339R\Documents\Epitec\CMS\Shared\ContactForm.razor"
                                        Contact.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(37, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Contact.LastName = __value, Contact.LastName))));
                __builder2.AddAttribute(38, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Contact.LastName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(39, "\r\n                ");
                __builder2.OpenElement(40, "ConcurrencyField");
                __builder2.AddAttribute(41, "Model", 
#nullable restore
#line 28 "C:\Users\7339R\Documents\Epitec\CMS\Shared\ContactForm.razor"
                                          Contact

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(42, "DbModel", 
#nullable restore
#line 29 "C:\Users\7339R\Documents\Epitec\CMS\Shared\ContactForm.razor"
                                            DbContact

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(43, "Property", "obj => obj?.LastName");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n            \r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n        ");
                __builder2.OpenElement(47, "p");
                __builder2.AddMarkupContent(48, "\r\n            ");
                __builder2.OpenElement(49, "label");
                __builder2.AddMarkupContent(50, "\r\n                Birth Date\r\n                ");
                __Blazor.CMS.Shared.ContactForm.TypeInference.CreateInputDate_0(__builder2, 51, 52, 
#nullable restore
#line 37 "C:\Users\7339R\Documents\Epitec\CMS\Shared\ContactForm.razor"
                                        Contact.BirthDate

#line default
#line hidden
#nullable disable
                , 53, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Contact.BirthDate = __value, Contact.BirthDate)), 54, () => Contact.BirthDate);
                __builder2.AddMarkupContent(55, "\r\n                ");
                __builder2.OpenElement(56, "ConcurrencyField");
                __builder2.AddAttribute(57, "Model", 
#nullable restore
#line 38 "C:\Users\7339R\Documents\Epitec\CMS\Shared\ContactForm.razor"
                                          Contact

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(58, "DbModel", 
#nullable restore
#line 39 "C:\Users\7339R\Documents\Epitec\CMS\Shared\ContactForm.razor"
                                            DbContact

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(59, "Property", "obj => obj?.BirthDate");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(62, "\r\n        ");
                __builder2.OpenElement(63, "p");
                __builder2.AddMarkupContent(64, "\r\n            ");
                __builder2.OpenElement(65, "label");
                __builder2.AddMarkupContent(66, "\r\n                Phone Number\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(67);
                __builder2.AddAttribute(68, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 46 "C:\Users\7339R\Documents\Epitec\CMS\Shared\ContactForm.razor"
                                        Contact.Phone

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(69, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Contact.Phone = __value, Contact.Phone))));
                __builder2.AddAttribute(70, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Contact.Phone));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(71, "\r\n                ");
                __builder2.OpenElement(72, "ConcurrencyField");
                __builder2.AddAttribute(73, "Model", 
#nullable restore
#line 47 "C:\Users\7339R\Documents\Epitec\CMS\Shared\ContactForm.razor"
                                          Contact

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(74, "DbModel", 
#nullable restore
#line 48 "C:\Users\7339R\Documents\Epitec\CMS\Shared\ContactForm.razor"
                                            DbContact

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(75, "Property", "obj => obj?.Phone");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(76, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(77, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(78, "\r\n         \r\n      \r\n        <br>\r\n        ");
                __builder2.OpenElement(79, "button");
                __builder2.AddAttribute(80, "disabled", 
#nullable restore
#line 55 "C:\Users\7339R\Documents\Epitec\CMS\Shared\ContactForm.razor"
                           Busy

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(81, "type", "submit");
                __builder2.AddAttribute(82, "class", "btn btn-primary");
                __builder2.AddMarkupContent(83, "\r\n            Save\r\n            \r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(84, "&nbsp;\r\n\r\n       \r\n        ");
                __builder2.OpenElement(85, "button");
                __builder2.AddAttribute(86, "disabled", 
#nullable restore
#line 62 "C:\Users\7339R\Documents\Epitec\CMS\Shared\ContactForm.razor"
                           Busy

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(87, "class", "btn btn-warning");
                __builder2.AddAttribute(88, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 63 "C:\Users\7339R\Documents\Epitec\CMS\Shared\ContactForm.razor"
                          CancelAsync

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(89, "\r\n            Cancel\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(90, "\r\n        \r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(91, "\r\n");
#nullable restore
#line 68 "C:\Users\7339R\Documents\Epitec\CMS\Shared\ContactForm.razor"
    
    
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 71 "C:\Users\7339R\Documents\Epitec\CMS\Shared\ContactForm.razor"
       




    /// <summary>
    /// Let parent handle result of validation.
    /// </su>
    [Parameter]
    public EventCallback<bool> ValidationResult { get; set; }

    /// <summary>
    /// Let parent handle what to do on cancel.
    /// </summary>
    [Parameter]
    public EventCallback CancelRequest { get; set; }

    /// <summary>
    /// <c>True</c> if add mode.
    /// </summary>
    [Parameter]
    public bool IsAdd { get; set; }

    /// <summary>
    /// The <see cref="Contact"/> to upsert.
    /// </summary>
    [Parameter]
    public Contact Contact { get; set; }

    /// <summary>
    /// The database version of <see cref="Contact"/> if a concurrency issue
    /// exists.
    /// </summary>
    [Parameter]
    public Contact DbContact { get; set; }

    /// <summary>
    /// Prevent multiple asynchronous operations at the same time.
    /// </summary>
    [Parameter]
    public bool Busy { get; set; }

    /// <summary>
    /// Mode.
    /// </summary>

    [Parameter]
    public int ContactId { get; set; }
    private string Mode => IsAdd ? "Add" : "Edit";

    /// <summary>
    /// Ask to cancel.
    /// </summary>
    /// <returns>A <see cref="Task"/>.</returns>

    
   
    private Task CancelAsync()
    {
        return CancelRequest.InvokeAsync(null);
    }

    /// <summary>
    /// Handle form submission request.
    /// </summary>
    /// <param name="isValid"><c>True</c> when field validation passed.</param>
    /// <returns>A <see cref="Task"/>.</returns>
    private Task HandleSubmitAsync(bool isValid)
    {
        return ValidationResult.InvokeAsync(isValid);
      
    }

     


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Nav { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDbContextFactory<ContactContext> DbFactory { get; set; }
    }
}
namespace __Blazor.CMS.Shared.ContactForm
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputDate_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591