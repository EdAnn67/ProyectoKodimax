using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MovieTheater
{
    class Program
    {
        private static List<User> People = new List<User>();
        private static List<User> Employee = new List<User>();
        private static List<Movie> Movies = new List<Movie>();
        private static List<Snacks> Snack = new List<Snacks>();

        static int Lev;
        static int Continue;


        static void Main(string[] args)
        {
            Continue = 0;
            bool exists;
            int exit = 1;
            User BT = new User();
            Movie MV = new Movie();
            Snacks SN = new Snacks();


            BT.Name = "Eduardo Andrés ";
            BT.LastName = "Canales Fernández";
            BT.Mail = "edann67@gmail.com";
            BT.Phone = "7894-5612";
            BT.Gender = "Masculino";
            BT.Birth = "06/07/2001";
            BT.UserName = "Edann67";
            BT.PassWord = "@dminM@x";
            BT.Level = 3;
            People.Add(BT);

            MV.Name = "Sí señor";
            MV.idmovie = 1;
            MV.duration = "2:00 h";
            MV.Type = "Comedia";
            Movies.Add(MV);

            SN.Name = "Palomitas con dulce";
            SN.IdSnack = 1;
            SN.price = 3.50;
            SN.Type = "Palomitas";
            Snack.Add(SN);

            string user, password;
            int Option;
            do
            {
                Console.Clear();
                Console.WriteLine("Bienvenido a KODIMAX");
                Console.WriteLine("Ingrese sus datos: ");
                Console.Write("Usuario: ");
                user = Console.ReadLine();
                Console.Write("Contraseña: ");
                password = Console.ReadLine();

                exists = Validate(user, password);

                if (exists)
                {
                    Continue = 0;
                    while (Continue == 0)
                    {
                    Menu();
                    }
                }
                else
                {
                    Console.WriteLine("El usuario que ingresó no existe, desea registrarlo?");
                    Console.WriteLine("1 - SI             2 - NO");
                    do
                    {
                        Console.Write("Opcion: ");
                        Option = int.Parse(Console.ReadLine());
                    } while (Option < 1 || Option > 2);

                    if(Option == 1)
                    {
                        newUser();
                    }
                }
                
            } while (exit != 0);
        }

        public static bool Validate(string username, string passWord)
        {
            int a = 0;
            bool b;
            foreach(var y in People)
            {
                if(username == y.UserName && passWord == y.PassWord)
                {
                    a = 1;
                    Lev = y.Level;
                    break;
                }
            }
            if(a == 0)
            {
                b = false;
            }
            else
            {
                b = true;
            }
            return b;
        }

        public static void LogOut()
        {
            Program.Continue = 1;
        }

        public static void Menu()
        {
            Console.Clear();
            int Op;
            if(Lev == 1)
            {
                Console.WriteLine("---------------MENÚ---------------");
                Console.WriteLine("1 - Ver Cartelera");
                Console.WriteLine("2 - Ver tienda de Golosinas");
                Console.WriteLine("3 - Comprar Boletos");
                Console.WriteLine("4 - Comprar Golosinas");
                Console.WriteLine("5 - Salir");
                do
                {
                    Console.Write("Opcion: ");
                    Op = int.Parse(Console.ReadLine());
                } while (Op < 1 || Op > 5);
                if(Op == 1)
                {
                    foreach(var y in Movies)
                    {
                        Console.WriteLine("Id Película: " + y.IdMovie);
                        Console.WriteLine("Nombre: " + y.Name);
                        Console.WriteLine("Duracion: " + y.Duration);
                        Console.WriteLine("Tipo: " + y.Type + "\n");
                    }
                    Console.Write("Presione una tecla para continuar: ");
                    Console.ReadKey();
                }
                else if(Op == 2)
                {
                    foreach(var y in Snack)
                    {
                        Console.WriteLine("Id Golosina: " + y.IdSnack);
                        Console.WriteLine("Nombre: " + y.Name);
                        Console.WriteLine("Precio: " + y.Price);
                        Console.WriteLine("Tipo: " + y.Type + "\n");
                    }
                    Console.Write("Presione una tecla para continuar: ");
                    Console.ReadKey();
                }

                else if(Op == 3)
                {
                    foreach(var y in Movies)
                    {
                        Console.WriteLine("Id Película: " + y.IdMovie);
                        Console.WriteLine("Nombre: " + y.Name);
                        Console.WriteLine("Duracion: " + y.Duration);
                        Console.WriteLine("Tipo: " + y.Type + "\n\n");
                    }
                    Console.WriteLine("Salas: ");
                    Console.WriteLine("1 - Estandar     $3.55");
                    Console.WriteLine("2 - Premium      $4.75");
                    Console.WriteLine("3 - V.I.P        $6.50");
                    int Room;
                    int Quantity;
                    double subtotal;
                    double total;
                    double recieved;
                    Movie Mov = new Movie();
                    Console.WriteLine("");
                    Console.Write("Ingrese el id de la película que desea ver: ");
                    Op = int.Parse(Console.ReadLine());
                    int x = 0;
                    foreach(var y in Movies)
                    {
                        if(y.IdMovie == Op)
                        {
                            break;
                        }
                        x++;
                    }
                    Mov = Movies[x];
                    do
                    {
                        Console.Write("Ingrese el tipo de sala que desea: ");
                        Room = int.Parse(Console.ReadLine());
                    } while (Room < 1 || Room > 3);
                    do
                    {
                        Console.Write("Ingrese la cantidad de boletos que desea: ");
                        Quantity = int.Parse(Console.ReadLine());
                    } while (Quantity < 0);
                    
                    if(Room == 1)
                    {
                        subtotal = 3.55 * Quantity;
                    }
                    else if(Room == 2)
                    {
                        subtotal = 4.75 * Quantity;
                    }
                    else
                    {
                        subtotal = 6.5 * Quantity;
                    }
                    int a = 0;
                    foreach(var y in Employee)
                    {
                        if(y.Level == 2)
                        {
                            a++;
                        }
                    }
                    x =  0;
                    Random z = new Random(a);
                    int c = z.Next();
                    
                    Console.WriteLine("KODIMAX");
                    //Console.WriteLine("Atendido por: " + People[c].Name + " " + People[c].LastName);
                    Console.WriteLine("Hora: " + DateTime.Now.ToString("hh:mm:ss"));
                    Console.WriteLine("Fecha: " + DateTime.Now.ToLongDateString());
                    Console.WriteLine("Sub-Total: " + subtotal);
                    Console.WriteLine("Impuesto: " + (subtotal * 0.3533));
                    total = subtotal * 1.3533;
                    Console.WriteLine("Total: $" + total);



                    do
                    {
                        Console.WriteLine("Ingrese la cantidad a pagar: ");
                        recieved = double.Parse(Console.ReadLine());
                    } while (recieved < total);

                    if(recieved == total)
                    {
                        Console.WriteLine("Cobro exacto, gracias por comprar en KODIMAX");
                    }
                    else
                    {
                        Console.WriteLine("Su cambio es: " + (recieved - total) + ", gracias por comprar en KODIMAX");
                    }
                    Console.ReadKey();

                }
                else if(Op == 4)
                {
                    foreach (var y in Snack)
                    {
                        Console.WriteLine("Id Golosina: " + y.IdSnack);
                        Console.WriteLine("Nombre: " + y.Name);
                        Console.WriteLine("Precio: " + y.Price);
                        Console.WriteLine("Tipo: " + y.Type + "\n\n");
                    }
                    int Quantity;
                    double subtotal;
                    double total;
                    double recieved;
                    Snacks SNK = new Snacks();
                    Console.WriteLine("");
                    Console.Write("Ingrese el id de la golosina que desea consumir: ");
                    Op = int.Parse(Console.ReadLine());
                    int x = 0;
                    foreach (var y in Snack)
                    {
                        if (y.IdSnack == Op)
                        {
                            break;
                        }
                        x++;
                    }
                    SNK = Snack[x];
                    
                    do
                    {
                        Console.Write("Ingrese la cantidad de productos que desea: ");
                        Quantity = int.Parse(Console.ReadLine());
                    } while (Quantity < 1);
                        subtotal = Snack[x].Price * Quantity;
                    
                    int a = 0;
                    foreach (var y in Employee)
                    {
                        if (y.Level == 2)
                        {
                            a++;
                        }
                    }
                    x = 0;
                    int b = 0;
                    Random z = new Random(a);
                    int c = z.Next();
                    foreach (var y in People)
                    {

                        if (y.Level == 2 && c == b)
                        {
                            b++;
                        }
                        x++;
                    }
                    Console.WriteLine("KODIMAX");
                    //Console.WriteLine("Atendido por: " + Employee[x].Name + " " + Employee[x].LastName);
                    Console.WriteLine("Hora: " + DateTime.Now.ToString("hh:mm:ss"));
                    Console.WriteLine("Fecha: " + DateTime.Now.ToLongDateString());
                    Console.WriteLine("Sub-Total: " + subtotal);
                    Console.WriteLine("Impuesto: " + (subtotal * 0.0453));
                    total = subtotal * 1.0453;
                    Console.WriteLine("Total: " + total);



                    do
                    {
                        Console.WriteLine("Ingrese la cantidad a pagar: ");
                        recieved = double.Parse(Console.ReadLine());
                    } while (recieved < total);

                    if (recieved == total)
                    {
                        Console.WriteLine("Cobro exacto, gracias por comprar en KODIMAX");
                    }
                    else
                    {
                        Console.WriteLine("Su cambio es: " + (recieved - total) + ", gracias por comprar en KODIMAX");
                    }
                    Console.ReadKey();
                }
            }







            else if(Lev == 2)
            {
                Console.WriteLine("---------------MENÚ---------------");
                Console.WriteLine("1 - Modificar Cartelera");
                Console.WriteLine("2 - Modificar tienda de Golosinas");
                Console.WriteLine("3 - Salir");
                do
                {
                    Console.Write("Opcion: ");
                    Op = int.Parse(Console.ReadLine());
                } while (Op < 1 || Op > 3);
                if (Op == 1)
                {
                    ModifyMovie();
                }
                else if (Op == 2)
                {
                    ModifySnacks();
                }
                else
                {
                    LogOut();
                }

            }








            else
            {
                Console.WriteLine("---------------MENÚ---------------");
                Console.WriteLine("1 - Modificar Lista de empleados");
                Console.WriteLine("2 - Eliminar Usuarios");
                Console.WriteLine("3 - Modificar Cartelera");
                Console.WriteLine("4 - Modificar tienda de Golosinas");
                Console.WriteLine("5 - Generar reporte");
                Console.WriteLine("6 - Salir");
                do
                {
                    Console.Write("Opcion: ");
                    Op = int.Parse(Console.ReadLine());
                } while (Op < 1 || Op > 6);
                if (Op == 1)
                {
                    ModifyUser();
                }
                else if (Op == 2)
                {
                    EliminateUser();
                }
                else if (Op == 3)
                {
                    ModifyMovie();
                }
                else if (Op == 4)
                {
                    ModifySnacks();
                }
                else if(Op == 5)
                {
                    string JSON;
                    Console.Clear();
                    Console.WriteLine("Generar Reportes\n");
                    Console.WriteLine(" U - Reporte de Usuarios\n");
                    Console.WriteLine(" C - Reporte de Peliculas\n");
                    Console.WriteLine(" G - Reporte de Golosinas\n");
                    Console.Write("  Ingrese opcion deseada: ");
                    string opt = Console.ReadLine();
                    if(opt == "U")
                    {
                        JSON = JsonConvert.SerializeObject(People.ToArray());
                        System.IO.File.WriteAllText(@"C:\JSON\Usuario.JSON", JSON);
                    }
                    else if (opt == "C")
                    {
                        JSON = JsonConvert.SerializeObject(Movies.ToArray());
                        System.IO.File.WriteAllText(@"C:\JSON\Peliculas.JSON", JSON);
                    }
                    else if( opt == "G")
                    {
                        JSON = JsonConvert.SerializeObject(Snack.ToArray());
                        System.IO.File.WriteAllText(@"C:\JSON\Golosinas.JSON", JSON);
                    }



                }
                else
                {
                    LogOut();
                }
            }
        }
        public static void newUser()
        {
            string id;
            User BM = new User();
            Console.WriteLine("Ingrese los datos que se le piden a continuacion: ");
            Console.Write("Nombre: ");
            BM.Name = Console.ReadLine();
            Console.Write("Apellido: ");
            BM.LastName = Console.ReadLine();
            Console.Write("Correo: ");
            BM.Mail = Console.ReadLine();
            Console.Write("Telefono: ");
            BM.Phone = Console.ReadLine();
            Console.Write("Sexo: ");
            BM.Gender = Console.ReadLine();
            Console.Write("Fecha de nacimiento: ");
            BM.Birth = Console.ReadLine();
            Console.Write("Usuario: ");
            BM.UserName = Console.ReadLine();
            Console.Write("Password: ");
            BM.PassWord = Console.ReadLine();
            if (Lev != 2)
            {
                Console.Write("Id empresa: ");
                id = Console.ReadLine();
                if(id == "idEmpresa1")
                {
                    BM.Level = 2;
                    Console.WriteLine("Se ha registrado como empleado");
                    Employee.Add(BM);
                }
                else
                {
                    BM.Level = 1;
                    Console.WriteLine("Se ha registrado como usuario");
                }
            }
            else
            {
                BM.Level = 2;
                Console.WriteLine("Se ha registrado como empleado");
                Employee.Add(BM);
            }
            
            People.Add(BM);
            Lev = 0;
        }

        public static void ModifyMovie()
        {
            Movie Mov = new Movie();
            int Opt;
            Console.Clear();
            Console.WriteLine("Seleccione la opcion que desea ejecutar: ");
            Console.WriteLine("1 - Agregar Películas");
            Console.WriteLine("2 - Eliminar Películas");
            Console.WriteLine("3 - Modificar Sala de Exhibicion");
            do
            {
                Console.Write("Opcion: ");
                Opt = int.Parse(Console.ReadLine());
            } while (Opt < 1 || Opt > 3);

            if(Opt == 1)
            {
                Console.Write("Ingrese el id de la prelícula: ");
                Mov.IdMovie = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el nombre de la prelícula: ");
                Mov.Name = Console.ReadLine();
                Console.Write("Ingrese la duracion de la película: ");
                Mov.Duration = Console.ReadLine();
                Console.Write("Ingrese el tipo de película: ");
                Mov.Type = Console.ReadLine();
                Movies.Add(Mov);
            }
            else if(Opt == 2)
            {
                foreach (var y in Movies)
                {
                    Console.WriteLine("Id Película: " + y.IdMovie);
                    Console.WriteLine("Nombre: " + y.Name);
                    Console.WriteLine("Duracion: " + y.Duration);
                    Console.WriteLine("Tipo: " + y.Type + "\n");
                }
                Console.Write("Presione una tecla para continuar: ");
                Console.ReadKey();

                Console.Write("Ingrese el id del producto que desea Eliminar: ");
                int Op = int.Parse(Console.ReadLine());
                int x = 0;
                foreach (var y in Movies)
                {
                    if (y.IdMovie == Op)
                    {
                        break;
                    }
                    x++;
                }
                Movies.RemoveAt(x);
            }
            else
            {
            }

        }

        public static void ModifySnacks()
        {
            Snacks Snk = new Snacks();
            int Opt;
            Console.Clear();
            Console.WriteLine("Seleccione la opcion que desea ejecutar: ");
            Console.WriteLine("1 - Agregar Productos");
            Console.WriteLine("2 - Eliminar Productos");
            Console.WriteLine("3 - Modificar tipo de Producto");
            do
            {
                Console.Write("Opcion: ");
                Opt = int.Parse(Console.ReadLine());
            } while (Opt < 1 || Opt > 3);

            if (Opt == 1)
            {
                Console.Write("Ingrese el id del Producto: ");
                Snk.IdSnack = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el nombre del Producto: ");
                Snk.Name = Console.ReadLine();
                Console.Write("Ingrese el precio del Producto: ");
                Snk.Price = double.Parse(Console.ReadLine());
                Console.Write("Ingrese el tipo de Producto: ");
                Snk.Type = Console.ReadLine();
                Snack.Add(Snk);
            }
            else if (Opt == 2)
            {
                foreach (var y in Snack)
                {
                    Console.WriteLine("Id Producto: " + y.IdSnack);
                    Console.WriteLine("Nombre: " + y.Name);
                    Console.WriteLine("Precio: " + y.Price);
                    Console.WriteLine("Tipo: " + y.Type + "\n");
                }
                Console.Write("Presione una tecla para continuar: ");
                Console.ReadKey();

                Console.Write("Ingrese el id del producto que desea Eliminar: ");
                int Op = int.Parse(Console.ReadLine());
                int x = 0;
                foreach (var y in Movies)
                {
                    if (y.IdMovie == Op)
                    {
                        break;
                    }
                    x++;
                }
                Movies.RemoveAt(x);
            }
            else
            {

            }

        }

        public static void ModifyUser()
        {
            User Employee = new User();
            int Opt;
            Console.Clear();
            Console.WriteLine("Seleccione la opcion que desea ejecutar: ");
            Console.WriteLine("1 - Agregar Empleado");
            Console.WriteLine("2 - Eliminar Empleado");
            do
            {
                Console.Write("Opcion: ");
                Opt = int.Parse(Console.ReadLine());
            } while (Opt < 1 || Opt > 3);

            if (Opt == 1)
            {
                Lev = 2;
                newUser();
            }
            else if (Opt == 2)
            {
                foreach (var y in People)
                {
                    if(y.Level == 2)
                    {
                        Console.WriteLine("Nombre: " + y.Name);
                        Console.WriteLine("Apellido: " + y.LastName);
                        Console.WriteLine("Usuario: " + y.UserName);
                        Console.WriteLine("Contraseña: " + y.PassWord + "\n");

                    }
                }
                Console.Write("Presione una tecla para continuar: \n");
                Console.ReadKey();

                Console.Write("Ingrese el Username del empleado que desea Eliminar: ");
                string Op = Console.ReadLine();
                int x = 0;
                foreach (var y in People)
                {
                    if (y.UserName == Op)
                    {
                        break;
                    }
                    x++;
                }
                People.RemoveAt(x);
                x = 0;
            }
        }

        public static void EliminateUser()
        {
            foreach (var y in People)
            {
                if(y.Level == 1)
                {
                Console.WriteLine("Nombre: " + y.Name);
                Console.WriteLine("Apellido: " + y.LastName);
                Console.WriteLine("Usuario: " + y.UserName);
                Console.WriteLine("Contraseña: " + y.PassWord + "\n");
                }
            }
            Console.Write("Presione una tecla para continuar: ");
            Console.ReadKey();

            Console.Write("Ingrese el Username del usuario que desea Eliminar: ");
            string Op = Console.ReadLine();
            int x = 0;
            foreach (var y in People)
            {
                if (y.UserName == Op)
                {
                    break;
                }
                x++;
            }
            People.RemoveAt(x);
        }
    }
}