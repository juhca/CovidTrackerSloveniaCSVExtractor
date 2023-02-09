using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IndigoLabs2.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CSVRegionLastWeeks",
                columns: table => new
                {
                    RegionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AvgDailyCases = table.Column<double>(type: "float", nullable: false),
                    NumAllCases = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CSVRegions",
                columns: table => new
                {
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Regioncecasesactive = table.Column<int>(name: "Region_ce_cases_active", type: "int", nullable: false),
                    Regioncecasesconfirmedtodate = table.Column<int>(name: "Region_ce_cases_confirmed_todate", type: "int", nullable: false),
                    Regioncedeceasedtodate = table.Column<int>(name: "Region_ce_deceased_todate", type: "int", nullable: false),
                    Regioncevaccinated1sttodate = table.Column<int>(name: "Region_ce_vaccinated_1st_todate", type: "int", nullable: false),
                    Regioncevaccinated2ndtodate = table.Column<int>(name: "Region_ce_vaccinated_2nd_todate", type: "int", nullable: false),
                    Regioncevaccinated3rdtodate = table.Column<int>(name: "Region_ce_vaccinated_3rd_todate", type: "int", nullable: false),
                    Regionforeigncasesactive = table.Column<int>(name: "Region_foreign_cases_active", type: "int", nullable: false),
                    Regionforeigncasesconfirmedtodate = table.Column<int>(name: "Region_foreign_cases_confirmed_todate", type: "int", nullable: false),
                    Regionforeigndeceasedtodate = table.Column<int>(name: "Region_foreign_deceased_todate", type: "int", nullable: false),
                    Regionkkcasesactive = table.Column<int>(name: "Region_kk_cases_active", type: "int", nullable: false),
                    Regionkkcasesconfirmedtodate = table.Column<int>(name: "Region_kk_cases_confirmed_todate", type: "int", nullable: false),
                    Regionkkdeceasedtodate = table.Column<int>(name: "Region_kk_deceased_todate", type: "int", nullable: false),
                    Regionkkvaccinated1sttodate = table.Column<int>(name: "Region_kk_vaccinated_1st_todate", type: "int", nullable: false),
                    Regionkkvaccinated2ndtodate = table.Column<int>(name: "Region_kk_vaccinated_2nd_todate", type: "int", nullable: false),
                    Regionkkvaccinated3rdtodate = table.Column<int>(name: "Region_kk_vaccinated_3rd_todate", type: "int", nullable: false),
                    Regionkpcasesactive = table.Column<int>(name: "Region_kp_cases_active", type: "int", nullable: false),
                    Regionkpcasesconfirmedtodate = table.Column<int>(name: "Region_kp_cases_confirmed_todate", type: "int", nullable: false),
                    Regionkpdeceasedtodate = table.Column<int>(name: "Region_kp_deceased_todate", type: "int", nullable: false),
                    Regionkpvaccinated1sttodate = table.Column<int>(name: "Region_kp_vaccinated_1st_todate", type: "int", nullable: false),
                    Regionkpvaccinated2ndtodate = table.Column<int>(name: "Region_kp_vaccinated_2nd_todate", type: "int", nullable: false),
                    Regionkpvaccinated3rdtodate = table.Column<int>(name: "Region_kp_vaccinated_3rd_todate", type: "int", nullable: false),
                    Regionkrcasesactive = table.Column<int>(name: "Region_kr_cases_active", type: "int", nullable: false),
                    Regionkrcasesconfirmedtodate = table.Column<int>(name: "Region_kr_cases_confirmed_todate", type: "int", nullable: false),
                    Regionkrdeceasedtodate = table.Column<int>(name: "Region_kr_deceased_todate", type: "int", nullable: false),
                    Regionkrvaccinated1sttodate = table.Column<int>(name: "Region_kr_vaccinated_1st_todate", type: "int", nullable: false),
                    Regionkrvaccinated2ndtodate = table.Column<int>(name: "Region_kr_vaccinated_2nd_todate", type: "int", nullable: false),
                    Regionkrvaccinated3rdtodate = table.Column<int>(name: "Region_kr_vaccinated_3rd_todate", type: "int", nullable: false),
                    Regionljcasesactive = table.Column<int>(name: "Region_lj_cases_active", type: "int", nullable: false),
                    Regionljcasesconfirmedtodate = table.Column<int>(name: "Region_lj_cases_confirmed_todate", type: "int", nullable: false),
                    Regionljdeceasedtodate = table.Column<int>(name: "Region_lj_deceased_todate", type: "int", nullable: false),
                    Regionljvaccinated1sttodate = table.Column<int>(name: "Region_lj_vaccinated_1st_todate", type: "int", nullable: false),
                    Regionljvaccinated2ndtodate = table.Column<int>(name: "Region_lj_vaccinated_2nd_todate", type: "int", nullable: false),
                    Regionljvaccinated3rdtodate = table.Column<int>(name: "Region_lj_vaccinated_3rd_todate", type: "int", nullable: false),
                    Regionmbcasesactive = table.Column<int>(name: "Region_mb_cases_active", type: "int", nullable: false),
                    Regionmbcasesconfirmedtodate = table.Column<int>(name: "Region_mb_cases_confirmed_todate", type: "int", nullable: false),
                    Regionmbdeceasedtodate = table.Column<int>(name: "Region_mb_deceased_todate", type: "int", nullable: false),
                    Regionmbvaccinated1sttodate = table.Column<int>(name: "Region_mb_vaccinated_1st_todate", type: "int", nullable: false),
                    Regionmbvaccinated2ndtodate = table.Column<int>(name: "Region_mb_vaccinated_2nd_todate", type: "int", nullable: false),
                    Regionmbvaccinated3rdtodate = table.Column<int>(name: "Region_mb_vaccinated_3rd_todate", type: "int", nullable: false),
                    Regionmscasesactive = table.Column<int>(name: "Region_ms_cases_active", type: "int", nullable: false),
                    Regionmscasesconfirmedtodate = table.Column<int>(name: "Region_ms_cases_confirmed_todate", type: "int", nullable: false),
                    Regionmsdeceasedtodate = table.Column<int>(name: "Region_ms_deceased_todate", type: "int", nullable: false),
                    Regionmsvaccinated1sttodate = table.Column<int>(name: "Region_ms_vaccinated_1st_todate", type: "int", nullable: false),
                    Regionmsvaccinated2ndtodate = table.Column<int>(name: "Region_ms_vaccinated_2nd_todate", type: "int", nullable: false),
                    Regionmsvaccinated3rdtodate = table.Column<int>(name: "Region_ms_vaccinated_3rd_todate", type: "int", nullable: false),
                    Regionngcasesactive = table.Column<int>(name: "Region_ng_cases_active", type: "int", nullable: false),
                    Regionngcasesconfirmedtodate = table.Column<int>(name: "Region_ng_cases_confirmed_todate", type: "int", nullable: false),
                    Regionngdeceasedtodate = table.Column<int>(name: "Region_ng_deceased_todate", type: "int", nullable: false),
                    Regionngvaccinated1sttodate = table.Column<int>(name: "Region_ng_vaccinated_1st_todate", type: "int", nullable: false),
                    Regionngvaccinated2ndtodate = table.Column<int>(name: "Region_ng_vaccinated_2nd_todate", type: "int", nullable: false),
                    Regionngvaccinated3rdtodate = table.Column<int>(name: "Region_ng_vaccinated_3rd_todate", type: "int", nullable: false),
                    Regionnmcasesactive = table.Column<int>(name: "Region_nm_cases_active", type: "int", nullable: false),
                    Regionnmcasesconfirmedtodate = table.Column<int>(name: "Region_nm_cases_confirmed_todate", type: "int", nullable: false),
                    Regionnmdeceasedtodate = table.Column<int>(name: "Region_nm_deceased_todate", type: "int", nullable: false),
                    Regionnmvaccinated1sttodate = table.Column<int>(name: "Region_nm_vaccinated_1st_todate", type: "int", nullable: false),
                    Regionnmvaccinated2ndtodate = table.Column<int>(name: "Region_nm_vaccinated_2nd_todate", type: "int", nullable: false),
                    Regionnmvaccinated3rdtodate = table.Column<int>(name: "Region_nm_vaccinated_3rd_todate", type: "int", nullable: false),
                    Regionpocasesactive = table.Column<int>(name: "Region_po_cases_active", type: "int", nullable: false),
                    Regionpocasesconfirmedtodate = table.Column<int>(name: "Region_po_cases_confirmed_todate", type: "int", nullable: false),
                    Regionpodeceasedtodate = table.Column<int>(name: "Region_po_deceased_todate", type: "int", nullable: false),
                    Regionpovaccinated1sttodate = table.Column<int>(name: "Region_po_vaccinated_1st_todate", type: "int", nullable: false),
                    Regionpovaccinated2ndtodate = table.Column<int>(name: "Region_po_vaccinated_2nd_todate", type: "int", nullable: false),
                    Regionpovaccinated3rdtodate = table.Column<int>(name: "Region_po_vaccinated_3rd_todate", type: "int", nullable: false),
                    Regionsgcasesactive = table.Column<int>(name: "Region_sg_cases_active", type: "int", nullable: false),
                    Regionsgcasesconfirmedtodate = table.Column<int>(name: "Region_sg_cases_confirmed_todate", type: "int", nullable: false),
                    Regionsgdeceasedtodate = table.Column<int>(name: "Region_sg_deceased_todate", type: "int", nullable: false),
                    Regionsgvaccinated1sttodate = table.Column<int>(name: "Region_sg_vaccinated_1st_todate", type: "int", nullable: false),
                    Regionsgvaccinated2ndtodate = table.Column<int>(name: "Region_sg_vaccinated_2nd_todate", type: "int", nullable: false),
                    Regionsgvaccinated3rdtodate = table.Column<int>(name: "Region_sg_vaccinated_3rd_todate", type: "int", nullable: false),
                    Regionunknowncasesactive = table.Column<int>(name: "Region_unknown_cases_active", type: "int", nullable: false),
                    Regionunknowncasesconfirmedtodate = table.Column<int>(name: "Region_unknown_cases_confirmed_todate", type: "int", nullable: false),
                    Regionunknowndeceasedtodate = table.Column<int>(name: "Region_unknown_deceased_todate", type: "int", nullable: false),
                    Regionzacasesactive = table.Column<int>(name: "Region_za_cases_active", type: "int", nullable: false),
                    Regionzacasesconfirmedtodate = table.Column<int>(name: "Region_za_cases_confirmed_todate", type: "int", nullable: false),
                    Regionzadeceasedtodate = table.Column<int>(name: "Region_za_deceased_todate", type: "int", nullable: false),
                    Regionzavaccinated1sttodate = table.Column<int>(name: "Region_za_vaccinated_1st_todate", type: "int", nullable: false),
                    Regionzavaccinated2ndtodate = table.Column<int>(name: "Region_za_vaccinated_2nd_todate", type: "int", nullable: false),
                    Regionzavaccinated3rdtodate = table.Column<int>(name: "Region_za_vaccinated_3rd_todate", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CSVRegions", x => x.Date);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Password", "Username" },
                values: new object[,]
                {
                    { 1, "admin", "admin" },
                    { 2, "000000", "tomas" },
                    { 3, "000000", "uporabnik01" },
                    { 4, "000000", "uporabnik02" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CSVRegionLastWeeks");

            migrationBuilder.DropTable(
                name: "CSVRegions");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
