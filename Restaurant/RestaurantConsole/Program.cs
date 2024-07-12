using RestaurantLibrary;

/*string filePath = "restaurant_data.json";
Restaurant restaurantInstance = Restaurant.LoadFromJson(filePath);

Menu menu = new Menu();
menu.AddOption("Make a reservation", () => MakeReservation(restaurantInstance, filePath));
menu.AddOption("Cancel a reservation", () => CancelReservation(restaurantInstance, filePath));
menu.AddOption("Place an order", () => PlaceOrder(restaurantInstance, filePath));
menu.AddOption("Generate bill", () => GenerateBill(restaurantInstance, filePath));
menu.AddOption("Exit", () =>
{
    restaurantInstance.SaveToJson(filePath);
    Console.WriteLine("Data saved. Exiting program.");
    Environment.Exit(0);
});

menu.Show();

static void MakeReservation(Restaurant restaurant, string filePath)
{
    var availableTables = restaurant.GetAvailableTables();
    foreach (var table in availableTables)
    {
        Console.WriteLine($"Table Number: {table.TableNumber}");
    }

    Console.WriteLine("\nEnter reservation details:");
    int reservationId = restaurant.Orders.Count() + 1;
    Console.Write("Name: ");
    string name = Console.ReadLine();
    DateTime date = DateTime.Now;
    Console.Write("Table number: ");
    int tableNumber = int.Parse(Console.ReadLine());
    Console.Write("Number of people: ");
    int numberOfPeople = int.Parse(Console.ReadLine());
    
    Reservation reservation = new Reservation(name, reservationId, date, numberOfPeople, tableNumber);

    restaurant.MakeReservation(reservation, restaurant.Get_tables());
    restaurant.SaveToJson(filePath);
    Console.WriteLine($"Your reservation ID: {reservationId}");
    Console.WriteLine("Reservation made successfully!");
    Console.ReadKey();
}

static void CancelReservation(Restaurant restaurant, string filePath)
{
    Console.Write("\nEnter reservation name: ");
    string name = Console.ReadLine();
    Console.Write("\nEnter reservation ID: ");
    int reservationId = int.Parse(Console.ReadLine());
    restaurant.CancelReservation(name, reservationId);
    restaurant.SaveToJson(filePath);
    Console.WriteLine("Reservation canceled successfully!");
    Console.ReadKey();
}

static void PlaceOrder(Restaurant restaurant, string filePath)
{
    Console.WriteLine("\nEnter order details:");
    int orderId = restaurant.Orders.Count() + 1;
    Console.Write("Table number: ");
    int tableNumber = int.Parse(Console.ReadLine());

    Dictionary<string, Dictionary<string, int>> dishes = new Dictionary<string, Dictionary<string, int>>();

    dishes["Appetizers"] = new Dictionary<string, int>()
{
    { "Treasures of the Sea Cream Soup", 2500 },
    { "Age of Pirates Meat Soup", 2200 }
};

    dishes["Main Courses"] = new Dictionary<string, int>()
{
    { "Black Flag Crispy Fish Scales", 3800 },
    { "Pirate Captain Lamb Ribs", 4200 },
    { "Wild Sea Pirate Catch", 4500 }
};

    dishes["Desserts"] = new Dictionary<string, int>()
{
    { "Chocolate Volcano", 2800 },
    { "Pirate's Treasure Caramel Pudding", 2400 }
};

    dishes["Drinks"] = new Dictionary<string, int>()
{
    { "Pirate Pearl Rum Cocktail", 1800 },
    { "Sea Storm Lemonade", 1200 },
    { "Pirates' Blood Red Wine", 3200 }
};

    int index = 1;
    Dictionary<int, string> etelSzamok = new Dictionary<int, string>();
    foreach (var csoport in dishes)
    {
        Console.WriteLine(csoport.Key + ":");
        foreach (var etel in csoport.Value)
        {
            Console.WriteLine($"{index}. {etel.Key}: {etel.Value}");
            etelSzamok[index] = etel.Key;
            index++;
        }
        Console.WriteLine();
    }

    Console.WriteLine("Enter item numbers (separated by comma):");
    string itemsInput = Console.ReadLine();
    List<int> itemNumbers = itemsInput.Split(',').Select(item => int.Parse(item.Trim())).ToList();
    List<string> items = itemNumbers.Select(number => etelSzamok[number]).ToList();

    Order order = new Order(orderId, tableNumber, items);

    restaurant.PlaceOrder(order);
    restaurant.SaveToJson(filePath);
    Console.WriteLine("Order placed successfully!");
    Console.ReadKey();
}

static void GenerateBill(Restaurant restaurant, string filePath)
{
    Console.Write("\nEnter table number to generate bill: ");
    int tableNumber = int.Parse(Console.ReadLine());

    var ordersForTable = restaurant.Orders.Where(order => order.TableNumber == tableNumber);
    double totalAmount = 0;
    Dictionary<string, int> foodPrices = new Dictionary<string, int>()
    {
        { "Treasures of the Sea Cream Soup", 2500 },
        { "Age of Pirates Meat Soup", 2200 },
        { "Black Flag Crispy Fish Scales", 3800 },
        { "Pirate Captain Lamb Ribs", 4200 },
        { "Wild Sea Pirate Catch", 4500 },
        { "Chocolate Volcano", 2800 },
        { "Pirate's Treasure Caramel Pudding", 2400 },
        { "Pirate Pearl Rum Cocktail", 1800 },
        { "Sea Storm Lemonade", 1200 },
        { "Pirates' Blood Red Wine", 3200 }
    };

    foreach (var order in ordersForTable)
    {
        foreach (var item in order.Items)
        {
            if (foodPrices.ContainsKey(item))
            {
                totalAmount += foodPrices[item];
            }
        }
    }
    int billId = restaurant.Bills.Count() + 1;

    Bill bill = new Bill(billId, tableNumber, totalAmount);

    restaurant.GenerateBill(bill);
    restaurant.SaveToJson(filePath);
    Console.WriteLine($"Bill generated successfully!\nTotal amount: {totalAmount} Ft");
    Console.ReadKey();
}
*/

