----------DATABASE CREATION----------
CREATE DATABASE AirportDB
GO
USE AirportDB 


----------TABLE CREATION----------
CREATE TABLE AIRLINEEMPLOYEE
	(ID 		INT				NOT NULL,
	 Fname 		VARCHAR(50) 	NOT NULL,
	 Lname 		VARCHAR(50) 	NOT NULL,
	 JobTitle	VARCHAR(50)		NOT NULL,
	 Airline	VARCHAR(50) 	NOT NULL,
	 PRIMARY KEY (ID)
	);
	
CREATE TABLE AIRLINE 
	(Name 		VARCHAR(50) 	NOT NULL,
	 Fare 		INT				NOT NULL,
	 City 		VARCHAR(50)		NOT NULL,
	 PRIMARY KEY (NAME)
	);
	
CREATE TABLE CITY
	(Name 		VARCHAR(50) 	NOT NULL,
	 Country    VARCHAR(50) 	NOT NULL,
	PRIMARY KEY (Name)
	);
	
CREATE TABLE CITYAIRPORTS
	(Airport 	VARCHAR(50)		NOT NULL,
	 City		VARCHAR(50)		NOT NULL,
	 PRIMARY KEY (Airport),
	 FOREIGN KEY (City) REFERENCES CITY (Name) ON UPDATE CASCADE ON DELETE CASCADE
	);
	
CREATE TABLE FLIGHT
	(FlightNo	CHAR(5)			NOT NULL,
	 ArrDep		BIT				NOT NULL,
     Time 		TIME 			NOT NULL,
	 City 		VARCHAR(50)		NOT NULL,
	 Airline	VARCHAR(50)		NOT NULL,
	 Terminal	CHAR(2),
	 Runway		VARCHAR(10),
	 PlaneType	VARCHAR(10)		NOT NULL,
	 PRIMARY KEY (FlightNo),
	 FOREIGN KEY (City) REFERENCES CITY (Name),
	 FOREIGN KEY (Airline) REFERENCES AIRLINE (Name)
	);
	
CREATE TABLE FLIGHTINSTANCE
	(InstanceNo VARCHAR(10)		NOT NULL,
	 Date		DATE			NOT NULL,
	 FlightNo	CHAR(5)			NOT NULL,
	 PRIMARY KEY (InstanceNo),
	 FOREIGN KEY (FlightNo) REFERENCES FLIGHT (FlightNo) ON UPDATE CASCADE ON DELETE CASCADE
	);
	
CREATE TABLE BOOKING
	(BookingPNR		CHAR(6)			NOT NULL,
	 Price 			INT				NOT NULL,
	 Class			CHAR(1)			NOT NULL,
	 FlightInstance VARCHAR(10),
	 PRIMARY KEY (BookingPNR),
	 FOREIGN KEY (FlightInstance) REFERENCES FLIGHTINSTANCE (InstanceNo) ON UPDATE CASCADE ON DELETE SET NULL
	);
	
CREATE TABLE PASSENGER 
	(Fname 		 VARCHAR(50)	NOT NULL,
	 Lname 		 VARCHAR(50) 	NOT NULL,
	 PassportNo	 CHAR(9)		NOT NULL,
	 Nationality VARCHAR(50)	NOT NULL,
	 Status 	 BIT			NOT NULL 	DEFAULT 1,
	 PRIMARY KEY (PassportNo)
	);
	
CREATE TABLE BOOKINGPASSENGER
	(BookingPNR CHAR(6)			NOT NULL,
	 PassportNo	CHAR(9)			NOT NULL,
	 Date 		DATE 			NOT NULL,
	 PRIMARY KEY (BookingPNR, PassportNo),
	 FOREIGN KEY (BookingPNR) REFERENCES BOOKING (BookingPNR) ON UPDATE CASCADE ON DELETE CASCADE,
	 FOREIGN KEY (PassportNo) REFERENCES PASSENGER (PassportNo) ON UPDATE CASCADE ON DELETE CASCADE
	);

