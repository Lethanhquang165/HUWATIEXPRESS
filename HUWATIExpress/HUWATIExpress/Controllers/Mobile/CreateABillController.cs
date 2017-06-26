using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HUWATIExpress.Models;

namespace HUWATIExpress.Controllers.Mobile
{
    public class CreateABillController : ApiController
    {
        huwadbDataContext db = new huwadbDataContext();

        /// <summary>
        /// GET EMPTY FORM FOR ADDING CUSTOMER
        /// </summary>

        [HttpGet]
        public void AddNewCustomer()
        {
            var customer = new Customer();
        }

        /// <summary>
        /// POST VALUE TO ADD A CUSTOMER BY SQL QUERY
        /// </summary>
        /// <param name="name"></param>
        /// <param name="address"></param>
        /// <param name="phone"></param>
        /// <param name="status"></param>
        /// <param name="idnum"></param>
        /// <param name="accid"></param>
        /// 
        [AcceptVerbs("GET")]
        [HttpPost]
        public void AddNewCustomer(string name, string address, decimal phone, bool status, decimal idnum, int accid)
        {
            var customer = new Customer
            {
                Customer_Name = name,
                Address = address,
                Phone = phone,
                Status = status,
                Identication_Number = idnum,
                Account_Id = accid,
            };
            db.Customers.InsertOnSubmit(customer);
            db.SubmitChanges();
        }

        [HttpGet]
        public void AddNewAccount()
        {
            var account = new Account();
        }

        [AcceptVerbs("Get")]
        [HttpPost]
        public void AddNewAccount(string username, string password, int roleid)
        {
            var account = new Account
            {
                User_Name = username,
                Password = password,
                Role_Id = roleid
            };
            db.Accounts.InsertOnSubmit(account);
            db.SubmitChanges();
        }
    }
}