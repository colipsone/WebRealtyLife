using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using WRL.DataLayer;
using WRL.DataLayer.Interface;
using WRL.DataLayer.Interface.Repository;
using WRL.Model.Entity.Apartment;
using WRL.Service.Interface;
using WRL.Web.Attributes;
using WRL.Web.ModelMappers;
using WRL.Web.Models.ApartmentService;

namespace WRL.Web.Controllers
{
    public class ApartmentsController : ApiController
    {
        #region Fields: Private

        private readonly IWrlDbContext _context;
        private readonly IApartmentService _apartmentService;

        #endregion

        #region Ctors: Public

        public ApartmentsController(IWrlDbContext context, IApartmentService apartmentService)
        {
            _context = context;
            _apartmentService = apartmentService;
        }

        #endregion

        #region Methods: Public

        // GET: api/Apartments
        [HttpGet]
        [AuthorizeByActivity("test action")]
        public IEnumerable<ApartmentViewModel> Get()
        {

            return _apartmentService.GetAll().Select(apartment => apartment.ToViewModel());
        }


        /*
        // GET: api/Apartments/5
        [ResponseType(typeof(Apartment))]
        public async Task<IHttpActionResult> GetApartment(int id)
        {
            Apartment apartment = await _context.Apartments.FindAsync(id);
            if (apartment == null)
            {
                return NotFound();
            }

            return Ok(apartment);
        }

        // PUT: api/Apartments/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutApartment(int id, Apartment apartment)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != apartment.Id)
            {
                return BadRequest();
            }

            _context.Entry(apartment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ApartmentExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Apartments
        [ResponseType(typeof(Apartment))]
        public async Task<IHttpActionResult> PostApartment(Apartment apartment)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Apartments.Add(apartment);
            await _context.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = apartment.Id }, apartment);
        }

        // DELETE: api/Apartments/5
        [ResponseType(typeof(Apartment))]
        public async Task<IHttpActionResult> DeleteApartment(int id)
        {
            Apartment apartment = await _context.Apartments.FindAsync(id);
            if (apartment == null)
            {
                return NotFound();
            }

            _context.Apartments.Remove(apartment);
            await _context.SaveChangesAsync();

            return Ok(apartment);
        }*/

        #endregion

        #region Methods: Protected

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
            base.Dispose(disposing);
        }

        #endregion

        #region Methods: Private

        private bool ApartmentExists(int id)
        {
            return _context.Apartments.Count(e => e.Id == id) > 0;
        }
         
        #endregion
    }
}