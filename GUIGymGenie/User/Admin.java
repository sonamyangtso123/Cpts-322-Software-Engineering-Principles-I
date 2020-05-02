package GUIGymGenie.User;
import java.util.ArrayList;
public class Admin 
{
    private ArrayList<User> users;
    public Admin()
    {
        users = new ArrayList <User>();
    }

    public User getUser(int ID)
    {
      User userMatch = null;
      
        for (int i = 0; i < users.size(); i++) 
        {
            if(users.get(i).getId() == ID)
            {
                userMatch = users.get(i);
            }
        }
        if (userMatch == null)
        {
            return null;
        } 
    return userMatch;
    }
    
    public String viewUsers()
    {
        String display ="";
        for (int i = 0;i<users.size();i++) {display+= users.toString();}
        return display;
    }
}