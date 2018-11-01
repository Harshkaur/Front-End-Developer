We  have developed application using Angular 6 and .Net Webapi  and used SQL Server as database.

This application contains two projects

1) PMS- Angular 6 application - Currently we have only shown listing of products on the selection of Vendor.

While designing the database, We have assumed that One vendor will have multiple branches and product will be assoicated with one or more branch.
Same product can be sold by multiple vendors, with different rates
We have designed few more tables, which are currently not in use as per current scope.

2) PMSapi - This is webapi project, we are using EF Database approach for database interaction. Currently only Product controller is in use.


Please run npm install command to restore node modules

