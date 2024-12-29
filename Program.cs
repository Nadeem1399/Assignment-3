// Create a new instance of the Family class
using System;

Family myFamily = new Family();

// Add person objects to the family
Person Frank = new Person("Frank", 25);
Person Adam = new Person("Adam", 56);
Person Jessica = new Person("Jessica", 19);


Person Ashley = new Person("Ashley+", 0);
Person Conor = new Person("Conor+", 0);
Person Linda = new Person("Linda+", 0);

// Parents properties
Frank.Parents.Add(Adam);
Frank.Parents.Add(Ashley);

Jessica.Parents.Add(Adam);
Jessica.Parents.Add(Ashley);

Adam.Parents.Add(Conor);
Adam.Parents.Add(Linda);

// Adding family members to the Family class
myFamily.AddMember(Frank);
myFamily.AddMember(Adam);
myFamily.AddMember(Jessica);
myFamily.AddMember(Ashley);
myFamily.AddMember(Conor);
myFamily.AddMember(Linda);

// Iterate over the Family collection and display information
foreach (Person person in myFamily)
{
    person.DisplayInfo();
}
