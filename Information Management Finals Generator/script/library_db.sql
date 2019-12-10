DROP DATABASE IF EXISTS library_db;

CREATE DATABASE library_db;

CREATE TABLE library_db.publishers(
	id				INT(6) NOT NULL AUTO_INCREMENT,
    first_name 		VARCHAR(24) NOT NULL,
    middle_name 	VARCHAR(24) DEFAULT NULL,
    last_name 		VARCHAR(24) NOT NULL,
    date_created	TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    last_updated	TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    PRIMARY KEY(id)
);

CREATE TABLE library_db.authors(
	id				INT(6) NOT NULL AUTO_INCREMENT,
    first_name 		VARCHAR(24) NOT NULL,
    middle_name 	VARCHAR(24) DEFAULT NULL,
    last_name 		VARCHAR(24) NOT NULL,
    date_created	TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    last_updated	TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    PRIMARY KEY(id)
);

CREATE TABLE library_db.members(
	id				INT(6) NOT NULL AUTO_INCREMENT,
    first_name 		VARCHAR(24) NOT NULL,
    middle_name 	VARCHAR(24) DEFAULT NULL,
    last_name 		VARCHAR(24) NOT NULL,
    street			VARCHAR(64) DEFAULT NULL,
    province		VARCHAR(64) DEFAULT 'Capiz',
    city			VARCHAR(24) DEFAULT 'Roxas City',
    zip				VARCHAR(12) DEFAULT '5800',
    date_created	TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    last_updated	TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    PRIMARY KEY(id)
);

CREATE TABLE library_db.category(
	id				INT(6) NOT NULL AUTO_INCREMENT,
    `name`			VARCHAR(24) NOT NULL,
    date_created	TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    last_updated	TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    PRIMARY KEY(id)
);

CREATE TABLE library_db.books(
	id				INT(6) NOT NULL AUTO_INCREMENT,
    isbn			VARCHAR(24) NOT NULL,
    title			VARCHAR(254) NOT NULL,
    abstract		VARCHAR(254) DEFAULT NULL,
    date_created	TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    last_updated	TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    category_id		INT(6) DEFAULT NULL,
    publisher_id	INT(6) DEFAULT NULL,
    PRIMARY KEY(id),
    FOREIGN KEY(category_id) REFERENCES library_db.category(id) ON DELETE SET NULL,
    FOREIGN KEY(publisher_id) REFERENCES library_db.publishers(id) ON DELETE SET NULL
);

CREATE TABLE library_db.book_authors(
	id				INT(6) NOT NULL AUTO_INCREMENT,
    book_id			INT(6) NOT NULL,
    author_id		INT(6) NOT NULL,
    date_created	TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    last_updated	TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    PRIMARY KEY(id),
    FOREIGN KEY(book_id) REFERENCES library_db.books(id) ON DELETE CASCADE,
    FOREIGN KEY(author_id) REFERENCES library_db.authors(id) ON DELETE CASCADE
);

CREATE TABLE library_db.transactions(
	id				INT(6) NOT NULL AUTO_INCREMENT,
    tran_date		TIMESTAMP NOT NULL,
    tran_type		VARCHAR(24) NOT NULL,
    date_created	TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    last_updated	TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    book_id			INT(6) NOT NULL,
    member_id		INT(6) NOT NULL,
    PRIMARY KEY(id),
    FOREIGN KEY(book_id) REFERENCES library_db.books(id) ON DELETE CASCADE,
    FOREIGN KEY(member_id) REFERENCES library_db.members(id) ON DELETE CASCADE
);

CREATE TABLE library_db.accounts(
	id				INT(6) NOT NULL AUTO_INCREMENT,
    username		VARCHAR(16) NOT NULL,
    `password`		VARCHAR(52) NOT NULL,
    role			VARCHAR(16) NOT NULL,
    date_created	TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    last_updated	TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    PRIMARY KEY(id)
);

INSERT INTO library_db.accounts(
username, `password`, role) VALUES
('admin', MD5('admin'), 'Administrator'),
('user', MD5('user'), 'User');


INSERT INTO library_db.authors(first_name,middle_name,last_name)
VALUES
('John','Ocean','McDavis'),
('Douglas','','Smith'),
('Mark','Peterson','Smith'),
('Cassius','','Juicy'),
('Karen','Kyle','Carrey'),
('David','Zane','Blake'),
('Lucy','Hu','Lee'),
('Harvey','Carter','Zoe');


INSERT INTO library_db.category(`name`)
VALUES
('Database'),
('Programming'),
('Web Development'),
('Communication'),
('Analytics');

