﻿using BlazorMovies.Shared.Entities;
using Microsoft.AspNetCore.Components;

namespace BlazorMovies.Client.Pages
{
    public partial class Counter
    {
        [Inject] SingletonService singleton { get; set; }
        [Inject] TransientService transient { get; set; }

        private List<Movie> movies;

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

        private void IncrementCount()
        {
            currentCount++;
            singleton.Value += 1;
            transient.Value += 1;
        }
    }
}
