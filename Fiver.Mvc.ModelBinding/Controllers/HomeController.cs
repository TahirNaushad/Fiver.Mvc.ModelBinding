using Microsoft.AspNetCore.Mvc;
using Fiver.Mvc.ModelBinding.Models.Home;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Fiver.Mvc.ModelBinding.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Content("Hello Model Binding");
        }

        #region " Simple Type "

        // Bind: route, query, form
        public IActionResult Simple(int id)
        {
            return Content($"Simple-Default: {id}");
        }

        // Bind: query
        public IActionResult SimpleQuery([FromQuery]int id)
        {
            return Content($"Simple-Query: {id}");
        }

        // Bind: form
        public IActionResult SimpleForm([FromForm]int id)
        {
            return Content($"Simple-Form: {id}");
        }

        // Bind: 
        public IActionResult SimpleBodyWithoutModel([FromBody]int id)
        {
            return Content($"Simple-Body-Primitive: {id}");
        }

        // Bind: body
        public IActionResult SimpleBodyWithModel([FromBody]SimpleBodyInputModel model)
        {
            return Content($"Simple-Body-Model: {model.Id}");
        }

        // Bind: header
        public IActionResult SimpleHeader(
            [FromHeader]string host, 
            [FromHeader(Name = "User-Agent")]string userAgent)
        {
            return Content($"Simple-Header: {host}, {userAgent}");
        }

        #endregion

        #region " Complex Type "

        // Bind: query, form
        public IActionResult Complex(GreetingInputModel model)
        {
            return Content($"Complex-Default: {model.Type} {model.To}");
        }

        // Bind: query
        public IActionResult ComplexQuery([FromQuery]GreetingInputModel model)
        {
            return Content($"Complex-Query: {model.Type} {model.To}");
        }

        // Bind: form
        public IActionResult ComplexForm([FromForm]GreetingInputModel model)
        {
            return Content($"Complex-Form: {model.Type} {model.To}");
        }

        // Bind: body
        public IActionResult ComplexBody([FromBody]GreetingInputModel model)
        {
            return Content($"Complex-Body: {model.Type} {model.To}");
        }

        // Bind: header
        public IActionResult ComplexHeader(HeaderInputModel model)
        {
            return Content($"Complex-Header: {model.Host}, {model.UserAgent}");
        }

        #endregion

        #region " Collections "
        
        // Bind: query
        public IActionResult Collection(IEnumerable<string> values)
        {
            return Content($"Collection-Simple: {values.Count()}");
        }

        // Bind: body
        public IActionResult CollectionComplex([FromBody]CollectionInputModel model)
        {
            return Content($"Collection-Complex: {model.Values.Count()}");
        }

        #endregion

        #region " Multiple Sources "
        
        // Order: form > route > query 
        public IActionResult Multiple(int id)
        {
            return Content($"Multiple: {id}");
        }

        #endregion

    }
}
