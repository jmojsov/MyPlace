using MyPlace.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPlace.Repositories.Interfaces
{
    public interface IPictureRepository
    {
        List<Picture> GetAll();
        void Delete(int id);
    }
}
