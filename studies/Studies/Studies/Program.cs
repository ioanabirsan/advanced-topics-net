using System;
using System.Linq;
using Studies.context;
using Studies.models;

namespace Studies
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            using (var ctx = new ModelSelfReferences())
            {
                SelfReference first = new SelfReference
                {
                    Name = "First"
                };

                SelfReference second = new SelfReference
                {
                    Name = "Second"
                };

                ctx.SelfReferences.Add(first);
                ctx.SelfReferences.Add(second);
                ctx.SaveChanges();

                foreach (var item in ctx.SelfReferences)
                {
                    Console.WriteLine("{0} {1}", item.SelfReferenceId, item.Name);
                }
            }
            */

            /*
            using (var ctx = new ProductContext())
            {
                var product = new Product
                {
                    SKU = 147,
                    Description = "Expandable Hydration Pack",
                    Price = 19.97M,
                    ImageUrl = "/pack147.jpg"
                };
                ctx.Products.Add(product);

                product = new Product
                {
                    SKU = 178,
                    Description = "Rugged Ranger Duffel Bag",
                    Price = 39.97M,
                    ImageUrl = "/pack178.jpg"
                };
                ctx.Products.Add(product);

                product = new Product
                {
                    SKU = 186,
                    Description = "Range Field Pack",
                    Price = 98.97M,
                    ImageUrl = "/noimage.jp"
                };
                ctx.Products.Add(product);

                product = new Product
                {
                    SKU = 202,
                    Description = "Small Deployment Back Pack",
                    Price = 29.97M,
                    ImageUrl= "/pack202.jpg"
                };
                ctx.Products.Add(product);

                ctx.SaveChanges();
            }
            */

            /*
            byte[] thumbBits = new byte[100];
            byte[] fullBits = new byte[2000];

            using (var context = new PhotographContext())
            {
                var photo = new Photograph
                {
                    Title = "My Dog",
                    ThumbnailBits = thumbBits
                };

                var fullImage = new PhotographFullImage
                {
                    HighResolutionBits = fullBits
                };

                photo.PhotographFullImage = fullImage;

                context.Photographs.Add(photo);
                context.SaveChanges();
            }

            using (var context = new PhotographContext())
            {
                foreach (var photo in context.Photographs)
                {
                    Console.WriteLine("Photo: {0}, ThumbnailSize {1} bytes", photo.Title, photo.ThumbnailBits.Length);
                    // explicitly load the "expensive" entity,
                    context.Entry(photo)
                        .Reference(p => p.PhotographFullImage)
                        .Load();

                    Console.WriteLine("Full Image Size: {0} bytes",
                        photo.PhotographFullImage.HighResolutionBits.Length);
                }
            }
            */

            /*
            using (var context = new BusinessContext())
            {
                var business = new Business
                {
                    Name = "Corner Dry Cleaning",
                    LicenseNumber = "100x1"
                };

                context.Businesses.Add(business);

                var retail = new Retail
                {
                    Name = "Shop and Save",
                    LicenseNumber = "200C",
                    Address = "101 Main",
                    City = "Anytown",
                    State = "TX", ZIPCode = "76106"
                };

                context.Businesses.Add(retail);

                var web = new eCommerce
                {
                    Name = "BuyNow.com",
                    LicenseNumber = "300AB",
                    URL = "www.buynow.com"
                };

                context.Businesses.Add(web);

                context.SaveChanges();
            }

            using (var context = new BusinessContext())
            {
                Console.WriteLine("\n---All Businesses ---");

                foreach (var business in context.Businesses)
                {
                    Console.WriteLine("{0} (#{1})", business.Name, business.LicenseNumber);
                }

                Console.WriteLine("\n---Retail Businesses ---");
                foreach (var retail in context.Businesses.OfType<Retail>())
                {
                    Console.WriteLine("{0} (#{1})", retail.Name, retail.LicenseNumber);
                    Console.WriteLine("{0}", retail.Address);
                    Console.WriteLine("{0}, {1} {2}", retail.City, retail.State, retail.ZIPCode);
                }

                Console.WriteLine("\n---eCommerce Businesses ---");
                foreach (var eCommerce in context.Businesses.OfType<eCommerce>())
                {
                    Console.WriteLine("{0} (#{1})", eCommerce.Name, eCommerce.LicenseNumber);
                    Console.WriteLine("Online address is: {0}", eCommerce.URL);
                }
            }
            */

            using (var context = new EmployeeContext())
            {
                var fte = new FullTimeEmployee
                {
                    FirstName = "Jane",
                    LastName = "Doe",
                    Salary = 71500M
                };

                context.Employees.Add(fte);

                fte = new FullTimeEmployee
                {
                    FirstName = "John",
                    LastName = "Smith",
                    Salary = 62500M
                };

                context.Employees.Add(fte);

                var hourly = new HourlyEmployee
                {
                    FirstName = "Tom",
                    LastName = "Jones",
                    Wage = 8.75M
                };

                context.Employees.Add(hourly);

                context.SaveChanges();
            }

            using (var context = new EmployeeContext())
            {
                Console.WriteLine("---All Employees ---");
                foreach (var employee in context.Employees)
                {
                    bool fullTime = !(employee is HourlyEmployee);
                    Console.WriteLine("{0} {1} ({2})", employee.FirstName, employee.LastName, fullTime ? "Full Time" : "Hourly");
                }

                Console.WriteLine("---Full Time ---");
                foreach (var fullTimeEmployee in context.Employees.OfType<FullTimeEmployee>())
                {
                    Console.WriteLine("{0} {1}", fullTimeEmployee.FirstName, fullTimeEmployee.LastName);
                }

                Console.WriteLine("---Hourly ---");
                foreach (var hourlyEmployee in context.Employees.OfType<HourlyEmployee>())
                {
                    Console.WriteLine("{0} {1}", hourlyEmployee.FirstName, hourlyEmployee.LastName);
                }
            }
        }
    }
}