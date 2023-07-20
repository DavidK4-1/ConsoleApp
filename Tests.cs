//ONLY 1 POCO AND REPO ARE REQUIRED 

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Service;

[TestClass]
public class TestContacts {
    [TestMethod]
    public void ContactPropertyTests() {
        Contact con = new(111111111, "bob", "121 str st", "email@mail.com");
        Assert.AreEqual(111111111, con.PhoneNumber);
        Assert.AreEqual("bob", con.Name);
        Assert.AreEqual("121 str st", con.Address);
        Assert.AreEqual(1, con.Id);
        Assert.AreEqual("email@mail.com", con.Email);
    }
    [TestMethod]
    public void AddContentAndGetTests() {
        Contact con = new(111111111, "bob", "121 str st", "email@mail.com");
        Contact shantFind = new(111111112, "joe", "122 str st", "email2@mail.com");
        ContactRepo conRepo = new();

        conRepo.AddContact(con);

        foreach (var cr in conRepo.GetContacts())
            Assert.AreEqual(con, cr.Value);

        conRepo.AddContact(shantFind);
        foreach (var cr in conRepo.GetContacts("bob"))
            Assert.AreEqual(con, cr);

        Assert.AreNotEqual(con, conRepo.GetContacts()[shantFind.Id]);
    }
    [TestMethod]
    public void AddContentAndUpdateTests() {
        Contact con = new(111111111, "bob", "121 str st", "email@mail.com");
        Contact update = new(111111111, "joe", "121 str st", "email@mail.com");
        ContactRepo conRepo = new();

        conRepo.AddContact(con);
        conRepo.UpdateContactInfo(con.Id, update);

        Assert.AreEqual(update, conRepo.GetContacts()[con.Id]);
    }
    [TestMethod]
    public void AddContentAndDeleteTests() {
        Contact con = new(111111111, "bob", "121 str st", "email@mail.com");
        ContactRepo conRepo = new();

        conRepo.AddContact(con);
        conRepo.DeleteContact(con.Id);

        Assert.IsTrue(conRepo.GetContacts().LongCount() == 0);
    }

}