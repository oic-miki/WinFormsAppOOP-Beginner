using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppOOP
{

    public class PersonNameLabel : Label, Observer
    {

        private Person person;

        public PersonNameLabel()
        {

            addPerson(NullPerson.getInstance());

        }

        public PersonNameLabel(Person person)
        {

            addPerson(person);

        }

        public PersonNameLabel addPerson(Person person)
        {

            this.person = person.addObserver(this);

            update();

            return this;

        }

        public void update()
        {

            Text = person.getName();

        }

    }

}
