﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Suz.Projetos.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddColunaCPF : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CPF",
                table: "Pessoas",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CPF",
                table: "Pessoas");
        }
    }
}
