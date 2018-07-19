using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractPlanet
{
    // 24 Marks
    public abstract class Planet
    {
        // FIELDS(PRIVATE INSTANCE VARIABLES): 7 Marks
        private double _diameter;
        private double _mass;
        private int _moonCount;
        private string _name;
        private double _orbitalPeriod;
        private int _ringcount;
        private double _rotationPeriod;

        // PROPERTIES : 7 Marks
        public double Diameter
        {
            get
            {
                return _diameter;
            }
        }

        public double Mass
        {
            get
            {
                return _mass;
            }
        }

        public int MoonCount
        {
            get
            {
                return _moonCount;
            }
            set
            {
                _moonCount = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public double OrbitalPeriod
        {
            get
            {
                return _orbitalPeriod;
            }
            set
            {
                _orbitalPeriod = value;
            }
        }

        public int RingCount
        {
            get
            {
                return _ringcount;
            }
            set
            {
                _ringcount = value;
            }
        }

        public double RotationPeriod
        {
            get
            {
                return _rotationPeriod;
            }
            set
            {
                _rotationPeriod = value;
            }
        }

        // CONSTRUCTOR : 6 Marks
        public Planet(string name, double diameter, double mass)
        {
            this._name = name;
            this._diameter = diameter;
            this._mass = mass;
        }

        // METHODS : 4 Marks
        public override string ToString()
        {
            return "[Planet Name: " + this.Name + "]\n" + 
                   " - Dismeter: " + this.Diameter + "KM\n" +
                   " - Mass: " + this.Mass + "E\n";
        }
    }
}
// 8-B. Program Structure Check (FileName) : 1 Mark
// 8-F1. Program Structure Check (Private Variable) : 1 Mark