INSERT INTO library_db.publishers(first_name,middle_name,last_name)
VALUES
('Garret','Bindy','Scarlet'),
('Tilly','Carl','Rowley'),
('Oswald','Bessie','Lorn'),
('Clint','Alivia','Wynonna'),
('Jeremy','Earnest','Corina'),
('Bennie','Randolph','Ora');


INSERT INTO library_db.books(isbn,title,abstract,category_id,publisher_id)
VALUES
('4730','SQL Tutorials','Sept. 29 (Bloomberg) -- NATO Secretary General Anders Fogh Rasmussen said nations waging the war in Afghanistan must change their tactics and promote successes or risk losing public support there and at home. 
“Reaching our goal in Afghanistan is not guaranteed,” Rasmussen told an audience at the Atlantic Council policy group in Washington yesterday. More troops will be needed at least to train the Afghan National Security Forces, Rasmussen said, while cautioning that a revised strategy must be agreed upon before decisions are made about the additional resources.','1','4'),
('4731','Database Management System','A single high reading does not necessarily mean that you have high blood pressure. However, if readings stay at 140/90 mm Hg or above (systolic 140 or above OR diastolic 90 or above) over time, your doctor will likely want you to begin a treatment program. Such a program almost always includes lifestyle changes and often prescription medication for those with readings of 140/90 or higher.','1','4'),
('4732','PHP Dummy','The North Atlantic Treaty Organization leads the 41-nation military campaign in Afghanistan, where the Taliban regime shielded al-Qaeda before being ousted by the U.S. after the Sept. 11, 2001, terrorist attacks. The U.S. has 65,000 troops in the country, with the remainder of the 103,000-strong foreign force contributed by NATO members and other allies.','2','3'),
('4733','VB .NET Beginners','The top commander in the war, U.S. Army General Stanley McChrystal, recently submitted an assessment of the security situation in the country that recommends even more emphasis on protecting the population to make room for the countryâ€™s development. He concluded he would need more forces to carry out the strategy than the 68,000 the U.S. expects to have in Afghanistan by the end of the year. 

Leaders of the nations fighting in Afghanistan must speak out more about the successes achieved in the eight years of the war to win back public support, Rasmussen said.','2','3'),
('4734','SQL Today','He cited 7 million Afghan students in school, one-third of them girls, and that millions of citizens were able to vote in the nationâ€™s presidential election last month in the face of threats from the Taliban. 

Fraud Allegations ','2','6'),
('4735','Programming Technique','He cited 7 million Afghan students in school, one-third of them girls, and that millions of citizens were able to vote in the nationâ€™s presidential election last month in the face of threats from the Taliban. 

Fraud Allegations 

The election results remain in dispute because of fraud allegations. Rasmussen said he agreed that the NATO-led alliance needs a “credible and legitimate government in Afghanistan.” 

Some administration officials and members of Congress, who question whether the U.S. should step up its involvement as McChrystal recommends, cite the risk that the fraud allegations could erode the strength of the Afghan government.','2','3'),
('4736','HTML','“Talking down the European and Canadian contributions as some here in the United States have done can become a self- fulfilling prophecy,” Rasmussen said. 

To contact the reporter on this story: Viola Gienger in Washington at vgienger@bloomberg.net .','3','6'),
('4737','English Now and Today','Yes actually I want the output in similar fashion as u understood. Besides these two tables o/p will have data from some labels, textboxes & combo boxes before as well as after the tables, i.e. some data before tables then tables then some data after tables.
Actually I have some data file with different ID for each record, for each ID have some data in two tables.
OK I am attaching a .zip file of .mdb file having three tabels. u can understand from this .mdb file.
If u help me for the problem as u understood, I think I could proceed further.
Thanks.','4','2'),
('4738','Communication Arts','No actually I want the output in similar fashion as u understood. Besides these two tables o/p will have data from some labels, textboxes & combo boxes.','4','1'),
('4739','PHP and MySQL','Your healthcare providers will want to get an accurate picture of your blood pressure and chart what happens over time. Your blood pressure rises with each heartbeat and falls when your heart relaxes between beats. While BP can change from minute to minute with changes in posture, exercise, stress or sleep, it should normally be less than 120/80 mm Hg (less than 120 systolic AND less than 80 diastolic) for an adult age 20 or over.','2','4');

INSERT INTO library_db.book_authors(book_id,author_id)
VALUES
('1','1'),
('2','1'),
('2','2'),
('3','3'),
('4','4'),
('5','5'),
('6','1'),
('7','6'),
('8','7'),
('9','7'),
('10','1'),
('10','3'),
('10','2');



