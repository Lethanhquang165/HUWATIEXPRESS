--delete from customer
--delete from Admin	
--delete from Driver
--delete from Role
--delete from Account
--delete from Trip
--delete from Route
--delete from Bill
--delete from Bill_Item
--delete from Ticket
--delete from Seat
--delete from Seat_Map
--delete from Bus
--delete from Bus_Type
--delete from Company
--delete from Salary

--insert into Role values ('Admin')
--insert into Role values ('Super_Admin')
--insert into Role values ('Customer')
--insert into Role values ('Main_Driver')
--insert into Role values ('Sub_Driver')

--select * from Role
--select * from Account
--select * from Customer

--insert into Account values ('Admin','Admin1234','18')
--insert into Account values ('Techone','Techone1234','19')
--insert into Account values ('Leoandres165','Leoandres165','18')
--insert into Account values ('Levantien','tienlevan','18')
--insert into Account values ('Techone','cianywhere','20')
--insert into Account values ('Leoandres165','Leoandres165','20')
--insert into Account values ('ATran','driver1234','21')
--insert into Account values ('BNguyen','driver1234','22')
--insert into Account values ('CLe','driver1234','22')
--insert into Account values ('DHo','driver1234','22')

--insert into Customer values ('Leo Andres','234 Phan Van Tri, phuong 11, quan Binh Thanh, TP.HCM','01203598364','true','025329454','20')
--insert into Customer values ('Techone','540 Wickham St, Fortitude Valley QLD 4006','31677300','true','31677300','20')

--insert into Salary values (1.0,3500000)
--insert into Salary values (1.5,4000000)
--insert into Salary values (2.0,5000000)
--insert into Salary values (3.0,6000000)

--select * from salary
--select * from Admin
--select * from Company
--select * from Driver

--insert into Admin values ('Leo Andres','01203598364',N'234 Phan Văn Trị, phường 11, quận Bình Thạnh','true','12','8','Koala.png')
--insert into Admin values (N'Lê Văn Tiến','01203598364',N'QTSC, TMA Tower, phường 1, quận 12','true','13','9','Koala.png')
--insert into Admin values ('TechnologyOneCorp','31677300','540 Wickham St, Fortitude Valley QLD 4006','false','11','10','Koala.png')

--insert into Company values ('TMA Solutions','#10 St, Quang Trung Software City, 1 To Ky, District 12','52775235','52775235','SOUTH','HCMC','true','TMASolutions.png')
--insert into Company values ('Technology One Corporation','540 Wickham St, Fortitude Valley QLD 4006','52775235','52775235','SOUTH','Brisbane','false','Techone.png')

--insert into Driver values (N'Trần Văn A','true','01234789465',N'234 Phan Văn Trị, phường 11, quận Bình Thạnh','false','3','16','9','Koala.png')
--insert into Driver values (N'Nguyễn Văn B','true','01235674567',N'1202 Quang Trung, phường 10, quận 12','true','4','17','8','Koala.png')
--insert into Driver values (N'Lê Văn C','true','3423546453',N'23 Lê Lai, phường 1, quận 1','false','4','20','10','Koala.png')
--insert into Driver values (N'Hồ Văn D','true','0123435646',N'30 Hoàng Hoa Thám, phường 5, quận Bình Thạnh','true','3','21','11','Koala.png')

--insert into Bus_Type values ('Hyundai Universe Noble','47','true')
--insert into Bus_Type values ('Hyundai County','29','true')
--insert into Bus_Type values ('Daewoo BC212MA','80','true')
--insert into Bus_Type values ('Deawoo FX12','47','true')
--insert into Bus_Type values ('Daewoo BX212DS','41','false')
--insert into Bus_Type values ('Daewoo BH117','47','false')
--insert into Bus_Type values ('Hino Limostart','29','true')
--insert into Bus_Type values ('Thaco Town','29','true')
--insert into Bus_Type values ('Thaco Universe TB120S','42','false')
--insert into Bus_Type values ('Universe Noble','42','false')

--select * from Bus_Type
--select * from Bus
--select * from Route

--insert into Bus values ('3','7','233B 2353','true','3','7')
--insert into Bus values ('4','8','256E 5977','false','4','7')
--insert into Bus values ('3','9','216T 6574','true','4','10')
--insert into Bus values ('4','10','270G 9043','false','3','7')
--insert into Bus values ('3','11','4535 2132','true','4','10')
--insert into Bus values ('4','16','235E 2125','false','3','6')
--insert into Bus values ('3','15','12RE 4543','false','3','6')

--insert into Route values (N'TP HCM',N'HÀ NỘI','5','HANOI.png')
--insert into Route values (N'TP HCM',N'NHA TRANG','2','NHATRANG.png')
--insert into Route values (N'TP HCM',N'HUẾ','5','HUE.png')
--insert into Route values (N'TP HCM',N'VŨNG TÀU','2','VUNGTAU.png')
--insert into Route values (N'TP HCM',N'ĐÀ LẠT','3','DALAT.png')
--insert into Route values (N'TP HCM',N'ĐỒNG THÁP','6','DONGTHAP.png')
--insert into Route values (N'TP HCM',N'RẠCH GIÁ','5','RACHGIA.png')
--insert into Route values (N'TP HCM',N'NAM ĐỊNH','4','NAMDINH.png')

--select * from Trip
--select * from Bus
--select * from Route
--select * from Driver

--insert into Trip values ('8','7','08:00:00.000','07-05-2017','true','1007','210000')
--insert into Trip values ('9','8','8:30:00.000','07-05-2017','true','1008','250000')
--insert into Trip values ('10','9','08:30:00','07-05-2017','true','1010','250000')
--insert into Trip values ('11','10','10:00:00','07-08-2017','false','1009','150000')
--insert into Trip values ('12','11','09:45:00','07-10-2017','false','1007','210000')
--insert into Trip values ('13','12','13:00:00','07-08-2017','false','1008','180000')
--insert into Trip values ('14','13','10:45:00','07-08-2017','false','1010','200000')
--insert into Trip values ('8','13','18:30:00','07-11-2017','false','1010','200000')
--insert into Trip values ('9','12','15:00:00','07-15-2017','false','1008','170000')
--insert into Trip values ('10','11','22:30:00','07-14-2017','false','1007','210000')
--insert into Trip values ('11','10','19:45:00','07-15-2017','false','1009','150000')
--insert into Trip values ('12','9','20:00:00','07-20-2017','false','1010','250000')
--insert into Trip values ('13','8','16:15:00','07-21-2017','false','1008','250000')
--insert into Trip values ('14','7','18:30:00','07-18-2017','false','1007','210000')




