using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionListadoCoche
{
    public class Coche
    {
        private int ID;
        private String modelo;
        private DateTime fechaCreacion;
        private int numeroAirbag;
        private String marca;
        private Coche sgte;
        private Coche ante;

        public Coche(int pID,string modelo,DateTime pFechaCreacion ,int numeroAirbag, string marca)
        {
            ID= pID;
            this.modelo = modelo;
            this.fechaCreacion = pFechaCreacion;
            this.numeroAirbag = numeroAirbag;
            this.marca = marca;
        }

        public void setID(int pID)
        {
            ID = pID;
        }

        public int getID()
        {
            return ID;
        }
        public String getModelo()
        {
            return modelo;
        }

        public void setModelo(String pModelo)
        {
            modelo = pModelo;
        }
  
        public DateTime getFechaCreacion()
        {
            return fechaCreacion;
        }

        public void setFechaCreacion(DateTime pFechaCreacion)
        {
            fechaCreacion = pFechaCreacion;
        }
        public int getNumeroAirBag()
        {
            return numeroAirbag;
        }

        public void setNumeroAirBag(int pAirBag)
        {
            numeroAirbag = pAirBag;
        }
        public String getMarca()
        {
            return marca;
        }

        public void setMarca(String pMarca)
        {
            marca = pMarca;
        }

        public void setSgte(Coche pSgte)
        {
            sgte = pSgte;
        }
        public Coche getSgte()
        {
            return sgte;
        }

        public void setAnte(Coche pAnte)
        {
            ante = pAnte;
        }
        public Coche getAnte ()
        {
            return ante;
        }
    }
}
