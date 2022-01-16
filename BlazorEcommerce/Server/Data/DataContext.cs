using BlazorEcommerce.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorEcommerce.Server.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                    new Product
                    {
                        ProductId = 1,
                        Title = "Burmese Days ",
                        Description = "Burmese Days is the first novel by English writer George Orwell, published in 1934. Set in British Burma during the waning days of empire, when Burma was ruled from Delhi as part of British India, the novel serves as",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/a/a3/Burmese_days.jpg",
                        Price = 9.95m
                    },
                    new Product
                    {
                        ProductId = 5,
                        Title = "A Clergyman's Daughter",
                        Description = "A Clergyman's Daughter is a 1935 novel by English author George Orwell. It tells the story of Dorothy Hare, the clergyman's daughter of the title, whose life is turned upside down when she suffers an attack of amnesia. It is Orwell's most formally experimental novel, featuring a chapter written entirely in dramatic form, but he was never satisfied with it and he left instructions that after his death it was not to be reprinted",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/a/ac/A_Clergyman%27s_Daughter_%281st_US_edition_-_cover_art%29.jpg",
                        Price = 7.3m
                    },
                    new Product
                    {
                        ProductId = 3,
                        Title = "Keep the Aspidistra Flying",
                        Description = "Keep the Aspidistra Flying, first published in 1936, is a socially critical novel by George Orwell. It is set in 1930s London. The main theme is Gordon Comstock's romantic ambition to defy worship of the money-god and status, and the dismal life that results.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/b/b8/KeepTheAspidistraFlying.jpg",
                        Price = 12.34m
                    }
              );
        }

        public DbSet<Product> Products { get; set; }
    }
}
