using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace classUsers
{
    class User
    {
        private String firstName;
        private String lastName;
        private DateTime birthDay;
        private double balance;
        private String carNumber;
        private String telephoneNumber;
        private DateTime lastEnter;
        private DateTime lastQuit;
        private static double price;

     
        public User()
        {
            
        }
        public User(String fN,String lN,DateTime bD,double b,String cN,String tN,DateTime lE,DateTime lQ)
        {
            firstName = fN;
            lastName = lN;
            birthDay = bD;
            balance = b;
            carNumber = cN;
            telephoneNumber = tN;
            lastEnter = lE;
            lastQuit = lQ;
        }
        public void changePrice(double p)
        {
            price = p;
        }

        public double getBalance()
        {
            changeBalance();
            return balance;
        }
        public Int64 getTime()
        {
            TimeSpan t1 =(lastEnter - new DateTime(1970, 1, 1, 0, 0, 0));
            TimeSpan t2 =(lastQuit - new DateTime(1970, 1, 1, 0, 0, 0));
            return ((int)(t2.TotalDays * 1440) - (int)(t1.TotalDays * 1440));
        }

        public double getChangesInBalance()
        {
            //if (getTime() > 15)
                return ((getTime()) * price);
           // else
               // return 0;
        }
        private void changeBalance()
        {
            balance-=getChangesInBalance();
        }
        public double getPrice()
        {
            return price;
        }
    }
}
