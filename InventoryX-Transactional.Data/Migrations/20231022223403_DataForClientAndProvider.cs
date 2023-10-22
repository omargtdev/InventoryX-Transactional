using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InventoryX_Transactional.Data.Migrations
{
    /// <inheritdoc />
    public partial class DataForClientAndProvider : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Provider",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 22, 17, 34, 3, 331, DateTimeKind.Local).AddTicks(269),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 22, 11, 52, 17, 373, DateTimeKind.Local).AddTicks(4844));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Client",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 22, 17, 34, 3, 330, DateTimeKind.Local).AddTicks(9358),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 22, 11, 52, 17, 373, DateTimeKind.Local).AddTicks(4315));

            migrationBuilder.InsertData(
                table: "Client",
                columns: new[] { "ClientId", "Address", "CreatedAt", "CreatedBy", "DocumentNumber", "DocumentType", "Email", "IsLegal", "ModifiedAt", "ModifiedBy", "Name", "Phone" },
                values: new object[,]
                {
                    { new Guid("0291ac52-7d67-415d-95c3-f13d5e1bde18"), "567 Cedar Ln, Houston", new DateTime(2023, 10, 22, 17, 34, 3, 330, DateTimeKind.Local).AddTicks(6694), new Guid("46dadb72-f4b7-400e-be4b-d58d36dc22dd"), "007654321098765", 3, "david@gmail.com", false, null, null, "David Aguilar", "555-456-7890" },
                    { new Guid("0692a703-5670-4f9c-a986-56fa040a9126"), "123 Cedar Ln, Los Angeles", new DateTime(2023, 10, 22, 17, 34, 3, 330, DateTimeKind.Local).AddTicks(9601), new Guid("46dadb72-f4b7-400e-be4b-d58d36dc22dd"), "76543210", 1, "ivy@gmail.com", false, null, null, "Ivy Williams", "555-987-6543" },
                    { new Guid("0cbb2dc5-eeb6-4660-b15f-023b0fc1cb05"), "123 Main St, New York", new DateTime(2023, 10, 22, 17, 34, 3, 330, DateTimeKind.Local).AddTicks(9608), new Guid("46dadb72-f4b7-400e-be4b-d58d36dc22dd"), "87654321", 1, "karen@gmail.com", false, null, null, "Karen Riques", "555-567-8901" },
                    { new Guid("0fde0983-a635-43e0-95dd-15fccf167262"), "456 Main St, New York", new DateTime(2023, 10, 22, 17, 34, 3, 330, DateTimeKind.Local).AddTicks(9583), new Guid("46dadb72-f4b7-400e-be4b-d58d36dc22dd"), "13456789012", 2, "eve@yahoo.com", false, null, null, "Eve Medina", "555-567-8901" },
                    { new Guid("1e07d6b2-b64d-4a3f-935a-2f01c655000b"), "321 Oak Dr, Los Angeles", new DateTime(2023, 10, 22, 17, 34, 3, 330, DateTimeKind.Local).AddTicks(6701), new Guid("46dadb72-f4b7-400e-be4b-d58d36dc22dd"), "54321678", 1, "frank@gmail.com", false, null, null, "Frank Jones", "555-987-6543" },
                    { new Guid("216b1298-51e3-46b3-8e51-386b855a7659"), "456 Maple Ave, New York", new DateTime(2023, 10, 22, 17, 34, 3, 330, DateTimeKind.Local).AddTicks(9598), new Guid("46dadb72-f4b7-400e-be4b-d58d36dc22dd"), "24567890123", 2, "holly@yahoo.com", true, null, null, "Holly Store S.A.", "555-444-5555" },
                    { new Guid("24e9c1e9-76d5-46d7-8982-a5dddd20b9b5"), "456 Elm St, Los Angeles", new DateTime(2023, 10, 22, 17, 34, 3, 330, DateTimeKind.Local).AddTicks(9574), new Guid("46dadb72-f4b7-400e-be4b-d58d36dc22dd"), "21345678901", 2, "bob@yahoo.com", true, null, null, "Pepitos S.A.C", "555-234-5678" },
                    { new Guid("2a5475ee-8f8c-41cd-9811-42bceb31fa32"), "123 Oak Dr, Los Angeles", new DateTime(2023, 10, 22, 17, 34, 3, 330, DateTimeKind.Local).AddTicks(6796), new Guid("46dadb72-f4b7-400e-be4b-d58d36dc22dd"), "76543210", 1, "thomas@yahoo.com", false, null, null, "Thomas Philipp", "555-987-6543" },
                    { new Guid("307f0a84-3b9d-4b56-956c-895f35329e86"), "789 Elm St, Chicago", new DateTime(2023, 10, 22, 17, 34, 3, 330, DateTimeKind.Local).AddTicks(6704), new Guid("46dadb72-f4b7-400e-be4b-d58d36dc22dd"), "002356789012345", 3, "grace@hotmail.com", false, null, null, "Grace", "555-111-2222" },
                    { new Guid("329c5534-14d7-4ace-a7f7-8ce1c0faacf3"), "789 Elm St, Chicago", new DateTime(2023, 10, 22, 17, 34, 3, 330, DateTimeKind.Local).AddTicks(9591), new Guid("46dadb72-f4b7-400e-be4b-d58d36dc22dd"), "002356789012345", 3, "grace@hotmail.com", false, null, null, "Grace", "555-111-2222" },
                    { new Guid("40e8ff14-fccf-4929-a979-522c04ffcce5"), "456 Elm St, Los Angeles", new DateTime(2023, 10, 22, 17, 34, 3, 330, DateTimeKind.Local).AddTicks(6768), new Guid("46dadb72-f4b7-400e-be4b-d58d36dc22dd"), "004567890123458", 3, "liam@yahoo.com", false, null, null, "Liam Nesson", "555-123-4567" },
                    { new Guid("53e869f0-a6d3-40a3-a9b7-9d04186d2b94"), "123 Maple Ave, Los Angeles", new DateTime(2023, 10, 22, 17, 34, 3, 330, DateTimeKind.Local).AddTicks(6784), new Guid("46dadb72-f4b7-400e-be4b-d58d36dc22dd"), "23456789012", 2, "parker@gmail.com", true, null, null, "Parker Corp.", "555-567-8901" },
                    { new Guid("54874129-ba8f-4b85-b313-029190422c20"), "456 Main St, New York", new DateTime(2023, 10, 22, 17, 34, 3, 330, DateTimeKind.Local).AddTicks(9618), new Guid("46dadb72-f4b7-400e-be4b-d58d36dc22dd"), "007654321098765", 3, "olivia@yahoo.com", false, null, null, "Olivia Fernandez", "555-456-7890" },
                    { new Guid("62c074b9-53cc-41bf-a33a-1cfa77d8923f"), "789 Oak Dr, Chicago", new DateTime(2023, 10, 22, 17, 34, 3, 330, DateTimeKind.Local).AddTicks(6691), new Guid("46dadb72-f4b7-400e-be4b-d58d36dc22dd"), "87654321", 1, "charlie@hotmail.com", false, null, null, "Charlie Martinez", "555-345-6789" },
                    { new Guid("6e34f5b4-0943-4a1c-99cf-9a4a0161e1af"), "456 Main St, New York", new DateTime(2023, 10, 22, 17, 34, 3, 330, DateTimeKind.Local).AddTicks(6697), new Guid("46dadb72-f4b7-400e-be4b-d58d36dc22dd"), "13456789012", 2, "eve@yahoo.com", false, null, null, "Eve Medina", "555-567-8901" },
                    { new Guid("816e040b-a42e-4001-b4d4-4151e1c37265"), "789 Oak Dr, Chicago", new DateTime(2023, 10, 22, 17, 34, 3, 330, DateTimeKind.Local).AddTicks(9577), new Guid("46dadb72-f4b7-400e-be4b-d58d36dc22dd"), "87654321", 1, "charlie@hotmail.com", false, null, null, "Charlie Martinez", "555-345-6789" },
                    { new Guid("8570332f-c566-449c-a22f-f6f3d6786fcf"), "456 Elm St, Los Angeles", new DateTime(2023, 10, 22, 17, 34, 3, 330, DateTimeKind.Local).AddTicks(9610), new Guid("46dadb72-f4b7-400e-be4b-d58d36dc22dd"), "004567890123458", 3, "liam@yahoo.com", false, null, null, "Liam Nesson", "555-123-4567" },
                    { new Guid("8d8b3dd5-3061-4f1f-8b85-cd4ae8d33b81"), "567 Cedar Ln, Houston", new DateTime(2023, 10, 22, 17, 34, 3, 330, DateTimeKind.Local).AddTicks(9580), new Guid("46dadb72-f4b7-400e-be4b-d58d36dc22dd"), "007654321098765", 3, "david@gmail.com", false, null, null, "David Aguilar", "555-456-7890" },
                    { new Guid("8e2d8daa-606e-45c2-98f3-f7fef8e23494"), "123 Main St, New York", new DateTime(2023, 10, 22, 17, 34, 3, 330, DateTimeKind.Local).AddTicks(6765), new Guid("46dadb72-f4b7-400e-be4b-d58d36dc22dd"), "87654321", 1, "karen@gmail.com", false, null, null, "Karen Riques", "555-567-8901" },
                    { new Guid("901d0afb-14d5-44df-ac87-c6c5f02acfbf"), "456 Main St, New York", new DateTime(2023, 10, 22, 17, 34, 3, 330, DateTimeKind.Local).AddTicks(9633), new Guid("46dadb72-f4b7-400e-be4b-d58d36dc22dd"), "24567890697", 2, "sofia@gmail.com", true, null, null, "Sofia Bazar", "555-444-5555" },
                    { new Guid("92103553-799a-4385-99ea-8aab44e9fc5c"), "321 Cedar Ln, Houston", new DateTime(2023, 10, 22, 17, 34, 3, 330, DateTimeKind.Local).AddTicks(9626), new Guid("46dadb72-f4b7-400e-be4b-d58d36dc22dd"), "54321678", 1, "quinn@yahoo.com", false, null, null, "Client Eastwood", "555-987-6543" },
                    { new Guid("995672a8-2064-41d0-856c-6bfae366c078"), "456 Maple Ave, New York", new DateTime(2023, 10, 22, 17, 34, 3, 330, DateTimeKind.Local).AddTicks(6723), new Guid("46dadb72-f4b7-400e-be4b-d58d36dc22dd"), "24567890123", 2, "holly@yahoo.com", true, null, null, "Holly Store S.A.", "555-444-5555" },
                    { new Guid("a7dff85e-a35a-4de5-aa6c-706e0a0684da"), "567 Cedar Ln, Houston", new DateTime(2023, 10, 22, 17, 34, 3, 330, DateTimeKind.Local).AddTicks(9616), new Guid("46dadb72-f4b7-400e-be4b-d58d36dc22dd"), "98765432", 1, "noah@hotmail.com", false, null, null, "Noah Azora", "555-345-6789" },
                    { new Guid("a8020912-dbed-4ff6-b730-f779008d927b"), "456 Oak Dr, Chicago", new DateTime(2023, 10, 22, 17, 34, 3, 330, DateTimeKind.Local).AddTicks(6762), new Guid("46dadb72-f4b7-400e-be4b-d58d36dc22dd"), "00345678601234", 3, "jack@hotmail.com", false, null, null, "Jack Smith", "555-333-4444" },
                    { new Guid("b03d3cb2-8b3c-42d0-a833-97cbe81d9705"), "789 Oak Dr, Chicago", new DateTime(2023, 10, 22, 17, 34, 3, 330, DateTimeKind.Local).AddTicks(9613), new Guid("46dadb72-f4b7-400e-be4b-d58d36dc22dd"), "22345228901", 2, "mia@gmail.com", true, null, null, "Mia Shop", "555-234-5678" },
                    { new Guid("b2229052-b97f-4baa-bcdf-3e38b693b486"), "789 Elm St, Chicago", new DateTime(2023, 10, 22, 17, 34, 3, 330, DateTimeKind.Local).AddTicks(6790), new Guid("46dadb72-f4b7-400e-be4b-d58d36dc22dd"), "001236789012345", 3, "ryan@hotmail.com", false, null, null, "Ryan Dominguez", "555-111-2222" },
                    { new Guid("b91c074e-e98b-4ded-9d7c-6cbe38170d7a"), "456 Main St, New York", new DateTime(2023, 10, 22, 17, 34, 3, 330, DateTimeKind.Local).AddTicks(6793), new Guid("46dadb72-f4b7-400e-be4b-d58d36dc22dd"), "24567890697", 2, "sofia@gmail.com", true, null, null, "Sofia Bazar", "555-444-5555" },
                    { new Guid("bb4ccddc-4706-4515-af0d-b856b5608847"), "123 Oak Dr, Los Angeles", new DateTime(2023, 10, 22, 17, 34, 3, 330, DateTimeKind.Local).AddTicks(9636), new Guid("46dadb72-f4b7-400e-be4b-d58d36dc22dd"), "76543210", 1, "thomas@yahoo.com", false, null, null, "Thomas Philipp", "555-987-6543" },
                    { new Guid("c0278887-92ec-4f2a-ba81-65b99e28cd0b"), "321 Cedar Ln, Houston", new DateTime(2023, 10, 22, 17, 34, 3, 330, DateTimeKind.Local).AddTicks(6786), new Guid("46dadb72-f4b7-400e-be4b-d58d36dc22dd"), "54321678", 1, "quinn@yahoo.com", false, null, null, "Client Eastwood", "555-987-6543" },
                    { new Guid("ce2d6792-aa82-4fe6-a83f-8bfdbecb2877"), "123 Cedar Ln, Los Angeles", new DateTime(2023, 10, 22, 17, 34, 3, 330, DateTimeKind.Local).AddTicks(6726), new Guid("46dadb72-f4b7-400e-be4b-d58d36dc22dd"), "76543210", 1, "ivy@gmail.com", false, null, null, "Ivy Williams", "555-987-6543" },
                    { new Guid("d01efb5b-8fdf-41c7-8ea5-3bad50388169"), "567 Cedar Ln, Houston", new DateTime(2023, 10, 22, 17, 34, 3, 330, DateTimeKind.Local).AddTicks(6774), new Guid("46dadb72-f4b7-400e-be4b-d58d36dc22dd"), "98765432", 1, "noah@hotmail.com", false, null, null, "Noah Azora", "555-345-6789" },
                    { new Guid("d4b75d97-1403-4a32-8fc4-148893a01858"), "456 Main St, New York", new DateTime(2023, 10, 22, 17, 34, 3, 330, DateTimeKind.Local).AddTicks(6777), new Guid("46dadb72-f4b7-400e-be4b-d58d36dc22dd"), "007654321098765", 3, "olivia@yahoo.com", false, null, null, "Olivia Fernandez", "555-456-7890" },
                    { new Guid("d65466d1-d593-4e26-b041-35d40fd6b6f7"), "456 Elm St, Los Angeles", new DateTime(2023, 10, 22, 17, 34, 3, 330, DateTimeKind.Local).AddTicks(6685), new Guid("46dadb72-f4b7-400e-be4b-d58d36dc22dd"), "21345678901", 2, "bob@yahoo.com", true, null, null, "Pepitos S.A.C", "555-234-5678" },
                    { new Guid("d74a7786-f6f4-4076-a971-83078352f532"), "123 Main St, New York", new DateTime(2023, 10, 22, 17, 34, 3, 330, DateTimeKind.Local).AddTicks(6676), new Guid("46dadb72-f4b7-400e-be4b-d58d36dc22dd"), "12345678", 1, "alice@gmail.com", false, null, null, "Alice Chains", "555-123-4567" },
                    { new Guid("df1c9a6d-7935-47af-a2f0-9efb1cf7170d"), "123 Maple Ave, Los Angeles", new DateTime(2023, 10, 22, 17, 34, 3, 330, DateTimeKind.Local).AddTicks(9623), new Guid("46dadb72-f4b7-400e-be4b-d58d36dc22dd"), "23456789012", 2, "parker@gmail.com", true, null, null, "Parker Corp.", "555-567-8901" },
                    { new Guid("df366bb1-4442-4da1-a6fa-09ba5fe4b691"), "456 Oak Dr, Chicago", new DateTime(2023, 10, 22, 17, 34, 3, 330, DateTimeKind.Local).AddTicks(9605), new Guid("46dadb72-f4b7-400e-be4b-d58d36dc22dd"), "00345678601234", 3, "jack@hotmail.com", false, null, null, "Jack Smith", "555-333-4444" },
                    { new Guid("dfdd52a6-e221-4ece-9f80-249502840f75"), "789 Oak Dr, Chicago", new DateTime(2023, 10, 22, 17, 34, 3, 330, DateTimeKind.Local).AddTicks(6771), new Guid("46dadb72-f4b7-400e-be4b-d58d36dc22dd"), "22345228901", 2, "mia@gmail.com", true, null, null, "Mia Shop", "555-234-5678" },
                    { new Guid("ee603878-f0e6-4c00-a39a-e206349de6e3"), "123 Main St, New York", new DateTime(2023, 10, 22, 17, 34, 3, 330, DateTimeKind.Local).AddTicks(9569), new Guid("46dadb72-f4b7-400e-be4b-d58d36dc22dd"), "12345678", 1, "alice@gmail.com", false, null, null, "Alice Chains", "555-123-4567" },
                    { new Guid("ee7a5082-af4f-4586-b3bc-3137ed83c485"), "321 Oak Dr, Los Angeles", new DateTime(2023, 10, 22, 17, 34, 3, 330, DateTimeKind.Local).AddTicks(9588), new Guid("46dadb72-f4b7-400e-be4b-d58d36dc22dd"), "54321678", 1, "frank@gmail.com", false, null, null, "Frank Jones", "555-987-6543" },
                    { new Guid("f8c93620-042e-464c-86be-f05b56e7db1f"), "789 Elm St, Chicago", new DateTime(2023, 10, 22, 17, 34, 3, 330, DateTimeKind.Local).AddTicks(9630), new Guid("46dadb72-f4b7-400e-be4b-d58d36dc22dd"), "001236789012345", 3, "ryan@hotmail.com", false, null, null, "Ryan Dominguez", "555-111-2222" }
                });

            migrationBuilder.InsertData(
                table: "Provider",
                columns: new[] { "ProviderId", "Address", "BusinessName", "ContactEmail", "ContactPhone", "CreatedAt", "CreatedBy", "ModifiedAt", "ModifiedBy", "RUC" },
                values: new object[,]
                {
                    { new Guid("00437607-dca0-458b-b618-5aa969abbe4d"), "573-5782 Ut Avenue", "In Foundation", "fringilla.euismod.enim@outlook.couk", "(812) 908-3601", new DateTime(2023, 10, 22, 17, 34, 3, 330, DateTimeKind.Local).AddTicks(8261), new Guid("46dadb72-f4b7-400e-be4b-d58d36dc22dd"), null, null, "23374028741" },
                    { new Guid("06566d2c-745c-486b-a790-491f20719c3f"), "733-4722 Mi. Avenue", "Enim Sit Ltd", "ut.aliquam@icloud.com", "1-696-562-7023", new DateTime(2023, 10, 22, 17, 34, 3, 331, DateTimeKind.Local).AddTicks(509), new Guid("46dadb72-f4b7-400e-be4b-d58d36dc22dd"), null, null, "28352851057" },
                    { new Guid("12468e86-2840-4f4c-af31-88a687a2c0f8"), "Ap #121-5878 Nulla. St.", "Egestas Rhoncus Corp.", "pede@icloud.net", "(487) 387-0723", new DateTime(2023, 10, 22, 17, 34, 3, 331, DateTimeKind.Local).AddTicks(465), new Guid("46dadb72-f4b7-400e-be4b-d58d36dc22dd"), null, null, "21438271486" },
                    { new Guid("13fe8d89-da49-49c5-8983-c6ceeef36f08"), "P.O. Box 145, 8931 Vitae Rd.", "Elit A Feugiat Corp.", "consectetuer.ipsum.nunc@hotmail.net", "(445) 745-2317", new DateTime(2023, 10, 22, 17, 34, 3, 331, DateTimeKind.Local).AddTicks(478), new Guid("46dadb72-f4b7-400e-be4b-d58d36dc22dd"), null, null, "28163725354" },
                    { new Guid("1b86e2bb-2b6b-49b9-bd2d-d32fe6960b8d"), "716-9139 Lectus, Road", "Feugiat Nec Foundation", "ut.tincidunt@yahoo.net", "1-324-172-5394", new DateTime(2023, 10, 22, 17, 34, 3, 330, DateTimeKind.Local).AddTicks(8178), new Guid("46dadb72-f4b7-400e-be4b-d58d36dc22dd"), null, null, "21425812564" },
                    { new Guid("1e307fb0-139f-4e7b-95f3-7ceeeda49dec"), "201 Auctor Rd.", "Malesuada Associates", "ut.mi@icloud.com", "1-531-938-2251", new DateTime(2023, 10, 22, 17, 34, 3, 331, DateTimeKind.Local).AddTicks(507), new Guid("46dadb72-f4b7-400e-be4b-d58d36dc22dd"), null, null, "28654072941" },
                    { new Guid("21c74117-3b4f-47e6-9685-e17ffab7470f"), "318-3230 Urna. Rd.", "Nibh Donec Est Institute", "proin.non.massa@aol.org", "1-854-225-3383", new DateTime(2023, 10, 22, 17, 34, 3, 330, DateTimeKind.Local).AddTicks(8216), new Guid("46dadb72-f4b7-400e-be4b-d58d36dc22dd"), null, null, "24821225133" },
                    { new Guid("3220758c-59e0-4b11-b6a7-2ccb757c13dd"), "523-8707 Et Rd.", "Nullam Nisl Maecenas PC", "vulputate@protonmail.couk", "(685) 481-5523", new DateTime(2023, 10, 22, 17, 34, 3, 330, DateTimeKind.Local).AddTicks(8192), new Guid("46dadb72-f4b7-400e-be4b-d58d36dc22dd"), null, null, "23414517112" },
                    { new Guid("3a03223f-6ee1-4eb5-9ec8-3279e96504b6"), "716-9139 Lectus, Road", "Feugiat Nec Foundation", "ut.tincidunt@yahoo.net", "1-324-172-5394", new DateTime(2023, 10, 22, 17, 34, 3, 331, DateTimeKind.Local).AddTicks(456), new Guid("46dadb72-f4b7-400e-be4b-d58d36dc22dd"), null, null, "21425812564" },
                    { new Guid("4a7eb499-8102-4ac7-a056-7ac5ccb8e833"), "P.O. Box 367, 4325 Augue Rd.", "Augue Corporation", "in.tempus@google.com", "(498) 810-4710", new DateTime(2023, 10, 22, 17, 34, 3, 331, DateTimeKind.Local).AddTicks(419), new Guid("46dadb72-f4b7-400e-be4b-d58d36dc22dd"), null, null, "28851161316" },
                    { new Guid("547f0486-2a83-4037-a766-a928d949473a"), "430-6187 Malesuada Ave", "Lorem Ipsum Institute", "orci.donec.nibh@aol.ca", "(747) 407-6648", new DateTime(2023, 10, 22, 17, 34, 3, 331, DateTimeKind.Local).AddTicks(484), new Guid("46dadb72-f4b7-400e-be4b-d58d36dc22dd"), null, null, "24334730132" },
                    { new Guid("54eba86d-f2f3-4b93-9bc8-8e463337fe76"), "201 Auctor Rd.", "Malesuada Associates", "ut.mi@icloud.com", "1-531-938-2251", new DateTime(2023, 10, 22, 17, 34, 3, 330, DateTimeKind.Local).AddTicks(8268), new Guid("46dadb72-f4b7-400e-be4b-d58d36dc22dd"), null, null, "28654072941" },
                    { new Guid("6d51b030-22c9-4d1a-9791-9ef2116c061d"), "733-4722 Mi. Avenue", "Enim Sit Ltd", "ut.aliquam@icloud.com", "1-696-562-7023", new DateTime(2023, 10, 22, 17, 34, 3, 330, DateTimeKind.Local).AddTicks(8271), new Guid("46dadb72-f4b7-400e-be4b-d58d36dc22dd"), null, null, "28352851057" },
                    { new Guid("736e1fbd-dc1a-4356-8495-dbaaac682822"), "523-8707 Et Rd.", "Nullam Nisl Maecenas PC", "vulputate@protonmail.couk", "(685) 481-5523", new DateTime(2023, 10, 22, 17, 34, 3, 331, DateTimeKind.Local).AddTicks(468), new Guid("46dadb72-f4b7-400e-be4b-d58d36dc22dd"), null, null, "23414517112" },
                    { new Guid("74555b2d-ff80-485a-89bb-7ceadd13aa8b"), "2259 Nunc St.", "At Associates", "ac@icloud.ca", "1-335-797-0988", new DateTime(2023, 10, 22, 17, 34, 3, 331, DateTimeKind.Local).AddTicks(486), new Guid("46dadb72-f4b7-400e-be4b-d58d36dc22dd"), null, null, "25016570928" },
                    { new Guid("77e0147a-4d08-4d40-bd85-0fd15dd6eedf"), "573-5782 Ut Avenue", "In Foundation", "fringilla.euismod.enim@outlook.couk", "(812) 908-3601", new DateTime(2023, 10, 22, 17, 34, 3, 331, DateTimeKind.Local).AddTicks(501), new Guid("46dadb72-f4b7-400e-be4b-d58d36dc22dd"), null, null, "23374028741" },
                    { new Guid("78f3c3c6-67e2-4a74-8853-a6d84c0d49c8"), "P.O. Box 398, 5701 Enim Ave", "Suspendisse Tristique Neque Foundation", "sed@aol.com", "(548) 947-6178", new DateTime(2023, 10, 22, 17, 34, 3, 331, DateTimeKind.Local).AddTicks(503), new Guid("46dadb72-f4b7-400e-be4b-d58d36dc22dd"), null, null, "23886134764" },
                    { new Guid("795cc4c5-c513-4962-be5c-6f7c25f93b18"), "P.O. Box 604, 2268 Ac St.", "Massa Limited", "at.libero.morbi@google.couk", "1-628-221-7892", new DateTime(2023, 10, 22, 17, 34, 3, 330, DateTimeKind.Local).AddTicks(8276), new Guid("46dadb72-f4b7-400e-be4b-d58d36dc22dd"), null, null, "22184652687" },
                    { new Guid("7a25bbba-3bf8-432c-8774-d00444616dad"), "Ap #312-3859 Arcu. Street", "Vitae Velit LLC", "at@icloud.ca", "1-202-357-4151", new DateTime(2023, 10, 22, 17, 34, 3, 331, DateTimeKind.Local).AddTicks(480), new Guid("46dadb72-f4b7-400e-be4b-d58d36dc22dd"), null, null, "20177426605" },
                    { new Guid("7ab86fca-0a1e-4d50-b721-54fa0a9d5cea"), "P.O. Box 994, 6300 Id Rd.", "Dis Parturient Montes Associates", "donec.luctus@aol.edu", "1-948-625-3851", new DateTime(2023, 10, 22, 17, 34, 3, 330, DateTimeKind.Local).AddTicks(8182), new Guid("46dadb72-f4b7-400e-be4b-d58d36dc22dd"), null, null, "20907865658" },
                    { new Guid("7c280667-5ef4-495f-be96-6e452d641375"), "P.O. Box 994, 6300 Id Rd.", "Dis Parturient Montes Associates", "donec.luctus@aol.edu", "1-948-625-3851", new DateTime(2023, 10, 22, 17, 34, 3, 331, DateTimeKind.Local).AddTicks(459), new Guid("46dadb72-f4b7-400e-be4b-d58d36dc22dd"), null, null, "20907865658" },
                    { new Guid("7c504e79-0d6f-4a2c-8d95-e7146d077a4b"), "2259 Nunc St.", "At Associates", "ac@icloud.ca", "1-335-797-0988", new DateTime(2023, 10, 22, 17, 34, 3, 330, DateTimeKind.Local).AddTicks(8211), new Guid("46dadb72-f4b7-400e-be4b-d58d36dc22dd"), null, null, "25016570928" },
                    { new Guid("7dad4b4f-8fc3-4fab-9c61-c5f2f23fc2ed"), "P.O. Box 367, 4325 Augue Rd.", "Augue Corporation", "in.tempus@google.com", "(498) 810-4710", new DateTime(2023, 10, 22, 17, 34, 3, 330, DateTimeKind.Local).AddTicks(8172), new Guid("46dadb72-f4b7-400e-be4b-d58d36dc22dd"), null, null, "28851161316" },
                    { new Guid("8858d818-9f0e-4f3d-b5d8-ba6c09332d6d"), "430-6187 Malesuada Ave", "Lorem Ipsum Institute", "orci.donec.nibh@aol.ca", "(747) 407-6648", new DateTime(2023, 10, 22, 17, 34, 3, 330, DateTimeKind.Local).AddTicks(8209), new Guid("46dadb72-f4b7-400e-be4b-d58d36dc22dd"), null, null, "24334730132" },
                    { new Guid("8c4181da-be81-4d1b-a0d5-a68844851d5c"), "Ap #717-2261 Mi Avenue", "Sem Limited", "lacinia@yahoo.ca", "(512) 376-4277", new DateTime(2023, 10, 22, 17, 34, 3, 331, DateTimeKind.Local).AddTicks(475), new Guid("46dadb72-f4b7-400e-be4b-d58d36dc22dd"), null, null, "27145868620" },
                    { new Guid("922ddff3-4c1d-4418-9173-8bcfe25dec1d"), "Ap #398-2179 Ligula Rd.", "Laoreet Posuere Ltd", "quis@yahoo.org", "1-331-293-1812", new DateTime(2023, 10, 22, 17, 34, 3, 331, DateTimeKind.Local).AddTicks(498), new Guid("46dadb72-f4b7-400e-be4b-d58d36dc22dd"), null, null, "20381813145" },
                    { new Guid("9efb88a7-5e09-43eb-8502-60bb3f004edc"), "163-409 In, Rd.", "Proin Eget Institute", "lobortis.mauris@google.net", "1-640-831-2711", new DateTime(2023, 10, 22, 17, 34, 3, 331, DateTimeKind.Local).AddTicks(496), new Guid("46dadb72-f4b7-400e-be4b-d58d36dc22dd"), null, null, "24419741745" },
                    { new Guid("a4cde0ff-0e29-4aae-9a6f-180da35dd705"), "Ap #645-3636 Conubia Av.", "Erat Volutpat Inc.", "elit.pretium@icloud.com", "(681) 652-3427", new DateTime(2023, 10, 22, 17, 34, 3, 330, DateTimeKind.Local).AddTicks(8219), new Guid("46dadb72-f4b7-400e-be4b-d58d36dc22dd"), null, null, "21546823173" },
                    { new Guid("a80b8878-04b4-447a-be6c-b024c790c7cd"), "318-3230 Urna. Rd.", "Nibh Donec Est Institute", "proin.non.massa@aol.org", "1-854-225-3383", new DateTime(2023, 10, 22, 17, 34, 3, 331, DateTimeKind.Local).AddTicks(491), new Guid("46dadb72-f4b7-400e-be4b-d58d36dc22dd"), null, null, "24821225133" },
                    { new Guid("b0a64515-d646-4be6-9e45-5a08007f0838"), "Ap #121-5878 Nulla. St.", "Egestas Rhoncus Corp.", "pede@icloud.net", "(487) 387-0723", new DateTime(2023, 10, 22, 17, 34, 3, 330, DateTimeKind.Local).AddTicks(8189), new Guid("46dadb72-f4b7-400e-be4b-d58d36dc22dd"), null, null, "21438271486" },
                    { new Guid("b7bd3fb7-2c2b-4cb2-a794-9948a27432b2"), "Ap #398-2179 Ligula Rd.", "Laoreet Posuere Ltd", "quis@yahoo.org", "1-331-293-1812", new DateTime(2023, 10, 22, 17, 34, 3, 330, DateTimeKind.Local).AddTicks(8258), new Guid("46dadb72-f4b7-400e-be4b-d58d36dc22dd"), null, null, "20381813145" },
                    { new Guid("b8e60311-5d9a-4050-af72-e72064644b44"), "P.O. Box 604, 2268 Ac St.", "Massa Limited", "at.libero.morbi@google.couk", "1-628-221-7892", new DateTime(2023, 10, 22, 17, 34, 3, 331, DateTimeKind.Local).AddTicks(514), new Guid("46dadb72-f4b7-400e-be4b-d58d36dc22dd"), null, null, "22184652687" },
                    { new Guid("c1d0f324-0ab4-4fc4-a12b-b47d5ff4b75d"), "P.O. Box 145, 8931 Vitae Rd.", "Elit A Feugiat Corp.", "consectetuer.ipsum.nunc@hotmail.net", "(445) 745-2317", new DateTime(2023, 10, 22, 17, 34, 3, 330, DateTimeKind.Local).AddTicks(8202), new Guid("46dadb72-f4b7-400e-be4b-d58d36dc22dd"), null, null, "28163725354" },
                    { new Guid("c9edfcde-e32d-4013-8610-b3054d84d111"), "Ap #312-3859 Arcu. Street", "Vitae Velit LLC", "at@icloud.ca", "1-202-357-4151", new DateTime(2023, 10, 22, 17, 34, 3, 330, DateTimeKind.Local).AddTicks(8204), new Guid("46dadb72-f4b7-400e-be4b-d58d36dc22dd"), null, null, "20177426605" },
                    { new Guid("cacedb40-c9a5-4fac-be38-49fa3be1277e"), "P.O. Box 398, 5701 Enim Ave", "Suspendisse Tristique Neque Foundation", "sed@aol.com", "(548) 947-6178", new DateTime(2023, 10, 22, 17, 34, 3, 330, DateTimeKind.Local).AddTicks(8264), new Guid("46dadb72-f4b7-400e-be4b-d58d36dc22dd"), null, null, "23886134764" },
                    { new Guid("cb00e59b-ccbe-4107-9ee3-6a6d140d336b"), "938-7069 Lobortis, Av.", "Turpis Egestas Fusce Inc.", "donec.feugiat.metus@google.ca", "(744) 465-4414", new DateTime(2023, 10, 22, 17, 34, 3, 331, DateTimeKind.Local).AddTicks(472), new Guid("46dadb72-f4b7-400e-be4b-d58d36dc22dd"), null, null, "20534218461" },
                    { new Guid("cf8ff22e-ae10-4956-bacf-dea02702e228"), "Ap #645-3636 Conubia Av.", "Erat Volutpat Inc.", "elit.pretium@icloud.com", "(681) 652-3427", new DateTime(2023, 10, 22, 17, 34, 3, 331, DateTimeKind.Local).AddTicks(493), new Guid("46dadb72-f4b7-400e-be4b-d58d36dc22dd"), null, null, "21546823173" },
                    { new Guid("d56f024e-27f8-45df-b496-07b8d0e88832"), "Ap #717-2261 Mi Avenue", "Sem Limited", "lacinia@yahoo.ca", "(512) 376-4277", new DateTime(2023, 10, 22, 17, 34, 3, 330, DateTimeKind.Local).AddTicks(8199), new Guid("46dadb72-f4b7-400e-be4b-d58d36dc22dd"), null, null, "27145868620" },
                    { new Guid("e4076494-29fb-4884-b475-b0a5b7a31a44"), "938-7069 Lobortis, Av.", "Turpis Egestas Fusce Inc.", "donec.feugiat.metus@google.ca", "(744) 465-4414", new DateTime(2023, 10, 22, 17, 34, 3, 330, DateTimeKind.Local).AddTicks(8196), new Guid("46dadb72-f4b7-400e-be4b-d58d36dc22dd"), null, null, "20534218461" },
                    { new Guid("f75677d3-e332-41c3-987c-f4004821b368"), "163-409 In, Rd.", "Proin Eget Institute", "lobortis.mauris@google.net", "1-640-831-2711", new DateTime(2023, 10, 22, 17, 34, 3, 330, DateTimeKind.Local).AddTicks(8254), new Guid("46dadb72-f4b7-400e-be4b-d58d36dc22dd"), null, null, "24419741745" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: new Guid("0291ac52-7d67-415d-95c3-f13d5e1bde18"));

            migrationBuilder.DeleteData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: new Guid("0692a703-5670-4f9c-a986-56fa040a9126"));

            migrationBuilder.DeleteData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: new Guid("0cbb2dc5-eeb6-4660-b15f-023b0fc1cb05"));

            migrationBuilder.DeleteData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: new Guid("0fde0983-a635-43e0-95dd-15fccf167262"));

            migrationBuilder.DeleteData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: new Guid("1e07d6b2-b64d-4a3f-935a-2f01c655000b"));

            migrationBuilder.DeleteData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: new Guid("216b1298-51e3-46b3-8e51-386b855a7659"));

            migrationBuilder.DeleteData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: new Guid("24e9c1e9-76d5-46d7-8982-a5dddd20b9b5"));

            migrationBuilder.DeleteData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: new Guid("2a5475ee-8f8c-41cd-9811-42bceb31fa32"));

            migrationBuilder.DeleteData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: new Guid("307f0a84-3b9d-4b56-956c-895f35329e86"));

            migrationBuilder.DeleteData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: new Guid("329c5534-14d7-4ace-a7f7-8ce1c0faacf3"));

            migrationBuilder.DeleteData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: new Guid("40e8ff14-fccf-4929-a979-522c04ffcce5"));

            migrationBuilder.DeleteData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: new Guid("53e869f0-a6d3-40a3-a9b7-9d04186d2b94"));

            migrationBuilder.DeleteData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: new Guid("54874129-ba8f-4b85-b313-029190422c20"));

            migrationBuilder.DeleteData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: new Guid("62c074b9-53cc-41bf-a33a-1cfa77d8923f"));

            migrationBuilder.DeleteData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: new Guid("6e34f5b4-0943-4a1c-99cf-9a4a0161e1af"));

            migrationBuilder.DeleteData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: new Guid("816e040b-a42e-4001-b4d4-4151e1c37265"));

            migrationBuilder.DeleteData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: new Guid("8570332f-c566-449c-a22f-f6f3d6786fcf"));

            migrationBuilder.DeleteData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: new Guid("8d8b3dd5-3061-4f1f-8b85-cd4ae8d33b81"));

            migrationBuilder.DeleteData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: new Guid("8e2d8daa-606e-45c2-98f3-f7fef8e23494"));

            migrationBuilder.DeleteData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: new Guid("901d0afb-14d5-44df-ac87-c6c5f02acfbf"));

            migrationBuilder.DeleteData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: new Guid("92103553-799a-4385-99ea-8aab44e9fc5c"));

            migrationBuilder.DeleteData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: new Guid("995672a8-2064-41d0-856c-6bfae366c078"));

            migrationBuilder.DeleteData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: new Guid("a7dff85e-a35a-4de5-aa6c-706e0a0684da"));

            migrationBuilder.DeleteData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: new Guid("a8020912-dbed-4ff6-b730-f779008d927b"));

            migrationBuilder.DeleteData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: new Guid("b03d3cb2-8b3c-42d0-a833-97cbe81d9705"));

            migrationBuilder.DeleteData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: new Guid("b2229052-b97f-4baa-bcdf-3e38b693b486"));

            migrationBuilder.DeleteData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: new Guid("b91c074e-e98b-4ded-9d7c-6cbe38170d7a"));

            migrationBuilder.DeleteData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: new Guid("bb4ccddc-4706-4515-af0d-b856b5608847"));

            migrationBuilder.DeleteData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: new Guid("c0278887-92ec-4f2a-ba81-65b99e28cd0b"));

            migrationBuilder.DeleteData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: new Guid("ce2d6792-aa82-4fe6-a83f-8bfdbecb2877"));

            migrationBuilder.DeleteData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: new Guid("d01efb5b-8fdf-41c7-8ea5-3bad50388169"));

            migrationBuilder.DeleteData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: new Guid("d4b75d97-1403-4a32-8fc4-148893a01858"));

            migrationBuilder.DeleteData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: new Guid("d65466d1-d593-4e26-b041-35d40fd6b6f7"));

            migrationBuilder.DeleteData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: new Guid("d74a7786-f6f4-4076-a971-83078352f532"));

            migrationBuilder.DeleteData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: new Guid("df1c9a6d-7935-47af-a2f0-9efb1cf7170d"));

            migrationBuilder.DeleteData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: new Guid("df366bb1-4442-4da1-a6fa-09ba5fe4b691"));

            migrationBuilder.DeleteData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: new Guid("dfdd52a6-e221-4ece-9f80-249502840f75"));

            migrationBuilder.DeleteData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: new Guid("ee603878-f0e6-4c00-a39a-e206349de6e3"));

            migrationBuilder.DeleteData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: new Guid("ee7a5082-af4f-4586-b3bc-3137ed83c485"));

            migrationBuilder.DeleteData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: new Guid("f8c93620-042e-464c-86be-f05b56e7db1f"));

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderId",
                keyValue: new Guid("00437607-dca0-458b-b618-5aa969abbe4d"));

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderId",
                keyValue: new Guid("06566d2c-745c-486b-a790-491f20719c3f"));

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderId",
                keyValue: new Guid("12468e86-2840-4f4c-af31-88a687a2c0f8"));

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderId",
                keyValue: new Guid("13fe8d89-da49-49c5-8983-c6ceeef36f08"));

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderId",
                keyValue: new Guid("1b86e2bb-2b6b-49b9-bd2d-d32fe6960b8d"));

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderId",
                keyValue: new Guid("1e307fb0-139f-4e7b-95f3-7ceeeda49dec"));

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderId",
                keyValue: new Guid("21c74117-3b4f-47e6-9685-e17ffab7470f"));

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderId",
                keyValue: new Guid("3220758c-59e0-4b11-b6a7-2ccb757c13dd"));

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderId",
                keyValue: new Guid("3a03223f-6ee1-4eb5-9ec8-3279e96504b6"));

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderId",
                keyValue: new Guid("4a7eb499-8102-4ac7-a056-7ac5ccb8e833"));

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderId",
                keyValue: new Guid("547f0486-2a83-4037-a766-a928d949473a"));

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderId",
                keyValue: new Guid("54eba86d-f2f3-4b93-9bc8-8e463337fe76"));

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderId",
                keyValue: new Guid("6d51b030-22c9-4d1a-9791-9ef2116c061d"));

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderId",
                keyValue: new Guid("736e1fbd-dc1a-4356-8495-dbaaac682822"));

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderId",
                keyValue: new Guid("74555b2d-ff80-485a-89bb-7ceadd13aa8b"));

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderId",
                keyValue: new Guid("77e0147a-4d08-4d40-bd85-0fd15dd6eedf"));

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderId",
                keyValue: new Guid("78f3c3c6-67e2-4a74-8853-a6d84c0d49c8"));

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderId",
                keyValue: new Guid("795cc4c5-c513-4962-be5c-6f7c25f93b18"));

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderId",
                keyValue: new Guid("7a25bbba-3bf8-432c-8774-d00444616dad"));

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderId",
                keyValue: new Guid("7ab86fca-0a1e-4d50-b721-54fa0a9d5cea"));

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderId",
                keyValue: new Guid("7c280667-5ef4-495f-be96-6e452d641375"));

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderId",
                keyValue: new Guid("7c504e79-0d6f-4a2c-8d95-e7146d077a4b"));

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderId",
                keyValue: new Guid("7dad4b4f-8fc3-4fab-9c61-c5f2f23fc2ed"));

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderId",
                keyValue: new Guid("8858d818-9f0e-4f3d-b5d8-ba6c09332d6d"));

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderId",
                keyValue: new Guid("8c4181da-be81-4d1b-a0d5-a68844851d5c"));

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderId",
                keyValue: new Guid("922ddff3-4c1d-4418-9173-8bcfe25dec1d"));

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderId",
                keyValue: new Guid("9efb88a7-5e09-43eb-8502-60bb3f004edc"));

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderId",
                keyValue: new Guid("a4cde0ff-0e29-4aae-9a6f-180da35dd705"));

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderId",
                keyValue: new Guid("a80b8878-04b4-447a-be6c-b024c790c7cd"));

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderId",
                keyValue: new Guid("b0a64515-d646-4be6-9e45-5a08007f0838"));

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderId",
                keyValue: new Guid("b7bd3fb7-2c2b-4cb2-a794-9948a27432b2"));

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderId",
                keyValue: new Guid("b8e60311-5d9a-4050-af72-e72064644b44"));

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderId",
                keyValue: new Guid("c1d0f324-0ab4-4fc4-a12b-b47d5ff4b75d"));

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderId",
                keyValue: new Guid("c9edfcde-e32d-4013-8610-b3054d84d111"));

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderId",
                keyValue: new Guid("cacedb40-c9a5-4fac-be38-49fa3be1277e"));

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderId",
                keyValue: new Guid("cb00e59b-ccbe-4107-9ee3-6a6d140d336b"));

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderId",
                keyValue: new Guid("cf8ff22e-ae10-4956-bacf-dea02702e228"));

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderId",
                keyValue: new Guid("d56f024e-27f8-45df-b496-07b8d0e88832"));

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderId",
                keyValue: new Guid("e4076494-29fb-4884-b475-b0a5b7a31a44"));

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "ProviderId",
                keyValue: new Guid("f75677d3-e332-41c3-987c-f4004821b368"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Provider",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 22, 11, 52, 17, 373, DateTimeKind.Local).AddTicks(4844),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 22, 17, 34, 3, 331, DateTimeKind.Local).AddTicks(269));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Client",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 22, 11, 52, 17, 373, DateTimeKind.Local).AddTicks(4315),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 22, 17, 34, 3, 330, DateTimeKind.Local).AddTicks(9358));
        }
    }
}
