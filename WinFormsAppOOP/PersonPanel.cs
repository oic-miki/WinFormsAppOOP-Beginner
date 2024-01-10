using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppOOP
{

    public class PersonPanel : Panel, Observer
    {

        private Person person;
        private List<Observer> observers = new List<Observer>();

        public PersonPanel()
        {

            addPerson(NullPerson.getInstance());

        }

        public PersonPanel(Person person)
        {

            addPerson(person);

        }

        public PersonPanel addPerson(Person person)
        {

            this.person = person.addObserver(this);

            update();

            return this;

        }

        public void update()
        {

            Text = person.getName();

        }

        public PersonPanel addObserver(Observer observer)
        {

            observers.Add(observer);

            return this;

        }

        private void notify()
        {

            observers.ForEach(observer =>
            {

                observer.update();

            });

        }

    }

}
