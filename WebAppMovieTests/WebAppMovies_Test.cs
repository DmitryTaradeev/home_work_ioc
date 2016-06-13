using System;
using NUnit.Framework;
using System.Web.Mvc;


namespace WebAppMovieTests
{
    [TestFixture]
    public class WebAppMovies_Test
    {
        [Test]
        public void Movie_Test()
        {

            WebAppMovies.Models.InMemoryMovieRepository m = new WebAppMovies.Models.InMemoryMovieRepository();
            WebAppMovies.Controllers.MoviesController con = new WebAppMovies.Controllers.MoviesController(m);
            ViewResult res = con.Index() as ViewResult;
            Assert.IsNotNull(res);


        }
    }
}