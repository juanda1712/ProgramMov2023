using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Xamarin.Forms;

namespace ProgramMov2023
{
    public class Unidad1
    {
        int num, num2, num3;
        int num4 = 1;
        long lg1;
        string nombre = "Juan";
        bool bl1;
        double dbl1;
        char ch;
        object obj = "";
        object niño = new { nombre = "carlos", edad = 20};

        
       
        private void ejemplo()
        {
            int num5;
            var casa = "cr 4";
            casa = "";           
            var persona = new { nombre = "carlos", edad = 20 };

            string edad = "20";
            int mi_edad= 0;


            ///Conversiones   string --> int 
            mi_edad = int.Parse(edad);
            mi_edad = Convert.ToInt16(edad);


            ///  conversion int ---> string
            ///  
            edad = mi_edad.ToString();

            /// fecha del day
            DateTime fn = DateTime.Now;
            string fecha = fn.ToString();
            fn = Convert.ToDateTime(fecha);

            /// asignaciones
            /// 
            mi_edad = mi_edad + 1;
            mi_edad++;
            --mi_edad;
            mi_edad += 10;


            // string format
            //  concat   msj ----> " Mi edad es # y mi nombre es: #"

            string mensaje = string.Concat("Mi edad es:", edad , "y mi nombre es:" , nombre);
            mensaje = string.Format("Mi edad es: {0} y mi nombre es: {1}",edad,nombre);

            ejemplo2(); /// llamar metodos 

           var resultado =  sumar(dbl1 , 10); // llamado de una función 

           // llamado con sobrecarga 
           resultado = sumar(10,5);
           resultado = sumar("10", "5");


            // llamado con parametro opcional 
            var set_nombre = consultar_nombre(1093);
            set_nombre = consultar_nombre(1093, 312980390);
                    
        }


        private void condicionales()
        {

            /// determinar si tiene cedula, contraseña o TI
            int edad = 19;
            string resultado = "";

            if ( edad == 18)
            {
                resultado = "contraseña";
            }
            else if (edad > 18 )
            {
                resultado = "Cedula";
            }
            else
            {
                resultado = "TI";
            }


            /// OPERADORES 
            ///  && --> AND
            ///  || --> OR
            ///  ! --> NEGACIÓN
            ///  == --> igual  / .equals
            ///  !=  --> Diferente

            int num = 10;
            int num2 = 20;

            if (num == 10 && num2 == 20 )
            {
                resultado = "10 y 20";
            }

            if (num == 10 || num2 == 10 )
            {
                resultado = "10";
            }

            if(!string.IsNullOrEmpty(nombre))
            {

            }

            if(nombre.Equals(""))
            {

            }
           
            if (num != 0)
            {

            }


            //SWITCH
            int n_mes = 5;
            string mes= "";

            switch(n_mes)
            {
                case 1:
                    mes = "Enero";
                    break;

                case 2:
                    mes = "Febrero";
                    break;

                default:
                    mes = "no existe";
                    break;
            }

        }



        private void ciclos()
        {
            int total = 10; 


            // WHILE 
            while ( total >= 0)
            {
                total--;
            }


            //DO WHILE
            do 
            {
                total--;
            } 
            while (total >= 0);


            // FOR 
            // for (ini; expresión bool; act variable)

            for (int b = 0; b <= total; b++ )
            {
                int c = b;
            }


            


        }



        private void vector()
        {
            int[] numeros;
            numeros = new int[5]; //cant posiciones  
            numeros = new int[3] { 1, 2, 3 }; // valores por default 

            numeros[0] = 4;  // set de valores


            /// ciclo al vector 
            for (int i = 0; i < numeros.Length - 1; i++)
            {
                numeros[i] = 0;
            }


            int[,] mt = new int[2,2];
        }



        public virtual void listas()
        {

            List<int> edades = new List<int>() { 1, 2, 3 }; // default
            edades.Add(20);
            edades.Add(32);// Add item a la lista

            edades.Remove(32); // remove por detalle
            edades.RemoveAt(0); // por indice

            edades.Sort(); // ordenar
            edades.Clear(); // limpiar
            int item = edades[0];  // set variable 


            for (int i = 1; i < edades.Count; i++)
            {
                item = edades[i];
            }


            foreach (int edad in edades)
            {
                item = edad;
            }



            /// Diccionarios 
            /// 


            Dictionary<int, string> apikeys = new Dictionary<int, string>();
            apikeys.Add(1, "zzzzz"); /// add items 
            apikeys.Add(2, "yyyyy");

            apikeys.Remove(1); // remove por key
            apikeys.Clear();
            apikeys[1] = "rrrrr";


            foreach(var dic in apikeys)
            {
                string detalle = dic.Value;
                int key = dic.Key;
            }



            // DAtaTable
            // 

            DataTable dtClientes = new DataTable();

            dtClientes.Columns.Add("Id", typeof(int));
            dtClientes.Columns.Add("Nombre", typeof(string));

            dtClientes.Rows.Add(); // row vacio

            dtClientes.Rows.Add(new object[] { 1, "Juan" }); // conservar el orden 


            DataRow dataRow = dtClientes.NewRow();
            dataRow["Id"] = 2;
            dataRow["Nombre"] = "Carlos";
            dtClientes.Rows.Add(dataRow);

            foreach(DataRow dr in dtClientes.Rows)
            {
                var id = dr["Id"];
            }

            var dato = dtClientes.Rows[0]["Id"].ToString();


            DataSet dtBd = new DataSet();
            dtBd.Tables.Add(dtClientes);


            //objeto 
            ClsClientes objClientes = new ClsClientes();
            objClientes.CrearCliente();

        }

        /// <summary>
        /// *void* no retorna información 
        /// </summary>
        private void ejemplo2()
        {
            int num6;
            num6 = 1;
            num = num6;
                      
        }


        /// <summary>
        /// especificar tipo de función (int, double, string)
        /// parametros con tipos
        /// </summary>
        /// <returns></returns>

        private double sumar(double n1 , double n2 )
        {
            double result = 0;
            result = n1 + n2;
            return result;
        }

        private double Multiplicar(double n1, double n2)
        {
            return n1*n2;
        }

        /// <summary>
        /// Parametro opcional 
        /// int = 0
        /// 
        /// string = ""
        /// </summary>
        /// <returns></returns>
        private string consultar_nombre(int cc , int tel = 0)
        {
            return "";
        }

        /// <summary>
        /// Cuerpo de expresión y tiene overloding(sobrecargar) 
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        private int sumar(int n1 , int n2) => n1 + n2;
        private double sumar(string n1, string n2)
        {
            double result = 0;           
            return result;
        }
        



    }
}
