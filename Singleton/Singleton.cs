using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    /// <summary>
    /// The Singleton should always be a 'sealed' class to prevent class
    /// inheritance through external classes and also through nested classes.
    /// </summary>
    public sealed class Singleton
    {
        /// <summary>
        /// The Singleton's constructor should always be private to prevent
        /// direct construction calls with the `new` operator.
        /// </summary>
        private Singleton() { }

        /** The Singleton's instance is stored in a static field. */
        private static Singleton instance;

        /// <summary>
        /// This is the static method that controls the access to the singleton
        /// instance. On the first run, it creates a singleton object and places
        /// it into the static field. On subsequent runs, it returns the client
        /// existing object stored in the static field.
        /// </summary>
        /// <returns></returns>
        public static Singleton GetInstance()
        {
            if(instance == null)
            {
                instance =  new Singleton();
            }

            return instance;
        }

        /// <summary>
        /// any singleton should define some business logic, which can
        /// be executed on its instance.
        /// </summary>
        public void SometOtherBusinessLogic()
        {
            /** 
             * Other Business Logic Deals with Singleton
             */
            Console.WriteLine($"Singleton other business logic {nameof(instance)}");
        }
    }
}
