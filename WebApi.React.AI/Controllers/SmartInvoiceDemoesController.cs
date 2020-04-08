using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebApi.React.AI.DB;

namespace WebApi.React.AI.Controllers
{
    public class SmartInvoiceDemoesController : ApiController
    {
        private CrudDemoEntities db = new CrudDemoEntities();

        // GET: api/SmartInvoiceDemoes
        public IQueryable<SmartInvoiceDemo> GetSmartInvoiceDemoes()
        {
            return db.SmartInvoiceDemoes;
        }

        // GET: api/SmartInvoiceDemoes/5
        [ResponseType(typeof(SmartInvoiceDemo))]
        public IHttpActionResult GetSmartInvoiceDemo(int id)
        {
            SmartInvoiceDemo smartInvoiceDemo = db.SmartInvoiceDemoes.Find(id);
            if (smartInvoiceDemo == null)
            {
                return NotFound();
            }

            return Ok(smartInvoiceDemo);
        }

        // PUT: api/SmartInvoiceDemoes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutSmartInvoiceDemo(int id, SmartInvoiceDemo smartInvoiceDemo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != smartInvoiceDemo.ID)
            {
                return BadRequest();
            }

            db.Entry(smartInvoiceDemo).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SmartInvoiceDemoExists(id))
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

        // POST: api/SmartInvoiceDemoes
        [ResponseType(typeof(SmartInvoiceDemo))]
        public IHttpActionResult PostSmartInvoiceDemo(SmartInvoiceDemo smartInvoiceDemo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.SmartInvoiceDemoes.Add(smartInvoiceDemo);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (SmartInvoiceDemoExists(smartInvoiceDemo.ID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = smartInvoiceDemo.ID }, smartInvoiceDemo);
        }

        // DELETE: api/SmartInvoiceDemoes/5
        [ResponseType(typeof(SmartInvoiceDemo))]
        public IHttpActionResult DeleteSmartInvoiceDemo(int id)
        {
            SmartInvoiceDemo smartInvoiceDemo = db.SmartInvoiceDemoes.Find(id);
            if (smartInvoiceDemo == null)
            {
                return NotFound();
            }

            db.SmartInvoiceDemoes.Remove(smartInvoiceDemo);
            db.SaveChanges();

            return Ok(smartInvoiceDemo);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SmartInvoiceDemoExists(int id)
        {
            return db.SmartInvoiceDemoes.Count(e => e.ID == id) > 0;
        }
    }
}