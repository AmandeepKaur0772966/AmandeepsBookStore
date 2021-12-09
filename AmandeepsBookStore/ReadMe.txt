Name: Amandeep Kaur
Student Id: 0772966
Project Name: AmandeepsBookStore
Professor: Andrew Steele

PART:-1 08-November-2021 (11:00 a.m.)

I created a new project named AmandeepsBookStore at (11:00 p.m.)
Created a github repo named AmandeepsBookStore at (11:02 p.m.)
Then, I reviewed the project and modified startup file (11:03 p.m.)
After that, started debugging the project and added two breakpoints on IAction Index and Privacy and ran the program.(11:04 p.m.)
After going to Bootswatch.com, I selected a theme named "Minty" (11.05 p.m.)
Downloaded its bootstrap.cs file and replaced it with the existing bootstap.cs under the wwwroot folder(11:06 p.m.)
Again, I went to wwwroot folder and changed site.css file with the file provided on Blackboard(11:15 p.m.)
Under Views folder, changed the file name from bootstrap.min.css to bootstrap.css(11:21 p.m.)
Changed the nav class from navbar-light to navbar dark and all(11:25 p.m.)
Removed extra text-dark content(11:33 p.m.)
Added additional properties to the footer class(11:36 p.m.)
Ran the project to review the changes and updated github rep(11:41 p.m.)
Added additional stylesheets and scripts from the CSS_JS.txt file to _Layout.cshtml(12:18a.m.)
And added dropdown to the NavBar into this file(12:31 a.m.)
Saved and refreshed it and checked the changes(12:33 a.m.)
After that, Chaged 'Dropdown' to 'Content Management' and ran it(12:36 a.m.)
Updated the github repo(12:40 a.m.)
After that, I added three new projects to the application(12:41 a.m.)
.DataAccess
.Models
.Utility
Copied the 'Data' folder and pasted it to .DataAccess project and deleted original one(12:43 a.m.)
Installed NuGet Packages and deleted Migrations folder(12:48 a.m.)
Modified the namespace to reflect the project(12:50 a.m.)
Deleted all default Class1.cs files from all projects(12:52 a.m.)
Then, built the project and solved the errors(12:55 a.m.)
Moved Models into .Models project and deleted original(12:59 a.m.)
Modified Error.cshtml file under Views folder(1:00 a.m.)
Added project references to .DataAccess and .Models project(1: 02 a.m.)
Renamed Models folder to ViewModels(1:04a.m.)
Changed the namespace and built the project and updated github repo(1:05 a.m.)
Modified Startup.cs file and ran it and reviewed the errors(1:06 a.m.)
Removed using statement and fixed the errors(1:08 a.m.)
After that, In Utility project, Created a class called SD.cs(4: 06 a.m.)
Modified the properties of the class and added references to main project(4: 10 a.m.)
Updated the github repo(4:12 a.m.)
Added 'Customer' area to Areas folder and changed the routes in startup.cs file(4: 13 a.m.)
Moved HomeController.cs to Controller Area and deleted Data and Models folder from it(4:15 a.m.)
Updated it's code and moved Home folder and modified HomeController namespace(4:16 a.m.)
Ran the application and copied _ViewImport and _ViewStart to customer area(4:30 a.m.)
Modified _ViewStart file and ran it again to review the changes(4:45a.m.)
Then, updated github rep(4:49a.m.)
Added a new Admin Area in Areas folder and proper view files and Deleted Data and Models folder(5: 06 a.m.)
Deleted Controllers folder(5:08 a.m.)
Updated tge GitHub repo(5:10 a.m.)
It took me 2 hours to complete Part 1.

PART:-2 10-November-2021 (3:00 a.m.)

