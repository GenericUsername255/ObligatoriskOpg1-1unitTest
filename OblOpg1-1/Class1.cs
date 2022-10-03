namespace OblOpg1_1
{
    public class FootballPlayer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int ShirtNumber { get; set; }



        public void ValidateName()
        {
            //Name must be over 2 char long 
            if (Name.Length <= 1) throw new ArgumentOutOfRangeException("Name is to short :" + Name);

            if (Name == null) throw new ArgumentNullException("Name is null :");

        }
        public void ValidateAge()
        {
            //Age must be over 1
            if (Age < 1) throw new ArgumentOutOfRangeException("Age must be more than 0: ");
        }
        public void ValidateShirtNumber()
        {
            //Must be 1..99
            if (ShirtNumber < 1)
            {
                throw new ArgumentOutOfRangeException("Shirt number to low: " + ShirtNumber);
            }
            else if (ShirtNumber > 99)
            {
                throw new ArgumentOutOfRangeException("Shirt number to high " + ShirtNumber);
            }
        }

    }
}