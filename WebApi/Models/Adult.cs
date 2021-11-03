namespace WebApi.Models
{
    public class Adult : Person
    {
         Job JobTitle { get; set; }
    


        public Adult()
        {
            JobTitle = new Job();
        }
    }
}