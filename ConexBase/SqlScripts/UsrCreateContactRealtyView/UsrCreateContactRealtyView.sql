create or alter view UsrVwContactRealtyM as
select Id as UsrId, Name as UsrName,
(select SUM(R.UsrPriceGBP) from UsrRealtyClassic as R 
where R.UsrManagerId = C.Id) / 1000000 as UsrPriceM,
Id as UsrContactId
from Contact C