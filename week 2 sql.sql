CREATE DATABASE transtest;

USE transtest;


CREATE TABLE concurrency test (cid INTEGER, cdesc VARCHAR(15));
INSERT INTO concurrency test
VALUES(1, 'First Record');
INSERT INTO concurrency_test 
VALUES (2, "Second Record");
SELECT * FROM concurrency_test;

SELECT * FROM concurrency_test;
