﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SalesManagementApp.Data;

#nullable disable

namespace SalesManagementApp.Migrations
{
    [DbContext(typeof(SalesManageDbContext))]
    [Migration("20231026133805_AddAppointmentTable")]
    partial class AddAppointmentTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SalesManagementApp.Entities.Appointments", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsAllDay")
                        .HasColumnType("bit");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RecurrenceException")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RecurrenceId")
                        .HasColumnType("int");

                    b.Property<string>("RecurrenceRule")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("SalesManagementApp.Entities.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RetailOutletId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Clients");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "james.tailor@company.com",
                            FirstName = "James",
                            JobTitle = "Buyer",
                            LastName = "Tailor",
                            PhoneNumber = "000000000",
                            RetailOutletId = 1
                        },
                        new
                        {
                            Id = 2,
                            Email = "jill.hutton@company.com",
                            FirstName = "Jill",
                            JobTitle = "Buyer",
                            LastName = "Hutton",
                            PhoneNumber = "000000000",
                            RetailOutletId = 2
                        },
                        new
                        {
                            Id = 3,
                            Email = "craig.rice@company.com",
                            FirstName = "Craig",
                            JobTitle = "Buyer",
                            LastName = "Rice",
                            PhoneNumber = "000000000",
                            RetailOutletId = 3
                        },
                        new
                        {
                            Id = 4,
                            Email = "amy.smith@company.com",
                            FirstName = "Amy",
                            JobTitle = "Buyer",
                            LastName = "Smith",
                            PhoneNumber = "000000000",
                            RetailOutletId = 4
                        });
                });

            modelBuilder.Entity("SalesManagementApp.Entities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmployeeJobTitleId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ReportToEmpId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateOfBirth = new DateTime(1974, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "bob.jones@oexl.com",
                            EmployeeJobTitleId = 1,
                            FirstName = "Bob",
                            Gender = "Male",
                            ImagePath = "/Images/Profile/BobJones.jpg",
                            LastName = "Jones"
                        },
                        new
                        {
                            Id = 2,
                            DateOfBirth = new DateTime(1976, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "jenny.marks@oexl.com",
                            EmployeeJobTitleId = 2,
                            FirstName = "Jenny",
                            Gender = "Female",
                            ImagePath = "/Images/Profile/JennyMarks.jpg",
                            LastName = "Marks",
                            ReportToEmpId = 1
                        },
                        new
                        {
                            Id = 3,
                            DateOfBirth = new DateTime(1981, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "henry.andrews@oexl.com",
                            EmployeeJobTitleId = 2,
                            FirstName = "Henry",
                            Gender = "Male",
                            ImagePath = "/Images/Profile/HenryAndrews.jpg",
                            LastName = "Andrews",
                            ReportToEmpId = 1
                        },
                        new
                        {
                            Id = 4,
                            DateOfBirth = new DateTime(1984, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "john.jameson@oexl.com",
                            EmployeeJobTitleId = 2,
                            FirstName = "John",
                            Gender = "Male",
                            ImagePath = "/Images/Profile/JohnJameson.jpg",
                            LastName = "Jameson",
                            ReportToEmpId = 1
                        },
                        new
                        {
                            Id = 5,
                            DateOfBirth = new DateTime(1993, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "noah.robinson@oexl.com",
                            EmployeeJobTitleId = 3,
                            FirstName = "Noah",
                            Gender = "Male",
                            ImagePath = "/Images/Profile/NoahRobinson.jpg",
                            LastName = "Robinson",
                            ReportToEmpId = 2
                        },
                        new
                        {
                            Id = 6,
                            DateOfBirth = new DateTime(1993, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "elijah.hamilton@oexl.com",
                            EmployeeJobTitleId = 3,
                            FirstName = "Elijah",
                            Gender = "Male",
                            ImagePath = "/Images/Profile/ElijahHamilton.jpg",
                            LastName = "Hamilton",
                            ReportToEmpId = 2
                        },
                        new
                        {
                            Id = 7,
                            DateOfBirth = new DateTime(1992, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "jamie.fisher@oexl.com",
                            EmployeeJobTitleId = 3,
                            FirstName = "Jamie",
                            Gender = "Male",
                            ImagePath = "/Images/Profile/JamieFisher.jpg",
                            LastName = "Fisher",
                            ReportToEmpId = 2
                        },
                        new
                        {
                            Id = 8,
                            DateOfBirth = new DateTime(1990, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "olivia.mills@oexl.com",
                            EmployeeJobTitleId = 3,
                            FirstName = "Olivia",
                            Gender = "Female",
                            ImagePath = "/Images/Profile/OliviaMills.jpg",
                            LastName = "Mills",
                            ReportToEmpId = 3
                        },
                        new
                        {
                            Id = 9,
                            DateOfBirth = new DateTime(1993, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "benjamin.lucas@oexl.com",
                            EmployeeJobTitleId = 3,
                            FirstName = "Benjamin",
                            Gender = "Male",
                            ImagePath = "/Images/Profile/BenjaminLucas.jpg",
                            LastName = "Lucas",
                            ReportToEmpId = 3
                        },
                        new
                        {
                            Id = 10,
                            DateOfBirth = new DateTime(1993, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "sarah.henderson@oexl.com",
                            EmployeeJobTitleId = 3,
                            FirstName = "Sarah",
                            Gender = "Female",
                            ImagePath = "/Images/Profile/SarahHenderson.jpg",
                            LastName = "Henderson",
                            ReportToEmpId = 3
                        },
                        new
                        {
                            Id = 11,
                            DateOfBirth = new DateTime(1995, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "emma.lee@oexl.com",
                            EmployeeJobTitleId = 3,
                            FirstName = "Emma",
                            Gender = "Female",
                            ImagePath = "/Images/Profile/EmmaLee.jpg",
                            LastName = "Lee",
                            ReportToEmpId = 4
                        },
                        new
                        {
                            Id = 12,
                            DateOfBirth = new DateTime(1998, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "ava.williams@oexl.com",
                            EmployeeJobTitleId = 3,
                            FirstName = "Ava",
                            Gender = "Female",
                            ImagePath = "/Images/Profile/AvaWilliams.jpg",
                            LastName = "Williams",
                            ReportToEmpId = 4
                        },
                        new
                        {
                            Id = 13,
                            DateOfBirth = new DateTime(1994, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "angela.moore@oexl.com",
                            EmployeeJobTitleId = 3,
                            FirstName = "Angela",
                            Gender = "Female",
                            ImagePath = "/Images/Profile/AngelaMoore.jpg",
                            LastName = "Moore",
                            ReportToEmpId = 4
                        });
                });

            modelBuilder.Entity("SalesManagementApp.Entities.EmployeeJobTitle", b =>
                {
                    b.Property<int>("EmployeeJobTitleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeJobTitleId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeJobTitleId");

                    b.ToTable("EmployeeJobTitles");

                    b.HasData(
                        new
                        {
                            EmployeeJobTitleId = 1,
                            Description = "Sales Manager",
                            Name = "SM"
                        },
                        new
                        {
                            EmployeeJobTitleId = 2,
                            Description = "Team Leader",
                            Name = "TL"
                        },
                        new
                        {
                            EmployeeJobTitleId = 3,
                            Description = "Sales Rep",
                            Name = "SR"
                        });
                });

            modelBuilder.Entity("SalesManagementApp.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDateTime")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("SalesManagementApp.Entities.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("OrdersItem");
                });

            modelBuilder.Entity("SalesManagementApp.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ",
                            ImagePath = "/Images/Products/MountainBike1.jpg",
                            Name = "Mountain Bike 1",
                            Price = 200m
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ",
                            ImagePath = "/Images/Products/MountainBike2.jpg",
                            Name = "Mountain Bike 2",
                            Price = 210m
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 2,
                            Description = "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ",
                            ImagePath = "/Images/Products/RoadBike1.jpg",
                            Name = "Road Bike 1",
                            Price = 240m
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            Description = "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ",
                            ImagePath = "/Images/Products/RoadBike2.jpg",
                            Name = "Road Bike 2",
                            Price = 250m
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            Description = "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ",
                            ImagePath = "/Images/Products/RoadBike3.jpg",
                            Name = "Road Bike 3",
                            Price = 252m
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 2,
                            Description = "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ",
                            ImagePath = "/Images/Products/RoadBike4.jpg",
                            Name = "Road Bike 4",
                            Price = 230m
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 3,
                            Description = "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ",
                            ImagePath = "/Images/Products/Tent1.jpg",
                            Name = "Tent 1",
                            Price = 230m
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 3,
                            Description = "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ",
                            ImagePath = "/Images/Products/Tent2.jpg",
                            Name = "Tent 2",
                            Price = 230m
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 3,
                            Description = "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ",
                            ImagePath = "/Images/Products/Mattress1.jpg",
                            Name = "Air Mattress 1",
                            Price = 11m
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 3,
                            Description = "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ",
                            ImagePath = "/Images/Products/Mattress2.jpg",
                            Name = "Air Mattress 2",
                            Price = 40m
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 3,
                            Description = "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ",
                            ImagePath = "/Images/Products/Mattress3.jpg",
                            Name = "Air Mattress 3",
                            Price = 54m
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 3,
                            Description = "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ",
                            ImagePath = "/Images/Products/Mattress4.jpg",
                            Name = "Air Mattress 4",
                            Price = 15m
                        },
                        new
                        {
                            Id = 13,
                            CategoryId = 4,
                            Description = "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ",
                            ImagePath = "/Images/Products/Pack1.jpg",
                            Name = "Pack 1",
                            Price = 24m
                        },
                        new
                        {
                            Id = 14,
                            CategoryId = 4,
                            Description = "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ",
                            ImagePath = "/Images/Products/Pack2.jpg",
                            Name = "Pack 2",
                            Price = 30m
                        },
                        new
                        {
                            Id = 15,
                            CategoryId = 4,
                            Description = "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ",
                            ImagePath = "/Images/Products/Pack3.jpg",
                            Name = "Pack 3",
                            Price = 35m
                        },
                        new
                        {
                            Id = 16,
                            CategoryId = 5,
                            Description = "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ",
                            ImagePath = "/Images/Products/Boot1.jpg",
                            Name = "Boot 1",
                            Price = 20m
                        },
                        new
                        {
                            Id = 17,
                            CategoryId = 5,
                            Description = "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ",
                            ImagePath = "/Images/Products/Boot2.jpg",
                            Name = "Boot 2",
                            Price = 38m
                        },
                        new
                        {
                            Id = 18,
                            CategoryId = 5,
                            Description = "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ",
                            ImagePath = "/Images/Products/Boot3.jpg",
                            Name = "Boot 3",
                            Price = 35m
                        },
                        new
                        {
                            Id = 19,
                            CategoryId = 5,
                            Description = "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ",
                            ImagePath = "/Images/Products/Boot4.jpg",
                            Name = "Boot 4",
                            Price = 31m
                        });
                });

            modelBuilder.Entity("SalesManagementApp.Entities.ProductCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProductCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Mountain Bikes"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Road Bikes"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Camping"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Hiking"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Boots"
                        });
                });

            modelBuilder.Entity("SalesManagementApp.Entities.RetailOutlet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RetailOutlets");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Location = "TX",
                            Name = "Texas Outdoor Store"
                        },
                        new
                        {
                            Id = 2,
                            Location = "CA",
                            Name = "California Outdoor Store"
                        },
                        new
                        {
                            Id = 3,
                            Location = "NY",
                            Name = "New York Outdoor Store"
                        },
                        new
                        {
                            Id = 4,
                            Location = "WA",
                            Name = " Washington Outdoor Store"
                        });
                });

            modelBuilder.Entity("SalesManagementApp.Entities.SalesOrderReport", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClientFirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<string>("ClientLastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeFirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<string>("EmployeeLastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OrderDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("OrderItemId")
                        .HasColumnType("int");

                    b.Property<decimal>("OrderItemPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("OrderItemQty")
                        .HasColumnType("int");

                    b.Property<decimal>("OrderPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("OrderQty")
                        .HasColumnType("int");

                    b.Property<int>("ProductCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("ProductCategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RetailOutletId")
                        .HasColumnType("int");

                    b.Property<string>("RetailOutletLocation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SalesOrderReports");
                });
#pragma warning restore 612, 618
        }
    }
}
