using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;
using Microsoft.AspNetCore.Mvc;


namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public ValuesController()
        {
            List<AuctionItem> auctionItems = new List<AuctionItem>();
        }

        //List<AuctionItem> GetAllAuctionItems();
        //AuctionItem GetAuctionItem(int itemNumber);
        //string ProvideBid(int itemNumber, int bidPrice, string bidCustomName,
        //string bidCustomPhone);


        // GET api/values
        [HttpGet]
        public IActionResult GetAllAuctionItems()
        {
            return
        }

        [HttpGet]
        public ActionResult<AuctionItem> GetAuctionItem(int itemNumber)
        {

        }

        [HttpPost]
        public IActionResult ProvideBid(int itemNumber, int bidPrice, string bidCustomName, string bidCustomPhone)
        {

        }

    }
}
