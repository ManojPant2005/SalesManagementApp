using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Migrations;
using System.Text;

#nullable disable

namespace SalesManagementApp.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserAndRolesData : Migration
    {

        const string ADMIN_ROLE_GUID = "59b82dba-9bb1-41c1-8447-b5d4654a6fcd";
        const string SM_ROLE_GUID = "42d84307-56ad-42f1-aeb4-1a80fe1a2039";
        const string TL_ROLE_GUID = "e37159c4 - 3690 - 4e3a-bb26-68c773870b1a";
        const string SR_ROLE_GUID = "2983f960-12ce-41eb-83a3-31b08e3df2c0";

        const string ADMIN_USER_GUID = "b1faf322-870e-4771-82c9-735470348867";
        const string SM_USER_GUID = "e526826a-432e-419f-b5d0-57206166eac4";
        const string TL_USER_GUID = "1bf84744-8c5c-43fa-873c-3fc0564a0cbc";
        const string SR1_USER_GUID = "63f70300-d134-4452-8a98-9c2cb22bfb57";
        const string SR2_USER_GUID = "b1fcafec-a7ed-47da-b328-58ff17d32f07";
        const string SR3_USER_GUID = "551b8505-65db-4f63-b46a-4c300635ec37";
        const string SR4_USER_GUID = "28f329bc-8fef-4d25-b3cc-c0781d76c6a5";


        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var hasher = new PasswordHasher<IdentityUser>();

            var passwordHash = hasher.HashPassword(null, "Password1!");

            AddUser(migrationBuilder, "admin@oexl.com", passwordHash, ADMIN_USER_GUID);

            AddUser(migrationBuilder, "bob.jones@oexl.com", passwordHash, SM_USER_GUID);

            AddUser(migrationBuilder, "henry.andrews@oexl.com", passwordHash, TL_USER_GUID);

            AddUser(migrationBuilder, "olivia.mills@oexl.com", passwordHash, SR1_USER_GUID);
            AddUser(migrationBuilder, "noah.robinson@oexl.com", passwordHash, SR2_USER_GUID);
            AddUser(migrationBuilder, "benjamin.lucas@oexl.com", passwordHash, SR3_USER_GUID);
            AddUser(migrationBuilder, "sarah.henderson@oexl.com", passwordHash, SR4_USER_GUID);

            AddRole(migrationBuilder, "Admin", ADMIN_ROLE_GUID);
            AddRole(migrationBuilder, "SM", SM_ROLE_GUID);
            AddRole(migrationBuilder, "TL", TL_ROLE_GUID);
            AddRole(migrationBuilder, "SR", SR_ROLE_GUID);

            AddUserToRole(migrationBuilder, ADMIN_USER_GUID, ADMIN_ROLE_GUID);
            AddUserToRole(migrationBuilder, SM_USER_GUID, SM_ROLE_GUID);

            AddUserToRole(migrationBuilder, TL_USER_GUID, TL_ROLE_GUID);
            AddUserToRole(migrationBuilder, SR1_USER_GUID, SR_ROLE_GUID);
            AddUserToRole(migrationBuilder, SR2_USER_GUID, SR_ROLE_GUID);
            AddUserToRole(migrationBuilder, SR3_USER_GUID, SR_ROLE_GUID);
            AddUserToRole(migrationBuilder, SR4_USER_GUID, SR_ROLE_GUID);
        }
        private void AddUser(MigrationBuilder migrationBuilder, string email, string passwordHash, string userGuid)
        {
            StringBuilder sb = new StringBuilder();

            string emailCaps = email.ToUpper();

            sb.AppendLine("INSERT INTO AspNetUsers(Id, UserName, NormalizedUserName,Email,EmailConfirmed,PhoneNumberConfirmed,TwoFactorEnabled,LockoutEnabled,AccessFailedCount,NormalizedEmail,PasswordHash,SecurityStamp)");
            sb.AppendLine("VALUES(");
            sb.AppendLine($"'{userGuid}'");
            sb.AppendLine($",'{email}'");
            sb.AppendLine($",'{emailCaps}'");
            sb.AppendLine($",'{email}'");
            sb.AppendLine(", 0");
            sb.AppendLine(", 0");
            sb.AppendLine(", 0");
            sb.AppendLine(", 0");
            sb.AppendLine(", 0");
            sb.AppendLine($",'{emailCaps}'");
            sb.AppendLine($", '{passwordHash}'");
            sb.AppendLine(", ''");
            sb.AppendLine(")");

            migrationBuilder.Sql(sb.ToString());
        }
        private void AddRole(MigrationBuilder migrationBuilder, string roleName, string roleGuid)
        {
            string roleNameCaps = roleName.ToUpper();

            migrationBuilder.Sql($"INSERT INTO AspNetRoles (Id, Name, NormalizedName) VALUES ('{roleGuid}','{roleName}','{roleNameCaps}')");


        }

        private void AddUserToRole(MigrationBuilder migrationBuilder, string userGuid, string roleGuid)
        {
            migrationBuilder.Sql($"INSERT INTO AspNetUserRoles (UserId, RoleId) VALUES ('{userGuid}','{roleGuid}')");


        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            RemoveUser(migrationBuilder, ADMIN_USER_GUID, ADMIN_ROLE_GUID);
            RemoveUser(migrationBuilder, SM_USER_GUID, SM_ROLE_GUID);
            RemoveUser(migrationBuilder, TL_USER_GUID, TL_ROLE_GUID);
            RemoveUser(migrationBuilder, SR1_USER_GUID, SR_ROLE_GUID);
            RemoveUser(migrationBuilder, SR2_USER_GUID, SR_ROLE_GUID);
            RemoveUser(migrationBuilder, SR3_USER_GUID, SR_ROLE_GUID);
            RemoveUser(migrationBuilder, SR4_USER_GUID, SR_ROLE_GUID);

            RemoveRole(migrationBuilder, ADMIN_ROLE_GUID);
            RemoveRole(migrationBuilder, SM_ROLE_GUID);
            RemoveRole(migrationBuilder, TL_ROLE_GUID);
            RemoveRole(migrationBuilder, SR_ROLE_GUID);
        }
        private void RemoveUser(MigrationBuilder migrationBuilder, string userGuid, string roleGuid)
        {
            migrationBuilder.Sql($"DELETE FROM AspNetUserRoles WHERE UserId = '{userGuid}' AND RoleId = '{roleGuid}'");

            migrationBuilder.Sql($"DELETE FROM AspNetUsers WHERE Id = '{userGuid}'");
        }
        private void RemoveRole(MigrationBuilder migrationBuilder, string roleGuid)
        {
            migrationBuilder.Sql($"DELETE FROM AspNetRoles WHERE Id = '{roleGuid}'");
        }
    }
}
