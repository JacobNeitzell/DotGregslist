-- Active: 1666715462927@@SG-fossil-throne-24-6835-mysql-master.servers.mongodirector.com@3306@FossilThrone

CREATE TABLE
    IF NOT EXISTS cars(
        id int NOT NULL AUTO_INCREMENT PRIMARY KEY,
        make VARCHAR(255) NOT NULL,
        model VARCHAR(255) NOT NULL,
        year int NOT NULL CHECK (year >= 1886),
        price DECIMAL(10, 2) NOT NULL CHECK (price >= 0),
        description VARCHAR(255),
        imgUrl VARCHAR(255) DEFAULT "https://i.ebayimg.com/thumbs/images/g/ZYMAAOSwp7FaagAd/s-l640.jpg"
    );

INSERT INTO
    cars(
        make,
        model,
        year,
        price,
        description,
        imgUrl
    )
VALUES (
        "KFC",
        "Bucket",
        1985,
        999,
        "YUM YUM!!",
        "https://cdn.drawception.com/images/panels/2013/6-9/pTFwH3f1xS-8.png"
    );

SELECT * FROM cars;