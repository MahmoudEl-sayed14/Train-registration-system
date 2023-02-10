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
  ![image](https://user-images.githubusercontent.com/124709587/217572773-c080e8bb-e2be-4803-a611-ee7059770272.png)
<pre>
  The classes used in constructing this app are represented in a UML diagram, where:

    `+` denotes a public access modifier,
    `-` denotes a private access modifier,
    `#` denotes a protected access modifier, and 
    an arrow represents inheritance.
  
  This diagram provides a visual representation of the relationships between the different classes, and the accessibility of their properties and methods.
</pre>
# 
