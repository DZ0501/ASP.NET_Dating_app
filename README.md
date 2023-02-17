# ASP.NET_Dating_app

Requirements: <br>
Visual Studio 2022 <br>
Microsoft SQL Server Management Studio (I was using v18.10)

Instructions:
1. Clone repository.
2. Change database connection parameters to your own in appsettings.json
![image](https://user-images.githubusercontent.com/94222896/219731733-ca19a9cc-7155-411e-9e6e-d3842902316a.png)
3. In terminal: <br>
  dotnet ef migrations add init <br>
  dotnet ef database update
4. Run project. 

<br> <br>

Test users: <br>
  (Admin) <br>
  login = admin@wp.pl <br>
  password = Zaq!23
 
 <br> <br>
 
Short project description:

By default - not registered user sees basic page with two buttons, which are responsible for logging in and registration. He doesn't have permissions to view /Authorized or /Admin pages.

![image](https://user-images.githubusercontent.com/94222896/219738878-6b3fdf04-6586-4d08-882f-4cdf67bf3513.png)

After registration application gives user Authorized Role and redirects him to Authorized side of application.
![image](https://user-images.githubusercontent.com/94222896/219740165-665bd158-b2bf-4482-a09f-f04643298f70.png)

In this scope user can use button "Find a match" which redirects him to site where he can pick his interest from list and application will find user in database, who has same interest as him.

![image](https://user-images.githubusercontent.com/94222896/219740993-3d0e3f5c-9389-438a-b137-b57605c082b3.png)

![image](https://user-images.githubusercontent.com/94222896/219741200-4dedcbb2-45fd-41d1-98fa-20d797c819d8.png)

After that user can display more detailed information about person which he found.

![image](https://user-images.githubusercontent.com/94222896/219741612-42dbdf99-6842-45a2-a97b-d572d54d1a64.png)

Admin has more control.

After admin logs in application will redirect him to /Admin scope where he can mainly delete certain user or show his detailed info.

![image](https://user-images.githubusercontent.com/94222896/219743006-5eb564b7-157d-4905-8101-5596be12007b.png)

![image](https://user-images.githubusercontent.com/94222896/219744226-f9248f39-1dca-435b-b840-1ea1f666da49.png)

Beside of that - admin can add roles to the database using "Create a role" button. (Future functionalities)

![image](https://user-images.githubusercontent.com/94222896/219745111-b5324c06-023b-4ecd-8e0d-c26435b0fb76.png)

<br> <br>

Postscriptum

It was supposed to be some kind of a dating application. I really felt overwhelmed by my own ambitions when I was doing this project. It has strong potential which I couldn't really use. At least I'm very proud of database context of this application. I had many problems with returining database data into front-end, appearance and with inventing functionalities. Hope for the best next time. :)

