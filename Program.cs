using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using NewsletteCore.Context;
using NewsletteCore.Models;
using System.Diagnostics;
using System.Diagnostics.Metrics;

namespace NewsletteCore;

class Program
{
    private static Customer customer;

    static void Main()
    {
        using (var context = new NewsletterContext())
        {
        //    Customer customer;
        //    customer = new Customer
        //    {
        //        FullName = "John Doe",
        //        BirthDate = new DateTime(1990, 5, 15),
        //        Gender = "Male",
        //        Email = "johndoe@example.com",
        //        Country = "United States",
        //        City = "New York"
        //    };

            //    context.Customers.Add(customer);
            //    context.SaveChanges();
            //}
            //using (var context = new NewsletterContext())
            //{
            //    var section = new Section
            //    {
            //        Name = "Mobile Phones"
            //    };

            //    context.Sections.Add(section);

            //    var promotion = new Promotion
            //    {
            //        Name = "Summer Sale",
            //        StartDate = new DateTime(2024, 6, 1),
            //        EndDate = new DateTime(2024, 6, 30),
            //        Country = "United States",
            //        Section = section
            //    };

            //    context.Promotions.Add(promotion);

            //    var customerInterest = new CustomerInterest
            //    {
            //        Customer = customer,
            //        Section = section
            //    };

            //    context.CustomerInterests.Add(customerInterest);


            //}

            //using (var context = new NewsletterContext())
            //{
            //    // Создаем раздел "Laptops"
            //    var laptopsSection = new Section
            //    {
            //        Name = "Laptops"
            //    };
            //    context.Sections.Add(laptopsSection);

            //    // Создаем акцию "Back to School Sale" для раздела "Laptops"
            //    var laptopsPromotion = new Promotion
            //    {
            //        Name = "Back to School Sale",
            //        StartDate = new DateTime(2024, 8, 1),
            //        EndDate = new DateTime(2024, 8, 31),
            //        Country = "United States",
            //        Section = laptopsSection
            //    };
            //    context.Promotions.Add(laptopsPromotion);

            //    // Создаем связь между покупателем и разделом "Laptops"
            //    var customerLaptopsInterest = new CustomerInterest
            //    {
            //        Customer = customer, // Предполагается, что customer уже создан
            //        Section = laptopsSection
            //    };
            //    context.CustomerInterests.Add(customerLaptopsInterest);


            //}

            //using (var context = new NewsletterContext())
            //{
            //    // Создаем раздел "Mobile Phones"
            //    var mobilePhonesSection = new Section
            //    {
            //        Name = "Mobile Phones"
            //    };
            //    context.Sections.Add(mobilePhonesSection);

            //    // Создаем акцию "Summer Sale" для раздела "Mobile Phones"
            //    var mobilePhonesPromotion = new Promotion
            //    {
            //        Name = "Summer Sale",
            //        StartDate = new DateTime(2024, 6, 1),
            //        EndDate = new DateTime(2024, 6, 30),
            //        Country = "United States",
            //        Section = mobilePhonesSection
            //    };
            //    context.Promotions.Add(mobilePhonesPromotion);

            //    // Создаем связь между покупателем и разделом "Mobile Phones"
            //    var customerMobilePhonesInterest = new CustomerInterest
            //    {
            //        Customer = customer, 
            //        Section = mobilePhonesSection
            //    };
            //    context.CustomerInterests.Add(customerMobilePhonesInterest);


            //}
            //using (var context = new NewsletterContext())
            //{
            //    // Создаем раздел "Kitchen Appliances"
            //    var kitchenAppliancesSection = new Section
            //    {
            //        Name = "Kitchen Appliances"
            //    };
            //    context.Sections.Add(kitchenAppliancesSection);

            //    // Создаем акцию "Cooking Essentials Sale" для раздела "Kitchen Appliances"
            //    var kitchenAppliancesPromotion = new Promotion
            //    {
            //        Name = "Cooking Essentials Sale",
            //        StartDate = new DateTime(2024, 7, 1),
            //        EndDate = new DateTime(2024, 7, 31),
            //        Country = "United States",
            //        Section = kitchenAppliancesSection
            //    };
            //    context.Promotions.Add(kitchenAppliancesPromotion);

            //    // Создаем связь между покупателем и разделом "Kitchen Appliances"
            //    var customerKitchenAppliancesInterest = new CustomerInterest
            //    {
            //        Customer = customer, 
            //        Section = kitchenAppliancesSection
            //    };
            //    context.CustomerInterests.Add(customerKitchenAppliancesInterest);


            //}
        

}
        //using (var context = new NewsletterContext())
        //{
        //    // Добавляем страны
        //    var usa = new Country { Name = "United States" };
        //    var canada = new Country { Name = "Canada" };
        //    var uk = new Country { Name = "United Kingdom" };

        //    context.Countries.AddRange(usa, canada, uk);
        //    context.SaveChanges();

        //    // Добавляем города
        //    var newYork = new City { Name = "New York", Country = usa };
        //    var losAngeles = new City { Name = "Los Angeles", Country = usa };
        //    var toronto = new City { Name = "Toronto", Country = canada };
        //    var london = new City { Name = "London", Country = uk };

        //    context.Cities.AddRange(newYork, losAngeles, toronto, london);
        //    context.SaveChanges();
        //}
        using (var context = new NewsletterContext())
        {
            context.Database.EnsureCreated();
        }
        while (true)
        {
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1. Отобразить всех покупателей");
            Console.WriteLine("2. Отобразить email всех покупателей");
            Console.WriteLine("3. Отобразить список разделов");
            Console.WriteLine("4. Отобразить список аукционных товаров");
            Console.WriteLine("5. Отобразить всех городов");
            Console.WriteLine("6. Отобразить все страны");
            Console.WriteLine("7. Отобразить всех покупателей из конкретного города");
            Console.WriteLine("8. Отобразить всех покупателей из конкретной страны");
            Console.WriteLine("9. Отобразить все акции для конкретной страны");
            Console.WriteLine("10. Вставить нового покупателя");
            Console.WriteLine("11. Вставить новую страну");
            Console.WriteLine("12. Вставить новый город");
            Console.WriteLine("13. Вставить новый раздел");
            Console.WriteLine("14. Вставить новый аукционный товар");
            Console.WriteLine("15. Обновить информацию о покупателе");
            Console.WriteLine("16. Обновить информацию о стране");
            Console.WriteLine("17. Обновить информацию о городе");
            Console.WriteLine("18. Обновить информацию о разделе");
            Console.WriteLine("19. Обновить информацию об аукционном товаре");
            Console.WriteLine("20. Удалить покупателя");
            Console.WriteLine("21. Удалить страну");
            Console.WriteLine("22. Удалить город");
            Console.WriteLine("23. Удалить раздел");
            Console.WriteLine("24. Удалить аукционный товар");
            Console.WriteLine("25. Отобразить список городов конкретной страны");
            Console.WriteLine("26. Отобразить список разделов конкретного покупателя");
            Console.WriteLine("27. Отобразить список аукционных товаров конкретного раздела");
            Console.WriteLine("0. Выйти из программы");

            Console.Write("Введите номер действия: ");
            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Введите корректное число.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    DisplayAllCustomers();
                    break;
                case 2:
                    DisplayAllCustomerEmails();
                    break;
                case 3:
                    DisplayAllSections();
                    break;
                case 4:
                    DisplayAllPromotions();
                    break;
                case 5:
                    DisplayAllCities();
                    break;
                case 6:
                    DisplayAllCountries();
                    break;
                case 7:
                    DisplayCustomersByCity();
                    break;
                case 8:
                    DisplayCustomersByCountry();
                    break;
                case 9:
                    DisplayPromotionsByCountry();
                    break;
                case 10:
                    InsertNewCustomer();
                    break;
                case 11:
                    InsertNewCountry();
                    break;
                case 12:
                    InsertNewCity();
                    break;
                case 13:
                    InsertNewSection();
                    break;
                case 14:
                    InsertNewPromotion();
                    break;
                case 15:
                    UpdateCustomer();
                    break;
                case 16:
                    UpdateCountry();
                    break;
                case 17:
                    UpdateCity();
                    break;
                case 18:
                    UpdateSection();
                    break;
                case 19:
                    UpdatePromotion();
                    break;
                case 20:
                    DeleteCustomer();
                    break;
                case 21:
                    DeleteCountry();
                    break;
                case 22:
                    DeleteCity();
                    break;
                case 23:
                    DeleteSection();
                    break;
                case 24:
                    DeletePromotion();
                    break;
                case 25:
                    DisplayCitiesByCountry();
                    break;
                case 26:
                    DisplaySectionsByCustomer();
                    break;
                case 27:
                    DisplayProductsBySection();
                    break;
                case 0:
                    return;
                default:
                    Console.WriteLine("Некорректный выбор. Попробуйте снова.");
                    break;
            }
        }
    }

    private static void DisplayAllCustomers()
    {
        using (var context = new NewsletterContext())
        {
            var customers = context.Customers.ToList();
            Console.WriteLine("Список всех покупателей:");
            foreach (var customer in customers)
            {
                Console.WriteLine($"Имя: {customer.FullName}, Email: {customer.Email}");
            }
        }
    }

    private static void DisplayAllCustomerEmails()
    {
        using (var context = new NewsletterContext())
        {
            var customerEmails = context.Customers.Select(c => c.Email).ToList();
            Console.WriteLine("Email всех покупателей:");
            foreach (var email in customerEmails)
            {
                Console.WriteLine(email);
            }
        }
    }

    private static void DisplayAllSections()
    {
        using (var context = new NewsletterContext())
        {
            var sections = context.Sections.ToList();
            Console.WriteLine("Список всех разделов:");
            foreach (var section in sections)
            {
                Console.WriteLine($"Название раздела: {section.Name}");
            }
        }
    }

    private static void DisplayAllPromotions()
    {
        using (var context = new NewsletterContext())
        {
            var promotions = context.Promotions.ToList();
            Console.WriteLine("Список всех акций:");
            foreach (var promotion in promotions)
            {
                Console.WriteLine($"Название акции: {promotion.Name}");
            }
        }
    }

    private static void DisplayAllCities()
    {
        using (var context = new NewsletterContext())
        {
            var cities = context.Customers.Select(c => c.City).Distinct().ToList();
            Console.WriteLine("Список всех городов:");
            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
        }
    }

    private static void DisplayAllCountries()
    {
        using (var context = new NewsletterContext())
        {
            var countries = context.Customers.Select(c => c.Country).Distinct().ToList();
            Console.WriteLine("Список всех стран:");
            foreach (var country in countries)
            {
                Console.WriteLine(country);
            }
        }
    }

    private static void DisplayCustomersByCity()
    {
        Console.Write("Введите название города: ");
        var city = Console.ReadLine();
        using (var context = new NewsletterContext())
        {
            var customers = context.Customers.Where(c => c.City == city).ToList();
            if (customers.Count == 0)
            {
                Console.WriteLine($"Нет покупателей из города {city}");
                return;
            }
            Console.WriteLine($"Список покупателей из города {city}:");
            foreach (var customer in customers)
            {
                Console.WriteLine($"Имя: {customer.FullName}, Email: {customer.Email}");
            }
        }
    }

    private static void DisplayCustomersByCountry()
    {
        Console.Write("Введите название страны: ");
        var country = Console.ReadLine();
        using (var context = new NewsletterContext())
        {
            var customers = context.Customers.Where(c => c.Country == country).ToList();
            if (customers.Count == 0)
            {
                Console.WriteLine($"Нет покупателей из страны {country}");
                return;
            }
            Console.WriteLine($"Список покупателей из страны {country}:");
            foreach (var customer in customers)
            {
                Console.WriteLine($"Имя: {customer.FullName}, Email: {customer.Email}");
            }
        }
    }

    private static void DisplayPromotionsByCountry()
    {
        Console.Write("Введите название страны: ");
        var country = Console.ReadLine();
        using (var context = new NewsletterContext())
        {
            var promotions = context.Promotions.Where(p => p.Country == country).ToList();
            if (promotions.Count == 0)
            {
                Console.WriteLine($"Нет акций для страны {country}");
                return;
            }
            Console.WriteLine($"Список акций для страны {country}:");
            foreach (var promotion in promotions)
            {
                Console.WriteLine($"Название акции: {promotion.Name}");
            }
        }
    }

    private static void InsertNewCustomer()
    {
        using (var context = new NewsletterContext())
        {
            var customer = new Customer();
            Console.Write("Введите имя покупателя: ");
            customer.FullName = Console.ReadLine();
            Console.Write("Введите дату рождения (гггг-мм-дд): ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime birthDate))
            {
                customer.BirthDate = birthDate;
            }
            else
            {
                Console.WriteLine("Некорректный формат даты.");
                return;
            }
            Console.Write("Введите пол покупателя: ");
            customer.Gender = Console.ReadLine();
            Console.Write("Введите email покупателя: ");
            customer.Email = Console.ReadLine();
            Console.Write("Введите страну покупателя: ");
            customer.Country = Console.ReadLine();
            Console.Write("Введите город покупателя: ");
            customer.City = Console.ReadLine();

            context.Customers.Add(customer);
            context.SaveChanges();
            Console.WriteLine("Новый покупатель добавлен.");
        }
    }

    private static void InsertNewCountry()
    {
        using (var context = new NewsletterContext())
        {
            var country = new Country();
            Console.Write("Введите название страны: ");
            country.Name = Console.ReadLine();

            context.Countries.Add(country);
            context.SaveChanges();
            Console.WriteLine("Новая страна добавлена.");
        }
    }

    private static void InsertNewCity()
    {
        using (var context = new NewsletterContext())
        {
            var city = new City();
            Console.Write("Введите название города: ");
            city.Name = Console.ReadLine();
            context.Cities.Add(city);
            context.SaveChanges();
            Console.WriteLine("Новый город добавлен.");
        }
    }

    private static void InsertNewSection()
    {
        using (var context = new NewsletterContext())
        {
            var section = new Section();
            Console.Write("Введите название раздела: ");
            section.Name = Console.ReadLine();

            context.Sections.Add(section);
            context.SaveChanges();
            Console.WriteLine("Новый раздел добавлен.");
        }
    }

    private static void InsertNewPromotion()
    {
        using (var context = new NewsletterContext())
        {
            var promotion = new Promotion();
            Console.Write("Введите название акции: ");
            promotion.Name = Console.ReadLine();
            Console.Write("Введите дату начала акции (гггг-мм-дд): ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime startDate))
            {
                promotion.StartDate = startDate;
            }
            else
            {
                Console.WriteLine("Некорректный формат даты.");
                return;
            }
            Console.Write("Введите дату окончания акции (гггг-мм-дд): ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime endDate))
            {
                promotion.EndDate = endDate;
            }
            else
            {
                Console.WriteLine("Некорректный формат даты.");
                return;
            }
            Console.Write("Введите название страны для акции: ");
            promotion.Country = Console.ReadLine();

            context.Promotions.Add(promotion);
            context.SaveChanges();
            Console.WriteLine("Новая акция добавлена.");
        }
    }

    private static void UpdateCustomer()
    {
        Console.Write("Введите ID покупателя для обновления: ");
        if (!int.TryParse(Console.ReadLine(), out int customerId))
        {
            Console.WriteLine("Введите корректный ID покупателя.");
            return;
        }

        using (var context = new NewsletterContext())
        {
            var customer = context.Customers.Find(customerId);
            if (customer == null)
            {
                Console.WriteLine("Покупатель с указанным ID не найден.");
                return;
            }

            Console.Write("Введите новое имя покупателя: ");
            customer.FullName = Console.ReadLine();
            Console.Write("Введите новую дату рождения (гггг-мм-дд): ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime birthDate))
            {
                customer.BirthDate = birthDate;
            }
            else
            {
                Console.WriteLine("Некорректный формат даты.");
                return;
            }
            Console.Write("Введите новый пол покупателя: ");
            customer.Gender = Console.ReadLine();
            Console.Write("Введите новый email покупателя: ");
            customer.Email = Console.ReadLine();
            Console.Write("Введите новую страну покупателя: ");
            customer.Country = Console.ReadLine();
            Console.Write("Введите новый город покупателя: ");
            customer.City = Console.ReadLine();

            context.SaveChanges();
            Console.WriteLine("Информация о покупателе обновлена.");
        }
    }

    private static void UpdateCountry()
    {
        Console.Write("Введите ID страны для обновления: ");
        if (!int.TryParse(Console.ReadLine(), out int countryId))
        {
            Console.WriteLine("Введите корректный ID страны.");
            return;
        }

        using (var context = new NewsletterContext())
        {
            var country = context.Countries.Find(countryId);
            if (country == null)
            {
                Console.WriteLine("Страна с указанным ID не найдена.");
                return;
            }

            Console.Write("Введите новое название страны: ");
            country.Name = Console.ReadLine();

            context.SaveChanges();
            Console.WriteLine("Информация о стране обновлена.");
        }
    }

    private static void UpdateCity()
    {
        Console.Write("Введите ID города для обновления: ");
        if (!int.TryParse(Console.ReadLine(), out int cityId))
        {
            Console.WriteLine("Введите корректный ID города.");
            return;
        }

        using (var context = new NewsletterContext())
        {
            var city = context.Cities.Find(cityId);
            if (city == null)
            {
                Console.WriteLine("Город с указанным ID не найден.");
                return;
            }

            Console.Write("Введите новое название города: ");
            city.Name = Console.ReadLine();
            Console.Write("Введите новое название страны: ");
            //city.Country = Console.ReadLine();

            context.SaveChanges();
            Console.WriteLine("Информация о городе обновлена.");
        }
    }

    private static void UpdateSection()
    {
        Console.Write("Введите ID раздела для обновления: ");
        if (!int.TryParse(Console.ReadLine(), out int sectionId))
        {
            Console.WriteLine("Введите корректный ID раздела.");
            return;
        }

        using (var context = new NewsletterContext())
        {
            var section = context.Sections.Find(sectionId);
            if (section == null)
            {
                Console.WriteLine("Раздел с указанным ID не найден.");
                return;
            }

            Console.Write("Введите новое название раздела: ");
            section.Name = Console.ReadLine();

            context.SaveChanges();
            Console.WriteLine("Информация о разделе обновлена.");
        }
    }

    private static void UpdatePromotion()
    {
        Console.Write("Введите ID акции для обновления: ");
        if (!int.TryParse(Console.ReadLine(), out int promotionId))
        {
            Console.WriteLine("Введите корректный ID акции.");
            return;
        }

        using (var context = new NewsletterContext())
        {
            var promotion = context.Promotions.Find(promotionId);
            if (promotion == null)
            {
                Console.WriteLine("Акция с указанным ID не найдена.");
                return;
            }

            Console.Write("Введите новое название акции: ");
            promotion.Name = Console.ReadLine();
            Console.Write("Введите новую дату начала акции (гггг-мм-дд): ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime startDate))
            {
                promotion.StartDate = startDate;
            }
            else
            {
                Console.WriteLine("Некорректный формат даты.");
                return;
            }
            Console.Write("Введите новую дату окончания акции (гггг-мм-дд): ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime endDate))
            {
                promotion.EndDate = endDate;
            }
            else
            {
                Console.WriteLine("Некорректный формат даты.");
                return;
            }
            Console.Write("Введите новую страну для акции: ");
            promotion.Country = Console.ReadLine();

            context.SaveChanges();
            Console.WriteLine("Информация об акции обновлена.");
        }
    }

    private static void DeleteCustomer()
    {
        Console.Write("Введите ID покупателя для удаления: ");
        if (!int.TryParse(Console.ReadLine(), out int customerId))
        {
            Console.WriteLine("Введите корректный ID покупателя.");
            return;
        }

        using (var context = new NewsletterContext())
        {
            var customer = context.Customers.Find(customerId);
            if (customer == null)
            {
                Console.WriteLine("Покупатель с указанным ID не найден.");
                return;
            }

            context.Customers.Remove(customer);
            context.SaveChanges();
            Console.WriteLine("Покупатель удален.");
        }
    }

    private static void DeleteCountry()
    {
        Console.Write("Введите ID страны для удаления: ");
        if (!int.TryParse(Console.ReadLine(), out int countryId))
        {
            Console.WriteLine("Введите корректный ID страны.");
            return;
        }

        using (var context = new NewsletterContext())
        {
            var country = context.Countries.Find(countryId);
            if (country == null)
            {
                Console.WriteLine("Страна с указанным ID не найдена.");
                return;
            }

            context.Countries.Remove(country);
            context.SaveChanges();
            Console.WriteLine("Страна удалена.");
        }
    }

    private static void DeleteCity()
    {
        Console.Write("Введите ID города для удаления: ");
        if (!int.TryParse(Console.ReadLine(), out int cityId))
        {
            Console.WriteLine("Введите корректный ID города.");
            return;
        }

        using (var context = new NewsletterContext())
        {
            var city = context.Cities.Find(cityId);
            if (city == null)
            {
                Console.WriteLine("Город с указанным ID не найден.");
                return;
            }

            context.Cities.Remove(city);
            context.SaveChanges();
            Console.WriteLine("Город удален.");
        }
    }

    private static void DeleteSection()
    {
        Console.Write("Введите ID раздела для удаления: ");
        if (!int.TryParse(Console.ReadLine(), out int sectionId))
        {
            Console.WriteLine("Введите корректный ID раздела.");
            return;
        }

        using (var context = new NewsletterContext())
        {
            var section = context.Sections.Find(sectionId);
            if (section == null)
            {
                Console.WriteLine("Раздел с указанным ID не найден.");
                return;
            }

            context.Sections.Remove(section);
            context.SaveChanges();
            Console.WriteLine("Раздел удален.");
        }
    }

    private static void DeletePromotion()
    {
        Console.Write("Введите ID акции для удаления: ");
        if (!int.TryParse(Console.ReadLine(), out int promotionId))
        {
            Console.WriteLine("Введите корректный ID акции.");
            return;
        }

        using (var context = new NewsletterContext())
        {
            var promotion = context.Promotions.Find(promotionId);
            if (promotion == null)
            {
                Console.WriteLine("Акция с указанным ID не найдена.");
                return;
            }

            context.Promotions.Remove(promotion);
            context.SaveChanges();
            Console.WriteLine("Акция удалена.");
        }
    }

    private static void DisplayCitiesByCountry()
    {
        Console.Write("Введите название страны: ");
        var countryName = Console.ReadLine();
        using (var context = new NewsletterContext())
        {
            var cities = context.Cities
                .Where(c => c.Country.Name == countryName)
                .ToList();
            if (cities.Count == 0)
            {
                Console.WriteLine($"Нет городов в стране {countryName}");
                return;
            }
            Console.WriteLine($"Список городов в стране {countryName}:");
            foreach (var city in cities)
            {
                Console.WriteLine(city.Name);
            }
        }
    }

    private static void DisplaySectionsByCustomer()
    {
        Console.Write("Введите ID покупателя: ");
        if (!int.TryParse(Console.ReadLine(), out int customerId))
        {
            Console.WriteLine("Введите корректный ID покупателя.");
            return;
        }

        using (var context = new NewsletterContext())
        {
            var customer = context.Customers.Find(customerId);
            if (customer == null)
            {
                Console.WriteLine("Покупатель с указанным ID не найден.");
                return;
            }

            var sections = context.CustomerInterests
                .Where(ci => ci.CustomerId == customerId)
                .Select(ci => ci.Section)
                .ToList();

            if (sections.Count == 0)
            {
                Console.WriteLine($"Покупатель {customer.FullName} не подписан ни на один раздел.");
                return;
            }

            Console.WriteLine($"Список разделов, на которые подписан {customer.FullName}:");
            foreach (var section in sections)
            {
                Console.WriteLine(section.Name);
            }
        }
    }

    private static void DisplayProductsBySection()
    {
        Console.Write("Введите ID раздела: ");
        if (!int.TryParse(Console.ReadLine(), out int sectionId))
        {
            Console.WriteLine("Введите корректный ID раздела.");
            return;
        }

        using (var context = new NewsletterContext())
        {
            var section = context.Sections.Find(sectionId);
            if (section == null)
            {
                Console.WriteLine("Раздел с указанным ID не найден.");
                return;
            }

            var promotions = context.Promotions
                .Where(p => p.SectionId == sectionId)
                .ToList();

            if (promotions.Count == 0)
            {
                Console.WriteLine($"В разделе {section.Name} нет акционных товаров.");
                return;
            }

            Console.WriteLine($"Список акционных товаров в разделе {section.Name}:");
            foreach (var promotion in promotions)
            {
                Console.WriteLine(promotion.Name);
            }
        }
    }
}
