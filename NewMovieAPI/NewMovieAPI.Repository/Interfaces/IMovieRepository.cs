namespace NewMovieAPI.Repository.Interfaces
{
    using NewMovieAPI.Entities;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    public interface IMovieRepository
    {
        void Add(Movie movie);
        void Delete(int id);
        void Edit(Movie movie);

        Task<Movie> GetMovie(int id);

        Task<IEnumerable<Movie>> GetMovies();

        IEnumerable<Movie> GetMovies2();
    }
}