/*string server = "100.124.111.31";*/
/*string server = "192.168.0.36";*/
string server = "46.139.116.158";
int port = 3307;
string database = "restaurant_database";
string username = "RemoteUser";
string password = "remoteUserPassword";

using (var dbHandler = new DataBaseHandler(server, port, database, username, password))
{
    Menu menu = new Menu();
    menu.AddOption("Make a reservation", () => MakeReservation(dbHandler));
    menu.AddOption("Cancel a reservation", () => CancelReservation(dbHandler));
    menu.AddOption("Place an order", () => PlaceOrder(dbHandler));
    menu.AddOption("Generate bill", () => GenerateBill(dbHandler));
    menu.AddOption("Exit", () =>
    {
        Console.WriteLine("Exiting program.");
        Environment.Exit(0);
    });

    menu.Show();
}


static void MakeReservation(DataBaseHandler dbHandler)
{
    var availableTables = dbHandler.GetAvailableTables();
    foreach (var table in availableTables)
    {
        Console.WriteLine($"Table Number: {table.TableNumber}");
    }

    Console.WriteLine("\nEnter reservation details:");
    int reservationId = dbHandler.GetNextReservationId();
    Console.Write("Name: ");
    string name = Console.ReadLine();
    DateTime date = DateTime.Now;
    Console.Write("Table number: ");
    int tableNumber = int.Parse(Console.ReadLine());
    Console.Write("Number of people: ");
    int numberOfPeople = int.Parse(Console.ReadLine());

    dbHandler.InsertReservation(reservationId, date, numberOfPeople, tableNumber, name);
    Console.WriteLine($"Your reservation ID: {reservationId}");
    Console.WriteLine("Reservation made successfully!");
    Console.ReadKey();
}

