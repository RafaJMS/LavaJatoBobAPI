using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LavaJatoBobAPI.Migrations
{
    public partial class ui : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "text", nullable: true),
                    cpf = table.Column<string>(type: "varchar(11)", unicode: false, maxLength: 11, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Funcionarios",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "text", nullable: true),
                    cpf = table.Column<string>(type: "varchar(11)", unicode: false, maxLength: 11, nullable: true),
                    telefone = table.Column<decimal>(type: "decimal(11,0)", nullable: true),
                    email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    salario = table.Column<decimal>(type: "decimal(10,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionarios", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Veiculos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tipo = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    modelo = table.Column<string>(type: "text", nullable: true),
                    placa = table.Column<string>(type: "varchar(7)", unicode: false, maxLength: 7, nullable: true),
                    preco = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    id_cliente = table.Column<int>(type: "int", nullable: true),
                    id_funcionario = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veiculos", x => x.id);
                    table.ForeignKey(
                        name: "FK__Veiculos__id_cli__3A81B327",
                        column: x => x.id_cliente,
                        principalTable: "Clientes",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK__Veiculos__id_fun__3B75D760",
                        column: x => x.id_funcionario,
                        principalTable: "Funcionarios",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Veiculos_id_cliente",
                table: "Veiculos",
                column: "id_cliente");

            migrationBuilder.CreateIndex(
                name: "IX_Veiculos_id_funcionario",
                table: "Veiculos",
                column: "id_funcionario");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Veiculos");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Funcionarios");
        }
    }
}