CREATE TABLE TERMINAL
	(TerminalCode	CHAR(2)		NOT NULL,
	 NoOfGates		INT			NOT NULL,
	 Capacity		INT			NOT NULL,
	 PRIMARY KEY (TerminalCode)
	);
	
CREATE TABLE RUNWAY 
	(RunwayCode		VARCHAR(10)	NOT NULL,
	 Type			VARCHAR(50)	NOT NULL,
	 PRIMARY KEY (RunwayCode)
	);
	
CREATE TABLE PLANETYPE
	(Name 			VARCHAR(10)	NOT NULL,
	 Manufacturer	VARCHAR(50) NOT NULL,
	 Type			VARCHAR(50)	NOT NULL,
	 Capacity		INT			NOT NULL,
	 PRIMARY KEY (Name)
	);
	
CREATE TABLE AIRPORTEMPLOYEE
	(ID				INT			NOT NULL,
	 Fname			VARCHAR(50)	NOT NULL,
	 Lname 			VARCHAR(50) NOT NULL,
	 Salary			INT 		NOT NULL,
	 JobTitle 		VARCHAR(50)	NOT NULL,
	 Department		VARCHAR(50),
	 PRIMARY KEY (ID)
	);
	

CREATE TABLE AIRLINELOGININFO
	(ID				INT 		NOT NULL,
	 Username		VARCHAR(50)	NOT NULL,
	 Password   	VARCHAR(50)	NOT NULL,
	 PRIMARY KEY (Username),
	 FOREIGN KEY (ID) REFERENCES AIRLINEEMPLOYEE (ID) 
	);
	
CREATE TABLE AIRPORTLOGININFO
	(ID				INT 		NOT NULL,
	 LevelAccess	INT			NOT NULL,
	 Username		VARCHAR(50)	NOT NULL,
	 Password   	VARCHAR(50)	NOT NULL,
	 PRIMARY KEY (Username),
	 FOREIGN KEY (ID) REFERENCES AIRPORTEMPLOYEE (ID) 
	); 
	
CREATE TABLE GOVLOGINFO
	(ID				INT 		NOT NULL,
	 Name 			VARCHAR(50)	NOT NULL,
	 Password   	VARCHAR(50)	NOT NULL,
	 PRIMARY KEY (ID) 
	);	
	
----------FOREIGN KEYS----------	
ALTER TABLE AIRLINEEMPLOYEE ADD FOREIGN KEY (Airline) REFERENCES AIRLINE (Name) ON UPDATE CASCADE ON DELETE CASCADE;
ALTER TABLE AIRLINE ADD FOREIGN KEY (City) REFERENCES CITY (Name);
ALTER TABLE FLIGHT ADD FOREIGN KEY (Terminal) REFERENCES TERMINAL (TerminalCode) ON UPDATE CASCADE ON DELETE SET NULL;
ALTER TABLE FLIGHT ADD FOREIGN KEY (Runway) REFERENCES RUNWAY (RunwayCode) ON UPDATE CASCADE ON DELETE SET NULL;
ALTER TABLE FLIGHT ADD FOREIGN KEY (PlaneType) REFERENCES PLANETYPE (Name) ON UPDATE CASCADE ON DELETE CASCADE;

----------INSERTING VALUES INTO TABLES----------
INSERT INTO CITY
VALUES
('Paris','France'),
('London','UK'),
('Beijing','China'),
('Tokyo','Japan'),
('Chicago','USA'),
('Los Angeles','USA'),
('Dubai','UAE'),
('Frankfurt','Germany'),
('Denver','USA'),
('Singapore','Singapore'),
('Amsterdam','Netherlands'),
('New York','USA'),
('Madrid','Spain'),
('Shanghai','China'),
('Texas','USA'),
('Barcelona','Spain'),
('Toronto','Canada'),
('Orlando','USA'),
('Delhi','India'),
('Cairo','Egypt'),
('Doha','Qatar'),
('Vienna','Austria'),
('Helsinki','Finland'),
('Rome', 'Italy'),
('Sofia','Bulgaria'),
('Atlanta','USA');


