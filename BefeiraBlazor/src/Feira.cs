using System;
using System.Collections.Generic;

namespace feira
{
    public class Feira
    {
        int idFeira;
        string categoria;
        List<Stand> stands = new List<Stand>();

        public Feira(int idFeira, string categoria, List<Stand> stands)
        {
            this.idFeira = idFeira;
            this.categoria = categoria;
            this.stands = new List<Stand>(stands);
        }

        public int getIdFeira()
        {
            return this.idFeira;
        }

        public string getCategoria()
        {
            return this.categoria;
        }

        public List<Stand> getStands()
        {
            return this.stands;
        }

        public void setIdFeira(int idFeira)
        {
            this.idFeira = idFeira;
        }

        public void setCategoria(string categoria)
        {
            this.categoria = categoria;
        }

        public void setStands(List<Stand> stands)
        {
            this.stands = stands;
        }

        public void addStand(Stand stand)
        {
            this.stands.Add(stand);
        }

        public void removeStand(Stand stand)
        {
            this.stands.Remove(stand);
        }
        
        public void removeStandWithId(int idStand)
        {
            for (int i = 0; i < this.stands.Capacity; i++)
            {
                if (this.stands[i].getIdStand() == idStand) this.stands.Remove(this.stands[i]);
            }
        }
    }
}
