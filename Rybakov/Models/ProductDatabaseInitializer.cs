﻿using Rybakov.Models;
using System.Collections.Generic;
using System.Data.Entity;

namespace Rybakov.Models
{
    public class ProductDatabaseInitializer : DropCreateDatabaseIfModelChanges<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetProducts().ForEach(p => context.Products.Add(p));
        }

        private static List<Category> GetCategories()
        {
            var categories = new List<Category> {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Новые"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Б/у"
                },
            };

            return categories;
        }

        private static List<Product> GetProducts()
        {
            var products = new List<Product> {
                new Product
                {
                    ProductID = 1,
                    ProductName = "Convertible Car",
                    Description = "This convertible car is fast! The engine is powered by a neutrino based battery (not included)." +
                                  "Power it up and let it go!",
                    ImagePath="car1.jpg",
                    UnitPrice = 22.50,
                    CategoryID = 1
               },
                new Product
                {
                    ProductID = 2,
                    ProductName = "Old-time Car",
                    Description = "There's nothing old about this toy car, except it's looks. Compatible with other old toy cars.",
                    ImagePath = "car2.jpg",
                    UnitPrice = 15.95,
                     CategoryID = 1
               },
                new Product
                {
                    ProductID = 3,
                    ProductName = "Fast Car",
                    Description = "Yes this car is fast, but it also floats in water.",
                    ImagePath="car3.jpg",
                    UnitPrice = 32.99,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 4,
                    ProductName = "Super Fast Car",
                    Description = "Use this super fast car to entertain guests. Lights and doors work!",
                    ImagePath="car4.jpg",
                    UnitPrice = 8.95,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 5,
                    ProductName = "Old Style Racer",
                    Description = "This old style racer can fly (with user assistance). Gravity controls flight duration." +
                                  "No batteries required.",
                    ImagePath="car5.jpg",
                    UnitPrice = 34.95,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 6,
                    ProductName = "Ace Plane",
                    Description = "Authentic airplane toy. Features realistic color and details.",
                    ImagePath="car6.jpg",
                    UnitPrice = 95.00,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 7,
                    ProductName = "Glider",
                    Description = "This fun glider is made from real balsa wood. Some assembly required.",
                    ImagePath="car7.jpg",
                    UnitPrice = 4.95,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 8,
                    ProductName = "Paper Plane",
                    Description = "This paper plane is like no other paper plane. Some folding required.",
                    ImagePath="car8.jpg",
                    UnitPrice = 2.95,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 9,
                    ProductName = "Propeller Plane",
                    Description = "Rubber band powered plane features two wheels.",
                    ImagePath="car9.jpg",
                    UnitPrice = 32.95,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 10,
                    ProductName = "Early Truck",
                    Description = "This toy truck has a real gas powered engine. Requires regular tune ups.",
                    ImagePath="car10.jpg",
                    UnitPrice = 15.00,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 11,
                    ProductName = "Fire Truck",
                    Description = "You will have endless fun with this one quarter sized fire truck.",
                    ImagePath="car11.jpg",
                    UnitPrice = 26.00,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 12,
                    ProductName = "Big Truck",
                    Description = "This fun toy truck can be used to tow other trucks that are not as big.",
                    ImagePath="car12.jpg",
                    UnitPrice = 29.00,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 13,
                    ProductName = "Big Ship",
                    Description = "Is it a boat or a ship. Let this floating vehicle decide by using its " +
                                  "artifically intelligent computer brain!",
                    ImagePath="car13.jpg",
                    UnitPrice = 95.00,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 14,
                    ProductName = "Paper Boat",
                    Description = "Floating fun for all! This toy boat can be assembled in seconds. Floats for minutes!" +
                                  "Some folding required.",
                    ImagePath="car14.jpg",
                    UnitPrice = 4.95,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 15,
                    ProductName = "Sail Boat",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="car15.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 16,
                    ProductName = "Rocket",
                    Description = "This fun rocket will travel up to a height of 200 feet.",
                    ImagePath="car16.jpg",
                    UnitPrice = 122.95,
                    CategoryID = 2
                }
            };

            return products;
        }
    }
}
