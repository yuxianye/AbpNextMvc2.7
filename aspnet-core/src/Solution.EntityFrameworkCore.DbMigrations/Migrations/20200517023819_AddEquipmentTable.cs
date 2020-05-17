using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Solution.Migrations
{
    public partial class AddEquipmentTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppEquipment",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ExtraProperties = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<Guid>(nullable: true),
                    EquipmentTypeId = table.Column<Guid>(nullable: false),
                    EquipmentBrandId = table.Column<Guid>(nullable: false),
                    EquipmentCode = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Specification = table.Column<string>(nullable: true),
                    ManufactureDate = table.Column<DateTime>(nullable: false),
                    EquipmentStatusId = table.Column<Guid>(nullable: true),
                    Remark = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppEquipment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppEquipmentBrands",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ExtraProperties = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<Guid>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Remark = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppEquipmentBrands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppEquipmentInspectionResults",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ExtraProperties = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<Guid>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Remark = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppEquipmentInspectionResults", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppEquipmentInspections",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ExtraProperties = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<Guid>(nullable: true),
                    EquipmentId = table.Column<Guid>(nullable: false),
                    InspectionTime = table.Column<DateTime>(nullable: false),
                    EquipmentInspectionResultId = table.Column<Guid>(nullable: false),
                    Problem = table.Column<string>(nullable: true),
                    Cause = table.Column<string>(nullable: true),
                    Solution = table.Column<string>(nullable: true),
                    Remark = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppEquipmentInspections", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppEquipmentMaintenanceResults",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ExtraProperties = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<Guid>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Remark = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppEquipmentMaintenanceResults", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppEquipmentMaintenances",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ExtraProperties = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<Guid>(nullable: true),
                    EquipmentId = table.Column<Guid>(nullable: false),
                    Problem = table.Column<string>(nullable: true),
                    Cause = table.Column<string>(nullable: true),
                    Solution = table.Column<string>(nullable: true),
                    ActualStartTime = table.Column<DateTime>(nullable: false),
                    ActualFinishTime = table.Column<DateTime>(nullable: false),
                    Consumable = table.Column<string>(nullable: true),
                    ResponsiblePerson = table.Column<string>(nullable: true),
                    MaintenanceTime = table.Column<DateTime>(nullable: false),
                    EquipmentMaintenanceResultId = table.Column<Guid>(nullable: false),
                    Remark = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppEquipmentMaintenances", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppEquipmentSpareParts",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ExtraProperties = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<Guid>(nullable: true),
                    EquipmentSparePartTypeId = table.Column<Guid>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Remark = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppEquipmentSpareParts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppEquipmentSparePartTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ExtraProperties = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<Guid>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Remark = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppEquipmentSparePartTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppEquipmentStatuses",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ExtraProperties = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<Guid>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Remark = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppEquipmentStatuses", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppEquipment");

            migrationBuilder.DropTable(
                name: "AppEquipmentBrands");

            migrationBuilder.DropTable(
                name: "AppEquipmentInspectionResults");

            migrationBuilder.DropTable(
                name: "AppEquipmentInspections");

            migrationBuilder.DropTable(
                name: "AppEquipmentMaintenanceResults");

            migrationBuilder.DropTable(
                name: "AppEquipmentMaintenances");

            migrationBuilder.DropTable(
                name: "AppEquipmentSpareParts");

            migrationBuilder.DropTable(
                name: "AppEquipmentSparePartTypes");

            migrationBuilder.DropTable(
                name: "AppEquipmentStatuses");
        }
    }
}
