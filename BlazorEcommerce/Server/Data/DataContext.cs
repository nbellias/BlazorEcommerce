
using BlazorEcommerce.Shared.Entities;

namespace BlazorEcommerce.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CartItem>()
                .HasKey(ci => new { ci.UserId, ci.ProductId, ci.ProductTypeId });

            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = Guid.Parse("e72b0914-9057-4bcf-ab27-dca606bc3796"),
                    Name = "Books",
                    Url = "books"
                },
                new Category
                {
                    Id = Guid.Parse("bab82ab7-2a1c-469c-92b6-4d0b606444ee"),
                    Name = "Movies",
                    Url = "movies"
                },
                new Category
                {
                    Id = Guid.Parse("29556bf0-ecee-4c97-af94-4b67acbd7efc"),
                    Name = "Video Games",
                    Url = "video-games"
                }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = Guid.Parse("bfb850c2-3c74-4d06-b39b-ff94a7f89f74"),
                    Title = "The Hitchhiker's Guide to the Galaxy",
                    Description = "The Hitchhiker's Guide to the Galaxy[note 1] (sometimes referred to as HG2G,[1] HHGTTG,[2] H2G2,[3] or tHGttG) is a comedy science fiction franchise created by Douglas Adams. Originally a 1978 radio comedy broadcast on BBC Radio 4, it was later adapted to other formats, including stage shows, novels, comic books, a 1981 TV series, a 1984 text-based computer game, and 2005 feature film.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                    CategoryId = Guid.Parse("e72b0914-9057-4bcf-ab27-dca606bc3796"),
                    Featured = true
                },
                new Product
                {
                    Id = Guid.Parse("10c34a0c-34d2-4701-9747-6fd1bc8453a1"),
                    Title = "Ready Player One",
                    Description = "Ready Player One is a 2011 science fiction novel, and the debut novel of American author Ernest Cline. The story, set in a dystopia in 2045, follows protagonist Wade Watts on his search for an Easter egg in a worldwide virtual reality game, the discovery of which would lead him to inherit the game creator's fortune. Cline sold the rights to publish the novel in June 2010, in a bidding war to the Crown Publishing Group (a division of Random House).[1] The book was published on August 16, 2011.[2] An audiobook was released the same day; it was narrated by Wil Wheaton, who was mentioned briefly in one of the chapters.[3][4]Ch. 20 In 2012, the book received an Alex Award from the Young Adult Library Services Association division of the American Library Association[5] and won the 2011 Prometheus Award.[6]",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/a/a4/Ready_Player_One_cover.jpg",
                    CategoryId = Guid.Parse("e72b0914-9057-4bcf-ab27-dca606bc3796")
                },
                new Product
                {
                    Id = Guid.Parse("ec68bfcc-282b-48f4-966b-94a5a438c808"),
                    Title = "Nineteen Eighty-Four",
                    Description = "Nineteen Eighty-Four (also stylised as 1984) is a dystopian social science fiction novel and cautionary tale written by English writer George Orwell. It was published on 8 June 1949 by Secker & Warburg as Orwell's ninth and final book completed in his lifetime. Thematically, it centres on the consequences of totalitarianism, mass surveillance and repressive regimentation of people and behaviours within society.[2][3] Orwell, a democratic socialist, modelled the totalitarian government in the novel after Stalinist Russia and Nazi Germany.[2][3][4] More broadly, the novel examines the role of truth and facts within politics and the ways in which they are manipulated.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/c/c3/1984first.jpg",
                    CategoryId = Guid.Parse("e72b0914-9057-4bcf-ab27-dca606bc3796")
                },
                new Product
                {
                    Id = Guid.Parse("b784d506-98ec-4a86-900d-48d63700b1ce"),
                    Title = "The Matrix",
                    Description = "The Matrix is a 1999 science fiction action film written and directed by the Wachowskis, and produced by Joel Silver. Starring Keanu Reeves, Laurence Fishburne, Carrie-Anne Moss, Hugo Weaving, and Joe Pantoliano, and as the first installment in the Matrix franchise, it depicts a dystopian future in which humanity is unknowingly trapped inside a simulated reality, the Matrix, which intelligent machines have created to distract humans while using their bodies as an energy source. When computer programmer Thomas Anderson, under the hacker alias \"Neo\", uncovers the truth, he \"is drawn into a rebellion against the machines\" along with other people who have been freed from the Matrix.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/c/c1/The_Matrix_Poster.jpg",
                    CategoryId = Guid.Parse("bab82ab7-2a1c-469c-92b6-4d0b606444ee")
                },
                new Product
                {
                    Id = Guid.Parse("81b77744-e198-40fe-b102-8c48ef41b283"),
                    Title = "Back to the Future",
                    Description = "Back to the Future is a 1985 American science fiction film directed by Robert Zemeckis. Written by Zemeckis and Bob Gale, it stars Michael J. Fox, Christopher Lloyd, Lea Thompson, Crispin Glover, and Thomas F. Wilson. Set in 1985, the story follows Marty McFly (Fox), a teenager accidentally sent back to 1955 in a time-traveling DeLorean automobile built by his eccentric scientist friend Doctor Emmett \"Doc\" Brown (Lloyd). Trapped in the past, Marty inadvertently prevents his future parents' meeting—threatening his very existence—and is forced to reconcile the pair and somehow get back to the future.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/d/d2/Back_to_the_Future.jpg",
                    CategoryId = Guid.Parse("bab82ab7-2a1c-469c-92b6-4d0b606444ee"),
                    Featured = true
                },
                new Product
                {
                    Id = Guid.Parse("d67b758a-5447-41c2-8ae6-108d4f92ad4c"),
                    Title = "Toy Story",
                    Description = "Toy Story is a 1995 American computer-animated comedy film produced by Pixar Animation Studios and released by Walt Disney Pictures. The first installment in the Toy Story franchise, it was the first entirely computer-animated feature film, as well as the first feature film from Pixar. The film was directed by John Lasseter (in his feature directorial debut), and written by Joss Whedon, Andrew Stanton, Joel Cohen, and Alec Sokolow from a story by Lasseter, Stanton, Pete Docter, and Joe Ranft. The film features music by Randy Newman, was produced by Bonnie Arnold and Ralph Guggenheim, and was executive-produced by Steve Jobs and Edwin Catmull. The film features the voices of Tom Hanks, Tim Allen, Don Rickles, Wallace Shawn, John Ratzenberger, Jim Varney, Annie Potts, R. Lee Ermey, John Morris, Laurie Metcalf, and Erik von Detten. Taking place in a world where anthropomorphic toys come to life when humans are not present, the plot focuses on the relationship between an old-fashioned pull-string cowboy doll named Woody and an astronaut action figure, Buzz Lightyear, as they evolve from rivals competing for the affections of their owner, Andy Davis, to friends who work together to be reunited with Andy after being separated from him.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/1/13/Toy_Story.jpg",
                    CategoryId = Guid.Parse("bab82ab7-2a1c-469c-92b6-4d0b606444ee")
                },
                new Product
                {
                    Id = Guid.Parse("277adaa9-3d24-4814-b655-943f3cca2f9a"),
                    Title = "Half-Life 2",
                    Description = "Half-Life 2 is a 2004 first-person shooter game developed and published by Valve. Like the original Half-Life, it combines shooting, puzzles, and storytelling, and adds features such as vehicles and physics-based gameplay.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg",
                    CategoryId = Guid.Parse("29556bf0-ecee-4c97-af94-4b67acbd7efc")
                },
                new Product
                {
                    Id = Guid.Parse("fb9c047c-b557-4148-8103-0df3d8c4d17f"),
                    Title = "Diablo II",
                    Description = "Diablo II is an action role-playing hack-and-slash computer video game developed by Blizzard North and published by Blizzard Entertainment in 2000 for Microsoft Windows, Classic Mac OS, and macOS.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/d/d5/Diablo_II_Coverart.png",
                    CategoryId = Guid.Parse("29556bf0-ecee-4c97-af94-4b67acbd7efc")
                },
                new Product
                {
                    Id = Guid.Parse("2655e4a5-6017-49e2-a4f2-e7e19477cd21"),
                    Title = "Day of the Tentacle",
                    Description = "Day of the Tentacle, also known as Maniac Mansion II: Day of the Tentacle, is a 1993 graphic adventure game developed and published by LucasArts. It is the sequel to the 1987 game Maniac Mansion.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/7/79/Day_of_the_Tentacle_artwork.jpg",
                    CategoryId = Guid.Parse("29556bf0-ecee-4c97-af94-4b67acbd7efc"),
                    Featured = true
                },
                new Product
                {
                    Id = Guid.Parse("30352fe2-306a-401f-bc1a-80175a6f6339"),
                    Title = "Xbox",
                    Description = "The Xbox is a home video game console and the first installment in the Xbox series of video game consoles manufactured by Microsoft.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/4/43/Xbox-console.jpg",
                    CategoryId = Guid.Parse("29556bf0-ecee-4c97-af94-4b67acbd7efc")
                },
                new Product
                {
                    Id = Guid.Parse("52c7bca4-530f-4bd2-aa10-614764287ea4"),
                    Title = "Super Nintendo Entertainment System",
                    Description = "The Super Nintendo Entertainment System (SNES), also known as the Super NES or Super Nintendo, is a 16-bit home video game console developed by Nintendo that was released in 1990 in Japan and South Korea.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/e/ee/Nintendo-Super-Famicom-Set-FL.jpg",
                    CategoryId = Guid.Parse("29556bf0-ecee-4c97-af94-4b67acbd7efc")
                }
            );

            modelBuilder.Entity<ProductType>().HasData(
                    new ProductType { Id = Guid.Parse("41a4ba21-4a69-48eb-9670-4a332ee0d471"), Name = "Default" },
                    new ProductType { Id = Guid.Parse("a02f43d7-1cbe-4e52-b7a5-f70edc0dbc67"), Name = "Paperback" },
                    new ProductType { Id = Guid.Parse("9a5e15c5-45c5-460c-97f6-5ecd3ada998e"), Name = "E-Book" },
                    new ProductType { Id = Guid.Parse("8fa1a293-9176-425d-8ef5-d22e49f66dd5"), Name = "Audiobook" },
                    new ProductType { Id = Guid.Parse("c95c9386-0231-48f5-8e8b-bb47950646bc"), Name = "Stream" },
                    new ProductType { Id = Guid.Parse("d0aa1426-45b6-4ecc-83e2-7eb03f94f307"), Name = "Blu-ray" },
                    new ProductType { Id = Guid.Parse("29ba1ff3-454e-4752-a774-9f889e978a57"), Name = "VHS" },
                    new ProductType { Id = Guid.Parse("d6b9cc8c-803f-4ba0-8ffb-a3171baaf618"), Name = "PC" },
                    new ProductType { Id = Guid.Parse("c1a0a0a5-abaa-4051-b3dc-ff4acc37f678"), Name = "PlayStation" },
                    new ProductType { Id = Guid.Parse("9c453430-13ec-4af0-be34-0466ad416573"), Name = "Xbox" }
                ); ;

            modelBuilder.Entity<ProductVariant>()
                .HasKey(p => new { p.ProductId, p.ProductTypeId });

            modelBuilder.Entity<ProductVariant>()
                .HasData(
                new ProductVariant
                {
                    ProductId = Guid.Parse("bfb850c2-3c74-4d06-b39b-ff94a7f89f74"),
                    ProductTypeId = Guid.Parse("a02f43d7-1cbe-4e52-b7a5-f70edc0dbc67"),
                    Price = 9.99m,
                    OriginalPrice = 19.99m
                },
                new ProductVariant
                {
                    ProductId = Guid.Parse("bfb850c2-3c74-4d06-b39b-ff94a7f89f74"),
                    ProductTypeId = Guid.Parse("9a5e15c5-45c5-460c-97f6-5ecd3ada998e"),
                    Price = 7.99m
                },
                new ProductVariant
                {
                    ProductId = Guid.Parse("bfb850c2-3c74-4d06-b39b-ff94a7f89f74"),
                    ProductTypeId = Guid.Parse("8fa1a293-9176-425d-8ef5-d22e49f66dd5"),
                    Price = 19.99m,
                    OriginalPrice = 29.99m
                },
                new ProductVariant
                {
                    ProductId = Guid.Parse("10c34a0c-34d2-4701-9747-6fd1bc8453a1"),
                    ProductTypeId = Guid.Parse("a02f43d7-1cbe-4e52-b7a5-f70edc0dbc67"),
                    Price = 7.99m,
                    OriginalPrice = 14.99m
                },
                new ProductVariant
                {
                    ProductId = Guid.Parse("ec68bfcc-282b-48f4-966b-94a5a438c808"),
                    ProductTypeId = Guid.Parse("a02f43d7-1cbe-4e52-b7a5-f70edc0dbc67"),
                    Price = 6.99m
                },
                new ProductVariant
                {
                    ProductId = Guid.Parse("b784d506-98ec-4a86-900d-48d63700b1ce"),
                    ProductTypeId = Guid.Parse("c95c9386-0231-48f5-8e8b-bb47950646bc"),
                    Price = 3.99m
                },
                new ProductVariant
                {
                    ProductId = Guid.Parse("b784d506-98ec-4a86-900d-48d63700b1ce"),
                    ProductTypeId = Guid.Parse("d0aa1426-45b6-4ecc-83e2-7eb03f94f307"),
                    Price = 9.99m
                },
                new ProductVariant
                {
                    ProductId = Guid.Parse("b784d506-98ec-4a86-900d-48d63700b1ce"),
                    ProductTypeId = Guid.Parse("29ba1ff3-454e-4752-a774-9f889e978a57"),
                    Price = 19.99m
                },
                new ProductVariant
                {
                    ProductId = Guid.Parse("81b77744-e198-40fe-b102-8c48ef41b283"),
                    ProductTypeId = Guid.Parse("c95c9386-0231-48f5-8e8b-bb47950646bc"),
                    Price = 3.99m,
                },
                new ProductVariant
                {
                    ProductId = Guid.Parse("d67b758a-5447-41c2-8ae6-108d4f92ad4c"),
                    ProductTypeId = Guid.Parse("c95c9386-0231-48f5-8e8b-bb47950646bc"),
                    Price = 2.99m
                },
                new ProductVariant
                {
                    ProductId = Guid.Parse("277adaa9-3d24-4814-b655-943f3cca2f9a"),
                    ProductTypeId = Guid.Parse("d6b9cc8c-803f-4ba0-8ffb-a3171baaf618"),
                    Price = 19.99m,
                    OriginalPrice = 29.99m
                },
                new ProductVariant
                {
                    ProductId = Guid.Parse("277adaa9-3d24-4814-b655-943f3cca2f9a"),
                    ProductTypeId = Guid.Parse("c1a0a0a5-abaa-4051-b3dc-ff4acc37f678"),
                    Price = 69.99m
                },
                new ProductVariant
                {
                    ProductId = Guid.Parse("277adaa9-3d24-4814-b655-943f3cca2f9a"),
                    ProductTypeId = Guid.Parse("9c453430-13ec-4af0-be34-0466ad416573"),
                    Price = 49.99m,
                    OriginalPrice = 59.99m
                },
                new ProductVariant
                {
                    ProductId = Guid.Parse("fb9c047c-b557-4148-8103-0df3d8c4d17f"),
                    ProductTypeId = Guid.Parse("d6b9cc8c-803f-4ba0-8ffb-a3171baaf618"),
                    Price = 9.99m,
                    OriginalPrice = 24.99m,
                },
                new ProductVariant
                {
                    ProductId = Guid.Parse("2655e4a5-6017-49e2-a4f2-e7e19477cd21"),
                    ProductTypeId = Guid.Parse("d6b9cc8c-803f-4ba0-8ffb-a3171baaf618"),
                    Price = 14.99m
                },
                new ProductVariant
                {
                    ProductId = Guid.Parse("30352fe2-306a-401f-bc1a-80175a6f6339"),
                    ProductTypeId = Guid.Parse("41a4ba21-4a69-48eb-9670-4a332ee0d471"),
                    Price = 159.99m,
                    OriginalPrice = 299m
                },
                new ProductVariant
                {
                    ProductId = Guid.Parse("52c7bca4-530f-4bd2-aa10-614764287ea4"),
                    ProductTypeId = Guid.Parse("41a4ba21-4a69-48eb-9670-4a332ee0d471"),
                    Price = 79.99m,
                    OriginalPrice = 399m
                }
                );
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<ProductVariant> ProductVariants { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
    }
}
