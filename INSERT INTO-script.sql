INSERT INTO dbo.Repairer(Name, Surname, EmailAddress, Password, Longevity, Birthday, Role, SuperiorsEmailAddress)
VALUES ('Roy', 'Johnson', 'roy@gmail.com', 'roy123', 16, '1973-09-25', 'MainRepairer', NULL)

INSERT INTO dbo.Repairer(Name, Surname, EmailAddress, Password, Longevity, Birthday, Role, SuperiorsEmailAddress)
VALUES ('Steven', 'Zerk', 'steven@gmail.com', 'steven123', 5, '1999-04-01', 'Repairer', 'roy@gmail.com')

/*---------------------------------------------------------------*/
INSERT INTO dbo.Client(Name, Surname, EmailAddress, Password, DeliveryAddress, DeliveryCity, PostalCode, Birthday, PhoneNumber)
VALUES ('Smith', 'Yurk', 'smith@gmail.com', 'smith123', 'Regent Street', 'London', 'EC1', '1998-03-23', '0523456234')

INSERT INTO dbo.Client(Name, Surname, EmailAddress, Password, DeliveryAddress, DeliveryCity, PostalCode, Birthday, PhoneNumber)
VALUES ('Clark', 'Peterson', 'clark@gmail.com', 'clark123', 'Avenue Victor Hugo', 'Paris', '75116', '1967-10-19', '523546246')

/*---------------------------------------------------------------*/
INSERT INTO dbo.Request(ClientsName, ClientsSurname, ClientsEmailAddress, Description, RequestType, StateType, PaymentType, Date, Importance, RepairerId, BillName, NotificationId, ReportId)
VALUES ('Clark', 'Peterson', 'clark@gmail.com', 'Equipment name :123456', 1, 0, 'Cash', '2022-06-18', 0, NULL, NULL, NULL, NULL)

INSERT INTO dbo.Request(ClientsName, ClientsSurname, ClientsEmailAddress, Description, RequestType, StateType, PaymentType, Date, Importance, RepairerId, BillName, NotificationId, ReportId)
VALUES ('Smith', 'Yurk', 'smith@gmail.com', 'Equipment name :123456', 1, 0, 'Check', '2022-04-22', 0, NULL, NULL, NULL, NULL)

INSERT INTO dbo.Request(ClientsName, ClientsSurname, ClientsEmailAddress, Description, RequestType, StateType, PaymentType, Date, Importance, RepairerId, BillName, NotificationId, ReportId)
VALUES ('Clark', 'Peterson', 'clark@gmail.com', 'Equipment name :123456', 1, 0, 'Cash', '2022-05-15', 0, NULL, NULL, NULL, NULL)

INSERT INTO dbo.Request(ClientsName, ClientsSurname, ClientsEmailAddress, Description, RequestType, StateType, PaymentType, Date, Importance, RepairerId, BillName, NotificationId, ReportId)
VALUES ('Smith', 'Yurk', 'smith@gmail.com', 'Equipment name :123456', 1, 0, 'Card', '2022-05-15', 0, NULL, NULL, NULL, NULL)

INSERT INTO dbo.Request(ClientsName, ClientsSurname, ClientsEmailAddress, Description, RequestType, StateType, PaymentType, Date, Importance, RepairerId, BillName, NotificationId, ReportId)
VALUES ('Smith', 'Yurk', 'smith@gmail.com', 'Equipment name :123456', 1, 0, 'Card', '2022-05-16', 0, NULL, NULL, NULL, NULL)

/*---------------------------------------------------------------*/
INSERT INTO dbo.Material (Name, Price, EarningPercentage)
VALUES ('Thermal paste', 1500.0, 10.0)

INSERT INTO dbo.Material (Name, Price, EarningPercentage)
VALUES ('Capacitor 1cm-length', 120.0, 20.0)

INSERT INTO dbo.Material (Name, Price, EarningPercentage)
VALUES ('Capacitor 2cm-length', 120.0, 20.0)

INSERT INTO dbo.Material (Name, Price, EarningPercentage)
VALUES ('VGA', 700.0, 60.0)

INSERT INTO dbo.Material (Name, Price, EarningPercentage)
VALUES ('PCI Express', 600.0, 90.0)

INSERT INTO dbo.Material (Name, Price, EarningPercentage)
VALUES ('CoolerMaster housing-diameter 50cm', 5000.0, 30.0)

INSERT INTO dbo.Material (Name, Price, EarningPercentage)
VALUES ('CoolerMaster power supply- 1000W', 12000.0, 20.0)

INSERT INTO dbo.Material (Name, Price, EarningPercentage)
VALUES ('nVidia GeForce GTX 1650', 40000.0, 15.0)

INSERT INTO dbo.Material (Name, Price, EarningPercentage)
VALUES ('Spire 5mm', 50.0, 100.0)

INSERT INTO dbo.Material (Name, Price, EarningPercentage)
VALUES ('Screw ambrovit 4x50/60', 15.0, 100.0)