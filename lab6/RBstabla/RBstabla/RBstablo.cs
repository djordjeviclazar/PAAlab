using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBstabla
{
    public class RBstablo
    {
        class Čvor
        {
            int ključ;
            object obj;
            Čvor levo, desno, roditelj;
            bool crven;

            Čvor()
            {
                crven = false;
                obj = null;
                levo = null;
                desno = null;
                ključ = default;
                roditelj = null;
            }

            Čvor(int ključ, object obj = null)
            {
                crven = false;
                this.obj = obj;
                levo = null;
                desno = null;
                this.ključ = ključ;
                roditelj = null;
            }

            void PromeniBoje()
            {
                if (this.roditelj != null)
                {
                    this.crven = true;
                }

                this.desno.crven = false;
                this.levo.crven = false;
            }

            Čvor RotirajLevo()
            {
                Čvor pom = this.desno;

                this.desno = pom.levo;
                pom.levo.roditelj = this;

                pom.levo = this;
                pom.roditelj = this.roditelj;
                this.roditelj = pom;

                pom.crven = this.crven;
                this.crven = true;

                return pom;
            }

            Čvor RotirajDesno()
            {
                Čvor pom = this.levo;

                this.levo = pom.desno;
                pom.desno.roditelj = this;

                pom.desno = this;
                pom.roditelj = this.roditelj;
                this.roditelj = pom;

                pom.crven = this.crven;
                this.crven = true;

                return pom;
            }
        }
    }
}