INSERT INTO CITYAIRPORTS
VALUES
('Beijing International Airport','Beijing'),
('Los Angeles International Airport','Los Angeles'),
('Tokyo Haneda Airport','Tokyo'),
('Dubai International Airport','Dubai'),
('Cairo International Airport','Cairo'),
('O''Hare International Airport','Chicago'),
('London Heathrow Airport','London'),
('Shanghai Pudong International Airport','Shanghai'),
('Paris-Charles de Gaulle Airport','Paris'),
('Dallas/Fort Worth International Airport','Texas'),
('Amsterdam Airport Schiphol','Amsterdam'),
('Frankfurt Airport','Frankfurt'),
('Singapore Changi Airport','Singapore'),
('Denver International Airport','Denver'),
('Indira Gandhi International Airport','Delhi'),
('John F. Kennedy International Airport','New York'),
('Madrid Barajas Airport','Madrid'),
('Orlando International Airport','Orlando'),
('Barcelona–El Prat Airport','Barcelona'),
('Toronto Pearson International Airport','Toronto'),
('Sofia Airport','Sofia'),
('Hartsfield–Jackson Atlanta International Airport','Atlanta');


INSERT INTO AIRLINE
VALUES
('Qatar Airways',0,'Doha'),
('Singapore Airlines',0,'Singapore'),
('Japan Airlines',0,'Tokyo'),
('Emirates',0,'Dubai'),
('Lufthansa',0,'Frankfurt'),
('Austrian Airlines',0,'Vienna'),
('KLM',0,'Amsterdam'),
('British Airways',0,'London'),
('Egyptair',0,'Cairo'),
('Air France',0,'Paris'),
('Iberia',0,'Madrid'),
('Air Italy',0,'Rome'),
('Finnair',0,'Helsinki'),
('Bulgaria Air',0,'Sofia'),
('Delta Airlines',0,'Atlanta');


INSERT INTO PLANETYPE
VALUES
('A300','Airbus','Wide-body',266),
('A380','Airbus','Wide-body',868),
('A320','Airbus','Narrow-body',140),
('A330','Airbus','Wide-body',335),
('747','Boeing','Wide-body',660),
('737','Boeing','Narrow-body',120),
('777','Boeing','Wide-body',354),
('767','Boeing','Wide-body',250),
('SE210','Sud Aviation','Narrow-body',230);


INSERT INTO RUNWAY
VALUES
('01C','Wide-Body'),
('01L','Narrow-Body'),
('01R','Cargo'),
('22C','Wide-Body'),
('22L','Narrow-Body'),
('22R','Cargo'),
('15C','Narrow-Body'),
('15L','Wide-Body'),
('15R','Cargo'),
('18C','Narrow-Body'),
('18L','Cargo'),
('18R','Wide-Body'),
('33C','Wide-Body'),
('33L','Cargo'),
('33R','Narrow-Body'),
('12C','Wide-Body'),
('12L','Cargo'),
('12R','Narrow-Body');


INSERT INTO TERMINAL
VALUES
('1A',5,100000),
('1B',5,100000),
('2A',3,50000),
('2B',5,80000),
('3A',4,60000),
('3B',5,70000),
('4A',4,60000),
('4B',4,50000),
('5A',5,120000),
('5B',5,100000),
('6A',6,130000),
('6B',2,40000);


INSERT INTO FLIGHT
VALUES 
('QR134',1,'1:20','Doha','Qatar Airways','1A','01C','A380'),
('SQ320',0,'1:35','Singapore','Singapore Airlines','2A','22R','737'),
('JL632',1,'2:40','Tokyo','Japan Airlines','1B','01R','A300'),
('EK453',0,'3:50','Dubai','Emirates','5A','33C','A320'),
('LH754',1,'4:15','Frankfurt','Lufthansa','4A','18C','747'),
('BA610',0,'4:50','London','British Airways','6B','12R','777'),
('OS367',1,'6:10','Vienna','Austrian Airlines','6A','15L','A380');


