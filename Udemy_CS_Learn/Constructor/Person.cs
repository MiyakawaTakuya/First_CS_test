using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Person
    {
        //フィールドはプライベート　クラス内のデータ管理  ここには他からアクセスできない
        private string _firstname;
        private string _lastname;
        private int _age = 26;
        //private int _age;

        //オーバーロード
        public Person()
        {
            _firstname = "Taro";
            _lastname = "Domyoji";
        }


        //２つのパラメーター(引数)を用意している
        public Person(string firstname, int age)
        {
            _firstname = firstname;
            _age = age;
        }

        //２つのパラメーター(string型の引数)を用意している
        public Person(string firstname, string lastname) 
        {
            _firstname = firstname;
            _lastname = lastname;
        }

        //３つのパラメーター(string型の引数)を用意している
        public Person(string firstname, string lastname, int age)
        {
            _firstname = firstname;
            _lastname = lastname;
            _age = age;
        }


        //年齢が入力された場合とそうでない場合  オーバーロード　
        public string GetFullnameWithAge(int age)
        {
            return $"{_firstname} {_lastname}  {age}";  //GetFullnameWithAgeの引数で渡された年齢になる
        }

        public string GetFullnameWithAge()
        {
            return $"{_firstname} {_lastname}  {_age}";
        }

        //public string GetFullname()
        //{
        //    return $"{_firstname} {_lastname}";
        //}
    }
}
