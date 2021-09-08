using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.models;

namespace WebApplication1.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        IUser Faidi = null;

        public ValuesController(IUser first)
        {
            this.Faidi = first;
        }

        [HttpGet]
        public List<Users> getall()
        {
            return Faidi.getall();
        }

        [HttpGet("{id}")]
        public Users get(int id)
        {
            return Faidi.get(id);
        }

        [HttpPost]
        public void addUser([FromBody] Users u)
        {
            Faidi.addUser(u);
        }

        [HttpDelete("{id}")]
        public void DeleteUser(int id)
        {
            Faidi.DeleteUser(id);
           
        }

        /*
         * 
        [HttpPut("{id}")]
        public IActionResult UpdateUser(int id,[FromBody] Users USRRR)
        {
            var ouser = us.SingleOrDefault(x => x.id == id);
            if (ouser == null)
            {
                return NotFound("No Found");
            }
            ouser.name = USRRR.name;
            ouser.email = USRRR.email;
            ouser.phone = USRRR.phone;
            ouser.date = USRRR.date;
            //   us.Add(ouser);
            /*
               if (us.Count == 0)
               {
                   return NotFound("No List found");
               }
               return Ok(us);
            */
            //  retun Ok(us); 
            //return Ok(us);
        
        }
    
    }


  


