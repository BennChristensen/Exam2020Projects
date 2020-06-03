using MovieApplication.Models;
using MovieApplication.Storage;
using Xunit;

namespace Example10
{
    public class TestIMovieData
    {
        [Fact]
        public void ShouldAddMovie()
        {
            var sut = new InMemoryMovieDataStorage();
            var currentCount = sut.Movies.Count;
            var movieToAdd = new Movie { Titel = "TestMovie" };

            sut.AddMovie(movieToAdd);

            Assert.Contains(sut.Movies, m => m.Id == movieToAdd.Id);

        }
    }
}
