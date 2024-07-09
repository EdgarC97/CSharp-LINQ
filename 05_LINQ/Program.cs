//HDELEON

//Nueva lista
// var beers = new List<Beer>()
// {
//     new Beer(){ Name = "Aguila", Brand = "Bavaria", Alcohol = 7.5m },
//     new Beer(){ Name = "Pilsen", Brand = "Bavaria", Alcohol = 8.5m },
//     new Beer(){ Name = "JOACO", Brand = "Andina", Alcohol = 2.5m },
//     new Beer(){ Name = "Club", Brand = "Modelo", Alcohol = 4.5m },
//     new Beer(){ Name = "Corona", Brand = "Mexico", Alcohol = 10.5m }
// };

// var brands = new List<Brand>()
// {
//     new Brand(){ Name = "Aguila", Country = "Colombia" },
//     new Brand(){ Name = "Pilsen", Country = "Colombia" },
//     new Brand(){ Name = "Andina", Country = "Alemania" },
//     new Brand(){ Name = "Club", Country = "Suiza" },
//     new Brand(){ Name = "Corona", Country = "Mexico" }
// };

//QUERY EXPRESSIONS

//SELECT
// var beers2 = from b in beers
//             select new {b.Name, b.Brand};


// foreach (var b in beers2)
// {
//     Console.WriteLine(b.Brand);
// }

//WHERE
// var beers3 = from b in beers
//              where b.Brand == "Bavaria" || b.Alcohol > 3
//              select new {b.Name, b.Brand};


// foreach (var b in beers3)
// {
//     Console.WriteLine(b.Name);
// }

// EXPRESSIONS 

// var beers4 = beers.Where(b => b.Brand == "Bavaria" || b.Alcohol >10)
//                     .Select(b => new
//                     {
//                         b.Name,
//                         b.Brand
//                     }    
//                     );

// foreach (var b in beers4)
// {
//     Console.WriteLine(b.Name);
// }

//ORDER BY
// var beers4 = from b in beers
//              where b.Brand == "Bavaria" || b.Alcohol > 3
//              orderby b.Name descending
//              select new {b.Name, b.Brand};


// foreach (var b in beers4)
// {
//     Console.WriteLine(b.Name);
// }

//GROUP BY
// var beers5 = from b in beers
//              group b by b.Brand into groupBeers //into like as
//              select new 
//              {
//                 Brand = groupBeers.Key,
//                 Count = groupBeers.Count()
//              };


// foreach (var b in beers5)
// {
//     Console.WriteLine(b.Brand + " " +b.Count);
// }

//JOIN
// var beers6 = from b in beers
//              join bra in brands on b.Brand equals bra.Name
//              select new 
//              {
//                 Name = b.Name,
//                 Brand = b.Brand,
//                 Country = bra.Country
//              };


// foreach (var b in beers6)
// {
//     Console.WriteLine($"El nombre de la cerveza es: {b.Name}, La marca es {b.Brand} y el pais es: {b.Country}" );
// }

// //Clase principal
// public class Beer 
// {
//     public string? Name {get; set;}
//     public string? Brand {get; set;}
//     public decimal Alcohol {get; set;}
// }

// public class Brand 
// {
//     public string? Name {get; set;}
//     public string? Country {get; set;}
// }

//*****************************************************************************************************
//PILDORAS INFORMATICAS

// int [] numericValues = new int [] {1,2,3,4,5,6,7,8,9,10};

//ORDINAL WAY
// List<int> parNumbers = new List<int>();

// foreach (int i in numericValues)
// {
//     if(i % 2 == 0 )
//     {
//         parNumbers.Add(i);
//     }
// }

//LINQ WAY

// IEnumerable<int> parNumbers = from number in numericValues where number % 2 == 0 select number;

// foreach (int i in parNumbers)
// {
//     Console.WriteLine(i);
// }

//WITH OBJECTS

//Definicion de namespaces
// namespace LINQ_Work
// {
//     class Program
//     {
//         // Punto de entrada principal del programa
//         static void Main(string[] args)
//         {
//             // Crear una instancia de la clase CompanyEmployeeControl
//             CompanyEmployeeControl ce = new CompanyEmployeeControl();
//             // Llamar al método  para imprimir empleados con salario >= 5000000
//             // ce.GetSalaryAbove();
//             //Llamar al metodo de ordenamiento de empleados
//             // ce.GetEmployeeNameAsc();
//             //Llamar al metodo para obtener empleados de Google
//             Console.Write("Por favor ingresa el id de la empresa que deseas buscas --> ");
//             int entryId = Convert.ToInt32(Console.ReadLine());
//             ce.GetCompanyEmployees(entryId);
//         }
//     }

