using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using ABC_WEB.Models;
using Microsoft.Build.Tasks.Deployment.Bootstrapper;
using Newtonsoft.Json;

namespace ABC_WEB.Controllers
{
    public class OrdersController : Controller
    {
        private ABCEntities dbContext = new ABCEntities();
        // GET: Orders
        public ActionResult Orders()
        {
            return View();
        }

        public ActionResult NewOrder()
        {
            return View();
        }

        [HttpPost]
        public JsonResult searchProduct(int idProduct)
        {
            List<string> List = new List<string>();
            try
            {
                using (ABCEntities db = new ABCEntities())
                {
                    var Order = db.PRODUCTS.FirstOrDefault(x => x.ID == idProduct);
                    if(Order != null)
                    {
                        List.Add(Order.ID.ToString());
                        List.Add(Order.Description.ToString());
                        return Json(List, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {
                        return Json("NoData");
                    }
                    
                }
            }
            catch (WebException ex)
            {
                return Json(ex.Message.ToString());
            }
        }

        [HttpPost]
        public JsonResult saveOrder(string[] arrayProduct, string Customer, string RFC, string DeliveryDate, string Comments)
        {
            List<string> List = new List<string>();
            try
            {
                using (ABCEntities db = new ABCEntities())
                {
                    ORDERS Order = new ORDERS();
                    Order.ID_Customer = 1;
                    Order.Order_Date = DateTime.Now;
                    Order.Order_Date = Convert.ToDateTime(DeliveryDate);
                    Order.Comments = Comments;
                    Order.Status = 0;

                    dbContext.ORDERS.Add(Order);
                    dbContext.SaveChanges();
                    var id = Order.ID;


                    return Json("");
                }
            }
            catch (WebException ex)
            {
                return Json(ex.Message.ToString());
            }
        }
    }
}