using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL 
{
    public class Materia
    {
        // Add, Update, Delete, GetAll, GetById

        public static void  Add() 
        {
            ML.Materia materia = new ML.Materia();

            Console.WriteLine("Ingrese el nombre de la materia");
            materia.Nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el número de créditos");
            materia.Creditos = byte.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el costo de la materia");
            materia.Costo = decimal.Parse(Console.ReadLine());

            ML.Result result= BL.Materia.Add(materia);

            if (result.Correct)
            {
                Console.WriteLine("La materia se insertó correctamente");
            }
            else
            {
                Console.WriteLine("Ocurrió un error" + result.ErrorMessage);
            }
            //BL.Materia materia = new BL.Materia();
            //materia.Add();


        }

        

        public static void Update()
        {
            ML.Materia materia = new ML.Materia();

            //
            Console.WriteLine("Ingresar el Id que se debe de actualizar");
            materia.IdMateria = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresar el nuevo nombre");
            materia.Nombre = Console.ReadLine();

            Console.WriteLine("Ingresar los nuevos créditos de la materia");
            materia.Creditos = byte.Parse(Console.ReadLine()); // 0..255

            Console.WriteLine("Ingresar el nuevo costo de la materia");
            materia.Costo = decimal.Parse(Console.ReadLine());

            BL.Materia.Update(materia);
        }


        public static void GetAll()
        {
            ML.Result result=BL.Materia.GetAll();

            if(result.Correct)
            {
                foreach(ML.Materia materia in result.Objects)
                {
                    Console.WriteLine("IdMateria:" + materia.IdMateria);
                    Console.WriteLine("Nombre:" + materia.Nombre);
                    Console.WriteLine("Creditos:" + materia.Creditos);
                    Console.WriteLine("Costo:" + materia.Costo);

                }
            }
            
        }
        public static void GetById()
        {
            Console.WriteLine("Ingrese el ID de la materia a consultar");
            int idMateria = int.Parse(Console.ReadLine());
            ML.Result result = BL.Materia.GetById(idMateria);

            if (result.Correct)
            {
                //unboxing
                ML.Materia materia = (ML.Materia)result.Object;
                Console.WriteLine("IdMateria:" + materia.IdMateria);
                Console.WriteLine("Nombre:" + materia.Nombre);
                Console.WriteLine("Creditos:" + materia.Creditos);
                Console.WriteLine("Costo:" + materia.Costo);
            }
            else
            {
                Console.WriteLine("Hubo un error al hacer la consulta" + result.ErrorMessage);
            }
            Console.ReadKey();

            //ML.Materia materia = new ML.Materia();
            //materia.IdMateria = int.Parse(Console.ReadLine());

            //Que es una propiedad de navegación de C#
            //Implementar propiedad de navegacion a Rol
        }
    }
}
