delete from [Transaction]


declare @i as int
set @i = 0
while @i < 50000000
begin


insert into [Transaction](Id, Successful, Way, DateKey, CarId, AtmId)
values (@i,
cast(ROUND(RAND(), 0) as bit),
case when cast(ROUND(RAND(), 0) as bit) = 1
		then 'I'
		else 'O'
			end,
(select top 1 DateKey from CalendarDimension where (ABS(CAST(
				(Rand()) as int)) < 10)),
(select top 1 Id from Car where (ABS(CAST(
				(Rand()) as int)) < 10)),
(select top 1 Code from ATM where (ABS(CAST(
				(Rand()) as int)) < 10))
		)

set @i = @i + 1
select @i

end
