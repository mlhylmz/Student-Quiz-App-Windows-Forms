using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenemeForm
{
    internal class Class1
    {
        string[] ans = {"z", "A", "D", "A","C", "C","B", "A","C", "C", "A", "C","C", "D", "B", "A","D", "C", "B", "B","C", "A", "B", "B","D"};


        public string getAns(int id)
        {
            return ans[id];
        }

        Random random = new Random();
        string ogrenciUserName = "melih";
        string ogrenciPassword = "melih123";

        string ogrenci2UserName = "default";
        string ogrenci2Password = "default";

        string adminUserName = "admin";
        string adminPassword = "admin123";

        string sorumluUsername = "sorumlu";
        string sorumluPassword = "sorumlu123";
        public string getogrenciUsername() {return ogrenciUserName;}
        public string getogrenciPassword() {return ogrenciPassword;}

        public string getogrenci2UserName()  { return ogrenci2UserName;}
        public string getogrenci2Password() { return ogrenci2Password;}

        public string getadminUserName() { return adminUserName; }
        public string getadminPassword() { return adminPassword; }

        public string getSorumluUsername() { return sorumluUsername; }
        public string getSorumluPassword() { return sorumluPassword; }

        public void setOgrenci2UserName(string name) { ogrenci2UserName = name;}
        public void setOgrenci2Password(string password) { ogrenci2Password = password;}
        public void print()
        {
            MessageBox.Show("print başarılı");
        }
        public int randNumber() { return random.Next(1, 25); }
    }
}
