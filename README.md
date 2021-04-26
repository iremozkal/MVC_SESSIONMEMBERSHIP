## MVC_SESSIONMEMBERSHIP

Basic session membership structure with Asp.Net MVC4 using Code First approach.  
DATA Layer includes web role(1-Admin, 2-User) and web user entity models.  
DAL Layer includes context and migrations. WebRole and WebUser tables have been added from seed method to the database. The Configuration.cs Seed method will run every time your model changes to make sure that some specific data stays in your DB, or to even possibly to reset that data to a specified default setting.    
UI Layer includes the mvc web page. It has login and register view models. Their input fields are controlled with System.ComponentModel.DataAnnotations.
Login and Register operations successfully runs. After login, home page gives the admin/user panel according to web role of the user.

### Technologies  

+ Asp.Net Web Application with .Net Framework 4.5 
+ Entity Framework 6.4.4
+ Bootstrap 4.5.3
+ Jquery 3.5.1
+ Visual Studio 2012


### Usage

on DAL Layer,

```python
PM> enable-migrations	# creates the Configuration.cs file for migrations.
PM> update-database 	# updates the database when code changes.
```
