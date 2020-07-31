using MyPlace.Models;
using MyPlace.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPlace.Helper
{
    public static class ModelConverter
    {
        public static PictureViewModel ToOverviewModel(this Picture picture)
        {
            return new PictureViewModel()
            {
                Id = picture.Id,
                ImageUrl = picture.ImageUrl,
                Email = picture.Email,
                DateCreated = picture.DateCreated

            };
        }
        public static ModifyOverviewModel ToModifyOverview (this Picture picture)
        {
            return new ModifyOverviewModel()
            {
                Id = picture.Id,
                ImageUrl = picture.ImageUrl,
                Email = picture.Email,
                DateCreated = picture.DateCreated,
                IsPrivate = picture.IsPrivate
            };
        }
        public static Picture ToPictureModel(PictureCreateModel createPicture)
        {
            return new Picture
            {
                ImageUrl = createPicture.ImageUrl,
                Email = createPicture.Email,
                DateCreated = createPicture.DateCreated,
                IsPrivate = createPicture.IsPrivate
            };
        }
    }
}
