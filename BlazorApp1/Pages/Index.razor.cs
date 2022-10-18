using Microsoft.JSInterop;

namespace BlazorApp1.Pages
{
    public partial class Index
    {
        private readonly IJSRuntime js;

        public string id;
        public string pass;
        public void Trypass()
        {
            System.Console.WriteLine("ID: " + id + "\nPass: " + pass);
            
        }
       
        public void lol()
        {
           js.InvokeVoidAsync("PageScript");
        }
    }
}

