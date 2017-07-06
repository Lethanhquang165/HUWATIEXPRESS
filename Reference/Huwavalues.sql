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
--select * from Seat_Map

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

--insert into Customer values ('Leo Andres','234 Phan Van Tri, phuong 11, quan Binh Thanh, TP.HCM','01203598364','025329454','20')
--insert into Customer values ('Techone','540 Wickham St, Fortitude Valley QLD 4006','31677300','31677300','20')

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
--insert into Bus_Type values ('Daewoo BC212MA','81','true')
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

--select * from Bus_Type
--select * from Bus
--select * from Seat
--select * from Route
--select * from Driver
--select * from Trip

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

--insert into Seat values ('true','A','1','8')
--insert into Seat values ('true','A','2','8')
--insert into Seat values ('true','A','3','8')
--insert into Seat values ('true','A','4','8')
--insert into Seat values ('true','A','5','8')
--insert into Seat values ('true','A','6','8')
--insert into Seat values ('true','A','7','8')
--insert into Seat values ('true','A','8','8')
--insert into Seat values ('true','A','9','8')
--insert into Seat values ('true','A','10','8')
--insert into Seat values ('true','A','11','8')
--insert into Seat values ('true','A','12','8')
--insert into Seat values ('true','A','13','8')
--insert into Seat values ('true','A','14','8')
--insert into Seat values ('true','A','15','8')
--insert into Seat values ('true','A','16','8')
--insert into Seat values ('true','A','17','8')
--insert into Seat values ('true','A','18','8')
--insert into Seat values ('true','A','19','8')
--insert into Seat values ('true','A','20','8')
--insert into Seat values ('true','A','21','8')
--insert into Seat values ('true','B','1','8')
--insert into Seat values ('true','B','2','8')
--insert into Seat values ('true','B','3','8')
--insert into Seat values ('true','B','4','8')
--insert into Seat values ('true','B','5','8')
--insert into Seat values ('true','B','6','8')
--insert into Seat values ('true','B','7','8')
--insert into Seat values ('true','B','8','8')
--insert into Seat values ('true','B','9','8')
--insert into Seat values ('true','B','10','8')
--insert into Seat values ('true','B','11','8')
--insert into Seat values ('true','B','12','8')
--insert into Seat values ('true','B','13','8')
--insert into Seat values ('true','B','14','8')
--insert into Seat values ('true','B','15','8')
--insert into Seat values ('true','B','16','8')
--insert into Seat values ('true','B','17','8')
--insert into Seat values ('true','B','18','8')
--insert into Seat values ('true','B','19','8')
--insert into Seat values ('true','B','20','8')
--insert into Seat values ('true','B','21','8')
--insert into Seat values ('true','C','1','8')
--insert into Seat values ('true','C','2','8')
--insert into Seat values ('true','C','3','8')
--insert into Seat values ('true','C','4','8')

--insert into Seat values ('true','A','1','9')
--insert into Seat values ('true','A','2','9')
--insert into Seat values ('true','A','3','9')
--insert into Seat values ('true','A','4','9')
--insert into Seat values ('true','A','5','9')
--insert into Seat values ('true','A','6','9')
--insert into Seat values ('true','A','7','9')
--insert into Seat values ('true','B','1','9')
--insert into Seat values ('true','B','2','9')
--insert into Seat values ('true','B','3','9')
--insert into Seat values ('true','B','4','9')
--insert into Seat values ('true','B','5','9')
--insert into Seat values ('true','B','6','9')
--insert into Seat values ('true','B','7','9')
--insert into Seat values ('true','C','1','9')
--insert into Seat values ('true','C','2','9')
--insert into Seat values ('true','C','3','9')
--insert into Seat values ('true','C','4','9')
--insert into Seat values ('true','C','5','9')
--insert into Seat values ('true','C','6','9')
--insert into Seat values ('true','C','7','9')
--insert into Seat values ('true','C','1','9')
--insert into Seat values ('true','C','2','9')
--insert into Seat values ('true','C','3','9')
--insert into Seat values ('true','C','4','9')
--insert into Seat values ('true','C','5','9')
--insert into Seat values ('true','C','6','9')
--insert into Seat values ('true','C','7','9')
--insert into Seat values ('true','D','1','9')
--insert into Seat values ('true','D','2','9')
--insert into Seat values ('true','D','3','9')
--insert into Seat values ('true','D','4','9')
--insert into Seat values ('true','D','5','9')
--insert into Seat values ('true','D','6','9')
--insert into Seat values ('true','D','7','9')

