using System;
using System.Collections.Generic;
using System.Text;

namespace PlayWithEquality
{
    class Location : IEquatable<Location>
    {
        public Location()
        { 
          
        }
        public string strName { get; set; }
        public string strMaterial { get; set; }

        public bool Equals(Location InLoc)
        {
            return this.strName == InLoc.strName && this.strMaterial == InLoc.strMaterial;
        }

        public static bool operator ==(Location lhs, Location rhs)
        {
            return lhs.Equals(rhs);
        }
        public static bool operator !=(Location lhs, Location rhs)
        {
            return !lhs.Equals(rhs);
        }

    }

    
        

}
