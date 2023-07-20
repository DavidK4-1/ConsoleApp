namespace Service;

//List, Dictionary or Queue
/*
public class DeliveryRepo {
    private readonly List<Delivery> _deliverys = new();

    //c
    public bool AddNewDeliberies(Delivery del) { 
        _deliverys.Add(del);
        return _deliverys.Contains(del);
    }
    //r
    public List<Delivery> GetDeliveryList() => new(_deliverys);
    //public Delivery? GetDelivery(int id) 
    //u // is this needed? i think i implemented the functionality inside of the poco
    //d
    public bool DeleteDelivery(Delivery del) => _deliverys.Remove(del);
    //public bool DeleteDelivery(int id) => DeleteDelivery(GetDeliveryById(id));
}
*/





//PRIORITY
public class ContactRepo { 
    private readonly Dictionary<int, Contact> _addresses = new();

    //c
    public bool AddContact(Contact c) { 
        _addresses.Add(c.Id, c);
        return _addresses.ContainsKey(c.Id);
    }
    //r
    public Dictionary<int,Contact> GetContacts() => new(_addresses);
    public List<Contact?> GetContacts(string name) { 
        List<Contact?> ret = new();
        foreach (var contact in _addresses.Values)
            if (contact.Name == name)
                ret.Add(contact);
        return ret;
    }

    //u
    public bool UpdateContactInfo(int id, Contact c) {
        if (!_addresses.ContainsKey(id) || c == null)
            return false;
        _addresses[id] = c;
        return true;
    }
    //d
    public bool DeleteContact(int id) => _addresses.Remove(id);
}





/*
public class InsuranceClaimRepo { 
    private readonly Queue<InsuranceClaim> _insuranceClaims = new();

    //c
    //r
    public Queue<InsuranceClaim> GetInsuranceClaimList() => new(_insuranceClaims);
    //u
    //d
    public bool RemoveEarliestInsuranceClaim(InsuranceClaim claim) => _insuranceClaims.Dequeue() != null ? true : false;
}
*/