--insert into Seat values ('true','AA','1','10')
--insert into Seat values ('true','AA','2','10')
--insert into Seat values ('true','AA','3','10')
--insert into Seat values ('true','AA','4','10')
--insert into Seat values ('true','AA','5','10')
--insert into Seat values ('true','AB','1','10')
--insert into Seat values ('true','AB','2','10')
--insert into Seat values ('true','AB','3','10')
--insert into Seat values ('true','AB','4','10')
--insert into Seat values ('true','AB','5','10')
--insert into Seat values ('true','AC','1','10')
--insert into Seat values ('true','AC','2','10')
--insert into Seat values ('true','AC','3','10')
--insert into Seat values ('true','AC','4','10')
--insert into Seat values ('true','AC','5','10')
--insert into Seat values ('true','AC','1','10')
--insert into Seat values ('true','AC','2','10')
--insert into Seat values ('true','AC','3','10')
--insert into Seat values ('true','AC','4','10')
--insert into Seat values ('true','AC','5','10')
--insert into Seat values ('true','AD','1','10')
--insert into Seat values ('true','AD','2','10')
--insert into Seat values ('true','AD','3','10')
--insert into Seat values ('true','AD','4','10')
--insert into Seat values ('true','AD','5','10')

--insert into Seat values ('true','BA','1','10')
--insert into Seat values ('true','BA','2','10')
--insert into Seat values ('true','BA','3','10')
--insert into Seat values ('true','BA','4','10')
--insert into Seat values ('true','BA','5','10')
--insert into Seat values ('true','BB','1','10')
--insert into Seat values ('true','BB','2','10')
--insert into Seat values ('true','BB','3','10')
--insert into Seat values ('true','BB','4','10')
--insert into Seat values ('true','BB','5','10')
--insert into Seat values ('true','BC','1','10')
--insert into Seat values ('true','BC','2','10')
--insert into Seat values ('true','BC','3','10')
--insert into Seat values ('true','BC','4','10')
--insert into Seat values ('true','BC','5','10')
--insert into Seat values ('true','BC','1','10')
--insert into Seat values ('true','BC','2','10')
--insert into Seat values ('true','BC','3','10')
--insert into Seat values ('true','BC','4','10')
--insert into Seat values ('true','BC','5','10')
--insert into Seat values ('true','BD','1','10')
--insert into Seat values ('true','BD','2','10')
--insert into Seat values ('true','BD','3','10')
--insert into Seat values ('true','BD','4','10')
--insert into Seat values ('true','BD','5','10')

--insert into Seat_Map values ('8','4','1')
--insert into Seat_Map values ('9','4','1')
--insert into Seat_Map values ('10','4','1')
--insert into Seat_Map values ('11','4','1')
--insert into Seat_Map values ('12','4','1')
--insert into Seat_Map values ('13','4','1')
--insert into Seat_Map values ('14','4','1')
--insert into Seat_Map values ('15','4','1')
--insert into Seat_Map values ('16','4','1')
--insert into Seat_Map values ('17','4','1')
--insert into Seat_Map values ('18','4','1')
--insert into Seat_Map values ('19','4','1')
--insert into Seat_Map values ('20','4','1')
--insert into Seat_Map values ('21','4','1')
--insert into Seat_Map values ('22','4','1')
--insert into Seat_Map values ('23','4','1')
--insert into Seat_Map values ('24','4','1')
--insert into Seat_Map values ('25','4','1')
--insert into Seat_Map values ('26','4','1')
--insert into Seat_Map values ('27','4','1')
--insert into Seat_Map values ('28','4','1')
--insert into Seat_Map values ('29','4','1')
--insert into Seat_Map values ('30','4','1')
--insert into Seat_Map values ('31','4','1')
--insert into Seat_Map values ('32','4','1')
--insert into Seat_Map values ('33','4','1')
--insert into Seat_Map values ('34','4','1')
--insert into Seat_Map values ('35','4','1')
--insert into Seat_Map values ('36','4','1')
--insert into Seat_Map values ('37','4','1')
--insert into Seat_Map values ('38','4','1')
--insert into Seat_Map values ('39','4','1')
--insert into Seat_Map values ('40','4','1')
--insert into Seat_Map values ('41','4','1')
--insert into Seat_Map values ('42','4','1')
--insert into Seat_Map values ('43','4','1')
--insert into Seat_Map values ('44','4','1')
--insert into Seat_Map values ('45','4','1')
--insert into Seat_Map values ('46','4','1')
--insert into Seat_Map values ('47','4','1')
--insert into Seat_Map values ('48','4','1')
--insert into Seat_Map values ('49','4','1')
--insert into Seat_Map values ('50','4','1')
--insert into Seat_Map values ('51','4','1')
--insert into Seat_Map values ('52','4','1')
--insert into Seat_Map values ('53','4','1')

