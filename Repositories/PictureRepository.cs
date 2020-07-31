using MyPlace.Models;
using MyPlace.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace MyPlace.Repositories
{
    public class PictureRepository : IPictureRepository
    {
        private readonly MyPlaceDbContext context;

        public PictureRepository(MyPlaceDbContext context)
        {
            this.context = context;
        }

        public void Delete(int id)
        {
            var picture = new Picture()
            {
                Id = id
            };

            context.Pictures.Remove(picture);
            context.SaveChanges();
        }

        public List<Picture> GetAll()
        {
            return context.Pictures.ToList();
        }

    }
}
