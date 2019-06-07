using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CRUD.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: false),
                    Foto = table.Column<string>(nullable: true),
                    Precio = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Recibos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Id_Alumno = table.Column<int>(nullable: false),
                    Cuenta1 = table.Column<string>(nullable: true),
                    Monto1 = table.Column<string>(nullable: true),
                    Cuenta2 = table.Column<string>(nullable: true),
                    Monto2 = table.Column<string>(nullable: true),
                    Cuenta3 = table.Column<string>(nullable: true),
                    Monto3 = table.Column<string>(nullable: true),
                    Cuenta4 = table.Column<string>(nullable: true),
                    Monto4 = table.Column<string>(nullable: true),
                    Cuenta5 = table.Column<string>(nullable: true),
                    Monto5 = table.Column<string>(nullable: true),
                    Cuenta6 = table.Column<string>(nullable: true),
                    Monto6 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recibos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SistemaPagos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: false),
                    Apoderado = table.Column<string>(nullable: true),
                    Direccion = table.Column<string>(nullable: true),
                    Dni = table.Column<string>(nullable: true),
                    Celular = table.Column<string>(nullable: true),
                    Correo = table.Column<string>(nullable: true),
                    Turno = table.Column<string>(nullable: true),
                    Aula = table.Column<string>(nullable: true),
                    Ciclo = table.Column<string>(nullable: true),
                    Modalidad = table.Column<string>(nullable: true),
                    Postula = table.Column<string>(nullable: true),
                    Cuenta1 = table.Column<string>(nullable: true),
                    Monto1 = table.Column<string>(nullable: true),
                    Cuenta2 = table.Column<string>(nullable: true),
                    Monto2 = table.Column<string>(nullable: true),
                    Cuenta3 = table.Column<string>(nullable: true),
                    Monto3 = table.Column<string>(nullable: true),
                    Cuenta4 = table.Column<string>(nullable: true),
                    Monto4 = table.Column<string>(nullable: true),
                    Cuenta5 = table.Column<string>(nullable: true),
                    Monto5 = table.Column<string>(nullable: true),
                    Cuenta6 = table.Column<string>(nullable: true),
                    Monto6 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SistemaPagos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "Recibos");

            migrationBuilder.DropTable(
                name: "SistemaPagos");
        }
    }
}