--insert into Seat_Map values ('54','5','1')
--insert into Seat_Map values ('55','5','1')
--insert into Seat_Map values ('56','5','1')
--insert into Seat_Map values ('57','5','1')
--insert into Seat_Map values ('58','5','1')
--insert into Seat_Map values ('59','5','1')
--insert into Seat_Map values ('60','5','1')
--insert into Seat_Map values ('61','5','1')
--insert into Seat_Map values ('62','5','1')
--insert into Seat_Map values ('63','5','1')
--insert into Seat_Map values ('64','5','1')
--insert into Seat_Map values ('65','5','1')
--insert into Seat_Map values ('66','5','1')
--insert into Seat_Map values ('67','5','1')
--insert into Seat_Map values ('68','5','1')
--insert into Seat_Map values ('69','5','1')
--insert into Seat_Map values ('70','5','1')
--insert into Seat_Map values ('71','5','1')
--insert into Seat_Map values ('72','5','1')
--insert into Seat_Map values ('73','5','1')
--insert into Seat_Map values ('74','5','1')
--insert into Seat_Map values ('75','5','1')
--insert into Seat_Map values ('76','5','1')
--insert into Seat_Map values ('77','5','1')
--insert into Seat_Map values ('78','5','1')
--insert into Seat_Map values ('79','5','1')
--insert into Seat_Map values ('80','5','1')
--insert into Seat_Map values ('81','5','1')
--insert into Seat_Map values ('82','5','1')
--insert into Seat_Map values ('83','5','1')
--insert into Seat_Map values ('84','5','1')
--insert into Seat_Map values ('85','5','1')
--insert into Seat_Map values ('86','5','1')
--insert into Seat_Map values ('87','5','1')
--insert into Seat_Map values ('88','5','1')

--insert into Seat_Map values ('89','6','1')
--insert into Seat_Map values ('90','6','1')
--insert into Seat_Map values ('91','6','1')
--insert into Seat_Map values ('92','6','1')
--insert into Seat_Map values ('93','6','1')
--insert into Seat_Map values ('94','6','1')
--insert into Seat_Map values ('95','6','1')
--insert into Seat_Map values ('96','6','1')
--insert into Seat_Map values ('97','6','1')
--insert into Seat_Map values ('98','6','1')
--insert into Seat_Map values ('99','6','1')
--insert into Seat_Map values ('100','6','1')
--insert into Seat_Map values ('101','6','1')
--insert into Seat_Map values ('102','6','1')
--insert into Seat_Map values ('103','6','1')
--insert into Seat_Map values ('104','6','1')
--insert into Seat_Map values ('105','6','1')
--insert into Seat_Map values ('106','6','1')
--insert into Seat_Map values ('107','6','1')
--insert into Seat_Map values ('108','6','1')
--insert into Seat_Map values ('109','6','1')
--insert into Seat_Map values ('110','6','1')
--insert into Seat_Map values ('111','6','1')
--insert into Seat_Map values ('112','6','1')
--insert into Seat_Map values ('113','6','1')
--insert into Seat_Map values ('114','6','1')
--insert into Seat_Map values ('115','6','1')
--insert into Seat_Map values ('116','6','1')
--insert into Seat_Map values ('117','6','1')
--insert into Seat_Map values ('118','6','1')
--insert into Seat_Map values ('119','6','1')
--insert into Seat_Map values ('120','6','1')
--insert into Seat_Map values ('121','6','1')
--insert into Seat_Map values ('122','6','1')
--insert into Seat_Map values ('123','6','1')
--insert into Seat_Map values ('124','6','1')
--insert into Seat_Map values ('125','6','1')
--insert into Seat_Map values ('126','6','1')
--insert into Seat_Map values ('127','6','1')
--insert into Seat_Map values ('128','6','1')
--insert into Seat_Map values ('129','6','1')
--insert into Seat_Map values ('130','6','1')
--insert into Seat_Map values ('131','6','1')
--insert into Seat_Map values ('132','6','1')
--insert into Seat_Map values ('133','6','1')
--insert into Seat_Map values ('134','6','1')
--insert into Seat_Map values ('135','6','1')
--insert into Seat_Map values ('136','6','1')
--insert into Seat_Map values ('137','6','1')
--insert into Seat_Map values ('138','6','1')