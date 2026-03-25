Console.WriteLine("Test 1");

Console.WriteLine();

Console.Write("Nama Paket: ");
string NamaPaket = Console.ReadLine();

var p = new KodePaket();

string KodeP = p.GetKodePaket(NamaPaket);

Console.WriteLine($"Kode Paket: {KodeP}");

Console.WriteLine();

Console.WriteLine("Test 2");

var mk = new MesinKopi();

mk.UbahStatusMesin(StatusMesinKopi.STANDBY);
mk.UbahStatusMesin(StatusMesinKopi.BREWING);
mk.UbahStatusMesin(StatusMesinKopi.STANDBY);
mk.UbahStatusMesin(StatusMesinKopi.MAINTENANCE);
mk.UbahStatusMesin(StatusMesinKopi.STANDBY);
mk.UbahStatusMesin(StatusMesinKopi.OFF);
mk.UbahStatusMesin(StatusMesinKopi.OFF);


