
UPDATE
    [Transaction]
SET
    AtmId =
	case when
		CAST(ROUND(RAND(),0) AS BIT) = 1
	then
		null
	else
    (
        SELECT TOP 1
            Id
        FROM
            ATM
        --	WHERE
        --		  Images.ProductId = Products.Id
        ORDER BY
            NEWID()
    )
	end
