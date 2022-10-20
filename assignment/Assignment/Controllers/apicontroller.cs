using Assignment.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Assignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class apicontroller : ControllerBase
    {
        private readonly d_assignContext obj;
        //object creation above
        public apicontroller(d_assignContext obj1)
        {
            this.obj = obj1;
        }

        [HttpGet("getcategory")]
        public List<Category> getcategory()
        {
            var data = this.obj.Categories.ToList();
            return data;
        }
        [HttpGet("getsubcategory")]
        public List<Subcategory> getsubcategory()
        {
            var data = this.obj.Subcategories.ToList();
            return data;
        }
        [HttpGet("getproduct")]
        public List<Product> getProduct()
        {
            var data = this.obj.Products.ToList();
            return data;
        }
        [HttpGet("getcustomer")]
        public List<Customer> getcustomer()
        {
            var data = this.obj.Customers.ToList();
            return data;
        }
        [HttpGet("getorder")]
        public List<Order> getorder()
        {
            var data = this.obj.Orders.ToList();
            return data;
        }

        [HttpPost("postcategory")]
        public string postcategory(Category rg)
        {
            this.obj.Add(rg);
            this.obj.SaveChanges();
            return "success";
        }
        [HttpPost("postsubcategory")]
        public string postsubcategory(Subcategory rg)
        {
            this.obj.Add(rg);
            this.obj.SaveChanges();
            return "success";
        }
        [HttpPost("postproduct")]
        public string postproduct(Product rg)
        {
            this.obj.Add(rg);
            this.obj.SaveChanges();
            return "success";
        }
        [HttpPost("postcustomer")]
        public string postcustomer(Customer rg)
        {
            this.obj.Add(rg);
            this.obj.SaveChanges();
            return "success";
        }
        [HttpPost("postorder")]
        public string postorder(Order rg)
        {
            this.obj.Add(rg);
            this.obj.SaveChanges();
            return "success";
        }


        [HttpDelete("deletecategory")]
        public string deletecategory(int id)
        {
            var data = this.obj.Categories.Find(id);
            if (data == null)
            {
                return "no data found";
            }
            this.obj.Categories.Remove(data);
            this.obj.SaveChanges();
            return "success";
        }
        [HttpDelete("deletesubcategory")]
        public string deletesubcategory(int id)
        {
            var data = this.obj.Subcategories.Find(id);
            if (data == null)
            {
                return "no data found";
            }
            this.obj.Subcategories.Remove(data);
            this.obj.SaveChanges();
            return "success";
        }
        [HttpDelete("deleteproduct")]
        public string deleteproduct(int id)
        {
            var data = this.obj.Products.Find(id);
            if (data == null)
            {
                return "no data found";
            }
            this.obj.Products.Remove(data);
            this.obj.SaveChanges();
            return "success";
        }
        [HttpDelete("deletecustomer")]
        public string deletecustomer(int id)
        {
            var data = this.obj.Customers.Find(id);
            if (data == null)
            {
                return "no data found";
            }
            this.obj.Customers.Remove(data);
            this.obj.SaveChanges();
            return "success";
        }
        [HttpDelete("deleteorder")]
        public string deleteorder(int id)
        {
            var data = this.obj.Orders.Find(id);
            if (data == null)
            {
                return "no data found";
            }
            this.obj.Orders.Remove(data);
            this.obj.SaveChanges();
            return "success";
        }


        [HttpPut("putcategory")]
        public string putcategory(Category rg)
        {
            if (rg == null)
            {
                return "bad reques";
            }
            this.obj.Categories.Update(rg);
            var data = this.obj.Categories.Find(rg.Catid);
            if (data == null)
            {
                return "no data found";
            }
            data.Name = rg.Name;
            this.obj.SaveChanges();
            return "success";
        }

        [HttpPut("putsubcategory")]
        public string putsubcategory(Subcategory rg)
        {
            if (rg == null)
            {
                return "bad reques";
            }
            this.obj.Subcategories.Update(rg);
            var data = this.obj.Subcategories.Find(rg.Subcatid);
            if (data == null)
            {
                return "no data found";
            }
            data.Subcatname = rg.Subcatname;
            data.Catid = rg.Catid;
            this.obj.SaveChanges();
            return "success";
        }

        [HttpPut("putproduct")]
        public string putproduct(Product rg)
        {
            if (rg == null)
            {
                return "bad reques";
            }
            this.obj.Products.Update(rg);
            var data = this.obj.Products.Find(rg.Pid);
            if (data == null)
            {
                return "no data found";
            }
            data.Pname = rg.Pname;
            data.Price = rg.Price;
            data.Qty = rg.Qty;
            data.Subcatid = rg.Subcatid;
            this.obj.SaveChanges();
            return "success";
        }

        [HttpPut("putcustomer")]
        public string putcustomer(Customer rg)
        {
            if (rg == null)
            {
                return "bad reques";
            }
            this.obj.Customers.Update(rg);
            var data = this.obj.Customers.Find(rg.Custid);
            if (data == null)
            {
                return "no data found";
            }
            data.Name = rg.Name;
            data.Address = rg.Address;
            data.Phone = rg.Phone;
            this.obj.SaveChanges();
            return "success";
        }

        [HttpPut("putorder")]
        public string putorder(Order rg)
        {
            if (rg == null)
            {
                return "bad reques";
            }
            this.obj.Orders.Update(rg);
            var data = this.obj.Orders.Find(rg.Oid);
            if (data == null)
            {
                return "no data found";
            }
            data.DateOfPurchase = rg.DateOfPurchase;
            data.Qty = rg.Qty;
            data.Custid = rg.Custid;
            data.Pid = rg.Pid;
            this.obj.SaveChanges();
            return "success";
        }
    }
}