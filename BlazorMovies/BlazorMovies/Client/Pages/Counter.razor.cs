using BlazorMovies.Shared.Entities;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using static BlazorMovies.Client.Shared.MainLayout;

namespace BlazorMovies.Client.Pages
{
    public partial class Counter
    {
        [Inject] SingletonService singleton { get; set; }
        [Inject] TransientService transient { get; set; }
        [Inject] IJSRuntime js { get; set; }
        [CascadingParameter(Name ="AppState")] public AppState AppState { get; set; }

        private List<Movie> movies;

        IJSObjectReference module;

        protected override void OnInitialized()
        {

            // Simulate waiting for database
            //await Task.Delay(3000);

            movies = new List<Movie>()
        {
            new Movie(){Title = "Joker", ReleaseDate = new DateTime(2019, 7, 2)},
            new Movie(){Title = "Avengers", ReleaseDate = new DateTime(2016, 11, 23)}
        };
        }

        private int currentCount = 0;
        private static int currentCountStatic = 0;

        [JSInvokable]
        public async Task IncrementCount()
        {
            module = await js.InvokeAsync<IJSObjectReference>("import", "./js/Counter.js");
            await module.InvokeVoidAsync("displayAlert", "hello world");

            currentCount++;
            singleton.Value += 1;
            transient.Value += 1;
            currentCountStatic++;
            await js.InvokeVoidAsync("dotnetStaticInvocation");
        }

        private async Task IncrementCountJavaScript()
        {
            await js.InvokeVoidAsync("dotnetInstanceInvocation",
                DotNetObjectReference.Create(this));
        }

        [JSInvokable]
        public static Task<int> GetCurrentCount()
        {
            return Task.FromResult(currentCountStatic);
        }
    }
}
