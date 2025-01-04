﻿using Microsoft.AspNetCore.Mvc;
using StudentPortal.Data;
using StudentPortal.Models;
using StudentPortal.Models.Entities;

namespace StudentPortal.Controllers
{
    public class StudentsController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public StudentsController(ApplicationDbContext dbcontext)
        {
            _dbContext=dbcontext;   
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(AddStudentViewModel viewModel)
        {
            var student = new Students
            {
                Name = viewModel.Name,
                Email = viewModel.Email,
                Phone = viewModel.Phone,
                Subscribed = viewModel.Subscribed
            };

            await _dbContext.Students.AddAsync(student);
            await _dbContext.SaveChangesAsync();

            return View();
        }

    }
}
