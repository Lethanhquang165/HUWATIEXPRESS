TripController: 
 - gettripbypoints (startpoint, defpoint, startdate) // Lay danh sach tuyen theo dia diem va ngay di theo yeu cau
							Link: localhost:..../api/trip/gettripbypoints?startpoint=:startpoint&defpoint=:defpoint&startdate=:startdate/

 - getlistoftriphaveemptyseat() // Lay tat ca tuyen con ghe trong
				Link: localhost:..../api/trip/getlistoftriphaveemptyseat/

 - getlistoftriphaveemptyseatbystartdate(startdate) // Lay tat ca tuyen co ghe trong theo ngay
							Link: localhost..../api/trip/getlistoftriphaveemptyseatbystartdate?startdate=:startdate/

RouteController:
 - getlistofstartpoints() // Lay danh sach tat ca diem den
				Link: localhost..../api/route/getlistofstartpoints/

 - getlistofdefpoints() // Lay danh sach tat ca diem di
			Link: localhost..../api/route/getlistofdefpoints/

 - getlistofroutes() // Lay danh sach tat ca chuyen
			Link: localhost..../api/route/getlistofroutes/

SeatMapForEachTripController:

 - seatmapfortrip(busid, tripid) // Lay danh sach ghe va trang thai ghe cho tat ca cac chuyen
					Link: localhost..../api/seatmapforeachtrip/seatmapfortrip?busid=:busid&tripid=:tripid

CreateABillController:

 - addnewaccount (username, password, roleid) // Tao 1 account cho khach hang troc khi bat dau dat ve
						Link: localhost..../api/createabill/addnewaccount?username=:username&password=:password&roleid=:roleid

 - addnewcustomer(name, address, phone, status, idnum, accid) // Tao 1 khach hang truoc voi ma tai khoan da tao o tren khi bat dau process dat ve
								Link: localhost..../api/createabill/addnewcustomer?name=:name&address=:address&......	

 - addabill(customerid) // Tao 1 hoa don voi ma khach hang da tao o tren
			Link: localhost..../api/createabill/addabill?customerid=:customerid

 - addnewticket(tripid, seatid) // Tao 1 ve voi ma chuyen va ma ghe
				Link: localhost..../api/createabill/addnewticket?tripid=:tripid&seatid=:seatid

 - addbillitem (billid, ticketid) // Tao 1 chi tiet hoa don voi ma hoa don va ma ve vua tao
					Link: localhost..../api/createabill/addbillitem?billid=:billid&ticketid=:ticketid

 - addbillprice (billid) // Them tong gia tien vao hoa don voi ma hoa don vua tao
			Link: localhost..../api/createabill/addbillprice?billid=:billid																