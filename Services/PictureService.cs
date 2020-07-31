using MyPlace.Models;
using MyPlace.Repositories.Interfaces;
using MyPlace.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPlace.Services
{
    public class PictureService : IPictureService
    {
        private readonly IPictureRepository pictureRepository;

        public PictureService(IPictureRepository pictureRepository)
        {
            this.pictureRepository = pictureRepository;
        }

        public void Create(Picture picture)
        {
            return ;
        }

        public void Delete(int id)
        {
            pictureRepository.Delete(id);
        }

        public List<Picture> GetAll()
        {
            return pictureRepository.GetAll();
        }
    }
}
