import axios from 'axios';
import {
    LOGIN_USER,
    REGISTER_USER,
    AUTH_USER,
    LOGOUT_USER,
} from './types';
import { USER_SERVER } from '../components/Config.js';

export function registerUser(dataToSubmit){
    const request = axios.post(`${USER_SERVER}/register`,dataToSubmit)
        .then(response => response.data);
    
    return {
        type: REGISTER_USER,
        payload: request
    }
}

export function loginUser(dataToSubmit){
    const request = axios.post(`${USER_SERVER}/login`,dataToSubmit)
                .then(response => response.data);

    return {
        type: LOGIN_USER,
        payload: request
    }
}

export function auth(){
    const request = axios.get(`${USER_SERVER}/auth`)
    .then(response => response.data);

    return {
        type: AUTH_USER,
        payload: request
    }
}

export function logoutUser(){
    const request = axios.get(`${USER_SERVER}/logout`)
    .then(response => response.data);

    return {
        type: LOGOUT_USER,
        payload: request
    }
}


//The code below is written in C++
/*
void ViewUserList(UserList* pHead)
{
//will allow the admin to view the list of users
//assumes that pHead is created in main and uses class UserList
//asssumes standard namespace and appropriate libraries

cout<< "UserList:"<<endl;
while(pHead.pNext!=NULL)
{
    cout<< pHead.User.GetName();
    pHead=pHead.pNext;
}
//no return since it is simply a view function

}

bool Trainer:: TrainingSessionT(Schedule*pHead, Session T)
{
//will allow a trainer to add a session to the list()
bool success=false;
Schedule *pNew= new Schedule(T)
while(success!=true)
{
   if(pHead.pNext=NULL) 
   {
       pHead.SetNext(pNew)'
       success=true;
   }
   else()
   {
       pHead=pHead.GetNext();
   }
}
return success;
}


report Trainer:: CreateReport()
{
//will allow trainer to create BMI report
//possible input: data need to fill Report class
    report l;
    cin<<l;
    return l;
}
 

void Customer::AddTrainingSessionC(int ClassID)
{
//allows customer to add a training session to their account
for(i=1;i++;i!=enrolled_classes.size())
{
    if(enrolled_classes[i]==0)
    {
        enrolled_classes[i]=ClassID;
        break;
    }
}
}


class BMI{
    public:
        BMI();
        ~BMI();
        int GetID();
        void SetId(int x);
        list GetAnalysis();
        void SetAnalysis(list);
        void SetDate(string x);
        string GetDate();
        friend istream & operator >>(istream &in,report &n)
    
    private: 
        int userId;
        string date;
        list analysis[];
}report;


class User{
public:
    User();
    User(User t);
    ~User();
    int GetID();
    string GetPW();
    string GetName();
    string GetUN();

    void SetID(int x);
    void SetPW(string x);
    void SetName(string x);
    void SetUN(string x);

private:

    int Id
    string password;
    string username;
    string name;
}User;


class Customer: public User
{
public:
    Customer();
    ~Customer();
    vector GetEnrolled_Classes();
    int GetMembership();
    void AddTrainingSessionC(int ClassID); //will use next avaiable space to input Class ID
    void SetMemberhsip(); //sets membership level

private:
    vector<int> enrolled_Classes; //acceps class iD's
    int Membership;
};


class Trainer: public User
{
 private:
    Trainer();
    ~Trainer();
    report CreateReport();
    bool TrainingSessionT(Schedule*pHead, Session T);
}

class TrainingSession
{
public:
    TrainingSession();
    TrainingSession(Session t);
    ~TrainingSession();
    string GetDate();
    string GetTime();
    string GetTrainer();
    string GetLocation();
    int GetCapacity();
    int GetClassID();//used to identify in customer class
    bool IsFull();
    *session GetNext();

    bool SetClassID(int x);
    bool SetDate(string x);
    bool SetTime(string x);
    bool SetTrainer(string x);
    bool SetLocation(string x);
    void SetCapacity(int x);
    void SetNext(Session)

private:
    int ClassID();
    string date;
    string time;
    string trainer;
    int capacity
    bool isFull;
    string location;
    session*pNext=NULL;
}Session;


class TrainingSchedule
{
public:
    TrainingSchedule();
    TrainingSchedule(session t);//copy contructor with an input session
    ~TrainingSchedule();
    *Schedule GetNext();
    void SetNext(Session input);
private:
    Session T;
    Schedule *pNext;
}Schedule;


class UserList
{
public:
    *UserList GetNext();
    User GetUser();
    void SetNext(*UserList input);
    void SetUser(User T);
private:
    User T;
    UserList *pNext;
}UserList;

istream & operator >>(istream &in,report &n)
{
    cout<< "Enter ID: ";
    cin >>n.ID>> endl;
    cout<< "Enter Data: ";
    cin >>n.Date>> endl;
   
    cout<<"Enter Analysis: "
    cin>> n.analysis
    //the last command would not work with the implementation 
    //without another overloaded operator and class list.
    //the standard library list does not play well with nonstandard object types
    return in;
}
*/