namespace CustomerPortal.Models

{
    public class Intervention
    {


        // Properties
        public ulong Id { get; set; }

        public ulong? Author_Id { get; set; }

        public ulong? Customer_Id { get; set; }

        public ulong? Building_Id { get; set; }

        public ulong? Battery_Id { get; set; }

        public ulong Column_Id { get; set; }

        public ulong? Elevator_Id { get; set; }

    }
}