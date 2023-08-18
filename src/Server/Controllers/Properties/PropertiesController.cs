﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Server.Data;
using Server.Data.Models;
using Server.Extensions;

namespace Server.Controllers.Properties
{
    [AuthorizeAdministrator]
    public class PropertiesController : ApiController
    {
        private readonly ApplicationDbContext _context;

        public PropertiesController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPropertiesAsync()
        {
            var properties = await _context.Properties.ToListAsync();

            return Ok(properties);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> AddPropertiesAsync([FromBody] Property propertyRequest)
        {
            propertyRequest.Id = Guid.NewGuid().ToString();

            await _context.Properties.AddAsync(propertyRequest);
            await _context.SaveChangesAsync();

            return Ok(propertyRequest);
        }
    }
}