Built the project to make sure that there are no errors(3.00 a.m.)
Reviewed the files(3:01 a.m.)
Added migration named 20211110193420_AddDefaultIdentityMigration.cs and 20211110200123_AddCategoryToDb.cs and modified database name(3:02 a.m.) 
Then cahnged the default project to .DataAccess and ran it(3:09 a.m.)
After completing migration, updated the database and reviewed it(3:12 a.m.)
Checked for errors and solved them(3:15a.m.)
Modified the github repo(3:19a.m.)
After that , I slept and starting working on it in noon.
Added a new class called Category.cs and modified it(2:51p.m.)
Added the migrations again(2:53p.m.)
Updated Application DB Context and using statement(2:56p.m.)
Ran the migrations again and reviewed changes(2:57p.m.)
Updated the database(2:59p.m.)
Added a new folder named Repository and a folder named IRepository inside it(3:32p.m.)
Added a new interface called IRepository.cs into the folder and modified it(3:34p.m.)
Added a class called Repository.cs inside the folder named Repository(3:45p.m.)
Reviewed the potential fixes and implemented interface(3:48p.m.)
Modified the code(3:52p.m.) 
Then created individual repos for category named CategoryRepository.cs and ICategoryRepository.cs(3:56p.m.)
And modified CategoryRepository.cs and ICategoryRepository.cs(4:14 p.m.)
Modified the errors and completed the remaining modifications(4:22p.m.)
Built it and updated the github repo(4:24p.m.)
Added a new interface called ISP_Call.cs in the IRepository folder(4:26p.m.)
Added a new class called SP_Call.cs in the Repository folder(5:30p.m.)
Updated the ISP_Call implementations(5:33p.m.)
Added a new interface called IUnitOfWork.cs to IRepository folder and a class inside Repository folder(5:35p.m.)
Modified the code and startup file(5:36p.m.)
Had to go to walmart because i needed to do goroceries
Then, started the project again built the project and fixed the errors(7:35p.m.) 
Updated the github repo(8:23p.m.)....
Added controllers folder under admin views and category folder and index.cshtml and modified all the code
Finally, I have completed the part 2.....yooo.
It took me almost 4 hours to complete this part.

Part:-3 24-November-2021 (8:00 p.m.)

I added product controller to my entire project.(8:00pm)
I added IWebHostEvironment call product (8:09pm)
Created View Model in the Models project (8:17pm)
Modified the ProductVM class and installed the Microsoft.AspNetCore.Mvc. ViewFeatures package.(8:26pm)
Modified the ProductController and using statement to the VM folder.(8:43pm)
Modified the API call.(8:54pm)
Added an Index view and copied it from category.(9:07pm)
Added some properties and references.(9:19pm)
Added product.js.(9:25pm)
modified _layout.cshtml file  (9:30pm)
Added CoverType.cs in the models folder and Cover Type to the Repository.(9:35pm)
Added CoverTypeRepository Class and interface.(9:37pm)
Added CoverType to UnitOfWork and IUnitofWork files.(9:57pm)
And pushed it via PM Console.(10:02pm)
Created migrations and Updated again the Database.(10:07pm)
Did some operations on Cover Type.(10:13pm)
Then added Cover Type property to NavBar.(10:18pm)
Added Covertype Controller with all Actions.(10:23pm)
After that, I added a new class in the .Models project.(10:28pm)
Afterthat, Fixed some errors.(10:32pm)
Modified ApplicationDbContext.cs file.(10:37pm)
Added migration named addProductToDb migration and updated database. (10:40pm)
Added Product class to the repository and its interface.(10:43pm)
Added Product to UnitOfWork and IUnitofWork.(10:50pm)
Updated the github repo.(10:54pm)
Finally after fixing errors I completed part 3 successfully..........
It took me almost 3 hours to complete both sections of this part.

25-November-2021
Did more modications from Section 3 and took me just about 1 hour to modify my code and to fix issues

Part:-4 06-December-2021 (2:00 pm p.m.)

Did comparison with the provided code on blackboard.........and made modifications
I tried to fix the issue at school now because my own laptop's window got demaged so was not able to do that at home (2:09pm)
and it's not fixing and not happy.................will try at home again......because running out of time
Updated some of my code after going through git rep that is provided on blackboard (2:24pm)
Updated the github repo and readme(2:50pm)
took 50 minutes.

08-December-2021(1:30 p.m.)
Modified my readme little bit to make more attractive.............
updated git rep....(2:00 p.m.)






