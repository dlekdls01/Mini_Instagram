using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace _2015726044_이다인_library
{
    public enum PacketType : int
    {
        Login = 0,
        Login_Result,
        Member_Register,
        Member_Register_Result
    }
    [Serializable]
    public class Class1
    {
        public int type;
        public int length;
        public Class1()
        {
            this.type = 0;
            this.length = 0;
        }
        public static byte[] Serialize(Object o)
        {
            MemoryStream ms = new MemoryStream(1024 * 4);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(ms, o);
            return ms.ToArray();
        }
        public static object Desserialize(byte[] bt)
        {
            MemoryStream ms = new MemoryStream(1024 * 4);
            ms.Write(bt, 0, bt.Length);
            ms.Position = 0;
            BinaryFormatter bf = new BinaryFormatter();
            Object obj = bf.Deserialize(ms);
            ms.Close();
            return obj;
        }
    }
    [Serializable]
    public class Login : Class1         //로그인 id/pw
    {
        public string id { get; set; }
        public string pw { get; set; }
    }
    [Serializable]
    public class LoginResult : Class1       //로그인 성골실패/메세지창
    {
        public bool result { get; set; }
        public string reason { get; set; }
        public string serverPath { get; set; }
    }
    [Serializable]
    public class MemberRegister : Class1    //회원가입id/pw
    {
        public string id { get; set; }
        public string pw { get; set; }
    }
    [Serializable]
    public class MemberRegisterResult : Class1  //회원가입 성공실패/메세지창
    {
        public bool result { get; set; }
        public string reason { get; set; }
    }
}
