-- CREATE DATABASE Sales

-- CREATE TABLE salespeople_db(snum INT, sname varchar(10), city varchar(10), comm decimal(3,2));

-- CREATE TABLE customers_db(cnum INTEGER, cname varchar(10), city varchar(10), rating INTEGER, snum INTEGER);

-- CREATE TABLE orders_db(onum INTEGER, amt decimal(7,2), odate date, cnum INTEGER, snum INTEGER);

-- INSERT INTO salespeople_db VALUES(1001, 'Peel', 'London', 0.12);
-- INSERT INTO salespeople_db VALUES(1002, 'Serres', 'San Jose', 0.13);
-- INSERT INTO salespeople_db VALUES(1004, 'Motika', 'London', 0.11);
-- INSERT INTO salespeople_db VALUES(1007, 'Rifkin', 'Barcelona', 0.15);
-- INSERT INTO salespeople_db VALUES(1003, 'Axelrod', 'New York', 0.10);

-- INSERT INTO customers_db VALUES(2001, 'Hoffman', 'London', 100, 1001);
-- INSERT INTO customers_db VALUES(2002, 'Giovanni', 'Rome', 200, 1003);
-- INSERT INTO customers_db VALUES(2003, 'Liu', 'San Jose', 200, 1002);
-- INSERT INTO customers_db VALUES(2004, 'Grass', 'Berlin', 300, 1002);
-- INSERT INTO customers_db VALUES(2006, 'Clemens', 'London', 100, 1001);
-- INSERT INTO customers_db VALUES(2008, 'Cisneros', 'San Jose', 300, 1007);
-- INSERT INTO customers_db VALUES(2007, 'Pereira', 'Rome', 100, 1004);

-- INSERT INTO orders_db VALUES(3001,18.69,'1990-10-03', 2008, 1007);
-- INSERT INTO orders_db VALUES(3003,767.19,'1990-10-03', 2001, 1001);
-- INSERT INTO orders_db VALUES(3002,1900.10,'1990-10-03', 2007, 1004);
-- INSERT INTO orders_db VALUES(3005,5160.45,'1990-10-03', 2003, 1002);
-- INSERT INTO orders_db VALUES(3006,1098.16,'1990-10-03', 2008, 1007);
-- INSERT INTO orders_db VALUES(3009,1713.23,'1990-10-04',2002, 1003);
-- INSERT INTO orders_db VALUES(3007,75.75,'1990-10-04',2004, 1002);
-- INSERT INTO orders_db VALUES(3008,4723.00,'1990-10-04',2006, 1001);
-- INSERT INTO orders_db VALUES(3010,309.95,'1990-10-04',2004, 1002);
-- INSERT INTO orders_db VALUES(3011,9891.88,'1990-10-04',2006, 1001);

-- SELECT * from salespeople_db
-- SELECT * FROM customers_db
-- SELECT * FROM orders_db


-- assignment 3

-- solve following queries using sales database

-- Write a query that produces all rows from the Customers table for which the salesperson’s number
-- is 1001
-- SELECT * FROM customers_db WHERE snum = 1001;

-- Write a select command that produces the rating followed by the name of each customer in San Jose
-- SELECT cname, rating FROM  customers_db WHERE city = 'San Jose'

-- Write a query that will produce the snum values of all salespeople from the Orders table (with the
-- duplicate values suppressed)
-- SELECT distinct snum from orders_db;

-- Write a query that will give you all orders for more than Rs. 1,000
-- Select * from orders_db WHERE amt >=1000;

-- Write a query that will give you the names and cities of all salespeople in London with a
-- commission above 0.10
-- SELECT sname, city from salespeople_db WHERE comm >=0.10 AND city='London';

-- Write a query on the Customers table whose output will exclude all customers with a rating <=
-- 100, unless they are located in Rome
-- SELECT * from customers_db WHERE rating > 100 OR city = 'Rome';

