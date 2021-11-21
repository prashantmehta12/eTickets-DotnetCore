namespace eTickets.Models
{
    public class Actor_Movie
    {

        /*
         1. Reason to declare this class is to set/convey to sql server through entity frameword code first approach that this is many to many relationship 
         2. Reason to declare Movie/Actor property is just to make sql sever identify that MovieId/ActorId property is foreign key of Movie property
         3. Another way to define the same is adding a attribute above Movie/Actor property as 
           [ForeignKey("MovieId/ActorId")]
         4. By default point number 3 can be defined in place of point no 2, as it is smartly understood by entity framework to convey the role of the class design in sql server.
         */

        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public int ActorId { get; set; }

        public Actor Actor { get; set; }
    }
}
