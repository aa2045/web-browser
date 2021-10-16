using NUnit.Framework;
using WebDraft1;
//using WebDraft1.Browser;

namespace NUnitTestProject1
{
    public class Tests
    {
        Browser s;
        Favorites f;
        DataClass d;
        History h;

        [SetUp]
        public void Setup()
        {
            s = new Browser();
            f = new Favorites();
            d = new DataClass();
            h = new History();
        }

        [Test]
        public void statuscode200()
        {
            s.getWebRequest("http://www.google.com");
            Assert.Pass(s.getStatuscode(), "200"); }

        [Test]
        public void getHomepage()
        {
            Assert.Pass(s.getHomePageData(), "http://www.google.com");                      
        }
        [Test]
        public void statuscode200Description()
        {
            Assert.Pass(s.getStatusDescription(), "OK");
        }
        [Test]
        public void title()
        {
            Assert.Pass(s.getTitle(), "google");
        }
        [Test]
        public void nameResolutionError()
        {
            s.getWebRequest("http://www.googlerandinfd.com");
            Assert.Pass(s.getStatuscode(), "Name resolution failure OK");
        }
        [Test]
        public void nameResErrorContent()
        {
            s.getWebRequest("http://www.googlerandinfd.com");
            Assert.Pass(s.getHtmlContent(), "The remote name could not be resolved:");
        }
        [Test]
        public void error404StatusCode()
        {
            s.getWebRequest("http://httpstat.us/404");
            Assert.Pass(s.getStatuscode(), "404");
        }
        [Test]
        public void error404Description()
        {
            s.getWebRequest("http://httpstat.us/404");
            Assert.Pass(s.getStatusDescription(), "404 Not Found");
        }
        [Test]
        public void error404Title()
        {
            Assert.Pass(s.getTitle(), "ERROR");
        }
        [Test]
        public void error403StatusCode()
        {
            s.getWebRequest("http://httpstat.us/403");
            Assert.Pass(s.getStatuscode(), "403");
        }
        [Test]
        public void error403Description()
        {
            s.getWebRequest("http://httpstat.us/403");
            Assert.Pass(s.getStatusDescription(), "403 Forbidden");
        }
        [Test]
        public void error403Title()
        {
            Assert.Pass(s.getTitle(), "ERROR");
        }
        public void error400StatusCode()
        {
            s.getWebRequest("http://httpstat.us/400");
            Assert.Pass(s.getStatuscode(), "400");
        }
        [Test]
        public void error400Description()
        {
            s.getWebRequest("http://httpstat.us/400");
            Assert.Pass(s.getStatusDescription(), "400 Bad Request");
        }
        [Test]
        public void error400Title()
        {
            Assert.Pass(s.getTitle(), "ERROR");
        }

        [Test]
        public void setHomepage()
        {
            Assert.Pass(s.setHomePage("http://wwww.bing.com"),"homepage added");
        }


        [Test]
        public void addToFavorites()
        {
            Assert.Pass(f.addFavoritesData("google","http://wwww.google.com"), "successful");
        }
        [Test]
        public void deleteFromFavorites()
        {
            Assert.Pass(f.removeSelectedData("google", "http://wwww.google.com",1), "deleted");
        }
        [Test]
        public void modifyInFavorites()
        {
            Assert.Pass(f.changeSelectedDataAtIndex("search engine", "http://wwww.google.com", 1), "modified");
        }
        [Test]

        public void addToHistory()
            {
                Assert.Pass(h.setHistory("http://wwww.google.com"), "added to history");
            }
        

    }

}