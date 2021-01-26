using GameStoreDAL.Models;
using GameStoreDAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST
{
    class Program
    {
        static void Main(string[] args)
        {
            DeveloperRepository developerR = new DeveloperRepository();
            GameRepository gameR = new GameRepository();
            GenreRepository genreR = new GenreRepository();
            OrderRepository orderR = new OrderRepository();
            PublisherRepository publisherR = new PublisherRepository();

            Genre genre1 = new Genre() {Title = "genre1" };
            Genre genre2 = new Genre() { Title = "genre2" };
            Genre genre3 = new Genre() { Title = "genre3" };

            Publisher publisher1 = new Publisher() { Title = "publisher" };

            Developer developer1 = new Developer() { Title = "developer" };

            genreR.Create(genre1);
            genreR.Create(genre2);
            genreR.Create(genre3);

            publisherR.Create(publisher1);

            developerR.Create(developer1);

            genre1 = genreR.GetById(1);
            genre2 = genreR.GetById(2);
            genre3 = genreR.GetById(3);

            publisher1 = publisherR.GetById(1);

            developer1 = developerR.GetById(1);

            Game game1 = new Game() {Title = "game1", Developer = developer1, Publisher = publisher1, Genres = new List<Genre> {genre1, genre2, genre3}, Discription ="AAA", ReleaseDate = DateTime.Now, Discount = 10, Price = 15};

            gameR.Create(game1);

            game1 = gameR.GetById(1);
        }
    }
}
