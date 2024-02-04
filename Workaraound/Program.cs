using Business.Concrete;
using Entities.Concrete;

Person p = new Person() { FirstName = "Ozgur", LastName = "Aydogan", DateOfBirthYear = 1400, Identity = 2 };
PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(p);