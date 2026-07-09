using ECommerceSystem.Data;
using ECommerceSystem.Models;
using Microsoft.EntityFrameworkCore;


namespace ECommerceSystem
{
    internal class Program
    {
      

        //case 1
        public static void RegisterUser()
        {
            using (var context = new ECommerceContext())
            {
                Console.WriteLine("Enter Username: ");
                string username = Console.ReadLine();

                Console.Write("Enter Email: ");
                string email = Console.ReadLine();

                Console.WriteLine("Enter password: ");
                string password = Console.ReadLine();

                Console.WriteLine("Enter full name: ");
                string fullName = Console.ReadLine();

                Console.WriteLine("Enter phone number: ");
                string phonenumber = Console.ReadLine();

                Console.WriteLine("Enter address: ");
                string address = Console.ReadLine();



                // creta a new user object
                User newUser = new User
                {
                    username = username,
                    email = email,
                    passwordHash = password,
                    fullName = fullName,
                    phoneNumber = phonenumber,
                    address = address,
                    registrationDate = DateTime.Now,
                    isActive = true
                };

                //add user to database
                context.Users.Add(newUser);
                //save changes
                context.SaveChanges();
                //display the userid
                Console.WriteLine("user registered successfuly..");
                Console.WriteLine($"assigned user id: {newUser.userId}");

            }
        }

        //case 2
        public static void addProduct()
        {
            using (var context = new ECommerceContext())
            {
                Console.WriteLine("Enter product Name: ");
                string productName = Console.ReadLine();

                Console.WriteLine("Enter description: ");
                string description = Console.ReadLine();

                Console.WriteLine("Enter price: ");
                decimal price = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Enter stock Quantity: ");
                int stockQuantity = int.Parse(Console.ReadLine());

                //create product obj
                Product newProduct = new Product
                {
                    productName = productName,
                    description = description,
                    price = price,
                    stockQuantity = stockQuantity,
                };

                //add product
                context.Products.Add(newProduct);
                //save to database
                context.SaveChanges();
                //display
                Console.WriteLine("product add successefully..");
                Console.WriteLine($"product id: {newProduct.productId}");

            }
        }




        static void Main(string[] args)
        {


            // Main Menu
            bool exit = false;
            while (exit == false)
            {
                Console.WriteLine("Flight Management System");
                Console.WriteLine("========================================");
                Console.WriteLine(" 1. Register a New User"); 
                Console.WriteLine(" 2. Add a New Product to a Category"); 
                Console.WriteLine(" 3. Place an Order"); 
                Console.WriteLine(" 4. Write a Product Review"); 
                Console.WriteLine(" 5. Update Product Price and Availability");
                Console.WriteLine(" 6. Cancel an Order");
                Console.WriteLine(" 7. Delete a Review");
                Console.WriteLine(" 8. View All Products(Get All)");
                Console.WriteLine(" 9. Filter Products by Category and Price Range");
                Console.WriteLine(" 10. Get Category with All Its Products(Include)");
                Console.WriteLine(" 11. View Order History with Full Details(ThenInclude)");
                Console.WriteLine(" 12. Product Summary Report (Projection + Lazy Loading)");
                Console.WriteLine(" 0.  Exit");
                Console.Write("Select option: ");

                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                   
                    case 1:
                        RegisterUser();
                        break;

                    case 2:
                       
                        break;

                    case 3:
                        
                        break;
                    case 4:
                        
                        break;

                    case 5:
                       
                        break;

                    case 6:
                       
                        break;

                    case 7:
                       
                        break;

                    case 8:
                        
                        break;

                    case 9:
                       
                        break;

                    case 10:
                        
                        break;

                    case 11:
                       
                        break;

                    case 12:

                        break;
                    case 0: exit = true; break;
                    default: Console.WriteLine("Invalid option. Please try again."); break;
                }

                if (!exit)
                {
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }

            Console.WriteLine("Goodbye!");


        }
    }



}
