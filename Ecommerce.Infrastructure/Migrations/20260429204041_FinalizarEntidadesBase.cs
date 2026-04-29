using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Ecommerce.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FinalizarEntidadesBase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "gn_auditoria",
                columns: table => new
                {
                    id_auditoria = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    tabla = table.Column<string>(type: "text", nullable: false),
                    accion = table.Column<string>(type: "text", nullable: false),
                    registro_id = table.Column<string>(type: "text", nullable: false),
                    datos_anteriores = table.Column<string>(type: "text", nullable: true),
                    datos_nuevos = table.Column<string>(type: "text", nullable: true),
                    usuario = table.Column<string>(type: "text", nullable: false),
                    fe_evento = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gn_auditoria", x => x.id_auditoria);
                });

            migrationBuilder.CreateTable(
                name: "gn_cliente",
                columns: table => new
                {
                    id_cliente = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombres = table.Column<string>(type: "text", nullable: false),
                    apellidos = table.Column<string>(type: "text", nullable: false),
                    correo = table.Column<string>(type: "text", nullable: false),
                    telefono = table.Column<string>(type: "text", nullable: true),
                    direccion = table.Column<string>(type: "text", nullable: true),
                    identificacion = table.Column<string>(type: "text", nullable: false),
                    es_activo = table.Column<bool>(type: "boolean", nullable: false),
                    fe_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gn_cliente", x => x.id_cliente);
                });

            migrationBuilder.CreateTable(
                name: "sc_usuario",
                columns: table => new
                {
                    id_usuario = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    usuario = table.Column<string>(type: "text", nullable: false),
                    correo = table.Column<string>(type: "text", nullable: false),
                    clave_hash = table.Column<string>(type: "text", nullable: false),
                    id_rol = table.Column<int>(type: "integer", nullable: false),
                    es_activo = table.Column<bool>(type: "boolean", nullable: false),
                    fe_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Rolid_rol = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sc_usuario", x => x.id_usuario);
                    table.ForeignKey(
                        name: "FK_sc_usuario_sc_rol_Rolid_rol",
                        column: x => x.Rolid_rol,
                        principalTable: "sc_rol",
                        principalColumn: "id_rol");
                });

            migrationBuilder.CreateIndex(
                name: "IX_sc_usuario_Rolid_rol",
                table: "sc_usuario",
                column: "Rolid_rol");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "gn_auditoria");

            migrationBuilder.DropTable(
                name: "gn_cliente");

            migrationBuilder.DropTable(
                name: "sc_usuario");
        }
    }
}
