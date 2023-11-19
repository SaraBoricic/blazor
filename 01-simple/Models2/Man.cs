namespace DSS.Models2
{
    public enum Gender = {Male, Female};

    public class Man
    {
        public string lastName = "";

        public string firstName ="";

        public Gender Gender = Gender.Male;

        public string Nationality ="";

    public Address Address = new Address(){

            Streat = "",
            City = "",
            PostalCode = "",
            State = ""


    };



    }
    
}