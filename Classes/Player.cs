using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBAManager.Classes
{
    public class Player
    {
        private string firstName;
        private string lastName;
        private int age;
        private double offense;
        private double defense;
        private double overall;
        private Team team;
        private Position position;

        public Player(string firstName, string lastName, int age, double offense, double defense, Position position)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.offense = offense;
            this.defense = defense;
            this.position = position;
        }

        public string getFirstName(){ return firstName; }
        public void setFirstName(string name){ this.firstName = name; }

        public string getLastName() { return lastName; }
        public void setLastName(string name) { this.lastName = name; }

        public int getAge() { return age; }

        public double getOverall() {  return ((this.offense+this.defense)/2) + 1; }

        public double getDefense() { return this.defense; }

        public void setDefense(double defense) { this.defense = defense; }

        public double getOffense() { return this.offense; }

        public void setOffense(double offense) { this.offense = offense; }

        public Team getTeam() { return team; }

        public void setTeam(Team team) { this.team = team; }

        public Position getPosition() { return position; }
        


        public override string ToString()
        {
            return getFirstName() + " " + getLastName() + ", " + getAge().ToString() + "y "+getOverall()+" Overall";
        }
    }
}
