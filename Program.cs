using Service;

ContactRepo repository = new();
main0(repository);
void main0(ContactRepo repository) {
    while (true) {
        Console.WriteLine("input 1-8 for options and anything else to end the program\n" +
                          "1). list all Contacts held\n"  +
                          "2). create new Contact\n"      +
                          "3). get contact by id \n"      +
                          "4). get contact by name\n"     +
                          "5). delete contact by id\n"    +
                          "6}. delete contact by name"    );

        switch (Console.ReadLine()) {
            case "1":
                dirPrintBlock(repository);
                break;
            case "2":
                Console.WriteLine("enter a phone nubber, full name, address, and email in that order");
                Console.WriteLine("success: " +
                repository.AddContact(new Contact(int.Parse(Console.ReadLine())     ,
                                                  Console.ReadLine()??"none given"  ,
                                                  Console.ReadLine()??"none given"  ,
                                                  Console.ReadLine()??"none given" )));
                break;
            case "3":
                dirPrintBlock(repository);
                Console.WriteLine("enter in an id from the table");
                Console.WriteLine(toStr(repository.GetContacts()[int.Parse(Console.ReadLine())])??"NotFound");
                break;
            case "4"://*
                dirPrintBlock(repository);
                Console.WriteLine("enter a name from the above table");
                Console.WriteLine(sameNamePrintBlock(repository, Console.ReadLine()??"")??"NotFound");
                break;
            case "5":
                dirPrintBlock(repository);
                Console.WriteLine("enter an id from the table above to delete");
                Console.WriteLine("success: " +
                    repository.DeleteContact(int.Parse(Console.ReadLine()??"0")));
                break;
            case "6":
                dirPrintBlock(repository);
                Console.WriteLine("enter a name from the table above to delete");
                Console.WriteLine("success: " +
                                   repository.DeleteContact(repository.GetContacts(Console.ReadLine())[0].Id));
                break;
            default: return;
        }
        Console.Write("Press any key to clear and continue: ");
        Console.ReadKey();
        Console.Clear();
    }
}
void dirPrintBlock(ContactRepo r) {
    Console.WriteLine("\n\ntable: ");
    foreach (var repo in r.GetContacts()) { 
        Console.WriteLine($" id <{repo.Key}>: name <{repo.Value.Name}>");
    }
    Console.WriteLine();
}
string sameNamePrintBlock(ContactRepo r, string name) {
    string? ret = null;
    foreach (var str in r.GetContacts(name))
        ret += " " + toStr(str);

    return ret??"None found";
}
string? toStr(Contact c) => $"{c.Id} : {c.Name} {c.Address} {c.Email} {c.PhoneNumber}";