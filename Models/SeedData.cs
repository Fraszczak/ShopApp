using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ShopApp.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Category = "Kajak",
                        Description = "Łodka przeznaczona dla jednej osoby",
                        Name = "Sporty wodne",
                        Price = 275
                    },
                    new Product
                    {
                        Category = "Kamizelka ratunkowa",
                        Description = "Chronu i dodaje uroku",
                        Name = "Sporty wodne",
                        Price = 48.95M
                    },
                    new Product
                    {
                        Category = "Piłka",
                        Description = "Zatwierdzone przez FIFA rozmiar i waga",
                        Name = "Piłka nożna",
                        Price = 19.50M
                    },
                    new Product
                    {
                        Category = "Flagi narożne",
                        Description = "Nadadzą Twojemu boisku profesjonalnu wygląd",
                        Name = "Piłka nożna",
                        Price = 35.95M
                    },
                    new Product
                    {
                        Category = "Stadion",
                        Description = "Składany statnion na 35 000 osób",
                        Name = "Piłka nożna",
                        Price = 79500
                    },
                    new Product
                    {
                        Category = "Czapka",
                        Description = "Zwiększa efektywność mózgu o 75%",
                        Name = "Szachy",
                        Price = 16
                    },
                    new Product
                    {
                        Category = "Niestabilne krzesło",
                        Description = "Zmiejsza szanse przeciwnika",
                        Name = "Szachy",
                        Price = 29.95M
                    },
                    new Product
                    {
                        Category = "Ludzka szachownica",
                        Description = "Przyjemna gra dla całej rodziny",
                        Name = "Szachy",
                        Price = 75
                    },
                    new Product
                    {
                        Category = "Błyszczący król",
                        Description = "Figura pokryta złotem i wysadzana diamentami",
                        Name = "Szachy",
                        Price = 1200
                    }
                );
                context.SaveChanges();
            }
        }
    }
}

