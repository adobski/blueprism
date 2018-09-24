# blueprism
Blue Prism Test domain

Assumption
Data will be store in an SQL Database and repositories and services will provide data access to the objects. Retreiving Customers and Products. My main goal here was to provide the functionality around order processing

Created git repository and cloned to local drive.
Added a .gitignore
Created a new solution and created domain project and tests
checked in skeleton
Added additional nuget packages for tests
Added test for product
Created Product and added mock data to resolve failing test
Added test for customer
Added customer object
Created tests for order
Created Order, orderline and orderstatus objects
 
Questions
Is this a stand alone project or will it interface with .net 4.6 applications. This would allow me to make a decision on the project type to be used. In this instance I have made an assumption that it will not and as such will use .net core instead of .net standard

I would need to confirm at which point does the order status change so we could handle this behaviour.

Database design

Assuming this is a green field project We could implement a code first approach to data persistance using EntityFramework. In this case we would be able to design the database tables from the objects. This would be my prefered approach.

In relation to the design of the database

Customers
Id = PrimaryKey, Name, EmailAddress

Products
Id = PrimaryKey, Title, Description, DefaultPrice

Orders
Id = PrimaryKey, CustomerId = ForeignKey(Customers Id), Status, TotalDefaultCost, TotalActualCost

OrderLines
Id = PrimaryKey, OrderId FK(Orders Id), ProductId, FK(Products Id), Quantity, DefaultPrice, ActualPrice
