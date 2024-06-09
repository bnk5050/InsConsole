// See https://aka.ms/new-console-template for more information
using InsConsole;
using System.ComponentModel.Design;

Console.WriteLine("Hello, World!");

List<PersonModel> people = new List<PersonModel>();
List<VisitModel> visits = new List<VisitModel>();
loadPeople();
loadVisits();


char menuSelection;

do
{
    Console.WriteLine("Main Menu");
    Console.WriteLine("1. Add Person");
    Console.WriteLine("2. Remove Person");
    Console.WriteLine("3. List everyone");
	Console.WriteLine("5. List visits");
    Console.WriteLine("4. Exit");
    Console.Write("\nEnter a selection: ");
    menuSelection = Console.ReadKey().KeyChar;
	switch (menuSelection)
	{
		case '1':
			Console.WriteLine("\nyou selected 1");
			Console.WriteLine("Adding a person");
			addPerson();
			break;
		case '2':
            Console.WriteLine("\nYou selected 2");
            Console.WriteLine("Removing a person");
			break;
		case '3':
            Console.WriteLine("\n");
            listEveryone();
			break;
		case '5':
            Console.WriteLine("\n");
            listVisits();
            break;
        default:
			Console.WriteLine("\nTry again!");
			break;
	}
	//Console.Clear();

} while (menuSelection!='4');

void listEveryone()
{
	people.ForEach(person => Console.WriteLine(person.FullName));
    Console.WriteLine("\n Press any key to continue....");
    Console.ReadKey();
}

void loadPeople()
{
	people = SqliteDataAccess.LoadPeople();

}

void loadVisits()
{
	visits = SqliteDataAccess.LoadVisits();
}
void addPerson()
{
	PersonModel person = new PersonModel();
	Console.WriteLine("Enter First Name: ");
	person.FirstName = Console.ReadLine();
	Console.WriteLine("Enter Last Name: ");
    person.LastName = Console.ReadLine();

	SqliteDataAccess.SavePerson(person);
	loadPeople();

}
void listVisits()
{
    visits.ForEach(visit => Console.WriteLine(visit.Date));
    Console.WriteLine("\n Press any key to continue....");
    Console.ReadKey();
}