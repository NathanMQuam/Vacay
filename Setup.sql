
-- NOTE: Vacations
-- CREATE TABLE vacations
-- (
--    Id VARCHAR(255) NOT NULL,
--    Type VARCHAR(255),
--    Name VARCHAR(255) NOT NULL,
--    Description VARCHAR(255),
--    Price int NOT NULL,

--    PRIMARY KEY (Id)
-- );

-- INSERT INTO vacations
-- VALUES ("1", "Hotel", "A Dovah's Slumber", "Requested the attic room as instructed by the holder of The Horn of Jurgen Windcaller", 5);



-- NOTE: Hotels
-- CREATE TABLE hotels
-- (
--    Id VARCHAR(255) NOT NULL,
--    Location VARCHAR(255),

--    PRIMARY KEY (Id),
--    FOREIGN KEY (Id) REFERENCES vacations(Id)
-- );

-- INSERT INTO hotels
-- VALUES ("1", "Riverwood, The Sleeping Giant Inn");



-- NOTE: Tours
-- CREATE TABLE tours
-- (
--    Id VARCHAR(255) NOT NULL,
--    Itinerary VARCHAR(255),

--    PRIMARY KEY (Id),
--    FOREIGN KEY (Id) REFERENCES vacations(Id)
-- );

-- INSERT INTO vacations
-- VALUES ("2", "Tour", "NYC and DC", "A tour of some of the most famous landmarks in New York City and Washington D.C.", 1500);

-- INSERT INTO tours
-- VALUES ("2", "Time's Square, the Empire State building, the Statue of Liberty...");



-- NOTE: Cruises
-- CREATE TABLE cruises
-- (
--    Id VARCHAR(255) NOT NULL,
--    Ship VARCHAR(255),

--    PRIMARY KEY (Id),
--    FOREIGN KEY (Id) REFERENCES tours(Id)
-- );

-- INSERT INTO vacations
-- VALUES ("3", "Cruise", "Around the world!", "Harder, Better, Faster, Stronger", 2500);

-- INSERT INTO tours
-- VALUES ("3", "America, South America, Europe...");

-- INSERT INTO cruises
-- VALUES ("3", "The USS idk...");

-- SELECT * FROM vacations;
-- SELECT * FROM hotels;
-- SELECT * FROM tours;
-- SELECT * FROM cruises;

SELECT * FROM vacations
INNER JOIN hotels ON vacations.Id = hotels.Id;