static void CancelReservation(DataBaseHandler dbHandler)
{
    Console.Write("\nEnter reservation name: ");
    string name = Console.ReadLine();
    Console.Write("\nEnter reservation ID: ");
    int reservationId = int.Parse(Console.ReadLine());
    dbHandler.DeleteReservation(reservationId);
    Console.WriteLine("Reservation canceled successfully!");
    Console.ReadKey();
}

static void PlaceOrder(DataBaseHandler dbHandler)
{
    Console.WriteLine("\nEnter order details:");
    int orderId = dbHandler.GetNextOrderId();
    Console.Write("Table number: ");
    int tableNumber = int.Parse(Console.ReadLine());

    Dictionary<string, Dictionary<string, int>> dishes = new Dictionary<string, Dictionary<string, int>>()
        {
            {"Appetizers", new Dictionary<string, int>
            {
                {"Treasures of the Sea Cream Soup", 2500},
                {"Age of Pirates Meat Soup", 2200}
            }},
            {"Main Courses", new Dictionary<string, int>
            {
                {"Black Flag Crispy Fish Scales", 3800},
                {"Pirate Captain Lamb Ribs", 4200},
                {"Wild Sea Pirate Catch", 4500}
            }},
            {"Desserts", new Dictionary<string, int>
            {
                {"Chocolate Volcano", 2800},
                {"Pirate's Treasure Caramel Pudding", 2400}
            }},
            {"Drinks", new Dictionary<string, int>
            {
                {"Pirate Pearl Rum Cocktail", 1800},
                {"Sea Storm Lemonade", 1200},
                {"Pirates' Blood Red Wine", 3200}
            }}
        };

    int index = 1;
    Dictionary<int, string> etelSzamok = new Dictionary<int, string>();
    foreach (var csoport in dishes)
    {
        Console.WriteLine(csoport.Key + ":");
        foreach (var etel in csoport.Value)
        {
            Console.WriteLine($"{index}. {etel.Key}: {etel.Value}");
            etelSzamok[index] = etel.Key;
            index++;
        }
        Console.WriteLine();
    }

    Console.WriteLine("Enter item numbers (separated by comma):");
    string itemsInput = Console.ReadLine();
    List<int> itemNumbers = itemsInput.Split(',').Select(item => int.Parse(item.Trim())).ToList();
    List<string> items = itemNumbers.Select(number => etelSzamok[number]).ToList();
    string itemsStr = string.Join(",", items);

    dbHandler.InsertOrder(orderId, tableNumber, itemsStr);
    Console.WriteLine("Order placed successfully!");
    Console.ReadKey();
}

static void GenerateBill(DataBaseHandler dbHandler)
{
    Console.Write("\nEnter table number to generate bill: ");
    int tableNumber = int.Parse(Console.ReadLine());

    var ordersForTable = dbHandler.GetOrdersForTable(tableNumber);
    double totalAmount = 0;
    Dictionary<string, int> foodPrices = new Dictionary<string, int>()
        {
            { "Treasures of the Sea Cream Soup", 2500 },
            { "Age of Pirates Meat Soup", 2200 },
            { "Black Flag Crispy Fish Scales", 3800 },
            { "Pirate Captain Lamb Ribs", 4200 },
            { "Wild Sea Pirate Catch", 4500 },
            { "Chocolate Volcano", 2800 },
            { "Pirate's Treasure Caramel Pudding", 2400 },
            { "Pirate Pearl Rum Cocktail", 1800 },
            { "Sea Storm Lemonade", 1200 },
            { "Pirates' Blood Red Wine", 3200 }
        };

    foreach (var order in ordersForTable)
    {
        var items = order.Items.Split(',');
        foreach (var item in items)
        {
            if (foodPrices.ContainsKey(item))
            {
                totalAmount += foodPrices[item];
            }
        }
    }

    int billId = dbHandler.GetNextBillId();

    dbHandler.InsertBill(billId, tableNumber, (decimal)totalAmount);
    Console.WriteLine($"Bill generated successfully!\nTotal amount: {totalAmount} Ft");
    Console.ReadKey();
}

