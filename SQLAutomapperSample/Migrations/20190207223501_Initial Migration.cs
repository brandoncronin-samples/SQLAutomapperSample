using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SQLAutomapperSample.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SampleOrderDbSet",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OrderKey = table.Column<Guid>(nullable: false),
                    OrderTypeKey = table.Column<Guid>(nullable: false),
                    OrderStatusKey = table.Column<Guid>(nullable: false),
                    OrderNo = table.Column<string>(nullable: true),
                    ResidentKey = table.Column<Guid>(nullable: false),
                    Item = table.Column<string>(nullable: true),
                    ItemDescription = table.Column<string>(nullable: true),
                    Quantity = table.Column<decimal>(nullable: false),
                    QuantityMax = table.Column<decimal>(nullable: false),
                    UOM = table.Column<string>(nullable: true),
                    Total = table.Column<decimal>(nullable: false),
                    ScheduleKey = table.Column<Guid>(nullable: false),
                    SiteKey = table.Column<Guid>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    VaccinationKey = table.Column<Guid>(nullable: false),
                    SubmittedByKey = table.Column<Guid>(nullable: false),
                    SubmittedDatetime = table.Column<DateTime>(nullable: false),
                    DiscontinuedByKey = table.Column<Guid>(nullable: false),
                    DiscontinuedDatetime = table.Column<DateTime>(nullable: false),
                    DeliveryMethodKey = table.Column<Guid>(nullable: false),
                    PRN = table.Column<bool>(nullable: false),
                    Instructions = table.Column<string>(nullable: true),
                    Comment = table.Column<string>(nullable: true),
                    SendToPharmacy = table.Column<bool>(nullable: false),
                    GCN_SEQNO = table.Column<decimal>(nullable: false),
                    DEA = table.Column<byte>(nullable: false),
                    ForPain = table.Column<bool>(nullable: false),
                    DoNotCrush = table.Column<bool>(nullable: false),
                    TranscribeMethod = table.Column<string>(nullable: true),
                    TranscribedForKey = table.Column<Guid>(nullable: false),
                    OffFormulary = table.Column<bool>(nullable: false),
                    ProfileOrder = table.Column<bool>(nullable: false),
                    DurationDays = table.Column<short>(nullable: false),
                    Refills = table.Column<byte>(nullable: false),
                    RefillMaxDays = table.Column<short>(nullable: false),
                    KopPrivilegeStatusId = table.Column<byte>(nullable: false),
                    PharmacyDeliveryTypeId = table.Column<byte>(nullable: false),
                    ModifyDate = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<Guid>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    FP = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SampleOrderDbSet", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SampleOrderDbSet");
        }
    }
}
