namespace Service;
/*
public enum DeliveryStatus { Scheduled, EnRoute, Complete }//cancel implimentation in REPO
public class Delivery {// needs some work
    //TODO cheak parameters
    private static int _makeIdUnq;

    public Delivery(int item, int quantity) {
        Id += ++_makeIdUnq;
        OrderTime = DateTime.Now;
        ItemNumber = item;
        ItemQuantity = quantity;
    }

    public int Id { get; private set; }
    public int ItemNumber { get; }
    public int ItemQuantity { get; set; }
    public string DeliveryDateApx {
        get => $"from: {OrderTime.AddDays(ItemQuantity - 1)} - {OrderTime.AddDays(ItemQuantity + 1)}"; } 
    public DateTime OrderTime { get; private set; }
    public DeliveryStatus Status { // work on this
        get => Math.Sign((DateTime.Now - OrderTime.AddDays(ItemQuantity + 1)).TotalDays) switch {
                    1 => DeliveryStatus.Scheduled,
                    0 => DeliveryStatus.EnRoute,
                    _ => DeliveryStatus.Complete  }; }
}
*/





//Priority
public class Contact { 
    private static int _makeIdUnq;

    public Contact(int phNum, string name, string addr, string email) {
        Id = ++_makeIdUnq;
        Name = name;
        PhoneNumber = phNum;
        Email = email;
        Address = addr;
    }

    public int Id { get; }
    public int PhoneNumber { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string Email { get; set; }
    
}






/*
public enum ClaimType { Car, Theft, Home }
public class InsuranceClaim {
    public InsuranceClaim(int ammount, string description, DateOnly incident) {
        ClaimAmmount = ammount;
        Description = description;
        DateOfIncident = incident;
        DateOfClaim = DateOnly.FromDateTime(DateTime.Now);
    }

    public bool IsValid { get => 30 >= DateOfClaim.Day - DateOfIncident.Day; }
    public int ClaimAmmount { get; set; }
    public string Description { get; set; }
    public DateOnly DateOfIncident { get; private set; }
    public DateOnly DateOfClaim { get; private set; }
}
*/