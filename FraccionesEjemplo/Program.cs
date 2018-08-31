using System;


namespace FraccionesEjemplo
{
    class Program
    {
        static void Main()
        {
            Fraccion f1 = new Fraccion(1, 2);
            Fraccion f2 = new Fraccion(3, 4);
            Fraccion f3 = f1 - f2;
            Console.WriteLine(" {0} - {1} = {2} ", f1, f2, f3);
            bool except=false;
            do
            {
                try
                {
                    Console.WriteLine("Ingresa el numerador: ");
                    int numerador = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa denominador");
                    int denominador = int.Parse(Console.ReadLine());
                    if (denominador == 0)
                    {
                        string error = "El denominador no puede ser cero ";
                        throw new ApplicationException(error);
                    }

                    f2 = new Fraccion(numerador, denominador);
                   
                    Console.WriteLine(f2);
                    except = false;
                }
                catch (ApplicationException error)
                {
                    Console.WriteLine(error.Message);
                    except = true;
                }

                catch (FormatException error)
                {
                    Console.WriteLine("error: " + error.Message);
                    except = true;
                }
                catch
                {
                    Console.WriteLine("Ups, parece que hubo un problema");
                    except = true;
                }

            } while (except); // exept == true

            //Multiplicación de fracciones
            do
            {
                try
                {
                    Console.WriteLine("Ingresa el numerador de f1: ");
                    int numerador = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa denominador de f1: ");
                    int denominador = int.Parse(Console.ReadLine());
                    if (denominador == 0)
                    {
                        string error = "El denominador no puede ser cero ";
                        throw new ApplicationException(error);
                    }

                    f1 = new Fraccion(numerador, denominador);
                    except = false;
                }
                catch (ApplicationException error)
                {
                    Console.WriteLine(error.Message);
                    except = true;
                }

                catch (FormatException error)
                {
                    Console.WriteLine("error: " + error.Message);
                    except = true;
                }
                catch
                {
                    Console.WriteLine("Ups, parece que hubo un problema");
                    except = true;
                }

            } while (except); // exept == true

            do
            {
                try
                {
                    Console.WriteLine("Ingresa el numerador de f2: ");
                    int numerador = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa denominador de f2: ");
                    int denominador = int.Parse(Console.ReadLine());
                    if (denominador == 0)
                    {
                        string error = "El denominador no puede ser cero ";
                        throw new ApplicationException(error);
                    }

                    f2 = new Fraccion(numerador, denominador);
                    except = false;
                }
                catch (ApplicationException error)
                {
                    Console.WriteLine(error.Message);
                    except = true;
                }

                catch (FormatException error)
                {
                    Console.WriteLine("error: " + error.Message);
                    except = true;
                }
                catch
                {
                    Console.WriteLine("Ups, parece que hubo un problema");
                    except = true;
                }

            } while (except); // exept == true

            f3 = f1 * f2;
            Console.WriteLine("La multiplicación de {0} * {1} es {2}",f1,f2,f3);

            //División de fracciones
            int a = 0;
            do
            {
                try
                {
                    Console.WriteLine("Ingresa el numerador de f1: ");
                    int numerador = int.Parse(Console.ReadLine());
                    if(numerador == 0)
                    {
                        a = 1;
                    }
                    else
                    {
                        a = 0;
                    }
                    Console.WriteLine("Ingresa denominador de f1: ");
                    int denominador = int.Parse(Console.ReadLine());
                    if (denominador == 0)
                    {
                        string error = "El denominador no puede ser cero ";
                        throw new ApplicationException(error);
                    }

                    f1 = new Fraccion(numerador, denominador);
                    except = false;
                }
                catch (ApplicationException error)
                {
                    Console.WriteLine(error.Message);
                    except = true;
                }

                catch (FormatException error)
                {
                    Console.WriteLine("error: " + error.Message);
                    except = true;
                }
                catch
                {
                    Console.WriteLine("Ups, parece que hubo un problema");
                    except = true;
                }

            } while (except); // exept == true

            do
            {
                try
                {
                    Console.WriteLine("Ingresa el numerador de f2: ");
                    int numerador = int.Parse(Console.ReadLine());
                    if (numerador == 0)
                    {
                        string error = "El numerador no puede ser cero ";
                        throw new ApplicationException(error);
                    }
                    Console.WriteLine("Ingresa denominador de f2: ");
                    int denominador = int.Parse(Console.ReadLine());
                    if (denominador == 0)
                    {
                        if (a == 0)
                        {
                            string error = "El denominador no puede ser cero ";
                            throw new ApplicationException(error);
                        }
                    }

                    f2 = new Fraccion(numerador, denominador);
                    except = false;
                }
                catch (ApplicationException error)
                {
                    Console.WriteLine(error.Message);
                    except = true;
                }

                catch (FormatException error)
                {
                    Console.WriteLine("error: " + error.Message);
                    except = true;
                }
                catch
                {
                    Console.WriteLine("Ups, parece que hubo un problema");
                    except = true;
                }

            } while (except); // exept == true

            f3 = f1 / f2;
            Console.WriteLine("La división de {0} / {1} es {2}",f1,f2,f3);




        }
    }
}
