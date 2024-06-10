// See https://aka.ms/new-console-template for more information
using InsConsole;
using InsConsole.models;
using System.ComponentModel.Design;
using System.Transactions;

Console.WriteLine("Hello, World!");

List<Person> people = new List<Person>();
List<Visit> visits = new List<Visit>();
List<InsPlan> plans = new List<InsPlan>();
//TODO: LOAD INSURANCE PLAN
loadPlans();
loadPeople();
loadVisits();


char menuSelection;

do
{
    Console.WriteLine("Main Menu");
    Console.WriteLine("a. Add Person");
    Console.WriteLine("r. Remove Person");
    Console.WriteLine("l. List everyone");
	Console.WriteLine("v. List visits");
    Console.WriteLine("s. Settings");
    Console.WriteLine("e Exit");
    Console.Write("\nEnter a selection: ");
    menuSelection = Console.ReadKey().KeyChar;
	switch (menuSelection)
	{
		case 'a':
			Console.WriteLine("\nyou selected 1");
			Console.WriteLine("Adding a person");
			addPerson();
			break;
		case 'r':
            Console.WriteLine("\nYou selected 2");
            Console.WriteLine("Removing a person");
			break;
		case 'l':
            Console.WriteLine("\n");
            listEveryone();
			break;
		case 'e':
            Console.WriteLine("\n");
            listVisits();
            break;
		case 's':
			Console.WriteLine("\n");
			showSettings();
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

void loadPlans()
{
	plans = SqliteDataAccess.LoadPlan();
}
void addPerson()
{
	Person person = new Person();
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

void showSettings()
{
    Console.WriteLine("Current Settings: \n");

}