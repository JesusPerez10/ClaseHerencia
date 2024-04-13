
using clase13042024.ClaseHija;

Nintendo sw = new Nintendo();
sw.EsPortatil = true;
sw.AnioLanzamiento = 2017;
sw.Marca = "Nintedo Switch";

string resultado= sw.MostrarDetallesNintendo();
Console.WriteLine(resultado);


PlayStation ps = new PlayStation();
ps.AnioLanzamiento = 2013;
ps.ModeloControlador = "Dualshock";

string resultado2 = ps.MostrarDetallesPS();
Console.WriteLine(resultado2);   

Xbox Xb = new Xbox();
Xb.Gamepass = true;
Xb.AnioLanzamiento = 2020;
Xb.Marca = "Xbox series X";

string resultado3 = Xb.MostrarDetallesXbox();
Console.WriteLine(resultado3);  




