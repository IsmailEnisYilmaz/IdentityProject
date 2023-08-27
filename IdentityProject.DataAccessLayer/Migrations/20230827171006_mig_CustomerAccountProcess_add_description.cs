using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IdentityProject.DataAccessLayer.Migrations
{
    public partial class mig_CustomerAccountProcess_add_description : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerAccountProcesses_CustomerAccounts_ReveiverID",
                table: "CustomerAccountProcesses");

            migrationBuilder.RenameColumn(
                name: "ReveiverID",
                table: "CustomerAccountProcesses",
                newName: "ReceiverID");

            migrationBuilder.RenameIndex(
                name: "IX_CustomerAccountProcesses_ReveiverID",
                table: "CustomerAccountProcesses",
                newName: "IX_CustomerAccountProcesses_ReceiverID");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "CustomerAccountProcesses",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerAccountProcesses_CustomerAccounts_ReceiverID",
                table: "CustomerAccountProcesses",
                column: "ReceiverID",
                principalTable: "CustomerAccounts",
                principalColumn: "CustomerAccountID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerAccountProcesses_CustomerAccounts_ReceiverID",
                table: "CustomerAccountProcesses");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "CustomerAccountProcesses");

            migrationBuilder.RenameColumn(
                name: "ReceiverID",
                table: "CustomerAccountProcesses",
                newName: "ReveiverID");

            migrationBuilder.RenameIndex(
                name: "IX_CustomerAccountProcesses_ReceiverID",
                table: "CustomerAccountProcesses",
                newName: "IX_CustomerAccountProcesses_ReveiverID");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerAccountProcesses_CustomerAccounts_ReveiverID",
                table: "CustomerAccountProcesses",
                column: "ReveiverID",
                principalTable: "CustomerAccounts",
                principalColumn: "CustomerAccountID");
        }
    }
}
