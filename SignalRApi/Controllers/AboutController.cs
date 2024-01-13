﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.AboutDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private readonly IAboutService _aboutService;

        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        [HttpGet]
        public IActionResult AboutList()
        {
            var values = _aboutService.BGetListAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateAbout(CreateAboutDto createAboutDto)
        {
            About about = new About()
            {
                Title = createAboutDto.Title,
                Description = createAboutDto.Description,
                ImageUrl = createAboutDto.ImageUrl,
            };
            _aboutService.BAdd(about);
            return Ok("Hakkımda başarılı bir şekilde eklendi...");
        }

        [HttpDelete]
        public IActionResult DeleteAbout(int id) { 
            var value=_aboutService.BGetByID(id);
            _aboutService.BDelete(value);
            return Ok("Hakkımda alanı silindi...");
        }

        [HttpPut]
        public IActionResult UpdateAbout(UpdateAboutDto updateAboutDto)
        {
            About about = new About()
            {
                ID = updateAboutDto.ID, 
                Title = updateAboutDto.Title,
                Description = updateAboutDto.Description,
                ImageUrl = updateAboutDto.ImageUrl,
            };
            _aboutService.BUpdate(about);
            return Ok("Hakkımda alanı güncellendi...");    
        }

        [HttpGet("GetAbout")]
        public IActionResult GetAbout(int id) {
            var value=_aboutService.BGetByID(id);
            return Ok(value);
        }

    }
}
