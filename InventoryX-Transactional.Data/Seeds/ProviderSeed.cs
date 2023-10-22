using InventoryX_Transactional.Data.Models;

namespace InventoryX_Transactional.Data.Seeds;

public static class ProviderSeed
{
    private const string AdminId = "46dadb72-f4b7-400e-be4b-d58d36dc22dd";

    public static List<Provider> Data 
    {
        get {
           return new List<Provider>() 
           {
                new ()
                {
                    ProviderId = Guid.NewGuid(),
                    CreatedBy = Guid.Parse(AdminId),
                    CreatedAt = DateTime.Now,
                    BusinessName = "Augue Corporation",
                    RUC = "28851161316",
                    ContactEmail = "in.tempus@google.com",
                    ContactPhone = "(498) 810-4710",
                    Address = "P.O. Box 367, 4325 Augue Rd."
                },
                new ()
                {
                    ProviderId = Guid.NewGuid(),
                    CreatedBy = Guid.Parse(AdminId),
                    CreatedAt = DateTime.Now,
                    BusinessName = "Feugiat Nec Foundation",
                    RUC = "21425812564",
                    ContactEmail = "ut.tincidunt@yahoo.net",
                    ContactPhone = "1-324-172-5394",
                    Address = "716-9139 Lectus, Road"
                },
                new () 
                {
                    ProviderId = Guid.NewGuid(),
                    CreatedBy = Guid.Parse(AdminId),
                    CreatedAt = DateTime.Now,
                    BusinessName = "Dis Parturient Montes Associates",
                    RUC = "20907865658",
                    ContactEmail = "donec.luctus@aol.edu",
                    ContactPhone = "1-948-625-3851",
                    Address = "P.O. Box 994, 6300 Id Rd."
                },
                new ()
                {
                    ProviderId = Guid.NewGuid(),
                    CreatedBy = Guid.Parse(AdminId),
                    CreatedAt = DateTime.Now,
                    BusinessName = "Egestas Rhoncus Corp.",
                    RUC = "21438271486",
                    ContactEmail = "pede@icloud.net",
                    ContactPhone = "(487) 387-0723",
                    Address = "Ap #121-5878 Nulla. St."
                },
                new ()
                {
                    ProviderId = Guid.NewGuid(),
                    CreatedBy = Guid.Parse(AdminId),
                    CreatedAt = DateTime.Now,
                    BusinessName = "Nullam Nisl Maecenas PC",
                    RUC = "23414517112",
                    ContactEmail = "vulputate@protonmail.couk",
                    ContactPhone = "(685) 481-5523",
                    Address = "523-8707 Et Rd."
                },
                new ()
                {
                    ProviderId = Guid.NewGuid(),
                    CreatedBy = Guid.Parse(AdminId),
                    CreatedAt = DateTime.Now,
                    BusinessName = "Turpis Egestas Fusce Inc.",
                    RUC = "20534218461",
                    ContactEmail = "donec.feugiat.metus@google.ca",
                    ContactPhone = "(744) 465-4414",
                    Address = "938-7069 Lobortis, Av."
                },
                new ()
                {
                    ProviderId = Guid.NewGuid(),
                    CreatedBy = Guid.Parse(AdminId),
                    CreatedAt = DateTime.Now,
                    BusinessName = "Sem Limited",
                    RUC = "27145868620",
                    ContactEmail = "lacinia@yahoo.ca",
                    ContactPhone = "(512) 376-4277",
                    Address = "Ap #717-2261 Mi Avenue"
                },
                new ()
                {
                    ProviderId = Guid.NewGuid(),
                    CreatedBy = Guid.Parse(AdminId),
                    CreatedAt = DateTime.Now,
                    BusinessName = "Elit A Feugiat Corp.",
                    RUC = "28163725354",
                    ContactEmail = "consectetuer.ipsum.nunc@hotmail.net",
                    ContactPhone = "(445) 745-2317",
                    Address = "P.O. Box 145, 8931 Vitae Rd."
                },
                new ()
                {
                    ProviderId = Guid.NewGuid(),
                    CreatedBy = Guid.Parse(AdminId),
                    CreatedAt = DateTime.Now,
                    BusinessName = "Vitae Velit LLC",
                    RUC = "20177426605",
                    ContactEmail = "at@icloud.ca",
                    ContactPhone = "1-202-357-4151",
                    Address = "Ap #312-3859 Arcu. Street"
                },
                new ()
                {
                    ProviderId = Guid.NewGuid(),
                    CreatedBy = Guid.Parse(AdminId),
                    CreatedAt = DateTime.Now,
                    BusinessName = "Lorem Ipsum Institute",
                    RUC = "24334730132",
                    ContactEmail = "orci.donec.nibh@aol.ca",
                    ContactPhone = "(747) 407-6648",
                    Address = "430-6187 Malesuada Ave"
                },
                new ()
                {
                    ProviderId = Guid.NewGuid(),
                    CreatedBy = Guid.Parse(AdminId),
                    CreatedAt = DateTime.Now,
                    BusinessName = "At Associates",
                    RUC = "25016570928",
                    ContactEmail = "ac@icloud.ca",
                    ContactPhone = "1-335-797-0988",
                    Address = "2259 Nunc St."
                },
                new ()
                {
                    ProviderId = Guid.NewGuid(),
                    CreatedBy = Guid.Parse(AdminId),
                    CreatedAt = DateTime.Now,
                    BusinessName = "Nibh Donec Est Institute",
                    RUC = "24821225133",
                    ContactEmail = "proin.non.massa@aol.org",
                    ContactPhone = "1-854-225-3383",
                    Address = "318-3230 Urna. Rd."
                },
                new ()
                {
                    ProviderId = Guid.NewGuid(),
                    CreatedBy = Guid.Parse(AdminId),
                    CreatedAt = DateTime.Now,
                    BusinessName = "Erat Volutpat Inc.",
                    RUC = "21546823173",
                    ContactEmail = "elit.pretium@icloud.com",
                    ContactPhone = "(681) 652-3427",
                    Address = "Ap #645-3636 Conubia Av."
                },
                new ()
                {
                    ProviderId = Guid.NewGuid(),
                    CreatedBy = Guid.Parse(AdminId),
                    CreatedAt = DateTime.Now,
                    BusinessName = "Proin Eget Institute",
                    RUC = "24419741745",
                    ContactEmail = "lobortis.mauris@google.net",
                    ContactPhone = "1-640-831-2711",
                    Address = "163-409 In, Rd."
                },
                new ()
                {
                    ProviderId = Guid.NewGuid(),
                    CreatedBy = Guid.Parse(AdminId),
                    CreatedAt = DateTime.Now,
                    BusinessName = "Laoreet Posuere Ltd",
                    RUC = "20381813145",
                    ContactEmail = "quis@yahoo.org",
                    ContactPhone = "1-331-293-1812",
                    Address = "Ap #398-2179 Ligula Rd."
                },
                new ()
                {
                    ProviderId = Guid.NewGuid(),
                    CreatedBy = Guid.Parse(AdminId),
                    CreatedAt = DateTime.Now,
                    BusinessName = "In Foundation",
                    RUC = "23374028741",
                    ContactEmail = "fringilla.euismod.enim@outlook.couk",
                    ContactPhone = "(812) 908-3601",
                    Address = "573-5782 Ut Avenue"
                },
                new ()
                {
                    ProviderId = Guid.NewGuid(),
                    CreatedBy = Guid.Parse(AdminId),
                    CreatedAt = DateTime.Now,
                    BusinessName = "Suspendisse Tristique Neque Foundation",
                    RUC = "23886134764",
                    ContactEmail = "sed@aol.com",
                    ContactPhone = "(548) 947-6178",
                    Address = "P.O. Box 398, 5701 Enim Ave"
                },
                new ()
                {
                    ProviderId = Guid.NewGuid(),
                    CreatedBy = Guid.Parse(AdminId),
                    CreatedAt = DateTime.Now,
                    BusinessName = "Malesuada Associates",
                    RUC = "28654072941",
                    ContactEmail = "ut.mi@icloud.com",
                    ContactPhone = "1-531-938-2251",
                    Address = "201 Auctor Rd."
                },
                new ()
                {
                    ProviderId = Guid.NewGuid(),
                    CreatedBy = Guid.Parse(AdminId),
                    CreatedAt = DateTime.Now,
                    BusinessName = "Enim Sit Ltd",
                    RUC = "28352851057",
                    ContactEmail = "ut.aliquam@icloud.com",
                    ContactPhone = "1-696-562-7023",
                    Address = "733-4722 Mi. Avenue"
                },
                new ()
                {
                    ProviderId = Guid.NewGuid(),
                    CreatedBy = Guid.Parse(AdminId),
                    CreatedAt = DateTime.Now,
                    BusinessName = "Massa Limited",
                    RUC = "22184652687",
                    ContactEmail = "at.libero.morbi@google.couk",
                    ContactPhone = "1-628-221-7892",
                    Address = "P.O. Box 604, 2268 Ac St."
                }
           };
        }
    }
}
