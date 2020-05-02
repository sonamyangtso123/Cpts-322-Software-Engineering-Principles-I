package GUIGymGenie.User;


public class Customer extends User 
{
    private boolean isMember;

    public Customer(String name, int id, String email, String password)
    {
        super(name, id,email,password);
        isMember = false;
    }
    

    
}