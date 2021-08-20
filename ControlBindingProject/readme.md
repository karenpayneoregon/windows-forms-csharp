# About

Shows one method to update a TextBox from two different list of strings. Note we can also do this with concrete classes such as FirstName and LastName classes included but see no reason to here.

![img](assets/figure1.png)


Mocked arrays where generated using SSMS sending output to text rather than a grid

```sql
SELECT TOP (5) STRING_AGG('"' + r.FirstName + '"', ',') FROM (SELECT DISTINCT TOP (100) FirstName FROM NorthWind2020.dbo.Contacts) AS r
SELECT TOP (5) STRING_AGG('"' + r.LastName + '"', ',') FROM (SELECT DISTINCT TOP (100) LastName FROM NorthWind2020.dbo.Contacts) AS r
```
