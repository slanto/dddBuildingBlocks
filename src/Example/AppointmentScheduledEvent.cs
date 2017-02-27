using System;
using SharedKernel.Interfaces;

namespace Example
{
    public class MyEvent : IDomainEvent
    {
        public MyEvent(Appointment appointment) : this()
        {
            AppointmentScheduled = appointment;
        }

        public MyEvent()
        {
            this.Id = Guid.NewGuid();
            DateTimeEventOccurred = DateTime.Now;
        }

        public Guid Id { get; private set; }

        public DateTime DateTimeEventOccurred { get; private set; }

        public Appointment AppointmentScheduled { get; private set; }
    }

    // How to use, somewhere in my Appointment class
    // var myEvent = new MyEvent(this);
    // DomainEvents.Raise(myEvent);
}