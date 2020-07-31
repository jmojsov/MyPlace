using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyPlace.Helper;
using MyPlace.Models;
using MyPlace.Services.Interfaces;
using MyPlace.ViewModels;

namespace MyPlace.Controllers
{
    public class PictureController : Controller
    {
        private readonly IPictureService pictureService;

        public PictureController(IPictureService pictureService)
        {
            this.pictureService = pictureService;
        }
        public IActionResult Overview()
        {
            List<Picture> picturesDb = pictureService.GetAll();
            var pictures = picturesDb.Select(x => x.ToOverviewModel()).ToList();
            return View(pictures);
        }
        [Authorize]
        public IActionResult ModifyOverview()
        {
            var picturesDb = pictureService.GetAll();
            var pictures = picturesDb.Select(x => x.ToModifyOverview()).ToList();

            return View(pictures);
        }
        [Authorize]
        public IActionResult Delete(int id)
        {
            pictureService.Delete(id);
            return RedirectToAction(nameof(ModifyOverview));
        }
        public IActionResult Create()
        {
            var picture = new PictureCreateModel();
            return View(picture);
        }

        [Authorize]
        [HttpPost]
        public IActionResult Create(PictureCreateModel createPicture)
        {
            if (ModelState.IsValid)
            {
                var picture = ModelConverter.ToPictureModel(createPicture);
                pictureService.Create(picture);
                return RedirectToAction(nameof(ModifyOverview));
            }
            else
            {
                return View(createPicture);
            }
        }



    }
}
