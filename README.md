# ShapesLib
Тестовое задание Mindbox

## Задача №1
Смотри код

## Задача №2
Предположим что у нас есть следующая структура таблиц:

CREATE TABLE Products (
    ProductID INT IDENTITY(1,1) PRIMARY KEY,
    ProductName NVARCHAR(100) NOT NULL
);

CREATE TABLE Categories (
    CategoryID INT IDENTITY(1,1) PRIMARY KEY,
    CategoryName NVARCHAR(100) NOT NULL
);

CREATE TABLE   
 ProductCategories (
    ProductID INT FOREIGN KEY REFERENCES Products(ProductID),
    CategoryID INT FOREIGN KEY REFERENCES Categories(CategoryID),   
    PRIMARY KEY (ProductID, CategoryID)   

);

Таблица ProductCategories нужна для реалищации связи многие-ко-многим между таблицами Products и Categories.
Тогда запрос для выбора всех пар «Имя продукта – Имя категории» (если у продукта нет категорий, то его имя все равно должно выводиться) будет:

SELECT p.ProductName, c.CategoryName
FROM Products p
LEFT JOIN ProductCategories pc ON p.ProductID = pc.ProductID
LEFT JOIN Categories c ON pc.CategoryID = c.CategoryID;
