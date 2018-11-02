В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.
 
CREATE TABLE Categories (id uniqueidentifier NOT NULL PRIMARY KEY, name nvarchar(256) NOT NULL unqiue)
 
CREATE TABLE Products (id uniqueidentifier NOT NULL PRIMARY KEY, name nvarchar(256) NOT NULL UNIQUE)
 
CREATE TABLE ProductsCategories
(
product_id uniqueidentifier,
categoryId uniqueidentifier,
FOREIGN KEY (product_id) REFERENCES Products(id),
FOREIGN KEY (category_id) REFERENCES Categories (id),
CONSTRAINT PK_ProductsCategories PRIMARY KEY (product_id,category_id)
)
 
SELECT p.name, c.name FROM
    products p LEFT OUTER JOIN productscategories pc ON p.id = pc.product_id
    LEFT JOIN categories c ON c.id = pc.category_id