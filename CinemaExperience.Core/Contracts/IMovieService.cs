﻿using CinemaExperience.Core.ViewModels.Director;
using CinemaExperience.Core.ViewModels.Genre;
using CinemaExperience.Core.ViewModels.Movie;
using CinemaExperience.Core.ViewModels.Review;

namespace CinemaExperience.Core.Contracts;
public interface IMovieService
{
    Task<IEnumerable<AllMoviesViewModel>> GetAllMoviesAsync();
    Task<MovieDetailsViewModel> GetMovieDetailsAsync(int movieId);
    Task<IEnumerable<ReviewViewModel>> GetLatestReviewsAsync(int movieId);
    Task<bool> GenreExistsAsync(IEnumerable<int> genreId);
    Task<bool> MovieExistsAsync(int movieId);
    Task<IEnumerable<DirectorFormViewModel>> GetDirectorsAsync();
    Task<IEnumerable<GenreViewModel>> GetGenresAsync();
    Task<int> AddMovieAsync(MovieViewModel movieForm);
    Task<IEnumerable<AllMoviesViewModel>> SearchAsync(string input);
    Task<MovieDeleteViewModel> DeleteAsync(int movieId);
    Task<int> DeleteConfirmedAsync(int movieId);
    Task<MovieViewModel> EditGetAsync(int movieId);
    Task<int> EditPostAsync(MovieViewModel movieForm);
}
