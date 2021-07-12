﻿using BigSch.DOTs;
using BigSch.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BigSch.Controllers
{
    [Authorize]
    public class AttendancesController : ApiController
    {
            
        
            private ApplicationDbContext _dbContext;
            public AttendancesController()
            {
                _dbContext = new ApplicationDbContext();
            }
            [HttpPost]
        //public IHttpActionResult Attend([FromBody] int courseId)
        //{
        //    var attendance = new Attendance
        //    {
        //        CourseId = courseId,
        //        AttendeeId = User.Identity.GetUserId()
        //    };

        //    _dbContext.Attendances.Add(attendance);
        //    _dbContext.SaveChanges();

        //    return Ok();
        //}

        public IHttpActionResult Attend(AttendanceDto attendanceDto)
        {
            var userId = User.Identity.GetUserId();
            if (_dbContext.Attendances.Any(a => a.AttendeeId == userId && a.CourseId == attendanceDto.CourseId))
                return BadRequest("The Attendance already exixts!");
            var attendance = new Attendance
            {
                CourseId = attendanceDto.CourseId,
                AttendeeId = userId
            };
            _dbContext.Attendances.Add(attendance);
            _dbContext.SaveChanges();

            return Ok();
        }

    }
}