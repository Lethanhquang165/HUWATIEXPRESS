using System;
using System.Linq;
using System.Web.Http;
using HUWATIExpress.Models;
using System.Data;

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

        /// <summary>
        /// GET EMPTY ACCOUNT FIELD PREPARE FOR ADDING
        /// </summary>
        [HttpGet]
        public void AddNewAccount()
        {
            var account = new Account();
        }

        /// <summary>
        /// POST VALUE TO ADD A ACCOUNT BY SQL QUERY
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="roleid"></param>
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

        /// <summary>
        /// GET EMPTY BILL FIELD PREPARE FOR ADDING
        /// </summary>
        [HttpGet]
        public void AddNewBill()
        {
            var bill = new Bill();
        }

        /// <summary>
        /// POST VALUE TO SQL QUERY FOR ADDING
        /// </summary>
        /// <param name="customerid"></param>
        [AcceptVerbs("Get")]
        [HttpPost]
        public void AddNewBill(int customerid)
        {
            var bill = new Bill
            {
                Create_Date = DateTime.Now,
                Total_Price = 0,
                Status = false,
                Customer_Id = customerid
            };
            db.Bills.InsertOnSubmit(bill);
            db.SubmitChanges();
        }

        /// <summary>
        /// GET EMPTY TICKET FIELD PREPARE FOR ADDING
        /// </summary>
        [HttpGet]
        public void AddNewTicket()
        {
            var ticket = new Ticket();
        }

        /// <summary>
        /// POST VALUE TO SQL QUERY FOR ADDING
        /// </summary>
        /// <param name="tripid"></param>
        /// <param name="seatid"></param>
        [AcceptVerbs("Get")]
        [HttpPost]
        public void AddNewTicket(int tripid, int seatid)
        {
            var tripItem = from trip in db.Trips where trip.Trip_Id == tripid select trip;

            var seatItem = from seat in db.Seats where seat.Seat_Id == seatid select seat;

            if (tripItem != null && seatItem != null)
            {
                var ticket = new Ticket
                {
                    Seat_Id = seatItem.First().Seat_Id,
                    Status = false,
                    Unit_Price = tripItem.First().Price,
                    Trip_Id = tripItem.First().Trip_Id
                };
                db.Tickets.InsertOnSubmit(ticket);
                db.SubmitChanges();
            }
        }

        /// <summary>
        /// GET EMPTY BILL ITEM FIELDS FOR ADDING
        /// </summary>
        [HttpGet]
        public void AddBillItem()
        {
            var item = new Bill_Item();
        }

        /// <summary>
        /// POST VALUE TO SQL QUERY FOR ADDING
        /// </summary>
        /// <param name="billid"></param>
        /// <param name="ticketid"></param>
        [AcceptVerbs("GET")]
        [HttpPost]
        public void AddBillItem (int billid, int ticketid)
        {
            var billItem = from bill in db.Bills where bill.Bill_Id == billid select bill.Bill_Id;

            var ticketItem = from ticket in db.Tickets where ticket.Ticket_Id == ticketid select ticket.Ticket_Id;

            if (billItem != null && ticketItem != null)
            {
                var item = new Bill_Item
                {
                    Bill_Id = billItem.First(),
                    Ticket_Id = ticketItem.First()
                };
                db.Bill_Items.InsertOnSubmit(item);
                db.SubmitChanges();
            }
        }

        [HttpGet]
        public void AddBillPrice()
        {
            var billItem = new Bill();
        }

        [AcceptVerbs("GET")]
        [HttpPut]
        public void AddBillPrice(int billid)
        {
            var item = from bill in db.Bills where bill.Bill_Id == billid select new
            {
                bill.Bill_Id,
                bill.Create_Date,
                bill.Total_Price,
                bill.Status,
                bill.Customer_Id 
            };

            var billItems = from items in db.Bill_Items where items.Bill_Id == billid select items.Ticket_Id;

            var ticketPrice = (from ticket in db.Tickets
                              join billticket in billItems on ticket.Ticket_Id equals billticket
                              select ticket.Unit_Price).Sum();

            if (item != null)
            {
                var billItem = db.Bills.Single(a => a.Bill_Id == billid);
                billItem.Total_Price = ticketPrice;
                db.SubmitChanges();
            }
        }
    }
}