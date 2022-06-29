using Shop;

Console.WriteLine("Inserisci nome prodotto");
string name = Console.ReadLine();
Console.WriteLine("Inserisci descrizione prodotto");
string description = Console.ReadLine();
Console.WriteLine("Inserisci prezzo prodotto");
double price = double.Parse(Console.ReadLine());

Product product = new Product(name, description, price);

product.Print();

Console.WriteLine("Prezzo con iva: " + product.GetTaxedPrice());
Console.WriteLine("Nome esteso: " + product.GetExtendedName());
Console.WriteLine("Codice di otto caratteri: " + product.GetPaddedCode());