-- What will be the output from the following query? Select * from Orders
-- where (amt < 1000 OR
-- NOT (odate = ‘1990-10-03’
-- AND cnum > 2003));

-- What will be the output of the following query?
-- Select * from Orders
-- where NOT ((odate = ‘1990-10-03’ OR snum >1006) AND amt >= 1500)

-- Write a query that selects all orders except those with zeroes or NULLs in the amt field.
-- SELECT * FROM orders_db WHERE NOT (amt = '0' OR amt = 'null');

-----------------------------------------------------------------------------------------------------------------------------------

--Assgnment 6

-- To solve below queries use “sales” database

-- Write a query that counts the number of salespeople registering orders for each day. (If a
-- salesperson has more than one order on a given day, he or she should be counted only once.).
-- SELECT odate,snum,COUNT(*) FROM orders_db GROUP BY odate,snum ;

-- Write a query on the Customers table that will find the highest rating in each city. Put the output in
-- this form:
-- For the city (city), the highest rating is : (rating).
-- SELECT city,MAX(rating) FROM customers_db GROUP BY city;

-- Write a query that totals the orders for each day and places the results in descending order.
-- select sum(amt) as amt,odate from orders_db group by odate order by amt desc;

-- Write a query that selects the total amount in orders for each salesperson for whom this total is
-- greater than the amount of the largest order in the table.
-- SELECT sum(amt) FROM orders_db GROUP BY snum HAVING sum(amt)> (SELECT max(amt)FROM orders_db);

-- Write a query that selects the highest rating in each city.
-- SELECT max(rating) "highest rating" FROM customers_db;

-- Largest order taken by each salesperson with order value more than Rs.3000. 7. Select each
-- customer smallest order.
-- Select odate, snum, max(amt) from orders_db where amt > 3000 group by odate, snum order by odate,snum;





-----------------------------------------------------------------------------------------------------------------------------------------
-- assignment 7

-- To solve below queries use “sales” database

-- Write a query that lists each order number followed by the name of the customer who made the
-- order.
-- SELECT orders_db.onum, customers_db.cname
-- FROM orders_db, customers_db
-- WHERE orders_db.cnum = customers_db.cnum;


-- Write a query that gives the names of both the salesperson and the customer for each order along
-- with the order number.
-- SELECT sname, cname, onum FROM orders_db o, customers_db c, salespeople_db s WHERE o.snum=c.snum AND o.snum=s.snum;


-- Write a query that produces all customers serviced by salespeople with a commission above 12%.
-- Output the customer’s name, the salesperson’s name, and the salesperson’s rate of commission.
-- SELECT customers_db.cname AS "Customer", customers_db.city AS "City",salespeople_db.sname AS "Salesman",
-- salespeople_db.comm FROM customers_db,salespeople_db
-- WHERE customers_db.snum = salespeople_db.snum AND salespeople_db.comm > .12 ;


-- Write a query that calculates the amount of the salesperson’s commission on each order by a
-- customer with a rating above 100.
-- select o.amt,o.cnum,c.rating,c.snum,s.sname,s.comm,o.amt*s.comm from orders_db o,customers_db c,salespeople_db s 
-- where o.cnum=c.cnum and c.snum=s.snum and c.rating>100;

-- Write a query that produces all pairs of salespeople who are living in the same city.Exclude
-- combinations of salespeople with themselves as well as duplicate rows with the order reversed
-- SELECT m.sname, n.sname, m.city FROM salespeople_db m, salespeople_db n
-- WHERE m.city=n.city AND m.sname<n.sname;




-------------------------------------------------------------------------------------------------------------------------------------------
-- assignment 8

-- To solve below queries use "sales" database

-- Write a query that uses a subquery to obtain all orders for the customer named Cisneros. Assume
-- you do not know his customer number (cnum).
-- SELECT onum "ALL ORDERS", cnum
-- FROM orders_db WHERE cnum= (SELECT cnum FROM customers_db WHERE cname='cisneros');

