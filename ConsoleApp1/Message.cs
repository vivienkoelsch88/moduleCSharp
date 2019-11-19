using ConsoleApp1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Message 
    {

        private String message = "";
        private int matin;
        private int midi;
        private int soir;
        private String name;
        private IDateTimeMe dateTime;

        public Message(int matin =  9, int midi = 13, int soir = 18)
            : this(new DateTimeMe(), new EnvironementMe(), matin, midi, soir)
        {
        }

        internal Message(IDateTimeMe iDateTimeMe, IEnvironementMe environement, int matin, int midi, int soir)
        {
            this.dateTime = iDateTimeMe;

            this.matin = matin;
            this.midi = midi;
            this.soir = soir;
            
            this.name = environement.getUserNamle();
        }

        public String GetHelloMessage()
        {
            DateTime dateValue = this.dateTime.getDateNow();

            if (dateValue.DayOfWeek == DayOfWeek.Saturday || dateValue.DayOfWeek == DayOfWeek.Sunday || (dateValue.DayOfWeek == DayOfWeek.Friday && (dateValue.Hour >= this.soir || dateValue.Hour < this.matin)))
            {
                this.message = "Bon week-end ";
            }
            else if (dateValue.Hour >= this.matin && dateValue.Hour <= this.midi)
            {
                this.message = "Bonjour ";
            }
            else if (dateValue.Hour > this.midi && dateValue.Hour < this.soir)
            {
                this.message = "Bon après midi ";
            }
            else if (dateValue.Hour >= 18 || dateValue.Hour < this.matin)
            {
                this.message = "Bonsoir ";
            }
            

            message = this.message + this.name + " !";

            return this.message;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public String getname()
        {
            return this.name;
        }
    }
}
