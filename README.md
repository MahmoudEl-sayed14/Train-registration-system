# Description:
<pre>
  The Train Registration System is a desktop application designed for both users and administrators. The administrator has the ability to add a single trip, while the 
  users can book a ticket. To ensure that tickets are not double-booked, the system uses files instead of a database to track ticket availability. This ensures that each 
  ticket can only be booked once, providing a streamlined and efficient booking experience for users.
</pre>
# Features:
<pre>
  User Features:
    • Can view available trip and it's details, including departure time, ticket prices, and available seats.
    • Can book a ticket for a selected trip by providing necessary information, such as name and contact information.
    • Cannot book a ticket that has already been booked by another user, as the system uses files to track ticket availability.
    • Have the option to view booked tickets.
  Administrator Features:
    • Has the ability to add only one trip at a time.
    • Can see how many tickets have been sold for trip.
</pre>
# UML diagram :
  ![image](https://user-images.githubusercontent.com/124709587/218259518-280a2199-a28a-4c3c-9d96-1eb6b9b281d8.png)
<pre>
  The classes used in constructing this app are represented in a UML diagram, where:

    `+` denotes a public access modifier,
    `-` denotes a private access modifier,
    `#` denotes a protected access modifier, and 
    an arrow represents inheritance.
  
  This diagram provides a visual representation of the relationships between the different classes, and the accessibility of their properties and methods.
</pre>
# Screenshots : 
![Screenshot_20230207_034030](https://user-images.githubusercontent.com/124709587/218313702-41184415-e22d-4477-81c2-96f190a349ac.png)
<pre>
  "This is the initial registration form that users must complete to create an account within the application."
</pre>
![Screenshot_20230207_034221](https://user-images.githubusercontent.com/124709587/218313753-51f093a7-6cc4-4b7b-939f-ae4150edd2f6.png)
<pre>
  "The text field features a dynamic animation where the picture box is hidden when the user focuses on the text box, and reappears if the text field remains empty."
</pre>
![Screenshot_20230207_034348](https://user-images.githubusercontent.com/124709587/218313888-d7d0e6f3-c460-4522-8bb5-127b95ad2309.png)
<pre>
  "Before submitting the form, the system checks to ensure that all fields have been filled out properly. An account cannot be created with incomplete information."
</pre>
![Screenshot_20230207_034706](https://user-images.githubusercontent.com/124709587/218314003-4184c692-9253-49c7-aa9c-252894ec4fa1.png)
<pre>
  "To create an account, the user must provide a valid 11-digit Egyptian phone number starting with 010, 011, 012, or 015, and it must match the designated pattern."
</pre>
![Screenshot_20230207_034803](https://user-images.githubusercontent.com/124709587/218314178-4a08fe03-d157-4b58-9a8c-4477ed849e8b.png)
<pre>
  "The user must enter a valid email address that conforms to the standard format of a valid email."
</pre>
![Screenshot_20230207_034914](https://user-images.githubusercontent.com/124709587/218314240-613a7e9c-71c5-4039-89e1-41e5572fbe49.png)
<pre>
  "If all the required fields have been filled out and comply with the specified patterns, the account will be created successfully."
</pre>
![Screenshot_20230207_035927](https://user-images.githubusercontent.com/124709587/218314343-16310c0e-28d1-4a83-ac91-b5f4dfcda3e9.png)
<pre>
  "This is the initial form that users see when they log in to the application."
</pre>
![Screenshot_20230207_041824](https://user-images.githubusercontent.com/124709587/218318207-80f3fde7-0178-470b-bf1d-26aab50b33fa.png)
<pre>
 "The interface includes a functional side bar menu, designed to enhance the user experience and provide an intuitive and interactive experience within the desktop   
  application."
</pre>
![Screenshot_20230207_040920](https://user-images.githubusercontent.com/124709587/218314890-7fbebd18-9e93-4db3-9f7e-a1d39d53809a.png)
<pre>
  "The home page is displayed when the user clicks on it, presenting information about the added trips. A user can also book a ticket through the 'book now' button on 
  this page."
</pre>
![Screenshot_20230207_040954](https://user-images.githubusercontent.com/124709587/218315128-50fd57cf-806a-4535-a8df-9ceb070acd03.png)
![Screenshot_20230207_041013](https://user-images.githubusercontent.com/124709587/218315622-2953d59d-7863-44da-834c-f3afaefe1f98.png)
<pre>
  "When the user clicks on the 'book now' button, they will be directed to the train ticket booking page which displays available tickets. The user can then select a 
  ticket and choose to either book it by clicking the 'save' button or reset all marked seats by clicking the 'cancel' button."
</pre>
![Screenshot_20230207_041019](https://user-images.githubusercontent.com/124709587/218315635-19910350-ee21-4a1b-9544-c6ac3eb8bc7f.png)
<pre>
  "It is not possible to book a ticket that has already been booked, either by the user or by another individual." 
</pre>
![Screenshot_20230207_040943](https://user-images.githubusercontent.com/124709587/218315720-f4434adb-bed7-4d53-b49b-1b2c4ee38e25.png)
![Screenshot_20230207_041036](https://user-images.githubusercontent.com/124709587/218315819-58821052-1a74-4787-b6a8-94e629ef8adf.png)
<pre>
  "The account page displays all information related to the user's account, including the number of booked tickets. If no tickets have been booked yet, this section 
  will display as null."
</pre>
![Screenshot_20230207_040016](https://user-images.githubusercontent.com/124709587/218315847-a0a65661-4771-43eb-b0f0-58656fe077f4.png)
![Screenshot_20230207_040039](https://user-images.githubusercontent.com/124709587/218315913-1c6159b0-c46b-4343-9287-68192151715b.png)
<pre>
  "The user has the option to change their password, but must first correctly enter their current password before making any changes."
</pre>
![Screenshot_20230207_040103](https://user-images.githubusercontent.com/124709587/218316033-28daa593-0dda-4a68-a512-005f8bb853ab.png)
<pre>
  "The new password must match the confirmation password in order to successfully update the current password."
</pre>
![Screenshot_20230207_040120](https://user-images.githubusercontent.com/124709587/218316039-6a411cc5-0207-40e4-9cc2-04be6e473d1d.png)
<pre>
  "If all the rules and requirements are met, the password change will be completed successfully."
</pre>
![Screenshot_20230207_041506](https://user-images.githubusercontent.com/124709587/218316196-5ac890ce-fdd4-4133-9013-08c41bca6a53.png)
<pre>
  "This is the administrator account."
</pre>
![Screenshot_20230207_041511](https://user-images.githubusercontent.com/124709587/218316276-daf624ff-0d3d-406a-80c3-155b73d5995a.png)
<pre>
   "This is the initial form that administrator see when they log in to the application."
</pre>
![Screenshot_20230207_041529](https://user-images.githubusercontent.com/124709587/218316334-f0509518-b260-43c9-bbd5-241f7668adf8.png)
![Screenshot_20230207_041611](https://user-images.githubusercontent.com/124709587/218316338-038b884c-da6c-46e1-8a40-7ad1e6f8bfc1.png)
![Screenshot_20230207_041716](https://user-images.githubusercontent.com/124709587/218316351-b2ea7d94-e6f5-46bf-a03d-eab9ee5ab9cc.png)
<pre>
  "The administrator has the ability to add a trip from the home page, but it is necessary that all required fields of the trip are filled out correctly and meet the  
  validation criteria."
</pre>
![Screenshot_20230207_041728](https://user-images.githubusercontent.com/124709587/218316544-4b1a0f33-b462-42ce-93fd-ad9f6cb6cf15.png)
![Screenshot_20230207_041740](https://user-images.githubusercontent.com/124709587/218316549-bbe44853-4d85-441b-a54d-b8de395ac7f2.png)
<pre>
  "As an administrator, you have access to the account page, where you can view a record of all tickets booked by users to date. Additionally, you can change the 
  current password from this page."
</pre>
