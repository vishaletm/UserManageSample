using Microsoft.AspNetCore.Mvc;
using UMBusinessService;
using UMRepository.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UserManageExample.Controller
{
    
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserManager _userManager;

        public UserController(IUserManager userManager)
        {
            _userManager = userManager;
        }

        //// GET: api/<UserController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/<UserController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}
        /// <summary>
        /// Get Femailes Below 25
        /// </summary>
        /// <returns></returns>
        /// 
        [Route("api/GetFemalesBelow25")]
        [HttpGet]
        public IActionResult GetFemalesBelow25()
        {
            try
            {
                return Ok(_userManager.GetFemalesBelow25());
            }
            catch (Exception ex)
            {
                //Log Here

                return BadRequest(ex.Message);
            }
        }
        /// <summary>
        /// Get Male Above 40
        /// </summary>
        /// <returns></returns>
        [Route("api/GetMaleAbove40")]
        [HttpGet]
        public IActionResult GetMaleAbove40()
        {
            try
            {
                return Ok(_userManager.GetMaleAbove40());
            }
            catch (Exception ex)
            {
                //Log Here

                return BadRequest(ex.Message);
            }
        }
        /// <summary>
        /// Get Youngest Male
        /// </summary>
        /// <returns></returns>
        [Route("api/GetYoungestMale")]
        [HttpGet]
        public IActionResult GetYoungestMale()
        {
            try
            {
                return Ok(_userManager.GetYoungestMale());
            }
            catch (Exception ex)
            {
                //Log Here

                return BadRequest(ex.Message);
            }
        }

    }
}