INSERT INTO FLIGHTINSTANCE
VALUES
('QR134/135','2019-12-1','QR134'),
('SQ320/105','2019-12-2','SQ320'),
('GL632/126','2019-12-3','JL632'),
('EK453/116','2019-12-4','EK453'),
('LH754/133','2019-12-5','LH754'),
('BA610/187','2019-12-6','BA610'),
('OS367/155','2019-12-7','OS367'),
('QR134/163','2019-12-8','QR134'),
('SQ320/154','2019-12-9','SQ320'),
('GL632/177','2019-12-10','JL632'),
('EK453/188','2019-12-11','EK453'),
('LH754/135','2019-12-12','LH754'),
('BA610/105','2019-12-13','BA610'),
('QR134/177','2019-12-14','QR134'),
('SQ320/133','2019-12-15','SQ320'),
('GL632/116','2019-12-16','JL632'),
('EK453/138','2019-12-17','EK453'),
('LH754/115','2019-12-18','LH754'),
('BA610/112','2019-12-19','BA610'),
('OS367/190','2019-12-20','OS367');


INSERT INTO PASSENGER
VALUES
('Sebastian','King','P8W0QBIS6','American',1),
('Scarlett','Wright','CSZ6Y822X','Algerian',1),
('Aiden','Lopez','6W6XXTAH5','Australian',1),
('Victoria','Hill','81NMVAGEV','Austrian',1),
('Matthew','Scott','82DQ4X099','Belgian',1),
('Madison','Green','RYMV3A5A6','Bolivian',1),
('Samuel','Adams','GQ1VF4RS4','Brazilian',1),
('Luna','Baker','1GTVASER4','British',1),
('David','Gonzalez','I4HUS5ANC','Bulgarian',1),
('Grace','Nelson','NT1ZQ6O98','Chilean',1),
('Joseph','Carter','EZYCGA2AG','Chinese',1),
('Chloe','Mitchel','1B8G2U589','Colombian',1),
('Carter','Perez','KPPDW3UA3','Croatian',1),
('Penelope','Roberts','PWSAEQZN7','Dutch',1),
('Owen','Turner','RIQTDD1K0','Egyptian',1),
('Layla','Parker','Z08Q6INEJ','Danish',1),
('Wyatt','Campbell','1XKCBHDQ6','French',1),
('Riley','King','DG9UX9Q4G','Greek',1),
('John','Evans','A2SNG9LWH','Canadian',1),
('Nora','Edwards','6VICVISYO','Indian',1);


INSERT INTO BOOKING
VALUES
('K13PN7',600,'A','QR134/135'),
('I4PNM2',1200,'A','SQ320/105'),
('JUHFJ3',250,'B','GL632/126'),
('R9SXMJ',1200,'B','EK453/116'),
('PWFWJQ',550,'C','LH754/133'),
('K38W46',350,'C','BA610/187'),
('6U08GE',320,'A','OS367/155'),
('RVOUMM',760,'A','QR134/163'),
('XNDO7U',900,'B','SQ320/154'),
('Z2JP8N',450,'C','GL632/177');


INSERT INTO BOOKINGPASSENGER
VALUES
('K13PN7','P8W0QBIS6','2019-12-01'),
('I4PNM2','CSZ6Y822X','2019-12-02'),
('JUHFJ3','6W6XXTAH5','2019-12-03'),
('R9SXMJ','81NMVAGEV','2019-12-04'),
('PWFWJQ','82DQ4X099','2019-12-05'),
('K38W46','RYMV3A5A6','2019-12-06'),
('6U08GE','GQ1VF4RS4','2019-12-07'),
('RVOUMM','1GTVASER4','2019-12-08'),
('XNDO7U','I4HUS5ANC','2019-12-09'),
('Z2JP8N','NT1ZQ6O98','2019-12-10'),
('K13PN7','EZYCGA2AG','2019-12-11'),
('I4PNM2','1B8G2U589','2019-12-12'),
('JUHFJ3','KPPDW3UA3','2019-12-13'),
('R9SXMJ','PWSAEQZN7','2019-12-14'),
('PWFWJQ','RIQTDD1K0','2019-12-15'),
('K38W46','Z08Q6INEJ','2019-12-16'),
('6U08GE','1XKCBHDQ6','2019-12-17'),
('RVOUMM','DG9UX9Q4G','2019-12-18'),
('XNDO7U','A2SNG9LWH','2019-12-19'),
('Z2JP8N','6VICVISYO','2019-12-20');


