﻿// <auto-generated />
using BlazorEcommerce.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlazorEcommerce.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220117125433_fixModel")]
    partial class fixModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BlazorEcommerce.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Burmese Days is the first novel by English writer George Orwell, published in 1934. Set in British Burma during the waning days of empire, when Burma was ruled from Delhi as part of British India, the novel serves as",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/a/a3/Burmese_days.jpg",
                            Price = 9.95m,
                            Title = "Burmese Days "
                        },
                        new
                        {
                            Id = 2,
                            Description = "A Clergyman's Daughter is a 1935 novel by English author George Orwell. It tells the story of Dorothy Hare, the clergyman's daughter of the title, whose life is turned upside down when she suffers an attack of amnesia. It is Orwell's most formally experimental novel, featuring a chapter written entirely in dramatic form, but he was never satisfied with it and he left instructions that after his death it was not to be reprinted",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/a/ac/A_Clergyman%27s_Daughter_%281st_US_edition_-_cover_art%29.jpg",
                            Price = 7.3m,
                            Title = "A Clergyman's Daughter"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Keep the Aspidistra Flying, first published in 1936, is a socially critical novel by George Orwell. It is set in 1930s London. The main theme is Gordon Comstock's romantic ambition to defy worship of the money-god and status, and the dismal life that results.",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/b/b8/KeepTheAspidistraFlying.jpg",
                            Price = 12.34m,
                            Title = "Keep the Aspidistra Flying"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
