using System;

namespace GitTest
{

    public class Person
    {
        private String firstName; 
        private String lastName;
        private String pNbr;



        public Person()
        {
         

        }

        public Person(String firsName, String lastName, String pNbr)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.pNbr = pNbr;
        }
 

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }

        public string PNbr
        {
            get
            {
                return pNbr;
            }

            set
            {
                pNbr = value;
            }
        }
    }
}
