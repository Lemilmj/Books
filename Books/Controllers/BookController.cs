using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Books.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class BookController : BaseController
    {
        public enum actions
        {
            Insert,
            Delete,
            Create,
        }


        [HttpGet]
        public ActionResult<String> Index()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(databaseConection.Books.ToArray());
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Post(String Services, [FromForm] Models.Books books)
        {

            if (ModelState.IsValid) 
            {
                try
                {
                    databaseConection.Books.Add(books);
                    databaseConection.SaveChanges();
                }
                catch (Exception e)
                {

                    return RedirectToAction(nameof(Index));
                }


            }
            
            return RedirectToAction(nameof(Index));

        }

        // POST: Books/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            try
            {
                var book =  databaseConection.Books.Find(id);
                databaseConection.Remove(book);
                databaseConection.SaveChanges();

            }
            catch
            {
                
            }

            return RedirectToAction(nameof(Index));

        }

    }
}