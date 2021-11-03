﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApi.Data;
using WebApi.Models;


namespace WebApi.Controllers
{
    
        [ApiController]
        [Route("[controller]")]

        public class AdultsController : ControllerBase
        {
            private IAdultData adultData;

            public AdultsController(IAdultData adultData)
            {
                this.adultData = adultData;
            }
            [HttpGet]
            public async Task<ActionResult<IList<Adult>>> GetAdults([FromQuery] int? adultId, [FromQuery] string name, [FromQuery] int? age, [FromQuery] string sex) {
                try {
                    IList<Adult> adults = adultData.getAdults();
                    Console.WriteLine(adults.Count);
                    return Ok(adults);
                } catch (Exception e) {
                    Console.WriteLine(e);
                    return StatusCode(500, e.Message);
                } 
            }
            /*[HttpDelete]
            [Route("{id:int}")]
            public async Task<ActionResult> RemoveAdultAsync([FromRoute] int id) {
                try {
                    await adultData.RemoveAdultAsync(id);
                    return Ok();
                } catch (Exception e) {
                    Console.WriteLine(e);
                    return StatusCode(500, e.Message);
                }
            }*/
            [HttpPost]
            public async Task<ActionResult<Adult>> AddAdult([FromBody] Adult adult) {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                try {
                    Adult added = await adultData.AddAdult(adult);
                    return Created($"/{added.Id}",added); // return newly added adult, to get the auto generated id
                } catch (Exception e) {
                    Console.WriteLine(e);
                    return StatusCode(500, e.Message);
                }
            }

            /*[HttpPatch]
            [Route("{id:int}")]
            public async Task<ActionResult<Adult>> UpdateAdultAsync([FromBody] Adult adult) {
                try
                {
                    Adult updatedAdult = await adultData.UpdateAdult(adult);
                    if (adult == null) throw new Exception();
                    return Ok(updatedAdult); 
                } catch (Exception e) {
                    Console.WriteLine(e);
                    return StatusCode(500, e.Message);
                }
            }*/


    }
}