//
/*
using Departamentos;

List<depto> ItsDeptos = new List<depto>()
{
    new depto("Boaco",185013),
    new depto("Carazo",197139),
    new depto("Chinandega",439906),
    new depto("Chontales",190863),
    new depto("Caribe Norte",530586),
    new depto("Costa Caribe Sur",414543),
    new depto("Esteli",229866),
    new depto("Granada",214317),
    new depto("Jinotega",475630),
    new depto("Leon",421050),
    new depto("Madriz",174744),
    new depto("Managua",1546939),
    new depto("Masaya",391903),
    new depto("Matagalpa",593503),
    new depto("Nueva Segovia",271581),
    new depto("Rio San Juan",135446),
    new depto("Rivas",182645)

};

depto minDepto = ItsDeptos.OrderBy(d => d.Population).First();
depto maxDepto = ItsDeptos.OrderBy(d => d.Population).Last();

var DeptOrdenado = ItsDeptos.OrderBy(d => d.Population);

foreach (var item in DeptOrdenado)
{
    Console.WriteLine($"{item.Name, -20}==> {item.Population,10:NO}");


    Console.WriteLine($"Depto con menor poblacion: {minDepto.Name}");
    Console.WriteLine($"Depto con mayor poblacion: {maxDepto.Name}");

    int total = ItsDeptos.Select(d => d.Population).Sum();
    Console.WriteLine($"Poblacion General: {total:NO}");

}*/