import java.io.Reader;

public class User
{
    private String name;
    private int id;
    private String email;
    private String password;

    public User ( String name, int id, String email, String password)
    {
        this. name = name;
        this.id = id;
        this.email = email;
        this.password = password;
    }
    public String getName(){return name;}
    public int getId(){return id;}
    public String getEmail(){ return email;}
    public String getPassword(){return password;}

    public void setName(String name){this.name = name;}
    public void setId(int id){this.id = id;}
    public void setEmail(String email){this.email = email;}
    public void setPassword(String password){this.password = password;}
    
    public String toString()
    {
    String UserInfo = "\n User Info: ";
    UserInfo += "\n\n1) User name: "+ getName();
    UserInfo += "\n2) User Id: "+ getId();
    UserInfo += "\n3) User email: " + getEmail();
    UserInfo += "\n4) User password: "+getPassword();
    return UserInfo;
    }
}
 