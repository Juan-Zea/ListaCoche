using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AplicacionListadoCoche

{
    class ServicioCoche
    {

        private static Coche coches;

        public ServicioCoche()
        {
            coches = null;
        }

        public static Coche GetCoches()
        {
            return coches;
        }

        public static void setCoche(Coche pCoche)
        {
            coches = pCoche;
        }

        //metodo para incertar al incio de la lista
        public static void adicionarInicio(Coche pCoche)
        {
            pCoche.setSgte(coches);
            if (comprovacionContenido() == true)
            {
                coches.setAnte(pCoche);
            }
            coches = pCoche;
        }

        //metodo para incertar al final de la lista
        public static void adicionarFinal(Coche pCoche)
        {
            if (coches == null)
            {
                coches = pCoche;

                throw new Exception("No hay coches en el concesionario" + Environment.NewLine + "Coche adicionado como primero de lista!");
            }
            else
            {
                Coche temCoches = coches;

                while (temCoches.getSgte() != null)
                {
                    temCoches = temCoches.getSgte();
                }

                temCoches.setSgte(pCoche);
                temCoches.getSgte().setAnte(temCoches);

            }

        }
        //Metodo para contar la cantidad de cohces que hay en el concesionario
        public static int condeContar()
        {
            Coche recorrido = coches;
            int count = 0;
            while (recorrido != null)
            {
                count++;
                recorrido = recorrido.getSgte();
            }

            return count;
        }

        //Metodo para comprobar si el concecionario esta en null
        public static Boolean comprovacionContenido()
        {
            if (coches == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        //Metodo para insertar en una posición ingrsada por parametro
        public static void adicionarPosicion(Coche pCoche, int pPosicion)
        {
            Coche recorrido = coches;


            if (comprovacionContenido() != true)
            {
                coches = pCoche;
            } else if (pPosicion == 1)
            {
                adicionarInicio(pCoche);
            }
            else
            {
                recorrido = buscarPosicion(pPosicion);
                pCoche.setSgte(recorrido);
                recorrido.getAnte().setSgte(pCoche);
                pCoche.setAnte(recorrido.getAnte());
                recorrido.setAnte(pCoche);
               
            }

        }

        //Metodo de prubeba para insertar 3 coches 
        public static void metodoPruebaInsertarNodos()
        {
            /*
            Coche nue;


            nue = new Coche(1, "A", 12, "Chevrolet",);
            ServicioCoche.adicionarInicio(nue);
            nue = new Coche(2, "B", 12, "Chevrolet");
            ServicioCoche.adicionarInicio(nue);
            nue = new Coche(3, "C", 12, "Chevrolet");
            ServicioCoche.adicionarInicio(nue);
            */

        }
        //Metodo para buscar por ID
        public static Coche buscarId(int pID)
        {   

            Coche recorrido = coches;
            if (comprovacionContenido()==false)
            {
                throw new Exception("No se encuentra  ningun coche");
            }
            while (recorrido != null)
            {
                if (recorrido.getID() == pID)
                {
                    break;
                } if (recorrido.getSgte()==null)
                {
                    throw new Exception("No se encuentra el coche con esa referencia");
                }
                recorrido = recorrido.getSgte();
                
            }

            return recorrido;
        }
        //Metodo para actualizar información de un coche
        public static void actualizarCoche(int pID, string pModelo, int pNumeroAirbag,
            string pMarca)
        {
            Coche cocheAc = buscarId(pID);

            cocheAc.setModelo(pModelo);
            cocheAc.setNumeroAirBag(pNumeroAirbag);
            cocheAc.setMarca(pMarca);

        }

        //Metodo para eliminar primero de la lista

        public static void eliminarPrimero()
        {
            if (comprovacionContenido() == false)
            {
                throw new Exception("No existen coches en el concecionario" + Environment.NewLine + "No se pudo eliminar!");
            } else
            {
                Coche tem = coches;
                tem = tem.getSgte();
                coches = tem;
            }

        }

        //Metodo para eliminar ultimo de la lista
        public static void eliminarUltimo()
        {
            if (comprovacionContenido() == false)
            {
                throw new Exception("No existen coches en el concecionario" + Environment.NewLine + "No se pudo eliminar!");
            }
            else
            {
                Coche temCoches = coches;

                while (temCoches.getSgte() != null)
                {
                    temCoches = temCoches.getSgte();
                }

                temCoches.getAnte().setSgte(null);
            }
        }

        //Metodo para buscar por ID
        public static Coche buscarPosicion(int pPosicion)
        {
            Coche recorrido = coches;
            int count = 1;
            while (recorrido != null)
            {
                if (count == pPosicion)
                {
                    break;
                }
                recorrido = recorrido.getSgte();
                count++;

            }

            return recorrido;
        }

        //Metodo eliminar por posición 
        public static void eliminarPosicion (int pPosicion)
        {
            if (comprovacionContenido() == false)
            {
                throw new Exception("No existen coches en el concecionario" + Environment.NewLine + "No se pudo eliminar!");
            }else if (pPosicion == 1)
            {
                eliminarPrimero();
            }else if (pPosicion == condeContar())
            {
                eliminarUltimo();
            }
            else if (condeContar() < pPosicion)
            {
                throw new Exception("No se puede eliminar el coche de esa posición" + Environment.NewLine + "no se cuenta con tantos coches!");
            }else
            {
                Coche eliminado = buscarPosicion(pPosicion);
                eliminado.getAnte().setSgte(eliminado.getSgte());
                eliminado.getSgte().setAnte(eliminado.getAnte());
            }
        }

    }
}
