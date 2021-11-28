SELECT P.ProductID, 
       P.ProductName, 
       P.SupplierID, 
       S.CompanyName, 
       P.CategoryID, 
       Cat.CategoryName, 
       P.QuantityPerUnit, 
       P.UnitPrice, 
       P.UnitsInStock, 
       P.UnitsOnOrder, 
       P.ReorderLevel, 
       P.Discontinued, 
       P.DiscontinuedDate, 
       C.Name
FROM Products AS P
     INNER JOIN Suppliers AS S ON P.SupplierID = S.SupplierID
     INNER JOIN Countries AS C ON S.CountryIdentifier = C.CountryIdentifier
     INNER JOIN Categories AS Cat ON P.CategoryID = Cat.CategoryID;