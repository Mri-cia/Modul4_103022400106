Console.WriteLine("Test 1");

Console.WriteLine();

Console.Write("Nama Paket: ");
string NamaPaket = Console.ReadLine();

var p = new KodePaket();

string KodeP = p.GetKodePaket(NamaPaket);

Console.WriteLine($"Kode Paket: {KodeP}");

