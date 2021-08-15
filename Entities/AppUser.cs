namespace API.Entities
{
    public class AppUser
    {
        private int id;
        private string username;
        public AppUser(int Id, string UserName){
            this.Id = Id;
            this.UserName = UserName;
        }
        public int Id { 
            get{
                return id;
            } 
            set{
                id = value;
            } 
        }
        public string UserName { 
            get{
                return username;
            } set{
                username = value;
            } 
        }
        // public string PasswordHash { get; set; }
        // public string PasswordSalt { get; set; }
    }
}