//     public class CompanyEmployeeControl
//     {
//         // Lista de compañías
//         public List<Company> companyList;
//         // Lista de empleados
//         public List<Employee> employeeList;

//         // Constructor de la clase
//         public CompanyEmployeeControl()
//         {
//             // Inicializar la lista de compañías
//             companyList = new List<Company>();
//             // Inicializar la lista de empleados
//             employeeList = new List<Employee>();

//             // Agregar compañías a la lista de compañías
//             companyList.Add(new Company { Id = 1, Name = "Google" });
//             companyList.Add(new Company { Id = 2, Name = "Microsoft" });

//             // Agregar empleados a la lista de empleados
//             employeeList.Add(new Employee { Id = 1, Name = "PEPE", Charge = "Barrendero", CompanyId = 1, Salary = 5000000 });
//             employeeList.Add(new Employee { Id = 2, Name = "JOACO", Charge = "Celador", CompanyId = 1, Salary = 8000000 });
//             employeeList.Add(new Employee { Id = 3, Name = "GUILLO", Charge = "Mensajero", CompanyId = 1, Salary = 3000000 });
//             employeeList.Add(new Employee { Id = 4, Name = "MELANY", Charge = "Recepcionista", CompanyId = 2, Salary = 6000000 });
//             employeeList.Add(new Employee { Id = 5, Name = "JUANELVER", Charge = "Barrendero", CompanyId = 2, Salary = 4000000 });
//             employeeList.Add(new Employee { Id = 6, Name = "SHAKIRA", Charge = "Recepcionista", CompanyId = 2, Salary = 5000000 });
//         }

//         // Método para obtener empleados con salario >= 5000000 y mostrar su información
//         public void GetSalaryAbove()
//         {
//             // Consultar empleados con salario >= 5000000 usando LINQ
//             IEnumerable<Employee> salarys = from employee in employeeList
//                                             where employee.Salary >= 5000000
//                                             select employee;

//             // Iterar sobre los empleados que cumplen la condición y mostrar su información
//             foreach (Employee i in salarys)
//             {
//                 i.GetEmployeeId();
//             }
//         }

//         //Metodo para ordenar empleados por orden alfabetico
//         public void GetEmployeeNameAsc()
//         {
//             //Consultar empleados usando LINQ
//             IEnumerable<Employee> ascName = from employee in employeeList
//                                             orderby employee.Name descending
//                                             select employee;
//             //Iterar sobre los empleados ordenados
//             foreach (Employee i in ascName)
//             {
//                 i.GetEmployeeId();
//             }
//         }

//         //Metodo que devuelve los empleados de una empresa
//         public void GetCompanyEmployees(int Id)
//         {
//             //Consultar empleados usando LINQ
//             IEnumerable<Employee> googleEmployee = from employee in employeeList
//                                             join company in companyList on employee.CompanyId equals company.Id
//                                             // where company.Name == "Google"
//                                             where company.Id == Id
//                                             select employee;
//             //Iterar sobre los empleados ordenados
//             foreach (Employee i in googleEmployee)
//             {
//                 i.GetEmployeeId();
//             }
//         }
//     }

//     public class Company
//     {
//         // Propiedad Id de la compañía
//         public int Id { get; set; }
//         // Propiedad Name de la compañía
//         public string? Name { get; set; }

//         // Método para mostrar la información de la compañía
//         public void GetCompanyData()
//         {
//             Console.WriteLine($"Company -> {Name} -- Id-> {Id}");
//         }
//     }

//     public class Employee
//     {
//         // Propiedad Id del empleado
//         public int Id { get; set; }
//         // Propiedad Name del empleado
//         public string? Name { get; set; }
//         // Propiedad Charge del empleado
//         public string? Charge { get; set; }
//         // Propiedad Salary del empleado
//         public double Salary { get; set; }
//         // Propiedad CompanyId (clave foránea) del empleado
//         public int CompanyId { get; set; }

//         // Método para mostrar la información del empleado
//         public void GetEmployeeId()
//         {
//             Console.WriteLine($"Empleado -> {Name} con ID -> {Id} Cargo -> {Charge} Salario -> {Salary} Id de la empresa -> {CompanyId}");
//         }
//     }
// }

