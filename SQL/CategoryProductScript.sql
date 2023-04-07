select Product.Name as 'Product', 
CASE WHEN ProductId IS NULL THEN '' ELSE Category.Name END AS 'Category' 
from Product
left join ProductCategory on ProductId=Product.Id
left join Category on CategoryId=Category.Id