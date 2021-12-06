Name: Amandeep Kaur
Student Id: 0772966
Project Name: AmandeepsBookStore
Professor: Andrew Steele

PART:-1 02-November-2021 (11:00 a.m.)

I created a new project named AmandeepsBookStore at (11:00 a.m.)
Created a github repo named AmandeepsBookStore at (11:02 a.m.)
Then, I reviewed the project and modified startup file (11:05 a.m.)
After that, started debugging the project and added two breakpoints on IAction Index and Privacy and ran the program.(11:10 a.m.)
After going to Bootswatch.com, I selected a theme named "Minty" (11.12a.m.)
Downloaded its bootstrap.cs file and replaced it with the existing bootstap.cs under the wwwroot folder(11:16 a.m.)
Again, I went to wwwroot folder and changed site.css file with the file provided on Blackboard(11:20 a.m.)
Under Views folder, changed the file name from bootstrap.min.css to bootstrap.css(11:21 a.m.)
Changed the nav class from navbar-light to navbar dark and all(11:25 a.m.)
Removed extra text-dark content(11:29 a.m.)
Added additional properties to the footer class(11:36 a.m.)
Ran the project to review the changes and updated github rep(11:41 a.m.)
Added additional stylesheets and scripts from the CSS_JS.txt file to _Layout.cshtml(11:50a.m.)
And added dropdown to the NavBar into this file(11:54a.m.)
Saved and refreshed it and checked the changes(12:01p.m.)
After that, Chaged 'Dropdown' to 'Content Management' and ran it(12:06p.m.)
Updated the github repo(12:10p.m.)
Then, I took break for few mintues and had my favourite meal(12:10p.m. to 12:30p.m.)
After that, I added three new projects to the application(12:31p.m.)
.DataAccess
.Models
.Utility
Copied the 'Data' folder and pasted it to .DataAccess project and deleted original one(12:37p.m.)
Installed NuGet Packages and deleted Migrations folder(12:38p.m.)
Modified the namespace to reflect the project(12:40p.m.)
Deleted all default Class1.cs files from all projects(12:42p.m.)
Then, built the project and solved the errors(12:45p.m.)
Moved Models into .Models project and deleted original(12:49p.m.)
Modified Error.cshtml file under Views folder(12:51p.m.)
Added project references to .DataAccess and .Models project(12:55p.m.)
Renamed Models folder to ViewModels(12:56p.m.)
Changed the namespace and built the project and updated github repo(1:00p.m.)
Modified Startup.cs file and ran it and reviewed the errors(1:03p.m.)
Removed using statement and fixed the errors(1:08p.m.)
After that, In Utility project, Created a class called SD.cs(1:15p.m.)
Modified the properties of the class and added references to main project(1:17p.m.)
Updated the github repo(1:20p.m.)
Added 'Customer' area to Areas folder and changed the routes in startup.cs file(1:25p.m.)
Moved HomeController.cs to Controller Area and deleted Data and Models folder from it(1:29p.m.)
Updated it's code and moved Home folder and modified HomeController namespace(1:34p.m.)
Ran the application and copied _ViewImport and _ViewStart to customer area(1:40p.m.)
Modified _ViewStart file and ran it again to review the changes(1:45p.m.)
Then, updated github rep(1:49p.m.)
Added a new Admin Area in Areas folder and proper view files and Deleted Data and Models folder(1:52p.m.)
Deleted Controllers folder(1:53p.m.)
Updated tge GitHub repo(1:55p.m.)
It took me 2 hours to complete Part 1.

PART:-2 08-November-2021 (2:30 p.m.)

