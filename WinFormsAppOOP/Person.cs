
using System;

namespace WinFormsAppOOP
{

    public interface Person
    {

        String getName();

        Person setName(String name);

        Person addObserver(Observer observer);

    }

    public class PersonModel : Person
    {

        private String name;
        private List<Observer> observers = new List<Observer>();

        public PersonModel()
        {

            setName("");

        }

        public PersonModel(String name)
        {

            setName(name);

        }

        public String getName()
        {

            return name;

        }

        public Person setName(String name)
        {

            this.name = name;

            notify();

            return this;

        }

        public Person addObserver(Observer observer)
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

    public class NullPerson : Person
    {

        private static Person nullPerson = new NullPerson();

        private NullPerson()
        {

        }

        public static Person getInstance()
        {

            return nullPerson;

        }

        public String getName()
        {

            return "";

        }

        public Person setName(String name)
        {

            return this;

        }

        public Person addObserver(Observer observer)
        {

            return this;

        }

    }

}