namespace NewMovieAPI.Service
{
    using NewMovieAPI.Entities;
    using NewMovieAPI.Repository.Interfaces;
    using NewMovieAPI.Service.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;

        public MovieService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public void Add(Movie movie)
        {
            _movieRepository.Add(movie);
        }

        public void Delete(int id)
        {
            _movieRepository.Delete(id);
        }

        public void Edit(Movie movie)
        {
            _movieRepository.Edit(movie);
        }

        public async Task<Movie> GetMovie(int id)
        {
            var result = await _movieRepository.GetMovie(id);
            return result;
        }

        public async Task<IEnumerable<Movie>> GetMovies()
        {
            var result = await _movieRepository.GetMovies();
            return result;
        }

        public IEnumerable<Movie> GetMovies2()
        {
            var result = _movieRepository.GetMovies2();
            return result;
        }
    }
}