INSERT INTO AIRLINEEMPLOYEE
VALUES
(504661102,'Liam','Smith','Manager','Egyptair'),
(847561717,'Emma','Johnson','Airline Station Agent','Egyptair'),
(844136681,'Noah','Williams','Passenger Service Agent','Egyptair'),
(677021548,'Olivia','Jones','Administrative Support','Egyptair'),
(876281477,'Oliver','Brown','Manager','Air France'),
(463194703,'Ava','Davis','Airline Station Agent','Air France'),
(505645876,'William','Miller','Passenger Service Agent','Air France'),
(531077956,'Isabella','Wilson','Administrative Support','Air France'),
(921485956,'James','Moore','Manager','British Airways'),
(361006010,'Sophia','Taylor','Airline Station Agent','British Airways'),
(414326238,'Elijah','Anderson','Passenger Service Agent','British Airways'),
(628359581,'Charlotte','Thomas','Administrative Support','British Airways'),
(526685708,'Benjamin','Jackson','Manager','KLM'),
(150032806,'Mia','White','Airline Station Agent','KLM'),
(450710433,'Lucas','Harris','Passenger Service Agent','KLM'),
(439610056,'Amelia','Martin','Administrative Support','KLM'),
(302608491,'Mason','Thompson','Manager','Emirates'),
(666841304,'Harper','Garcia','Airline Station Agent','Emirates'),
(564972709,'Logan','Martinez','Passenger Service Agent','Emirates'),
(396942915,'Evelyn','Robinson','Administrative Support','Emirates'),
(548195498,'Alexander','Clark','Manager','Lufthansa'),
(990340592,'Abigail','Rodriguez','Airline Station Agent','Lufthansa'),
(115682529,'Ethan','Lewis','Passenger Service Agent','Lufthansa'),
(435238446,'Emily','Lee','Administrative Support','Lufthansa'),
(952712751,'Jacob','Walker','Manager','Delta Airlines'),
(505051748,'Elizabeth','Hall','Airline Station Agent','Delta Airlines'),
(722867565,'Michael','Allen','Passenger Service Agent','Delta Airlines'),
(160955933,'Mila','Young','Administrative Support','Delta Airlines'),
(876003326,'Daniel','Eskandar','Manager','Iberia'),
(767793096,'Ella','Hernandez','Airline Station Agent','Iberia'),
(652539921,'Henry','King','Passenger Service Agent','Iberia'),
(373254899,'Avery','Wright','Administrative Support','Iberia');


INSERT INTO AIRPORTEMPLOYEE
VALUES
(611323604,'Jack','Collins',75000,'Manager','Management'),
(804399088,'Lily','Stewart',50000,'Manager','Engineering Department'),
(631749040,'Luke','Sanchez',55000,'Manager','Operations Department'),
(334291278,'Eleanor','Morris',70000,'Manager','Finance Department'),
(826928211,'Jayden','Rogers',40000,'Manager','Human Resource Management Department'),
(470134105,'Hannah','Reed',10000,'Avionics Technician','Engineering Department'),
(900880321,'Dylan','Cook',10000,'Avionics Technician','Engineering Department'),
(217266888,'Lillian','Morgan',10000,'Avionics Technician','Engineering Department'),
(429439440,'Grayson','Bell',10000,'Avionics Technician','Engineering Department'),
(601399130,'Addison','Murphy',10000,'Avionics Technician','Engineering Department'),
(481969048,'Levi','Bailey',12000,'Flight Dispatcher','Operations Department'),
(646776340,'Aubrey','Riveira',12000,'Flight Dispatcher','Operations Department'),
(790010194,'Isaac','Cooper',12000,'Flight Dispatcher','Operations Department'),
(847284124,'Ellie','Richardson',8000,'Aviation Meteorologist','Operations Department'),
(760851773,'Gabriel','Cox',8000,'Aviation Meteorologist','Operations Department'),
(520282309,'Stella','Howard',10000,'Accountant','Finance Department'),
(702882747,'Julian','Ward',10000,'Accountant','Finance Department'),
(829541062,'Natalie','Torres',10000,'Accountant','Finance Department'),
(855174251,'Mateo','Peterson',8000,'Recruiter','Human Resource Management Department'),
(526105652,'Zoe','Gray',8000,'Recruiter','Human Resource Management Department');


