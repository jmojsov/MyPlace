using MyPlace.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPlace.Services.Interfaces
{
    public interface IPictureService
    {
        List<Picture> GetAll();
        void Delete(int id);
        void Create(Picture picture);
    }
}
