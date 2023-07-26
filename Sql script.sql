--Таблица для продуктов
CREATE TABLE Product (
	ID INT PRIMARY KEY IDENTITY(1,1), 
	[NAME] VARCHAR(100) 
)

INSERT INTO Product (NAME) VALUES('Помидоры')
INSERT INTO Product (NAME) VALUES('Колбаса')
INSERT INTO Product (NAME) VALUES('Хлеб')
INSERT INTO Product (NAME) VALUES('Круассан')
INSERT INTO Product (NAME) VALUES('Молоко')
INSERT INTO Product (NAME) VALUES('Огурцы')

--Таблица для категорий 2
CREATE TABLE Category (
	ID INT PRIMARY KEY IDENTITY(1,1), 
	[NAME] VARCHAR(100) 
)

INSERT INTO Category (NAME) VALUES('Овощи')
INSERT INTO Category (NAME) VALUES('Мясные изделия')
INSERT INTO Category (NAME) VALUES('Выпечка')
INSERT INTO Category (NAME) VALUES('Десерты')

--Таблица для продуктов и категорий
CREATE TABLE CategoryOfProduct (
	idProduct INT REFERENCES Product(ID),
	idCategory INT REFERENCES Category(ID)
)

INSERT INTO CategoryOfProduct (idProduct,idCategory) VALUES (1, 1)
INSERT INTO CategoryOfProduct (idProduct,idCategory) VALUES (2, 2)
INSERT INTO CategoryOfProduct (idProduct,idCategory) VALUES (3, 3)
INSERT INTO CategoryOfProduct (idProduct,idCategory) VALUES (4, 4)
INSERT INTO CategoryOfProduct (idProduct,idCategory) VALUES (4, 3)
INSERT INTO CategoryOfProduct (idProduct,idCategory) VALUES (6, 1)

--Итоговый запрос
SELECT p.NAME [Продукт], 
	   c.NAME [Категория]
FROM Product AS p
LEFT JOIN CategoryOfProduct AS cop ON p.ID = cop.idProduct
LEFT JOIN Category AS c ON cop.idCategory = c.ID
ORDER BY p.NAME