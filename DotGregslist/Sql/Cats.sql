CREATE TABLE
    IF NOT EXISTS cats(
        id INT AUTO_INCREMENT PRIMARY KEY,
        name VARCHAR(255)
    );

INSERT INTO cats (name) VALUES ("Felix");

INSERT INTO cats (name) VALUES ("Garfield");

INSERT INTO cats (name) VALUES ("Sylvester");

INSERT INTO cats (name) VALUES ("Hobs");

INSERT INTO cats (name) VALUES ("Tony");

SELECT * FROM cats WHERE id = 3;

DROP TABLE cats;