using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SocialAssistInfoSystem.Client.Data;
using SocialAssistInfoSystem.Client.Data.Enum;
using SocialAssistInfoSystem.Client.Util;
using SocialAssistInfoSystem.Data;
using SocialAssistInfoSystem.Data.DBEntity;
using SocialAssistInfoSystem.Data.Dto;
using SocialAssistInfoSystem.Util;
using System.Text.Json;
using static MudBlazor.CategoryTypes;

namespace SocialAssistInfoSystem.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class ApplicationController : ControllerBase
    {
        public ApplicationDbContext DbContext { get; set; }

        public ApplicationController(ApplicationDbContext obj)
        {
            DbContext = obj;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            //var Data = DbContext.Applications.ToList();

            List<Application> lstItems = await DbContext.Applications
                                                .Include(a => a.Scheme)    // Include related Scheme
                                                .Include(a => a.Address)   // Include related Address
                                                .Include(a => a.Profile)   // Include related Profile
                                                .ToListAsync();

            if (lstItems == null || !lstItems.Any())
            {
                return NotFound(lstItems);
            }

            return Ok(lstItems);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ApplicationDto objApplication)
        {

            //objApplication.Address = new AddressDto();
            //objApplication.Address.Country = 2;
            //objApplication.Address.Subcountry = 3;
            //objApplication.Address.Location = 4;
            //objApplication.Address.SubLocation = 5;
            //objApplication.Address.Village = 6;
            //objApplication.Scheme = new SchemeDto();
            //objApplication.Scheme.SchemeName = SchemeOption.ANY_OTHER.ToString();
            //objApplication.Scheme.OtherScheme = "Hi";
            //objApplication.Profile = new ProfileDto();
            //objApplication.Profile.FirstName = "Pritesh";
            //objApplication.Profile.MiddleName = "Pradeep";
            //objApplication.Profile.LastName = "More";
            //objApplication.Profile.DOB = new DateTime();
            //objApplication.Profile.MaritalStatus = Client.Data.Enum.MaritalStatus.MARRIED;
            //objApplication.Profile.Gender = Client.Data.Enum.Gender.MALE;
            //objApplication.Profile.PhoneNumber = "7666123165";
            //objApplication.Profile.PassportNo = 98976543;



            if (objApplication != null)
            {
                Application obj = StdUtil.Convert(objApplication);

                if (obj != null)
                {

                    DbContext.Applications.Add(obj);
                    await DbContext.SaveChangesAsync();
                    return CreatedAtAction(nameof(Get), new { id = objApplication.Id }, objApplication);
                }
            }

            return BadRequest("Application data is null");
        }

        [HttpPut("{Id}")]
        public async Task<IActionResult> Edit(int Id, [FromBody] ApplicationDto obj)
        {
            if (obj.Id != Id)
            {
                return BadRequest("Id Mismatch");
            }

            //Application objApplicationEntity = StdUtil.Convert(obj);

            var existingEntity = await DbContext.Applications
                                                .Include(a => a.Profile)
                                                .Include(a => a.Address)
                                                .Include(c => c.Scheme)
                                                .FirstOrDefaultAsync(x => x.Id == obj.Id);
            if (existingEntity != null)
            {
                //DbContext.Entry(existingEntity).State = EntityState.Detached; // Detach old

                existingEntity = StdUtil.UpdateApplicationEntity(obj, existingEntity);

                

                //DbContext.Attach(existingEntity); // Attach your updated object
                DbContext.Entry(existingEntity).State = EntityState.Modified;
                if (existingEntity.Profile != null)
                {
                    DbContext.Entry(existingEntity.Profile).State = EntityState.Modified;
                }
                if (existingEntity.Address!=null)
                {
                    DbContext.Entry(existingEntity.Address).State = EntityState.Modified;
                }

                if (existingEntity.Scheme != null)
                {

                    DbContext.Entry(existingEntity.Scheme).State = EntityState.Modified;
                }

                await DbContext.SaveChangesAsync();
            }

            return Ok(existingEntity);

        }


        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete(int Id)
        {
            var item = await DbContext.Applications.FindAsync(Id);

            if (item == null)
                return NotFound();

            DbContext.Applications.Remove(item);
            await DbContext.SaveChangesAsync();

            return NoContent();
        }
    }
}
