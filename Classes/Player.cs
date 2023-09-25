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
        private double overall;
        private Team team;

        public Player(string firstName, string lastName, int age, double overall)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.overall = overall;
        }

        public string getFirstName(){ return firstName; }
        public void setFirstName(string name){ this.firstName = name; }

        public string getLastName() { return lastName; }
        public void setLastName(string name) { this.lastName = name; }

        public int getAge() { return age; }

        public double getOverall() {  return overall; }
        public void setOverall(double overall) { this.overall = overall; }

        public Team getTeam() { return team; }

        public void setTeam(Team team) { this.team = team; }

        public override string ToString()
        {
            return getFirstName() + " " + getLastName() + ", " + getAge().ToString() + " years old.";
        }
    }
}
