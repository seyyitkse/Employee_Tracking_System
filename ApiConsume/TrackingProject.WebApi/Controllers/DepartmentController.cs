﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TrackingProject.BusinessLayer.Abstract;
using TrackingProject.EntityLayer.Concrete;

namespace TrackingProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        IDepartmentService _departmentService;

        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        [HttpGet]
        public IActionResult DepartmentList(Department Department)
        {
            _departmentService.TInsert(Department);
            return Ok();
        }
        [HttpPost]
        public IActionResult AddDepartment(Department Department)
        {
            _departmentService.TInsert(Department);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteDepartment(int id)
        {
            var values = _departmentService.TGetById(id);
            _departmentService.TDelete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateDepartment(Department Department)
        {
            _departmentService.TUpdate(Department);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetDepartment(int id)
        {
            var values = _departmentService.TGetById(id);
            return Ok(values);
        }
    }
}