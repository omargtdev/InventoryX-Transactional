using InventoryX_Transactional.Data.Models;

namespace InventoryX_Transactional.Data.Seeds;

public static class ClientSeed
{
    private const string AdminId = "46dadb72-f4b7-400e-be4b-d58d36dc22dd";

    public static List<Client> Data
    {
        get
        {
            return new List<Client>()
           {
                new()
                {
                    ClientId = Guid.NewGuid(),
                    CreatedBy = AdminId,
                    CreatedAt = DateTime.Now,
                    Name = "Alice Chains",
                    DocumentType = DocumentType.DNI,
                    DocumentNumber = "12345678",
                    Email = "alice@gmail.com",
                    Phone = "555-123-4567",
                    Address = "123 Main St, New York",
                    IsLegal = false
                },
                new ()
                {
                    ClientId = Guid.NewGuid(),
                    CreatedBy = AdminId,
                    CreatedAt = DateTime.Now,
                    Name = "Pepitos S.A.C",
                    DocumentType = DocumentType.RUC,
                    DocumentNumber = "21345678901",
                    Email = "bob@yahoo.com",
                    Phone = "555-234-5678",
                    Address = "456 Elm St, Los Angeles",
                    IsLegal = true
                },
                new ()
                {
                    ClientId = Guid.NewGuid(),
                    CreatedBy = AdminId,
                    CreatedAt = DateTime.Now,
                    Name = "Charlie Martinez",
                    DocumentType = DocumentType.DNI,
                    DocumentNumber = "87654321",
                    Email = "charlie@hotmail.com",
                    Phone = "555-345-6789",
                    Address = "789 Oak Dr, Chicago",
                    IsLegal = false
                },
                new ()
                {
                    ClientId = Guid.NewGuid(),
                    CreatedBy = AdminId,
                    CreatedAt = DateTime.Now,
                    Name = "David Aguilar",
                    DocumentType = DocumentType.ImmigrationCard,
                    DocumentNumber = "007654321098765",
                    Email = "david@gmail.com",
                    Phone = "555-456-7890",
                    Address = "567 Cedar Ln, Houston",
                    IsLegal = false
                },
                new ()
                {
                    ClientId = Guid.NewGuid(),
                    CreatedBy = AdminId,
                    CreatedAt = DateTime.Now,
                    Name = "Eve Medina",
                    DocumentType = DocumentType.RUC,
                    DocumentNumber = "13456789012",
                    Email = "eve@yahoo.com",
                    Phone = "555-567-8901",
                    Address = "456 Main St, New York",
                    IsLegal = false
                },
                new ()
                {
                    ClientId = Guid.NewGuid(),
                    CreatedBy = AdminId,
                    CreatedAt = DateTime.Now,
                    Name = "Frank Jones",
                    DocumentType = DocumentType.DNI,
                    DocumentNumber = "54321678",
                    Email = "frank@gmail.com",
                    Phone = "555-987-6543",
                    Address = "321 Oak Dr, Los Angeles",
                    IsLegal = false
                },
                new ()
                {
                    ClientId = Guid.NewGuid(),
                    CreatedBy = AdminId,
                    CreatedAt = DateTime.Now,
                    Name = "Grace",
                    DocumentType = DocumentType.ImmigrationCard,
                    DocumentNumber = "002356789012345",
                    Email = "grace@hotmail.com",
                    Phone = "555-111-2222",
                    Address = "789 Elm St, Chicago",
                    IsLegal = false
                },
                new ()
                {
                    ClientId = Guid.NewGuid(),
                    CreatedBy = AdminId,
                    CreatedAt = DateTime.Now,
                    Name = "Holly Store S.A.",
                    DocumentType = DocumentType.RUC,
                    DocumentNumber = "24567890123",
                    Email = "holly@yahoo.com",
                    Phone = "555-444-5555",
                    Address = "456 Maple Ave, New York",
                    IsLegal = true
                },
                new ()
                {
                    ClientId = Guid.NewGuid(),
                    CreatedBy = AdminId,
                    CreatedAt = DateTime.Now,
                    Name = "Ivy Williams",
                    DocumentType = DocumentType.DNI,
                    DocumentNumber = "76543210",
                    Email = "ivy@gmail.com",
                    Phone = "555-987-6543",
                    Address = "123 Cedar Ln, Los Angeles",
                    IsLegal = false
                },
                new ()
                {
                    ClientId = Guid.NewGuid(),
                    CreatedBy = AdminId,
                    CreatedAt = DateTime.Now,
                    Name = "Jack Smith",
                    DocumentType = DocumentType.ImmigrationCard,
                    DocumentNumber = "00345678601234",
                    Email = "jack@hotmail.com",
                    Phone = "555-333-4444",
                    Address = "456 Oak Dr, Chicago",
                    IsLegal = false
                },
                new ()
                {
                    ClientId = Guid.NewGuid(),
                    CreatedBy = AdminId,
                    CreatedAt = DateTime.Now,
                    Name = "Karen Riques",
                    DocumentType = DocumentType.DNI,
                    DocumentNumber = "87654321",
                    Email = "karen@gmail.com",
                    Phone = "555-567-8901",
                    Address = "123 Main St, New York",
                    IsLegal = false
                },
                new ()
                {
                    ClientId = Guid.NewGuid(),
                    CreatedBy = AdminId,
                    CreatedAt = DateTime.Now,
                    Name = "Liam Nesson",
                    DocumentType = DocumentType.ImmigrationCard,
                    DocumentNumber = "004567890123458",
                    Email = "liam@yahoo.com",
                    Phone = "555-123-4567",
                    Address = "456 Elm St, Los Angeles",
                    IsLegal = false
                },
                new ()
                {
                    ClientId = Guid.NewGuid(),
                    CreatedBy = AdminId,
                    CreatedAt = DateTime.Now,
                    Name = "Mia Shop",
                    DocumentType = DocumentType.RUC,
                    DocumentNumber = "22345228901",
                    Email = "mia@gmail.com",
                    Phone = "555-234-5678",
                    Address = "789 Oak Dr, Chicago",
                    IsLegal = true
                },
                new ()
                {
                    ClientId = Guid.NewGuid(),
                    CreatedBy = AdminId,
                    CreatedAt = DateTime.Now,
                    Name = "Noah Azora",
                    DocumentType = DocumentType.DNI,
                    DocumentNumber = "98765432",
                    Email = "noah@hotmail.com",
                    Phone = "555-345-6789",
                    Address = "567 Cedar Ln, Houston",
                    IsLegal = false
                },
                new ()
                {
                    ClientId = Guid.NewGuid(),
                    CreatedBy = AdminId,
                    CreatedAt = DateTime.Now,
                    Name = "Olivia Fernandez",
                    DocumentType = DocumentType.ImmigrationCard,
                    DocumentNumber = "007654321098765",
                    Email = "olivia@yahoo.com",
                    Phone = "555-456-7890",
                    Address = "456 Main St, New York",
                    IsLegal = false
                },
                new ()
                {
                    ClientId = Guid.NewGuid(),
                    CreatedBy = AdminId,
                    CreatedAt = DateTime.Now,
                    Name = "Parker Corp.",
                    DocumentType = DocumentType.RUC,
                    DocumentNumber = "23456789012",
                    Email = "parker@gmail.com",
                    Phone = "555-567-8901",
                    Address = "123 Maple Ave, Los Angeles",
                    IsLegal = true
                },
                new ()
                {
                    ClientId = Guid.NewGuid(),
                    CreatedBy = AdminId,
                    CreatedAt = DateTime.Now,
                    Name = "Client Eastwood",
                    DocumentType = DocumentType.DNI,
                    DocumentNumber = "54321678",
                    Email = "quinn@yahoo.com",
                    Phone = "555-987-6543",
                    Address = "321 Cedar Ln, Houston",
                    IsLegal = false
                },
                new ()
                {
                    ClientId = Guid.NewGuid(),
                    CreatedBy = AdminId,
                    CreatedAt = DateTime.Now,
                    Name = "Ryan Dominguez",
                    DocumentType = DocumentType.ImmigrationCard,
                    DocumentNumber = "001236789012345",
                    Email = "ryan@hotmail.com",
                    Phone = "555-111-2222",
                    Address = "789 Elm St, Chicago",
                    IsLegal = false
                },
                new ()
                {
                    ClientId = Guid.NewGuid(),
                    CreatedBy = AdminId,
                    CreatedAt = DateTime.Now,
                    Name = "Sofia Bazar",
                    DocumentType = DocumentType.RUC,
                    DocumentNumber = "24567890697",
                    Email = "sofia@gmail.com",
                    Phone = "555-444-5555",
                    Address = "456 Main St, New York",
                    IsLegal = true
                },
                new ()
                {
                    ClientId = Guid.NewGuid(),
                    CreatedBy = AdminId,
                    CreatedAt = DateTime.Now,
                    Name = "Thomas Philipp",
                    DocumentType = DocumentType.DNI,
                    DocumentNumber = "76543210",
                    Email = "thomas@yahoo.com",
                    Phone = "555-987-6543",
                    Address = "123 Oak Dr, Los Angeles",
                    IsLegal = false
                }
           };
        }
    }
}
