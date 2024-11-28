//-----------------------------------------------------------------
//    <copyright file="Lesson.cs" company="IPCA">
//     Copyright IPCA-EST. All rights reserved.
//    </copyright>
//    <date>28-12-2024</date>
//    <time>21:00</time>
//    <version>0.1</version>
//    <author>Ernesto Casanova</author>
//-----------------------------------------------------------------

using Lesson10.Enums;
using Lesson10.Interfaces;
using Lesson10.Models;
using Lesson10.Models.Facade.View;
using Lesson10.Models.Payments;
using Microsoft.Extensions.DependencyInjection;

namespace Lesson10
{
    /// <summary>
    /// Summary description for Lesson.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Main function
        /// </summary>
        /// <param name="args">string[]</param>
        static void Main(string[] args)
        {
            #region 1. Singleton Pattern (Private Constructor)
            // The Singleton pattern restricts a class to a single instance.
            // In C#, this is typically done by using a private constructor to 
            // prevent external instantiation and exposing a static property 
            // or method to access the instance.
            
            Singleton.Instance.DoSomething();
            
            // In Singleton.Instance, it provides the only access to the Singleton instance. 
            // This ensures there's only one instance of Singleton throughout the application.
            #endregion
            
            #region 2. Parameterized Constructor for Dependency Injection
            // Constructors with arguments are commonly used in Dependency Injection (DI). 
            // This is particularly useful in applications using frameworks like ASP.NET Core, 
            // where dependencies are injected into classes to promote loose coupling and testability.
            
            // Console Logger Implementation
            ConsoleLogger consoleLogger = new ConsoleLogger();
            ReportGenerator reportConsoleGenerator = new ReportGenerator(consoleLogger);
            reportConsoleGenerator.GenerateReport();
            
            // File Logger Implementation
            FileLogger fileLogger = new FileLogger();
            ReportGenerator reportFileGenerator = new ReportGenerator(fileLogger);
            reportFileGenerator.GenerateReport();
            
            // Cloud Logger Implementation (Like ElasticSearch and Kibana)
            CloudLogger cloudLogger = new CloudLogger();
            ReportGenerator reportCloudGenerator = new ReportGenerator(cloudLogger);
            reportCloudGenerator.GenerateReport();
            
            // ILogger as an Interface:
            // Reason for Using an Interface:
            //
            // Using an interface (ILogger) instead of a concrete implementation
            // (like ConsoleLogger, FileLogger, etc.) allows you to decouple
            // the ReportGenerator class from specific implementations of logging.
            //     - This makes ReportGenerator agnostic about how logging is performed.
            //       It doesn't care whether logs are written to the console, a file,
            //       a database, or a cloud service—just that logging is done.
            //     - This enables Dependency Inversion Principle (DIP), which is a core
            //       principle of SOLID design:
            // High-level modules (like ReportGenerator) should not depend on low-level
            // modules (specific loggers). Both should depend on abstractions (ILogger).
            //
            //     Flexibility: At runtime, you can inject different implementations of
            //     ILogger, such as FileLogger, ConsoleLogger, or even a mock logger for
            //     testing purposes.
            //
            //     Testability: You can inject a mock or stub implementation of ILogger
            //     when testing ReportGenerator, which makes it easier to verify the
            //     logging behavior without relying on external systems (e.g., file
            //     system, cloud).
            //
            //     _logger as a Dependency:
            // Constructor Injection:
            //
            // The ILogger dependency is provided (or injected) to the ReportGenerator
            // through its constructor.
            //     This pattern makes the dependency explicit, meaning the class clearly
            //     declares that it cannot function without an ILogger.
            //     Why readonly?
            //
            // Marking _logger as readonly ensures that it can only be assigned during
            // construction and prevents accidental reassignment later, preserving the
            // integrity of the object.
            #endregion
            
            #region 2.1. Constructor for Dependency Injection with Microsoft.Extentions NuGet
            // Step 1: Setup the Dependency Injection (DI) container
            ServiceProvider provider = ConfigureServices();

            // Step 2: Resolve and retrieve the service (Greeter)
            ReportGenerator report = provider.GetService<ReportGenerator>();

            // Step 3: Use the resolved service
            report.GenerateReport();
            #endregion
            
            #region 3. Factory Pattern (Private Constructor with Factory Method)
            // The Factory pattern is another example where a private constructor is useful. 
            // It allows you to control the instantiation of objects and encapsulate the 
            // creation logic in a factory method.
            
            Product product = Product.CreateProduct("Laptop", 1500);
            Console.WriteLine($"Product: {product.Name}, Price: {product.Price}");
            
            // The Product class has a private constructor and a public static method 
            // CreateProduct, which acts as a factory method. This factory method ensures 
            // that products are only created if they meet certain criteria (e.g., price 
            // is non-negative). This approach encapsulates the creation logic and prevents 
            // direct instantiation with potentially invalid data.
            #endregion
            
            #region 3.1. Factory Simple Pattern (Static Class with Simple Factory)
            // Use factory to create the payment instance
            IPayment payment = PaymentSimpleFactory.CreatePayment(PaymentType.CreditCard);

            // Process payment
            payment.ProcessPayment(100.00m);
            #endregion
            
            #region 4. Facade Pattern (Private Constructor with Facade Method)
            // Initialize individual views
            IView header = new HeaderView();
            IView content = new ContentView();
            IView footer = new FooterView();

            // Use the facade to manage rendering
            var pageRenderer = new PageRenderer(header, content, footer);
            pageRenderer.RenderPage();
            #endregion
            
            // *** Summary ***
            //  - Singleton Pattern: Uses a private constructor to prevent external
            // instantiation, ensuring a single instance.
            //  - Dependency Injection: Uses a parameterized constructor to inject
            // dependencies, promoting flexibility and testability.
            //  - Factory Pattern: Multiple examples, the simple one uses
            // a private constructor with a factory method to control object
            // creation and enforce specific rules.
            //  - Facade Pattern: The Facade pattern by centralizing the rendering
            // of multiple view components into a single interface (PageRenderer)
            // that the client can use easily.
        }
        
        //Dependency Injection with Microsoft.Extentions NuGet
        static ServiceProvider ConfigureServices()
        {
            // Create a service collection and register services
            ServiceCollection services = new ServiceCollection();
            services.AddTransient<ILogger, FileLogger>();
            services.AddTransient<ReportGenerator>();
        
            return services.BuildServiceProvider();
        }
    }
}