Built the project to make sure that there are no errors(2:31p.m.)
Reviewed the files(2:33p.m.)
Added migration named 20211110193420_AddDefaultIdentityMigration.cs and 20211110200123_AddCategoryToDb.cs and modified database name(2:35p.m.) 
Then cahnged the default project to .DataAccess and ran it(2:40p.m.)
After completing migration, updated the database and reviewed it(2:42p.m.)
Checked for errors and solved them(2:45p.m.)
Modified the github repo(2:49p.m.)
Added a new class called Category.cs and modified it(2:51p.m.)
Added the migrations again(2:53p.m.)
Updated Application DB Context and using statement(2:56p.m.)
Ran the migrations again and reviewed changes(2:57p.m.)
Updated the database(2:59p.m.)
Added a new folder named Repository and a folder named IRepository inside it(3:02p.m.)
Added a new interface called IRepository.cs into the folder and modified it(3:04p.m.)
Added a class called Repository.cs inside the folder named Repository(3:05p.m.)
Reviewed the potential fixes and implemented interface(3:08p.m.)
Modified the code(3:12p.m.) 
Then created individual repos for category named CategoryRepository.cs and ICategoryRepository.cs(3:16p.m.)
And modified CategoryRepository.cs and ICategoryRepository.cs(3:20p.m.)
Modified the errors and completed the remaining modifications(3:22p.m.)
Built it and updated the github repo(3:24p.m.)
Added a new interface called ISP_Call.cs in the IRepository folder(3:26p.m.)
Added a new class called SP_Call.cs in the Repository folder(3:30p.m.)
Updated the ISP_Call implementations(3:33p.m.)
Added a new interface called IUnitOfWork.cs to IRepository folder and a class inside Repository folder(3:35p.m.)
Modified the code and startup file(3:36p.m.)
Had to go to walmart because i needed to do goroceries
Then, started the project again built the project and fixed the errors(7:35p.m.) (10-November-2021)
Updated the github repo(8:18p.m.)....
Added controllers folder under admin views and category folder and index.cshtml and modified all the code
Finally, I have completed the part 2.....yooo.
It took me almost 2 hours to complete this part.

Part:-3 24-November-2021 (8:00 p.m.)

I added Product Controller.(8:00pm)
I added IWebHostEvironment call and its using statement to the Microsoft.(8:09pm)
I created ViewModel in the Models project and selected list for Category and CoverType.(8:17pm)
I Modified the ProductVM class and installed the Microsoft.AspNetCore.Mvc. ViewFeatures package.(8:26pm)
Then again modified the ProductController and included the using statement to the ViewModels folder.(8:43pm)
Then I Modified the API call to include the Category and coverType Properties.(8:54pm)
I added an Index view and copy the index.cshtml code from View/Category.(9:07pm)
Then, added some properties and reference a new product.js file.(9:19pm)
copied nad pasted the category.js and renamed to product.js.(9:25pm)
modified the_layout.cshtml to add a new link to product.(9:30pm)
Then I created the Cover Type CRUD and added CoverType.cs in the models folder.(9:32pm)
I added CoverType to the Repository.(9:35pm)
Added CoverTypeRepository Class.(9:37pm)
Added ICoverTypeRepository Interface.(9:42pm)
Added CoverType to UnitOfWork and IUnitofWork.(9:57pm)
And Pushed CoverType to the Database.(10:02pm)
Created migrations and Updated the Database.(10:07pm)
performed CRUD operations on Cover Type.(10:13pm)
Then added Cover Type to NavBar.(10:18pm)
Added Covertype Controller with all required Action Methods.(10:23pm)
And Then deleted CoverType using the API Call.(10:25pm)
Then I added a new class in the .Models project.(10:28pm)
Then I added the code to build the blueprint.(10:30pm)
Afterthat, I checked for errors.(10:32pm)
Then I added reference to the new products piece to the database in the ApplicationDbContext.cs file.(10:37pm)
In the PM Console, I ran the add-migration command for an addProductToDb migration and updated database. (10:40pm)
Then I Updated the product class and created new migrations and updated the database. (10:41pm)
Then, Added Product to the repository.(10:43pm)
Then Add IProductRepository interface.(10:47pm)
Added ProductRepository Class and also added Product to UnitOfWork and IUnitofWork.(10:50pm)
After that, I built and checked for the errors and updated the github repo.(10:54pm)
It took me 3 hours to complete both sections of this part.

Part:-4 06-December-2021 (1:55 p.m.)

Compared my code with the provided code on blackboard.........
I tried to fix the issue at school now because my own laptop's window got demaged so was not able to do that at home (2:00pm)
and it's not fixing and not happy.................will try at home again......because running out of time
Updated the github repo and readme(2:15pm)