-- Write a query that produces the names and ratings of all customers who have above- average
-- orders.
-- SELECT cname, rating FROM customers_db WHERE cnum IN 
-- (SELECT cnum FROM orders_db WHERE amt > (SELECT avg(amt) FROM orders_db));

-- Write a query that selects the total amount in orders for each salesperson for whom this total is
-- greater than the amount of the largest order in the table.
-- SELECT sum(amt) FROM orders_db GROUP BY snum
-- HAVING sum(amt)> (SELECT max(amt) FROM orders_db);

-- Write a query that selects all customers whose ratings are equal to or greater than ANY of Serres.
-- SELECT * FROM customers_db WHERE rating >=ANY
-- ( SELECT rating FROM customers_db WHERE snum IN ( SELECT snum FROM salespeople_db WHERE sname='serres' ) );

-- Write a query using ANY or ALL that will find all salespeople who have no customers located in
-- their city.
-- SELECT * FROM customers_db WHERE rating >=ANY( SELECT rating FROM customers_db
--  WHERE snum IN ( SELECT snum FROM salespeople_db WHERE sname='serres' ) );

-- Write a query that selects all orders for amounts greater than any for the customers in London.
-- SELECT * FROM orders_db WHERE amt> ANY( SELECT amt FROM orders_db
-- WHERE cnum IN ( SELECT cnum FROM customers_db WHERE city='london' ) )

-- Extract all the orders of Motika.
-- Select onum from orders_db	where snum = ( select snum from salespeople_db where sname = 'Motika'); 

-- Find all the order attribute to salespeople servicing customers in London.
-- Select snum, cnum  from orders_db where cnum in (select cnum  from customers_db where city = 'London'); 

-- Find names and numbers of all salesperson who have more than one customer. 10. Find
-- salespeople number,name and city who have multiple customers.
-- SELECT snum,sname FROM salespeople_db s 
-- WHERE 1 < (SELECT COUNT(*)  FROM customers_db  WHERE snum=s.snum)

-- Select customers who have a greater rating than any other customer in Rome.
-- Select c.cname from customers_db c where city = 'Rome' 
-- and rating > ( select max(rating) from customers_db where city != 'Rome');


-- Select all orders that had amounts that were greater that at least one of the orders from ‘1990-10-04’ .
-- SELECT * FROM orders_db WHERE amt > ANY 
-- (SELECT amt FROM orders_db	WHERE  odate='1990/10/04');


-- Find all orders with amounts smaller than any amount for a customer in San Jose. 
-- SELECT * FROM orders_db WHERE amt < ANY 
-- (SELECT amt FROM orders_db a, customers_db b 
-- WHERE  a.cnum=b.cnum AND b.city='San Jose');

-- Select those customers whose rating are higher than every customer in Paris.
-- SELECT * FROM customers_db WHERE rating > ALL
-- (SELECT rating FROM customers_db WHERE city='Paris');



--------------------------------------------------------------------------------------------------------------------------------------

-- assignment 9

-- use "sales" database to solve below queries.

-- Create an index that will enable a user to pull orders for ‘1990-10-03’ out of the Orders table quickly.
-- CREATE INDEX indextwo on orders_db (odate);
-- SELECT odate from orders_db where odate = '1990-10-03';

-- If the Orders table has already been created, how can you force the onum field to be unique
-- (assume all current values are unique)?
-- SELECT distinct onum from orders_db;

-- Create an index that would permit salesperson to retrieve his orders.
-- CREATE INDEX o_index on orders_db (onum, odate);

-- Let us assume that each salesperson is to have only one customer of a given rating, and that this is
-- currently the case. Create an index that enforces it.
-- CREATE INDEX sales_index on customers_db(rating, snum);

-- Create an index to speed up searching order on a given date by given customer.
-- CREATE INDEX order_index on orders_db (onum);