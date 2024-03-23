---- Role(RoleID, RoleName)
--create table Role(
--    RoleID int IDENTITY(1,1) constraint PK_Role PRIMARY KEY,
--    Rolename varchar(255),
--);

---- Category(CatID, CatName)
--create table Category(
--    CatID int IDENTITY(1,1) constraint PK_Category PRIMARY KEY,
--    CatName varchar(255),
--);


---- User(UserID, Name, Username, Password, Phone, IsActive, Address, Birthdate, RoleID FK)
--create table Users(
--    UserID int IDENTITY(1,1) constraint PK_User PRIMARY KEY,
--    Name varchar(255) not null,
--    Username varchar(255) not null,
--    Password varchar(255) not null,
--    Phone varchar(255) not null,
--    IsActive bit default 1 not null,
--    Address varchar(255) not null,
--    Birthdate date not null,
--    RoleID int references Role(RoleID),
--    constraint CK_Phone check (Phone like '[0-9][0-9][0-9]-[0-9][0-9][0-9][0-9]-[0-9][0-9][0-9]'),
--    constraint CK_Birthdate check (Birthdate <= getdate())
--);


---- Product(ProductID, Quantity, Info_des, Status_des, Original_price, Sell_price, UploadedDate, CatID FK, UserID FK)
--create table Product(
--    ProductID int IDENTITY(1,1) constraint PK_Product PRIMARY KEY,
--    Quantity int not null,
--    Info_des varchar(255) not null,
--    Status_des varchar(255) not null,
--    Original_price float not null,
--    Sell_price float not null,
--    UploadedDate date not null,
--    CatID int references Category(CatID),
--    UserID int references Users(UserID),
--    constraint CK_Original_price check (Original_price > 0),
--    constraint CK_Sell_price check (Sell_price > 0),
--    constraint CK_Quantity check (Quantity > 0),
--    constraint CK_UploadedDate check (UploadedDate <= getdate())
--);

---- Images(ImageID, ProductID FK, ImageUrl)
--create table Images(
--    ImageID int IDENTITY(1,1) constraint PK_Images PRIMARY KEY,
--    ProductID int references Product(ProductID),
--    ImageUrl varbinary(max) not null
--);

---- User_Order(OrderID, UserID FK, Status, OrderDate)
--create table User_Order(
--    OrderID int IDENTITY(1,1) constraint PK_User_Order PRIMARY KEY,
--    UserID int references Users(UserID),
--    Status varchar(255) not null,
--    OrderDate date not null
--);

---- OrderDetail(OrderDetailID, OrderID FK, ProductID FK, Quantity)
--create table OrderDetail(
--    OrderDetailID int IDENTITY(1,1) constraint PK_OrderDetail PRIMARY KEY,
--    OrderID int references User_Order(OrderID),
--    ProductID int references Product(ProductID),
--    Quantity int check (Quantity > 0) not null,  
--);

INSERT INTO Category(CatName) VALUES ('Laptop');	
