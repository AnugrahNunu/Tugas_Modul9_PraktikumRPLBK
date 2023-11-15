using Microsoft.AspNetCore.Mvc;
using TestAPI.Data;
using TestAPI.Models.Dto;

namespace TestAPI.Controllers
{
    [Route("api/AuthorizationModify")]
    [ApiController]
    public class VillaAPIController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<AuthDTO>> GetAuth()
        {
            return Ok(AuthStore.authList);
        }

        [HttpPost]
        [Route("api/AuthorizationModify/Verify")]
        public ActionResult<AuthDTO> VerifyAuth([FromBody] AuthDTO auth)
        {
            var existingAuthUsername = AuthStore.authList.FirstOrDefault(u => u.Username.ToLower() == auth.Username.ToLower());
            var existingAuthPassword = AuthStore.authList.FirstOrDefault(u => u.Password.ToLower() == auth.Password.ToLower());
            if (existingAuthUsername != null && existingAuthPassword != null)
            {
                return Ok(new { Message = "Auth is exists" });
            }
            else
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPost]
        
        public ActionResult<AuthDTO> AddAuth([FromBody] AuthDTO auth)
        {
            if (AuthStore.authList.FirstOrDefault(u => u.Username.ToLower() == auth.Username.ToLower()) != null)
            {
                ModelState.AddModelError("CustomError", "Auth is already exists");
                return BadRequest(ModelState);
            }
            if (auth == null)
            {
                return BadRequest(auth);
            }
            if (auth.Id > 0)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            auth.Id = AuthStore.authList.OrderByDescending(u => u.Id).FirstOrDefault().Id + 1;
            AuthStore.authList.Add(auth);
            string response = "Sukses menambahkan data akun" + "\nId : " + auth.Id.ToString() + "\nNama : " + auth.Username;
            return CreatedAtRoute("GetVilla", new { id = auth.Id }, response);
        }

        [HttpPut("{id:int}", Name = "UpdateAuth")]
        public IActionResult UpdateAuth(int id, [FromBody] AuthDTO auth)
        {
            if (auth == null || id != auth.Id)
            {
                return BadRequest();
            }
            var author = AuthStore.authList.FirstOrDefault(u => u.Id == id);
            author.Username = auth.Username;
            author.Password = auth.Password;
            return NoContent();
        }

        [HttpDelete("{id:int}", Name = "DeleteAuth")]
        public IActionResult DeleteAuth(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var auth = AuthStore.authList.FirstOrDefault(u => u.Id == id);
            if (auth == null)
            {
                return NotFound();
            }
            AuthStore.authList.Remove(auth);
            return NoContent();
        }
    }
}
