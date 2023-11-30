using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RSA rsa = new RSA();
            json json = new json();
            int eleccion;
            bool op1eleccion = false;
            int op1 = 0;

            int eleccionReclutador;

            try
            {
                Console.WriteLine("-----------------------------------------------------------------------------\n");
                Console.WriteLine("---------------LABORATORIO 5: FALSAS IDENTIDADES DE TALENT HUB---------------\n");
                Console.WriteLine("-----------------------------------------------------------------------------\n");
                Console.WriteLine("Presione el número 1 para cargar la información en el árbol mediante el archivo json predeterminado.");

                while (op1 != 1)
                {
                    op1 = Convert.ToInt32(Console.ReadLine());

                    if (op1 == 1)
                    {
                        json.leerArchivo();
                        op1eleccion = true;
                    }
                    else
                    {
                        Console.WriteLine("Por favor ingrese un número válido (1)");
                    }
                }

                if (op1eleccion == true)
                {
                    Console.WriteLine("----------------BIENVENIDO A LOS DATOS SENSIBLES DE TALENT HUB----------------");
                    Console.WriteLine("------------------------------------------------------------------------------");
                    Console.WriteLine("Ingrese el número de la acción a realizar: \n" +
                        "1. Buscar persona mediante su DPI \n" +
                        "2. Ver compresión de compañias de una persona mediante su DPI\n" +
                        "3. Ver descompresión de compañias de una persona mediante su DPI\n" +
                        "4. Ver cartas cifradas de una persona mediante su DPI\n" +
                        "5. Ver cartas descifradas de una persona mediante su DPI\n" +
                        "6. Ver conversaciones cifradas de una persona mediante su DPI\n" +
                        "7. Ver conversaciones descifradas de una persona mediante su DPI\n" +
                        "8. Iniciar sesión según un reclutador\n" +
                        "9. Salir del programa \n");
                    eleccion = Convert.ToInt32(Console.ReadLine());

                    while (eleccion != 0)
                    {
                        switch (eleccion)
                        {
                            case 1:
                                buscar();
                                Console.WriteLine("\n------------------------------------------------------------------------------");
                                Console.WriteLine("Ingrese el número de la acción a realizar: \n" +
                                    "1. Buscar persona mediante su DPI \n" +
                                    "2. Ver compresión de compañias de una persona mediante su DPI\n" +
                                    "3. Ver descompresión de compañias de una persona mediante su DPI\n" +
                                    "4. Ver cartas cifradas de una persona mediante su DPI\n" +
                                    "5. Ver cartas descifradas de una persona mediante su DPI\n" +
                                    "6. Ver conversaciones cifradas de una persona mediante su DPI\n" +
                                    "7. Ver conversaciones descifradas de una persona mediante su DPI\n" +
                                    "8. Iniciar sesión según un reclutador\n" +
                                    "9. Salir del programa \n");
                                eleccion = Convert.ToInt32(Console.ReadLine());
                                break;
                            case 2:
                                ir_a_compresion();
                                Console.WriteLine("\n------------------------------------------------------------------------------");
                                Console.WriteLine("Ingrese el número de la acción a realizar: \n" +
                                    "1. Buscar persona mediante su DPI \n" +
                                    "2. Ver compresión de compañias de una persona mediante su DPI\n" +
                                    "3. Ver descompresión de compañias de una persona mediante su DPI\n" +
                                    "4. Ver cartas cifradas de una persona mediante su DPI\n" +
                                    "5. Ver cartas descifradas de una persona mediante su DPI\n" +
                                    "6. Ver conversaciones cifradas de una persona mediante su DPI\n" +
                                    "7. Ver conversaciones descifradas de una persona mediante su DPI\n" +
                                    "8. Iniciar sesión según un reclutador\n" +
                                    "9. Salir del programa \n");
                                eleccion = Convert.ToInt32(Console.ReadLine());
                                break;
                            case 3:
                                pruebaDESC();
                                Console.WriteLine("\n------------------------------------------------------------------------------");
                                Console.WriteLine("Ingrese el número de la acción a realizar: \n" +
                                    "1. Buscar persona mediante su DPI \n" +
                                    "2. Ver compresión de compañias de una persona mediante su DPI\n" +
                                    "3. Ver descompresión de compañias de una persona mediante su DPI\n" +
                                    "4. Ver cartas cifradas de una persona mediante su DPI\n" +
                                    "5. Ver cartas descifradas de una persona mediante su DPI\n" +
                                    "6. Ver conversaciones cifradas de una persona mediante su DPI\n" +
                                    "7. Ver conversaciones descifradas de una persona mediante su DPI\n" +
                                    "8. Iniciar sesión según un reclutador\n" +
                                    "9. Salir del programa \n");
                                eleccion = Convert.ToInt32(Console.ReadLine());
                                break;
                            case 4:
                                mostrar_cartas_cifradas();
                                Console.WriteLine("\n------------------------------------------------------------------------------");
                                Console.WriteLine("Ingrese el número de la acción a realizar: \n" +
                                    "1. Buscar persona mediante su DPI \n" +
                                    "2. Ver compresión de compañias de una persona mediante su DPI\n" +
                                    "3. Ver descompresión de compañias de una persona mediante su DPI\n" +
                                    "4. Ver cartas cifradas de una persona mediante su DPI\n" +
                                    "5. Ver cartas descifradas de una persona mediante su DPI\n" +
                                    "6. Ver conversaciones cifradas de una persona mediante su DPI\n" +
                                    "7. Ver conversaciones descifradas de una persona mediante su DPI\n" +
                                    "8. Iniciar sesión según un reclutador\n" +
                                    "9. Salir del programa \n");
                                eleccion = Convert.ToInt32(Console.ReadLine());
                                break;
                            case 5:
                                mostrar_cartas_descifradas();
                                Console.WriteLine("\n------------------------------------------------------------------------------");
                                Console.WriteLine("Ingrese el número de la acción a realizar: \n" +
                                    "1. Buscar persona mediante su DPI \n" +
                                    "2. Ver compresión de compañias de una persona mediante su DPI\n" +
                                    "3. Ver descompresión de compañias de una persona mediante su DPI\n" +
                                    "4. Ver cartas cifradas de una persona mediante su DPI\n" +
                                    "5. Ver cartas descifradas de una persona mediante su DPI\n" +
                                    "6. Ver conversaciones cifradas de una persona mediante su DPI\n" +
                                    "7. Ver conversaciones descifradas de una persona mediante su DPI\n" +
                                    "8. Iniciar sesión según un reclutador\n" +
                                    "9. Salir del programa \n");
                                eleccion = Convert.ToInt32(Console.ReadLine());
                                break;
                            case 6:
                                mostrar_conversaciones_cifradas();
                                Console.WriteLine("\n------------------------------------------------------------------------------");
                                Console.WriteLine("Ingrese el número de la acción a realizar: \n" +
                                    "1. Buscar persona mediante su DPI \n" +
                                    "2. Ver compresión de compañias de una persona mediante su DPI\n" +
                                    "3. Ver descompresión de compañias de una persona mediante su DPI\n" +
                                    "4. Ver cartas cifradas de una persona mediante su DPI\n" +
                                    "5. Ver cartas descifradas de una persona mediante su DPI\n" +
                                    "6. Ver conversaciones cifradas de una persona mediante su DPI\n" +
                                    "7. Ver conversaciones descifradas de una persona mediante su DPI\n" +
                                    "8. Iniciar sesión según un reclutador\n" +
                                    "9. Salir del programa \n");
                                eleccion = Convert.ToInt32(Console.ReadLine());
                                break;
                            case 7:
                                mostrar_conversaciones_descifradas();
                                Console.WriteLine("\n------------------------------------------------------------------------------");
                                Console.WriteLine("Ingrese el número de la acción a realizar: \n" +
                                    "1. Buscar persona mediante su DPI \n" +
                                    "2. Ver compresión de compañias de una persona mediante su DPI\n" +
                                    "3. Ver descompresión de compañias de una persona mediante su DPI\n" +
                                    "4. Ver cartas cifradas de una persona mediante su DPI\n" +
                                    "5. Ver cartas descifradas de una persona mediante su DPI\n" +
                                    "6. Ver conversaciones cifradas de una persona mediante su DPI\n" +
                                    "7. Ver conversaciones descifradas de una persona mediante su DPI\n" +
                                    "8. Iniciar sesión según un reclutador\n" +
                                    "9. Salir del programa \n");
                                eleccion = Convert.ToInt32(Console.ReadLine());
                                break;
                            case 8:
                                buscar_para_lab5();
                                Console.WriteLine("\n------------------------------------------------------------------------------");
                                Console.WriteLine("Bienvenido reclutador, ingresa la opción con la que desees trabajar: \n" +
                                    "1. Ver conversaciones cifradas de una persona mediante su DPI\n" +
                                    "2. Ver conversaciones descifradas de una persona mediante su DPI\n" +
                                    "3. Salir del programa \n");
                                eleccionReclutador = Convert.ToInt32(Console.ReadLine());

                                    switch (eleccionReclutador)
                                    {
                                        case 1:
                                            mostrar_conversaciones_cifradasRECLUTADOR();
                                            break;
                                        case 2:
                                            mostrar_conversaciones_descifradasRECLUTADOR();
                                            break;
                                        default:
                                            Console.WriteLine("Opción incorrecta");
                                            break;
                                    }
                                break;
                            case 9:
                                Console.WriteLine("\nGracias por utilizar nuestro programa de búsquedas y compresión.");
                                Environment.Exit(0);
                                break;
                            default:
                                Console.WriteLine("Opción incorrecta");
                                break;
                        }
                    }
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
            Console.ReadKey();
        }

        public static void buscar()
        {
            try
            {
                long dpi = 0;

                Console.WriteLine("Ingrese el número de DPI de la persona que desea buscar:");
                string dpi_buscar = Console.ReadLine().Trim();
                dpi = Convert.ToInt64(dpi_buscar);

                Console.WriteLine(json.personaBuscada(dpi));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }


        //LAB 2
        public static void ir_a_compresion()
        {
            try
            {
                Console.WriteLine("DPI a buscar: ");
                string dpi_buscar = Console.ReadLine().Trim();
                long dpi_convertido = Convert.ToInt64(dpi_buscar);

                Console.WriteLine(json.aplicacion_de_compresion(dpi_convertido));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        public static void ir_a_descompresion()
        {
            try
            {
                Console.WriteLine("DPI a buscar: ");
                string dpi_buscar = Console.ReadLine().Trim();
                long dpi_convertido = Convert.ToInt64(dpi_buscar);

                Console.WriteLine(json.aplicacion_de_descompresion(dpi_convertido));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        public static void pruebaDESC()
        {
            try
            {
                long dpi = 0;

                Console.WriteLine("DPI a buscar: ");
                string dpi_buscar = Console.ReadLine().Trim();
                dpi = Convert.ToInt64(dpi_buscar);

                Console.WriteLine(json.pruebaDESCOMPRESION(dpi));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }



        //LAB 3
        public static void mostrar_cartas_cifradas()
        {
            try
            {
                Console.WriteLine("DPI a buscar: ");
                string dpi_buscar = Console.ReadLine().Trim();
                long dpi_convertido = Convert.ToInt64(dpi_buscar);

                json.archivoBuscadoCifrado(dpi_convertido);
            }
            catch (Exception)
            {
                Console.WriteLine("ERROR al buscar el archivo cifrado.");
                throw;
            }
        }

        public static void mostrar_cartas_descifradas()
        {
            try
            {
                Console.WriteLine("DPI a buscar: ");
                string dpi_buscar = Console.ReadLine().Trim();
                long dpi_convertido = Convert.ToInt64(dpi_buscar);

                json.archivoBuscadoDescifrado(dpi_convertido);
            }
            catch (Exception)
            {
                Console.WriteLine("ERROR al buscar el archivo descifrado.");
                throw;
            }
        }



        //LAB 4
        public static void mostrar_conversaciones_cifradas()
        {
            try
            {
                Console.WriteLine("DPI a buscar: ");
                string dpi_buscar = Console.ReadLine().Trim();
                long dpi_convertido = Convert.ToInt64(dpi_buscar);

                json.ConversacionCifrado(dpi_convertido);
            }
            catch (Exception)
            {
                Console.WriteLine("ERROR al buscar el archivo cifrado.");
                throw;
            }
        }

        public static void mostrar_conversaciones_descifradas()
        {
            try
            {
                Console.WriteLine("DPI a buscar: ");
                string dpi_buscar = Console.ReadLine().Trim();
                long dpi_convertido = Convert.ToInt64(dpi_buscar);

                json.ConversacionDescifrado(dpi_convertido);
            }
            catch (Exception)
            {
                Console.WriteLine("ERROR al buscar el archivo descifrado.");
                throw;
            }
        }



        //LAB 5
        public static void buscar_para_lab5()
        {
            try
            {
                Console.WriteLine("\n------------------------------------------------------------------------------");
                Console.WriteLine("INICIO DE SESIÓN:");
                Console.WriteLine("Ingrese el nombre del reclutador:");
                string n_reclutador = Console.ReadLine().Trim();
                Console.WriteLine("Ingrese su contraseña: ");
                string contrasenia = Console.ReadLine().Trim();
                

                json.personaBuscadaParaLab5(n_reclutador, contrasenia);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }


        public static void mostrar_conversaciones_cifradasRECLUTADOR()
        {
            /*try
            {
                Console.WriteLine("Por control de seguridad, ingrese su contraseña para acceder a las conversaciones: ");
                string contrasenia = Console.ReadLine().Trim();
                long dpi_convertido = Convert.ToInt64(dpi_buscar);

                json.ConversacionCifradoRECLUTADOR(contrasenia);
            }
            catch (Exception)
            {
                Console.WriteLine("ERROR al buscar el archivo cifrado.");
                throw;
            }*/

            try
            {
                Console.WriteLine("DPI a buscar: ");
                string dpi_buscar = Console.ReadLine().Trim();
                long dpi_convertido = Convert.ToInt64(dpi_buscar);

                json.ConversacionCifrado(dpi_convertido);
            }
            catch (Exception)
            {
                Console.WriteLine("ERROR al buscar el archivo cifrado.");
                throw;
            }
        }

        public static void mostrar_conversaciones_descifradasRECLUTADOR()
        {
            try
            {
                Console.WriteLine("DPI a buscar: ");
                string dpi_buscar = Console.ReadLine().Trim();
                long dpi_convertido = Convert.ToInt64(dpi_buscar);

                json.ConversacionDescifradoRECLUTADOR(dpi_convertido);
            }
            catch (Exception)
            {
                Console.WriteLine("ERROR al buscar el archivo descifrado.");
                throw;
            }
        }






        public static void pruebas()
        {
            ir_a_descompresion();
        }

    }

}

