Sample URL shortner Application
--------------------------------

This is a simple console application that serves as a proff of concept for a TinyURL type service.
It allows you to create short URLs for long URLs, delete short URLs, retreive long URLs and to get the Click Statistics on the number of clicks for a short URL.


Getting Started:
------------------------------------------------------
1. Open TinyUrlService.sln Solution in Visual Studio.
2. Build the Project.
3. Run the console application.
-------------------------------------------------------

Commands:
----------
Application supports the following commands on CLI.

1. Create Short URL
---------------------
	Enter the long URL.
	Choose to enter a custom short URL or let the application generate one.

2. Delete Short URL
-------------------
	Enter the short URL you want to delete.

3. Get Long URL
----------------
	Enter the short URL to retrieve the associated long URL.

4. Get Click Statistics
------------------------
	Enter the short URL to get the number of clicks.

5. Exit
---------
	Exit the application.


----------
Example:
----------

--------------------------------------
-- Welcome to URL Shortner Service --
--------------------------------------
--------------------------------------
1. Create Short URL
2. Delete Short URL
3. Get Long URL
4. Get Click Statistics
5. Exit
--------------------------------------
Please select an option to continue:
--------------------------------------
1
Enter long URl:
google.com
Do you want to enter a custom short URL? (y/n):
n
*******************************************************
Short URL created and stored: myurlshortnerservice.com/HvRaS8fF
*******************************************************

--------------------------------------
1. Create Short URL
2. Delete Short URL
3. Get Long URL
4. Get Click Statistics
5. Exit
--------------------------------------
Please select an option to continue:
--------------------------------------
3
Enter Short URL. Enter full url incuding domain.:
myurlshortnerservice.com/HvRaS8fF
*************************************************
Long URL Found.
Long URL: google.com
*************************************************
--------------------------------------
1. Create Short URL
2. Delete Short URL
3. Get Long URL
4. Get Click Statistics
5. Exit
--------------------------------------
Please select an option to continue:
--------------------------------------
4
Enter Short URL. Enter full url incuding domain.:
myurlshortnerservice.com/HvRaS8fF
*************************************************
Short URL Found.
Click Count for myurlshortnerservice.com/HvRaS8fF is: 2 clicks
*************************************************
