using GameStore.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace GameStore.Domain
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Game> Games { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "6f554181-3a58-4604-8390-1b91c9597b1d",
                Name = "admin",
                NormalizedName = "ADMIN"
            });

            builder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "ebcca213-1f9a-445d-bbc2-845e487e81b5",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "gamestore@email.com",
                NormalizedEmail = "GAMESTORE@EMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "superpassword"),
                SecurityStamp = string.Empty
            });

            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "6f554181-3a58-4604-8390-1b91c9597b1d",
                UserId = "ebcca213-1f9a-445d-bbc2-845e487e81b5"
            });

            builder.Entity<Game>().HasData(new Game
            {
                GameId = new Guid("46725a94-5859-49bb-8937-5f3226e12013"),
                Name = "Forza Horizon 5",
                Description = "Вас ждёт бесконечный калейдоскоп приключений Horizon! Совершайте увлекательные поездки по невероятно красивому и самобытному миру Мексики за рулём величайших автомобилей в истории. Начните своё приключение Horizon уже сегодня, добавив игру в свой список желаний!",
                Category = "Гонки",
                TitleImage = "/images/games/forza5.jpeg",
                Video = "https://www.youtube.com/embed/FYH9n37B7Yw",
                Price = 2499
            }, new Game
            {
                GameId = new Guid("3835f7be-c98e-421b-ac04-f484521c4751"),
                Name = "Battlefield 2042",
                Description = "Battlefield™ 2042 — это шутер от первого лица, в котором серия возвращается к легендарным масштабным сражениям. В будущем, где царит хаос, адаптируйтесь и процветайте на постоянно меняющихся полях боя благодаря своему отряду и арсеналу новейших технологий.",
                Category = "Шутер",
                TitleImage = "/images/games/battlefield2042.jpg",
                Video = "https://www.youtube.com/embed/ASzOzrB-a9E",
                Price = 999
            }, new Game
            {
                GameId = new Guid("fd94bacd-6151-4d04-8dfa-b0750cd25d93"),
                Name = "Life is Strange True Colors",
                Description = "Алекс Чэнь от всех скрывает своё «проклятие» — сверхъестественную способность считывать сильные эмоции других и влиять на них. Но когда её брат погибает — якобы в результате несчастного случая, — Алекс использует её, чтобы узнать правду.",
                Category = "Экшен",
                TitleImage = "/images/games/lifeIsStrangeTrueColors.jpeg",
                Video = "https://www.youtube.com/embed/b6CkzwVAr0M",
                Price = 1999
            }, new Game
            {
                GameId = new Guid("c6b7d8f3-b571-4c33-ab18-d8df6ed4542f"),
                Name = "Grand Theft Auto V",
                Description = "Grand Theft Auto V для PC позволяет игрокам исследовать знаменитый мир Лос-Сантоса и округа Блэйн в разрешении до 4k и выше с частотой 60 кадров в секунду.",
                Category = "Открытый мир",
                TitleImage = "/images/games/gtaV.jpeg",
                Video = "https://www.youtube.com/embed/QkkoHAzjnUs",
                Price = 1099
            }, new Game
            {
                GameId = new Guid("92eb4866-97c8-4d7d-839f-eb482a69068c"),
                Name = "Tom Clancy\'s Rainbow Six® Siege",
                Description = "Tom Clancy\'s Rainbow Six Осада – это продолжение нашумевшего шутера от первого лица, разработанного студией Ubisoft Montreal.",
                Category = "Тактический шутер",
                TitleImage = "/images/games/rainbowSiege.jpeg",
                Video = "https://www.youtube.com/embed/6wlvYh0h63k",
                Price = 499
            }, new Game
            {
                GameId = new Guid("60d829f6-80e5-4a4d-bbce-571b543d66c3"),
                Name = "Assassin’s Creed Valhalla",
                Description = "Assassin’s Creed Valhalla — мультиплатформенная компьютерная игра в жанре action/RPG, разработанная студией Ubisoft Montreal под издательством компании Ubisoft. Является двенадцатой игрой в серии игр Assassin’s Creed.",
                Category = "РПГ",
                TitleImage = "/images/games/assassinsCreedValhalla.png",
                Video = "https://www.youtube.com/embed/ssrNcwxALS4",
                Price = 2299
            });
        }
    }
}