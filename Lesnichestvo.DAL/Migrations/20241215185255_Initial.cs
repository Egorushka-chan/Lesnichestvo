using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lesnichestvo.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    INN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContractDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Inventory",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventory", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "QuartalNetworks",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Importance = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuartalNetworks", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "WoodTypes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WoodTypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Workers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Patronymic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IssueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Payment = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "WorkTypes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkTypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Dachas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NetworkID = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dachas", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Dachas_QuartalNetworks_NetworkID",
                        column: x => x.NetworkID,
                        principalTable: "QuartalNetworks",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SoldWoods",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WoodTypeID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    CustomerID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SoldWoods", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SoldWoods_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SoldWoods_WoodTypes_WoodTypeID",
                        column: x => x.WoodTypeID,
                        principalTable: "WoodTypes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UnsoldWoods",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WoodTypeID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnsoldWoods", x => x.ID);
                    table.ForeignKey(
                        name: "FK_UnsoldWoods_WoodTypes_WoodTypeID",
                        column: x => x.WoodTypeID,
                        principalTable: "WoodTypes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Qualifications",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IssueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CertificateCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IssuedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WorkerID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Qualifications", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Qualifications_Workers_WorkerID",
                        column: x => x.WorkerID,
                        principalTable: "Workers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Works",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HoursSpent = table.Column<int>(type: "int", nullable: false),
                    TypeID = table.Column<int>(type: "int", nullable: false),
                    PreviousWorkID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Works", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Works_WorkTypes_TypeID",
                        column: x => x.TypeID,
                        principalTable: "WorkTypes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Works_Works_PreviousWorkID",
                        column: x => x.PreviousWorkID,
                        principalTable: "Works",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Mapping",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    XCoord = table.Column<double>(type: "float", nullable: false),
                    YCoord = table.Column<double>(type: "float", nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NetworkID = table.Column<int>(type: "int", nullable: true),
                    DachaID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mapping", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Mapping_Dachas_DachaID",
                        column: x => x.DachaID,
                        principalTable: "Dachas",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Mapping_QuartalNetworks_NetworkID",
                        column: x => x.NetworkID,
                        principalTable: "QuartalNetworks",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Inspections",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuartalNetworkID = table.Column<int>(type: "int", nullable: false),
                    WorkID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inspections", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Inspections_QuartalNetworks_QuartalNetworkID",
                        column: x => x.QuartalNetworkID,
                        principalTable: "QuartalNetworks",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Inspections_Works_WorkID",
                        column: x => x.WorkID,
                        principalTable: "Works",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkHasInventory",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkID = table.Column<int>(type: "int", nullable: false),
                    ItemID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkHasInventory", x => x.ID);
                    table.ForeignKey(
                        name: "FK_WorkHasInventory_Inventory_ItemID",
                        column: x => x.ItemID,
                        principalTable: "Inventory",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkHasInventory_Works_WorkID",
                        column: x => x.WorkID,
                        principalTable: "Works",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkHasWorkers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkID = table.Column<int>(type: "int", nullable: false),
                    WorkerID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkHasWorkers", x => x.ID);
                    table.ForeignKey(
                        name: "FK_WorkHasWorkers_Workers_WorkerID",
                        column: x => x.WorkerID,
                        principalTable: "Workers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkHasWorkers_Works_WorkID",
                        column: x => x.WorkID,
                        principalTable: "Works",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reports",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InspectionID = table.Column<int>(type: "int", nullable: false),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TakenMeasures = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Conclusion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reports", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Reports_Inspections_InspectionID",
                        column: x => x.InspectionID,
                        principalTable: "Inspections",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dachas_NetworkID",
                table: "Dachas",
                column: "NetworkID");

            migrationBuilder.CreateIndex(
                name: "IX_Inspections_QuartalNetworkID",
                table: "Inspections",
                column: "QuartalNetworkID");

            migrationBuilder.CreateIndex(
                name: "IX_Inspections_WorkID",
                table: "Inspections",
                column: "WorkID");

            migrationBuilder.CreateIndex(
                name: "IX_Mapping_DachaID",
                table: "Mapping",
                column: "DachaID");

            migrationBuilder.CreateIndex(
                name: "IX_Mapping_NetworkID",
                table: "Mapping",
                column: "NetworkID");

            migrationBuilder.CreateIndex(
                name: "IX_Qualifications_WorkerID",
                table: "Qualifications",
                column: "WorkerID");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_InspectionID",
                table: "Reports",
                column: "InspectionID");

            migrationBuilder.CreateIndex(
                name: "IX_SoldWoods_CustomerID",
                table: "SoldWoods",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_SoldWoods_WoodTypeID",
                table: "SoldWoods",
                column: "WoodTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_UnsoldWoods_WoodTypeID",
                table: "UnsoldWoods",
                column: "WoodTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_WorkHasInventory_ItemID",
                table: "WorkHasInventory",
                column: "ItemID");

            migrationBuilder.CreateIndex(
                name: "IX_WorkHasInventory_WorkID",
                table: "WorkHasInventory",
                column: "WorkID");

            migrationBuilder.CreateIndex(
                name: "IX_WorkHasWorkers_WorkerID",
                table: "WorkHasWorkers",
                column: "WorkerID");

            migrationBuilder.CreateIndex(
                name: "IX_WorkHasWorkers_WorkID",
                table: "WorkHasWorkers",
                column: "WorkID");

            migrationBuilder.CreateIndex(
                name: "IX_Works_PreviousWorkID",
                table: "Works",
                column: "PreviousWorkID");

            migrationBuilder.CreateIndex(
                name: "IX_Works_TypeID",
                table: "Works",
                column: "TypeID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mapping");

            migrationBuilder.DropTable(
                name: "Qualifications");

            migrationBuilder.DropTable(
                name: "Reports");

            migrationBuilder.DropTable(
                name: "SoldWoods");

            migrationBuilder.DropTable(
                name: "UnsoldWoods");

            migrationBuilder.DropTable(
                name: "WorkHasInventory");

            migrationBuilder.DropTable(
                name: "WorkHasWorkers");

            migrationBuilder.DropTable(
                name: "Dachas");

            migrationBuilder.DropTable(
                name: "Inspections");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "WoodTypes");

            migrationBuilder.DropTable(
                name: "Inventory");

            migrationBuilder.DropTable(
                name: "Workers");

            migrationBuilder.DropTable(
                name: "QuartalNetworks");

            migrationBuilder.DropTable(
                name: "Works");

            migrationBuilder.DropTable(
                name: "WorkTypes");
        }
    }
}
