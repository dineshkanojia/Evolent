*********************** Project Specification *********************** 

This Project done using Visual Studio 2015 community and SQL Server 2008

*********************** Download ***********************

Downloand this project from Github
Restore the DBBackup.bkp file in SQL Server Management Tool this will create the required DB and Tables for this project.
Execute the DBScript.sql file which create the sample records for initial testing.

	
*********************** Steps to follow ***********************

Once project is downloaded and open in respected Visual Studio IDE
need to update the Entity Frame Work from ServerExplorer tool with your Database connectionstring it will update the connection string in web.config file.
It might required to change the port number for service call.
If case project fail to execute and retunr error message "port is already in use" in this need to change the port

***** Steps to chang port number ***** 

1. Right click on Assignment project from solution explorer.
2. Navigate to Web section from left panel.
3. Under Project URL textbox set the port number which is not in use.
4. Save the chnages.
5. Build and Run the project.



************************ Unit Test project ************************

Also need to update the Entity Frame Work from ServerExplorer tool with your Database connectionstring it will update the connection string in app.config file of TestProject.