INSERT INTO AIRPORTLOGININFO
VALUES
(611323604,3,'jcollins','CQZPP5AZ'),
(804399088,3,'lilys','TWNKLRHR'),
(631749040,3,'lukesanch','6NLXD8BQ'),
(334291278,3,'elmorris','1CPVBQQM'),
(826928211,3,'jayrog','8DSBNADF'),
(470134105,2,'hannahr','TUZ9SP7P'),
(900880321,2,'dcook','UEKKVDWL'),
(217266888,2,'lilimorg','HQCEVYWJ'),
(429439440,2,'graybell','PBULI4GS'),
(601399130,2,'addisonm','VZ7N5U51'),
(481969048,2,'levibailey','TDLBA6GE'),
(646776340,2,'aubryr','EARTGHKF'),
(790010194,2,'cooperis','05708IUE'),
(847284124,2,'elrich','D9T6VHOW'),
(760851773,2,'gabcox','T5ZB4IQD'),
(520282309,1,'stellah','75ESVU2D'),
(702882747,1,'julianw','D0NNPD7J'),
(829541062,1,'natorres','NEDT8AS4'),
(855174251,1,'matpat','WXOP93YR'),
(526105652,1,'zgray','T961AXE2');


INSERT INTO AIRLINELOGININFO
VALUES
(504661102,'lsmith','2RK3E9Y5'),
(847561717,'emjohnson','YL7NLECY'),
(844136681,'noahwill','RHAEP20C'),
(677021548,'ojones','RNZFR57Q'),
(876281477,'obrown','VN6BSCEG'),
(463194703,'adavis','ZIZ9XUDY'),
(505645876,'willmiller','GAWK1QDU'),
(531077956,'isabelwilson','7EIBOX4L'),
(921485956,'jmoore','87B4T1NA'),
(361006010,'staylor','EHQK4NJA'),
(414326238,'elijaha','B08AGA4F'),
(628359581,'charlottetho','2D8VCAHG'),
(526685708,'benjack','9XQTXKXY'),
(150032806,'mwhite','BM6G5PH6'),
(450710433,'lukeharris','ZOGJ3KHG'),
(439610056,'ameliam','79HZACGI'),
(302608491,'masont','OP8JQ6N7'),
(666841304,'hgarcia','3W3TQNV3'),
(564972709,'lmartinez','B3EBCFI0'),
(396942915,'erobinson','GFSUFDID'),
(548195498,'alexclark','7YC6JN9Y'),
(990340592,'arodriguez','61LNPCEG'),
(115682529,'ethanlewis','Y9PV36X6'),
(435238446,'elee','GRIQAF6C'),
(952712751,'jwalker','77YIKKHM'),
(505051748,'elizabethhall','IMGSM40G'),
(722867565,'mikeallen','73B9XFKN'),
(160955933,'milayoung','4LNO7NQU'),
(876003326,'deskandar','9LRDZMWF'),
(767793096,'hernandez','J8QEK54T'),
(652539921,'hking','NCYPNZV6'),
(373254899,'averywright','2OMTJMME');


INSERT INTO GOVLOGINFO
VALUES
(373251211,'Bassem Elguindi','9Q1OI7T3YP'),
(373251221,'Hossam Mohamed','XFX2D4PXJ2'),
(373251231,'Abdelrahman Morsy','5BIQX4EDQJ'),
(373251241,'Enas Gohar','7HNIJU99UK'),
(373251251,'Omar Tarek','KDLU1YXKWL'),
(373251271,'Ahmed Abdulkader','CKTNCF0PU6'),
(373251281,'Osama Khatib','KHXWFIGXDW'),
(373251291,'Hazem Hassan','4A919BYIGO'),
(373251301,'Ahmed Shobeir','LGTLHNPBWK');