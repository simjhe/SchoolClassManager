using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClassManager
{
    /// <summary>
    /// treat address of a student as own class
    /// </summary>
    public class Address
    {
        /// <summary>
        /// fields
        /// </summary>
        private string city;
        private string street;
        private string zip;

        /// <summary>
        /// default constructor
        /// </summary>
        public Address()
        {

        }

        /// <summary>
        /// Constructor with four parameters
        /// </summary>
        /// <param name="city">city as input</param>
        /// <param name="country">the country as enum as input</param>
        /// <param name="street">street as input</param>
        /// <param name="zip">zip code as input</param>
        /// <remarks></remarks>
        public Address(string city, string street, string zip) : this()
        {
            this.city = city;
            this.street = street;
            this.zip = zip;
        }

        /// <summary>
        /// properties - allowing write and read access
        /// </summary>
        public string City
        {
            get
            {
                return city;
            }

            set
            {
                if (!string.IsNullOrEmpty(value)) // for all properties, perform an input validation - values should not be zero
                    city = value;
            }
        }

        public string Street
        {

            get
            {
                return street;
            }

            set
            {
                if (!string.IsNullOrEmpty(value))
                    street = value;
            }
        }

        public string Zip
        {
            get
            {
                return zip;
            }

            set
            {
                if (!string.IsNullOrEmpty(value))
                    zip = value;
            }
        }
    }
}
